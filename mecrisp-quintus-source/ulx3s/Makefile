
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-ulx3s.bin

mecrisp-quintus-ulx3s.o : mecrisp-quintus-ulx3s.s
	$(ARMGNU)-as mecrisp-quintus-ulx3s.s -o mecrisp-quintus-ulx3s.o -march=rv32im

mecrisp-quintus-ulx3s.bin : memmap mecrisp-quintus-ulx3s.o
	$(ARMGNU)-ld -o mecrisp-quintus-ulx3s.elf -T memmap mecrisp-quintus-ulx3s.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-ulx3s.elf > mecrisp-quintus-ulx3s.list
	$(ARMGNU)-objcopy mecrisp-quintus-ulx3s.elf mecrisp-quintus-ulx3s.bin -O binary

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
