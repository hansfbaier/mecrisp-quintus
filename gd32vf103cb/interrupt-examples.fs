
\ Examples for interrupts on GD32VF103

\ Research by Wolfgang Strauss, heavily modified by Matthias Koch

\ Requires interrupt-common.fs


\ ----------------------------------------------------------------------
\   RISC-V core timer registers
\ ----------------------------------------------------------------------

\ Timer unit of the RISC-V core. 32-bit access only, read/write
\ If mtime > mtimecmp then interrupt# 7 is generated.
\ mtime increments at a rate of SYS_CLK/4 (2 MHz @ default 8 MHz RC clock)
$d1000000 constant TIMER_mtime_lo     \ LSBs of 64-bit timer
$d1000004 constant TIMER_mtime_hi      \ MSBs of 64-bit timer
$d1000008 constant TIMER_mtimecmp_lo  \ LSBs of 64-bit compare register
$d100000c constant TIMER_mtimecmp_hi   \ MSBs of 64-bit compare register
$d1000ff8 constant TIMER_mstop        \ 0: timer increments (default)
                                       \ 1: timer is paused
$d1000ffc constant TIMER_msip  \ Software interrupt register
                                \ 0: no interrupt   1: interrupt# 3 is generated
           \ Yes, you read correctly. To trigger a software interrupt, which has
            \ nothing to do with timers whatsoever, you have to write to this
             \ unspectacular register hidden in the timer block.

\ ----------------------------------------------------------------------
\   RISC-V core timer words
\ ----------------------------------------------------------------------

: mtime-stop  ( -- )  \ Timer stops incrementing
  #1 TIMER_mstop !  ;

: mtime-run  ( -- )  \ Timer starts incrementing
  #0 TIMER_mstop !  ;

: mtime-set  ( d -- )  \ Load 64-bit timer with a double integer
  TIMER_mstop @ -rot   mtime-stop   TIMER_mtime_hi !   TIMER_mtime_lo !
  TIMER_mstop !  ;

: mtimecmp-set  ( d -- )  \ Load 64-bit compare register with a double integer
  TIMER_mstop @ -rot   mtime-stop   TIMER_mtimecmp_hi !   TIMER_mtimecmp_lo !
  TIMER_mstop !  ;

: mtime-unit-reset  ( -- )  \ Fill complete timer block with default values
  mtime-stop   #0. mtime-set   $ffff.ffff.ffff.ffff mtimecmp-set   mtime-run
  #0 TIMER_msip !  ;

: ud.mtime  ( -- )  \ Print out 64-bit timer as unsigned double
  TIMER_mstop @   mtime-stop   TIMER_mtime_lo @   TIMER_mtime_hi @   ud.
  TIMER_mstop !  ;

: ud.mtimecmp  ( -- )  \ Print out 64-bit compare register as unsigned double
  TIMER_mstop @   mtime-stop   TIMER_mtimecmp_lo @   TIMER_mtimecmp_hi @   ud.
  TIMER_mstop !  ;

: soft-interrupt  ( -- )   \  Triggers the software interrupt# 3
  #1 TIMER_msip !
  #0 TIMER_msip !  ;  \ Create a falling egde

\ -----------------------------------------------------------------------------
\   Special opcodes and routines for fault injection
\ -----------------------------------------------------------------------------

$12345673 constant OPCODE_illegal
$00000000 constant OPCODE_c.illegal
$00100073 constant OPCODE_ebreak
$00000073 constant OPCODE_ecall
$9002     constant OPCODE_c.ebreak

: illegal-opcode    ( -- )  \  Triggers exception with EXCODE# 2
  [ OPCODE_illegal , ] ;

: c.illegal-opcode  ( -- )  \  Triggers exception with EXCODE# 2
  [ OPCODE_c.illegal h, ] ;

: ebreak-opcode     ( -- )  \  Triggers exception with EXCODE# 3
  [ OPCODE_ebreak , ] ;

: c.ebreak-opcode   ( -- )  \  Triggers exception with EXCODE# 3
  [ OPCODE_c.ebreak h, ] ;

: ecall-opcode      ( -- )  \  Triggers exception with EXCODE# 11
  [ OPCODE_ecall , ] ;

: memory-error      ( -- )  \  Triggers memory access error interrupt# 17
  0 -2 ! ;                   \   Yes, an interrupt, not an exception!

\ ----------------------------------------------------------------------
\   Let it shine !
\ ----------------------------------------------------------------------

$40010800 constant PORTA_CRL

: green-flash  ( -- )  \ Flash the green LED at port PA1
  $44444424 PORTA_CRL !   100000 0 DO LOOP
  $44444444 PORTA_CRL !   100000 0 DO LOOP
;

\ -----------------------------------------------------------------------------
\   Test cases
\ -----------------------------------------------------------------------------

: test-1  ( -- )  \ Triggers a software interrupt

  ['] green-flash irq-software !         \ Install handler
  $7FC70100 vectorconfig-base 3 4 * + !   \ ECLIC settings for vector 3: Falling edge, vectored, enabled, not pending.
  eint                                     \ Global interrupt enable

  soft-interrupt \ Open fire!  Green LED should flash
;

\ -----------------------------------------------------------------------------

: tick ( -- ) ." Tick !" cr ;

: test-2  ( -- )  \ Triggers an mtime-timer interrupt

  ['] tick irq-timer !                   \ Install handler
  $7FC30100 vectorconfig-base 7 4 * + !   \ ECLIC settings for vector 7: Rising edge, vectored, enabled, not pending.
  eint                                     \ Global interrupt enable


  mtime-unit-reset       \ Fill all timer registers with default values
  1.000.000 mtimecmp-set  \ Should take 10 seconds to fire,
                           \ assuming a system clock of 8 MHz
  cr ." Waiting ..." cr
;

\ -----------------------------------------------------------------------------

: test-3  ( -- )  \ Installs custom exception handler and
                   \ executes an illegal opcode

  ['] tracing-exception-handler irq-fault !

  illegal-opcode
;

\ -----------------------------------------------------------------------------

: test-4 ( -- ) \ Provokes a memory fault
  memory-error
;

\ -----------------------------------------------------------------------------
