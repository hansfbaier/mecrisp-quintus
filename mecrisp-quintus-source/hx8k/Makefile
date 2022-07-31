
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-hx8k.bin

mecrisp-quintus-hx8k.o : mecrisp-quintus-hx8k.s
	$(ARMGNU)-as mecrisp-quintus-hx8k.s -o mecrisp-quintus-hx8k.o -march=rv32imc

mecrisp-quintus-hx8k.bin : memmap mecrisp-quintus-hx8k.o
	$(ARMGNU)-ld -o mecrisp-quintus-hx8k.elf -T memmap mecrisp-quintus-hx8k.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-hx8k.elf > mecrisp-quintus-hx8k.list
	$(ARMGNU)-objcopy mecrisp-quintus-hx8k.elf mecrisp-quintus-hx8k.bin -O binary

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
