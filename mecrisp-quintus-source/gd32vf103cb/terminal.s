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

  .equ GPIOA_BASE      ,   0x40010800
  .equ GPIOA_CRL       ,   GPIOA_BASE + 0x00
  .equ GPIOA_CRH       ,   GPIOA_BASE + 0x04
  .equ GPIOA_IDR       ,   GPIOA_BASE + 0x08
  .equ GPIOA_ODR       ,   GPIOA_BASE + 0x0C
  .equ GPIOA_BSRR      ,   GPIOA_BASE + 0x10
  .equ GPIOA_BRR       ,   GPIOA_BASE + 0x14
  .equ GPIOA_LCKR      ,   GPIOA_BASE + 0x18

  .equ RCU_BASE        ,   0x40021000
  .equ RCU_APB2EN      ,   RCU_BASE + 0x18

    .equ AFEN,     0x0001
    .equ PAEN,     0x0004
    .equ PBEN,     0x0008
    .equ PCEN,     0x0010
    .equ PDEN,     0x0020
    .equ PEEN,     0x0040
    .equ USART0EN, 0x4000


  .equ DBGMCU2,   0xe0042008
  .equ DBGMCU2EN, 0xe004200c

  .equ Terminal_USART_Base, 0x40013800 # USART 0

  .equ Terminal_USART_SR,    Terminal_USART_Base + 0x00
  .equ Terminal_USART_DR,    Terminal_USART_Base + 0x04
  .equ Terminal_USART_BRR,   Terminal_USART_Base + 0x08
  .equ Terminal_USART_CR1,   Terminal_USART_Base + 0x0c
  .equ Terminal_USART_CR2,   Terminal_USART_Base + 0x10
  .equ Terminal_USART_CR3,   Terminal_USART_Base + 0x14
  .equ Terminal_USART_GTPR,  Terminal_USART_Base + 0x18

  .equ RXNE,  BIT5
  .equ TC,    BIT6
  .equ TXE,   BIT7

  # Baudrate settings: Bit 11-4 Divider, Bit 3-0 Fractional

  # Baud rate generation for 16 MHz:
  # 16000000 / (16 * 115200 ) = 1000000 / 115200 = 8.6805
  # 0.6805... * 16 = 10,8 rounds to 11 = B
  # $8B

  # For 8 MHz:

  #  8000000 / (16 * 115200 ) = 4.3403
  #  0.3403 * 16 = 5.4448
  #  Divider 4, Fractional term 5 or 6 --> $45 or $46.


# -----------------------------------------------------------------------------
uart_init:
# -----------------------------------------------------------------------------

  # Most of the peripherals are connected to APB2.  Turn on the
  # clocks for the interesting peripherals and all GPIOs.

  li x15, AFEN|PAEN|PBEN|PCEN|PDEN|USART0EN
  li x14, RCU_APB2EN
  sw x15, 0(x14)

  # Let it shine: Turquoise !
  #
  # li x15, 0x44444224 # PA2 & PA1 outputs
  # li x14, GPIOA_CRL
  # sw x15, 0(x14)
  #
  # li x15, 0x0 # LEDs are active low.
  # li x14, GPIOA_ODR
  # sw x15, 0(x14)

  # Set PORTA pins in alternate function mode
  # Put PA9  (TX) to alternate function output push-pull at 2 MHz
  # Put PA10 (RX) to pull-up input
  #
  # li x15, 0x00000400
  # li x14, GPIOA_BSRR
  # sw x15, 0(x14)
  #
  # li x15, 0x444448A4
  # li x14, GPIOA_CRH
  # sw x15, 0(x14)

  # Set PORTA pins in alternate function mode
  # Put PA9  (TX) to alternate function output push-pull at 2 MHz
  # Put PA10 (RX) to vanilla input

  li x15, 0x444444A4 # Set PA10 as floating input instead
  li x14, GPIOA_CRH
  sw x15, 0(x14)

  # Configure BRR by deviding the bus clock with the baud rate
  li x15, 0x45  # 115200 baud at 8 MHz
  li x14, Terminal_USART_BRR
  sw x15, 0(x14)

  # Enable the USART, TX, and RX circuit
  li x15, BIT13+BIT3+BIT2 # USART_CR1_UE | USART_CR1_TE | USART_CR1_RE
  li x14, Terminal_USART_CR1
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

  li x14, Terminal_USART_DR
  sb x8, 0(x14)
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

  li x14, Terminal_USART_DR
  pushdatos
  lbu x8, 0(x14)

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit?"
serial_qemit:  # ( -- ? ) Ready to send a character ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdatos
  li x8, Terminal_USART_SR
  lw x8, 0(x8)
  andi x8, x8, TXE

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
  li x8, Terminal_USART_SR
  lw x8, 0(x8)
  andi x8, x8, RXNE

  sltiu x8, x8, 1 # 0<>
  addi x8, x8, -1

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# -----------------------------------------------------------------------------

  li x15, 0x4b5a6978
  li x14, DBGMCU2EN
  sw x15, 0(x14)

  li x15, 1
  li x14, DBGMCU2
  sw x15, 0(x14)

  # Real chip resets now; this jump is just to trap the emulator:
  j Reset
