\ xy-hard.txt
\ Part of pixelmaler-v0.1 for Mecrisp-Quintus - A native code Forth implementation for RISC-V
\ Copyright (C) 2018  Matthias Koch
\ display longan nano
\ MB March 2020

\ The words from xy.txt now hardcoded. So you don't need to have
\ the assembler included.
\ Comments are in xy.txt

\ Later on I have to do some calculations with xy-coordinates.
\ So here are some words to ease it.
\ the words come in three flavors:
\ 1. xy-high-level.txt: defined in high-level, no advantage
\ in speed but better legibility
\ 2. File xy.txt: defined with Matthias's inline assembler -- more speed!
\ 3. This file xy-hard.txt: hard coded - if you won't have
\    the assembler installed.
\ Use it to your convenience.



\ A hardcode example:
\ : us ( u -- )  2* 0 ?do [ $0001 h, ] loop ; \ 8 MHz, c.nop for 4 cycles/loop run.



base @ 
hex
: xywh+
    [
    a783 h, 0044 h, 0433 h, 00f4 h,
    a783 h, 0084 h, a803 h, 0004 h,
    87b3 h, 0107 h, a023 h, 00f4 h,
  ]
;


: xy-minmax
    [
    A783 h, 0044 h, C863 h, 0087 h,
    0713 h, 0004 h, 8413 h, 0007 h,
    A223 h, 00E4 h, A783 h, 0084 h,
    A703 h, 0004 h, C663 h, 00E7 h,
    A423 h, 00E4 h, A023 h, 00F4 h,
    ]
;


: xy-
    [
    A783 h, 0044 h, 8433 h, 4087 h,
    A783 h, 0084 h, A803 h, 0004 h,
    87B3 h, 4107 h, 8493 h, 0084 h,
    A023 h, 00F4 h,
    ]
;
: xywh-
    [
    A783 h, 0044 h, 8433 h, 4087 h,
    A783 h, 0084 h, A803 h, 0004 h,
    87B3 h, 4107 h, A023 h, 00F4 h,
    ]
;

: xy+
    [
    A783 h, 0044 h, 0433 h, 00F4 h,
    A783 h, 0084 h, A803 h, 0004 h,
    87B3 h, 0107 h, 8493 h, 0084 h,
    A023 h, 00F4 h,
    ]
;

base !
