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

# Interrupt handling and CSR register access


       # ECLIC register constants (ECLIC: Enhanced Core Local Interrupt Controller)

        .equ ECLIC_cliccfg       , 0xd2000000  #  8 bit read/write
        .equ ECLIC_clicinfo      , 0xd2000004  # 32 bit read only
        .equ ECLIC_mth           , 0xd200000b  #  8 bit read/write


        .equ vectorconfig_base   ,  0xd2001000

       # The following 4 registers exist for each of the 87 possible interrupt sources

        .equ offset_pending      , 0
        .equ offset_enabled      , 1
        .equ offset_attributes   , 2
        .equ offset_control      , 3

# 0 constant vectorconfig-ip   \ Interrupt Pending:    0: Not Pending, 1: Pending
# 1 constant vectorconfig-ie   \ Interrupt Enable:     0: Disabled,    1: Enabled
# 2 constant vectorconfig-attr \ Interrupt Attributes  0: Non-Vectored 1: Vectored   Bits 2:1 Trigger on 0: Rising Edge, 1: Falling Edge, 2: Level, 3: Level, too ?
# 3 constant vectorconfig-ctl  \ Interrupt Control     Interrupt threshold, range 0 to 255. Usually set to 127.

  .include "../common/interrupt-common.s"
  .include "../common/cycles.s"

# -----------------------------------------------------------------------------
  Definition Flag_visible, "mepc!" # Where did it occour ?
mepc_store:
# -----------------------------------------------------------------------------
  csrrw x0, mepc, x8
  drop
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "mepc@" # Where did it occour ?
mepc_fetch:
# -----------------------------------------------------------------------------
  pushdatos
  csrrs x8, mepc, zero
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "mcause@" # Which interrupt ?
mcause_fetch:
# -----------------------------------------------------------------------------
  pushdatos
  csrrs x8, mcause, zero
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "mtval@" # Which value ? Important for memory errors.
mtval_fetch:
# -----------------------------------------------------------------------------
  pushdatos
  csrrs x8, mtval, zero
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "memfault"  # Message for wild memory access
memfault:                              #
# -----------------------------------------------------------------------------
  push x1
  write "Memory access error"
  j unhandled_intern

# -----------------------------------------------------------------------------
  Definition Flag_visible, "unhandled-nonvector" # Message for wild interrupts
unhandled_nonvector:                             #   and handler for unused nonvectored interrupts
# -----------------------------------------------------------------------------
  push x1
  write "Unhandled Interrupt (non-vectored)"
  j unhandled_intern

# -----------------------------------------------------------------------------
  Definition Flag_visible, "unhandled" # Message for wild interrupts
unhandled:                             #   and handler for unused interrupts
# -----------------------------------------------------------------------------
  push x1
  write "Unhandled Interrupt (vectored)"

unhandled_intern:
  call trap_signature

  # Clear pending interrupt in ECLIC

  csrrs x15, mcause, zero     # Extract the interrupt number
  li x14, 0xFFF
  and x15, x15, x14

  slli x15, x15, 2            # Clear interrupt# pending bit to avoid endless
  li x14, vectorconfig_base   # retrigger in non-vectored interrupts
  add x15, x15, x14
  sb zero, offset_pending(x15)

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "fault" # Message for unhandled exceptions
fault:
# -----------------------------------------------------------------------------
  push x1

  write "Unhandled Exception"
  call trap_signature

  # Advance the location we are returning to in order to skip the faulty instruction
  csrrs x15, mepc, zero
  lhu x14, 0(x15)     # Fetch the opcode which caused this exception

  andi x14, x15,  3   # Compressed opcodes end with %00, %01 or %10. Normal 4 byte opcodes end with %11.
  addi x14, x14, -3   # Gives zero for long opcodes only

  addi x15, x15,  2   # Skip 2 bytes for a compressed opcode
  bne  x14, zero, 1f
    addi x15, x15,  2 # Skip 4 bytes in total for a long opcode

1:csrrw x0, mepc, x15 # Set return address.

  pop x1
  ret

# -----------------------------------------------------------------------------
trap_signature:
# -----------------------------------------------------------------------------
  push x1

  write " mcause: "
  call mcause_fetch
  call hexdot

  write "mepc: "
  call mepc_fetch
  call hexdot

  write "mtval: "
  call mtval_fetch
  call hexdot

  writeln "!"

  pop x1
  ret

# -----------------------------------------------------------------------------
  .include "../common/irq-handler.s"
# -----------------------------------------------------------------------------

# -----------------------------------------------------------------------------
# Fault and collection vectors, special:
# -----------------------------------------------------------------------------

initinterrupt  fault,      irq_fault,      fault, 6  # In CLIC mode, the trap entry must be 64 bytes aligned

initinterrupt  nonvector,  irq_nonvector,  unhandled_nonvector
initinterrupt  collection, irq_collection, unhandled

# -----------------------------------------------------------------------------
# For all these vectors in the interrupt vector table you may wish to use from Forth:
# -----------------------------------------------------------------------------

initinterrupt  software,   irq_software,   unhandled
initinterrupt  timer,      irq_timer,      unhandled
initinterrupt  memfault,   irq_memfault,   memfault
initinterrupt  exti0,      irq_exti0,      unhandled
initinterrupt  exti1,      irq_exti1,      unhandled
initinterrupt  exti2,      irq_exti2,      unhandled
initinterrupt  exti3,      irq_exti3,      unhandled
initinterrupt  exti4,      irq_exti4,      unhandled
initinterrupt  exti5,      irq_exti5,      unhandled
initinterrupt  adc,        irq_adc,        unhandled

#              Forth-Name  Assembler-Name  Default handler
