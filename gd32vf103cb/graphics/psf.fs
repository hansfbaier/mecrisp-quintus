\ Convert a PSF bitmat font file to mecrisp font format
\ Redesign: Kurze pfad&file Bezeichnungen wg. Stringbeschränkung auf 255 Zeichen :-(
\ gforth
\ MB March 2020

warnings off

: .help ( -- )
    cr ." Usage: gforth psf.fs [source-path/file] [destination-path] "
    cr ."   -h, --help         shows this help "
    cr ."   -e, --exec         skips every action, jumps into gforth itself. "
\    cr ."   -v, --verbose      produces some infos "
\    cr ."  --v                 produces more infos "
    cr ." Convert a PSF2 font [source-path/file] into a mecrisp-font file."
    cr ." The PSF2 font [source-path/file] may be compressed (.gz)"
    cr ." The convertet font ist stored in the destination path."
    cr ." Usually PSF2-font files are found in /usr/share/consolefonts/"
    cr ." No guarantees are given!"
    cr
;
    
Create (source-path&file) 255 allot
Create source-file 255 allot 
Create temp-file 255 allot
Create temp-path 255 allot
Create dest-path 255 allot
Create dest-file 255 allot

Create stringbuffer 255 allot

: source-path&file ( -- addr u )
 \   source-path count stringbuffer place
 \   s" /" stringbuffer +place
 \   source-file  count stringbuffer +place
    \   stringbuffer count
    (source-path&file) count
;

: temp-path&file ( -- addr u )
    temp-path  count stringbuffer place
    s" /" stringbuffer +place
    temp-file  count stringbuffer +place
    stringbuffer count
;

: dest-path&file ( -- addr u )
    dest-path  count stringbuffer place
    s" /" stringbuffer +place
    dest-file  count stringbuffer +place
    stringbuffer count
;    

: build-filenames ( -- )
    source-path&file
    BEGIN s" /" search
    WHILE 1- swap 1+ swap
    REPEAT
    source-file place
    source-file count 7 - dest-file place
    s" .mfnt" dest-file +place
    dest-path count temp-path place
    source-file count 6 - temp-file place
    s" .tmp" temp-file +place
;

: commandline? ( -- )
    next-arg (source-path&file) place
    next-arg dest-path place s" /" dest-path +place
    source-path&file s" -h" search nip nip
    source-path&file s" --help" search nip nip or
    source-path&file nip 0= or
    dest-path count nip 0= or
    IF .help bye THEN
    source-path&file s" -e" search nip nip
    source-path&file s" --exec" search nip nip or
    IF quit THEN
    build-filenames
;

: .files
    cr  ." s-path&file: " source-path&file type
    cr  ." s-file     : " source-file count type
    cr  ." d-path&file: "  dest-path&file type
    cr  ." d-file     : " dest-file count type
    cr  ." t-path&file: " temp-path&file type
    cr  ." t-file     : " temp-file count type
;



0 Value psf


100 1024 * Value buf-len
buf-len buffer: psf-buf

$FF Value utf-8-end
$FE Value utf-8-start

: psf-open
    source-file count 3 - r/o open-file throw to psf
    psf file-size throw d>s buf-len >
    IF s" Die Psfdatei ist zu groß für den internen Puffer (100kb)."
        exception throw
    ELSE
        psf-buf
        psf file-size throw
        d>s psf read-file throw drop
    Then
    psf close-file throw
    0 to psf
;

: psf: ( addr -- n / name )
    s" psf-" pad place
    parse-name pad +place
    pad count nextname
    Create ,
  Does> @ l@ ;

psf-buf

dup psf: magic 4 +
dup psf: version 4 +
dup psf: headersize 4 +
dup psf: flags 4 +
dup psf: glyphs 4 +
dup psf: glyphsize 4 +
dup psf: glyphheight 4 +
    psf: glyphwidth


: psf-utf-8 ( -- n ) 
    psf-buf psf-headersize + psf-glyphs psf-glyphsize * +
;

: valid? ( -- f )
    psf-magic
    $864AB572 =
;

: .header ( -- )
    cr ." Die Datei " source-file count type ."  ist "
    valid?
    IF 
    ." ein gültiger PSF2-Font!"
    cr psf-version ." Version: " .
    cr ." Offset der Daten: " psf-headersize .
    cr ." Es gibt " psf-flags 1 <>
    IF ." k" THEN ." eine UTF8-Tabelle!"
    cr ." Anzahl der Zeichen: " psf-glyphs .
    cr ." Zeichenhöhe: " psf-glyphheight .
    cr ." Zeichenbreite: " psf-glyphwidth .
    cr 
    ELSE ." kein gültiger PSF2-Font!"

    THEN
;

\ Häh?? Wat isn dat?
\ gzip -dk /usr/share/consolefonts/CyrAsia-Terminus32x16.psf.gz /  >"/home/martin/Programmieren/mecrisp-quintus-0.27-experimental/gd32vf103cb/martin/src/CyrAsia-Terminus32x16.psf"
\ schreibt eine entpackte Datei _nicht_ ins angegeben Ziel,
\ sondern bleibt im Urverzeichnis und dafür muss man auch noch Superuser sein!!
\ Also: erst kopieren, dann entpacken       

: uncompress ( -- )
    source-file count
    s" gz" search 
    swap 2 = and nip
    IF  s" cp "             stringbuffer place 
        source-path&file    stringbuffer +place
        s"  "               stringbuffer +place \ mit Platz für gzip-String
\       dest-path count     stringbuffer +place
        source-file count   stringbuffer +place
        stringbuffer count  system
        s" gzip -d  "       stringbuffer place
\       dest-path count     stringbuffer +place
        source-file count   stringbuffer +place
        stringbuffer count  system
    THEN
;


: show-glyph-dots ( b n -- )
    dup 0=
    IF
        drop
    ELSE
        0 DO \ 2 /mod swap
            dup %10000000 and 
            IF ." *" ELSE ."  " THEN
            2* 
    LOOP
    drop
    THEN
;

: show-glyph-byte ( b -- )
     8 show-glyph-dots
;


: show-glyph-row ( addr -- addr' )
    psf-glyphwidth 8 /mod swap -rot 
    0 ?DO count show-glyph-byte
    LOOP
    over
    IF    count rot show-glyph-dots
    ELSE  nip 
    THEN
;

: glyphaddr ( n -- addr )
    psf-glyphsize *
    psf-headersize +
    psf-buf +
;

: show-glyph ( n -- )
    glyphaddr
    psf-glyphheight
    0 ?DO
        cr show-glyph-row 
    LOOP
    drop
;

: pos>utf ( n -- addr count ) 
    psf-utf-8
    swap 0
    ?DO
        BEGIN
            count $ff =
        UNTIL
    LOOP
    dup
        BEGIN
            count $ff =
        UNTIL
        over - 1- 
;

0 Variable unicode

: utf-8-bytes>unicode ( addr -- n )
    0 unicode !
    dup c@  
    5 rshift
    case
        7 of \ dup c@ hex. ."  3 "
            count %1111 and 12 lshift unicode +!
            count %111111 and 6 lshift unicode +!
            c@  %111111 and unicode +!
        endof
        1 rshift 
        3 of \ dup c@ hex. ."  2 "
            count %11111 and 6 lshift unicode +!
            c@ %111111 and unicode +!
        endof
        1 rshift
        0 of \ dup c@ hex. ."  1 "
            c@ unicode +!
        endof
        drop
    endcase
;



: alles ( -- )
    psf-glyphs 0
    DO decimal I  .
        I pos>utf 2dup
        hex
        0 DO count 2 .r space LOOP drop 
        space ~~ 
        \       0 DO dup 2 type bl 2 + LOOP drop ~~
        type
        I pos>utf drop utf-8-bytes>unicode
        I show-glyph
        key drop 
    LOOP
;

: unicode-entries ( -- )
    psf-glyphs 0
    DO cr I .
        I pos>utf drop
        utf-8-bytes>unicode
        base @ hex
        unicode @  s>d <# # # # # #> type
        base !
    LOOP
;

: swap-bytes ( n -- n )
    $100 /mod swap $100 * +
;

\ Mist! e4thcom kann nicht mit Zeilen länger als 80? umgehen
\ Das können wir hier wg dem anschlließenden sort nicht berücksichtigen
\ Das darf erst nach sort s.u. geschehen. Sch....ade!

: mecrisp-font ( -- )
    base @ hex  
    psf-glyphs 0
    DO  cr \ [char] . (emit)
        I pos>utf drop utf-8-bytes>unicode
        unicode @  s>d <# # # # # #> type ."  h, "
        I glyphaddr psf-glyphsize 2/ 0
        DO dup
            w@ \ swap-bytes
            s>d <# # # # # #> type ."  h, "
            2 +
        LOOP drop
    LOOP
    base ! 
;

: (ftype) ( addr c -- )
\    2dup (type)
    psf IF psf write-file drop THEN ; 

: (femit) ( c -- ) 
\    dup (emit)
    psf IF psf emit-file drop THEN ;


: new-output ( -- )
    ['] (ftype) [is] type
    ['] (femit) [is] emit
;

: restore-output ( -- )
    ['] (type) [is] type
    ['] (emit) [is] emit
;    

: .str stringbuffer count cr dup . cr type ;

: write-font ( -- )
    s" temp.mfnt" r/w create-file throw to psf
    0.0 psf reposition-file throw
     mecrisp-font cr
    psf close-file throw
;

: sort-font ( -- )
    s" sort temp.mfnt > temp1.mfnt" system
    s" temp1.mfnt" r/w open-file throw to psf
    psf file-size throw psf reposition-file throw 
    s" grep 2666 temp.mfnt " sh-get
    over $30303030 swap l! type
    psf close-file throw
    s" temp.mfnt" delete-file throw
\    s" temp1.fnt" dest-file count rename-file throw close-file
;

: tidy-up-filenames ( -- )
    \    s" temp1.mfnt" dest-file count rename-file throw
    s" fold -s temp1.mfnt >" psf-buf place
    dest-file count psf-buf +place
    psf-buf count system
    s" mv " psf-buf place
    dest-file count psf-buf +place
    s"  " psf-buf +place
    dest-path count psf-buf +place
    psf-buf count system
    source-file count 3 - delete-file throw 
;


: convert-font ( -- )
    new-output
    write-font
    sort-font
    restore-output
    tidy-up-filenames
;


: main ( -- )
    commandline?
\    .files
    uncompress
    psf-open
    .header
    valid?
    IF convert-font
    ELSE source-file count 3 - delete-file throw
    THEN
    bye
;

 main

\   commandline?
\     gz?
\     psf-open
\ .header
