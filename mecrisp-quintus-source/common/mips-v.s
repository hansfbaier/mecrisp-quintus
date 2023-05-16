
/*

$0   $zero, $r0   Always zero
$1   $at   Reserved for assembler
$2, $3   $v0, $v1   First and second return values, respectively
$4, ..., $7   $a0, ..., $a3   First four arguments to functions
$8, ..., $15   $t0, ..., $t7   Temporary registers
$16, ..., $23   $s0, ..., $s7   Saved registers
$24, $25   $t8, $t9   More temporary registers
$26, $27   $k0, $k1   Reserved for kernel (operating system)
$28   $gp   Global pointer
$29   $sp   Stack pointer
$30   $fp   Frame pointer
$31   $ra   Return address

JAL in MIPS uses $31 !
Save $1 when entering interrupts !

*/

.set zero, $zero
.set x0,   $zero
.set x1,   $31   # Link register is x1 on RISC-V and $31 on MIPS
.set x2,   $2    # Stack pointer is x2 on RISC-V and $29 on MIPS for normal call convention - take care when doing syscalls !
.set sp,   $2    # Another name for stack pointer
.set x3,   $3    # Loop index
.set x4,   $4    # Loop limit
.set x5,   $5    # Scratch register, needs to be saved.
.set x6,   $6    # Scratch register, needs to be saved.
.set x7,   $7    # Scratch register, needs to be saved.

.set x8,   $8    # Top of data stack
.set x9,   $9    # Data stack pointer
.set x10,  $10   # Scratch register, needs to be saved.
.set x11,  $11   # Scratch register, needs to be saved.
.set x12,  $12   # Scratch register, needs to be saved.
.set x13,  $13   # Scratch register, needs to be saved.
.set x14,  $14   # Free scratch register, not saved across calls.
.set x15,  $15   # Free scratch register, not saved across calls.

# x16-x31 are unused in Mecrisp-Quintus Forth core, but x16 to x25 are used as "free scratch registers" by Acrobatics compiler.

.set x16,  $16
.set x17,  $17
.set x18,  $18
.set x19,  $19
.set x20,  $20
.set x21,  $21
.set x22,  $22
.set x23,  $23
.set x24,  $24
.set x25,  $25

.macro call name
  jal \name
.endm

.macro ret
  jr x1
.endm

.macro mv destination, source
  or \destination, \source, zero
.endm

.macro slli p1, p2, p3
  sll \p1, \p2, \p3
.endm

.macro srli p1, p2, p3
  srl \p1, \p2, \p3
.endm

.macro srai p1, p2, p3
  sra \p1, \p2, \p3
.endm

.macro add p1, p2, p3
  addu \p1, \p2, \p3
.endm

.macro addi p1, p2, p3
  addiu \p1, \p2, \p3
.endm

.macro sub p1, p2, p3
  subu \p1, \p2, \p3
.endm
