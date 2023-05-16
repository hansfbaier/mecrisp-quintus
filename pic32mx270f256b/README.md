
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
adapter. This version of Mecrisp uses UART1, connected to pins 24 and 26 of the
chip. RPA13 (pin 24) is RX and RPB15 (pin 26) is TX.

To flash the chip using open source tools, "Pickle" is recommended.

Using an AVR-based Arduino as PIC32 flasher is described here:
https://blogs.fsfe.org/pboddie/?p=1654

These instructions are valid for a Raspberry Pi 3B using vanilla Raspbian:

wget "https://wiki.kewl.org/downloads/pickle-5.01.tgz"
tar zxf pickle-5.01.tgz
cd pickle
make linux
sudo make linux-install

Config in ~/.pickle file:

DEVICE=RPI3
SLEEP=1
BITRULES=0x1000
VPP=9
PGM=-1
PGC=10
PGD=11

Connections for using Pickle and Terminal:

         3v3 Power (pin 17) <--> positive rail
  "PGC" on GPIO 10 (pin 19)      PGEC2 (pin 19)
  "VPP" on GPIO  9 (pin 21)      /MCLR (pin  1)
  "PGD" on GPIO 11 (pin 23)      PGED2 (pin 18)
            Ground (pin 25)      ground rail

           UART TX (pin  8)      RPB13 (pin 24)
           UART RX (pin 10)      RPB15 (pin 26)

Flashing can be done with these commands:

  p32 blank && p32 program mecrisp-quintus-pic32mx270f256b-with-tools.hex

It is handy to know that

  p32 config

also resets the chip without changing anything else.

For using the serial terminal of a Raspberry Pi 3B towards a microcontroller,
you need to configure it as /dev/serial0.

  sudo raspi-config

  -->  3 Interface Options
  --> I6 Serial Port
  --> Would you Would you like a login shell to be accessible over serial?  --> No.
  --> Would you like the serial port hardware to be enabled?                --> Yes.

      The serial login shell is disabled
      The serial interface is enabled

After installation of

  sudo apt-get install picocom minicom

one can reset and connect to terminal then:

  p32 config && picocom -b 115200 /dev/serial0 --imap lfcrlf,crcrlf --omap delbs,crlf --send-cmd "ascii-xfr -s -l 100 -n"
