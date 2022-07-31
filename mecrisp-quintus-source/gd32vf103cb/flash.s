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

.equ FLASH_Base, 0x40022000

.equ FLASH_ACR,     FLASH_Base + 0x00 # Flash Access Control Register
.equ FLASH_KEYR,    FLASH_Base + 0x04 # Flash Key Register
.equ FLASH_OPTKEYR, FLASH_Base + 0x08 # Flash Option Key Register
.equ FLASH_SR,      FLASH_Base + 0x0C # Flash Status Register
.equ FLASH_CR,      FLASH_Base + 0x10 # Flash Control Register
.equ FLASH_AR,      FLASH_Base + 0x14 # Flash Address Register

# -----------------------------------------------------------------------------
  Definition Flag_visible, "hflash!" # ( x Addr -- )
  # Schreibt an eine gerade Adresse in den Flash.
# -----------------------------------------------------------------------------
hflashstore:
  push_x1_x10_x11

  # Ist die gewünschte Stelle im Flash-Dictionary ?
  dup
  call addrinflash
  popda x15
  beq x15, zero, 3f

  # Außerhalb des Forth-Kerns ?
  laf x15, FlashDictionaryAnfang
  bltu x8, x15, 3f

  popda x10 # Adresse
  popda x11 # Inhalt.

  # Prüfe die Adresse: Sie muss gerade sein:
  andi x15, x10, 1
  bne x15, zero, 3f

  # Ist an der gewünschten Stelle $FFFF im Speicher ?
  lhu x15, 0(x10)
  li x14, 0xFFFF
  bne x15, x14, 3f

  # Prüfe Inhalt. Schreibe nur, wenn es NICHT -1 ist.
  li x15, 0xFFFF
  beq x11, x15, 2f

  # Alles paletti. Schreibe tatsächlich !

  li x14, FLASH_KEYR
  li x15, 0x45670123
  sw x15, 0(x14)
  li x15, 0xCDEF89AB
  sw x15, 0(x14)

  li x14, FLASH_CR
  li x15, 1 # Select Flash programming
  sw x15, 0(x14)

  # Flash-Speicher ist gespiegelt, die wirkliche Adresse liegt weiter hinten !
  # Flash memory is mirrored, use true address later for write
  li x14, 0x08000000
  add x10, x10, x14

  # Write to Flash !
  sh x11, 0(x10)

    # Wait for Flash BUSY Flag to be cleared
    li x14, FLASH_SR
1:    lw x15, 0(x14)
      andi x15, x15, 1
      bne x15, zero, 1b

  # Lock Flash after finishing this
  li x14, FLASH_CR
  li x15, 0x80
  sw x15, 0(x14)

2:pop_x1_x10_x11
  ret

3:writeln "Wrong address or data for writing flash !"
  j quit

# -----------------------------------------------------------------------------
  Definition Flag_visible, "flash!" # ( x Addr -- )
# -----------------------------------------------------------------------------
flashstore:
  push x1

  over
  li x15, 0xFFFF
  and x8, x8, x15
  over
  call hflashstore

  addi x8, x8, 2
  lw x15, 0(x9)
  srli x15, x15, 16
  sw x15, 0(x9)
  call hflashstore

  pop x1
  ret

# -----------------------------------------------------------------------------
  Definition Flag_visible, "flashpageerase" # ( Addr -- )
  # Löscht einen 1kb großen Flashblock.  Deletes one 1kb Flash page.
flashpageerase:
# -----------------------------------------------------------------------------
  push x1

  # Ist die gewünschte Stelle im Flash-Dictionary ?
  dup
  call addrinflash
  popda x15
  beq x15, zero, 2f

  # Außerhalb des Forth-Kerns ?
  laf x15, FlashDictionaryAnfang
  bltu x8, x15, 2f

  li x14, FLASH_KEYR
  li x15, 0x45670123
  sw x15, 0(x14)
  li x15, 0xCDEF89AB
  sw x15, 0(x14)

  # Enable erase
  li x14, FLASH_CR
  li x15, 2 # Set Erase bit
  sw x15, 0(x14)

  # Flash-Speicher ist gespiegelt, die wirkliche Adresse liegt weiter hinten !
  # Flash memory is mirrored, use true address later for write
  li x14, 0x08000000
  add x8, x8, x14

  # Set page to erase
  li x14, FLASH_AR
  sw x8, 0(x14)
  drop

  # Start erasing
  li x14, FLASH_CR
  li x15, 0x42 # Start + Erase
  sw x15, 0(x14)

    # Wait for Flash BUSY Flag to be cleared
    li x14, FLASH_SR
1:    lw x15, 0(x14)
      andi x15, x15, 1
      bne x15, zero, 1b

  # Lock Flash after finishing this
  li x14, FLASH_CR
  li x15, 0x80
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
