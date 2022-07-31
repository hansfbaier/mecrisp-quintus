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

.include "../common/terminalhooks.s"

# -----------------------------------------------------------------------------

# Stack pointer is $29 in MIPS for normal call convention. Take care when doing Syscalls !
.macro push_mips register
  addiu $29, $29, -4
  sw \register, 0($29)
.endm

.macro pop_mips register
  lw \register, 0($29)
  addiu $29, $29, 4
.endm

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -----------------------------------------------------------------------------

  push x1
  call pause

  pushdatos # Put character which was buffered on the data stack into memory

  push_mips x1
  push_mips x2
  push_mips x3
  push_mips x4
  push_mips x5
  push_mips x6
  push_mips x7
  push_mips x8
  push_mips x9
  push_mips x10
  push_mips x11
  push_mips x12
  push_mips x13
  push_mips x14
  push_mips x15

  mv  x5, x9      # Use data stack pointer as location for the character to emit
  li  x4, 1       # STDOUT
  li  x6, 1       # Length: 1
  li  x2, 4004    # Syscall number
  syscall

  pop_mips x15
  pop_mips x14
  pop_mips x13
  pop_mips x12
  pop_mips x11
  pop_mips x10
  pop_mips x9
  pop_mips x8
  pop_mips x7
  pop_mips x6
  pop_mips x5
  pop_mips x4
  pop_mips x3
  pop_mips x2
  pop_mips x1

  ddrop

  pop x1
  ret


# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key"
serial_key: # ( -- c ) Receive one character
# -----------------------------------------------------------------------------

  push x1
  call pause

  pushdaconst 0  # Save old content of TOS into data stack memory, zero out TOS
  pushdatos      # Allocate one more cell on datastack for the syscall to fill

  push_mips x1
  push_mips x2
  push_mips x3
  push_mips x4
  push_mips x5
  push_mips x6
  push_mips x7
  push_mips x8
  push_mips x9
  push_mips x10
  push_mips x11
  push_mips x12
  push_mips x13
  push_mips x14
  push_mips x15

  mv  x5, x9      # Use data stack pointer as location for the character to emit
  li  x4, 0       # STDIN
  li  x6, 1       # Length: 1
  li  x2, 4003    # Syscall number
  syscall

  pop_mips x15
  pop_mips x14
  pop_mips x13
  pop_mips x12
  pop_mips x11
  pop_mips x10
  pop_mips x9
  pop_mips x8
  pop_mips x7
  pop_mips x6
  pop_mips x5
  pop_mips x4
  pop_mips x3
  pop_mips x2
  pop_mips x1

  drop # Put syscall result from data stack memory into TOS

  pop x1
  ret


# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-emit?"
serial_qemit:  # ( -- ? ) Ready to send a character ?
# -----------------------------------------------------------------------------
  push x1
  call pause
  pushdaconst -1
  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "serial-key?"
serial_qkey:  # ( -- ? ) Is there a key press ?
# -----------------------------------------------------------------------------
  push x1
  call pause
  pushdaconst -1
  pop x1
  ret

# -----------------------------------------------------------------------------
 Definition Flag_visible, "syscall" # ( a0 a1 a2 a3 Syscall# -- result )
# -----------------------------------------------------------------------------

  push x1

  push_mips x1
  push_mips x2
  push_mips x3
  push_mips x4
  push_mips x5
  push_mips x6
  push_mips x7

  push_mips x9
  push_mips x10
  push_mips x11
  push_mips x12
  push_mips x13
  push_mips x14
  push_mips x15

  mv x2, x8 # TOS --> Syscall number

  lw x7,  0(x9) # a3
  lw x6,  4(x9) # a2
  lw x5,  8(x9) # a1
  lw x4, 12(x9) # a0

  syscall

  mv x8, x2 # Syscall result --> TOS

  pop_mips x15
  pop_mips x14
  pop_mips x13
  pop_mips x12
  pop_mips x11
  pop_mips x10
  pop_mips x9

  pop_mips x7
  pop_mips x6
  pop_mips x5
  pop_mips x4
  pop_mips x3
  pop_mips x2
  pop_mips x1

  addi x9, x9, 4*4 # Remove arguments from data stack

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_foldable_0, "arguments" # ( -- a-addr )
# -----------------------------------------------------------------------------
  pushdatos
  laf x8, arguments
  lw x8, 0(x8)
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "reset"
# -----------------------------------------------------------------------------
  j Reset

# -----------------------------------------------------------------------------
  Definition Flag_visible, "bye"
bye:
# -----------------------------------------------------------------------------
  li x4, 0      # Error code
  li x2, 4001   # Syscall code
  syscall
