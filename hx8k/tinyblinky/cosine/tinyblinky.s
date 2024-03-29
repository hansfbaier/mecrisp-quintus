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

.equ leds, 0x400080

# -----------------------------------------------------------------------------
#  Flash start
# -----------------------------------------------------------------------------

.text
  j Boot # irq_collection
  .balign 4, 0
Boot:    # Normal entry point

  # Take care: We are executing at 0x00840000 currently.
  # Copy code from SPI Flash to RAM for execution, mirroring at 0

  li x8, 0x00840000
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

  li   x10, 1                    # Set up initial x, y for Minsky circle algorithm
  slli x11, x10, 19

# -----------------------------------------------------------------------------
breathe_led: # Generate smooth breathing LED effect
# -----------------------------------------------------------------------------

    # Register usage:

    # x8  : Initialised with IO address for GPIO
    # x9  : Phase accumulator for sigma-delta modulator
    # x10 : Minsky circle alg x = sin(t)
    # x11 : Minsky circle alg y = cos(t)
    # x12 : Scratch
    # x13 : Scratch
                                 # Minsky circle algorithm x, y = sin(t), cos(t)
    srai x12, x10, 17            # -dx = y >> 17
    sub  x11, x11, x12           #  x += dx
    srai x12, x11, 17            #  dy = x >> 17
    add  x10, x10, x12           #  y += dy

    srai x12, x11, 13            # -49 <= r4 <= 64   --> scaled cos(t)
    addi x12, x12, 167           # 118 <= r4 <= 231  --> scaled cos(t) with offset

    andi x13, x12, 7             # Simplified bitexp function.
    addi x13, x13, 8             #   Valid for inputs up to 231
    srli x12, x12, 3             #   Gives too small values above 231
    sll  x13, x13, x12           # Input in x12, output in x13

    add  x9, x9, x13             # Sigma-Delta phase accumulator
    sltu x13, x9, x13            # Sigma-Delta output on overflow

   sw  x13, 0(x8)                # Set output accordingly
   j breathe_led
