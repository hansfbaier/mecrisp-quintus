\    Filename: gd32vf103-csr.fs
\     Purpose: Words for manipulating the Control and Status Registers
\                of the RISC-V core
\         MCU: GD32VF103
\       Board: -
\        Core: Mecrisp-Quintus 0.27 with disassembler and
\              s31.32 fixpoint math prebuild by Matthias Koch.
\              MCU runs @ 8 MHz clock (internal RC).
\              All GPIO's and USART0 enabled by default.
\    Required: -
\ Recommended: -
\      Author: Wolfgang Strauss  wost@ewost.de
\    Based on: mreg@: and mreg!:  by Matthias Koch
\     Licence: GPLv3
\   Changelog:
\   2020-07-01 File created
\ 

\ The "Control and Status Registers" of the RISC-V core
\ are only accessible through special machine codes.
\ The two following defining words take care of that.

: mreg@: ( csr -- )
  20 lshift >r
  :
  postpone dup
  $00002473 r> or , \ csrrs x8, csr, x0
  postpone ;
;

: mreg!: ( csr -- )
  20 lshift >r
  :
  $00041073 r> or , \ csrrw x0, csr, x8
  postpone drop
  postpone ;
;


\ *************************************
\  RISC-V  Standard CSR (Machine Mode)
\ *************************************

\  $F11  MRO  mvendorid      Machine Vendor ID Register
$F11 mreg@: mvendorid@  ( -- csr-value )

\  $F12  MRO  marchid        Machine Architecture ID Register
$F12 mreg@: marchid@  ( -- csr-value )

\  $F13  MRO  mimpid         Machine Implementation ID Register
$F13 mreg@: mimpid@  ( -- csr-value )

\  $F14  MRO  mhartid        Hart ID Register
$F14 mreg@: mhartid@  ( -- csr-value )

\  $300  MRW  mstatus        Machine Status Register
$300 dup  mreg@: mstatus@  ( -- csr-value )
          mreg!: mstatus!  ( csr-value -- )

\  $301  MRO  misa           Machine ISA Register
$301 mreg@: misa@  ( -- csr-value )

\  $304  MRW  mie            Machine Interrupt Enable Register
$304 dup  mreg@: mie@  ( -- csr-value )
          mreg!: mie!  ( csr-value -- )

\  $305  MRW  mtvec  Machine Trap-Vector Base-Address Register
$305 dup  mreg@: mtvec@  ( -- csr-value )
          mreg!: mtvec!  ( csr-value -- )

\  $307  MRW  mtvt  ECLIC Interrupt Vector Table Base Address
$307 dup  mreg@: mtvt@  ( -- csr-value )
          mreg!: mtvt!  ( csr-value -- )

\  $340  MRW  mscratch  Machine Scratch Register
$340 dup  mreg@: mscratch@  ( -- csr-value )
          mreg!: mscratch!  ( csr-value -- )

\  $341  MRW  mepc  Machine Exception Program Counter
$341 dup  mreg@: mepc@  ( -- csr-value )
          mreg!: mepc!  ( csr-value -- )

\  $342  MRW  mcause  Machine Cause Register
$342 dup  mreg@: mcause@  ( -- csr-value )
          mreg!: mcause!  ( csr-value -- )

\  $343  MRW  mtval  Machine Trap Value Register
$343 dup  mreg@: mtval@  ( -- csr-value )
          mreg!: mtval!  ( csr-value -- )

\  $344  MRW  mip  Machine Interrupt Pending Register
$344 dup  mreg@: mip@  ( -- csr-value )
          mreg!: mip!  ( csr-value -- )

\  $345  MRW  mnxti  The next interrupt handler address and enable modifier
$345 dup  mreg@: mnxti@  ( -- csr-value )
          mreg!: mnxti!  ( csr-value -- )

\  $346  MRO  mintstatus  Current Interrupt Levels
$346 mreg@: mintstatus@  ( -- csr-value )

\  $348  MRW  mscratchcsw  Scratch swap register for privileged mode
$348 dup  mreg@: mscratchcsw@  ( -- csr-value )
          mreg!: mscratchcsw!  ( csr-value -- )

\  $349  MRW  mscratchcswl  Scratch swap register for interrupt levels
$349 dup  mreg@: mscratchcswl@  ( -- csr-value )
          mreg!: mscratchcswl!  ( csr-value -- )

\  $B00  MRW  mcycle  Lower 32 bits of Cycle counter
$B00 dup  mreg@: mcycle@  ( -- csr-value )
          mreg!: mcycle!  ( csr-value -- )

\  $B80  MRW  mcycleh  Upper 32 bits of Cycle counter
$B80 dup  mreg@: mcycleh@  ( -- csr-value )
          mreg!: mcycleh!  ( csr-value -- )

\  $B02  MRW  minstret  Lower 32 bits of Instructions-retired counter
$B02 dup  mreg@: minstret@  ( -- csr-value )
          mreg!: minstret!  ( csr-value -- )

\  $B82  MRW  minstreth  Upper 32 bits of Instructions-retired counter
$B82 dup  mreg@: minstreth@  ( -- csr-value )
          mreg!: minstreth!  ( csr-value -- )


\ ***********************************
\  RISC-V  Standard CSR (User Mode)
\ ***********************************

\  $C00  URO  cycle  mcycle read only copy
$C00 mreg@: cycle@  ( -- csr-value )

\  $C80  URO  cycleh  mcycleh read only copy
$C80 mreg@: cycleh@  ( -- csr-value )

\  $C01  URO  time  mtime read only copy
$C01 mreg@: time@  ( -- csr-value )

\  $C81  URO  timeh  mtimeh read only copy
$C81 mreg@: timeh@  ( -- csr-value )

\  $C02  URO  instret  minstret read only copy
$C02 mreg@: instret@  ( -- csr-value )

\  $C82  URO  instreth  minstreth read only copy
$C82 mreg@: instreth@  ( -- csr-value )


\ ****************************
\   Bumblebee Customized CSR
\ ****************************

\  $320  MRW  mcountinhibit  Customized register for counters on & off
$320 dup  mreg@: mcountinhibit@  ( -- csr-value )
          mreg!: mcountinhibit!  ( csr-value -- )

\  $7C3  MRO  mnvec  NMI Entry Address
$7C3 mreg@: mnvec@  ( -- csr-value )

\  $7C4  MRW  msubm  Customized Register Storing Type of Trap
$7C4 dup  mreg@: msubm@  ( -- csr-value )
          mreg!: msubm!  ( csr-value -- )

\  $7D0  MRW  mmisc_ctl  Customized Register holding NMI Handler Entry Address
$7D0 dup  mreg@: mmisc_ctl@  ( -- csr-value )
          mreg!: mmisc_ctl!  ( csr-value -- )

\  $7D6  MRW  msavestatus  Customized Register holding the value of mstatus
$7D6 dup  mreg@: msavestatus@  ( -- csr-value )
          mreg!: msavestatus!  ( csr-value -- )

\  $7D7  MRW  msaveepc1  Customized Register holding the value of mepc for
\                          the first-level preempted NMI or Exception
$7D7 dup  mreg@: msaveepc1@  ( -- csr-value )
          mreg!: msaveepc1!  ( csr-value -- )

\  $7D8  MRW  msavecause1  Customized Register holding the value of mcause for
\                            the first-level preempted NMI or Exception
$7D8 dup  mreg@: msavecause1@  ( -- csr-value )
          mreg!: msavecause1!  ( csr-value -- )

\  $7D9  MRW  msaveepc2  Customized Register holding the value of mepc for
\                          the second-level preempted NMI or Exception
$7D9 dup  mreg@: msaveepc2@  ( -- csr-value )
          mreg!: msaveepc2!  ( csr-value -- )

\  $7DA  MRW  msavecause2  Customized Register holding the value of mcause for
\                            the second-level preempted NMI or Exception
$7DA dup  mreg@: msavecause2@  ( -- csr-value )
          mreg!: msavecause2!  ( csr-value -- )

\  $7EB  MRW  pushmsubm  Push msubm to stack

\  $7EC  MRW  mtvt2  ECLIC non-vectored interrupt handler address register
$7EC dup  mreg@: mtvt2@  ( -- csr-value )
          mreg!: mtvt2!  ( csr-value -- )

\  $7ED  MRW  jalmnxti  Jumping to next interrupt handler address
\                         and interrupt-enable register

\  $7EE  MRW  pushmcause  Push mcause to stack

\  $7EF  MRW  pushmepc  Push mepc to stack

\  $811  MRW  sleepvalue  WFI Sleep Mode Register
$811 dup  mreg@: sleepvalue@  ( -- csr-value )
          mreg!: sleepvalue!  ( csr-value -- )

\  $812  MRW  txevt  Send Event Register
$812 dup  mreg@: txevt@  ( -- csr-value )
          mreg!: txevt!  ( csr-value -- )

\  $810  MRW  wfe  Wait for Event Control Register
$810 dup  mreg@: wfe@  ( -- csr-value )
          mreg!: wfe!  ( csr-value -- )


\ ***********
\   TESTING
\ ***********

0 minstret!   \ Reset the Instruction Retirement Counter
minstret@ u.  \ How many instructions has the cpu executed since reset?


\ EOF gd32vf103-csr.fs
