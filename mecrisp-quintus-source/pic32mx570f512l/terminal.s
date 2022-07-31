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

.include "pic32.s"

# -----------------------------------------------------------------------------
uart_init:
# -----------------------------------------------------------------------------

  # Memory initialisation to make RAM executable

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


  # Remove analogue features from pins.
  li x14, ANSELD
  sw zero, 0(x14)

  # Set LED pins as outputs.
  li x14, TRISD
  li x15, ~(1<<6 | 1<<2 | 1<<1 | 1<<0) # Set RD0 (red) RD1 (yellow) and RD2 (green) as outputs, and RD6 for UART connection, too.
  sw x15, 0(x14)

  # Enable pullup resistors for buttons
 # li x14, CNPUD
 # li x15, (1<<13 | 1<<7 | 1<<6)
 # sw x15, 0(x14)

  # Clear outputs, set UART wire high.
  li x14, PORTD
  li x15, 1<<6
  sw x15, 0(x14)

  ret

# -----------------------------------------------------------------------------
delay_half_bit:
# -----------------------------------------------------------------------------
  li x15, 68 # 4 MHz / 3 cycles for each loop run / 2 for half-bit-delay / 9600 Baud = 68
1:addiu x15, x15, -1
  bnez x15, 1b
  ret

# -----------------------------------------------------------------------------
sample_rx: # Get RX pin state into LSB of x15
# -----------------------------------------------------------------------------
  li x15, PORTD
  lw x15, 0(x15)
  srli x15, x15, 7  # Shift RD7 to LSB
  andi x15, x15, 1
  ret

# -----------------------------------------------------------------------------
tx_bit: # Transmit LSB of x15
# -----------------------------------------------------------------------------
  push x1

  andi x15, x15, 1
  slli x15, x15, 6 # Shift LSB to RD6 for UART connection

  li x14, PORTD
  sw x15, 0(x14)

  call delay_half_bit
  call delay_half_bit

  pop x1
  ret

# -----------------------------------------------------------------------------
rx_bit: # Receive one bit
# -----------------------------------------------------------------------------
  push x1
  call delay_half_bit
  call delay_half_bit
  call sample_rx
  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -----------------------------------------------------------------------------
  push x1

1:call serial_qemit
  popda x15
  beq x15, zero, 1b


  # --------
  li x15, 0              # Start bit
  call tx_bit

  srli x15, x8, 0
  call tx_bit

  srli x15, x8, 1
  call tx_bit

  srli x15, x8, 2
  call tx_bit

  srli x15, x8, 3
  call tx_bit

  srli x15, x8, 4
  call tx_bit

  srli x15, x8, 5
  call tx_bit

  srli x15, x8, 6
  call tx_bit

  srli x15, x8, 7
  call tx_bit

  li x15, 1              # Stop bit
  call tx_bit
  # --------

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

   # --------
1:call sample_rx        # Wait for start bit
  bne x15, zero, 1b

  call delay_half_bit   # Advance to the middle of the bit time

  call rx_bit
  slli x8, x15, 0

  call rx_bit
  slli x15, x15, 1
  or x8, x8, x15

  call rx_bit
  slli x15, x15, 2
  or x8, x8, x15

  call rx_bit
  slli x15, x15, 3
  or x8, x8, x15

  call rx_bit
  slli x15, x15, 4
  or x8, x8, x15

  call rx_bit
  slli x15, x15, 5
  or x8, x8, x15

  call rx_bit
  slli x15, x15, 6
  or x8, x8, x15

  call rx_bit
  slli x15, x15, 7
  or x8, x8, x15

  call rx_bit     # Stop bit, to get timing right
  # --------

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit?"
serial_qemit:  # ( -- ? ) Ready to send a character ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdaconst -1

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key?"
serial_qkey:  # ( -- ? ) Is there a key press ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdaconst -1

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# -----------------------------------------------------------------------------
  j Reset
