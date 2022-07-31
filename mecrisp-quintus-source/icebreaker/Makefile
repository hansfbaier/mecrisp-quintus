
ARMGNU?=riscv64-linux-gnu

AOPS = --warn --fatal-warnings

all : mecrisp-quintus-icebreaker.bin

mecrisp-quintus-icebreaker.o : mecrisp-quintus-icebreaker.s
	$(ARMGNU)-as mecrisp-quintus-icebreaker.s -o mecrisp-quintus-icebreaker.o -march=rv32im

mecrisp-quintus-icebreaker.bin : memmap mecrisp-quintus-icebreaker.o
	$(ARMGNU)-ld -o mecrisp-quintus-icebreaker.elf -T memmap mecrisp-quintus-icebreaker.o -m elf32lriscv
	$(ARMGNU)-objdump -Mnumeric -D mecrisp-quintus-icebreaker.elf > mecrisp-quintus-icebreaker.list
	$(ARMGNU)-objcopy mecrisp-quintus-icebreaker.elf mecrisp-quintus-icebreaker.bin -O binary

clean:
	rm -f *.bin
	rm -f *.o
	rm -f *.elf
	rm -f *.list
