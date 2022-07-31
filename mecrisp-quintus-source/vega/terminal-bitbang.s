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
# .equ GPIOE, 0x4100F000

.equ PDOR,  0x0 # Port Data Output Register (PDOR)
.equ PSOR,  0x4 # Port Set Output Register (PSOR)
.equ PCOR,  0x8 # Port Clear Output Register (PCOR)
.equ PTOR,  0xC # Port Toggle Output Register (PTOR)
.equ PDIR, 0x10 # Port Data Input Register (PDIR)
.equ PDDR, 0x14 # Port Data Direction Register (PDDR)

.equ PCC0_Base, 0x4002B000
.equ PCC_PORTA, PCC0_Base + 0x118
.equ PCC_PORTB, PCC0_Base + 0x11C
.equ PCC_PORTC, PCC0_Base + 0x120
.equ PCC_PORTD, PCC0_Base + 0x124

.equ PCC_LPUART0, PCC0_Base + 0x108

.equ PORTA, 0x40046000
.equ PORTB, 0x40047000
.equ PORTC, 0x40048000
.equ PORTD, 0x40049000

# .equ PORTE, 0x41037000

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

# Enable clock for PORTA, PORTB, PORTC, PORTD

  li x10, 0x40000000
  li x11, PCC_PORTA
  sw x10, 0(x11)

  li x11, PCC_PORTB
  sw x10, 0(x11)

  li x11, PCC_PORTC
  sw x10, 0(x11)

  li x11, PCC_PORTD
  sw x10, 0(x11)

# Enable clock for LPUART0

  li x10, 0x41000000 # Enabled, 1: System OSC
  li x11, PCC_LPUART0
  sw x10, 0(x11)

# Alternate Function 1: GPIO for PA0, PA22, PA23, PA24

  li x10, 0x00000100

  li x11, PORTA_PCR0
  sw x10, 0(x11)

  li x11, PORTA_PCR22
  sw x10, 0(x11)

  li x11, PORTA_PCR23
  sw x10, 0(x11)

  li x11, PORTA_PCR24
  sw x10, 0(x11)

# Alternate Function 3: LPUART0 for PC7, PC8

  # li x10, 0x00000300
  li x10, 0x00000100

  li x11, PORTC_PCR7
  sw x10, 0(x11)

  li x11, PORTC_PCR8
  sw x10, 0(x11)

# Set LED pins as output, let it shine

  li x11, GPIOA

  li x10, 0x01C00000
  sw x10, PDDR(x11)

  li x10, 0x01000000
  sw x10, PDOR(x11)



# # Configure LPUART0
#
# # Baud Rate Modulo Divisor.
# # The 13 bits in SBR[12:0] set the modulo divide rate for the baud rate generator. When SBR is 1 - 8191,
# # the baud rate equals "baud clock / ((OSR+1) × SBR)". The 13-bit baud rate setting [SBR12:SBR0] must
# # only be updated when the transmitter and receiver are both disabled (LPUART_CTRL[RE] and
# # LPUART_CTRL[TE] are both 0).
#
# # baudrate = baud clock / ((OSR+1) × SBR)
# # <=> ((OSR+1) × SBR) = baud clock / baudrate
# # <=> SBR = baud clock / (baudrate * (OSR+1) )
#
#   li x10, 294 # Oversampling ratio of 16 (default),  48e6/(115200*17) = 24.510
#   li x11, LPUART0_BAUD
#   sw x10, 0(x11)
#
#   li x10, (1 << 19) | (1 << 18)  # Transmitter Enable,
#   li x11, LPUART0_CTRL
#   sw x10, 0(x11)
#
#
#   li x11, GPIOA
#   li x10, 0x01000000
#   sw x10, PDOR(x11)
#
#
# 1:
#   li x10, 42
#   li x11, LPUART0_DATA
#   sw x10, 0(x11)
#
#   li x12, 0xFFFF
# 2:addi x12, x12, -1
#
#
#     li x11, GPIOA
#     slli x10, x12, 16
#     sw x10, PDOR(x11)
#
#   bne x12, zero, 2b
#
#   j 1b


# Set UART pins as inputs and outputs

  li x11, GPIOC
  li x10, (1<<8)    # PC8 (TX) as output, PC7 (RX) as input
  sw x10, PDDR(x11)
  sw x10, PDOR(x11) # Set TX line high

  ret

# Electrical echo
#
# 1:lw x10, PDIR(x11)
#   slli x10, x10, 1
#   sw x10, PDOR(x11)
#   j 1b


# 1: call rx_bit
#    call tx_bit
#    j 1b

#
#    pushdaconst 42
#    call serial_emit
#
# 1:call serial_key
#   addi x8, x8, 1
#   call serial_emit
#
#    j 1b

# -----------------------------------------------------------------------------
delay_half_bit:
# -----------------------------------------------------------------------------
  li x15, 625  # 48 MHz / 4 cycles for each loop run / 2 for half-bit-delay / 9600 Baud
1:addi x15, x15, -1
  bne x15, zero, 1b
  ret

# -----------------------------------------------------------------------------
sample_rx: # Get RX pin state into LSB of x10
# -----------------------------------------------------------------------------
  li x11, GPIOC
  lw x10, PDIR(x11)
  srli x10, x10, 7 # Shift RX pin to LSB
  andi x10, x10, 1
  ret

# -----------------------------------------------------------------------------
tx_bit: # Transmit LSB of x10
# -----------------------------------------------------------------------------
  push x1

  andi x10, x10, 1
  slli x10, x10, 8 # Shift LSB to TX pin
  li x11, GPIOC
  sw x10, PDOR(x11)

  call delay_half_bit
  call delay_half_bit

  pop x1
  ret

# -----------------------------------------------------------------------------
rx_bit: # Receive one bit into x10
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
  push x10
  push x11

1:call serial_qemit
  popda x15
  beq x15, zero, 1b

   # --------
  li x10, 0                  # Start bit
  call tx_bit

  srli x10, x8, 0
  call tx_bit

  srli x10, x8, 1
  call tx_bit

  srli x10, x8, 2
  call tx_bit

  srli x10, x8, 3
  call tx_bit

  srli x10, x8, 4
  call tx_bit

  srli x10, x8, 5
  call tx_bit

  srli x10, x8, 6
  call tx_bit

  srli x10, x8, 7
  call tx_bit

  li x10, 1                 # Stop bit
  call tx_bit
   # --------

  drop

  pop x11
  pop x10
  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key"
serial_key: # ( -- c ) Receive one character
# -----------------------------------------------------------------------------
  push x1
  push x10
  push x11

1:call serial_qkey
  popda x15
  beq x15, zero, 1b

   pushdatos

   # --------
1:call sample_rx        # Wait for start bit
  bne x10, zero, 1b

  call delay_half_bit   # Advance to the middle of the bit time

  call rx_bit
  slli x8, x10, 0

  call rx_bit
  slli x10, x10, 1
  or x8, x8, x10

  call rx_bit
  slli x10, x10, 2
  or x8, x8, x10

  call rx_bit
  slli x10, x10, 3
  or x8, x8, x10

  call rx_bit
  slli x10, x10, 4
  or x8, x8, x10

  call rx_bit
  slli x10, x10, 5
  or x8, x8, x10

  call rx_bit
  slli x10, x10, 6
  or x8, x8, x10

  call rx_bit
  slli x10, x10, 7
  or x8, x8, x10

  call rx_bit     # Stop bit, to get timing right
   # --------

  pop x11
  pop x10
  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit?"
serial_qemit:  # ( -- ? ) Ready to send a character ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdaconst -1 # Always true for bitbang terminal

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key?"
serial_qkey:  # ( -- ? ) Is there a key press ?
# -----------------------------------------------------------------------------
  push x1
  call pause

  pushdaconst -1 # Always true for bitbang terminal

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# -----------------------------------------------------------------------------
  j Reset
