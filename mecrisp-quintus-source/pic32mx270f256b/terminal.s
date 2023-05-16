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

# ------------------------------------------------------------------------
# Memory Initialization
# ------------------------------------------------------------------------

memory_init:

  li x14, BMXCON     # No wait states for RAM access
# li x15, 0x001F0001 # Bus fault exceptions still enabled according to reset value
  li x15, 0x00000001 # Bus fault exceptions disabled
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
#  Pinout
# ------------------------------------------------------------------------
#
#              /MCLR  1  v 28  AVdd
#         RPA0        2    27  AVss
#         RPA1        3    26        RPB15
#         RPB0        4    25        RPB14
#         RPB1        5    24        RPB13
#         RPB2        6    23  Vusb
#         RPB3        7    22        RPB11
#               Vss   8    21        RPB10
#         RPA2        9    20  Vcap
#         RPA3       10    19  Vss
#         RPB4       11    18        RPB9
#         RPA4       12    17        RPB8
#               Vdd  13    16        RPB7
#         RPB5       14    15  Vbus


# ------------------------------------------------------------------------
uart_init:
# ------------------------------------------------------------------------

  # UNLOCK CFGCON
  li x14, CFGCON
  lw x15, 0(x14)
  li x12, ~BIT13                 # IOLOCK bit 13
  and x15, x12, 0
  sw x15, 0(x14)

  # Select pin mapping for terminal

    # Possible values for U1RXR:
    # 0000 = RPA2
    # 0001 = RPB6
    # 0010 = RPA4
    # 0011 = RPB13
    # 0100 = RPB2

    # Possible pins for U1TX special function 0b0001:
    # RPA0
    # RPB3
    # RPB4
    # RPB15
    # RPB7
    # RPC7
    # RPC0
    # RPC5

# li x14, RPB4R
# li x15, 0b0001
# sw x15, 0(x14)                  # RPB4 is TX
# li x14, U1RXR
# li x15, 0b0010
# sw x15, 0(x14)                  # RPA4 is RX

  li x14, RPB15R
  li x15, 0b0001
  sw x15, 0(x14)                  # RPB15 is TX

  li x14, ANSELBCLR
  li x15, 1<<13
  sw x15, 0(x14)                  # RPB13 shall be in digital mode

  li x14, TRISBSET
  li x15, 1<<13
  sw x15, 0(x14)                  # RPB13 shall be input

  li x14, U1RXR
  li x15, 0b0011
  sw x15, 0(x14)                  # RPB13 is RX

    # Possible values for U2RXR:
    # 0000 = RPA1
    # 0001 = RPB5
    # 0010 = RPB1
    # 0011 = RPB11
    # 0100 = RPB8

    # Possible pins for U2TX special function 0b0010:
    # RPA3
    # RPB14
    # RPB0
    # RPB10
    # RPB9
    # RPC9
    # RPC2
    # RPC4

# li x14, RPB14R
# li x15, 0b0010
# sw x15, 0(x14)                  # RPB15 is TX
# li x14, U2RXR
# li x15, 0b0001
# sw x15, 0(x14)                  # RPB5  is RX

  li x14, CFGCON
  lw x15, 0(x14)
  ori x15, x15, BIT13             # set IOLOCK again
  sw x15, 0(x14)

  li x14, U1BRG
  li x15, 12                      # baud is 115,200
  sw x15, 0(x14)                  # assumes PBCLK = 24MHz

  li x14, U1STA
  sw zero, 0(x14)                 # deactivate to change UxMODE

  li x14, U1MODE
  li x15, (1 << 15)               # bit 15, ON: UARTx enable, 8N1
  sw x15, 0(x14)

  li x14, U1STA
  li x15, (0b101 << 10)
  sw x15, 0(x14)                  # enable transmit and receive

  ret


# -------------------------------------------------------------------
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -------------------------------------------------------------------
  push x1

1:call serial_qemit
  popda x15
  beq x15, zero, 1b

  li x14, U1TXREG
  sw x8, 0(x14)
  drop

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

  pushdatos
  li x14, U1RXREG
  lw x8, 0(x14)

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
  slli x8, x8, 31-9 # isolate UTXBF (transmit buffer full)
  srai x8, x8, 31
  inv x8

  pop x1
  ret

# ------------------------------------------------------------------------
  Definition Flag_visible, "serial-key?"
serial_qkey:  # ( -- ? ) Is there a key press ?
# ------------------------------------------------------------------------
  push x1
  call pause

  pushdatos
  li x8, U1STA
  lw x8, 0(x8)
  slli x8, x8, 31-0 # isolate URXDA (receive buffer flag bit)
  srai x8, x8, 31

  pop x1
  ret

# ------------------------------------------------------------------------
  Definition Flag_visible, "restart"
# ------------------------------------------------------------------------

  mtc0 zero, CP0_STATUS # Disable interrupts
  j Reset

# ------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# ------------------------------------------------------------------------

  mtc0 zero, CP0_STATUS # Disable interrupts

  li x14, SYSKEY # System unlock sequence
  li x15, 0xAA996655
  sw x15, 0(x14)
  li x15, 0x556699AA
  sw x15, 0(x14)

# Writing a ‘1’ to RSWRST register sets bit SWRST, arming the software Reset. The subsequent
# read of the RSWRST register triggers the software Reset, which should occur on the next clock
# cycle following the read operation.

  li x14, RSWRST
  li x15, 1
  sw x15, 0(x14)
  lw x15, 0(x14)

1:j 1b # Wait for reset to happen within the next 4 clock cycles
