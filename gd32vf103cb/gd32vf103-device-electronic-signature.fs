\ Program Name: device-electronic-signature.fs
\ Date: Wed 8 Nov 2019
\ Copyright 2019  t.porter <terry@tjporter.com.au>, licensed under the GPL
\ For Mecrisp-Stellaris by Matthias Koch
\ Chip: GD32VF103

\ stm32id 
\ Die xy coords: 107741012 
\ Wafer Number: 72 
\ Lot_num ascii encoded  [23:0]: 0x00555285  | U R .
\ Lot_num ascii encoded [55:24]: 0x87237267  | . # r g


\ compiletoflash

 : is-ascii? ( u -- yes = print | no = . ) >r
   r@ 32 u>= r@ 127 u<
   and if
      r> emit
      else
      [char] . emit rdrop
      then ;

 : UNIQUE_ID[31:0] ( -- )
   $1FFFF7E8 @ dup ." UNIQUE_ID[31:0]  0x" hex. ." | "
   dup $ff000000 and 24 rshift is-ascii? space
   dup $00ff0000 and 16 rshift is-ascii? space
   dup $0000ff00 and  8 rshift is-ascii? space
       $000000ff and is-ascii? ;


 : UNIQUE_ID[63:32] ( -- )
   $1FFFF7EC @ dup ." UNIQUE_ID[63:32] 0x" hex. ." | "
   dup $ff000000 and 24 rshift is-ascii? space
   dup $00ff0000 and 16 rshift is-ascii? space
   dup $0000ff00 and  8 rshift is-ascii? space
       $000000ff and is-ascii? ;

 : UNIQUE_ID[95:64] ( -- )
   $1FFFF7F0 @ dup ." UNIQUE_ID[95:64] 0x" hex. ." | "
   dup $ff000000 and 24 rshift is-ascii? space
   dup $00ff0000 and 16 rshift is-ascii? space
   dup $0000ff00 and  8 rshift is-ascii? space
       $000000ff and is-ascii? ;
 
 : id ( -- ) cr
   UNIQUE_ID[31:0]  cr
   UNIQUE_ID[63:32] cr
   UNIQUE_ID[95:64] cr
 ;


compiletoram

\ id

\ id 
\ UNIQUE_ID[31:0]  0x3641294D | 6 A ) M
\ UNIQUE_ID[63:32] 0x00123736 | . . 7 6
\ UNIQUE_ID[95:64] 0xFFFFFFFF | . . . .
\  ok.

