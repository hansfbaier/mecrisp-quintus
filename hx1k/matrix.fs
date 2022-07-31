\ -----------------------------------------------------------------------------

\ Paint on a LED matrix connected to FPGA.

\ Take care: Leakage currents can heavily influence the measurement.
\ Tiny currents ! Keep tracks clean and place board on a good insulator.
\ One LED has a junction capacitance in the 10-20 pF range, therefore, use short wires.

\ -----------------------------------------------------------------------------

\ Bits  7 -  0: PMOD
\ Bits 15 -  8: Header 1
\ Bits 23 - 16: Header 2

$400020 constant port-in
$400040 constant port-out
$400080 constant port-dir

\  Pinout and board layout:
\
\         /--------------------------------------
\        /                 Header 1:  76543210-+
\       /            ________              ++
\      /            |        |      R      --
\  [USB]  FT        |  FPGA  |    R G R    73   Ir
\  [USB]  DI        |        |      R      62   DA
\      \            |________|             51
\       \                                  40
\        \                 Header 2:  01234567-+
\         \--------------------------------------
\
\    Numbers are bit numbers
\    + is 3.3 V   - is GND
\    G Green LED  R Red LEDs

\ -----------------------------------------------------------------------------
\   8x8 LED matrix connected to Header 1 and Header 2
\ -----------------------------------------------------------------------------

\ $000100 Anode 1
\ $000200 Anode 2
\ $000400 Cathode 7
\ $000800 Anode 8
\ $001000 Cathode 5
\ $002000 Anode 3
\ $004000 Anode 5
\ $008000 Cathode 8

\ $010000 Cathode 6
\ $020000 Cathode 3
\ $040000 Anode 4
\ $080000 Cathode 1
\ $100000 Anode 6
\ $200000 Anode 7
\ $400000 Cathode 2
\ $800000 Cathode 4

create Cathodes 0-foldable

$080000 dup ,    \ Cathode 1
$400000 dup , or \ Cathode 2
$020000 dup , or \ Cathode 3
$800000 dup , or \ Cathode 4
$001000 dup , or \ Cathode 5
$010000 dup , or \ Cathode 6
$000400 dup , or \ Cathode 7
$008000 dup , or \ Cathode 8
        constant Cathodemask

create Anodes 0-foldable

$000100 dup ,    \ Anode 1
$000200 dup , or \ Anode 2
$002000 dup , or \ Anode 3
$040000 dup , or \ Anode 4
$004000 dup , or \ Anode 5
$100000 dup , or \ Anode 6
$200000 dup , or \ Anode 7
$000800 dup , or \ Anode 8
        constant Anodemask

\ -----------------------------------------------------------------------------
\   Display an image on the matrix
\ -----------------------------------------------------------------------------

8 buffer: image \ Eight bytes of image data

: display-matrix ( -- )
  0 port-out !
  $FFFF00 port-dir !
  8 0 do
    image i + c@
    8 0 do
      dup $80 and 0<>
      Anodes   i cells + @
      Cathodes j cells + @ Cathodemask xor
      or
      and
      port-out !
      2*
    loop
    drop
  loop
  0 port-out !
;

\ -----------------------------------------------------------------------------
\   Darkness measurement on rows and cols
\ -----------------------------------------------------------------------------

8 cells buffer: anodelines
8 cells buffer: cathodelines

: measurement ( -- )

  display-matrix \ Less flicker when displaying the image in between

  \ Set all cathodes high and all anodes low
  $FFFF00 port-dir !
  Cathodemask port-out !

  \ Wait a little bit for charging the LED junction capacitances
  \ while clearing the result buffer
  anodelines 8 cells 0 fill

  \ Anodes should be inputs
  Cathodemask port-dir !

  \ Note how long the lines are low
  32 0 do \ Maximum measurement
    port-in @
    8 0 do
      dup Anodes i cells + @ and
      0= 1 and anodelines i cells + +!
    loop
    drop
  loop

  display-matrix \ Less flicker when displaying the image in between

  \ Set all cathodes high and all anodes low
  $FFFF00 port-dir !
  Cathodemask port-out !

  \ Wait a little bit for charging the LED junction capacitances
  \ while clearing the result buffer
  cathodelines 8 cells 0 fill

  \ Cathodes should be inputs
  Anodemask port-dir !

  \ Note how long the lines are high
  32 0 do \ Maximum measurement
    port-in @
    8 0 do
      dup Cathodes i cells + @ and
      0<> 1 and cathodelines i cells + +!
    loop
    drop
  loop

  display-matrix \ Less flicker when displaying the image in between
;

\ -----------------------------------------------------------------------------
\   Drawing canvas
\ -----------------------------------------------------------------------------

: rawdata ( -- )

  $08.1c.3e.1c.1c.3e.08.14 swap image 2!
  ['] display-matrix hook-pause !

  begin
    cr cr
    measurement
    8 0 do   anodelines i cells + @ hex. cr loop cr
    8 0 do cathodelines i cells + @ hex. cr loop cr

    1000 0 do pause loop
  key? until
;

0 variable minimum
0 variable pos

: findminimum ( array-addr elements -- position )
  -1 minimum !
   0 pos !

  0 ?do
    dup i cells + @ dup minimum @ u< if minimum ! i pos ! else drop then
  loop
  drop

  pos @
;

: canvas ( -- )

  $08.1c.3e.1c.1c.3e.08.14 swap image 2!
  ['] display-matrix hook-pause !

  begin
    measurement

    cathodelines 8 findminimum ( x )
      anodelines 8 findminimum ( y )

    minimum @ 24 u< \ Bright enough
    if
      2dup 0. d= \ Paint corner to erase
      if
        ( 0. ) image 2!
      else \ Set pixel in image
        ( x y )
        $80 swap rshift
        swap image + cbis!
      then
    else
      2drop
    then

  key? until
;
