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

# -----------------------------------------------------------------------------
# Swiches for capabilities of this chip
# -----------------------------------------------------------------------------

.option norelax
.option rvc

# -----------------------------------------------------------------------------
#  A few constant definitions
# -----------------------------------------------------------------------------

.equ leds, 0x20000080

# -----------------------------------------------------------------------------
#  Flash start
# -----------------------------------------------------------------------------

.text
  j Boot # irq_collection
  .balign 4, 0
Boot:    # Normal entry point

  # Take care: We are executing at 0x00100000 currently.
  # Copy code from SPI Flash to RAM for execution, mirroring at 0

  li x8, 0x00100000
  li x9, 0x00000000
  li x10, 0x100

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

  li x8, leds # Dies ist der LED-Register

# -----------------------------------------------------------------------------
breathe_led: # Generate smooth breathing LED effect
# -----------------------------------------------------------------------------

    # Register usage:

    # x8  : Initialised with IO address for GPIO
    # x9  : Phase accumulator for sigma-delta modulator
    # x10 : Delay counter
    # x11 : Slow triangle counter, clipped
    # x12 : Scratch
    # x13 : Scratch

    addi x10, x10, 1             # Delay counter

    slli x11, x10, 12            # Select blinking speed here.
    bge  x11, zero, 1f           # Triangle generator between 0 and 0x80000000
    sub  x11, zero, x11          # Idea: abs(upcounter << 12)
1:
    li   x12, 2*(231-117)        # Scale range:
    mulhu x11, x11, x12          # (high-low) * x * 2 / $80000000 + low
    addi x11, x11, 117           # Baseline minimum brightness

    andi x13, x11, 7             # Simplified bitexp function.
    addi x13, x13, 8             #   Valid for inputs up to 231
    srli x11, x11, 3             #   Gives too small values above 231
    sll  x13, x13, x11           # Input in x11, output in x13

    add  x9, x9, x13             # Sigma-Delta phase accumulator
    sltu x13, x9, x13            # Sigma-Delta output on overflow

   sw  x13, 0(x8)                # Set output accordingly
   j breathe_led
