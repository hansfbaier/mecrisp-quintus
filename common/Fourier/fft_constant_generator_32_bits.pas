
const N_WAVE  = 1024;
      // maximum = 32767; // = $7FFF: For 16 bit fixpoint fourier
      maximum = $7FFFFFFF; // = $7FFF: For 32 bit fixpoint fourier

var output : text;
    sine : extended;
    x : longint;

    linebreak : longint;

begin

  linebreak := 0;

  assign(output, 'FFT-Constants.dat');
  rewrite(output);

  write(output, ' ');

  for x := 0 to N_WAVE - (N_WAVE div 4) - 1 do
  begin
    sine := maximum * sin(2*pi* x / N_WAVE);

    if sine < 0 then write(output, round(sine+0.4999999):11, ', ')
                else write(output, round(sine-0.4999999):11, ', ');

    inc(linebreak);
    if linebreak mod     8  = 0 then begin writeln(output); write(output, ' '); end;
    if linebreak mod (32*8) = 0 then begin writeln(output); write(output, ' '); end;

  end;
  close(output);
end.

