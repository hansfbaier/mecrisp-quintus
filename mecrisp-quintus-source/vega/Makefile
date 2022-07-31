
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-vega.bin

mecrisp-quintus-vega.o : mecrisp-quintus-vega.s
	$(ARMGNU)-as mecrisp-quintus-vega.s -o mecrisp-quintus-vega.o -march=rv32im

mecrisp-quintus-vega.bin : memmap mecrisp-quintus-vega.o
	$(ARMGNU)-ld -o mecrisp-quintus-vega.elf -T memmap mecrisp-quintus-vega.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-vega.elf > mecrisp-quintus-vega.list
	$(ARMGNU)-objcopy mecrisp-quintus-vega.elf mecrisp-quintus-vega.bin -O binary
	$(ARMGNU)-objcopy mecrisp-quintus-vega.elf mecrisp-quintus-vega.hex -O ihex

clean:
	rm -f *.bin
	rm -f *.hex
	rm -f *.o
	rm -f *.elf
	rm -f *.list
