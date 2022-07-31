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

.equ GPIOBASE, 0x10012000

.equ GPIO_VALUE        , GPIOBASE + 0x00
.equ GPIO_INPUT_EN     , GPIOBASE + 0x04
.equ GPIO_OUTPUT_EN    , GPIOBASE + 0x08
.equ GPIO_PORT         , GPIOBASE + 0x0C
.equ GPIO_PUE          , GPIOBASE + 0x10
.equ GPIO_IOF_EN       , GPIOBASE + 0x38
.equ GPIO_IOF_SEL      , GPIOBASE + 0x3C
.equ GPIO_OUT_XOR      , GPIOBASE + 0x40

  # Common Anode tied to Vcc. LEDs shine on low.
.equ green, 1<<19 # GPIO 19: Green LED
.equ blue,  1<<21 # GPIO 21: Blue LED
.equ red,   1<<22 # GPIO 22: Red LED

.equ UART0BASE, 0x10013000

.equ UART0_TXDATA    , UART0BASE + 0x00
.equ UART0_RXDATA    , UART0BASE + 0x04
.equ UART0_TXCTRL    , UART0BASE + 0x08
.equ UART0_RXCTRL    , UART0BASE + 0x0C
.equ UART0_IE        , UART0BASE + 0x10
.equ UART0_IP        , UART0BASE + 0x14
.equ UART0_DIV       , UART0BASE + 0x18

.equ PRCI_BASE, 0x10008000

.equ PRCI_HFROSCCFG  , PRCI_BASE + 0x00
.equ PRCI_HFXOSCCFG  , PRCI_BASE + 0x04
.equ PRCI_PLLCFG     , PRCI_BASE + 0x08
.equ PRCI_PLLDIV     , PRCI_BASE + 0x0C
.equ PRCI_PROCMONCFG , PRCI_BASE + 0xF0


# -----------------------------------------------------------------------------
uart_init:
# -----------------------------------------------------------------------------
  # Wait for crystal to oscillate:

1:li x10, PRCI_HFXOSCCFG   # 0x10008004
  lw x11, 0(x10)
  li x12, 0xC0000000
  bne x11, x12, 1b

  # Select crystal as main clock source

  li x10, PRCI_PLLCFG
  li x11, 0x00070df1 # 0x00060df1 | (1<<16) | (1<<17) | (1<<18)  # Reset value | PLLSEL | PLLREFSEL | PLLBYPASS
  sw x11, 0(x10)

  # UART RX/TX are selected IOF_SEL on Reset. Set IOF_EN bits.

  li x10, GPIO_IOF_EN
  li x11, (1<<17)|(1<<16)
  sw x11, 0(x10)

  # Set baud rate

  li x10, UART0_DIV
  li x11, 139-1  # 16 MHz / 115200 Baud = 138.89
  sw x11, 0(x10)

  # Enable transmit

  li x10, UART0_TXCTRL
  li x11, 1
  sw x11, 0(x10)

  # Enable receive

  li x10, UART0_RXCTRL
  li x11, 1
  sw x11, 0(x10)

  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible|Flag_variable, "serial-lastchar" # ( -- addr )
  CoreVariable serial_lastchar
# -----------------------------------------------------------------------------
  pushdatos
  li x8, serial_lastchar
  ret
  .word -1

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -----------------------------------------------------------------------------
  push x1

1:call serial_qemit
  popda x15
  beq x15, zero, 1b

  li x14, UART0_TXDATA
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

  li x14, serial_lastchar
  pushdatos
  lw x8, 0(x14)

  li x15, -1
  sw x15, 0(x14)

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit?"
serial_qemit:  # ( -- ? ) Ready to send a character ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdatos
  li x15, UART0_TXDATA
  lw x15, 0(x15)
  srai x15, x15, 31  # Sign extend the "transmit FIFO full" bit
  xori x8, x15, -1  # Invert it

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key?"
serial_qkey:  # ( -- ? ) Is there a key press ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdatos

  # Check buffer for waiting character

  li x14, serial_lastchar
  lw x15, 0(x14)
  srai x8, x15, 31 # Sign extend the "receive FIFO empty" bit
  beq x8, zero, 1f

  # No character waiting in the buffer variable. Check UART for new character:

  li x14, UART0_RXDATA
  lw x15, 0(x14)
  li x14, serial_lastchar
  sw x15, 0(x14)

  srai x8, x15, 31 # Sign extend the "receive FIFO empty" bit

1:xori x8, x8, -1
  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# -----------------------------------------------------------------------------
  j Reset
