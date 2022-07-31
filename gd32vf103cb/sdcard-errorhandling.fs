\   Filename: vis-sdcard.fs
\    Purpose: access sdcard via spi1 bit banging
\        MCU: GD32VF103
\      Board: * , tested with Logan Nano
\       Core: Mecrisp-Quintus 0.27 by Matthias Koch.
\   Required: Mecrisp-Quintus >= 0.27
\     Author: Matthias Koch
\      Date : Jun 2020
\   Requiers: registernames.fs
\ Literature: https://www.convict.lu/pdf/ProdManualSDCardv1.9.pdf
\    Licence: GPLv3
\  Changelog:
\ 2020-06-xx:  MaBi001 prepared VIS
\ 2020-07-31:  MaBi002 added "noanswer?"
\ 2020-08-01:  MaBi003 added sd-error?
\ 2020-08-01:  MaBi004 corrected typo in sd-erase
\ 2020-08-02:  MaBi005 reworked sd-error? to handle multiple errors

\ -------------------------------------------------------------
\   Leitungen für die SPI-Schnittstelle definieren
\ -------------------------------------------------------------


1 12 lshift constant CS_TF  \ GD_PB12
1 13 lshift constant SCLK   \ GD_PB13
1 14 lshift constant MISO   \ GD_PB14
1 15 lshift constant MOSI   \ GD_PB15

: miso@ ( -- 0|1) GPIOB_ISTAT @  MISO and 14 rshift ;

: sclk-high    SCLK  GPIOB_BOP h! ;
: sclk-low     SCLK  GPIOB_BC  h! ;

: mosi-high    MOSI  GPIOB_BOP h! ;
: mosi-low     MOSI  GPIOB_BC  h! ;

: -spi1 ( -- )  CS_TF GPIOB_BOP h! ; \ deselect SPI
: +spi1 ( -- )  CS_TF GPIOB_BC  h! ; \ select SPI

: spi-init ( -- )
  $14114444 GPIOB_CTL1 !  \ Set PB12, PB13 and PB15 as output, PB14 as input.
   -spi1  sclk-low  mosi-high \ Fürs Reset benötigter Ruhezustand: /CS and DI=MOSI high, Clock low.
;

\ -------------------------------------------------------------
\   Leitungen prüfen
\ -------------------------------------------------------------

\ : b-sclk spi-init begin sclk-high 1000000 0 do loop sclk-low 1000000 0 do loop key? until ;
\ : b-mosi spi-init begin mosi-high 1000000 0 do loop mosi-low 1000000 0 do loop key? until ;
\ : b-cs   spi-init begin -spi      1000000 0 do loop +spi     1000000 0 do loop key? until ;
\ : s-miso spi-init begin miso hex. cr key? until ;

\ -------------------------------------------------------------
\   Kommunikation über die SPI-Leitungen
\ -------------------------------------------------------------

: >spi> ( c -- c )  \ bit-banged SPI, 8 bits
  8 0 do
    dup $80 and if  mosi-high else  mosi-low then
     sclk-high
    2*  miso@ or
     sclk-low
  loop

  $FF and ;

\ Single byte transfers

: spi> ( -- c ) $FF   >spi> ;  \ read byte from SPI
: >spi ( c -- )  >spi> drop ;  \ write byte to SPI

\ -------------------------------------------------------------
\   Kommunikation mit der SD-Karte
\ -------------------------------------------------------------


0 variable crc
0 Variable answer#  \ MaBi002

: noanswer? ( -- flag )  \ MaBi002
  answer# @ 10 >
  1 answer# +!
;


: sd-error? ( f -- f ) \ MaBi005
  dup 7 rshift 0 =
  over 0 <>
  and
  IF
    dup 1 and 1 = IF cr ." Card is idle!" THEN
    dup 2 and 2 = IF cr ." Erase command beyond border!" THEN
    dup 4 and 4 = IF cr ." Illegal command!" THEN
    dup 8 and 8 = IF cr ." CRC Error!" THEN
    dup 16 and 16 = IF cr ." Wrong sequence of erase commands!" THEN
    dup 32 and 32 = IF cr ." Misaligned address!" THEN
    dup 64 and 64 = IF cr ." Wrong parameter (blocknumber?)!" THEN
    quit
  THEN
;

: (sd-cmd) ( arg cmd -- u )
  2 us
   +spi1
            $FF  >spi
         $40 or  >spi \ Command
  dup 24 rshift  >spi \ Argument, 32 Bits, 31-24
  dup 16 rshift  >spi \ 23-16
  dup  8 rshift  >spi \ 15-8
                 >spi \ 7-0
          crc @  >spi \ CRC-Feld, welches bei SPI-Schnittstelle nur für den ersten Befehl gebraucht und sonst ignoriert wird.

  0 answer# ! \ MaBi002
  begin $FF   \ Auf die Antwort von der SD-Karte warten
    noanswer?   \ MaBi002
    IF  ." No answer from SPI! Is there a card inserted?" quit THEN \ MaBi002
     >spi> dup ( error? ) $80 and
  while drop
  repeat
;



: sd-cmd ( arg cmd -- u ) (sd-cmd)  -spi1 ;

512 buffer: sd.buf

: sd-copy ( f n -- )
  swap
  begin
    sd-error? \ MaBi003
    $FE <>
  while $FF  >spi> \ dup .
  repeat
  0 do
    $FF  >spi> sd.buf i + c!
  loop
  $FF dup  >spi  >spi
;

: sd-cmd-r3-r7 ( arg cmd -- u response )
  (sd-cmd)

   spi>    8 lshift
   spi> or 8 lshift
   spi> or 8 lshift
   spi> or

   -spi1
;

: sd-cmd-r2 ( arg cmd -- u ) \ 17-Bytes lange Antwort, die ersten 16 davon im Puffer zuückgeben.
  (sd-cmd)
  16 sd-copy
   -spi1
;

\ -------------------------------------------------------------
\   Größe der Karte bestimmen
\ -------------------------------------------------------------

0 variable #sd-blocks

: read-sd-size ( -- )  \ Return card size in 512-byte blocks

  0 9 sd-cmd-r2 \ Send CSD

  sd.buf 7 + c@    8 lshift
  sd.buf 8 + c@ or 8 lshift
  sd.buf 9 + c@ or
  1+ 10 lshift

  #sd-blocks ! \ Zahl der Blöcke speichern
;

: sd-size ( -- u ) #sd-blocks @ ;

\ -------------------------------------------------------------
\   Initialisierung
\ -------------------------------------------------------------

: sd-init ( -- )  \ Initialize card, show messages
   spi-init
  100 ms

  10 0 do $FF  >spi loop \ Mindestens 74 Taktpulse mit /CS high

  begin
    $95 crc ! 0 0 sd-cmd  \ CMD0 go idle
  $01 = until

  1 crc !
  0 59 sd-cmd drop \ CRC off

  ." SD-Card type: "
  $87 crc ! $1AA 8 sd-cmd-r3-r7 hex. dup hex. 1 =

  if \ Ver 2.00 or later SD Memory Card

    begin
              0 55 sd-cmd drop \ Es folgt einer der ACMD-Kommandos
      $40000000 41 sd-cmd       \ ACMD41, mit HCS=1, da wir hier hohe Kapazitäten unterstützen
    0= until

    0 58 sd-cmd-r3-r7 ." OCR: " hex. hex. \ Read OCR register. Das ist ein R3-Antworttyp, aber die haben die gleiche Länge.

    512 16 sd-cmd ?dup if ." Wrong block size: " hex. then \ Blockgröße auf 512 Bytes setzen

    read-sd-size

  else
    ." Ver 1.X SD Memory Card or not SD Memory Card" cr
    exit
  then

  ." with " sd-size hex.
  ." blocks or " sd-size 2/ 1024 / .
  ." MB initialised." cr
;



: sd-init-silent ( -- )  \ Same as sd-init but silent mode (no messages)
   spi-init
  100 ms

  10 0 do $FF  >spi loop \ Mindestens 74 Taktpulse mit /CS high

  begin
    $95 crc ! 0 0 sd-cmd  \ CMD0 go idle
  $01 = until

  1 crc !
  0 59 sd-cmd drop \ CRC off

  $86 crc ! $1AA 8 sd-cmd-r3-r7 drop 1 =

  if \ Ver 2.00 or later Memory Card

    begin
              0 55 sd-cmd drop \ Es folgt einer der ACMD-Kommandos
      $40000000 41 sd-cmd       \ ACMD41, mit HCS=1, da wir hier hohe Kapazitäten unterstützen
    0= until

    0 58 sd-cmd-r3-r7 drop drop \ Read OCR register. Das ist ein R3-Antworttyp, aber die haben die gleiche Länge.

    512 16 sd-cmd ?dup if ( error: wrong block size ) drop then \ Blockgröße auf 512 Bytes setzen

    read-sd-size

  else
    ( error: Ver 1.X Memory Card or not an Memory Card )
    exit
  then

  ( no error. card is initialized )
;

\ -------------------------------------------------------------
\   Identifikation anzeigen
\ -------------------------------------------------------------

: show-sd-size ( -- )
  0 9 sd-cmd-r2 \ Send CSD
  sd.buf 16 dump
;

: show-sd-id ( -- )
  0 10 sd-cmd-r2 \ Send CID
  sd.buf 16 dump
;

\ -------------------------------------------------------------
\   Block lesen und schreiben
\ -------------------------------------------------------------

: sd-read ( block -- ) \ Einen 512-Byte-Block von der SD-Karte lesen
  17 (sd-cmd) \ Single block read
  512 sd-copy
   -spi1
;

: sd-write ( block -- ) \ Einen 512-Byte-Block auf die SD-Karte schreiben
  24 (sd-cmd) \ Single block write
  sd-error?      \ Mabi003
  $FE  >spi   \ DATA_START_BLOCK

  512 0 do
    sd.buf i + c@  >spi
  loop

   spi> drop  spi> drop \ ." CRC " spi> 8 lshift spi> or hex. \ Data response
  begin  spi> $FF = until \ Warte, bis Busy-Flag verschwindet
   -spi1
;

\ -------------------------------------------------------------
\   Alles löschen
\ -------------------------------------------------------------

: sd-erase ( -- )
           0 32  sd-cmd  sd-error? hex. \ Startblock fürs Löschen
  sd-size 1- 33  sd-cmd  sd-error? hex. \   Endblock MaBi004

        0 38 (sd-cmd) sd-error? hex. \ Löschen ausführen
  begin  spi> $FF = until \ Warte, bis Busy-Flag verschwindet
   -spi1
;

\ -------------------------------------------------------------
\   Ausprobieren
\ -------------------------------------------------------------

: db ( -- ) sd.buf 512 dump ;  \ Dump sector buffer to screen

: view ( u -- ) sd-read db ;  \ Read sector u and dump to screen

: sector-empty? ( -- flag )  \ Test if sector is completely filled with zeros
  true  \ assume that sector is empty
  512 0
  do
    sd.buf i +
    @ 0<>
    if
      drop false leave  \ sector is not empty
    then
  4
  +loop
;

: n-view ( limit-sector start-sector -- )
         \ Prints content of a number of sectors that are not empty.
         \ If empty, only the sector number is printed.
         \ Example: 9000 8192 n-view
         \ Reads in sectors 8192-8999 and shows content or sectornumber only.
  cr
  do
    i sd-read
    sector-empty?
    if
      i .
    else
      cr i .  i view cr
    then
  loop
;

: pattern1 ( -- )
  512 0 do i i sd.buf + c! loop
;

: pattern2 ( -- )
  512 0 do i 1 rshift i sd.buf + c! loop
;

\ sd-init      \ Muss als erstes aufgerufen werden
\ 10 0 n-view  \ Die ersten 10 Sektoren lesen und wenn nicht leer, dann anzeigen
