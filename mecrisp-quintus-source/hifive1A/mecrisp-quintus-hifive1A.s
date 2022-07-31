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

# -----------------------------------------------------------------------------
# Swiches for capabilities of this chip
# -----------------------------------------------------------------------------

.option norelax
.option rvc
.equ compressed_isa, 1

# -----------------------------------------------------------------------------
# Speicherkarte für Flash und RAM
# Memory map for Flash and RAM
# -----------------------------------------------------------------------------

# Konstanten für die Größe des Ram-Speichers

.equ RamAnfang, 0x80000000 # Start of RAM          Porting: Change this !
.equ RamEnde,   0x80004000 # End   of RAM.  16 kb. Porting: Change this !

# Konstanten für die Größe und Aufteilung des Flash-Speichers

.equ FlashAnfang, 0x20400000 # Start of Flash          Porting: Change this !
.equ FlashEnde,   0x20410000 # End   of Flash.  64 kb. Porting: Change this !

.equ FlashDictionaryAnfang, FlashAnfang + 0x5000 # 20 kb reserved for core.
.equ FlashDictionaryEnde,   FlashEnde

# -----------------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------------

.text
  j Reset # Instead of a true vector table

# -----------------------------------------------------------------------------
# Include the Forth core of Mecrisp-Quintus
# -----------------------------------------------------------------------------

.include "../common/forth-core.s"

# -----------------------------------------------------------------------------
Reset: # Forth begins here
# -----------------------------------------------------------------------------

  # Set base address for interrupt handler

  la x15, irq_collection
  csrrs zero, mtvec, x15

#  li x10, red|green|blue
#  li x11, GPIO_OUTPUT_EN
#  sw x10, 0(x11)

#  li x10, red|blue   # Green light, active low !
#  li x11, GPIO_PORT
#  sw x10, 0(x11)

  .include "../common/catchflashpointers.s"

#  li x10, blue|green   # Red light, active low !
#  li x11, GPIO_PORT
#  sw x10, 0(x11)

  call uart_init

#  li x10, 42 # '*'
#  li x11, UART0_TXDATA
#  sw x10, 0(x11)

  welcome " for RISC-V 32 IMC on HiFive1A by Matthias Koch"

#  li x10, red|green   # Blue light, active low !
#  li x11, GPIO_PORT
#  sw x10, 0(x11)

  # Ready to fly !
  .include "../common/boot.s"
