
`default_nettype none // Makes it easier to detect typos !

/*******************************************************************/
// FemtoRV32, a collection of minimalistic RISC-V RV32 cores.
//
// This version: The "Pegasus" with a three stage pipeline
//               which executes everything in one single cycle,
//               except division and remainder instructions.
//
// Instruction set: RV32IM + CSR + MRET
//
// Parameters:
//  Reset address can be defined using RESET_ADDR (default is 0).
//
//  The ADDR_WIDTH parameter lets you define the width of the internal
//  address bus (and address computation logic).
//
// Bruno Levy, Matthias Koch, 2020-2022
/*******************************************************************/

// Firmware generation flags for this processor
`define NRV_ARCH     "rv32im"
`define NRV_ABI      "ilp32"
`define NRV_OPTIMIZE "-O2"

module FemtoRV32(
   input         clk,

   output [31:0] mem_addr,  // address bus
   output [31:0] mem_wdata, // data to be written
   output  [3:0] mem_wmask, // write mask for the 4 bytes of each word
   input  [31:0] mem_rdata, // input lines for data
   output        mem_rstrb, // active to initiate memory read (used by IO)
   input         mem_rbusy, // asserted if memory is busy reading value
   input         mem_wbusy, // asserted if memory is busy writing value

   output [31:0] instr_addr,  // address bus for instr
   input  [31:0] instr_rdata, // input lines for instr, single cycle memory

   input         interrupt_request,

   input         reset      // set to 0 to reset the processor
);

   parameter RESET_ADDR       = 32'h00000000;
   parameter ADDR_WIDTH       = 32;

 /***************************************************************************/
 // Instruction decoding.
 /***************************************************************************/

 // Extracts rd,rs1,rs2,funct3,imm and opcode from instruction.
 // Reference: Table page 104 of:
 // https://content.riscv.org/wp-content/uploads/2017/05/riscv-spec-v2.2.pdf

 // The ALU function, decoded in 1-hot form (doing so reduces LUT count)
 // It is used as follows: funct3Is[val] <=> funct3 == val
 (* onehot *)
 wire [7:0] funct3Is = 8'b00000001 << instr[14:12];

 // The five immediate formats, see RiscV reference (link above), Fig. 2.4 p. 12
 wire [31:0] Uimm = {    instr[31],   instr[30:12], {12{1'b0}}};
 wire [31:0] Iimm = {{21{instr[31]}}, instr[30:20]};
 /* verilator lint_off UNUSED */ // MSBs of SBJimms are not used by addr adder.
 wire [31:0] Simm = {{21{instr[31]}}, instr[30:25],instr[11:7]};
 wire [31:0] Bimm = {{20{instr[31]}}, instr[7],instr[30:25],instr[11:8],1'b0};
 wire [31:0] Jimm = {{12{instr[31]}}, instr[19:12],instr[20],instr[30:21],1'b0};
 /* verilator lint_on UNUSED */

   // Base RISC-V (RV32I) has only 10 different instructions !
   wire isLoad    =  (instr[6:2] == 5'b00000); // rd <- mem[rs1+Iimm]
   wire isALUimm  =  (instr[6:2] == 5'b00100); // rd <- rs1 OP Iimm
   wire isAUIPC   =  (instr[6:2] == 5'b00101); // rd <- PC + Uimm
   wire isStore   =  (instr[6:2] == 5'b01000); // mem[rs1+Simm] <- rs2
   wire isALUreg  =  (instr[6:2] == 5'b01100); // rd <- rs1 OP rs2
   wire isLUI     =  (instr[6:2] == 5'b01101); // rd <- Uimm
   wire isBranch  =  (instr[6:2] == 5'b11000); // if(rs1 OP rs2) PC<-PC+Bimm
   wire isJALR    =  (instr[6:2] == 5'b11001); // rd <- PC+4; PC<-rs1+Iimm
   wire isJAL     =  (instr[6:2] == 5'b11011); // rd <- PC+4; PC<-PC+Jimm
   wire isSYSTEM  =  (instr[6:2] == 5'b11100); // rd <- CSR <- rs1/uimm5

   wire isALU = isALUimm | isALUreg;

   /***************************************************************************/
   // The register file with register forwarding.
   /***************************************************************************/

   reg  [31:0] registerFile [31:0];

   reg load_writeback;
   reg  alu_writeback;
   reg [31:0] alu_data;

   wire [31:0] rs1 = (wb_destination == instr[19:15]) &
                     (alu_writeback | load_writeback) ?
                                       alu_writeback  ? alu_data  : LOAD_data :
                                                        registerFile[instr[19:15]];

   wire [31:0] rs2 = (wb_destination == instr[24:20]) &
                     (alu_writeback | load_writeback) ?
                                       alu_writeback  ? alu_data  : LOAD_data :
                                                        registerFile[instr[24:20]];

   /***************************************************************************/
   // The ALU. Does operations and tests combinatorially, except div & rem.
   /***************************************************************************/

   // First ALU source, always rs1
   wire [31:0] aluIn1 = rs1;

   // Second ALU source, depends on opcode:
   //    ALUreg, Branch:     rs2
   //    ALUimm, Load, JALR: Iimm
   wire [31:0] aluIn2 = isALUreg | isBranch ? rs2 : Iimm;

   // The adder is used by both arithmetic instructions and JALR.
   wire [31:0] aluPlus = aluIn1 + aluIn2;

   // Use a single 33 bits subtract to do subtraction and all comparisons
   // (trick borrowed from swapforth/J1)
   wire [32:0] aluMinus = {1'b1, ~aluIn2} + {1'b0,aluIn1} + 33'b1;
   wire        LT  = (aluIn1[31] ^ aluIn2[31]) ? aluIn1[31] : aluMinus[32];
   wire        LTU = aluMinus[32];
   wire        EQ  = (aluMinus[31:0] == 0);

   /***************************************************************************/

   // Use the same shifter both for left and right shifts by
   // applying bit reversal

   wire [31:0] shifter_in = funct3Is[1] ?
     {aluIn1[ 0], aluIn1[ 1], aluIn1[ 2], aluIn1[ 3], aluIn1[ 4], aluIn1[ 5],
      aluIn1[ 6], aluIn1[ 7], aluIn1[ 8], aluIn1[ 9], aluIn1[10], aluIn1[11],
      aluIn1[12], aluIn1[13], aluIn1[14], aluIn1[15], aluIn1[16], aluIn1[17],
      aluIn1[18], aluIn1[19], aluIn1[20], aluIn1[21], aluIn1[22], aluIn1[23],
      aluIn1[24], aluIn1[25], aluIn1[26], aluIn1[27], aluIn1[28], aluIn1[29],
      aluIn1[30], aluIn1[31]} : aluIn1;

   /* verilator lint_off WIDTH */
   wire [31:0] shifter =
               $signed({instr[30] & aluIn1[31], shifter_in}) >>> aluIn2[4:0];
   /* verilator lint_on WIDTH */

   wire [31:0] leftshift = {
     shifter[ 0], shifter[ 1], shifter[ 2], shifter[ 3], shifter[ 4],
     shifter[ 5], shifter[ 6], shifter[ 7], shifter[ 8], shifter[ 9],
     shifter[10], shifter[11], shifter[12], shifter[13], shifter[14],
     shifter[15], shifter[16], shifter[17], shifter[18], shifter[19],
     shifter[20], shifter[21], shifter[22], shifter[23], shifter[24],
     shifter[25], shifter[26], shifter[27], shifter[28], shifter[29],
     shifter[30], shifter[31]};

   /***************************************************************************/

   wire funcM     = instr[25];
   wire isDivide  = isALUreg & funcM & instr[14];

   // funct3: 1->MULH, 2->MULHSU  3->MULHU
   wire isMULH   = funct3Is[1];
   wire isMULHSU = funct3Is[2];

   wire sign1 = aluIn1[31] &  isMULH;
   wire sign2 = aluIn2[31] & (isMULH | isMULHSU);

   wire signed [32:0] signed1 = {sign1, aluIn1};
   wire signed [32:0] signed2 = {sign2, aluIn2};
   wire signed [63:0] multiply = signed1 * signed2;

   /***************************************************************************/

   // Notes:
   // - instr[30] is 1 for SUB and 0 for ADD
   // - for SUB, need to test also instr[5] to discriminate ADDI:
   //    (1 for ADD/SUB, 0 for ADDI, and Iimm used by ADDI overlaps bit 30 !)
   // - instr[30] is 1 for SRA (do sign extension) and 0 for SRL

   wire [31:0] aluOut_base =
     (funct3Is[0]  ? instr[30] & instr[5] ? aluMinus[31:0] : aluPlus : 32'b0) |
     (funct3Is[1]  ? leftshift                                       : 32'b0) |
     (funct3Is[2]  ? {31'b0, LT}                                     : 32'b0) |
     (funct3Is[3]  ? {31'b0, LTU}                                    : 32'b0) |
     (funct3Is[4]  ? aluIn1 ^ aluIn2                                 : 32'b0) |
     (funct3Is[5]  ? shifter                                         : 32'b0) |
     (funct3Is[6]  ? aluIn1 | aluIn2                                 : 32'b0) |
     (funct3Is[7]  ? aluIn1 & aluIn2                                 : 32'b0) ;

   wire [31:0] aluOut_muldiv =
     (  funct3Is[0]   ?  multiply[31: 0] : 32'b0) | // 0:MUL
     ( |funct3Is[3:1] ?  multiply[63:32] : 32'b0) ; // 1:MULH, 2:MULHSU, 3:MULHU
     // Multicycle div/rem handled separately.      // 4:DIV, 5:DIVU, 6:REM, 7:REMU

   wire [31:0] aluOut = isALUreg & funcM ? aluOut_muldiv : aluOut_base;

   /***************************************************************************/
   // Implementation of DIV/REM instructions, highly inspired by PicoRV32

   reg [31:0] dividend;
   reg [62:0] divisor;
   reg [31:0] quotient;
   reg [31:0] quotient_msk;

   reg div_sign;
   reg div_or_rem;

   reg divBusy;

   wire divstep_do = (divisor <= {31'b0, dividend});

   wire [31:0] dividendN     = divstep_do ? dividend - divisor[31:0] : dividend;
   wire [31:0] quotientN     = divstep_do ? quotient | quotient_msk  : quotient;

   wire [31:0] divResult       = div_or_rem ? dividendN : quotientN;
   wire [31:0] divResultSigned = div_sign ? -divResult : divResult;

   /***************************************************************************/
   // The predicate for conditional branches.
   /***************************************************************************/

   wire predicate =
        funct3Is[0] &  EQ  | // BEQ
        funct3Is[1] & !EQ  | // BNE
        funct3Is[4] &  LT  | // BLT
        funct3Is[5] & !LT  | // BGE
        funct3Is[6] &  LTU | // BLTU
        funct3Is[7] & !LTU ; // BGEU

   /***************************************************************************/
   // Program counter and branch target computation.
   /***************************************************************************/

   reg  [ADDR_WIDTH-1:0] PC; // The program counter.
   /* verilator lint_off UNUSED */
   wire [31:0] instr; // Decompress instruction from memory
   decompressor _decomp ( .c(instr_rdata), .d(instr) );
   /* verilator lint_on UNUSED */

   wire long_instr = &instr_rdata[1:0];

   wire [ADDR_WIDTH-1:0] PCplus2 = PC + 2;
   wire [ADDR_WIDTH-1:0] PCplus4 = PC + 4;
   wire [ADDR_WIDTH-1:0] PCinc   = long_instr ? PCplus4 : PCplus2;

   // An adder used to compute branch address, JAL address and AUIPC.
   // branch->PC+Bimm    AUIPC->PC+Uimm    JAL->PC+Jimm
   // Equivalent to PCplusImm = PC + (isJAL ? Jimm : isAUIPC ? Uimm : Bimm)
   wire [ADDR_WIDTH-1:0] PCplusImm = PC + ( instr[3] ? Jimm[ADDR_WIDTH-1:0] :
                                            instr[4] ? Uimm[ADDR_WIDTH-1:0] :
                                                       Bimm[ADDR_WIDTH-1:0] );

   // A separate adder to compute the destination of load/store.
   // testing instr[5] is equivalent to testing isStore in this context.
   wire [ADDR_WIDTH-1:0] loadstore_addr = rs1[ADDR_WIDTH-1:0] +
                   (instr[5] ? Simm[ADDR_WIDTH-1:0] : Iimm[ADDR_WIDTH-1:0]);

   wire [ADDR_WIDTH-1:0] PC_new =
      interrupt_return ? mepc                           :
      isJALR           ? {aluPlus[ADDR_WIDTH-1:1],1'b0} :
      jumpToPCplusImm  ? PCplusImm                      :
                         PCinc;

   assign instr_addr = ~reset | busy ? PC : interrupt ? mtvec : PC_new;

   assign mem_addr = busy ? loadstore_addr_buffered : loadstore_addr;

   /***************************************************************************/
   // Interrupt logic, CSR registers and opcodes.
   /***************************************************************************/

   // Remember interrupt requests as they are not checked for every cycle
   reg  interrupt_request_sticky;

   // Interrupt enable and lock logic
   wire interrupt = interrupt_request_sticky & mstatus & ~mcause;

   // Processor accepts interrupts only when not busy.
   wire interrupt_accepted = interrupt & ~busy;

   // If current interrupt is accepted, there already might be the next one,
   //  which should not be missed:
   always @(posedge clk) begin
     interrupt_request_sticky <=
         interrupt_request | (interrupt_request_sticky & ~interrupt_accepted);
   end

   // Decoder for mret opcode
   wire interrupt_return = isSYSTEM & funct3Is[0]; // & (instr[31:20]==12'h302);

   // CSRs:
   reg  [ADDR_WIDTH-1:0] mepc;    // The saved program counter.
   reg  [ADDR_WIDTH-1:0] mtvec;   // The address of the interrupt handler.
   reg                   mstatus; // Interrupt enable
   reg                   mcause;  // Interrupt cause (and lock)
   reg  [63:0]           cycles;  // Cycle counter

   wire sel_mstatus  = (instr[31:20] == 12'h300);
   wire sel_mtvec    = (instr[31:20] == 12'h305);
   wire sel_mepc     = (instr[31:20] == 12'h341);
   wire sel_mcause   = (instr[31:20] == 12'h342);
   wire sel_cycles   = (instr[31:20] == 12'hC00);
   wire sel_cyclesh  = (instr[31:20] == 12'hC80);

   // Read CSRs
   /* verilator lint_off WIDTH */
   wire [31:0] CSR_read =
     (sel_mstatus  ? {28'b0, mstatus, 3'b0} : 32'b0) |
     (sel_mtvec    ? mtvec                  : 32'b0) |
     (sel_mepc     ? mepc                   : 32'b0) |
     (sel_mcause   ? {mcause, 31'b0}        : 32'b0) |
     (sel_cycles   ? cycles[31:0]           : 32'b0) |
     (sel_cyclesh  ? cycles[63:32]          : 32'b0) ;
   /* verilator lint_on WIDTH */

   // Write CSRs: 5 bit unsigned immediate or content of RS1
   wire [31:0] CSR_modifier = instr[14] ? {27'd0, instr[19:15]} : rs1;

   wire [31:0] CSR_write = (instr[13:12] == 2'b10) ? CSR_modifier | CSR_read  :
                           (instr[13:12] == 2'b11) ? ~CSR_modifier & CSR_read :
                        /* (instr[13:12] == 2'b01) ? */  CSR_modifier ;

   /***************************************************************************/
   // The value written back to the register file.
   /***************************************************************************/

   /* verilator lint_off WIDTH */
   wire [31:0] writeBackData  =
      (isSYSTEM            ? CSR_read   : 32'b0) |  // SYSTEM
      (isLUI               ? Uimm       : 32'b0) |  // LUI
      (isALU               ? aluOut     : 32'b0) |  // ALUreg, ALUimm
      (isAUIPC             ? PCplusImm  : 32'b0) |  // AUIPC
      (isJALR   | isJAL    ? PCinc      : 32'b0) ;  // JAL, JALR
   /* verilator lint_on WIDTH */

   /***************************************************************************/
   // LOAD/STORE
   /***************************************************************************/

   // All memory accesses are aligned on 32 bits boundary. For this
   // reason, we need some circuitry that does unaligned halfword
   // and byte load/store, based on:
   // - funct3[1:0]:  00->byte 01->halfword 10->word
   // - mem_addr[1:0]: indicates which byte/halfword is accessed

   wire mem_byteAccess     = instr[13:12] == 2'b00; // funct3[1:0] == 2'b00;
   wire mem_halfwordAccess = instr[13:12] == 2'b01; // funct3[1:0] == 2'b01;

   reg [1:0] load_cached_addr;
   reg load_signed;
   reg load_byteAccess;
   reg load_halfwordAccess;
   reg [4:0] wb_destination;

   // LOAD, in addition to funct3[1:0], LOAD depends on:
   // - funct3[2] (instr[14]): 0->do sign expansion   1->no sign expansion

   wire LOAD_sign =
        !load_signed & (load_byteAccess ? LOAD_byte[7] : LOAD_halfword[15]);

   wire [31:0] LOAD_data =
         load_byteAccess ? {{24{LOAD_sign}},     LOAD_byte} :
     load_halfwordAccess ? {{16{LOAD_sign}}, LOAD_halfword} :
                          mem_rdata ;

   wire [15:0] LOAD_halfword =
               load_cached_addr[1] ? mem_rdata[31:16] : mem_rdata[15:0];

   wire  [7:0] LOAD_byte =
               load_cached_addr[0] ? LOAD_halfword[15:8] : LOAD_halfword[7:0];

   // STORE

   assign mem_wdata = busy ? mem_wdata_buffered : mem_wdata_current;

   wire [31:0] mem_wdata_current;

   assign mem_wdata_current[ 7: 0] = rs2[7:0];
   assign mem_wdata_current[15: 8] = loadstore_addr[0] ? rs2[7:0]  : rs2[15: 8];
   assign mem_wdata_current[23:16] = loadstore_addr[1] ? rs2[7:0]  : rs2[23:16];
   assign mem_wdata_current[31:24] = loadstore_addr[0] ? rs2[7:0]  :
                             loadstore_addr[1] ? rs2[15:8] : rs2[31:24];

   // The memory write mask:
   //    1111                     if writing a word
   //    0011 or 1100             if writing a halfword
   //                                (depending on loadstore_addr[1])
   //    0001, 0010, 0100 or 1000 if writing a byte
   //                                (depending on loadstore_addr[1:0])

   wire [3:0] STORE_wmask =
          mem_byteAccess      ?
                (loadstore_addr[1] ?
                  (loadstore_addr[0] ? 4'b1000 : 4'b0100) :
                  (loadstore_addr[0] ? 4'b0010 : 4'b0001)
                    ) :
          mem_halfwordAccess ?
                (loadstore_addr[1] ? 4'b1100 : 4'b0011) :
              4'b1111;

   /*************************************************************************/
   // And, last but not least, the clocked parts.
   /*************************************************************************/

   // The memory-read signal.
   assign mem_rstrb = isLoad & ~busy;

   // The mask for memory-write.
   assign mem_wmask = {4{isStore & ~busy}} & STORE_wmask;

   wire jumpToPCplusImm = isJAL | (isBranch & predicate);

   wire busy = divBusy | mem_rbusy | mem_wbusy;

   reg [ADDR_WIDTH-1:0] loadstore_addr_buffered = 0;
   reg           [31:0] mem_wdata_buffered = 0;

   always @(posedge clk)
   if (!reset) begin
      PC      <= RESET_ADDR[ADDR_WIDTH-1:0];
      divBusy <= 0;
      mcause  <= 0;
      mstatus <= 0;
      cycles  <= 0;
    end else begin

      cycles <= cycles + 1;

      if (~busy) begin

         // Continue executing or handle interrupt entry & exit

         if (interrupt) begin
            PC     <= mtvec;
            mepc   <= PC_new;
            mcause <= 1;
         end else begin
            PC <= PC_new;
            if (interrupt_return) mcause <= 0;
         end

         // Signals for properly handling the load result in the next cycle

         load_cached_addr    <= loadstore_addr[1:0];
         load_byteAccess     <= mem_byteAccess;
         load_halfwordAccess <= mem_halfwordAccess;
         load_signed         <= instr[14];

         // Signals for register writeback & forwarding

         load_writeback      <= isLoad & |instr[11:7];
         alu_writeback       <= ~(isBranch | isStore | isLoad) & |instr[11:7];
         alu_data            <= writeBackData;
         wb_destination      <= instr[11:7];


         // Buffer the values on the load/store memory bus for the occassion of being busy
         //// in the next cycle so that bus keeps stable.

         loadstore_addr_buffered <= loadstore_addr;
              mem_wdata_buffered <= mem_wdata_current;

         // Writeback of ALU or load results into the register file

         if (load_writeback | alu_writeback) registerFile[wb_destination] <= alu_writeback ? alu_data : LOAD_data;

         // Take care of CSR writes

         if (isSYSTEM & (instr[14:12] != 0)) begin
            if (sel_mstatus) mstatus <= CSR_write[3];
            if (sel_mtvec  ) mtvec   <= CSR_write[ADDR_WIDTH-1:0];
         end

         // Start multicycle division/remainder

         if (isDivide) begin
            dividend <=   ~instr[12] & aluIn1[31] ? -aluIn1 : aluIn1;
            divisor  <= {(~instr[12] & aluIn2[31] ? -aluIn2 : aluIn2), 31'b0};
            div_sign <=   ~instr[12] & (instr[13] ? aluIn1[31] :
                                                   (aluIn1[31] != aluIn2[31]) & |aluIn2);
            div_or_rem <=  instr[13];

            quotient <= 0;
            quotient_msk <= 1 << 31;

            divBusy <= 1;
         end

      end else begin // CPU Busy

         // Division steps

         if (divBusy)
            if (|quotient_msk)
            begin
               dividend     <= dividendN;
               divisor      <= divisor >> 1;
               quotient     <= quotientN;
               quotient_msk <= quotient_msk >> 1;
               alu_data     <= divResultSigned;
            end
            else divBusy    <= 0; // Clear busy one clock cycle AFTER alu_data has been updated with final value.

         // Memory busy signals simply stall the pipeline and do not need any special handling.
         // Just wait for memory to finish its task.

     end // CPU Busy
   end // (!reset)

endmodule


/*****************************************************************************/

// if c[15:0] is a compressed instrution, decompresses it in d
// else copies c to d
module decompressor(
   input  wire [31:0] c,
   output reg  [31:0] d
);

   // How to handle illegal and unknown opcodes

   localparam illegal = 32'h00000000;
   localparam unknown = 32'h00000000;

   // Register decoder

   wire [4:0] rcl = {2'b01, c[4:2]}; // Register compressed low
   wire [4:0] rch = {2'b01, c[9:7]}; // Register compressed high

   wire [4:0] rwl  = c[ 6:2];  // Register wide low
   wire [4:0] rwh  = c[11:7];  // Register wide high

   localparam x0 = 5'b00000;
   localparam x1 = 5'b00001;
   localparam x2 = 5'b00010;

   // Immediate decoder

   wire  [4:0]    shiftImm = c[6:2];

   wire [11:0] addi4spnImm = {2'b00, c[10:7], c[12:11], c[5], c[6], 2'b00};
   wire [11:0]     lwswImm = {5'b00000, c[5], c[12:10] , c[6], 2'b00};
   wire [11:0]     lwspImm = {4'b0000, c[3:2], c[12], c[6:4], 2'b00};
   wire [11:0]     swspImm = {4'b0000, c[8:7], c[12:9], 2'b00};

   wire [11:0] addi16spImm = {{ 3{c[12]}}, c[4:3], c[5], c[2], c[6], 4'b0000};
   wire [11:0]      addImm = {{ 7{c[12]}}, c[6:2]};

   /* verilator lint_off UNUSED */
   wire [12:0]        bImm = {{ 5{c[12]}}, c[6:5], c[2], c[11:10], c[4:3], 1'b0};
   wire [20:0]      jalImm = {{10{c[12]}}, c[8], c[10:9], c[6], c[7], c[2], c[11], c[5:3], 1'b0};
   wire [31:0]      luiImm = {{15{c[12]}}, c[6:2], 12'b000000000000};
   /* verilator lint_on UNUSED */

   reg [31:0] d00, d01, d10; // Split into instruction set quadrants to be decoded separately

   always @*
   casez (c[15:0])
                                                     // imm / funct7   +   rs2  rs1     fn3                   rd    opcode

      16'b000___00000000_000_?? : d00 =                                                                       illegal ; // c.illegal   -->  illegal
      16'b000___????????_???_?? : d00 = {      addi4spnImm,             x2, 3'b000,                 rcl, 7'b00100_11} ; // c.addi4spn  -->  addi rd', x2, nzuimm[9:2]
      16'b010_???_???_??_???_?? : d00 = {          lwswImm,            rch, 3'b010,                 rcl, 7'b00000_11} ; // c.lw        -->  lw   rd', offset[6:2](rs1')
      16'b110_???_???_??_???_?? : d00 = {    lwswImm[11:5],       rcl, rch, 3'b010,        lwswImm[4:0], 7'b01000_11} ; // c.sw        -->  sw   rs2', offset[6:2](rs1')

      default:                    d00 =                                                                      unknown  ; // Unknown opcode
   endcase

   always @*
   casez (c[15:0])
                                                     // imm / funct7   +   rs2  rs1     fn3                   rd    opcode

      16'b000_???_???_??_???_?? : d01 = {           addImm,            rwh, 3'b000,                 rwh, 7'b00100_11} ; // c.addi      -->  addi rd, rd, nzimm[5:0]
      16'b001____???????????_?? : d01 = {     jalImm[20], jalImm[10:1], jalImm[11], jalImm[19:12],   x1, 7'b11011_11} ; // c.jal       -->  jal  x1, offset[11:1]
      16'b010__?_?????_?????_?? : d01 = {           addImm,             x0, 3'b000,                 rwh, 7'b00100_11} ; // c.li        -->  addi rd, x0, imm[5:0]
      16'b011__?_00010_?????_?? : d01 = {      addi16spImm,            rwh, 3'b000,                 rwh, 7'b00100_11} ; // c.addi16sp  -->  addi x2, x2, nzimm[9:4]
      16'b011__?_?????_?????_?? : d01 = {    luiImm[31:12],                                         rwh, 7'b01101_11} ; // c.lui       -->  lui  rd, nzuimm[17:12]
      16'b100_?_00_???_?????_?? : d01 = {       7'b0000000,  shiftImm, rch, 3'b101,                 rch, 7'b00100_11} ; // c.srli      -->  srli rd', rd', shamt[5:0]
      16'b100_?_01_???_?????_?? : d01 = {       7'b0100000,  shiftImm, rch, 3'b101,                 rch, 7'b00100_11} ; // c.srai      -->  srai rd', rd', shamt[5:0]
      16'b100_?_10_???_?????_?? : d01 = {           addImm,            rch, 3'b111,                 rch, 7'b00100_11} ; // c.andi      -->  andi rd', rd', imm[5:0]
      16'b100_011_???_00_???_?? : d01 = {       7'b0100000,       rcl, rch, 3'b000,                 rch, 7'b01100_11} ; // c.sub       -->  sub  rd', rd', rs2'
      16'b100_011_???_01_???_?? : d01 = {       7'b0000000,       rcl, rch, 3'b100,                 rch, 7'b01100_11} ; // c.xor       -->  xor  rd', rd', rs2'
      16'b100_011_???_10_???_?? : d01 = {       7'b0000000,       rcl, rch, 3'b110,                 rch, 7'b01100_11} ; // c.or        -->  or   rd', rd', rs2'
      16'b100_011_???_11_???_?? : d01 = {       7'b0000000,       rcl, rch, 3'b111,                 rch, 7'b01100_11} ; // c.and       -->  and  rd', rd', rs2'
      16'b101____???????????_?? : d01 = {     jalImm[20], jalImm[10:1], jalImm[11], jalImm[19:12],   x0, 7'b11011_11} ; // c.j         -->  jal  x0, offset[11:1]
      16'b110__???_???_?????_?? : d01 = {bImm[12], bImm[10:5],     x0, rch, 3'b000, bImm[4:1], bImm[11], 7'b11000_11} ; // c.beqz      -->  beq  rs1', x0, offset[8:1]
      16'b111__???_???_?????_?? : d01 = {bImm[12], bImm[10:5],     x0, rch, 3'b001, bImm[4:1], bImm[11], 7'b11000_11} ; // c.bnez      -->  bne  rs1', x0, offset[8:1]

      default:                    d01 =                                                                      unknown  ; // Unknown opcode
   endcase

   always @*
   casez (c[15:0])
                                                     // imm / funct7   +   rs2  rs1     fn3                   rd    opcode

      16'b000__?_?????_?????_?? : d10 = {        7'b0000000, shiftImm, rwh, 3'b001,                 rwh, 7'b00100_11} ; // c.slli      -->  slli rd, rd, shamt[5:0]
      16'b010__?_?????_?????_?? : d10 = {           lwspImm,            x2, 3'b010,                 rwh, 7'b00000_11} ; // c.lwsp      -->  lw   rd, offset[7:2](x2)
      16'b100__0_?????_00000_?? : d10 = {  12'b000000000000,           rwh, 3'b000,                  x0, 7'b11001_11} ; // c.jr        -->  jalr x0, rs1, 0
      16'b100__0_?????_?????_?? : d10 = {        7'b0000000,      rwl,  x0, 3'b000,                 rwh, 7'b01100_11} ; // c.mv        -->  add  rd, x0, rs2
   // 16'b100__1_00000_00000_?? : d10 = {                              25'b00000000_00010000_00000000_0, 7'b11100_11} ; // c.ebreak    -->  ebreak
      16'b100__1_?????_00000_?? : d10 = {  12'b000000000000,           rwh, 3'b000,                  x1, 7'b11001_11} ; // c.jalr      -->  jalr x1, rs1, 0
      16'b100__1_?????_?????_?? : d10 = {        7'b0000000,      rwl, rwh, 3'b000,                 rwh, 7'b01100_11} ; // c.add       -->  add  rd, rd, rs2
      16'b110__?_?????_?????_?? : d10 = {     swspImm[11:5],      rwl,  x2, 3'b010,        swspImm[4:0], 7'b01000_11} ; // c.swsp      -->  sw   rs2, offset[7:2](x2)

      default:                    d10 =                                                                      unknown  ; // Unknown opcode
   endcase

   always @*
   casez (c[1:0])
     2'b00 : d = d00;
     2'b01 : d = d01;
     2'b10 : d = d10;
     2'b11 : d = c;
    endcase

endmodule
