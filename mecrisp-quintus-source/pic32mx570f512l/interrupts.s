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

# Interrupt handling and CP0 register access

.equ CP0_HWRENA, $7
.equ CP0_BADVADDR, $8
.equ CP0_COUNT, $9

.equ CP0_COMPARE, $11

.equ CP0_STATUS, $12
.equ CP0_INTCTL_1, $12
.equ CP0_SRSCTL_2, $12
.equ CP0_SRSMAP_3, $12

.equ CP0_CAUSE, $13
.equ CP0_EPC, $14

.equ CP0_PRID, $15
.equ CP0_EBASE_1, $15

.equ CP0_CONFIG, $16 # CONFIG, CONFIG1, CONFIG2, CONFIG3.

.equ CP0_DEBUG, $23
.equ CP0_DEPC, $24

.equ CP0_ERROREPC, $30
.equ CP0_DESAVE, $31

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-hwrena@"
  pushdatos
  mfc0 x8, CP0_HWRENA
  ret

  Definition Flag_visible, "cp0-hwrena!"
  mtc0 x8, CP0_HWRENA
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-badvaddr@"
  pushdatos
  mfc0 x8, CP0_BADVADDR
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-count@"
  pushdatos
  mfc0 x8, CP0_COUNT
  ret

  Definition Flag_visible, "cp0-count!"
  mtc0 x8, CP0_COUNT
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-compare@"
  pushdatos
  mfc0 x8, CP0_COMPARE
  ret

  Definition Flag_visible, "cp0-compare!"
  mtc0 x8, CP0_COMPARE
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-status@"
  pushdatos
  mfc0 x8, CP0_STATUS
  ret

  Definition Flag_visible, "cp0-status!"
  mtc0 x8, CP0_STATUS
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-intctl@"
  pushdatos
  mfc0 x8, CP0_INTCTL_1, 1
  ret

  Definition Flag_visible, "cp0-intctl!"
  mtc0 x8, CP0_INTCTL_1, 1
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-srsctl@"
  pushdatos
  mfc0 x8, CP0_SRSCTL_2, 2
  ret

  Definition Flag_visible, "cp0-srsctl!"
  mtc0 x8, CP0_SRSCTL_2, 2
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-srsmap@"
  pushdatos
  mfc0 x8, CP0_SRSMAP_3, 3
  ret

  Definition Flag_visible, "cp0-srsmap!"
  mtc0 x8, CP0_SRSMAP_3, 3
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-cause@"
interrupt_cause:
  pushdatos
  mfc0 x8, CP0_CAUSE
  ret

  Definition Flag_visible, "cp0-cause!"
  mtc0 x8, CP0_CAUSE
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-epc@"
interrupt_location:
  pushdatos
  mfc0 x8, CP0_EPC
  ret

  Definition Flag_visible, "cp0-epc!"
  mtc0 x8, CP0_EPC
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-prid@"
  pushdatos
  mfc0 x8, CP0_PRID
  ret


# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-ebase@"
  pushdatos
  mfc0 x8, CP0_EBASE_1, 1
  ret

  Definition Flag_visible, "cp0-ebase!"
  mtc0 x8, CP0_EBASE_1, 1
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-config@"
  pushdatos
  mfc0 x8, CP0_CONFIG
  ret

  Definition Flag_visible, "cp0-config!"
  mtc0 x8, CP0_CONFIG
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-config1@"
  pushdatos
  mfc0 x8, CP0_CONFIG, 1
  ret

  Definition Flag_visible, "cp0-config2@"
  pushdatos
  mfc0 x8, CP0_CONFIG, 2
  ret

  Definition Flag_visible, "cp0-config3@"
  pushdatos
  mfc0 x8, CP0_CONFIG, 3
  ret


# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-debug@"
  pushdatos
  mfc0 x8, CP0_DEBUG
  ret

  Definition Flag_visible, "cp0-debug!"
  mtc0 x8, CP0_DEBUG
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-depc@"
  pushdatos
  mfc0 x8, CP0_DEPC
  ret

  Definition Flag_visible, "cp0-depc!"
  mtc0 x8, CP0_DEPC
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-errorepc@"
  pushdatos
  mfc0 x8, CP0_ERROREPC
  ret

  Definition Flag_visible, "cp0-errorepc!"
  mtc0 x8, CP0_ERROREPC
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-desave@"
  pushdatos
  mfc0 x8, CP0_DESAVE
  ret

  Definition Flag_visible, "cp0-desave!"
  mtc0 x8, CP0_DESAVE
  drop
  ret





# -----------------------------------------------------------------------------
  Definition Flag_visible, "eint?" # ( -- ) Are Interrupts enabled ?
# -----------------------------------------------------------------------------
  pushdatos
  mfc0 x8, CP0_STATUS
  andi x8, x8, 0x00000001 # STATUS_IE
  sltiu x8, x8, 1
  addi x8, x8, -1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "eint"
eint:
# -----------------------------------------------------------------------------
  li x15, 0x0000FC01
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
  write "Unhandled Interrupt "
  call interrupt_cause
  call hexdot
  writeln "!"
  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "fault" # Message for unhandled exceptions
fault:
# -----------------------------------------------------------------------------
  push x1
  write "Unhandled Exception "
  call interrupt_cause
  call hexdot
  write "at "
  call interrupt_location
  call hexdot
  writeln "!"
  pop x1
  ret

# -----------------------------------------------------------------------------
  .include "../common/irq-handler-mips.s"
# -----------------------------------------------------------------------------

initinterrupt fault, irq_fault, fault
initinterrupt collection, irq_collection, unhandled
