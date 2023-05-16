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

# Interrupt handler for MIPS
# Also see mips-v.s for MIPS <-> RISC-V register assignment

.macro initinterrupt Name, Asmname, Routine

#------------------------------------------------------------------------------
  Definition Flag_visible|Flag_variable, "irq-\Name" # ( -- addr )
  CoreVariable irq_hook_\Name
#------------------------------------------------------------------------------
  pushdatos
  laf x8, irq_hook_\Name
  ret
  .word \Routine  # Startwert für unbelegte Interrupts   Start value for unused interrupts

\Asmname:

  addiu sp, sp, -16*4

  .set noat
  sw  $1, 0*4(sp) # Assembler uses register $1 for temporary constructs
  laf $1, irq_hook_\Name
  .set at

  j irq_common

.endm

#------------------------------------------------------------------------------
irq_common: # Common framework for all interrupt entries
#------------------------------------------------------------------------------

  sw x1,   1*4(sp) # Required for Forth core...
  sw x14,  2*4(sp)
  sw x15,  3*4(sp)

  mflo x15         # Required for multiplication...
  sw x15,  4*4(sp)
  mfhi x15
  sw x15,  5*4(sp)

  sw x16,  6*4(sp) # Required for Acrobatics only...
  sw x17,  7*4(sp)
  sw x18,  8*4(sp)
  sw x19,  9*4(sp)
  sw x20, 10*4(sp)
  sw x21, 11*4(sp)
  sw x22, 12*4(sp)
  sw x23, 13*4(sp)
  sw x24, 14*4(sp)
  sw x25, 15*4(sp)

  .set noat
  lw $1, 0($1)
  jalr $1
  .set at

  lw x25, 15*4(sp) # Required for Acrobatics only...
  lw x24, 14*4(sp)
  lw x23, 13*4(sp)
  lw x22, 12*4(sp)
  lw x21, 11*4(sp)
  lw x20, 10*4(sp)
  lw x19,  9*4(sp)
  lw x18,  8*4(sp)
  lw x17,  7*4(sp)
  lw x16,  6*4(sp)

  lw x15,  5*4(sp) # Required for multiplication...
  mthi x15
  lw x15,  4*4(sp)
  mtlo x15

  lw x15,  3*4(sp) # Required for Forth core...
  lw x14,  2*4(sp)
  lw x1,   1*4(sp)

  .set noat
  lw $1,   0*4(sp) # Assembler uses register $1 for temporary constructs
  .set at

  addiu sp, sp, 16*4

  eret
