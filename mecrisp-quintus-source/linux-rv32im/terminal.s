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
  Definition Flag_visible, "serial-emit"
serial_emit: # ( c -- ) Emit one character
# -----------------------------------------------------------------------------

  push x1
  call pause

  pushdatos # Put character which was buffered on the data stack into memory

  push x2
  push x3
  push x4
  push x5
  push x6
  push x7
  push x8
  push x9
  push x10
  push x11
  push x12
  push x13
  push x14
  push x15

    li x10, 1                    # stdout
    mv x11, x9                   # msg
    li x12, 1                    # length
    li x13, 0
    li x17, 64                   # _NR_sys_write
    ecall                        # system call

  pop x15
  pop x14
  pop x13
  pop x12
  pop x11
  pop x10
  pop x9
  pop x8
  pop x7
  pop x6
  pop x5
  pop x4
  pop x3
  pop x2

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

  push x2
  push x3
  push x4
  push x5
  push x6
  push x7
  push x8
  push x9
  push x10
  push x11
  push x12
  push x13
  push x14
  push x15

    li x10, 0                    # stdin
    mv x11, x9                   # msg
    li x12, 1                    # length
    li x13, 0
    li x17, 63                   # _NR_sys_read
    ecall                        # system call

  pop x15
  pop x14
  pop x13
  pop x12
  pop x11
  pop x10
  pop x9
  pop x8
  pop x7
  pop x6
  pop x5
  pop x4
  pop x3
  pop x2

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
  push x2
  push x3
  push x4
  push x5
  push x6
  push x7

  push x9
  push x10
  push x11
  push x12
  push x13
  push x14
  push x15

    lw x10, 12(x9) # a0
    lw x11,  8(x9) # a1
    lw x12,  4(x9) # a2
    lw x13,  0(x9) # a3

    mv x17, x8                  # TOS --> Syscall number
    ecall                       # system call
    mv x8, x10                  # Syscall result --> TOS

  pop x15
  pop x14
  pop x13
  pop x12
  pop x11
  pop x10
  pop x9

  pop x7
  pop x6
  pop x5
  pop x4
  pop x3
  pop x2
  pop x1

  addi x9, x9, 4*4 # Remove arguments from data stack
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

    li a0, 0
    li a1, 0
    li a2, 0
    li a3, 0
    li a7, 93                   # _NR_sys_exit
    ecall                       # system call
