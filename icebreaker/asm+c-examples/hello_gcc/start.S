
   .section .text.start
   .global _start
_start:

# -----------------------------------------------------------------------------
#   Execution starts here, in XIP from SPI flash
# -----------------------------------------------------------------------------

  # Take care: We are executing at 0x00820000 currently.
  # Copy code from SPI Flash to RAM for execution, mirroring at 0

  auipc x8, 0
  li x9, 0x00000000
  li x10, 0x20000

1:lw x11, 0(x8)
  sw x11, 0(x9)

  addi x8, x8, 4
  addi x9, x9, 4
  addi x10, x10, -4

  bnez x10, 1b

  # Long absolute jump into RAM now:

  lui x8, %hi(Reset)
  jalr zero, x8, %lo(Reset)

# -----------------------------------------------------------------------------
#  RAM start
# -----------------------------------------------------------------------------

Reset:

   # Copy data section
   la a0, _sidata
   la a1, _sdata
   la a2, _edata
   bge a1, a2, end_init_data
loop_init_data:
   lw a3, 0(a0)
   sw a3, 0(a1)
   addi a0, a0, 4
   addi a1, a1, 4
   blt a1, a2, loop_init_data
end_init_data:

   # BSS zero-init
   la a0, _sbss
   la a1, _ebss
   bge a0, a1, end_init_bss
loop_init_bss:
   sw zero, 0(a0)
   addi a0, a0, 4
   blt a0, a1, loop_init_bss
end_init_bss:

   # Set stack pointer to end of heap
   li sp, 0x00020000

   # Call main
   call main

   # Trap here should main return
trap:
   j trap
