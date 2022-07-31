This is a GD32VF103 SVD2FORTH By Terry Porter <terry@tjporter.com.au> 2019 for Mecrisp_Quintus by Mathias Koch
Developed on FreeBSD but will run on other BSD's and Linux. 

Purpose:
========
It uses a MCU CMSIS-SVD file to auto generate every Peripheral and Register memory mapped Word, every Register Bitfield manipulation Word, and every GNU Assembler EQUATE for the *ENTIRE* MCU.
 

Quick Description
-----------------
1) Peripheral and Register Pretty Printing Legends are separated from the XML file and now contained in a "1b.fs" file.
2) 1b.fs MUST be loaded FIRST before anything else.
3) Both bitfields.fs and memmap.fs now contain description fields parsed from the SVD. Hopefully this will reduce the need to have a databook open while coding.
4) gd32vf103.svd.equates.s is for use in any assembly program.

Features:
* memmap.fs file contains all memory mapped peripheral Words and can print all register contents in a group or singly. The print Word for every register has a simple 32 bit legend showing the bit number and current value, this applies to registers which only use 15 bits or different groupings. Bitfields.fs, memmap.fs and equates.s files now contain description fields parsed from the SVD. Hopefully this will reduce the need to have a databook open while coding.

Example
-------
"ADC0." prints all the ADC register values but can also print enay MEMBER of that group alone, i.e. "ADC0_STAT."

* bitfield.fs file contains a Word for each bitfield to be pasted in full or part as desired.
Example
-------
\ ADC0_STAT (read-write) Reset:0x00000000
: ADC0_STAT_STRC ( -- x addr ) 4 bit ADC0_STAT ; \ ADC0_STAT_STRC, Start flag of regular channel group
: ADC0_STAT_STIC ( -- x addr ) 3 bit ADC0_STAT ; \ ADC0_STAT_STIC, Start flag of inserted channel group
: ADC0_STAT_EOIC ( -- x addr ) 2 bit ADC0_STAT ; \ ADC0_STAT_EOIC, End of inserted group conversion flag
: ADC0_STAT_EOC ( -- x addr ) 1 bit ADC0_STAT ; \ ADC0_STAT_EOC, End of group conversion flag
: ADC0_STAT_WDE ( -- x addr ) 0 bit ADC0_STAT ; \ ADC0_STAT_WDE, Analog watchdog event flag

A note about flags. Where a flag is read only then "bit@" will be appended as it can only ever be read. i.e.
\ CAN0_STAT (multiple-access)  Reset:0x00000C02
: CAN0_STAT_ERRIF? ( -- 1|0 ) 2 bit CAN0_STAT bit@ ; \ CAN0_STAT_ERRIF, Error interrupt flag

Longer Description
------------------
1) Peripheral and Register Pretty Printing Legends are separated from the XML file and now contained in a "1b.fs" file.
2) 1b.fs MUST be loaded first BEFORE memmap.fs
3) Both bitfields.fs and memmap.fs now contain description fields parsed from the SVD. Hopefully this will reduce the need to have a databook open while coding.

Howto
=====
* run "make everything", this creates template.xml, bitfields.fs, memmap.fs and STMxxxxx.svd.equates.s
* Edit "template.xml" and COMMENT OUT the Peripherals you are NOT using 
   Not commented out:  <name>GPIOE</name>
   Commented out:      <!-- <name>GPIOE</name> -->   
* run "make mem"
   This will create new bitfields.fs and memmap.fs based on your edited template.xml file.
* Upload 1b.fs then memmap.fs to your MCU. If the Flash or Ram is filled, then perhaps you didn't bother editing template.xml to reduce the size ?
* bitfields.fs are for copy and pasting into your Forth program to configure Register Bitfields.

Dependencies
=============
make
xsltproc
sed

template.xml
============
    Initially contains a list of ALL the Peripherals in your ARM svd MCU file. You edit this file by either commenting out, or deleting lines of Peripherals you DON'T want to use in your project. 

