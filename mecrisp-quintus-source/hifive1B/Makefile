
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-hifive1B.bin

mecrisp-quintus-hifive1B.o : mecrisp-quintus-hifive1B.s
	$(ARMGNU)-as mecrisp-quintus-hifive1B.s -o mecrisp-quintus-hifive1B.o -march=rv32im

mecrisp-quintus-hifive1B.bin : memmapB mecrisp-quintus-hifive1B.o
	$(ARMGNU)-ld -o mecrisp-quintus-hifive1B.elf -T memmapB mecrisp-quintus-hifive1B.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-hifive1B.elf > mecrisp-quintus-hifive1B.list
	$(ARMGNU)-objcopy mecrisp-quintus-hifive1B.elf mecrisp-quintus-hifive1B.bin -O binary
	$(ARMGNU)-objcopy mecrisp-quintus-hifive1B.elf mecrisp-quintus-hifive1B.hex -O ihex

clean:
	rm -f *.bin
	rm -f *.hex
	rm -f *.o
	rm -f *.elf
	rm -f *.list
