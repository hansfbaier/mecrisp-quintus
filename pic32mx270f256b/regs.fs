\ forth registers for PIC32MX270F256B
\ a 32-bit PIC32MX microcontroller in a DIP-28 package

\ useful additions for clearing, setting, or inverting
\ a bit in almost all registers in the chip
\ e.g., TRISAINV is simply: TRISA __INV + 
\ to set turn on timer1, you would 15 T1CON __SET + !
\ because bit 15 is the "ON" bit for the T1CON register
$04       constant __CLR
$08       constant __SET
$0C       constant __INV

\ simple GPIO registers
$BF886000 constant ANSELA
$BF886010 constant TRISA
$BF886020 constant PORTA
$BF886030 constant LATA

$BF886100 constant ANSELB
$BF886110 constant TRISB
$BF886120 constant PORTB
$BF886130 constant LATB


\ TIMER1
$BF800600 constant T1CON
$BF800610 constant TMR1
$BF800620 constant PR1

$BF800800 constant T2CON
$BF800810 constant TMR2
$BF800820 constant PR2
$BF800A00 constant T3CON
$BF800A10 constant TMR3
$BF800A20 constant PR3
$BF800C00 constant T4CON
$BF800C10 constant TMR4
$BF800C20 constant PR4
$BF800E00 constant T5CON
$BF800E10 constant TMR5
$BF800E20 constant PR5






