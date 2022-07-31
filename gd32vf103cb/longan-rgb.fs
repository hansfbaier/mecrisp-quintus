\    Filename: longan-rgb-fs
\     Purpose: LED routines for the Longan Nano board
\         MCU: GD32VF103
\       Board: Longan-Nano
\        Core: Mecrisp-Quintus 0.29 with disassembler and
\              s31.32 fixpoint math prebuild by Matthias Koch.
\              MCU runs @ 8 MHz clock (internal RC).
\              All GPIO's and USART0 enabled by default.
\    Required: --
\ Recommended: --
\      Author: Wolfgang Strauss  wost@ewost.de
\    Based on: --
\     Licence: GPLv3
\   Changelog:
\   2020-07-26  create file
\
\ ==== Description =============================================================
\
\   The words in this source take care of the RGB-LED on the Longan Nano board.
\   Only needed bits are changed, so no side effects are to be expected.
\
\   Note:
\   Addresses are hardcoded, so no dependencies.
\   No dependency sounds good, but --- hardcoding is considered bad style,
\   so I have tried to make up for it with some commentary. :-)
\
\ ==== Summary of words ========================================================
\
\   longan-rgb-init  ( -- )  Prepare RGB LED of Longan Nano board
\
\   red-f    ( flag -- )   Switch LED.  true: LED on  false: LED off
\   green-f  ( flag -- )   Switch LED.  true: LED on  false: LED off
\   blue-f   ( flag -- )   Switch LED.  true: LED on  false: LED off
\
\   -red    ( -- )   Turn off red LED
\   +red    ( -- )   Turn on  red LED
\   -green  ( -- )   Turn off green LED
\   +green  ( -- )   Turn on  green LED
\   -blue   ( -- )   Turn off blue LED
\   +blue   ( -- )   Turn on  blue LED
\
\   red-toggle    ( -- )   Invert LED
\   green-toggle  ( -- )   Invert LED
\   blue-toggle   ( -- )   Invert LED
\
\ ==============================================================================

decimal  \ Default base

\ ----------------------------------------------------------------------
\   Little shiny words for RGB-LED on Sipeeds Longan Nano board
\ ----------------------------------------------------------------------

: red-f  ( flag -- )  \ Switch LED.  true: LED on  false: LED off
  1 13 lshift $4001100c ( PORTC_OCTL )  \ PC13 red LED, active low
  rot IF  bic!  ELSE  bis!  THEN  ;

: green-f  ( flag -- )  \ Switch LED.  true: LED on  false: LED off
  1 1 lshift $4001080c ( PORTA_OCTL )  \ PA1 green LED
  rot IF  bic!  ELSE  bis!  THEN  ;

: blue-f  ( flag -- )  \ Switch LED.  true: LED on  false: LED off
  1 2 lshift $4001080c ( PORTA_OCTL )  \ PA2 blue LED
  rot IF  bic!  ELSE  bis!  THEN  ;

\ Some shortcuts
: -red    ( -- )  0 red-f    ;
: +red    ( -- )  1 red-f    ;
: -green  ( -- )  0 green-f  ;
: +green  ( -- )  1 green-f  ;
: -blue   ( -- )  0 blue-f   ;
: +blue   ( -- )  1 blue-f   ;

: red-toggle  ( -- )  \ Invert LED
  1 13 lshift $4001100c ( PORTC_OCTL )  xor!  ;  \ PC13 red LED

: green-toggle  ( -- )  \ Invert LED
  1 1 lshift $4001080c ( PORTA_OCTL )   xor!  ;  \ PA1 green LED

: blue-toggle  ( -- )  \ Invert LED
  1 2 lshift $4001080c ( PORTA_OCTL )   xor!  ;  \ PA2 blue LED


: longan-rgb-init  ( -- )  \ Prepare RGB LED of Longan Nano board

  \ Switch off LEDs first to avoid a possible glitch
   \   when switching to output in the next step
  -red -green -blue

  \ Make pins PA1 (green) and PA2 (blue) outputs
  $40010800 ( PORTA_CTL0 ) @
  $fffff00f and
  $00000220 or               \ Mode 2: push/pull output, 2 MHz
  $40010800 ( PORTA_CTL0 ) !

  \ Make pin PC13 (red) an output
  $40011004 ( PORTC_CTL1 ) @
  $ff0fffff and
  $00200000 or               \ Mode 2: push/pull output, 2 MHz
  $40011004 ( PORTC_CTL1 ) !
;

\ ----------------------------------------------------------------------
\   Testing
\ ----------------------------------------------------------------------

\ longan-rgb-init    \ Call first to define needed outputs

\ -red -green -blue  \ Turn off all colors
\ +red +green +blue  \ Turn on  all colors

\ ----------------------------------------------------------------------
decimal  \ Restore default base
\ EOF longan-rgb.fs
