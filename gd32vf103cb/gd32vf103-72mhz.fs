\ Program Name: gd32vf103-72mhz.fs
\ Date: Jan 2020
\ For Mecrisp-Quintus by Matthias Koch.
\ https://sourceforge.net/projects/mecrisp/
\ Chip: Gigadevices GD32VF103, Board: Longan-Nano
\ Clock: 72 Mhz, note this chip can go to 108MHz with zero flash wait states.
\ Which probably means it's shadowing Flash into Ram as GD tend to do ?
\ -------------------------------------------------------------
\ Clock setup and timing. STANDALONE no dependencies.
\
\ The peripheral clock is PCLK2 for USART0 @ $40013808
\ USARTDIV = PCLK2 / Baud Rate
\ 72,000,000 / 115200 baud = 625
\ -------------------------------------------------------------
 compiletoflash
 \ compiletoram

 : 72mhz ( -- )				  \ HSE = on board 8Mhz xtal
   %1 16 lshift $40021000  bis! 	  \ RCU_CTL_HXTALEN    External High Speed oscillator Enable
   begin 
      %1 17 lshift $40021000 bit@ 
   until				  \ RCU_CTL_HXTALSTB   External crystal oscillator HXTAL clock stabilization flag
   1 16 lshift				  \ HSE clock is 8 MHz Xtal source for PLL
   %111 18 lshift or			  \ PLL * 9 (%111) = 72 MHz = HCLK = PCLK2
   4  8 lshift or			  \ PCLK1 = HCLK/2 = 36 MHz. Maximum is 54 MHz.
   2 14 lshift or			  \ ADCPRE = PCLK2/6 = 12 MHz. Maximum is 14 MHz.
   2 or  $40021004 !			  \ RCU_CFG0; PLL is the system clock
   %1 24 lshift $40021000 bis!		  \ RCU_CTL_PLLEN    PLL enable
   begin
      %1 25 lshift $40021000 bit@ 
   until				  \ RCU_CTL_PLLSTB    PLL Clock Stabilization Flag

   625 $40013808 !			  \ 115200 baud @ clock of 72 MHz = 625
 ;

 : init 72mhz ;

   compiletoram
