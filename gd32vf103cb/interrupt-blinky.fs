\    Filename: interrupt-blinky.fs
\     Purpose: Blinkenlights interrupt driven
\         MCU: GD32VF103
\       Board: Longan-Nano
\        Core: Mecrisp-Quintus 0.29 with disassembler and
\              s31.32 fixpoint math prebuild by Matthias Koch.
\              MCU runs @ 8 MHz clock (internal RC).
\              All GPIO's and USART0 enabled by default.
\    Required: - mtime.fs       \ RISC-V core timer words
\              - longan-rgb.fs  \ Manage the RGB-LED of the Longan Nano board
\ Recommended: --
\      Author: Wolfgang Strauss  wost@ewost.de
\    Based on: --
\     Licence: GPLv3
\   Changelog:
\   2020-07-26  create file
\
\ ==== Description =============================================================
\
\   In this example code, an interrupt driven blinking light (green LED) is
\   shown.
\   You can change the frequency on the fly or shut off the blinking altogether.
\
\   If you are not running your chip with the standard frequency (8 MHz), you
\   need to adjust the value for MS_COUNT (see below).
\
\ ==== Summary of words ========================================================
\
\   blinky-install   ( -- )      Installs handler, enables blinking of green LED
\                                  and sets frequency to 1 Hz
\
\   blinky-time-set  ( ms -- )   Set LED on-time in ms. Off-time is the same.
\                                  So "500 blinky-time-set" results in 1 Hz
\   blinky-on        ( -- )      Enables the blinking action
\   blinky-off       ( -- )      Disables the blinking action
\
\
\ ==============================================================================

decimal  \ Default base

$d2001000 constant VECTORCONFIG_BASE  \ Starting address of 87*4 
                                       \  ECLIC configuration registers
 %1  0 lshift constant PENDING       \ ECLIC interrupt on this vector pending
 %1  8 lshift constant ENABLED       \ ECLIC interrupt on this vector enabled
 %1 16 lshift constant VECTORED      \ ECLIC interrupt is vectored
%01 17 lshift constant RISING_EDGE   \ ECLIC trigger mode
%11 17 lshift constant FALLING_EDGE  \ ECLIC trigger mode
%00 17 lshift constant LEVEL         \ ECLIC trigger mode

\ Let's build some commonly used ECLIC configs

0 ENABLED     +
  VECTORED    +
  RISING_EDGE +
127 24 lshift +  constant VECTORED_RISING  \ with level set to 127

0 ENABLED      +
  VECTORED     +
  FALLING_EDGE +
127 24 lshift  +  constant VECTORED_FALLING  \ with level set to 127


2.000  2constant MS_COUNT  \ Timing for mtime. Assumed CPU clock: 8 MHz
                            \ Value is for 1 ms. (8.000.000/4/1.000)

0  variable blinky-flag  \ On/off flag

\ ------------------------------------------------------------------------------
\   User interface
\ ------------------------------------------------------------------------------

: blinky-time-set  ( ms -- )  \ Set LED on time in ms. Off time is the same.
  0. mtime-set     \ Reset mtime counter
  0  MS_COUNT ud*  \ Make ms a double and calculate the compare value
  mtimecmp-set      \  Set the compare register
;

: blinky-on  ( -- )  \ Enables the blinking action
  0. mtime-set     \ Reset mtime counter
  1 blinky-flag !  \ Enables blinky
;

: blinky-off  ( -- )  \ Disables the blinking action
  0. mtime-set     \ Reset mtime counter
  0 blinky-flag !  \ Disables blinky
  -green           \ Turn off green LED
;

\ ------------------------------------------------------------------------------
\   Interrupt service routine and installation
\ ------------------------------------------------------------------------------

: blinky-handler  ( -- )  \ Called on every mtime interrupt
  blinky-flag @  IF  green-toggle  THEN
  0. mtime-set  \ start over again
;

: blinky-install  ( -- )  \ Installs handler, enables blinking of green LED
                           \  and sets frequency to 1 Hz
  longan-rgb-init  \ Prepare GPIOs

  ['] blinky-handler irq-timer !  \ Install handler

  \ ECLIC settings for vector# 7: Rising edge, vectored,
   \  enabled, not pending, level set at 127.
  VECTORED_RISING VECTORCONFIG_BASE 7 4 * + !   \ 7 is the vector number

  mtime-unit-reset      \ Fill all timer registers with default values
  500 blinky-time-set   \ 500 ms delay
  blinky-on             \ Enables blinky
  eint                  \ Global interrupt enable

  cr ." Ready."
  cr ." Handler installed ..."
  cr
;

\ ------------------------------------------------------------------------------
\   Testing
\ ------------------------------------------------------------------------------

\   blinky-install       \ Installs handler, enables blinking and sets
\                         \  frequency to 1 Hz
\   blinky-off           \ Disables blinking
\   blinky-on            \ Enables  blinking
\   250 blinky-time-set  \ Set LED on/off time to 250 ms each. That gives 2 Hz

\ ------------------------------------------------------------------------------
decimal  \ Restore default base
\ EOF interrupt-blinky.fs
