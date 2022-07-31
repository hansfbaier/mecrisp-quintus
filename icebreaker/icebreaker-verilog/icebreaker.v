/*
 *  PicoSoC - A simple example SoC using PicoRV32
 *
 *  Copyright (C) 2017  Clifford Wolf <clifford@clifford.at>
 *
 *  Permission to use, copy, modify, and/or distribute this software for any
 *  purpose with or without fee is hereby granted, provided that the above
 *  copyright notice and this permission notice appear in all copies.
 *
 *  THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
 *  WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
 *  MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
 *  ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
 *  WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
 *  ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
 *  OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
 *
 */

`ifdef PICOSOC_V
`error "icebreaker.v must be read before picosoc.v!"
`endif

`define PICOSOC_MEM ice40up5k_spram

`define cfg_divider       104  // 12 MHz / 115200

module icebreaker (
    input clk,

    output ser_tx,
    input  ser_rx,

    input  button,
    output ledr_n,
    output ledg_n,

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
    inout PORTC7
);

  // ######   Reset logic   #####################################

    reg [5:0] reset_cnt = 0;
    wire resetn = &reset_cnt;

    always @(posedge clk) begin
      if (button) reset_cnt <= reset_cnt + !resetn;
      else        reset_cnt <= 0;
    end

  // ######   RING OSCILLATOR   ###############################

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

  // ######   TICKS   #########################################

  reg interrupt = 0;

  reg [31:0] ticks;

  wire [32:0] ticks_plus_1 = ticks + 1;

  reg [31:0] reload = 0;

  wire [31:0] next_ticks = ticks_plus_1[32] ? reload[31:0] : ticks_plus_1[31:0];

  always @(posedge clk)
    if (iomem_valid & (iomem_wstrb[0] | iomem_wstrb[1] | iomem_wstrb[2] | iomem_wstrb[3]) & iomem_addr[18])
    begin
      if (iomem_wstrb[0]) ticks[ 7: 0] <= iomem_wdata[ 7: 0];
      if (iomem_wstrb[1]) ticks[15: 8] <= iomem_wdata[15: 8];
      if (iomem_wstrb[2]) ticks[23:16] <= iomem_wdata[23:16];
      if (iomem_wstrb[3]) ticks[31:24] <= iomem_wdata[31:24];
    end
    else ticks <= next_ticks;

  always @(posedge clk) // Generate interrupt on ticks overflow
    interrupt <= ticks_plus_1[32];

  always @(posedge clk)
    if (iomem_valid & (iomem_wstrb[0] | iomem_wstrb[1] | iomem_wstrb[2] | iomem_wstrb[3]) & iomem_addr[19])
    begin
      if (iomem_wstrb[0]) reload[ 7: 0] <= iomem_wdata[ 7: 0];
      if (iomem_wstrb[1]) reload[15: 8] <= iomem_wdata[15: 8];
      if (iomem_wstrb[2]) reload[23:16] <= iomem_wdata[23:16];
      if (iomem_wstrb[3]) reload[31:24] <= iomem_wdata[31:24];
    end

  // ######   LEDS   ############################################

  reg  [1:0] LEDS;

  assign ledr_n = ~LEDS[0];
  assign ledg_n = ~LEDS[1];

  // ######   PORTA   ###########################################

  reg  [7:0] porta_dir;   // 1:output, 0:input
  reg  [7:0] porta_out;
  wire [7:0] porta_in;

  SB_IO #(.PIN_TYPE(6'b1010_01)) ioa0  (.PACKAGE_PIN(PORTA0),  .D_OUT_0(porta_out[0]),  .D_IN_0(porta_in[0]),  .OUTPUT_ENABLE(porta_dir[0]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioa1  (.PACKAGE_PIN(PORTA1),  .D_OUT_0(porta_out[1]),  .D_IN_0(porta_in[1]),  .OUTPUT_ENABLE(porta_dir[1]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioa2  (.PACKAGE_PIN(PORTA2),  .D_OUT_0(porta_out[2]),  .D_IN_0(porta_in[2]),  .OUTPUT_ENABLE(porta_dir[2]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioa3  (.PACKAGE_PIN(PORTA3),  .D_OUT_0(porta_out[3]),  .D_IN_0(porta_in[3]),  .OUTPUT_ENABLE(porta_dir[3]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioa4  (.PACKAGE_PIN(PORTA4),  .D_OUT_0(porta_out[4]),  .D_IN_0(porta_in[4]),  .OUTPUT_ENABLE(porta_dir[4]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioa5  (.PACKAGE_PIN(PORTA5),  .D_OUT_0(porta_out[5]),  .D_IN_0(porta_in[5]),  .OUTPUT_ENABLE(porta_dir[5]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioa6  (.PACKAGE_PIN(PORTA6),  .D_OUT_0(porta_out[6]),  .D_IN_0(porta_in[6]),  .OUTPUT_ENABLE(porta_dir[6]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioa7  (.PACKAGE_PIN(PORTA7),  .D_OUT_0(porta_out[7]),  .D_IN_0(porta_in[7]),  .OUTPUT_ENABLE(porta_dir[7]));

  // ######   PORTB   ###########################################

  reg  [7:0] portb_dir;   // 1:output, 0:input
  reg  [7:0] portb_out;
  wire [7:0] portb_in;

  SB_IO #(.PIN_TYPE(6'b1010_01)) iob0  (.PACKAGE_PIN(PORTB0),  .D_OUT_0(portb_out[0]),  .D_IN_0(portb_in[0]),  .OUTPUT_ENABLE(portb_dir[0]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) iob1  (.PACKAGE_PIN(PORTB1),  .D_OUT_0(portb_out[1]),  .D_IN_0(portb_in[1]),  .OUTPUT_ENABLE(portb_dir[1]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) iob2  (.PACKAGE_PIN(PORTB2),  .D_OUT_0(portb_out[2]),  .D_IN_0(portb_in[2]),  .OUTPUT_ENABLE(portb_dir[2]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) iob3  (.PACKAGE_PIN(PORTB3),  .D_OUT_0(portb_out[3]),  .D_IN_0(portb_in[3]),  .OUTPUT_ENABLE(portb_dir[3]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) iob4  (.PACKAGE_PIN(PORTB4),  .D_OUT_0(portb_out[4]),  .D_IN_0(portb_in[4]),  .OUTPUT_ENABLE(portb_dir[4]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) iob5  (.PACKAGE_PIN(PORTB5),  .D_OUT_0(portb_out[5]),  .D_IN_0(portb_in[5]),  .OUTPUT_ENABLE(portb_dir[5]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) iob6  (.PACKAGE_PIN(PORTB6),  .D_OUT_0(portb_out[6]),  .D_IN_0(portb_in[6]),  .OUTPUT_ENABLE(portb_dir[6]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) iob7  (.PACKAGE_PIN(PORTB7),  .D_OUT_0(portb_out[7]),  .D_IN_0(portb_in[7]),  .OUTPUT_ENABLE(portb_dir[7]));

  // ######   PORTC   ###########################################

  reg  [7:0] portc_dir;   // 1:output, 0:input
  reg  [7:0] portc_out;
  wire [7:0] portc_in;

  SB_IO #(.PIN_TYPE(6'b1010_01)) ioc0  (.PACKAGE_PIN(PORTC0),  .D_OUT_0(portc_out[0]),  .D_IN_0(portc_in[0]),  .OUTPUT_ENABLE(portc_dir[0]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioc1  (.PACKAGE_PIN(PORTC1),  .D_OUT_0(portc_out[1]),  .D_IN_0(portc_in[1]),  .OUTPUT_ENABLE(portc_dir[1]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioc2  (.PACKAGE_PIN(PORTC2),  .D_OUT_0(portc_out[2]),  .D_IN_0(portc_in[2]),  .OUTPUT_ENABLE(portc_dir[2]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioc3  (.PACKAGE_PIN(PORTC3),  .D_OUT_0(portc_out[3]),  .D_IN_0(portc_in[3]),  .OUTPUT_ENABLE(portc_dir[3]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioc4  (.PACKAGE_PIN(PORTC4),  .D_OUT_0(portc_out[4]),  .D_IN_0(portc_in[4]),  .OUTPUT_ENABLE(portc_dir[4]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioc5  (.PACKAGE_PIN(PORTC5),  .D_OUT_0(portc_out[5]),  .D_IN_0(portc_in[5]),  .OUTPUT_ENABLE(portc_dir[5]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioc6  (.PACKAGE_PIN(PORTC6),  .D_OUT_0(portc_out[6]),  .D_IN_0(portc_in[6]),  .OUTPUT_ENABLE(portc_dir[6]));
  SB_IO #(.PIN_TYPE(6'b1010_01)) ioc7  (.PACKAGE_PIN(PORTC7),  .D_OUT_0(portc_out[7]),  .D_IN_0(portc_in[7]),  .OUTPUT_ENABLE(portc_dir[7]));


  // ######   IOMEM bus wires   #################################

  wire        iomem_valid;
  wire        iomem_ready  = iomem_valid; // One cycle access to all IO registers, no wait states.

  wire [3:0]  iomem_wstrb;
  wire [31:0] iomem_addr;
  wire [31:0] iomem_wdata;
  wire [31:0] iomem_rdata;

  // ######   UART   ##########################################

  wire uart0_valid, uart0_busy;
  wire [7:0] uart0_data;
  wire uart0_wr = iomem_valid &  iomem_wstrb[0] & iomem_addr[16];
  wire uart0_rd = iomem_valid & !iomem_wstrb[0] & iomem_addr[16];
  wire UART0_RX;
  buart _uart0 (
     .clk(clk),
     .resetq(resetn),
     .rx(ser_rx),
     .tx(ser_tx),
     .rd(uart0_rd),
     .wr(uart0_wr),
     .valid(uart0_valid),
     .busy(uart0_busy),
     .tx_data(iomem_wdata[7:0]),
     .rx_data(uart0_data));

  // ######   IOMEM register interface   #######################6

  assign iomem_rdata =

    (iomem_addr[ 4] ?         porta_in                                                 : 32'd0) |
    (iomem_addr[ 5] ?         porta_out                                                : 32'd0) |
    (iomem_addr[ 6] ?         porta_dir                                                : 32'd0) |
    (iomem_addr[ 7] ?         LEDS                                                     : 32'd0) |

    (iomem_addr[ 8] ?         portb_in                                                 : 32'd0) |
    (iomem_addr[ 9] ?         portb_out                                                : 32'd0) |
    (iomem_addr[10] ?         portb_dir                                                : 32'd0) |


    (iomem_addr[12] ?         portc_in                                                 : 32'd0) |
    (iomem_addr[13] ?         portc_out                                                : 32'd0) |
    (iomem_addr[14] ?         portc_dir                                                : 32'd0) |


    (iomem_addr[16] ?         uart0_data                                               : 32'd0) |
    (iomem_addr[17] ?         {random, uart0_valid, !uart0_busy}                       : 32'd0) |
    (iomem_addr[18] ?         ticks                                                    : 32'd0) |
    (iomem_addr[19] ?         reload                                                   : 32'd0) ;


  always @(posedge clk) begin

    if (iomem_valid & iomem_wstrb[0] & iomem_addr[5]  & (iomem_addr[3:2] == 0))  porta_out  <=               iomem_wdata[7:0];
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[5]  & (iomem_addr[3:2] == 1))  porta_out  <=  porta_out & ~iomem_wdata[7:0]; // Clear
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[5]  & (iomem_addr[3:2] == 2))  porta_out  <=  porta_out |  iomem_wdata[7:0]; // Set
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[5]  & (iomem_addr[3:2] == 3))  porta_out  <=  porta_out ^  iomem_wdata[7:0]; // Invert

    if (iomem_valid & iomem_wstrb[0] & iomem_addr[6]  & (iomem_addr[3:2] == 0))  porta_dir  <=               iomem_wdata[7:0];
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[6]  & (iomem_addr[3:2] == 1))  porta_dir  <=  porta_dir & ~iomem_wdata[7:0]; // Clear
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[6]  & (iomem_addr[3:2] == 2))  porta_dir  <=  porta_dir |  iomem_wdata[7:0]; // Set
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[6]  & (iomem_addr[3:2] == 3))  porta_dir  <=  porta_dir ^  iomem_wdata[7:0]; // Invert

    if (iomem_valid & iomem_wstrb[0] & iomem_addr[7]  & (iomem_addr[3:2] == 0))  LEDS       <=               iomem_wdata[7:0];
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[7]  & (iomem_addr[3:2] == 1))  LEDS       <=  LEDS      & ~iomem_wdata[7:0]; // Clear
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[7]  & (iomem_addr[3:2] == 2))  LEDS       <=  LEDS      |  iomem_wdata[7:0]; // Set
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[7]  & (iomem_addr[3:2] == 3))  LEDS       <=  LEDS      ^  iomem_wdata[7:0]; // Invert

    if (iomem_valid & iomem_wstrb[0] & iomem_addr[9]  & (iomem_addr[3:2] == 0))  portb_out  <=               iomem_wdata[7:0];
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[9]  & (iomem_addr[3:2] == 1))  portb_out  <=  portb_out & ~iomem_wdata[7:0]; // Clear
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[9]  & (iomem_addr[3:2] == 2))  portb_out  <=  portb_out |  iomem_wdata[7:0]; // Set
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[9]  & (iomem_addr[3:2] == 3))  portb_out  <=  portb_out ^  iomem_wdata[7:0]; // Invert

    if (iomem_valid & iomem_wstrb[0] & iomem_addr[10] & (iomem_addr[3:2] == 0))  portb_dir  <=               iomem_wdata[7:0];
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[10] & (iomem_addr[3:2] == 1))  portb_dir  <=  portb_dir & ~iomem_wdata[7:0]; // Clear
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[10] & (iomem_addr[3:2] == 2))  portb_dir  <=  portb_dir |  iomem_wdata[7:0]; // Set
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[10] & (iomem_addr[3:2] == 3))  portb_dir  <=  portb_dir ^  iomem_wdata[7:0]; // Invert

    if (iomem_valid & iomem_wstrb[0] & iomem_addr[13] & (iomem_addr[3:2] == 0))  portc_out  <=               iomem_wdata[7:0];
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[13] & (iomem_addr[3:2] == 1))  portc_out  <=  portc_out & ~iomem_wdata[7:0]; // Clear
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[13] & (iomem_addr[3:2] == 2))  portc_out  <=  portc_out |  iomem_wdata[7:0]; // Set
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[13] & (iomem_addr[3:2] == 3))  portc_out  <=  portc_out ^  iomem_wdata[7:0]; // Invert

    if (iomem_valid & iomem_wstrb[0] & iomem_addr[14] & (iomem_addr[3:2] == 0))  portc_dir  <=               iomem_wdata[7:0];
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[14] & (iomem_addr[3:2] == 1))  portc_dir  <=  portc_dir & ~iomem_wdata[7:0]; // Clear
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[14] & (iomem_addr[3:2] == 2))  portc_dir  <=  portc_dir |  iomem_wdata[7:0]; // Set
    if (iomem_valid & iomem_wstrb[0] & iomem_addr[14] & (iomem_addr[3:2] == 3))  portc_dir  <=  portc_dir ^  iomem_wdata[7:0]; // Invert

  end


  // ######   SPI Flash interface   #############################

    wire flash_io0_oe, flash_io0_do, flash_io0_di;
    wire flash_io1_oe, flash_io1_do, flash_io1_di;
    wire flash_io2_oe, flash_io2_do, flash_io2_di;
    wire flash_io3_oe, flash_io3_do, flash_io3_di;

    SB_IO #(
        .PIN_TYPE(6'b 1010_01),
        .PULLUP(1'b 0)
    ) flash_io_buf [3:0] (
        .PACKAGE_PIN({flash_io3, flash_io2, flash_io1, flash_io0}),
        .OUTPUT_ENABLE({flash_io3_oe, flash_io2_oe, flash_io1_oe, flash_io0_oe}),
        .D_OUT_0({flash_io3_do, flash_io2_do, flash_io1_do, flash_io0_do}),
        .D_IN_0({flash_io3_di, flash_io2_di, flash_io1_di, flash_io0_di})
    );

  // ######   Processor and memory module   #####################

    picosoc soc (
        .clk          (clk         ),
        .resetn       (resetn      ),

        .flash_csb    (flash_csb   ),
        .flash_clk    (flash_clk   ),

        .flash_io0_oe (flash_io0_oe),
        .flash_io1_oe (flash_io1_oe),
        .flash_io2_oe (flash_io2_oe),
        .flash_io3_oe (flash_io3_oe),

        .flash_io0_do (flash_io0_do),
        .flash_io1_do (flash_io1_do),
        .flash_io2_do (flash_io2_do),
        .flash_io3_do (flash_io3_do),

        .flash_io0_di (flash_io0_di),
        .flash_io1_di (flash_io1_di),
        .flash_io2_di (flash_io2_di),
        .flash_io3_di (flash_io3_di),

        .irq_5        (interrupt   ),
        .irq_6        (1'b0        ),
        .irq_7        (1'b0        ),

        .iomem_valid  (iomem_valid ),
        .iomem_ready  (iomem_ready ),
        .iomem_wstrb  (iomem_wstrb ),
        .iomem_addr   (iomem_addr  ),
        .iomem_wdata  (iomem_wdata ),
        .iomem_rdata  (iomem_rdata )
    );

endmodule
