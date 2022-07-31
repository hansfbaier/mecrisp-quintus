
\ Common tools for interrupts on GD32VF103

\ Research done for this by Wolfgang Strauss, heavily modified by Matthias Koch

\ Requires dictionary-tools.txt

\ ----------------------------------------------------------------------
\   ECLIC register constants (Enhanced Core Local Interrupt Controller)
\ ----------------------------------------------------------------------

$d2000000 constant ECLIC_cliccfg    \  8 bit read/write : Global threshold level. Range: 0..255
                                    \ Only interrupts with a greater level than this will be able to trigger an interrupt.

$d2000004 constant ECLIC_clicinfo   \ 32 bit read only

$d200000b constant ECLIC_mth        \  8 bit read/write : Bits 3:1 Global number of level bits,  Possible range: 0..4


\ The following 4 registers exist for each
\   of the 87 possible interrupt sources

$d2001000 constant vectorconfig-base

0 constant vectorconfig-ip   \ Interrupt Pending:    0: Not Pending, 1: Pending
1 constant vectorconfig-ie   \ Interrupt Enable:     0: Disabled,    1: Enabled
2 constant vectorconfig-attr \ Interrupt Attributes  0: Non-Vectored 1: Vectored   Bits 2:1 Trigger on 1: Rising Edge, 3: Falling Edge, 0: Level, 2: Level, too ?
3 constant vectorconfig-ctl  \ Interrupt Control     Interrupt threshold, range 0 to 255. Usually set to 127 = $7F.

\ Examples:
\ To configure timer interrupt 7 as vectored, enabled, not currently pending, sensitive to rising edges and with a threshold of 127:
\ $7FC30100 vectorconfig-base 7 4 * + !

\ To disable it:
\ 0 vectorconfig-base 7 4 * + !

\ With vectored interrupts, the pending flag is cleared automatically by hardware.
\ In non-vectored more, the pending flag needs to be cleared manually, which can be done atomically:
\ 0 vectorconfig-base 7 4 * + vectorconfig-ip + c!

\ -----------------------------------------------------------------------------
\  Trace of the return stack entries
\ -----------------------------------------------------------------------------

\ Call trace on return stack.

\ Beware: This searches for the closest dictionary entry points to the addresses on the return stack
\         and may give random results for values that aren't return addresses.
\         I assume that users can decide from context which ones are correct.

: calltrace ( -- )
  cr
  rdepth 0 do
    i hex. i 2+ rpick dup hex. traceinside. cr
  loop
;

\ ----------------------------------------------------------------------
\   Custom handler for tracing exceptions
\ ----------------------------------------------------------------------

: tracing-exception-handler ( -- ) \ Try your very best to help tracing unhandled interrupt causes...
  cr cr
  fault
  cr
  h.s
  cr
  ." Calltrace:" calltrace
;

\ Install this handler by adding this line to your "init":
\ ['] tracing-exception-handler irq-fault !

\ ----------------------------------------------------------------------
\   Print complete vector configuration for debugging
\ ----------------------------------------------------------------------

: d.r ( d n -- )
    >r
    dup >r dabs <# #s r> sign #>
    r> over - spaces type
;

: .r ( n1 n2 -- ) >r s>d r> d.r ;

: u.r ( u n -- ) 0 swap d.r ;

: vectors ( -- ) \ Print the current configuration of all interrupt vectors
  cr
  ." Exceptions:" 27 spaces
  ." irq-fault" irq-fault @

          code>link ?dup
          if
            ."  --> " link>name ctype \ Name of the currently installed handler
          then
  cr
  ." Non-Vectored Interrupts:" 14 spaces
  ." irq-nonvector" irq-nonvector @

          code>link ?dup
          if
            ."  --> " link>name ctype \ Name of the currently installed handler
          then
  cr

  87 0 do
    i hex. ." : " \ Vector number

    i 4 * vectorconfig-base + @

    dup hex.

    dup 1 and if ." P " \ Pending
            else ."   " then

    dup $100 and if ." E " else \ Enabled
                    ."   " then

    dup $10000 and if ." Vec " \ Vectored
                 else ."     " then

    dup 17 rshift 3 and \ Sensitivity
    case
      1 of ." Rise  " endof
      3 of ." Fall  " endof
           ." Level "

    endcase

    24 rshift 3 u.r space \ Threshold

    i 4 * @ inside-code>link ?dup \ Get vector from the vector table starting at address 0
    if
      dup link>name ctype     \ Hook for this vector
          link>code execute @  \ Fetch currently installed handler address

          code>link ?dup
          if
            ."  --> " link>name ctype \ Name of the currently installed handler
          then
    then

    cr

  loop
;

\ ----------------------------------------------------------------------
