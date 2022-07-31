
# Mecrisp-Quintus for PIC32MX270F256B chip.

This chip is available in a 28-pin DIP package, as well as other surface-mount 
packages.  This README pertains only to the DIP package, and it has not been 
tested with other packages. The chip has 256kB of Flash and 64kB of RAM, 
operates on 3.3V (with four pins 5v tolerant), has a USB peripheral, 10-bit 
1.1MSPS ADC, internal fast RC oscillator, and plenty of IO.

### Connections

The connections for the chip are shown in Figure 2.1 of the data sheet. You 
must connect them as described; do not overlook VUSB3V3, VCAP, and MCLR (raised 
to VDD with a resistor, and debounced with a small ceramic capacitor). As 
explained in the datasheet, you must also attach AVDD to VDD (using a 1 or 
2-ohm resistor is fine; add another capacitor to ground) and AVSS to VSS.  The 
pinout for this chip is at Table 4.  

> See here for the [data sheet](http://ww1.microchip.com/downloads/en/DeviceDoc/PIC32MX1XX2XX-28-36-44-PIN-DS60001168K.pdf)

In addition, to flash the hex file onto the chip, you will need a programmer 
like the PICKit3. Use a simple pin header and connector and connect PGED1/PGEC1 
(pins 4 and 5, respectively) to pins 4 and 5 of the PICKit3 header.

As of right now, serial connections do not work via USB; you must use a serial 
adapter. This version of Mecrisp uses UART1, connected to pins 11 and 12 of the 
chip. RPB4 (pin 11) is TX and RPA4 is RX.

### TODO:
	* Interrupts

