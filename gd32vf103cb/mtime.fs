\    Filename: mtime.fs
\     Purpose: Utility routines for the RISC-V core timer "mtime"
\         MCU: GD32VF103
\       Board: --
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
\   2020-07-26  WSW001 Create File
\   2020-07-26  WSW002 Rewrite ud.mtime
\
\ ==== Description =============================================================
\
\   The core timer "mtime" is a nice and easy to use unit.
\   It starts counting automatically afer a system reset, so you don't need to
\   initialize the timer to use it. The length of the timer is 64 bits.
\   This is plenty. At a maximum clock rate it overflows in about 20000 years!
\
\ ==== Summary of words ========================================================
\
\   mtime-unit-reset ( -- )     Fill complete timer block with default values
\
\   mtime-stop       ( -- )     Timer stops  incrementing
\   mtime-run        ( -- )     Timer starts incrementing
\
\   mtime-set        ( d -- )   Load 64-bit timer with a double integer
\   mtimecmp-set     ( d -- )   Load 64-bit compare register with a double int
\
\   ud.mtime         ( -- )     Print 64-bit timer as unsigned double
\   ud.mtimecmp      ( -- )     Print 64-bit compare register as unsigned double
\
\ ==============================================================================

decimal  \ Default base

\ ------------------------------------------------------------------------------
\   Timer unit constants
\ ------------------------------------------------------------------------------

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

\ ------------------------------------------------------------------------------
\   RISC-V core-timer words
\ ------------------------------------------------------------------------------

: mtime-stop  ( -- )  \ Timer stops incrementing
  1 TIMER_mstop !  ;

: mtime-run  ( -- )  \ Timer starts incrementing
  0 TIMER_mstop !  ;

: mtime-set  ( d -- )  \ Load 64-bit timer with a double integer
  TIMER_mstop @ -rot   mtime-stop   TIMER_mtime_hi !   TIMER_mtime_lo !
  TIMER_mstop !  ;

: mtimecmp-set  ( d -- )  \ Load 64-bit compare register with a double integer
  TIMER_mstop @ -rot   mtime-stop   TIMER_mtimecmp_hi !   TIMER_mtimecmp_lo !
  TIMER_mstop !  ;

: mtime-unit-reset  ( -- )  \ Fill complete timer block with default values
  mtime-stop   0. mtime-set   $ffff.ffff.ffff.ffff mtimecmp-set   mtime-run
  0 TIMER_msip !  ;

: ud.mtime  ( -- )  \ Print out 64-bit timer as unsigned double     (WSW002)
  BEGIN
    TIMER_mtime_hi @   TIMER_mtime_lo @   swap dup  ( lo hi hi )
    TIMER_mtime_hi @  <>  \ Overflow detection
  WHILE
    2drop
  REPEAT
  ud.  ;

: ud.mtimecmp  ( -- )  \ Print out 64-bit compare register as unsigned double
  TIMER_mtimecmp_lo @   TIMER_mtimecmp_hi @   ud.  ;

\ ------------------------------------------------------------------------------
\   Testing
\ ------------------------------------------------------------------------------

\   : test  ( -- )
\     10 0 DO
\       cr  ud.mtime  \ Print 64-bit value of counter mtime as unsigned double
\     LOOP
\     cr
\   ;
\
\   0. mtime-set  ud.mtime  \ Load 64-bit timer with 0. (double) and print
\   mtime-stop
\   0. mtime-set  ud.mtime  \ Load 64-bit timer with 0. (double) and print
\   mtime-run
\
\   test

\ ------------------------------------------------------------------------------
decimal  \ Back to default base
\ EOF mtime.fs
