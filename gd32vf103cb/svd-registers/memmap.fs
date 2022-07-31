\ TEMPLATE FILE for GD32VF103
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence
\ Available forth template words as selected by config.xm 

compiletoflash
: WRITEONLY ( -- ) ." WO" cr ;
		
$40012400 constant ADC0 \ Analog to digital converter
ADC0 $0 + constant ADC0_STAT ( read-write )  \ status register
ADC0 $04 + constant ADC0_CTL0 ( read-write )  \ control register 0
ADC0 $08 + constant ADC0_CTL1 ( read-write )  \ control register 1
ADC0 $0C + constant ADC0_SAMPT0 ( read-write )  \ Sample time register 0
ADC0 $10 + constant ADC0_SAMPT1 ( read-write )  \ Sample time register 1
ADC0 $14 + constant ADC0_IOFF0 ( read-write )  \ Inserted channel data offset register  0
ADC0 $18 + constant ADC0_IOFF1 ( read-write )  \ Inserted channel data offset register  1
ADC0 $1C + constant ADC0_IOFF2 ( read-write )  \ Inserted channel data offset register  2
ADC0 $20 + constant ADC0_IOFF3 ( read-write )  \ Inserted channel data offset register  3
ADC0 $24 + constant ADC0_WDHT ( read-write )  \ watchdog higher threshold  register
ADC0 $28 + constant ADC0_WDLT ( read-write )  \ watchdog lower threshold  register
ADC0 $2C + constant ADC0_RSQ0 ( read-write )  \ regular sequence register 0
ADC0 $30 + constant ADC0_RSQ1 ( read-write )  \ regular sequence register 1
ADC0 $34 + constant ADC0_RSQ2 ( read-write )  \ regular sequence register 2
ADC0 $38 + constant ADC0_ISQ ( read-write )  \ Inserted sequence register
ADC0 $3C + constant ADC0_IDATA0 ( read-only )  \ Inserted data register 0
ADC0 $40 + constant ADC0_IDATA1 ( read-only )  \ Inserted data register 1
ADC0 $44 + constant ADC0_IDATA2 ( read-only )  \ Inserted data register 2
ADC0 $48 + constant ADC0_IDATA3 ( read-only )  \ Inserted data register 3
ADC0 $4C + constant ADC0_RDATA ( read-only )  \ regular data register
ADC0 $80 + constant ADC0_OVSAMPCTL ( read-write )  \ Oversample control register
: ADC0_STAT. cr ." ADC0_STAT.  RW   $" ADC0_STAT @ hex. ADC0_STAT 1b. ;
: ADC0_CTL0. cr ." ADC0_CTL0.  RW   $" ADC0_CTL0 @ hex. ADC0_CTL0 1b. ;
: ADC0_CTL1. cr ." ADC0_CTL1.  RW   $" ADC0_CTL1 @ hex. ADC0_CTL1 1b. ;
: ADC0_SAMPT0. cr ." ADC0_SAMPT0.  RW   $" ADC0_SAMPT0 @ hex. ADC0_SAMPT0 1b. ;
: ADC0_SAMPT1. cr ." ADC0_SAMPT1.  RW   $" ADC0_SAMPT1 @ hex. ADC0_SAMPT1 1b. ;
: ADC0_IOFF0. cr ." ADC0_IOFF0.  RW   $" ADC0_IOFF0 @ hex. ADC0_IOFF0 1b. ;
: ADC0_IOFF1. cr ." ADC0_IOFF1.  RW   $" ADC0_IOFF1 @ hex. ADC0_IOFF1 1b. ;
: ADC0_IOFF2. cr ." ADC0_IOFF2.  RW   $" ADC0_IOFF2 @ hex. ADC0_IOFF2 1b. ;
: ADC0_IOFF3. cr ." ADC0_IOFF3.  RW   $" ADC0_IOFF3 @ hex. ADC0_IOFF3 1b. ;
: ADC0_WDHT. cr ." ADC0_WDHT.  RW   $" ADC0_WDHT @ hex. ADC0_WDHT 1b. ;
: ADC0_WDLT. cr ." ADC0_WDLT.  RW   $" ADC0_WDLT @ hex. ADC0_WDLT 1b. ;
: ADC0_RSQ0. cr ." ADC0_RSQ0.  RW   $" ADC0_RSQ0 @ hex. ADC0_RSQ0 1b. ;
: ADC0_RSQ1. cr ." ADC0_RSQ1.  RW   $" ADC0_RSQ1 @ hex. ADC0_RSQ1 1b. ;
: ADC0_RSQ2. cr ." ADC0_RSQ2.  RW   $" ADC0_RSQ2 @ hex. ADC0_RSQ2 1b. ;
: ADC0_ISQ. cr ." ADC0_ISQ.  RW   $" ADC0_ISQ @ hex. ADC0_ISQ 1b. ;
: ADC0_IDATA0. cr ." ADC0_IDATA0.  RO   $" ADC0_IDATA0 @ hex. ADC0_IDATA0 1b. ;
: ADC0_IDATA1. cr ." ADC0_IDATA1.  RO   $" ADC0_IDATA1 @ hex. ADC0_IDATA1 1b. ;
: ADC0_IDATA2. cr ." ADC0_IDATA2.  RO   $" ADC0_IDATA2 @ hex. ADC0_IDATA2 1b. ;
: ADC0_IDATA3. cr ." ADC0_IDATA3.  RO   $" ADC0_IDATA3 @ hex. ADC0_IDATA3 1b. ;
: ADC0_RDATA. cr ." ADC0_RDATA.  RO   $" ADC0_RDATA @ hex. ADC0_RDATA 1b. ;
: ADC0_OVSAMPCTL. cr ." ADC0_OVSAMPCTL.  RW   $" ADC0_OVSAMPCTL @ hex. ADC0_OVSAMPCTL 1b. ;
: ADC0.
ADC0_STAT.
ADC0_CTL0.
ADC0_CTL1.
ADC0_SAMPT0.
ADC0_SAMPT1.
ADC0_IOFF0.
ADC0_IOFF1.
ADC0_IOFF2.
ADC0_IOFF3.
ADC0_WDHT.
ADC0_WDLT.
ADC0_RSQ0.
ADC0_RSQ1.
ADC0_RSQ2.
ADC0_ISQ.
ADC0_IDATA0.
ADC0_IDATA1.
ADC0_IDATA2.
ADC0_IDATA3.
ADC0_RDATA.
ADC0_OVSAMPCTL.
;

$40012800 constant ADC1 \ Analog to digital converter
ADC1 $0 + constant ADC1_STAT ( read-write )  \ status register
ADC1 $4 + constant ADC1_CTL0 ( read-write )  \ control register 0
ADC1 $08 + constant ADC1_CTL1 ( read-write )  \ control register 1
ADC1 $0C + constant ADC1_SAMPT0 ( read-write )  \ Sample time register 0
ADC1 $10 + constant ADC1_SAMPT1 ( read-write )  \ Sample time register 1
ADC1 $14 + constant ADC1_IOFF0 ( read-write )  \ Inserted channel data offset register  0
ADC1 $18 + constant ADC1_IOFF1 ( read-write )  \ Inserted channel data offset register  1
ADC1 $1C + constant ADC1_IOFF2 ( read-write )  \ Inserted channel data offset register  2
ADC1 $20 + constant ADC1_IOFF3 ( read-write )  \ Inserted channel data offset register  3
ADC1 $24 + constant ADC1_WDHT ( read-write )  \ watchdog higher threshold  register
ADC1 $28 + constant ADC1_WDLT ( read-write )  \ watchdog lower threshold  register
ADC1 $2C + constant ADC1_RSQ0 ( read-write )  \ regular sequence register 0
ADC1 $30 + constant ADC1_RSQ1 ( read-write )  \ regular sequence register 1
ADC1 $34 + constant ADC1_RSQ2 ( read-write )  \ regular sequence register 2
ADC1 $38 + constant ADC1_ISQ ( read-write )  \ Inserted sequence register
ADC1 $3C + constant ADC1_IDATA0 ( read-only )  \ Inserted data register 0
ADC1 $40 + constant ADC1_IDATA1 ( read-only )  \ Inserted data register 1
ADC1 $44 + constant ADC1_IDATA2 ( read-only )  \ Inserted data register 2
ADC1 $48 + constant ADC1_IDATA3 ( read-only )  \ Inserted data register 3
ADC1 $4C + constant ADC1_RDATA ( read-only )  \ regular data register
: ADC1_STAT. cr ." ADC1_STAT.  RW   $" ADC1_STAT @ hex. ADC1_STAT 1b. ;
: ADC1_CTL0. cr ." ADC1_CTL0.  RW   $" ADC1_CTL0 @ hex. ADC1_CTL0 1b. ;
: ADC1_CTL1. cr ." ADC1_CTL1.  RW   $" ADC1_CTL1 @ hex. ADC1_CTL1 1b. ;
: ADC1_SAMPT0. cr ." ADC1_SAMPT0.  RW   $" ADC1_SAMPT0 @ hex. ADC1_SAMPT0 1b. ;
: ADC1_SAMPT1. cr ." ADC1_SAMPT1.  RW   $" ADC1_SAMPT1 @ hex. ADC1_SAMPT1 1b. ;
: ADC1_IOFF0. cr ." ADC1_IOFF0.  RW   $" ADC1_IOFF0 @ hex. ADC1_IOFF0 1b. ;
: ADC1_IOFF1. cr ." ADC1_IOFF1.  RW   $" ADC1_IOFF1 @ hex. ADC1_IOFF1 1b. ;
: ADC1_IOFF2. cr ." ADC1_IOFF2.  RW   $" ADC1_IOFF2 @ hex. ADC1_IOFF2 1b. ;
: ADC1_IOFF3. cr ." ADC1_IOFF3.  RW   $" ADC1_IOFF3 @ hex. ADC1_IOFF3 1b. ;
: ADC1_WDHT. cr ." ADC1_WDHT.  RW   $" ADC1_WDHT @ hex. ADC1_WDHT 1b. ;
: ADC1_WDLT. cr ." ADC1_WDLT.  RW   $" ADC1_WDLT @ hex. ADC1_WDLT 1b. ;
: ADC1_RSQ0. cr ." ADC1_RSQ0.  RW   $" ADC1_RSQ0 @ hex. ADC1_RSQ0 1b. ;
: ADC1_RSQ1. cr ." ADC1_RSQ1.  RW   $" ADC1_RSQ1 @ hex. ADC1_RSQ1 1b. ;
: ADC1_RSQ2. cr ." ADC1_RSQ2.  RW   $" ADC1_RSQ2 @ hex. ADC1_RSQ2 1b. ;
: ADC1_ISQ. cr ." ADC1_ISQ.  RW   $" ADC1_ISQ @ hex. ADC1_ISQ 1b. ;
: ADC1_IDATA0. cr ." ADC1_IDATA0.  RO   $" ADC1_IDATA0 @ hex. ADC1_IDATA0 1b. ;
: ADC1_IDATA1. cr ." ADC1_IDATA1.  RO   $" ADC1_IDATA1 @ hex. ADC1_IDATA1 1b. ;
: ADC1_IDATA2. cr ." ADC1_IDATA2.  RO   $" ADC1_IDATA2 @ hex. ADC1_IDATA2 1b. ;
: ADC1_IDATA3. cr ." ADC1_IDATA3.  RO   $" ADC1_IDATA3 @ hex. ADC1_IDATA3 1b. ;
: ADC1_RDATA. cr ." ADC1_RDATA.  RO   $" ADC1_RDATA @ hex. ADC1_RDATA 1b. ;
: ADC1.
ADC1_STAT.
ADC1_CTL0.
ADC1_CTL1.
ADC1_SAMPT0.
ADC1_SAMPT1.
ADC1_IOFF0.
ADC1_IOFF1.
ADC1_IOFF2.
ADC1_IOFF3.
ADC1_WDHT.
ADC1_WDLT.
ADC1_RSQ0.
ADC1_RSQ1.
ADC1_RSQ2.
ADC1_ISQ.
ADC1_IDATA0.
ADC1_IDATA1.
ADC1_IDATA2.
ADC1_IDATA3.
ADC1_RDATA.
;

$40010000 constant AFIO \ Alternate-function I/Os
AFIO $0 + constant AFIO_EC ( read-write )  \ Event control register
AFIO $04 + constant AFIO_PCF0 ( read-write )  \ AFIO port configuration register 0
AFIO $08 + constant AFIO_EXTISS0 ( read-write )  \ EXTI sources selection register 0
AFIO $0C + constant AFIO_EXTISS1 ( read-write )  \ EXTI sources selection register 1
AFIO $10 + constant AFIO_EXTISS2 ( read-write )  \ EXTI sources selection register 2
AFIO $14 + constant AFIO_EXTISS3 ( read-write )  \ EXTI sources selection register 3
AFIO $1C + constant AFIO_PCF1 ( read-write )  \ AFIO port configuration register 1
: AFIO_EC. cr ." AFIO_EC.  RW   $" AFIO_EC @ hex. AFIO_EC 1b. ;
: AFIO_PCF0. cr ." AFIO_PCF0.  RW   $" AFIO_PCF0 @ hex. AFIO_PCF0 1b. ;
: AFIO_EXTISS0. cr ." AFIO_EXTISS0.  RW   $" AFIO_EXTISS0 @ hex. AFIO_EXTISS0 1b. ;
: AFIO_EXTISS1. cr ." AFIO_EXTISS1.  RW   $" AFIO_EXTISS1 @ hex. AFIO_EXTISS1 1b. ;
: AFIO_EXTISS2. cr ." AFIO_EXTISS2.  RW   $" AFIO_EXTISS2 @ hex. AFIO_EXTISS2 1b. ;
: AFIO_EXTISS3. cr ." AFIO_EXTISS3.  RW   $" AFIO_EXTISS3 @ hex. AFIO_EXTISS3 1b. ;
: AFIO_PCF1. cr ." AFIO_PCF1.  RW   $" AFIO_PCF1 @ hex. AFIO_PCF1 1b. ;
: AFIO.
AFIO_EC.
AFIO_PCF0.
AFIO_EXTISS0.
AFIO_EXTISS1.
AFIO_EXTISS2.
AFIO_EXTISS3.
AFIO_PCF1.
;

$40006C00 constant BKP \ Backup registers
BKP $4 + constant BKP_DATA0 ( read-write )  \ Backup data register 0
BKP $8 + constant BKP_DATA1 ( read-write )  \ Backup data register 1
BKP $C + constant BKP_DATA2 ( read-write )  \ Backup data register 2
BKP $10 + constant BKP_DATA3 ( read-write )  \ Backup data register 3
BKP $14 + constant BKP_DATA4 ( read-write )  \ Backup data register 4
BKP $18 + constant BKP_DATA5 ( read-write )  \ Backup data register 5
BKP $1C + constant BKP_DATA6 ( read-write )  \ Backup data register 6
BKP $20 + constant BKP_DATA7 ( read-write )  \ Backup data register 7
BKP $24 + constant BKP_DATA8 ( read-write )  \ Backup data register 8
BKP $28 + constant BKP_DATA9 ( read-write )  \ Backup data register 9
BKP $40 + constant BKP_DATA10 ( read-write )  \ Backup data register 10
BKP $44 + constant BKP_DATA11 ( read-write )  \ Backup data register 11
BKP $48 + constant BKP_DATA12 ( read-write )  \ Backup data register 12
BKP $4C + constant BKP_DATA13 ( read-write )  \ Backup data register 13
BKP $50 + constant BKP_DATA14 ( read-write )  \ Backup data register 14
BKP $54 + constant BKP_DATA15 ( read-write )  \ Backup data register 15
BKP $58 + constant BKP_DATA16 ( read-write )  \ Backup data register 16
BKP $5C + constant BKP_DATA17 ( read-write )  \ Backup data register 17
BKP $60 + constant BKP_DATA18 ( read-write )  \ Backup data register 18
BKP $64 + constant BKP_DATA19 ( read-write )  \ Backup data register 19
BKP $68 + constant BKP_DATA20 ( read-write )  \ Backup data register 20
BKP $6C + constant BKP_DATA21 ( read-write )  \ Backup data register 21
BKP $70 + constant BKP_DATA22 ( read-write )  \ Backup data register 22
BKP $74 + constant BKP_DATA23 ( read-write )  \ Backup data register 23
BKP $78 + constant BKP_DATA24 ( read-write )  \ Backup data register 24
BKP $7C + constant BKP_DATA25 ( read-write )  \ Backup data register 25
BKP $80 + constant BKP_DATA26 ( read-write )  \ Backup data register 26
BKP $84 + constant BKP_DATA27 ( read-write )  \ Backup data register 27
BKP $88 + constant BKP_DATA28 ( read-write )  \ Backup data register 28
BKP $8C + constant BKP_DATA29 ( read-write )  \ Backup data register 29
BKP $90 + constant BKP_DATA30 ( read-write )  \ Backup data register 30
BKP $94 + constant BKP_DATA31 ( read-write )  \ Backup data register 31
BKP $98 + constant BKP_DATA32 ( read-write )  \ Backup data register 32
BKP $9C + constant BKP_DATA33 ( read-write )  \ Backup data register 33
BKP $A0 + constant BKP_DATA34 ( read-write )  \ Backup data register 34
BKP $A4 + constant BKP_DATA35 ( read-write )  \ Backup data register 35
BKP $A8 + constant BKP_DATA36 ( read-write )  \ Backup data register 36
BKP $AC + constant BKP_DATA37 ( read-write )  \ Backup data register 37
BKP $B0 + constant BKP_DATA38 ( read-write )  \ Backup data register 38
BKP $B4 + constant BKP_DATA39 ( read-write )  \ Backup data register 39
BKP $B8 + constant BKP_DATA40 ( read-write )  \ Backup data register 40
BKP $BC + constant BKP_DATA41 ( read-write )  \ Backup data register 41
BKP $2C + constant BKP_OCTL ( read-write )  \ RTC signal output control register
BKP $30 + constant BKP_TPCTL ( read-write )  \ Tamper pin control register
BKP $34 + constant BKP_TPCS ( read-write )  \ Tamper control and status register
: BKP_DATA0. cr ." BKP_DATA0.  RW   $" BKP_DATA0 @ hex. BKP_DATA0 1b. ;
: BKP_DATA1. cr ." BKP_DATA1.  RW   $" BKP_DATA1 @ hex. BKP_DATA1 1b. ;
: BKP_DATA2. cr ." BKP_DATA2.  RW   $" BKP_DATA2 @ hex. BKP_DATA2 1b. ;
: BKP_DATA3. cr ." BKP_DATA3.  RW   $" BKP_DATA3 @ hex. BKP_DATA3 1b. ;
: BKP_DATA4. cr ." BKP_DATA4.  RW   $" BKP_DATA4 @ hex. BKP_DATA4 1b. ;
: BKP_DATA5. cr ." BKP_DATA5.  RW   $" BKP_DATA5 @ hex. BKP_DATA5 1b. ;
: BKP_DATA6. cr ." BKP_DATA6.  RW   $" BKP_DATA6 @ hex. BKP_DATA6 1b. ;
: BKP_DATA7. cr ." BKP_DATA7.  RW   $" BKP_DATA7 @ hex. BKP_DATA7 1b. ;
: BKP_DATA8. cr ." BKP_DATA8.  RW   $" BKP_DATA8 @ hex. BKP_DATA8 1b. ;
: BKP_DATA9. cr ." BKP_DATA9.  RW   $" BKP_DATA9 @ hex. BKP_DATA9 1b. ;
: BKP_DATA10. cr ." BKP_DATA10.  RW   $" BKP_DATA10 @ hex. BKP_DATA10 1b. ;
: BKP_DATA11. cr ." BKP_DATA11.  RW   $" BKP_DATA11 @ hex. BKP_DATA11 1b. ;
: BKP_DATA12. cr ." BKP_DATA12.  RW   $" BKP_DATA12 @ hex. BKP_DATA12 1b. ;
: BKP_DATA13. cr ." BKP_DATA13.  RW   $" BKP_DATA13 @ hex. BKP_DATA13 1b. ;
: BKP_DATA14. cr ." BKP_DATA14.  RW   $" BKP_DATA14 @ hex. BKP_DATA14 1b. ;
: BKP_DATA15. cr ." BKP_DATA15.  RW   $" BKP_DATA15 @ hex. BKP_DATA15 1b. ;
: BKP_DATA16. cr ." BKP_DATA16.  RW   $" BKP_DATA16 @ hex. BKP_DATA16 1b. ;
: BKP_DATA17. cr ." BKP_DATA17.  RW   $" BKP_DATA17 @ hex. BKP_DATA17 1b. ;
: BKP_DATA18. cr ." BKP_DATA18.  RW   $" BKP_DATA18 @ hex. BKP_DATA18 1b. ;
: BKP_DATA19. cr ." BKP_DATA19.  RW   $" BKP_DATA19 @ hex. BKP_DATA19 1b. ;
: BKP_DATA20. cr ." BKP_DATA20.  RW   $" BKP_DATA20 @ hex. BKP_DATA20 1b. ;
: BKP_DATA21. cr ." BKP_DATA21.  RW   $" BKP_DATA21 @ hex. BKP_DATA21 1b. ;
: BKP_DATA22. cr ." BKP_DATA22.  RW   $" BKP_DATA22 @ hex. BKP_DATA22 1b. ;
: BKP_DATA23. cr ." BKP_DATA23.  RW   $" BKP_DATA23 @ hex. BKP_DATA23 1b. ;
: BKP_DATA24. cr ." BKP_DATA24.  RW   $" BKP_DATA24 @ hex. BKP_DATA24 1b. ;
: BKP_DATA25. cr ." BKP_DATA25.  RW   $" BKP_DATA25 @ hex. BKP_DATA25 1b. ;
: BKP_DATA26. cr ." BKP_DATA26.  RW   $" BKP_DATA26 @ hex. BKP_DATA26 1b. ;
: BKP_DATA27. cr ." BKP_DATA27.  RW   $" BKP_DATA27 @ hex. BKP_DATA27 1b. ;
: BKP_DATA28. cr ." BKP_DATA28.  RW   $" BKP_DATA28 @ hex. BKP_DATA28 1b. ;
: BKP_DATA29. cr ." BKP_DATA29.  RW   $" BKP_DATA29 @ hex. BKP_DATA29 1b. ;
: BKP_DATA30. cr ." BKP_DATA30.  RW   $" BKP_DATA30 @ hex. BKP_DATA30 1b. ;
: BKP_DATA31. cr ." BKP_DATA31.  RW   $" BKP_DATA31 @ hex. BKP_DATA31 1b. ;
: BKP_DATA32. cr ." BKP_DATA32.  RW   $" BKP_DATA32 @ hex. BKP_DATA32 1b. ;
: BKP_DATA33. cr ." BKP_DATA33.  RW   $" BKP_DATA33 @ hex. BKP_DATA33 1b. ;
: BKP_DATA34. cr ." BKP_DATA34.  RW   $" BKP_DATA34 @ hex. BKP_DATA34 1b. ;
: BKP_DATA35. cr ." BKP_DATA35.  RW   $" BKP_DATA35 @ hex. BKP_DATA35 1b. ;
: BKP_DATA36. cr ." BKP_DATA36.  RW   $" BKP_DATA36 @ hex. BKP_DATA36 1b. ;
: BKP_DATA37. cr ." BKP_DATA37.  RW   $" BKP_DATA37 @ hex. BKP_DATA37 1b. ;
: BKP_DATA38. cr ." BKP_DATA38.  RW   $" BKP_DATA38 @ hex. BKP_DATA38 1b. ;
: BKP_DATA39. cr ." BKP_DATA39.  RW   $" BKP_DATA39 @ hex. BKP_DATA39 1b. ;
: BKP_DATA40. cr ." BKP_DATA40.  RW   $" BKP_DATA40 @ hex. BKP_DATA40 1b. ;
: BKP_DATA41. cr ." BKP_DATA41.  RW   $" BKP_DATA41 @ hex. BKP_DATA41 1b. ;
: BKP_OCTL. cr ." BKP_OCTL.  RW   $" BKP_OCTL @ hex. BKP_OCTL 1b. ;
: BKP_TPCTL. cr ." BKP_TPCTL.  RW   $" BKP_TPCTL @ hex. BKP_TPCTL 1b. ;
: BKP_TPCS. cr ." BKP_TPCS.  RW   $" BKP_TPCS @ hex. BKP_TPCS 1b. ;
: BKP.
BKP_DATA0.
BKP_DATA1.
BKP_DATA2.
BKP_DATA3.
BKP_DATA4.
BKP_DATA5.
BKP_DATA6.
BKP_DATA7.
BKP_DATA8.
BKP_DATA9.
BKP_DATA10.
BKP_DATA11.
BKP_DATA12.
BKP_DATA13.
BKP_DATA14.
BKP_DATA15.
BKP_DATA16.
BKP_DATA17.
BKP_DATA18.
BKP_DATA19.
BKP_DATA20.
BKP_DATA21.
BKP_DATA22.
BKP_DATA23.
BKP_DATA24.
BKP_DATA25.
BKP_DATA26.
BKP_DATA27.
BKP_DATA28.
BKP_DATA29.
BKP_DATA30.
BKP_DATA31.
BKP_DATA32.
BKP_DATA33.
BKP_DATA34.
BKP_DATA35.
BKP_DATA36.
BKP_DATA37.
BKP_DATA38.
BKP_DATA39.
BKP_DATA40.
BKP_DATA41.
BKP_OCTL.
BKP_TPCTL.
BKP_TPCS.
;

$40006400 constant CAN0 \ Controller area network
CAN0 $0 + constant CAN0_CTL ( read-write )  \ Control register
CAN0 $04 + constant CAN0_STAT (  )  \ Status register
CAN0 $8 + constant CAN0_TSTAT (  )  \ Transmit status register
CAN0 $0C + constant CAN0_RFIFO0 (  )  \ Receive message FIFO0 register
CAN0 $10 + constant CAN0_RFIFO1 (  )  \ Receive message FIFO1 register
CAN0 $14 + constant CAN0_INTEN ( read-write )  \ Interrupt enable register
CAN0 $18 + constant CAN0_ERR (  )  \ Error register
CAN0 $1C + constant CAN0_BT ( read-write )  \ Bit timing register
CAN0 $180 + constant CAN0_TMI0 ( read-write )  \ Transmit mailbox identifier register 0
CAN0 $184 + constant CAN0_TMP0 ( read-write )  \ Transmit mailbox property register 0
CAN0 $188 + constant CAN0_TMDATA00 ( read-write )  \ Transmit mailbox data0 register
CAN0 $18C + constant CAN0_TMDATA10 ( read-write )  \ Transmit mailbox data1 register
CAN0 $190 + constant CAN0_TMI1 ( read-write )  \ Transmit mailbox identifier register 1
CAN0 $194 + constant CAN0_TMP1 ( read-write )  \ Transmit mailbox property register 1
CAN0 $198 + constant CAN0_TMDATA01 ( read-write )  \ Transmit mailbox data0 register
CAN0 $19C + constant CAN0_TMDATA11 ( read-write )  \ Transmit mailbox data1 register
CAN0 $1A0 + constant CAN0_TMI2 ( read-write )  \ Transmit mailbox identifier register 2
CAN0 $1A4 + constant CAN0_TMP2 ( read-write )  \ Transmit mailbox property register 2
CAN0 $1A8 + constant CAN0_TMDATA02 ( read-write )  \ Transmit mailbox data0 register
CAN0 $1AC + constant CAN0_TMDATA12 ( read-write )  \ Transmit mailbox data1 register
CAN0 $1B0 + constant CAN0_RFIFOMI0 ( read-only )  \ Receive FIFO mailbox identifier register
CAN0 $1B4 + constant CAN0_RFIFOMP0 ( read-only )  \ Receive FIFO0 mailbox property register
CAN0 $1B8 + constant CAN0_RFIFOMDATA00 ( read-only )  \ Receive FIFO0 mailbox data0 register
CAN0 $1BC + constant CAN0_RFIFOMDATA10 ( read-only )  \ Receive FIFO0 mailbox data1 register
CAN0 $1C0 + constant CAN0_RFIFOMI1 ( read-only )  \ Receive FIFO1 mailbox identifier register
CAN0 $1C4 + constant CAN0_RFIFOMP1 ( read-only )  \ Receive FIFO1 mailbox property register
CAN0 $1C8 + constant CAN0_RFIFOMDATA01 ( read-only )  \ Receive FIFO1 mailbox data0 register
CAN0 $1CC + constant CAN0_RFIFOMDATA11 ( read-only )  \ Receive FIFO1 mailbox data1 register
CAN0 $200 + constant CAN0_FCTL ( read-write )  \ Filter control register
CAN0 $204 + constant CAN0_FMCFG ( read-write )  \ Filter mode configuration register
CAN0 $20C + constant CAN0_FSCFG ( read-write )  \ Filter scale configuration register
CAN0 $214 + constant CAN0_FAFIFO ( read-write )  \ Filter associated FIFO register
CAN0 $21C + constant CAN0_FW ( read-write )  \ Filter working register
CAN0 $240 + constant CAN0_F0DATA0 ( read-write )  \ Filter 0 data 0 register
CAN0 $244 + constant CAN0_F0DATA1 ( read-write )  \ Filter 0 data 1 register
CAN0 $248 + constant CAN0_F1DATA0 ( read-write )  \ Filter 1 data 0 register
CAN0 $24C + constant CAN0_F1DATA1 ( read-write )  \ Filter 1 data 1 register
CAN0 $250 + constant CAN0_F2DATA0 ( read-write )  \ Filter 2 data 0 register
CAN0 $254 + constant CAN0_F2DATA1 ( read-write )  \ Filter 2 data 1 register
CAN0 $258 + constant CAN0_F3DATA0 ( read-write )  \ Filter 3 data 0 register
CAN0 $25C + constant CAN0_F3DATA1 ( read-write )  \ Filter 3 data 1 register
CAN0 $260 + constant CAN0_F4DATA0 ( read-write )  \ Filter 4 data 0 register
CAN0 $264 + constant CAN0_F4DATA1 ( read-write )  \ Filter 4 data 1 register
CAN0 $268 + constant CAN0_F5DATA0 ( read-write )  \ Filter 5 data 0 register
CAN0 $26C + constant CAN0_F5DATA1 ( read-write )  \ Filter 5 data 1 register
CAN0 $270 + constant CAN0_F6DATA0 ( read-write )  \ Filter 6 data 0 register
CAN0 $274 + constant CAN0_F6DATA1 ( read-write )  \ Filter 6 data 1 register
CAN0 $278 + constant CAN0_F7DATA0 ( read-write )  \ Filter 7 data 0 register
CAN0 $27C + constant CAN0_F7DATA1 ( read-write )  \ Filter 7 data 1 register
CAN0 $280 + constant CAN0_F8DATA0 ( read-write )  \ Filter 8 data 0 register
CAN0 $284 + constant CAN0_F8DATA1 ( read-write )  \ Filter 8 data 1 register
CAN0 $288 + constant CAN0_F9DATA0 ( read-write )  \ Filter 9 data 0 register
CAN0 $28C + constant CAN0_F9DATA1 ( read-write )  \ Filter 9 data 1 register
CAN0 $290 + constant CAN0_F10DATA0 ( read-write )  \ Filter 10 data 0 register
CAN0 $294 + constant CAN0_F10DATA1 ( read-write )  \ Filter 10 data 1 register
CAN0 $298 + constant CAN0_F11DATA0 ( read-write )  \ Filter 11 data 0 register
CAN0 $29C + constant CAN0_F11DATA1 ( read-write )  \ Filter 11 data 1 register
CAN0 $2A0 + constant CAN0_F12DATA0 ( read-write )  \ Filter 12 data 0 register
CAN0 $2A4 + constant CAN0_F12DATA1 ( read-write )  \ Filter 12 data 1 register
CAN0 $2A8 + constant CAN0_F13DATA0 ( read-write )  \ Filter 13 data 0 register
CAN0 $2AC + constant CAN0_F13DATA1 ( read-write )  \ Filter 13 data 1 register
CAN0 $2B0 + constant CAN0_F14DATA0 ( read-write )  \ Filter 14 data 0 register
CAN0 $2B4 + constant CAN0_F14DATA1 ( read-write )  \ Filter 14 data 1 register
CAN0 $2B8 + constant CAN0_F15DATA0 ( read-write )  \ Filter 15 data 0 register
CAN0 $2BC + constant CAN0_F15DATA1 ( read-write )  \ Filter 15 data 1 register
CAN0 $2C0 + constant CAN0_F16DATA0 ( read-write )  \ Filter 16 data 0 register
CAN0 $2C4 + constant CAN0_F16DATA1 ( read-write )  \ Filter 16 data 1 register
CAN0 $2C8 + constant CAN0_F17DATA0 ( read-write )  \ Filter 17 data 0 register
CAN0 $2CC + constant CAN0_F17DATA1 ( read-write )  \ Filter 17 data 1 register
CAN0 $2D0 + constant CAN0_F18DATA0 ( read-write )  \ Filter 18 data 0 register
CAN0 $2D4 + constant CAN0_F18DATA1 ( read-write )  \ Filter 18 data 1 register
CAN0 $2D8 + constant CAN0_F19DATA0 ( read-write )  \ Filter 19 data 0 register
CAN0 $2DC + constant CAN0_F19DATA1 ( read-write )  \ Filter 19 data 1 register
CAN0 $2E0 + constant CAN0_F20DATA0 ( read-write )  \ Filter 20 data 0 register
CAN0 $2E4 + constant CAN0_F20DATA1 ( read-write )  \ Filter 20 data 1 register
CAN0 $2E8 + constant CAN0_F21DATA0 ( read-write )  \ Filter 21 data 0 register
CAN0 $2EC + constant CAN0_F21DATA1 ( read-write )  \ Filter 21 data 1 register
CAN0 $2F0 + constant CAN0_F22DATA0 ( read-write )  \ Filter 22 data 0 register
CAN0 $2F4 + constant CAN0_F22DATA1 ( read-write )  \ Filter 22 data 1 register
CAN0 $2F8 + constant CAN0_F23DATA0 ( read-write )  \ Filter 23 data 0 register
CAN0 $2FC + constant CAN0_F23DATA1 ( read-write )  \ Filter 23 data 1 register
CAN0 $300 + constant CAN0_F24DATA0 ( read-write )  \ Filter 24 data 0 register
CAN0 $304 + constant CAN0_F24DATA1 ( read-write )  \ Filter 24 data 1 register
CAN0 $308 + constant CAN0_F25DATA0 ( read-write )  \ Filter 25 data 0 register
CAN0 $30C + constant CAN0_F25DATA1 ( read-write )  \ Filter 25 data 1 register
CAN0 $310 + constant CAN0_F26DATA0 ( read-write )  \ Filter 26 data 0 register
CAN0 $314 + constant CAN0_F26DATA1 ( read-write )  \ Filter 26 data 1 register
CAN0 $318 + constant CAN0_F27DATA0 ( read-write )  \ Filter 27 data 0 register
CAN0 $31C + constant CAN0_F27DATA1 ( read-write )  \ Filter 27 data 1 register
: CAN0_CTL. cr ." CAN0_CTL.  RW   $" CAN0_CTL @ hex. CAN0_CTL 1b. ;
: CAN0_STAT. cr ." CAN0_STAT.   $" CAN0_STAT @ hex. CAN0_STAT 1b. ;
: CAN0_TSTAT. cr ." CAN0_TSTAT.   $" CAN0_TSTAT @ hex. CAN0_TSTAT 1b. ;
: CAN0_RFIFO0. cr ." CAN0_RFIFO0.   $" CAN0_RFIFO0 @ hex. CAN0_RFIFO0 1b. ;
: CAN0_RFIFO1. cr ." CAN0_RFIFO1.   $" CAN0_RFIFO1 @ hex. CAN0_RFIFO1 1b. ;
: CAN0_INTEN. cr ." CAN0_INTEN.  RW   $" CAN0_INTEN @ hex. CAN0_INTEN 1b. ;
: CAN0_ERR. cr ." CAN0_ERR.   $" CAN0_ERR @ hex. CAN0_ERR 1b. ;
: CAN0_BT. cr ." CAN0_BT.  RW   $" CAN0_BT @ hex. CAN0_BT 1b. ;
: CAN0_TMI0. cr ." CAN0_TMI0.  RW   $" CAN0_TMI0 @ hex. CAN0_TMI0 1b. ;
: CAN0_TMP0. cr ." CAN0_TMP0.  RW   $" CAN0_TMP0 @ hex. CAN0_TMP0 1b. ;
: CAN0_TMDATA00. cr ." CAN0_TMDATA00.  RW   $" CAN0_TMDATA00 @ hex. CAN0_TMDATA00 1b. ;
: CAN0_TMDATA10. cr ." CAN0_TMDATA10.  RW   $" CAN0_TMDATA10 @ hex. CAN0_TMDATA10 1b. ;
: CAN0_TMI1. cr ." CAN0_TMI1.  RW   $" CAN0_TMI1 @ hex. CAN0_TMI1 1b. ;
: CAN0_TMP1. cr ." CAN0_TMP1.  RW   $" CAN0_TMP1 @ hex. CAN0_TMP1 1b. ;
: CAN0_TMDATA01. cr ." CAN0_TMDATA01.  RW   $" CAN0_TMDATA01 @ hex. CAN0_TMDATA01 1b. ;
: CAN0_TMDATA11. cr ." CAN0_TMDATA11.  RW   $" CAN0_TMDATA11 @ hex. CAN0_TMDATA11 1b. ;
: CAN0_TMI2. cr ." CAN0_TMI2.  RW   $" CAN0_TMI2 @ hex. CAN0_TMI2 1b. ;
: CAN0_TMP2. cr ." CAN0_TMP2.  RW   $" CAN0_TMP2 @ hex. CAN0_TMP2 1b. ;
: CAN0_TMDATA02. cr ." CAN0_TMDATA02.  RW   $" CAN0_TMDATA02 @ hex. CAN0_TMDATA02 1b. ;
: CAN0_TMDATA12. cr ." CAN0_TMDATA12.  RW   $" CAN0_TMDATA12 @ hex. CAN0_TMDATA12 1b. ;
: CAN0_RFIFOMI0. cr ." CAN0_RFIFOMI0.  RO   $" CAN0_RFIFOMI0 @ hex. CAN0_RFIFOMI0 1b. ;
: CAN0_RFIFOMP0. cr ." CAN0_RFIFOMP0.  RO   $" CAN0_RFIFOMP0 @ hex. CAN0_RFIFOMP0 1b. ;
: CAN0_RFIFOMDATA00. cr ." CAN0_RFIFOMDATA00.  RO   $" CAN0_RFIFOMDATA00 @ hex. CAN0_RFIFOMDATA00 1b. ;
: CAN0_RFIFOMDATA10. cr ." CAN0_RFIFOMDATA10.  RO   $" CAN0_RFIFOMDATA10 @ hex. CAN0_RFIFOMDATA10 1b. ;
: CAN0_RFIFOMI1. cr ." CAN0_RFIFOMI1.  RO   $" CAN0_RFIFOMI1 @ hex. CAN0_RFIFOMI1 1b. ;
: CAN0_RFIFOMP1. cr ." CAN0_RFIFOMP1.  RO   $" CAN0_RFIFOMP1 @ hex. CAN0_RFIFOMP1 1b. ;
: CAN0_RFIFOMDATA01. cr ." CAN0_RFIFOMDATA01.  RO   $" CAN0_RFIFOMDATA01 @ hex. CAN0_RFIFOMDATA01 1b. ;
: CAN0_RFIFOMDATA11. cr ." CAN0_RFIFOMDATA11.  RO   $" CAN0_RFIFOMDATA11 @ hex. CAN0_RFIFOMDATA11 1b. ;
: CAN0_FCTL. cr ." CAN0_FCTL.  RW   $" CAN0_FCTL @ hex. CAN0_FCTL 1b. ;
: CAN0_FMCFG. cr ." CAN0_FMCFG.  RW   $" CAN0_FMCFG @ hex. CAN0_FMCFG 1b. ;
: CAN0_FSCFG. cr ." CAN0_FSCFG.  RW   $" CAN0_FSCFG @ hex. CAN0_FSCFG 1b. ;
: CAN0_FAFIFO. cr ." CAN0_FAFIFO.  RW   $" CAN0_FAFIFO @ hex. CAN0_FAFIFO 1b. ;
: CAN0_FW. cr ." CAN0_FW.  RW   $" CAN0_FW @ hex. CAN0_FW 1b. ;
: CAN0_F0DATA0. cr ." CAN0_F0DATA0.  RW   $" CAN0_F0DATA0 @ hex. CAN0_F0DATA0 1b. ;
: CAN0_F0DATA1. cr ." CAN0_F0DATA1.  RW   $" CAN0_F0DATA1 @ hex. CAN0_F0DATA1 1b. ;
: CAN0_F1DATA0. cr ." CAN0_F1DATA0.  RW   $" CAN0_F1DATA0 @ hex. CAN0_F1DATA0 1b. ;
: CAN0_F1DATA1. cr ." CAN0_F1DATA1.  RW   $" CAN0_F1DATA1 @ hex. CAN0_F1DATA1 1b. ;
: CAN0_F2DATA0. cr ." CAN0_F2DATA0.  RW   $" CAN0_F2DATA0 @ hex. CAN0_F2DATA0 1b. ;
: CAN0_F2DATA1. cr ." CAN0_F2DATA1.  RW   $" CAN0_F2DATA1 @ hex. CAN0_F2DATA1 1b. ;
: CAN0_F3DATA0. cr ." CAN0_F3DATA0.  RW   $" CAN0_F3DATA0 @ hex. CAN0_F3DATA0 1b. ;
: CAN0_F3DATA1. cr ." CAN0_F3DATA1.  RW   $" CAN0_F3DATA1 @ hex. CAN0_F3DATA1 1b. ;
: CAN0_F4DATA0. cr ." CAN0_F4DATA0.  RW   $" CAN0_F4DATA0 @ hex. CAN0_F4DATA0 1b. ;
: CAN0_F4DATA1. cr ." CAN0_F4DATA1.  RW   $" CAN0_F4DATA1 @ hex. CAN0_F4DATA1 1b. ;
: CAN0_F5DATA0. cr ." CAN0_F5DATA0.  RW   $" CAN0_F5DATA0 @ hex. CAN0_F5DATA0 1b. ;
: CAN0_F5DATA1. cr ." CAN0_F5DATA1.  RW   $" CAN0_F5DATA1 @ hex. CAN0_F5DATA1 1b. ;
: CAN0_F6DATA0. cr ." CAN0_F6DATA0.  RW   $" CAN0_F6DATA0 @ hex. CAN0_F6DATA0 1b. ;
: CAN0_F6DATA1. cr ." CAN0_F6DATA1.  RW   $" CAN0_F6DATA1 @ hex. CAN0_F6DATA1 1b. ;
: CAN0_F7DATA0. cr ." CAN0_F7DATA0.  RW   $" CAN0_F7DATA0 @ hex. CAN0_F7DATA0 1b. ;
: CAN0_F7DATA1. cr ." CAN0_F7DATA1.  RW   $" CAN0_F7DATA1 @ hex. CAN0_F7DATA1 1b. ;
: CAN0_F8DATA0. cr ." CAN0_F8DATA0.  RW   $" CAN0_F8DATA0 @ hex. CAN0_F8DATA0 1b. ;
: CAN0_F8DATA1. cr ." CAN0_F8DATA1.  RW   $" CAN0_F8DATA1 @ hex. CAN0_F8DATA1 1b. ;
: CAN0_F9DATA0. cr ." CAN0_F9DATA0.  RW   $" CAN0_F9DATA0 @ hex. CAN0_F9DATA0 1b. ;
: CAN0_F9DATA1. cr ." CAN0_F9DATA1.  RW   $" CAN0_F9DATA1 @ hex. CAN0_F9DATA1 1b. ;
: CAN0_F10DATA0. cr ." CAN0_F10DATA0.  RW   $" CAN0_F10DATA0 @ hex. CAN0_F10DATA0 1b. ;
: CAN0_F10DATA1. cr ." CAN0_F10DATA1.  RW   $" CAN0_F10DATA1 @ hex. CAN0_F10DATA1 1b. ;
: CAN0_F11DATA0. cr ." CAN0_F11DATA0.  RW   $" CAN0_F11DATA0 @ hex. CAN0_F11DATA0 1b. ;
: CAN0_F11DATA1. cr ." CAN0_F11DATA1.  RW   $" CAN0_F11DATA1 @ hex. CAN0_F11DATA1 1b. ;
: CAN0_F12DATA0. cr ." CAN0_F12DATA0.  RW   $" CAN0_F12DATA0 @ hex. CAN0_F12DATA0 1b. ;
: CAN0_F12DATA1. cr ." CAN0_F12DATA1.  RW   $" CAN0_F12DATA1 @ hex. CAN0_F12DATA1 1b. ;
: CAN0_F13DATA0. cr ." CAN0_F13DATA0.  RW   $" CAN0_F13DATA0 @ hex. CAN0_F13DATA0 1b. ;
: CAN0_F13DATA1. cr ." CAN0_F13DATA1.  RW   $" CAN0_F13DATA1 @ hex. CAN0_F13DATA1 1b. ;
: CAN0_F14DATA0. cr ." CAN0_F14DATA0.  RW   $" CAN0_F14DATA0 @ hex. CAN0_F14DATA0 1b. ;
: CAN0_F14DATA1. cr ." CAN0_F14DATA1.  RW   $" CAN0_F14DATA1 @ hex. CAN0_F14DATA1 1b. ;
: CAN0_F15DATA0. cr ." CAN0_F15DATA0.  RW   $" CAN0_F15DATA0 @ hex. CAN0_F15DATA0 1b. ;
: CAN0_F15DATA1. cr ." CAN0_F15DATA1.  RW   $" CAN0_F15DATA1 @ hex. CAN0_F15DATA1 1b. ;
: CAN0_F16DATA0. cr ." CAN0_F16DATA0.  RW   $" CAN0_F16DATA0 @ hex. CAN0_F16DATA0 1b. ;
: CAN0_F16DATA1. cr ." CAN0_F16DATA1.  RW   $" CAN0_F16DATA1 @ hex. CAN0_F16DATA1 1b. ;
: CAN0_F17DATA0. cr ." CAN0_F17DATA0.  RW   $" CAN0_F17DATA0 @ hex. CAN0_F17DATA0 1b. ;
: CAN0_F17DATA1. cr ." CAN0_F17DATA1.  RW   $" CAN0_F17DATA1 @ hex. CAN0_F17DATA1 1b. ;
: CAN0_F18DATA0. cr ." CAN0_F18DATA0.  RW   $" CAN0_F18DATA0 @ hex. CAN0_F18DATA0 1b. ;
: CAN0_F18DATA1. cr ." CAN0_F18DATA1.  RW   $" CAN0_F18DATA1 @ hex. CAN0_F18DATA1 1b. ;
: CAN0_F19DATA0. cr ." CAN0_F19DATA0.  RW   $" CAN0_F19DATA0 @ hex. CAN0_F19DATA0 1b. ;
: CAN0_F19DATA1. cr ." CAN0_F19DATA1.  RW   $" CAN0_F19DATA1 @ hex. CAN0_F19DATA1 1b. ;
: CAN0_F20DATA0. cr ." CAN0_F20DATA0.  RW   $" CAN0_F20DATA0 @ hex. CAN0_F20DATA0 1b. ;
: CAN0_F20DATA1. cr ." CAN0_F20DATA1.  RW   $" CAN0_F20DATA1 @ hex. CAN0_F20DATA1 1b. ;
: CAN0_F21DATA0. cr ." CAN0_F21DATA0.  RW   $" CAN0_F21DATA0 @ hex. CAN0_F21DATA0 1b. ;
: CAN0_F21DATA1. cr ." CAN0_F21DATA1.  RW   $" CAN0_F21DATA1 @ hex. CAN0_F21DATA1 1b. ;
: CAN0_F22DATA0. cr ." CAN0_F22DATA0.  RW   $" CAN0_F22DATA0 @ hex. CAN0_F22DATA0 1b. ;
: CAN0_F22DATA1. cr ." CAN0_F22DATA1.  RW   $" CAN0_F22DATA1 @ hex. CAN0_F22DATA1 1b. ;
: CAN0_F23DATA0. cr ." CAN0_F23DATA0.  RW   $" CAN0_F23DATA0 @ hex. CAN0_F23DATA0 1b. ;
: CAN0_F23DATA1. cr ." CAN0_F23DATA1.  RW   $" CAN0_F23DATA1 @ hex. CAN0_F23DATA1 1b. ;
: CAN0_F24DATA0. cr ." CAN0_F24DATA0.  RW   $" CAN0_F24DATA0 @ hex. CAN0_F24DATA0 1b. ;
: CAN0_F24DATA1. cr ." CAN0_F24DATA1.  RW   $" CAN0_F24DATA1 @ hex. CAN0_F24DATA1 1b. ;
: CAN0_F25DATA0. cr ." CAN0_F25DATA0.  RW   $" CAN0_F25DATA0 @ hex. CAN0_F25DATA0 1b. ;
: CAN0_F25DATA1. cr ." CAN0_F25DATA1.  RW   $" CAN0_F25DATA1 @ hex. CAN0_F25DATA1 1b. ;
: CAN0_F26DATA0. cr ." CAN0_F26DATA0.  RW   $" CAN0_F26DATA0 @ hex. CAN0_F26DATA0 1b. ;
: CAN0_F26DATA1. cr ." CAN0_F26DATA1.  RW   $" CAN0_F26DATA1 @ hex. CAN0_F26DATA1 1b. ;
: CAN0_F27DATA0. cr ." CAN0_F27DATA0.  RW   $" CAN0_F27DATA0 @ hex. CAN0_F27DATA0 1b. ;
: CAN0_F27DATA1. cr ." CAN0_F27DATA1.  RW   $" CAN0_F27DATA1 @ hex. CAN0_F27DATA1 1b. ;
: CAN0.
CAN0_CTL.
CAN0_STAT.
CAN0_TSTAT.
CAN0_RFIFO0.
CAN0_RFIFO1.
CAN0_INTEN.
CAN0_ERR.
CAN0_BT.
CAN0_TMI0.
CAN0_TMP0.
CAN0_TMDATA00.
CAN0_TMDATA10.
CAN0_TMI1.
CAN0_TMP1.
CAN0_TMDATA01.
CAN0_TMDATA11.
CAN0_TMI2.
CAN0_TMP2.
CAN0_TMDATA02.
CAN0_TMDATA12.
CAN0_RFIFOMI0.
CAN0_RFIFOMP0.
CAN0_RFIFOMDATA00.
CAN0_RFIFOMDATA10.
CAN0_RFIFOMI1.
CAN0_RFIFOMP1.
CAN0_RFIFOMDATA01.
CAN0_RFIFOMDATA11.
CAN0_FCTL.
CAN0_FMCFG.
CAN0_FSCFG.
CAN0_FAFIFO.
CAN0_FW.
CAN0_F0DATA0.
CAN0_F0DATA1.
CAN0_F1DATA0.
CAN0_F1DATA1.
CAN0_F2DATA0.
CAN0_F2DATA1.
CAN0_F3DATA0.
CAN0_F3DATA1.
CAN0_F4DATA0.
CAN0_F4DATA1.
CAN0_F5DATA0.
CAN0_F5DATA1.
CAN0_F6DATA0.
CAN0_F6DATA1.
CAN0_F7DATA0.
CAN0_F7DATA1.
CAN0_F8DATA0.
CAN0_F8DATA1.
CAN0_F9DATA0.
CAN0_F9DATA1.
CAN0_F10DATA0.
CAN0_F10DATA1.
CAN0_F11DATA0.
CAN0_F11DATA1.
CAN0_F12DATA0.
CAN0_F12DATA1.
CAN0_F13DATA0.
CAN0_F13DATA1.
CAN0_F14DATA0.
CAN0_F14DATA1.
CAN0_F15DATA0.
CAN0_F15DATA1.
CAN0_F16DATA0.
CAN0_F16DATA1.
CAN0_F17DATA0.
CAN0_F17DATA1.
CAN0_F18DATA0.
CAN0_F18DATA1.
CAN0_F19DATA0.
CAN0_F19DATA1.
CAN0_F20DATA0.
CAN0_F20DATA1.
CAN0_F21DATA0.
CAN0_F21DATA1.
CAN0_F22DATA0.
CAN0_F22DATA1.
CAN0_F23DATA0.
CAN0_F23DATA1.
CAN0_F24DATA0.
CAN0_F24DATA1.
CAN0_F25DATA0.
CAN0_F25DATA1.
CAN0_F26DATA0.
CAN0_F26DATA1.
CAN0_F27DATA0.
CAN0_F27DATA1.
;

$40006800 constant CAN1 \ Controller area network
CAN1 $0 + constant CAN1_CTL ( read-write )  \ Control register
CAN1 $04 + constant CAN1_STAT (  )  \ Status register
CAN1 $8 + constant CAN1_TSTAT (  )  \ Transmit status register
CAN1 $0C + constant CAN1_RFIFO0 (  )  \ Receive message FIFO0 register
CAN1 $10 + constant CAN1_RFIFO1 (  )  \ Receive message FIFO1 register
CAN1 $14 + constant CAN1_INTEN ( read-write )  \ Interrupt enable register
CAN1 $18 + constant CAN1_ERR (  )  \ Error register
CAN1 $1C + constant CAN1_BT ( read-write )  \ Bit timing register
CAN1 $180 + constant CAN1_TMI0 ( read-write )  \ Transmit mailbox identifier register 0
CAN1 $184 + constant CAN1_TMP0 ( read-write )  \ Transmit mailbox property register 0
CAN1 $188 + constant CAN1_TMDATA00 ( read-write )  \ Transmit mailbox data0 register
CAN1 $18C + constant CAN1_TMDATA10 ( read-write )  \ Transmit mailbox data1 register
CAN1 $190 + constant CAN1_TMI1 ( read-write )  \ Transmit mailbox identifier register 1
CAN1 $194 + constant CAN1_TMP1 ( read-write )  \ Transmit mailbox property register 1
CAN1 $198 + constant CAN1_TMDATA01 ( read-write )  \ Transmit mailbox data0 register
CAN1 $19C + constant CAN1_TMDATA11 ( read-write )  \ Transmit mailbox data1 register
CAN1 $1A0 + constant CAN1_TMI2 ( read-write )  \ Transmit mailbox identifier register 2
CAN1 $1A4 + constant CAN1_TMP2 ( read-write )  \ Transmit mailbox property register 2
CAN1 $1A8 + constant CAN1_TMDATA02 ( read-write )  \ Transmit mailbox data0 register
CAN1 $1AC + constant CAN1_TMDATA12 ( read-write )  \ Transmit mailbox data1 register
CAN1 $1B0 + constant CAN1_RFIFOMI0 ( read-only )  \ Receive FIFO mailbox identifier register
CAN1 $1B4 + constant CAN1_RFIFOMP0 ( read-only )  \ Receive FIFO0 mailbox property register
CAN1 $1B8 + constant CAN1_RFIFOMDATA00 ( read-only )  \ Receive FIFO0 mailbox data0 register
CAN1 $1BC + constant CAN1_RFIFOMDATA10 ( read-only )  \ Receive FIFO0 mailbox data1 register
CAN1 $1C0 + constant CAN1_RFIFOMI1 ( read-only )  \ Receive FIFO1 mailbox identifier register
CAN1 $1C4 + constant CAN1_RFIFOMP1 ( read-only )  \ Receive FIFO1 mailbox property register
CAN1 $1C8 + constant CAN1_RFIFOMDATA01 ( read-only )  \ Receive FIFO1 mailbox data0 register
CAN1 $1CC + constant CAN1_RFIFOMDATA11 ( read-only )  \ Receive FIFO1 mailbox data1 register
CAN1 $200 + constant CAN1_FCTL ( read-write )  \ Filter control register
CAN1 $204 + constant CAN1_FMCFG ( read-write )  \ Filter mode configuration register
CAN1 $20C + constant CAN1_FSCFG ( read-write )  \ Filter scale configuration register
CAN1 $214 + constant CAN1_FAFIFO ( read-write )  \ Filter associated FIFO register
CAN1 $21C + constant CAN1_FW ( read-write )  \ Filter working register
CAN1 $240 + constant CAN1_F0DATA0 ( read-write )  \ Filter 0 data 0 register
CAN1 $244 + constant CAN1_F0DATA1 ( read-write )  \ Filter 0 data 1 register
CAN1 $248 + constant CAN1_F1DATA0 ( read-write )  \ Filter 1 data 0 register
CAN1 $24C + constant CAN1_F1DATA1 ( read-write )  \ Filter 1 data 1 register
CAN1 $250 + constant CAN1_F2DATA0 ( read-write )  \ Filter 2 data 0 register
CAN1 $254 + constant CAN1_F2DATA1 ( read-write )  \ Filter 2 data 1 register
CAN1 $258 + constant CAN1_F3DATA0 ( read-write )  \ Filter 3 data 0 register
CAN1 $25C + constant CAN1_F3DATA1 ( read-write )  \ Filter 3 data 1 register
CAN1 $260 + constant CAN1_F4DATA0 ( read-write )  \ Filter 4 data 0 register
CAN1 $264 + constant CAN1_F4DATA1 ( read-write )  \ Filter 4 data 1 register
CAN1 $268 + constant CAN1_F5DATA0 ( read-write )  \ Filter 5 data 0 register
CAN1 $26C + constant CAN1_F5DATA1 ( read-write )  \ Filter 5 data 1 register
CAN1 $270 + constant CAN1_F6DATA0 ( read-write )  \ Filter 6 data 0 register
CAN1 $274 + constant CAN1_F6DATA1 ( read-write )  \ Filter 6 data 1 register
CAN1 $278 + constant CAN1_F7DATA0 ( read-write )  \ Filter 7 data 0 register
CAN1 $27C + constant CAN1_F7DATA1 ( read-write )  \ Filter 7 data 1 register
CAN1 $280 + constant CAN1_F8DATA0 ( read-write )  \ Filter 8 data 0 register
CAN1 $284 + constant CAN1_F8DATA1 ( read-write )  \ Filter 8 data 1 register
CAN1 $288 + constant CAN1_F9DATA0 ( read-write )  \ Filter 9 data 0 register
CAN1 $28C + constant CAN1_F9DATA1 ( read-write )  \ Filter 9 data 1 register
CAN1 $290 + constant CAN1_F10DATA0 ( read-write )  \ Filter 10 data 0 register
CAN1 $294 + constant CAN1_F10DATA1 ( read-write )  \ Filter 10 data 1 register
CAN1 $298 + constant CAN1_F11DATA0 ( read-write )  \ Filter 11 data 0 register
CAN1 $29C + constant CAN1_F11DATA1 ( read-write )  \ Filter 11 data 1 register
CAN1 $2A0 + constant CAN1_F12DATA0 ( read-write )  \ Filter 12 data 0 register
CAN1 $2A4 + constant CAN1_F12DATA1 ( read-write )  \ Filter 12 data 1 register
CAN1 $2A8 + constant CAN1_F13DATA0 ( read-write )  \ Filter 13 data 0 register
CAN1 $2AC + constant CAN1_F13DATA1 ( read-write )  \ Filter 13 data 1 register
CAN1 $2B0 + constant CAN1_F14DATA0 ( read-write )  \ Filter 14 data 0 register
CAN1 $2B4 + constant CAN1_F14DATA1 ( read-write )  \ Filter 14 data 1 register
CAN1 $2B8 + constant CAN1_F15DATA0 ( read-write )  \ Filter 15 data 0 register
CAN1 $2BC + constant CAN1_F15DATA1 ( read-write )  \ Filter 15 data 1 register
CAN1 $2C0 + constant CAN1_F16DATA0 ( read-write )  \ Filter 16 data 0 register
CAN1 $2C4 + constant CAN1_F16DATA1 ( read-write )  \ Filter 16 data 1 register
CAN1 $2C8 + constant CAN1_F17DATA0 ( read-write )  \ Filter 17 data 0 register
CAN1 $2CC + constant CAN1_F17DATA1 ( read-write )  \ Filter 17 data 1 register
CAN1 $2D0 + constant CAN1_F18DATA0 ( read-write )  \ Filter 18 data 0 register
CAN1 $2D4 + constant CAN1_F18DATA1 ( read-write )  \ Filter 18 data 1 register
CAN1 $2D8 + constant CAN1_F19DATA0 ( read-write )  \ Filter 19 data 0 register
CAN1 $2DC + constant CAN1_F19DATA1 ( read-write )  \ Filter 19 data 1 register
CAN1 $2E0 + constant CAN1_F20DATA0 ( read-write )  \ Filter 20 data 0 register
CAN1 $2E4 + constant CAN1_F20DATA1 ( read-write )  \ Filter 20 data 1 register
CAN1 $2E8 + constant CAN1_F21DATA0 ( read-write )  \ Filter 21 data 0 register
CAN1 $2EC + constant CAN1_F21DATA1 ( read-write )  \ Filter 21 data 1 register
CAN1 $2F0 + constant CAN1_F22DATA0 ( read-write )  \ Filter 22 data 0 register
CAN1 $2F4 + constant CAN1_F22DATA1 ( read-write )  \ Filter 22 data 1 register
CAN1 $2F8 + constant CAN1_F23DATA0 ( read-write )  \ Filter 23 data 0 register
CAN1 $2FC + constant CAN1_F23DATA1 ( read-write )  \ Filter 23 data 1 register
CAN1 $300 + constant CAN1_F24DATA0 ( read-write )  \ Filter 24 data 0 register
CAN1 $304 + constant CAN1_F24DATA1 ( read-write )  \ Filter 24 data 1 register
CAN1 $308 + constant CAN1_F25DATA0 ( read-write )  \ Filter 25 data 0 register
CAN1 $30C + constant CAN1_F25DATA1 ( read-write )  \ Filter 25 data 1 register
CAN1 $310 + constant CAN1_F26DATA0 ( read-write )  \ Filter 26 data 0 register
CAN1 $314 + constant CAN1_F26DATA1 ( read-write )  \ Filter 26 data 1 register
CAN1 $318 + constant CAN1_F27DATA0 ( read-write )  \ Filter 27 data 0 register
CAN1 $31C + constant CAN1_F27DATA1 ( read-write )  \ Filter 27 data 1 register
: CAN1_CTL. cr ." CAN1_CTL.  RW   $" CAN1_CTL @ hex. CAN1_CTL 1b. ;
: CAN1_STAT. cr ." CAN1_STAT.   $" CAN1_STAT @ hex. CAN1_STAT 1b. ;
: CAN1_TSTAT. cr ." CAN1_TSTAT.   $" CAN1_TSTAT @ hex. CAN1_TSTAT 1b. ;
: CAN1_RFIFO0. cr ." CAN1_RFIFO0.   $" CAN1_RFIFO0 @ hex. CAN1_RFIFO0 1b. ;
: CAN1_RFIFO1. cr ." CAN1_RFIFO1.   $" CAN1_RFIFO1 @ hex. CAN1_RFIFO1 1b. ;
: CAN1_INTEN. cr ." CAN1_INTEN.  RW   $" CAN1_INTEN @ hex. CAN1_INTEN 1b. ;
: CAN1_ERR. cr ." CAN1_ERR.   $" CAN1_ERR @ hex. CAN1_ERR 1b. ;
: CAN1_BT. cr ." CAN1_BT.  RW   $" CAN1_BT @ hex. CAN1_BT 1b. ;
: CAN1_TMI0. cr ." CAN1_TMI0.  RW   $" CAN1_TMI0 @ hex. CAN1_TMI0 1b. ;
: CAN1_TMP0. cr ." CAN1_TMP0.  RW   $" CAN1_TMP0 @ hex. CAN1_TMP0 1b. ;
: CAN1_TMDATA00. cr ." CAN1_TMDATA00.  RW   $" CAN1_TMDATA00 @ hex. CAN1_TMDATA00 1b. ;
: CAN1_TMDATA10. cr ." CAN1_TMDATA10.  RW   $" CAN1_TMDATA10 @ hex. CAN1_TMDATA10 1b. ;
: CAN1_TMI1. cr ." CAN1_TMI1.  RW   $" CAN1_TMI1 @ hex. CAN1_TMI1 1b. ;
: CAN1_TMP1. cr ." CAN1_TMP1.  RW   $" CAN1_TMP1 @ hex. CAN1_TMP1 1b. ;
: CAN1_TMDATA01. cr ." CAN1_TMDATA01.  RW   $" CAN1_TMDATA01 @ hex. CAN1_TMDATA01 1b. ;
: CAN1_TMDATA11. cr ." CAN1_TMDATA11.  RW   $" CAN1_TMDATA11 @ hex. CAN1_TMDATA11 1b. ;
: CAN1_TMI2. cr ." CAN1_TMI2.  RW   $" CAN1_TMI2 @ hex. CAN1_TMI2 1b. ;
: CAN1_TMP2. cr ." CAN1_TMP2.  RW   $" CAN1_TMP2 @ hex. CAN1_TMP2 1b. ;
: CAN1_TMDATA02. cr ." CAN1_TMDATA02.  RW   $" CAN1_TMDATA02 @ hex. CAN1_TMDATA02 1b. ;
: CAN1_TMDATA12. cr ." CAN1_TMDATA12.  RW   $" CAN1_TMDATA12 @ hex. CAN1_TMDATA12 1b. ;
: CAN1_RFIFOMI0. cr ." CAN1_RFIFOMI0.  RO   $" CAN1_RFIFOMI0 @ hex. CAN1_RFIFOMI0 1b. ;
: CAN1_RFIFOMP0. cr ." CAN1_RFIFOMP0.  RO   $" CAN1_RFIFOMP0 @ hex. CAN1_RFIFOMP0 1b. ;
: CAN1_RFIFOMDATA00. cr ." CAN1_RFIFOMDATA00.  RO   $" CAN1_RFIFOMDATA00 @ hex. CAN1_RFIFOMDATA00 1b. ;
: CAN1_RFIFOMDATA10. cr ." CAN1_RFIFOMDATA10.  RO   $" CAN1_RFIFOMDATA10 @ hex. CAN1_RFIFOMDATA10 1b. ;
: CAN1_RFIFOMI1. cr ." CAN1_RFIFOMI1.  RO   $" CAN1_RFIFOMI1 @ hex. CAN1_RFIFOMI1 1b. ;
: CAN1_RFIFOMP1. cr ." CAN1_RFIFOMP1.  RO   $" CAN1_RFIFOMP1 @ hex. CAN1_RFIFOMP1 1b. ;
: CAN1_RFIFOMDATA01. cr ." CAN1_RFIFOMDATA01.  RO   $" CAN1_RFIFOMDATA01 @ hex. CAN1_RFIFOMDATA01 1b. ;
: CAN1_RFIFOMDATA11. cr ." CAN1_RFIFOMDATA11.  RO   $" CAN1_RFIFOMDATA11 @ hex. CAN1_RFIFOMDATA11 1b. ;
: CAN1_FCTL. cr ." CAN1_FCTL.  RW   $" CAN1_FCTL @ hex. CAN1_FCTL 1b. ;
: CAN1_FMCFG. cr ." CAN1_FMCFG.  RW   $" CAN1_FMCFG @ hex. CAN1_FMCFG 1b. ;
: CAN1_FSCFG. cr ." CAN1_FSCFG.  RW   $" CAN1_FSCFG @ hex. CAN1_FSCFG 1b. ;
: CAN1_FAFIFO. cr ." CAN1_FAFIFO.  RW   $" CAN1_FAFIFO @ hex. CAN1_FAFIFO 1b. ;
: CAN1_FW. cr ." CAN1_FW.  RW   $" CAN1_FW @ hex. CAN1_FW 1b. ;
: CAN1_F0DATA0. cr ." CAN1_F0DATA0.  RW   $" CAN1_F0DATA0 @ hex. CAN1_F0DATA0 1b. ;
: CAN1_F0DATA1. cr ." CAN1_F0DATA1.  RW   $" CAN1_F0DATA1 @ hex. CAN1_F0DATA1 1b. ;
: CAN1_F1DATA0. cr ." CAN1_F1DATA0.  RW   $" CAN1_F1DATA0 @ hex. CAN1_F1DATA0 1b. ;
: CAN1_F1DATA1. cr ." CAN1_F1DATA1.  RW   $" CAN1_F1DATA1 @ hex. CAN1_F1DATA1 1b. ;
: CAN1_F2DATA0. cr ." CAN1_F2DATA0.  RW   $" CAN1_F2DATA0 @ hex. CAN1_F2DATA0 1b. ;
: CAN1_F2DATA1. cr ." CAN1_F2DATA1.  RW   $" CAN1_F2DATA1 @ hex. CAN1_F2DATA1 1b. ;
: CAN1_F3DATA0. cr ." CAN1_F3DATA0.  RW   $" CAN1_F3DATA0 @ hex. CAN1_F3DATA0 1b. ;
: CAN1_F3DATA1. cr ." CAN1_F3DATA1.  RW   $" CAN1_F3DATA1 @ hex. CAN1_F3DATA1 1b. ;
: CAN1_F4DATA0. cr ." CAN1_F4DATA0.  RW   $" CAN1_F4DATA0 @ hex. CAN1_F4DATA0 1b. ;
: CAN1_F4DATA1. cr ." CAN1_F4DATA1.  RW   $" CAN1_F4DATA1 @ hex. CAN1_F4DATA1 1b. ;
: CAN1_F5DATA0. cr ." CAN1_F5DATA0.  RW   $" CAN1_F5DATA0 @ hex. CAN1_F5DATA0 1b. ;
: CAN1_F5DATA1. cr ." CAN1_F5DATA1.  RW   $" CAN1_F5DATA1 @ hex. CAN1_F5DATA1 1b. ;
: CAN1_F6DATA0. cr ." CAN1_F6DATA0.  RW   $" CAN1_F6DATA0 @ hex. CAN1_F6DATA0 1b. ;
: CAN1_F6DATA1. cr ." CAN1_F6DATA1.  RW   $" CAN1_F6DATA1 @ hex. CAN1_F6DATA1 1b. ;
: CAN1_F7DATA0. cr ." CAN1_F7DATA0.  RW   $" CAN1_F7DATA0 @ hex. CAN1_F7DATA0 1b. ;
: CAN1_F7DATA1. cr ." CAN1_F7DATA1.  RW   $" CAN1_F7DATA1 @ hex. CAN1_F7DATA1 1b. ;
: CAN1_F8DATA0. cr ." CAN1_F8DATA0.  RW   $" CAN1_F8DATA0 @ hex. CAN1_F8DATA0 1b. ;
: CAN1_F8DATA1. cr ." CAN1_F8DATA1.  RW   $" CAN1_F8DATA1 @ hex. CAN1_F8DATA1 1b. ;
: CAN1_F9DATA0. cr ." CAN1_F9DATA0.  RW   $" CAN1_F9DATA0 @ hex. CAN1_F9DATA0 1b. ;
: CAN1_F9DATA1. cr ." CAN1_F9DATA1.  RW   $" CAN1_F9DATA1 @ hex. CAN1_F9DATA1 1b. ;
: CAN1_F10DATA0. cr ." CAN1_F10DATA0.  RW   $" CAN1_F10DATA0 @ hex. CAN1_F10DATA0 1b. ;
: CAN1_F10DATA1. cr ." CAN1_F10DATA1.  RW   $" CAN1_F10DATA1 @ hex. CAN1_F10DATA1 1b. ;
: CAN1_F11DATA0. cr ." CAN1_F11DATA0.  RW   $" CAN1_F11DATA0 @ hex. CAN1_F11DATA0 1b. ;
: CAN1_F11DATA1. cr ." CAN1_F11DATA1.  RW   $" CAN1_F11DATA1 @ hex. CAN1_F11DATA1 1b. ;
: CAN1_F12DATA0. cr ." CAN1_F12DATA0.  RW   $" CAN1_F12DATA0 @ hex. CAN1_F12DATA0 1b. ;
: CAN1_F12DATA1. cr ." CAN1_F12DATA1.  RW   $" CAN1_F12DATA1 @ hex. CAN1_F12DATA1 1b. ;
: CAN1_F13DATA0. cr ." CAN1_F13DATA0.  RW   $" CAN1_F13DATA0 @ hex. CAN1_F13DATA0 1b. ;
: CAN1_F13DATA1. cr ." CAN1_F13DATA1.  RW   $" CAN1_F13DATA1 @ hex. CAN1_F13DATA1 1b. ;
: CAN1_F14DATA0. cr ." CAN1_F14DATA0.  RW   $" CAN1_F14DATA0 @ hex. CAN1_F14DATA0 1b. ;
: CAN1_F14DATA1. cr ." CAN1_F14DATA1.  RW   $" CAN1_F14DATA1 @ hex. CAN1_F14DATA1 1b. ;
: CAN1_F15DATA0. cr ." CAN1_F15DATA0.  RW   $" CAN1_F15DATA0 @ hex. CAN1_F15DATA0 1b. ;
: CAN1_F15DATA1. cr ." CAN1_F15DATA1.  RW   $" CAN1_F15DATA1 @ hex. CAN1_F15DATA1 1b. ;
: CAN1_F16DATA0. cr ." CAN1_F16DATA0.  RW   $" CAN1_F16DATA0 @ hex. CAN1_F16DATA0 1b. ;
: CAN1_F16DATA1. cr ." CAN1_F16DATA1.  RW   $" CAN1_F16DATA1 @ hex. CAN1_F16DATA1 1b. ;
: CAN1_F17DATA0. cr ." CAN1_F17DATA0.  RW   $" CAN1_F17DATA0 @ hex. CAN1_F17DATA0 1b. ;
: CAN1_F17DATA1. cr ." CAN1_F17DATA1.  RW   $" CAN1_F17DATA1 @ hex. CAN1_F17DATA1 1b. ;
: CAN1_F18DATA0. cr ." CAN1_F18DATA0.  RW   $" CAN1_F18DATA0 @ hex. CAN1_F18DATA0 1b. ;
: CAN1_F18DATA1. cr ." CAN1_F18DATA1.  RW   $" CAN1_F18DATA1 @ hex. CAN1_F18DATA1 1b. ;
: CAN1_F19DATA0. cr ." CAN1_F19DATA0.  RW   $" CAN1_F19DATA0 @ hex. CAN1_F19DATA0 1b. ;
: CAN1_F19DATA1. cr ." CAN1_F19DATA1.  RW   $" CAN1_F19DATA1 @ hex. CAN1_F19DATA1 1b. ;
: CAN1_F20DATA0. cr ." CAN1_F20DATA0.  RW   $" CAN1_F20DATA0 @ hex. CAN1_F20DATA0 1b. ;
: CAN1_F20DATA1. cr ." CAN1_F20DATA1.  RW   $" CAN1_F20DATA1 @ hex. CAN1_F20DATA1 1b. ;
: CAN1_F21DATA0. cr ." CAN1_F21DATA0.  RW   $" CAN1_F21DATA0 @ hex. CAN1_F21DATA0 1b. ;
: CAN1_F21DATA1. cr ." CAN1_F21DATA1.  RW   $" CAN1_F21DATA1 @ hex. CAN1_F21DATA1 1b. ;
: CAN1_F22DATA0. cr ." CAN1_F22DATA0.  RW   $" CAN1_F22DATA0 @ hex. CAN1_F22DATA0 1b. ;
: CAN1_F22DATA1. cr ." CAN1_F22DATA1.  RW   $" CAN1_F22DATA1 @ hex. CAN1_F22DATA1 1b. ;
: CAN1_F23DATA0. cr ." CAN1_F23DATA0.  RW   $" CAN1_F23DATA0 @ hex. CAN1_F23DATA0 1b. ;
: CAN1_F23DATA1. cr ." CAN1_F23DATA1.  RW   $" CAN1_F23DATA1 @ hex. CAN1_F23DATA1 1b. ;
: CAN1_F24DATA0. cr ." CAN1_F24DATA0.  RW   $" CAN1_F24DATA0 @ hex. CAN1_F24DATA0 1b. ;
: CAN1_F24DATA1. cr ." CAN1_F24DATA1.  RW   $" CAN1_F24DATA1 @ hex. CAN1_F24DATA1 1b. ;
: CAN1_F25DATA0. cr ." CAN1_F25DATA0.  RW   $" CAN1_F25DATA0 @ hex. CAN1_F25DATA0 1b. ;
: CAN1_F25DATA1. cr ." CAN1_F25DATA1.  RW   $" CAN1_F25DATA1 @ hex. CAN1_F25DATA1 1b. ;
: CAN1_F26DATA0. cr ." CAN1_F26DATA0.  RW   $" CAN1_F26DATA0 @ hex. CAN1_F26DATA0 1b. ;
: CAN1_F26DATA1. cr ." CAN1_F26DATA1.  RW   $" CAN1_F26DATA1 @ hex. CAN1_F26DATA1 1b. ;
: CAN1_F27DATA0. cr ." CAN1_F27DATA0.  RW   $" CAN1_F27DATA0 @ hex. CAN1_F27DATA0 1b. ;
: CAN1_F27DATA1. cr ." CAN1_F27DATA1.  RW   $" CAN1_F27DATA1 @ hex. CAN1_F27DATA1 1b. ;
: CAN1.
CAN1_CTL.
CAN1_STAT.
CAN1_TSTAT.
CAN1_RFIFO0.
CAN1_RFIFO1.
CAN1_INTEN.
CAN1_ERR.
CAN1_BT.
CAN1_TMI0.
CAN1_TMP0.
CAN1_TMDATA00.
CAN1_TMDATA10.
CAN1_TMI1.
CAN1_TMP1.
CAN1_TMDATA01.
CAN1_TMDATA11.
CAN1_TMI2.
CAN1_TMP2.
CAN1_TMDATA02.
CAN1_TMDATA12.
CAN1_RFIFOMI0.
CAN1_RFIFOMP0.
CAN1_RFIFOMDATA00.
CAN1_RFIFOMDATA10.
CAN1_RFIFOMI1.
CAN1_RFIFOMP1.
CAN1_RFIFOMDATA01.
CAN1_RFIFOMDATA11.
CAN1_FCTL.
CAN1_FMCFG.
CAN1_FSCFG.
CAN1_FAFIFO.
CAN1_FW.
CAN1_F0DATA0.
CAN1_F0DATA1.
CAN1_F1DATA0.
CAN1_F1DATA1.
CAN1_F2DATA0.
CAN1_F2DATA1.
CAN1_F3DATA0.
CAN1_F3DATA1.
CAN1_F4DATA0.
CAN1_F4DATA1.
CAN1_F5DATA0.
CAN1_F5DATA1.
CAN1_F6DATA0.
CAN1_F6DATA1.
CAN1_F7DATA0.
CAN1_F7DATA1.
CAN1_F8DATA0.
CAN1_F8DATA1.
CAN1_F9DATA0.
CAN1_F9DATA1.
CAN1_F10DATA0.
CAN1_F10DATA1.
CAN1_F11DATA0.
CAN1_F11DATA1.
CAN1_F12DATA0.
CAN1_F12DATA1.
CAN1_F13DATA0.
CAN1_F13DATA1.
CAN1_F14DATA0.
CAN1_F14DATA1.
CAN1_F15DATA0.
CAN1_F15DATA1.
CAN1_F16DATA0.
CAN1_F16DATA1.
CAN1_F17DATA0.
CAN1_F17DATA1.
CAN1_F18DATA0.
CAN1_F18DATA1.
CAN1_F19DATA0.
CAN1_F19DATA1.
CAN1_F20DATA0.
CAN1_F20DATA1.
CAN1_F21DATA0.
CAN1_F21DATA1.
CAN1_F22DATA0.
CAN1_F22DATA1.
CAN1_F23DATA0.
CAN1_F23DATA1.
CAN1_F24DATA0.
CAN1_F24DATA1.
CAN1_F25DATA0.
CAN1_F25DATA1.
CAN1_F26DATA0.
CAN1_F26DATA1.
CAN1_F27DATA0.
CAN1_F27DATA1.
;

$40023000 constant CRC \ cyclic redundancy check calculation unit
CRC $0 + constant CRC_DATA ( read-write )  \ Data register
CRC $04 + constant CRC_FDATA ( read-write )  \ Free data register
CRC $08 + constant CRC_CTL ( read-write )  \ Control register
: CRC_DATA. cr ." CRC_DATA.  RW   $" CRC_DATA @ hex. CRC_DATA 1b. ;
: CRC_FDATA. cr ." CRC_FDATA.  RW   $" CRC_FDATA @ hex. CRC_FDATA 1b. ;
: CRC_CTL. cr ." CRC_CTL.  RW   $" CRC_CTL @ hex. CRC_CTL 1b. ;
: CRC.
CRC_DATA.
CRC_FDATA.
CRC_CTL.
;

$40007400 constant DAC \ Digital-to-analog converter
DAC $0 + constant DAC_CTL ( read-write )  \ control register
DAC $04 + constant DAC_SWT ( write-only )  \ software trigger register
DAC $08 + constant DAC_DAC0_R12DH ( read-write )  \ DAC0 12-bit right-aligned data holding register
DAC $0C + constant DAC_DAC0_L12DH ( read-write )  \ DAC0 12-bit left-aligned data holding register
DAC $10 + constant DAC_DAC0_R8DH ( read-write )  \ DAC0 8-bit right aligned data holding  register
DAC $14 + constant DAC_DAC1_R12DH ( read-write )  \ DAC1 12-bit right-aligned data holding  register
DAC $18 + constant DAC_DAC1_L12DH ( read-write )  \ DAC1 12-bit left aligned data holding  register
DAC $1C + constant DAC_DAC1_R8DH ( read-write )  \ DAC1 8-bit right aligned data holding  register
DAC $20 + constant DAC_DACC_R12DH ( read-write )  \ DAC concurrent mode 12-bit right-aligned data holding  register
DAC $24 + constant DAC_DACC_L12DH ( read-write )  \ DAC concurrent mode 12-bit left aligned data holding  register
DAC $28 + constant DAC_DACC_R8DH ( read-write )  \ DAC concurrent mode 8-bit right aligned data holding  register
DAC $2C + constant DAC_DAC0_DO ( read-only )  \ DAC0 data output register
DAC $30 + constant DAC_DAC1_DO ( read-only )  \ DAC1 data output register
: DAC_CTL. cr ." DAC_CTL.  RW   $" DAC_CTL @ hex. DAC_CTL 1b. ;
: DAC_SWT. cr ." DAC_SWT " WRITEONLY ; 
: DAC_DAC0_R12DH. cr ." DAC_DAC0_R12DH.  RW   $" DAC_DAC0_R12DH @ hex. DAC_DAC0_R12DH 1b. ;
: DAC_DAC0_L12DH. cr ." DAC_DAC0_L12DH.  RW   $" DAC_DAC0_L12DH @ hex. DAC_DAC0_L12DH 1b. ;
: DAC_DAC0_R8DH. cr ." DAC_DAC0_R8DH.  RW   $" DAC_DAC0_R8DH @ hex. DAC_DAC0_R8DH 1b. ;
: DAC_DAC1_R12DH. cr ." DAC_DAC1_R12DH.  RW   $" DAC_DAC1_R12DH @ hex. DAC_DAC1_R12DH 1b. ;
: DAC_DAC1_L12DH. cr ." DAC_DAC1_L12DH.  RW   $" DAC_DAC1_L12DH @ hex. DAC_DAC1_L12DH 1b. ;
: DAC_DAC1_R8DH. cr ." DAC_DAC1_R8DH.  RW   $" DAC_DAC1_R8DH @ hex. DAC_DAC1_R8DH 1b. ;
: DAC_DACC_R12DH. cr ." DAC_DACC_R12DH.  RW   $" DAC_DACC_R12DH @ hex. DAC_DACC_R12DH 1b. ;
: DAC_DACC_L12DH. cr ." DAC_DACC_L12DH.  RW   $" DAC_DACC_L12DH @ hex. DAC_DACC_L12DH 1b. ;
: DAC_DACC_R8DH. cr ." DAC_DACC_R8DH.  RW   $" DAC_DACC_R8DH @ hex. DAC_DACC_R8DH 1b. ;
: DAC_DAC0_DO. cr ." DAC_DAC0_DO.  RO   $" DAC_DAC0_DO @ hex. DAC_DAC0_DO 1b. ;
: DAC_DAC1_DO. cr ." DAC_DAC1_DO.  RO   $" DAC_DAC1_DO @ hex. DAC_DAC1_DO 1b. ;
: DAC.
DAC_CTL.
DAC_SWT.
DAC_DAC0_R12DH.
DAC_DAC0_L12DH.
DAC_DAC0_R8DH.
DAC_DAC1_R12DH.
DAC_DAC1_L12DH.
DAC_DAC1_R8DH.
DAC_DACC_R12DH.
DAC_DACC_L12DH.
DAC_DACC_R8DH.
DAC_DAC0_DO.
DAC_DAC1_DO.
;

$E0042000 constant DBG \ Debug support
DBG $0 + constant DBG_ID ( read-only )  \ ID code register
DBG $4 + constant DBG_CTL ( read-write )  \ Control register 0
: DBG_ID. cr ." DBG_ID.  RO   $" DBG_ID @ hex. DBG_ID 1b. ;
: DBG_CTL. cr ." DBG_CTL.  RW   $" DBG_CTL @ hex. DBG_CTL 1b. ;
: DBG.
DBG_ID.
DBG_CTL.
;

$40020000 constant DMA0 \ DMA controller
DMA0 $0 + constant DMA0_INTF ( read-only )  \ Interrupt flag register 
DMA0 $04 + constant DMA0_INTC ( write-only )  \ Interrupt flag clear register 
DMA0 $08 + constant DMA0_CH0CTL ( read-write )  \ Channel 0 control register
DMA0 $0C + constant DMA0_CH0CNT ( read-write )  \ Channel 0 counter register
DMA0 $10 + constant DMA0_CH0PADDR ( read-write )  \ Channel 0 peripheral base address register
DMA0 $14 + constant DMA0_CH0MADDR ( read-write )  \ Channel 0 memory base address register
DMA0 $1C + constant DMA0_CH1CTL ( read-write )  \ Channel 1 control register
DMA0 $20 + constant DMA0_CH1CNT ( read-write )  \ Channel 1 counter register
DMA0 $24 + constant DMA0_CH1PADDR ( read-write )  \ Channel 1 peripheral base address register
DMA0 $28 + constant DMA0_CH1MADDR ( read-write )  \ Channel 1 memory base address register
DMA0 $30 + constant DMA0_CH2CTL ( read-write )  \ Channel 2 control register
DMA0 $34 + constant DMA0_CH2CNT ( read-write )  \ Channel 2 counter register
DMA0 $38 + constant DMA0_CH2PADDR ( read-write )  \ Channel 2 peripheral base address register
DMA0 $3C + constant DMA0_CH2MADDR ( read-write )  \ Channel 2 memory base address register
DMA0 $44 + constant DMA0_CH3CTL ( read-write )  \ Channel 3 control register
DMA0 $48 + constant DMA0_CH3CNT ( read-write )  \ Channel 3 counter register
DMA0 $4C + constant DMA0_CH3PADDR ( read-write )  \ Channel 3 peripheral base address register
DMA0 $50 + constant DMA0_CH3MADDR ( read-write )  \ Channel 3 memory base address register
DMA0 $58 + constant DMA0_CH4CTL ( read-write )  \ Channel 4 control register
DMA0 $5C + constant DMA0_CH4CNT ( read-write )  \ Channel 4 counter register
DMA0 $60 + constant DMA0_CH4PADDR ( read-write )  \ Channel 4 peripheral base address register
DMA0 $64 + constant DMA0_CH4MADDR ( read-write )  \ Channel 4 memory base address register
DMA0 $6C + constant DMA0_CH5CTL ( read-write )  \ Channel 5 control register
DMA0 $70 + constant DMA0_CH5CNT ( read-write )  \ Channel 5 counter register
DMA0 $74 + constant DMA0_CH5PADDR ( read-write )  \ Channel 5 peripheral base address register
DMA0 $78 + constant DMA0_CH5MADDR ( read-write )  \ Channel 5 memory base address register
DMA0 $80 + constant DMA0_CH6CTL ( read-write )  \ Channel 6 control register
DMA0 $84 + constant DMA0_CH6CNT ( read-write )  \ Channel 6 counter register
DMA0 $88 + constant DMA0_CH6PADDR ( read-write )  \ Channel 6 peripheral base address register
DMA0 $8C + constant DMA0_CH6MADDR ( read-write )  \ Channel 6 memory base address register
: DMA0_INTF. cr ." DMA0_INTF.  RO   $" DMA0_INTF @ hex. DMA0_INTF 1b. ;
: DMA0_INTC. cr ." DMA0_INTC " WRITEONLY ; 
: DMA0_CH0CTL. cr ." DMA0_CH0CTL.  RW   $" DMA0_CH0CTL @ hex. DMA0_CH0CTL 1b. ;
: DMA0_CH0CNT. cr ." DMA0_CH0CNT.  RW   $" DMA0_CH0CNT @ hex. DMA0_CH0CNT 1b. ;
: DMA0_CH0PADDR. cr ." DMA0_CH0PADDR.  RW   $" DMA0_CH0PADDR @ hex. DMA0_CH0PADDR 1b. ;
: DMA0_CH0MADDR. cr ." DMA0_CH0MADDR.  RW   $" DMA0_CH0MADDR @ hex. DMA0_CH0MADDR 1b. ;
: DMA0_CH1CTL. cr ." DMA0_CH1CTL.  RW   $" DMA0_CH1CTL @ hex. DMA0_CH1CTL 1b. ;
: DMA0_CH1CNT. cr ." DMA0_CH1CNT.  RW   $" DMA0_CH1CNT @ hex. DMA0_CH1CNT 1b. ;
: DMA0_CH1PADDR. cr ." DMA0_CH1PADDR.  RW   $" DMA0_CH1PADDR @ hex. DMA0_CH1PADDR 1b. ;
: DMA0_CH1MADDR. cr ." DMA0_CH1MADDR.  RW   $" DMA0_CH1MADDR @ hex. DMA0_CH1MADDR 1b. ;
: DMA0_CH2CTL. cr ." DMA0_CH2CTL.  RW   $" DMA0_CH2CTL @ hex. DMA0_CH2CTL 1b. ;
: DMA0_CH2CNT. cr ." DMA0_CH2CNT.  RW   $" DMA0_CH2CNT @ hex. DMA0_CH2CNT 1b. ;
: DMA0_CH2PADDR. cr ." DMA0_CH2PADDR.  RW   $" DMA0_CH2PADDR @ hex. DMA0_CH2PADDR 1b. ;
: DMA0_CH2MADDR. cr ." DMA0_CH2MADDR.  RW   $" DMA0_CH2MADDR @ hex. DMA0_CH2MADDR 1b. ;
: DMA0_CH3CTL. cr ." DMA0_CH3CTL.  RW   $" DMA0_CH3CTL @ hex. DMA0_CH3CTL 1b. ;
: DMA0_CH3CNT. cr ." DMA0_CH3CNT.  RW   $" DMA0_CH3CNT @ hex. DMA0_CH3CNT 1b. ;
: DMA0_CH3PADDR. cr ." DMA0_CH3PADDR.  RW   $" DMA0_CH3PADDR @ hex. DMA0_CH3PADDR 1b. ;
: DMA0_CH3MADDR. cr ." DMA0_CH3MADDR.  RW   $" DMA0_CH3MADDR @ hex. DMA0_CH3MADDR 1b. ;
: DMA0_CH4CTL. cr ." DMA0_CH4CTL.  RW   $" DMA0_CH4CTL @ hex. DMA0_CH4CTL 1b. ;
: DMA0_CH4CNT. cr ." DMA0_CH4CNT.  RW   $" DMA0_CH4CNT @ hex. DMA0_CH4CNT 1b. ;
: DMA0_CH4PADDR. cr ." DMA0_CH4PADDR.  RW   $" DMA0_CH4PADDR @ hex. DMA0_CH4PADDR 1b. ;
: DMA0_CH4MADDR. cr ." DMA0_CH4MADDR.  RW   $" DMA0_CH4MADDR @ hex. DMA0_CH4MADDR 1b. ;
: DMA0_CH5CTL. cr ." DMA0_CH5CTL.  RW   $" DMA0_CH5CTL @ hex. DMA0_CH5CTL 1b. ;
: DMA0_CH5CNT. cr ." DMA0_CH5CNT.  RW   $" DMA0_CH5CNT @ hex. DMA0_CH5CNT 1b. ;
: DMA0_CH5PADDR. cr ." DMA0_CH5PADDR.  RW   $" DMA0_CH5PADDR @ hex. DMA0_CH5PADDR 1b. ;
: DMA0_CH5MADDR. cr ." DMA0_CH5MADDR.  RW   $" DMA0_CH5MADDR @ hex. DMA0_CH5MADDR 1b. ;
: DMA0_CH6CTL. cr ." DMA0_CH6CTL.  RW   $" DMA0_CH6CTL @ hex. DMA0_CH6CTL 1b. ;
: DMA0_CH6CNT. cr ." DMA0_CH6CNT.  RW   $" DMA0_CH6CNT @ hex. DMA0_CH6CNT 1b. ;
: DMA0_CH6PADDR. cr ." DMA0_CH6PADDR.  RW   $" DMA0_CH6PADDR @ hex. DMA0_CH6PADDR 1b. ;
: DMA0_CH6MADDR. cr ." DMA0_CH6MADDR.  RW   $" DMA0_CH6MADDR @ hex. DMA0_CH6MADDR 1b. ;
: DMA0.
DMA0_INTF.
DMA0_INTC.
DMA0_CH0CTL.
DMA0_CH0CNT.
DMA0_CH0PADDR.
DMA0_CH0MADDR.
DMA0_CH1CTL.
DMA0_CH1CNT.
DMA0_CH1PADDR.
DMA0_CH1MADDR.
DMA0_CH2CTL.
DMA0_CH2CNT.
DMA0_CH2PADDR.
DMA0_CH2MADDR.
DMA0_CH3CTL.
DMA0_CH3CNT.
DMA0_CH3PADDR.
DMA0_CH3MADDR.
DMA0_CH4CTL.
DMA0_CH4CNT.
DMA0_CH4PADDR.
DMA0_CH4MADDR.
DMA0_CH5CTL.
DMA0_CH5CNT.
DMA0_CH5PADDR.
DMA0_CH5MADDR.
DMA0_CH6CTL.
DMA0_CH6CNT.
DMA0_CH6PADDR.
DMA0_CH6MADDR.
;

$40020000 constant DMA1 \ Direct memory access controller
DMA1 $0 + constant DMA1_INTF ( read-only )  \ Interrupt flag register 
DMA1 $04 + constant DMA1_INTC ( write-only )  \ Interrupt flag clear register 
DMA1 $08 + constant DMA1_CH0CTL ( read-write )  \ Channel 0 control register
DMA1 $0C + constant DMA1_CH0CNT ( read-write )  \ Channel 0 counter register
DMA1 $10 + constant DMA1_CH0PADDR ( read-write )  \ Channel 0 peripheral base address register
DMA1 $14 + constant DMA1_CH0MADDR ( read-write )  \ Channel 0 memory base address register
DMA1 $1C + constant DMA1_CH1CTL ( read-write )  \ Channel 1 control register
DMA1 $20 + constant DMA1_CH1CNT ( read-write )  \ Channel 1 counter register
DMA1 $24 + constant DMA1_CH1PADDR ( read-write )  \ Channel 1 peripheral base address register
DMA1 $28 + constant DMA1_CH1MADDR ( read-write )  \ Channel 1 memory base address register
DMA1 $30 + constant DMA1_CH2CTL ( read-write )  \ Channel 2 control register
DMA1 $34 + constant DMA1_CH2CNT ( read-write )  \ Channel 2 counter register
DMA1 $38 + constant DMA1_CH2PADDR ( read-write )  \ Channel 2 peripheral base address register
DMA1 $3C + constant DMA1_CH2MADDR ( read-write )  \ Channel 2 memory base address register
DMA1 $44 + constant DMA1_CH3CTL ( read-write )  \ Channel 3 control register
DMA1 $48 + constant DMA1_CH3CNT ( read-write )  \ Channel 3 counter register
DMA1 $4C + constant DMA1_CH3PADDR ( read-write )  \ Channel 3 peripheral base address register
DMA1 $50 + constant DMA1_CH3MADDR ( read-write )  \ Channel 3 memory base address register
DMA1 $58 + constant DMA1_CH4CTL ( read-write )  \ Channel 4 control register
DMA1 $5C + constant DMA1_CH4CNT ( read-write )  \ Channel 4 counter register
DMA1 $60 + constant DMA1_CH4PADDR ( read-write )  \ Channel 4 peripheral base address register
DMA1 $64 + constant DMA1_CH4MADDR ( read-write )  \ Channel 4 memory base address register
: DMA1_INTF. cr ." DMA1_INTF.  RO   $" DMA1_INTF @ hex. DMA1_INTF 1b. ;
: DMA1_INTC. cr ." DMA1_INTC " WRITEONLY ; 
: DMA1_CH0CTL. cr ." DMA1_CH0CTL.  RW   $" DMA1_CH0CTL @ hex. DMA1_CH0CTL 1b. ;
: DMA1_CH0CNT. cr ." DMA1_CH0CNT.  RW   $" DMA1_CH0CNT @ hex. DMA1_CH0CNT 1b. ;
: DMA1_CH0PADDR. cr ." DMA1_CH0PADDR.  RW   $" DMA1_CH0PADDR @ hex. DMA1_CH0PADDR 1b. ;
: DMA1_CH0MADDR. cr ." DMA1_CH0MADDR.  RW   $" DMA1_CH0MADDR @ hex. DMA1_CH0MADDR 1b. ;
: DMA1_CH1CTL. cr ." DMA1_CH1CTL.  RW   $" DMA1_CH1CTL @ hex. DMA1_CH1CTL 1b. ;
: DMA1_CH1CNT. cr ." DMA1_CH1CNT.  RW   $" DMA1_CH1CNT @ hex. DMA1_CH1CNT 1b. ;
: DMA1_CH1PADDR. cr ." DMA1_CH1PADDR.  RW   $" DMA1_CH1PADDR @ hex. DMA1_CH1PADDR 1b. ;
: DMA1_CH1MADDR. cr ." DMA1_CH1MADDR.  RW   $" DMA1_CH1MADDR @ hex. DMA1_CH1MADDR 1b. ;
: DMA1_CH2CTL. cr ." DMA1_CH2CTL.  RW   $" DMA1_CH2CTL @ hex. DMA1_CH2CTL 1b. ;
: DMA1_CH2CNT. cr ." DMA1_CH2CNT.  RW   $" DMA1_CH2CNT @ hex. DMA1_CH2CNT 1b. ;
: DMA1_CH2PADDR. cr ." DMA1_CH2PADDR.  RW   $" DMA1_CH2PADDR @ hex. DMA1_CH2PADDR 1b. ;
: DMA1_CH2MADDR. cr ." DMA1_CH2MADDR.  RW   $" DMA1_CH2MADDR @ hex. DMA1_CH2MADDR 1b. ;
: DMA1_CH3CTL. cr ." DMA1_CH3CTL.  RW   $" DMA1_CH3CTL @ hex. DMA1_CH3CTL 1b. ;
: DMA1_CH3CNT. cr ." DMA1_CH3CNT.  RW   $" DMA1_CH3CNT @ hex. DMA1_CH3CNT 1b. ;
: DMA1_CH3PADDR. cr ." DMA1_CH3PADDR.  RW   $" DMA1_CH3PADDR @ hex. DMA1_CH3PADDR 1b. ;
: DMA1_CH3MADDR. cr ." DMA1_CH3MADDR.  RW   $" DMA1_CH3MADDR @ hex. DMA1_CH3MADDR 1b. ;
: DMA1_CH4CTL. cr ." DMA1_CH4CTL.  RW   $" DMA1_CH4CTL @ hex. DMA1_CH4CTL 1b. ;
: DMA1_CH4CNT. cr ." DMA1_CH4CNT.  RW   $" DMA1_CH4CNT @ hex. DMA1_CH4CNT 1b. ;
: DMA1_CH4PADDR. cr ." DMA1_CH4PADDR.  RW   $" DMA1_CH4PADDR @ hex. DMA1_CH4PADDR 1b. ;
: DMA1_CH4MADDR. cr ." DMA1_CH4MADDR.  RW   $" DMA1_CH4MADDR @ hex. DMA1_CH4MADDR 1b. ;
: DMA1.
DMA1_INTF.
DMA1_INTC.
DMA1_CH0CTL.
DMA1_CH0CNT.
DMA1_CH0PADDR.
DMA1_CH0MADDR.
DMA1_CH1CTL.
DMA1_CH1CNT.
DMA1_CH1PADDR.
DMA1_CH1MADDR.
DMA1_CH2CTL.
DMA1_CH2CNT.
DMA1_CH2PADDR.
DMA1_CH2MADDR.
DMA1_CH3CTL.
DMA1_CH3CNT.
DMA1_CH3PADDR.
DMA1_CH3MADDR.
DMA1_CH4CTL.
DMA1_CH4CNT.
DMA1_CH4PADDR.
DMA1_CH4MADDR.
;

$A0000000 constant EXMC \ External memory controller
EXMC $0 + constant EXMC_SNCTL0 ( read-write )  \ SRAM/NOR flash control register 0
EXMC $4 + constant EXMC_SNTCFG0 ( read-write )  \ SRAM/NOR flash timing configuration register 0
EXMC $8 + constant EXMC_SNCTL1 ( read-write )  \ SRAM/NOR flash control register 1
: EXMC_SNCTL0. cr ." EXMC_SNCTL0.  RW   $" EXMC_SNCTL0 @ hex. EXMC_SNCTL0 1b. ;
: EXMC_SNTCFG0. cr ." EXMC_SNTCFG0.  RW   $" EXMC_SNTCFG0 @ hex. EXMC_SNTCFG0 1b. ;
: EXMC_SNCTL1. cr ." EXMC_SNCTL1.  RW   $" EXMC_SNCTL1 @ hex. EXMC_SNCTL1 1b. ;
: EXMC.
EXMC_SNCTL0.
EXMC_SNTCFG0.
EXMC_SNCTL1.
;

$40010400 constant EXTI \ External interrupt/event  controller
EXTI $0 + constant EXTI_INTEN ( read-write )  \ Interrupt enable register  EXTI_INTEN
EXTI $04 + constant EXTI_EVEN ( read-write )  \ Event enable register EXTI_EVEN
EXTI $08 + constant EXTI_RTEN ( read-write )  \ Rising Edge Trigger Enable register  EXTI_RTEN
EXTI $0C + constant EXTI_FTEN ( read-write )  \ Falling Egde Trigger Enable register  EXTI_FTEN
EXTI $10 + constant EXTI_SWIEV ( read-write )  \ Software interrupt event register  EXTI_SWIEV
EXTI $14 + constant EXTI_PD ( read-write )  \ Pending register EXTI_PD
: EXTI_INTEN. cr ." EXTI_INTEN.  RW   $" EXTI_INTEN @ hex. EXTI_INTEN 1b. ;
: EXTI_EVEN. cr ." EXTI_EVEN.  RW   $" EXTI_EVEN @ hex. EXTI_EVEN 1b. ;
: EXTI_RTEN. cr ." EXTI_RTEN.  RW   $" EXTI_RTEN @ hex. EXTI_RTEN 1b. ;
: EXTI_FTEN. cr ." EXTI_FTEN.  RW   $" EXTI_FTEN @ hex. EXTI_FTEN 1b. ;
: EXTI_SWIEV. cr ." EXTI_SWIEV.  RW   $" EXTI_SWIEV @ hex. EXTI_SWIEV 1b. ;
: EXTI_PD. cr ." EXTI_PD.  RW   $" EXTI_PD @ hex. EXTI_PD 1b. ;
: EXTI.
EXTI_INTEN.
EXTI_EVEN.
EXTI_RTEN.
EXTI_FTEN.
EXTI_SWIEV.
EXTI_PD.
;

$40022000 constant FMC \ FMC
FMC $0 + constant FMC_WS ( read-write )  \ wait state counter register
FMC $04 + constant FMC_KEY0 ( write-only )  \ Unlock key register 0
FMC $08 + constant FMC_OBKEY ( write-only )  \ Option byte unlock key register
FMC $0C + constant FMC_STAT0 (  )  \ Status register 0
FMC $10 + constant FMC_CTL0 ( read-write )  \ Control register 0
FMC $14 + constant FMC_ADDR0 ( write-only )  \ Address register 0
FMC $1C + constant FMC_OBSTAT ( read-only )  \ Option byte status register
FMC $20 + constant FMC_WP ( read-only )  \ Erase/Program Protection register
FMC $100 + constant FMC_PID ( read-only )  \ Product ID register
: FMC_WS. cr ." FMC_WS.  RW   $" FMC_WS @ hex. FMC_WS 1b. ;
: FMC_KEY0. cr ." FMC_KEY0 " WRITEONLY ; 
: FMC_OBKEY. cr ." FMC_OBKEY " WRITEONLY ; 
: FMC_STAT0. cr ." FMC_STAT0.   $" FMC_STAT0 @ hex. FMC_STAT0 1b. ;
: FMC_CTL0. cr ." FMC_CTL0.  RW   $" FMC_CTL0 @ hex. FMC_CTL0 1b. ;
: FMC_ADDR0. cr ." FMC_ADDR0 " WRITEONLY ; 
: FMC_OBSTAT. cr ." FMC_OBSTAT.  RO   $" FMC_OBSTAT @ hex. FMC_OBSTAT 1b. ;
: FMC_WP. cr ." FMC_WP.  RO   $" FMC_WP @ hex. FMC_WP 1b. ;
: FMC_PID. cr ." FMC_PID.  RO   $" FMC_PID @ hex. FMC_PID 1b. ;
: FMC.
FMC_WS.
FMC_KEY0.
FMC_OBKEY.
FMC_STAT0.
FMC_CTL0.
FMC_ADDR0.
FMC_OBSTAT.
FMC_WP.
FMC_PID.
;

$40003000 constant FWDGT \ free watchdog timer
FWDGT $00 + constant FWDGT_CTL ( write-only )  \ Control register
FWDGT $04 + constant FWDGT_PSC ( read-write )  \ Prescaler register
FWDGT $08 + constant FWDGT_RLD ( read-write )  \ Reload register
FWDGT $0C + constant FWDGT_STAT ( read-only )  \ Status register
: FWDGT_CTL. cr ." FWDGT_CTL " WRITEONLY ; 
: FWDGT_PSC. cr ." FWDGT_PSC.  RW   $" FWDGT_PSC @ hex. FWDGT_PSC 1b. ;
: FWDGT_RLD. cr ." FWDGT_RLD.  RW   $" FWDGT_RLD @ hex. FWDGT_RLD 1b. ;
: FWDGT_STAT. cr ." FWDGT_STAT.  RO   $" FWDGT_STAT @ hex. FWDGT_STAT 1b. ;
: FWDGT.
FWDGT_CTL.
FWDGT_PSC.
FWDGT_RLD.
FWDGT_STAT.
;

$40010800 constant GPIOA \ General-purpose I/Os
GPIOA $0 + constant GPIOA_CTL0 ( read-write )  \ port control register 0
GPIOA $04 + constant GPIOA_CTL1 ( read-write )  \ port control register 1
GPIOA $08 + constant GPIOA_ISTAT ( read-only )  \ Port input status register
GPIOA $0C + constant GPIOA_OCTL ( read-write )  \ Port output control register
GPIOA $10 + constant GPIOA_BOP ( write-only )  \ Port bit operate register
GPIOA $14 + constant GPIOA_BC ( write-only )  \ Port bit clear register
GPIOA $18 + constant GPIOA_LOCK ( read-write )  \ GPIO port configuration lock  register
: GPIOA_CTL0. cr ." GPIOA_CTL0.  RW   $" GPIOA_CTL0 @ hex. GPIOA_CTL0;
: GPIOA_CTL1. cr ." GPIOA_CTL1.  RW   $" GPIOA_CTL1 @ hex. GPIOA_CTL1;
: GPIOA_ISTAT. cr ." GPIOA_ISTAT.  RO   $" GPIOA_ISTAT @ hex. GPIOA_ISTAT;
: GPIOA_OCTL. cr ." GPIOA_OCTL.  RW   $" GPIOA_OCTL @ hex. GPIOA_OCTL;
: GPIOA_BOP. cr ." GPIOA_BOP " WRITEONLY ; 
: GPIOA_BC. cr ." GPIOA_BC " WRITEONLY ; 
: GPIOA_LOCK. cr ." GPIOA_LOCK.  RW   $" GPIOA_LOCK @ hex. GPIOA_LOCK;
: GPIOA.
GPIOA_CTL0.
GPIOA_CTL1.
GPIOA_ISTAT.
GPIOA_OCTL.
GPIOA_BOP.
GPIOA_BC.
GPIOA_LOCK.
;

$40010C00 constant GPIOB \ General-purpose I/Os
GPIOB $0 + constant GPIOB_CTL0 ( read-write )  \ port control register 0
GPIOB $04 + constant GPIOB_CTL1 ( read-write )  \ port control register 1
GPIOB $08 + constant GPIOB_ISTAT ( read-only )  \ Port input status register
GPIOB $0C + constant GPIOB_OCTL ( read-write )  \ Port output control register
GPIOB $10 + constant GPIOB_BOP ( write-only )  \ Port bit operate register
GPIOB $14 + constant GPIOB_BC ( write-only )  \ Port bit clear register
GPIOB $18 + constant GPIOB_LOCK ( read-write )  \ GPIO port configuration lock  register
: GPIOB_CTL0. cr ." GPIOB_CTL0.  RW   $" GPIOB_CTL0 @ hex. GPIOB_CTL0;
: GPIOB_CTL1. cr ." GPIOB_CTL1.  RW   $" GPIOB_CTL1 @ hex. GPIOB_CTL1;
: GPIOB_ISTAT. cr ." GPIOB_ISTAT.  RO   $" GPIOB_ISTAT @ hex. GPIOB_ISTAT;
: GPIOB_OCTL. cr ." GPIOB_OCTL.  RW   $" GPIOB_OCTL @ hex. GPIOB_OCTL;
: GPIOB_BOP. cr ." GPIOB_BOP " WRITEONLY ; 
: GPIOB_BC. cr ." GPIOB_BC " WRITEONLY ; 
: GPIOB_LOCK. cr ." GPIOB_LOCK.  RW   $" GPIOB_LOCK @ hex. GPIOB_LOCK;
: GPIOB.
GPIOB_CTL0.
GPIOB_CTL1.
GPIOB_ISTAT.
GPIOB_OCTL.
GPIOB_BOP.
GPIOB_BC.
GPIOB_LOCK.
;

$40011000 constant GPIOC \ General-purpose I/Os
GPIOC $0 + constant GPIOC_CTL0 ( read-write )  \ port control register 0
GPIOC $04 + constant GPIOC_CTL1 ( read-write )  \ port control register 1
GPIOC $08 + constant GPIOC_ISTAT ( read-only )  \ Port input status register
GPIOC $0C + constant GPIOC_OCTL ( read-write )  \ Port output control register
GPIOC $10 + constant GPIOC_BOP ( write-only )  \ Port bit operate register
GPIOC $14 + constant GPIOC_BC ( write-only )  \ Port bit clear register
GPIOC $18 + constant GPIOC_LOCK ( read-write )  \ GPIO port configuration lock  register
: GPIOC_CTL0. cr ." GPIOC_CTL0.  RW   $" GPIOC_CTL0 @ hex. GPIOC_CTL0;
: GPIOC_CTL1. cr ." GPIOC_CTL1.  RW   $" GPIOC_CTL1 @ hex. GPIOC_CTL1;
: GPIOC_ISTAT. cr ." GPIOC_ISTAT.  RO   $" GPIOC_ISTAT @ hex. GPIOC_ISTAT;
: GPIOC_OCTL. cr ." GPIOC_OCTL.  RW   $" GPIOC_OCTL @ hex. GPIOC_OCTL;
: GPIOC_BOP. cr ." GPIOC_BOP " WRITEONLY ; 
: GPIOC_BC. cr ." GPIOC_BC " WRITEONLY ; 
: GPIOC_LOCK. cr ." GPIOC_LOCK.  RW   $" GPIOC_LOCK @ hex. GPIOC_LOCK;
: GPIOC.
GPIOC_CTL0.
GPIOC_CTL1.
GPIOC_ISTAT.
GPIOC_OCTL.
GPIOC_BOP.
GPIOC_BC.
GPIOC_LOCK.
;

$40011400 constant GPIOD \ General-purpose I/Os
GPIOD $0 + constant GPIOD_CTL0 ( read-write )  \ port control register 0
GPIOD $04 + constant GPIOD_CTL1 ( read-write )  \ port control register 1
GPIOD $08 + constant GPIOD_ISTAT ( read-only )  \ Port input status register
GPIOD $0C + constant GPIOD_OCTL ( read-write )  \ Port output control register
GPIOD $10 + constant GPIOD_BOP ( write-only )  \ Port bit operate register
GPIOD $14 + constant GPIOD_BC ( write-only )  \ Port bit clear register
GPIOD $18 + constant GPIOD_LOCK ( read-write )  \ GPIO port configuration lock  register
: GPIOD_CTL0. cr ." GPIOD_CTL0.  RW   $" GPIOD_CTL0 @ hex. GPIOD_CTL0;
: GPIOD_CTL1. cr ." GPIOD_CTL1.  RW   $" GPIOD_CTL1 @ hex. GPIOD_CTL1;
: GPIOD_ISTAT. cr ." GPIOD_ISTAT.  RO   $" GPIOD_ISTAT @ hex. GPIOD_ISTAT;
: GPIOD_OCTL. cr ." GPIOD_OCTL.  RW   $" GPIOD_OCTL @ hex. GPIOD_OCTL;
: GPIOD_BOP. cr ." GPIOD_BOP " WRITEONLY ; 
: GPIOD_BC. cr ." GPIOD_BC " WRITEONLY ; 
: GPIOD_LOCK. cr ." GPIOD_LOCK.  RW   $" GPIOD_LOCK @ hex. GPIOD_LOCK;
: GPIOD.
GPIOD_CTL0.
GPIOD_CTL1.
GPIOD_ISTAT.
GPIOD_OCTL.
GPIOD_BOP.
GPIOD_BC.
GPIOD_LOCK.
;

$40011800 constant GPIOE \ General-purpose I/Os
GPIOE $0 + constant GPIOE_CTL0 ( read-write )  \ port control register 0
GPIOE $04 + constant GPIOE_CTL1 ( read-write )  \ port control register 1
GPIOE $08 + constant GPIOE_ISTAT ( read-only )  \ Port input status register
GPIOE $0C + constant GPIOE_OCTL ( read-write )  \ Port output control register
GPIOE $10 + constant GPIOE_BOP ( write-only )  \ Port bit operate register
GPIOE $14 + constant GPIOE_BC ( write-only )  \ Port bit clear register
GPIOE $18 + constant GPIOE_LOCK ( read-write )  \ GPIO port configuration lock  register
: GPIOE_CTL0. cr ." GPIOE_CTL0.  RW   $" GPIOE_CTL0 @ hex. GPIOE_CTL0 1b. ;
: GPIOE_CTL1. cr ." GPIOE_CTL1.  RW   $" GPIOE_CTL1 @ hex. GPIOE_CTL1 1b. ;
: GPIOE_ISTAT. cr ." GPIOE_ISTAT.  RO   $" GPIOE_ISTAT @ hex. GPIOE_ISTAT 1b. ;
: GPIOE_OCTL. cr ." GPIOE_OCTL.  RW   $" GPIOE_OCTL @ hex. GPIOE_OCTL 1b. ;
: GPIOE_BOP. cr ." GPIOE_BOP " WRITEONLY ; 
: GPIOE_BC. cr ." GPIOE_BC " WRITEONLY ; 
: GPIOE_LOCK. cr ." GPIOE_LOCK.  RW   $" GPIOE_LOCK @ hex. GPIOE_LOCK 1b. ;
: GPIOE.
GPIOE_CTL0.
GPIOE_CTL1.
GPIOE_ISTAT.
GPIOE_OCTL.
GPIOE_BOP.
GPIOE_BC.
GPIOE_LOCK.
;

$40005400 constant I2C0 \ Inter integrated circuit
I2C0 $0 + constant I2C0_CTL0 ( read-write )  \ Control register 0
I2C0 $04 + constant I2C0_CTL1 ( read-write )  \ Control register 1
I2C0 $08 + constant I2C0_SADDR0 ( read-write )  \ Slave address register 0
I2C0 $0C + constant I2C0_SADDR1 ( read-write )  \ Slave address register 1
I2C0 $10 + constant I2C0_DATA ( read-write )  \ Transfer buffer register
I2C0 $14 + constant I2C0_STAT0 (  )  \ Transfer status register 0
I2C0 $18 + constant I2C0_STAT1 ( read-only )  \ Transfer status register 1
I2C0 $1C + constant I2C0_CKCFG ( read-write )  \ Clock configure register
I2C0 $20 + constant I2C0_RT ( read-write )  \ Rise time register
: I2C0_CTL0. cr ." I2C0_CTL0.  RW   $" I2C0_CTL0 @ hex. I2C0_CTL0 1b. ;
: I2C0_CTL1. cr ." I2C0_CTL1.  RW   $" I2C0_CTL1 @ hex. I2C0_CTL1 1b. ;
: I2C0_SADDR0. cr ." I2C0_SADDR0.  RW   $" I2C0_SADDR0 @ hex. I2C0_SADDR0 1b. ;
: I2C0_SADDR1. cr ." I2C0_SADDR1.  RW   $" I2C0_SADDR1 @ hex. I2C0_SADDR1 1b. ;
: I2C0_DATA. cr ." I2C0_DATA.  RW   $" I2C0_DATA @ hex. I2C0_DATA 1b. ;
: I2C0_STAT0. cr ." I2C0_STAT0.   $" I2C0_STAT0 @ hex. I2C0_STAT0 1b. ;
: I2C0_STAT1. cr ." I2C0_STAT1.  RO   $" I2C0_STAT1 @ hex. I2C0_STAT1 1b. ;
: I2C0_CKCFG. cr ." I2C0_CKCFG.  RW   $" I2C0_CKCFG @ hex. I2C0_CKCFG 1b. ;
: I2C0_RT. cr ." I2C0_RT.  RW   $" I2C0_RT @ hex. I2C0_RT 1b. ;
: I2C0.
I2C0_CTL0.
I2C0_CTL1.
I2C0_SADDR0.
I2C0_SADDR1.
I2C0_DATA.
I2C0_STAT0.
I2C0_STAT1.
I2C0_CKCFG.
I2C0_RT.
;

$40005800 constant I2C1 \ Inter integrated circuit
I2C1 $0 + constant I2C1_CTL0 ( read-write )  \ Control register 0
I2C1 $04 + constant I2C1_CTL1 ( read-write )  \ Control register 1
I2C1 $08 + constant I2C1_SADDR0 ( read-write )  \ Slave address register 0
I2C1 $0C + constant I2C1_SADDR1 ( read-write )  \ Slave address register 1
I2C1 $10 + constant I2C1_DATA ( read-write )  \ Transfer buffer register
I2C1 $14 + constant I2C1_STAT0 (  )  \ Transfer status register 0
I2C1 $18 + constant I2C1_STAT1 ( read-only )  \ Transfer status register 1
I2C1 $1C + constant I2C1_CKCFG ( read-write )  \ Clock configure register
I2C1 $20 + constant I2C1_RT ( read-write )  \ Rise time register
: I2C1_CTL0. cr ." I2C1_CTL0.  RW   $" I2C1_CTL0 @ hex. I2C1_CTL0 1b. ;
: I2C1_CTL1. cr ." I2C1_CTL1.  RW   $" I2C1_CTL1 @ hex. I2C1_CTL1 1b. ;
: I2C1_SADDR0. cr ." I2C1_SADDR0.  RW   $" I2C1_SADDR0 @ hex. I2C1_SADDR0 1b. ;
: I2C1_SADDR1. cr ." I2C1_SADDR1.  RW   $" I2C1_SADDR1 @ hex. I2C1_SADDR1 1b. ;
: I2C1_DATA. cr ." I2C1_DATA.  RW   $" I2C1_DATA @ hex. I2C1_DATA 1b. ;
: I2C1_STAT0. cr ." I2C1_STAT0.   $" I2C1_STAT0 @ hex. I2C1_STAT0 1b. ;
: I2C1_STAT1. cr ." I2C1_STAT1.  RO   $" I2C1_STAT1 @ hex. I2C1_STAT1 1b. ;
: I2C1_CKCFG. cr ." I2C1_CKCFG.  RW   $" I2C1_CKCFG @ hex. I2C1_CKCFG 1b. ;
: I2C1_RT. cr ." I2C1_RT.  RW   $" I2C1_RT @ hex. I2C1_RT 1b. ;
: I2C1.
I2C1_CTL0.
I2C1_CTL1.
I2C1_SADDR0.
I2C1_SADDR1.
I2C1_DATA.
I2C1_STAT0.
I2C1_STAT1.
I2C1_CKCFG.
I2C1_RT.
;

$D2000000 constant ECLIC \ Enhanced Core Local Interrupt Controller
ECLIC $0 + constant ECLIC_CLICCFG ( read-write )  \ cliccfg Register
ECLIC $04 + constant ECLIC_CLICINFO ( read-only )  \ clicinfo Register
ECLIC $0b + constant ECLIC_MTH ( read-write )  \ MTH Register
ECLIC $1000 + constant ECLIC_CLICINTIP_0 ( read-write )  \ clicintip Register
ECLIC $1004 + constant ECLIC_CLICINTIP_1 ( read-write )  \ clicintip Register
ECLIC $1008 + constant ECLIC_CLICINTIP_2 ( read-write )  \ clicintip Register
ECLIC $100C + constant ECLIC_CLICINTIP_3 ( read-write )  \ clicintip Register
ECLIC $1010 + constant ECLIC_CLICINTIP_4 ( read-write )  \ clicintip Register
ECLIC $1014 + constant ECLIC_CLICINTIP_5 ( read-write )  \ clicintip Register
ECLIC $1018 + constant ECLIC_CLICINTIP_6 ( read-write )  \ clicintip Register
ECLIC $101C + constant ECLIC_CLICINTIP_7 ( read-write )  \ clicintip Register
ECLIC $1020 + constant ECLIC_CLICINTIP_8 ( read-write )  \ clicintip Register
ECLIC $1024 + constant ECLIC_CLICINTIP_9 ( read-write )  \ clicintip Register
ECLIC $1028 + constant ECLIC_CLICINTIP_10 ( read-write )  \ clicintip Register
ECLIC $102C + constant ECLIC_CLICINTIP_11 ( read-write )  \ clicintip Register
ECLIC $1030 + constant ECLIC_CLICINTIP_12 ( read-write )  \ clicintip Register
ECLIC $1034 + constant ECLIC_CLICINTIP_13 ( read-write )  \ clicintip Register
ECLIC $1038 + constant ECLIC_CLICINTIP_14 ( read-write )  \ clicintip Register
ECLIC $103C + constant ECLIC_CLICINTIP_15 ( read-write )  \ clicintip Register
ECLIC $1040 + constant ECLIC_CLICINTIP_16 ( read-write )  \ clicintip Register
ECLIC $1044 + constant ECLIC_CLICINTIP_17 ( read-write )  \ clicintip Register
ECLIC $1048 + constant ECLIC_CLICINTIP_18 ( read-write )  \ clicintip Register
ECLIC $104C + constant ECLIC_CLICINTIP_19 ( read-write )  \ clicintip Register
ECLIC $1050 + constant ECLIC_CLICINTIP_20 ( read-write )  \ clicintip Register
ECLIC $1054 + constant ECLIC_CLICINTIP_21 ( read-write )  \ clicintip Register
ECLIC $1058 + constant ECLIC_CLICINTIP_22 ( read-write )  \ clicintip Register
ECLIC $105C + constant ECLIC_CLICINTIP_23 ( read-write )  \ clicintip Register
ECLIC $1060 + constant ECLIC_CLICINTIP_24 ( read-write )  \ clicintip Register
ECLIC $1064 + constant ECLIC_CLICINTIP_25 ( read-write )  \ clicintip Register
ECLIC $1068 + constant ECLIC_CLICINTIP_26 ( read-write )  \ clicintip Register
ECLIC $106C + constant ECLIC_CLICINTIP_27 ( read-write )  \ clicintip Register
ECLIC $1070 + constant ECLIC_CLICINTIP_28 ( read-write )  \ clicintip Register
ECLIC $1074 + constant ECLIC_CLICINTIP_29 ( read-write )  \ clicintip Register
ECLIC $1078 + constant ECLIC_CLICINTIP_30 ( read-write )  \ clicintip Register
ECLIC $107C + constant ECLIC_CLICINTIP_31 ( read-write )  \ clicintip Register
ECLIC $1080 + constant ECLIC_CLICINTIP_32 ( read-write )  \ clicintip Register
ECLIC $1084 + constant ECLIC_CLICINTIP_33 ( read-write )  \ clicintip Register
ECLIC $1088 + constant ECLIC_CLICINTIP_34 ( read-write )  \ clicintip Register
ECLIC $108C + constant ECLIC_CLICINTIP_35 ( read-write )  \ clicintip Register
ECLIC $1090 + constant ECLIC_CLICINTIP_36 ( read-write )  \ clicintip Register
ECLIC $1094 + constant ECLIC_CLICINTIP_37 ( read-write )  \ clicintip Register
ECLIC $1098 + constant ECLIC_CLICINTIP_38 ( read-write )  \ clicintip Register
ECLIC $109C + constant ECLIC_CLICINTIP_39 ( read-write )  \ clicintip Register
ECLIC $10A0 + constant ECLIC_CLICINTIP_40 ( read-write )  \ clicintip Register
ECLIC $10A4 + constant ECLIC_CLICINTIP_41 ( read-write )  \ clicintip Register
ECLIC $10A8 + constant ECLIC_CLICINTIP_42 ( read-write )  \ clicintip Register
ECLIC $10AC + constant ECLIC_CLICINTIP_43 ( read-write )  \ clicintip Register
ECLIC $10B0 + constant ECLIC_CLICINTIP_44 ( read-write )  \ clicintip Register
ECLIC $10B4 + constant ECLIC_CLICINTIP_45 ( read-write )  \ clicintip Register
ECLIC $10B8 + constant ECLIC_CLICINTIP_46 ( read-write )  \ clicintip Register
ECLIC $10BC + constant ECLIC_CLICINTIP_47 ( read-write )  \ clicintip Register
ECLIC $10C0 + constant ECLIC_CLICINTIP_48 ( read-write )  \ clicintip Register
ECLIC $10C4 + constant ECLIC_CLICINTIP_49 ( read-write )  \ clicintip Register
ECLIC $10C8 + constant ECLIC_CLICINTIP_50 ( read-write )  \ clicintip Register
ECLIC $10CC + constant ECLIC_CLICINTIP_51 ( read-write )  \ clicintip Register
ECLIC $10D0 + constant ECLIC_CLICINTIP_52 ( read-write )  \ clicintip Register
ECLIC $10D4 + constant ECLIC_CLICINTIP_53 ( read-write )  \ clicintip Register
ECLIC $10D8 + constant ECLIC_CLICINTIP_54 ( read-write )  \ clicintip Register
ECLIC $10DC + constant ECLIC_CLICINTIP_55 ( read-write )  \ clicintip Register
ECLIC $10E0 + constant ECLIC_CLICINTIP_56 ( read-write )  \ clicintip Register
ECLIC $10E4 + constant ECLIC_CLICINTIP_57 ( read-write )  \ clicintip Register
ECLIC $10E8 + constant ECLIC_CLICINTIP_58 ( read-write )  \ clicintip Register
ECLIC $10EC + constant ECLIC_CLICINTIP_59 ( read-write )  \ clicintip Register
ECLIC $10F0 + constant ECLIC_CLICINTIP_60 ( read-write )  \ clicintip Register
ECLIC $10F4 + constant ECLIC_CLICINTIP_61 ( read-write )  \ clicintip Register
ECLIC $10F8 + constant ECLIC_CLICINTIP_62 ( read-write )  \ clicintip Register
ECLIC $10FC + constant ECLIC_CLICINTIP_63 ( read-write )  \ clicintip Register
ECLIC $1100 + constant ECLIC_CLICINTIP_64 ( read-write )  \ clicintip Register
ECLIC $1104 + constant ECLIC_CLICINTIP_65 ( read-write )  \ clicintip Register
ECLIC $1108 + constant ECLIC_CLICINTIP_66 ( read-write )  \ clicintip Register
ECLIC $110C + constant ECLIC_CLICINTIP_67 ( read-write )  \ clicintip Register
ECLIC $1110 + constant ECLIC_CLICINTIP_68 ( read-write )  \ clicintip Register
ECLIC $1114 + constant ECLIC_CLICINTIP_69 ( read-write )  \ clicintip Register
ECLIC $1118 + constant ECLIC_CLICINTIP_70 ( read-write )  \ clicintip Register
ECLIC $111C + constant ECLIC_CLICINTIP_71 ( read-write )  \ clicintip Register
ECLIC $1120 + constant ECLIC_CLICINTIP_72 ( read-write )  \ clicintip Register
ECLIC $1124 + constant ECLIC_CLICINTIP_73 ( read-write )  \ clicintip Register
ECLIC $1128 + constant ECLIC_CLICINTIP_74 ( read-write )  \ clicintip Register
ECLIC $112C + constant ECLIC_CLICINTIP_75 ( read-write )  \ clicintip Register
ECLIC $1130 + constant ECLIC_CLICINTIP_76 ( read-write )  \ clicintip Register
ECLIC $1134 + constant ECLIC_CLICINTIP_77 ( read-write )  \ clicintip Register
ECLIC $1138 + constant ECLIC_CLICINTIP_78 ( read-write )  \ clicintip Register
ECLIC $113C + constant ECLIC_CLICINTIP_79 ( read-write )  \ clicintip Register
ECLIC $1140 + constant ECLIC_CLICINTIP_80 ( read-write )  \ clicintip Register
ECLIC $1144 + constant ECLIC_CLICINTIP_81 ( read-write )  \ clicintip Register
ECLIC $1148 + constant ECLIC_CLICINTIP_82 ( read-write )  \ clicintip Register
ECLIC $114C + constant ECLIC_CLICINTIP_83 ( read-write )  \ clicintip Register
ECLIC $1150 + constant ECLIC_CLICINTIP_84 ( read-write )  \ clicintip Register
ECLIC $1158 + constant ECLIC_CLICINTIP_85 ( read-write )  \ clicintip Register
ECLIC $115C + constant ECLIC_CLICINTIP_86 ( read-write )  \ clicintip Register
ECLIC $1001 + constant ECLIC_CLICINTIE_0 ( read-write )  \ clicintie Register
ECLIC $1005 + constant ECLIC_CLICINTIE_1 ( read-write )  \ clicintie Register
ECLIC $1009 + constant ECLIC_CLICINTIE_2 ( read-write )  \ clicintie Register
ECLIC $100D + constant ECLIC_CLICINTIE_3 ( read-write )  \ clicintie Register
ECLIC $1011 + constant ECLIC_CLICINTIE_4 ( read-write )  \ clicintie Register
ECLIC $1015 + constant ECLIC_CLICINTIE_5 ( read-write )  \ clicintie Register
ECLIC $1019 + constant ECLIC_CLICINTIE_6 ( read-write )  \ clicintie Register
ECLIC $101D + constant ECLIC_CLICINTIE_7 ( read-write )  \ clicintie Register
ECLIC $1021 + constant ECLIC_CLICINTIE_8 ( read-write )  \ clicintie Register
ECLIC $1025 + constant ECLIC_CLICINTIE_9 ( read-write )  \ clicintie Register
ECLIC $1029 + constant ECLIC_CLICINTIE_10 ( read-write )  \ clicintie Register
ECLIC $102D + constant ECLIC_CLICINTIE_11 ( read-write )  \ clicintie Register
ECLIC $1031 + constant ECLIC_CLICINTIE_12 ( read-write )  \ clicintie Register
ECLIC $1035 + constant ECLIC_CLICINTIE_13 ( read-write )  \ clicintie Register
ECLIC $1039 + constant ECLIC_CLICINTIE_14 ( read-write )  \ clicintie Register
ECLIC $103D + constant ECLIC_CLICINTIE_15 ( read-write )  \ clicintie Register
ECLIC $1041 + constant ECLIC_CLICINTIE_16 ( read-write )  \ clicintie Register
ECLIC $1045 + constant ECLIC_CLICINTIE_17 ( read-write )  \ clicintie Register
ECLIC $1049 + constant ECLIC_CLICINTIE_18 ( read-write )  \ clicintie Register
ECLIC $104D + constant ECLIC_CLICINTIE_19 ( read-write )  \ clicintie Register
ECLIC $1051 + constant ECLIC_CLICINTIE_20 ( read-write )  \ clicintie Register
ECLIC $1055 + constant ECLIC_CLICINTIE_21 ( read-write )  \ clicintie Register
ECLIC $1059 + constant ECLIC_CLICINTIE_22 ( read-write )  \ clicintie Register
ECLIC $105D + constant ECLIC_CLICINTIE_23 ( read-write )  \ clicintie Register
ECLIC $1061 + constant ECLIC_CLICINTIE_24 ( read-write )  \ clicintie Register
ECLIC $1065 + constant ECLIC_CLICINTIE_25 ( read-write )  \ clicintie Register
ECLIC $1069 + constant ECLIC_CLICINTIE_26 ( read-write )  \ clicintie Register
ECLIC $106D + constant ECLIC_CLICINTIE_27 ( read-write )  \ clicintie Register
ECLIC $1071 + constant ECLIC_CLICINTIE_28 ( read-write )  \ clicintie Register
ECLIC $1075 + constant ECLIC_CLICINTIE_29 ( read-write )  \ clicintie Register
ECLIC $1079 + constant ECLIC_CLICINTIE_30 ( read-write )  \ clicintie Register
ECLIC $107D + constant ECLIC_CLICINTIE_31 ( read-write )  \ clicintie Register
ECLIC $1081 + constant ECLIC_CLICINTIE_32 ( read-write )  \ clicintie Register
ECLIC $1085 + constant ECLIC_CLICINTIE_33 ( read-write )  \ clicintie Register
ECLIC $1089 + constant ECLIC_CLICINTIE_34 ( read-write )  \ clicintie Register
ECLIC $108D + constant ECLIC_CLICINTIE_35 ( read-write )  \ clicintie Register
ECLIC $1091 + constant ECLIC_CLICINTIE_36 ( read-write )  \ clicintie Register
ECLIC $1095 + constant ECLIC_CLICINTIE_37 ( read-write )  \ clicintie Register
ECLIC $1099 + constant ECLIC_CLICINTIE_38 ( read-write )  \ clicintie Register
ECLIC $109D + constant ECLIC_CLICINTIE_39 ( read-write )  \ clicintie Register
ECLIC $10A1 + constant ECLIC_CLICINTIE_40 ( read-write )  \ clicintie Register
ECLIC $10A5 + constant ECLIC_CLICINTIE_41 ( read-write )  \ clicintie Register
ECLIC $10A9 + constant ECLIC_CLICINTIE_42 ( read-write )  \ clicintie Register
ECLIC $10AD + constant ECLIC_CLICINTIE_43 ( read-write )  \ clicintie Register
ECLIC $10B1 + constant ECLIC_CLICINTIE_44 ( read-write )  \ clicintie Register
ECLIC $10B5 + constant ECLIC_CLICINTIE_45 ( read-write )  \ clicintie Register
ECLIC $10B9 + constant ECLIC_CLICINTIE_46 ( read-write )  \ clicintie Register
ECLIC $10BD + constant ECLIC_CLICINTIE_47 ( read-write )  \ clicintie Register
ECLIC $10C1 + constant ECLIC_CLICINTIE_48 ( read-write )  \ clicintie Register
ECLIC $10C5 + constant ECLIC_CLICINTIE_49 ( read-write )  \ clicintie Register
ECLIC $10C9 + constant ECLIC_CLICINTIE_50 ( read-write )  \ clicintie Register
ECLIC $10CD + constant ECLIC_CLICINTIE_51 ( read-write )  \ clicintie Register
ECLIC $10D1 + constant ECLIC_CLICINTIE_52 ( read-write )  \ clicintie Register
ECLIC $10D5 + constant ECLIC_CLICINTIE_53 ( read-write )  \ clicintie Register
ECLIC $10D9 + constant ECLIC_CLICINTIE_54 ( read-write )  \ clicintie Register
ECLIC $10DD + constant ECLIC_CLICINTIE_55 ( read-write )  \ clicintie Register
ECLIC $10E1 + constant ECLIC_CLICINTIE_56 ( read-write )  \ clicintie Register
ECLIC $10E5 + constant ECLIC_CLICINTIE_57 ( read-write )  \ clicintie Register
ECLIC $10E9 + constant ECLIC_CLICINTIE_58 ( read-write )  \ clicintie Register
ECLIC $10ED + constant ECLIC_CLICINTIE_59 ( read-write )  \ clicintie Register
ECLIC $10F1 + constant ECLIC_CLICINTIE_60 ( read-write )  \ clicintie Register
ECLIC $10F5 + constant ECLIC_CLICINTIE_61 ( read-write )  \ clicintie Register
ECLIC $10F9 + constant ECLIC_CLICINTIE_62 ( read-write )  \ clicintie Register
ECLIC $10FD + constant ECLIC_CLICINTIE_63 ( read-write )  \ clicintie Register
ECLIC $1101 + constant ECLIC_CLICINTIE_64 ( read-write )  \ clicintie Register
ECLIC $1105 + constant ECLIC_CLICINTIE_65 ( read-write )  \ clicintie Register
ECLIC $1109 + constant ECLIC_CLICINTIE_66 ( read-write )  \ clicintie Register
ECLIC $110D + constant ECLIC_CLICINTIE_67 ( read-write )  \ clicintie Register
ECLIC $1111 + constant ECLIC_CLICINTIE_68 ( read-write )  \ clicintie Register
ECLIC $1115 + constant ECLIC_CLICINTIE_69 ( read-write )  \ clicintie Register
ECLIC $1119 + constant ECLIC_CLICINTIE_70 ( read-write )  \ clicintie Register
ECLIC $111D + constant ECLIC_CLICINTIE_71 ( read-write )  \ clicintie Register
ECLIC $1121 + constant ECLIC_CLICINTIE_72 ( read-write )  \ clicintie Register
ECLIC $1125 + constant ECLIC_CLICINTIE_73 ( read-write )  \ clicintie Register
ECLIC $1129 + constant ECLIC_CLICINTIE_74 ( read-write )  \ clicintie Register
ECLIC $112D + constant ECLIC_CLICINTIE_75 ( read-write )  \ clicintie Register
ECLIC $1131 + constant ECLIC_CLICINTIE_76 ( read-write )  \ clicintie Register
ECLIC $1135 + constant ECLIC_CLICINTIE_77 ( read-write )  \ clicintie Register
ECLIC $1139 + constant ECLIC_CLICINTIE_78 ( read-write )  \ clicintie Register
ECLIC $113D + constant ECLIC_CLICINTIE_79 ( read-write )  \ clicintie Register
ECLIC $1141 + constant ECLIC_CLICINTIE_80 ( read-write )  \ clicintie Register
ECLIC $1145 + constant ECLIC_CLICINTIE_81 ( read-write )  \ clicintie Register
ECLIC $1149 + constant ECLIC_CLICINTIE_82 ( read-write )  \ clicintie Register
ECLIC $114D + constant ECLIC_CLICINTIE_83 ( read-write )  \ clicintie Register
ECLIC $1151 + constant ECLIC_CLICINTIE_84 ( read-write )  \ clicintie Register
ECLIC $1155 + constant ECLIC_CLICINTIE_85 ( read-write )  \ clicintie Register
ECLIC $1159 + constant ECLIC_CLICINTIE_86 ( read-write )  \ clicintie Register
ECLIC $1002 + constant ECLIC_CLICINTATTR_0 ( read-write )  \ clicintattr Register
ECLIC $1006 + constant ECLIC_CLICINTATTR_1 ( read-write )  \ clicintattr Register
ECLIC $100A + constant ECLIC_CLICINTATTR_2 ( read-write )  \ clicintattr Register
ECLIC $100E + constant ECLIC_CLICINTATTR_3 ( read-write )  \ clicintattr Register
ECLIC $1012 + constant ECLIC_CLICINTATTR_4 ( read-write )  \ clicintattr Register
ECLIC $1016 + constant ECLIC_CLICINTATTR_5 ( read-write )  \ clicintattr Register
ECLIC $101A + constant ECLIC_CLICINTATTR_6 ( read-write )  \ clicintattr Register
ECLIC $101E + constant ECLIC_CLICINTATTR_7 ( read-write )  \ clicintattr Register
ECLIC $1022 + constant ECLIC_CLICINTATTR_8 ( read-write )  \ clicintattr Register
ECLIC $1026 + constant ECLIC_CLICINTATTR_9 ( read-write )  \ clicintattr Register
ECLIC $102A + constant ECLIC_CLICINTATTR_10 ( read-write )  \ clicintattr Register
ECLIC $102E + constant ECLIC_CLICINTATTR_11 ( read-write )  \ clicintattr Register
ECLIC $1032 + constant ECLIC_CLICINTATTR_12 ( read-write )  \ clicintattr Register
ECLIC $1036 + constant ECLIC_CLICINTATTR_13 ( read-write )  \ clicintattr Register
ECLIC $103A + constant ECLIC_CLICINTATTR_14 ( read-write )  \ clicintattr Register
ECLIC $103E + constant ECLIC_CLICINTATTR_15 ( read-write )  \ clicintattr Register
ECLIC $1042 + constant ECLIC_CLICINTATTR_16 ( read-write )  \ clicintattr Register
ECLIC $1046 + constant ECLIC_CLICINTATTR_17 ( read-write )  \ clicintattr Register
ECLIC $104A + constant ECLIC_CLICINTATTR_18 ( read-write )  \ clicintattr Register
ECLIC $104E + constant ECLIC_CLICINTATTR_19 ( read-write )  \ clicintattr Register
ECLIC $1052 + constant ECLIC_CLICINTATTR_20 ( read-write )  \ clicintattr Register
ECLIC $1056 + constant ECLIC_CLICINTATTR_21 ( read-write )  \ clicintattr Register
ECLIC $105A + constant ECLIC_CLICINTATTR_22 ( read-write )  \ clicintattr Register
ECLIC $105E + constant ECLIC_CLICINTATTR_23 ( read-write )  \ clicintattr Register
ECLIC $1062 + constant ECLIC_CLICINTATTR_24 ( read-write )  \ clicintattr Register
ECLIC $1066 + constant ECLIC_CLICINTATTR_25 ( read-write )  \ clicintattr Register
ECLIC $106A + constant ECLIC_CLICINTATTR_26 ( read-write )  \ clicintattr Register
ECLIC $106E + constant ECLIC_CLICINTATTR_27 ( read-write )  \ clicintattr Register
ECLIC $1072 + constant ECLIC_CLICINTATTR_28 ( read-write )  \ clicintattr Register
ECLIC $1076 + constant ECLIC_CLICINTATTR_29 ( read-write )  \ clicintattr Register
ECLIC $107A + constant ECLIC_CLICINTATTR_30 ( read-write )  \ clicintattr Register
ECLIC $107E + constant ECLIC_CLICINTATTR_31 ( read-write )  \ clicintattr Register
ECLIC $1082 + constant ECLIC_CLICINTATTR_32 ( read-write )  \ clicintattr Register
ECLIC $1086 + constant ECLIC_CLICINTATTR_33 ( read-write )  \ clicintattr Register
ECLIC $108A + constant ECLIC_CLICINTATTR_34 ( read-write )  \ clicintattr Register
ECLIC $108E + constant ECLIC_CLICINTATTR_35 ( read-write )  \ clicintattr Register
ECLIC $1092 + constant ECLIC_CLICINTATTR_36 ( read-write )  \ clicintattr Register
ECLIC $1096 + constant ECLIC_CLICINTATTR_37 ( read-write )  \ clicintattr Register
ECLIC $109A + constant ECLIC_CLICINTATTR_38 ( read-write )  \ clicintattr Register
ECLIC $109E + constant ECLIC_CLICINTATTR_39 ( read-write )  \ clicintattr Register
ECLIC $10A2 + constant ECLIC_CLICINTATTR_40 ( read-write )  \ clicintattr Register
ECLIC $10A6 + constant ECLIC_CLICINTATTR_41 ( read-write )  \ clicintattr Register
ECLIC $10AA + constant ECLIC_CLICINTATTR_42 ( read-write )  \ clicintattr Register
ECLIC $10AE + constant ECLIC_CLICINTATTR_43 ( read-write )  \ clicintattr Register
ECLIC $10B2 + constant ECLIC_CLICINTATTR_44 ( read-write )  \ clicintattr Register
ECLIC $10B6 + constant ECLIC_CLICINTATTR_45 ( read-write )  \ clicintattr Register
ECLIC $10BA + constant ECLIC_CLICINTATTR_46 ( read-write )  \ clicintattr Register
ECLIC $10BE + constant ECLIC_CLICINTATTR_47 ( read-write )  \ clicintattr Register
ECLIC $10C2 + constant ECLIC_CLICINTATTR_48 ( read-write )  \ clicintattr Register
ECLIC $10C6 + constant ECLIC_CLICINTATTR_49 ( read-write )  \ clicintattr Register
ECLIC $10CA + constant ECLIC_CLICINTATTR_50 ( read-write )  \ clicintattr Register
ECLIC $10CE + constant ECLIC_CLICINTATTR_51 ( read-write )  \ clicintattr Register
ECLIC $10D2 + constant ECLIC_CLICINTATTR_52 ( read-write )  \ clicintattr Register
ECLIC $10D6 + constant ECLIC_CLICINTATTR_53 ( read-write )  \ clicintattr Register
ECLIC $10DA + constant ECLIC_CLICINTATTR_54 ( read-write )  \ clicintattr Register
ECLIC $10DE + constant ECLIC_CLICINTATTR_55 ( read-write )  \ clicintattr Register
ECLIC $10E2 + constant ECLIC_CLICINTATTR_56 ( read-write )  \ clicintattr Register
ECLIC $10E6 + constant ECLIC_CLICINTATTR_57 ( read-write )  \ clicintattr Register
ECLIC $10EA + constant ECLIC_CLICINTATTR_58 ( read-write )  \ clicintattr Register
ECLIC $10EE + constant ECLIC_CLICINTATTR_59 ( read-write )  \ clicintattr Register
ECLIC $10F2 + constant ECLIC_CLICINTATTR_60 ( read-write )  \ clicintattr Register
ECLIC $10F6 + constant ECLIC_CLICINTATTR_61 ( read-write )  \ clicintattr Register
ECLIC $10FA + constant ECLIC_CLICINTATTR_62 ( read-write )  \ clicintattr Register
ECLIC $10FE + constant ECLIC_CLICINTATTR_63 ( read-write )  \ clicintattr Register
ECLIC $1102 + constant ECLIC_CLICINTATTR_64 ( read-write )  \ clicintattr Register
ECLIC $1106 + constant ECLIC_CLICINTATTR_65 ( read-write )  \ clicintattr Register
ECLIC $110A + constant ECLIC_CLICINTATTR_66 ( read-write )  \ clicintattr Register
ECLIC $110E + constant ECLIC_CLICINTATTR_67 ( read-write )  \ clicintattr Register
ECLIC $1112 + constant ECLIC_CLICINTATTR_68 ( read-write )  \ clicintattr Register
ECLIC $1116 + constant ECLIC_CLICINTATTR_69 ( read-write )  \ clicintattr Register
ECLIC $111A + constant ECLIC_CLICINTATTR_70 ( read-write )  \ clicintattr Register
ECLIC $111E + constant ECLIC_CLICINTATTR_71 ( read-write )  \ clicintattr Register
ECLIC $1122 + constant ECLIC_CLICINTATTR_72 ( read-write )  \ clicintattr Register
ECLIC $1126 + constant ECLIC_CLICINTATTR_73 ( read-write )  \ clicintattr Register
ECLIC $112A + constant ECLIC_CLICINTATTR_74 ( read-write )  \ clicintattr Register
ECLIC $112E + constant ECLIC_CLICINTATTR_75 ( read-write )  \ clicintattr Register
ECLIC $1132 + constant ECLIC_CLICINTATTR_76 ( read-write )  \ clicintattr Register
ECLIC $1136 + constant ECLIC_CLICINTATTR_77 ( read-write )  \ clicintattr Register
ECLIC $113A + constant ECLIC_CLICINTATTR_78 ( read-write )  \ clicintattr Register
ECLIC $113E + constant ECLIC_CLICINTATTR_79 ( read-write )  \ clicintattr Register
ECLIC $1142 + constant ECLIC_CLICINTATTR_80 ( read-write )  \ clicintattr Register
ECLIC $1146 + constant ECLIC_CLICINTATTR_81 ( read-write )  \ clicintattr Register
ECLIC $114A + constant ECLIC_CLICINTATTR_82 ( read-write )  \ clicintattr Register
ECLIC $114E + constant ECLIC_CLICINTATTR_83 ( read-write )  \ clicintattr Register
ECLIC $1152 + constant ECLIC_CLICINTATTR_84 ( read-write )  \ clicintattr Register
ECLIC $1156 + constant ECLIC_CLICINTATTR_85 ( read-write )  \ clicintattr Register
ECLIC $115A + constant ECLIC_CLICINTATTR_86 ( read-write )  \ clicintattr Register
ECLIC $1003 + constant ECLIC_CLICINTCTL_0 ( read-write )  \ clicintctl Register
ECLIC $1007 + constant ECLIC_CLICINTCTL_1 ( read-write )  \ clicintctl Register
ECLIC $100B + constant ECLIC_CLICINTCTL_2 ( read-write )  \ clicintctl Register
ECLIC $100F + constant ECLIC_CLICINTCTL_3 ( read-write )  \ clicintctl Register
ECLIC $1013 + constant ECLIC_CLICINTCTL_4 ( read-write )  \ clicintctl Register
ECLIC $1017 + constant ECLIC_CLICINTCTL_5 ( read-write )  \ clicintctl Register
ECLIC $101B + constant ECLIC_CLICINTCTL_6 ( read-write )  \ clicintctl Register
ECLIC $101F + constant ECLIC_CLICINTCTL_7 ( read-write )  \ clicintctl Register
ECLIC $1023 + constant ECLIC_CLICINTCTL_8 ( read-write )  \ clicintctl Register
ECLIC $1027 + constant ECLIC_CLICINTCTL_9 ( read-write )  \ clicintctl Register
ECLIC $102B + constant ECLIC_CLICINTCTL_10 ( read-write )  \ clicintctl Register
ECLIC $102F + constant ECLIC_CLICINTCTL_11 ( read-write )  \ clicintctl Register
ECLIC $1033 + constant ECLIC_CLICINTCTL_12 ( read-write )  \ clicintctl Register
ECLIC $1037 + constant ECLIC_CLICINTCTL_13 ( read-write )  \ clicintctl Register
ECLIC $103B + constant ECLIC_CLICINTCTL_14 ( read-write )  \ clicintctl Register
ECLIC $103F + constant ECLIC_CLICINTCTL_15 ( read-write )  \ clicintctl Register
ECLIC $1043 + constant ECLIC_CLICINTCTL_16 ( read-write )  \ clicintctl Register
ECLIC $1047 + constant ECLIC_CLICINTCTL_17 ( read-write )  \ clicintctl Register
ECLIC $104B + constant ECLIC_CLICINTCTL_18 ( read-write )  \ clicintctl Register
ECLIC $104F + constant ECLIC_CLICINTCTL_19 ( read-write )  \ clicintctl Register
ECLIC $1053 + constant ECLIC_CLICINTCTL_20 ( read-write )  \ clicintctl Register
ECLIC $1057 + constant ECLIC_CLICINTCTL_21 ( read-write )  \ clicintctl Register
ECLIC $105B + constant ECLIC_CLICINTCTL_22 ( read-write )  \ clicintctl Register
ECLIC $105F + constant ECLIC_CLICINTCTL_23 ( read-write )  \ clicintctl Register
ECLIC $1063 + constant ECLIC_CLICINTCTL_24 ( read-write )  \ clicintctl Register
ECLIC $1067 + constant ECLIC_CLICINTCTL_25 ( read-write )  \ clicintctl Register
ECLIC $106B + constant ECLIC_CLICINTCTL_26 ( read-write )  \ clicintctl Register
ECLIC $106F + constant ECLIC_CLICINTCTL_27 ( read-write )  \ clicintctl Register
ECLIC $1073 + constant ECLIC_CLICINTCTL_28 ( read-write )  \ clicintctl Register
ECLIC $1077 + constant ECLIC_CLICINTCTL_29 ( read-write )  \ clicintctl Register
ECLIC $107B + constant ECLIC_CLICINTCTL_30 ( read-write )  \ clicintctl Register
ECLIC $107F + constant ECLIC_CLICINTCTL_31 ( read-write )  \ clicintctl Register
ECLIC $1083 + constant ECLIC_CLICINTCTL_32 ( read-write )  \ clicintctl Register
ECLIC $1087 + constant ECLIC_CLICINTCTL_33 ( read-write )  \ clicintctl Register
ECLIC $108B + constant ECLIC_CLICINTCTL_34 ( read-write )  \ clicintctl Register
ECLIC $108F + constant ECLIC_CLICINTCTL_35 ( read-write )  \ clicintctl Register
ECLIC $1093 + constant ECLIC_CLICINTCTL_36 ( read-write )  \ clicintctl Register
ECLIC $1097 + constant ECLIC_CLICINTCTL_37 ( read-write )  \ clicintctl Register
ECLIC $109B + constant ECLIC_CLICINTCTL_38 ( read-write )  \ clicintctl Register
ECLIC $109F + constant ECLIC_CLICINTCTL_39 ( read-write )  \ clicintctl Register
ECLIC $10A3 + constant ECLIC_CLICINTCTL_40 ( read-write )  \ clicintctl Register
ECLIC $10A7 + constant ECLIC_CLICINTCTL_41 ( read-write )  \ clicintctl Register
ECLIC $10AB + constant ECLIC_CLICINTCTL_42 ( read-write )  \ clicintctl Register
ECLIC $10AF + constant ECLIC_CLICINTCTL_43 ( read-write )  \ clicintctl Register
ECLIC $10B3 + constant ECLIC_CLICINTCTL_44 ( read-write )  \ clicintctl Register
ECLIC $10B7 + constant ECLIC_CLICINTCTL_45 ( read-write )  \ clicintctl Register
ECLIC $10BB + constant ECLIC_CLICINTCTL_46 ( read-write )  \ clicintctl Register
ECLIC $10BF + constant ECLIC_CLICINTCTL_47 ( read-write )  \ clicintctl Register
ECLIC $10C3 + constant ECLIC_CLICINTCTL_48 ( read-write )  \ clicintctl Register
ECLIC $10C7 + constant ECLIC_CLICINTCTL_49 ( read-write )  \ clicintctl Register
ECLIC $10CB + constant ECLIC_CLICINTCTL_50 ( read-write )  \ clicintctl Register
ECLIC $10CF + constant ECLIC_CLICINTCTL_51 ( read-write )  \ clicintctl Register
ECLIC $10D3 + constant ECLIC_CLICINTCTL_52 ( read-write )  \ clicintctl Register
ECLIC $10D7 + constant ECLIC_CLICINTCTL_53 ( read-write )  \ clicintctl Register
ECLIC $10DB + constant ECLIC_CLICINTCTL_54 ( read-write )  \ clicintctl Register
ECLIC $10DF + constant ECLIC_CLICINTCTL_55 ( read-write )  \ clicintctl Register
ECLIC $10E3 + constant ECLIC_CLICINTCTL_56 ( read-write )  \ clicintctl Register
ECLIC $10E7 + constant ECLIC_CLICINTCTL_57 ( read-write )  \ clicintctl Register
ECLIC $10EB + constant ECLIC_CLICINTCTL_58 ( read-write )  \ clicintctl Register
ECLIC $10EF + constant ECLIC_CLICINTCTL_59 ( read-write )  \ clicintctl Register
ECLIC $10F3 + constant ECLIC_CLICINTCTL_60 ( read-write )  \ clicintctl Register
ECLIC $10F7 + constant ECLIC_CLICINTCTL_61 ( read-write )  \ clicintctl Register
ECLIC $10FB + constant ECLIC_CLICINTCTL_62 ( read-write )  \ clicintctl Register
ECLIC $10FF + constant ECLIC_CLICINTCTL_63 ( read-write )  \ clicintctl Register
ECLIC $1103 + constant ECLIC_CLICINTCTL_64 ( read-write )  \ clicintctl Register
ECLIC $1107 + constant ECLIC_CLICINTCTL_65 ( read-write )  \ clicintctl Register
ECLIC $110B + constant ECLIC_CLICINTCTL_66 ( read-write )  \ clicintctl Register
ECLIC $110F + constant ECLIC_CLICINTCTL_67 ( read-write )  \ clicintctl Register
ECLIC $1113 + constant ECLIC_CLICINTCTL_68 ( read-write )  \ clicintctl Register
ECLIC $1117 + constant ECLIC_CLICINTCTL_69 ( read-write )  \ clicintctl Register
ECLIC $111B + constant ECLIC_CLICINTCTL_70 ( read-write )  \ clicintctl Register
ECLIC $111F + constant ECLIC_CLICINTCTL_71 ( read-write )  \ clicintctl Register
ECLIC $1123 + constant ECLIC_CLICINTCTL_72 ( read-write )  \ clicintctl Register
ECLIC $1127 + constant ECLIC_CLICINTCTL_73 ( read-write )  \ clicintctl Register
ECLIC $112B + constant ECLIC_CLICINTCTL_74 ( read-write )  \ clicintctl Register
ECLIC $112F + constant ECLIC_CLICINTCTL_75 ( read-write )  \ clicintctl Register
ECLIC $1133 + constant ECLIC_CLICINTCTL_76 ( read-write )  \ clicintctl Register
ECLIC $1137 + constant ECLIC_CLICINTCTL_77 ( read-write )  \ clicintctl Register
ECLIC $113B + constant ECLIC_CLICINTCTL_78 ( read-write )  \ clicintctl Register
ECLIC $113F + constant ECLIC_CLICINTCTL_79 ( read-write )  \ clicintctl Register
ECLIC $1143 + constant ECLIC_CLICINTCTL_80 ( read-write )  \ clicintctl Register
ECLIC $1147 + constant ECLIC_CLICINTCTL_81 ( read-write )  \ clicintctl Register
ECLIC $114B + constant ECLIC_CLICINTCTL_82 ( read-write )  \ clicintctl Register
ECLIC $114F + constant ECLIC_CLICINTCTL_83 ( read-write )  \ clicintctl Register
ECLIC $1153 + constant ECLIC_CLICINTCTL_84 ( read-write )  \ clicintctl Register
ECLIC $1157 + constant ECLIC_CLICINTCTL_85 ( read-write )  \ clicintctl Register
ECLIC $115B + constant ECLIC_CLICINTCTL_86 ( read-write )  \ clicintctl Register
: ECLIC_CLICCFG. cr ." ECLIC_CLICCFG.  RW   $" ECLIC_CLICCFG @ hex. ECLIC_CLICCFG 1b. ;
: ECLIC_CLICINFO. cr ." ECLIC_CLICINFO.  RO   $" ECLIC_CLICINFO @ hex. ECLIC_CLICINFO 1b. ;
: ECLIC_MTH. cr ." ECLIC_MTH.  RW   $" ECLIC_MTH @ hex. ECLIC_MTH 1b. ;
: ECLIC_CLICINTIP_0. cr ." ECLIC_CLICINTIP_0.  RW   $" ECLIC_CLICINTIP_0 @ hex. ECLIC_CLICINTIP_0 1b. ;
: ECLIC_CLICINTIP_1. cr ." ECLIC_CLICINTIP_1.  RW   $" ECLIC_CLICINTIP_1 @ hex. ECLIC_CLICINTIP_1 1b. ;
: ECLIC_CLICINTIP_2. cr ." ECLIC_CLICINTIP_2.  RW   $" ECLIC_CLICINTIP_2 @ hex. ECLIC_CLICINTIP_2 1b. ;
: ECLIC_CLICINTIP_3. cr ." ECLIC_CLICINTIP_3.  RW   $" ECLIC_CLICINTIP_3 @ hex. ECLIC_CLICINTIP_3 1b. ;
: ECLIC_CLICINTIP_4. cr ." ECLIC_CLICINTIP_4.  RW   $" ECLIC_CLICINTIP_4 @ hex. ECLIC_CLICINTIP_4 1b. ;
: ECLIC_CLICINTIP_5. cr ." ECLIC_CLICINTIP_5.  RW   $" ECLIC_CLICINTIP_5 @ hex. ECLIC_CLICINTIP_5 1b. ;
: ECLIC_CLICINTIP_6. cr ." ECLIC_CLICINTIP_6.  RW   $" ECLIC_CLICINTIP_6 @ hex. ECLIC_CLICINTIP_6 1b. ;
: ECLIC_CLICINTIP_7. cr ." ECLIC_CLICINTIP_7.  RW   $" ECLIC_CLICINTIP_7 @ hex. ECLIC_CLICINTIP_7 1b. ;
: ECLIC_CLICINTIP_8. cr ." ECLIC_CLICINTIP_8.  RW   $" ECLIC_CLICINTIP_8 @ hex. ECLIC_CLICINTIP_8 1b. ;
: ECLIC_CLICINTIP_9. cr ." ECLIC_CLICINTIP_9.  RW   $" ECLIC_CLICINTIP_9 @ hex. ECLIC_CLICINTIP_9 1b. ;
: ECLIC_CLICINTIP_10. cr ." ECLIC_CLICINTIP_10.  RW   $" ECLIC_CLICINTIP_10 @ hex. ECLIC_CLICINTIP_10 1b. ;
: ECLIC_CLICINTIP_11. cr ." ECLIC_CLICINTIP_11.  RW   $" ECLIC_CLICINTIP_11 @ hex. ECLIC_CLICINTIP_11 1b. ;
: ECLIC_CLICINTIP_12. cr ." ECLIC_CLICINTIP_12.  RW   $" ECLIC_CLICINTIP_12 @ hex. ECLIC_CLICINTIP_12 1b. ;
: ECLIC_CLICINTIP_13. cr ." ECLIC_CLICINTIP_13.  RW   $" ECLIC_CLICINTIP_13 @ hex. ECLIC_CLICINTIP_13 1b. ;
: ECLIC_CLICINTIP_14. cr ." ECLIC_CLICINTIP_14.  RW   $" ECLIC_CLICINTIP_14 @ hex. ECLIC_CLICINTIP_14 1b. ;
: ECLIC_CLICINTIP_15. cr ." ECLIC_CLICINTIP_15.  RW   $" ECLIC_CLICINTIP_15 @ hex. ECLIC_CLICINTIP_15 1b. ;
: ECLIC_CLICINTIP_16. cr ." ECLIC_CLICINTIP_16.  RW   $" ECLIC_CLICINTIP_16 @ hex. ECLIC_CLICINTIP_16 1b. ;
: ECLIC_CLICINTIP_17. cr ." ECLIC_CLICINTIP_17.  RW   $" ECLIC_CLICINTIP_17 @ hex. ECLIC_CLICINTIP_17 1b. ;
: ECLIC_CLICINTIP_18. cr ." ECLIC_CLICINTIP_18.  RW   $" ECLIC_CLICINTIP_18 @ hex. ECLIC_CLICINTIP_18 1b. ;
: ECLIC_CLICINTIP_19. cr ." ECLIC_CLICINTIP_19.  RW   $" ECLIC_CLICINTIP_19 @ hex. ECLIC_CLICINTIP_19 1b. ;
: ECLIC_CLICINTIP_20. cr ." ECLIC_CLICINTIP_20.  RW   $" ECLIC_CLICINTIP_20 @ hex. ECLIC_CLICINTIP_20 1b. ;
: ECLIC_CLICINTIP_21. cr ." ECLIC_CLICINTIP_21.  RW   $" ECLIC_CLICINTIP_21 @ hex. ECLIC_CLICINTIP_21 1b. ;
: ECLIC_CLICINTIP_22. cr ." ECLIC_CLICINTIP_22.  RW   $" ECLIC_CLICINTIP_22 @ hex. ECLIC_CLICINTIP_22 1b. ;
: ECLIC_CLICINTIP_23. cr ." ECLIC_CLICINTIP_23.  RW   $" ECLIC_CLICINTIP_23 @ hex. ECLIC_CLICINTIP_23 1b. ;
: ECLIC_CLICINTIP_24. cr ." ECLIC_CLICINTIP_24.  RW   $" ECLIC_CLICINTIP_24 @ hex. ECLIC_CLICINTIP_24 1b. ;
: ECLIC_CLICINTIP_25. cr ." ECLIC_CLICINTIP_25.  RW   $" ECLIC_CLICINTIP_25 @ hex. ECLIC_CLICINTIP_25 1b. ;
: ECLIC_CLICINTIP_26. cr ." ECLIC_CLICINTIP_26.  RW   $" ECLIC_CLICINTIP_26 @ hex. ECLIC_CLICINTIP_26 1b. ;
: ECLIC_CLICINTIP_27. cr ." ECLIC_CLICINTIP_27.  RW   $" ECLIC_CLICINTIP_27 @ hex. ECLIC_CLICINTIP_27 1b. ;
: ECLIC_CLICINTIP_28. cr ." ECLIC_CLICINTIP_28.  RW   $" ECLIC_CLICINTIP_28 @ hex. ECLIC_CLICINTIP_28 1b. ;
: ECLIC_CLICINTIP_29. cr ." ECLIC_CLICINTIP_29.  RW   $" ECLIC_CLICINTIP_29 @ hex. ECLIC_CLICINTIP_29 1b. ;
: ECLIC_CLICINTIP_30. cr ." ECLIC_CLICINTIP_30.  RW   $" ECLIC_CLICINTIP_30 @ hex. ECLIC_CLICINTIP_30 1b. ;
: ECLIC_CLICINTIP_31. cr ." ECLIC_CLICINTIP_31.  RW   $" ECLIC_CLICINTIP_31 @ hex. ECLIC_CLICINTIP_31 1b. ;
: ECLIC_CLICINTIP_32. cr ." ECLIC_CLICINTIP_32.  RW   $" ECLIC_CLICINTIP_32 @ hex. ECLIC_CLICINTIP_32 1b. ;
: ECLIC_CLICINTIP_33. cr ." ECLIC_CLICINTIP_33.  RW   $" ECLIC_CLICINTIP_33 @ hex. ECLIC_CLICINTIP_33 1b. ;
: ECLIC_CLICINTIP_34. cr ." ECLIC_CLICINTIP_34.  RW   $" ECLIC_CLICINTIP_34 @ hex. ECLIC_CLICINTIP_34 1b. ;
: ECLIC_CLICINTIP_35. cr ." ECLIC_CLICINTIP_35.  RW   $" ECLIC_CLICINTIP_35 @ hex. ECLIC_CLICINTIP_35 1b. ;
: ECLIC_CLICINTIP_36. cr ." ECLIC_CLICINTIP_36.  RW   $" ECLIC_CLICINTIP_36 @ hex. ECLIC_CLICINTIP_36 1b. ;
: ECLIC_CLICINTIP_37. cr ." ECLIC_CLICINTIP_37.  RW   $" ECLIC_CLICINTIP_37 @ hex. ECLIC_CLICINTIP_37 1b. ;
: ECLIC_CLICINTIP_38. cr ." ECLIC_CLICINTIP_38.  RW   $" ECLIC_CLICINTIP_38 @ hex. ECLIC_CLICINTIP_38 1b. ;
: ECLIC_CLICINTIP_39. cr ." ECLIC_CLICINTIP_39.  RW   $" ECLIC_CLICINTIP_39 @ hex. ECLIC_CLICINTIP_39 1b. ;
: ECLIC_CLICINTIP_40. cr ." ECLIC_CLICINTIP_40.  RW   $" ECLIC_CLICINTIP_40 @ hex. ECLIC_CLICINTIP_40 1b. ;
: ECLIC_CLICINTIP_41. cr ." ECLIC_CLICINTIP_41.  RW   $" ECLIC_CLICINTIP_41 @ hex. ECLIC_CLICINTIP_41 1b. ;
: ECLIC_CLICINTIP_42. cr ." ECLIC_CLICINTIP_42.  RW   $" ECLIC_CLICINTIP_42 @ hex. ECLIC_CLICINTIP_42 1b. ;
: ECLIC_CLICINTIP_43. cr ." ECLIC_CLICINTIP_43.  RW   $" ECLIC_CLICINTIP_43 @ hex. ECLIC_CLICINTIP_43 1b. ;
: ECLIC_CLICINTIP_44. cr ." ECLIC_CLICINTIP_44.  RW   $" ECLIC_CLICINTIP_44 @ hex. ECLIC_CLICINTIP_44 1b. ;
: ECLIC_CLICINTIP_45. cr ." ECLIC_CLICINTIP_45.  RW   $" ECLIC_CLICINTIP_45 @ hex. ECLIC_CLICINTIP_45 1b. ;
: ECLIC_CLICINTIP_46. cr ." ECLIC_CLICINTIP_46.  RW   $" ECLIC_CLICINTIP_46 @ hex. ECLIC_CLICINTIP_46 1b. ;
: ECLIC_CLICINTIP_47. cr ." ECLIC_CLICINTIP_47.  RW   $" ECLIC_CLICINTIP_47 @ hex. ECLIC_CLICINTIP_47 1b. ;
: ECLIC_CLICINTIP_48. cr ." ECLIC_CLICINTIP_48.  RW   $" ECLIC_CLICINTIP_48 @ hex. ECLIC_CLICINTIP_48 1b. ;
: ECLIC_CLICINTIP_49. cr ." ECLIC_CLICINTIP_49.  RW   $" ECLIC_CLICINTIP_49 @ hex. ECLIC_CLICINTIP_49 1b. ;
: ECLIC_CLICINTIP_50. cr ." ECLIC_CLICINTIP_50.  RW   $" ECLIC_CLICINTIP_50 @ hex. ECLIC_CLICINTIP_50 1b. ;
: ECLIC_CLICINTIP_51. cr ." ECLIC_CLICINTIP_51.  RW   $" ECLIC_CLICINTIP_51 @ hex. ECLIC_CLICINTIP_51 1b. ;
: ECLIC_CLICINTIP_52. cr ." ECLIC_CLICINTIP_52.  RW   $" ECLIC_CLICINTIP_52 @ hex. ECLIC_CLICINTIP_52 1b. ;
: ECLIC_CLICINTIP_53. cr ." ECLIC_CLICINTIP_53.  RW   $" ECLIC_CLICINTIP_53 @ hex. ECLIC_CLICINTIP_53 1b. ;
: ECLIC_CLICINTIP_54. cr ." ECLIC_CLICINTIP_54.  RW   $" ECLIC_CLICINTIP_54 @ hex. ECLIC_CLICINTIP_54 1b. ;
: ECLIC_CLICINTIP_55. cr ." ECLIC_CLICINTIP_55.  RW   $" ECLIC_CLICINTIP_55 @ hex. ECLIC_CLICINTIP_55 1b. ;
: ECLIC_CLICINTIP_56. cr ." ECLIC_CLICINTIP_56.  RW   $" ECLIC_CLICINTIP_56 @ hex. ECLIC_CLICINTIP_56 1b. ;
: ECLIC_CLICINTIP_57. cr ." ECLIC_CLICINTIP_57.  RW   $" ECLIC_CLICINTIP_57 @ hex. ECLIC_CLICINTIP_57 1b. ;
: ECLIC_CLICINTIP_58. cr ." ECLIC_CLICINTIP_58.  RW   $" ECLIC_CLICINTIP_58 @ hex. ECLIC_CLICINTIP_58 1b. ;
: ECLIC_CLICINTIP_59. cr ." ECLIC_CLICINTIP_59.  RW   $" ECLIC_CLICINTIP_59 @ hex. ECLIC_CLICINTIP_59 1b. ;
: ECLIC_CLICINTIP_60. cr ." ECLIC_CLICINTIP_60.  RW   $" ECLIC_CLICINTIP_60 @ hex. ECLIC_CLICINTIP_60 1b. ;
: ECLIC_CLICINTIP_61. cr ." ECLIC_CLICINTIP_61.  RW   $" ECLIC_CLICINTIP_61 @ hex. ECLIC_CLICINTIP_61 1b. ;
: ECLIC_CLICINTIP_62. cr ." ECLIC_CLICINTIP_62.  RW   $" ECLIC_CLICINTIP_62 @ hex. ECLIC_CLICINTIP_62 1b. ;
: ECLIC_CLICINTIP_63. cr ." ECLIC_CLICINTIP_63.  RW   $" ECLIC_CLICINTIP_63 @ hex. ECLIC_CLICINTIP_63 1b. ;
: ECLIC_CLICINTIP_64. cr ." ECLIC_CLICINTIP_64.  RW   $" ECLIC_CLICINTIP_64 @ hex. ECLIC_CLICINTIP_64 1b. ;
: ECLIC_CLICINTIP_65. cr ." ECLIC_CLICINTIP_65.  RW   $" ECLIC_CLICINTIP_65 @ hex. ECLIC_CLICINTIP_65 1b. ;
: ECLIC_CLICINTIP_66. cr ." ECLIC_CLICINTIP_66.  RW   $" ECLIC_CLICINTIP_66 @ hex. ECLIC_CLICINTIP_66 1b. ;
: ECLIC_CLICINTIP_67. cr ." ECLIC_CLICINTIP_67.  RW   $" ECLIC_CLICINTIP_67 @ hex. ECLIC_CLICINTIP_67 1b. ;
: ECLIC_CLICINTIP_68. cr ." ECLIC_CLICINTIP_68.  RW   $" ECLIC_CLICINTIP_68 @ hex. ECLIC_CLICINTIP_68 1b. ;
: ECLIC_CLICINTIP_69. cr ." ECLIC_CLICINTIP_69.  RW   $" ECLIC_CLICINTIP_69 @ hex. ECLIC_CLICINTIP_69 1b. ;
: ECLIC_CLICINTIP_70. cr ." ECLIC_CLICINTIP_70.  RW   $" ECLIC_CLICINTIP_70 @ hex. ECLIC_CLICINTIP_70 1b. ;
: ECLIC_CLICINTIP_71. cr ." ECLIC_CLICINTIP_71.  RW   $" ECLIC_CLICINTIP_71 @ hex. ECLIC_CLICINTIP_71 1b. ;
: ECLIC_CLICINTIP_72. cr ." ECLIC_CLICINTIP_72.  RW   $" ECLIC_CLICINTIP_72 @ hex. ECLIC_CLICINTIP_72 1b. ;
: ECLIC_CLICINTIP_73. cr ." ECLIC_CLICINTIP_73.  RW   $" ECLIC_CLICINTIP_73 @ hex. ECLIC_CLICINTIP_73 1b. ;
: ECLIC_CLICINTIP_74. cr ." ECLIC_CLICINTIP_74.  RW   $" ECLIC_CLICINTIP_74 @ hex. ECLIC_CLICINTIP_74 1b. ;
: ECLIC_CLICINTIP_75. cr ." ECLIC_CLICINTIP_75.  RW   $" ECLIC_CLICINTIP_75 @ hex. ECLIC_CLICINTIP_75 1b. ;
: ECLIC_CLICINTIP_76. cr ." ECLIC_CLICINTIP_76.  RW   $" ECLIC_CLICINTIP_76 @ hex. ECLIC_CLICINTIP_76 1b. ;
: ECLIC_CLICINTIP_77. cr ." ECLIC_CLICINTIP_77.  RW   $" ECLIC_CLICINTIP_77 @ hex. ECLIC_CLICINTIP_77 1b. ;
: ECLIC_CLICINTIP_78. cr ." ECLIC_CLICINTIP_78.  RW   $" ECLIC_CLICINTIP_78 @ hex. ECLIC_CLICINTIP_78 1b. ;
: ECLIC_CLICINTIP_79. cr ." ECLIC_CLICINTIP_79.  RW   $" ECLIC_CLICINTIP_79 @ hex. ECLIC_CLICINTIP_79 1b. ;
: ECLIC_CLICINTIP_80. cr ." ECLIC_CLICINTIP_80.  RW   $" ECLIC_CLICINTIP_80 @ hex. ECLIC_CLICINTIP_80 1b. ;
: ECLIC_CLICINTIP_81. cr ." ECLIC_CLICINTIP_81.  RW   $" ECLIC_CLICINTIP_81 @ hex. ECLIC_CLICINTIP_81 1b. ;
: ECLIC_CLICINTIP_82. cr ." ECLIC_CLICINTIP_82.  RW   $" ECLIC_CLICINTIP_82 @ hex. ECLIC_CLICINTIP_82 1b. ;
: ECLIC_CLICINTIP_83. cr ." ECLIC_CLICINTIP_83.  RW   $" ECLIC_CLICINTIP_83 @ hex. ECLIC_CLICINTIP_83 1b. ;
: ECLIC_CLICINTIP_84. cr ." ECLIC_CLICINTIP_84.  RW   $" ECLIC_CLICINTIP_84 @ hex. ECLIC_CLICINTIP_84 1b. ;
: ECLIC_CLICINTIP_85. cr ." ECLIC_CLICINTIP_85.  RW   $" ECLIC_CLICINTIP_85 @ hex. ECLIC_CLICINTIP_85 1b. ;
: ECLIC_CLICINTIP_86. cr ." ECLIC_CLICINTIP_86.  RW   $" ECLIC_CLICINTIP_86 @ hex. ECLIC_CLICINTIP_86 1b. ;
: ECLIC_CLICINTIE_0. cr ." ECLIC_CLICINTIE_0.  RW   $" ECLIC_CLICINTIE_0 @ hex. ECLIC_CLICINTIE_0 1b. ;
: ECLIC_CLICINTIE_1. cr ." ECLIC_CLICINTIE_1.  RW   $" ECLIC_CLICINTIE_1 @ hex. ECLIC_CLICINTIE_1 1b. ;
: ECLIC_CLICINTIE_2. cr ." ECLIC_CLICINTIE_2.  RW   $" ECLIC_CLICINTIE_2 @ hex. ECLIC_CLICINTIE_2 1b. ;
: ECLIC_CLICINTIE_3. cr ." ECLIC_CLICINTIE_3.  RW   $" ECLIC_CLICINTIE_3 @ hex. ECLIC_CLICINTIE_3 1b. ;
: ECLIC_CLICINTIE_4. cr ." ECLIC_CLICINTIE_4.  RW   $" ECLIC_CLICINTIE_4 @ hex. ECLIC_CLICINTIE_4 1b. ;
: ECLIC_CLICINTIE_5. cr ." ECLIC_CLICINTIE_5.  RW   $" ECLIC_CLICINTIE_5 @ hex. ECLIC_CLICINTIE_5 1b. ;
: ECLIC_CLICINTIE_6. cr ." ECLIC_CLICINTIE_6.  RW   $" ECLIC_CLICINTIE_6 @ hex. ECLIC_CLICINTIE_6 1b. ;
: ECLIC_CLICINTIE_7. cr ." ECLIC_CLICINTIE_7.  RW   $" ECLIC_CLICINTIE_7 @ hex. ECLIC_CLICINTIE_7 1b. ;
: ECLIC_CLICINTIE_8. cr ." ECLIC_CLICINTIE_8.  RW   $" ECLIC_CLICINTIE_8 @ hex. ECLIC_CLICINTIE_8 1b. ;
: ECLIC_CLICINTIE_9. cr ." ECLIC_CLICINTIE_9.  RW   $" ECLIC_CLICINTIE_9 @ hex. ECLIC_CLICINTIE_9 1b. ;
: ECLIC_CLICINTIE_10. cr ." ECLIC_CLICINTIE_10.  RW   $" ECLIC_CLICINTIE_10 @ hex. ECLIC_CLICINTIE_10 1b. ;
: ECLIC_CLICINTIE_11. cr ." ECLIC_CLICINTIE_11.  RW   $" ECLIC_CLICINTIE_11 @ hex. ECLIC_CLICINTIE_11 1b. ;
: ECLIC_CLICINTIE_12. cr ." ECLIC_CLICINTIE_12.  RW   $" ECLIC_CLICINTIE_12 @ hex. ECLIC_CLICINTIE_12 1b. ;
: ECLIC_CLICINTIE_13. cr ." ECLIC_CLICINTIE_13.  RW   $" ECLIC_CLICINTIE_13 @ hex. ECLIC_CLICINTIE_13 1b. ;
: ECLIC_CLICINTIE_14. cr ." ECLIC_CLICINTIE_14.  RW   $" ECLIC_CLICINTIE_14 @ hex. ECLIC_CLICINTIE_14 1b. ;
: ECLIC_CLICINTIE_15. cr ." ECLIC_CLICINTIE_15.  RW   $" ECLIC_CLICINTIE_15 @ hex. ECLIC_CLICINTIE_15 1b. ;
: ECLIC_CLICINTIE_16. cr ." ECLIC_CLICINTIE_16.  RW   $" ECLIC_CLICINTIE_16 @ hex. ECLIC_CLICINTIE_16 1b. ;
: ECLIC_CLICINTIE_17. cr ." ECLIC_CLICINTIE_17.  RW   $" ECLIC_CLICINTIE_17 @ hex. ECLIC_CLICINTIE_17 1b. ;
: ECLIC_CLICINTIE_18. cr ." ECLIC_CLICINTIE_18.  RW   $" ECLIC_CLICINTIE_18 @ hex. ECLIC_CLICINTIE_18 1b. ;
: ECLIC_CLICINTIE_19. cr ." ECLIC_CLICINTIE_19.  RW   $" ECLIC_CLICINTIE_19 @ hex. ECLIC_CLICINTIE_19 1b. ;
: ECLIC_CLICINTIE_20. cr ." ECLIC_CLICINTIE_20.  RW   $" ECLIC_CLICINTIE_20 @ hex. ECLIC_CLICINTIE_20 1b. ;
: ECLIC_CLICINTIE_21. cr ." ECLIC_CLICINTIE_21.  RW   $" ECLIC_CLICINTIE_21 @ hex. ECLIC_CLICINTIE_21 1b. ;
: ECLIC_CLICINTIE_22. cr ." ECLIC_CLICINTIE_22.  RW   $" ECLIC_CLICINTIE_22 @ hex. ECLIC_CLICINTIE_22 1b. ;
: ECLIC_CLICINTIE_23. cr ." ECLIC_CLICINTIE_23.  RW   $" ECLIC_CLICINTIE_23 @ hex. ECLIC_CLICINTIE_23 1b. ;
: ECLIC_CLICINTIE_24. cr ." ECLIC_CLICINTIE_24.  RW   $" ECLIC_CLICINTIE_24 @ hex. ECLIC_CLICINTIE_24 1b. ;
: ECLIC_CLICINTIE_25. cr ." ECLIC_CLICINTIE_25.  RW   $" ECLIC_CLICINTIE_25 @ hex. ECLIC_CLICINTIE_25 1b. ;
: ECLIC_CLICINTIE_26. cr ." ECLIC_CLICINTIE_26.  RW   $" ECLIC_CLICINTIE_26 @ hex. ECLIC_CLICINTIE_26 1b. ;
: ECLIC_CLICINTIE_27. cr ." ECLIC_CLICINTIE_27.  RW   $" ECLIC_CLICINTIE_27 @ hex. ECLIC_CLICINTIE_27 1b. ;
: ECLIC_CLICINTIE_28. cr ." ECLIC_CLICINTIE_28.  RW   $" ECLIC_CLICINTIE_28 @ hex. ECLIC_CLICINTIE_28 1b. ;
: ECLIC_CLICINTIE_29. cr ." ECLIC_CLICINTIE_29.  RW   $" ECLIC_CLICINTIE_29 @ hex. ECLIC_CLICINTIE_29 1b. ;
: ECLIC_CLICINTIE_30. cr ." ECLIC_CLICINTIE_30.  RW   $" ECLIC_CLICINTIE_30 @ hex. ECLIC_CLICINTIE_30 1b. ;
: ECLIC_CLICINTIE_31. cr ." ECLIC_CLICINTIE_31.  RW   $" ECLIC_CLICINTIE_31 @ hex. ECLIC_CLICINTIE_31 1b. ;
: ECLIC_CLICINTIE_32. cr ." ECLIC_CLICINTIE_32.  RW   $" ECLIC_CLICINTIE_32 @ hex. ECLIC_CLICINTIE_32 1b. ;
: ECLIC_CLICINTIE_33. cr ." ECLIC_CLICINTIE_33.  RW   $" ECLIC_CLICINTIE_33 @ hex. ECLIC_CLICINTIE_33 1b. ;
: ECLIC_CLICINTIE_34. cr ." ECLIC_CLICINTIE_34.  RW   $" ECLIC_CLICINTIE_34 @ hex. ECLIC_CLICINTIE_34 1b. ;
: ECLIC_CLICINTIE_35. cr ." ECLIC_CLICINTIE_35.  RW   $" ECLIC_CLICINTIE_35 @ hex. ECLIC_CLICINTIE_35 1b. ;
: ECLIC_CLICINTIE_36. cr ." ECLIC_CLICINTIE_36.  RW   $" ECLIC_CLICINTIE_36 @ hex. ECLIC_CLICINTIE_36 1b. ;
: ECLIC_CLICINTIE_37. cr ." ECLIC_CLICINTIE_37.  RW   $" ECLIC_CLICINTIE_37 @ hex. ECLIC_CLICINTIE_37 1b. ;
: ECLIC_CLICINTIE_38. cr ." ECLIC_CLICINTIE_38.  RW   $" ECLIC_CLICINTIE_38 @ hex. ECLIC_CLICINTIE_38 1b. ;
: ECLIC_CLICINTIE_39. cr ." ECLIC_CLICINTIE_39.  RW   $" ECLIC_CLICINTIE_39 @ hex. ECLIC_CLICINTIE_39 1b. ;
: ECLIC_CLICINTIE_40. cr ." ECLIC_CLICINTIE_40.  RW   $" ECLIC_CLICINTIE_40 @ hex. ECLIC_CLICINTIE_40 1b. ;
: ECLIC_CLICINTIE_41. cr ." ECLIC_CLICINTIE_41.  RW   $" ECLIC_CLICINTIE_41 @ hex. ECLIC_CLICINTIE_41 1b. ;
: ECLIC_CLICINTIE_42. cr ." ECLIC_CLICINTIE_42.  RW   $" ECLIC_CLICINTIE_42 @ hex. ECLIC_CLICINTIE_42 1b. ;
: ECLIC_CLICINTIE_43. cr ." ECLIC_CLICINTIE_43.  RW   $" ECLIC_CLICINTIE_43 @ hex. ECLIC_CLICINTIE_43 1b. ;
: ECLIC_CLICINTIE_44. cr ." ECLIC_CLICINTIE_44.  RW   $" ECLIC_CLICINTIE_44 @ hex. ECLIC_CLICINTIE_44 1b. ;
: ECLIC_CLICINTIE_45. cr ." ECLIC_CLICINTIE_45.  RW   $" ECLIC_CLICINTIE_45 @ hex. ECLIC_CLICINTIE_45 1b. ;
: ECLIC_CLICINTIE_46. cr ." ECLIC_CLICINTIE_46.  RW   $" ECLIC_CLICINTIE_46 @ hex. ECLIC_CLICINTIE_46 1b. ;
: ECLIC_CLICINTIE_47. cr ." ECLIC_CLICINTIE_47.  RW   $" ECLIC_CLICINTIE_47 @ hex. ECLIC_CLICINTIE_47 1b. ;
: ECLIC_CLICINTIE_48. cr ." ECLIC_CLICINTIE_48.  RW   $" ECLIC_CLICINTIE_48 @ hex. ECLIC_CLICINTIE_48 1b. ;
: ECLIC_CLICINTIE_49. cr ." ECLIC_CLICINTIE_49.  RW   $" ECLIC_CLICINTIE_49 @ hex. ECLIC_CLICINTIE_49 1b. ;
: ECLIC_CLICINTIE_50. cr ." ECLIC_CLICINTIE_50.  RW   $" ECLIC_CLICINTIE_50 @ hex. ECLIC_CLICINTIE_50 1b. ;
: ECLIC_CLICINTIE_51. cr ." ECLIC_CLICINTIE_51.  RW   $" ECLIC_CLICINTIE_51 @ hex. ECLIC_CLICINTIE_51 1b. ;
: ECLIC_CLICINTIE_52. cr ." ECLIC_CLICINTIE_52.  RW   $" ECLIC_CLICINTIE_52 @ hex. ECLIC_CLICINTIE_52 1b. ;
: ECLIC_CLICINTIE_53. cr ." ECLIC_CLICINTIE_53.  RW   $" ECLIC_CLICINTIE_53 @ hex. ECLIC_CLICINTIE_53 1b. ;
: ECLIC_CLICINTIE_54. cr ." ECLIC_CLICINTIE_54.  RW   $" ECLIC_CLICINTIE_54 @ hex. ECLIC_CLICINTIE_54 1b. ;
: ECLIC_CLICINTIE_55. cr ." ECLIC_CLICINTIE_55.  RW   $" ECLIC_CLICINTIE_55 @ hex. ECLIC_CLICINTIE_55 1b. ;
: ECLIC_CLICINTIE_56. cr ." ECLIC_CLICINTIE_56.  RW   $" ECLIC_CLICINTIE_56 @ hex. ECLIC_CLICINTIE_56 1b. ;
: ECLIC_CLICINTIE_57. cr ." ECLIC_CLICINTIE_57.  RW   $" ECLIC_CLICINTIE_57 @ hex. ECLIC_CLICINTIE_57 1b. ;
: ECLIC_CLICINTIE_58. cr ." ECLIC_CLICINTIE_58.  RW   $" ECLIC_CLICINTIE_58 @ hex. ECLIC_CLICINTIE_58 1b. ;
: ECLIC_CLICINTIE_59. cr ." ECLIC_CLICINTIE_59.  RW   $" ECLIC_CLICINTIE_59 @ hex. ECLIC_CLICINTIE_59 1b. ;
: ECLIC_CLICINTIE_60. cr ." ECLIC_CLICINTIE_60.  RW   $" ECLIC_CLICINTIE_60 @ hex. ECLIC_CLICINTIE_60 1b. ;
: ECLIC_CLICINTIE_61. cr ." ECLIC_CLICINTIE_61.  RW   $" ECLIC_CLICINTIE_61 @ hex. ECLIC_CLICINTIE_61 1b. ;
: ECLIC_CLICINTIE_62. cr ." ECLIC_CLICINTIE_62.  RW   $" ECLIC_CLICINTIE_62 @ hex. ECLIC_CLICINTIE_62 1b. ;
: ECLIC_CLICINTIE_63. cr ." ECLIC_CLICINTIE_63.  RW   $" ECLIC_CLICINTIE_63 @ hex. ECLIC_CLICINTIE_63 1b. ;
: ECLIC_CLICINTIE_64. cr ." ECLIC_CLICINTIE_64.  RW   $" ECLIC_CLICINTIE_64 @ hex. ECLIC_CLICINTIE_64 1b. ;
: ECLIC_CLICINTIE_65. cr ." ECLIC_CLICINTIE_65.  RW   $" ECLIC_CLICINTIE_65 @ hex. ECLIC_CLICINTIE_65 1b. ;
: ECLIC_CLICINTIE_66. cr ." ECLIC_CLICINTIE_66.  RW   $" ECLIC_CLICINTIE_66 @ hex. ECLIC_CLICINTIE_66 1b. ;
: ECLIC_CLICINTIE_67. cr ." ECLIC_CLICINTIE_67.  RW   $" ECLIC_CLICINTIE_67 @ hex. ECLIC_CLICINTIE_67 1b. ;
: ECLIC_CLICINTIE_68. cr ." ECLIC_CLICINTIE_68.  RW   $" ECLIC_CLICINTIE_68 @ hex. ECLIC_CLICINTIE_68 1b. ;
: ECLIC_CLICINTIE_69. cr ." ECLIC_CLICINTIE_69.  RW   $" ECLIC_CLICINTIE_69 @ hex. ECLIC_CLICINTIE_69 1b. ;
: ECLIC_CLICINTIE_70. cr ." ECLIC_CLICINTIE_70.  RW   $" ECLIC_CLICINTIE_70 @ hex. ECLIC_CLICINTIE_70 1b. ;
: ECLIC_CLICINTIE_71. cr ." ECLIC_CLICINTIE_71.  RW   $" ECLIC_CLICINTIE_71 @ hex. ECLIC_CLICINTIE_71 1b. ;
: ECLIC_CLICINTIE_72. cr ." ECLIC_CLICINTIE_72.  RW   $" ECLIC_CLICINTIE_72 @ hex. ECLIC_CLICINTIE_72 1b. ;
: ECLIC_CLICINTIE_73. cr ." ECLIC_CLICINTIE_73.  RW   $" ECLIC_CLICINTIE_73 @ hex. ECLIC_CLICINTIE_73 1b. ;
: ECLIC_CLICINTIE_74. cr ." ECLIC_CLICINTIE_74.  RW   $" ECLIC_CLICINTIE_74 @ hex. ECLIC_CLICINTIE_74 1b. ;
: ECLIC_CLICINTIE_75. cr ." ECLIC_CLICINTIE_75.  RW   $" ECLIC_CLICINTIE_75 @ hex. ECLIC_CLICINTIE_75 1b. ;
: ECLIC_CLICINTIE_76. cr ." ECLIC_CLICINTIE_76.  RW   $" ECLIC_CLICINTIE_76 @ hex. ECLIC_CLICINTIE_76 1b. ;
: ECLIC_CLICINTIE_77. cr ." ECLIC_CLICINTIE_77.  RW   $" ECLIC_CLICINTIE_77 @ hex. ECLIC_CLICINTIE_77 1b. ;
: ECLIC_CLICINTIE_78. cr ." ECLIC_CLICINTIE_78.  RW   $" ECLIC_CLICINTIE_78 @ hex. ECLIC_CLICINTIE_78 1b. ;
: ECLIC_CLICINTIE_79. cr ." ECLIC_CLICINTIE_79.  RW   $" ECLIC_CLICINTIE_79 @ hex. ECLIC_CLICINTIE_79 1b. ;
: ECLIC_CLICINTIE_80. cr ." ECLIC_CLICINTIE_80.  RW   $" ECLIC_CLICINTIE_80 @ hex. ECLIC_CLICINTIE_80 1b. ;
: ECLIC_CLICINTIE_81. cr ." ECLIC_CLICINTIE_81.  RW   $" ECLIC_CLICINTIE_81 @ hex. ECLIC_CLICINTIE_81 1b. ;
: ECLIC_CLICINTIE_82. cr ." ECLIC_CLICINTIE_82.  RW   $" ECLIC_CLICINTIE_82 @ hex. ECLIC_CLICINTIE_82 1b. ;
: ECLIC_CLICINTIE_83. cr ." ECLIC_CLICINTIE_83.  RW   $" ECLIC_CLICINTIE_83 @ hex. ECLIC_CLICINTIE_83 1b. ;
: ECLIC_CLICINTIE_84. cr ." ECLIC_CLICINTIE_84.  RW   $" ECLIC_CLICINTIE_84 @ hex. ECLIC_CLICINTIE_84 1b. ;
: ECLIC_CLICINTIE_85. cr ." ECLIC_CLICINTIE_85.  RW   $" ECLIC_CLICINTIE_85 @ hex. ECLIC_CLICINTIE_85 1b. ;
: ECLIC_CLICINTIE_86. cr ." ECLIC_CLICINTIE_86.  RW   $" ECLIC_CLICINTIE_86 @ hex. ECLIC_CLICINTIE_86 1b. ;
: ECLIC_CLICINTATTR_0. cr ." ECLIC_CLICINTATTR_0.  RW   $" ECLIC_CLICINTATTR_0 @ hex. ECLIC_CLICINTATTR_0 1b. ;
: ECLIC_CLICINTATTR_1. cr ." ECLIC_CLICINTATTR_1.  RW   $" ECLIC_CLICINTATTR_1 @ hex. ECLIC_CLICINTATTR_1 1b. ;
: ECLIC_CLICINTATTR_2. cr ." ECLIC_CLICINTATTR_2.  RW   $" ECLIC_CLICINTATTR_2 @ hex. ECLIC_CLICINTATTR_2 1b. ;
: ECLIC_CLICINTATTR_3. cr ." ECLIC_CLICINTATTR_3.  RW   $" ECLIC_CLICINTATTR_3 @ hex. ECLIC_CLICINTATTR_3 1b. ;
: ECLIC_CLICINTATTR_4. cr ." ECLIC_CLICINTATTR_4.  RW   $" ECLIC_CLICINTATTR_4 @ hex. ECLIC_CLICINTATTR_4 1b. ;
: ECLIC_CLICINTATTR_5. cr ." ECLIC_CLICINTATTR_5.  RW   $" ECLIC_CLICINTATTR_5 @ hex. ECLIC_CLICINTATTR_5 1b. ;
: ECLIC_CLICINTATTR_6. cr ." ECLIC_CLICINTATTR_6.  RW   $" ECLIC_CLICINTATTR_6 @ hex. ECLIC_CLICINTATTR_6 1b. ;
: ECLIC_CLICINTATTR_7. cr ." ECLIC_CLICINTATTR_7.  RW   $" ECLIC_CLICINTATTR_7 @ hex. ECLIC_CLICINTATTR_7 1b. ;
: ECLIC_CLICINTATTR_8. cr ." ECLIC_CLICINTATTR_8.  RW   $" ECLIC_CLICINTATTR_8 @ hex. ECLIC_CLICINTATTR_8 1b. ;
: ECLIC_CLICINTATTR_9. cr ." ECLIC_CLICINTATTR_9.  RW   $" ECLIC_CLICINTATTR_9 @ hex. ECLIC_CLICINTATTR_9 1b. ;
: ECLIC_CLICINTATTR_10. cr ." ECLIC_CLICINTATTR_10.  RW   $" ECLIC_CLICINTATTR_10 @ hex. ECLIC_CLICINTATTR_10 1b. ;
: ECLIC_CLICINTATTR_11. cr ." ECLIC_CLICINTATTR_11.  RW   $" ECLIC_CLICINTATTR_11 @ hex. ECLIC_CLICINTATTR_11 1b. ;
: ECLIC_CLICINTATTR_12. cr ." ECLIC_CLICINTATTR_12.  RW   $" ECLIC_CLICINTATTR_12 @ hex. ECLIC_CLICINTATTR_12 1b. ;
: ECLIC_CLICINTATTR_13. cr ." ECLIC_CLICINTATTR_13.  RW   $" ECLIC_CLICINTATTR_13 @ hex. ECLIC_CLICINTATTR_13 1b. ;
: ECLIC_CLICINTATTR_14. cr ." ECLIC_CLICINTATTR_14.  RW   $" ECLIC_CLICINTATTR_14 @ hex. ECLIC_CLICINTATTR_14 1b. ;
: ECLIC_CLICINTATTR_15. cr ." ECLIC_CLICINTATTR_15.  RW   $" ECLIC_CLICINTATTR_15 @ hex. ECLIC_CLICINTATTR_15 1b. ;
: ECLIC_CLICINTATTR_16. cr ." ECLIC_CLICINTATTR_16.  RW   $" ECLIC_CLICINTATTR_16 @ hex. ECLIC_CLICINTATTR_16 1b. ;
: ECLIC_CLICINTATTR_17. cr ." ECLIC_CLICINTATTR_17.  RW   $" ECLIC_CLICINTATTR_17 @ hex. ECLIC_CLICINTATTR_17 1b. ;
: ECLIC_CLICINTATTR_18. cr ." ECLIC_CLICINTATTR_18.  RW   $" ECLIC_CLICINTATTR_18 @ hex. ECLIC_CLICINTATTR_18 1b. ;
: ECLIC_CLICINTATTR_19. cr ." ECLIC_CLICINTATTR_19.  RW   $" ECLIC_CLICINTATTR_19 @ hex. ECLIC_CLICINTATTR_19 1b. ;
: ECLIC_CLICINTATTR_20. cr ." ECLIC_CLICINTATTR_20.  RW   $" ECLIC_CLICINTATTR_20 @ hex. ECLIC_CLICINTATTR_20 1b. ;
: ECLIC_CLICINTATTR_21. cr ." ECLIC_CLICINTATTR_21.  RW   $" ECLIC_CLICINTATTR_21 @ hex. ECLIC_CLICINTATTR_21 1b. ;
: ECLIC_CLICINTATTR_22. cr ." ECLIC_CLICINTATTR_22.  RW   $" ECLIC_CLICINTATTR_22 @ hex. ECLIC_CLICINTATTR_22 1b. ;
: ECLIC_CLICINTATTR_23. cr ." ECLIC_CLICINTATTR_23.  RW   $" ECLIC_CLICINTATTR_23 @ hex. ECLIC_CLICINTATTR_23 1b. ;
: ECLIC_CLICINTATTR_24. cr ." ECLIC_CLICINTATTR_24.  RW   $" ECLIC_CLICINTATTR_24 @ hex. ECLIC_CLICINTATTR_24 1b. ;
: ECLIC_CLICINTATTR_25. cr ." ECLIC_CLICINTATTR_25.  RW   $" ECLIC_CLICINTATTR_25 @ hex. ECLIC_CLICINTATTR_25 1b. ;
: ECLIC_CLICINTATTR_26. cr ." ECLIC_CLICINTATTR_26.  RW   $" ECLIC_CLICINTATTR_26 @ hex. ECLIC_CLICINTATTR_26 1b. ;
: ECLIC_CLICINTATTR_27. cr ." ECLIC_CLICINTATTR_27.  RW   $" ECLIC_CLICINTATTR_27 @ hex. ECLIC_CLICINTATTR_27 1b. ;
: ECLIC_CLICINTATTR_28. cr ." ECLIC_CLICINTATTR_28.  RW   $" ECLIC_CLICINTATTR_28 @ hex. ECLIC_CLICINTATTR_28 1b. ;
: ECLIC_CLICINTATTR_29. cr ." ECLIC_CLICINTATTR_29.  RW   $" ECLIC_CLICINTATTR_29 @ hex. ECLIC_CLICINTATTR_29 1b. ;
: ECLIC_CLICINTATTR_30. cr ." ECLIC_CLICINTATTR_30.  RW   $" ECLIC_CLICINTATTR_30 @ hex. ECLIC_CLICINTATTR_30 1b. ;
: ECLIC_CLICINTATTR_31. cr ." ECLIC_CLICINTATTR_31.  RW   $" ECLIC_CLICINTATTR_31 @ hex. ECLIC_CLICINTATTR_31 1b. ;
: ECLIC_CLICINTATTR_32. cr ." ECLIC_CLICINTATTR_32.  RW   $" ECLIC_CLICINTATTR_32 @ hex. ECLIC_CLICINTATTR_32 1b. ;
: ECLIC_CLICINTATTR_33. cr ." ECLIC_CLICINTATTR_33.  RW   $" ECLIC_CLICINTATTR_33 @ hex. ECLIC_CLICINTATTR_33 1b. ;
: ECLIC_CLICINTATTR_34. cr ." ECLIC_CLICINTATTR_34.  RW   $" ECLIC_CLICINTATTR_34 @ hex. ECLIC_CLICINTATTR_34 1b. ;
: ECLIC_CLICINTATTR_35. cr ." ECLIC_CLICINTATTR_35.  RW   $" ECLIC_CLICINTATTR_35 @ hex. ECLIC_CLICINTATTR_35 1b. ;
: ECLIC_CLICINTATTR_36. cr ." ECLIC_CLICINTATTR_36.  RW   $" ECLIC_CLICINTATTR_36 @ hex. ECLIC_CLICINTATTR_36 1b. ;
: ECLIC_CLICINTATTR_37. cr ." ECLIC_CLICINTATTR_37.  RW   $" ECLIC_CLICINTATTR_37 @ hex. ECLIC_CLICINTATTR_37 1b. ;
: ECLIC_CLICINTATTR_38. cr ." ECLIC_CLICINTATTR_38.  RW   $" ECLIC_CLICINTATTR_38 @ hex. ECLIC_CLICINTATTR_38 1b. ;
: ECLIC_CLICINTATTR_39. cr ." ECLIC_CLICINTATTR_39.  RW   $" ECLIC_CLICINTATTR_39 @ hex. ECLIC_CLICINTATTR_39 1b. ;
: ECLIC_CLICINTATTR_40. cr ." ECLIC_CLICINTATTR_40.  RW   $" ECLIC_CLICINTATTR_40 @ hex. ECLIC_CLICINTATTR_40 1b. ;
: ECLIC_CLICINTATTR_41. cr ." ECLIC_CLICINTATTR_41.  RW   $" ECLIC_CLICINTATTR_41 @ hex. ECLIC_CLICINTATTR_41 1b. ;
: ECLIC_CLICINTATTR_42. cr ." ECLIC_CLICINTATTR_42.  RW   $" ECLIC_CLICINTATTR_42 @ hex. ECLIC_CLICINTATTR_42 1b. ;
: ECLIC_CLICINTATTR_43. cr ." ECLIC_CLICINTATTR_43.  RW   $" ECLIC_CLICINTATTR_43 @ hex. ECLIC_CLICINTATTR_43 1b. ;
: ECLIC_CLICINTATTR_44. cr ." ECLIC_CLICINTATTR_44.  RW   $" ECLIC_CLICINTATTR_44 @ hex. ECLIC_CLICINTATTR_44 1b. ;
: ECLIC_CLICINTATTR_45. cr ." ECLIC_CLICINTATTR_45.  RW   $" ECLIC_CLICINTATTR_45 @ hex. ECLIC_CLICINTATTR_45 1b. ;
: ECLIC_CLICINTATTR_46. cr ." ECLIC_CLICINTATTR_46.  RW   $" ECLIC_CLICINTATTR_46 @ hex. ECLIC_CLICINTATTR_46 1b. ;
: ECLIC_CLICINTATTR_47. cr ." ECLIC_CLICINTATTR_47.  RW   $" ECLIC_CLICINTATTR_47 @ hex. ECLIC_CLICINTATTR_47 1b. ;
: ECLIC_CLICINTATTR_48. cr ." ECLIC_CLICINTATTR_48.  RW   $" ECLIC_CLICINTATTR_48 @ hex. ECLIC_CLICINTATTR_48 1b. ;
: ECLIC_CLICINTATTR_49. cr ." ECLIC_CLICINTATTR_49.  RW   $" ECLIC_CLICINTATTR_49 @ hex. ECLIC_CLICINTATTR_49 1b. ;
: ECLIC_CLICINTATTR_50. cr ." ECLIC_CLICINTATTR_50.  RW   $" ECLIC_CLICINTATTR_50 @ hex. ECLIC_CLICINTATTR_50 1b. ;
: ECLIC_CLICINTATTR_51. cr ." ECLIC_CLICINTATTR_51.  RW   $" ECLIC_CLICINTATTR_51 @ hex. ECLIC_CLICINTATTR_51 1b. ;
: ECLIC_CLICINTATTR_52. cr ." ECLIC_CLICINTATTR_52.  RW   $" ECLIC_CLICINTATTR_52 @ hex. ECLIC_CLICINTATTR_52 1b. ;
: ECLIC_CLICINTATTR_53. cr ." ECLIC_CLICINTATTR_53.  RW   $" ECLIC_CLICINTATTR_53 @ hex. ECLIC_CLICINTATTR_53 1b. ;
: ECLIC_CLICINTATTR_54. cr ." ECLIC_CLICINTATTR_54.  RW   $" ECLIC_CLICINTATTR_54 @ hex. ECLIC_CLICINTATTR_54 1b. ;
: ECLIC_CLICINTATTR_55. cr ." ECLIC_CLICINTATTR_55.  RW   $" ECLIC_CLICINTATTR_55 @ hex. ECLIC_CLICINTATTR_55 1b. ;
: ECLIC_CLICINTATTR_56. cr ." ECLIC_CLICINTATTR_56.  RW   $" ECLIC_CLICINTATTR_56 @ hex. ECLIC_CLICINTATTR_56 1b. ;
: ECLIC_CLICINTATTR_57. cr ." ECLIC_CLICINTATTR_57.  RW   $" ECLIC_CLICINTATTR_57 @ hex. ECLIC_CLICINTATTR_57 1b. ;
: ECLIC_CLICINTATTR_58. cr ." ECLIC_CLICINTATTR_58.  RW   $" ECLIC_CLICINTATTR_58 @ hex. ECLIC_CLICINTATTR_58 1b. ;
: ECLIC_CLICINTATTR_59. cr ." ECLIC_CLICINTATTR_59.  RW   $" ECLIC_CLICINTATTR_59 @ hex. ECLIC_CLICINTATTR_59 1b. ;
: ECLIC_CLICINTATTR_60. cr ." ECLIC_CLICINTATTR_60.  RW   $" ECLIC_CLICINTATTR_60 @ hex. ECLIC_CLICINTATTR_60 1b. ;
: ECLIC_CLICINTATTR_61. cr ." ECLIC_CLICINTATTR_61.  RW   $" ECLIC_CLICINTATTR_61 @ hex. ECLIC_CLICINTATTR_61 1b. ;
: ECLIC_CLICINTATTR_62. cr ." ECLIC_CLICINTATTR_62.  RW   $" ECLIC_CLICINTATTR_62 @ hex. ECLIC_CLICINTATTR_62 1b. ;
: ECLIC_CLICINTATTR_63. cr ." ECLIC_CLICINTATTR_63.  RW   $" ECLIC_CLICINTATTR_63 @ hex. ECLIC_CLICINTATTR_63 1b. ;
: ECLIC_CLICINTATTR_64. cr ." ECLIC_CLICINTATTR_64.  RW   $" ECLIC_CLICINTATTR_64 @ hex. ECLIC_CLICINTATTR_64 1b. ;
: ECLIC_CLICINTATTR_65. cr ." ECLIC_CLICINTATTR_65.  RW   $" ECLIC_CLICINTATTR_65 @ hex. ECLIC_CLICINTATTR_65 1b. ;
: ECLIC_CLICINTATTR_66. cr ." ECLIC_CLICINTATTR_66.  RW   $" ECLIC_CLICINTATTR_66 @ hex. ECLIC_CLICINTATTR_66 1b. ;
: ECLIC_CLICINTATTR_67. cr ." ECLIC_CLICINTATTR_67.  RW   $" ECLIC_CLICINTATTR_67 @ hex. ECLIC_CLICINTATTR_67 1b. ;
: ECLIC_CLICINTATTR_68. cr ." ECLIC_CLICINTATTR_68.  RW   $" ECLIC_CLICINTATTR_68 @ hex. ECLIC_CLICINTATTR_68 1b. ;
: ECLIC_CLICINTATTR_69. cr ." ECLIC_CLICINTATTR_69.  RW   $" ECLIC_CLICINTATTR_69 @ hex. ECLIC_CLICINTATTR_69 1b. ;
: ECLIC_CLICINTATTR_70. cr ." ECLIC_CLICINTATTR_70.  RW   $" ECLIC_CLICINTATTR_70 @ hex. ECLIC_CLICINTATTR_70 1b. ;
: ECLIC_CLICINTATTR_71. cr ." ECLIC_CLICINTATTR_71.  RW   $" ECLIC_CLICINTATTR_71 @ hex. ECLIC_CLICINTATTR_71 1b. ;
: ECLIC_CLICINTATTR_72. cr ." ECLIC_CLICINTATTR_72.  RW   $" ECLIC_CLICINTATTR_72 @ hex. ECLIC_CLICINTATTR_72 1b. ;
: ECLIC_CLICINTATTR_73. cr ." ECLIC_CLICINTATTR_73.  RW   $" ECLIC_CLICINTATTR_73 @ hex. ECLIC_CLICINTATTR_73 1b. ;
: ECLIC_CLICINTATTR_74. cr ." ECLIC_CLICINTATTR_74.  RW   $" ECLIC_CLICINTATTR_74 @ hex. ECLIC_CLICINTATTR_74 1b. ;
: ECLIC_CLICINTATTR_75. cr ." ECLIC_CLICINTATTR_75.  RW   $" ECLIC_CLICINTATTR_75 @ hex. ECLIC_CLICINTATTR_75 1b. ;
: ECLIC_CLICINTATTR_76. cr ." ECLIC_CLICINTATTR_76.  RW   $" ECLIC_CLICINTATTR_76 @ hex. ECLIC_CLICINTATTR_76 1b. ;
: ECLIC_CLICINTATTR_77. cr ." ECLIC_CLICINTATTR_77.  RW   $" ECLIC_CLICINTATTR_77 @ hex. ECLIC_CLICINTATTR_77 1b. ;
: ECLIC_CLICINTATTR_78. cr ." ECLIC_CLICINTATTR_78.  RW   $" ECLIC_CLICINTATTR_78 @ hex. ECLIC_CLICINTATTR_78 1b. ;
: ECLIC_CLICINTATTR_79. cr ." ECLIC_CLICINTATTR_79.  RW   $" ECLIC_CLICINTATTR_79 @ hex. ECLIC_CLICINTATTR_79 1b. ;
: ECLIC_CLICINTATTR_80. cr ." ECLIC_CLICINTATTR_80.  RW   $" ECLIC_CLICINTATTR_80 @ hex. ECLIC_CLICINTATTR_80 1b. ;
: ECLIC_CLICINTATTR_81. cr ." ECLIC_CLICINTATTR_81.  RW   $" ECLIC_CLICINTATTR_81 @ hex. ECLIC_CLICINTATTR_81 1b. ;
: ECLIC_CLICINTATTR_82. cr ." ECLIC_CLICINTATTR_82.  RW   $" ECLIC_CLICINTATTR_82 @ hex. ECLIC_CLICINTATTR_82 1b. ;
: ECLIC_CLICINTATTR_83. cr ." ECLIC_CLICINTATTR_83.  RW   $" ECLIC_CLICINTATTR_83 @ hex. ECLIC_CLICINTATTR_83 1b. ;
: ECLIC_CLICINTATTR_84. cr ." ECLIC_CLICINTATTR_84.  RW   $" ECLIC_CLICINTATTR_84 @ hex. ECLIC_CLICINTATTR_84 1b. ;
: ECLIC_CLICINTATTR_85. cr ." ECLIC_CLICINTATTR_85.  RW   $" ECLIC_CLICINTATTR_85 @ hex. ECLIC_CLICINTATTR_85 1b. ;
: ECLIC_CLICINTATTR_86. cr ." ECLIC_CLICINTATTR_86.  RW   $" ECLIC_CLICINTATTR_86 @ hex. ECLIC_CLICINTATTR_86 1b. ;
: ECLIC_CLICINTCTL_0. cr ." ECLIC_CLICINTCTL_0.  RW   $" ECLIC_CLICINTCTL_0 @ hex. ECLIC_CLICINTCTL_0 1b. ;
: ECLIC_CLICINTCTL_1. cr ." ECLIC_CLICINTCTL_1.  RW   $" ECLIC_CLICINTCTL_1 @ hex. ECLIC_CLICINTCTL_1 1b. ;
: ECLIC_CLICINTCTL_2. cr ." ECLIC_CLICINTCTL_2.  RW   $" ECLIC_CLICINTCTL_2 @ hex. ECLIC_CLICINTCTL_2 1b. ;
: ECLIC_CLICINTCTL_3. cr ." ECLIC_CLICINTCTL_3.  RW   $" ECLIC_CLICINTCTL_3 @ hex. ECLIC_CLICINTCTL_3 1b. ;
: ECLIC_CLICINTCTL_4. cr ." ECLIC_CLICINTCTL_4.  RW   $" ECLIC_CLICINTCTL_4 @ hex. ECLIC_CLICINTCTL_4 1b. ;
: ECLIC_CLICINTCTL_5. cr ." ECLIC_CLICINTCTL_5.  RW   $" ECLIC_CLICINTCTL_5 @ hex. ECLIC_CLICINTCTL_5 1b. ;
: ECLIC_CLICINTCTL_6. cr ." ECLIC_CLICINTCTL_6.  RW   $" ECLIC_CLICINTCTL_6 @ hex. ECLIC_CLICINTCTL_6 1b. ;
: ECLIC_CLICINTCTL_7. cr ." ECLIC_CLICINTCTL_7.  RW   $" ECLIC_CLICINTCTL_7 @ hex. ECLIC_CLICINTCTL_7 1b. ;
: ECLIC_CLICINTCTL_8. cr ." ECLIC_CLICINTCTL_8.  RW   $" ECLIC_CLICINTCTL_8 @ hex. ECLIC_CLICINTCTL_8 1b. ;
: ECLIC_CLICINTCTL_9. cr ." ECLIC_CLICINTCTL_9.  RW   $" ECLIC_CLICINTCTL_9 @ hex. ECLIC_CLICINTCTL_9 1b. ;
: ECLIC_CLICINTCTL_10. cr ." ECLIC_CLICINTCTL_10.  RW   $" ECLIC_CLICINTCTL_10 @ hex. ECLIC_CLICINTCTL_10 1b. ;
: ECLIC_CLICINTCTL_11. cr ." ECLIC_CLICINTCTL_11.  RW   $" ECLIC_CLICINTCTL_11 @ hex. ECLIC_CLICINTCTL_11 1b. ;
: ECLIC_CLICINTCTL_12. cr ." ECLIC_CLICINTCTL_12.  RW   $" ECLIC_CLICINTCTL_12 @ hex. ECLIC_CLICINTCTL_12 1b. ;
: ECLIC_CLICINTCTL_13. cr ." ECLIC_CLICINTCTL_13.  RW   $" ECLIC_CLICINTCTL_13 @ hex. ECLIC_CLICINTCTL_13 1b. ;
: ECLIC_CLICINTCTL_14. cr ." ECLIC_CLICINTCTL_14.  RW   $" ECLIC_CLICINTCTL_14 @ hex. ECLIC_CLICINTCTL_14 1b. ;
: ECLIC_CLICINTCTL_15. cr ." ECLIC_CLICINTCTL_15.  RW   $" ECLIC_CLICINTCTL_15 @ hex. ECLIC_CLICINTCTL_15 1b. ;
: ECLIC_CLICINTCTL_16. cr ." ECLIC_CLICINTCTL_16.  RW   $" ECLIC_CLICINTCTL_16 @ hex. ECLIC_CLICINTCTL_16 1b. ;
: ECLIC_CLICINTCTL_17. cr ." ECLIC_CLICINTCTL_17.  RW   $" ECLIC_CLICINTCTL_17 @ hex. ECLIC_CLICINTCTL_17 1b. ;
: ECLIC_CLICINTCTL_18. cr ." ECLIC_CLICINTCTL_18.  RW   $" ECLIC_CLICINTCTL_18 @ hex. ECLIC_CLICINTCTL_18 1b. ;
: ECLIC_CLICINTCTL_19. cr ." ECLIC_CLICINTCTL_19.  RW   $" ECLIC_CLICINTCTL_19 @ hex. ECLIC_CLICINTCTL_19 1b. ;
: ECLIC_CLICINTCTL_20. cr ." ECLIC_CLICINTCTL_20.  RW   $" ECLIC_CLICINTCTL_20 @ hex. ECLIC_CLICINTCTL_20 1b. ;
: ECLIC_CLICINTCTL_21. cr ." ECLIC_CLICINTCTL_21.  RW   $" ECLIC_CLICINTCTL_21 @ hex. ECLIC_CLICINTCTL_21 1b. ;
: ECLIC_CLICINTCTL_22. cr ." ECLIC_CLICINTCTL_22.  RW   $" ECLIC_CLICINTCTL_22 @ hex. ECLIC_CLICINTCTL_22 1b. ;
: ECLIC_CLICINTCTL_23. cr ." ECLIC_CLICINTCTL_23.  RW   $" ECLIC_CLICINTCTL_23 @ hex. ECLIC_CLICINTCTL_23 1b. ;
: ECLIC_CLICINTCTL_24. cr ." ECLIC_CLICINTCTL_24.  RW   $" ECLIC_CLICINTCTL_24 @ hex. ECLIC_CLICINTCTL_24 1b. ;
: ECLIC_CLICINTCTL_25. cr ." ECLIC_CLICINTCTL_25.  RW   $" ECLIC_CLICINTCTL_25 @ hex. ECLIC_CLICINTCTL_25 1b. ;
: ECLIC_CLICINTCTL_26. cr ." ECLIC_CLICINTCTL_26.  RW   $" ECLIC_CLICINTCTL_26 @ hex. ECLIC_CLICINTCTL_26 1b. ;
: ECLIC_CLICINTCTL_27. cr ." ECLIC_CLICINTCTL_27.  RW   $" ECLIC_CLICINTCTL_27 @ hex. ECLIC_CLICINTCTL_27 1b. ;
: ECLIC_CLICINTCTL_28. cr ." ECLIC_CLICINTCTL_28.  RW   $" ECLIC_CLICINTCTL_28 @ hex. ECLIC_CLICINTCTL_28 1b. ;
: ECLIC_CLICINTCTL_29. cr ." ECLIC_CLICINTCTL_29.  RW   $" ECLIC_CLICINTCTL_29 @ hex. ECLIC_CLICINTCTL_29 1b. ;
: ECLIC_CLICINTCTL_30. cr ." ECLIC_CLICINTCTL_30.  RW   $" ECLIC_CLICINTCTL_30 @ hex. ECLIC_CLICINTCTL_30 1b. ;
: ECLIC_CLICINTCTL_31. cr ." ECLIC_CLICINTCTL_31.  RW   $" ECLIC_CLICINTCTL_31 @ hex. ECLIC_CLICINTCTL_31 1b. ;
: ECLIC_CLICINTCTL_32. cr ." ECLIC_CLICINTCTL_32.  RW   $" ECLIC_CLICINTCTL_32 @ hex. ECLIC_CLICINTCTL_32 1b. ;
: ECLIC_CLICINTCTL_33. cr ." ECLIC_CLICINTCTL_33.  RW   $" ECLIC_CLICINTCTL_33 @ hex. ECLIC_CLICINTCTL_33 1b. ;
: ECLIC_CLICINTCTL_34. cr ." ECLIC_CLICINTCTL_34.  RW   $" ECLIC_CLICINTCTL_34 @ hex. ECLIC_CLICINTCTL_34 1b. ;
: ECLIC_CLICINTCTL_35. cr ." ECLIC_CLICINTCTL_35.  RW   $" ECLIC_CLICINTCTL_35 @ hex. ECLIC_CLICINTCTL_35 1b. ;
: ECLIC_CLICINTCTL_36. cr ." ECLIC_CLICINTCTL_36.  RW   $" ECLIC_CLICINTCTL_36 @ hex. ECLIC_CLICINTCTL_36 1b. ;
: ECLIC_CLICINTCTL_37. cr ." ECLIC_CLICINTCTL_37.  RW   $" ECLIC_CLICINTCTL_37 @ hex. ECLIC_CLICINTCTL_37 1b. ;
: ECLIC_CLICINTCTL_38. cr ." ECLIC_CLICINTCTL_38.  RW   $" ECLIC_CLICINTCTL_38 @ hex. ECLIC_CLICINTCTL_38 1b. ;
: ECLIC_CLICINTCTL_39. cr ." ECLIC_CLICINTCTL_39.  RW   $" ECLIC_CLICINTCTL_39 @ hex. ECLIC_CLICINTCTL_39 1b. ;
: ECLIC_CLICINTCTL_40. cr ." ECLIC_CLICINTCTL_40.  RW   $" ECLIC_CLICINTCTL_40 @ hex. ECLIC_CLICINTCTL_40 1b. ;
: ECLIC_CLICINTCTL_41. cr ." ECLIC_CLICINTCTL_41.  RW   $" ECLIC_CLICINTCTL_41 @ hex. ECLIC_CLICINTCTL_41 1b. ;
: ECLIC_CLICINTCTL_42. cr ." ECLIC_CLICINTCTL_42.  RW   $" ECLIC_CLICINTCTL_42 @ hex. ECLIC_CLICINTCTL_42 1b. ;
: ECLIC_CLICINTCTL_43. cr ." ECLIC_CLICINTCTL_43.  RW   $" ECLIC_CLICINTCTL_43 @ hex. ECLIC_CLICINTCTL_43 1b. ;
: ECLIC_CLICINTCTL_44. cr ." ECLIC_CLICINTCTL_44.  RW   $" ECLIC_CLICINTCTL_44 @ hex. ECLIC_CLICINTCTL_44 1b. ;
: ECLIC_CLICINTCTL_45. cr ." ECLIC_CLICINTCTL_45.  RW   $" ECLIC_CLICINTCTL_45 @ hex. ECLIC_CLICINTCTL_45 1b. ;
: ECLIC_CLICINTCTL_46. cr ." ECLIC_CLICINTCTL_46.  RW   $" ECLIC_CLICINTCTL_46 @ hex. ECLIC_CLICINTCTL_46 1b. ;
: ECLIC_CLICINTCTL_47. cr ." ECLIC_CLICINTCTL_47.  RW   $" ECLIC_CLICINTCTL_47 @ hex. ECLIC_CLICINTCTL_47 1b. ;
: ECLIC_CLICINTCTL_48. cr ." ECLIC_CLICINTCTL_48.  RW   $" ECLIC_CLICINTCTL_48 @ hex. ECLIC_CLICINTCTL_48 1b. ;
: ECLIC_CLICINTCTL_49. cr ." ECLIC_CLICINTCTL_49.  RW   $" ECLIC_CLICINTCTL_49 @ hex. ECLIC_CLICINTCTL_49 1b. ;
: ECLIC_CLICINTCTL_50. cr ." ECLIC_CLICINTCTL_50.  RW   $" ECLIC_CLICINTCTL_50 @ hex. ECLIC_CLICINTCTL_50 1b. ;
: ECLIC_CLICINTCTL_51. cr ." ECLIC_CLICINTCTL_51.  RW   $" ECLIC_CLICINTCTL_51 @ hex. ECLIC_CLICINTCTL_51 1b. ;
: ECLIC_CLICINTCTL_52. cr ." ECLIC_CLICINTCTL_52.  RW   $" ECLIC_CLICINTCTL_52 @ hex. ECLIC_CLICINTCTL_52 1b. ;
: ECLIC_CLICINTCTL_53. cr ." ECLIC_CLICINTCTL_53.  RW   $" ECLIC_CLICINTCTL_53 @ hex. ECLIC_CLICINTCTL_53 1b. ;
: ECLIC_CLICINTCTL_54. cr ." ECLIC_CLICINTCTL_54.  RW   $" ECLIC_CLICINTCTL_54 @ hex. ECLIC_CLICINTCTL_54 1b. ;
: ECLIC_CLICINTCTL_55. cr ." ECLIC_CLICINTCTL_55.  RW   $" ECLIC_CLICINTCTL_55 @ hex. ECLIC_CLICINTCTL_55 1b. ;
: ECLIC_CLICINTCTL_56. cr ." ECLIC_CLICINTCTL_56.  RW   $" ECLIC_CLICINTCTL_56 @ hex. ECLIC_CLICINTCTL_56 1b. ;
: ECLIC_CLICINTCTL_57. cr ." ECLIC_CLICINTCTL_57.  RW   $" ECLIC_CLICINTCTL_57 @ hex. ECLIC_CLICINTCTL_57 1b. ;
: ECLIC_CLICINTCTL_58. cr ." ECLIC_CLICINTCTL_58.  RW   $" ECLIC_CLICINTCTL_58 @ hex. ECLIC_CLICINTCTL_58 1b. ;
: ECLIC_CLICINTCTL_59. cr ." ECLIC_CLICINTCTL_59.  RW   $" ECLIC_CLICINTCTL_59 @ hex. ECLIC_CLICINTCTL_59 1b. ;
: ECLIC_CLICINTCTL_60. cr ." ECLIC_CLICINTCTL_60.  RW   $" ECLIC_CLICINTCTL_60 @ hex. ECLIC_CLICINTCTL_60 1b. ;
: ECLIC_CLICINTCTL_61. cr ." ECLIC_CLICINTCTL_61.  RW   $" ECLIC_CLICINTCTL_61 @ hex. ECLIC_CLICINTCTL_61 1b. ;
: ECLIC_CLICINTCTL_62. cr ." ECLIC_CLICINTCTL_62.  RW   $" ECLIC_CLICINTCTL_62 @ hex. ECLIC_CLICINTCTL_62 1b. ;
: ECLIC_CLICINTCTL_63. cr ." ECLIC_CLICINTCTL_63.  RW   $" ECLIC_CLICINTCTL_63 @ hex. ECLIC_CLICINTCTL_63 1b. ;
: ECLIC_CLICINTCTL_64. cr ." ECLIC_CLICINTCTL_64.  RW   $" ECLIC_CLICINTCTL_64 @ hex. ECLIC_CLICINTCTL_64 1b. ;
: ECLIC_CLICINTCTL_65. cr ." ECLIC_CLICINTCTL_65.  RW   $" ECLIC_CLICINTCTL_65 @ hex. ECLIC_CLICINTCTL_65 1b. ;
: ECLIC_CLICINTCTL_66. cr ." ECLIC_CLICINTCTL_66.  RW   $" ECLIC_CLICINTCTL_66 @ hex. ECLIC_CLICINTCTL_66 1b. ;
: ECLIC_CLICINTCTL_67. cr ." ECLIC_CLICINTCTL_67.  RW   $" ECLIC_CLICINTCTL_67 @ hex. ECLIC_CLICINTCTL_67 1b. ;
: ECLIC_CLICINTCTL_68. cr ." ECLIC_CLICINTCTL_68.  RW   $" ECLIC_CLICINTCTL_68 @ hex. ECLIC_CLICINTCTL_68 1b. ;
: ECLIC_CLICINTCTL_69. cr ." ECLIC_CLICINTCTL_69.  RW   $" ECLIC_CLICINTCTL_69 @ hex. ECLIC_CLICINTCTL_69 1b. ;
: ECLIC_CLICINTCTL_70. cr ." ECLIC_CLICINTCTL_70.  RW   $" ECLIC_CLICINTCTL_70 @ hex. ECLIC_CLICINTCTL_70 1b. ;
: ECLIC_CLICINTCTL_71. cr ." ECLIC_CLICINTCTL_71.  RW   $" ECLIC_CLICINTCTL_71 @ hex. ECLIC_CLICINTCTL_71 1b. ;
: ECLIC_CLICINTCTL_72. cr ." ECLIC_CLICINTCTL_72.  RW   $" ECLIC_CLICINTCTL_72 @ hex. ECLIC_CLICINTCTL_72 1b. ;
: ECLIC_CLICINTCTL_73. cr ." ECLIC_CLICINTCTL_73.  RW   $" ECLIC_CLICINTCTL_73 @ hex. ECLIC_CLICINTCTL_73 1b. ;
: ECLIC_CLICINTCTL_74. cr ." ECLIC_CLICINTCTL_74.  RW   $" ECLIC_CLICINTCTL_74 @ hex. ECLIC_CLICINTCTL_74 1b. ;
: ECLIC_CLICINTCTL_75. cr ." ECLIC_CLICINTCTL_75.  RW   $" ECLIC_CLICINTCTL_75 @ hex. ECLIC_CLICINTCTL_75 1b. ;
: ECLIC_CLICINTCTL_76. cr ." ECLIC_CLICINTCTL_76.  RW   $" ECLIC_CLICINTCTL_76 @ hex. ECLIC_CLICINTCTL_76 1b. ;
: ECLIC_CLICINTCTL_77. cr ." ECLIC_CLICINTCTL_77.  RW   $" ECLIC_CLICINTCTL_77 @ hex. ECLIC_CLICINTCTL_77 1b. ;
: ECLIC_CLICINTCTL_78. cr ." ECLIC_CLICINTCTL_78.  RW   $" ECLIC_CLICINTCTL_78 @ hex. ECLIC_CLICINTCTL_78 1b. ;
: ECLIC_CLICINTCTL_79. cr ." ECLIC_CLICINTCTL_79.  RW   $" ECLIC_CLICINTCTL_79 @ hex. ECLIC_CLICINTCTL_79 1b. ;
: ECLIC_CLICINTCTL_80. cr ." ECLIC_CLICINTCTL_80.  RW   $" ECLIC_CLICINTCTL_80 @ hex. ECLIC_CLICINTCTL_80 1b. ;
: ECLIC_CLICINTCTL_81. cr ." ECLIC_CLICINTCTL_81.  RW   $" ECLIC_CLICINTCTL_81 @ hex. ECLIC_CLICINTCTL_81 1b. ;
: ECLIC_CLICINTCTL_82. cr ." ECLIC_CLICINTCTL_82.  RW   $" ECLIC_CLICINTCTL_82 @ hex. ECLIC_CLICINTCTL_82 1b. ;
: ECLIC_CLICINTCTL_83. cr ." ECLIC_CLICINTCTL_83.  RW   $" ECLIC_CLICINTCTL_83 @ hex. ECLIC_CLICINTCTL_83 1b. ;
: ECLIC_CLICINTCTL_84. cr ." ECLIC_CLICINTCTL_84.  RW   $" ECLIC_CLICINTCTL_84 @ hex. ECLIC_CLICINTCTL_84 1b. ;
: ECLIC_CLICINTCTL_85. cr ." ECLIC_CLICINTCTL_85.  RW   $" ECLIC_CLICINTCTL_85 @ hex. ECLIC_CLICINTCTL_85 1b. ;
: ECLIC_CLICINTCTL_86. cr ." ECLIC_CLICINTCTL_86.  RW   $" ECLIC_CLICINTCTL_86 @ hex. ECLIC_CLICINTCTL_86 1b. ;
: ECLIC.
ECLIC_CLICCFG.
ECLIC_CLICINFO.
ECLIC_MTH.
ECLIC_CLICINTIP_0.
ECLIC_CLICINTIP_1.
ECLIC_CLICINTIP_2.
ECLIC_CLICINTIP_3.
ECLIC_CLICINTIP_4.
ECLIC_CLICINTIP_5.
ECLIC_CLICINTIP_6.
ECLIC_CLICINTIP_7.
ECLIC_CLICINTIP_8.
ECLIC_CLICINTIP_9.
ECLIC_CLICINTIP_10.
ECLIC_CLICINTIP_11.
ECLIC_CLICINTIP_12.
ECLIC_CLICINTIP_13.
ECLIC_CLICINTIP_14.
ECLIC_CLICINTIP_15.
ECLIC_CLICINTIP_16.
ECLIC_CLICINTIP_17.
ECLIC_CLICINTIP_18.
ECLIC_CLICINTIP_19.
ECLIC_CLICINTIP_20.
ECLIC_CLICINTIP_21.
ECLIC_CLICINTIP_22.
ECLIC_CLICINTIP_23.
ECLIC_CLICINTIP_24.
ECLIC_CLICINTIP_25.
ECLIC_CLICINTIP_26.
ECLIC_CLICINTIP_27.
ECLIC_CLICINTIP_28.
ECLIC_CLICINTIP_29.
ECLIC_CLICINTIP_30.
ECLIC_CLICINTIP_31.
ECLIC_CLICINTIP_32.
ECLIC_CLICINTIP_33.
ECLIC_CLICINTIP_34.
ECLIC_CLICINTIP_35.
ECLIC_CLICINTIP_36.
ECLIC_CLICINTIP_37.
ECLIC_CLICINTIP_38.
ECLIC_CLICINTIP_39.
ECLIC_CLICINTIP_40.
ECLIC_CLICINTIP_41.
ECLIC_CLICINTIP_42.
ECLIC_CLICINTIP_43.
ECLIC_CLICINTIP_44.
ECLIC_CLICINTIP_45.
ECLIC_CLICINTIP_46.
ECLIC_CLICINTIP_47.
ECLIC_CLICINTIP_48.
ECLIC_CLICINTIP_49.
ECLIC_CLICINTIP_50.
ECLIC_CLICINTIP_51.
ECLIC_CLICINTIP_52.
ECLIC_CLICINTIP_53.
ECLIC_CLICINTIP_54.
ECLIC_CLICINTIP_55.
ECLIC_CLICINTIP_56.
ECLIC_CLICINTIP_57.
ECLIC_CLICINTIP_58.
ECLIC_CLICINTIP_59.
ECLIC_CLICINTIP_60.
ECLIC_CLICINTIP_61.
ECLIC_CLICINTIP_62.
ECLIC_CLICINTIP_63.
ECLIC_CLICINTIP_64.
ECLIC_CLICINTIP_65.
ECLIC_CLICINTIP_66.
ECLIC_CLICINTIP_67.
ECLIC_CLICINTIP_68.
ECLIC_CLICINTIP_69.
ECLIC_CLICINTIP_70.
ECLIC_CLICINTIP_71.
ECLIC_CLICINTIP_72.
ECLIC_CLICINTIP_73.
ECLIC_CLICINTIP_74.
ECLIC_CLICINTIP_75.
ECLIC_CLICINTIP_76.
ECLIC_CLICINTIP_77.
ECLIC_CLICINTIP_78.
ECLIC_CLICINTIP_79.
ECLIC_CLICINTIP_80.
ECLIC_CLICINTIP_81.
ECLIC_CLICINTIP_82.
ECLIC_CLICINTIP_83.
ECLIC_CLICINTIP_84.
ECLIC_CLICINTIP_85.
ECLIC_CLICINTIP_86.
ECLIC_CLICINTIE_0.
ECLIC_CLICINTIE_1.
ECLIC_CLICINTIE_2.
ECLIC_CLICINTIE_3.
ECLIC_CLICINTIE_4.
ECLIC_CLICINTIE_5.
ECLIC_CLICINTIE_6.
ECLIC_CLICINTIE_7.
ECLIC_CLICINTIE_8.
ECLIC_CLICINTIE_9.
ECLIC_CLICINTIE_10.
ECLIC_CLICINTIE_11.
ECLIC_CLICINTIE_12.
ECLIC_CLICINTIE_13.
ECLIC_CLICINTIE_14.
ECLIC_CLICINTIE_15.
ECLIC_CLICINTIE_16.
ECLIC_CLICINTIE_17.
ECLIC_CLICINTIE_18.
ECLIC_CLICINTIE_19.
ECLIC_CLICINTIE_20.
ECLIC_CLICINTIE_21.
ECLIC_CLICINTIE_22.
ECLIC_CLICINTIE_23.
ECLIC_CLICINTIE_24.
ECLIC_CLICINTIE_25.
ECLIC_CLICINTIE_26.
ECLIC_CLICINTIE_27.
ECLIC_CLICINTIE_28.
ECLIC_CLICINTIE_29.
ECLIC_CLICINTIE_30.
ECLIC_CLICINTIE_31.
ECLIC_CLICINTIE_32.
ECLIC_CLICINTIE_33.
ECLIC_CLICINTIE_34.
ECLIC_CLICINTIE_35.
ECLIC_CLICINTIE_36.
ECLIC_CLICINTIE_37.
ECLIC_CLICINTIE_38.
ECLIC_CLICINTIE_39.
ECLIC_CLICINTIE_40.
ECLIC_CLICINTIE_41.
ECLIC_CLICINTIE_42.
ECLIC_CLICINTIE_43.
ECLIC_CLICINTIE_44.
ECLIC_CLICINTIE_45.
ECLIC_CLICINTIE_46.
ECLIC_CLICINTIE_47.
ECLIC_CLICINTIE_48.
ECLIC_CLICINTIE_49.
ECLIC_CLICINTIE_50.
ECLIC_CLICINTIE_51.
ECLIC_CLICINTIE_52.
ECLIC_CLICINTIE_53.
ECLIC_CLICINTIE_54.
ECLIC_CLICINTIE_55.
ECLIC_CLICINTIE_56.
ECLIC_CLICINTIE_57.
ECLIC_CLICINTIE_58.
ECLIC_CLICINTIE_59.
ECLIC_CLICINTIE_60.
ECLIC_CLICINTIE_61.
ECLIC_CLICINTIE_62.
ECLIC_CLICINTIE_63.
ECLIC_CLICINTIE_64.
ECLIC_CLICINTIE_65.
ECLIC_CLICINTIE_66.
ECLIC_CLICINTIE_67.
ECLIC_CLICINTIE_68.
ECLIC_CLICINTIE_69.
ECLIC_CLICINTIE_70.
ECLIC_CLICINTIE_71.
ECLIC_CLICINTIE_72.
ECLIC_CLICINTIE_73.
ECLIC_CLICINTIE_74.
ECLIC_CLICINTIE_75.
ECLIC_CLICINTIE_76.
ECLIC_CLICINTIE_77.
ECLIC_CLICINTIE_78.
ECLIC_CLICINTIE_79.
ECLIC_CLICINTIE_80.
ECLIC_CLICINTIE_81.
ECLIC_CLICINTIE_82.
ECLIC_CLICINTIE_83.
ECLIC_CLICINTIE_84.
ECLIC_CLICINTIE_85.
ECLIC_CLICINTIE_86.
ECLIC_CLICINTATTR_0.
ECLIC_CLICINTATTR_1.
ECLIC_CLICINTATTR_2.
ECLIC_CLICINTATTR_3.
ECLIC_CLICINTATTR_4.
ECLIC_CLICINTATTR_5.
ECLIC_CLICINTATTR_6.
ECLIC_CLICINTATTR_7.
ECLIC_CLICINTATTR_8.
ECLIC_CLICINTATTR_9.
ECLIC_CLICINTATTR_10.
ECLIC_CLICINTATTR_11.
ECLIC_CLICINTATTR_12.
ECLIC_CLICINTATTR_13.
ECLIC_CLICINTATTR_14.
ECLIC_CLICINTATTR_15.
ECLIC_CLICINTATTR_16.
ECLIC_CLICINTATTR_17.
ECLIC_CLICINTATTR_18.
ECLIC_CLICINTATTR_19.
ECLIC_CLICINTATTR_20.
ECLIC_CLICINTATTR_21.
ECLIC_CLICINTATTR_22.
ECLIC_CLICINTATTR_23.
ECLIC_CLICINTATTR_24.
ECLIC_CLICINTATTR_25.
ECLIC_CLICINTATTR_26.
ECLIC_CLICINTATTR_27.
ECLIC_CLICINTATTR_28.
ECLIC_CLICINTATTR_29.
ECLIC_CLICINTATTR_30.
ECLIC_CLICINTATTR_31.
ECLIC_CLICINTATTR_32.
ECLIC_CLICINTATTR_33.
ECLIC_CLICINTATTR_34.
ECLIC_CLICINTATTR_35.
ECLIC_CLICINTATTR_36.
ECLIC_CLICINTATTR_37.
ECLIC_CLICINTATTR_38.
ECLIC_CLICINTATTR_39.
ECLIC_CLICINTATTR_40.
ECLIC_CLICINTATTR_41.
ECLIC_CLICINTATTR_42.
ECLIC_CLICINTATTR_43.
ECLIC_CLICINTATTR_44.
ECLIC_CLICINTATTR_45.
ECLIC_CLICINTATTR_46.
ECLIC_CLICINTATTR_47.
ECLIC_CLICINTATTR_48.
ECLIC_CLICINTATTR_49.
ECLIC_CLICINTATTR_50.
ECLIC_CLICINTATTR_51.
ECLIC_CLICINTATTR_52.
ECLIC_CLICINTATTR_53.
ECLIC_CLICINTATTR_54.
ECLIC_CLICINTATTR_55.
ECLIC_CLICINTATTR_56.
ECLIC_CLICINTATTR_57.
ECLIC_CLICINTATTR_58.
ECLIC_CLICINTATTR_59.
ECLIC_CLICINTATTR_60.
ECLIC_CLICINTATTR_61.
ECLIC_CLICINTATTR_62.
ECLIC_CLICINTATTR_63.
ECLIC_CLICINTATTR_64.
ECLIC_CLICINTATTR_65.
ECLIC_CLICINTATTR_66.
ECLIC_CLICINTATTR_67.
ECLIC_CLICINTATTR_68.
ECLIC_CLICINTATTR_69.
ECLIC_CLICINTATTR_70.
ECLIC_CLICINTATTR_71.
ECLIC_CLICINTATTR_72.
ECLIC_CLICINTATTR_73.
ECLIC_CLICINTATTR_74.
ECLIC_CLICINTATTR_75.
ECLIC_CLICINTATTR_76.
ECLIC_CLICINTATTR_77.
ECLIC_CLICINTATTR_78.
ECLIC_CLICINTATTR_79.
ECLIC_CLICINTATTR_80.
ECLIC_CLICINTATTR_81.
ECLIC_CLICINTATTR_82.
ECLIC_CLICINTATTR_83.
ECLIC_CLICINTATTR_84.
ECLIC_CLICINTATTR_85.
ECLIC_CLICINTATTR_86.
ECLIC_CLICINTCTL_0.
ECLIC_CLICINTCTL_1.
ECLIC_CLICINTCTL_2.
ECLIC_CLICINTCTL_3.
ECLIC_CLICINTCTL_4.
ECLIC_CLICINTCTL_5.
ECLIC_CLICINTCTL_6.
ECLIC_CLICINTCTL_7.
ECLIC_CLICINTCTL_8.
ECLIC_CLICINTCTL_9.
ECLIC_CLICINTCTL_10.
ECLIC_CLICINTCTL_11.
ECLIC_CLICINTCTL_12.
ECLIC_CLICINTCTL_13.
ECLIC_CLICINTCTL_14.
ECLIC_CLICINTCTL_15.
ECLIC_CLICINTCTL_16.
ECLIC_CLICINTCTL_17.
ECLIC_CLICINTCTL_18.
ECLIC_CLICINTCTL_19.
ECLIC_CLICINTCTL_20.
ECLIC_CLICINTCTL_21.
ECLIC_CLICINTCTL_22.
ECLIC_CLICINTCTL_23.
ECLIC_CLICINTCTL_24.
ECLIC_CLICINTCTL_25.
ECLIC_CLICINTCTL_26.
ECLIC_CLICINTCTL_27.
ECLIC_CLICINTCTL_28.
ECLIC_CLICINTCTL_29.
ECLIC_CLICINTCTL_30.
ECLIC_CLICINTCTL_31.
ECLIC_CLICINTCTL_32.
ECLIC_CLICINTCTL_33.
ECLIC_CLICINTCTL_34.
ECLIC_CLICINTCTL_35.
ECLIC_CLICINTCTL_36.
ECLIC_CLICINTCTL_37.
ECLIC_CLICINTCTL_38.
ECLIC_CLICINTCTL_39.
ECLIC_CLICINTCTL_40.
ECLIC_CLICINTCTL_41.
ECLIC_CLICINTCTL_42.
ECLIC_CLICINTCTL_43.
ECLIC_CLICINTCTL_44.
ECLIC_CLICINTCTL_45.
ECLIC_CLICINTCTL_46.
ECLIC_CLICINTCTL_47.
ECLIC_CLICINTCTL_48.
ECLIC_CLICINTCTL_49.
ECLIC_CLICINTCTL_50.
ECLIC_CLICINTCTL_51.
ECLIC_CLICINTCTL_52.
ECLIC_CLICINTCTL_53.
ECLIC_CLICINTCTL_54.
ECLIC_CLICINTCTL_55.
ECLIC_CLICINTCTL_56.
ECLIC_CLICINTCTL_57.
ECLIC_CLICINTCTL_58.
ECLIC_CLICINTCTL_59.
ECLIC_CLICINTCTL_60.
ECLIC_CLICINTCTL_61.
ECLIC_CLICINTCTL_62.
ECLIC_CLICINTCTL_63.
ECLIC_CLICINTCTL_64.
ECLIC_CLICINTCTL_65.
ECLIC_CLICINTCTL_66.
ECLIC_CLICINTCTL_67.
ECLIC_CLICINTCTL_68.
ECLIC_CLICINTCTL_69.
ECLIC_CLICINTCTL_70.
ECLIC_CLICINTCTL_71.
ECLIC_CLICINTCTL_72.
ECLIC_CLICINTCTL_73.
ECLIC_CLICINTCTL_74.
ECLIC_CLICINTCTL_75.
ECLIC_CLICINTCTL_76.
ECLIC_CLICINTCTL_77.
ECLIC_CLICINTCTL_78.
ECLIC_CLICINTCTL_79.
ECLIC_CLICINTCTL_80.
ECLIC_CLICINTCTL_81.
ECLIC_CLICINTCTL_82.
ECLIC_CLICINTCTL_83.
ECLIC_CLICINTCTL_84.
ECLIC_CLICINTCTL_85.
ECLIC_CLICINTCTL_86.
;

$40007000 constant PMU \ Power management unit
PMU $00 + constant PMU_CTL ( read-write )  \ power control register
PMU $04 + constant PMU_CS (  )  \ power control/status register
: PMU_CTL. cr ." PMU_CTL.  RW   $" PMU_CTL @ hex. PMU_CTL 1b. ;
: PMU_CS. cr ." PMU_CS.   $" PMU_CS @ hex. PMU_CS 1b. ;
: PMU.
PMU_CTL.
PMU_CS.
;

$40021000 constant RCU \ Reset and clock unit
RCU $0 + constant RCU_CTL (  )  \ Control register
RCU $04 + constant RCU_CFG0 (  )  \ Clock configuration register 0  RCU_CFG0
RCU $08 + constant RCU_INT (  )  \ Clock interrupt register  RCU_INT
RCU $0C + constant RCU_APB2RST ( read-write )  \ APB2 reset register  RCU_APB2RST
RCU $10 + constant RCU_APB1RST ( read-write )  \ APB1 reset register  RCU_APB1RST
RCU $14 + constant RCU_AHBEN ( read-write )  \ AHB enable register
RCU $18 + constant RCU_APB2EN ( read-write )  \ APB2 clock enable register  RCU_APB2EN
RCU $1C + constant RCU_APB1EN ( read-write )  \ APB1 clock enable register  RCU_APB1EN
RCU $20 + constant RCU_BDCTL (  )  \ Backup domain control register  RCU_BDCTL
RCU $24 + constant RCU_RSTSCK (  )  \ Reset source /clock register  RCU_RSTSCK
RCU $28 + constant RCU_AHBRST ( read-write )  \ AHB reset register
RCU $2C + constant RCU_CFG1 ( read-write )  \ Clock Configuration register 1
RCU $34 + constant RCU_DSV (  )  \ Deep sleep mode Voltage register
: RCU_CTL. cr ." RCU_CTL.   $" RCU_CTL @ hex. RCU_CTL 1b. ;
: RCU_CFG0. cr ." RCU_CFG0.   $" RCU_CFG0 @ hex. RCU_CFG0 1b. ;
: RCU_INT. cr ." RCU_INT.   $" RCU_INT @ hex. RCU_INT 1b. ;
: RCU_APB2RST. cr ." RCU_APB2RST.  RW   $" RCU_APB2RST @ hex. RCU_APB2RST 1b. ;
: RCU_APB1RST. cr ." RCU_APB1RST.  RW   $" RCU_APB1RST @ hex. RCU_APB1RST 1b. ;
: RCU_AHBEN. cr ." RCU_AHBEN.  RW   $" RCU_AHBEN @ hex. RCU_AHBEN 1b. ;
: RCU_APB2EN. cr ." RCU_APB2EN.  RW   $" RCU_APB2EN @ hex. RCU_APB2EN 1b. ;
: RCU_APB1EN. cr ." RCU_APB1EN.  RW   $" RCU_APB1EN @ hex. RCU_APB1EN 1b. ;
: RCU_BDCTL. cr ." RCU_BDCTL.   $" RCU_BDCTL @ hex. RCU_BDCTL 1b. ;
: RCU_RSTSCK. cr ." RCU_RSTSCK.   $" RCU_RSTSCK @ hex. RCU_RSTSCK 1b. ;
: RCU_AHBRST. cr ." RCU_AHBRST.  RW   $" RCU_AHBRST @ hex. RCU_AHBRST 1b. ;
: RCU_CFG1. cr ." RCU_CFG1.  RW   $" RCU_CFG1 @ hex. RCU_CFG1 1b. ;
: RCU_DSV. cr ." RCU_DSV.   $" RCU_DSV @ hex. RCU_DSV 1b. ;
: RCU.
RCU_CTL.
RCU_CFG0.
RCU_INT.
RCU_APB2RST.
RCU_APB1RST.
RCU_AHBEN.
RCU_APB2EN.
RCU_APB1EN.
RCU_BDCTL.
RCU_RSTSCK.
RCU_AHBRST.
RCU_CFG1.
RCU_DSV.
;

$40002800 constant RTC \ Real-time clock
RTC $0 + constant RTC_INTEN ( read-write )  \ RTC interrupt enable register
RTC $04 + constant RTC_CTL ( read-write )  \ control register
RTC $08 + constant RTC_PSCH (  )  \ RTC prescaler high register
RTC $0C + constant RTC_PSCL (  )  \  RTC prescaler low  register
RTC $10 + constant RTC_DIVH ( read-only )  \ RTC divider high register
RTC $14 + constant RTC_DIVL ( read-only )  \ RTC divider low register
RTC $18 + constant RTC_CNTH ( read-write )  \ RTC counter high register
RTC $1C + constant RTC_CNTL ( read-write )  \ RTC counter low register
RTC $20 + constant RTC_ALRMH ( write )  \ Alarm high register
RTC $24 + constant RTC_ALRML ( write )  \ RTC alarm low register
: RTC_INTEN. cr ." RTC_INTEN.  RW   $" RTC_INTEN @ hex. RTC_INTEN 1b. ;
: RTC_CTL. cr ." RTC_CTL.  RW   $" RTC_CTL @ hex. RTC_CTL 1b. ;
: RTC_PSCH. cr ." RTC_PSCH.   $" RTC_PSCH @ hex. RTC_PSCH 1b. ;
: RTC_PSCL. cr ." RTC_PSCL.   $" RTC_PSCL @ hex. RTC_PSCL 1b. ;
: RTC_DIVH. cr ." RTC_DIVH.  RO   $" RTC_DIVH @ hex. RTC_DIVH 1b. ;
: RTC_DIVL. cr ." RTC_DIVL.  RO   $" RTC_DIVL @ hex. RTC_DIVL 1b. ;
: RTC_CNTH. cr ." RTC_CNTH.  RW   $" RTC_CNTH @ hex. RTC_CNTH 1b. ;
: RTC_CNTL. cr ." RTC_CNTL.  RW   $" RTC_CNTL @ hex. RTC_CNTL 1b. ;
: RTC_ALRMH. cr ." RTC_ALRMH.   $" RTC_ALRMH @ hex. RTC_ALRMH 1b. ;
: RTC_ALRML. cr ." RTC_ALRML.   $" RTC_ALRML @ hex. RTC_ALRML 1b. ;
: RTC.
RTC_INTEN.
RTC_CTL.
RTC_PSCH.
RTC_PSCL.
RTC_DIVH.
RTC_DIVL.
RTC_CNTH.
RTC_CNTL.
RTC_ALRMH.
RTC_ALRML.
;

$40013000 constant SPI0 \ Serial peripheral interface
SPI0 $0 + constant SPI0_CTL0 ( read-write )  \ control register 0
SPI0 $04 + constant SPI0_CTL1 ( read-write )  \ control register 1
SPI0 $08 + constant SPI0_STAT (  )  \ status register
SPI0 $0C + constant SPI0_DATA ( read-write )  \ data register
SPI0 $10 + constant SPI0_CRCPOLY ( read-write )  \ CRC polynomial register
SPI0 $14 + constant SPI0_RCRC ( read-only )  \ RX CRC register
SPI0 $18 + constant SPI0_TCRC ( read-only )  \ TX CRC register
SPI0 $1C + constant SPI0_I2SCTL ( read-write )  \ I2S control register
SPI0 $20 + constant SPI0_I2SPSC ( read-write )  \ I2S prescaler register
: SPI0_CTL0. cr ." SPI0_CTL0.  RW   $" SPI0_CTL0 @ hex. SPI0_CTL0 1b. ;
: SPI0_CTL1. cr ." SPI0_CTL1.  RW   $" SPI0_CTL1 @ hex. SPI0_CTL1 1b. ;
: SPI0_STAT. cr ." SPI0_STAT.   $" SPI0_STAT @ hex. SPI0_STAT 1b. ;
: SPI0_DATA. cr ." SPI0_DATA.  RW   $" SPI0_DATA @ hex. SPI0_DATA 1b. ;
: SPI0_CRCPOLY. cr ." SPI0_CRCPOLY.  RW   $" SPI0_CRCPOLY @ hex. SPI0_CRCPOLY 1b. ;
: SPI0_RCRC. cr ." SPI0_RCRC.  RO   $" SPI0_RCRC @ hex. SPI0_RCRC 1b. ;
: SPI0_TCRC. cr ." SPI0_TCRC.  RO   $" SPI0_TCRC @ hex. SPI0_TCRC 1b. ;
: SPI0_I2SCTL. cr ." SPI0_I2SCTL.  RW   $" SPI0_I2SCTL @ hex. SPI0_I2SCTL 1b. ;
: SPI0_I2SPSC. cr ." SPI0_I2SPSC.  RW   $" SPI0_I2SPSC @ hex. SPI0_I2SPSC 1b. ;
: SPI0.
SPI0_CTL0.
SPI0_CTL1.
SPI0_STAT.
SPI0_DATA.
SPI0_CRCPOLY.
SPI0_RCRC.
SPI0_TCRC.
SPI0_I2SCTL.
SPI0_I2SPSC.
;

$40003800 constant SPI1 \ Serial peripheral interface
SPI1 $0 + constant SPI1_CTL0 ( read-write )  \ control register 0
SPI1 $04 + constant SPI1_CTL1 ( read-write )  \ control register 1
SPI1 $08 + constant SPI1_STAT (  )  \ status register
SPI1 $0C + constant SPI1_DATA ( read-write )  \ data register
SPI1 $10 + constant SPI1_CRCPOLY ( read-write )  \ CRC polynomial register
SPI1 $14 + constant SPI1_RCRC ( read-only )  \ RX CRC register
SPI1 $18 + constant SPI1_TCRC ( read-only )  \ TX CRC register
SPI1 $1C + constant SPI1_I2SCTL ( read-write )  \ I2S control register
SPI1 $20 + constant SPI1_I2SPSC ( read-write )  \ I2S prescaler register
: SPI1_CTL0. cr ." SPI1_CTL0.  RW   $" SPI1_CTL0 @ hex. SPI1_CTL0 1b. ;
: SPI1_CTL1. cr ." SPI1_CTL1.  RW   $" SPI1_CTL1 @ hex. SPI1_CTL1 1b. ;
: SPI1_STAT. cr ." SPI1_STAT.   $" SPI1_STAT @ hex. SPI1_STAT 1b. ;
: SPI1_DATA. cr ." SPI1_DATA.  RW   $" SPI1_DATA @ hex. SPI1_DATA 1b. ;
: SPI1_CRCPOLY. cr ." SPI1_CRCPOLY.  RW   $" SPI1_CRCPOLY @ hex. SPI1_CRCPOLY 1b. ;
: SPI1_RCRC. cr ." SPI1_RCRC.  RO   $" SPI1_RCRC @ hex. SPI1_RCRC 1b. ;
: SPI1_TCRC. cr ." SPI1_TCRC.  RO   $" SPI1_TCRC @ hex. SPI1_TCRC 1b. ;
: SPI1_I2SCTL. cr ." SPI1_I2SCTL.  RW   $" SPI1_I2SCTL @ hex. SPI1_I2SCTL 1b. ;
: SPI1_I2SPSC. cr ." SPI1_I2SPSC.  RW   $" SPI1_I2SPSC @ hex. SPI1_I2SPSC 1b. ;
: SPI1.
SPI1_CTL0.
SPI1_CTL1.
SPI1_STAT.
SPI1_DATA.
SPI1_CRCPOLY.
SPI1_RCRC.
SPI1_TCRC.
SPI1_I2SCTL.
SPI1_I2SPSC.
;

$40003C00 constant SPI2 \ Serial peripheral interface
SPI2 $0 + constant SPI2_CTL0 ( read-write )  \ control register 0
SPI2 $04 + constant SPI2_CTL1 ( read-write )  \ control register 1
SPI2 $08 + constant SPI2_STAT (  )  \ status register
SPI2 $0C + constant SPI2_DATA ( read-write )  \ data register
SPI2 $10 + constant SPI2_CRCPOLY ( read-write )  \ CRC polynomial register
SPI2 $14 + constant SPI2_RCRC ( read-only )  \ RX CRC register
SPI2 $18 + constant SPI2_TCRC ( read-only )  \ TX CRC register
SPI2 $1C + constant SPI2_I2SCTL ( read-write )  \ I2S control register
SPI2 $20 + constant SPI2_I2SPSC ( read-write )  \ I2S prescaler register
: SPI2_CTL0. cr ." SPI2_CTL0.  RW   $" SPI2_CTL0 @ hex. SPI2_CTL0 1b. ;
: SPI2_CTL1. cr ." SPI2_CTL1.  RW   $" SPI2_CTL1 @ hex. SPI2_CTL1 1b. ;
: SPI2_STAT. cr ." SPI2_STAT.   $" SPI2_STAT @ hex. SPI2_STAT 1b. ;
: SPI2_DATA. cr ." SPI2_DATA.  RW   $" SPI2_DATA @ hex. SPI2_DATA 1b. ;
: SPI2_CRCPOLY. cr ." SPI2_CRCPOLY.  RW   $" SPI2_CRCPOLY @ hex. SPI2_CRCPOLY 1b. ;
: SPI2_RCRC. cr ." SPI2_RCRC.  RO   $" SPI2_RCRC @ hex. SPI2_RCRC 1b. ;
: SPI2_TCRC. cr ." SPI2_TCRC.  RO   $" SPI2_TCRC @ hex. SPI2_TCRC 1b. ;
: SPI2_I2SCTL. cr ." SPI2_I2SCTL.  RW   $" SPI2_I2SCTL @ hex. SPI2_I2SCTL 1b. ;
: SPI2_I2SPSC. cr ." SPI2_I2SPSC.  RW   $" SPI2_I2SPSC @ hex. SPI2_I2SPSC 1b. ;
: SPI2.
SPI2_CTL0.
SPI2_CTL1.
SPI2_STAT.
SPI2_DATA.
SPI2_CRCPOLY.
SPI2_RCRC.
SPI2_TCRC.
SPI2_I2SCTL.
SPI2_I2SPSC.
;

$40012c00 constant TIMER0 \ Advanced-timers
TIMER0 $0 + constant TIMER0_CTL0 ( read-write )  \ control register 0
TIMER0 $04 + constant TIMER0_CTL1 ( read-write )  \ control register 1
TIMER0 $08 + constant TIMER0_SMCFG ( read-write )  \ slave mode configuration register
TIMER0 $0C + constant TIMER0_DMAINTEN ( read-write )  \ DMA/Interrupt enable register
TIMER0 $10 + constant TIMER0_INTF ( read-write )  \ Interrupt flag register
TIMER0 $14 + constant TIMER0_SWEVG ( write-only )  \ Software event generation register
TIMER0 $18 + constant TIMER0_CHCTL0_Output ( read-write )  \ Channel control register 0 output  mode
TIMER0 $18 + constant TIMER0_CHCTL0_Input ( read-write )  \ Channel control register 0 input  mode
TIMER0 $1C + constant TIMER0_CHCTL1_Output ( read-write )  \ Channel control register 1 output  mode
TIMER0 $1C + constant TIMER0_CHCTL1_Input ( read-write )  \ Channel control register 1 input  mode
TIMER0 $20 + constant TIMER0_CHCTL2 ( read-write )  \ Channel control register 2
TIMER0 $24 + constant TIMER0_CNT ( read-write )  \ counter
TIMER0 $28 + constant TIMER0_PSC ( read-write )  \ prescaler
TIMER0 $2C + constant TIMER0_CAR ( read-write )  \ Counter auto reload register
TIMER0 $30 + constant TIMER0_CREP ( read-write )  \ Counter repetition register
TIMER0 $34 + constant TIMER0_CH0CV ( read-write )  \ Channel 0 capture/compare value register
TIMER0 $38 + constant TIMER0_CH1CV ( read-write )  \ Channel 1 capture/compare value register
TIMER0 $3C + constant TIMER0_CH2CV ( read-write )  \ Channel 2 capture/compare value register
TIMER0 $40 + constant TIMER0_CH3CV ( read-write )  \ Channel 3 capture/compare value register
TIMER0 $44 + constant TIMER0_CCHP ( read-write )  \ channel complementary protection register
TIMER0 $48 + constant TIMER0_DMACFG ( read-write )  \ DMA configuration register
TIMER0 $4C + constant TIMER0_DMATB ( read-write )  \ DMA transfer buffer register
: TIMER0_CTL0. cr ." TIMER0_CTL0.  RW   $" TIMER0_CTL0 @ hex. TIMER0_CTL0 1b. ;
: TIMER0_CTL1. cr ." TIMER0_CTL1.  RW   $" TIMER0_CTL1 @ hex. TIMER0_CTL1 1b. ;
: TIMER0_SMCFG. cr ." TIMER0_SMCFG.  RW   $" TIMER0_SMCFG @ hex. TIMER0_SMCFG 1b. ;
: TIMER0_DMAINTEN. cr ." TIMER0_DMAINTEN.  RW   $" TIMER0_DMAINTEN @ hex. TIMER0_DMAINTEN 1b. ;
: TIMER0_INTF. cr ." TIMER0_INTF.  RW   $" TIMER0_INTF @ hex. TIMER0_INTF 1b. ;
: TIMER0_SWEVG. cr ." TIMER0_SWEVG " WRITEONLY ; 
: TIMER0_CHCTL0_Output. cr ." TIMER0_CHCTL0_Output.  RW   $" TIMER0_CHCTL0_Output @ hex. TIMER0_CHCTL0_Output 1b. ;
: TIMER0_CHCTL0_Input. cr ." TIMER0_CHCTL0_Input.  RW   $" TIMER0_CHCTL0_Input @ hex. TIMER0_CHCTL0_Input 1b. ;
: TIMER0_CHCTL1_Output. cr ." TIMER0_CHCTL1_Output.  RW   $" TIMER0_CHCTL1_Output @ hex. TIMER0_CHCTL1_Output 1b. ;
: TIMER0_CHCTL1_Input. cr ." TIMER0_CHCTL1_Input.  RW   $" TIMER0_CHCTL1_Input @ hex. TIMER0_CHCTL1_Input 1b. ;
: TIMER0_CHCTL2. cr ." TIMER0_CHCTL2.  RW   $" TIMER0_CHCTL2 @ hex. TIMER0_CHCTL2 1b. ;
: TIMER0_CNT. cr ." TIMER0_CNT.  RW   $" TIMER0_CNT @ hex. TIMER0_CNT 1b. ;
: TIMER0_PSC. cr ." TIMER0_PSC.  RW   $" TIMER0_PSC @ hex. TIMER0_PSC 1b. ;
: TIMER0_CAR. cr ." TIMER0_CAR.  RW   $" TIMER0_CAR @ hex. TIMER0_CAR 1b. ;
: TIMER0_CREP. cr ." TIMER0_CREP.  RW   $" TIMER0_CREP @ hex. TIMER0_CREP 1b. ;
: TIMER0_CH0CV. cr ." TIMER0_CH0CV.  RW   $" TIMER0_CH0CV @ hex. TIMER0_CH0CV 1b. ;
: TIMER0_CH1CV. cr ." TIMER0_CH1CV.  RW   $" TIMER0_CH1CV @ hex. TIMER0_CH1CV 1b. ;
: TIMER0_CH2CV. cr ." TIMER0_CH2CV.  RW   $" TIMER0_CH2CV @ hex. TIMER0_CH2CV 1b. ;
: TIMER0_CH3CV. cr ." TIMER0_CH3CV.  RW   $" TIMER0_CH3CV @ hex. TIMER0_CH3CV 1b. ;
: TIMER0_CCHP. cr ." TIMER0_CCHP.  RW   $" TIMER0_CCHP @ hex. TIMER0_CCHP 1b. ;
: TIMER0_DMACFG. cr ." TIMER0_DMACFG.  RW   $" TIMER0_DMACFG @ hex. TIMER0_DMACFG 1b. ;
: TIMER0_DMATB. cr ." TIMER0_DMATB.  RW   $" TIMER0_DMATB @ hex. TIMER0_DMATB 1b. ;
: TIMER0.
TIMER0_CTL0.
TIMER0_CTL1.
TIMER0_SMCFG.
TIMER0_DMAINTEN.
TIMER0_INTF.
TIMER0_SWEVG.
TIMER0_CHCTL0_Output.
TIMER0_CHCTL0_Input.
TIMER0_CHCTL1_Output.
TIMER0_CHCTL1_Input.
TIMER0_CHCTL2.
TIMER0_CNT.
TIMER0_PSC.
TIMER0_CAR.
TIMER0_CREP.
TIMER0_CH0CV.
TIMER0_CH1CV.
TIMER0_CH2CV.
TIMER0_CH3CV.
TIMER0_CCHP.
TIMER0_DMACFG.
TIMER0_DMATB.
;

$40000000 constant TIMER1 \ General-purpose-timers
TIMER1 $0 + constant TIMER1_CTL0 ( read-write )  \ control register 0
TIMER1 $04 + constant TIMER1_CTL1 ( read-write )  \ control register 1
TIMER1 $08 + constant TIMER1_SMCFG ( read-write )  \ slave mode control register
TIMER1 $0C + constant TIMER1_DMAINTEN ( read-write )  \ DMA/Interrupt enable register
TIMER1 $10 + constant TIMER1_INTF ( read-write )  \ interrupt flag register
TIMER1 $14 + constant TIMER1_SWEVG ( write-only )  \ event generation register
TIMER1 $18 + constant TIMER1_CHCTL0_Output ( read-write )  \ Channel control register 0 output  mode
TIMER1 $18 + constant TIMER1_CHCTL0_Input ( read-write )  \ Channel control register 0 input  mode
TIMER1 $1C + constant TIMER1_CHCTL1_Output ( read-write )  \ Channel control register 1 output mode
TIMER1 $1C + constant TIMER1_CHCTL1_Input ( read-write )  \ Channel control register 1 input  mode
TIMER1 $20 + constant TIMER1_CHCTL2 ( read-write )  \ Channel control register 2
TIMER1 $24 + constant TIMER1_CNT ( read-write )  \ Counter register
TIMER1 $28 + constant TIMER1_PSC ( read-write )  \ Prescaler register
TIMER1 $2C + constant TIMER1_CAR ( read-write )  \ Counter auto reload register
TIMER1 $34 + constant TIMER1_CH0CV ( read-write )  \ Channel 0 capture/compare value register
TIMER1 $38 + constant TIMER1_CH1CV ( read-write )  \ Channel 1 capture/compare value register
TIMER1 $3C + constant TIMER1_CH2CV ( read-write )  \ Channel 2 capture/compare value register
TIMER1 $40 + constant TIMER1_CH3CV ( read-write )  \ Channel 3 capture/compare value register
TIMER1 $48 + constant TIMER1_DMACFG ( read-write )  \ DMA configuration register
TIMER1 $4C + constant TIMER1_DMATB ( read-write )  \ DMA transfer buffer register
: TIMER1_CTL0. cr ." TIMER1_CTL0.  RW   $" TIMER1_CTL0 @ hex. TIMER1_CTL0 1b. ;
: TIMER1_CTL1. cr ." TIMER1_CTL1.  RW   $" TIMER1_CTL1 @ hex. TIMER1_CTL1 1b. ;
: TIMER1_SMCFG. cr ." TIMER1_SMCFG.  RW   $" TIMER1_SMCFG @ hex. TIMER1_SMCFG 1b. ;
: TIMER1_DMAINTEN. cr ." TIMER1_DMAINTEN.  RW   $" TIMER1_DMAINTEN @ hex. TIMER1_DMAINTEN 1b. ;
: TIMER1_INTF. cr ." TIMER1_INTF.  RW   $" TIMER1_INTF @ hex. TIMER1_INTF 1b. ;
: TIMER1_SWEVG. cr ." TIMER1_SWEVG " WRITEONLY ; 
: TIMER1_CHCTL0_Output. cr ." TIMER1_CHCTL0_Output.  RW   $" TIMER1_CHCTL0_Output @ hex. TIMER1_CHCTL0_Output 1b. ;
: TIMER1_CHCTL0_Input. cr ." TIMER1_CHCTL0_Input.  RW   $" TIMER1_CHCTL0_Input @ hex. TIMER1_CHCTL0_Input 1b. ;
: TIMER1_CHCTL1_Output. cr ." TIMER1_CHCTL1_Output.  RW   $" TIMER1_CHCTL1_Output @ hex. TIMER1_CHCTL1_Output 1b. ;
: TIMER1_CHCTL1_Input. cr ." TIMER1_CHCTL1_Input.  RW   $" TIMER1_CHCTL1_Input @ hex. TIMER1_CHCTL1_Input 1b. ;
: TIMER1_CHCTL2. cr ." TIMER1_CHCTL2.  RW   $" TIMER1_CHCTL2 @ hex. TIMER1_CHCTL2 1b. ;
: TIMER1_CNT. cr ." TIMER1_CNT.  RW   $" TIMER1_CNT @ hex. TIMER1_CNT 1b. ;
: TIMER1_PSC. cr ." TIMER1_PSC.  RW   $" TIMER1_PSC @ hex. TIMER1_PSC 1b. ;
: TIMER1_CAR. cr ." TIMER1_CAR.  RW   $" TIMER1_CAR @ hex. TIMER1_CAR 1b. ;
: TIMER1_CH0CV. cr ." TIMER1_CH0CV.  RW   $" TIMER1_CH0CV @ hex. TIMER1_CH0CV 1b. ;
: TIMER1_CH1CV. cr ." TIMER1_CH1CV.  RW   $" TIMER1_CH1CV @ hex. TIMER1_CH1CV 1b. ;
: TIMER1_CH2CV. cr ." TIMER1_CH2CV.  RW   $" TIMER1_CH2CV @ hex. TIMER1_CH2CV 1b. ;
: TIMER1_CH3CV. cr ." TIMER1_CH3CV.  RW   $" TIMER1_CH3CV @ hex. TIMER1_CH3CV 1b. ;
: TIMER1_DMACFG. cr ." TIMER1_DMACFG.  RW   $" TIMER1_DMACFG @ hex. TIMER1_DMACFG 1b. ;
: TIMER1_DMATB. cr ." TIMER1_DMATB.  RW   $" TIMER1_DMATB @ hex. TIMER1_DMATB 1b. ;
: TIMER1.
TIMER1_CTL0.
TIMER1_CTL1.
TIMER1_SMCFG.
TIMER1_DMAINTEN.
TIMER1_INTF.
TIMER1_SWEVG.
TIMER1_CHCTL0_Output.
TIMER1_CHCTL0_Input.
TIMER1_CHCTL1_Output.
TIMER1_CHCTL1_Input.
TIMER1_CHCTL2.
TIMER1_CNT.
TIMER1_PSC.
TIMER1_CAR.
TIMER1_CH0CV.
TIMER1_CH1CV.
TIMER1_CH2CV.
TIMER1_CH3CV.
TIMER1_DMACFG.
TIMER1_DMATB.
;

$40000400 constant TIMER2 \ General-purpose-timers
TIMER2 $0 + constant TIMER2_CTL0 ( read-write )  \ control register 0
TIMER2 $04 + constant TIMER2_CTL1 ( read-write )  \ control register 1
TIMER2 $08 + constant TIMER2_SMCFG ( read-write )  \ slave mode control register
TIMER2 $0C + constant TIMER2_DMAINTEN ( read-write )  \ DMA/Interrupt enable register
TIMER2 $10 + constant TIMER2_INTF ( read-write )  \ interrupt flag register
TIMER2 $14 + constant TIMER2_SWEVG ( write-only )  \ event generation register
TIMER2 $18 + constant TIMER2_CHCTL0_Output ( read-write )  \ Channel control register 0 output  mode
TIMER2 $18 + constant TIMER2_CHCTL0_Input ( read-write )  \ Channel control register 0 input  mode
TIMER2 $1C + constant TIMER2_CHCTL1_Output ( read-write )  \ Channel control register 1 output mode
TIMER2 $1C + constant TIMER2_CHCTL1_Input ( read-write )  \ Channel control register 1 input  mode
TIMER2 $20 + constant TIMER2_CHCTL2 ( read-write )  \ Channel control register 2
TIMER2 $24 + constant TIMER2_CNT ( read-write )  \ Counter register
TIMER2 $28 + constant TIMER2_PSC ( read-write )  \ Prescaler register
TIMER2 $2C + constant TIMER2_CAR ( read-write )  \ Counter auto reload register
TIMER2 $34 + constant TIMER2_CH0CV ( read-write )  \ Channel 0 capture/compare value register
TIMER2 $38 + constant TIMER2_CH1CV ( read-write )  \ Channel 1 capture/compare value register
TIMER2 $3C + constant TIMER2_CH2CV ( read-write )  \ Channel 2 capture/compare value register
TIMER2 $40 + constant TIMER2_CH3CV ( read-write )  \ Channel 3 capture/compare value register
TIMER2 $48 + constant TIMER2_DMACFG ( read-write )  \ DMA configuration register
TIMER2 $4C + constant TIMER2_DMATB ( read-write )  \ DMA transfer buffer register
: TIMER2_CTL0. cr ." TIMER2_CTL0.  RW   $" TIMER2_CTL0 @ hex. TIMER2_CTL0 1b. ;
: TIMER2_CTL1. cr ." TIMER2_CTL1.  RW   $" TIMER2_CTL1 @ hex. TIMER2_CTL1 1b. ;
: TIMER2_SMCFG. cr ." TIMER2_SMCFG.  RW   $" TIMER2_SMCFG @ hex. TIMER2_SMCFG 1b. ;
: TIMER2_DMAINTEN. cr ." TIMER2_DMAINTEN.  RW   $" TIMER2_DMAINTEN @ hex. TIMER2_DMAINTEN 1b. ;
: TIMER2_INTF. cr ." TIMER2_INTF.  RW   $" TIMER2_INTF @ hex. TIMER2_INTF 1b. ;
: TIMER2_SWEVG. cr ." TIMER2_SWEVG " WRITEONLY ; 
: TIMER2_CHCTL0_Output. cr ." TIMER2_CHCTL0_Output.  RW   $" TIMER2_CHCTL0_Output @ hex. TIMER2_CHCTL0_Output 1b. ;
: TIMER2_CHCTL0_Input. cr ." TIMER2_CHCTL0_Input.  RW   $" TIMER2_CHCTL0_Input @ hex. TIMER2_CHCTL0_Input 1b. ;
: TIMER2_CHCTL1_Output. cr ." TIMER2_CHCTL1_Output.  RW   $" TIMER2_CHCTL1_Output @ hex. TIMER2_CHCTL1_Output 1b. ;
: TIMER2_CHCTL1_Input. cr ." TIMER2_CHCTL1_Input.  RW   $" TIMER2_CHCTL1_Input @ hex. TIMER2_CHCTL1_Input 1b. ;
: TIMER2_CHCTL2. cr ." TIMER2_CHCTL2.  RW   $" TIMER2_CHCTL2 @ hex. TIMER2_CHCTL2 1b. ;
: TIMER2_CNT. cr ." TIMER2_CNT.  RW   $" TIMER2_CNT @ hex. TIMER2_CNT 1b. ;
: TIMER2_PSC. cr ." TIMER2_PSC.  RW   $" TIMER2_PSC @ hex. TIMER2_PSC 1b. ;
: TIMER2_CAR. cr ." TIMER2_CAR.  RW   $" TIMER2_CAR @ hex. TIMER2_CAR 1b. ;
: TIMER2_CH0CV. cr ." TIMER2_CH0CV.  RW   $" TIMER2_CH0CV @ hex. TIMER2_CH0CV 1b. ;
: TIMER2_CH1CV. cr ." TIMER2_CH1CV.  RW   $" TIMER2_CH1CV @ hex. TIMER2_CH1CV 1b. ;
: TIMER2_CH2CV. cr ." TIMER2_CH2CV.  RW   $" TIMER2_CH2CV @ hex. TIMER2_CH2CV 1b. ;
: TIMER2_CH3CV. cr ." TIMER2_CH3CV.  RW   $" TIMER2_CH3CV @ hex. TIMER2_CH3CV 1b. ;
: TIMER2_DMACFG. cr ." TIMER2_DMACFG.  RW   $" TIMER2_DMACFG @ hex. TIMER2_DMACFG 1b. ;
: TIMER2_DMATB. cr ." TIMER2_DMATB.  RW   $" TIMER2_DMATB @ hex. TIMER2_DMATB 1b. ;
: TIMER2.
TIMER2_CTL0.
TIMER2_CTL1.
TIMER2_SMCFG.
TIMER2_DMAINTEN.
TIMER2_INTF.
TIMER2_SWEVG.
TIMER2_CHCTL0_Output.
TIMER2_CHCTL0_Input.
TIMER2_CHCTL1_Output.
TIMER2_CHCTL1_Input.
TIMER2_CHCTL2.
TIMER2_CNT.
TIMER2_PSC.
TIMER2_CAR.
TIMER2_CH0CV.
TIMER2_CH1CV.
TIMER2_CH2CV.
TIMER2_CH3CV.
TIMER2_DMACFG.
TIMER2_DMATB.
;

$40000800 constant TIMER3 \ General-purpose-timers
TIMER3 $0 + constant TIMER3_CTL0 ( read-write )  \ control register 0
TIMER3 $04 + constant TIMER3_CTL1 ( read-write )  \ control register 1
TIMER3 $08 + constant TIMER3_SMCFG ( read-write )  \ slave mode control register
TIMER3 $0C + constant TIMER3_DMAINTEN ( read-write )  \ DMA/Interrupt enable register
TIMER3 $10 + constant TIMER3_INTF ( read-write )  \ interrupt flag register
TIMER3 $14 + constant TIMER3_SWEVG ( write-only )  \ event generation register
TIMER3 $18 + constant TIMER3_CHCTL0_Output ( read-write )  \ Channel control register 0 output  mode
TIMER3 $18 + constant TIMER3_CHCTL0_Input ( read-write )  \ Channel control register 0 input  mode
TIMER3 $1C + constant TIMER3_CHCTL1_Output ( read-write )  \ Channel control register 1 output mode
TIMER3 $1C + constant TIMER3_CHCTL1_Input ( read-write )  \ Channel control register 1 input  mode
TIMER3 $20 + constant TIMER3_CHCTL2 ( read-write )  \ Channel control register 2
TIMER3 $24 + constant TIMER3_CNT ( read-write )  \ Counter register
TIMER3 $28 + constant TIMER3_PSC ( read-write )  \ Prescaler register
TIMER3 $2C + constant TIMER3_CAR ( read-write )  \ Counter auto reload register
TIMER3 $34 + constant TIMER3_CH0CV ( read-write )  \ Channel 0 capture/compare value register
TIMER3 $38 + constant TIMER3_CH1CV ( read-write )  \ Channel 1 capture/compare value register
TIMER3 $3C + constant TIMER3_CH2CV ( read-write )  \ Channel 2 capture/compare value register
TIMER3 $40 + constant TIMER3_CH3CV ( read-write )  \ Channel 3 capture/compare value register
TIMER3 $48 + constant TIMER3_DMACFG ( read-write )  \ DMA configuration register
TIMER3 $4C + constant TIMER3_DMATB ( read-write )  \ DMA transfer buffer register
: TIMER3_CTL0. cr ." TIMER3_CTL0.  RW   $" TIMER3_CTL0 @ hex. TIMER3_CTL0 1b. ;
: TIMER3_CTL1. cr ." TIMER3_CTL1.  RW   $" TIMER3_CTL1 @ hex. TIMER3_CTL1 1b. ;
: TIMER3_SMCFG. cr ." TIMER3_SMCFG.  RW   $" TIMER3_SMCFG @ hex. TIMER3_SMCFG 1b. ;
: TIMER3_DMAINTEN. cr ." TIMER3_DMAINTEN.  RW   $" TIMER3_DMAINTEN @ hex. TIMER3_DMAINTEN 1b. ;
: TIMER3_INTF. cr ." TIMER3_INTF.  RW   $" TIMER3_INTF @ hex. TIMER3_INTF 1b. ;
: TIMER3_SWEVG. cr ." TIMER3_SWEVG " WRITEONLY ; 
: TIMER3_CHCTL0_Output. cr ." TIMER3_CHCTL0_Output.  RW   $" TIMER3_CHCTL0_Output @ hex. TIMER3_CHCTL0_Output 1b. ;
: TIMER3_CHCTL0_Input. cr ." TIMER3_CHCTL0_Input.  RW   $" TIMER3_CHCTL0_Input @ hex. TIMER3_CHCTL0_Input 1b. ;
: TIMER3_CHCTL1_Output. cr ." TIMER3_CHCTL1_Output.  RW   $" TIMER3_CHCTL1_Output @ hex. TIMER3_CHCTL1_Output 1b. ;
: TIMER3_CHCTL1_Input. cr ." TIMER3_CHCTL1_Input.  RW   $" TIMER3_CHCTL1_Input @ hex. TIMER3_CHCTL1_Input 1b. ;
: TIMER3_CHCTL2. cr ." TIMER3_CHCTL2.  RW   $" TIMER3_CHCTL2 @ hex. TIMER3_CHCTL2 1b. ;
: TIMER3_CNT. cr ." TIMER3_CNT.  RW   $" TIMER3_CNT @ hex. TIMER3_CNT 1b. ;
: TIMER3_PSC. cr ." TIMER3_PSC.  RW   $" TIMER3_PSC @ hex. TIMER3_PSC 1b. ;
: TIMER3_CAR. cr ." TIMER3_CAR.  RW   $" TIMER3_CAR @ hex. TIMER3_CAR 1b. ;
: TIMER3_CH0CV. cr ." TIMER3_CH0CV.  RW   $" TIMER3_CH0CV @ hex. TIMER3_CH0CV 1b. ;
: TIMER3_CH1CV. cr ." TIMER3_CH1CV.  RW   $" TIMER3_CH1CV @ hex. TIMER3_CH1CV 1b. ;
: TIMER3_CH2CV. cr ." TIMER3_CH2CV.  RW   $" TIMER3_CH2CV @ hex. TIMER3_CH2CV 1b. ;
: TIMER3_CH3CV. cr ." TIMER3_CH3CV.  RW   $" TIMER3_CH3CV @ hex. TIMER3_CH3CV 1b. ;
: TIMER3_DMACFG. cr ." TIMER3_DMACFG.  RW   $" TIMER3_DMACFG @ hex. TIMER3_DMACFG 1b. ;
: TIMER3_DMATB. cr ." TIMER3_DMATB.  RW   $" TIMER3_DMATB @ hex. TIMER3_DMATB 1b. ;
: TIMER3.
TIMER3_CTL0.
TIMER3_CTL1.
TIMER3_SMCFG.
TIMER3_DMAINTEN.
TIMER3_INTF.
TIMER3_SWEVG.
TIMER3_CHCTL0_Output.
TIMER3_CHCTL0_Input.
TIMER3_CHCTL1_Output.
TIMER3_CHCTL1_Input.
TIMER3_CHCTL2.
TIMER3_CNT.
TIMER3_PSC.
TIMER3_CAR.
TIMER3_CH0CV.
TIMER3_CH1CV.
TIMER3_CH2CV.
TIMER3_CH3CV.
TIMER3_DMACFG.
TIMER3_DMATB.
;

$40000C00 constant TIMER4 \ General-purpose-timers
TIMER4 $0 + constant TIMER4_CTL0 ( read-write )  \ control register 0
TIMER4 $04 + constant TIMER4_CTL1 ( read-write )  \ control register 1
TIMER4 $08 + constant TIMER4_SMCFG ( read-write )  \ slave mode control register
TIMER4 $0C + constant TIMER4_DMAINTEN ( read-write )  \ DMA/Interrupt enable register
TIMER4 $10 + constant TIMER4_INTF ( read-write )  \ interrupt flag register
TIMER4 $14 + constant TIMER4_SWEVG ( write-only )  \ event generation register
TIMER4 $18 + constant TIMER4_CHCTL0_Output ( read-write )  \ Channel control register 0 output  mode
TIMER4 $18 + constant TIMER4_CHCTL0_Input ( read-write )  \ Channel control register 0 input  mode
TIMER4 $1C + constant TIMER4_CHCTL1_Output ( read-write )  \ Channel control register 1 output mode
TIMER4 $1C + constant TIMER4_CHCTL1_Input ( read-write )  \ Channel control register 1 input  mode
TIMER4 $20 + constant TIMER4_CHCTL2 ( read-write )  \ Channel control register 2
TIMER4 $24 + constant TIMER4_CNT ( read-write )  \ Counter register
TIMER4 $28 + constant TIMER4_PSC ( read-write )  \ Prescaler register
TIMER4 $2C + constant TIMER4_CAR ( read-write )  \ Counter auto reload register
TIMER4 $34 + constant TIMER4_CH0CV ( read-write )  \ Channel 0 capture/compare value register
TIMER4 $38 + constant TIMER4_CH1CV ( read-write )  \ Channel 1 capture/compare value register
TIMER4 $3C + constant TIMER4_CH2CV ( read-write )  \ Channel 2 capture/compare value register
TIMER4 $40 + constant TIMER4_CH3CV ( read-write )  \ Channel 3 capture/compare value register
TIMER4 $48 + constant TIMER4_DMACFG ( read-write )  \ DMA configuration register
TIMER4 $4C + constant TIMER4_DMATB ( read-write )  \ DMA transfer buffer register
: TIMER4_CTL0. cr ." TIMER4_CTL0.  RW   $" TIMER4_CTL0 @ hex. TIMER4_CTL0 1b. ;
: TIMER4_CTL1. cr ." TIMER4_CTL1.  RW   $" TIMER4_CTL1 @ hex. TIMER4_CTL1 1b. ;
: TIMER4_SMCFG. cr ." TIMER4_SMCFG.  RW   $" TIMER4_SMCFG @ hex. TIMER4_SMCFG 1b. ;
: TIMER4_DMAINTEN. cr ." TIMER4_DMAINTEN.  RW   $" TIMER4_DMAINTEN @ hex. TIMER4_DMAINTEN 1b. ;
: TIMER4_INTF. cr ." TIMER4_INTF.  RW   $" TIMER4_INTF @ hex. TIMER4_INTF 1b. ;
: TIMER4_SWEVG. cr ." TIMER4_SWEVG " WRITEONLY ; 
: TIMER4_CHCTL0_Output. cr ." TIMER4_CHCTL0_Output.  RW   $" TIMER4_CHCTL0_Output @ hex. TIMER4_CHCTL0_Output 1b. ;
: TIMER4_CHCTL0_Input. cr ." TIMER4_CHCTL0_Input.  RW   $" TIMER4_CHCTL0_Input @ hex. TIMER4_CHCTL0_Input 1b. ;
: TIMER4_CHCTL1_Output. cr ." TIMER4_CHCTL1_Output.  RW   $" TIMER4_CHCTL1_Output @ hex. TIMER4_CHCTL1_Output 1b. ;
: TIMER4_CHCTL1_Input. cr ." TIMER4_CHCTL1_Input.  RW   $" TIMER4_CHCTL1_Input @ hex. TIMER4_CHCTL1_Input 1b. ;
: TIMER4_CHCTL2. cr ." TIMER4_CHCTL2.  RW   $" TIMER4_CHCTL2 @ hex. TIMER4_CHCTL2 1b. ;
: TIMER4_CNT. cr ." TIMER4_CNT.  RW   $" TIMER4_CNT @ hex. TIMER4_CNT 1b. ;
: TIMER4_PSC. cr ." TIMER4_PSC.  RW   $" TIMER4_PSC @ hex. TIMER4_PSC 1b. ;
: TIMER4_CAR. cr ." TIMER4_CAR.  RW   $" TIMER4_CAR @ hex. TIMER4_CAR 1b. ;
: TIMER4_CH0CV. cr ." TIMER4_CH0CV.  RW   $" TIMER4_CH0CV @ hex. TIMER4_CH0CV 1b. ;
: TIMER4_CH1CV. cr ." TIMER4_CH1CV.  RW   $" TIMER4_CH1CV @ hex. TIMER4_CH1CV 1b. ;
: TIMER4_CH2CV. cr ." TIMER4_CH2CV.  RW   $" TIMER4_CH2CV @ hex. TIMER4_CH2CV 1b. ;
: TIMER4_CH3CV. cr ." TIMER4_CH3CV.  RW   $" TIMER4_CH3CV @ hex. TIMER4_CH3CV 1b. ;
: TIMER4_DMACFG. cr ." TIMER4_DMACFG.  RW   $" TIMER4_DMACFG @ hex. TIMER4_DMACFG 1b. ;
: TIMER4_DMATB. cr ." TIMER4_DMATB.  RW   $" TIMER4_DMATB @ hex. TIMER4_DMATB 1b. ;
: TIMER4.
TIMER4_CTL0.
TIMER4_CTL1.
TIMER4_SMCFG.
TIMER4_DMAINTEN.
TIMER4_INTF.
TIMER4_SWEVG.
TIMER4_CHCTL0_Output.
TIMER4_CHCTL0_Input.
TIMER4_CHCTL1_Output.
TIMER4_CHCTL1_Input.
TIMER4_CHCTL2.
TIMER4_CNT.
TIMER4_PSC.
TIMER4_CAR.
TIMER4_CH0CV.
TIMER4_CH1CV.
TIMER4_CH2CV.
TIMER4_CH3CV.
TIMER4_DMACFG.
TIMER4_DMATB.
;

$40001000 constant TIMER5 \ Basic-timers
TIMER5 $0 + constant TIMER5_CTL0 ( read-write )  \ control register 0
TIMER5 $04 + constant TIMER5_CTL1 ( read-write )  \ control register 1
TIMER5 $0C + constant TIMER5_DMAINTEN ( read-write )  \ DMA/Interrupt enable register
TIMER5 $10 + constant TIMER5_INTF ( read-write )  \ Interrupt flag register
TIMER5 $14 + constant TIMER5_SWEVG ( write-only )  \ event generation register
TIMER5 $24 + constant TIMER5_CNT ( read-write )  \ Counter register
TIMER5 $28 + constant TIMER5_PSC ( read-write )  \ Prescaler register
TIMER5 $2C + constant TIMER5_CAR ( read-write )  \ Counter auto reload register
: TIMER5_CTL0. cr ." TIMER5_CTL0.  RW   $" TIMER5_CTL0 @ hex. TIMER5_CTL0 1b. ;
: TIMER5_CTL1. cr ." TIMER5_CTL1.  RW   $" TIMER5_CTL1 @ hex. TIMER5_CTL1 1b. ;
: TIMER5_DMAINTEN. cr ." TIMER5_DMAINTEN.  RW   $" TIMER5_DMAINTEN @ hex. TIMER5_DMAINTEN 1b. ;
: TIMER5_INTF. cr ." TIMER5_INTF.  RW   $" TIMER5_INTF @ hex. TIMER5_INTF 1b. ;
: TIMER5_SWEVG. cr ." TIMER5_SWEVG " WRITEONLY ; 
: TIMER5_CNT. cr ." TIMER5_CNT.  RW   $" TIMER5_CNT @ hex. TIMER5_CNT 1b. ;
: TIMER5_PSC. cr ." TIMER5_PSC.  RW   $" TIMER5_PSC @ hex. TIMER5_PSC 1b. ;
: TIMER5_CAR. cr ." TIMER5_CAR.  RW   $" TIMER5_CAR @ hex. TIMER5_CAR 1b. ;
: TIMER5.
TIMER5_CTL0.
TIMER5_CTL1.
TIMER5_DMAINTEN.
TIMER5_INTF.
TIMER5_SWEVG.
TIMER5_CNT.
TIMER5_PSC.
TIMER5_CAR.
;

$40001400 constant TIMER6 \ Basic-timers
TIMER6 $0 + constant TIMER6_CTL0 ( read-write )  \ control register 0
TIMER6 $04 + constant TIMER6_CTL1 ( read-write )  \ control register 1
TIMER6 $0C + constant TIMER6_DMAINTEN ( read-write )  \ DMA/Interrupt enable register
TIMER6 $10 + constant TIMER6_INTF ( read-write )  \ Interrupt flag register
TIMER6 $14 + constant TIMER6_SWEVG ( write-only )  \ event generation register
TIMER6 $24 + constant TIMER6_CNT ( read-write )  \ Counter register
TIMER6 $28 + constant TIMER6_PSC ( read-write )  \ Prescaler register
TIMER6 $2C + constant TIMER6_CAR ( read-write )  \ Counter auto reload register
: TIMER6_CTL0. cr ." TIMER6_CTL0.  RW   $" TIMER6_CTL0 @ hex. TIMER6_CTL0 1b. ;
: TIMER6_CTL1. cr ." TIMER6_CTL1.  RW   $" TIMER6_CTL1 @ hex. TIMER6_CTL1 1b. ;
: TIMER6_DMAINTEN. cr ." TIMER6_DMAINTEN.  RW   $" TIMER6_DMAINTEN @ hex. TIMER6_DMAINTEN 1b. ;
: TIMER6_INTF. cr ." TIMER6_INTF.  RW   $" TIMER6_INTF @ hex. TIMER6_INTF 1b. ;
: TIMER6_SWEVG. cr ." TIMER6_SWEVG " WRITEONLY ; 
: TIMER6_CNT. cr ." TIMER6_CNT.  RW   $" TIMER6_CNT @ hex. TIMER6_CNT 1b. ;
: TIMER6_PSC. cr ." TIMER6_PSC.  RW   $" TIMER6_PSC @ hex. TIMER6_PSC 1b. ;
: TIMER6_CAR. cr ." TIMER6_CAR.  RW   $" TIMER6_CAR @ hex. TIMER6_CAR 1b. ;
: TIMER6.
TIMER6_CTL0.
TIMER6_CTL1.
TIMER6_DMAINTEN.
TIMER6_INTF.
TIMER6_SWEVG.
TIMER6_CNT.
TIMER6_PSC.
TIMER6_CAR.
;

$40013800 constant USART0 \ Universal synchronous asynchronous receiver  transmitter
USART0 $00 + constant USART0_STAT (  )  \ Status register 
USART0 $04 + constant USART0_DATA ( read-write )  \ Data register
USART0 $08 + constant USART0_BAUD ( read-write )  \ Baud rate register
USART0 $0C + constant USART0_CTL0 ( read-write )  \ Control register 0
USART0 $10 + constant USART0_CTL1 ( read-write )  \ Control register 1
USART0 $14 + constant USART0_CTL2 ( read-write )  \ Control register 2
USART0 $18 + constant USART0_GP ( read-write )  \ Guard time and prescaler  register
: USART0_STAT. cr ." USART0_STAT.   $" USART0_STAT @ hex. USART0_STAT 1b. ;
: USART0_DATA. cr ." USART0_DATA.  RW   $" USART0_DATA @ hex. USART0_DATA 1b. ;
: USART0_BAUD. cr ." USART0_BAUD.  RW   $" USART0_BAUD @ hex. USART0_BAUD 1b. ;
: USART0_CTL0. cr ." USART0_CTL0.  RW   $" USART0_CTL0 @ hex. USART0_CTL0 1b. ;
: USART0_CTL1. cr ." USART0_CTL1.  RW   $" USART0_CTL1 @ hex. USART0_CTL1 1b. ;
: USART0_CTL2. cr ." USART0_CTL2.  RW   $" USART0_CTL2 @ hex. USART0_CTL2 1b. ;
: USART0_GP. cr ." USART0_GP.  RW   $" USART0_GP @ hex. USART0_GP 1b. ;
: USART0.
USART0_STAT.
USART0_DATA.
USART0_BAUD.
USART0_CTL0.
USART0_CTL1.
USART0_CTL2.
USART0_GP.
;

$40004400 constant USART1 \ Universal synchronous asynchronous receiver  transmitter
USART1 $00 + constant USART1_STAT (  )  \ Status register 
USART1 $04 + constant USART1_DATA ( read-write )  \ Data register
USART1 $08 + constant USART1_BAUD ( read-write )  \ Baud rate register
USART1 $0C + constant USART1_CTL0 ( read-write )  \ Control register 0
USART1 $10 + constant USART1_CTL1 ( read-write )  \ Control register 1
USART1 $14 + constant USART1_CTL2 ( read-write )  \ Control register 2
USART1 $18 + constant USART1_GP ( read-write )  \ Guard time and prescaler  register
: USART1_STAT. cr ." USART1_STAT.   $" USART1_STAT @ hex. USART1_STAT 1b. ;
: USART1_DATA. cr ." USART1_DATA.  RW   $" USART1_DATA @ hex. USART1_DATA 1b. ;
: USART1_BAUD. cr ." USART1_BAUD.  RW   $" USART1_BAUD @ hex. USART1_BAUD 1b. ;
: USART1_CTL0. cr ." USART1_CTL0.  RW   $" USART1_CTL0 @ hex. USART1_CTL0 1b. ;
: USART1_CTL1. cr ." USART1_CTL1.  RW   $" USART1_CTL1 @ hex. USART1_CTL1 1b. ;
: USART1_CTL2. cr ." USART1_CTL2.  RW   $" USART1_CTL2 @ hex. USART1_CTL2 1b. ;
: USART1_GP. cr ." USART1_GP.  RW   $" USART1_GP @ hex. USART1_GP 1b. ;
: USART1.
USART1_STAT.
USART1_DATA.
USART1_BAUD.
USART1_CTL0.
USART1_CTL1.
USART1_CTL2.
USART1_GP.
;

$40004800 constant USART2 \ Universal synchronous asynchronous receiver  transmitter
USART2 $00 + constant USART2_STAT (  )  \ Status register 
USART2 $04 + constant USART2_DATA ( read-write )  \ Data register
USART2 $08 + constant USART2_BAUD ( read-write )  \ Baud rate register
USART2 $0C + constant USART2_CTL0 ( read-write )  \ Control register 0
USART2 $10 + constant USART2_CTL1 ( read-write )  \ Control register 1
USART2 $14 + constant USART2_CTL2 ( read-write )  \ Control register 2
USART2 $18 + constant USART2_GP ( read-write )  \ Guard time and prescaler  register
: USART2_STAT. cr ." USART2_STAT.   $" USART2_STAT @ hex. USART2_STAT 1b. ;
: USART2_DATA. cr ." USART2_DATA.  RW   $" USART2_DATA @ hex. USART2_DATA 1b. ;
: USART2_BAUD. cr ." USART2_BAUD.  RW   $" USART2_BAUD @ hex. USART2_BAUD 1b. ;
: USART2_CTL0. cr ." USART2_CTL0.  RW   $" USART2_CTL0 @ hex. USART2_CTL0 1b. ;
: USART2_CTL1. cr ." USART2_CTL1.  RW   $" USART2_CTL1 @ hex. USART2_CTL1 1b. ;
: USART2_CTL2. cr ." USART2_CTL2.  RW   $" USART2_CTL2 @ hex. USART2_CTL2 1b. ;
: USART2_GP. cr ." USART2_GP.  RW   $" USART2_GP @ hex. USART2_GP 1b. ;
: USART2.
USART2_STAT.
USART2_DATA.
USART2_BAUD.
USART2_CTL0.
USART2_CTL1.
USART2_CTL2.
USART2_GP.
;

$40004C00 constant UART3 \ Universal asynchronous receiver  transmitter
UART3 $00 + constant UART3_STAT (  )  \ Status register 
UART3 $04 + constant UART3_DATA ( read-write )  \ Data register
UART3 $08 + constant UART3_BAUD ( read-write )  \ Baud rate register
UART3 $0C + constant UART3_CTL0 ( read-write )  \ Control register 0
UART3 $10 + constant UART3_CTL1 ( read-write )  \ Control register 1
UART3 $14 + constant UART3_CTL2 ( read-write )  \ Control register 2
UART3 $18 + constant UART3_GP ( read-write )  \ Guard time and prescaler  register
: UART3_STAT. cr ." UART3_STAT.   $" UART3_STAT @ hex. UART3_STAT 1b. ;
: UART3_DATA. cr ." UART3_DATA.  RW   $" UART3_DATA @ hex. UART3_DATA 1b. ;
: UART3_BAUD. cr ." UART3_BAUD.  RW   $" UART3_BAUD @ hex. UART3_BAUD 1b. ;
: UART3_CTL0. cr ." UART3_CTL0.  RW   $" UART3_CTL0 @ hex. UART3_CTL0 1b. ;
: UART3_CTL1. cr ." UART3_CTL1.  RW   $" UART3_CTL1 @ hex. UART3_CTL1 1b. ;
: UART3_CTL2. cr ." UART3_CTL2.  RW   $" UART3_CTL2 @ hex. UART3_CTL2 1b. ;
: UART3_GP. cr ." UART3_GP.  RW   $" UART3_GP @ hex. UART3_GP 1b. ;
: UART3.
UART3_STAT.
UART3_DATA.
UART3_BAUD.
UART3_CTL0.
UART3_CTL1.
UART3_CTL2.
UART3_GP.
;

$40005000 constant UART4 \ Universal asynchronous receiver  transmitter
UART4 $00 + constant UART4_STAT (  )  \ Status register 
UART4 $04 + constant UART4_DATA ( read-write )  \ Data register
UART4 $08 + constant UART4_BAUD ( read-write )  \ Baud rate register
UART4 $0C + constant UART4_CTL0 ( read-write )  \ Control register 0
UART4 $10 + constant UART4_CTL1 ( read-write )  \ Control register 1
UART4 $14 + constant UART4_CTL2 ( read-write )  \ Control register 2
UART4 $18 + constant UART4_GP ( read-write )  \ Guard time and prescaler  register
: UART4_STAT. cr ." UART4_STAT.   $" UART4_STAT @ hex. UART4_STAT 1b. ;
: UART4_DATA. cr ." UART4_DATA.  RW   $" UART4_DATA @ hex. UART4_DATA 1b. ;
: UART4_BAUD. cr ." UART4_BAUD.  RW   $" UART4_BAUD @ hex. UART4_BAUD 1b. ;
: UART4_CTL0. cr ." UART4_CTL0.  RW   $" UART4_CTL0 @ hex. UART4_CTL0 1b. ;
: UART4_CTL1. cr ." UART4_CTL1.  RW   $" UART4_CTL1 @ hex. UART4_CTL1 1b. ;
: UART4_CTL2. cr ." UART4_CTL2.  RW   $" UART4_CTL2 @ hex. UART4_CTL2 1b. ;
: UART4_GP. cr ." UART4_GP.  RW   $" UART4_GP @ hex. UART4_GP 1b. ;
: UART4.
UART4_STAT.
UART4_DATA.
UART4_BAUD.
UART4_CTL0.
UART4_CTL1.
UART4_CTL2.
UART4_GP.
;

$50000000 constant USBFS_GLOBAL \ USB full speed global registers
USBFS_GLOBAL $0 + constant USBFS_GLOBAL_GOTGCS (  )  \ Global OTG control and status register   USBFS_GOTGCS
USBFS_GLOBAL $04 + constant USBFS_GLOBAL_GOTGINTF ( read-write )  \ Global OTG interrupt flag register  USBFS_GOTGINTF
USBFS_GLOBAL $08 + constant USBFS_GLOBAL_GAHBCS ( read-write )  \ Global AHB control and status register  USBFS_GAHBCS
USBFS_GLOBAL $0C + constant USBFS_GLOBAL_GUSBCS (  )  \ Global USB control and status register  USBFS_GUSBCSR
USBFS_GLOBAL $10 + constant USBFS_GLOBAL_GRSTCTL (  )  \ Global reset control register USBFS_GRSTCTL
USBFS_GLOBAL $14 + constant USBFS_GLOBAL_GINTF (  )  \ Global interrupt flag register USBFS_GINTF
USBFS_GLOBAL $18 + constant USBFS_GLOBAL_GINTEN (  )  \ Global interrupt enable register  USBFS_GINTEN
USBFS_GLOBAL $1C + constant USBFS_GLOBAL_GRSTATR_Device ( read-only )  \ Global Receive status readDevice  mode
USBFS_GLOBAL $1C + constant USBFS_GLOBAL_GRSTATR_Host ( read-only )  \ Global Receive status readHost  mode
USBFS_GLOBAL $20 + constant USBFS_GLOBAL_GRSTATP_Device ( read-only )  \ Global Receive status popDevice  mode
USBFS_GLOBAL $20 + constant USBFS_GLOBAL_GRSTATP_Host ( read-only )  \ Global Receive status popHost  mode
USBFS_GLOBAL $24 + constant USBFS_GLOBAL_GRFLEN ( read-write )  \ Global Receive FIFO size register  USBFS_GRFLEN
USBFS_GLOBAL $28 + constant USBFS_GLOBAL_HNPTFLEN ( read-write )  \ Host non-periodic transmit FIFO length register  Host mode
USBFS_GLOBAL $28 + constant USBFS_GLOBAL_DIEP0TFLEN ( read-write )  \ Device IN endpoint 0 transmit FIFO length  Device mode
USBFS_GLOBAL $2C + constant USBFS_GLOBAL_HNPTFQSTAT ( read-only )  \ Host non-periodic transmit FIFO/queue  status register HNPTFQSTAT
USBFS_GLOBAL $38 + constant USBFS_GLOBAL_GCCFG ( read-write )  \ Global core configuration register USBFS_GCCFG
USBFS_GLOBAL $3C + constant USBFS_GLOBAL_CID ( read-write )  \ core ID register
USBFS_GLOBAL $100 + constant USBFS_GLOBAL_HPTFLEN ( read-write )  \ Host periodic transmit FIFO length register HPTFLEN
USBFS_GLOBAL $104 + constant USBFS_GLOBAL_DIEP1TFLEN ( read-write )  \ device IN endpoint transmit FIFO size  register DIEP1TFLEN
USBFS_GLOBAL $108 + constant USBFS_GLOBAL_DIEP2TFLEN ( read-write )  \ device IN endpoint transmit FIFO size  register DIEP2TFLEN
USBFS_GLOBAL $10C + constant USBFS_GLOBAL_DIEP3TFLEN ( read-write )  \ device IN endpoint transmit FIFO size  register FS_DIEP3TXFLEN
: USBFS_GLOBAL_GOTGCS. cr ." USBFS_GLOBAL_GOTGCS.   $" USBFS_GLOBAL_GOTGCS @ hex. USBFS_GLOBAL_GOTGCS 1b. ;
: USBFS_GLOBAL_GOTGINTF. cr ." USBFS_GLOBAL_GOTGINTF.  RW   $" USBFS_GLOBAL_GOTGINTF @ hex. USBFS_GLOBAL_GOTGINTF 1b. ;
: USBFS_GLOBAL_GAHBCS. cr ." USBFS_GLOBAL_GAHBCS.  RW   $" USBFS_GLOBAL_GAHBCS @ hex. USBFS_GLOBAL_GAHBCS 1b. ;
: USBFS_GLOBAL_GUSBCS. cr ." USBFS_GLOBAL_GUSBCS.   $" USBFS_GLOBAL_GUSBCS @ hex. USBFS_GLOBAL_GUSBCS 1b. ;
: USBFS_GLOBAL_GRSTCTL. cr ." USBFS_GLOBAL_GRSTCTL.   $" USBFS_GLOBAL_GRSTCTL @ hex. USBFS_GLOBAL_GRSTCTL 1b. ;
: USBFS_GLOBAL_GINTF. cr ." USBFS_GLOBAL_GINTF.   $" USBFS_GLOBAL_GINTF @ hex. USBFS_GLOBAL_GINTF 1b. ;
: USBFS_GLOBAL_GINTEN. cr ." USBFS_GLOBAL_GINTEN.   $" USBFS_GLOBAL_GINTEN @ hex. USBFS_GLOBAL_GINTEN 1b. ;
: USBFS_GLOBAL_GRSTATR_Device. cr ." USBFS_GLOBAL_GRSTATR_Device.  RO   $" USBFS_GLOBAL_GRSTATR_Device @ hex. USBFS_GLOBAL_GRSTATR_Device 1b. ;
: USBFS_GLOBAL_GRSTATR_Host. cr ." USBFS_GLOBAL_GRSTATR_Host.  RO   $" USBFS_GLOBAL_GRSTATR_Host @ hex. USBFS_GLOBAL_GRSTATR_Host 1b. ;
: USBFS_GLOBAL_GRSTATP_Device. cr ." USBFS_GLOBAL_GRSTATP_Device.  RO   $" USBFS_GLOBAL_GRSTATP_Device @ hex. USBFS_GLOBAL_GRSTATP_Device 1b. ;
: USBFS_GLOBAL_GRSTATP_Host. cr ." USBFS_GLOBAL_GRSTATP_Host.  RO   $" USBFS_GLOBAL_GRSTATP_Host @ hex. USBFS_GLOBAL_GRSTATP_Host 1b. ;
: USBFS_GLOBAL_GRFLEN. cr ." USBFS_GLOBAL_GRFLEN.  RW   $" USBFS_GLOBAL_GRFLEN @ hex. USBFS_GLOBAL_GRFLEN 1b. ;
: USBFS_GLOBAL_HNPTFLEN. cr ." USBFS_GLOBAL_HNPTFLEN.  RW   $" USBFS_GLOBAL_HNPTFLEN @ hex. USBFS_GLOBAL_HNPTFLEN 1b. ;
: USBFS_GLOBAL_DIEP0TFLEN. cr ." USBFS_GLOBAL_DIEP0TFLEN.  RW   $" USBFS_GLOBAL_DIEP0TFLEN @ hex. USBFS_GLOBAL_DIEP0TFLEN 1b. ;
: USBFS_GLOBAL_HNPTFQSTAT. cr ." USBFS_GLOBAL_HNPTFQSTAT.  RO   $" USBFS_GLOBAL_HNPTFQSTAT @ hex. USBFS_GLOBAL_HNPTFQSTAT 1b. ;
: USBFS_GLOBAL_GCCFG. cr ." USBFS_GLOBAL_GCCFG.  RW   $" USBFS_GLOBAL_GCCFG @ hex. USBFS_GLOBAL_GCCFG 1b. ;
: USBFS_GLOBAL_CID. cr ." USBFS_GLOBAL_CID.  RW   $" USBFS_GLOBAL_CID @ hex. USBFS_GLOBAL_CID 1b. ;
: USBFS_GLOBAL_HPTFLEN. cr ." USBFS_GLOBAL_HPTFLEN.  RW   $" USBFS_GLOBAL_HPTFLEN @ hex. USBFS_GLOBAL_HPTFLEN 1b. ;
: USBFS_GLOBAL_DIEP1TFLEN. cr ." USBFS_GLOBAL_DIEP1TFLEN.  RW   $" USBFS_GLOBAL_DIEP1TFLEN @ hex. USBFS_GLOBAL_DIEP1TFLEN 1b. ;
: USBFS_GLOBAL_DIEP2TFLEN. cr ." USBFS_GLOBAL_DIEP2TFLEN.  RW   $" USBFS_GLOBAL_DIEP2TFLEN @ hex. USBFS_GLOBAL_DIEP2TFLEN 1b. ;
: USBFS_GLOBAL_DIEP3TFLEN. cr ." USBFS_GLOBAL_DIEP3TFLEN.  RW   $" USBFS_GLOBAL_DIEP3TFLEN @ hex. USBFS_GLOBAL_DIEP3TFLEN 1b. ;
: USBFS_GLOBAL.
USBFS_GLOBAL_GOTGCS.
USBFS_GLOBAL_GOTGINTF.
USBFS_GLOBAL_GAHBCS.
USBFS_GLOBAL_GUSBCS.
USBFS_GLOBAL_GRSTCTL.
USBFS_GLOBAL_GINTF.
USBFS_GLOBAL_GINTEN.
USBFS_GLOBAL_GRSTATR_Device.
USBFS_GLOBAL_GRSTATR_Host.
USBFS_GLOBAL_GRSTATP_Device.
USBFS_GLOBAL_GRSTATP_Host.
USBFS_GLOBAL_GRFLEN.
USBFS_GLOBAL_HNPTFLEN.
USBFS_GLOBAL_DIEP0TFLEN.
USBFS_GLOBAL_HNPTFQSTAT.
USBFS_GLOBAL_GCCFG.
USBFS_GLOBAL_CID.
USBFS_GLOBAL_HPTFLEN.
USBFS_GLOBAL_DIEP1TFLEN.
USBFS_GLOBAL_DIEP2TFLEN.
USBFS_GLOBAL_DIEP3TFLEN.
;

$50000400 constant USBFS_HOST \ USB on the go full speed host
USBFS_HOST $00 + constant USBFS_HOST_HCTL (  )  \ host configuration register  HCTL
USBFS_HOST $04 + constant USBFS_HOST_HFT ( read-write )  \ Host frame interval  register
USBFS_HOST $08 + constant USBFS_HOST_HFINFR ( read-only )  \ FS host frame number/frame time  remaining register HFINFR
USBFS_HOST $10 + constant USBFS_HOST_HPTFQSTAT (  )  \ Host periodic transmit FIFO/queue  status register HPTFQSTAT
USBFS_HOST $14 + constant USBFS_HOST_HACHINT ( read-only )  \  Host all channels interrupt  register
USBFS_HOST $18 + constant USBFS_HOST_HACHINTEN ( read-write )  \ host all channels interrupt mask  register
USBFS_HOST $40 + constant USBFS_HOST_HPCS (  )  \ Host port control and status register USBFS_HPCS
USBFS_HOST $100 + constant USBFS_HOST_HCH0CTL ( read-write )  \ host channel-0 characteristics  register HCH0CTL
USBFS_HOST $120 + constant USBFS_HOST_HCH1CTL ( read-write )  \  host channel-1 characteristics  register HCH1CTL
USBFS_HOST $140 + constant USBFS_HOST_HCH2CTL ( read-write )  \ host channel-2 characteristics  register HCH2CTL
USBFS_HOST $160 + constant USBFS_HOST_HCH3CTL ( read-write )  \ host channel-3 characteristics  register HCH3CTL
USBFS_HOST $180 + constant USBFS_HOST_HCH4CTL ( read-write )  \  host channel-4 characteristics  register HCH4CTL
USBFS_HOST $1A0 + constant USBFS_HOST_HCH5CTL ( read-write )  \ host channel-5 characteristics  register HCH5CTL
USBFS_HOST $1C0 + constant USBFS_HOST_HCH6CTL ( read-write )  \ host channel-6 characteristics  register HCH6CTL
USBFS_HOST $1E0 + constant USBFS_HOST_HCH7CTL ( read-write )  \ host channel-7 characteristics  register HCH7CTL
USBFS_HOST $108 + constant USBFS_HOST_HCH0INTF ( read-write )  \ host channel-0 interrupt register  USBFS_HCHxINTF
USBFS_HOST $128 + constant USBFS_HOST_HCH1INTF ( read-write )  \ host channel-1 interrupt register  HCH1INTF
USBFS_HOST $148 + constant USBFS_HOST_HCH2INTF ( read-write )  \ host channel-2 interrupt register  HCH2INTF
USBFS_HOST $168 + constant USBFS_HOST_HCH3INTF ( read-write )  \ host channel-3 interrupt register  HCH3INTF
USBFS_HOST $188 + constant USBFS_HOST_HCH4INTF ( read-write )  \ host channel-4 interrupt register  HCH4INTF
USBFS_HOST $1A8 + constant USBFS_HOST_HCH5INTF ( read-write )  \ host channel-5 interrupt register  HCH5INTF
USBFS_HOST $1C8 + constant USBFS_HOST_HCH6INTF ( read-write )  \ host channel-6 interrupt register  HCH6INTF
USBFS_HOST $1E8 + constant USBFS_HOST_HCH7INTF ( read-write )  \ host channel-7 interrupt register  HCH7INTF
USBFS_HOST $10C + constant USBFS_HOST_HCH0INTEN ( read-write )  \ host channel-0 interrupt enable register  HCH0INTEN
USBFS_HOST $12C + constant USBFS_HOST_HCH1INTEN ( read-write )  \ host channel-1 interrupt enable register  HCH1INTEN
USBFS_HOST $14C + constant USBFS_HOST_HCH2INTEN ( read-write )  \ host channel-2 interrupt enable register  HCH2INTEN
USBFS_HOST $16C + constant USBFS_HOST_HCH3INTEN ( read-write )  \ host channel-3 interrupt enable register  HCH3INTEN
USBFS_HOST $18C + constant USBFS_HOST_HCH4INTEN ( read-write )  \ host channel-4 interrupt enable register  HCH4INTEN
USBFS_HOST $1AC + constant USBFS_HOST_HCH5INTEN ( read-write )  \ host channel-5 interrupt enable register  HCH5INTEN
USBFS_HOST $1CC + constant USBFS_HOST_HCH6INTEN ( read-write )  \ host channel-6 interrupt enable register  HCH6INTEN
USBFS_HOST $1EC + constant USBFS_HOST_HCH7INTEN ( read-write )  \ host channel-7 interrupt enable register  HCH7INTEN
USBFS_HOST $110 + constant USBFS_HOST_HCH0LEN ( read-write )  \ host channel-0 transfer length  register
USBFS_HOST $130 + constant USBFS_HOST_HCH1LEN ( read-write )  \ host channel-1 transfer length  register
USBFS_HOST $150 + constant USBFS_HOST_HCH2LEN ( read-write )  \  host channel-2 transfer length  register
USBFS_HOST $170 + constant USBFS_HOST_HCH3LEN ( read-write )  \  host channel-3 transfer length  register
USBFS_HOST $190 + constant USBFS_HOST_HCH4LEN ( read-write )  \ host channel-4 transfer length  register
USBFS_HOST $1B0 + constant USBFS_HOST_HCH5LEN ( read-write )  \ host channel-5 transfer length  register
USBFS_HOST $1D0 + constant USBFS_HOST_HCH6LEN ( read-write )  \ host channel-6 transfer length  register
USBFS_HOST $1F0 + constant USBFS_HOST_HCH7LEN ( read-write )  \ host channel-7 transfer length  register
: USBFS_HOST_HCTL. cr ." USBFS_HOST_HCTL.   $" USBFS_HOST_HCTL @ hex. USBFS_HOST_HCTL 1b. ;
: USBFS_HOST_HFT. cr ." USBFS_HOST_HFT.  RW   $" USBFS_HOST_HFT @ hex. USBFS_HOST_HFT 1b. ;
: USBFS_HOST_HFINFR. cr ." USBFS_HOST_HFINFR.  RO   $" USBFS_HOST_HFINFR @ hex. USBFS_HOST_HFINFR 1b. ;
: USBFS_HOST_HPTFQSTAT. cr ." USBFS_HOST_HPTFQSTAT.   $" USBFS_HOST_HPTFQSTAT @ hex. USBFS_HOST_HPTFQSTAT 1b. ;
: USBFS_HOST_HACHINT. cr ." USBFS_HOST_HACHINT.  RO   $" USBFS_HOST_HACHINT @ hex. USBFS_HOST_HACHINT 1b. ;
: USBFS_HOST_HACHINTEN. cr ." USBFS_HOST_HACHINTEN.  RW   $" USBFS_HOST_HACHINTEN @ hex. USBFS_HOST_HACHINTEN 1b. ;
: USBFS_HOST_HPCS. cr ." USBFS_HOST_HPCS.   $" USBFS_HOST_HPCS @ hex. USBFS_HOST_HPCS 1b. ;
: USBFS_HOST_HCH0CTL. cr ." USBFS_HOST_HCH0CTL.  RW   $" USBFS_HOST_HCH0CTL @ hex. USBFS_HOST_HCH0CTL 1b. ;
: USBFS_HOST_HCH1CTL. cr ." USBFS_HOST_HCH1CTL.  RW   $" USBFS_HOST_HCH1CTL @ hex. USBFS_HOST_HCH1CTL 1b. ;
: USBFS_HOST_HCH2CTL. cr ." USBFS_HOST_HCH2CTL.  RW   $" USBFS_HOST_HCH2CTL @ hex. USBFS_HOST_HCH2CTL 1b. ;
: USBFS_HOST_HCH3CTL. cr ." USBFS_HOST_HCH3CTL.  RW   $" USBFS_HOST_HCH3CTL @ hex. USBFS_HOST_HCH3CTL 1b. ;
: USBFS_HOST_HCH4CTL. cr ." USBFS_HOST_HCH4CTL.  RW   $" USBFS_HOST_HCH4CTL @ hex. USBFS_HOST_HCH4CTL 1b. ;
: USBFS_HOST_HCH5CTL. cr ." USBFS_HOST_HCH5CTL.  RW   $" USBFS_HOST_HCH5CTL @ hex. USBFS_HOST_HCH5CTL 1b. ;
: USBFS_HOST_HCH6CTL. cr ." USBFS_HOST_HCH6CTL.  RW   $" USBFS_HOST_HCH6CTL @ hex. USBFS_HOST_HCH6CTL 1b. ;
: USBFS_HOST_HCH7CTL. cr ." USBFS_HOST_HCH7CTL.  RW   $" USBFS_HOST_HCH7CTL @ hex. USBFS_HOST_HCH7CTL 1b. ;
: USBFS_HOST_HCH0INTF. cr ." USBFS_HOST_HCH0INTF.  RW   $" USBFS_HOST_HCH0INTF @ hex. USBFS_HOST_HCH0INTF 1b. ;
: USBFS_HOST_HCH1INTF. cr ." USBFS_HOST_HCH1INTF.  RW   $" USBFS_HOST_HCH1INTF @ hex. USBFS_HOST_HCH1INTF 1b. ;
: USBFS_HOST_HCH2INTF. cr ." USBFS_HOST_HCH2INTF.  RW   $" USBFS_HOST_HCH2INTF @ hex. USBFS_HOST_HCH2INTF 1b. ;
: USBFS_HOST_HCH3INTF. cr ." USBFS_HOST_HCH3INTF.  RW   $" USBFS_HOST_HCH3INTF @ hex. USBFS_HOST_HCH3INTF 1b. ;
: USBFS_HOST_HCH4INTF. cr ." USBFS_HOST_HCH4INTF.  RW   $" USBFS_HOST_HCH4INTF @ hex. USBFS_HOST_HCH4INTF 1b. ;
: USBFS_HOST_HCH5INTF. cr ." USBFS_HOST_HCH5INTF.  RW   $" USBFS_HOST_HCH5INTF @ hex. USBFS_HOST_HCH5INTF 1b. ;
: USBFS_HOST_HCH6INTF. cr ." USBFS_HOST_HCH6INTF.  RW   $" USBFS_HOST_HCH6INTF @ hex. USBFS_HOST_HCH6INTF 1b. ;
: USBFS_HOST_HCH7INTF. cr ." USBFS_HOST_HCH7INTF.  RW   $" USBFS_HOST_HCH7INTF @ hex. USBFS_HOST_HCH7INTF 1b. ;
: USBFS_HOST_HCH0INTEN. cr ." USBFS_HOST_HCH0INTEN.  RW   $" USBFS_HOST_HCH0INTEN @ hex. USBFS_HOST_HCH0INTEN 1b. ;
: USBFS_HOST_HCH1INTEN. cr ." USBFS_HOST_HCH1INTEN.  RW   $" USBFS_HOST_HCH1INTEN @ hex. USBFS_HOST_HCH1INTEN 1b. ;
: USBFS_HOST_HCH2INTEN. cr ." USBFS_HOST_HCH2INTEN.  RW   $" USBFS_HOST_HCH2INTEN @ hex. USBFS_HOST_HCH2INTEN 1b. ;
: USBFS_HOST_HCH3INTEN. cr ." USBFS_HOST_HCH3INTEN.  RW   $" USBFS_HOST_HCH3INTEN @ hex. USBFS_HOST_HCH3INTEN 1b. ;
: USBFS_HOST_HCH4INTEN. cr ." USBFS_HOST_HCH4INTEN.  RW   $" USBFS_HOST_HCH4INTEN @ hex. USBFS_HOST_HCH4INTEN 1b. ;
: USBFS_HOST_HCH5INTEN. cr ." USBFS_HOST_HCH5INTEN.  RW   $" USBFS_HOST_HCH5INTEN @ hex. USBFS_HOST_HCH5INTEN 1b. ;
: USBFS_HOST_HCH6INTEN. cr ." USBFS_HOST_HCH6INTEN.  RW   $" USBFS_HOST_HCH6INTEN @ hex. USBFS_HOST_HCH6INTEN 1b. ;
: USBFS_HOST_HCH7INTEN. cr ." USBFS_HOST_HCH7INTEN.  RW   $" USBFS_HOST_HCH7INTEN @ hex. USBFS_HOST_HCH7INTEN 1b. ;
: USBFS_HOST_HCH0LEN. cr ." USBFS_HOST_HCH0LEN.  RW   $" USBFS_HOST_HCH0LEN @ hex. USBFS_HOST_HCH0LEN 1b. ;
: USBFS_HOST_HCH1LEN. cr ." USBFS_HOST_HCH1LEN.  RW   $" USBFS_HOST_HCH1LEN @ hex. USBFS_HOST_HCH1LEN 1b. ;
: USBFS_HOST_HCH2LEN. cr ." USBFS_HOST_HCH2LEN.  RW   $" USBFS_HOST_HCH2LEN @ hex. USBFS_HOST_HCH2LEN 1b. ;
: USBFS_HOST_HCH3LEN. cr ." USBFS_HOST_HCH3LEN.  RW   $" USBFS_HOST_HCH3LEN @ hex. USBFS_HOST_HCH3LEN 1b. ;
: USBFS_HOST_HCH4LEN. cr ." USBFS_HOST_HCH4LEN.  RW   $" USBFS_HOST_HCH4LEN @ hex. USBFS_HOST_HCH4LEN 1b. ;
: USBFS_HOST_HCH5LEN. cr ." USBFS_HOST_HCH5LEN.  RW   $" USBFS_HOST_HCH5LEN @ hex. USBFS_HOST_HCH5LEN 1b. ;
: USBFS_HOST_HCH6LEN. cr ." USBFS_HOST_HCH6LEN.  RW   $" USBFS_HOST_HCH6LEN @ hex. USBFS_HOST_HCH6LEN 1b. ;
: USBFS_HOST_HCH7LEN. cr ." USBFS_HOST_HCH7LEN.  RW   $" USBFS_HOST_HCH7LEN @ hex. USBFS_HOST_HCH7LEN 1b. ;
: USBFS_HOST.
USBFS_HOST_HCTL.
USBFS_HOST_HFT.
USBFS_HOST_HFINFR.
USBFS_HOST_HPTFQSTAT.
USBFS_HOST_HACHINT.
USBFS_HOST_HACHINTEN.
USBFS_HOST_HPCS.
USBFS_HOST_HCH0CTL.
USBFS_HOST_HCH1CTL.
USBFS_HOST_HCH2CTL.
USBFS_HOST_HCH3CTL.
USBFS_HOST_HCH4CTL.
USBFS_HOST_HCH5CTL.
USBFS_HOST_HCH6CTL.
USBFS_HOST_HCH7CTL.
USBFS_HOST_HCH0INTF.
USBFS_HOST_HCH1INTF.
USBFS_HOST_HCH2INTF.
USBFS_HOST_HCH3INTF.
USBFS_HOST_HCH4INTF.
USBFS_HOST_HCH5INTF.
USBFS_HOST_HCH6INTF.
USBFS_HOST_HCH7INTF.
USBFS_HOST_HCH0INTEN.
USBFS_HOST_HCH1INTEN.
USBFS_HOST_HCH2INTEN.
USBFS_HOST_HCH3INTEN.
USBFS_HOST_HCH4INTEN.
USBFS_HOST_HCH5INTEN.
USBFS_HOST_HCH6INTEN.
USBFS_HOST_HCH7INTEN.
USBFS_HOST_HCH0LEN.
USBFS_HOST_HCH1LEN.
USBFS_HOST_HCH2LEN.
USBFS_HOST_HCH3LEN.
USBFS_HOST_HCH4LEN.
USBFS_HOST_HCH5LEN.
USBFS_HOST_HCH6LEN.
USBFS_HOST_HCH7LEN.
;

$50000800 constant USBFS_DEVICE \ USB on the go full speed device
USBFS_DEVICE $0 + constant USBFS_DEVICE_DCFG ( read-write )  \ device configuration register  DCFG
USBFS_DEVICE $04 + constant USBFS_DEVICE_DCTL (  )  \ device control register  DCTL
USBFS_DEVICE $08 + constant USBFS_DEVICE_DSTAT ( read-only )  \ device status register  DSTAT
USBFS_DEVICE $10 + constant USBFS_DEVICE_DIEPINTEN ( read-write )  \ device IN endpoint common interrupt  mask register DIEPINTEN
USBFS_DEVICE $14 + constant USBFS_DEVICE_DOEPINTEN ( read-write )  \ device OUT endpoint common interrupt  enable register DOEPINTEN
USBFS_DEVICE $18 + constant USBFS_DEVICE_DAEPINT ( read-only )  \ device all endpoints interrupt  register DAEPINT
USBFS_DEVICE $1C + constant USBFS_DEVICE_DAEPINTEN ( read-write )  \ Device all endpoints interrupt enable register  DAEPINTEN
USBFS_DEVICE $28 + constant USBFS_DEVICE_DVBUSDT ( read-write )  \ device VBUS discharge time  register
USBFS_DEVICE $2C + constant USBFS_DEVICE_DVBUSPT ( read-write )  \ device VBUS pulsing time  register
USBFS_DEVICE $34 + constant USBFS_DEVICE_DIEPFEINTEN ( read-write )  \ device IN endpoint FIFO empty  interrupt enable register
USBFS_DEVICE $100 + constant USBFS_DEVICE_DIEP0CTL (  )  \ device IN endpoint 0 control  register DIEP0CTL
USBFS_DEVICE $120 + constant USBFS_DEVICE_DIEP1CTL (  )  \ device in endpoint-1 control  register
USBFS_DEVICE $140 + constant USBFS_DEVICE_DIEP2CTL (  )  \ device endpoint-2 control  register
USBFS_DEVICE $160 + constant USBFS_DEVICE_DIEP3CTL (  )  \ device endpoint-3 control  register
USBFS_DEVICE $300 + constant USBFS_DEVICE_DOEP0CTL (  )  \ device endpoint-0 control  register
USBFS_DEVICE $320 + constant USBFS_DEVICE_DOEP1CTL (  )  \ device endpoint-1 control  register
USBFS_DEVICE $340 + constant USBFS_DEVICE_DOEP2CTL (  )  \ device endpoint-2 control  register
USBFS_DEVICE $360 + constant USBFS_DEVICE_DOEP3CTL (  )  \ device endpoint-3 control  register
USBFS_DEVICE $108 + constant USBFS_DEVICE_DIEP0INTF (  )  \ device endpoint-0 interrupt  register
USBFS_DEVICE $128 + constant USBFS_DEVICE_DIEP1INTF (  )  \ device endpoint-1 interrupt  register
USBFS_DEVICE $148 + constant USBFS_DEVICE_DIEP2INTF (  )  \ device endpoint-2 interrupt  register
USBFS_DEVICE $168 + constant USBFS_DEVICE_DIEP3INTF (  )  \ device endpoint-3 interrupt  register
USBFS_DEVICE $308 + constant USBFS_DEVICE_DOEP0INTF ( read-write )  \ device out endpoint-0 interrupt flag   register
USBFS_DEVICE $328 + constant USBFS_DEVICE_DOEP1INTF ( read-write )  \ device out endpoint-1 interrupt flag   register
USBFS_DEVICE $348 + constant USBFS_DEVICE_DOEP2INTF ( read-write )  \ device out endpoint-2 interrupt flag   register
USBFS_DEVICE $368 + constant USBFS_DEVICE_DOEP3INTF ( read-write )  \ device out endpoint-3 interrupt flag   register
USBFS_DEVICE $110 + constant USBFS_DEVICE_DIEP0LEN ( read-write )  \ device IN endpoint-0 transfer length  register
USBFS_DEVICE $310 + constant USBFS_DEVICE_DOEP0LEN ( read-write )  \ device OUT endpoint-0 transfer length  register
USBFS_DEVICE $130 + constant USBFS_DEVICE_DIEP1LEN ( read-write )  \ device IN endpoint-1 transfer length  register
USBFS_DEVICE $150 + constant USBFS_DEVICE_DIEP2LEN ( read-write )  \ device IN endpoint-2 transfer length  register
USBFS_DEVICE $170 + constant USBFS_DEVICE_DIEP3LEN ( read-write )  \ device IN endpoint-3 transfer length  register
USBFS_DEVICE $330 + constant USBFS_DEVICE_DOEP1LEN ( read-write )  \ device OUT endpoint-1 transfer length  register
USBFS_DEVICE $350 + constant USBFS_DEVICE_DOEP2LEN ( read-write )  \ device OUT endpoint-2 transfer length  register
USBFS_DEVICE $370 + constant USBFS_DEVICE_DOEP3LEN ( read-write )  \ device OUT endpoint-3 transfer length  register
USBFS_DEVICE $118 + constant USBFS_DEVICE_DIEP0TFSTAT ( read-only )  \ device IN endpoint 0 transmit FIFO  status register
USBFS_DEVICE $138 + constant USBFS_DEVICE_DIEP1TFSTAT ( read-only )  \ device IN endpoint 1 transmit FIFO  status register
USBFS_DEVICE $158 + constant USBFS_DEVICE_DIEP2TFSTAT ( read-only )  \ device IN endpoint 2 transmit FIFO  status register
USBFS_DEVICE $178 + constant USBFS_DEVICE_DIEP3TFSTAT ( read-only )  \ device IN endpoint 3 transmit FIFO  status register
: USBFS_DEVICE_DCFG. cr ." USBFS_DEVICE_DCFG.  RW   $" USBFS_DEVICE_DCFG @ hex. USBFS_DEVICE_DCFG 1b. ;
: USBFS_DEVICE_DCTL. cr ." USBFS_DEVICE_DCTL.   $" USBFS_DEVICE_DCTL @ hex. USBFS_DEVICE_DCTL 1b. ;
: USBFS_DEVICE_DSTAT. cr ." USBFS_DEVICE_DSTAT.  RO   $" USBFS_DEVICE_DSTAT @ hex. USBFS_DEVICE_DSTAT 1b. ;
: USBFS_DEVICE_DIEPINTEN. cr ." USBFS_DEVICE_DIEPINTEN.  RW   $" USBFS_DEVICE_DIEPINTEN @ hex. USBFS_DEVICE_DIEPINTEN 1b. ;
: USBFS_DEVICE_DOEPINTEN. cr ." USBFS_DEVICE_DOEPINTEN.  RW   $" USBFS_DEVICE_DOEPINTEN @ hex. USBFS_DEVICE_DOEPINTEN 1b. ;
: USBFS_DEVICE_DAEPINT. cr ." USBFS_DEVICE_DAEPINT.  RO   $" USBFS_DEVICE_DAEPINT @ hex. USBFS_DEVICE_DAEPINT 1b. ;
: USBFS_DEVICE_DAEPINTEN. cr ." USBFS_DEVICE_DAEPINTEN.  RW   $" USBFS_DEVICE_DAEPINTEN @ hex. USBFS_DEVICE_DAEPINTEN 1b. ;
: USBFS_DEVICE_DVBUSDT. cr ." USBFS_DEVICE_DVBUSDT.  RW   $" USBFS_DEVICE_DVBUSDT @ hex. USBFS_DEVICE_DVBUSDT 1b. ;
: USBFS_DEVICE_DVBUSPT. cr ." USBFS_DEVICE_DVBUSPT.  RW   $" USBFS_DEVICE_DVBUSPT @ hex. USBFS_DEVICE_DVBUSPT 1b. ;
: USBFS_DEVICE_DIEPFEINTEN. cr ." USBFS_DEVICE_DIEPFEINTEN.  RW   $" USBFS_DEVICE_DIEPFEINTEN @ hex. USBFS_DEVICE_DIEPFEINTEN 1b. ;
: USBFS_DEVICE_DIEP0CTL. cr ." USBFS_DEVICE_DIEP0CTL.   $" USBFS_DEVICE_DIEP0CTL @ hex. USBFS_DEVICE_DIEP0CTL 1b. ;
: USBFS_DEVICE_DIEP1CTL. cr ." USBFS_DEVICE_DIEP1CTL.   $" USBFS_DEVICE_DIEP1CTL @ hex. USBFS_DEVICE_DIEP1CTL 1b. ;
: USBFS_DEVICE_DIEP2CTL. cr ." USBFS_DEVICE_DIEP2CTL.   $" USBFS_DEVICE_DIEP2CTL @ hex. USBFS_DEVICE_DIEP2CTL 1b. ;
: USBFS_DEVICE_DIEP3CTL. cr ." USBFS_DEVICE_DIEP3CTL.   $" USBFS_DEVICE_DIEP3CTL @ hex. USBFS_DEVICE_DIEP3CTL 1b. ;
: USBFS_DEVICE_DOEP0CTL. cr ." USBFS_DEVICE_DOEP0CTL.   $" USBFS_DEVICE_DOEP0CTL @ hex. USBFS_DEVICE_DOEP0CTL 1b. ;
: USBFS_DEVICE_DOEP1CTL. cr ." USBFS_DEVICE_DOEP1CTL.   $" USBFS_DEVICE_DOEP1CTL @ hex. USBFS_DEVICE_DOEP1CTL 1b. ;
: USBFS_DEVICE_DOEP2CTL. cr ." USBFS_DEVICE_DOEP2CTL.   $" USBFS_DEVICE_DOEP2CTL @ hex. USBFS_DEVICE_DOEP2CTL 1b. ;
: USBFS_DEVICE_DOEP3CTL. cr ." USBFS_DEVICE_DOEP3CTL.   $" USBFS_DEVICE_DOEP3CTL @ hex. USBFS_DEVICE_DOEP3CTL 1b. ;
: USBFS_DEVICE_DIEP0INTF. cr ." USBFS_DEVICE_DIEP0INTF.   $" USBFS_DEVICE_DIEP0INTF @ hex. USBFS_DEVICE_DIEP0INTF 1b. ;
: USBFS_DEVICE_DIEP1INTF. cr ." USBFS_DEVICE_DIEP1INTF.   $" USBFS_DEVICE_DIEP1INTF @ hex. USBFS_DEVICE_DIEP1INTF 1b. ;
: USBFS_DEVICE_DIEP2INTF. cr ." USBFS_DEVICE_DIEP2INTF.   $" USBFS_DEVICE_DIEP2INTF @ hex. USBFS_DEVICE_DIEP2INTF 1b. ;
: USBFS_DEVICE_DIEP3INTF. cr ." USBFS_DEVICE_DIEP3INTF.   $" USBFS_DEVICE_DIEP3INTF @ hex. USBFS_DEVICE_DIEP3INTF 1b. ;
: USBFS_DEVICE_DOEP0INTF. cr ." USBFS_DEVICE_DOEP0INTF.  RW   $" USBFS_DEVICE_DOEP0INTF @ hex. USBFS_DEVICE_DOEP0INTF 1b. ;
: USBFS_DEVICE_DOEP1INTF. cr ." USBFS_DEVICE_DOEP1INTF.  RW   $" USBFS_DEVICE_DOEP1INTF @ hex. USBFS_DEVICE_DOEP1INTF 1b. ;
: USBFS_DEVICE_DOEP2INTF. cr ." USBFS_DEVICE_DOEP2INTF.  RW   $" USBFS_DEVICE_DOEP2INTF @ hex. USBFS_DEVICE_DOEP2INTF 1b. ;
: USBFS_DEVICE_DOEP3INTF. cr ." USBFS_DEVICE_DOEP3INTF.  RW   $" USBFS_DEVICE_DOEP3INTF @ hex. USBFS_DEVICE_DOEP3INTF 1b. ;
: USBFS_DEVICE_DIEP0LEN. cr ." USBFS_DEVICE_DIEP0LEN.  RW   $" USBFS_DEVICE_DIEP0LEN @ hex. USBFS_DEVICE_DIEP0LEN 1b. ;
: USBFS_DEVICE_DOEP0LEN. cr ." USBFS_DEVICE_DOEP0LEN.  RW   $" USBFS_DEVICE_DOEP0LEN @ hex. USBFS_DEVICE_DOEP0LEN 1b. ;
: USBFS_DEVICE_DIEP1LEN. cr ." USBFS_DEVICE_DIEP1LEN.  RW   $" USBFS_DEVICE_DIEP1LEN @ hex. USBFS_DEVICE_DIEP1LEN 1b. ;
: USBFS_DEVICE_DIEP2LEN. cr ." USBFS_DEVICE_DIEP2LEN.  RW   $" USBFS_DEVICE_DIEP2LEN @ hex. USBFS_DEVICE_DIEP2LEN 1b. ;
: USBFS_DEVICE_DIEP3LEN. cr ." USBFS_DEVICE_DIEP3LEN.  RW   $" USBFS_DEVICE_DIEP3LEN @ hex. USBFS_DEVICE_DIEP3LEN 1b. ;
: USBFS_DEVICE_DOEP1LEN. cr ." USBFS_DEVICE_DOEP1LEN.  RW   $" USBFS_DEVICE_DOEP1LEN @ hex. USBFS_DEVICE_DOEP1LEN 1b. ;
: USBFS_DEVICE_DOEP2LEN. cr ." USBFS_DEVICE_DOEP2LEN.  RW   $" USBFS_DEVICE_DOEP2LEN @ hex. USBFS_DEVICE_DOEP2LEN 1b. ;
: USBFS_DEVICE_DOEP3LEN. cr ." USBFS_DEVICE_DOEP3LEN.  RW   $" USBFS_DEVICE_DOEP3LEN @ hex. USBFS_DEVICE_DOEP3LEN 1b. ;
: USBFS_DEVICE_DIEP0TFSTAT. cr ." USBFS_DEVICE_DIEP0TFSTAT.  RO   $" USBFS_DEVICE_DIEP0TFSTAT @ hex. USBFS_DEVICE_DIEP0TFSTAT 1b. ;
: USBFS_DEVICE_DIEP1TFSTAT. cr ." USBFS_DEVICE_DIEP1TFSTAT.  RO   $" USBFS_DEVICE_DIEP1TFSTAT @ hex. USBFS_DEVICE_DIEP1TFSTAT 1b. ;
: USBFS_DEVICE_DIEP2TFSTAT. cr ." USBFS_DEVICE_DIEP2TFSTAT.  RO   $" USBFS_DEVICE_DIEP2TFSTAT @ hex. USBFS_DEVICE_DIEP2TFSTAT 1b. ;
: USBFS_DEVICE_DIEP3TFSTAT. cr ." USBFS_DEVICE_DIEP3TFSTAT.  RO   $" USBFS_DEVICE_DIEP3TFSTAT @ hex. USBFS_DEVICE_DIEP3TFSTAT 1b. ;
: USBFS_DEVICE.
USBFS_DEVICE_DCFG.
USBFS_DEVICE_DCTL.
USBFS_DEVICE_DSTAT.
USBFS_DEVICE_DIEPINTEN.
USBFS_DEVICE_DOEPINTEN.
USBFS_DEVICE_DAEPINT.
USBFS_DEVICE_DAEPINTEN.
USBFS_DEVICE_DVBUSDT.
USBFS_DEVICE_DVBUSPT.
USBFS_DEVICE_DIEPFEINTEN.
USBFS_DEVICE_DIEP0CTL.
USBFS_DEVICE_DIEP1CTL.
USBFS_DEVICE_DIEP2CTL.
USBFS_DEVICE_DIEP3CTL.
USBFS_DEVICE_DOEP0CTL.
USBFS_DEVICE_DOEP1CTL.
USBFS_DEVICE_DOEP2CTL.
USBFS_DEVICE_DOEP3CTL.
USBFS_DEVICE_DIEP0INTF.
USBFS_DEVICE_DIEP1INTF.
USBFS_DEVICE_DIEP2INTF.
USBFS_DEVICE_DIEP3INTF.
USBFS_DEVICE_DOEP0INTF.
USBFS_DEVICE_DOEP1INTF.
USBFS_DEVICE_DOEP2INTF.
USBFS_DEVICE_DOEP3INTF.
USBFS_DEVICE_DIEP0LEN.
USBFS_DEVICE_DOEP0LEN.
USBFS_DEVICE_DIEP1LEN.
USBFS_DEVICE_DIEP2LEN.
USBFS_DEVICE_DIEP3LEN.
USBFS_DEVICE_DOEP1LEN.
USBFS_DEVICE_DOEP2LEN.
USBFS_DEVICE_DOEP3LEN.
USBFS_DEVICE_DIEP0TFSTAT.
USBFS_DEVICE_DIEP1TFSTAT.
USBFS_DEVICE_DIEP2TFSTAT.
USBFS_DEVICE_DIEP3TFSTAT.
;

$50000E00 constant USBFS_PWRCLK \ USB on the go full speed
USBFS_PWRCLK $00 + constant USBFS_PWRCLK_PWRCLKCTL ( read-write )  \ power and clock gating control  register PWRCLKCTL
: USBFS_PWRCLK_PWRCLKCTL. cr ." USBFS_PWRCLK_PWRCLKCTL.  RW   $" USBFS_PWRCLK_PWRCLKCTL @ hex. USBFS_PWRCLK_PWRCLKCTL 1b. ;
: USBFS_PWRCLK.
USBFS_PWRCLK_PWRCLKCTL.
;

$40002C00 constant WWDGT \ Window watchdog timer
WWDGT $0 + constant WWDGT_CTL ( read-write )  \ Control register
WWDGT $04 + constant WWDGT_CFG ( read-write )  \ Configuration register
WWDGT $08 + constant WWDGT_STAT ( read-write )  \ Status register
: WWDGT_CTL. cr ." WWDGT_CTL.  RW   $" WWDGT_CTL @ hex. WWDGT_CTL 1b. ;
: WWDGT_CFG. cr ." WWDGT_CFG.  RW   $" WWDGT_CFG @ hex. WWDGT_CFG 1b. ;
: WWDGT_STAT. cr ." WWDGT_STAT.  RW   $" WWDGT_STAT @ hex. WWDGT_STAT 1b. ;
: WWDGT.
WWDGT_CTL.
WWDGT_CFG.
WWDGT_STAT.
;


compiletoram
