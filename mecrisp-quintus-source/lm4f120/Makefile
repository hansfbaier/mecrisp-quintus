
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-lm4f120-mamihlapinatapai.bin

mecrisp-quintus-lm4f120-mamihlapinatapai.o : mecrisp-quintus-lm4f120-mamihlapinatapai.s
	$(ARMGNU)-as mecrisp-quintus-lm4f120-mamihlapinatapai.s -o mecrisp-quintus-lm4f120-mamihlapinatapai.o -march=rv32im

mecrisp-quintus-lm4f120-mamihlapinatapai.bin : memmap mecrisp-quintus-lm4f120-mamihlapinatapai.o
	$(ARMGNU)-ld -o mecrisp-quintus-lm4f120-mamihlapinatapai.elf -T memmap mecrisp-quintus-lm4f120-mamihlapinatapai.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-lm4f120-mamihlapinatapai.elf > mecrisp-quintus-lm4f120-mamihlapinatapai.list
	$(ARMGNU)-objcopy mecrisp-quintus-lm4f120-mamihlapinatapai.elf mecrisp-quintus-lm4f120-mamihlapinatapai.bin -O binary

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
