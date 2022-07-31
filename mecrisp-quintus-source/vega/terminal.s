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

.equ GPIOA, 0x48020000
.equ GPIOB, 0x48020040
.equ GPIOC, 0x48020080
.equ GPIOD, 0x480200C0
.equ GPIOE, 0x4100F000

.equ PDOR,  0x0 # Port Data Output Register (PDOR)
.equ PSOR,  0x4 # Port Set Output Register (PSOR)
.equ PCOR,  0x8 # Port Clear Output Register (PCOR)
.equ PTOR,  0xC # Port Toggle Output Register (PTOR)
.equ PDIR, 0x10 # Port Data Input Register (PDIR)
.equ PDDR, 0x14 # Port Data Direction Register (PDDR)

.equ SCG_SIRCDIV, 0x4002c204
.equ SCG_FIRCDIV, 0x4002c304

.equ PCC0_Base, 0x4002B000

.equ PCC_PORTA,   PCC0_Base + 0x118
.equ PCC_PORTB,   PCC0_Base + 0x11C
.equ PCC_PORTC,   PCC0_Base + 0x120
.equ PCC_PORTD,   PCC0_Base + 0x124
.equ PCC_LPUART0, PCC0_Base + 0x108

.equ PCC1_Base, 0x41027000
.equ PCC_GPIOE,   PCC1_Base + 0x03C
.equ PCC_PORTE,   PCC1_Base + 0x0DC

.equ PORTA, 0x40046000
.equ PORTB, 0x40047000
.equ PORTC, 0x40048000
.equ PORTD, 0x40049000
.equ PORTE, 0x41037000

.equ PORTA_PCR0,  PORTA + 0x0
.equ PORTA_PCR22, PORTA + 0x58
.equ PORTA_PCR23, PORTA + 0x5C
.equ PORTA_PCR24, PORTA + 0x60

# Debug UART0 RX: PC7
# Debug UART0 TX: PC8

.equ PORTC_PCR7,  PORTC + 7*4
.equ PORTC_PCR8,  PORTC + 8*4

.equ LPUART0, 0x40042000

.equ LPUART0_VERID  , LPUART0 + 0x00 # Version ID Register (VERID)                      0401_0003h   RO
.equ LPUART0_PARAM  , LPUART0 + 0x04 # Parameter Register (PARAM)                       0000_0303h   RO
.equ LPUART0_GLOBAL , LPUART0 + 0x08 # LPUART Global Register (GLOBAL)                  0000_0000h
.equ LPUART0_PINCFG , LPUART0 + 0x0C # LPUART Pin Configuration Register (PINCFG)       0000_0000h
.equ LPUART0_BAUD   , LPUART0 + 0x10 # LPUART Baud Rate Register (BAUD)                 0F00_0004h
.equ LPUART0_STAT   , LPUART0 + 0x14 # LPUART Status Register (STAT)                    00C0_0000h
.equ LPUART0_CTRL   , LPUART0 + 0x18 # LPUART Control Register (CTRL)                   0000_0000h
.equ LPUART0_DATA   , LPUART0 + 0x1C # LPUART Data Register (DATA)                      0000_1000h
.equ LPUART0_MATCH  , LPUART0 + 0x20 # LPUART Match Address Register (MATCH)            0000_0000h
.equ LPUART0_MODIR  , LPUART0 + 0x24 # LPUART Modem IrDA Register (MODIR)               0000_0000h
.equ LPUART0_FIFO   , LPUART0 + 0x28 # LPUART FIFO Register (FIFO)                      00C0_0022h
.equ LPUART0_WATER  , LPUART0 + 0x2C # LPUART Watermark Register (WATER)                0000_0000h

# -----------------------------------------------------------------------------
uart_init:
# -----------------------------------------------------------------------------

# Enable dividers for FIRC & SIRC

  li x10, 0x00010101
  li x11, SCG_SIRCDIV # Slow IRC Divide Register (SIRCDIV): SIRC3, SIRC2, SIRC1 enabled with /1 divider.
  sw x10, 0(x11)
  li x11, SCG_FIRCDIV # Fast IRC Divide Register (FIRCDIV): FIRC3, FIRC2, FIRC1 enabled with /1 divider.
  sw x10, 0(x11)

# Enable clock for PORTA, PORTB, PORTC, PORTD, PORTE

  li x10, 0x40000000
  li x11, PCC_PORTA
  sw x10, 0(x11)

  li x11, PCC_PORTB
  sw x10, 0(x11)

  li x11, PCC_PORTC
  sw x10, 0(x11)

  li x11, PCC_PORTD
  sw x10, 0(x11)

  li x11, PCC_PORTE
  sw x10, 0(x11)

  li x11, PCC_GPIOE # Special, for E only.
  sw x10, 0(x11)

# Enable clock for LPUART0

  li x10, 0x43000000 # Enabled, clock source 3: FIRC
  li x11, PCC_LPUART0
  sw x10, 0(x11)

# # Alternate Function 1: GPIO for PA0, PA22, PA23, PA24
#
#   li x10, 0x00000100
#
#   li x11, PORTA_PCR0
#   sw x10, 0(x11)
#
#   li x11, PORTA_PCR22
#   sw x10, 0(x11)
#
#   li x11, PORTA_PCR23
#   sw x10, 0(x11)
#
#   li x11, PORTA_PCR24
#   sw x10, 0(x11)

# Alternate Function 3: LPUART0 for PC7, PC8

  li x10, 0x00000300

  li x11, PORTC_PCR7
  sw x10, 0(x11)

  li x11, PORTC_PCR8
  sw x10, 0(x11)

# # Set LED pins as output, let it shine
#
#   li x11, GPIOA
#
#   li x10, 0x01C00000
#   sw x10, PDDR(x11)
#
#   li x10, 0x00C00000
#   sw x10, PDOR(x11)

# Configure LPUART0

# Baud Rate Modulo Divisor.
# The 13 bits in SBR[12:0] set the modulo divide rate for the baud rate generator. When SBR is 1 - 8191,
# the baud rate equals "baud clock / ((OSR+1) × SBR)". The 13-bit baud rate setting [SBR12:SBR0] must
# only be updated when the transmitter and receiver are both disabled (LPUART_CTRL[RE] and
# LPUART_CTRL[TE] are both 0).

# baudrate = baud clock / ((OSR+1) × SBR)
# <=> ((OSR+1) × SBR) = baud clock / baudrate
# <=> SBR = baud clock / (baudrate * (OSR+1) )

  li x10, 0x1E00000D # Oversampling ratio of 31, Divisor 13. --> 48e6/((1 + 31) * 13) = 115384.615384615
  li x11, LPUART0_BAUD
  sw x10, 0(x11)

  li x10, 0x0000C088 # TXFLUSH, RXFLUSH, Transmit FIFO enable, Receive FIFO enable. Both are 8 characters deep.
  li x11, LPUART0_FIFO
  sw x10, 0(x11)

  li x10, (1 << 19) | (1 << 18)  # Transmitter Enable, Receiver Enable
  li x11, LPUART0_CTRL
  sw x10, 0(x11)

  ret

# # Set UART pins as inputs and outputs
#
#   li x11, GPIOC
#   li x10, (1<<8) # PC8 (TX) as output, PC7 (RX) as input
#   sw x10, PDDR(x11)
#
# # Electrical echo
#
# 1:lw x10, PDIR(x11)
#   slli x10, x10, 1
#   sw x10, PDOR(x11)
#   j 1b

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -----------------------------------------------------------------------------
  push x1

1:call serial_qemit
  popda x15
  beq x15, zero, 1b

  andi x8, x8, 0xFF
  li x14, LPUART0_DATA
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

  li x14, LPUART0_DATA
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

  pushdatos
  li x8, LPUART0_STAT
  lw x8, 0(x8)
  srli x8, x8, 23 # Transmit Data Register Empty Flag
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
  li x8, LPUART0_STAT
  lw x8, 0(x8)
  srli x8, x8, 21 # Receive Data Register Full Flag
  andi x8, x8, 1

  sltiu x8, x8, 1 # 0<>
  addi x8, x8, -1

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# -----------------------------------------------------------------------------
  j Reset
