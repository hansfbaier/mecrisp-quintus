
/******************************************************************************/
// A lot of RISC-V on the ULX3S
/******************************************************************************/

`default_nettype none // Makes it easier to detect typos !

`include "../../common-verilog/femtorv32_gracilis.v"
`include "../../common-verilog/uart-fifo.v"
`include "../../common-verilog/MappedSPIFlash.v"
`include "../../common-verilog/ringoscillator-ecp5.v"
`include "../../common-verilog/sdram/muchtoremember.v"

module ulx3s(

  input clk_25mhz,
  input [6:0] btn,
   output [7:0] led,

  output wifi_gpio0,
  output wifi_en,

  inout [27:0] gp,
  inout [27:0] gn,

  output flash_csn,
  // output flash_clk, // This is a special pin on ECP5 and requires using the USRMCLK macro.
  inout  flash_mosi,   // IO0
  inout  flash_miso,   // IO1
  output flash_wpn,    // IO2
  output flash_holdn,  // IO3

  output adc_sclk,
  output adc_csn,
  output adc_mosi,
  input  adc_miso,

  output sd_cmd,
  output sd_clk,
  output sd_d3,
  input  sd_d0,

  output [3:0] audio_l,
  output [3:0] audio_r,
  output [3:0] audio_v,

  inout oled_clk,
  inout oled_mosi,
  inout oled_resn,
  inout oled_dc,
  inout oled_csn,

  output ftdi_rxd, // UART TX
  input  ftdi_txd, // UART RX

  output sdram_csn,       // chip select
  output sdram_clk,       // clock to SDRAM
  output sdram_cke,       // clock enable to SDRAM
  output sdram_rasn,      // SDRAM RAS
  output sdram_casn,      // SDRAM CAS
  output sdram_wen,       // SDRAM write-enable
  output [12:0] sdram_a,  // SDRAM address bus
  output [1:0] sdram_ba,  // SDRAM bank-address
  output [1:0] sdram_dqm, // byte select
  inout [15:0] sdram_d    // data bus to/from SDRAM

);

   /***************************************************************************/
   // Clock.
   /***************************************************************************/

   wire clk;

   pll _pll( .clkin(clk_25mhz), .clkout0(clk) );  // 40 MHz

   // Tie GPIO0 high, keep board from rebooting
   assign wifi_gpio0 = 1;

   // Cut off wifi_en
   assign wifi_en = 0;

   /***************************************************************************/
   // Reset logic.
   /***************************************************************************/

   reg [7:0] reset_cnt = 0;
   wire resetq = &reset_cnt;

   always @(posedge clk) begin
     if (btn[0]) reset_cnt <= reset_cnt + !resetq;
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

   wire [27:0] porta_in;
   reg  [31:0] porta_out;
   reg  [31:0] porta_dir;  // 1:output, 0:input

   wire [27:0] portb_in;
   reg  [31:0] portb_out;
   reg  [31:0] portb_dir;  // 1:output, 0:input

   BB ioa [27:0] (.B(gp[27:0]), .I(porta_out[27:0]), .O(porta_in[27:0]), .T(~porta_dir[27:0]));
   BB iob [27:0] (.B(gn[27:0]), .I(portb_out[27:0]), .O(portb_in[27:0]), .T(~portb_dir[27:0]));

   wire [6:0] buttons_in = {random, btn[6:1]};

   /***************************************************************************/
   // UART.
   /***************************************************************************/

   wire serial_valid, serial_busy;
   wire [7:0] serial_data;
   wire serial_wr = io_wstrb & mem_address[IO_UART_DAT_bit];
   wire serial_rd = io_rstrb & mem_address[IO_UART_DAT_bit];

   buart #(
     .FREQ_MHZ(40),
     .BAUDS(115200)
   ) buart (
      .clk(clk),
      .resetq(resetq),
      .rx(ftdi_txd),
      .tx(ftdi_rxd),
      .rd(serial_rd),
      .wr(serial_wr),
      .valid(serial_valid),
      .busy(serial_busy),
      .tx_data(mem_wdata[7:0]),
      .rx_data(serial_data)
   );

   /***************************************************************************/
   // OLED.
   /***************************************************************************/

   wire [4:0] oled_in;
   reg  [4:0] oled_out;
   reg  [4:0] oled_dir;   // 1:output, 0:input

   BBPU oled0  (.B(oled_clk  ), .I(oled_out[ 0]), .O(oled_in[ 0]), .T(~oled_dir[ 0]));
   BBPU oled1  (.B(oled_mosi ), .I(oled_out[ 1]), .O(oled_in[ 1]), .T(~oled_dir[ 1]));
   BBPU oled2  (.B(oled_resn ), .I(oled_out[ 2]), .O(oled_in[ 2]), .T(~oled_dir[ 2]));
   BBPU oled3  (.B(oled_dc   ), .I(oled_out[ 3]), .O(oled_in[ 3]), .T(~oled_dir[ 3]));
   BBPU oled4  (.B(oled_csn  ), .I(oled_out[ 4]), .O(oled_in[ 4]), .T(~oled_dir[ 4]));

   /***************************************************************************/
   // ADC.
   /***************************************************************************/

   wire      adc_in = adc_miso;
   reg [2:0] adc_out;

   assign {adc_csn, adc_sclk, adc_mosi} = adc_out;

   /***************************************************************************/
   // SD-Card.
   /***************************************************************************/

   wire       sd_in = sd_d0; // MISO
   reg  [2:0] sd_out;

   assign {sd_d3, sd_clk, sd_cmd} = sd_out[2:0]; // CS, SCLK, MOSI

   /***************************************************************************/
   // Analog out.
   /***************************************************************************/

   reg [11:0] analog_out;

   assign audio_l = analog_out[3:0];
   assign audio_r = analog_out[7:4];
   assign audio_v = analog_out[11:8];

   /***************************************************************************/
   // IO Ports.
   /***************************************************************************/

   // We got a total of 30 bits for 1-hot addressing of IO registers.

   // Bits mem_address[1:0] : Byte select
   // Bits mem_address[3:2] : Write +0, Clear +4, Set +8, Toggle +12

   localparam IO_PORTA_IN_bit    =  4; // R:  GPIO port in
   localparam IO_PORTA_OUT_bit   =  5; // RW: GPIO port out
   localparam IO_PORTA_DIR_bit   =  6; // RW: GPIO port dir
   localparam IO_LEDS_bit        =  7; // RW: Eight leds

   localparam IO_PORTB_IN_bit    =  8; // R:  GPIO port in
   localparam IO_PORTB_OUT_bit   =  9; // RW: GPIO port out
   localparam IO_PORTB_DIR_bit   = 10; // RW: GPIO port dir
   localparam IO_BUTTONS_IN_bit  = 11; // R:  Six buttons and random

   localparam IO_OLED_IN_bit     = 12; // R:  OLED in
   localparam IO_OLED_OUT_bit    = 13; // RW: OLED out
   localparam IO_OLED_DIR_bit    = 14; // RW: OLED dir
   localparam IO_ANALOG_OUT_bit  = 15; // RW: 3 * 4 Bit DAC

   localparam IO_UART_DAT_bit    = 16; // RW write: data to send (8 bits) read: received data (8 bits)
   localparam IO_UART_CNTL_bit   = 17; // R  status. bit 8: valid read data. bit 9: busy sending
   localparam IO_Ticks_bit       = 18; // RW: Timer count register
   localparam IO_Reload_bit      = 19; // RW: Timer reload value

   localparam IO_ADC_IN_bit      = 20; // R:  ADC in
   localparam IO_ADC_OUT_bit     = 21; // RW: ADC out
   localparam IO_SD_IN_bit       = 22; // R:  SD-Card in
   localparam IO_SD_OUT_bit      = 23; // RW: SD-Card out

   wire [31:0] io_rdata =

      (mem_address[IO_PORTA_IN_bit   ] ?  porta_in                                 : 32'd0) |
      (mem_address[IO_PORTA_OUT_bit  ] ?  porta_out                                : 32'd0) |
      (mem_address[IO_PORTA_DIR_bit  ] ?  porta_dir                                : 32'd0) |
      (mem_address[IO_LEDS_bit       ] ?  LEDs                                     : 32'd0) |

      (mem_address[IO_PORTB_IN_bit   ] ?  portb_in                                 : 32'd0) |
      (mem_address[IO_PORTB_OUT_bit  ] ?  portb_out                                : 32'd0) |
      (mem_address[IO_PORTB_DIR_bit  ] ?  portb_dir                                : 32'd0) |
      (mem_address[IO_BUTTONS_IN_bit ] ?  buttons_in                               : 32'd0) |

      (mem_address[IO_OLED_IN_bit    ] ?  oled_in                                  : 32'd0) |
      (mem_address[IO_OLED_OUT_bit   ] ?  oled_out                                 : 32'd0) |
      (mem_address[IO_OLED_DIR_bit   ] ?  oled_dir                                 : 32'd0) |
      (mem_address[IO_ANALOG_OUT_bit ] ?  analog_out                               : 32'd0) |

      (mem_address[IO_UART_DAT_bit   ] |
       mem_address[IO_UART_CNTL_bit  ] ? {serial_busy, serial_valid, serial_data}  : 32'd0) |
      (mem_address[IO_Ticks_bit      ] ?  ticks                                    : 32'd0) |
      (mem_address[IO_Reload_bit     ] ?  reload                                   : 32'd0) |

      (mem_address[IO_ADC_IN_bit     ] ?  adc_in                                   : 32'd0) |
      (mem_address[IO_ADC_OUT_bit    ] ?  adc_out                                  : 32'd0) |
      (mem_address[IO_SD_IN_bit      ] ?  sd_in                                    : 32'd0) |
      (mem_address[IO_SD_OUT_bit     ] ?  sd_out                                   : 32'd0) ;

   wire [31:0] io_modifier = (mem_address[3:2] == 2'b01)    ? ~mem_wdata & io_rdata :  // Clear
                             (mem_address[3:2] == 2'b10)    ?  mem_wdata | io_rdata :  // Set
                             (mem_address[3:2] == 2'b11)    ?  mem_wdata ^ io_rdata :  // Toggle
                          /* (mem_address[3:2] == 2'b00) */    mem_wdata            ;

   always @(posedge clk)
   begin

     // Variable width access, allows to control the individual bytes
     if (mem_address_is_io & mem_address[IO_PORTA_OUT_bit] & mem_wmask[0]) porta_out[ 7:0 ] <= io_modifier[ 7:0 ];
     if (mem_address_is_io & mem_address[IO_PORTA_OUT_bit] & mem_wmask[1]) porta_out[15:8 ] <= io_modifier[15:8 ];
     if (mem_address_is_io & mem_address[IO_PORTA_OUT_bit] & mem_wmask[2]) porta_out[23:16] <= io_modifier[23:16];
     if (mem_address_is_io & mem_address[IO_PORTA_OUT_bit] & mem_wmask[3]) porta_out[31:24] <= io_modifier[31:24];

     if (mem_address_is_io & mem_address[IO_PORTA_DIR_bit] & mem_wmask[0]) porta_dir[ 7:0 ] <= io_modifier[ 7:0 ];
     if (mem_address_is_io & mem_address[IO_PORTA_DIR_bit] & mem_wmask[1]) porta_dir[15:8 ] <= io_modifier[15:8 ];
     if (mem_address_is_io & mem_address[IO_PORTA_DIR_bit] & mem_wmask[2]) porta_dir[23:16] <= io_modifier[23:16];
     if (mem_address_is_io & mem_address[IO_PORTA_DIR_bit] & mem_wmask[3]) porta_dir[31:24] <= io_modifier[31:24];

     if (mem_address_is_io & mem_address[IO_PORTB_OUT_bit] & mem_wmask[0]) portb_out[ 7:0 ] <= io_modifier[ 7:0 ];
     if (mem_address_is_io & mem_address[IO_PORTB_OUT_bit] & mem_wmask[1]) portb_out[15:8 ] <= io_modifier[15:8 ];
     if (mem_address_is_io & mem_address[IO_PORTB_OUT_bit] & mem_wmask[2]) portb_out[23:16] <= io_modifier[23:16];
     if (mem_address_is_io & mem_address[IO_PORTB_OUT_bit] & mem_wmask[3]) portb_out[31:24] <= io_modifier[31:24];

     if (mem_address_is_io & mem_address[IO_PORTB_DIR_bit] & mem_wmask[0]) portb_dir[ 7:0 ] <= io_modifier[ 7:0 ];
     if (mem_address_is_io & mem_address[IO_PORTB_DIR_bit] & mem_wmask[1]) portb_dir[15:8 ] <= io_modifier[15:8 ];
     if (mem_address_is_io & mem_address[IO_PORTB_DIR_bit] & mem_wmask[2]) portb_dir[23:16] <= io_modifier[23:16];
     if (mem_address_is_io & mem_address[IO_PORTB_DIR_bit] & mem_wmask[3]) portb_dir[31:24] <= io_modifier[31:24];

     if (io_wstrb & mem_address[IO_ADC_OUT_bit   ]) adc_out    <= io_modifier;
     if (io_wstrb & mem_address[IO_OLED_OUT_bit  ]) oled_out   <= io_modifier;
     if (io_wstrb & mem_address[IO_OLED_DIR_bit  ]) oled_dir   <= io_modifier;
     if (io_wstrb & mem_address[IO_SD_OUT_bit    ]) sd_out     <= io_modifier;
     if (io_wstrb & mem_address[IO_ANALOG_OUT_bit]) analog_out <= io_modifier;
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
   //   mem_address[31:30] 00: RAM              (starts at 0x00000000)
   //                      01: IO page (1-hot)  (starts at 0x40000000)
   //                      10: SPI Flash page   (starts at 0x80000000)
   //                      11: SDRAM, 64 MB     (starts at 0xC0000000)

   wire [31:0] mem_address; // 32 bits are used internally. The two LSBs are ignored (using word addresses)
   wire  [3:0] mem_wmask;   // mem write mask and strobe /write Legal values are 0000,0001,0010,0100,1000,0011,1100,1111
   wire [31:0] mem_rdata;   // processor <- (mem and peripherals)
   wire [31:0] mem_wdata;   // processor -> (mem and peripherals)
   wire        mem_rstrb;   // mem read strobe. Goes high to initiate memory read.
   wire        mem_rbusy;   // processor <- (mem and peripherals). Stays high until a read transfer is finished.
   wire        mem_wbusy;   // processor <- (mem and peripherals). Stays high until a write transfer is finished.

   /***************************************************************************/
   // The processor.
   /***************************************************************************/

   FemtoRV32 #(
     .RESET_ADDR(32'h80200000), // Start 2 MB into SPI flash memory
     .ADDR_WIDTH(32)
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

   wire mem_address_is_ram       = (mem_address[31:30] == 2'b00);
   wire mem_address_is_io        = (mem_address[31:30] == 2'b01);
   wire mem_address_is_spi_flash = (mem_address[31:30] == 2'b10);
   wire mem_address_is_sdram     = (mem_address[31:30] == 2'b11);

   wire io_rstrb = mem_rstrb & mem_address_is_io;
   wire io_wstrb = mem_wstrb & mem_address_is_io;

   /***************************************************************************/
   // 64 MB SD-RAM.
   /***************************************************************************/

   wire [31:0] sdram_rdata;
   wire sdram_busy;

   muchtoremember sdram(
     // Physical interface
    .sd_d(sdram_d),
    .sd_addr(sdram_a),
    .sd_dqm(sdram_dqm),
    .sd_cs(sdram_csn),
    .sd_ba(sdram_ba),
    .sd_we(sdram_wen),
    .sd_ras(sdram_rasn),
    .sd_cas(sdram_casn),
    .sd_clk(sdram_clk),
    .sd_cke(sdram_cke),

     // Internal bus interface
    .clk(clk),
    .resetn(resetq),
    .addr(mem_address[25:0]),
    .wmask({4{mem_address_is_sdram}} & mem_wmask),
    .rd   (   mem_address_is_sdram   & mem_rstrb),
    .din(mem_wdata),
    .dout(sdram_rdata),
    .busy(sdram_busy)
  );

   /***************************************************************************/
   // XIP from SPI flash.
   /***************************************************************************/

   // A special macro is necessary to access the clock wire of the SPI flash memory chip

   wire flash_clk;
   wire untristate = 0;
   USRMCLK mclk (.USRMCLKTS(untristate), .USRMCLKI(flash_clk));

   assign flash_wpn   = 1;
   assign flash_holdn = 1;

   wire mapped_spi_flash_rbusy;
   wire [31:0] mapped_spi_flash_rdata;

   MappedSPIFlash #( .DUMMY_CYCLES(4) ) mapped_spi_flash (
      .clk(clk),
      .rstrb(mem_rstrb && mem_address_is_spi_flash),
      .word_address(mem_address[23:2]),
      .rdata(mapped_spi_flash_rdata),
      .rbusy(mapped_spi_flash_rbusy),

      .CLK(flash_clk),
      .CS_N(flash_csn),
      .IO({flash_miso, flash_mosi})
   );

   assign  mem_rbusy = sdram_busy | mapped_spi_flash_rbusy;
   assign  mem_wbusy = sdram_busy;

   /***************************************************************************/
   // RAM.
   /***************************************************************************/

   reg  [31:0] RAM[(128*1024/4)-1:0];
   reg  [31:0] ram_rdata;

   always @(posedge clk) begin

     if(mem_wmask[0] & mem_address_is_ram) RAM[mem_address[16:2]][ 7:0 ] <= mem_wdata[ 7:0 ];
     if(mem_wmask[1] & mem_address_is_ram) RAM[mem_address[16:2]][15:8 ] <= mem_wdata[15:8 ];
     if(mem_wmask[2] & mem_address_is_ram) RAM[mem_address[16:2]][23:16] <= mem_wdata[23:16];
     if(mem_wmask[3] & mem_address_is_ram) RAM[mem_address[16:2]][31:24] <= mem_wdata[31:24];

      ram_rdata <= RAM[mem_address[16:2]];
   end

   /***************************************************************************/
   // Connect the read wires of memories and IO registers to the memory bus.
   /***************************************************************************/

   assign mem_rdata =

      (mem_address_is_ram       ? ram_rdata              : 32'd0) |
      (mem_address_is_io        ? io_rdata_buffered      : 32'd0) |
      (mem_address_is_spi_flash ? mapped_spi_flash_rdata : 32'd0) |
      (mem_address_is_sdram     ? sdram_rdata            : 32'd0) ;

endmodule


// 40 MHz system clock
// ecppll -i 25 -o 40 -f /dev/stdout

module pll
(
    input clkin, // 25 MHz, 0 deg
    output clkout0, // 40 MHz, 0 deg
    output locked
);
(* FREQUENCY_PIN_CLKI="25" *)
(* FREQUENCY_PIN_CLKOP="40" *)
(* ICP_CURRENT="12" *) (* LPF_RESISTOR="8" *) (* MFG_ENABLE_FILTEROPAMP="1" *) (* MFG_GMCREF_SEL="2" *)
EHXPLLL #(
        .PLLRST_ENA("DISABLED"),
        .INTFB_WAKE("DISABLED"),
        .STDBY_ENABLE("DISABLED"),
        .DPHASE_SOURCE("DISABLED"),
        .OUTDIVIDER_MUXA("DIVA"),
        .OUTDIVIDER_MUXB("DIVB"),
        .OUTDIVIDER_MUXC("DIVC"),
        .OUTDIVIDER_MUXD("DIVD"),
        .CLKI_DIV(5),
        .CLKOP_ENABLE("ENABLED"),
        .CLKOP_DIV(15),
        .CLKOP_CPHASE(7),
        .CLKOP_FPHASE(0),
        .FEEDBK_PATH("CLKOP"),
        .CLKFB_DIV(8)
    ) pll_i (
        .RST(1'b0),
        .STDBY(1'b0),
        .CLKI(clkin),
        .CLKOP(clkout0),
        .CLKFB(clkout0),
        .CLKINTFB(),
        .PHASESEL0(1'b0),
        .PHASESEL1(1'b0),
        .PHASEDIR(1'b1),
        .PHASESTEP(1'b1),
        .PHASELOADREG(1'b1),
        .PLLWAKESYNC(1'b0),
        .ENCLKOP(1'b0),
        .LOCK(locked)
        );
endmodule
