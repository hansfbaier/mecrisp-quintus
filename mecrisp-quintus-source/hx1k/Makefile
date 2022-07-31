
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-hx1k.bin

mecrisp-quintus-hx1k.o : mecrisp-quintus-hx1k.s
	$(ARMGNU)-as mecrisp-quintus-hx1k.s -o mecrisp-quintus-hx1k.o -march=rv32i

mecrisp-quintus-hx1k.bin : memmap mecrisp-quintus-hx1k.o
	$(ARMGNU)-ld -o mecrisp-quintus-hx1k.elf -T memmap mecrisp-quintus-hx1k.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-hx1k.elf > mecrisp-quintus-hx1k.list
	$(ARMGNU)-objcopy mecrisp-quintus-hx1k.elf mecrisp-quintus-hx1k.bin -O binary

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
