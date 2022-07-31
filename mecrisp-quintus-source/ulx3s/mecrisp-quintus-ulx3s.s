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

.equ RamAnfang, 0x00000000 # Start of RAM          Porting: Change this !
.equ RamEnde,   0x00010000 # End   of RAM.  64 kb. Porting: Change this !

# Konstanten für die Größe und Aufteilung des Flash-Speichers

.equ FlashAnfang, 0x00010000 # Start of Flash          Porting: Change this !
.equ FlashEnde,   0x00020000 # End   of Flash.  64 kb. Porting: Change this !

.equ FlashDictionaryAnfang, FlashAnfang + 0x4400 # 17 kb reserved for core.
.equ FlashDictionaryEnde,   FlashEnde            # 47 kb space for "user flash dictionary"

# -----------------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------------

.text

  # Take care: We are executing at 0x80200000 currently.
  # Copy Forth core from SPI Flash to RAM, mirroring the core to 0x10000:

  auipc x5, 0
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

  welcome " for RISC-V 32 IMC on ULX3S by Matthias Koch"

  # Ready to fly !
  .include "../common/boot.s"

.org 0x10000, 0xFF
