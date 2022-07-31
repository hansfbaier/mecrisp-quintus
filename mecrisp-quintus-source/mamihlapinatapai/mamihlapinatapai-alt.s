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
  lsrs r4, r2, #7-2
  ands r4, r4, #0x1F<<2
  beq continue
    str r7, [r0, r4]
  b.n continue
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
  lsrs r3, #2

  tbb [pc, r3]
execute_table:
  .byte ((execute_load      - execute_table) / 2)  @   0x0 -->  0x3
  .byte ((continue          - execute_table) / 2)  @   0x1 -->  0x7
  .byte ((continue          - execute_table) / 2)  @   0x2 -->  0xB
  .byte ((continue          - execute_table) / 2)  @   0x3 -->  0xF
  .byte ((execute_immediate - execute_table) / 2)  @   0x4 --> 0x13
  .byte ((execute_auipc     - execute_table) / 2)  @   0x5 --> 0x17
  .byte ((continue          - execute_table) / 2)  @   0x6 --> 0x1B
  .byte ((continue          - execute_table) / 2)  @   0x7 --> 0x1F
  .byte ((execute_store     - execute_table) / 2)  @   0x8 --> 0x23
  .byte ((continue          - execute_table) / 2)  @   0x9 --> 0x27
  .byte ((continue          - execute_table) / 2)  @   0xA --> 0x2B
  .byte ((continue          - execute_table) / 2)  @   0xB --> 0x2F
  .byte ((execute_register  - execute_table) / 2)  @   0xC --> 0x33
  .byte ((execute_lui       - execute_table) / 2)  @   0xD --> 0x37
  .byte ((continue          - execute_table) / 2)  @   0xE --> 0x3B
  .byte ((continue          - execute_table) / 2)  @   0xF --> 0x3F
  .byte ((continue          - execute_table) / 2)  @  0x10 --> 0x43
  .byte ((continue          - execute_table) / 2)  @  0x11 --> 0x47
  .byte ((continue          - execute_table) / 2)  @  0x12 --> 0x4B
  .byte ((continue          - execute_table) / 2)  @  0x13 --> 0x4F
  .byte ((continue          - execute_table) / 2)  @  0x14 --> 0x53
  .byte ((continue          - execute_table) / 2)  @  0x15 --> 0x57
  .byte ((continue          - execute_table) / 2)  @  0x16 --> 0x5B
  .byte ((continue          - execute_table) / 2)  @  0x17 --> 0x5F
  .byte ((execute_branch    - execute_table) / 2)  @  0x18 --> 0x63
  .byte ((execute_jalr      - execute_table) / 2)  @  0x19 --> 0x67
  .byte ((continue          - execute_table) / 2)  @  0x1A --> 0x6B
  .byte ((execute_jal       - execute_table) / 2)  @  0x1B --> 0x6F
  .byte ((continue          - execute_table) / 2)  @  0x1C --> 0x73
  .byte ((continue          - execute_table) / 2)  @  0x1D --> 0x77
  .byte ((continue          - execute_table) / 2)  @  0x1E --> 0x7B
  .byte ((continue          - execute_table) / 2)  @  0x1F --> 0x7F

  @ Unknown opcode ? Skip silently and continue.

continue:
  adds r1, #4
  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_load:
  decode_funct3    @ --> r3
  decode_rs1       @ --> r5
  decode_imm_i     @ --> r7

  tbb [pc, r3]
load_table:
  .byte ((load_0        - load_table) / 2)
  .byte ((load_1        - load_table) / 2)
  .byte ((load_2        - load_table) / 2)
  .byte ((load_finished - load_table) / 2)
  .byte ((load_4        - load_table) / 2)
  .byte ((load_5        - load_table) / 2)
  .byte ((load_finished - load_table) / 2)
  .byte ((load_finished - load_table) / 2)

load_0: @ lb
    ldrb r7, [r5, r7]
    sxtb r7, r7
    b.n load_finished

load_1: @ lh
    ldrh r7, [r5, r7]
    sxth r7, r7
    b.n load_finished

load_2: @ lw
    ldr r7, [r5, r7]
    b.n load_finished

load_4: @ lbu
    ldrb r7, [r5, r7]
    b.n load_finished

load_5: @ lhu
    ldrh r7, [r5, r7]

load_finished:
  write_rd_finish

@ -----------------------------------------------------------------------------

execute_store:
  decode_funct3    @ --> r3
  decode_rs1       @ --> r5
  decode_rs2       @ --> r6
  decode_imm_s     @ --> r7

  tbb [pc, r3]
store_table:
  .byte ((store_0        - store_table) / 2)
  .byte ((store_1        - store_table) / 2)
  .byte ((store_2        - store_table) / 2)
  .byte ((store_finished - store_table) / 2)
  .byte ((store_finished - store_table) / 2)
  .byte ((store_finished - store_table) / 2)
  .byte ((store_finished - store_table) / 2)
  .byte ((store_finished - store_table) / 2)

store_0: @ sb
    strb r6, [r5, r7]
    b.n continue

store_1: @ sh
    strh r6, [r5, r7]
    b.n continue

store_2: @ sw
    str r6, [r5, r7]

store_finished:
  b.n continue

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

  cmp r5, r6 @ Prepare flags for conditional jumps

  tbb [pc, r3]
branch_table:
  .byte ((branch_0    - branch_table) / 2)
  .byte ((branch_1    - branch_table) / 2)
  .byte ((branch_skip - branch_table) / 2)
  .byte ((branch_skip - branch_table) / 2)
  .byte ((branch_4    - branch_table) / 2)
  .byte ((branch_5    - branch_table) / 2)
  .byte ((branch_6    - branch_table) / 2)
  .byte ((branch_7    - branch_table) / 2)

branch_0: @ beq
    beq.n branch_take
    b.n continue

branch_1: @ bne
    bne.n branch_take
    b.n continue

branch_4: @ blt
    blt.n branch_take
    b.n continue

branch_5: @ bge
    bge.n branch_take
    b.n continue

branch_6: @ bltu
    blo.n branch_take
    b.n continue

branch_7: @ bgeu
    bhs.n branch_take

branch_skip:
  b.n continue

branch_take: @ Jump !
  decode_imm_sb @ --> r7
  adds r1, r7
  b.n mamihlapinatapai_execute

@ -----------------------------------------------------------------------------

execute_immediate:
  decode_funct3    @ --> r3
  decode_rs1       @ --> r5
  decode_imm_i     @ --> r7

  tbb [pc, r3]
immediate_table:
  .byte ((immediate_0 - immediate_table) / 2)
  .byte ((immediate_1 - immediate_table) / 2)
  .byte ((immediate_2 - immediate_table) / 2)
  .byte ((immediate_3 - immediate_table) / 2)
  .byte ((immediate_4 - immediate_table) / 2)
  .byte ((immediate_5 - immediate_table) / 2)
  .byte ((immediate_6 - immediate_table) / 2)
  .byte ((immediate_7 - immediate_table) / 2)

immediate_0: @ addi
    adds r7, r5
    b.n 1f

immediate_1: @ slli
    ands r7, #0x1F
    lsls r7, r5, r7
    b.n 1f

immediate_2: @ slti
    cmp r5, r7
    ite lt
    movlt r7, 1
    movge r7, 0
    b.n 1f

immediate_3: @ sltiu
    cmp r5, r7
    ite lo
    movlo r7, 1
    movhs r7, 0
    b.n 1f

immediate_4: @ xori
    eors r7, r5
    b.n 1f

immediate_5: @ srai/srli
    ands r7, #0x1F
    lsrs r4, r2, 26
    cmp r4, #16
    ite eq
    asreq r7, r5, r7
    lsrne r7, r5, r7
    b.n 1f

immediate_6: @ ori
    orrs r7, r5
    b.n 1f

immediate_7: @ andi
    ands r7, r5

1:write_rd_finish

@ -----------------------------------------------------------------------------

execute_register:
  decode_funct3    @ --> r3
  decode_rs1       @ --> r5
  decode_rs2       @ --> r6

  lsrs r7, r2, #25
  cmp r7, #1
  beq.n execute_register_muldiv

  tbb [pc, r3]
register_table:
  .byte ((register_0 - register_table) / 2)
  .byte ((register_1 - register_table) / 2)
  .byte ((register_2 - register_table) / 2)
  .byte ((register_3 - register_table) / 2)
  .byte ((register_4 - register_table) / 2)
  .byte ((register_5 - register_table) / 2)
  .byte ((register_6 - register_table) / 2)
  .byte ((register_7 - register_table) / 2)

register_0: @ add/sub
    cmp r7, #32
    ite eq
    subeq r7, r5, r6
    addne r7, r5, r6
    b.n 1f

register_1: @ sll
    ands r6, #0x1F
    lsls r7, r5, r6
    b.n 1f

register_2: @ slt
    cmp r5, r6
    ite lt
    movlt r7, 1
    movge r7, 0
    b.n 1f

register_3: @ sltu
    cmp r5, r6
    ite lo
    movlo r7, 1
    movhs r7, 0
    b.n 1f

register_4: @ xor
    eors r7, r5, r6
    b.n 1f

register_5: @ sra/srl
    ands r6, #0x1F
    cmp r7, #32
    ite eq
    asreq r7, r5, r6
    lsrne r7, r5, r6
    b.n 1f

register_6: @ or
    orrs r7, r5, r6
    b.n 1f

register_7: @ and
    ands r7, r5, r6

1:write_rd_finish


execute_register_muldiv:
  tbb [pc, r3]
register_muldiv_table:
  .byte ((register_muldiv_0 - register_muldiv_table) / 2)
  .byte ((register_muldiv_1 - register_muldiv_table) / 2)
  .byte ((register_muldiv_2 - register_muldiv_table) / 2)
  .byte ((register_muldiv_3 - register_muldiv_table) / 2)
  .byte ((register_muldiv_4 - register_muldiv_table) / 2)
  .byte ((register_muldiv_5 - register_muldiv_table) / 2)
  .byte ((register_muldiv_6 - register_muldiv_table) / 2)
  .byte ((register_muldiv_7 - register_muldiv_table) / 2)

register_muldiv_0: @ mul
    mul r7, r5, r6
    b.n 1f

register_muldiv_1: @ mulh
    smull r4, r7, r5, r6
    b.n 1f

register_muldiv_2: @ mulhsu
    umull r4, r7, r5, r6
    asrs r4, r5, #31
    ands r4, r6
    subs r7, r4
    b.n 1f

register_muldiv_3: @ mulhu
    umull r4, r7, r5, r6
    b.n 1f

register_muldiv_4: @ div
    sdiv r7, r5, r6
    b.n 1f

register_muldiv_5: @ divu
    udiv r7, r5, r6
    b.n 1f

register_muldiv_6: @ rem
    sdiv r4, r5, r6 @ Divide
    mul r7, r4, r6 @ Un-divide to compute remainder.
    subs r7, r5, r7 @ Compute remainder.
    b.n 1f

register_muldiv_7: @ remu
    udiv r4, r5, r6 @ Divide
    mul r7, r4, r6 @ Un-divide to compute remainder.
    subs r7, r5, r7 @ Compute remainder.

1:write_rd_finish

@ -----------------------------------------------------------------------------

.p2align 10
