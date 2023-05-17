
// Execute in place (XIP) from serial SPI flash,
// using the standard 03 read command which takes 64 clock cycles per word.

// This is very slow, but works with every standard SPI flash chip.

module MappedSPIFlash(
    input  wire        clk,          // system clock
    input  wire        rstrb,        // read strobe
    input  wire [21:0] word_address, // read address

    output wire [31:0] rdata,        // data read
    output wire        rbusy,        // asserted if busy receiving data

    output wire        CLK,          // clock
    output wire        CS_N,         // chip select negated (active low)

    input  wire        MISO,
    output wire        MOSI
);

   reg [6:0]  clock_cnt = 7'b1000000; // send/receive clock, 2 bits per clock (dual IO)
   reg [31:0] shifter   = 0;          // used for sending and receiving

   assign  rbusy  = ~clock_cnt[6];
   assign  CS_N   =  clock_cnt[6];
   assign  CLK    =  rbusy & ~clk; // CLK needs to be disabled when not active.

   // Since least significant bytes are read first, we need to swizzle...
   assign rdata={shifter[7:0],shifter[15:8],shifter[23:16],shifter[31:24]};

   assign MOSI = shifter[31];

   always @(posedge clk) begin

      if(rstrb) begin
         shifter <= {8'h03, word_address[21:0], 2'b00};
         clock_cnt <= 7'd63; // cmd: 8 clocks address: 24 clocks data: 32 clocks
      end else
      if (rbusy) begin
         shifter <= {shifter[30:0], MISO};
         clock_cnt <= clock_cnt - 7'd1;
      end

   end
endmodule
