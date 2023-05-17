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
# Swiches for capabilities of this target
# -----------------------------------------------------------------------------

# Mecrisp-Quintus is small enough to handle all calls with jal opcodes.
# Do not use "relax" option for linker, as this confuses absolute addresses.

.option norelax
.option rvc
.equ compressed_isa, 1
.equ within_os, 1
.equ erasedflashcontainszero, 1

# -----------------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------------

.section mecrisp, "awx" # Everything is writeable and executable
.equ FlashAnfang, .

# -----------------------------------------------------------------------------
# Include the Forth core of Mecrisp-Quintus
# -----------------------------------------------------------------------------

.global _start
_start:
  j Reset_with_arguments

.include "../common/forth-core.s"

# -----------------------------------------------------------------------------
# Entry point
# -----------------------------------------------------------------------------

Reset_with_arguments:

    laf x15, arguments  # Save the initial stack pointer, as it contains
    sw x2, 0(x15)       # command line arguments. Do this only once on first entry.

Reset:
  # No initialisation necessary, as we are not running bare metal.

  # Catch the pointers for "Flash" dictionary
  .include "../common/catchflashpointers.s"

  welcome " for RISC-V RV32IMC Linux by Matthias Koch"

  # Ready to fly !
  .include "../common/boot.s"

# -----------------------------------------------------------------------------
# Special memory map for "Flash" and RAM sections within target RAM.
# -----------------------------------------------------------------------------

.bss

.equ FlashDictionaryAnfang, . # Ein bisschen Platz für den Kern reserviert... Some space reserved for core.

  .rept 1024 * 256      # 1024 * 256*4 = 1 MB for "Flash" dictionary
  .word 0x00000000
  .endr


.equ FlashEnde, .
.equ FlashDictionaryEnde,   .  # 1 MB Platz für das Flash-Dictionary     1 MB Flash available. Porting: Change this !
.equ Backlinkgrenze,        .  # Ab dem Ram-Start.

# Konstanten für die Größe des Ram-Speichers

.equ RamAnfang, . # Start of RAM

  .rept 1024 * 256      # 1024 * 254*4 = 1 MB for RAM dictionary
  .word 0x00000000
  .endr

.equ RamEnde,   . # End   of RAM.

