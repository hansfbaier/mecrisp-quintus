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

# Interpreter und Optimierungen
# Interpreter and optimisations

# -----------------------------------------------------------------------------
  Definition Flag_visible, "evaluate" # ( -- )
# -----------------------------------------------------------------------------
  push x1
  call source             # Save current source

  # 2>r
  popdadouble x15, x14
  pushdouble x14, x15

  laf x14, Pufferstand  # Save >in and set to zero
  lw x15, 0(x14)
  push x15
  li x15, 0
  sw x15, 0(x14)

  call setsource          # Set new source
  call interpret          # Interpret

  laf x14, Pufferstand  # Restore >in
  pop x15
  sw x15, 0(x14)

  # 2r>
  popdouble x15, x14
  pushdadouble x14, x15

  pop x1
  j setsource          # Restore old source

#------------------------------------------------------------------------------
  Definition Flag_visible|Flag_variable, "hook-interpret" # ( -- addr )
  CoreVariable hook_interpret
#------------------------------------------------------------------------------
  pushdaaddrf hook_interpret
  ret
  .word interpret_vanilla

# -----------------------------------------------------------------------------
  Definition Flag_visible, "interpret" # ( -- )
interpret:
# -----------------------------------------------------------------------------

  laf x15, hook_interpret
  lw x15, 0(x15)

  .ifdef mipscore
  jr x15
  .else
  jalr zero, x15, 0
  .endif

# -----------------------------------------------------------------------------
  Definition Flag_visible, "(interpret)" # ( -- )
interpret_vanilla:
# -----------------------------------------------------------------------------
  push x1

1:# Bleibe solange in der Schleife, wie token noch etwas zurückliefert.
  # Stay in loop as long token can fetch something from input buffer.

  # Probe des Datenstackpointers.
  # Check pointer for datastack.

  laf x10, datenstackanfang   # Stacks fangen oben an und wachsen nach unten.
  bgeu x10, x9, 2f           # Wenn die Adresse kleiner oder gleich der Anfangsadresse ist, ist alles okay.
    writeln "Stack underflow"
    j quit

2:laf x10, datenstackende     # Solange der Stackzeiger oberhalb des Endes liegt, ist alles okay.
  bltu x10, x9, 3f
    writeln "Stack overflow"
    j quit

3: # Alles ok.  Stacks are fine.

# -----------------------------------------------------------------------------

  # Konstantenfaltungszeiger setzen, falls er das noch nicht ist.
  # Set Constant-Folding-Pointer
  laf x14, konstantenfaltungszeiger
  lw x7, 0(x14)
  bne x7, zero, 3f
    # Konstantenfaltungszeiger setzen.
    # If not set yet, set it now.
    mv x7, x9
    sw x7, 0(x14)
3:

# -----------------------------------------------------------------------------
  call token
  # ( Address Length )

  # Prüfe, ob der String leer ist  Check if token is empty - that designates an empty input buffer.
  bne x8, zero, 2f
    ddrop
    pop x1
    ret
2:

# -----------------------------------------------------------------------------
  # String aus Token angekommen.  We have a string to interpret.
  # ( Address Length )

  ddup
  call find # Probe, ob es sich um ein Wort aus dem Dictionary handelt:  Attemp to find token in dictionary.
  # ( Token-Addr Token-Length Addr Flags )

  popdadouble x11, x12
  #popda x11 # Flags
  #popda x12 # Einsprungadresse

  # ( Token-Addr Token-Length )

  # Registerkarte:
  #  x11: Flags                                  Flags
  #  x12: Einsprungadresse                       Code entry point
  #  x7: Konstantenfaltungszeiger               Constant folding pointer

  bne x12, zero, 4f
    # Nicht gefunden. Ein Fall für Number.
    # Entry-Address is zero if not found ! Note that Flags have very special meanings in Mecrisp !

    lw x10, 0(x9)
    mv x11, x8

    call number

  # Number gives back ( 0 ) or ( x 1 ).
  # Zero means: Not recognized.
  # Note that literals actually are not written/compiled here.
  # They are simply placed on stack and constant folding takes care of them later.

    popda x12   # Flag von Number holen
    bne x12, zero, 1b # Did number recognize the string ?
    # Zahl gefunden, alles gut. Interpretschleife fortsetzen.  Finished.

    # Number mochte das Token auch nicht.
    pushdadouble x10, x11
    #pushda x10
    #pushda x11
type_not_found_quit:
    call type
    writeln " not found."
    j quit

# -----------------------------------------------------------------------------
4:# Token im Dictionary gefunden. Found token in dictionary. Decide what to do.

  # ( Token-Addr Token-Length )

  # Registerkarte:
  #  x11: Flags                                  Flags
  #  x12: Einsprungadresse                       Code entry point
  #  x7: Konstantenfaltungszeiger               Constant folding pointer

  laf x13, state
  lw x13, 0(x13)
  bne x13, zero, 5f
    # Im Ausführzustand.  Execute.
    laf x14, konstantenfaltungszeiger
    li x7, 0   # Konstantenfaltungszeiger löschen  Clear constant folding pointer
    sw x7, 0(x14)  # Do not collect literals for folding in execute mode. They simply stay on stack.

    li x15, Flag_immediate_compileonly & ~Flag_visible
    and x13, x11, x15
    bne x13, x15, ausfuehren
      call type
      writeln " is compile-only."
      j quit

ausfuehren:
    ddrop
    pushda x12    # Adresse zum Ausführen   Code entry point
    call execute  #                         Execute it
    j 1b          # Interpretschleife fortsetzen.  Finished.

  # Registerkarte:
  #  x10: Stringadresse des Tokens, wird ab hier nicht mehr benötigt.
  #       Wird danach für die Zahl der benötigten Konstanten für die Faltung genutzt.
  #       From now on, this is number of constants that would be needed for folding this definition
  #  x11: Flags
  #  x13: Temporärer Register, ab hier: Konstantenfüllstand  Constant fill gauge of Datastack
  #  x12: Einsprungadresse                        Code entry point
  #  x7: Konstantenfaltungszeiger                Constant folding pointer

# -----------------------------------------------------------------------------
5:# Im Kompilierzustand.  In compile state.
    ddrop

    # Prüfe das Ramallot-Flag, das automatisch 0-faltbar bedeutet:
    # Ramallot-Words always are 0-foldable !
    # Check this first, as Ramallot is set together with foldability,
    # but the meaning of the lower 4 bits is different.

    andi x10, x11, Flag_ramallot & ~Flag_visible # Flagfeld auf Faltbarkeit hin prüfen
    bne x10, zero, interpret_faltoptimierung

    # Bestimme die Anzahl der zur Faltung bereitliegenden Konstanten:
    # Calculate number of folding constants available.

    sub x13, x7, x9 # Konstantenfüllstandszeiger - Aktuellen Stackpointer
    srli x13, x13, 2      # Durch 4 teilen  Divide by 4 to get number of stack elements.
    # Number of folding constants now available in x13.

    # Prüfe die Faltbarkeit des aktuellen Tokens:
    # Check for foldability.

    andi x10, x11, Flag_foldable & ~Flag_visible # Flagfeld auf Faltbarkeit hin prüfen
    beq x10, zero, konstantenschleife

#       # Check for opcodability.
#       movs r0, #Flag_opcodable & ~Flag_visible
#       ands r0, r1
#       beq.n .interpret_genugkonstanten # Flag is set
#       cmp r3, #0 # And at least one constant is available for folding.
#       beq.n .interpret_genugkonstanten
#         b.n .interpret_opcodierbar

interpret_genugkonstanten: # Not opcodable. Maybe foldable.
      # Prüfe, ob genug Konstanten da sind:
      # How many constants are necessary to fold this word ?
      andi x10, x11, 0x0F # Zahl der benötigten Konstanten maskieren
      bltu x13, x10, konstantenschleife

interpret_faltoptimierung:
        # Do folding by running the definition.
        # Note that Constant-Folding-Pointer is already set to keep track of results calculated.
        pushda x12 # Einsprungadresse bereitlegen  Code entry point
        call execute # Durch Ausführung falten      Fold by executing
        j 1b # Interpretschleife weitermachen     Finished.


konstantenschleife:
    # No constant folding was possible, but perhaps we can generate a special opcode for this ?

    sltiu x10, x13, 1 # Only if there is at least one constant available
    bne zero, x10, 2f

      andi x10, x11, Flag_opcodierbar & ~Flag_visible # Flagfeld auf Opcodierbarkeit hin prüfen
      beq x10, zero, 2f

        # Flags of Definition in x11
        # Entry-Point of Definition in x12
        # Number of folding constants available in x13

        pushda x12
        call suchedefinitionsende
        call execute
        j 1b

2:  # No optimizations possible. Compile the normal way.
    # Write all folding constants left into dictionary.

    call konstantenschreiben

# -----------------------------------------------------------------------------
  # Classic compilation.
  pushda x12 # Adresse zum klassischen Bearbeiten. Put code entry point on datastack.

  andi x12, x11, Flag_immediate & ~Flag_visible
  beq x12, zero, 6f
    # Es ist immediate. Immer ausführen. Always execute immediate definitions.
    call execute # Ausführen.
    j 1b # Zurück in die Interpret-Schleife.  Finished.

6:andi x12, x11, Flag_inline & ~Flag_visible
  beq x12, zero, 7f
    call inlinekomma # Direkt einfügen.        Inline the code
    j 1b # Zurück in die Interpret-Schleife  Finished.

7:call callkomma # Klassisch einkompilieren  Simply compile a call.
  j 1b # Zurück in die Interpret-Schleife  Finished.



# -----------------------------------------------------------------------------
konstantenschreiben: # Special internal entry point with register dependencies.
# -----------------------------------------------------------------------------
  push x1
  beq x13, zero, 7f # Null Konstanten liegen bereit ? Zero constants available ?
                    # Dann ist nichts zu tun.         Nothing to write.

konstanteninnenschleife:
    # Schleife über x7 :-)
    # Loop for writing all folding constants left.
    addi x13, x13, -1 # Weil Pick das oberste Element mit Null addressiert.
    pushda x13

    call pick
    call literalkomma

    bne x13, zero, konstanteninnenschleife

    # Die geschriebenen Konstanten herunterwerfen.
    # Drop constants written.

    addi x9, x7, -4 # TOS wurde beim drauflegen der Konstanten gesichert.
    drop         # Das alte TOS aus seinem Platz auf dem Stack zurückholen.

7:laf x14, konstantenfaltungszeiger
  li x7, 0   # Konstantenfaltungszeiger löschen  Clear constant folding pointer.
  sw x7, 0(x14)
  pop x1
  ret


#------------------------------------------------------------------------------
  Definition Flag_visible|Flag_variable, "hook-quit" # ( -- addr )
  CoreVariable hook_quit
#------------------------------------------------------------------------------
  pushdaaddrf hook_quit
  ret
  .word quit_vanilla  # Simple loop for default

# -----------------------------------------------------------------------------
  Definition Flag_visible, "quit" # ( -- )
quit:
# -----------------------------------------------------------------------------
  # Endlosschleife - muss LR nicht sichern.  No need for saving LR as this is an endless loop.
  # Stacks zurücksetzen
  # Clear stacks and tidy up.

  laf sp, returnstackanfang
  laf x9, datenstackanfang

  .ifdef initflash
  call initflash
  .endif

  laf x14, base
  li x15, 10      # Base decimal
  sw x15, 0(x14)

  laf x14, state
  li x15, 0       # Execute mode
  sw x15, 0(x14)

  laf x14, konstantenfaltungszeiger
  # li x15, 0       # Clear constant folding pointer
  sw x15, 0(x14)

  laf x14, Pufferstand
  # li x15, 0       # Set >IN to 0
  sw x15, 0(x14)

  laf x14, current_source
  # li x15, 0       # Empty TIB is source
  sw x15, 0(x14)
  laf x15, Eingabepuffer
  sw x15, 4(x14)

quit_intern:
  laf x15, hook_quit
  lw x15, 0(x15)

  .ifdef mipscore
  jr x15
  .else
  jalr zero, x15, 0
  .endif


# -----------------------------------------------------------------------------
  Definition Flag_visible, "(quit)" # ( -- )
quit_vanilla:  # Main loop of Forth system.
# -----------------------------------------------------------------------------
  call query
  call interpret
  writeln " ok."
  j quit_vanilla
