\    Filename: vis-wordlist-in-ram-mqs.fs
\     Purpose: Display all RAM words of a given wordlist.
\    Required: Mecrisp-Stellaris RA 2.3.8 or later by Matthias Koch.
\              vis-0.8.4-mecrisp-stellaris.fs      by Manfred Mahlow
\          or: Mecrisp-Quintus >= 0.27
\              vis-x.y.z-mecrisp-quintus.fs  >= 0.8.4
\         MCU: * , tested with Logan Nano (GD32)
\       Board: * , tested with Logan Nano
\ Recommended: e4thcom Terminal (1)
\      Author: manfred.mahlow@forth-ev.de
\    Based on: -
\     Licence: GPLv3
\   Changelog: 2021-03-01

inside
#ifndef traverse-wordlist  #include vis-traverse-wordlist-mq.fs

inside definitions  decimal

voc wordlist-in-ram  @voc wordlist-in-ram definitions

: \?id ( lfa -- tf )
  inside also
  dup smudged? if space .id else drop then true 
  previous
;

: words ( wid )
\ Display all RAM words of the wordlist wid.
  inside also
  @voc ['] \?id swap ( xt wid ) traverse-wordlist-in-ram
  previous
;

forth definitions

\ EOF

