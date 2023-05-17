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
.equ flash8bytesblockwrite, 1

# -----------------------------------------------------------------------------
# Speicherkarte für Flash und RAM
# Memory map for Flash and RAM
# -----------------------------------------------------------------------------

# Konstanten für die Größe des Ram-Speichers

.equ RamAnfang, 0x20000000          # Start of RAM           Porting: Change this !
.equ RamEnde,   0x20030000 - 0x1800 # End   of RAM.  186 kb. Porting: Change this !

# Konstanten für die Größe und Aufteilung des Flash-Speichers

.equ FlashAnfang, 0x00000000 # Start of Flash           Porting: Change this !
.equ FlashEnde,   0x00100000 # End   of Flash. 1024 kb. Porting: Change this !

.equ FlashDictionaryAnfang, FlashAnfang
.equ FlashDictionaryEnde,   FlashEnde - 0x8000 # 32 kb reserved for core.

# -----------------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------------

.text
.org 0x000F8000, 0xFFFFFFFF

# -----------------------------------------------------------------------------
# Include the Forth core of Mecrisp-Quintus
# -----------------------------------------------------------------------------

  .include "../common/forth-core.s"

# -----------------------------------------------------------------------------
Reset: # Forth begins here
# -----------------------------------------------------------------------------

  # Stop watchdog timer
    # WDOG0->CNT = 0xD928C520U;
    # WDOG0->TOVAL = 0xFFFF;
    # WDOG0->CS = (uint32_t) ((WDOG0->CS) & ~WDOG_CS_EN_MASK) | WDOG_CS_UPDATE_MASK;

  li x10, 0xD928C520
  li x11, 0x4002A004 # WDOG0_CNT
  sw x10, 0(x11)

  li x10, 0x0000FFFF
  li x11, 0x4002A008 # WDOG0_TOVAL
  sw x10, 0(x11)

  li x10, 0x00002920
  li x11, 0x4002A000 # WDOG0_CS
  sw x10, 0(x11)

  # Set base address for interrupt vecor table

  li x15, 0x000FFF00
  csrrs zero, mtvec, x15
  csrrs zero, 0x005, x15

  # Enable cycle counter with overflow, specific for Vega

  li x15, 1
  csrrw zero, 0x7A0, x15
  csrrw zero, 0x7A1, x15

  .include "../common/catchflashpointers.s"

  call uart_init

  welcome " for RISC-V RV32IM on RV32M1 Vega by Matthias Koch"

  # Ready to fly !
  .include "../common/boot.s"

# -----------------------------------------------------------------------------
# Vector table
# -----------------------------------------------------------------------------

.org 0x000FFF00 , 0xFFFFFFFF

j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j irq_collection  #  <IRQ_Handler>
j Reset           #  <Reset_Handler>
j irq_fault       #  <IllegalInstruction_Handler>
j irq_fault       #  <Ecall_Handler>
j irq_fault       #  <LSU_Handler>

.org 0x00100000 , 0xFFFFFFFF
