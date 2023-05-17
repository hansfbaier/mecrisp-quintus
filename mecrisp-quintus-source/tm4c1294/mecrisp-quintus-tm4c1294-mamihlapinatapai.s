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

.equ riscvregisters, 0x20000000  # 128 bytes for the instruction set emulator
.equ RamAnfang, 0x20000000 + 128 # Start of RAM          Porting: Change this !
.equ RamEnde,   0x20040000       # End   of RAM. 256 kb. Porting: Change this !  Debug stack for emulator.

# Konstanten für die Größe und Aufteilung des Flash-Speichers

.equ FlashAnfang, 0x00000000 # Start of Flash          Porting: Change this !
.equ FlashEnde,   0x00100000 # End   of Flash.   1 MB. Porting: Change this !

.equ FlashDictionaryAnfang, FlashAnfang + 0x6000 # 24 kb reserved for core.
.equ FlashDictionaryEnde,   FlashEnde

# -----------------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------------

.text
  # Improvised ARM Cortex style vector table
  .word riscvregisters
  .word Mamihlapinatapai + 1

# -----------------------------------------------------------------------------
# Include the Forth core of Mecrisp-Quintus
# -----------------------------------------------------------------------------

.include "../common/forth-core.s"

# -----------------------------------------------------------------------------
Mamihlapinatapai: # ARM begins executing here
# -----------------------------------------------------------------------------

  .incbin "../mamihlapinatapai/mamihlapinatapai.bin"

# -----------------------------------------------------------------------------
Reset: # Forth begins here, directly after the emulator binary
# -----------------------------------------------------------------------------

  .include "../common/catchflashpointers.s"

  call uart_init

  welcome " for emulated RISC-V RV32IM with Mamihlapinatapai on TM4C1294 by Matthias Koch"

  # Ready to fly !
  .include "../common/boot.s"
