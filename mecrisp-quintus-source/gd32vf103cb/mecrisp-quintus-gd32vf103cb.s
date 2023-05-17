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

.equ RamAnfang,  0x20000000  # Start of RAM           Porting: Change this !
.equ RamEnde,    0x20008000  # End   of RAM.   32 kb. Porting: Change this !

# Konstanten für die Größe und Aufteilung des Flash-Speichers

.equ FlashAnfang, 0x00000000 # Start of Flash           Porting: Change this !
.equ FlashEnde,   0x00020000 # End   of Flash.  128 kb. Porting: Change this !

.equ FlashDictionaryAnfang, FlashAnfang + 0x4C00 # 19 kb reserved for core.
.equ FlashDictionaryEnde,   FlashEnde

# -----------------------------------------------------------------------------
# Core start
# -----------------------------------------------------------------------------

.text

# -----------------------------------------------------------------------------
# Vector table
# -----------------------------------------------------------------------------

vector_table: # Aligned on 512 Byte boundary.

  j Reset
  .word 0                #                      1
  .word 0                #                      2
  .word irq_software     # 0x0000_000C: Vector  3:   CLIC_INT_SFT              --> Software interrupt
  .word 0                #                      4
  .word 0                #                      5
  .word 0                #                      6
  .word irq_timer        # 0x0000_001C: Vector  7:   CLIC_INT_TMR              --> Core timer
  .word 0                #                      8
  .word 0                #                      9
  .word 0                #                     10
  .word 0                #                     11
  .word 0                #                     12
  .word 0                #                     13
  .word 0                #                     14
  .word 0                #                     15
  .word 0                #                     16
  .word irq_memfault     # 0x0000_0044: Vector 17:   CLIC_INT_BWEI             --> Memory access error
  .word irq_collection   # 0x0000_0048: Vector 18:   CLIC_INT_PMOVI
  .word irq_collection   # 0x0000_004C: Vector 19:   WWDGT interrupt
  .word irq_collection   # 0x0000_0050: Vector 20:   LVD from EXTI interrupt
  .word irq_collection   # 0x0000_0054: Vector 21:   Tamper interrupt
  .word irq_collection   # 0x0000_0058: Vector 22:   RTC global interrupt
  .word irq_collection   # 0x0000_005C: Vector 23:   FMC global interrupt
  .word irq_collection   # 0x0000_0060: Vector 24:   RCU global interrupt
  .word irq_exti0        # 0x0000_0064: Vector 25:   EXTI Line0 interrupt
  .word irq_exti1        # 0x0000_0068: Vector 26:   EXTI Line1 interrupt
  .word irq_exti2        # 0x0000_006C: Vector 27:   EXTI Line2 interrupt
  .word irq_exti3        # 0x0000_0070: Vector 28:   EXTI Line3 interrupt
  .word irq_exti4        # 0x0000_0074: Vector 29:   EXTI Line4 interrupt
  .word irq_collection   # 0x0000_0078: Vector 30:   DMA0 channel0 global interrupt
  .word irq_collection   # 0x0000_007C: Vector 31:   DMA0 channel1 global interrupt
  .word irq_collection   # 0x0000_0080: Vector 32:   DMA0 channel2 global interrupt
  .word irq_collection   # 0x0000_0084: Vector 33:   DMA0 channel3 global interrupt
  .word irq_collection   # 0x0000_0088: Vector 34:   DMA0 channel4 global interrupt
  .word irq_collection   # 0x0000_008C: Vector 35:   DMA0 channel5 global interrupt
  .word irq_collection   # 0x0000_0090: Vector 36:   DMA0 channel6 global interrupt
  .word irq_adc          # 0x0000_0094: Vector 37:   ADC0 and ADC1 global interrupt
  .word irq_collection   # 0x0000_0098: Vector 38:   CAN0 TX interrupts
  .word irq_collection   # 0x0000_009C: Vector 39:   CAN0 RX0 interrupts
  .word irq_collection   # 0x0000_00A0: Vector 40:   CAN0 RX1 interrupts
  .word irq_collection   # 0x0000_00A4: Vector 41:   CAN0 EWMC interrupts
  .word irq_exti5        # 0x0000_00A8: Vector 42:   EXTI line[9:5] interrupts
  .word irq_collection   # 0x0000_00AC: Vector 43:   TIMER0 break interrupt
  .word irq_collection   # 0x0000_00B0: Vector 44:   TIMER0 update interrupt
  .word irq_collection   # 0x0000_00B4: Vector 45:   TIMER0 trigger and channel commutation interrupts
  .word irq_collection   # 0x0000_00B8: Vector 46:   TIMER0 channel capture compare interrupt
  .word irq_collection   # 0x0000_00BC: Vector 47:   TIMER1 global interrupt
  .word irq_collection   # 0x0000_00C0: Vector 48:   TIMER2 global interrupt
  .word irq_collection   # 0x0000_00C4: Vector 49:   TIMER3 global interrupt
  .word irq_collection   # 0x0000_00C8: Vector 50:   I2C0 event interrupt
  .word irq_collection   # 0x0000_00CC: Vector 51:   I2C0 error interrupt
  .word irq_collection   # 0x0000_00D0: Vector 52:   I2C1 event interrupt
  .word irq_collection   # 0x0000_00D4: Vector 53:   I2C1 error interrupt
  .word irq_collection   # 0x0000_00D8: Vector 54:   SPI0 global interrupt
  .word irq_collection   # 0x0000_00DC: Vector 55:   SPI1 global interrupt
  .word irq_collection   # 0x0000_00E0: Vector 56:   USART0 global interrupt
  .word irq_collection   # 0x0000_00E4: Vector 57:   USART1 global interrupt
  .word irq_collection   # 0x0000_00E8: Vector 58:   USART2 global interrupt
  .word irq_collection   # 0x0000_00EC: Vector 59:   EXTI line[15:10] interrupts
  .word irq_collection   # 0x0000_00F0: Vector 60:   RTC alarm from EXTI interrupt
  .word irq_collection   # 0x0000_00F4: Vector 61:   USBFS wakeup from EXTI interrupt
  .word 0                # 0x0000_00F8: Vector 62:   Reserved
  .word 0                # 0x0000_00FC: Vector 63:   Reserved
  .word 0                # 0x0000_0100: Vector 64:   Reserved
  .word 0                # 0x0000_0104: Vector 65:   Reserved
  .word 0                # 0x0000_0108: Vector 66:   Reserved
  .word 0                # 0x0000_010C: Vector 67:   Reserved
  .word 0                # 0x0000_0110: Vector 68:   Reserved
  .word irq_collection   # 0x0000_0114: Vector 69:   TIMER4 global interrupt
  .word irq_collection   # 0x0000_0118: Vector 70:   SPI2 global interrupt
  .word irq_collection   # 0x0000_011C: Vector 71:   UART3 global interrupt
  .word irq_collection   # 0x0000_0120: Vector 72:   UART4 global interrupt
  .word irq_collection   # 0x0000_0124: Vector 73:   TIMER5 global interrupt
  .word irq_collection   # 0x0000_0128: Vector 74:   TIMER6 global interrupt
  .word irq_collection   # 0x0000_012C: Vector 75:   DMA1 channel0 global interrupt
  .word irq_collection   # 0x0000_0130: Vector 76:   DMA1 channel1 global interrupt
  .word irq_collection   # 0x0000_0134: Vector 77:   DMA1 channel2 global interrupt
  .word irq_collection   # 0x0000_0138: Vector 78:   DMA1 channel3 global interrupt
  .word irq_collection   # 0x0000_013C: Vector 79:   DMA1 channel4 global interrupt
  .word 0                # 0x0000_0140: Vector 80:   Reserved
  .word 0                # 0x0000_0144: Vector 81:   Reserved
  .word irq_collection   # 0x0000_0148: Vector 82:   CAN1 TX interrupt
  .word irq_collection   # 0x0000_014C: Vector 83:   CAN1 RX0 interrupt
  .word irq_collection   # 0x0000_0150: Vector 84:   CAN1 RX1 interrupt
  .word irq_collection   # 0x0000_0154: Vector 85:   CAN1 EWMC interrupt
  .word irq_collection   # 0x0000_0158: Vector 86:   USBFS global interrupt

# -----------------------------------------------------------------------------
# Include the Forth core of Mecrisp-Quintus
# -----------------------------------------------------------------------------

  .include "../common/forth-core.s"

# -----------------------------------------------------------------------------
Reset: # Forth begins here
# -----------------------------------------------------------------------------

  # Initialise special registers for interrupt handling
  # Many thanks to Wolfgang Strauss

  # Disable interrupts
  csrrci zero, mstatus, 8    # MSTATUS: Clear Machine Interrupt Enable Bit

  # Set global number of level bits.
  li x15, 3 << 1             # Global number of level bits = 3
  li x14, ECLIC_cliccfg      # Possible range: 0..4
  sb x15, 0(x14)

  # Set global threshold level
  li x15, 3 << 1             # Global threshold = 64
  li x14, ECLIC_mth          # Only interrupts with a greater level than this will be able to
  sb x15, 0(x14)             # trigger an interrupt. Range: 0..255

  # Vector table setting
  la x15, vector_table       #                 Make sure address is 512-aligned.
  li x14, 0x08000000         #                 Physical start address of flash memory
  or x15, x15, x14
  csrrw zero, 0x307, x15     # MTVT (special): mtvt The base address of the eclic interrupt vector table.

  # Hardcoded exception handler:
  la x15, irq_fault          #        Make sure address is 64-aligned.
  ori x15, x15, 3            #        Set interrupt mode to ECLIC mode.
  csrrw zero, 0x305, x15     # MTVEC: Store address of exception handler and ECLIC mode in CSR mtvec.

  # Non-vectored interrupt setting
  la x15, irq_nonvector      #         Make sure address is 4-aligned.
  ori x15, x15, 1            #         Set LSB to 1: Indicates that this register (mtvt2)
  csrrw zero, 0x7EC, x15     # MTVT2:  contains the address of non-vectored interrupts.

  # NMI setting
  li x15, 0x200              #            Set bit [9] in mmisc_ctl. Result: the value of mnvec
  csrrs zero, 0x7d0, x15     # MMISC_CTL:  (read only register) is a mirror of the register mtvec and
                             #              NMIs and exceptions share the same service routine.
                             #               The field mcause.EXCCODE of an NMI is 0xfff.

  # Interrupts are configured properly now.

  # To simplify debugging, additionally configure the memory access error interrupt, vector 17:

  li x15, 0x7FC30100         # 7FC30100   E Vec Rise  127  Enabled, vectored handler, trigger on rising edge, threshold 127.
  li x14, vectorconfig_base
  sw x15, 17*4(x14)

  # Initialisations for terminal hardware, without stacks
  call uart_init

  # Catch the pointers for Flash dictionary
  .include "../common/catchflashpointers.s"

  welcome " for RISC-V RV32IMC on GD32VF103CB by Matthias Koch"

  # Memory access errors will go pending, but do not trigger unless interrupts are enabled globally.
  csrrsi zero, mstatus, 8    # MSTATUS: Set Machine Interrupt Enable Bit

  # Ready to fly !
  .include "../common/boot.s"
