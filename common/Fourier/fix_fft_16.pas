(* fix_fft.c - Fixed-point in-place Fast Fourier Transform  *)
(*
  All data are fixed-point smallint integers, in which -32768
  to +32768 represent -1.0 to +1.0 respectively. Integer
  arithmetic is used for speed, instead of the more natural
  floating-point.

  For the forward FFT (time -> freq), fixed scaling is
  performed to prevent arithmetic overflow, and to map a 0dB
  sine/cosine wave (i.e. amplitude = 32767) to two -6dB freq
  coefficients. The return value is always 0.

  For the inverse FFT (freq -> time), fixed scaling cannot be
  done, as two 0dB coefficients would sum to a peak amplitude
  of 64K, overflowing the 32k range of the fixed-point integers.
  Thus, the fix_fft() routine performs variable scaling, and
  returns a value which is the number of bits LEFT by which
  the output must be shifted to get the actual amplitude
  (i.e. if fix_fft() returns 3, each value of fr[] and fi[]
  must be multiplied by 8 (2**3) for proper scaling.
  Clearly, this cannot be done within fixed-point smallint
  integers. In practice, if the result is to be used as a
  filter, the scale_shift can usually be ignored, as the
  result will be approximately correctly normalized as is.

  Written by:  Tom Roberts  11/8/89
  Made portable:  Malcolm Slaney 12/15/94 malcolm@interval.com
  Enhanced:  Dimitrios P. Bouras  14 Jun 2006 dbouras@ieee.org
  Translated to Pascal:  Matthias Koch, 22 Jan 2020 m.cook@gmx.net
*)
{$R+}
const N_WAVE = 1024;    (* full length of Sinewave[] *)
 LOG2_N_WAVE = 10;      (* log2(N_WAVE) *)

(*
  Henceforth "smallint" implies 16-bit word. If this is not
  the case in your architecture, please replace "smallint"
  with a type definition which *is* a 16-bit word.
*)

(*
  Since we only use 3/4 of N_WAVE, we define only
  this many samples, in order to conserve data space.
*)

const Sinewave : array[0..N_WAVE - (N_WAVE div 4) - 1] of smallint =
(
      0,    201,    402,    603,    804,   1005,   1206,   1406,
   1607,   1808,   2009,   2209,   2410,   2610,   2811,   3011,
   3211,   3411,   3611,   3811,   4011,   4210,   4409,   4608,
   4807,   5006,   5205,   5403,   5601,   5799,   5997,   6195,
   6392,   6589,   6786,   6982,   7179,   7375,   7571,   7766,
   7961,   8156,   8351,   8545,   8739,   8932,   9126,   9319,
   9511,   9703,   9895,  10087,  10278,  10469,  10659,  10849,
  11038,  11227,  11416,  11604,  11792,  11980,  12166,  12353,
  12539,  12724,  12909,  13094,  13278,  13462,  13645,  13827,
  14009,  14191,  14372,  14552,  14732,  14911,  15090,  15268,
  15446,  15623,  15799,  15975,  16150,  16325,  16499,  16672,
  16845,  17017,  17189,  17360,  17530,  17699,  17868,  18036,
  18204,  18371,  18537,  18702,  18867,  19031,  19194,  19357,
  19519,  19680,  19840,  20000,  20159,  20317,  20474,  20631,
  20787,  20942,  21096,  21249,  21402,  21554,  21705,  21855,
  22004,  22153,  22301,  22448,  22594,  22739,  22883,  23027,
  23169,  23311,  23452,  23592,  23731,  23869,  24006,  24143,
  24278,  24413,  24546,  24679,  24811,  24942,  25072,  25201,
  25329,  25456,  25582,  25707,  25831,  25954,  26077,  26198,
  26318,  26437,  26556,  26673,  26789,  26905,  27019,  27132,
  27244,  27355,  27466,  27575,  27683,  27790,  27896,  28001,
  28105,  28208,  28309,  28410,  28510,  28608,  28706,  28802,
  28897,  28992,  29085,  29177,  29268,  29358,  29446,  29534,
  29621,  29706,  29790,  29873,  29955,  30036,  30116,  30195,
  30272,  30349,  30424,  30498,  30571,  30643,  30713,  30783,
  30851,  30918,  30984,  31049,  31113,  31175,  31236,  31297,
  31356,  31413,  31470,  31525,  31580,  31633,  31684,  31735,
  31785,  31833,  31880,  31926,  31970,  32014,  32056,  32097,
  32137,  32176,  32213,  32249,  32284,  32318,  32350,  32382,
  32412,  32441,  32468,  32495,  32520,  32544,  32567,  32588,
  32609,  32628,  32646,  32662,  32678,  32692,  32705,  32717,
  32727,  32736,  32744,  32751,  32757,  32761,  32764,  32766,

  32767,  32766,  32764,  32761,  32757,  32751,  32744,  32736,
  32727,  32717,  32705,  32692,  32678,  32662,  32646,  32628,
  32609,  32588,  32567,  32544,  32520,  32495,  32468,  32441,
  32412,  32382,  32350,  32318,  32284,  32249,  32213,  32176,
  32137,  32097,  32056,  32014,  31970,  31926,  31880,  31833,
  31785,  31735,  31684,  31633,  31580,  31525,  31470,  31413,
  31356,  31297,  31236,  31175,  31113,  31049,  30984,  30918,
  30851,  30783,  30713,  30643,  30571,  30498,  30424,  30349,
  30272,  30195,  30116,  30036,  29955,  29873,  29790,  29706,
  29621,  29534,  29446,  29358,  29268,  29177,  29085,  28992,
  28897,  28802,  28706,  28608,  28510,  28410,  28309,  28208,
  28105,  28001,  27896,  27790,  27683,  27575,  27466,  27355,
  27244,  27132,  27019,  26905,  26789,  26673,  26556,  26437,
  26318,  26198,  26077,  25954,  25831,  25707,  25582,  25456,
  25329,  25201,  25072,  24942,  24811,  24679,  24546,  24413,
  24278,  24143,  24006,  23869,  23731,  23592,  23452,  23311,
  23169,  23027,  22883,  22739,  22594,  22448,  22301,  22153,
  22004,  21855,  21705,  21554,  21402,  21249,  21096,  20942,
  20787,  20631,  20474,  20317,  20159,  20000,  19840,  19680,
  19519,  19357,  19194,  19031,  18867,  18702,  18537,  18371,
  18204,  18036,  17868,  17699,  17530,  17360,  17189,  17017,
  16845,  16672,  16499,  16325,  16150,  15975,  15799,  15623,
  15446,  15268,  15090,  14911,  14732,  14552,  14372,  14191,
  14009,  13827,  13645,  13462,  13278,  13094,  12909,  12724,
  12539,  12353,  12166,  11980,  11792,  11604,  11416,  11227,
  11038,  10849,  10659,  10469,  10278,  10087,   9895,   9703,
   9511,   9319,   9126,   8932,   8739,   8545,   8351,   8156,
   7961,   7766,   7571,   7375,   7179,   6982,   6786,   6589,
   6392,   6195,   5997,   5799,   5601,   5403,   5205,   5006,
   4807,   4608,   4409,   4210,   4011,   3811,   3611,   3411,
   3211,   3011,   2811,   2610,   2410,   2209,   2009,   1808,
   1607,   1406,   1206,   1005,    804,    603,    402,    201,

      0,   -201,   -402,   -603,   -804,  -1005,  -1206,  -1406,
  -1607,  -1808,  -2009,  -2209,  -2410,  -2610,  -2811,  -3011,
  -3211,  -3411,  -3611,  -3811,  -4011,  -4210,  -4409,  -4608,
  -4807,  -5006,  -5205,  -5403,  -5601,  -5799,  -5997,  -6195,
  -6392,  -6589,  -6786,  -6982,  -7179,  -7375,  -7571,  -7766,
  -7961,  -8156,  -8351,  -8545,  -8739,  -8932,  -9126,  -9319,
  -9511,  -9703,  -9895, -10087, -10278, -10469, -10659, -10849,
 -11038, -11227, -11416, -11604, -11792, -11980, -12166, -12353,
 -12539, -12724, -12909, -13094, -13278, -13462, -13645, -13827,
 -14009, -14191, -14372, -14552, -14732, -14911, -15090, -15268,
 -15446, -15623, -15799, -15975, -16150, -16325, -16499, -16672,
 -16845, -17017, -17189, -17360, -17530, -17699, -17868, -18036,
 -18204, -18371, -18537, -18702, -18867, -19031, -19194, -19357,
 -19519, -19680, -19840, -20000, -20159, -20317, -20474, -20631,
 -20787, -20942, -21096, -21249, -21402, -21554, -21705, -21855,
 -22004, -22153, -22301, -22448, -22594, -22739, -22883, -23027,
 -23169, -23311, -23452, -23592, -23731, -23869, -24006, -24143,
 -24278, -24413, -24546, -24679, -24811, -24942, -25072, -25201,
 -25329, -25456, -25582, -25707, -25831, -25954, -26077, -26198,
 -26318, -26437, -26556, -26673, -26789, -26905, -27019, -27132,
 -27244, -27355, -27466, -27575, -27683, -27790, -27896, -28001,
 -28105, -28208, -28309, -28410, -28510, -28608, -28706, -28802,
 -28897, -28992, -29085, -29177, -29268, -29358, -29446, -29534,
 -29621, -29706, -29790, -29873, -29955, -30036, -30116, -30195,
 -30272, -30349, -30424, -30498, -30571, -30643, -30713, -30783,
 -30851, -30918, -30984, -31049, -31113, -31175, -31236, -31297,
 -31356, -31413, -31470, -31525, -31580, -31633, -31684, -31735,
 -31785, -31833, -31880, -31926, -31970, -32014, -32056, -32097,
 -32137, -32176, -32213, -32249, -32284, -32318, -32350, -32382,
 -32412, -32441, -32468, -32495, -32520, -32544, -32567, -32588,
 -32609, -32628, -32646, -32662, -32678, -32692, -32705, -32717,
 -32727, -32736, -32744, -32751, -32757, -32761, -32764, -32766
);

(*
  FIX_MPY() - fixed-point multiplication & scaling.
  Substitute inline assembly for hardware-specific
  optimization suited to a particluar DSP processor.
  Scaling ensures that result remains 16-bit.
*)
function FIX_MPY(a, b : smallint) : smallint;
var c : longint;
begin
  c := a * b;
  c := c div $8000;
  fix_mpy := c;
end;

(*
  fix_fft() - perform forward/inverse fast Fourier transform.
  fr[n],fi[n] are real and imaginary arrays, both INPUT AND
  RESULT (in-place FFT), with 0 <= n < 2**m; set inverse to
  0 for forward transform (FFT), or 1 for iFFT.
*)


var fr : array[0..511] of smallint;
    fi : array[0..511] of smallint;

function fix_fft(m : smallint; inverse : boolean) : smallint;

var mr, nn, i, j, l, k, istep, n, scale : smallint;
    qr, qi, tr, ti, wr, wi : smallint;
    shift : boolean;

begin
  n := 1 shl m;

  (* max FFT size = N_WAVE *)
  if n > N_WAVE then begin fix_fft := -1; exit; end;

  mr := 0;
  nn := n - 1;
  scale := 0;

  (* decimation in time - re-order data *)
  for m := 1 to nn do
  begin
    l := n;

    repeat
      l := l shr 1;
    until not(mr+l > nn);

    mr := (mr and (l-1)) + l;

    if not(mr <= m) then
    begin
      tr := fr[m]; fr[m] := fr[mr]; fr[mr] := tr;
      ti := fi[m]; fi[m] := fi[mr]; fi[mr] := ti;
    end;
  end;

  l := 1;
  k := LOG2_N_WAVE-1;

  while (l < n) do
  begin

    if inverse then
    begin

      (* variable scaling, depending upon data *)
      shift := false;
      for i := 0 to n-1 do
      begin
        j := abs(fr[i]); m := abs(fi[i]);
        if (j > $3FFF) or (m > $3FFF) then shift := true;
      end;
      if shift then inc(scale);

    end
    else
    begin
      (*
        fixed scaling, for proper normalization --
        there will be log2(n) passes, so this results
        in an overall factor of 1/n, distributed to
        maximize arithmetic accuracy.
      *)
      shift := true;
    end;

    (*
      it may not be obvious, but the shift will be
      performed on each data point exactly once,
      during this pass.
    *)
    istep := l shl 1;

    for m := 0 to l-1 do
    begin
      j := m shl k;

      (* 0 <= j < N_WAVE/2 *)
      wr :=  Sinewave[j+N_WAVE div 4];
      wi := -Sinewave[j];

      if inverse then wi := -wi;

      if shift then
      begin
        wr := wr div 2;
        wi := wi div 2;
      end;

      // for (i=m; i<n; i+=istep)
      i := m;
      while i < n do
      begin
        j := i + l;
        tr := FIX_MPY(wr,fr[j]) - FIX_MPY(wi,fi[j]);
        ti := FIX_MPY(wr,fi[j]) + FIX_MPY(wi,fr[j]);

        qr := fr[i];  qi := fi[i];

        if shift then
        begin
          qr := qr div 2;
          qi := qi div 2;
        end;

        fr[j] := qr - tr;  fi[j] := qi - ti;
        fr[i] := qr + tr;  fi[i] := qi + ti;

        i := i + istep;
      end;

    end;
    dec(k);
    l := istep;
  end;

  fix_fft := scale;
end;


// Reorder array from native order to math order and back

procedure fftswap(m : smallint);
var k, i, r, n : smallint;
begin
  n := 1 shl (m-1);
  for k := 0 to n - 1 do
  begin
    r := fr[k];  fr[k] := fr[k + n];  fr[k + n] := r;
    i := fi[k];  fi[k] := fi[k + n];  fi[k + n] := i;
  end;
end;

// A small test routine for FFT and iFFT

var x : smallint;
    input_r, input_i, output_r, output_i : array[0..511] of smallint;
    datafile : text;

begin
  for x := 0 to 511 do
  begin
    input_r[x] := sinewave[((x*16) and $1FF)] div 2;
    if (((x*16) shr 9) and 1) = 1 then input_r[x] := - input_r[x];
    input_r[x] := input_r[x] + 4096;
    input_i[x] := 0;
  end;

  fr := input_r;
  fi := input_i;
  writeln('Scale FFT: ', fix_fft(9, false));

  fftswap(9);

  fr[256 + 5] := 2000;
  fr[256 - 5] := 2000;

  output_r := fr;
  output_i := fi;
  fftswap(9);

  writeln('Scale iFFT: ', fix_fft(9, true));

  assign(datafile, 'FFT.dat');
  rewrite(datafile);
  for x := 0 to 511 do writeln(datafile, input_r[x], chr(9), input_i[x], chr(9), output_r[x], chr(9), output_i[x], chr(9), fr[x], chr(9), fi[x]);
  close(datafile);
end.

// fpc fix_fft.pas && ./fix_fft
// plot "FFT.dat" u 0:1 w l,  "FFT.dat" u 0:2 w l,  "FFT.dat" u 0:3 w l,  "FFT.dat" u 0:4 w l,  "FFT.dat" u 0:5 w l,  "FFT.dat" u 0:6 w l
// plot "FFT.dat" u 0:1 w lp, "FFT.dat" u 0:2 w lp, "FFT.dat" u 0:3 w lp, "FFT.dat" u 0:4 w lp, "FFT.dat" u 0:5 w lp, "FFT.dat" u 0:6 w lp
// plot "FFT.dat" u 0:1 w l,  "FFT.dat" u 0:2 w l,  "FFT.dat" u 0:5 w l,  "FFT.dat" u 0:6 w l,  "FFT.dat" u 0:3 w lp, "FFT.dat" u 0:4 w lp

