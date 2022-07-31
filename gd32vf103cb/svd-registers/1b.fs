\ Program Name: 1b.fs  for Mecrisp-Stellaris by Matthias Koch and licensed under the GPL
\ Copyright 2019 t.porter <terry@tjporter.com.au> and licensed under the BSD license.
\ This program must be loaded before memmap.fs as it provided the pretty printing legend for generic 32 bit prints
\ Also included is "bin." which prints the binary form of a number with no spaces between numbers for easy copy and pasting purposes

compiletoflash

\ -------------------
\  Beautiful output
\ -------------------

: u.2 ( u -- ) 0 <# # # #> type ;
: u.4 ( u -- ) 0 <# # # # # #> type ;
: u.8 ( u -- ) 0 <# # # # # # # # # #> type ;
: h.4 ( u -- ) base @ hex swap  u.4  base ! ;
: h.2 ( u -- ) base @ hex swap  u.2  base ! ;

: u.ns 0 <# #s #> type ;
: const. ."  #" u.ns ;
: addr. u.8 ;
: .decimal base @ >r decimal . r> base ! ;



: b8loop. ( u -- ) \ print  32 bits in 4 bit groups
0 <#
7 0 DO
# # # #
32 HOLD
LOOP
# # # # 
#>
TYPE ;

: b16loop. ( u -- ) \ print 32 bits in 2 bit groups
0 <#
15 0 DO
# #
32 HOLD
LOOP
# #
#>
TYPE ;

: b16loop-a. ( u -- ) \ print 16 bits in 1 bit groups
0  <#
15 0 DO 
# 32 HOLD LOOP
# #>
TYPE ;

: b32loop. ( u -- ) \ print 32 bits in 1 bit groups with vertical bars
0  <#
31 0 DO 
# 32 HOLD LOOP
# #>
TYPE ; 

: b32sloop. ( u -- ) \ print 32 bits in 1 bit groups without vertical bars
0  <#
31 0 DO
# LOOP
# #>
TYPE ;

\ for use with AUTO GENERATED default labels ............................
: 1b. ( u -- ) cr \ 31-0, 1 bit groups generic legend
." 3|3|2|2|2|2|2|2|2|2|2|2|1|1|1|1|1|1|1|1|1|1|" cr
." 1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0 " cr
@ binary b32loop. decimal cr cr ;

: 2b. ( u -- ) cr \ 32 bit, 2 bit groups generic legend
." 15|14|13|12|11|10|09|08|07|06|05|04|03|02|01|00 " cr
@ binary b16loop. decimal cr cr ;

: 4bl. ( u -- ) cr \ 32 bit, 4 bit groups generic legend for bits 7 - 0
."  07   06   05   04   03   02   01   00  " cr
@ binary b8loop. decimal cr cr ;

: 4bh. ( u -- ) cr \ 32 bit, 4 bit groups generic legend for bits 15 - 8
."  15   14   13   12   11   10   09   08  " cr
@ binary b8loop. decimal cr cr ;

: 16b. ( u -- ) cr  \ 16 bit - 1 bit groups generic legend
." 1|1|1|1|1|1|" cr
." 5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0 " cr
@ binary b16loop-a. decimal cr cr ;

\ Manual Use Legends ..............................................
: bin. ( u -- ) dup ." $" hex.  cr   \ 1 bit legend - manual use
." 3322222222221111111111" cr
." 10987654321098765432109876543210 " cr
binary b32sloop. decimal cr cr ;

: bin1. ( u -- ) dup ." $" hex. cr \ 1 bit legend - manual use
." 3|3|2|2|2|2|2|2|2|2|2|2|1|1|1|1|1|1|1|1|1|1|" cr
." 1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0|9|8|7|6|5|4|3|2|1|0 " cr
binary b32loop. decimal cr cr ;

: bin2. ( u -- ) dup ." $" hex. cr \ 2 bit legend - manual use
." 15|14|13|12|11|10|09|08|07|06|05|04|03|02|01|00 " cr
binary b16loop. decimal cr cr ;

: bin4. ." Must be bin4h. or bin4l. " cr ;

: bin4l. ( u -- ) dup ." $" hex.  cr \ 4 bit generic legend for bits 7 - 0 - manual use
."  07   06   05   04   03   02   01   00  " cr
binary b8loop. decimal cr cr ;

: bin4h. ( u -- ) dup ." $" hex.  cr \ 4 bit generic legend for bits 15 - 8 - manual use
."  15   14   13   12   11   10   09   08  " cr
binary b8loop. decimal cr cr ;

compiletoram

