OUTPUT_ARCH(mips)
ENTRY(_reset)

PROVIDE(_vector_spacing = 0x0001);
PROVIDE(_ebase_address = 0xBD03F000);
_GEN_EXCPT_ADDR = _ebase_address + 0x180;
_RESET_ADDR = 0xBFC00000;
_reset = _RESET_ADDR;

MEMORY
{
  kseg1_data_mem       (w!x) : ORIGIN = 0xA0000000, LENGTH = 0x10000
  kseg1_boot_mem       (rx)  : ORIGIN = 0xBFC00000, LENGTH = 0x0490
  kseg1_program_mem    (rx)  : ORIGIN = 0xBD000000, LENGTH = 0x3F000
  /* not used: */
  kseg0_data_mem       (w!x) : ORIGIN = 0x80000000, LENGTH = 0x10000
  kseg0_boot_mem       (rx)  : ORIGIN = 0x9FC00000, LENGTH = 0x0BF0
  kseg0_program_mem    (rx)  : ORIGIN = 0x9D000000, LENGTH = 0x3F000


  physical_boot_mem    (rx)  : ORIGIN = 0x1FC00000, LENGTH = 0x0BF0
  physical_program_mem (rx)  : ORIGIN = 0x1D000000, LENGTH = 0x8000

  sfrs                       : ORIGIN = 0xBF800000, LENGTH = 0x100000
  configsfrs                 : ORIGIN = 0xBFC00BF0, LENGTH = 0x10
  devcfg3                    : ORIGIN = 0xBFC00BF0, LENGTH = 0x4
  devcfg2                    : ORIGIN = 0xBFC00BF4, LENGTH = 0x4
  devcfg1                    : ORIGIN = 0xBFC00BF8, LENGTH = 0x4
  devcfg0                    : ORIGIN = 0xBFC00BFC, LENGTH = 0x4
  physical_devcfg3           : ORIGIN = 0x1FC00BF0, LENGTH = 0x4
  physical_devcfg2           : ORIGIN = 0x1FC00BF4, LENGTH = 0x4
  physical_devcfg1           : ORIGIN = 0x1FC00BF8, LENGTH = 0x4
  physical_devcfg0           : ORIGIN = 0x1FC00BFC, LENGTH = 0x4
}

SECTIONS
{
  .boot     : { *(.boot*) }     > kseg1_boot_mem    AT > physical_boot_mem
  .reset    : { *(.boot*)
                *(.reset*)}     > kseg1_boot_mem    AT > physical_boot_mem
  .vectors  : { *(.vectors*) }  > kseg1_program_mem AT > physical_program_mem
  .text     : { *(.text*) }     > kseg1_program_mem AT > physical_program_mem

  .bss      : { *(.bss*)  }     > kseg1_data_mem
  .rodata   : { *(.rodata*) }   > kseg1_program_mem AT > physical_program_mem
/*  .got      : {
                _gp = ALIGN(16)+0x7FF0;
                *(.got*)
              }                 > kseg1_program_mem AT > physical_program_mem */
  .devcfg0  : { KEEP(*(.devcfg0)) } > devcfg0       AT > physical_devcfg0
  .devcfg1  : { KEEP(*(.devcfg1)) } > devcfg1       AT > physical_devcfg1
  .devcfg2  : { KEEP(*(.devcfg2)) } > devcfg2       AT > physical_devcfg2
  .devcfg3  : { KEEP(*(.devcfg3)) } > devcfg3       AT > physical_devcfg3
/*  /DISCARD/ : { KEEP(*(.reginfo) *(.MIPS.abiflags)) } */
}




/* vim: set shiftwidth=2:  */
