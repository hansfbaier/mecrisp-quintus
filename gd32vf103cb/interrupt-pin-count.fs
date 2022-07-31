\    Filename: interrupt-pin-count.fs
\     Purpose: Counting falling edges on pins, interrupt driven
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
\   2020-07-26  Create file
\   2020-08-15  Refinement and testing
\
\ ==== Description =============================================================
\
\   In this demo, the occurence of falling edges at pins PB5, PB6 and PB7 is
\   counted interrupt-driven. Each pin has its own counter.
\   Internal pull-ups are enabled. There is no debouncing.
\   So, if you use push buttons connected to ground, you are likely to get
\   multiple counts on each press.
\
\   Note:
\   The "drop trick" is used in this file.
\   For example, instead of writing  %0001000100010001 ...  witch is hard to
\   read and error prone, %0001.0001.0001.0001 drop ...  does the same, but is
\   easier to "scan". Using dots inside literals produce double precision
\   numbers and drop discards the not wanted high part. 
\
\ ==== Summary of user words ========================================================
\
\   counter-reset       ( -- )  \ Set all 3 counters to 0
\
\   .counter            ( -- )  \ Print counter values
\
\   pincounter-install  ( -- )  \ Installs handler
\
\ ==============================================================================

decimal  \ Default base


\ ------------------------------------------------------------------------------
\   Registers for pin-interrupt configuration
\ ------------------------------------------------------------------------------

\ EXTI registers
$40010400 constant EXTI_INTEN  \ INTerrupt ENable register
$40010404 constant EXTI_EVEN   \ EVent ENable register
$40010408 constant EXTI_RTEN   \ Rising edge Trigger ENable register
$4001040c constant EXTI_FTEN   \ Falling edge Trigger ENable register
$40010410 constant EXTI_SWIEV  \ SoftWare Interrupt EVent register
$40010414 constant EXTI_PD     \ PenDing register. Write 1 to clear

\ GPIOB registers
$40010c00 constant GPIOB_CTL0   \ General Purpose IO Port B ConTroL register 0
$40010c04 constant GPIOB_CTL1   \ General Purpose IO Port B ConTroL register 1
$40010c08 constant GPIOB_ISTAT  \ General Purpose IO Port B Input STATus
$40010c0c constant GPIOB_OCTL   \ General Purpose IO Port B Output ConTroL

\ AFIO registers
$40010008 constant AFIO_EXTISS0  \ EXTI Sources Selection reg. 0 (line 0..3)
$4001000c constant AFIO_EXTISS1  \ EXTI Sources Selection reg. 1 (line 4..7)
$40010010 constant AFIO_EXTISS2  \ EXTI Sources Selection reg. 2 (line 8..11)
$40010014 constant AFIO_EXTISS3  \ EXTI Sources Selection reg. 3 (line 12..15)

: exti-init  ( -- )  \ Prepare the pins for falling edge interrupts
  \ PB7  PB6  PB5  PB4
  %0001.0001.0001.0001 drop  AFIO_EXTISS1 !  \ %0001 -> port-B

  \ Set mode %1000 for pins PB5..PB7: inputs with pull-up or pull-down
  %1111.1111.1111 drop  20 lshift GPIOB_CTL0  bic!
  %1000.1000.1000 drop  20 lshift GPIOB_CTL0  bis!

  %111  5 lshift  GPIOB_OCTL  bis!  \ Select pull-ups for PB5..PB7

  %111  5 lshift  EXTI_FTEN   bis!  \ Falling edge trigger enable for PB5..PB7
  %111  5 lshift  EXTI_INTEN  bis!  \ Enable EXTI Interrupt for PB5..PB7
;


\ ------------------------------------------------------------------------------
\   ECLIC registers and configuration
\ ------------------------------------------------------------------------------

$d2001000 constant VECTORCONFIG_BASE  \ Starting address of 87*4 
                                       \  ECLIC configuration registers
 %1  0 lshift constant PENDING       \ ECLIC interrupt on this vector pending
 %1  8 lshift constant ENABLED       \ ECLIC interrupt on this vector enabled
 %1 16 lshift constant VECTORED      \ ECLIC interrupt is vectored
%01 17 lshift constant RISING_EDGE   \ ECLIC trigger mode
%11 17 lshift constant FALLING_EDGE  \ ECLIC trigger mode
%00 17 lshift constant LEVEL         \ ECLIC trigger mode

\ Let's build some commonly used ECLIC configs

0 ENABLED      +
  VECTORED     +
  LEVEL        +
127 24 lshift  +  constant VECTORED_LEVEL    \ with level set to 127

0 ENABLED      +
  VECTORED     +
  RISING_EDGE  +
127 24 lshift  +  constant VECTORED_RISING   \ with level set to 127

0 ENABLED      +
  VECTORED     +
  FALLING_EDGE +
127 24 lshift  +  constant VECTORED_FALLING  \ with level set to 127


\ ------------------------------------------------------------------------------
\   User interface
\ ------------------------------------------------------------------------------

0 0 0  3 nvariable counter  \ 3 counters. 1 each for pin interrupts PB5..PB7

: counter-reset  ( -- )  \ Set the 3 counters to 0
  counter  3 4 *  0  fill
;

: .counter  ( -- )  \ Print counter values
  cr ." Port-B5 counter: "   counter 0 cells +  @ .
  cr ." Port-B6 counter: "   counter 1 cells +  @ .
  cr ." Port-B7 counter: "   counter 2 cells +  @ .
  cr
;


\ ------------------------------------------------------------------------------
\   Interrupt service routine and installation
\ ------------------------------------------------------------------------------

: pincounter-handler  ( -- )  \ Called on every exti5 interrupt
  3 0  DO
    1  I 5 +  lshift  EXTI_PD bit@  IF  \ Is pending bit set?
      1  counter I cells +  +!          \ Increment corresponding counter
    THEN
  LOOP
  %111 5 lshift EXTI_PD bis!  \ Clear pending bits by writing 1's
;

: pincounter-install  ( -- )  \ Installs handler

  exti-init  \ Prepare pins for falling edge interrupts

  ['] pincounter-handler irq-exti5 !  \ Install handler

  \ ECLIC settings for vector# 42:
   \ Level triggered, vectored, enabled, not pending, level set to 127
  VECTORED_LEVEL VECTORCONFIG_BASE 42 4 * + !

  eint  \ Global interrupt enable

  cr ." Ready."
  cr ." Handler installed ..."
  cr
;


\ ------------------------------------------------------------------------------
\   Demo
\ ------------------------------------------------------------------------------

\ Connect push buttons to pins PB5, PB6 and PB7 to ground.
\ Button presses are counted interrupt driven. No debouncing.


\ pincounter-install  \ This prepares pins PB5 to PB7 and the interrupt system

\ counter-reset       \ Set all counters to 0

\ .counter            \ Print all counters


decimal  \ Restore default base
\ EOF interrupt-pin-count.fs
