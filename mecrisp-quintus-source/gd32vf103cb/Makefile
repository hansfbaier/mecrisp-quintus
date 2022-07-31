
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-gd32vf103cb.bin

mecrisp-quintus-gd32vf103cb.o : mecrisp-quintus-gd32vf103cb.s
	$(ARMGNU)-as mecrisp-quintus-gd32vf103cb.s -o mecrisp-quintus-gd32vf103cb.o -march=rv32im

mecrisp-quintus-gd32vf103cb.bin : memmap mecrisp-quintus-gd32vf103cb.o
	$(ARMGNU)-ld -o mecrisp-quintus-gd32vf103cb.elf -T memmap mecrisp-quintus-gd32vf103cb.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-gd32vf103cb.elf > mecrisp-quintus-gd32vf103cb.list
	$(ARMGNU)-objcopy mecrisp-quintus-gd32vf103cb.elf mecrisp-quintus-gd32vf103cb.bin -O binary

clean:
	rm -f *.bin
	rm -f *.hex
	rm -f *.o
	rm -f *.elf
	rm -f *.list
