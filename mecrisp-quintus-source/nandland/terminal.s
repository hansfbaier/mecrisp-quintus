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

.include "../common/terminalhooks.s"

# -----------------------------------------------------------------------------
# Labels for a few hardware ports
# -----------------------------------------------------------------------------

#################################################################################

# Mapped IO constants

.equ IO_BASE,         0x10000   # Base address of memory-mapped IO
.equ IO_LEDS,          4        # Lights
.equ IO_UART_DATA,     8        # USB UART data (read/write)
.equ IO_UART_CNTL,    16        # USB UART data (read/write)

################################################################################

# -----------------------------------------------------------------------------
uart_init:
# -----------------------------------------------------------------------------
  # Nothing to do.
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -----------------------------------------------------------------------------
  push x1

1:call serial_qemit
  popda x15
  beq x15, zero, 1b

  li x14, IO_BASE
  sw x8, IO_UART_DATA(x14)
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
  li x14, IO_BASE
  lw x8, IO_UART_DATA(x14)
  andi x8, x8, 0xFF

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit?"
serial_qemit:  # ( -- ? ) Ready to send a character ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdatos
  li x8, IO_BASE
  lw x8, IO_UART_CNTL(x8)
  andi x8, x8, 0x200

  sltiu x8, x8, 1 # 0=
  sub x8, zero, x8

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key?"
serial_qkey:  # ( -- ? ) Is there a key press ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdatos
  li x8, IO_BASE
  lw x8, IO_UART_CNTL(x8)
  andi x8, x8, 0x100

  sltiu x8, x8, 1 # 0<>
  addi x8, x8, -1

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "cycles" # ( -- u )
# -----------------------------------------------------------------------------
  pushdatos
  rdcycle x8
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# -----------------------------------------------------------------------------
  j Reset
