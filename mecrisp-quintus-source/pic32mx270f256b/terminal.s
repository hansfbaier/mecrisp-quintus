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

# ------------------------------------------------------------------------
# Memory Initialization
# ------------------------------------------------------------------------

memory_init:

  li x14, BMXCON     # No wait states for RAM access
  li x15, 0x001F0001 # Bus fault exceptions still enabled according to reset value
  sw x15, 0(x14)

  li x14, BMXDKPBA   # Lowest 1 kb as data RAM. Must not be zero, 1 kb increments.
  li x15, 0x400      # Usually the RAM dictionary starts at $530 above begin of RAM.
  sw x15, 0(x14)

  li x14, BMXDUDBA   # Everything above shall be program RAM.
  li x15, 0x10000    # Change size if you port for a chip with less RAM
  sw x15, 0(x14)

  li x14, BMXDUPBA   # No user program area, everything reserved for kernel usage
  li x15, 0x10000    # Change size if you port for a chip with less RAM
  sw x15, 0(x14)

  ret



# ------------------------------------------------------------------------
uart_init:
# ------------------------------------------------------------------------
# RPA4 ==> U1RX
# RPB4 ==> U1TX
  # Set RPB4 as digital
  # PPS for UART1

  # UNLOCK CFGCON
  li x14, CFGCON
  lw x15, 0(x14)
  li x12, ~BIT13                 # IOLOCK bit 13
  and x15, x12, 0
  sw x15, 0(x14)

  li x14, RPB4R
  li x15, 0b0001
  sw x15, 0(x14)                  # RPB4 is TX
  li x14, U1RXR
  li x15, 0b0010
  sw x15, 0(x14)                  # RPA4 is RX

  li x14, CFGCON
  lw x15, 0(x14)
  ori x15, x15, BIT13             # set IOLOCK again
  sw x15, 0(x14)

  li x14, U1BRG
  li x15, 12                     # baud is 115,200
  sw x15, 0(x14)                  # assumes PBCLK = 24MHz

  li x14, U1STA
  sw zero, 0(x14)               # deactivate to change U1MODE

  li x14, U1MODE
  li x15, (1 << 15)              # bit 15, ON: UARTx enable, 8N1
  sw x15, 0(x14)

  li x14, U1STA
  li x15, (0b101 << 10)
  sw x15, 0(x14)                 # enable transmit and receive


  ret


# -------------------------------------------------------------------
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -------------------------------------------------------------------

  push x1

1:call serial_qemit
  popda x15
  beq x15, zero, 1b

  popda x15
  li x14, U1TXREG
  sw x15, 0(x14)                  # sp -> U1TXREG

  pop x1
  ret


# ------------------------------------------------------------------------
  Definition Flag_visible, "serial-key"
serial_key: # ( -- c ) Receive one character
# ------------------------------------------------------------------------

  push x1

1:call serial_qkey
  popda x15
  beq x15, zero, 1b

  li x14, U1RXREG
  lw x15, 0(x14)
  pushda x15                     # ( -- U1RXREG )

  pop x1
  ret

# ------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit?"
serial_qemit:  # ( -- ? ) Ready to send a character ?
# ------------------------------------------------------------------------

  push x1
  call pause

  pushdatos
  li x8, U1STA
  lw x8, 0(x8)
  srli x8, x8, 9 # isolate UTXBF (transmit buffer full)
  andi x8, x8, 1

  sltiu x8, x8, 1 # 0=
  addi x8, x8, -1
  inv x8

  pop x1
  ret

# ------------------------------------------------------------------------
  Definition Flag_visible, "serial-key?"
serial_qkey:  # ( -- ? ) Is there a key press ?
# ------------------------------------------------------------------------
# U1RXREG should be cleared by user

  push x1
  call pause

  pushdatos
  li x8, U1STA
  lw x8, 0(x8)
  andi x8, x8, 1 # isolate URXDA (receive buffer flag bit)

  sltiu x8, x8, 1 # 0<>
  addi x8, x8, -1

  pop x1
  ret

# ------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# ------------------------------------------------------------------------
  j Reset




# vim: set shiftwidth=2:
