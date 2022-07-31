
\ Advanced tools for interrupts on GD32VF103 by Wolfgang Strauss

\ ----------------------------------------------------------------------
\   ECLIC register constants (ECLIC: Enhanced Core Local Interrupt Controller)
\ ----------------------------------------------------------------------

$d2000000 constant ECLIC_cliccfg         \  8 bit read/write
$d2000004 constant ECLIC_clicinfo        \ 32 bit read only
$d200000b constant ECLIC_mth             \  8 bit read/write

\ The following 4 registers exist for each
\   of the 87 possible interrupt sources
$d2001000 constant ECLIC_clicintip[0]    \ - clicintip[86]    8 bit read/write
$d2001001 constant ECLIC_clicintie[0]    \ - clicintie[86]    8 bit read/write
$d2001002 constant ECLIC_clicintattr[0]  \ - clicintattr[86]  8 bit read/write
$d2001003 constant ECLIC_clicintctl[0]   \ - clicintctl[86]   8 bit read/write

\ ECLIC trigger modes
%01 constant RISING_EDGE
%11 constant FALLING_EDGE
%00 constant LEVEL
\ %10 constant LEVEL_TOO  \ Behaviour seems to be the same as LEVEL

\ ----------------------------------------------------------------------
\   ECLIC helper words
\ ----------------------------------------------------------------------

: int-disable  ( vector# -- )  \ Clear enable flag of interrupt[vector#]
  #0 swap   #2 lshift  ECLIC_clicintie[0] +  c!  ;

: int-enable  ( vector# -- )  \ Set enable flag of interrupt[vector#]
  #1 swap   #2 lshift  ECLIC_clicintie[0] +  c!  ;

: int-pending-clear  ( vector# -- )  \ Clear pending flag of interrupt[vector#]
  \ Only pending flags of edge-triggered interrupts can be set or cleared
  #0 swap   #2 lshift  ECLIC_clicintip[0] +  c!  ;

: int-pending-set  ( vector# -- )  \ Set pending flag of interrupt[vector#]
  \ Only pending flags of edge-triggered interrupts can be set or cleared
  #1 swap   #2 lshift  ECLIC_clicintip[0] +  c!  ;

: int-vectored  ( vector# -- )  \ Make interrupt[vector#] a vectored one
  #1 swap   #2 lshift  ECLIC_clicintattr[0] +  cbis!  ;  \ Set LSB

: int-nonvectored  ( vector# -- )  \ Make interrupt[vector#] a non-vectored one
  #1 swap   #2 lshift  ECLIC_clicintattr[0] +  cbic!  ;  \ Clear LSB

: int-trigger-assign  ( trigger-mode vector# -- )
  \ Set trigger mode of interrupt[vector#]
  #2 lshift  ECLIC_clicintattr[0] +  \ Calculate address in vector table
  dup  c@ #1 and  \ Only keep vector mode bit: vectored or non-vectored
  ( trigger-mode vector-addr value )
  rot  #1 lshift  or
  swap  c!  ;

: int-threshold-set  ( level vector# -- )
  \ Set threshold level of interrupt[vector#].
  \ Only if the level is greater than the level defined with "threshold-set"
  \ then this interrupt has a chance to be handled.
  #2 lshift  ECLIC_clicintctl[0] +  c!  ;

: nlbits-set  ( bits# -- )  \ Set global number of level bits
  \ Possible range: 0..4
  #1 lshift   ECLIC_cliccfg c!  ;

: threshold-set  ( level -- )  \ Set global threshold level
  \ Only interrupts with a greater level than this will be able to
  \ trigger an interrupt. Range: 0..255
  ECLIC_mth c!  ;

