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

.include "../common/mips-v.s" # Twist MIPS assembler to accept RISC-V style

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

# -----------------------------------------------------------------------------
# Boot flash area for low-level initialisation and device configuration
# -----------------------------------------------------------------------------

.section .boot, "ax"

  j Reset

# -----------------------------------------------------------------------------
# Configuration bits at the end of the boot flash area
# Internal FRC oscillator, PLL makes it 48MHz, CLKO is enabled, PBCLK = 24MHz
# -----------------------------------------------------------------------------

.org 0xBF0

  .word 0xCFFFFFFF # DEVCFG3
  .word 0xFFF979F9 # DEVCFG2
  .word 0xFF7FDAD9 # DEVCFG1
  .word 0x7FFFFFFB # DEVCFG0

# -----------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------

.text

handler_base: /* TLB error servicing. */
  j irq_fault

.org 0x180 /* General exception servicing. */
  j irq_fault

.org 0x200 /* Interrupt servicing. */

  # Single vector for all interrupts:
  j irq_collection

# # Multi-vectored mode:
# # Every vector needs 32 bytes and we have 64 interrupt sources.
# .rept 64
# j irq_collection
# nop
# nop
# nop
# nop
# nop
# nop
# nop
# .endr

# -----------------------------------------------------------------------
# Include the Forth core of Mecrisp-Quintus and SFRs from Microchip
# -----------------------------------------------------------------------

.include "p32mx270f256b.S"
.include "../common/forth-core.s"

# -----------------------------------------------------------------------
Reset: # Forth begins here
# -----------------------------------------------------------------------

  call memory_init          # terminal.s

  .include "../common/catchflashpointers.s"

  call uart_init            # terminal.s
  call interrupt_init       # interrupts.s

  welcome " for MIPS on PIC32MX270F256B by Matthias Koch"

  # Ready to fly !
  .include "../common/boot.s"
