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

  .ifdef mipscore

# -----------------------------------------------------------------------------
  Definition Flag_visible, "mips"
# -----------------------------------------------------------------------------
  push x1
  welcome " for MIPS by Matthias Koch"
  pop x1
  ret

  .else

# -----------------------------------------------------------------------------
  Definition Flag_visible, "risc-v"
# -----------------------------------------------------------------------------
  push x1
  welcome " for RISC-V by Matthias Koch"
  pop x1
  ret

  .endif


# -----------------------------------------------------------------------------
  Definition Flag_visible, "hex."
hexdot: # ( u -- ) Print an unsigned number in Base 16, independent of number subsystem.
# -----------------------------------------------------------------------------

  push_x1_x10_x12

  popda x10   # Value to print
  li x11, 32  # Number of bits left

1:pushdatos
  srli x8, x10, 28
  andi x8, x8, 0xF
  li x12, 10

  bltu x8, x12, 2f
    addi x8, x8, 55-48
2:addi x8, x8, 48
  call emit

  slli x10, x10, 4
  addi x11, x11, -4
  bne x11, zero, 1b

  pop_x1_x10_x12
  j space


# -----------------------------------------------------------------------------
  Definition Flag_visible, ".rs"  # Print out return stack
# -----------------------------------------------------------------------------

  push_x1_x10_x11
  write "Returnstack: [ "

  # Berechne den Stackfüllstand  Calculate number of elements on datastack
  laf x15, returnstackanfang # Anfang laden
  sub x15, x15, sp # und aktuellen Stackpointer abziehen
  blt x15, zero, 2f # Stack underflow ? Do not print a zillion of locations.
  srli x11, x15, 2 # Durch 4 teilen  Divide by 4 Bytes/Element
  addi x11, x11, 1 # Ein Element mehr anzeigen

  pushda x11
  call hexdot
  write "] "

  beq x11, zero, 2f # Bei einem leeren Stack ist nichts auszugeben.  Don't print elements for an empty stack

  laf x10, returnstackanfang # Anfang laden, wo ich beginne:  Start here !

1: # Hole das Stackelement !  Fetch stack element directly
   pushdatos
   lw x8, 0(x10)
   call hexdot

   addi x10, x10, -4
   addi x11, x11, -1
   bne x11, zero, 1b

2: writeln " *>"

  pop_x1_x10_x11
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "words" # Print list of words with debug information
words: # Malt den Dictionaryinhalt
# -----------------------------------------------------------------------------
  push x1

  writeln ""

  call dictionarystart

1:# Adresse:
  write "Address: "
  dup
  call hexdot

  # Link
  write "Link: "
  dup
  lw x8, 0(x8)
  call hexdot

  # Flagfeld
  write "Flags: "
  dup
  lw x8, 4(x8)
  call hexdot

  # Einsprungadresse
  write "Code: "
  dup
  addi x8, x8, 8
  call skipstring
  call hexdot

  write "Name: "
  dup
  addi x8, x8, 8
  call ctype

  writeln ""

  call dictionarynext
  popda x15
  beq x15, zero, 1b

  drop

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "unused" # Bytes free for compilation in current memory area
# -----------------------------------------------------------------------------
  push x1
  call here

  call compiletoramq
  popda x15
  bne x15, zero, unused_ram

    laf x15, FlashDictionaryEnde
    j unused_common

unused_ram:
  call flashvarhere
  popda x15

unused_common:
  sub x8, x15, x8

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "h.s"  # Print out data stack
# -----------------------------------------------------------------------------
  la x15, hexdot
  j 1f

# -----------------------------------------------------------------------------
  Definition Flag_visible, ".s"  # Print out data stack
# -----------------------------------------------------------------------------
  la x15, dot
  j 1f

# -----------------------------------------------------------------------------
  Definition Flag_visible, "u.s"  # Print out data stack
# -----------------------------------------------------------------------------
  la x15, udot

1:push_x1_x10_x13
  mv x10, x15
  write "Stack: [ "

  laf x14, base
  lw x13, 0(x14)
  li x15, 10
  sw x15, 0(x14)

  # Berechne den Stackfüllstand  Calculate number of elements on datastack
  laf x11, datenstackanfang # Anfang laden
  sub x11, x11, x9 # und aktuellen Stackpointer abziehen
  blt x11, zero, 2f # Stack underflow ? Do not print a zillion of locations.
  srli x11, x11, 2 # Durch 4 teilen  Divide by 4 Bytes/Element

  pushda x11
  call dot
  write "] "

  laf x14, base
  sw x13, 0(x14)

  blt x11, zero, 2f # Stack underflow ? Do not print a zillion of locations.

  beq x11, zero, 2f # Bei einem leeren Stack ist nichts auszugeben.  Don't print elements for an empty stack

  laf x12, datenstackanfang - 4 # Anfang laden, wo ich beginne:  Start here !

1: # Hole das Stackelement !  Fetch stack element directly
   pushdatos
   lw x8, 0(x12)

  .ifdef mipscore
    jalr x1, x10
  .else
    jalr x1, x10, 0
  .endif

   addi x12, x12, -4
   addi x11, x11, -1
   bne x11, zero, 1b

2: # TOS zeigen  Print TOS
   write " TOS: "
   pushda x8

  .ifdef mipscore
    jalr x1, x10
  .else
    jalr x1, x10, 0
  .endif

   writeln " *>"

   pop_x1_x10_x13
   ret


  .ifdef debug # Only necessary for deep core debugging...

# -----------------------------------------------------------------------------
  Definition Flag_visible, "hex.s"  # Print out data stack, do not use number subsystem
dots:
# -----------------------------------------------------------------------------

  push_x1_x10_x11
  write "Stack: [ "

  # Berechne den Stackfüllstand  Calculate number of elements on datastack
  laf x11, datenstackanfang # Anfang laden
  sub x11, x11, x9 # und aktuellen Stackpointer abziehen
  blt x11, zero, 2f # Stack underflow ? Do not print a zillion of locations.
  srli x11, x11, 2 # Durch 4 teilen  Divide by 4 Bytes/Element

  pushda x11
  call hexdot
  write "] "

  beq x11, zero, 2f # Bei einem leeren Stack ist nichts auszugeben.  Don't print elements for an empty stack

  laf x10, datenstackanfang - 4 # Anfang laden, wo ich beginne:  Start here !

1: # Hole das Stackelement !  Fetch stack element directly
   pushdatos
   lw x8, 0(x10)
   call hexdot

   addi x10, x10, -4
   addi x11, x11, -1
   bne x11, zero, 1b

2: # TOS zeigen  Print TOS
   write " TOS: "
   dup
   call hexdot
   writeln " *>"

   pop_x1_x10_x11
   ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "dump"
dump: # ( addr len -- )
# -----------------------------------------------------------------------------
  push_x1_x10
  writeln ""

  popda x10        # Length
  add x10, x10, x8 # Stop address

1:dup
  call hexdot
  write ": "

  .ifdef compressed_isa
  pushdatos
  lhu x8, 0(x8)
  call hexdot
  writeln ""
  addi x8, x8, 2
  .else
  pushdatos
  lw x8, 0(x8)
  call hexdot
  writeln ""
  addi x8, x8, 4
  .endif

  bgeu x10, x8, 1b

  drop
  pop_x1_x10
  ret

  .endif

