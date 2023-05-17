
# -----------------------------------------------------------------------------
#  Bootloader
# -----------------------------------------------------------------------------

.text

  # We are executing from a special bootloader block at $80000000 here to
  # copy 128 kb of code and data from SPI Flash (R) to RAM (RWX) for execution.

  li x8, 0x80200000 + 128*1024
  li x9, 128*1024

1:addi x8, x8, -4
  addi x9, x9, -4

  lw x10, 0(x8)
  sw x10, 0(x9)

  bnez x9, 1b

  # Long absolute jump to start of RAM now:

  jalr zero, zero, 0

.org 32, 0
