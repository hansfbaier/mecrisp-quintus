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

.equ RCGCPIO,    0x400FE608
.equ RCGCUART,   0x400FE618

.equ GPIOA_BASE, 0x40004000
.equ GPIOAFSEL,  0x40004420
.equ GPIODEN,    0x4000451C

.equ Terminal_UART_Base, 0x4000C000

.equ UARTDR,     Terminal_UART_Base + 0x000
.equ UARTFR,     Terminal_UART_Base + 0x018
.equ UARTIBRD,   Terminal_UART_Base + 0x024
.equ UARTFBRD,   Terminal_UART_Base + 0x028
.equ UARTLCRH,   Terminal_UART_Base + 0x02C
.equ UARTCTL,    Terminal_UART_Base + 0x030
.equ UARTCC,     Terminal_UART_Base + 0xFC8

# Werte für den UARTFR-Register

.equ RXFE, 0x10 # Receive  FIFO empty
.equ TXFF, 0x20 # Transmit FIFO full

# -----------------------------------------------------------------------------
uart_init:
# -----------------------------------------------------------------------------

  li x15, 1            # UART0 aktivieren
  li x14, RCGCUART
  sw x15, 0(x14)

  li x15, 0x3F         # Alle GPIO-Ports aktivieren
  li x14, RCGCPIO
  sw x15, 0(x14)

  li x15, 3            # PA0 und PA1 auf UART-Sonderfunktion schalten
  li x14, GPIOAFSEL
  sw x15, 0(x14)

  li x15, 3            # PA0 und PA1 als digitale Leitungen aktivieren
  li x14, GPIODEN
  sw x15, 0(x14)

  # Set_Terminal_UART_Baudrate

   # UART-Einstellungen vornehmen

  li x15, 0         # UART stop
  li x14, UARTCTL
  sw x15, 0(x14)

  # Baud rate generation:
  # 16000000 / (16 * 115200 ) = 1000000 / 115200 = 8.6805
  # 0.6805... * 64 = 43.5   ~ 44
  # use 8 and 44

  li x15, 8
  li x14, UARTIBRD
  sw x15, 0(x14)

  li x15, 44
  li x14, UARTFBRD
  sw x15, 0(x14)

  li x15, 0x60|0x10  # 8N1, enable FIFOs !
  li x14, UARTLCRH
  sw x15, 0(x14)

  li x15, 5          # Choose PIOSC as source
  li x14, UARTCC
  sw x15, 0(x14)

  li x15, 0
  li x14, UARTFR
  sw x15, 0(x14)

  li x15, 0x301      # UART start
  li x14, UARTCTL
  sw x15, 0(x14)

  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -----------------------------------------------------------------------------
  push x1

1:call serial_qemit
  popda x15
  beq x15, zero, 1b

  li x14, UARTDR
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

  li x14, UARTDR
  pushdatos
  lw x8, 0(x14)
  andi x8, x8, 0xFF

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit?"
serial_qemit:  # ( -- ? ) Ready to send a character ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdaconst 0
  li x14, UARTFR
  lw x15, 0(x14)
  andi x15, x15, TXFF

  bne x15, zero, 1f
    xori x8, x8, -1
1:

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key?"
serial_qkey:  # ( -- ? ) Is there a key press ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdaconst 0
  li x14, UARTFR
  lw x15, 0(x14)
  andi x15, x15, RXFE

  bne x15, zero, 1f
    xori x8, x8, -1
1:

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# -----------------------------------------------------------------------------
  j Reset

#
#  # -----------------------------------------------------------------------------
#  simpleecho: # Most simple UART echo possible
#  # -----------------------------------------------------------------------------
#    li x10, uart_data
#    lw x11, 0(x10)
#    li x12, -1
#    beq x11, x12, echo
#
#    li x10, uart_data
#    sw x11, 0(x10)
#  j simpleecho
#
#  # -----------------------------------------------------------------------------
#  echo: # Echo with data stack usage and LED blinking
#  # -----------------------------------------------------------------------------
#    call key
#
#      li x10, leds
#      sw x8, 0(x10)
#
#    call emit
#    j echo
#
#  # -----------------------------------------------------------------------------
#  blinky: # Blink the LEDs with a counter
#  # -----------------------------------------------------------------------------
#    li x10, leds
#    addi x11, x11, 1
#    sw x11, 0(x10)
#    j blinky
#
