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

# Schreiben und Löschen des Flash-Speichers im Stellaris.

# In diesem Chip gibt es nur 32-aligned-Schreibzugriffe, die aber dafür beliebig 1->0 setzen können.
# Auch mehrere Schreibzugriffe auf eine Word-Stelle sind damit möglich.
# Deshalb laufen all die kleineren Schreibzugriffe über den 32-Bit-Zugriff.
# Dies ist aber sehr speziell und muss für andere Chips sicherlich ganz neu geschrieben werden.

# Write and Erase Flash in TM4C1294.
# Porting: Rewrite this ! You need hflash! and - as far as possible - cflash!

.equ FLASH_FMA, 0x400FD000
.equ FLASH_FMD, 0x400FD004
.equ FLASH_FMC, 0x400FD008

.equ FLASH_FMC2, 0x400FD020
.equ FLASHCONF,  0x400FDFC8

# -----------------------------------------------------------------------------
  Definition Flag_visible, "flash!" # ( x Addr -- )
  # Schreibt an die auf 4 gerade Adresse in den Flash.
# -----------------------------------------------------------------------------
flashstore:
  push x10
  push x11
  push x12
  push x13

  popda x10 # Adresse
  popda x11 # Inhalt.

  # Prüfe die Adresse: Sie muss auf 4 gerade sein:
  andi x12, x10, 3
  bne x12, zero, 3f

  # Ist an der gewünschten Stelle -1 im Speicher ? Muss noch ersetzt werden durch eine Routine, die prüft, ob nur 1->0 Wechsel auftreten.
  lw x12, 0(x10)
  li x15, -1
  bne x12, x15, 3f

  # Ist die gewünschte Stelle im Flash-Dictionary ? Außerhalb des Forth-Kerns ?
  li x13, FlashDictionaryAnfang
  bltu x10, x13, 3f

  # Prüfe Inhalt. Schreibe nur, wenn es NICHT -1 ist.
  li x15, -1
  beq x11, x15, 2f

  # Alles paletti. Schreibe tatsächlich !
  li x12, FLASH_FMD # 1. Write source data to the FMD register.
  sw x11, 0(x12)

  li x12, FLASH_FMA # 2. Write the target address to the FMA register.
  sw x10, 0(x12)

  li x12, FLASH_FMC # 3. Write the Flash memory write key and the WRITE bit (a value of 0xA442.0001) to the FMC register.
  li x13, 0xA4420001
  sw x13, 0(x12)

1:lw x13, 0(x12)       # 4. Poll the FMC register until the WRITE bit is cleared.
  andi x13, x13, 1
  bne x13, zero, 1b

2:pop x13
  pop x12
  pop x11
  pop x10
  ret

3:writeln "Wrong address or data for writing flash !"
  j quit


# -----------------------------------------------------------------------------
  Definition Flag_visible, "flashpageerase" # ( Addr -- )
  # Löscht einen 16kb großen Flashblock
flashpageerase:
# -----------------------------------------------------------------------------
  # Lösche gleich und ohne viel Federlesen.
  push x10
  push x11
  push x12
  push x13

  popda x10 # Adresse zum Löschen holen Address to erase

  li x11, 0xFFFFC000 # Align to begin of 16 kb Flash block
  and x10, x10, x11

  # Ist die gewünschte Stelle im Flash-Dictionary ? Außerhalb des Forth-Kerns ?
  li x13, FlashDictionaryAnfang
  bltu x10, x13, 3b

  li x12, FLASH_FMA # 1. Write the page address to the FMA register.
  sw x10, 0(x12)

  li x12, FLASH_FMC # 2. Write the Flash memory write key and the ERASE bit (a value of 0xA442.0002) to the FMC register.
  li x13, 0xA4420002
  sw x13, 0(x12)

1:lw x13, 0(x12)       # 3. Poll the FMC register until the ERASE bit is cleared
  andi x13, x13, 2
  bne x13, zero, 1b

  pop x13
  pop x12
  pop x11
  pop x10
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
