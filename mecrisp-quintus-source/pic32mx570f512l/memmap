OUTPUT_ARCH(mips)

/* See...
 * FIGURE 4-5: MEMORY MAP ON RESET FOR PIC32MX170/270 DEVICES (64 KB RAM, 256 KB FLASH)
 * PIC32MX1XX/2XX 28/36/44-pin Family Data Sheet
 *
 * Flash memory is limied to 32 kb here in order to check core size.
 * Actual size used for flash dictionary is given in mecrisp-quintus-...s file.
 */

MEMORY
{
  kseg1_boot_mem       (rx)  : ORIGIN = 0xBFC00000, LENGTH = 0xC00
  kseg1_program_mem    (rx)  : ORIGIN = 0xBD000000, LENGTH = 0x8000

  physical_boot_mem    (rx)  : ORIGIN = 0x1FC00000, LENGTH = 0xC00
  physical_program_mem (rx)  : ORIGIN = 0x1D000000, LENGTH = 0x8000

}

SECTIONS
{
  .boot     : { *(.boot*) }     > kseg1_boot_mem    AT > physical_boot_mem
  .text     : { *(.text*) }     > kseg1_program_mem AT > physical_program_mem

  /DISCARD/ : { *(.reginfo) *(.MIPS.abiflags) }
}
