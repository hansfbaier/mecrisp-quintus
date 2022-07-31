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

# -----------------------------------------------------------------------------
# Speicherkarte für Flash und RAM
# Memory map for Flash and RAM
# -----------------------------------------------------------------------------

# Konstanten für die Größe des Ram-Speichers

.equ RamAnfang, 0x00000000 # Start of RAM          Porting: Change this !
.equ RamEnde,   0x00003000 # End   of RAM.  12 kb. Porting: Change this !

# Konstanten für die Größe und Aufteilung des Flash-Speichers

.equ FlashAnfang, 0x00003000 # Start of Flash          Porting: Change this !
.equ FlashEnde,   0x00023000 # End   of Flash. 128 kb. Porting: Change this !

.equ FlashDictionaryAnfang, FlashAnfang + 0x6000 #  24 kb reserved for core.
.equ FlashDictionaryEnde,   FlashEnde            # 104 kb space for "user flash dictionary"

# -----------------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------------

.text
  j irq_collection

  # Take care: We are executing at 0x00100000 currently.
  # Copy Forth core from SPI Flash to RAM, mirroring the core to 0x3000:

  li x5, 0x00100000
  li x6, FlashAnfang
  li x7, FlashEnde-FlashAnfang

1:lw x8, 0(x5)
  sw x8, 0(x6)

  addi x5, x5, 4
  addi x6, x6, 4
  addi x7, x7, -4

  bne x7, zero, 1b

  # Long absolute jump into RAM now:

  lui x5, %hi(Reset)
  jalr zero, x5, %lo(Reset)

# -----------------------------------------------------------------------------
# Include the Forth core of Mecrisp-Quintus
# -----------------------------------------------------------------------------

.include "../common/forth-core.s"

# -----------------------------------------------------------------------------
Reset: # Forth begins here
# -----------------------------------------------------------------------------
  .include "../common/catchflashpointers.s"

  call uart_init

  welcome " for RISC-V 32 IM on Icebreaker by Matthias Koch"

  # Ready to fly !
  .include "../common/boot.s"
