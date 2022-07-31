\ manhattan.fs
\ Part of pixelmaler-v0.1 for Mecrisp-Quintus - A native code Forth implementation for RISC-V
\ Copyright (C) 2018  Matthias Koch
\ display longan nano
\ MB March 2020

\ Just for fun: an orthogonal turtle graphic system
\ There is also an programm called turtle.fs
\ To avoid naming conflicts all words in this file
\ are preceded by 'mh-'. In this way one can use both
\ of them at one time.

\ Manhattan geometrie is kind of fun. What is the Pythagorean theorem
\ in manhattan geometry? How does a circle look in manhattan geometry?
\ What is the equivalent to Pi in  manhattan geometry?

0 Variable mh-pen         \ pen is down or up
0 Variable mh-orientation \ could be north(0), east(1), south(2), west(3)
0 0 2Variable mh-pos    \ turtle position
0 Variable mh-fg-col
0 Variable mh-bg-col

: mh-fg-col! ( -- ) \ store color of foreground
    color @ mh-fg-col ! ;

: mh-bg-col! ( -- ) \ store color of background
    color @ mh-bg-col ! ;

: mh-pencolor ( -- )
    mh-fg-col! ;

: mh-pu ( -- ) false mh-pen ! ; \ pen up

: mh-pd ( -- ) true  mh-pen !  \ pen down
    mh-fg-col @ color ! ;

: mh-north ( -- ) 0 mh-orientation ! ;
: mh-east  ( -- ) 1 mh-orientation ! ;
: mh-south ( -- ) 2 mh-orientation ! ;
: mh-west  ( -- ) 3 mh-orientation ! ;

: mh-mv-to ( x y -- ) mh-pos 2! ;  \ move to 

: mh-home ( -- )             \ turtle go home!
    tft-width @  2/
    tft-height @ 2/
    mh-pos 2!
    mh-north
    mh-pd ;

: mh-tg-erase ( -- ) \ turtle graphic erase
    mh-bg-col @ color !
    tft-clear
    mh-home ;

: mh-tl ( -- ) \ turn left
    mh-orientation @
    3 + 4 mod
    mh-orientation !
;

: mh-tr ( -- ) \ turn right
    mh-orientation @
    1 + 4 mod
    mh-orientation !
;

: mh-tt ( -- ) \ turtle turn
    mh-orientation @
    2 + 4 mod
    mh-orientation !
;    

: mh-n-line ( x y n -- ) \ draws a line northward
    tuck - swap p-line ;

: mh-s-line ( x y n -- ) \ draws a line southward
    p-line ;

: mh-e-line ( x y n -- ) \ draws a line eastward
    h-line ;

: mh-w-line  ( x y n -- ) \ draws a line westward
    rot over - -rot h-line ;

: mh-mv-n ( n -- ) \ move northward 
    mh-pos 2@ rot - mh-pos 2! ;

: mh-mv-s ( n -- ) \ move southwards
    mh-pos 2@ rot + mh-pos 2! ;

: mh-mv-e ( n -- ) \ move eastward
    mh-pos 2@ swap rot + swap mh-pos 2! ;

: mh-mv-w ( n -- ) \ move westward
    mh-pos 2@ swap rot - swap mh-pos 2! ;

: mh-fd ( n -- ) \ forward 
    dup
    mh-pos 2@ rot       
    mh-orientation @
    case
        0 of mh-pen @ IF mh-n-line ELSE 2drop drop THEN  mh-mv-n endof
        1 of mh-pen @ IF mh-e-line ELSE 2drop drop THEN  mh-mv-e endof
        2 of mh-pen @ IF mh-s-line ELSE 2drop drop THEN  mh-mv-s endof
        3 of mh-pen @ IF mh-w-line ELSE 2drop drop THEN  mh-mv-w endof
    endcase
;

: mh-bd ( n -- ) \ backwards    
    dup
    mh-pos 2@ rot       
    mh-orientation @
    case
        2 of mh-pen @ IF mh-n-line ELSE 2drop drop THEN  mh-mv-n endof
        3 of mh-pen @ IF mh-e-line ELSE 2drop drop THEN  mh-mv-e endof
        0 of mh-pen @ IF mh-s-line ELSE 2drop drop THEN  mh-mv-s endof
        1 of mh-pen @ IF mh-w-line ELSE 2drop drop THEN  mh-mv-w endof
    endcase
;


: mh-nwd ( n -- ) \ northward
    mh-north mh-fd ;

: mh-ewd ( n -- ) \ eastward
    mh-east mh-fd ;

: mh-swd ( n -- ) \ southward
    mh-south mh-fd ;

: mh-wwd ( n -- ) \ westward
    mh-west mh-fd ;


3 thickness !

: mh-4th ( -- )
    40 50 mh-mv-to mh-east 15 mh-fd 
    40 50 mh-mv-to mh-south 15 mh-fd  
    40 50 mh-mv-to mh-north 15 mh-fd  
    40 50 mh-mv-to mh-west 20 mh-fd mh-tr 40 mh-fd

    65 20 mh-mv-to mh-east 10 mh-fd
    65 20 mh-mv-to mh-west 10 mh-fd
    65 20 mh-mv-to mh-north 10 mh-fd
    55 mh-bd

    95 10 mh-mv-to mh-south 55 mh-fd
    95 30 mh-mv-to mh-east  25 mh-fd
    mh-tr 35 mh-fd 
    
;

: mh-test
    white mh-bg-col!
    red mh-pencolor
    mh-tg-erase
    red mh-pencolor mh-home ( north ) 30 mh-fd
    blue mh-pencolor mh-home mh-west 30 mh-fd
    yellow mh-pencolor mh-home mh-south 30 mh-fd
    green mh-pencolor mh-home mh-east 30 mh-fd
    \ window
    maroon mh-pencolor
    mh-home mh-pu
    30 mh-fd mh-tr 
    mh-pd 
    4 0 DO 30 mh-fd mh-tr 30 mh-fd LOOP
    3000 ms
    mh-tg-erase
    1 thickness !
    40 0 DO mh-tr 5 I 3 * + mh-fd LOOP
    yellow mh-pencolor
    mh-home mh-pu 1 mh-fd mh-tr 1 mh-fd mh-tl mh-pd 
    40 0 DO mh-tr 6 I 3 * + mh-fd LOOP
; 


: mh-4th-2 ( -- )
    ( blue mh-pencolor )
    mh-pd
    5 thickness !
    10 5 mh-mv-to
    mh-south 35 mh-fd mh-tl tft-width @  20 - mh-fd mh-tr 35 mh-fd
    mh-south 3 0 DO 45 35 I * + 5 mh-mv-to 70 mh-fd LOOP
;

100 Variable mh-warte

: mh-4th-demo ( -- )
    cr ." Drücke eine Taste zum Beenden!" cr
    1
    BEGIN mh-warte @ ms
        #colors mod dup color! mh-fg-col! 1 +
        mh-4th-2
        key?
    UNTIL
    drop ;


: manhattan-demo ( -- )
    color-demo
    3000 ms
    mh-test
    1000 ms
    blue mh-pencolor
    3 thickness !
    mh-4th
    2000 ms
    mh-tg-erase
    mh-4th-demo
;
