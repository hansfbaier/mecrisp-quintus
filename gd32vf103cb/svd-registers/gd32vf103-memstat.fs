\ Program Name: memstat.fs
\ Date: Sun 12 Jan 2020 18:55:01 AEDT
\ Copyright 2020 by t.j.porter <terry@tjporter.com.au>, licensed under the GPLV2
\ For Mecrisp-Stellaris by Matthias Koch.
\ https://sourceforge.net/projects/mecrisp/
\ Standalone: no preloaded support files required
\
\ This Program : Displays memory statistics
\
\ ---------------------------------------------------------------------------\
\     Usage:    " ramsize-kb flashmod flash-size-register-address memstats "
\
\     'ramsize-kb' = Get the MCU ram size from the datasheet as it's not 
\     available from the mcu directly like the flash size.
\
\     'flashmod' = flash size modifier
\	 '1' = normal use, flash exactly as reported
\
\	 '2' = doubles the reported flash size. Only for a STM32F103C8 which
\	 reports 64kB of Flash but actually has DOUBLE (128kB) that size.
\	 OR if you suspect your chip MAY have double the flash advertized. Note:
\	 will crash this program with a Exception if it doesn't!
\
\     'flash-size-register-address' = "Flash size data register address". Check
\     your STM reference manual "Device electronic signature" section for the
\     correct address.
\
\     'memstats' = this program
\
\ --------------------------- MCU Type Examples -----------------------------\
\  
\ ram-size  flashmod	ram-size    ram-size MCU Type
\ -kb			-register   (bytes)
\			-address
\ --------  ---------   ---------   -------- --------
\  8	    1		$1FFFF7CC   8192     STM32F0
\  20	    1		$1FFFF7E0   20480    STM32F10
\  20	    2		$1FFFF7E0   20480    STM32F103C8 (2x indicated Flash)
\  20	    1		$1FF8007C   20480    STM32L0x3
\  64	    1		$1FFF7A22   65536    STM32F407,415,427,437,429,439
\  32	    1		$1FFFF7E0   32768    GD32VF103
\ 
\ ----------------------------- Screenshot ----------------------------------\
\
\ free 
\ Memory stats in bytes: 
\ Total Flash:131072  Free:27336  Used:103736 
\ Total Ram:20480  Free:18784  Used:1696 
\ ok.
\ ----------------------------- Screenshot ----------------------------------\

 \ compiletoram
  compiletoflash

 : flashfree ( flashmod flash-size-register-address -- free flash )
   @ $FFFF and 1024 * * dup
   compiletoram? >r
   compiletoflash		     
   here -			    
      r> if compiletoram
      then			    
 ;
 
 : ramfree ( ramsize-kb -- free ram ) 
   compiletoram? not    
   flashvar-here	    
   4 -			    
   compiletoram	   
   here -
   swap		   		   
      if compiletoflash   
      then
 ;
 
 : memstats ( ramsize-kb flashmod flash-size-register-address -- memory stats) cr
   ." Memory stats in bytes: " cr   
   flashfree swap 2dup ." Total Flash:". ."  Free:" . swap - ."  Used:" . cr
   1024 * ramfree  2dup  swap ." Total Ram:". ."  Free:" . - ."  Used:" . cr
 ;      
 
  : free ( -- ) 32 1 $1FFFF7E0 memstats ;  \ <---- Change this to suit your MCU <---- <-----


 \ free

 compiletoram
