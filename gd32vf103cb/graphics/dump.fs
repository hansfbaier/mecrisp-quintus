\ MB jan 2020
\ dump ( addr len -- )
\ I needed it

decimal

: ?emit ( n -- )
    dup 31 >
    over 127 < and \ .s 
    IF emit ELSE drop [char] . emit THEN
;

: -aligned ( addr -- addr ' )
    dup 4 mod
    IF 4 - aligned THEN
;

: .dumpline ( addr -- addr' )
    cr
    base @ hex swap
    dup s>d <# # # # # [char] . hold # # # # #> type 3 spaces
    dup
    8 0 DO count s>d <# # # #> type space
    LOOP
    ."  -- "
    8 0 DO count s>d <# # # #> type space
    LOOP
    4 spaces
    swap 8 0 DO count ?emit LOOP 
    2 spaces 8 0 DO count ?emit LOOP drop
    swap base !
;


: dump ( addr n -- )
    cr over dup . + swap
    -aligned
    BEGIN .dumpline 2dup <=
    UNTIL
    2drop
;

$20001000 100 dump