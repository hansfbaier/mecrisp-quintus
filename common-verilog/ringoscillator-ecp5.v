
module ring_osc ( input resetq, output osc_out );

  parameter NUM_LUTS = 42;

  wire [NUM_LUTS:0] buffers_in, buffers_out;
  assign buffers_in = {buffers_out[NUM_LUTS - 1:0], chain_in};
  wire chain_out = buffers_out[NUM_LUTS];
  wire chain_in = resetq ? !chain_out : 0;

  LUT4 #(
      .INIT(16'd2)
  ) buffers [NUM_LUTS:0] (
      .Z(buffers_out),
      .A(buffers_in),
      .B(1'b0),
      .C(1'b0),
      .D(1'b0)
  );

  assign osc_out = chain_out;

endmodule
