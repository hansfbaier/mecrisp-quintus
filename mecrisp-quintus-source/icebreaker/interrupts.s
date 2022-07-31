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

# -----------------------------------------------------------------------------
  Definition Flag_visible, "mepc" # ( -- x )
interrupt_location:
# -----------------------------------------------------------------------------
  pushda x30
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "mcause" # ( -- x )
interrupt_cause:
# -----------------------------------------------------------------------------
  pushda x31
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "maskirq" # ( new -- old )
maskirq:
# -----------------------------------------------------------------------------
  .word 0x0600600B | reg_tos << 7 | reg_tos << 15 # maskirq zero, x15
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "waitirq" # ( -- x )
waitirq:
# -----------------------------------------------------------------------------
  pushdatos
  .word 0x0800400B | reg_tos << 7
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "eint" # ( -- x )
eint:
# -----------------------------------------------------------------------------
  # No interrupts masked - all active
  .word 0x0600600B | 0 << 7 | 0 << 15 # maskirq zero, zero
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "dint" # ( -- x )
dint:
# -----------------------------------------------------------------------------
  li x15, -8        # Enable error interrupts to prevent trap in case of failure
  .word 0x0600600B | 0 << 7 | reg_tmp1 << 15 # maskirq zero, x15
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "unhandled" # Message for wild interrupts
unhandled:                             #   and handler for unused interrupts
# -----------------------------------------------------------------------------
  push x1
  write "Unhandled Interrupt "
  call interrupt_cause
  call hexdot
  write "at "
  call interrupt_location
  call hexdot
  writeln "!"
  pop x1
  ret

# -----------------------------------------------------------------------------
  .macro mret
    .word 0x0400000B # retirq
  .endm

  .include "../common/irq-handler.s"
# -----------------------------------------------------------------------------

initinterrupt collection, irq_collection, unhandled
