@
@    Mamihlapinatapai - A Risc-V instruction set emulator running on ARM
@    Copyright (C) 2018  Matthias Koch
@
@    This program is free software: you can redistribute it and/or modify
@    it under the terms of the GNU General Public License as published by
@    the Free Software Foundation, either version 3 of the License, or
@    (at your option) any later version.
@
@    This program is distributed in the hope that it will be useful,
@    but WITHOUT ANY WARRANTY; without even the implied warranty of
@    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
@    GNU General Public License for more details.
@
@    You should have received a copy of the GNU General Public License
@    along with this program.  If not, see <http://www.gnu.org/licenses/>.
@

@ How to use:

@ Include the binary into your Risc-V 32 IM project.
@
@ Vector table needs to be:
@  0: Pointer to a RAM location with 128 bytes free space for registers.
@  4: Start address of the emulator binary anywhere +1 for Thumb entry
@
@ Risc-V execution starts immediately after this binary, which is fully relocatable.

@ To do:
@   Synch, System and Counter opcodes ?

.syntax unified
.cpu cortex-m0
.thumb

@ Register usage:
@
@ r0  Base address of the register memory block
@ r1  PC of RISC-V
@ r2  Current instruction opcode
@ r3  decode_funct3 and scratch register afterwards
@ r4  Scratch register
@ r5  decode_rs1
@ r6  decode_rs2
@ r7  write_rd


@ -----------------------------------------------------------------------------
@   Macro definitions
@ -----------------------------------------------------------------------------

.macro decode_funct3 @ --> r3
  lsls r3, r2,      31-14
  lsrs r3, r3, 12 + 31-14
.endm

.macro decode_rs1 @ --> r5
  lsls r5, r2,      31-19
  lsrs r5, r5, 15 + 31-19
  lsls r5, r5,             2
  ldr r5, [r0, r5]
.endm

.macro decode_rs2 @ --> r6
  lsls r6, r2,      31-24
  lsrs r6, r6, 20 + 31-24
  lsls r6, r6,             2
  ldr r6, [r0, r6]
.endm

@ -----------------------------------------------------------------------------
@   Immediate decoders. They are either short or used once only.

.macro decode_imm_s @ --> r7
  lsls r7, r2,      31-11
  lsrs r7, r7,  7 + 31-11

  asrs r4, r2, 25
  lsls r4, r4,  5
  orrs r7, r4
.endm

.macro decode_imm_sb @ --> r7
  lsls r7, r2,      31-11
  lsrs r7, r7,  8 + 31-11
  lsls r7, r7,             1

  lsls r4, r2,      31-30
  lsrs r4, r4, 25 + 31-30
  lsls r4, r4,             5
  orrs r7, r4

  lsls r4, r2,      31-7
  lsrs r4, r4,  7 + 31-7
  lsls r4, r4,            11
  orrs r7, r4

  asrs r4, r2, 31
  lsls r4, r4, 12
  orrs r7, r4
.endm

.macro decode_imm_i @ --> r7
  asrs r7, r2, 20
.endm

.macro decode_imm_u @ --> r7
  lsrs r7, r2, 12
  lsls r7, r7, 12
.endm

.macro decode_imm_uj @ --> r7
  lsls r7, r2,      31-30
  lsrs r7, r7, 21 + 31-30
  lsls r7, r7,             1

  lsls r4, r2,      31-20
  lsrs r4, r4, 20 + 31-20
  lsls r4, r4,            11
  orrs r7, r4

  lsls r4, r2,      31-19
  lsrs r4, r4, 12 + 31-19
  lsls r4, r4,            12
  orrs r7, r4

  asrs r4, r2, 31
  lsls r4, r4, 20
  orrs r7, r4
.endm

@ -----------------------------------------------------------------------------
@   End of macro definitions
@ -----------------------------------------------------------------------------



@ -----------------------------------------------------------------------------
mamihlapinatapai:
@ -----------------------------------------------------------------------------

  @ Start address for emulated execution at the end of the 1 kb binary blob relative to PC
  adr.n r1, riscvboot

  @ Base address of the register memory block:
  mov r0, sp

  @ Clear the memory block, zero out all Risc-V registers
  movs r2, #0
  movs r3, #0
1:str r3, [r0, r2]
  adds r2, #4
  cmp r2, #4*32
  bne 1b

  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_load:
@ decode_rs1       @ --> r5
  decode_imm_i     @ --> r7
@ decode_funct3    @ --> r3

  cmp r3, 0 @ lb
  bne 1f
    ldrb r7, [r5, r7]
    sxtb r7, r7
    b.n write_rd_finish
1:cmp r3, 1 @ lh
  bne 1f
    ldrh r7, [r5, r7]
    sxth r7, r7
    b.n write_rd_finish
1:cmp r3, 2 @ lw
  bne 1f
    ldr r7, [r5, r7]
    b.n write_rd_finish
1:cmp r3, 4 @ lbu
  bne 1f
    ldrb r7, [r5, r7]
    b.n write_rd_finish
1:cmp r3, 5 @ lhu
  bne.n continue
    ldrh r7, [r5, r7]
    b.n write_rd_finish

@ -----------------------------------------------------------------------------

execute_store:
@ decode_rs1       @ --> r5
@ decode_rs2       @ --> r6
  decode_imm_s     @ --> r7
@ decode_funct3    @ --> r3

  cmp r3, 0 @ sb
  bne 1f
    strb r6, [r5, r7]
    b.n continue

1:cmp r3, 1 @ sh
  bne 1f
    strh r6, [r5, r7]
    b.n continue

1:cmp r3, 2 @ sw
  bne.n continue
    str r6, [r5, r7]
    b.n continue

@ -----------------------------------------------------------------------------

execute_jal:
  decode_imm_uj @ --> r7
  adds r3, r1, 4
  adds r1, r7
  b.n 1f

@ -----------------------------------------------------------------------------

execute_jalr:
@ decode_rs1       @ --> r5
  decode_imm_i     @ --> r7

  adds r3, r1, 4   @ Link back

  adds r1, r5, r7  @ New PC
  lsrs r1, r1, 1   @ Clear LSB of PC
  lsls r1, r1, 1

1:@ Data in r3, register specified by instruction

  lsls r4, r2,      31-11
  lsrs r4, r4,  7 + 31-11
  lsls r4, r4,             2

  beq.n mamihlapinatapai_execute
    str r3, [r0, r4]
  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_auipc:
  decode_imm_u @ --> r7
  adds r7, r1 @ PC + Immediate
  b.n write_rd_finish

@ -----------------------------------------------------------------------------

execute_lui:
  decode_imm_u @ --> r7
  @ b.n write_rd_finish  @ Fallthrough

@ -----------------------------------------------------------------------------

write_rd_finish:

  lsls r4, r2,      31-11
  lsrs r4, r4,  7 + 31-11
  lsls r4, r4,             2

  beq.n continue
    str r7, [r0, r4]

continue:
  adds r1, 4

mamihlapinatapai_execute:
  @ Main loop for emulation. Fetch instruction. Decode instruction type.

  ldr r2, [r1]
  movs r4, 0x7F
  ands r4, r2

    cmp r4, 0x6F
      beq.n execute_jal
    cmp r4, 0x37
      beq.n execute_lui
    cmp r4, 0x17
      beq.n execute_auipc

  decode_rs1

    cmp r4, 0x67
      beq.n execute_jalr

  decode_funct3

    cmp r4, 0x13
      beq.n execute_immediate
    cmp r4, 0x03
      beq.n execute_load

  decode_rs2

    cmp r4, 0x33
      beq.n execute_register
    cmp r4, 0x63
      beq.n execute_branch
    cmp r4, 0x23
      beq.n execute_store

  @ Unknown opcode ? Skip silently and continue.
  b.n continue

@ -----------------------------------------------------------------------------

execute_branch:
@ decode_rs1       @ --> r5
@ decode_rs2       @ --> r6
@ decode_funct3    @ --> r3

  cmp r3, 0 @ beq
  bne 1f
    cmp r5, r6
    beq.n branch_take
    b.n continue

1:cmp r3, 1 @ bne
  bne 1f
    cmp r5, r6
    bne.n branch_take
    b.n continue

1:cmp r3, 4 @ blt
  bne 1f
    cmp r5, r6
    blt.n branch_take
    b.n continue

1:cmp r3, 5 @ bge
  bne 1f
    cmp r5, r6
    bge.n branch_take
    b.n continue

1:cmp r3, 6 @ bltu
  bne 1f
    cmp r5, r6
    blo.n branch_take
    b.n continue

1:cmp r3, 7 @ bgeu
  bne.n continue
    cmp r5, r6
    bhs.n branch_take
    b.n continue

branch_take: @ Jump !
  decode_imm_sb @ --> r7
  adds r1, r7
  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_immediate:
@ decode_rs1       @ --> r5
  decode_imm_i     @ --> r7
@ decode_funct3    @ --> r3

  cmp r3, 0 @ addi
  bne 1f
    adds r7, r5
    b.n write_rd_finish

1:cmp r3, 1 @ slli
  bne 1f
    lsls r7, 31-4
    lsrs r7, 31-4
    lsls r5, r7
    movs r7, r5
    b.n write_rd_finish

1:cmp r3, 2 @ slti
  bne 1f
    cmp r5, r7
    bge 2f
    movs r7, 1
    b.n write_rd_finish
@2: movs r7, 0
@   b.n write_rd_finish

1:cmp r3, 3 @ sltiu
  bne 1f
    cmp r5, r7
    bhs 2f
    movs r7, 1
    b.n write_rd_finish
2:  movs r7, 0
    b.n write_rd_finish

1:cmp r3, 4 @ xori
  bne 1f
    eors r7, r5
    b.n write_rd_finish

1:cmp r3, 5 @ srai/srli
  bne 1f
    lsls r7, 31-4
    lsrs r7, 31-4
    lsls r3, r2, 1
    bpl 2f
      asrs r5, r7
      movs r7, r5
      b.n write_rd_finish
2:    lsrs r5, r7
      movs r7, r5
      b.n write_rd_finish

1:cmp r3, 6 @ ori
  bne 1f
    orrs r7, r5
    b.n write_rd_finish

1:@ cmp r3, 7 @ andi
  @ bne.n continue
    ands r7, r5
    b.n write_rd_finish

@ -----------------------------------------------------------------------------

execute_register:
@ decode_rs1       @ --> r5
@ decode_rs2       @ --> r6
@ decode_funct3    @ --> r3

  lsls r4, r2, 31-25
  bmi.n execute_register_muldiv

  cmp r3, 0 @ add/sub
  bne 1f

    lsls r3, r2, 1
    bpl 2f

    subs r7, r5, r6
    b.n write_rd_finish
2:  adds r7, r5, r6
    b.n write_rd_finish

1:cmp r3, 1 @ sll
  bne 1f
    lsls r6, 31-4
    lsrs r6, 31-4
    lsls r5, r6
    ands r7, r5
    b.n write_rd_finish

1:cmp r3, 2 @ slt
  bne 1f
    cmp r5, r6
    bge 2f
    movs r7, 1
    b.n write_rd_finish
2:  movs r7, 0
    b.n write_rd_finish

1:cmp r3, 3 @ sltu
  bne 1f
    cmp r5, r6
    bhs 2f
    movs r7, 1
    b.n write_rd_finish
2:  movs r7, 0
    b.n write_rd_finish

1:cmp r3, 4 @ xor
  bne 1f
    eors r5, r6
    movs r7, r5
    b.n write_rd_finish

1:cmp r3, 5 @ sra/srl
  bne 1f
    lsls r6, 31-4
    lsrs r6, 31-4
    lsls r3, r2, 1
    bpl 2f
      asrs r5, r6
      movs r7, r5
      b.n write_rd_finish
2:    lsrs r5, r6
      movs r7, r5
      b.n write_rd_finish

1:cmp r3, 6 @ or
  bne 1f
    orrs r5, r6
    movs r7, r5
    b.n write_rd_finish

1:@cmp r3, 7 @ and
  @bne.n continue
    ands r5, r6
    movs r7, r5
    b.n write_rd_finish

@ -----------------------------------------------------------------------------

execute_register_muldiv:

  cmp r3, 0 @ mul
  bne 1f
    muls r5, r6
    movs r7, r5
    b.n write_rd_finish

1:cmp r3, 1 @ mulh
  bne 1f
    asrs r4, r6, 31
    asrs r7, r5, 31
    b.n multiply

1:cmp r3, 2 @ mulhsu
  bne 1f
    movs r4, 0
    asrs r7, r5, 31
    b.n multiply

1:cmp r3, 3 @ mulhu
  bne 1f
    movs r7, 0
    b.n multiply_unsigned

1:cmp r3, #4 @ div
  bne 1f

    cmp r6, 0
    beq 3f

    @ Absolute value of r5
    asrs r3, r5, 31
    adds r5, r5, r3
    eors r5, r3

    @ Absolute value of r6
    asrs r4, r6, 31
    adds r6, r6, r4
    eors r6, r4

    @ Sign of result
    eors r3, r4

    bl u_slash_mod

    @ Apply sign to result
    adds r7, r3
    eors r7, r3

    b.n write_rd_finish

1:cmp r3, #5 @ divu
  bne 1f

    cmp r6, 0
    bne 2f
3:    mvns r7, r6
      b.n write_rd_finish

2:  bl u_slash_mod
    b.n write_rd_finish

1:cmp r3, #6 @ rem
  bne 1f

    cmp r6, 0
    bne 2f
      movs r7, r5
      b.n write_rd_finish

2:  @ Absolute value of r5 and sign of result
    asrs r3, r5, 31
    adds r5, r5, r3
    eors r5, r3

    @ Absolute value of r6
    asrs r4, r6, 31
    adds r6, r6, r4
    eors r6, r4

    bl u_slash_mod

    @ Apply sign to result
    adds r7, r5, r3
    eors r7, r3

    b.n write_rd_finish

1:@cmp r3, #7 @ remu
  @bne.n continue

    cmp r6, 0
    beq 2f
      bl u_slash_mod
2:  movs r7, r5
    b.n write_rd_finish

@ -----------------------------------------------------------------------------

  @ Multiply r7:r5 and r4:r6 and return the product in r7:r5. Use r3 for scratch.

multiply:

  muls  r7, r6   @ High-1 * Low-2 --> r7
  muls  r4, r5   @ High-2 * Low-1 --> r4
  adds  r7, r4   @                    Sum into r7

multiply_unsigned:

  lsrs  r4, r5, 16
  lsrs  r3, r6, 16
  muls  r4, r3
  adds  r7, r4

  lsrs  r4, r5, 16
  uxth  r5, r5
  uxth  r6, r6
  muls  r4, r6
  muls  r3, r5
  muls  r5, r6

  movs  r6, 0
  adds  r4, r3
  adcs  r6, r6
  lsls  r6, 16
  adds  r7, r6

  lsls  r6, r4, 16
  lsrs  r4, 16
  adds  r5, r6
  adcs  r7, r4

  b.n write_rd_finish

@ -----------------------------------------------------------------------------

u_slash_mod: @ r5 / r6 --> r7 rem r5

  @ Shift left the denominator until it is greater than the numerator
  movs r4, 1    @ Zähler
  movs r7, 0    @ Ergebnis
  cmp r5, r6
  bls 3f
  adds r6, 0    @ Don't shift if denominator would overflow
  bmi 3f

2:lsls r4, 1
  lsls r6, 1
  bmi 3f
  cmp r5, r6
  bhi 2b

3:cmp r5, r6
  bcc 4f         @ if (num>denom)
  subs r5, r6     @ numerator -= denom
  orrs r7, r4      @ result(r7) |= bitmask(r4)

4:lsrs r6, 1    @ denom(r6) >>= 1
  lsrs r4, 1    @ bitmask(r4) >>= 1
  bne 3b

  bx lr

@ -----------------------------------------------------------------------------

.org 1024, 0
riscvboot:
