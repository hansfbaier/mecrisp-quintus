\ Program Name: gd32vf103-104mhz.fs
\ Date: Jan 2020
\ For Mecrisp-Quintus by Matthias Koch.
\ https://sourceforge.net/projects/mecrisp/
\ Chip: Gigadevices GD32VF103, Board: Longan-Nano
\ Clock: 104 Mhz with a 8mhz xtal, note this chip can go to 108MHz
\ with zero flash wait states using a different xtal.
\ because it has a serial Flash that loads into Ram at boot.
\ -------------------------------------------------------------
\  Clock setup and timing. STANDALONE no dependencies.
\  406800 baud
\ -------------------- screenshot -----------------------------
\ Mecrisp-Quintus 0.27 for RISC-V 32 IMC on GD32VF103CB by Matthias Koch
\ 
\ Clock: 8MHz --> 104MHz 
\ Serial: 115200 bps --> 460800 bps, please change the terminal speed accordingly. 
\ If Picocom is in use, 50mS will now be adequate for EOL delays.
\ ------------------------------------------------------------
\  compiletoflash
\ compiletoram

 : 104mhz ( -- )                          \ HSE = on board 8Mhz xtal
   %1 16 lshift $40021000  bis!           \ RCU_CTL_HXTALEN    External High Speed oscillator Enable
   begin 
      %1 17 lshift $40021000 bit@         
   until                                  \ RCU_CTL_HXTALSTB   External crystal oscillator HXTAL clock stabilization flag
   1 16 lshift                            \ HSE clock is 8 MHz Xtal source for PLL
   %1011 18 lshift or                     \ PLL * 13 (%1011) = 104 MHz
   4  8 lshift or                         \ PCLK1 = HCLK/2 = 36 MHz. Maximum is 54 MHz.
   2 14 lshift or                         \ ADCPRE = PCLK2/6 = 12 MHz. Maximum is 14 MHz.
   2 or  $40021004 !                      \ RCU_CFG0; PLL is the system clock
   %1 24 lshift $40021000 bis!            \ RCU_CTL_PLLEN    PLL enable
   begin
      %1 25 lshift $40021000 bit@ 
   until                                  \ RCU_CTL_PLLSTB    PLL Clock Stabilization Flag  
   \  225 $40013808 !                     \ 406800 baud @ clock of 104 MHz = 225
   #907 $40013808 !                        \ 115200 baud @ clock of 104 MHz = 628 MB
 ;


 
 
 
\ 104mhz \ test
 

 
 : 104-init
     26000 ms-systicks !
     104mhz
     cr
     ." Clock set to 104MHz " cr
     ." adjusted Variable ms-systicks to 26.000 " cr
     ." Baudrate set to 115200 " cr
     Flamingo
 ;

 : init ( -- ) init 104-init ; 
 
 \ : init
 \   cr
 \   ." Clock: 8MHz --> 104MHz " cr
 \   ." Serial: 115200 bps --> 460800 bps, please change the terminal speed accordingly. " cr
 \   ." If Picocom is in use, 50mS will now be adequate for EOL delays." cr
 \   104mhz
 \   ;

\   compiletoram



