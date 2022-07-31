\ memstat.fs
\ For use with Mecrisp-Stellaris Forth by Matthias Koch, Version: 2.3.6
\ Used with a GD32VF103 MCU
\ Author:  T.Porter <terry@tjporter.com.au> 2019
\ This Program:  prints out memory stats
\ ...........................................

 compiletoflash

\ Bits   Fields         Descriptions
\ 31:16  SRAM_DENSITY   SRAM density
\        [15:0]         The value indicates the on-chip SRAM density of the device in Kbytes.
\ 15:0                  Example: 0x0008 indicates 8 Kbytes.
\ 
\        FLASH_DENSITY  Flash memory density
\        [15:0]         The value indicates the Flash memory density of the device in Kbytes.
\                       Example: 0x0020 indicates 32 Kbytes.



: flashfree    ( here hex. = currently in compiletoram mode @ memory location 2000038C )
   compiletoram?		 \ Remember if in compile mode on entry. compiletoram? leaves -1 on stack if in compiletoram mode. 
   $1FFFF7E0 @ $FFFF and 1024 *  \ FLASH as reported by the  "Flash size data register"
   compiletoflash		 \ enter compiletoflash mode. here hex. = 0000F860 (63584). dictionary pointer is at 63584 right now
   here -			 \ 65536 - 63584 = reported mcu flash minus dictionary pointer
   swap				 \ .s = 1952 -1 after swap command for following IF decision statement to use
      if compiletoram		 \ in compiletoram on entry, restore mode on exit
   then				 \ free FLASH memory is 1952 bytes
;

: ramfree    ( here hex. = currently in compiletoram mode @ memory location $2000038C ) 
   compiletoram?	\ Remember if in compile mode on entry. compiletoram? leaves -1 on stack if in compiletoram mode.
   not			\ invert the compiletoram? test result for compiletoflash test instead
   flashvar-here	\ flashvar-here = current RAM management pointer = $20001B24. Ram starts at $20000000. 8192 = $2000
   4 -			\ subtract 4 bytes because ??? ($20001B24 - 4 = $20001B20)
   compiletoram		\ enter compiletoram mode
   here -		\ $20001B20 - $2000038C = $1794 = 6036
   swap			\ .s =  6036 0
      if compiletoflash	\ in compiletoflash on entry, restore mode on exit
   then
;

: free ( -- ) ." (bytes) " cr
   ." FLASH.. TOTAL REPORTED: " $1FFFF7E0 @ $FFFF and 1024 * dup >R .	\ FLASH as reported by the  "Flash size data register"
   ." USED: " R> flashfree  - . ." FREE: " flashfree .
   cr
   32767 >R								\ RAM VALUE, 32kB
   ." RAM.... TOTAL PRESET: "  R@ . ." USED: " R> ramfree - . ." FREE: " ramfree .
   cr cr
 ;

compiletoram



