
/*******************************************************************/
// Femtosoc, a lot of RISC-V on the Icestick
/*******************************************************************/

`default_nettype none // Makes it easier to detect typos !

`include "femtorv32_quark.v"
`include "uart_picosoc_shrunk.v"
`include "MappedSPIFlash.v"

module femtosoc(
   input oscillator,

   output D1, D2, D3, D4, D5,

   output TXD,
   input  RXD,

   output spi_clk,
   output spi_cs_n,
   inout  spi_mosi,
   inout  spi_miso,

   input      IR_RXD,
   output reg IR_TXD,
   output     IR_SD,

   inout PIO1_02,    // PMOD 1
   inout PIO1_03,    // PMOD 2
   inout PIO1_04,    // PMOD 3
   inout PIO1_05,    // PMOD 4
   inout PIO1_06,    // PMOD 5
   inout PIO1_07,    // PMOD 6
   inout PIO1_08,    // PMOD 7
   inout PIO1_09,    // PMOD 8

   inout PIO0_02,    // Header 1
   inout PIO0_03,    // Header 2
   inout PIO0_04,    // Header 3
   inout PIO0_05,    // Header 4
   inout PIO0_06,    // Header 5
   inout PIO0_07,    // Header 6
   inout PIO0_08,    // Header 7
   inout PIO0_09,    // Header 8

   inout PIO2_10,    // Header 1
   inout PIO2_11,    // Header 2
   inout PIO2_12,    // Header 3
   inout PIO2_13,    // Header 4
   inout PIO2_14,    // Header 5
   inout PIO2_15,    // Header 6
   inout PIO2_16,    // Header 7
   inout PIO2_17,    // Header 8

   input reset_button
);

   assign IR_SD = 0;

   /***************************************************************************/
   // Clock.
   /***************************************************************************/

   wire clk; // Configured for 48 MHz

   SB_PLL40_CORE #(.FEEDBACK_PATH("SIMPLE"),
                   .PLLOUT_SELECT("GENCLK"),
                   .DIVR(4'b0000),
                   .DIVF(7'd3),
                   .DIVQ(3'b000),
                   .FILTER_RANGE(3'b001),
                  ) uut (
                          .REFERENCECLK(oscillator),
                          .PLLOUTCORE(clk),
                          //.PLLOUTGLOBAL(clk),
                          //.LOCK(D5),
                          .RESETB(1'b1),
                          .BYPASS(1'b0)
                         );

   /***************************************************************************/
   // Reset logic.
   /***************************************************************************/

   reg [7:0] reset_cnt = 0;
   wire resetq = &reset_cnt;

   always @(posedge clk, negedge reset_button) begin
     if (!reset_button) reset_cnt <= 0;
     else               reset_cnt <= reset_cnt + !resetq;
   end


   /***************************************************************************/
   // LEDs.
   /***************************************************************************/

   reg [4:0] LEDs;
   assign {D5, D4, D3, D2, D1} = LEDs;

   /***************************************************************************/
   // Ring oscillator for random numbers.
   /***************************************************************************/

   wire [1:0] buffers_in, buffers_out;
   assign buffers_in = {buffers_out[0:0], ~buffers_out[1]};
   SB_LUT4 #(
           .LUT_INIT(16'd2)
   ) buffers [1:0] (
           .O(buffers_out),
           .I0(buffers_in),
           .I1(1'b0),
           .I2(1'b0),
           .I3(1'b0)
   );

   wire random = ~buffers_out[1];

   /***************************************************************************/
   // GPIO.
   /***************************************************************************/

   wire [24:0] port_in;
   reg  [23:0] port_out;
   reg  [23:0] port_dir;

   assign port_in[24] = random;

   // PMOD

   SB_IO #(.PIN_TYPE(6'b1010_01)) fio0 (.PACKAGE_PIN(PIO1_02), .D_OUT_0(port_out[ 0]), .D_IN_0(port_in[ 0]), .OUTPUT_ENABLE(port_dir[ 0]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio1 (.PACKAGE_PIN(PIO1_03), .D_OUT_0(port_out[ 1]), .D_IN_0(port_in[ 1]), .OUTPUT_ENABLE(port_dir[ 1]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio2 (.PACKAGE_PIN(PIO1_04), .D_OUT_0(port_out[ 2]), .D_IN_0(port_in[ 2]), .OUTPUT_ENABLE(port_dir[ 2]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio3 (.PACKAGE_PIN(PIO1_05), .D_OUT_0(port_out[ 3]), .D_IN_0(port_in[ 3]), .OUTPUT_ENABLE(port_dir[ 3]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio4 (.PACKAGE_PIN(PIO1_06), .D_OUT_0(port_out[ 4]), .D_IN_0(port_in[ 4]), .OUTPUT_ENABLE(port_dir[ 4]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio5 (.PACKAGE_PIN(PIO1_07), .D_OUT_0(port_out[ 5]), .D_IN_0(port_in[ 5]), .OUTPUT_ENABLE(port_dir[ 5]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio6 (.PACKAGE_PIN(PIO1_08), .D_OUT_0(port_out[ 6]), .D_IN_0(port_in[ 6]), .OUTPUT_ENABLE(port_dir[ 6]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) fio7 (.PACKAGE_PIN(PIO1_09), .D_OUT_0(port_out[ 7]), .D_IN_0(port_in[ 7]), .OUTPUT_ENABLE(port_dir[ 7]));

   // Header 1

   SB_IO #(.PIN_TYPE(6'b1010_01)) gio0 (.PACKAGE_PIN(PIO0_02), .D_OUT_0(port_out[ 8]), .D_IN_0(port_in[ 8]), .OUTPUT_ENABLE(port_dir[ 8]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio1 (.PACKAGE_PIN(PIO0_03), .D_OUT_0(port_out[ 9]), .D_IN_0(port_in[ 9]), .OUTPUT_ENABLE(port_dir[ 9]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio2 (.PACKAGE_PIN(PIO0_04), .D_OUT_0(port_out[10]), .D_IN_0(port_in[10]), .OUTPUT_ENABLE(port_dir[10]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio3 (.PACKAGE_PIN(PIO0_05), .D_OUT_0(port_out[11]), .D_IN_0(port_in[11]), .OUTPUT_ENABLE(port_dir[11]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio4 (.PACKAGE_PIN(PIO0_06), .D_OUT_0(port_out[12]), .D_IN_0(port_in[12]), .OUTPUT_ENABLE(port_dir[12]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio5 (.PACKAGE_PIN(PIO0_07), .D_OUT_0(port_out[13]), .D_IN_0(port_in[13]), .OUTPUT_ENABLE(port_dir[13]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio6 (.PACKAGE_PIN(PIO0_08), .D_OUT_0(port_out[14]), .D_IN_0(port_in[14]), .OUTPUT_ENABLE(port_dir[14]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) gio7 (.PACKAGE_PIN(PIO0_09), .D_OUT_0(port_out[15]), .D_IN_0(port_in[15]), .OUTPUT_ENABLE(port_dir[15]));

   // Header 2

   SB_IO #(.PIN_TYPE(6'b1010_01)) hio0 (.PACKAGE_PIN(PIO2_10), .D_OUT_0(port_out[16]), .D_IN_0(port_in[16]), .OUTPUT_ENABLE(port_dir[16]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio1 (.PACKAGE_PIN(PIO2_11), .D_OUT_0(port_out[17]), .D_IN_0(port_in[17]), .OUTPUT_ENABLE(port_dir[17]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio2 (.PACKAGE_PIN(PIO2_12), .D_OUT_0(port_out[18]), .D_IN_0(port_in[18]), .OUTPUT_ENABLE(port_dir[18]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio3 (.PACKAGE_PIN(PIO2_13), .D_OUT_0(port_out[19]), .D_IN_0(port_in[19]), .OUTPUT_ENABLE(port_dir[19]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio4 (.PACKAGE_PIN(PIO2_14), .D_OUT_0(port_out[20]), .D_IN_0(port_in[20]), .OUTPUT_ENABLE(port_dir[20]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio5 (.PACKAGE_PIN(PIO2_15), .D_OUT_0(port_out[21]), .D_IN_0(port_in[21]), .OUTPUT_ENABLE(port_dir[21]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio6 (.PACKAGE_PIN(PIO2_16), .D_OUT_0(port_out[22]), .D_IN_0(port_in[22]), .OUTPUT_ENABLE(port_dir[22]));
   SB_IO #(.PIN_TYPE(6'b1010_01)) hio7 (.PACKAGE_PIN(PIO2_17), .D_OUT_0(port_out[23]), .D_IN_0(port_in[23]), .OUTPUT_ENABLE(port_dir[23]));


   /***************************************************************************/
   // UART.
   /***************************************************************************/

   wire serial_valid, serial_busy;
   wire [7:0] serial_data;
   wire serial_wr = io_wstrb & mem_address[IO_UART_DAT_bit];
   wire serial_rd = io_rstrb & mem_address[IO_UART_DAT_bit];

   buart #(
     .FREQ_MHZ(48),
     .BAUDS(115200)
   ) the_buart (
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

   localparam IO_LEDS_bit      = 2; // RW four leds
   localparam IO_UART_DAT_bit  = 3; // RW write: data to send (8 bits) read: received data (8 bits)
   localparam IO_UART_CNTL_bit = 4; // R  status. bit 8: valid read data. bit 9: busy sending
   localparam IO_PORT_IN_bit   = 5; // R:  GPIO port in
   localparam IO_PORT_OUT_bit  = 6; // RW: GPIO port out
   localparam IO_PORT_DIR_bit  = 7; // RW: GPIO port dir
   localparam IO_IR_bit        = 8; // RW: Infrared communication

   wire [31:0] io_rdata =

      (mem_address[IO_UART_DAT_bit ] |
       mem_address[IO_UART_CNTL_bit] ? {serial_busy, serial_valid, serial_data}  : 32'd0) |
      (mem_address[IO_PORT_IN_bit  ] ?  port_in                                  : 32'd0) |
      (mem_address[IO_PORT_OUT_bit ] ?  port_out                                 : 32'd0) |
      (mem_address[IO_PORT_DIR_bit ] ?  port_dir                                 : 32'd0) |
      (mem_address[IO_LEDS_bit     ] ?  LEDs                                     : 32'd0) |
      (mem_address[IO_IR_bit       ] ?  IR_RXD                                   : 32'd0) ;

   always @(posedge clk)
   begin
     if (io_wstrb & mem_address[IO_LEDS_bit    ]) LEDs     <= mem_wdata;
     if (io_wstrb & mem_address[IO_PORT_OUT_bit]) port_out <= mem_wdata;
     if (io_wstrb & mem_address[IO_PORT_DIR_bit]) port_dir <= mem_wdata;
     if (io_wstrb & mem_address[IO_IR_bit      ]) IR_TXD   <= mem_wdata;
   end

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
     .RESET_ADDR(32'h810000)
   ) processor (
     .clk(clk),
     .mem_addr(mem_address),
     .mem_wdata(mem_wdata),
     .mem_wmask(mem_wmask),
     .mem_rdata(mem_rdata),
     .mem_rstrb(mem_rstrb),
     .mem_rbusy(mem_rbusy),
     .mem_wbusy(mem_wbusy),
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
      .word_address(mem_address[21:2]),
      .rdata(mapped_spi_flash_rdata),
      .rbusy(mapped_spi_flash_rbusy),
      .CLK(spi_clk),
      .CS_N(spi_cs_n),
      .IO({spi_miso,spi_mosi})
   );

   assign  mem_rbusy = mapped_spi_flash_rbusy ;
   assign  mem_wbusy = 0;

   /***************************************************************************/
   // RAM.
   /***************************************************************************/

   reg  [31:0] RAM[(6144/4)-1:0];
   reg  [31:0] ram_rdata;

   always @(posedge clk) begin

     if(mem_wmask[0] & mem_address_is_ram) RAM[mem_address[12:2]][ 7:0 ] <= mem_wdata[ 7:0 ];
     if(mem_wmask[1] & mem_address_is_ram) RAM[mem_address[12:2]][15:8 ] <= mem_wdata[15:8 ];
     if(mem_wmask[2] & mem_address_is_ram) RAM[mem_address[12:2]][23:16] <= mem_wdata[23:16];
     if(mem_wmask[3] & mem_address_is_ram) RAM[mem_address[12:2]][31:24] <= mem_wdata[31:24];

      ram_rdata <= RAM[mem_address[12:2]];
   end

   /***************************************************************************/
   // Connect the read wires of memories and IO registers to the memory bus.
   /***************************************************************************/

   assign mem_rdata =

      (mem_address_is_ram       ? ram_rdata              : 32'd0) |
      (mem_address_is_io        ? io_rdata               : 32'd0) |
      (mem_address_is_spi_flash ? mapped_spi_flash_rdata : 32'd0) ;

endmodule
