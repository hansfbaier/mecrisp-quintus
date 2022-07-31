
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-tm4c1294-mamihlapinatapai.bin

mecrisp-quintus-tm4c1294-mamihlapinatapai.o : mecrisp-quintus-tm4c1294-mamihlapinatapai.s
	$(ARMGNU)-as mecrisp-quintus-tm4c1294-mamihlapinatapai.s -o mecrisp-quintus-tm4c1294-mamihlapinatapai.o -march=rv32im

mecrisp-quintus-tm4c1294-mamihlapinatapai.bin : memmap mecrisp-quintus-tm4c1294-mamihlapinatapai.o
	$(ARMGNU)-ld -o mecrisp-quintus-tm4c1294-mamihlapinatapai.elf -T memmap mecrisp-quintus-tm4c1294-mamihlapinatapai.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-tm4c1294-mamihlapinatapai.elf > mecrisp-quintus-tm4c1294-mamihlapinatapai.list
	$(ARMGNU)-objcopy mecrisp-quintus-tm4c1294-mamihlapinatapai.elf mecrisp-quintus-tm4c1294-mamihlapinatapai.bin -O binary

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
