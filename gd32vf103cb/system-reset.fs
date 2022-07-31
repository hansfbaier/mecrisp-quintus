
\ System reset for GD32vf103

$e0042008 constant DBGMCU2
$e004200c constant DBGMCU2EN

: system-reset  ( -- )  \ Resets chip
  $4b5a6978 DBGMCU2EN !
  1         DBGMCU2   !
;
