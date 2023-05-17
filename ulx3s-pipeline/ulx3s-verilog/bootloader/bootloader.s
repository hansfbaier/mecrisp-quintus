
# -----------------------------------------------------------------------------
#  Bootloader
# -----------------------------------------------------------------------------

.text

  # We are executing from a special bootloader block at $80000000 here to
  # copy 256 kb of code and data from SPI Flash (R) to RAM (RWX) for execution.

  li x8, 0x80200000
  li x9, 0x00000000
  li x10, 256*1024

1:lw x11, 0(x8)
  sw x11, 0(x9)

  addi x8, x8, 4
  addi x9, x9, 4
  addi x10, x10, -4

  bnez x10, 1b

  # Long absolute jump to start of RAM now:

  jalr zero, zero, 0

.org 64, 0
