
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-nandland.bin

mecrisp-quintus-nandland.o : mecrisp-quintus-nandland.s
	$(ARMGNU)-as mecrisp-quintus-nandland.s -o mecrisp-quintus-nandland.o -march=rv32i

mecrisp-quintus-nandland.bin : memmap mecrisp-quintus-nandland.o
	$(ARMGNU)-ld -o mecrisp-quintus-nandland.elf -T memmap mecrisp-quintus-nandland.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-nandland.elf > mecrisp-quintus-nandland.list
	$(ARMGNU)-objcopy mecrisp-quintus-nandland.elf mecrisp-quintus-nandland.bin -O binary

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
