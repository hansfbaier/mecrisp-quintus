// femtorv32, a minimalistic RISC-V RV32I core
//    (minus SYSTEM and FENCE that are not implemented)
//
//       Bruno Levy, 2020-2021
//
// This file: driver for SPI Flash, projected in memory space (readonly)
//
// TODO: go faster with XIP mode and dummy cycles customization
// - send write enable command                   (06h)
// - send write volatile config register command (08h REG)
//   REG=dummy_cycles[7:4]=4'b0100 XIP[3]=1'b1 reserved[2]=1'b0 wrap[1:0]=2'b11
//     (4 dummy cycles, works at up to 90 MHz according to datasheet)
//
// DataSheets:
// https://media-www.micron.com/-/media/client/global/documents/products/data-sheet/nor-flash/serial-nor/n25q/n25q_32mb_3v_65nm.pdf?rev=27fc6016fc5249adb4bb8f221e72b395
// https://www.winbond.com/resource-files/w25q128jv%20spi%20revc%2011162016.pdf (not the same chip, mostly compatible, datasheet is easier to read)


// There are four versions (from slowest to fastest)
//
// Version (used command)          | cycles per 32-bits read | Specificity           |
// ----------------------------------------------------------|-----------------------|
// SPI_FLASH_READ                  | 64 slow (50 MHz)        | Standard              |
// SPI_FLASH_FAST_READ             | 72 fast (100 MHz)       | Uses dummy cycles     |
// SPI_FLASH_FAST_READ_DUAL_OUTPUT | 56 fast                 | Reverts MOSI          |
// SPI_FLASH_FAST_READ_DUAL_IO     | 44 fast                 | Reverts MISO and MOSI |

// One can go even faster by configuring number of dummy cycles (can save up to 4 cycles per read)
// and/or using XIP mode (that just requires the address to be send, saves 16 cycles per 32-bits read)
// (I tried both without success).
//
// Most chips support a QUAD IO mode, using four bidirectional pins,
// however, is not possible because the IO2 and IO3 pins
// are not wired on the IceStick (one may solder a tiny wire and plug it
// to a GPIO pin but I haven't soldering skills for things of that size !!)
// It is a pity, because one could go really fast with these pins !


module MappedSPIFlash(
    input  wire        clk,          // system clock
    input  wire        rstrb,        // read strobe
    input  wire [21:0] word_address, // read address

    output wire [31:0] rdata,        // data read
    output wire        rbusy,        // asserted if busy receiving data

    output wire        CLK,          // clock
    output wire        CS_N,         // chip select negated (active low)
    inout  wire [1:0]  IO            // two bidirectional IO pins
);

   parameter DUMMY_CYCLES = 8;

   reg [6:0]  clock_cnt = 7'b1000000; // send/receive clock, 2 bits per clock (dual IO)
   reg [39:0] shifter   = 0;          // used for sending and receiving

   assign  rbusy  = ~clock_cnt[6];
   assign  CS_N   =  clock_cnt[6];
   assign  CLK    =  rbusy & ~clk; // CLK needs to be disabled when not active.

   // Since least significant bytes are read first, we need to swizzle...
   assign rdata={shifter[7:0],shifter[15:8],shifter[23:16],shifter[31:24]};

   // The two data pins IO0 (=MOSI) and IO1 (=MISO) used in bidirectional mode.
   wire [1:0] IO_out = shifter[39:38];
   wire [1:0] IO_in  = IO;
   assign IO = clock_cnt[5:0] > 6'd15 ? IO_out : 2'bZZ; // |clock_cnt[5:4]

   always @(posedge clk) begin

      if(rstrb) begin
         shifter <= {16'hCFCF, word_address[21:0], 2'b00}; // 16'hCFCF is 8'hbb with bits doubled
         clock_cnt <= 7'd35 + DUMMY_CYCLES; // cmd: 8 clocks address: 12 clocks dummy: DUMMY_CYCLES clocks. data: 16 clocks, 2 bits per clock
      end else
      if (rbusy) begin
         shifter <= {shifter[37:0], IO_in};
         clock_cnt <= clock_cnt - 7'd1;
      end

   end
endmodule
