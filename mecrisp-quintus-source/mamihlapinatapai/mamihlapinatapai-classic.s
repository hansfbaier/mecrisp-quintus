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
.cpu cortex-m3
.thumb

@ -----------------------------------------------------------------------------
@   Macro definitions
@ -----------------------------------------------------------------------------

.macro decode_funct3 @ --> r3
  lsrs r3, r2, #12
  ands r3, r3, #0x07
.endm

.macro decode_rs1 @ --> r5
  lsrs r5, r2, #15-2
  ands r5, r5, #0x1F<<2
  ldr r5, [r0, r5]
.endm

.macro decode_rs2 @ --> r6
  lsrs r6, r2, #20-2
  ands r6, r6, #0x1F<<2
  ldr r6, [r0, r6]
.endm

.macro write_rd @ Data in r7, register specified by instruction
  lsrs r4, r2, #7-2
  ands r4, r4, #0x1F<<2
  beq.n 9f
    str r7, [r0, r4]
9:
.endm

.macro write_rd_finish @ Increment PC and jump back to main loop.
  adds r1, #4
  lsrs r4, r2, #7-2
  ands r4, r4, #0x1F<<2
  beq mamihlapinatapai_execute
    str r7, [r0, r4]
  b.n mamihlapinatapai_execute
.endm

@ -----------------------------------------------------------------------------
@   Immediate decoders. They are either short or used once only.

.macro decode_imm_s @ --> r7
  ands r7, r2, 0xFE000000
  asrs r7, r7, 20
    lsrs r4, r2, 7
    ands r4, r4, #0x1F
  orrs r7, r4
.endm

.macro decode_imm_sb @ --> r7
  @ Does not preserve r3, r4, r5, r6

  lsrs r7, r2, #31-12
  ands r7, #1<<12

  lsrs r3, r2, #25-5
  ands r3, #0x7E0
  orrs r7, r3

  lsrs r3, r2, #8-1
  ands r3, #0x1E
  orrs r7, r3

  lsls r3, r2, #11-7
  ands r3, #1<<11
  orrs r7, r3

  lsls r7, r7, #19
  asrs r7, r7, #19
.endm

.macro decode_imm_i @ --> r7
  asrs r7, r2, #20
.endm

.macro decode_imm_u @ --> r7
  @ ands r7, r2, 0xFFFFF000
  lsrs r7, r2, #12
  lsls r7, #12
.endm

.macro decode_imm_uj @ --> r7.
  @ Does not preserve r3, r4, r5, r6

  lsrs r7, r2, #31-20
  ands r7, #1<<20

  lsrs r3, r2, #21-1
  movw r4, #0x7FE
  ands r3, r4
  orrs r7, r3

  lsrs r3, r2, #20-11
  ands r3, #1<<11
  orrs r7, r3

  ands r3, r2, #0xff000
  orrs r7, r3

  lsls r7, r7, #11
  asrs r7, r7, #11
.endm

@ -----------------------------------------------------------------------------
@   End of macro definitions
@ -----------------------------------------------------------------------------



@ -----------------------------------------------------------------------------
mamihlapinatapai:
@ -----------------------------------------------------------------------------

  @ Start address for emulated execution at the end of the 1 kb binary blob relative to PC
  addw r1, pc, #0x400 - 4

  @ Base address of the register memory block:
  mov r0, sp

  @ Clear the memory block, zero out all Risc-V registers
  movs r2, #0
  movs r3, #0
1:str r3, [r0, r2]
  adds r2, #4
  cmp r2, #4*32
  bne 1b

mamihlapinatapai_execute:
  @ Main loop for emulation. Fetch instruction. Decode instruction type.

  ldr r2, [r1]
  ands r3, r2, #0x7F

    cmp r3, #0x03
      beq.n execute_load
    cmp r3, #0x13
      beq   execute_immediate
    cmp r3, #0x17
      beq.n execute_auipc
    cmp r3, #0x23
      beq.n execute_store
    cmp r3, #0x33
      beq   execute_register
    cmp r3, #0x37
      beq.n execute_lui
    cmp r3, #0x63
      beq.n execute_branch
    cmp r3, #0x67
      beq.n execute_jalr
    cmp r3, #0x6F
      beq.n execute_jal

  @ Unknown opcode ? Skip silently and continue.

  adds r1, #4
  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_load:
  decode_funct3    @ --> r3
  decode_rs1       @ --> r5
  decode_imm_i     @ --> r7

  cmp r3, 0 @ lb
  itt eq
    ldrbeq r7, [r5, r7]
    sxtbeq r7, r7
  cmp r3, 1 @ lh
  itt eq
    ldrheq r7, [r5, r7]
    sxtheq r7, r7
  cmp r3, 2 @ lw
  it eq
    ldreq r7, [r5, r7]
  cmp r3, 4 @ lbu
  it eq
    ldrbeq r7, [r5, r7]
  cmp r3, 5 @ lhu
  it eq
    ldrheq r7, [r5, r7]

  write_rd_finish

@ -----------------------------------------------------------------------------

execute_store:
  decode_funct3    @ --> r3
  decode_rs1       @ --> r5
  decode_rs2       @ --> r6
  decode_imm_s     @ --> r7

  cmp r3, #0 @ sb
  it eq
    strbeq r6, [r5, r7]
  cmp r3, #1 @ sh
  it eq
    strheq r6, [r5, r7]
  cmp r3, #2 @ sw
  it eq
    streq r6, [r5, r7]

  adds r1, #4
  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_auipc:
  decode_imm_u @ --> r7
  adds r7, r1 @ PC + Immediate
  write_rd_finish

@ -----------------------------------------------------------------------------

execute_lui:
  decode_imm_u @ --> r7
  write_rd_finish

@ -----------------------------------------------------------------------------

execute_jalr:
  movs r3, r1
  decode_rs1       @ --> r5
  decode_imm_i     @ --> r7

  adds r1, r5, r7
  bics r1, #1

  adds r7, r3, #4
  write_rd
  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_jal:
  adds r7, r1, #4
  write_rd

  decode_imm_uj @ --> r7
  adds r1, r7
  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_branch:
  decode_funct3    @ --> r3
  decode_rs1       @ --> r5
  decode_rs2       @ --> r6

  cmp r3, #0 @ beq
  bne 1f
    cmp r5, r6
    beq 2f

1:cmp r3, #1 @ bne
  bne 1f
    cmp r5, r6
    bne 2f

1:cmp r3, #4 @ blt
  bne 1f
    cmp r5, r6
    blt 2f

1:cmp r3, #5 @ bge
  bne 1f
    cmp r5, r6
    bge 2f

1:cmp r3, #6 @ bltu
  bne 1f
    cmp r5, r6
    blo 2f

1:cmp r3, #7 @ bgeu
  bne 1f
    cmp r5, r6
    bhs 2f

1:adds r1, #4
  b.n mamihlapinatapai_execute

2:@ Jump !
  decode_imm_sb @ --> r7
  adds r1, r7
  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_immediate:
  decode_funct3    @ --> r3
  decode_rs1       @ --> r5
  decode_imm_i     @ --> r7

  cmp r3, #0 @ addi
  it eq
    addseq r7, r5

  cmp r3, #1 @ slli
  itt eq
    andeq r7, #0x1F
    lsleq r7, r5, r7

  cmp r3, #2 @ slti
  bne 1f
    cmp r5, r7
    ite lt
    movlt r7, 1
    movge r7, 0

1:cmp r3, #3 @ sltiu
  bne 1f
    cmp r5, r7
    ite lo
    movlo r7, 1
    movhs r7, 0

1:cmp r3, #4 @ xori
  it eq
    eorseq r7, r5

  cmp r3, #5 @ srai/srli
  bne 1f
    ands r7, #0x1F
    lsrs r4, r2, 26
    cmp r4, #16
    ite eq
    asreq r7, r5, r7
    lsrne r7, r5, r7

1:cmp r3, #6 @ ori
  it eq
    orrseq r7, r5

1:cmp r3, #7 @ andi
  it eq
    andseq r7, r5

  write_rd_finish

@ -----------------------------------------------------------------------------

execute_register:
  decode_funct3    @ --> r3
  decode_rs1       @ --> r5
  decode_rs2       @ --> r6

  lsrs r7, r2, #25
  cmp r7, #1
  beq.n execute_register_muldiv

  cmp r3, #0 @ add/sub
  bne 1f
    cmp r7, #32
    ite eq
    subeq r7, r5, r6
    addne r7, r5, r6

1:cmp r3, #1 @ sll
  itt eq
    andeq r6, #0x1F
    lsleq r7, r5, r6

  cmp r3, #2 @ slt
  bne 1f
    cmp r5, r6
    ite lt
    movlt r7, 1
    movge r7, 0

1:cmp r3, #3 @ sltu
  bne 1f
    cmp r5, r6
    ite lo
    movlo r7, 1
    movhs r7, 0

1:cmp r3, #4 @ xor
  it eq
    eorseq r7, r5, r6

  cmp r3, #5 @ sra/srl
  bne 1f
    ands r6, #0x1F
    cmp r7, #32
    ite eq
    asreq r7, r5, r6
    lsrne r7, r5, r6

1:cmp r3, #6 @ or
  it eq
    orrseq r7, r5, r6

  cmp r3, #7 @ and
  it eq
    andseq r7, r5, r6

  write_rd_finish

execute_register_muldiv:

  cmp r3, #0 @ mul
  it eq
    muleq r7, r5, r6

  cmp r3, #1 @ mulh
  it eq
    smulleq r4, r7, r5, r6

  cmp r3, #2 @ mulhsu
  bne 1f
    umull r4, r7, r5, r6
    asrs r4, r5, #31
    ands r4, r6
    subs r7, r4

1:cmp r3, #3 @ mulhu
  it eq
    umulleq r4, r7, r5, r6

  cmp r3, #4 @ div
  it eq
    sdiveq r7, r5, r6

  cmp r3, #5 @ divu
  it eq
    udiveq r7, r5, r6

  cmp r3, #6 @ rem
  bne 1f
    sdiv r4, r5, r6 @ Divide
    mul r7, r4, r6 @ Un-divide to compute remainder.
    subs r7, r5, r7 @ Compute remainder.

1:cmp r3, #7 @ remu
  bne 1f
    udiv r4, r5, r6 @ Divide
    mul r7, r4, r6 @ Un-divide to compute remainder.
    subs r7, r5, r7 @ Compute remainder.

1:
  write_rd_finish

@ -----------------------------------------------------------------------------

.p2align 10
