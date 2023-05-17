
/*******************************************************************/
// A lot of RISC-V on the Breakout
/*******************************************************************/

`default_nettype none // Makes it easier to detect typos !

`include "../../common-verilog/femtorv32_gracilis.v"
`include "../../common-verilog/uart-fifo.v"
`include "../../common-verilog/MappedSPIFlash.v"
`include "../../common-verilog/ringoscillator.v"

module breakout(

   input oscillator,

   output [7:0] led,

   output TXD,
   input  RXD,

   output flash_csb,
   output flash_clk,
   inout  flash_io0,
   inout  flash_io1,
   inout  flash_io2,
   inout  flash_io3,

   inout PORTA0,
   inout PORTA1,
   inout PORTA2,
   inout PORTA3,
   inout PORTA4,
   inout PORTA5,
   inout PORTA6,
   inout PORTA7,

   inout PORTB0,
   inout PORTB1,
   inout PORTB2,
   inout PORTB3,
   inout PORTB4,
   inout PORTB5,
   inout PORTB6,
   inout PORTB7,

   inout PORTC0,
   inout PORTC1,
   inout PORTC2,
   inout PORTC3,
   inout PORTC4,
   inout PORTC5,
   inout PORTC6,
   inout PORTC7,

   input reset_button
);

   /***************************************************************************/
   // Clock.
   /***************************************************************************/

   wire clk; // Configured for 30 MHz

   SB_PLL40_CORE #(
                   .FEEDBACK_PATH("SIMPLE"),
                   .DIVR(4'b0000),         // DIVR =  0
                   .DIVF(7'b1001111),      // DIVF = 79
                   .DIVQ(3'b101),          // DIVQ =  5
                   .FILTER_RANGE(3'b001)   // FILTER_RANGE = 1
           ) uut (
                   // .LOCK(locked),
                   .RESETB(1'b1),
                   .BYPASS(1'b0),
                   .REFERENCECLK(oscillator),
                   .PLLOUTCORE(clk)
                   );

   /***************************************************************************/
   // Reset logic.
   /***************************************************************************/

   reg [7:0] reset_cnt = 0;
   wire resetq = &reset_cnt;

   always @(posedge clk) begin
     if (reset_button) reset_cnt <= reset_cnt + !resetq;
     else        reset_cnt <= 0;
   end

   /***************************************************************************/
   // LEDs.
   /***************************************************************************/

   reg [7:0] LEDs;
   assign led = LEDs;

   /***************************************************************************/
   // Ring oscillator for random numbers.
   /***************************************************************************/

   wire random;
   ring_osc #( .NUM_LUTS(1) ) chaos ( .osc_out(random), .resetq(resetq) );

   /***************************************************************************/
   // Timer with interrupt.
   /***************************************************************************/

   reg  interrupt = 0;
   reg  [31:0] ticks;
   wire [32:0] ticks_plus_1 = ticks + 1;
   reg  [31:0] reload = 0;
   wire [31:0] next_ticks = ticks_plus_1[32] ? reload[31:0] : ticks_plus_1[31:0];

   always @(posedge clk)
   begin
     if (io_wstrb & mem_address[IO_Ticks_bit])  ticks  <= mem_wdata; else ticks <= next_ticks;
     if (io_wstrb & mem_address[IO_Reload_bit]) reload <= mem_wdata;

     interrupt <= ticks_plus_1[32]; // Generate interrupt on ticks overflow
   end

   /***************************************************************************/
   // GPIO.
   /***************************************************************************/

   wire [24:0] port_in;
   reg  [23:0] port_out;
   reg  [23:0] port_dir;

   assign port_in[24] = random;

   // First row

   SB_IO #(.PIN_TYPE(6'b1010_01)) fio0 (.PACKAGE_PIN(PORTA0), .D_OUT_0(port_out[ 0]), .D_IN_0(port_in[ 0]), .OUTPUT_ENABLE(port_dir[ 0]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio1 (.PACKAGE_PIN(PORTA1), .D_OUT_0(port_out[ 1]), .D_IN_0(port_in[ 1]), .OUTPUT_ENABLE(port_dir[ 1]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio2 (.PACKAGE_PIN(PORTA2), .D_OUT_0(port_out[ 2]), .D_IN_0(port_in[ 2]), .OUTPUT_ENABLE(port_dir[ 2]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio3 (.PACKAGE_PIN(PORTA3), .D_OUT_0(port_out[ 3]), .D_IN_0(port_in[ 3]), .OUTPUT_ENABLE(port_dir[ 3]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio4 (.PACKAGE_PIN(PORTA4), .D_OUT_0(port_out[ 4]), .D_IN_0(port_in[ 4]), .OUTPUT_ENABLE(port_dir[ 4]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio5 (.PACKAGE_PIN(PORTA5), .D_OUT_0(port_out[ 5]), .D_IN_0(port_in[ 5]), .OUTPUT_ENABLE(port_dir[ 5]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio6 (.PACKAGE_PIN(PORTA6), .D_OUT_0(port_out[ 6]), .D_IN_0(port_in[ 6]), .OUTPUT_ENABLE(port_dir[ 6]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio7 (.PACKAGE_PIN(PORTA7), .D_OUT_0(port_out[ 7]), .D_IN_0(port_in[ 7]), .OUTPUT_ENABLE(port_dir[ 7]));

   // Second row

   SB_IO #(.PIN_TYPE(6'b1010_01)) gio0 (.PACKAGE_PIN(PORTB0), .D_OUT_0(port_out[ 8]), .D_IN_0(port_in[ 8]), .OUTPUT_ENABLE(port_dir[ 8]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio1 (.PACKAGE_PIN(PORTB1), .D_OUT_0(port_out[ 9]), .D_IN_0(port_in[ 9]), .OUTPUT_ENABLE(port_dir[ 9]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio2 (.PACKAGE_PIN(PORTB2), .D_OUT_0(port_out[10]), .D_IN_0(port_in[10]), .OUTPUT_ENABLE(port_dir[10]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio3 (.PACKAGE_PIN(PORTB3), .D_OUT_0(port_out[11]), .D_IN_0(port_in[11]), .OUTPUT_ENABLE(port_dir[11]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio4 (.PACKAGE_PIN(PORTB4), .D_OUT_0(port_out[12]), .D_IN_0(port_in[12]), .OUTPUT_ENABLE(port_dir[12]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio5 (.PACKAGE_PIN(PORTB5), .D_OUT_0(port_out[13]), .D_IN_0(port_in[13]), .OUTPUT_ENABLE(port_dir[13]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio6 (.PACKAGE_PIN(PORTB6), .D_OUT_0(port_out[14]), .D_IN_0(port_in[14]), .OUTPUT_ENABLE(port_dir[14]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio7 (.PACKAGE_PIN(PORTB7), .D_OUT_0(port_out[15]), .D_IN_0(port_in[15]), .OUTPUT_ENABLE(port_dir[15]));

   // Third row

   SB_IO #(.PIN_TYPE(6'b1010_01)) hio0 (.PACKAGE_PIN(PORTC0), .D_OUT_0(port_out[16]), .D_IN_0(port_in[16]), .OUTPUT_ENABLE(port_dir[16]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio1 (.PACKAGE_PIN(PORTC1), .D_OUT_0(port_out[17]), .D_IN_0(port_in[17]), .OUTPUT_ENABLE(port_dir[17]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio2 (.PACKAGE_PIN(PORTC2), .D_OUT_0(port_out[18]), .D_IN_0(port_in[18]), .OUTPUT_ENABLE(port_dir[18]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio3 (.PACKAGE_PIN(PORTC3), .D_OUT_0(port_out[19]), .D_IN_0(port_in[19]), .OUTPUT_ENABLE(port_dir[19]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio4 (.PACKAGE_PIN(PORTC4), .D_OUT_0(port_out[20]), .D_IN_0(port_in[20]), .OUTPUT_ENABLE(port_dir[20]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio5 (.PACKAGE_PIN(PORTC5), .D_OUT_0(port_out[21]), .D_IN_0(port_in[21]), .OUTPUT_ENABLE(port_dir[21]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio6 (.PACKAGE_PIN(PORTC6), .D_OUT_0(port_out[22]), .D_IN_0(port_in[22]), .OUTPUT_ENABLE(port_dir[22]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio7 (.PACKAGE_PIN(PORTC7), .D_OUT_0(port_out[23]), .D_IN_0(port_in[23]), .OUTPUT_ENABLE(port_dir[23]));


   /***************************************************************************/
   // UART.
   /***************************************************************************/

   wire serial_valid, serial_busy;
   wire [7:0] serial_data;
   wire serial_wr = io_wstrb & mem_address[IO_UART_DAT_bit];
   wire serial_rd = io_rstrb & mem_address[IO_UART_DAT_bit];

   buart #(
     .FREQ_MHZ(30),
     .BAUDS(115200)
   ) buart (
      .clk(clk),
      .resetq(resetq),
      .rx(RXD),
      .tx(TXD),
      .rd(serial_rd),
      .wr(serial_wr),
      .valid(serial_valid),
      .busy(serial_busy),
      .tx_data(mem_wdata[7:0]),
      .rx_data(serial_data)
   );

   /***************************************************************************/
   // IO Ports.
   /***************************************************************************/

   // We got a total of 20 bits for 1-hot addressing of IO registers.

   // Bits mem_address[1:0] : Byte select
   // Bits mem_address[3:2] : Write +0, Clear +4, Set +8, Toggle +12

   localparam IO_PORT_IN_bit     =  4; // R:  GPIO port in
   localparam IO_PORT_OUT_bit    =  5; // RW: GPIO port out
   localparam IO_PORT_DIR_bit    =  6; // RW: GPIO port dir
   localparam IO_LEDS_bit        =  7; // RW: Eight leds

   localparam IO_UART_DAT_bit    = 16; // RW write: data to send (8 bits) read: received data (8 bits)
   localparam IO_UART_CNTL_bit   = 17; // R  status. bit 8: valid read data. bit 9: busy sending
   localparam IO_Ticks_bit       = 18; // RW: Timer count register
   localparam IO_Reload_bit      = 19; // RW: Timer reload value

   wire [31:0] io_rdata =

      (mem_address[IO_PORT_IN_bit    ] ?  port_in                                  : 32'd0) |
      (mem_address[IO_PORT_OUT_bit   ] ?  port_out                                 : 32'd0) |
      (mem_address[IO_PORT_DIR_bit   ] ?  port_dir                                 : 32'd0) |
      (mem_address[IO_LEDS_bit       ] ?  LEDs                                     : 32'd0) |

      (mem_address[IO_UART_DAT_bit   ] |
       mem_address[IO_UART_CNTL_bit  ] ? {serial_busy, serial_valid, serial_data}  : 32'd0) |
      (mem_address[IO_Ticks_bit      ] ?  ticks                                    : 32'd0) |
      (mem_address[IO_Reload_bit     ] ?  reload                                   : 32'd0) ;

   wire [31:0] io_modifier = (mem_address[3:2] == 2'b01)    ? ~mem_wdata & io_rdata :  // Clear
                             (mem_address[3:2] == 2'b10)    ?  mem_wdata | io_rdata :  // Set
                             (mem_address[3:2] == 2'b11)    ?  mem_wdata ^ io_rdata :  // Toggle
                          /* (mem_address[3:2] == 2'b00) */    mem_wdata            ;

   always @(posedge clk)
   begin

     // Word-only access
     // if (io_wstrb & mem_address[IO_PORT_OUT_bit]) port_out <= io_modifier;
     // if (io_wstrb & mem_address[IO_PORT_DIR_bit]) port_dir <= io_modifier;

     // Variable width access, allows to control the individual bytes
     if (mem_address_is_io & mem_address[IO_PORT_OUT_bit] & mem_wmask[0]) port_out[ 7:0 ] <= io_modifier[ 7:0 ];
     if (mem_address_is_io & mem_address[IO_PORT_OUT_bit] & mem_wmask[1]) port_out[15:8 ] <= io_modifier[15:8 ];
     if (mem_address_is_io & mem_address[IO_PORT_OUT_bit] & mem_wmask[2]) port_out[23:16] <= io_modifier[23:16];
   //if (mem_address_is_io & mem_address[IO_PORT_OUT_bit] & mem_wmask[3]) port_out[31:24] <= io_modifier[31:24]; // This port has 24 bits only

     // Variable width access, allows to control the individual bytes
     if (mem_address_is_io & mem_address[IO_PORT_DIR_bit] & mem_wmask[0]) port_dir[ 7:0 ] <= io_modifier[ 7:0 ];
     if (mem_address_is_io & mem_address[IO_PORT_DIR_bit] & mem_wmask[1]) port_dir[15:8 ] <= io_modifier[15:8 ];
     if (mem_address_is_io & mem_address[IO_PORT_DIR_bit] & mem_wmask[2]) port_dir[23:16] <= io_modifier[23:16];
   //if (mem_address_is_io & mem_address[IO_PORT_DIR_bit] & mem_wmask[3]) port_dir[31:24] <= io_modifier[31:24]; // This port has 24 bits only

     if (io_wstrb & mem_address[IO_LEDS_bit    ]) LEDs     <= io_modifier;
   end

   // The processor reads the contents one clock cycle after the read strobe has been active.
   // Buffering it for getting IO register contents of the read strobe cycle.

   reg  [31:0] io_rdata_buffered;

   always @(posedge clk)
      if (mem_address_is_io & io_rstrb) io_rdata_buffered <= io_rdata;

   /***************************************************************************/
   // The memory bus.
   /***************************************************************************/

   // Memory map:
   //   mem_address[23:22] 00: RAM              (starts at 0x00000000)
   //                      01: IO page (1-hot)  (starts at 0x00400000)
   //                      10: SPI Flash page   (starts at 0x00800000)

   wire [31:0] mem_address; // 24 bits are used internally. The two LSBs are ignored (using word addresses)
   wire  [3:0] mem_wmask;   // mem write mask and strobe /write Legal values are 000,0001,0010,0100,1000,0011,1100,1111
   wire [31:0] mem_rdata;   // processor <- (mem and peripherals)
   wire [31:0] mem_wdata;   // processor -> (mem and peripherals)
   wire        mem_rstrb;   // mem read strobe. Goes high to initiate memory read.
   wire        mem_rbusy;   // processor <- (mem and peripherals). Stays high until a read transfer is finished.
   wire        mem_wbusy;   // processor <- (mem and peripherals). Stays high until a write transfer is finished.

   /***************************************************************************/
   // The processor.
   /***************************************************************************/

   FemtoRV32 #(
     .RESET_ADDR(24'h840000),
     .ADDR_WIDTH(24)
   ) processor (
     .clk(clk),
     .mem_addr(mem_address),
     .mem_wdata(mem_wdata),
     .mem_wmask(mem_wmask),
     .mem_rdata(mem_rdata),
     .mem_rstrb(mem_rstrb),
     .mem_rbusy(mem_rbusy),
     .mem_wbusy(mem_wbusy),
     .interrupt_request(interrupt),
     .reset(resetq)
   );

   /***************************************************************************/
   // Memory and register access control wires.
   /***************************************************************************/

   wire mem_wstrb = |mem_wmask; // mem write strobe, goes high to initiate memory write (deduced from wmask)

   // RAM, IO or Flash ?

   wire mem_address_is_ram       = (mem_address[23:22] == 2'b00);
   wire mem_address_is_io        = (mem_address[23:22] == 2'b01);
   wire mem_address_is_spi_flash = (mem_address[23:22] == 2'b10);

   wire io_rstrb = mem_rstrb & mem_address_is_io;
   wire io_wstrb = mem_wstrb & mem_address_is_io;

   /***************************************************************************/
   // XIP from SPI flash.
   /***************************************************************************/

   wire mapped_spi_flash_rbusy;
   wire [31:0] mapped_spi_flash_rdata;

   MappedSPIFlash mapped_spi_flash(
      .clk(clk),
      .rstrb(mem_rstrb && mem_address_is_spi_flash),
      .word_address({2'b00, mem_address[21:2]}),
      .rdata(mapped_spi_flash_rdata),
      .rbusy(mapped_spi_flash_rbusy),

      .CLK(flash_clk),
      .CS_N(flash_csb),
      .IO({flash_io1,flash_io0})
   );

   assign  mem_rbusy = mapped_spi_flash_rbusy;
   assign  mem_wbusy = 0;

   /***************************************************************************/
   // RAM.
   /***************************************************************************/

   reg  [31:0] RAM[(14*1024/4)-1:0];
   reg  [31:0] ram_rdata;

   always @(posedge clk) begin

     if(mem_wmask[0] & mem_address_is_ram) RAM[mem_address[13:2]][ 7:0 ] <= mem_wdata[ 7:0 ];
     if(mem_wmask[1] & mem_address_is_ram) RAM[mem_address[13:2]][15:8 ] <= mem_wdata[15:8 ];
     if(mem_wmask[2] & mem_address_is_ram) RAM[mem_address[13:2]][23:16] <= mem_wdata[23:16];
     if(mem_wmask[3] & mem_address_is_ram) RAM[mem_address[13:2]][31:24] <= mem_wdata[31:24];

      ram_rdata <= RAM[mem_address[13:2]];
   end

   /***************************************************************************/
   // Connect the read wires of memories and IO registers to the memory bus.
   /***************************************************************************/

   assign mem_rdata =

      (mem_address_is_ram       ? ram_rdata              : 32'd0) |
      (mem_address_is_io        ? io_rdata_buffered      : 32'd0) |
      (mem_address_is_spi_flash ? mapped_spi_flash_rdata : 32'd0) ;

endmodule
