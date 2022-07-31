\ turtle.fs
\ Part of pixelmaler-v0.1 for Mecrisp-Quintus - A native code Forth implementation for RISC-V
\ Copyright (C) 2018  Matthias Koch
\ display longan nano
\ MB March 2020

\ simple turtle graphics
\ It uses the fixpoint math from
\ common/fixpt-math-lib.fs
\ including some triogonemetry especially sin cos.
\ Calculating the position of the turtle with fixpoint math has
\ the great advantage to avoid rounding faults.

0. 2Variable t-sin
0. 2Variable t-cos
0. 2Variable t-x
0. 2Variable t-y

0 Variable t-orientation 

0 Variable pen 
0 Variable t-fg-col
0 Variable t-bg-col

: .t-param ( -- )
    cr ."         sin: " t-sin 2@ f.
    cr ."           x: " t-x 2@ f.
    cr ."         cos: " t-cos 2@ f.
    cr ."           y: " t-y 2@ f.
    cr ." orientation: " t-orientation @ .
;

: pencolor ( -- )
    color @ t-fg-col !
;

: groundcolor ( -- )
    color @ t-bg-col !
;


: pu ( -- )
    false pen !
;

: pd ( -- )
    true pen !
;

: mv-to ( x y -- )
    pen @
    IF
        t-x @ t-y @
        2over
        line
    THEN
    0 swap t-y 2!
    0 swap t-x 2!
;

: erase ( -- )
    t-bg-col @
    color !
; 

: home \ home
    0 t-orientation !
    0,0 t-sin 2!
    1,0 t-cos 2!
    0 tft-width @  2/ t-x 2!
    0 tft-height @ 2/ t-y 2! ;

: t-page ( -- )
    t-bg-col @ color !
    tft-clear
    t-fg-col @ color !
    home
;


: turn ( n -- ) \ signed hundredth of degrees i.e. 45° --> 4500
    t-orientation @ + 36000 mod dup t-orientation !
    0 swap \ single to s31.32
    2dup
    100,0 f/ sin t-sin 2!
    100,0 f/ cos t-cos 2!
;

: tl ( n -- ) \ turn left
    turn
;
: tr ( n -- ) \ turn right
    negate turn
;




: fd-y ( n -- y0 y1 )
    t-y @              \ lenght old-x(int)
    0 rot              \ old-x(int) f,length
    t-cos 2@ f*        \ old-x(int) f,cos*length
    t-y 2@ d+ dup >r   \ 
    t-y 2!
    r> ;

: fd-x ( n -- x0 x1 )
    t-x @
    0 rot
    t-sin 2@ f*
    t-x 2@  d+ dup >r
    t-x 2!
    r> ;
    
: fd ( n -- )
    dup fd-x
    rot fd-y
    rot swap
    pen @
    IF
        line
    ELSE
        2dup 2dup
    THEN
;

: backward ( n -- )
    18000 turn
    fd
    18000 turn
; 

: spiral ( n -- ) \ degrees 
    home
    360 over / 0
    DO
        dup 100 * turn
        4 0 DO 9000 turn 30 fd LOOP
    LOOP
    drop
;

: turtle-demo ( -- )
    white groundcolor
    blue pencolor
    t-page pd
    10 spiral
;
