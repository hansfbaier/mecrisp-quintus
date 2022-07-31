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
# Start with some essential macro definitions
# -----------------------------------------------------------------------------

.set reorder # Assembler takes care of inserting NOPs into the delay slots
             # if the instruction before cannot be swapped with the jump opcode.

.include "../common/mips-v.s"

# -----------------------------------------------------------------------------
# Swiches for capabilities of this chip
# -----------------------------------------------------------------------------

.equ mipscore, 1

# -----------------------------------------------------------------------------
# Speicherkarte für Flash und RAM
# Memory map for Flash and RAM
# -----------------------------------------------------------------------------

# Konstanten für die Größe des Ram-Speichers

.equ RamAnfang, 0xA0000000 # Start of RAM
.equ RamEnde,   0xA0010000 # End   of RAM.  64 kb.

# Konstanten für die Größe und Aufteilung des Flash-Speichers

.equ FlashAnfang, 0xBD000000 # Start of Flash
.equ FlashEnde,   0xBD040000 # End   of Flash, total is 256kB

.equ FlashDictionaryAnfang, FlashAnfang + 0x8000 # 32 kb reserved for core.
.equ FlashDictionaryEnde,   FlashEnde

# ---------------------------------------------------------------------------
# Configuration bits area
# Internal FRC oscillator, PLL makes it 48MHz, CLKO is enabled, PBCLK = 24MHz
# -----------------------------------------------------------------------------

.section .devcfg3, "a", @progbits
            .word 0xCFFFFFFF
.section .devcfg2, "a", @progbits
            .word 0xFFF979F9
.section .devcfg1, "a", @progbits
            .word 0xFF7FDAD9
.section .devcfg0, "a", @progbits
            .word 0x7FFFFFFB




# ----------------------------------------------------------------------
# Boot flash area for low-level memory initialisation
# You do not need this if you are loading something with a bootloader
# ----------------------------------------------------------------------

.section .boot, "ax"

        .align 2
        .globl _reset
        .set noreorder
        .ent _reset
_reset:

        ##################################################################
        # Call main.
        #
        #################################################################
        j Reset
        nop
        .end _reset

# -----------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------

        .text
        .align 2
        .set reorder
# -----------------------------------------------------------------------
# Include the Forth core of Mecrisp-Quintus and SFRs from Microchip
# -----------------------------------------------------------------------

.include "p32mx270f256b.S"
.include "../common/forth-core.s"

# -----------------------------------------------------------------------
Reset: # Forth begins here
# -----------------------------------------------------------------------

  call memory_init          # terminal.s
  call uart_init            # terminal.s

  Debug_Terminal_Init

  .include "../common/catchflashpointers.s"


  welcome " for PIC32MX270F256B by Matthias Koch"

  # Ready to fly !
  .include "../common/boot.s"

# vim: set shiftwidth=2:
