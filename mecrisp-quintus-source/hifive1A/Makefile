
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-hifive1A.bin

mecrisp-quintus-hifive1A.o : mecrisp-quintus-hifive1A.s
	$(ARMGNU)-as mecrisp-quintus-hifive1A.s -o mecrisp-quintus-hifive1A.o -march=rv32im

mecrisp-quintus-hifive1A.bin : memmapA mecrisp-quintus-hifive1A.o
	$(ARMGNU)-ld -o mecrisp-quintus-hifive1A.elf -T memmapA mecrisp-quintus-hifive1A.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-hifive1A.elf > mecrisp-quintus-hifive1A.list
	$(ARMGNU)-objcopy mecrisp-quintus-hifive1A.elf mecrisp-quintus-hifive1A.bin -O binary
	$(ARMGNU)-objcopy mecrisp-quintus-hifive1A.elf mecrisp-quintus-hifive1A.hex -O ihex

clean:
	rm -f *.bin
	rm -f *.hex
	rm -f *.o
	rm -f *.elf
	rm -f *.list
