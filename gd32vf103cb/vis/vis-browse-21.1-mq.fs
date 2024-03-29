\     Filename: vis-bowse-21.1-mq.fs
\     Purpose: A dictionary browser to show VOCabularies in a non-tabular 
\              stile. Adds the words  ?? ( -- ) S,I  and  browse ( -- ) S 
\              to the root VOCabulary. 
\    Required: Mecrisp-Quintus >= 0.27
\              vis-x.y.z-mecrisp-quintus.fs  >= 0.8.4
\         MCU: * , tested with Logan Nano (GD32)
\       Board: * , tested with Logan Nano
\ Recommended: e4thcom Terminal (1)
\      Author: manfred.mahlow@forth-ev.de
\    Based on: -
\     Licence: GPLv3
\   Changelog: 2020-06-25 first release
\              2021-03-01 recasted
\              2021-03-17 #ifndef traverse-wordlist added
\
\ (1) The e4thcom Terminal allows to upload files conditionally ( only once )
\     with #require <filename> and unconditionally with #include <filename>.
\
\     To load this file with e4thcom it's recommended to use the command
\     #r[equire] browse . This conditionally loads this and all other required
\     files and displays a Glossary of the added words. 
\
\     If you do not or can not use e4thcom, comment out the e4thcom directives
\     and then load the required files manually.

inside
#ifndef traverse-wordlist  #include vis-traverse-wordlist-mq.fs
inside
#ifndef wordlist-in-flash  #include vis-wordlist-in-flash-mq.fs
inside
#ifndef wordlist-in-ram    #include vis-wordlist-in-ram-mqs.fs

inside definitions  decimal

: \sw+ ( u1 lfa -- u2 true (
  inside smudged? if 1+ then true
;
 
: words-in-ram ( wid -- u )
  inside also
  0 swap ['] \sw+ swap traverse-wordlist-in-ram
  previous
;  

: words-in-flash ( wid -- u )
  inside also
  0 swap ['] \sw+ swap traverse-wordlist-in-flash
  previous
;

: .base ( -- ) base @ dup decimal u. base ! ;

root definitions

  sticky
: browse ( -- )
\ Display all words of the top entry of the active search order. Do not change 
\ the search order.
  inside also
  _sop_ @ @ ( wid ) 
  begin
    cr dup .vid ." : " 
    compiletoram?
    if
      dup words-in-RAM if dup wordlist-in-ram words space then
    then
    dup words-in-flash dup compiletoram? 0= or 
    if
      drop ."  [FLASH]>  " dup wordlist-in-flash words
    else
      drop
    then
    cr
    vocnext dup
  while
    80 dashes
  repeat drop
  previous
;

  sticky
: ?? ( -- )
\ A dictionary browser that displays the system status and all words of the
\ top entry of the active search order. It's a STICKY word. It does not change
\ the search order, so that one can take a look into a VOCabulary to find and
\ execute a word.
  cr order ."    Base: " inside .base cr .s browse .. immediate
;

forth definitions

\ EOF

