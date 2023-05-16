#
#    Mecrisp-Quintus - A native code Forth implementation for RISC-V
#    Copyright (C) 2018  Matthias Koch
#
#    This program is free software: you can redistribute it and/or modify
#    it under the terms of the GNU General Public License as published by
#    the Free Software Foundation, either version 3 of the License, or
#    (at your option) any later version.
#
#    This program is distributed in the hope that it will be useful,
#    but WITHOUT ANY WARRANTY; without even the implied warranty of
#    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
#    GNU General Public License for more details.
#
#    You should have received a copy of the GNU General Public License
#    along with this program.  If not, see <http://www.gnu.org/licenses/>.
#

# Interrupt initialisation and handling

.equ CP0_HWRENA,   $7
.equ CP0_BADVADDR, $8
.equ CP0_COUNT,    $9

.equ CP0_COMPARE,  $11

.equ CP0_STATUS,   $12
.equ CP0_INTCTL_1, $12 #
.equ CP0_SRSCTL_2, $12 #
.equ CP0_SRSMAP_3, $12 #

.equ CP0_CAUSE,    $13
.equ CP0_EPC,      $14

.equ CP0_PRID,     $15
.equ CP0_EBASE_1,  $15

.equ CP0_CONFIG,   $16 # CONFIG, CONFIG1, CONFIG2, CONFIG3.

.equ CP0_DEBUG,    $23
.equ CP0_DEPC,     $24

.equ CP0_ERROREPC, $30
.equ CP0_DESAVE,   $31

.equ INTSTAT, 0xBF881010

# -----------------------------------------------------------------------------
interrupt_init:
# -----------------------------------------------------------------------------

    # Initialisation for Interrupts. Similar to code by Paul Boddie: https://blogs.fsfe.org/pboddie/?p=1712

#   mfc0 x15, CP0_DEBUG
#   li x14, ~0x40000000 # DEBUG_DM
#   and x15, x15, x14
#   mtc0 x15, CP0_DEBUG

    li x15, 0x00400000 # STATUS_BEV  /* BEV = 1 or EBASE cannot be set */
    mtc0 x15, CP0_STATUS

    la x15, handler_base
    mtc0 x15, CP0_EBASE_1, 1  /* EBASE = exception_handler */

    li x15, 0x00000000
    mtc0 x15, CP0_STATUS

    li x15, 0x20  /* Must be non-zero or the CPU gets upset */
    mtc0 x15, CP0_INTCTL_1, 1 # Set vector spacing to 32 bytes

    li x15, 0x00800000 # CAUSE_IV  /* IV = 1 (use EBASE+0x200 for interrupts) */
    mtc0 x15, CP0_CAUSE

#   li x14, INTCON
#   li x15, 1<<12 # Multi-vectored mode
#   sw x15, 0(x14)

  ret

# -----------------------------------------------------------------------------

.include "interrupts-forth-regs.s" # Access to special MIPS registers from within Forth

# -----------------------------------------------------------------------------
  Definition Flag_visible, "eint?" # ( -- ) Are Interrupts enabled ?
# -----------------------------------------------------------------------------
  pushdatos
  mfc0 x8, CP0_STATUS # STATUS IE
  slli x8, x8, 31
  srai x8, x8, 31
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "eint"
eint:
# -----------------------------------------------------------------------------
  li x15, 0x00000001
  mtc0 x15, CP0_STATUS
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "dint"
dint:
# -----------------------------------------------------------------------------
  mtc0 zero, CP0_STATUS
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "wfi"
# -----------------------------------------------------------------------------
  wait
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "cycles" # Uptime in cycles, 32 bits
# -----------------------------------------------------------------------------
  pushdatos
  mfc0 x8, CP0_COUNT
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "unhandled" # Message for wild interrupts
unhandled:                             #   and handler for unused interrupts
# -----------------------------------------------------------------------------
  push x1

  write "\nUnhandled Interrupt "
  call trap_signature

  # Clear all "interrupt pending" flags:

  li x14, IFS0
  li x15, IFS1
  sw zero, 0(x14)
  sw zero, 0(x15)

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "fault" # Message for unhandled exceptions
fault:
# -----------------------------------------------------------------------------
  push x1

  write "\nUnhandled Exception "
  call trap_signature

  writeln "Quit."

  la x15, quit
  mtc0 x15, CP0_EPC

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "trap-signature"
trap_signature: # Let the user know what happened
# -----------------------------------------------------------------------------
  push x1

  write "[ status: "
  pushdatos
  mfc0 x8, CP0_STATUS
  call hexdot

  write "cause: "
  pushdatos
  mfc0 x8, CP0_CAUSE
  call hexdot

  write "epc: "
  pushdatos
  mfc0 x8, CP0_EPC
  call hexdot

# write "errorepc: "
# pushdatos
# mfc0 x8, CP0_ERROREPC
# call hexdot

  write "badvaddr: "
  pushdatos
  mfc0 x8, CP0_BADVADDR
  call hexdot

# write "intstat: "
# pushdatos
# li x8, INTSTAT
# lw x8, 0(x8)
# call hexdot

  write "ifs0: "
  pushdatos
  li x8, IFS0
  lw x8, 0(x8)
  call hexdot

  write "ifs1: "
  pushdatos
  li x8, IFS1
  lw x8, 0(x8)
  call hexdot

  writeln "]"

  pop x1
  ret

# -----------------------------------------------------------------------------
  .include "../common/irq-handler-mips.s"
# -----------------------------------------------------------------------------

initinterrupt fault, irq_fault, fault
initinterrupt collection, irq_collection, unhandled
