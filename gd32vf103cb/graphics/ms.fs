\ Das folgende läßt sich nicht hochladen! Warum? Na, was macht den der Uploader aus dem \?
\ Also per paste&copy ins Terminal schreiben.
\ \en: Try to write comments in English.
\ \de: Kommentare auf Deutsch.

\ \en: A ms based on the systick feature of the bumblebee core
\ \de: Eine Millisekunde. Es wird der Systick des bumblebee cores ausgenutzt.
    
    \ "Bumblebee core datasheet_en.pdf": 6.1.3. Timing through the mtime register
    \ register offset default   read/write function    
    \ mtime_lo 0x0 (0x00000000)     r/w Reflects the lower 32-bit value of timer and mtime
    \ mtime_hi 0x4 (0x00000000)     r/w  Reflects the high 32-bit value of the timer and mtime
    \ mtimecmp_lo 0x8 (0xFFFFFFFF)  r/w Configure the timer comparison value and  mtimecmp to be lower 32 bits
    \ mtimecmp_hi 0xc (0xFFFFFFFF) r/w Configure the timer comparison value and mtimecmp high 32 bits
    \ mstop 0xFF8 (0x00000000) r/w Control the pause of the timer  \ bits 7 - 1 = reserved; bit 0 = puse/run 0=run; 1=pause
    \ msip 0xFFC (0x00000000)r/w Generate software interrupts
    
    \ register mtime
    \ 64-bit Value systickcounter since reset

    \ register mstop
    \ bits 7 - 1 = reserved; bit 0 = puse/run 0=run; 1=pause
    
\     Ah! Hilfe: Die Doku oben teilt nur die Offsets mit. ZUr Baseaddress steht dort:
\     The base address of the TIMER unit in the Bumblebee kernel is described in
\       the Bumblebee Kernel Concise Data Sheet. Das ist "Bumblebee core intro_en.pdf"
\       Dort findet sich nichts zur Baseadress auch nicht in der Memory-Map im User Manual.
\       Schrecklich!
    \
    \ Wichtig! Die 'note'
\       Note: The RISC-V architecture does not define the mtime and mtimecmp registers as
\ CSR registers, but rather as system registers for Memory Address Mapped. The specific
\ memory mapped address RISC-V architecture is not specified, but is instead The kernel
\ designer implements it on its own.In the implementation of the Bumblebee kernel,
\ mtime/mtimecmp is
\ TIMER unit implementation, see the Bumblebee Kernel Instruction Architecture Handbook
\ for details on the TIBR unit of the Bumblebee kernel.
\     Das "Bumblebee Kernel Instruction Architecture Handbook" ist das "bumblebee core datasheet._en.pdf"
\     Typische Zirkelreferenz - aber keines teilt die Adresse mit.
    
        
\     Weiter:
\     In .platformio/packages/framework-gd32vf103-sdk/RISCV/drivers/n200_timer.h stehen folgende defines:
\     #define TIMER_MSIP 0xFFC
\     #define TIMER_MSIP_size   0x4
\     #define TIMER_MTIMECMP 0x8
\     #define TIMER_MTIMECMP_size 0x8
\     #define TIMER_MTIME 0x0
\     #define TIMER_MTIME_size 0x8

\     #define TIMER_CTRL_ADDR           0xd1000000
\     #define TIMER_REG(offset)         _REG32(TIMER_CTRL_ADDR, offset)
\     #define TIMER_FREQ                    ((uint32_t)SystemCoreClock/4)  //units HZ

\ Fazit (nach einem ganzen Vormittag!): Die Doku ist so beschaffen, dass man (ich) nicht ohe die C-Quellen auskommt!

\ \de: Die Zählwerte für eine Millisekunde (Systicks) werden in einer Variablen gehalten. Mit welcher Frequenz die
\ \de: Cpu läuft, wird nicht abgefragt. Da muss der Programmierer, wenn er die Frequenzen umstellt, den richtigen
\ \de: Wert setzten. Dabei hilft das Wort freq-ms (s.u.)

\ \en: The systicks counts are stored in a variable. This is not done automatically. It has to be invoked by the
\ \en: programmer using the word freq-ms (see below).
    
\ \en: Systemticks depend on SystemcoreClock and is one fourth of it.
\ \de: Systemtick ist ein Viertel der SystemCoreClock.

$D1000000 Constant mtime \ \de: mtime ist mtime_base + 0      
                         \ \en: mitme equals mtime_base + 0

\ \en: systicks waits for n systicks. Of course there will be an overhead - especially at short times.
\ \de: systicks wartet n systicks lang. Es gibt einen Overhead - besonders bei kurzen Zeiten.   
    : systicks ( n -- )  
        mtime 2@ swap
        rot s>d d+
        BEGIN mtime 2@ swap
            2over du>
        UNTIL
        2drop
    ;

   
    \ 8MHz -->     8.000.000 / 4 per second =  2000000/sec =  2000/ms =  2.00/us
    \ 16MHz ...    4.000.000 / 4 per second =  4000000/sec =  4000/ms =  4.00/us
    \ 25MHz -->   25.000.000 / 4 per second =  6250000/sec =  6250/ms =  6.25/us 
    \ 36MHz -->   36.000.000 / 4 per second =  9000000/sec =  9000/ms =  9.00/us 
    \ 48MHz -->   48.000.000 / 4 per second = 12000000/sec = 12000/ms = 12.00/us
    \ (60MHZ)
    \ 72MHz -->   72.000.000 / 4 per second = 18000000/sec = 18000/ms = 18.00/us 
    \ (84MHz)
    \ 96MHz -->   96.000.000 / 4 per second = 24000000/sec = 24000/ms = 24.00/us 
    \ 108MHz --> 108.000.000 / 4 per second = 27000000/sec = 27000/ms = 27.00/us 

 
    
\ \de: mecrisp läuft nach einem reset mit 8MHz
\ \en: after reset mecrisp runs with a speed of 8MHz
2000 Variable ms-systicks     
   2 Variable us-systicks
    
\ \de: die Frequenz in MHz wird in die entsprechden Systicks für eine ms und us umgewandelt.
\ \en: calculate the systick count depending in the cpu-freq MHz
: freq-ms ( n -- ) \ freq (MHz) i.e. 36 equals 38,000,000
    250 * ms-systicks ! ;

: ms ( n -- )
    ms-systicks @ * systicks
;

\ \en: Cave at! There's a big overhead!
\ \de: Achtung! Ein hoher Overhead!
: us ( n -- )
    ms-systicks @ 1000 */ systicks ; 