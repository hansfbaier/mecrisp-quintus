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

.equ MCM0_CPCR2, 0xE0080034

# -----------------------------------------------------------------------------
  Definition Flag_visible, "8flash!" # ( x1 x2 Addr -- )
eightflashstore: # Schreibt an die auf 8 gerade Adresse in den Flash.
# -----------------------------------------------------------------------------
  push_x1_x10_x12

  # write "8flash!"
  # call dots

  popda x10 # Adresse
  popda x12 # Inhalt zweiter Teil
  popda x11 # Inhalt erster Teil

  # Ist die gewünschte Stelle im Flash-Dictionary ? Außerhalb des Forth-Kerns ?
  laf x15, FlashDictionaryEnde
  bgeu x10, x15, 3f

  # Prüfe die Adresse: Sie muss auf 8 gerade sein:
  andi x15, x10, 7
  bne x15, zero, 3f

  # Ist an der gewünschten Stelle -1. im Speicher ?
  li x15, -1
  lw x14, 0(x10)
  bne x15, x14, 3f
  lw x14, 4(x10)
  bne x15, x14, 3f

  # Prüfe Inhalt. Schreibe nur, wenn es NICHT -1. ist.
  li x15, -1
  and x14, x11, x12
  beq x15, x14, 2f

  # Alles paletti. Schreibe tatsächlich !

  li x14, 0x40023000

  # Clear status

  li x15, 0x70
  sw x15, 0(x14)

  # Program phrase command with 64-Bit aligned address

  li x15, 0x00FFFFF8
  and x10, x10, x15
  li x15, 0x07000000
  or x10, x10, x15
  sw x10,  4(x14)

  sw x11,  8(x14) # Data low
  sw x12, 12(x14) # Data high

  # Run command

  li x15, 0x80
  sw x15, 0(x14)

  # Wait for completion

1:lw x15, 0(x14)
  andi x15, x15, 0x80
  beq x15, zero, 1b

  # Clear Cache

  li x14, MCM0_CPCR2
  li x15, 1
  sw x15, 0(x14)

2:pop_x1_x10_x12
  ret

3:writeln "Wrong address or data for writing flash !"
  j quit


# -----------------------------------------------------------------------------
  Definition Flag_visible, "flashpageerase" # ( Addr -- )
  # Löscht einen 4 kb großen Flashblock
flashpageerase:
# -----------------------------------------------------------------------------
  push x1

  # Ist die gewünschte Stelle im Flash-Dictionary ? Außerhalb des Forth-Kerns ?

  laf x15, FlashDictionaryEnde
  bgeu x8, x15, 2f

  li x14, 0x40023000

  # Clear status

  li x15, 0x70
  sw x15, 0(x14)

  # Erase sector command with 128-Bit aligned address

  li x15, 0x00FFFFF0
  and x8, x8, x15
  li x15, 0x09000000
  or x8, x8, x15
  sw x8, 4(x14)
  drop

  # Run command

  li x15, 0x80
  sw x15, 0(x14)

  # Wait for completion

1:lw x15, 0(x14)
  andi x15, x15, 0x80
  beq x15, zero, 1b

  # Clear Cache

  li x14, MCM0_CPCR2
  li x15, 1
  sw x15, 0(x14)

  pop x1
  ret

2:writeln "Wrong address for erasing flash !"
  j quit

# -----------------------------------------------------------------------------
  Definition Flag_visible, "eraseflash" # ( -- )
  # Löscht den gesamten Inhalt des Flashdictionaries.
# -----------------------------------------------------------------------------
        li x10, FlashDictionaryAnfang

eraseflash_intern:
        li x11, FlashDictionaryEnde
        li x12, -1

1:      lw x13, 0(x10)
        beq x13, x12, 2f
          pushda x10
            dup
            write "Erase block at  "
            call hexdot
            writeln " from Flash"
          call flashpageerase
2:      addi x10, x10, 4
        bne x10, x11, 1b
  writeln "Finished. Reset !"

  j Reset

# -----------------------------------------------------------------------------
  Definition Flag_visible, "eraseflashfrom" # ( Addr -- )
  # Beginnt an der angegebenen Adresse mit dem Löschen des Dictionaries.
# -----------------------------------------------------------------------------
  popda x10
  j eraseflash_intern
