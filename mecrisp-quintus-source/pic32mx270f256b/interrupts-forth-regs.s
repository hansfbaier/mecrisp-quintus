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

# CP0 register access from within Forth

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-hwrena@"
  pushdatos
  mfc0 x8, CP0_HWRENA
  ret

  Definition Flag_visible, "cp0-hwrena!"
  mtc0 x8, CP0_HWRENA
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-badvaddr@"
  pushdatos
  mfc0 x8, CP0_BADVADDR
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-count@"
  pushdatos
  mfc0 x8, CP0_COUNT
  ret

  Definition Flag_visible, "cp0-count!"
  mtc0 x8, CP0_COUNT
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-compare@"
  pushdatos
  mfc0 x8, CP0_COMPARE
  ret

  Definition Flag_visible, "cp0-compare!"
  mtc0 x8, CP0_COMPARE
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-status@"
  pushdatos
  mfc0 x8, CP0_STATUS
  ret

  Definition Flag_visible, "cp0-status!"
  mtc0 x8, CP0_STATUS
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-intctl@"
  pushdatos
  mfc0 x8, CP0_INTCTL_1, 1
  ret

  Definition Flag_visible, "cp0-intctl!"
  mtc0 x8, CP0_INTCTL_1, 1
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-srsctl@"
  pushdatos
  mfc0 x8, CP0_SRSCTL_2, 2
  ret

  Definition Flag_visible, "cp0-srsctl!"
  mtc0 x8, CP0_SRSCTL_2, 2
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-srsmap@"
  pushdatos
  mfc0 x8, CP0_SRSMAP_3, 3
  ret

  Definition Flag_visible, "cp0-srsmap!"
  mtc0 x8, CP0_SRSMAP_3, 3
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-cause@"
  pushdatos
  mfc0 x8, CP0_CAUSE
  ret

  Definition Flag_visible, "cp0-cause!"
  mtc0 x8, CP0_CAUSE
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-epc@"
  pushdatos
  mfc0 x8, CP0_EPC
  ret

  Definition Flag_visible, "cp0-epc!"
  mtc0 x8, CP0_EPC
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-prid@"
  pushdatos
  mfc0 x8, CP0_PRID
  ret


# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-ebase@"
  pushdatos
  mfc0 x8, CP0_EBASE_1, 1
  ret

  Definition Flag_visible, "cp0-ebase!"
  mtc0 x8, CP0_EBASE_1, 1
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-config@"
  pushdatos
  mfc0 x8, CP0_CONFIG
  ret

  Definition Flag_visible, "cp0-config!"
  mtc0 x8, CP0_CONFIG
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-config1@"
  pushdatos
  mfc0 x8, CP0_CONFIG, 1
  ret

  Definition Flag_visible, "cp0-config2@"
  pushdatos
  mfc0 x8, CP0_CONFIG, 2
  ret

  Definition Flag_visible, "cp0-config3@"
  pushdatos
  mfc0 x8, CP0_CONFIG, 3
  ret


# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-debug@"
  pushdatos
  mfc0 x8, CP0_DEBUG
  ret

  Definition Flag_visible, "cp0-debug!"
  mtc0 x8, CP0_DEBUG
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-depc@"
  pushdatos
  mfc0 x8, CP0_DEPC
  ret

  Definition Flag_visible, "cp0-depc!"
  mtc0 x8, CP0_DEPC
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-errorepc@"
  pushdatos
  mfc0 x8, CP0_ERROREPC
  ret

  Definition Flag_visible, "cp0-errorepc!"
  mtc0 x8, CP0_ERROREPC
  drop
  ret

# -----------------------------------------------------------------------------

  Definition Flag_visible, "cp0-desave@"
  pushdatos
  mfc0 x8, CP0_DESAVE
  ret

  Definition Flag_visible, "cp0-desave!"
  mtc0 x8, CP0_DESAVE
  drop
  ret

