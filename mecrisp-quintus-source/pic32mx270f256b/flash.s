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

.equ NVMCON,  0xbf80f400
.equ NVMKEY,  0xbf80f410
.equ NVMADDR, 0xbf80f420
.equ NVMDATA, 0xbf80f430
.equ NVMSRCADDR, 0xbf80f440

# -----------------------------------------------------------------------------
  Definition Flag_visible, "flash!" # ( x Addr -- )
  # Schreibt an die auf 4 gerade Adresse in den Flash.
# -----------------------------------------------------------------------------
flashstore:
  push x1

  push x10
  push x11
  push x12
  push x13

  popda x10 # Adresse
  popda x11 # Inhalt.

  # Prüfe Inhalt. Schreibe nur, wenn es NICHT -1 ist.
  li x15, -1
  beq x11, x15, 2f

  # Prüfe die Adresse: Sie muss auf 4 gerade sein:
  andi x12, x10, 3
  bne x12, zero, 3f

  # Ist an der gewünschten Stelle -1 im Speicher ?
  lw x12, 0(x10)
  li x15, -1
  bne x12, x15, 3f

  # Ist die gewünschte Stelle im Flash-Dictionary ? Außerhalb des Forth-Kerns ?
  li x13, FlashDictionaryAnfang
  bltu x10, x13, 3f

  # Alles paletti. Schreibe tatsächlich !

  li x15, 0x1FFFFFFF # --> Physical address
  and x10, x10, x15

  li x14, NVMDATA
  sw x11, 0(x14)

  li x14, NVMADDR
  sw x10, 0(x14)

  li x14, NVMCON
  li x15, 0x4001
  sw x15, 0(x14)

  li x14, NVMKEY
  li x15, 0xAA996655
  sw x15, 0(x14)
  li x15, 0x556699AA
  sw x15, 0(x14)

  li x14, NVMCON
  li x15, 0xC001
  sw x15, 0(x14)

1:lw x15, 0(x14)
  andi x15, x15, 0x8000
  bne x15, zero, 1b

  sw zero, 0(x14)

2:pop x13
  pop x12
  pop x11
  pop x10

  pop x1
  ret

3:writeln "Wrong address or data for writing flash !"
  j quit


# -----------------------------------------------------------------------------
  Definition Flag_visible, "flashpageerase" # ( Addr -- )
  # Löscht einen 1kb großen Flashblock
flashpageerase:
# -----------------------------------------------------------------------------
  # Lösche gleich und ohne viel Federlesen.
  push x1

  push x10
  push x11
  push x12
  push x13

  popda x10 # Adresse zum Löschen holen

  # Ist die gewünschte Stelle im Flash-Dictionary ? Außerhalb des Forth-Kerns ?
  li x13, FlashDictionaryAnfang
  bltu x10, x13, 3b

  # li x15, 0x1FFFF400 # Start address of 1 kb page, physical address
  li x15, 0x1FFFFFFF # --> Physical address
  and x10, x10, x15

  li x14, NVMADDR
  sw x10, 0(x14)

  li x14, NVMCON
  li x15, 0x4004
  sw x15, 0(x14)

  li x14, NVMKEY
  li x15, 0xAA996655
  sw x15, 0(x14)
  li x15, 0x556699AA
  sw x15, 0(x14)

  li x14, NVMCON
  li x15, 0xC004
  sw x15, 0(x14)

1:lw x15, 0(x14)
  andi x15, x15, 0x8000
  bne x15, zero, 1b

  sw zero, 0(x14)

  pop x13
  pop x12
  pop x11
  pop x10

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
