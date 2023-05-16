\   Filename: vis-traverse-wordlist-mq.fs
\    Purpose: Execute a word on all words of a given wordlist.
\   Required: Mecrisp-Quintus by Matthias Koch.
\             VIS-Extension for Mecrisp-Quintus: vis-0.8.4-mecrisp-quintus.fs
\        MCU: * , tested with Logan Nano (GD32)
\      Board: * , tested with Logan Nano
\ Recommended: e4thcom Terminal
\     Author: Manfred Mahlow          manfred.mahlow@forth-ev.de
\   Based on: -
\    Licence: GPLv3
\  Changelog: 2020-06-25 first release
\             2021-03-01 traverse-wordlist moved from forth to inside

inside also definitions  decimal

: traverse-wordlist-in-ram ( xt wid -- )
\ Traveral from the last to the first defined word in RAM.
  >r  ( xt ) ( R: wid )
  dictionarystart ( xt lfa )
  begin
    dup _sof_ <>
  while  ( xt lfa ) ( R: wid )
    \ execute xt if the word at lfa is a member of wordlist wid
    dup lfa>wtag tag>wid r@ = ( xt lfa f )
    if ( xt lfa )
       2dup 2>r swap ( lfa xt ) execute ( f ) 2r> ( f lfa xt )
       rot 0= if 2drop r> drop exit then
    then
    dictionarynext if drop _sof_ then
  repeat
  2drop r> drop
;

: traverse-wordlist-in-flash ( xt wid -- )
\ Traversal from the first to the last defined word in FLASH.
  \ A wordlist defined in RAM has no members in FLASH.
  dup addrinram? if 2drop exit then
  dup >r  ( xt wid ) ( R: wid )
  forth-wordlist = if _sof_ else r@ then
  begin ( xt lfa )
    \ execute xt if the word at lfa is a member of wordlist wid
\    dup lfa>wtag tag>wid r@ = ( xt lfa f )
    dup forth-wordlist < if forth-wordlist else dup lfa>wtag tag>wid then
    ( xt lfa wid ) r@  = ( xt lfa f )
    if ( xt lfa )
       2dup 2>r swap ( lfa xt ) execute ( f ) 2r> ( f lfa xt )
       rot 0= if 2drop r> drop exit then
    then
    dictionarynext 
  until
  2drop r> drop 
;

: traverse-wordlist ( xt wid -- )
\ xt is executed for every word that is a member of the wordlist wid. The code
\ at xt is executed with the words name token ( nt = lfa ) on top of the data
\ stack and must return a flag.
\
\ Stack effect of xt :  ( k*x nt -- l*x flag )
\
\ A false flag stops the traversal before the end of the wordlist.
\
\ Traversal goes from the last to the first defined word in RAM and continues
\ from the first to the last defined word in FLASH. In compiletoflash mode the
\ words in RAM are ignored.
\
  compiletoram? if 2dup 2>r traverse-wordlist-in-ram 2r> then
  traverse-wordlist-in-flash
;

previous

\ EOF

