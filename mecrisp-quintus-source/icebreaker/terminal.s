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

.include "interrupts.s"
.include "../common/terminalhooks.s"

# -----------------------------------------------------------------------------
# Labels for a few hardware ports
# -----------------------------------------------------------------------------

.equ spictrl,       0x02000000  # SPI Flash Controller Config Register

.equ leds,          0x20000080
.equ uart_data,     0x20010000
.equ uart_flags,    0x20020000

# -----------------------------------------------------------------------------
uart_init:
# -----------------------------------------------------------------------------
  j dint # Just enable error interrupts and disable all other interrupt sources

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -----------------------------------------------------------------------------
  push x1

1:call serial_qemit
  popda x15
  beq x15, zero, 1b

  li x14, uart_data
  sw x8, 0(x14)
  drop

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key"
serial_key: # ( -- c ) Receive one character
# -----------------------------------------------------------------------------
  push x1

1:call serial_qkey
  popda x15
  beq x15, zero, 1b

  pushdatos
  li x14, uart_data
  lw x8, 0(x14)

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit?"
serial_qemit:  # ( -- ? ) Ready to send a character ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdatos
  li x8, uart_flags
  lw x8, 0(x8)
  andi x8, x8, 1

  sltiu x8, x8, 1 # 0<>
  addi x8, x8, -1

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key?"
serial_qkey:  # ( -- ? ) Is there a key press ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdatos
  li x8, uart_flags
  lw x8, 0(x8)
  andi x8, x8, 2

  sltiu x8, x8, 1 # 0<>
  addi x8, x8, -1

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "leds"
# -----------------------------------------------------------------------------
  li x14, leds
  sw x8, 0(x14)
  drop
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# -----------------------------------------------------------------------------
  j Reset
