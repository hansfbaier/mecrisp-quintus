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

.set reorder # Assembler takes care of inserting NOPs into the delay slots if the instruction before cannot be swapped with the jump opcode.

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

.equ RamAnfang, 0xA0000000 # Start of RAM          Porting: Change this !
.equ RamEnde,   0xA0010000 # End   of RAM.  64 kb. Porting: Change this !

# Konstanten für die Größe und Aufteilung des Flash-Speichers

.equ FlashAnfang, 0xBD000000 # Start of Flash          Porting: Change this !
.equ FlashEnde,   0xBD080000 # End   of Flash. 512 kb. Porting: Change this !

.equ FlashDictionaryAnfang, FlashAnfang + 0x8000 # 32 kb reserved for core.
.equ FlashDictionaryEnde,   FlashEnde

# -----------------------------------------------------------------------------
# Boot flash area for low-level memory initialisation
# -----------------------------------------------------------------------------

.section .boot, "a"

  j Reset

# -----------------------------------------------------------------------------
# Configuration bits at the end of the boot flash area
# -----------------------------------------------------------------------------

.org 0xBF0

  .word 0xFFFFFFFF # DEVCFG3
  .word 0xFFFFFFFF # DEVCFG2
  .word ~( (1<<23) ) # | (1<<5) ) # DEVCFG1: FWDTEN Watchdog off, FSOSCEN off to use Y2 pins RC13 and RC14 as GPIO.
  .word 0xFFFFFFFF # DEVCFG0

# -----------------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------------

.text

handler_base:

.org 0x180 /* General exception servicing. */

exception_handler:
  j irq_fault

.org 0x200 /* Interrupt servicing. */

interrupt_handler:
  j irq_collection


# -----------------------------------------------------------------------------
# Include the Forth core of Mecrisp-Quintus
# -----------------------------------------------------------------------------

.include "../common/forth-core.s"

# -----------------------------------------------------------------------------
Reset: # Forth begins here
# -----------------------------------------------------------------------------

  .include "../common/catchflashpointers.s"

  call uart_init

    # Initialisation for Interrupts. Similar to code of Paul Boddie: https://blogs.fsfe.org/pboddie/?p=1712

    mfc0 x15, CP0_DEBUG
    li x14, ~0x40000000 # DEBUG_DM
    and x15, x15, x14
    mtc0 x15, CP0_DEBUG

    mfc0 x15, CP0_STATUS
    li x14, 0x00400000 # STATUS_BEV  /* BEV = 1 or EBASE cannot be set */
    or x15, x15, x14
    mtc0 x15, CP0_STATUS

      la x15, handler_base
      mtc0 x15, CP0_EBASE_1, 1  /* EBASE = exception_handler */

    mfc0 x15, CP0_STATUS
    li x14, ~0x00400000 # STATUS_BEV  /* CP0_STATUS &= ~STATUS_BEV (use non-bootloader vectors) */
    and x15, x15, x14
    mtc0 x15, CP0_STATUS

    li x15, 0x20  /* Must be non-zero or the CPU gets upset */
    mtc0 x15, CP0_INTCTL_1, 1

    li x15, 0x00800000 # CAUSE_IV  /* IV = 1 (use EBASE+0x200 for interrupts) */
    mtc0 x15, CP0_CAUSE

  welcome " for PIC32MX570F512L by Matthias Koch"

  # Ready to fly !
  .include "../common/boot.s"

