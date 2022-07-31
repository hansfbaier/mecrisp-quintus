\ GD32VF103 Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2020 and released under the GPL V2.
\ Requires: bit ( u -- u ) 1 swap lshift1-foldable ;	\ turn a bit position into a binary number.

\ ADC0_STAT (read-write) Reset:0x00000000
: ADC0_STAT_STRC ( -- x addr ) 4 bit ADC0_STAT ; \ ADC0_STAT_STRC, Start flag of regular channel group
: ADC0_STAT_STIC ( -- x addr ) 3 bit ADC0_STAT ; \ ADC0_STAT_STIC, Start flag of inserted channel group
: ADC0_STAT_EOIC ( -- x addr ) 2 bit ADC0_STAT ; \ ADC0_STAT_EOIC, End of inserted group conversion flag
: ADC0_STAT_EOC ( -- x addr ) 1 bit ADC0_STAT ; \ ADC0_STAT_EOC, End of group conversion flag
: ADC0_STAT_WDE ( -- x addr ) 0 bit ADC0_STAT ; \ ADC0_STAT_WDE, Analog watchdog event flag

\ ADC0_CTL0 (read-write) Reset:0x00000000
: ADC0_CTL0_RWDEN ( -- x addr ) 23 bit ADC0_CTL0 ; \ ADC0_CTL0_RWDEN, Regular channel analog watchdog enable
: ADC0_CTL0_IWDEN ( -- x addr ) 22 bit ADC0_CTL0 ; \ ADC0_CTL0_IWDEN, Inserted channel analog watchdog  	 enable
: ADC0_CTL0_SYNCM ( %bbbb -- x addr ) 16 lshift ADC0_CTL0 ; \ ADC0_CTL0_SYNCM, sync mode selection
: ADC0_CTL0_DISNUM ( %bbb -- x addr ) 13 lshift ADC0_CTL0 ; \ ADC0_CTL0_DISNUM, Number of conversions in  	 discontinuous mode
: ADC0_CTL0_DISIC ( -- x addr ) 12 bit ADC0_CTL0 ; \ ADC0_CTL0_DISIC, Discontinuous mode on  	 inserted channels
: ADC0_CTL0_DISRC ( -- x addr ) 11 bit ADC0_CTL0 ; \ ADC0_CTL0_DISRC, Discontinuous mode on regular  channels
: ADC0_CTL0_ICA ( -- x addr ) 10 bit ADC0_CTL0 ; \ ADC0_CTL0_ICA, Inserted channel group convert  	 automatically
: ADC0_CTL0_WDSC ( -- x addr ) 9 bit ADC0_CTL0 ; \ ADC0_CTL0_WDSC, When in scan mode, analog watchdog 	 is effective on a single channel
: ADC0_CTL0_SM ( -- x addr ) 8 bit ADC0_CTL0 ; \ ADC0_CTL0_SM, Scan mode
: ADC0_CTL0_EOICIE ( -- x addr ) 7 bit ADC0_CTL0 ; \ ADC0_CTL0_EOICIE, Interrupt enable for EOIC
: ADC0_CTL0_WDEIE ( -- x addr ) 6 bit ADC0_CTL0 ; \ ADC0_CTL0_WDEIE, Interrupt enable for WDE
: ADC0_CTL0_EOCIE ( -- x addr ) 5 bit ADC0_CTL0 ; \ ADC0_CTL0_EOCIE, Interrupt enable for EOC
: ADC0_CTL0_WDCHSEL ( %bbbbb -- x addr ) ADC0_CTL0 ; \ ADC0_CTL0_WDCHSEL, Analog watchdog channel select

\ ADC0_CTL1 (read-write) Reset:0x00000000
: ADC0_CTL1_TSVREN ( -- x addr ) 23 bit ADC0_CTL1 ; \ ADC0_CTL1_TSVREN, Channel 16 and 17 enable of ADC0
: ADC0_CTL1_SWRCST ( -- x addr ) 22 bit ADC0_CTL1 ; \ ADC0_CTL1_SWRCST, Start on regular channel
: ADC0_CTL1_SWICST ( -- x addr ) 21 bit ADC0_CTL1 ; \ ADC0_CTL1_SWICST, Start on inserted channel
: ADC0_CTL1_ETERC ( -- x addr ) 20 bit ADC0_CTL1 ; \ ADC0_CTL1_ETERC, External trigger enable for regular channel
: ADC0_CTL1_ETSRC ( %bbb -- x addr ) 17 lshift ADC0_CTL1 ; \ ADC0_CTL1_ETSRC, External trigger select for regular channel
: ADC0_CTL1_ETEIC ( -- x addr ) 15 bit ADC0_CTL1 ; \ ADC0_CTL1_ETEIC, External trigger select for inserted channel
: ADC0_CTL1_ETSIC ( %bbb -- x addr ) 12 lshift ADC0_CTL1 ; \ ADC0_CTL1_ETSIC, External trigger select for inserted channel
: ADC0_CTL1_DAL ( -- x addr ) 11 bit ADC0_CTL1 ; \ ADC0_CTL1_DAL, Data alignment
: ADC0_CTL1_DMA ( -- x addr ) 8 bit ADC0_CTL1 ; \ ADC0_CTL1_DMA, DMA request enable
: ADC0_CTL1_RSTCLB ( -- x addr ) 3 bit ADC0_CTL1 ; \ ADC0_CTL1_RSTCLB, Reset calibration
: ADC0_CTL1_CLB ( -- x addr ) 2 bit ADC0_CTL1 ; \ ADC0_CTL1_CLB, ADC calibration
: ADC0_CTL1_CTN ( -- x addr ) 1 bit ADC0_CTL1 ; \ ADC0_CTL1_CTN, Continuous mode
: ADC0_CTL1_ADCON ( -- x addr ) 0 bit ADC0_CTL1 ; \ ADC0_CTL1_ADCON, ADC on

\ ADC0_SAMPT0 (read-write) Reset:0x00000000
: ADC0_SAMPT0_SPT10 ( %bbb -- x addr ) ADC0_SAMPT0 ; \ ADC0_SAMPT0_SPT10, Channel 10 sample time  selection
: ADC0_SAMPT0_SPT11 ( %bbb -- x addr ) 3 lshift ADC0_SAMPT0 ; \ ADC0_SAMPT0_SPT11, Channel 11 sample time  selection
: ADC0_SAMPT0_SPT12 ( %bbb -- x addr ) 6 lshift ADC0_SAMPT0 ; \ ADC0_SAMPT0_SPT12, Channel 12 sample time  selection
: ADC0_SAMPT0_SPT13 ( %bbb -- x addr ) 9 lshift ADC0_SAMPT0 ; \ ADC0_SAMPT0_SPT13, Channel 13 sample time  selection
: ADC0_SAMPT0_SPT14 ( %bbb -- x addr ) 12 lshift ADC0_SAMPT0 ; \ ADC0_SAMPT0_SPT14, Channel 14 sample time  selection
: ADC0_SAMPT0_SPT15 ( %bbb -- x addr ) 15 lshift ADC0_SAMPT0 ; \ ADC0_SAMPT0_SPT15, Channel 15 sample time  selection
: ADC0_SAMPT0_SPT16 ( %bbb -- x addr ) 18 lshift ADC0_SAMPT0 ; \ ADC0_SAMPT0_SPT16, Channel 16 sample time  selection
: ADC0_SAMPT0_SPT17 ( %bbb -- x addr ) 21 lshift ADC0_SAMPT0 ; \ ADC0_SAMPT0_SPT17, Channel 17 sample time  selection

\ ADC0_SAMPT1 (read-write) Reset:0x00000000
: ADC0_SAMPT1_SPT0 ( %bbb -- x addr ) ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT0, Channel 0 sample time  selection
: ADC0_SAMPT1_SPT1 ( %bbb -- x addr ) 3 lshift ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT1, Channel 1 sample time  selection
: ADC0_SAMPT1_SPT2 ( %bbb -- x addr ) 6 lshift ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT2, Channel 2 sample time  selection
: ADC0_SAMPT1_SPT3 ( %bbb -- x addr ) 9 lshift ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT3, Channel 3 sample time  selection
: ADC0_SAMPT1_SPT4 ( %bbb -- x addr ) 12 lshift ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT4, Channel 4 sample time  selection
: ADC0_SAMPT1_SPT5 ( %bbb -- x addr ) 15 lshift ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT5, Channel 5 sample time  selection
: ADC0_SAMPT1_SPT6 ( %bbb -- x addr ) 18 lshift ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT6, Channel 6 sample time  selection
: ADC0_SAMPT1_SPT7 ( %bbb -- x addr ) 21 lshift ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT7, Channel 7 sample time  selection
: ADC0_SAMPT1_SPT8 ( %bbb -- x addr ) 24 lshift ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT8, Channel 8 sample time  selection
: ADC0_SAMPT1_SPT9 ( %bbb -- x addr ) 27 lshift ADC0_SAMPT1 ; \ ADC0_SAMPT1_SPT9, Channel 9 sample time  selection

\ ADC0_IOFF0 (read-write) Reset:0x00000000
: ADC0_IOFF0_IOFF ( %bbbbbbbbbbb -- x addr ) ADC0_IOFF0 ; \ ADC0_IOFF0_IOFF, Data offset for inserted channel  0

\ ADC0_IOFF1 (read-write) Reset:0x00000000
: ADC0_IOFF1_IOFF ( %bbbbbbbbbbb -- x addr ) ADC0_IOFF1 ; \ ADC0_IOFF1_IOFF, Data offset for inserted channel  1

\ ADC0_IOFF2 (read-write) Reset:0x00000000
: ADC0_IOFF2_IOFF ( %bbbbbbbbbbb -- x addr ) ADC0_IOFF2 ; \ ADC0_IOFF2_IOFF, Data offset for inserted channel  2

\ ADC0_IOFF3 (read-write) Reset:0x00000000
: ADC0_IOFF3_IOFF ( %bbbbbbbbbbb -- x addr ) ADC0_IOFF3 ; \ ADC0_IOFF3_IOFF, Data offset for inserted channel  3

\ ADC0_WDHT (read-write) Reset:0x00000FFF
: ADC0_WDHT_WDHT ( %bbbbbbbbbbb -- x addr ) ADC0_WDHT ; \ ADC0_WDHT_WDHT, Analog watchdog higher  threshold

\ ADC0_WDLT (read-write) Reset:0x00000000
: ADC0_WDLT_WDLT ( %bbbbbbbbbbb -- x addr ) ADC0_WDLT ; \ ADC0_WDLT_WDLT, Analog watchdog lower  threshold

\ ADC0_RSQ0 (read-write) Reset:0x00000000
: ADC0_RSQ0_RL ( %bbbb -- x addr ) 20 lshift ADC0_RSQ0 ; \ ADC0_RSQ0_RL, Regular channel group  length
: ADC0_RSQ0_RSQ15 ( %bbbbb -- x addr ) 15 lshift ADC0_RSQ0 ; \ ADC0_RSQ0_RSQ15, 16th conversion in regular  sequence
: ADC0_RSQ0_RSQ14 ( %bbbbb -- x addr ) 10 lshift ADC0_RSQ0 ; \ ADC0_RSQ0_RSQ14, 15th conversion in regular  sequence
: ADC0_RSQ0_RSQ13 ( %bbbbb -- x addr ) 5 lshift ADC0_RSQ0 ; \ ADC0_RSQ0_RSQ13, 14th conversion in regular  sequence
: ADC0_RSQ0_RSQ12 ( %bbbbb -- x addr ) ADC0_RSQ0 ; \ ADC0_RSQ0_RSQ12, 13th conversion in regular  sequence

\ ADC0_RSQ1 (read-write) Reset:0x00000000
: ADC0_RSQ1_RSQ11 ( %bbbbb -- x addr ) 25 lshift ADC0_RSQ1 ; \ ADC0_RSQ1_RSQ11, 12th conversion in regular  sequence
: ADC0_RSQ1_RSQ10 ( %bbbbb -- x addr ) 20 lshift ADC0_RSQ1 ; \ ADC0_RSQ1_RSQ10, 11th conversion in regular  sequence
: ADC0_RSQ1_RSQ9 ( %bbbbb -- x addr ) 15 lshift ADC0_RSQ1 ; \ ADC0_RSQ1_RSQ9, 10th conversion in regular  sequence
: ADC0_RSQ1_RSQ8 ( %bbbbb -- x addr ) 10 lshift ADC0_RSQ1 ; \ ADC0_RSQ1_RSQ8, 9th conversion in regular  sequence
: ADC0_RSQ1_RSQ7 ( %bbbbb -- x addr ) 5 lshift ADC0_RSQ1 ; \ ADC0_RSQ1_RSQ7, 8th conversion in regular  sequence
: ADC0_RSQ1_RSQ6 ( %bbbbb -- x addr ) ADC0_RSQ1 ; \ ADC0_RSQ1_RSQ6, 7th conversion in regular  sequence

\ ADC0_RSQ2 (read-write) Reset:0x00000000
: ADC0_RSQ2_RSQ5 ( %bbbbb -- x addr ) 25 lshift ADC0_RSQ2 ; \ ADC0_RSQ2_RSQ5, 6th conversion in regular  sequence
: ADC0_RSQ2_RSQ4 ( %bbbbb -- x addr ) 20 lshift ADC0_RSQ2 ; \ ADC0_RSQ2_RSQ4, 5th conversion in regular  sequence
: ADC0_RSQ2_RSQ3 ( %bbbbb -- x addr ) 15 lshift ADC0_RSQ2 ; \ ADC0_RSQ2_RSQ3, 4th conversion in regular  sequence
: ADC0_RSQ2_RSQ2 ( %bbbbb -- x addr ) 10 lshift ADC0_RSQ2 ; \ ADC0_RSQ2_RSQ2, 3rd conversion in regular  sequence
: ADC0_RSQ2_RSQ1 ( %bbbbb -- x addr ) 5 lshift ADC0_RSQ2 ; \ ADC0_RSQ2_RSQ1, 2nd conversion in regular  sequence
: ADC0_RSQ2_RSQ0 ( %bbbbb -- x addr ) ADC0_RSQ2 ; \ ADC0_RSQ2_RSQ0, 1st conversion in regular  sequence

\ ADC0_ISQ (read-write) Reset:0x00000000
: ADC0_ISQ_IL ( %bb -- x addr ) 20 lshift ADC0_ISQ ; \ ADC0_ISQ_IL, Inserted channel group length
: ADC0_ISQ_ISQ3 ( %bbbbb -- x addr ) 15 lshift ADC0_ISQ ; \ ADC0_ISQ_ISQ3, 4th conversion in inserted  sequence
: ADC0_ISQ_ISQ2 ( %bbbbb -- x addr ) 10 lshift ADC0_ISQ ; \ ADC0_ISQ_ISQ2, 3rd conversion in inserted  sequence
: ADC0_ISQ_ISQ1 ( %bbbbb -- x addr ) 5 lshift ADC0_ISQ ; \ ADC0_ISQ_ISQ1, 2nd conversion in inserted  sequence
: ADC0_ISQ_ISQ0 ( %bbbbb -- x addr ) ADC0_ISQ ; \ ADC0_ISQ_ISQ0, 1st conversion in inserted  sequence

\ ADC0_IDATA0 (read-only) Reset:0x00000000
: ADC0_IDATA0_IDATAn? ( --  x ) ADC0_IDATA0 @ ; \ ADC0_IDATA0_IDATAn, Inserted number n conversion data

\ ADC0_IDATA1 (read-only) Reset:0x00000000
: ADC0_IDATA1_IDATAn? ( --  x ) ADC0_IDATA1 @ ; \ ADC0_IDATA1_IDATAn, Inserted number n conversion data

\ ADC0_IDATA2 (read-only) Reset:0x00000000
: ADC0_IDATA2_IDATAn? ( --  x ) ADC0_IDATA2 @ ; \ ADC0_IDATA2_IDATAn, Inserted number n conversion data

\ ADC0_IDATA3 (read-only) Reset:0x00000000
: ADC0_IDATA3_IDATAn? ( --  x ) ADC0_IDATA3 @ ; \ ADC0_IDATA3_IDATAn, Inserted number n conversion data

\ ADC0_RDATA (read-only) Reset:0x00000000
: ADC0_RDATA_ADC1RDTR? ( --  x ) 16 lshift ADC0_RDATA @ ; \ ADC0_RDATA_ADC1RDTR, ADC regular channel data
: ADC0_RDATA_RDATA? ( --  x ) ADC0_RDATA @ ; \ ADC0_RDATA_RDATA, Regular channel data

\ ADC0_OVSAMPCTL (read-write) Reset:0x00000000
: ADC0_OVSAMPCTL_DRES ( %bb -- x addr ) 12 lshift ADC0_OVSAMPCTL ; \ ADC0_OVSAMPCTL_DRES, ADC resolution
: ADC0_OVSAMPCTL_TOVS ( -- x addr ) 9 bit ADC0_OVSAMPCTL ; \ ADC0_OVSAMPCTL_TOVS, Triggered Oversampling
: ADC0_OVSAMPCTL_OVSS ( %bbbb -- x addr ) 5 lshift ADC0_OVSAMPCTL ; \ ADC0_OVSAMPCTL_OVSS, Oversampling shift
: ADC0_OVSAMPCTL_OVSR ( %bbb -- x addr ) 2 lshift ADC0_OVSAMPCTL ; \ ADC0_OVSAMPCTL_OVSR, Oversampling ratio
: ADC0_OVSAMPCTL_OVSEN ( -- x addr ) 0 bit ADC0_OVSAMPCTL ; \ ADC0_OVSAMPCTL_OVSEN, Oversampler Enable

\ ADC1_STAT (read-write) Reset:0x00000000
: ADC1_STAT_STRC ( -- x addr ) 4 bit ADC1_STAT ; \ ADC1_STAT_STRC, Start flag of regular channel group
: ADC1_STAT_STIC ( -- x addr ) 3 bit ADC1_STAT ; \ ADC1_STAT_STIC, Start flag of inserted channel group
: ADC1_STAT_EOIC ( -- x addr ) 2 bit ADC1_STAT ; \ ADC1_STAT_EOIC, End of inserted group conversion flag
: ADC1_STAT_EOC ( -- x addr ) 1 bit ADC1_STAT ; \ ADC1_STAT_EOC, End of group conversion flag
: ADC1_STAT_WDE ( -- x addr ) 0 bit ADC1_STAT ; \ ADC1_STAT_WDE, Analog watchdog event flag

\ ADC1_CTL0 (read-write) Reset:0x00000000
: ADC1_CTL0_RWDEN ( -- x addr ) 23 bit ADC1_CTL0 ; \ ADC1_CTL0_RWDEN, Regular channel analog watchdog  	 enable
: ADC1_CTL0_IWDEN ( -- x addr ) 22 bit ADC1_CTL0 ; \ ADC1_CTL0_IWDEN, Inserted channel analog watchdog  	 enable
: ADC1_CTL0_DISNUM ( %bbb -- x addr ) 13 lshift ADC1_CTL0 ; \ ADC1_CTL0_DISNUM, Number of conversions in  	 discontinuous mode
: ADC1_CTL0_DISIC ( -- x addr ) 12 bit ADC1_CTL0 ; \ ADC1_CTL0_DISIC, Discontinuous mode on  	 inserted channels
: ADC1_CTL0_DISRC ( -- x addr ) 11 bit ADC1_CTL0 ; \ ADC1_CTL0_DISRC, Discontinuous mode on regular  channels
: ADC1_CTL0_ICA ( -- x addr ) 10 bit ADC1_CTL0 ; \ ADC1_CTL0_ICA, Inserted channel group convert  	 automatically
: ADC1_CTL0_WDSC ( -- x addr ) 9 bit ADC1_CTL0 ; \ ADC1_CTL0_WDSC, When in scan mode, analog watchdog 	 is effective on a single channel
: ADC1_CTL0_SM ( -- x addr ) 8 bit ADC1_CTL0 ; \ ADC1_CTL0_SM, Scan mode
: ADC1_CTL0_EOICIE ( -- x addr ) 7 bit ADC1_CTL0 ; \ ADC1_CTL0_EOICIE, Interrupt enable for EOIC
: ADC1_CTL0_WDEIE ( -- x addr ) 6 bit ADC1_CTL0 ; \ ADC1_CTL0_WDEIE, Interrupt enable for WDE
: ADC1_CTL0_EOCIE ( -- x addr ) 5 bit ADC1_CTL0 ; \ ADC1_CTL0_EOCIE, Interrupt enable for EOC
: ADC1_CTL0_WDCHSEL ( %bbbbb -- x addr ) ADC1_CTL0 ; \ ADC1_CTL0_WDCHSEL, Analog watchdog channel select

\ ADC1_CTL1 (read-write) Reset:0x00000000
: ADC1_CTL1_SWRCST ( -- x addr ) 22 bit ADC1_CTL1 ; \ ADC1_CTL1_SWRCST, Start on regular channel
: ADC1_CTL1_SWICST ( -- x addr ) 21 bit ADC1_CTL1 ; \ ADC1_CTL1_SWICST, Start on inserted channel
: ADC1_CTL1_ETERC ( -- x addr ) 20 bit ADC1_CTL1 ; \ ADC1_CTL1_ETERC, External trigger enable for regular channel
: ADC1_CTL1_ETSRC ( %bbb -- x addr ) 17 lshift ADC1_CTL1 ; \ ADC1_CTL1_ETSRC, External trigger select for regular channel
: ADC1_CTL1_ETEIC ( -- x addr ) 15 bit ADC1_CTL1 ; \ ADC1_CTL1_ETEIC, External trigger enable for inserted channel
: ADC1_CTL1_ETSIC ( %bbb -- x addr ) 12 lshift ADC1_CTL1 ; \ ADC1_CTL1_ETSIC, External trigger select for inserted channel
: ADC1_CTL1_DAL ( -- x addr ) 11 bit ADC1_CTL1 ; \ ADC1_CTL1_DAL, Data alignment
: ADC1_CTL1_DMA ( -- x addr ) 8 bit ADC1_CTL1 ; \ ADC1_CTL1_DMA, DMA request enable
: ADC1_CTL1_RSTCLB ( -- x addr ) 3 bit ADC1_CTL1 ; \ ADC1_CTL1_RSTCLB, Reset calibration
: ADC1_CTL1_CLB ( -- x addr ) 2 bit ADC1_CTL1 ; \ ADC1_CTL1_CLB, ADC calibration
: ADC1_CTL1_CTN ( -- x addr ) 1 bit ADC1_CTL1 ; \ ADC1_CTL1_CTN, Continuous mode
: ADC1_CTL1_ADCON ( -- x addr ) 0 bit ADC1_CTL1 ; \ ADC1_CTL1_ADCON, ADC on

\ ADC1_SAMPT0 (read-write) Reset:0x00000000
: ADC1_SAMPT0_SPT10 ( %bbb -- x addr ) ADC1_SAMPT0 ; \ ADC1_SAMPT0_SPT10, Channel 10 sample time  selection
: ADC1_SAMPT0_SPT11 ( %bbb -- x addr ) 3 lshift ADC1_SAMPT0 ; \ ADC1_SAMPT0_SPT11, Channel 11 sample time  selection
: ADC1_SAMPT0_SPT12 ( %bbb -- x addr ) 6 lshift ADC1_SAMPT0 ; \ ADC1_SAMPT0_SPT12, Channel 12 sample time  selection
: ADC1_SAMPT0_SPT13 ( %bbb -- x addr ) 9 lshift ADC1_SAMPT0 ; \ ADC1_SAMPT0_SPT13, Channel 13 sample time  selection
: ADC1_SAMPT0_SPT14 ( %bbb -- x addr ) 12 lshift ADC1_SAMPT0 ; \ ADC1_SAMPT0_SPT14, Channel 14 sample time  selection
: ADC1_SAMPT0_SPT15 ( %bbb -- x addr ) 15 lshift ADC1_SAMPT0 ; \ ADC1_SAMPT0_SPT15, Channel 15 sample time  selection
: ADC1_SAMPT0_SPT16 ( %bbb -- x addr ) 18 lshift ADC1_SAMPT0 ; \ ADC1_SAMPT0_SPT16, Channel 16 sample time  selection
: ADC1_SAMPT0_SPT17 ( %bbb -- x addr ) 21 lshift ADC1_SAMPT0 ; \ ADC1_SAMPT0_SPT17, Channel 17 sample time  selection

\ ADC1_SAMPT1 (read-write) Reset:0x00000000
: ADC1_SAMPT1_SPT0 ( %bbb -- x addr ) ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT0, Channel 0 sample time  selection
: ADC1_SAMPT1_SPT1 ( %bbb -- x addr ) 3 lshift ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT1, Channel 1 sample time  selection
: ADC1_SAMPT1_SPT2 ( %bbb -- x addr ) 6 lshift ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT2, Channel 2 sample time  selection
: ADC1_SAMPT1_SPT3 ( %bbb -- x addr ) 9 lshift ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT3, Channel 3 sample time  selection
: ADC1_SAMPT1_SPT4 ( %bbb -- x addr ) 12 lshift ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT4, Channel 4 sample time  selection
: ADC1_SAMPT1_SPT5 ( %bbb -- x addr ) 15 lshift ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT5, Channel 5 sample time  selection
: ADC1_SAMPT1_SPT6 ( %bbb -- x addr ) 18 lshift ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT6, Channel 6 sample time  selection
: ADC1_SAMPT1_SPT7 ( %bbb -- x addr ) 21 lshift ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT7, Channel 7 sample time  selection
: ADC1_SAMPT1_SPT8 ( %bbb -- x addr ) 24 lshift ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT8, Channel 8 sample time  selection
: ADC1_SAMPT1_SPT9 ( %bbb -- x addr ) 27 lshift ADC1_SAMPT1 ; \ ADC1_SAMPT1_SPT9, Channel 9 sample time  selection

\ ADC1_IOFF0 (read-write) Reset:0x00000000
: ADC1_IOFF0_IOFF ( %bbbbbbbbbbb -- x addr ) ADC1_IOFF0 ; \ ADC1_IOFF0_IOFF, Data offset for inserted channel  0

\ ADC1_IOFF1 (read-write) Reset:0x00000000
: ADC1_IOFF1_IOFF ( %bbbbbbbbbbb -- x addr ) ADC1_IOFF1 ; \ ADC1_IOFF1_IOFF, Data offset for inserted channel  1

\ ADC1_IOFF2 (read-write) Reset:0x00000000
: ADC1_IOFF2_IOFF ( %bbbbbbbbbbb -- x addr ) ADC1_IOFF2 ; \ ADC1_IOFF2_IOFF, Data offset for inserted channel  2

\ ADC1_IOFF3 (read-write) Reset:0x00000000
: ADC1_IOFF3_IOFF ( %bbbbbbbbbbb -- x addr ) ADC1_IOFF3 ; \ ADC1_IOFF3_IOFF, Data offset for inserted channel  3

\ ADC1_WDHT (read-write) Reset:0x00000FFF
: ADC1_WDHT_WDHT ( %bbbbbbbbbbb -- x addr ) ADC1_WDHT ; \ ADC1_WDHT_WDHT, Analog watchdog higher  threshold

\ ADC1_WDLT (read-write) Reset:0x00000000
: ADC1_WDLT_WDLT ( %bbbbbbbbbbb -- x addr ) ADC1_WDLT ; \ ADC1_WDLT_WDLT, Analog watchdog lower  threshold

\ ADC1_RSQ0 (read-write) Reset:0x00000000
: ADC1_RSQ0_RL ( %bbbb -- x addr ) 20 lshift ADC1_RSQ0 ; \ ADC1_RSQ0_RL, Regular channel group  length
: ADC1_RSQ0_RSQ15 ( %bbbbb -- x addr ) 15 lshift ADC1_RSQ0 ; \ ADC1_RSQ0_RSQ15, 16th conversion in regular  sequence
: ADC1_RSQ0_RSQ14 ( %bbbbb -- x addr ) 10 lshift ADC1_RSQ0 ; \ ADC1_RSQ0_RSQ14, 15th conversion in regular  sequence
: ADC1_RSQ0_RSQ13 ( %bbbbb -- x addr ) 5 lshift ADC1_RSQ0 ; \ ADC1_RSQ0_RSQ13, 14th conversion in regular  sequence
: ADC1_RSQ0_RSQ12 ( %bbbbb -- x addr ) ADC1_RSQ0 ; \ ADC1_RSQ0_RSQ12, 13th conversion in regular  sequence

\ ADC1_RSQ1 (read-write) Reset:0x00000000
: ADC1_RSQ1_RSQ11 ( %bbbbb -- x addr ) 25 lshift ADC1_RSQ1 ; \ ADC1_RSQ1_RSQ11, 12th conversion in regular  sequence
: ADC1_RSQ1_RSQ10 ( %bbbbb -- x addr ) 20 lshift ADC1_RSQ1 ; \ ADC1_RSQ1_RSQ10, 11th conversion in regular  sequence
: ADC1_RSQ1_RSQ9 ( %bbbbb -- x addr ) 15 lshift ADC1_RSQ1 ; \ ADC1_RSQ1_RSQ9, 10th conversion in regular  sequence
: ADC1_RSQ1_RSQ8 ( %bbbbb -- x addr ) 10 lshift ADC1_RSQ1 ; \ ADC1_RSQ1_RSQ8, 9th conversion in regular  sequence
: ADC1_RSQ1_RSQ7 ( %bbbbb -- x addr ) 5 lshift ADC1_RSQ1 ; \ ADC1_RSQ1_RSQ7, 8th conversion in regular  sequence
: ADC1_RSQ1_RSQ6 ( %bbbbb -- x addr ) ADC1_RSQ1 ; \ ADC1_RSQ1_RSQ6, 7th conversion in regular  sequence

\ ADC1_RSQ2 (read-write) Reset:0x00000000
: ADC1_RSQ2_RSQ5 ( %bbbbb -- x addr ) 25 lshift ADC1_RSQ2 ; \ ADC1_RSQ2_RSQ5, 6th conversion in regular  sequence
: ADC1_RSQ2_RSQ4 ( %bbbbb -- x addr ) 20 lshift ADC1_RSQ2 ; \ ADC1_RSQ2_RSQ4, 5th conversion in regular  sequence
: ADC1_RSQ2_RSQ3 ( %bbbbb -- x addr ) 15 lshift ADC1_RSQ2 ; \ ADC1_RSQ2_RSQ3, 4th conversion in regular  sequence
: ADC1_RSQ2_RSQ2 ( %bbbbb -- x addr ) 10 lshift ADC1_RSQ2 ; \ ADC1_RSQ2_RSQ2, 3rd conversion in regular  sequence
: ADC1_RSQ2_RSQ1 ( %bbbbb -- x addr ) 5 lshift ADC1_RSQ2 ; \ ADC1_RSQ2_RSQ1, 2nd conversion in regular  sequence
: ADC1_RSQ2_RSQ0 ( %bbbbb -- x addr ) ADC1_RSQ2 ; \ ADC1_RSQ2_RSQ0, 1st conversion in regular  sequence

\ ADC1_ISQ (read-write) Reset:0x00000000
: ADC1_ISQ_IL ( %bb -- x addr ) 20 lshift ADC1_ISQ ; \ ADC1_ISQ_IL, Inserted channel group length
: ADC1_ISQ_ISQ3 ( %bbbbb -- x addr ) 15 lshift ADC1_ISQ ; \ ADC1_ISQ_ISQ3, 4th conversion in inserted  sequence
: ADC1_ISQ_ISQ2 ( %bbbbb -- x addr ) 10 lshift ADC1_ISQ ; \ ADC1_ISQ_ISQ2, 3rd conversion in inserted  sequence
: ADC1_ISQ_ISQ1 ( %bbbbb -- x addr ) 5 lshift ADC1_ISQ ; \ ADC1_ISQ_ISQ1, 2nd conversion in inserted  sequence
: ADC1_ISQ_ISQ0 ( %bbbbb -- x addr ) ADC1_ISQ ; \ ADC1_ISQ_ISQ0, 1st conversion in inserted  sequence

\ ADC1_IDATA0 (read-only) Reset:0x00000000
: ADC1_IDATA0_IDATAn? ( --  x ) ADC1_IDATA0 @ ; \ ADC1_IDATA0_IDATAn, Inserted number n conversion data

\ ADC1_IDATA1 (read-only) Reset:0x00000000
: ADC1_IDATA1_IDATAn? ( --  x ) ADC1_IDATA1 @ ; \ ADC1_IDATA1_IDATAn, Inserted number n conversion data

\ ADC1_IDATA2 (read-only) Reset:0x00000000
: ADC1_IDATA2_IDATAn? ( --  x ) ADC1_IDATA2 @ ; \ ADC1_IDATA2_IDATAn, Inserted number n conversion data

\ ADC1_IDATA3 (read-only) Reset:0x00000000
: ADC1_IDATA3_IDATAn? ( --  x ) ADC1_IDATA3 @ ; \ ADC1_IDATA3_IDATAn, Inserted number n conversion data

\ ADC1_RDATA (read-only) Reset:0x00000000
: ADC1_RDATA_RDATA? ( --  x ) ADC1_RDATA @ ; \ ADC1_RDATA_RDATA, Regular channel data

\ AFIO_EC (read-write) Reset:0x00000000
: AFIO_EC_EOE ( -- x addr ) 7 bit AFIO_EC ; \ AFIO_EC_EOE, Event output enable
: AFIO_EC_PORT ( %bbb -- x addr ) 4 lshift AFIO_EC ; \ AFIO_EC_PORT, Event output port selection
: AFIO_EC_PIN ( %bbbb -- x addr ) AFIO_EC ; \ AFIO_EC_PIN, Event output pin selection

\ AFIO_PCF0 (read-write) Reset:0x00000000
: AFIO_PCF0_TIMER1ITI1_REMAP ( -- x addr ) 29 bit AFIO_PCF0 ; \ AFIO_PCF0_TIMER1ITI1_REMAP, TIMER1 internal trigger 1 remapping
: AFIO_PCF0_SPI2_REMAP ( -- x addr ) 28 bit AFIO_PCF0 ; \ AFIO_PCF0_SPI2_REMAP,  SPI2/I2S2 remapping
: AFIO_PCF0_SWJ_CFG ( %bbb -- x addr ) 24 lshift AFIO_PCF0 ; \ AFIO_PCF0_SWJ_CFG, Serial wire JTAG configuration
: AFIO_PCF0_CAN1_REMAP ( -- x addr ) 22 bit AFIO_PCF0 ; \ AFIO_PCF0_CAN1_REMAP, CAN1 I/O remapping
: AFIO_PCF0_TIMER4CH3_IREMAP ( -- x addr ) 16 bit AFIO_PCF0 ; \ AFIO_PCF0_TIMER4CH3_IREMAP, TIMER4 channel3 internal remapping
: AFIO_PCF0_PD01_REMAP ( -- x addr ) 15 bit AFIO_PCF0 ; \ AFIO_PCF0_PD01_REMAP, Port D0/Port D1 mapping on OSC_IN/OSC_OUT
: AFIO_PCF0_CAN0_REMAP ( %bb -- x addr ) 13 lshift AFIO_PCF0 ; \ AFIO_PCF0_CAN0_REMAP, CAN0 alternate interface remapping
: AFIO_PCF0_TIMER3_REMAP ( -- x addr ) 12 bit AFIO_PCF0 ; \ AFIO_PCF0_TIMER3_REMAP, TIMER3 remapping
: AFIO_PCF0_TIMER2_REMAP ( %bb -- x addr ) 10 lshift AFIO_PCF0 ; \ AFIO_PCF0_TIMER2_REMAP, TIMER2 remapping
: AFIO_PCF0_TIMER1_REMAP ( %bb -- x addr ) 8 lshift AFIO_PCF0 ; \ AFIO_PCF0_TIMER1_REMAP, TIMER1 remapping
: AFIO_PCF0_TIMER0_REMAP ( %bb -- x addr ) 6 lshift AFIO_PCF0 ; \ AFIO_PCF0_TIMER0_REMAP, TIMER0 remapping
: AFIO_PCF0_USART2_REMAP ( %bb -- x addr ) 4 lshift AFIO_PCF0 ; \ AFIO_PCF0_USART2_REMAP, USART2 remapping
: AFIO_PCF0_USART1_REMAP ( -- x addr ) 3 bit AFIO_PCF0 ; \ AFIO_PCF0_USART1_REMAP, USART1 remapping
: AFIO_PCF0_USART0_REMAP ( -- x addr ) 2 bit AFIO_PCF0 ; \ AFIO_PCF0_USART0_REMAP, USART0 remapping
: AFIO_PCF0_I2C0_REMAP ( -- x addr ) 1 bit AFIO_PCF0 ; \ AFIO_PCF0_I2C0_REMAP, I2C0 remapping
: AFIO_PCF0_SPI0_REMAP ( -- x addr ) 0 bit AFIO_PCF0 ; \ AFIO_PCF0_SPI0_REMAP, SPI0 remapping

\ AFIO_EXTISS0 (read-write) Reset:0x00000000
: AFIO_EXTISS0_EXTI3_SS ( %bbbb -- x addr ) 12 lshift AFIO_EXTISS0 ; \ AFIO_EXTISS0_EXTI3_SS, EXTI 3 sources selection
: AFIO_EXTISS0_EXTI2_SS ( %bbbb -- x addr ) 8 lshift AFIO_EXTISS0 ; \ AFIO_EXTISS0_EXTI2_SS, EXTI 2 sources selection
: AFIO_EXTISS0_EXTI1_SS ( %bbbb -- x addr ) 4 lshift AFIO_EXTISS0 ; \ AFIO_EXTISS0_EXTI1_SS, EXTI 1 sources selection
: AFIO_EXTISS0_EXTI0_SS ( %bbbb -- x addr ) AFIO_EXTISS0 ; \ AFIO_EXTISS0_EXTI0_SS, EXTI 0 sources selection

\ AFIO_EXTISS1 (read-write) Reset:0x00000000
: AFIO_EXTISS1_EXTI7_SS ( %bbbb -- x addr ) 12 lshift AFIO_EXTISS1 ; \ AFIO_EXTISS1_EXTI7_SS, EXTI 7 sources selection
: AFIO_EXTISS1_EXTI6_SS ( %bbbb -- x addr ) 8 lshift AFIO_EXTISS1 ; \ AFIO_EXTISS1_EXTI6_SS, EXTI 6 sources selection
: AFIO_EXTISS1_EXTI5_SS ( %bbbb -- x addr ) 4 lshift AFIO_EXTISS1 ; \ AFIO_EXTISS1_EXTI5_SS, EXTI 5 sources selection
: AFIO_EXTISS1_EXTI4_SS ( %bbbb -- x addr ) AFIO_EXTISS1 ; \ AFIO_EXTISS1_EXTI4_SS, EXTI 4 sources selection

\ AFIO_EXTISS2 (read-write) Reset:0x00000000
: AFIO_EXTISS2_EXTI11_SS ( %bbbb -- x addr ) 12 lshift AFIO_EXTISS2 ; \ AFIO_EXTISS2_EXTI11_SS, EXTI 11 sources selection
: AFIO_EXTISS2_EXTI10_SS ( %bbbb -- x addr ) 8 lshift AFIO_EXTISS2 ; \ AFIO_EXTISS2_EXTI10_SS, EXTI 10 sources selection
: AFIO_EXTISS2_EXTI9_SS ( %bbbb -- x addr ) 4 lshift AFIO_EXTISS2 ; \ AFIO_EXTISS2_EXTI9_SS, EXTI 9 sources selection
: AFIO_EXTISS2_EXTI8_SS ( %bbbb -- x addr ) AFIO_EXTISS2 ; \ AFIO_EXTISS2_EXTI8_SS, EXTI 8 sources selection

\ AFIO_EXTISS3 (read-write) Reset:0x00000000
: AFIO_EXTISS3_EXTI15_SS ( %bbbb -- x addr ) 12 lshift AFIO_EXTISS3 ; \ AFIO_EXTISS3_EXTI15_SS, EXTI 15 sources selection
: AFIO_EXTISS3_EXTI14_SS ( %bbbb -- x addr ) 8 lshift AFIO_EXTISS3 ; \ AFIO_EXTISS3_EXTI14_SS, EXTI 14 sources selection
: AFIO_EXTISS3_EXTI13_SS ( %bbbb -- x addr ) 4 lshift AFIO_EXTISS3 ; \ AFIO_EXTISS3_EXTI13_SS, EXTI 13 sources selection
: AFIO_EXTISS3_EXTI12_SS ( %bbbb -- x addr ) AFIO_EXTISS3 ; \ AFIO_EXTISS3_EXTI12_SS, EXTI 12 sources selection

\ AFIO_PCF1 (read-write) Reset:0x00000000
: AFIO_PCF1_EXMC_NADV ( -- x addr ) 10 bit AFIO_PCF1 ; \ AFIO_PCF1_EXMC_NADV, EXMC_NADV connect/disconnect

\ BKP_DATA0 (read-write) Reset:0x0000
: BKP_DATA0_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA0 ; \ BKP_DATA0_DATA, Backup data

\ BKP_DATA1 (read-write) Reset:0x0000
: BKP_DATA1_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA1 ; \ BKP_DATA1_DATA, Backup data

\ BKP_DATA2 (read-write) Reset:0x0000
: BKP_DATA2_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA2 ; \ BKP_DATA2_DATA, Backup data

\ BKP_DATA3 (read-write) Reset:0x0000
: BKP_DATA3_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA3 ; \ BKP_DATA3_DATA, Backup data

\ BKP_DATA4 (read-write) Reset:0x0000
: BKP_DATA4_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA4 ; \ BKP_DATA4_DATA, Backup data

\ BKP_DATA5 (read-write) Reset:0x0000
: BKP_DATA5_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA5 ; \ BKP_DATA5_DATA, Backup data

\ BKP_DATA6 (read-write) Reset:0x0000
: BKP_DATA6_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA6 ; \ BKP_DATA6_DATA, Backup data

\ BKP_DATA7 (read-write) Reset:0x0000
: BKP_DATA7_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA7 ; \ BKP_DATA7_DATA, Backup data

\ BKP_DATA8 (read-write) Reset:0x0000
: BKP_DATA8_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA8 ; \ BKP_DATA8_DATA, Backup data

\ BKP_DATA9 (read-write) Reset:0x0000
: BKP_DATA9_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA9 ; \ BKP_DATA9_DATA, Backup data

\ BKP_DATA10 (read-write) Reset:0x0000
: BKP_DATA10_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA10 ; \ BKP_DATA10_DATA, Backup data

\ BKP_DATA11 (read-write) Reset:0x0000
: BKP_DATA11_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA11 ; \ BKP_DATA11_DATA, Backup data

\ BKP_DATA12 (read-write) Reset:0x0000
: BKP_DATA12_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA12 ; \ BKP_DATA12_DATA, Backup data

\ BKP_DATA13 (read-write) Reset:0x0000
: BKP_DATA13_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA13 ; \ BKP_DATA13_DATA, Backup data

\ BKP_DATA14 (read-write) Reset:0x0000
: BKP_DATA14_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA14 ; \ BKP_DATA14_DATA, Backup data

\ BKP_DATA15 (read-write) Reset:0x0000
: BKP_DATA15_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA15 ; \ BKP_DATA15_DATA, Backup data

\ BKP_DATA16 (read-write) Reset:0x0000
: BKP_DATA16_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA16 ; \ BKP_DATA16_DATA, Backup data

\ BKP_DATA17 (read-write) Reset:0x0000
: BKP_DATA17_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA17 ; \ BKP_DATA17_DATA, Backup data

\ BKP_DATA18 (read-write) Reset:0x0000
: BKP_DATA18_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA18 ; \ BKP_DATA18_DATA, Backup data

\ BKP_DATA19 (read-write) Reset:0x0000
: BKP_DATA19_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA19 ; \ BKP_DATA19_DATA, Backup data

\ BKP_DATA20 (read-write) Reset:0x0000
: BKP_DATA20_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA20 ; \ BKP_DATA20_DATA, Backup data

\ BKP_DATA21 (read-write) Reset:0x0000
: BKP_DATA21_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA21 ; \ BKP_DATA21_DATA, Backup data

\ BKP_DATA22 (read-write) Reset:0x0000
: BKP_DATA22_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA22 ; \ BKP_DATA22_DATA, Backup data

\ BKP_DATA23 (read-write) Reset:0x0000
: BKP_DATA23_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA23 ; \ BKP_DATA23_DATA, Backup data

\ BKP_DATA24 (read-write) Reset:0x0000
: BKP_DATA24_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA24 ; \ BKP_DATA24_DATA, Backup data

\ BKP_DATA25 (read-write) Reset:0x0000
: BKP_DATA25_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA25 ; \ BKP_DATA25_DATA, Backup data

\ BKP_DATA26 (read-write) Reset:0x0000
: BKP_DATA26_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA26 ; \ BKP_DATA26_DATA, Backup data

\ BKP_DATA27 (read-write) Reset:0x0000
: BKP_DATA27_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA27 ; \ BKP_DATA27_DATA, Backup data

\ BKP_DATA28 (read-write) Reset:0x0000
: BKP_DATA28_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA28 ; \ BKP_DATA28_DATA, Backup data

\ BKP_DATA29 (read-write) Reset:0x0000
: BKP_DATA29_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA29 ; \ BKP_DATA29_DATA, Backup data

\ BKP_DATA30 (read-write) Reset:0x0000
: BKP_DATA30_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA30 ; \ BKP_DATA30_DATA, Backup data

\ BKP_DATA31 (read-write) Reset:0x0000
: BKP_DATA31_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA31 ; \ BKP_DATA31_DATA, Backup data

\ BKP_DATA32 (read-write) Reset:0x0000
: BKP_DATA32_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA32 ; \ BKP_DATA32_DATA, Backup data

\ BKP_DATA33 (read-write) Reset:0x0000
: BKP_DATA33_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA33 ; \ BKP_DATA33_DATA, Backup data

\ BKP_DATA34 (read-write) Reset:0x0000
: BKP_DATA34_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA34 ; \ BKP_DATA34_DATA, Backup data

\ BKP_DATA35 (read-write) Reset:0x0000
: BKP_DATA35_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA35 ; \ BKP_DATA35_DATA, Backup data

\ BKP_DATA36 (read-write) Reset:0x0000
: BKP_DATA36_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA36 ; \ BKP_DATA36_DATA, Backup data

\ BKP_DATA37 (read-write) Reset:0x0000
: BKP_DATA37_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA37 ; \ BKP_DATA37_DATA, Backup data

\ BKP_DATA38 (read-write) Reset:0x0000
: BKP_DATA38_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA38 ; \ BKP_DATA38_DATA, Backup data

\ BKP_DATA39 (read-write) Reset:0x0000
: BKP_DATA39_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA39 ; \ BKP_DATA39_DATA, Backup data

\ BKP_DATA40 (read-write) Reset:0x0000
: BKP_DATA40_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA40 ; \ BKP_DATA40_DATA, Backup data

\ BKP_DATA41 (read-write) Reset:0x0000
: BKP_DATA41_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) BKP_DATA41 ; \ BKP_DATA41_DATA, Backup data

\ BKP_OCTL (read-write) Reset:0x0000
: BKP_OCTL_ROSEL ( -- x addr ) 9 bit BKP_OCTL ; \ BKP_OCTL_ROSEL, RTC output selection
: BKP_OCTL_ASOEN ( -- x addr ) 8 bit BKP_OCTL ; \ BKP_OCTL_ASOEN, RTC alarm or second signal output enable
: BKP_OCTL_COEN ( -- x addr ) 7 bit BKP_OCTL ; \ BKP_OCTL_COEN, RTC clock calibration output enable
: BKP_OCTL_RCCV ( %bbbbbbb -- x addr ) BKP_OCTL ; \ BKP_OCTL_RCCV, RTC clock calibration value

\ BKP_TPCTL (read-write) Reset:0x0000
: BKP_TPCTL_TPAL ( -- x addr ) 1 bit BKP_TPCTL ; \ BKP_TPCTL_TPAL, TAMPER pin active level
: BKP_TPCTL_TPEN ( -- x addr ) 0 bit BKP_TPCTL ; \ BKP_TPCTL_TPEN, TAMPER detection enable

\ BKP_TPCS (read-write) Reset:0x0000
: BKP_TPCS_TIF ( -- x addr ) 9 bit BKP_TPCS ; \ BKP_TPCS_TIF, Tamper interrupt flag
: BKP_TPCS_TEF ( -- x addr ) 8 bit BKP_TPCS ; \ BKP_TPCS_TEF, Tamper event flag
: BKP_TPCS_TPIE ( -- x addr ) 2 bit BKP_TPCS ; \ BKP_TPCS_TPIE, Tamper interrupt enable
: BKP_TPCS_TIR ( -- x addr ) 1 bit BKP_TPCS ; \ BKP_TPCS_TIR, Tamper interrupt reset
: BKP_TPCS_TER ( -- x addr ) 0 bit BKP_TPCS ; \ BKP_TPCS_TER, Tamper event reset

\ CAN0_CTL (read-write) Reset:0x00010002
: CAN0_CTL_DFZ ( -- x addr ) 16 bit CAN0_CTL ; \ CAN0_CTL_DFZ, Debug freeze
: CAN0_CTL_SWRST ( -- x addr ) 15 bit CAN0_CTL ; \ CAN0_CTL_SWRST, Software reset
: CAN0_CTL_TTC ( -- x addr ) 7 bit CAN0_CTL ; \ CAN0_CTL_TTC, Time-triggered communication
: CAN0_CTL_ABOR ( -- x addr ) 6 bit CAN0_CTL ; \ CAN0_CTL_ABOR, Automatic bus-off recovery
: CAN0_CTL_AWU ( -- x addr ) 5 bit CAN0_CTL ; \ CAN0_CTL_AWU, Automatic wakeup
: CAN0_CTL_ARD ( -- x addr ) 4 bit CAN0_CTL ; \ CAN0_CTL_ARD, Automatic retransmission disable
: CAN0_CTL_RFOD ( -- x addr ) 3 bit CAN0_CTL ; \ CAN0_CTL_RFOD, Receive FIFO overwrite disable
: CAN0_CTL_TFO ( -- x addr ) 2 bit CAN0_CTL ; \ CAN0_CTL_TFO, Transmit FIFO order
: CAN0_CTL_SLPWMOD ( -- x addr ) 1 bit CAN0_CTL ; \ CAN0_CTL_SLPWMOD, Sleep working mode
: CAN0_CTL_IWMOD ( -- x addr ) 0 bit CAN0_CTL ; \ CAN0_CTL_IWMOD, Initial working mode

\ CAN0_STAT (multiple-access)  Reset:0x00000C02
: CAN0_STAT_RXL ( -- x addr ) 11 bit CAN0_STAT ; \ CAN0_STAT_RXL, RX level
: CAN0_STAT_LASTRX ( -- x addr ) 10 bit CAN0_STAT ; \ CAN0_STAT_LASTRX, Last sample value of RX pin
: CAN0_STAT_RS ( -- x addr ) 9 bit CAN0_STAT ; \ CAN0_STAT_RS, Receiving state
: CAN0_STAT_TS ( -- x addr ) 8 bit CAN0_STAT ; \ CAN0_STAT_TS, Transmitting state
: CAN0_STAT_SLPIF? ( -- 1|0 ) 4 bit CAN0_STAT bit@ ; \ CAN0_STAT_SLPIF, Status change interrupt flag of sleep  	 working mode entering
: CAN0_STAT_WUIF? ( -- 1|0 ) 3 bit CAN0_STAT bit@ ; \ CAN0_STAT_WUIF, Status change interrupt flag of wakeup  	 from sleep working mode
: CAN0_STAT_ERRIF? ( -- 1|0 ) 2 bit CAN0_STAT bit@ ; \ CAN0_STAT_ERRIF, Error interrupt flag
: CAN0_STAT_SLPWS ( -- x addr ) 1 bit CAN0_STAT ; \ CAN0_STAT_SLPWS, Sleep working state
: CAN0_STAT_IWS ( -- x addr ) 0 bit CAN0_STAT ; \ CAN0_STAT_IWS, Initial working state

\ CAN0_TSTAT (multiple-access)  Reset:0x1C000000
: CAN0_TSTAT_TMLS2 ( -- x addr ) 31 bit CAN0_TSTAT ; \ CAN0_TSTAT_TMLS2, Transmit mailbox 2 last sending  	 in transmit FIFO
: CAN0_TSTAT_TMLS1 ( -- x addr ) 30 bit CAN0_TSTAT ; \ CAN0_TSTAT_TMLS1, Transmit mailbox 1 last sending  	 in transmit FIFO
: CAN0_TSTAT_TMLS0 ( -- x addr ) 29 bit CAN0_TSTAT ; \ CAN0_TSTAT_TMLS0, Transmit mailbox 0 last sending  	 in transmit FIFO
: CAN0_TSTAT_TME2 ( -- x addr ) 28 bit CAN0_TSTAT ; \ CAN0_TSTAT_TME2, Transmit mailbox 2 empty
: CAN0_TSTAT_TME1 ( -- x addr ) 27 bit CAN0_TSTAT ; \ CAN0_TSTAT_TME1, Transmit mailbox 1 empty
: CAN0_TSTAT_TME0 ( -- x addr ) 26 bit CAN0_TSTAT ; \ CAN0_TSTAT_TME0, Transmit mailbox 0 empty
: CAN0_TSTAT_NUM ( %bb -- x addr ) 24 lshift CAN0_TSTAT ; \ CAN0_TSTAT_NUM, number of the transmit FIFO mailbox in  	 which the frame will be transmitted if at least one mailbox is empty
: CAN0_TSTAT_MST2 ( -- x addr ) 23 bit CAN0_TSTAT ; \ CAN0_TSTAT_MST2, Mailbox 2 stop transmitting
: CAN0_TSTAT_MTE2 ( -- x addr ) 19 bit CAN0_TSTAT ; \ CAN0_TSTAT_MTE2, Mailbox 2 transmit error
: CAN0_TSTAT_MAL2 ( -- x addr ) 18 bit CAN0_TSTAT ; \ CAN0_TSTAT_MAL2, Mailbox 2 arbitration lost
: CAN0_TSTAT_MTFNERR2 ( -- x addr ) 17 bit CAN0_TSTAT ; \ CAN0_TSTAT_MTFNERR2, Mailbox 2 transmit finished and no error
: CAN0_TSTAT_MTF2 ( -- x addr ) 16 bit CAN0_TSTAT ; \ CAN0_TSTAT_MTF2, Mailbox 2 transmit finished
: CAN0_TSTAT_MST1 ( -- x addr ) 15 bit CAN0_TSTAT ; \ CAN0_TSTAT_MST1, Mailbox 1 stop transmitting
: CAN0_TSTAT_MTE1 ( -- x addr ) 11 bit CAN0_TSTAT ; \ CAN0_TSTAT_MTE1, Mailbox 1 transmit error
: CAN0_TSTAT_MAL1 ( -- x addr ) 10 bit CAN0_TSTAT ; \ CAN0_TSTAT_MAL1, Mailbox 1 arbitration lost
: CAN0_TSTAT_MTFNERR1 ( -- x addr ) 9 bit CAN0_TSTAT ; \ CAN0_TSTAT_MTFNERR1, Mailbox 1 transmit finished and no error
: CAN0_TSTAT_MTF1 ( -- x addr ) 8 bit CAN0_TSTAT ; \ CAN0_TSTAT_MTF1, Mailbox 1 transmit finished
: CAN0_TSTAT_MST0 ( -- x addr ) 7 bit CAN0_TSTAT ; \ CAN0_TSTAT_MST0, Mailbox 0 stop transmitting
: CAN0_TSTAT_MTE0 ( -- x addr ) 3 bit CAN0_TSTAT ; \ CAN0_TSTAT_MTE0, Mailbox 0 transmit error
: CAN0_TSTAT_MAL0 ( -- x addr ) 2 bit CAN0_TSTAT ; \ CAN0_TSTAT_MAL0, Mailbox 0 arbitration lost
: CAN0_TSTAT_MTFNERR0 ( -- x addr ) 1 bit CAN0_TSTAT ; \ CAN0_TSTAT_MTFNERR0, Mailbox 0 transmit finished and no error
: CAN0_TSTAT_MTF0 ( -- x addr ) 0 bit CAN0_TSTAT ; \ CAN0_TSTAT_MTF0, Mailbox 0 transmit finished

\ CAN0_RFIFO0 (multiple-access)  Reset:0x00000000
: CAN0_RFIFO0_RFD0 ( -- x addr ) 5 bit CAN0_RFIFO0 ; \ CAN0_RFIFO0_RFD0, Receive FIFO0 dequeue
: CAN0_RFIFO0_RFO0 ( -- x addr ) 4 bit CAN0_RFIFO0 ; \ CAN0_RFIFO0_RFO0, Receive FIFO0 overfull
: CAN0_RFIFO0_RFF0 ( -- x addr ) 3 bit CAN0_RFIFO0 ; \ CAN0_RFIFO0_RFF0, Receive FIFO0 full
: CAN0_RFIFO0_RFL0 ( %bb -- x addr ) CAN0_RFIFO0 ; \ CAN0_RFIFO0_RFL0, Receive FIFO0 length

\ CAN0_RFIFO1 (multiple-access)  Reset:0x00000000
: CAN0_RFIFO1_RFD1 ( -- x addr ) 5 bit CAN0_RFIFO1 ; \ CAN0_RFIFO1_RFD1, Receive FIFO1 dequeue
: CAN0_RFIFO1_RFO1 ( -- x addr ) 4 bit CAN0_RFIFO1 ; \ CAN0_RFIFO1_RFO1, Receive FIFO1 overfull
: CAN0_RFIFO1_RFF1 ( -- x addr ) 3 bit CAN0_RFIFO1 ; \ CAN0_RFIFO1_RFF1, Receive FIFO1 full
: CAN0_RFIFO1_RFL1 ( %bb -- x addr ) CAN0_RFIFO1 ; \ CAN0_RFIFO1_RFL1, Receive FIFO1 length

\ CAN0_INTEN (read-write) Reset:0x00000000
: CAN0_INTEN_SLPWIE ( -- x addr ) 17 bit CAN0_INTEN ; \ CAN0_INTEN_SLPWIE, Sleep working interrupt enable
: CAN0_INTEN_WIE ( -- x addr ) 16 bit CAN0_INTEN ; \ CAN0_INTEN_WIE, Wakeup interrupt enable
: CAN0_INTEN_ERRIE ( -- x addr ) 15 bit CAN0_INTEN ; \ CAN0_INTEN_ERRIE, Error interrupt enable
: CAN0_INTEN_ERRNIE ( -- x addr ) 11 bit CAN0_INTEN ; \ CAN0_INTEN_ERRNIE, Error number interrupt enable
: CAN0_INTEN_BOIE ( -- x addr ) 10 bit CAN0_INTEN ; \ CAN0_INTEN_BOIE, Bus-off interrupt enable
: CAN0_INTEN_PERRIE ( -- x addr ) 9 bit CAN0_INTEN ; \ CAN0_INTEN_PERRIE, Passive error interrupt enable
: CAN0_INTEN_WERRIE ( -- x addr ) 8 bit CAN0_INTEN ; \ CAN0_INTEN_WERRIE, Warning error interrupt enable
: CAN0_INTEN_RFOIE1 ( -- x addr ) 6 bit CAN0_INTEN ; \ CAN0_INTEN_RFOIE1, Receive FIFO1 overfull interrupt enable
: CAN0_INTEN_RFFIE1 ( -- x addr ) 5 bit CAN0_INTEN ; \ CAN0_INTEN_RFFIE1, Receive FIFO1 full interrupt enable
: CAN0_INTEN_RFNEIE1 ( -- x addr ) 4 bit CAN0_INTEN ; \ CAN0_INTEN_RFNEIE1, Receive FIFO1 not empty interrupt enable
: CAN0_INTEN_RFOIE0 ( -- x addr ) 3 bit CAN0_INTEN ; \ CAN0_INTEN_RFOIE0, Receive FIFO0 overfull interrupt enable
: CAN0_INTEN_RFFIE0 ( -- x addr ) 2 bit CAN0_INTEN ; \ CAN0_INTEN_RFFIE0, Receive FIFO0 full interrupt enable
: CAN0_INTEN_RFNEIE0 ( -- x addr ) 1 bit CAN0_INTEN ; \ CAN0_INTEN_RFNEIE0, Receive FIFO0 not empty interrupt enable
: CAN0_INTEN_TMEIE ( -- x addr ) 0 bit CAN0_INTEN ; \ CAN0_INTEN_TMEIE, Transmit mailbox empty interrupt enable

\ CAN0_ERR (multiple-access)  Reset:0x00000000
: CAN0_ERR_RECNT ( %bbbbbbbb -- x addr ) 24 lshift CAN0_ERR ; \ CAN0_ERR_RECNT, Receive Error Count defined  	 by the CAN standard
: CAN0_ERR_TECNT ( %bbbbbbbb -- x addr ) 16 lshift CAN0_ERR ; \ CAN0_ERR_TECNT, Transmit Error Count defined  	 by the CAN standard
: CAN0_ERR_ERRN ( %bbb -- x addr ) 4 lshift CAN0_ERR ; \ CAN0_ERR_ERRN, Error number
: CAN0_ERR_BOERR ( -- x addr ) 2 bit CAN0_ERR ; \ CAN0_ERR_BOERR, Bus-off error
: CAN0_ERR_PERR ( -- x addr ) 1 bit CAN0_ERR ; \ CAN0_ERR_PERR, Passive error
: CAN0_ERR_WERR ( -- x addr ) 0 bit CAN0_ERR ; \ CAN0_ERR_WERR, Warning error

\ CAN0_BT (read-write) Reset:0x01230000
: CAN0_BT_SCMOD ( -- x addr ) 31 bit CAN0_BT ; \ CAN0_BT_SCMOD, Silent communication mode
: CAN0_BT_LCMOD ( -- x addr ) 30 bit CAN0_BT ; \ CAN0_BT_LCMOD, Loopback communication mode
: CAN0_BT_SJW ( %bb -- x addr ) 24 lshift CAN0_BT ; \ CAN0_BT_SJW, Resynchronization jump width
: CAN0_BT_BS2 ( %bbb -- x addr ) 20 lshift CAN0_BT ; \ CAN0_BT_BS2, Bit segment 2
: CAN0_BT_BS1 ( %bbbb -- x addr ) 16 lshift CAN0_BT ; \ CAN0_BT_BS1, Bit segment 1
: CAN0_BT_BAUDPSC ( %bbbbbbbbbb -- x addr ) CAN0_BT ; \ CAN0_BT_BAUDPSC, Baud rate prescaler

\ CAN0_TMI0 (read-write) Reset:0x00000000
: CAN0_TMI0_SFID_EFID x addr ) 21 lshift CAN0_TMI0 ; \ CAN0_TMI0_SFID_EFID, The frame identifier
: CAN0_TMI0_EFID x addr ) 3 lshift CAN0_TMI0 ; \ CAN0_TMI0_EFID, The frame identifier
: CAN0_TMI0_FF ( -- x addr ) 2 bit CAN0_TMI0 ; \ CAN0_TMI0_FF, Frame format
: CAN0_TMI0_FT ( -- x addr ) 1 bit CAN0_TMI0 ; \ CAN0_TMI0_FT, Frame type
: CAN0_TMI0_TEN ( -- x addr ) 0 bit CAN0_TMI0 ; \ CAN0_TMI0_TEN, Transmit enable

\ CAN0_TMP0 (read-write) Reset:0x00000000
: CAN0_TMP0_TS ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift CAN0_TMP0 ; \ CAN0_TMP0_TS, Time stamp
: CAN0_TMP0_TSEN ( -- x addr ) 8 bit CAN0_TMP0 ; \ CAN0_TMP0_TSEN, Time stamp enable
: CAN0_TMP0_DLENC ( %bbbb -- x addr ) CAN0_TMP0 ; \ CAN0_TMP0_DLENC, Data length code

\ CAN0_TMDATA00 (read-write) Reset:0x00000000
: CAN0_TMDATA00_DB3 ( %bbbbbbbb -- x addr ) 24 lshift CAN0_TMDATA00 ; \ CAN0_TMDATA00_DB3, Data byte 3
: CAN0_TMDATA00_DB2 ( %bbbbbbbb -- x addr ) 16 lshift CAN0_TMDATA00 ; \ CAN0_TMDATA00_DB2, Data byte 2
: CAN0_TMDATA00_DB1 ( %bbbbbbbb -- x addr ) 8 lshift CAN0_TMDATA00 ; \ CAN0_TMDATA00_DB1, Data byte 1
: CAN0_TMDATA00_DB0 ( %bbbbbbbb -- x addr ) CAN0_TMDATA00 ; \ CAN0_TMDATA00_DB0, Data byte 0

\ CAN0_TMDATA10 (read-write) Reset:0x00000000
: CAN0_TMDATA10_DB7 ( %bbbbbbbb -- x addr ) 24 lshift CAN0_TMDATA10 ; \ CAN0_TMDATA10_DB7, Data byte 7
: CAN0_TMDATA10_DB6 ( %bbbbbbbb -- x addr ) 16 lshift CAN0_TMDATA10 ; \ CAN0_TMDATA10_DB6, Data byte 6
: CAN0_TMDATA10_DB5 ( %bbbbbbbb -- x addr ) 8 lshift CAN0_TMDATA10 ; \ CAN0_TMDATA10_DB5, Data byte 5
: CAN0_TMDATA10_DB4 ( %bbbbbbbb -- x addr ) CAN0_TMDATA10 ; \ CAN0_TMDATA10_DB4, Data byte 4

\ CAN0_TMI1 (read-write) Reset:0x00000000
: CAN0_TMI1_SFID_EFID x addr ) 21 lshift CAN0_TMI1 ; \ CAN0_TMI1_SFID_EFID, The frame identifier
: CAN0_TMI1_EFID x addr ) 3 lshift CAN0_TMI1 ; \ CAN0_TMI1_EFID, The frame identifier
: CAN0_TMI1_FF ( -- x addr ) 2 bit CAN0_TMI1 ; \ CAN0_TMI1_FF, Frame format
: CAN0_TMI1_FT ( -- x addr ) 1 bit CAN0_TMI1 ; \ CAN0_TMI1_FT, Frame type
: CAN0_TMI1_TEN ( -- x addr ) 0 bit CAN0_TMI1 ; \ CAN0_TMI1_TEN, Transmit enable

\ CAN0_TMP1 (read-write) Reset:0x00000000
: CAN0_TMP1_TS ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift CAN0_TMP1 ; \ CAN0_TMP1_TS, Time stamp
: CAN0_TMP1_TSEN ( -- x addr ) 8 bit CAN0_TMP1 ; \ CAN0_TMP1_TSEN, Time stamp enable
: CAN0_TMP1_DLENC ( %bbbb -- x addr ) CAN0_TMP1 ; \ CAN0_TMP1_DLENC, Data length code

\ CAN0_TMDATA01 (read-write) Reset:0x00000000
: CAN0_TMDATA01_DB3 ( %bbbbbbbb -- x addr ) 24 lshift CAN0_TMDATA01 ; \ CAN0_TMDATA01_DB3, Data byte 3
: CAN0_TMDATA01_DB2 ( %bbbbbbbb -- x addr ) 16 lshift CAN0_TMDATA01 ; \ CAN0_TMDATA01_DB2, Data byte 2
: CAN0_TMDATA01_DB1 ( %bbbbbbbb -- x addr ) 8 lshift CAN0_TMDATA01 ; \ CAN0_TMDATA01_DB1, Data byte 1
: CAN0_TMDATA01_DB0 ( %bbbbbbbb -- x addr ) CAN0_TMDATA01 ; \ CAN0_TMDATA01_DB0, Data byte 0

\ CAN0_TMDATA11 (read-write) Reset:0x00000000
: CAN0_TMDATA11_DB7 ( %bbbbbbbb -- x addr ) 24 lshift CAN0_TMDATA11 ; \ CAN0_TMDATA11_DB7, Data byte 7
: CAN0_TMDATA11_DB6 ( %bbbbbbbb -- x addr ) 16 lshift CAN0_TMDATA11 ; \ CAN0_TMDATA11_DB6, Data byte 6
: CAN0_TMDATA11_DB5 ( %bbbbbbbb -- x addr ) 8 lshift CAN0_TMDATA11 ; \ CAN0_TMDATA11_DB5, Data byte 5
: CAN0_TMDATA11_DB4 ( %bbbbbbbb -- x addr ) CAN0_TMDATA11 ; \ CAN0_TMDATA11_DB4, Data byte 4

\ CAN0_TMI2 (read-write) Reset:0x00000000
: CAN0_TMI2_SFID_EFID x addr ) 21 lshift CAN0_TMI2 ; \ CAN0_TMI2_SFID_EFID, The frame identifier
: CAN0_TMI2_EFID x addr ) 3 lshift CAN0_TMI2 ; \ CAN0_TMI2_EFID, The frame identifier
: CAN0_TMI2_FF ( -- x addr ) 2 bit CAN0_TMI2 ; \ CAN0_TMI2_FF, Frame format
: CAN0_TMI2_FT ( -- x addr ) 1 bit CAN0_TMI2 ; \ CAN0_TMI2_FT, Frame type
: CAN0_TMI2_TEN ( -- x addr ) 0 bit CAN0_TMI2 ; \ CAN0_TMI2_TEN, Transmit enable

\ CAN0_TMP2 (read-write) Reset:0x00000000
: CAN0_TMP2_TS ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift CAN0_TMP2 ; \ CAN0_TMP2_TS, Time stamp
: CAN0_TMP2_TSEN ( -- x addr ) 8 bit CAN0_TMP2 ; \ CAN0_TMP2_TSEN, Time stamp enable
: CAN0_TMP2_DLENC ( %bbbb -- x addr ) CAN0_TMP2 ; \ CAN0_TMP2_DLENC, Data length code

\ CAN0_TMDATA02 (read-write) Reset:0x00000000
: CAN0_TMDATA02_DB3 ( %bbbbbbbb -- x addr ) 24 lshift CAN0_TMDATA02 ; \ CAN0_TMDATA02_DB3, Data byte 3
: CAN0_TMDATA02_DB2 ( %bbbbbbbb -- x addr ) 16 lshift CAN0_TMDATA02 ; \ CAN0_TMDATA02_DB2, Data byte 2
: CAN0_TMDATA02_DB1 ( %bbbbbbbb -- x addr ) 8 lshift CAN0_TMDATA02 ; \ CAN0_TMDATA02_DB1, Data byte 1
: CAN0_TMDATA02_DB0 ( %bbbbbbbb -- x addr ) CAN0_TMDATA02 ; \ CAN0_TMDATA02_DB0, Data byte 0

\ CAN0_TMDATA12 (read-write) Reset:0x00000000
: CAN0_TMDATA12_DB7 ( %bbbbbbbb -- x addr ) 24 lshift CAN0_TMDATA12 ; \ CAN0_TMDATA12_DB7, Data byte 7
: CAN0_TMDATA12_DB6 ( %bbbbbbbb -- x addr ) 16 lshift CAN0_TMDATA12 ; \ CAN0_TMDATA12_DB6, Data byte 6
: CAN0_TMDATA12_DB5 ( %bbbbbbbb -- x addr ) 8 lshift CAN0_TMDATA12 ; \ CAN0_TMDATA12_DB5, Data byte 5
: CAN0_TMDATA12_DB4 ( %bbbbbbbb -- x addr ) CAN0_TMDATA12 ; \ CAN0_TMDATA12_DB4, Data byte 4

\ CAN0_RFIFOMI0 (read-only) Reset:0x00000000
: CAN0_RFIFOMI0_SFID_EFID? ( --  x ) 21 lshift CAN0_RFIFOMI0 @ ; \ CAN0_RFIFOMI0_SFID_EFID, The frame identifier
: CAN0_RFIFOMI0_EFID? ( --  x ) 3 lshift CAN0_RFIFOMI0 @ ; \ CAN0_RFIFOMI0_EFID, The frame identifier
: CAN0_RFIFOMI0_FF? ( --  1|0 ) 2 bit CAN0_RFIFOMI0 bit@ ; \ CAN0_RFIFOMI0_FF, Frame format
: CAN0_RFIFOMI0_FT? ( --  1|0 ) 1 bit CAN0_RFIFOMI0 bit@ ; \ CAN0_RFIFOMI0_FT, Frame type

\ CAN0_RFIFOMP0 (read-only) Reset:0x00000000
: CAN0_RFIFOMP0_TS? ( --  x ) 16 lshift CAN0_RFIFOMP0 @ ; \ CAN0_RFIFOMP0_TS, Time stamp
: CAN0_RFIFOMP0_FI? ( --  x ) 8 lshift CAN0_RFIFOMP0 @ ; \ CAN0_RFIFOMP0_FI, Filtering index
: CAN0_RFIFOMP0_DLENC? ( --  x ) CAN0_RFIFOMP0 @ ; \ CAN0_RFIFOMP0_DLENC, Data length code

\ CAN0_RFIFOMDATA00 (read-only) Reset:0x00000000
: CAN0_RFIFOMDATA00_DB3? ( --  x ) 24 lshift CAN0_RFIFOMDATA00 @ ; \ CAN0_RFIFOMDATA00_DB3, Data byte 3
: CAN0_RFIFOMDATA00_DB2? ( --  x ) 16 lshift CAN0_RFIFOMDATA00 @ ; \ CAN0_RFIFOMDATA00_DB2, Data byte 2
: CAN0_RFIFOMDATA00_DB1? ( --  x ) 8 lshift CAN0_RFIFOMDATA00 @ ; \ CAN0_RFIFOMDATA00_DB1, Data byte 1
: CAN0_RFIFOMDATA00_DB0? ( --  x ) CAN0_RFIFOMDATA00 @ ; \ CAN0_RFIFOMDATA00_DB0, Data byte 0

\ CAN0_RFIFOMDATA10 (read-only) Reset:0x00000000
: CAN0_RFIFOMDATA10_DB7? ( --  x ) 24 lshift CAN0_RFIFOMDATA10 @ ; \ CAN0_RFIFOMDATA10_DB7, Data byte 7
: CAN0_RFIFOMDATA10_DB6? ( --  x ) 16 lshift CAN0_RFIFOMDATA10 @ ; \ CAN0_RFIFOMDATA10_DB6, Data byte 6
: CAN0_RFIFOMDATA10_DB5? ( --  x ) 8 lshift CAN0_RFIFOMDATA10 @ ; \ CAN0_RFIFOMDATA10_DB5, Data byte 5
: CAN0_RFIFOMDATA10_DB4? ( --  x ) CAN0_RFIFOMDATA10 @ ; \ CAN0_RFIFOMDATA10_DB4, Data byte 4

\ CAN0_RFIFOMI1 (read-only) Reset:0x00000000
: CAN0_RFIFOMI1_SFID_EFID? ( --  x ) 21 lshift CAN0_RFIFOMI1 @ ; \ CAN0_RFIFOMI1_SFID_EFID, The frame identifier
: CAN0_RFIFOMI1_EFID? ( --  x ) 3 lshift CAN0_RFIFOMI1 @ ; \ CAN0_RFIFOMI1_EFID, The frame identifier
: CAN0_RFIFOMI1_FF? ( --  1|0 ) 2 bit CAN0_RFIFOMI1 bit@ ; \ CAN0_RFIFOMI1_FF, Frame format
: CAN0_RFIFOMI1_FT? ( --  1|0 ) 1 bit CAN0_RFIFOMI1 bit@ ; \ CAN0_RFIFOMI1_FT, Frame type

\ CAN0_RFIFOMP1 (read-only) Reset:0x00000000
: CAN0_RFIFOMP1_TS? ( --  x ) 16 lshift CAN0_RFIFOMP1 @ ; \ CAN0_RFIFOMP1_TS, Time stamp
: CAN0_RFIFOMP1_FI? ( --  x ) 8 lshift CAN0_RFIFOMP1 @ ; \ CAN0_RFIFOMP1_FI, Filtering index
: CAN0_RFIFOMP1_DLENC? ( --  x ) CAN0_RFIFOMP1 @ ; \ CAN0_RFIFOMP1_DLENC, Data length code

\ CAN0_RFIFOMDATA01 (read-only) Reset:0x00000000
: CAN0_RFIFOMDATA01_DB3? ( --  x ) 24 lshift CAN0_RFIFOMDATA01 @ ; \ CAN0_RFIFOMDATA01_DB3, Data byte 3
: CAN0_RFIFOMDATA01_DB2? ( --  x ) 16 lshift CAN0_RFIFOMDATA01 @ ; \ CAN0_RFIFOMDATA01_DB2, Data byte 2
: CAN0_RFIFOMDATA01_DB1? ( --  x ) 8 lshift CAN0_RFIFOMDATA01 @ ; \ CAN0_RFIFOMDATA01_DB1, Data byte 1
: CAN0_RFIFOMDATA01_DB0? ( --  x ) CAN0_RFIFOMDATA01 @ ; \ CAN0_RFIFOMDATA01_DB0, Data byte 0

\ CAN0_RFIFOMDATA11 (read-only) Reset:0x00000000
: CAN0_RFIFOMDATA11_DB7? ( --  x ) 24 lshift CAN0_RFIFOMDATA11 @ ; \ CAN0_RFIFOMDATA11_DB7, Data byte 7
: CAN0_RFIFOMDATA11_DB6? ( --  x ) 16 lshift CAN0_RFIFOMDATA11 @ ; \ CAN0_RFIFOMDATA11_DB6, Data byte 6
: CAN0_RFIFOMDATA11_DB5? ( --  x ) 8 lshift CAN0_RFIFOMDATA11 @ ; \ CAN0_RFIFOMDATA11_DB5, Data byte 5
: CAN0_RFIFOMDATA11_DB4? ( --  x ) CAN0_RFIFOMDATA11 @ ; \ CAN0_RFIFOMDATA11_DB4, Data byte 4

\ CAN0_FCTL (read-write) Reset:0x2A1C0E01
: CAN0_FCTL_HBC1F ( %bbbbbb -- x addr ) 8 lshift CAN0_FCTL ; \ CAN0_FCTL_HBC1F, Header bank of CAN1 filter
: CAN0_FCTL_FLD ( -- x addr ) 0 bit CAN0_FCTL ; \ CAN0_FCTL_FLD, Filter lock disable

\ CAN0_FMCFG (read-write) Reset:0x00000000
: CAN0_FMCFG_FMOD27 ( -- x addr ) 27 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD27, Filter mode
: CAN0_FMCFG_FMOD26 ( -- x addr ) 26 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD26, Filter mode
: CAN0_FMCFG_FMOD25 ( -- x addr ) 25 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD25, Filter mode
: CAN0_FMCFG_FMOD24 ( -- x addr ) 24 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD24, Filter mode
: CAN0_FMCFG_FMOD23 ( -- x addr ) 23 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD23, Filter mode
: CAN0_FMCFG_FMOD22 ( -- x addr ) 22 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD22, Filter mode
: CAN0_FMCFG_FMOD21 ( -- x addr ) 21 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD21, Filter mode
: CAN0_FMCFG_FMOD20 ( -- x addr ) 20 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD20, Filter mode
: CAN0_FMCFG_FMOD19 ( -- x addr ) 19 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD19, Filter mode
: CAN0_FMCFG_FMOD18 ( -- x addr ) 18 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD18, Filter mode
: CAN0_FMCFG_FMOD17 ( -- x addr ) 17 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD17, Filter mode
: CAN0_FMCFG_FMOD16 ( -- x addr ) 16 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD16, Filter mode
: CAN0_FMCFG_FMOD15 ( -- x addr ) 15 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD15, Filter mode
: CAN0_FMCFG_FMOD14 ( -- x addr ) 14 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD14, Filter mode
: CAN0_FMCFG_FMOD13 ( -- x addr ) 13 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD13, Filter mode
: CAN0_FMCFG_FMOD12 ( -- x addr ) 12 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD12, Filter mode
: CAN0_FMCFG_FMOD11 ( -- x addr ) 11 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD11, Filter mode
: CAN0_FMCFG_FMOD10 ( -- x addr ) 10 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD10, Filter mode
: CAN0_FMCFG_FMOD9 ( -- x addr ) 9 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD9, Filter mode
: CAN0_FMCFG_FMOD8 ( -- x addr ) 8 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD8, Filter mode
: CAN0_FMCFG_FMOD7 ( -- x addr ) 7 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD7, Filter mode
: CAN0_FMCFG_FMOD6 ( -- x addr ) 6 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD6, Filter mode
: CAN0_FMCFG_FMOD5 ( -- x addr ) 5 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD5, Filter mode
: CAN0_FMCFG_FMOD4 ( -- x addr ) 4 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD4, Filter mode
: CAN0_FMCFG_FMOD3 ( -- x addr ) 3 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD3, Filter mode
: CAN0_FMCFG_FMOD2 ( -- x addr ) 2 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD2, Filter mode
: CAN0_FMCFG_FMOD1 ( -- x addr ) 1 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD1, Filter mode
: CAN0_FMCFG_FMOD0 ( -- x addr ) 0 bit CAN0_FMCFG ; \ CAN0_FMCFG_FMOD0, Filter mode

\ CAN0_FSCFG (read-write) Reset:0x00000000
: CAN0_FSCFG_FS0 ( -- x addr ) 0 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS0, Filter scale configuration
: CAN0_FSCFG_FS1 ( -- x addr ) 1 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS1, Filter scale configuration
: CAN0_FSCFG_FS2 ( -- x addr ) 2 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS2, Filter scale configuration
: CAN0_FSCFG_FS3 ( -- x addr ) 3 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS3, Filter scale configuration
: CAN0_FSCFG_FS4 ( -- x addr ) 4 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS4, Filter scale configuration
: CAN0_FSCFG_FS5 ( -- x addr ) 5 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS5, Filter scale configuration
: CAN0_FSCFG_FS6 ( -- x addr ) 6 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS6, Filter scale configuration
: CAN0_FSCFG_FS7 ( -- x addr ) 7 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS7, Filter scale configuration
: CAN0_FSCFG_FS8 ( -- x addr ) 8 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS8, Filter scale configuration
: CAN0_FSCFG_FS9 ( -- x addr ) 9 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS9, Filter scale configuration
: CAN0_FSCFG_FS10 ( -- x addr ) 10 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS10, Filter scale configuration
: CAN0_FSCFG_FS11 ( -- x addr ) 11 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS11, Filter scale configuration
: CAN0_FSCFG_FS12 ( -- x addr ) 12 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS12, Filter scale configuration
: CAN0_FSCFG_FS13 ( -- x addr ) 13 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS13, Filter scale configuration
: CAN0_FSCFG_FS14 ( -- x addr ) 14 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS14, Filter scale configuration
: CAN0_FSCFG_FS15 ( -- x addr ) 15 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS15, Filter scale configuration
: CAN0_FSCFG_FS16 ( -- x addr ) 16 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS16, Filter scale configuration
: CAN0_FSCFG_FS17 ( -- x addr ) 17 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS17, Filter scale configuration
: CAN0_FSCFG_FS18 ( -- x addr ) 18 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS18, Filter scale configuration
: CAN0_FSCFG_FS19 ( -- x addr ) 19 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS19, Filter scale configuration
: CAN0_FSCFG_FS20 ( -- x addr ) 20 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS20, Filter scale configuration
: CAN0_FSCFG_FS21 ( -- x addr ) 21 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS21, Filter scale configuration
: CAN0_FSCFG_FS22 ( -- x addr ) 22 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS22, Filter scale configuration
: CAN0_FSCFG_FS23 ( -- x addr ) 23 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS23, Filter scale configuration
: CAN0_FSCFG_FS24 ( -- x addr ) 24 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS24, Filter scale configuration
: CAN0_FSCFG_FS25 ( -- x addr ) 25 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS25, Filter scale configuration
: CAN0_FSCFG_FS26 ( -- x addr ) 26 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS26, Filter scale configuration
: CAN0_FSCFG_FS27 ( -- x addr ) 27 bit CAN0_FSCFG ; \ CAN0_FSCFG_FS27, Filter scale configuration

\ CAN0_FAFIFO (read-write) Reset:0x00000000
: CAN0_FAFIFO_FAF0 ( -- x addr ) 0 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF0, Filter 0 associated with FIFO
: CAN0_FAFIFO_FAF1 ( -- x addr ) 1 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF1, Filter 1 associated with FIFO
: CAN0_FAFIFO_FAF2 ( -- x addr ) 2 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF2, Filter 2 associated with FIFO
: CAN0_FAFIFO_FAF3 ( -- x addr ) 3 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF3, Filter 3 associated with FIFO
: CAN0_FAFIFO_FAF4 ( -- x addr ) 4 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF4, Filter 4 associated with FIFO
: CAN0_FAFIFO_FAF5 ( -- x addr ) 5 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF5, Filter 5 associated with FIFO
: CAN0_FAFIFO_FAF6 ( -- x addr ) 6 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF6, Filter 6 associated with FIFO
: CAN0_FAFIFO_FAF7 ( -- x addr ) 7 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF7, Filter 7 associated with FIFO
: CAN0_FAFIFO_FAF8 ( -- x addr ) 8 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF8, Filter 8 associated with FIFO
: CAN0_FAFIFO_FAF9 ( -- x addr ) 9 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF9, Filter 9 associated with FIFO
: CAN0_FAFIFO_FAF10 ( -- x addr ) 10 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF10, Filter 10 associated with FIFO
: CAN0_FAFIFO_FAF11 ( -- x addr ) 11 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF11, Filter 11 associated with FIFO
: CAN0_FAFIFO_FAF12 ( -- x addr ) 12 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF12, Filter 12 associated with FIFO
: CAN0_FAFIFO_FAF13 ( -- x addr ) 13 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF13, Filter 13 associated with FIFO
: CAN0_FAFIFO_FAF14 ( -- x addr ) 14 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF14, Filter 14 associated with FIFO
: CAN0_FAFIFO_FAF15 ( -- x addr ) 15 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF15, Filter 15 associated with FIFO
: CAN0_FAFIFO_FAF16 ( -- x addr ) 16 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF16, Filter 16 associated with FIFO
: CAN0_FAFIFO_FAF17 ( -- x addr ) 17 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF17, Filter 17 associated with FIFO
: CAN0_FAFIFO_FAF18 ( -- x addr ) 18 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF18, Filter 18 associated with FIFO
: CAN0_FAFIFO_FAF19 ( -- x addr ) 19 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF19, Filter 19 associated with FIFO
: CAN0_FAFIFO_FAF20 ( -- x addr ) 20 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF20, Filter 20 associated with FIFO
: CAN0_FAFIFO_FAF21 ( -- x addr ) 21 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF21, Filter 21 associated with FIFO
: CAN0_FAFIFO_FAF22 ( -- x addr ) 22 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF22, Filter 22 associated with FIFO
: CAN0_FAFIFO_FAF23 ( -- x addr ) 23 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF23, Filter 23 associated with FIFO
: CAN0_FAFIFO_FAF24 ( -- x addr ) 24 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF24, Filter 24 associated with FIFO
: CAN0_FAFIFO_FAF25 ( -- x addr ) 25 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF25, Filter 25 associated with FIFO
: CAN0_FAFIFO_FAF26 ( -- x addr ) 26 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF26, Filter 26 associated with FIFO
: CAN0_FAFIFO_FAF27 ( -- x addr ) 27 bit CAN0_FAFIFO ; \ CAN0_FAFIFO_FAF27, Filter 27 associated with FIFO

\ CAN0_FW (read-write) Reset:0x00000000
: CAN0_FW_FW0 ( -- x addr ) 0 bit CAN0_FW ; \ CAN0_FW_FW0, Filter working
: CAN0_FW_FW1 ( -- x addr ) 1 bit CAN0_FW ; \ CAN0_FW_FW1, Filter working
: CAN0_FW_FW2 ( -- x addr ) 2 bit CAN0_FW ; \ CAN0_FW_FW2, Filter working
: CAN0_FW_FW3 ( -- x addr ) 3 bit CAN0_FW ; \ CAN0_FW_FW3, Filter working
: CAN0_FW_FW4 ( -- x addr ) 4 bit CAN0_FW ; \ CAN0_FW_FW4, Filter working
: CAN0_FW_FW5 ( -- x addr ) 5 bit CAN0_FW ; \ CAN0_FW_FW5, Filter working
: CAN0_FW_FW6 ( -- x addr ) 6 bit CAN0_FW ; \ CAN0_FW_FW6, Filter working
: CAN0_FW_FW7 ( -- x addr ) 7 bit CAN0_FW ; \ CAN0_FW_FW7, Filter working
: CAN0_FW_FW8 ( -- x addr ) 8 bit CAN0_FW ; \ CAN0_FW_FW8, Filter working
: CAN0_FW_FW9 ( -- x addr ) 9 bit CAN0_FW ; \ CAN0_FW_FW9, Filter working
: CAN0_FW_FW10 ( -- x addr ) 10 bit CAN0_FW ; \ CAN0_FW_FW10, Filter working
: CAN0_FW_FW11 ( -- x addr ) 11 bit CAN0_FW ; \ CAN0_FW_FW11, Filter working
: CAN0_FW_FW12 ( -- x addr ) 12 bit CAN0_FW ; \ CAN0_FW_FW12, Filter working
: CAN0_FW_FW13 ( -- x addr ) 13 bit CAN0_FW ; \ CAN0_FW_FW13, Filter working
: CAN0_FW_FW14 ( -- x addr ) 14 bit CAN0_FW ; \ CAN0_FW_FW14, Filter working
: CAN0_FW_FW15 ( -- x addr ) 15 bit CAN0_FW ; \ CAN0_FW_FW15, Filter working
: CAN0_FW_FW16 ( -- x addr ) 16 bit CAN0_FW ; \ CAN0_FW_FW16, Filter working
: CAN0_FW_FW17 ( -- x addr ) 17 bit CAN0_FW ; \ CAN0_FW_FW17, Filter working
: CAN0_FW_FW18 ( -- x addr ) 18 bit CAN0_FW ; \ CAN0_FW_FW18, Filter working
: CAN0_FW_FW19 ( -- x addr ) 19 bit CAN0_FW ; \ CAN0_FW_FW19, Filter working
: CAN0_FW_FW20 ( -- x addr ) 20 bit CAN0_FW ; \ CAN0_FW_FW20, Filter working
: CAN0_FW_FW21 ( -- x addr ) 21 bit CAN0_FW ; \ CAN0_FW_FW21, Filter working
: CAN0_FW_FW22 ( -- x addr ) 22 bit CAN0_FW ; \ CAN0_FW_FW22, Filter working
: CAN0_FW_FW23 ( -- x addr ) 23 bit CAN0_FW ; \ CAN0_FW_FW23, Filter working
: CAN0_FW_FW24 ( -- x addr ) 24 bit CAN0_FW ; \ CAN0_FW_FW24, Filter working
: CAN0_FW_FW25 ( -- x addr ) 25 bit CAN0_FW ; \ CAN0_FW_FW25, Filter working
: CAN0_FW_FW26 ( -- x addr ) 26 bit CAN0_FW ; \ CAN0_FW_FW26, Filter working
: CAN0_FW_FW27 ( -- x addr ) 27 bit CAN0_FW ; \ CAN0_FW_FW27, Filter working

\ CAN0_F0DATA0 (read-write) Reset:0x00000000
: CAN0_F0DATA0_FD0 ( -- x addr ) 0 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD0, Filter bits
: CAN0_F0DATA0_FD1 ( -- x addr ) 1 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD1, Filter bits
: CAN0_F0DATA0_FD2 ( -- x addr ) 2 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD2, Filter bits
: CAN0_F0DATA0_FD3 ( -- x addr ) 3 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD3, Filter bits
: CAN0_F0DATA0_FD4 ( -- x addr ) 4 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD4, Filter bits
: CAN0_F0DATA0_FD5 ( -- x addr ) 5 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD5, Filter bits
: CAN0_F0DATA0_FD6 ( -- x addr ) 6 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD6, Filter bits
: CAN0_F0DATA0_FD7 ( -- x addr ) 7 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD7, Filter bits
: CAN0_F0DATA0_FD8 ( -- x addr ) 8 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD8, Filter bits
: CAN0_F0DATA0_FD9 ( -- x addr ) 9 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD9, Filter bits
: CAN0_F0DATA0_FD10 ( -- x addr ) 10 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD10, Filter bits
: CAN0_F0DATA0_FD11 ( -- x addr ) 11 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD11, Filter bits
: CAN0_F0DATA0_FD12 ( -- x addr ) 12 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD12, Filter bits
: CAN0_F0DATA0_FD13 ( -- x addr ) 13 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD13, Filter bits
: CAN0_F0DATA0_FD14 ( -- x addr ) 14 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD14, Filter bits
: CAN0_F0DATA0_FD15 ( -- x addr ) 15 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD15, Filter bits
: CAN0_F0DATA0_FD16 ( -- x addr ) 16 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD16, Filter bits
: CAN0_F0DATA0_FD17 ( -- x addr ) 17 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD17, Filter bits
: CAN0_F0DATA0_FD18 ( -- x addr ) 18 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD18, Filter bits
: CAN0_F0DATA0_FD19 ( -- x addr ) 19 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD19, Filter bits
: CAN0_F0DATA0_FD20 ( -- x addr ) 20 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD20, Filter bits
: CAN0_F0DATA0_FD21 ( -- x addr ) 21 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD21, Filter bits
: CAN0_F0DATA0_FD22 ( -- x addr ) 22 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD22, Filter bits
: CAN0_F0DATA0_FD23 ( -- x addr ) 23 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD23, Filter bits
: CAN0_F0DATA0_FD24 ( -- x addr ) 24 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD24, Filter bits
: CAN0_F0DATA0_FD25 ( -- x addr ) 25 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD25, Filter bits
: CAN0_F0DATA0_FD26 ( -- x addr ) 26 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD26, Filter bits
: CAN0_F0DATA0_FD27 ( -- x addr ) 27 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD27, Filter bits
: CAN0_F0DATA0_FD28 ( -- x addr ) 28 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD28, Filter bits
: CAN0_F0DATA0_FD29 ( -- x addr ) 29 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD29, Filter bits
: CAN0_F0DATA0_FD30 ( -- x addr ) 30 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD30, Filter bits
: CAN0_F0DATA0_FD31 ( -- x addr ) 31 bit CAN0_F0DATA0 ; \ CAN0_F0DATA0_FD31, Filter bits

\ CAN0_F0DATA1 (read-write) Reset:0x00000000
: CAN0_F0DATA1_FD0 ( -- x addr ) 0 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD0, Filter bits
: CAN0_F0DATA1_FD1 ( -- x addr ) 1 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD1, Filter bits
: CAN0_F0DATA1_FD2 ( -- x addr ) 2 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD2, Filter bits
: CAN0_F0DATA1_FD3 ( -- x addr ) 3 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD3, Filter bits
: CAN0_F0DATA1_FD4 ( -- x addr ) 4 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD4, Filter bits
: CAN0_F0DATA1_FD5 ( -- x addr ) 5 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD5, Filter bits
: CAN0_F0DATA1_FD6 ( -- x addr ) 6 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD6, Filter bits
: CAN0_F0DATA1_FD7 ( -- x addr ) 7 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD7, Filter bits
: CAN0_F0DATA1_FD8 ( -- x addr ) 8 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD8, Filter bits
: CAN0_F0DATA1_FD9 ( -- x addr ) 9 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD9, Filter bits
: CAN0_F0DATA1_FD10 ( -- x addr ) 10 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD10, Filter bits
: CAN0_F0DATA1_FD11 ( -- x addr ) 11 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD11, Filter bits
: CAN0_F0DATA1_FD12 ( -- x addr ) 12 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD12, Filter bits
: CAN0_F0DATA1_FD13 ( -- x addr ) 13 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD13, Filter bits
: CAN0_F0DATA1_FD14 ( -- x addr ) 14 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD14, Filter bits
: CAN0_F0DATA1_FD15 ( -- x addr ) 15 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD15, Filter bits
: CAN0_F0DATA1_FD16 ( -- x addr ) 16 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD16, Filter bits
: CAN0_F0DATA1_FD17 ( -- x addr ) 17 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD17, Filter bits
: CAN0_F0DATA1_FD18 ( -- x addr ) 18 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD18, Filter bits
: CAN0_F0DATA1_FD19 ( -- x addr ) 19 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD19, Filter bits
: CAN0_F0DATA1_FD20 ( -- x addr ) 20 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD20, Filter bits
: CAN0_F0DATA1_FD21 ( -- x addr ) 21 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD21, Filter bits
: CAN0_F0DATA1_FD22 ( -- x addr ) 22 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD22, Filter bits
: CAN0_F0DATA1_FD23 ( -- x addr ) 23 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD23, Filter bits
: CAN0_F0DATA1_FD24 ( -- x addr ) 24 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD24, Filter bits
: CAN0_F0DATA1_FD25 ( -- x addr ) 25 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD25, Filter bits
: CAN0_F0DATA1_FD26 ( -- x addr ) 26 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD26, Filter bits
: CAN0_F0DATA1_FD27 ( -- x addr ) 27 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD27, Filter bits
: CAN0_F0DATA1_FD28 ( -- x addr ) 28 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD28, Filter bits
: CAN0_F0DATA1_FD29 ( -- x addr ) 29 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD29, Filter bits
: CAN0_F0DATA1_FD30 ( -- x addr ) 30 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD30, Filter bits
: CAN0_F0DATA1_FD31 ( -- x addr ) 31 bit CAN0_F0DATA1 ; \ CAN0_F0DATA1_FD31, Filter bits

\ CAN0_F1DATA0 (read-write) Reset:0x00000000
: CAN0_F1DATA0_FD0 ( -- x addr ) 0 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD0, Filter bits
: CAN0_F1DATA0_FD1 ( -- x addr ) 1 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD1, Filter bits
: CAN0_F1DATA0_FD2 ( -- x addr ) 2 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD2, Filter bits
: CAN0_F1DATA0_FD3 ( -- x addr ) 3 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD3, Filter bits
: CAN0_F1DATA0_FD4 ( -- x addr ) 4 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD4, Filter bits
: CAN0_F1DATA0_FD5 ( -- x addr ) 5 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD5, Filter bits
: CAN0_F1DATA0_FD6 ( -- x addr ) 6 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD6, Filter bits
: CAN0_F1DATA0_FD7 ( -- x addr ) 7 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD7, Filter bits
: CAN0_F1DATA0_FD8 ( -- x addr ) 8 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD8, Filter bits
: CAN0_F1DATA0_FD9 ( -- x addr ) 9 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD9, Filter bits
: CAN0_F1DATA0_FD10 ( -- x addr ) 10 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD10, Filter bits
: CAN0_F1DATA0_FD11 ( -- x addr ) 11 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD11, Filter bits
: CAN0_F1DATA0_FD12 ( -- x addr ) 12 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD12, Filter bits
: CAN0_F1DATA0_FD13 ( -- x addr ) 13 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD13, Filter bits
: CAN0_F1DATA0_FD14 ( -- x addr ) 14 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD14, Filter bits
: CAN0_F1DATA0_FD15 ( -- x addr ) 15 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD15, Filter bits
: CAN0_F1DATA0_FD16 ( -- x addr ) 16 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD16, Filter bits
: CAN0_F1DATA0_FD17 ( -- x addr ) 17 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD17, Filter bits
: CAN0_F1DATA0_FD18 ( -- x addr ) 18 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD18, Filter bits
: CAN0_F1DATA0_FD19 ( -- x addr ) 19 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD19, Filter bits
: CAN0_F1DATA0_FD20 ( -- x addr ) 20 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD20, Filter bits
: CAN0_F1DATA0_FD21 ( -- x addr ) 21 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD21, Filter bits
: CAN0_F1DATA0_FD22 ( -- x addr ) 22 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD22, Filter bits
: CAN0_F1DATA0_FD23 ( -- x addr ) 23 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD23, Filter bits
: CAN0_F1DATA0_FD24 ( -- x addr ) 24 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD24, Filter bits
: CAN0_F1DATA0_FD25 ( -- x addr ) 25 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD25, Filter bits
: CAN0_F1DATA0_FD26 ( -- x addr ) 26 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD26, Filter bits
: CAN0_F1DATA0_FD27 ( -- x addr ) 27 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD27, Filter bits
: CAN0_F1DATA0_FD28 ( -- x addr ) 28 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD28, Filter bits
: CAN0_F1DATA0_FD29 ( -- x addr ) 29 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD29, Filter bits
: CAN0_F1DATA0_FD30 ( -- x addr ) 30 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD30, Filter bits
: CAN0_F1DATA0_FD31 ( -- x addr ) 31 bit CAN0_F1DATA0 ; \ CAN0_F1DATA0_FD31, Filter bits

\ CAN0_F1DATA1 (read-write) Reset:0x00000000
: CAN0_F1DATA1_FD0 ( -- x addr ) 0 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD0, Filter bits
: CAN0_F1DATA1_FD1 ( -- x addr ) 1 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD1, Filter bits
: CAN0_F1DATA1_FD2 ( -- x addr ) 2 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD2, Filter bits
: CAN0_F1DATA1_FD3 ( -- x addr ) 3 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD3, Filter bits
: CAN0_F1DATA1_FD4 ( -- x addr ) 4 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD4, Filter bits
: CAN0_F1DATA1_FD5 ( -- x addr ) 5 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD5, Filter bits
: CAN0_F1DATA1_FD6 ( -- x addr ) 6 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD6, Filter bits
: CAN0_F1DATA1_FD7 ( -- x addr ) 7 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD7, Filter bits
: CAN0_F1DATA1_FD8 ( -- x addr ) 8 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD8, Filter bits
: CAN0_F1DATA1_FD9 ( -- x addr ) 9 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD9, Filter bits
: CAN0_F1DATA1_FD10 ( -- x addr ) 10 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD10, Filter bits
: CAN0_F1DATA1_FD11 ( -- x addr ) 11 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD11, Filter bits
: CAN0_F1DATA1_FD12 ( -- x addr ) 12 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD12, Filter bits
: CAN0_F1DATA1_FD13 ( -- x addr ) 13 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD13, Filter bits
: CAN0_F1DATA1_FD14 ( -- x addr ) 14 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD14, Filter bits
: CAN0_F1DATA1_FD15 ( -- x addr ) 15 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD15, Filter bits
: CAN0_F1DATA1_FD16 ( -- x addr ) 16 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD16, Filter bits
: CAN0_F1DATA1_FD17 ( -- x addr ) 17 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD17, Filter bits
: CAN0_F1DATA1_FD18 ( -- x addr ) 18 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD18, Filter bits
: CAN0_F1DATA1_FD19 ( -- x addr ) 19 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD19, Filter bits
: CAN0_F1DATA1_FD20 ( -- x addr ) 20 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD20, Filter bits
: CAN0_F1DATA1_FD21 ( -- x addr ) 21 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD21, Filter bits
: CAN0_F1DATA1_FD22 ( -- x addr ) 22 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD22, Filter bits
: CAN0_F1DATA1_FD23 ( -- x addr ) 23 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD23, Filter bits
: CAN0_F1DATA1_FD24 ( -- x addr ) 24 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD24, Filter bits
: CAN0_F1DATA1_FD25 ( -- x addr ) 25 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD25, Filter bits
: CAN0_F1DATA1_FD26 ( -- x addr ) 26 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD26, Filter bits
: CAN0_F1DATA1_FD27 ( -- x addr ) 27 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD27, Filter bits
: CAN0_F1DATA1_FD28 ( -- x addr ) 28 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD28, Filter bits
: CAN0_F1DATA1_FD29 ( -- x addr ) 29 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD29, Filter bits
: CAN0_F1DATA1_FD30 ( -- x addr ) 30 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD30, Filter bits
: CAN0_F1DATA1_FD31 ( -- x addr ) 31 bit CAN0_F1DATA1 ; \ CAN0_F1DATA1_FD31, Filter bits

\ CAN0_F2DATA0 (read-write) Reset:0x00000000
: CAN0_F2DATA0_FD0 ( -- x addr ) 0 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD0, Filter bits
: CAN0_F2DATA0_FD1 ( -- x addr ) 1 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD1, Filter bits
: CAN0_F2DATA0_FD2 ( -- x addr ) 2 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD2, Filter bits
: CAN0_F2DATA0_FD3 ( -- x addr ) 3 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD3, Filter bits
: CAN0_F2DATA0_FD4 ( -- x addr ) 4 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD4, Filter bits
: CAN0_F2DATA0_FD5 ( -- x addr ) 5 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD5, Filter bits
: CAN0_F2DATA0_FD6 ( -- x addr ) 6 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD6, Filter bits
: CAN0_F2DATA0_FD7 ( -- x addr ) 7 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD7, Filter bits
: CAN0_F2DATA0_FD8 ( -- x addr ) 8 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD8, Filter bits
: CAN0_F2DATA0_FD9 ( -- x addr ) 9 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD9, Filter bits
: CAN0_F2DATA0_FD10 ( -- x addr ) 10 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD10, Filter bits
: CAN0_F2DATA0_FD11 ( -- x addr ) 11 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD11, Filter bits
: CAN0_F2DATA0_FD12 ( -- x addr ) 12 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD12, Filter bits
: CAN0_F2DATA0_FD13 ( -- x addr ) 13 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD13, Filter bits
: CAN0_F2DATA0_FD14 ( -- x addr ) 14 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD14, Filter bits
: CAN0_F2DATA0_FD15 ( -- x addr ) 15 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD15, Filter bits
: CAN0_F2DATA0_FD16 ( -- x addr ) 16 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD16, Filter bits
: CAN0_F2DATA0_FD17 ( -- x addr ) 17 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD17, Filter bits
: CAN0_F2DATA0_FD18 ( -- x addr ) 18 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD18, Filter bits
: CAN0_F2DATA0_FD19 ( -- x addr ) 19 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD19, Filter bits
: CAN0_F2DATA0_FD20 ( -- x addr ) 20 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD20, Filter bits
: CAN0_F2DATA0_FD21 ( -- x addr ) 21 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD21, Filter bits
: CAN0_F2DATA0_FD22 ( -- x addr ) 22 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD22, Filter bits
: CAN0_F2DATA0_FD23 ( -- x addr ) 23 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD23, Filter bits
: CAN0_F2DATA0_FD24 ( -- x addr ) 24 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD24, Filter bits
: CAN0_F2DATA0_FD25 ( -- x addr ) 25 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD25, Filter bits
: CAN0_F2DATA0_FD26 ( -- x addr ) 26 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD26, Filter bits
: CAN0_F2DATA0_FD27 ( -- x addr ) 27 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD27, Filter bits
: CAN0_F2DATA0_FD28 ( -- x addr ) 28 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD28, Filter bits
: CAN0_F2DATA0_FD29 ( -- x addr ) 29 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD29, Filter bits
: CAN0_F2DATA0_FD30 ( -- x addr ) 30 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD30, Filter bits
: CAN0_F2DATA0_FD31 ( -- x addr ) 31 bit CAN0_F2DATA0 ; \ CAN0_F2DATA0_FD31, Filter bits

\ CAN0_F2DATA1 (read-write) Reset:0x00000000
: CAN0_F2DATA1_FD0 ( -- x addr ) 0 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD0, Filter bits
: CAN0_F2DATA1_FD1 ( -- x addr ) 1 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD1, Filter bits
: CAN0_F2DATA1_FD2 ( -- x addr ) 2 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD2, Filter bits
: CAN0_F2DATA1_FD3 ( -- x addr ) 3 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD3, Filter bits
: CAN0_F2DATA1_FD4 ( -- x addr ) 4 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD4, Filter bits
: CAN0_F2DATA1_FD5 ( -- x addr ) 5 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD5, Filter bits
: CAN0_F2DATA1_FD6 ( -- x addr ) 6 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD6, Filter bits
: CAN0_F2DATA1_FD7 ( -- x addr ) 7 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD7, Filter bits
: CAN0_F2DATA1_FD8 ( -- x addr ) 8 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD8, Filter bits
: CAN0_F2DATA1_FD9 ( -- x addr ) 9 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD9, Filter bits
: CAN0_F2DATA1_FD10 ( -- x addr ) 10 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD10, Filter bits
: CAN0_F2DATA1_FD11 ( -- x addr ) 11 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD11, Filter bits
: CAN0_F2DATA1_FD12 ( -- x addr ) 12 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD12, Filter bits
: CAN0_F2DATA1_FD13 ( -- x addr ) 13 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD13, Filter bits
: CAN0_F2DATA1_FD14 ( -- x addr ) 14 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD14, Filter bits
: CAN0_F2DATA1_FD15 ( -- x addr ) 15 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD15, Filter bits
: CAN0_F2DATA1_FD16 ( -- x addr ) 16 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD16, Filter bits
: CAN0_F2DATA1_FD17 ( -- x addr ) 17 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD17, Filter bits
: CAN0_F2DATA1_FD18 ( -- x addr ) 18 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD18, Filter bits
: CAN0_F2DATA1_FD19 ( -- x addr ) 19 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD19, Filter bits
: CAN0_F2DATA1_FD20 ( -- x addr ) 20 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD20, Filter bits
: CAN0_F2DATA1_FD21 ( -- x addr ) 21 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD21, Filter bits
: CAN0_F2DATA1_FD22 ( -- x addr ) 22 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD22, Filter bits
: CAN0_F2DATA1_FD23 ( -- x addr ) 23 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD23, Filter bits
: CAN0_F2DATA1_FD24 ( -- x addr ) 24 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD24, Filter bits
: CAN0_F2DATA1_FD25 ( -- x addr ) 25 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD25, Filter bits
: CAN0_F2DATA1_FD26 ( -- x addr ) 26 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD26, Filter bits
: CAN0_F2DATA1_FD27 ( -- x addr ) 27 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD27, Filter bits
: CAN0_F2DATA1_FD28 ( -- x addr ) 28 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD28, Filter bits
: CAN0_F2DATA1_FD29 ( -- x addr ) 29 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD29, Filter bits
: CAN0_F2DATA1_FD30 ( -- x addr ) 30 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD30, Filter bits
: CAN0_F2DATA1_FD31 ( -- x addr ) 31 bit CAN0_F2DATA1 ; \ CAN0_F2DATA1_FD31, Filter bits

\ CAN0_F3DATA0 (read-write) Reset:0x00000000
: CAN0_F3DATA0_FD0 ( -- x addr ) 0 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD0, Filter bits
: CAN0_F3DATA0_FD1 ( -- x addr ) 1 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD1, Filter bits
: CAN0_F3DATA0_FD2 ( -- x addr ) 2 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD2, Filter bits
: CAN0_F3DATA0_FD3 ( -- x addr ) 3 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD3, Filter bits
: CAN0_F3DATA0_FD4 ( -- x addr ) 4 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD4, Filter bits
: CAN0_F3DATA0_FD5 ( -- x addr ) 5 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD5, Filter bits
: CAN0_F3DATA0_FD6 ( -- x addr ) 6 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD6, Filter bits
: CAN0_F3DATA0_FD7 ( -- x addr ) 7 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD7, Filter bits
: CAN0_F3DATA0_FD8 ( -- x addr ) 8 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD8, Filter bits
: CAN0_F3DATA0_FD9 ( -- x addr ) 9 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD9, Filter bits
: CAN0_F3DATA0_FD10 ( -- x addr ) 10 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD10, Filter bits
: CAN0_F3DATA0_FD11 ( -- x addr ) 11 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD11, Filter bits
: CAN0_F3DATA0_FD12 ( -- x addr ) 12 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD12, Filter bits
: CAN0_F3DATA0_FD13 ( -- x addr ) 13 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD13, Filter bits
: CAN0_F3DATA0_FD14 ( -- x addr ) 14 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD14, Filter bits
: CAN0_F3DATA0_FD15 ( -- x addr ) 15 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD15, Filter bits
: CAN0_F3DATA0_FD16 ( -- x addr ) 16 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD16, Filter bits
: CAN0_F3DATA0_FD17 ( -- x addr ) 17 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD17, Filter bits
: CAN0_F3DATA0_FD18 ( -- x addr ) 18 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD18, Filter bits
: CAN0_F3DATA0_FD19 ( -- x addr ) 19 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD19, Filter bits
: CAN0_F3DATA0_FD20 ( -- x addr ) 20 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD20, Filter bits
: CAN0_F3DATA0_FD21 ( -- x addr ) 21 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD21, Filter bits
: CAN0_F3DATA0_FD22 ( -- x addr ) 22 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD22, Filter bits
: CAN0_F3DATA0_FD23 ( -- x addr ) 23 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD23, Filter bits
: CAN0_F3DATA0_FD24 ( -- x addr ) 24 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD24, Filter bits
: CAN0_F3DATA0_FD25 ( -- x addr ) 25 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD25, Filter bits
: CAN0_F3DATA0_FD26 ( -- x addr ) 26 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD26, Filter bits
: CAN0_F3DATA0_FD27 ( -- x addr ) 27 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD27, Filter bits
: CAN0_F3DATA0_FD28 ( -- x addr ) 28 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD28, Filter bits
: CAN0_F3DATA0_FD29 ( -- x addr ) 29 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD29, Filter bits
: CAN0_F3DATA0_FD30 ( -- x addr ) 30 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD30, Filter bits
: CAN0_F3DATA0_FD31 ( -- x addr ) 31 bit CAN0_F3DATA0 ; \ CAN0_F3DATA0_FD31, Filter bits

\ CAN0_F3DATA1 (read-write) Reset:0x00000000
: CAN0_F3DATA1_FD0 ( -- x addr ) 0 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD0, Filter bits
: CAN0_F3DATA1_FD1 ( -- x addr ) 1 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD1, Filter bits
: CAN0_F3DATA1_FD2 ( -- x addr ) 2 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD2, Filter bits
: CAN0_F3DATA1_FD3 ( -- x addr ) 3 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD3, Filter bits
: CAN0_F3DATA1_FD4 ( -- x addr ) 4 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD4, Filter bits
: CAN0_F3DATA1_FD5 ( -- x addr ) 5 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD5, Filter bits
: CAN0_F3DATA1_FD6 ( -- x addr ) 6 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD6, Filter bits
: CAN0_F3DATA1_FD7 ( -- x addr ) 7 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD7, Filter bits
: CAN0_F3DATA1_FD8 ( -- x addr ) 8 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD8, Filter bits
: CAN0_F3DATA1_FD9 ( -- x addr ) 9 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD9, Filter bits
: CAN0_F3DATA1_FD10 ( -- x addr ) 10 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD10, Filter bits
: CAN0_F3DATA1_FD11 ( -- x addr ) 11 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD11, Filter bits
: CAN0_F3DATA1_FD12 ( -- x addr ) 12 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD12, Filter bits
: CAN0_F3DATA1_FD13 ( -- x addr ) 13 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD13, Filter bits
: CAN0_F3DATA1_FD14 ( -- x addr ) 14 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD14, Filter bits
: CAN0_F3DATA1_FD15 ( -- x addr ) 15 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD15, Filter bits
: CAN0_F3DATA1_FD16 ( -- x addr ) 16 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD16, Filter bits
: CAN0_F3DATA1_FD17 ( -- x addr ) 17 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD17, Filter bits
: CAN0_F3DATA1_FD18 ( -- x addr ) 18 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD18, Filter bits
: CAN0_F3DATA1_FD19 ( -- x addr ) 19 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD19, Filter bits
: CAN0_F3DATA1_FD20 ( -- x addr ) 20 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD20, Filter bits
: CAN0_F3DATA1_FD21 ( -- x addr ) 21 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD21, Filter bits
: CAN0_F3DATA1_FD22 ( -- x addr ) 22 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD22, Filter bits
: CAN0_F3DATA1_FD23 ( -- x addr ) 23 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD23, Filter bits
: CAN0_F3DATA1_FD24 ( -- x addr ) 24 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD24, Filter bits
: CAN0_F3DATA1_FD25 ( -- x addr ) 25 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD25, Filter bits
: CAN0_F3DATA1_FD26 ( -- x addr ) 26 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD26, Filter bits
: CAN0_F3DATA1_FD27 ( -- x addr ) 27 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD27, Filter bits
: CAN0_F3DATA1_FD28 ( -- x addr ) 28 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD28, Filter bits
: CAN0_F3DATA1_FD29 ( -- x addr ) 29 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD29, Filter bits
: CAN0_F3DATA1_FD30 ( -- x addr ) 30 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD30, Filter bits
: CAN0_F3DATA1_FD31 ( -- x addr ) 31 bit CAN0_F3DATA1 ; \ CAN0_F3DATA1_FD31, Filter bits

\ CAN0_F4DATA0 (read-write) Reset:0x00000000
: CAN0_F4DATA0_FD0 ( -- x addr ) 0 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD0, Filter bits
: CAN0_F4DATA0_FD1 ( -- x addr ) 1 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD1, Filter bits
: CAN0_F4DATA0_FD2 ( -- x addr ) 2 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD2, Filter bits
: CAN0_F4DATA0_FD3 ( -- x addr ) 3 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD3, Filter bits
: CAN0_F4DATA0_FD4 ( -- x addr ) 4 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD4, Filter bits
: CAN0_F4DATA0_FD5 ( -- x addr ) 5 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD5, Filter bits
: CAN0_F4DATA0_FD6 ( -- x addr ) 6 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD6, Filter bits
: CAN0_F4DATA0_FD7 ( -- x addr ) 7 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD7, Filter bits
: CAN0_F4DATA0_FD8 ( -- x addr ) 8 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD8, Filter bits
: CAN0_F4DATA0_FD9 ( -- x addr ) 9 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD9, Filter bits
: CAN0_F4DATA0_FD10 ( -- x addr ) 10 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD10, Filter bits
: CAN0_F4DATA0_FD11 ( -- x addr ) 11 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD11, Filter bits
: CAN0_F4DATA0_FD12 ( -- x addr ) 12 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD12, Filter bits
: CAN0_F4DATA0_FD13 ( -- x addr ) 13 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD13, Filter bits
: CAN0_F4DATA0_FD14 ( -- x addr ) 14 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD14, Filter bits
: CAN0_F4DATA0_FD15 ( -- x addr ) 15 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD15, Filter bits
: CAN0_F4DATA0_FD16 ( -- x addr ) 16 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD16, Filter bits
: CAN0_F4DATA0_FD17 ( -- x addr ) 17 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD17, Filter bits
: CAN0_F4DATA0_FD18 ( -- x addr ) 18 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD18, Filter bits
: CAN0_F4DATA0_FD19 ( -- x addr ) 19 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD19, Filter bits
: CAN0_F4DATA0_FD20 ( -- x addr ) 20 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD20, Filter bits
: CAN0_F4DATA0_FD21 ( -- x addr ) 21 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD21, Filter bits
: CAN0_F4DATA0_FD22 ( -- x addr ) 22 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD22, Filter bits
: CAN0_F4DATA0_FD23 ( -- x addr ) 23 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD23, Filter bits
: CAN0_F4DATA0_FD24 ( -- x addr ) 24 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD24, Filter bits
: CAN0_F4DATA0_FD25 ( -- x addr ) 25 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD25, Filter bits
: CAN0_F4DATA0_FD26 ( -- x addr ) 26 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD26, Filter bits
: CAN0_F4DATA0_FD27 ( -- x addr ) 27 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD27, Filter bits
: CAN0_F4DATA0_FD28 ( -- x addr ) 28 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD28, Filter bits
: CAN0_F4DATA0_FD29 ( -- x addr ) 29 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD29, Filter bits
: CAN0_F4DATA0_FD30 ( -- x addr ) 30 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD30, Filter bits
: CAN0_F4DATA0_FD31 ( -- x addr ) 31 bit CAN0_F4DATA0 ; \ CAN0_F4DATA0_FD31, Filter bits

\ CAN0_F4DATA1 (read-write) Reset:0x00000000
: CAN0_F4DATA1_FD0 ( -- x addr ) 0 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD0, Filter bits
: CAN0_F4DATA1_FD1 ( -- x addr ) 1 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD1, Filter bits
: CAN0_F4DATA1_FD2 ( -- x addr ) 2 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD2, Filter bits
: CAN0_F4DATA1_FD3 ( -- x addr ) 3 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD3, Filter bits
: CAN0_F4DATA1_FD4 ( -- x addr ) 4 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD4, Filter bits
: CAN0_F4DATA1_FD5 ( -- x addr ) 5 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD5, Filter bits
: CAN0_F4DATA1_FD6 ( -- x addr ) 6 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD6, Filter bits
: CAN0_F4DATA1_FD7 ( -- x addr ) 7 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD7, Filter bits
: CAN0_F4DATA1_FD8 ( -- x addr ) 8 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD8, Filter bits
: CAN0_F4DATA1_FD9 ( -- x addr ) 9 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD9, Filter bits
: CAN0_F4DATA1_FD10 ( -- x addr ) 10 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD10, Filter bits
: CAN0_F4DATA1_FD11 ( -- x addr ) 11 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD11, Filter bits
: CAN0_F4DATA1_FD12 ( -- x addr ) 12 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD12, Filter bits
: CAN0_F4DATA1_FD13 ( -- x addr ) 13 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD13, Filter bits
: CAN0_F4DATA1_FD14 ( -- x addr ) 14 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD14, Filter bits
: CAN0_F4DATA1_FD15 ( -- x addr ) 15 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD15, Filter bits
: CAN0_F4DATA1_FD16 ( -- x addr ) 16 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD16, Filter bits
: CAN0_F4DATA1_FD17 ( -- x addr ) 17 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD17, Filter bits
: CAN0_F4DATA1_FD18 ( -- x addr ) 18 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD18, Filter bits
: CAN0_F4DATA1_FD19 ( -- x addr ) 19 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD19, Filter bits
: CAN0_F4DATA1_FD20 ( -- x addr ) 20 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD20, Filter bits
: CAN0_F4DATA1_FD21 ( -- x addr ) 21 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD21, Filter bits
: CAN0_F4DATA1_FD22 ( -- x addr ) 22 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD22, Filter bits
: CAN0_F4DATA1_FD23 ( -- x addr ) 23 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD23, Filter bits
: CAN0_F4DATA1_FD24 ( -- x addr ) 24 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD24, Filter bits
: CAN0_F4DATA1_FD25 ( -- x addr ) 25 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD25, Filter bits
: CAN0_F4DATA1_FD26 ( -- x addr ) 26 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD26, Filter bits
: CAN0_F4DATA1_FD27 ( -- x addr ) 27 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD27, Filter bits
: CAN0_F4DATA1_FD28 ( -- x addr ) 28 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD28, Filter bits
: CAN0_F4DATA1_FD29 ( -- x addr ) 29 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD29, Filter bits
: CAN0_F4DATA1_FD30 ( -- x addr ) 30 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD30, Filter bits
: CAN0_F4DATA1_FD31 ( -- x addr ) 31 bit CAN0_F4DATA1 ; \ CAN0_F4DATA1_FD31, Filter bits

\ CAN0_F5DATA0 (read-write) Reset:0x00000000
: CAN0_F5DATA0_FD0 ( -- x addr ) 0 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD0, Filter bits
: CAN0_F5DATA0_FD1 ( -- x addr ) 1 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD1, Filter bits
: CAN0_F5DATA0_FD2 ( -- x addr ) 2 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD2, Filter bits
: CAN0_F5DATA0_FD3 ( -- x addr ) 3 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD3, Filter bits
: CAN0_F5DATA0_FD4 ( -- x addr ) 4 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD4, Filter bits
: CAN0_F5DATA0_FD5 ( -- x addr ) 5 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD5, Filter bits
: CAN0_F5DATA0_FD6 ( -- x addr ) 6 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD6, Filter bits
: CAN0_F5DATA0_FD7 ( -- x addr ) 7 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD7, Filter bits
: CAN0_F5DATA0_FD8 ( -- x addr ) 8 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD8, Filter bits
: CAN0_F5DATA0_FD9 ( -- x addr ) 9 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD9, Filter bits
: CAN0_F5DATA0_FD10 ( -- x addr ) 10 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD10, Filter bits
: CAN0_F5DATA0_FD11 ( -- x addr ) 11 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD11, Filter bits
: CAN0_F5DATA0_FD12 ( -- x addr ) 12 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD12, Filter bits
: CAN0_F5DATA0_FD13 ( -- x addr ) 13 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD13, Filter bits
: CAN0_F5DATA0_FD14 ( -- x addr ) 14 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD14, Filter bits
: CAN0_F5DATA0_FD15 ( -- x addr ) 15 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD15, Filter bits
: CAN0_F5DATA0_FD16 ( -- x addr ) 16 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD16, Filter bits
: CAN0_F5DATA0_FD17 ( -- x addr ) 17 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD17, Filter bits
: CAN0_F5DATA0_FD18 ( -- x addr ) 18 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD18, Filter bits
: CAN0_F5DATA0_FD19 ( -- x addr ) 19 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD19, Filter bits
: CAN0_F5DATA0_FD20 ( -- x addr ) 20 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD20, Filter bits
: CAN0_F5DATA0_FD21 ( -- x addr ) 21 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD21, Filter bits
: CAN0_F5DATA0_FD22 ( -- x addr ) 22 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD22, Filter bits
: CAN0_F5DATA0_FD23 ( -- x addr ) 23 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD23, Filter bits
: CAN0_F5DATA0_FD24 ( -- x addr ) 24 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD24, Filter bits
: CAN0_F5DATA0_FD25 ( -- x addr ) 25 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD25, Filter bits
: CAN0_F5DATA0_FD26 ( -- x addr ) 26 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD26, Filter bits
: CAN0_F5DATA0_FD27 ( -- x addr ) 27 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD27, Filter bits
: CAN0_F5DATA0_FD28 ( -- x addr ) 28 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD28, Filter bits
: CAN0_F5DATA0_FD29 ( -- x addr ) 29 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD29, Filter bits
: CAN0_F5DATA0_FD30 ( -- x addr ) 30 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD30, Filter bits
: CAN0_F5DATA0_FD31 ( -- x addr ) 31 bit CAN0_F5DATA0 ; \ CAN0_F5DATA0_FD31, Filter bits

\ CAN0_F5DATA1 (read-write) Reset:0x00000000
: CAN0_F5DATA1_FD0 ( -- x addr ) 0 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD0, Filter bits
: CAN0_F5DATA1_FD1 ( -- x addr ) 1 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD1, Filter bits
: CAN0_F5DATA1_FD2 ( -- x addr ) 2 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD2, Filter bits
: CAN0_F5DATA1_FD3 ( -- x addr ) 3 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD3, Filter bits
: CAN0_F5DATA1_FD4 ( -- x addr ) 4 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD4, Filter bits
: CAN0_F5DATA1_FD5 ( -- x addr ) 5 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD5, Filter bits
: CAN0_F5DATA1_FD6 ( -- x addr ) 6 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD6, Filter bits
: CAN0_F5DATA1_FD7 ( -- x addr ) 7 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD7, Filter bits
: CAN0_F5DATA1_FD8 ( -- x addr ) 8 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD8, Filter bits
: CAN0_F5DATA1_FD9 ( -- x addr ) 9 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD9, Filter bits
: CAN0_F5DATA1_FD10 ( -- x addr ) 10 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD10, Filter bits
: CAN0_F5DATA1_FD11 ( -- x addr ) 11 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD11, Filter bits
: CAN0_F5DATA1_FD12 ( -- x addr ) 12 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD12, Filter bits
: CAN0_F5DATA1_FD13 ( -- x addr ) 13 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD13, Filter bits
: CAN0_F5DATA1_FD14 ( -- x addr ) 14 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD14, Filter bits
: CAN0_F5DATA1_FD15 ( -- x addr ) 15 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD15, Filter bits
: CAN0_F5DATA1_FD16 ( -- x addr ) 16 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD16, Filter bits
: CAN0_F5DATA1_FD17 ( -- x addr ) 17 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD17, Filter bits
: CAN0_F5DATA1_FD18 ( -- x addr ) 18 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD18, Filter bits
: CAN0_F5DATA1_FD19 ( -- x addr ) 19 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD19, Filter bits
: CAN0_F5DATA1_FD20 ( -- x addr ) 20 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD20, Filter bits
: CAN0_F5DATA1_FD21 ( -- x addr ) 21 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD21, Filter bits
: CAN0_F5DATA1_FD22 ( -- x addr ) 22 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD22, Filter bits
: CAN0_F5DATA1_FD23 ( -- x addr ) 23 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD23, Filter bits
: CAN0_F5DATA1_FD24 ( -- x addr ) 24 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD24, Filter bits
: CAN0_F5DATA1_FD25 ( -- x addr ) 25 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD25, Filter bits
: CAN0_F5DATA1_FD26 ( -- x addr ) 26 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD26, Filter bits
: CAN0_F5DATA1_FD27 ( -- x addr ) 27 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD27, Filter bits
: CAN0_F5DATA1_FD28 ( -- x addr ) 28 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD28, Filter bits
: CAN0_F5DATA1_FD29 ( -- x addr ) 29 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD29, Filter bits
: CAN0_F5DATA1_FD30 ( -- x addr ) 30 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD30, Filter bits
: CAN0_F5DATA1_FD31 ( -- x addr ) 31 bit CAN0_F5DATA1 ; \ CAN0_F5DATA1_FD31, Filter bits

\ CAN0_F6DATA0 (read-write) Reset:0x00000000
: CAN0_F6DATA0_FD0 ( -- x addr ) 0 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD0, Filter bits
: CAN0_F6DATA0_FD1 ( -- x addr ) 1 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD1, Filter bits
: CAN0_F6DATA0_FD2 ( -- x addr ) 2 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD2, Filter bits
: CAN0_F6DATA0_FD3 ( -- x addr ) 3 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD3, Filter bits
: CAN0_F6DATA0_FD4 ( -- x addr ) 4 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD4, Filter bits
: CAN0_F6DATA0_FD5 ( -- x addr ) 5 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD5, Filter bits
: CAN0_F6DATA0_FD6 ( -- x addr ) 6 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD6, Filter bits
: CAN0_F6DATA0_FD7 ( -- x addr ) 7 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD7, Filter bits
: CAN0_F6DATA0_FD8 ( -- x addr ) 8 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD8, Filter bits
: CAN0_F6DATA0_FD9 ( -- x addr ) 9 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD9, Filter bits
: CAN0_F6DATA0_FD10 ( -- x addr ) 10 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD10, Filter bits
: CAN0_F6DATA0_FD11 ( -- x addr ) 11 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD11, Filter bits
: CAN0_F6DATA0_FD12 ( -- x addr ) 12 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD12, Filter bits
: CAN0_F6DATA0_FD13 ( -- x addr ) 13 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD13, Filter bits
: CAN0_F6DATA0_FD14 ( -- x addr ) 14 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD14, Filter bits
: CAN0_F6DATA0_FD15 ( -- x addr ) 15 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD15, Filter bits
: CAN0_F6DATA0_FD16 ( -- x addr ) 16 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD16, Filter bits
: CAN0_F6DATA0_FD17 ( -- x addr ) 17 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD17, Filter bits
: CAN0_F6DATA0_FD18 ( -- x addr ) 18 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD18, Filter bits
: CAN0_F6DATA0_FD19 ( -- x addr ) 19 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD19, Filter bits
: CAN0_F6DATA0_FD20 ( -- x addr ) 20 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD20, Filter bits
: CAN0_F6DATA0_FD21 ( -- x addr ) 21 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD21, Filter bits
: CAN0_F6DATA0_FD22 ( -- x addr ) 22 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD22, Filter bits
: CAN0_F6DATA0_FD23 ( -- x addr ) 23 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD23, Filter bits
: CAN0_F6DATA0_FD24 ( -- x addr ) 24 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD24, Filter bits
: CAN0_F6DATA0_FD25 ( -- x addr ) 25 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD25, Filter bits
: CAN0_F6DATA0_FD26 ( -- x addr ) 26 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD26, Filter bits
: CAN0_F6DATA0_FD27 ( -- x addr ) 27 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD27, Filter bits
: CAN0_F6DATA0_FD28 ( -- x addr ) 28 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD28, Filter bits
: CAN0_F6DATA0_FD29 ( -- x addr ) 29 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD29, Filter bits
: CAN0_F6DATA0_FD30 ( -- x addr ) 30 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD30, Filter bits
: CAN0_F6DATA0_FD31 ( -- x addr ) 31 bit CAN0_F6DATA0 ; \ CAN0_F6DATA0_FD31, Filter bits

\ CAN0_F6DATA1 (read-write) Reset:0x00000000
: CAN0_F6DATA1_FD0 ( -- x addr ) 0 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD0, Filter bits
: CAN0_F6DATA1_FD1 ( -- x addr ) 1 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD1, Filter bits
: CAN0_F6DATA1_FD2 ( -- x addr ) 2 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD2, Filter bits
: CAN0_F6DATA1_FD3 ( -- x addr ) 3 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD3, Filter bits
: CAN0_F6DATA1_FD4 ( -- x addr ) 4 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD4, Filter bits
: CAN0_F6DATA1_FD5 ( -- x addr ) 5 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD5, Filter bits
: CAN0_F6DATA1_FD6 ( -- x addr ) 6 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD6, Filter bits
: CAN0_F6DATA1_FD7 ( -- x addr ) 7 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD7, Filter bits
: CAN0_F6DATA1_FD8 ( -- x addr ) 8 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD8, Filter bits
: CAN0_F6DATA1_FD9 ( -- x addr ) 9 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD9, Filter bits
: CAN0_F6DATA1_FD10 ( -- x addr ) 10 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD10, Filter bits
: CAN0_F6DATA1_FD11 ( -- x addr ) 11 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD11, Filter bits
: CAN0_F6DATA1_FD12 ( -- x addr ) 12 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD12, Filter bits
: CAN0_F6DATA1_FD13 ( -- x addr ) 13 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD13, Filter bits
: CAN0_F6DATA1_FD14 ( -- x addr ) 14 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD14, Filter bits
: CAN0_F6DATA1_FD15 ( -- x addr ) 15 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD15, Filter bits
: CAN0_F6DATA1_FD16 ( -- x addr ) 16 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD16, Filter bits
: CAN0_F6DATA1_FD17 ( -- x addr ) 17 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD17, Filter bits
: CAN0_F6DATA1_FD18 ( -- x addr ) 18 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD18, Filter bits
: CAN0_F6DATA1_FD19 ( -- x addr ) 19 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD19, Filter bits
: CAN0_F6DATA1_FD20 ( -- x addr ) 20 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD20, Filter bits
: CAN0_F6DATA1_FD21 ( -- x addr ) 21 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD21, Filter bits
: CAN0_F6DATA1_FD22 ( -- x addr ) 22 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD22, Filter bits
: CAN0_F6DATA1_FD23 ( -- x addr ) 23 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD23, Filter bits
: CAN0_F6DATA1_FD24 ( -- x addr ) 24 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD24, Filter bits
: CAN0_F6DATA1_FD25 ( -- x addr ) 25 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD25, Filter bits
: CAN0_F6DATA1_FD26 ( -- x addr ) 26 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD26, Filter bits
: CAN0_F6DATA1_FD27 ( -- x addr ) 27 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD27, Filter bits
: CAN0_F6DATA1_FD28 ( -- x addr ) 28 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD28, Filter bits
: CAN0_F6DATA1_FD29 ( -- x addr ) 29 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD29, Filter bits
: CAN0_F6DATA1_FD30 ( -- x addr ) 30 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD30, Filter bits
: CAN0_F6DATA1_FD31 ( -- x addr ) 31 bit CAN0_F6DATA1 ; \ CAN0_F6DATA1_FD31, Filter bits

\ CAN0_F7DATA0 (read-write) Reset:0x00000000
: CAN0_F7DATA0_FD0 ( -- x addr ) 0 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD0, Filter bits
: CAN0_F7DATA0_FD1 ( -- x addr ) 1 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD1, Filter bits
: CAN0_F7DATA0_FD2 ( -- x addr ) 2 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD2, Filter bits
: CAN0_F7DATA0_FD3 ( -- x addr ) 3 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD3, Filter bits
: CAN0_F7DATA0_FD4 ( -- x addr ) 4 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD4, Filter bits
: CAN0_F7DATA0_FD5 ( -- x addr ) 5 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD5, Filter bits
: CAN0_F7DATA0_FD6 ( -- x addr ) 6 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD6, Filter bits
: CAN0_F7DATA0_FD7 ( -- x addr ) 7 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD7, Filter bits
: CAN0_F7DATA0_FD8 ( -- x addr ) 8 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD8, Filter bits
: CAN0_F7DATA0_FD9 ( -- x addr ) 9 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD9, Filter bits
: CAN0_F7DATA0_FD10 ( -- x addr ) 10 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD10, Filter bits
: CAN0_F7DATA0_FD11 ( -- x addr ) 11 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD11, Filter bits
: CAN0_F7DATA0_FD12 ( -- x addr ) 12 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD12, Filter bits
: CAN0_F7DATA0_FD13 ( -- x addr ) 13 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD13, Filter bits
: CAN0_F7DATA0_FD14 ( -- x addr ) 14 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD14, Filter bits
: CAN0_F7DATA0_FD15 ( -- x addr ) 15 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD15, Filter bits
: CAN0_F7DATA0_FD16 ( -- x addr ) 16 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD16, Filter bits
: CAN0_F7DATA0_FD17 ( -- x addr ) 17 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD17, Filter bits
: CAN0_F7DATA0_FD18 ( -- x addr ) 18 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD18, Filter bits
: CAN0_F7DATA0_FD19 ( -- x addr ) 19 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD19, Filter bits
: CAN0_F7DATA0_FD20 ( -- x addr ) 20 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD20, Filter bits
: CAN0_F7DATA0_FD21 ( -- x addr ) 21 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD21, Filter bits
: CAN0_F7DATA0_FD22 ( -- x addr ) 22 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD22, Filter bits
: CAN0_F7DATA0_FD23 ( -- x addr ) 23 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD23, Filter bits
: CAN0_F7DATA0_FD24 ( -- x addr ) 24 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD24, Filter bits
: CAN0_F7DATA0_FD25 ( -- x addr ) 25 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD25, Filter bits
: CAN0_F7DATA0_FD26 ( -- x addr ) 26 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD26, Filter bits
: CAN0_F7DATA0_FD27 ( -- x addr ) 27 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD27, Filter bits
: CAN0_F7DATA0_FD28 ( -- x addr ) 28 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD28, Filter bits
: CAN0_F7DATA0_FD29 ( -- x addr ) 29 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD29, Filter bits
: CAN0_F7DATA0_FD30 ( -- x addr ) 30 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD30, Filter bits
: CAN0_F7DATA0_FD31 ( -- x addr ) 31 bit CAN0_F7DATA0 ; \ CAN0_F7DATA0_FD31, Filter bits

\ CAN0_F7DATA1 (read-write) Reset:0x00000000
: CAN0_F7DATA1_FD0 ( -- x addr ) 0 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD0, Filter bits
: CAN0_F7DATA1_FD1 ( -- x addr ) 1 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD1, Filter bits
: CAN0_F7DATA1_FD2 ( -- x addr ) 2 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD2, Filter bits
: CAN0_F7DATA1_FD3 ( -- x addr ) 3 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD3, Filter bits
: CAN0_F7DATA1_FD4 ( -- x addr ) 4 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD4, Filter bits
: CAN0_F7DATA1_FD5 ( -- x addr ) 5 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD5, Filter bits
: CAN0_F7DATA1_FD6 ( -- x addr ) 6 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD6, Filter bits
: CAN0_F7DATA1_FD7 ( -- x addr ) 7 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD7, Filter bits
: CAN0_F7DATA1_FD8 ( -- x addr ) 8 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD8, Filter bits
: CAN0_F7DATA1_FD9 ( -- x addr ) 9 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD9, Filter bits
: CAN0_F7DATA1_FD10 ( -- x addr ) 10 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD10, Filter bits
: CAN0_F7DATA1_FD11 ( -- x addr ) 11 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD11, Filter bits
: CAN0_F7DATA1_FD12 ( -- x addr ) 12 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD12, Filter bits
: CAN0_F7DATA1_FD13 ( -- x addr ) 13 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD13, Filter bits
: CAN0_F7DATA1_FD14 ( -- x addr ) 14 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD14, Filter bits
: CAN0_F7DATA1_FD15 ( -- x addr ) 15 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD15, Filter bits
: CAN0_F7DATA1_FD16 ( -- x addr ) 16 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD16, Filter bits
: CAN0_F7DATA1_FD17 ( -- x addr ) 17 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD17, Filter bits
: CAN0_F7DATA1_FD18 ( -- x addr ) 18 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD18, Filter bits
: CAN0_F7DATA1_FD19 ( -- x addr ) 19 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD19, Filter bits
: CAN0_F7DATA1_FD20 ( -- x addr ) 20 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD20, Filter bits
: CAN0_F7DATA1_FD21 ( -- x addr ) 21 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD21, Filter bits
: CAN0_F7DATA1_FD22 ( -- x addr ) 22 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD22, Filter bits
: CAN0_F7DATA1_FD23 ( -- x addr ) 23 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD23, Filter bits
: CAN0_F7DATA1_FD24 ( -- x addr ) 24 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD24, Filter bits
: CAN0_F7DATA1_FD25 ( -- x addr ) 25 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD25, Filter bits
: CAN0_F7DATA1_FD26 ( -- x addr ) 26 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD26, Filter bits
: CAN0_F7DATA1_FD27 ( -- x addr ) 27 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD27, Filter bits
: CAN0_F7DATA1_FD28 ( -- x addr ) 28 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD28, Filter bits
: CAN0_F7DATA1_FD29 ( -- x addr ) 29 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD29, Filter bits
: CAN0_F7DATA1_FD30 ( -- x addr ) 30 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD30, Filter bits
: CAN0_F7DATA1_FD31 ( -- x addr ) 31 bit CAN0_F7DATA1 ; \ CAN0_F7DATA1_FD31, Filter bits

\ CAN0_F8DATA0 (read-write) Reset:0x00000000
: CAN0_F8DATA0_FD0 ( -- x addr ) 0 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD0, Filter bits
: CAN0_F8DATA0_FD1 ( -- x addr ) 1 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD1, Filter bits
: CAN0_F8DATA0_FD2 ( -- x addr ) 2 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD2, Filter bits
: CAN0_F8DATA0_FD3 ( -- x addr ) 3 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD3, Filter bits
: CAN0_F8DATA0_FD4 ( -- x addr ) 4 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD4, Filter bits
: CAN0_F8DATA0_FD5 ( -- x addr ) 5 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD5, Filter bits
: CAN0_F8DATA0_FD6 ( -- x addr ) 6 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD6, Filter bits
: CAN0_F8DATA0_FD7 ( -- x addr ) 7 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD7, Filter bits
: CAN0_F8DATA0_FD8 ( -- x addr ) 8 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD8, Filter bits
: CAN0_F8DATA0_FD9 ( -- x addr ) 9 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD9, Filter bits
: CAN0_F8DATA0_FD10 ( -- x addr ) 10 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD10, Filter bits
: CAN0_F8DATA0_FD11 ( -- x addr ) 11 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD11, Filter bits
: CAN0_F8DATA0_FD12 ( -- x addr ) 12 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD12, Filter bits
: CAN0_F8DATA0_FD13 ( -- x addr ) 13 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD13, Filter bits
: CAN0_F8DATA0_FD14 ( -- x addr ) 14 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD14, Filter bits
: CAN0_F8DATA0_FD15 ( -- x addr ) 15 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD15, Filter bits
: CAN0_F8DATA0_FD16 ( -- x addr ) 16 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD16, Filter bits
: CAN0_F8DATA0_FD17 ( -- x addr ) 17 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD17, Filter bits
: CAN0_F8DATA0_FD18 ( -- x addr ) 18 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD18, Filter bits
: CAN0_F8DATA0_FD19 ( -- x addr ) 19 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD19, Filter bits
: CAN0_F8DATA0_FD20 ( -- x addr ) 20 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD20, Filter bits
: CAN0_F8DATA0_FD21 ( -- x addr ) 21 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD21, Filter bits
: CAN0_F8DATA0_FD22 ( -- x addr ) 22 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD22, Filter bits
: CAN0_F8DATA0_FD23 ( -- x addr ) 23 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD23, Filter bits
: CAN0_F8DATA0_FD24 ( -- x addr ) 24 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD24, Filter bits
: CAN0_F8DATA0_FD25 ( -- x addr ) 25 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD25, Filter bits
: CAN0_F8DATA0_FD26 ( -- x addr ) 26 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD26, Filter bits
: CAN0_F8DATA0_FD27 ( -- x addr ) 27 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD27, Filter bits
: CAN0_F8DATA0_FD28 ( -- x addr ) 28 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD28, Filter bits
: CAN0_F8DATA0_FD29 ( -- x addr ) 29 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD29, Filter bits
: CAN0_F8DATA0_FD30 ( -- x addr ) 30 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD30, Filter bits
: CAN0_F8DATA0_FD31 ( -- x addr ) 31 bit CAN0_F8DATA0 ; \ CAN0_F8DATA0_FD31, Filter bits

\ CAN0_F8DATA1 (read-write) Reset:0x00000000
: CAN0_F8DATA1_FD0 ( -- x addr ) 0 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD0, Filter bits
: CAN0_F8DATA1_FD1 ( -- x addr ) 1 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD1, Filter bits
: CAN0_F8DATA1_FD2 ( -- x addr ) 2 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD2, Filter bits
: CAN0_F8DATA1_FD3 ( -- x addr ) 3 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD3, Filter bits
: CAN0_F8DATA1_FD4 ( -- x addr ) 4 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD4, Filter bits
: CAN0_F8DATA1_FD5 ( -- x addr ) 5 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD5, Filter bits
: CAN0_F8DATA1_FD6 ( -- x addr ) 6 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD6, Filter bits
: CAN0_F8DATA1_FD7 ( -- x addr ) 7 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD7, Filter bits
: CAN0_F8DATA1_FD8 ( -- x addr ) 8 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD8, Filter bits
: CAN0_F8DATA1_FD9 ( -- x addr ) 9 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD9, Filter bits
: CAN0_F8DATA1_FD10 ( -- x addr ) 10 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD10, Filter bits
: CAN0_F8DATA1_FD11 ( -- x addr ) 11 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD11, Filter bits
: CAN0_F8DATA1_FD12 ( -- x addr ) 12 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD12, Filter bits
: CAN0_F8DATA1_FD13 ( -- x addr ) 13 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD13, Filter bits
: CAN0_F8DATA1_FD14 ( -- x addr ) 14 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD14, Filter bits
: CAN0_F8DATA1_FD15 ( -- x addr ) 15 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD15, Filter bits
: CAN0_F8DATA1_FD16 ( -- x addr ) 16 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD16, Filter bits
: CAN0_F8DATA1_FD17 ( -- x addr ) 17 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD17, Filter bits
: CAN0_F8DATA1_FD18 ( -- x addr ) 18 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD18, Filter bits
: CAN0_F8DATA1_FD19 ( -- x addr ) 19 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD19, Filter bits
: CAN0_F8DATA1_FD20 ( -- x addr ) 20 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD20, Filter bits
: CAN0_F8DATA1_FD21 ( -- x addr ) 21 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD21, Filter bits
: CAN0_F8DATA1_FD22 ( -- x addr ) 22 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD22, Filter bits
: CAN0_F8DATA1_FD23 ( -- x addr ) 23 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD23, Filter bits
: CAN0_F8DATA1_FD24 ( -- x addr ) 24 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD24, Filter bits
: CAN0_F8DATA1_FD25 ( -- x addr ) 25 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD25, Filter bits
: CAN0_F8DATA1_FD26 ( -- x addr ) 26 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD26, Filter bits
: CAN0_F8DATA1_FD27 ( -- x addr ) 27 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD27, Filter bits
: CAN0_F8DATA1_FD28 ( -- x addr ) 28 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD28, Filter bits
: CAN0_F8DATA1_FD29 ( -- x addr ) 29 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD29, Filter bits
: CAN0_F8DATA1_FD30 ( -- x addr ) 30 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD30, Filter bits
: CAN0_F8DATA1_FD31 ( -- x addr ) 31 bit CAN0_F8DATA1 ; \ CAN0_F8DATA1_FD31, Filter bits

\ CAN0_F9DATA0 (read-write) Reset:0x00000000
: CAN0_F9DATA0_FD0 ( -- x addr ) 0 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD0, Filter bits
: CAN0_F9DATA0_FD1 ( -- x addr ) 1 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD1, Filter bits
: CAN0_F9DATA0_FD2 ( -- x addr ) 2 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD2, Filter bits
: CAN0_F9DATA0_FD3 ( -- x addr ) 3 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD3, Filter bits
: CAN0_F9DATA0_FD4 ( -- x addr ) 4 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD4, Filter bits
: CAN0_F9DATA0_FD5 ( -- x addr ) 5 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD5, Filter bits
: CAN0_F9DATA0_FD6 ( -- x addr ) 6 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD6, Filter bits
: CAN0_F9DATA0_FD7 ( -- x addr ) 7 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD7, Filter bits
: CAN0_F9DATA0_FD8 ( -- x addr ) 8 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD8, Filter bits
: CAN0_F9DATA0_FD9 ( -- x addr ) 9 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD9, Filter bits
: CAN0_F9DATA0_FD10 ( -- x addr ) 10 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD10, Filter bits
: CAN0_F9DATA0_FD11 ( -- x addr ) 11 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD11, Filter bits
: CAN0_F9DATA0_FD12 ( -- x addr ) 12 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD12, Filter bits
: CAN0_F9DATA0_FD13 ( -- x addr ) 13 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD13, Filter bits
: CAN0_F9DATA0_FD14 ( -- x addr ) 14 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD14, Filter bits
: CAN0_F9DATA0_FD15 ( -- x addr ) 15 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD15, Filter bits
: CAN0_F9DATA0_FD16 ( -- x addr ) 16 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD16, Filter bits
: CAN0_F9DATA0_FD17 ( -- x addr ) 17 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD17, Filter bits
: CAN0_F9DATA0_FD18 ( -- x addr ) 18 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD18, Filter bits
: CAN0_F9DATA0_FD19 ( -- x addr ) 19 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD19, Filter bits
: CAN0_F9DATA0_FD20 ( -- x addr ) 20 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD20, Filter bits
: CAN0_F9DATA0_FD21 ( -- x addr ) 21 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD21, Filter bits
: CAN0_F9DATA0_FD22 ( -- x addr ) 22 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD22, Filter bits
: CAN0_F9DATA0_FD23 ( -- x addr ) 23 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD23, Filter bits
: CAN0_F9DATA0_FD24 ( -- x addr ) 24 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD24, Filter bits
: CAN0_F9DATA0_FD25 ( -- x addr ) 25 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD25, Filter bits
: CAN0_F9DATA0_FD26 ( -- x addr ) 26 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD26, Filter bits
: CAN0_F9DATA0_FD27 ( -- x addr ) 27 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD27, Filter bits
: CAN0_F9DATA0_FD28 ( -- x addr ) 28 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD28, Filter bits
: CAN0_F9DATA0_FD29 ( -- x addr ) 29 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD29, Filter bits
: CAN0_F9DATA0_FD30 ( -- x addr ) 30 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD30, Filter bits
: CAN0_F9DATA0_FD31 ( -- x addr ) 31 bit CAN0_F9DATA0 ; \ CAN0_F9DATA0_FD31, Filter bits

\ CAN0_F9DATA1 (read-write) Reset:0x00000000
: CAN0_F9DATA1_FD0 ( -- x addr ) 0 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD0, Filter bits
: CAN0_F9DATA1_FD1 ( -- x addr ) 1 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD1, Filter bits
: CAN0_F9DATA1_FD2 ( -- x addr ) 2 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD2, Filter bits
: CAN0_F9DATA1_FD3 ( -- x addr ) 3 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD3, Filter bits
: CAN0_F9DATA1_FD4 ( -- x addr ) 4 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD4, Filter bits
: CAN0_F9DATA1_FD5 ( -- x addr ) 5 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD5, Filter bits
: CAN0_F9DATA1_FD6 ( -- x addr ) 6 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD6, Filter bits
: CAN0_F9DATA1_FD7 ( -- x addr ) 7 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD7, Filter bits
: CAN0_F9DATA1_FD8 ( -- x addr ) 8 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD8, Filter bits
: CAN0_F9DATA1_FD9 ( -- x addr ) 9 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD9, Filter bits
: CAN0_F9DATA1_FD10 ( -- x addr ) 10 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD10, Filter bits
: CAN0_F9DATA1_FD11 ( -- x addr ) 11 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD11, Filter bits
: CAN0_F9DATA1_FD12 ( -- x addr ) 12 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD12, Filter bits
: CAN0_F9DATA1_FD13 ( -- x addr ) 13 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD13, Filter bits
: CAN0_F9DATA1_FD14 ( -- x addr ) 14 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD14, Filter bits
: CAN0_F9DATA1_FD15 ( -- x addr ) 15 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD15, Filter bits
: CAN0_F9DATA1_FD16 ( -- x addr ) 16 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD16, Filter bits
: CAN0_F9DATA1_FD17 ( -- x addr ) 17 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD17, Filter bits
: CAN0_F9DATA1_FD18 ( -- x addr ) 18 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD18, Filter bits
: CAN0_F9DATA1_FD19 ( -- x addr ) 19 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD19, Filter bits
: CAN0_F9DATA1_FD20 ( -- x addr ) 20 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD20, Filter bits
: CAN0_F9DATA1_FD21 ( -- x addr ) 21 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD21, Filter bits
: CAN0_F9DATA1_FD22 ( -- x addr ) 22 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD22, Filter bits
: CAN0_F9DATA1_FD23 ( -- x addr ) 23 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD23, Filter bits
: CAN0_F9DATA1_FD24 ( -- x addr ) 24 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD24, Filter bits
: CAN0_F9DATA1_FD25 ( -- x addr ) 25 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD25, Filter bits
: CAN0_F9DATA1_FD26 ( -- x addr ) 26 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD26, Filter bits
: CAN0_F9DATA1_FD27 ( -- x addr ) 27 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD27, Filter bits
: CAN0_F9DATA1_FD28 ( -- x addr ) 28 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD28, Filter bits
: CAN0_F9DATA1_FD29 ( -- x addr ) 29 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD29, Filter bits
: CAN0_F9DATA1_FD30 ( -- x addr ) 30 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD30, Filter bits
: CAN0_F9DATA1_FD31 ( -- x addr ) 31 bit CAN0_F9DATA1 ; \ CAN0_F9DATA1_FD31, Filter bits

\ CAN0_F10DATA0 (read-write) Reset:0x00000000
: CAN0_F10DATA0_FD0 ( -- x addr ) 0 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD0, Filter bits
: CAN0_F10DATA0_FD1 ( -- x addr ) 1 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD1, Filter bits
: CAN0_F10DATA0_FD2 ( -- x addr ) 2 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD2, Filter bits
: CAN0_F10DATA0_FD3 ( -- x addr ) 3 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD3, Filter bits
: CAN0_F10DATA0_FD4 ( -- x addr ) 4 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD4, Filter bits
: CAN0_F10DATA0_FD5 ( -- x addr ) 5 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD5, Filter bits
: CAN0_F10DATA0_FD6 ( -- x addr ) 6 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD6, Filter bits
: CAN0_F10DATA0_FD7 ( -- x addr ) 7 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD7, Filter bits
: CAN0_F10DATA0_FD8 ( -- x addr ) 8 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD8, Filter bits
: CAN0_F10DATA0_FD9 ( -- x addr ) 9 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD9, Filter bits
: CAN0_F10DATA0_FD10 ( -- x addr ) 10 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD10, Filter bits
: CAN0_F10DATA0_FD11 ( -- x addr ) 11 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD11, Filter bits
: CAN0_F10DATA0_FD12 ( -- x addr ) 12 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD12, Filter bits
: CAN0_F10DATA0_FD13 ( -- x addr ) 13 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD13, Filter bits
: CAN0_F10DATA0_FD14 ( -- x addr ) 14 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD14, Filter bits
: CAN0_F10DATA0_FD15 ( -- x addr ) 15 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD15, Filter bits
: CAN0_F10DATA0_FD16 ( -- x addr ) 16 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD16, Filter bits
: CAN0_F10DATA0_FD17 ( -- x addr ) 17 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD17, Filter bits
: CAN0_F10DATA0_FD18 ( -- x addr ) 18 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD18, Filter bits
: CAN0_F10DATA0_FD19 ( -- x addr ) 19 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD19, Filter bits
: CAN0_F10DATA0_FD20 ( -- x addr ) 20 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD20, Filter bits
: CAN0_F10DATA0_FD21 ( -- x addr ) 21 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD21, Filter bits
: CAN0_F10DATA0_FD22 ( -- x addr ) 22 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD22, Filter bits
: CAN0_F10DATA0_FD23 ( -- x addr ) 23 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD23, Filter bits
: CAN0_F10DATA0_FD24 ( -- x addr ) 24 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD24, Filter bits
: CAN0_F10DATA0_FD25 ( -- x addr ) 25 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD25, Filter bits
: CAN0_F10DATA0_FD26 ( -- x addr ) 26 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD26, Filter bits
: CAN0_F10DATA0_FD27 ( -- x addr ) 27 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD27, Filter bits
: CAN0_F10DATA0_FD28 ( -- x addr ) 28 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD28, Filter bits
: CAN0_F10DATA0_FD29 ( -- x addr ) 29 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD29, Filter bits
: CAN0_F10DATA0_FD30 ( -- x addr ) 30 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD30, Filter bits
: CAN0_F10DATA0_FD31 ( -- x addr ) 31 bit CAN0_F10DATA0 ; \ CAN0_F10DATA0_FD31, Filter bits

\ CAN0_F10DATA1 (read-write) Reset:0x00000000
: CAN0_F10DATA1_FD0 ( -- x addr ) 0 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD0, Filter bits
: CAN0_F10DATA1_FD1 ( -- x addr ) 1 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD1, Filter bits
: CAN0_F10DATA1_FD2 ( -- x addr ) 2 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD2, Filter bits
: CAN0_F10DATA1_FD3 ( -- x addr ) 3 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD3, Filter bits
: CAN0_F10DATA1_FD4 ( -- x addr ) 4 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD4, Filter bits
: CAN0_F10DATA1_FD5 ( -- x addr ) 5 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD5, Filter bits
: CAN0_F10DATA1_FD6 ( -- x addr ) 6 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD6, Filter bits
: CAN0_F10DATA1_FD7 ( -- x addr ) 7 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD7, Filter bits
: CAN0_F10DATA1_FD8 ( -- x addr ) 8 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD8, Filter bits
: CAN0_F10DATA1_FD9 ( -- x addr ) 9 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD9, Filter bits
: CAN0_F10DATA1_FD10 ( -- x addr ) 10 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD10, Filter bits
: CAN0_F10DATA1_FD11 ( -- x addr ) 11 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD11, Filter bits
: CAN0_F10DATA1_FD12 ( -- x addr ) 12 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD12, Filter bits
: CAN0_F10DATA1_FD13 ( -- x addr ) 13 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD13, Filter bits
: CAN0_F10DATA1_FD14 ( -- x addr ) 14 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD14, Filter bits
: CAN0_F10DATA1_FD15 ( -- x addr ) 15 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD15, Filter bits
: CAN0_F10DATA1_FD16 ( -- x addr ) 16 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD16, Filter bits
: CAN0_F10DATA1_FD17 ( -- x addr ) 17 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD17, Filter bits
: CAN0_F10DATA1_FD18 ( -- x addr ) 18 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD18, Filter bits
: CAN0_F10DATA1_FD19 ( -- x addr ) 19 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD19, Filter bits
: CAN0_F10DATA1_FD20 ( -- x addr ) 20 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD20, Filter bits
: CAN0_F10DATA1_FD21 ( -- x addr ) 21 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD21, Filter bits
: CAN0_F10DATA1_FD22 ( -- x addr ) 22 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD22, Filter bits
: CAN0_F10DATA1_FD23 ( -- x addr ) 23 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD23, Filter bits
: CAN0_F10DATA1_FD24 ( -- x addr ) 24 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD24, Filter bits
: CAN0_F10DATA1_FD25 ( -- x addr ) 25 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD25, Filter bits
: CAN0_F10DATA1_FD26 ( -- x addr ) 26 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD26, Filter bits
: CAN0_F10DATA1_FD27 ( -- x addr ) 27 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD27, Filter bits
: CAN0_F10DATA1_FD28 ( -- x addr ) 28 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD28, Filter bits
: CAN0_F10DATA1_FD29 ( -- x addr ) 29 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD29, Filter bits
: CAN0_F10DATA1_FD30 ( -- x addr ) 30 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD30, Filter bits
: CAN0_F10DATA1_FD31 ( -- x addr ) 31 bit CAN0_F10DATA1 ; \ CAN0_F10DATA1_FD31, Filter bits

\ CAN0_F11DATA0 (read-write) Reset:0x00000000
: CAN0_F11DATA0_FD0 ( -- x addr ) 0 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD0, Filter bits
: CAN0_F11DATA0_FD1 ( -- x addr ) 1 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD1, Filter bits
: CAN0_F11DATA0_FD2 ( -- x addr ) 2 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD2, Filter bits
: CAN0_F11DATA0_FD3 ( -- x addr ) 3 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD3, Filter bits
: CAN0_F11DATA0_FD4 ( -- x addr ) 4 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD4, Filter bits
: CAN0_F11DATA0_FD5 ( -- x addr ) 5 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD5, Filter bits
: CAN0_F11DATA0_FD6 ( -- x addr ) 6 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD6, Filter bits
: CAN0_F11DATA0_FD7 ( -- x addr ) 7 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD7, Filter bits
: CAN0_F11DATA0_FD8 ( -- x addr ) 8 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD8, Filter bits
: CAN0_F11DATA0_FD9 ( -- x addr ) 9 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD9, Filter bits
: CAN0_F11DATA0_FD10 ( -- x addr ) 10 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD10, Filter bits
: CAN0_F11DATA0_FD11 ( -- x addr ) 11 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD11, Filter bits
: CAN0_F11DATA0_FD12 ( -- x addr ) 12 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD12, Filter bits
: CAN0_F11DATA0_FD13 ( -- x addr ) 13 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD13, Filter bits
: CAN0_F11DATA0_FD14 ( -- x addr ) 14 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD14, Filter bits
: CAN0_F11DATA0_FD15 ( -- x addr ) 15 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD15, Filter bits
: CAN0_F11DATA0_FD16 ( -- x addr ) 16 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD16, Filter bits
: CAN0_F11DATA0_FD17 ( -- x addr ) 17 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD17, Filter bits
: CAN0_F11DATA0_FD18 ( -- x addr ) 18 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD18, Filter bits
: CAN0_F11DATA0_FD19 ( -- x addr ) 19 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD19, Filter bits
: CAN0_F11DATA0_FD20 ( -- x addr ) 20 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD20, Filter bits
: CAN0_F11DATA0_FD21 ( -- x addr ) 21 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD21, Filter bits
: CAN0_F11DATA0_FD22 ( -- x addr ) 22 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD22, Filter bits
: CAN0_F11DATA0_FD23 ( -- x addr ) 23 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD23, Filter bits
: CAN0_F11DATA0_FD24 ( -- x addr ) 24 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD24, Filter bits
: CAN0_F11DATA0_FD25 ( -- x addr ) 25 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD25, Filter bits
: CAN0_F11DATA0_FD26 ( -- x addr ) 26 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD26, Filter bits
: CAN0_F11DATA0_FD27 ( -- x addr ) 27 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD27, Filter bits
: CAN0_F11DATA0_FD28 ( -- x addr ) 28 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD28, Filter bits
: CAN0_F11DATA0_FD29 ( -- x addr ) 29 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD29, Filter bits
: CAN0_F11DATA0_FD30 ( -- x addr ) 30 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD30, Filter bits
: CAN0_F11DATA0_FD31 ( -- x addr ) 31 bit CAN0_F11DATA0 ; \ CAN0_F11DATA0_FD31, Filter bits

\ CAN0_F11DATA1 (read-write) Reset:0x00000000
: CAN0_F11DATA1_FD0 ( -- x addr ) 0 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD0, Filter bits
: CAN0_F11DATA1_FD1 ( -- x addr ) 1 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD1, Filter bits
: CAN0_F11DATA1_FD2 ( -- x addr ) 2 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD2, Filter bits
: CAN0_F11DATA1_FD3 ( -- x addr ) 3 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD3, Filter bits
: CAN0_F11DATA1_FD4 ( -- x addr ) 4 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD4, Filter bits
: CAN0_F11DATA1_FD5 ( -- x addr ) 5 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD5, Filter bits
: CAN0_F11DATA1_FD6 ( -- x addr ) 6 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD6, Filter bits
: CAN0_F11DATA1_FD7 ( -- x addr ) 7 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD7, Filter bits
: CAN0_F11DATA1_FD8 ( -- x addr ) 8 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD8, Filter bits
: CAN0_F11DATA1_FD9 ( -- x addr ) 9 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD9, Filter bits
: CAN0_F11DATA1_FD10 ( -- x addr ) 10 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD10, Filter bits
: CAN0_F11DATA1_FD11 ( -- x addr ) 11 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD11, Filter bits
: CAN0_F11DATA1_FD12 ( -- x addr ) 12 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD12, Filter bits
: CAN0_F11DATA1_FD13 ( -- x addr ) 13 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD13, Filter bits
: CAN0_F11DATA1_FD14 ( -- x addr ) 14 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD14, Filter bits
: CAN0_F11DATA1_FD15 ( -- x addr ) 15 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD15, Filter bits
: CAN0_F11DATA1_FD16 ( -- x addr ) 16 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD16, Filter bits
: CAN0_F11DATA1_FD17 ( -- x addr ) 17 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD17, Filter bits
: CAN0_F11DATA1_FD18 ( -- x addr ) 18 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD18, Filter bits
: CAN0_F11DATA1_FD19 ( -- x addr ) 19 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD19, Filter bits
: CAN0_F11DATA1_FD20 ( -- x addr ) 20 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD20, Filter bits
: CAN0_F11DATA1_FD21 ( -- x addr ) 21 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD21, Filter bits
: CAN0_F11DATA1_FD22 ( -- x addr ) 22 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD22, Filter bits
: CAN0_F11DATA1_FD23 ( -- x addr ) 23 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD23, Filter bits
: CAN0_F11DATA1_FD24 ( -- x addr ) 24 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD24, Filter bits
: CAN0_F11DATA1_FD25 ( -- x addr ) 25 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD25, Filter bits
: CAN0_F11DATA1_FD26 ( -- x addr ) 26 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD26, Filter bits
: CAN0_F11DATA1_FD27 ( -- x addr ) 27 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD27, Filter bits
: CAN0_F11DATA1_FD28 ( -- x addr ) 28 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD28, Filter bits
: CAN0_F11DATA1_FD29 ( -- x addr ) 29 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD29, Filter bits
: CAN0_F11DATA1_FD30 ( -- x addr ) 30 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD30, Filter bits
: CAN0_F11DATA1_FD31 ( -- x addr ) 31 bit CAN0_F11DATA1 ; \ CAN0_F11DATA1_FD31, Filter bits

\ CAN0_F12DATA0 (read-write) Reset:0x00000000
: CAN0_F12DATA0_FD0 ( -- x addr ) 0 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD0, Filter bits
: CAN0_F12DATA0_FD1 ( -- x addr ) 1 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD1, Filter bits
: CAN0_F12DATA0_FD2 ( -- x addr ) 2 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD2, Filter bits
: CAN0_F12DATA0_FD3 ( -- x addr ) 3 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD3, Filter bits
: CAN0_F12DATA0_FD4 ( -- x addr ) 4 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD4, Filter bits
: CAN0_F12DATA0_FD5 ( -- x addr ) 5 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD5, Filter bits
: CAN0_F12DATA0_FD6 ( -- x addr ) 6 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD6, Filter bits
: CAN0_F12DATA0_FD7 ( -- x addr ) 7 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD7, Filter bits
: CAN0_F12DATA0_FD8 ( -- x addr ) 8 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD8, Filter bits
: CAN0_F12DATA0_FD9 ( -- x addr ) 9 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD9, Filter bits
: CAN0_F12DATA0_FD10 ( -- x addr ) 10 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD10, Filter bits
: CAN0_F12DATA0_FD11 ( -- x addr ) 11 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD11, Filter bits
: CAN0_F12DATA0_FD12 ( -- x addr ) 12 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD12, Filter bits
: CAN0_F12DATA0_FD13 ( -- x addr ) 13 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD13, Filter bits
: CAN0_F12DATA0_FD14 ( -- x addr ) 14 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD14, Filter bits
: CAN0_F12DATA0_FD15 ( -- x addr ) 15 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD15, Filter bits
: CAN0_F12DATA0_FD16 ( -- x addr ) 16 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD16, Filter bits
: CAN0_F12DATA0_FD17 ( -- x addr ) 17 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD17, Filter bits
: CAN0_F12DATA0_FD18 ( -- x addr ) 18 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD18, Filter bits
: CAN0_F12DATA0_FD19 ( -- x addr ) 19 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD19, Filter bits
: CAN0_F12DATA0_FD20 ( -- x addr ) 20 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD20, Filter bits
: CAN0_F12DATA0_FD21 ( -- x addr ) 21 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD21, Filter bits
: CAN0_F12DATA0_FD22 ( -- x addr ) 22 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD22, Filter bits
: CAN0_F12DATA0_FD23 ( -- x addr ) 23 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD23, Filter bits
: CAN0_F12DATA0_FD24 ( -- x addr ) 24 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD24, Filter bits
: CAN0_F12DATA0_FD25 ( -- x addr ) 25 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD25, Filter bits
: CAN0_F12DATA0_FD26 ( -- x addr ) 26 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD26, Filter bits
: CAN0_F12DATA0_FD27 ( -- x addr ) 27 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD27, Filter bits
: CAN0_F12DATA0_FD28 ( -- x addr ) 28 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD28, Filter bits
: CAN0_F12DATA0_FD29 ( -- x addr ) 29 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD29, Filter bits
: CAN0_F12DATA0_FD30 ( -- x addr ) 30 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD30, Filter bits
: CAN0_F12DATA0_FD31 ( -- x addr ) 31 bit CAN0_F12DATA0 ; \ CAN0_F12DATA0_FD31, Filter bits

\ CAN0_F12DATA1 (read-write) Reset:0x00000000
: CAN0_F12DATA1_FD0 ( -- x addr ) 0 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD0, Filter bits
: CAN0_F12DATA1_FD1 ( -- x addr ) 1 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD1, Filter bits
: CAN0_F12DATA1_FD2 ( -- x addr ) 2 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD2, Filter bits
: CAN0_F12DATA1_FD3 ( -- x addr ) 3 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD3, Filter bits
: CAN0_F12DATA1_FD4 ( -- x addr ) 4 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD4, Filter bits
: CAN0_F12DATA1_FD5 ( -- x addr ) 5 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD5, Filter bits
: CAN0_F12DATA1_FD6 ( -- x addr ) 6 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD6, Filter bits
: CAN0_F12DATA1_FD7 ( -- x addr ) 7 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD7, Filter bits
: CAN0_F12DATA1_FD8 ( -- x addr ) 8 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD8, Filter bits
: CAN0_F12DATA1_FD9 ( -- x addr ) 9 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD9, Filter bits
: CAN0_F12DATA1_FD10 ( -- x addr ) 10 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD10, Filter bits
: CAN0_F12DATA1_FD11 ( -- x addr ) 11 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD11, Filter bits
: CAN0_F12DATA1_FD12 ( -- x addr ) 12 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD12, Filter bits
: CAN0_F12DATA1_FD13 ( -- x addr ) 13 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD13, Filter bits
: CAN0_F12DATA1_FD14 ( -- x addr ) 14 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD14, Filter bits
: CAN0_F12DATA1_FD15 ( -- x addr ) 15 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD15, Filter bits
: CAN0_F12DATA1_FD16 ( -- x addr ) 16 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD16, Filter bits
: CAN0_F12DATA1_FD17 ( -- x addr ) 17 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD17, Filter bits
: CAN0_F12DATA1_FD18 ( -- x addr ) 18 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD18, Filter bits
: CAN0_F12DATA1_FD19 ( -- x addr ) 19 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD19, Filter bits
: CAN0_F12DATA1_FD20 ( -- x addr ) 20 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD20, Filter bits
: CAN0_F12DATA1_FD21 ( -- x addr ) 21 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD21, Filter bits
: CAN0_F12DATA1_FD22 ( -- x addr ) 22 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD22, Filter bits
: CAN0_F12DATA1_FD23 ( -- x addr ) 23 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD23, Filter bits
: CAN0_F12DATA1_FD24 ( -- x addr ) 24 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD24, Filter bits
: CAN0_F12DATA1_FD25 ( -- x addr ) 25 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD25, Filter bits
: CAN0_F12DATA1_FD26 ( -- x addr ) 26 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD26, Filter bits
: CAN0_F12DATA1_FD27 ( -- x addr ) 27 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD27, Filter bits
: CAN0_F12DATA1_FD28 ( -- x addr ) 28 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD28, Filter bits
: CAN0_F12DATA1_FD29 ( -- x addr ) 29 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD29, Filter bits
: CAN0_F12DATA1_FD30 ( -- x addr ) 30 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD30, Filter bits
: CAN0_F12DATA1_FD31 ( -- x addr ) 31 bit CAN0_F12DATA1 ; \ CAN0_F12DATA1_FD31, Filter bits

\ CAN0_F13DATA0 (read-write) Reset:0x00000000
: CAN0_F13DATA0_FD0 ( -- x addr ) 0 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD0, Filter bits
: CAN0_F13DATA0_FD1 ( -- x addr ) 1 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD1, Filter bits
: CAN0_F13DATA0_FD2 ( -- x addr ) 2 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD2, Filter bits
: CAN0_F13DATA0_FD3 ( -- x addr ) 3 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD3, Filter bits
: CAN0_F13DATA0_FD4 ( -- x addr ) 4 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD4, Filter bits
: CAN0_F13DATA0_FD5 ( -- x addr ) 5 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD5, Filter bits
: CAN0_F13DATA0_FD6 ( -- x addr ) 6 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD6, Filter bits
: CAN0_F13DATA0_FD7 ( -- x addr ) 7 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD7, Filter bits
: CAN0_F13DATA0_FD8 ( -- x addr ) 8 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD8, Filter bits
: CAN0_F13DATA0_FD9 ( -- x addr ) 9 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD9, Filter bits
: CAN0_F13DATA0_FD10 ( -- x addr ) 10 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD10, Filter bits
: CAN0_F13DATA0_FD11 ( -- x addr ) 11 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD11, Filter bits
: CAN0_F13DATA0_FD12 ( -- x addr ) 12 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD12, Filter bits
: CAN0_F13DATA0_FD13 ( -- x addr ) 13 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD13, Filter bits
: CAN0_F13DATA0_FD14 ( -- x addr ) 14 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD14, Filter bits
: CAN0_F13DATA0_FD15 ( -- x addr ) 15 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD15, Filter bits
: CAN0_F13DATA0_FD16 ( -- x addr ) 16 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD16, Filter bits
: CAN0_F13DATA0_FD17 ( -- x addr ) 17 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD17, Filter bits
: CAN0_F13DATA0_FD18 ( -- x addr ) 18 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD18, Filter bits
: CAN0_F13DATA0_FD19 ( -- x addr ) 19 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD19, Filter bits
: CAN0_F13DATA0_FD20 ( -- x addr ) 20 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD20, Filter bits
: CAN0_F13DATA0_FD21 ( -- x addr ) 21 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD21, Filter bits
: CAN0_F13DATA0_FD22 ( -- x addr ) 22 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD22, Filter bits
: CAN0_F13DATA0_FD23 ( -- x addr ) 23 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD23, Filter bits
: CAN0_F13DATA0_FD24 ( -- x addr ) 24 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD24, Filter bits
: CAN0_F13DATA0_FD25 ( -- x addr ) 25 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD25, Filter bits
: CAN0_F13DATA0_FD26 ( -- x addr ) 26 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD26, Filter bits
: CAN0_F13DATA0_FD27 ( -- x addr ) 27 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD27, Filter bits
: CAN0_F13DATA0_FD28 ( -- x addr ) 28 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD28, Filter bits
: CAN0_F13DATA0_FD29 ( -- x addr ) 29 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD29, Filter bits
: CAN0_F13DATA0_FD30 ( -- x addr ) 30 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD30, Filter bits
: CAN0_F13DATA0_FD31 ( -- x addr ) 31 bit CAN0_F13DATA0 ; \ CAN0_F13DATA0_FD31, Filter bits

\ CAN0_F13DATA1 (read-write) Reset:0x00000000
: CAN0_F13DATA1_FD0 ( -- x addr ) 0 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD0, Filter bits
: CAN0_F13DATA1_FD1 ( -- x addr ) 1 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD1, Filter bits
: CAN0_F13DATA1_FD2 ( -- x addr ) 2 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD2, Filter bits
: CAN0_F13DATA1_FD3 ( -- x addr ) 3 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD3, Filter bits
: CAN0_F13DATA1_FD4 ( -- x addr ) 4 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD4, Filter bits
: CAN0_F13DATA1_FD5 ( -- x addr ) 5 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD5, Filter bits
: CAN0_F13DATA1_FD6 ( -- x addr ) 6 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD6, Filter bits
: CAN0_F13DATA1_FD7 ( -- x addr ) 7 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD7, Filter bits
: CAN0_F13DATA1_FD8 ( -- x addr ) 8 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD8, Filter bits
: CAN0_F13DATA1_FD9 ( -- x addr ) 9 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD9, Filter bits
: CAN0_F13DATA1_FD10 ( -- x addr ) 10 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD10, Filter bits
: CAN0_F13DATA1_FD11 ( -- x addr ) 11 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD11, Filter bits
: CAN0_F13DATA1_FD12 ( -- x addr ) 12 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD12, Filter bits
: CAN0_F13DATA1_FD13 ( -- x addr ) 13 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD13, Filter bits
: CAN0_F13DATA1_FD14 ( -- x addr ) 14 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD14, Filter bits
: CAN0_F13DATA1_FD15 ( -- x addr ) 15 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD15, Filter bits
: CAN0_F13DATA1_FD16 ( -- x addr ) 16 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD16, Filter bits
: CAN0_F13DATA1_FD17 ( -- x addr ) 17 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD17, Filter bits
: CAN0_F13DATA1_FD18 ( -- x addr ) 18 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD18, Filter bits
: CAN0_F13DATA1_FD19 ( -- x addr ) 19 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD19, Filter bits
: CAN0_F13DATA1_FD20 ( -- x addr ) 20 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD20, Filter bits
: CAN0_F13DATA1_FD21 ( -- x addr ) 21 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD21, Filter bits
: CAN0_F13DATA1_FD22 ( -- x addr ) 22 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD22, Filter bits
: CAN0_F13DATA1_FD23 ( -- x addr ) 23 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD23, Filter bits
: CAN0_F13DATA1_FD24 ( -- x addr ) 24 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD24, Filter bits
: CAN0_F13DATA1_FD25 ( -- x addr ) 25 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD25, Filter bits
: CAN0_F13DATA1_FD26 ( -- x addr ) 26 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD26, Filter bits
: CAN0_F13DATA1_FD27 ( -- x addr ) 27 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD27, Filter bits
: CAN0_F13DATA1_FD28 ( -- x addr ) 28 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD28, Filter bits
: CAN0_F13DATA1_FD29 ( -- x addr ) 29 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD29, Filter bits
: CAN0_F13DATA1_FD30 ( -- x addr ) 30 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD30, Filter bits
: CAN0_F13DATA1_FD31 ( -- x addr ) 31 bit CAN0_F13DATA1 ; \ CAN0_F13DATA1_FD31, Filter bits

\ CAN0_F14DATA0 (read-write) Reset:0x00000000
: CAN0_F14DATA0_FD0 ( -- x addr ) 0 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD0, Filter bits
: CAN0_F14DATA0_FD1 ( -- x addr ) 1 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD1, Filter bits
: CAN0_F14DATA0_FD2 ( -- x addr ) 2 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD2, Filter bits
: CAN0_F14DATA0_FD3 ( -- x addr ) 3 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD3, Filter bits
: CAN0_F14DATA0_FD4 ( -- x addr ) 4 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD4, Filter bits
: CAN0_F14DATA0_FD5 ( -- x addr ) 5 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD5, Filter bits
: CAN0_F14DATA0_FD6 ( -- x addr ) 6 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD6, Filter bits
: CAN0_F14DATA0_FD7 ( -- x addr ) 7 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD7, Filter bits
: CAN0_F14DATA0_FD8 ( -- x addr ) 8 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD8, Filter bits
: CAN0_F14DATA0_FD9 ( -- x addr ) 9 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD9, Filter bits
: CAN0_F14DATA0_FD10 ( -- x addr ) 10 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD10, Filter bits
: CAN0_F14DATA0_FD11 ( -- x addr ) 11 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD11, Filter bits
: CAN0_F14DATA0_FD12 ( -- x addr ) 12 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD12, Filter bits
: CAN0_F14DATA0_FD13 ( -- x addr ) 13 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD13, Filter bits
: CAN0_F14DATA0_FD14 ( -- x addr ) 14 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD14, Filter bits
: CAN0_F14DATA0_FD15 ( -- x addr ) 15 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD15, Filter bits
: CAN0_F14DATA0_FD16 ( -- x addr ) 16 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD16, Filter bits
: CAN0_F14DATA0_FD17 ( -- x addr ) 17 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD17, Filter bits
: CAN0_F14DATA0_FD18 ( -- x addr ) 18 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD18, Filter bits
: CAN0_F14DATA0_FD19 ( -- x addr ) 19 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD19, Filter bits
: CAN0_F14DATA0_FD20 ( -- x addr ) 20 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD20, Filter bits
: CAN0_F14DATA0_FD21 ( -- x addr ) 21 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD21, Filter bits
: CAN0_F14DATA0_FD22 ( -- x addr ) 22 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD22, Filter bits
: CAN0_F14DATA0_FD23 ( -- x addr ) 23 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD23, Filter bits
: CAN0_F14DATA0_FD24 ( -- x addr ) 24 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD24, Filter bits
: CAN0_F14DATA0_FD25 ( -- x addr ) 25 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD25, Filter bits
: CAN0_F14DATA0_FD26 ( -- x addr ) 26 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD26, Filter bits
: CAN0_F14DATA0_FD27 ( -- x addr ) 27 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD27, Filter bits
: CAN0_F14DATA0_FD28 ( -- x addr ) 28 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD28, Filter bits
: CAN0_F14DATA0_FD29 ( -- x addr ) 29 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD29, Filter bits
: CAN0_F14DATA0_FD30 ( -- x addr ) 30 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD30, Filter bits
: CAN0_F14DATA0_FD31 ( -- x addr ) 31 bit CAN0_F14DATA0 ; \ CAN0_F14DATA0_FD31, Filter bits

\ CAN0_F14DATA1 (read-write) Reset:0x00000000
: CAN0_F14DATA1_FD0 ( -- x addr ) 0 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD0, Filter bits
: CAN0_F14DATA1_FD1 ( -- x addr ) 1 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD1, Filter bits
: CAN0_F14DATA1_FD2 ( -- x addr ) 2 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD2, Filter bits
: CAN0_F14DATA1_FD3 ( -- x addr ) 3 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD3, Filter bits
: CAN0_F14DATA1_FD4 ( -- x addr ) 4 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD4, Filter bits
: CAN0_F14DATA1_FD5 ( -- x addr ) 5 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD5, Filter bits
: CAN0_F14DATA1_FD6 ( -- x addr ) 6 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD6, Filter bits
: CAN0_F14DATA1_FD7 ( -- x addr ) 7 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD7, Filter bits
: CAN0_F14DATA1_FD8 ( -- x addr ) 8 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD8, Filter bits
: CAN0_F14DATA1_FD9 ( -- x addr ) 9 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD9, Filter bits
: CAN0_F14DATA1_FD10 ( -- x addr ) 10 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD10, Filter bits
: CAN0_F14DATA1_FD11 ( -- x addr ) 11 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD11, Filter bits
: CAN0_F14DATA1_FD12 ( -- x addr ) 12 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD12, Filter bits
: CAN0_F14DATA1_FD13 ( -- x addr ) 13 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD13, Filter bits
: CAN0_F14DATA1_FD14 ( -- x addr ) 14 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD14, Filter bits
: CAN0_F14DATA1_FD15 ( -- x addr ) 15 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD15, Filter bits
: CAN0_F14DATA1_FD16 ( -- x addr ) 16 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD16, Filter bits
: CAN0_F14DATA1_FD17 ( -- x addr ) 17 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD17, Filter bits
: CAN0_F14DATA1_FD18 ( -- x addr ) 18 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD18, Filter bits
: CAN0_F14DATA1_FD19 ( -- x addr ) 19 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD19, Filter bits
: CAN0_F14DATA1_FD20 ( -- x addr ) 20 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD20, Filter bits
: CAN0_F14DATA1_FD21 ( -- x addr ) 21 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD21, Filter bits
: CAN0_F14DATA1_FD22 ( -- x addr ) 22 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD22, Filter bits
: CAN0_F14DATA1_FD23 ( -- x addr ) 23 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD23, Filter bits
: CAN0_F14DATA1_FD24 ( -- x addr ) 24 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD24, Filter bits
: CAN0_F14DATA1_FD25 ( -- x addr ) 25 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD25, Filter bits
: CAN0_F14DATA1_FD26 ( -- x addr ) 26 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD26, Filter bits
: CAN0_F14DATA1_FD27 ( -- x addr ) 27 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD27, Filter bits
: CAN0_F14DATA1_FD28 ( -- x addr ) 28 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD28, Filter bits
: CAN0_F14DATA1_FD29 ( -- x addr ) 29 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD29, Filter bits
: CAN0_F14DATA1_FD30 ( -- x addr ) 30 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD30, Filter bits
: CAN0_F14DATA1_FD31 ( -- x addr ) 31 bit CAN0_F14DATA1 ; \ CAN0_F14DATA1_FD31, Filter bits

\ CAN0_F15DATA0 (read-write) Reset:0x00000000
: CAN0_F15DATA0_FD0 ( -- x addr ) 0 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD0, Filter bits
: CAN0_F15DATA0_FD1 ( -- x addr ) 1 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD1, Filter bits
: CAN0_F15DATA0_FD2 ( -- x addr ) 2 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD2, Filter bits
: CAN0_F15DATA0_FD3 ( -- x addr ) 3 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD3, Filter bits
: CAN0_F15DATA0_FD4 ( -- x addr ) 4 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD4, Filter bits
: CAN0_F15DATA0_FD5 ( -- x addr ) 5 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD5, Filter bits
: CAN0_F15DATA0_FD6 ( -- x addr ) 6 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD6, Filter bits
: CAN0_F15DATA0_FD7 ( -- x addr ) 7 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD7, Filter bits
: CAN0_F15DATA0_FD8 ( -- x addr ) 8 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD8, Filter bits
: CAN0_F15DATA0_FD9 ( -- x addr ) 9 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD9, Filter bits
: CAN0_F15DATA0_FD10 ( -- x addr ) 10 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD10, Filter bits
: CAN0_F15DATA0_FD11 ( -- x addr ) 11 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD11, Filter bits
: CAN0_F15DATA0_FD12 ( -- x addr ) 12 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD12, Filter bits
: CAN0_F15DATA0_FD13 ( -- x addr ) 13 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD13, Filter bits
: CAN0_F15DATA0_FD14 ( -- x addr ) 14 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD14, Filter bits
: CAN0_F15DATA0_FD15 ( -- x addr ) 15 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD15, Filter bits
: CAN0_F15DATA0_FD16 ( -- x addr ) 16 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD16, Filter bits
: CAN0_F15DATA0_FD17 ( -- x addr ) 17 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD17, Filter bits
: CAN0_F15DATA0_FD18 ( -- x addr ) 18 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD18, Filter bits
: CAN0_F15DATA0_FD19 ( -- x addr ) 19 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD19, Filter bits
: CAN0_F15DATA0_FD20 ( -- x addr ) 20 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD20, Filter bits
: CAN0_F15DATA0_FD21 ( -- x addr ) 21 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD21, Filter bits
: CAN0_F15DATA0_FD22 ( -- x addr ) 22 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD22, Filter bits
: CAN0_F15DATA0_FD23 ( -- x addr ) 23 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD23, Filter bits
: CAN0_F15DATA0_FD24 ( -- x addr ) 24 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD24, Filter bits
: CAN0_F15DATA0_FD25 ( -- x addr ) 25 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD25, Filter bits
: CAN0_F15DATA0_FD26 ( -- x addr ) 26 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD26, Filter bits
: CAN0_F15DATA0_FD27 ( -- x addr ) 27 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD27, Filter bits
: CAN0_F15DATA0_FD28 ( -- x addr ) 28 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD28, Filter bits
: CAN0_F15DATA0_FD29 ( -- x addr ) 29 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD29, Filter bits
: CAN0_F15DATA0_FD30 ( -- x addr ) 30 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD30, Filter bits
: CAN0_F15DATA0_FD31 ( -- x addr ) 31 bit CAN0_F15DATA0 ; \ CAN0_F15DATA0_FD31, Filter bits

\ CAN0_F15DATA1 (read-write) Reset:0x00000000
: CAN0_F15DATA1_FD0 ( -- x addr ) 0 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD0, Filter bits
: CAN0_F15DATA1_FD1 ( -- x addr ) 1 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD1, Filter bits
: CAN0_F15DATA1_FD2 ( -- x addr ) 2 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD2, Filter bits
: CAN0_F15DATA1_FD3 ( -- x addr ) 3 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD3, Filter bits
: CAN0_F15DATA1_FD4 ( -- x addr ) 4 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD4, Filter bits
: CAN0_F15DATA1_FD5 ( -- x addr ) 5 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD5, Filter bits
: CAN0_F15DATA1_FD6 ( -- x addr ) 6 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD6, Filter bits
: CAN0_F15DATA1_FD7 ( -- x addr ) 7 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD7, Filter bits
: CAN0_F15DATA1_FD8 ( -- x addr ) 8 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD8, Filter bits
: CAN0_F15DATA1_FD9 ( -- x addr ) 9 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD9, Filter bits
: CAN0_F15DATA1_FD10 ( -- x addr ) 10 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD10, Filter bits
: CAN0_F15DATA1_FD11 ( -- x addr ) 11 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD11, Filter bits
: CAN0_F15DATA1_FD12 ( -- x addr ) 12 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD12, Filter bits
: CAN0_F15DATA1_FD13 ( -- x addr ) 13 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD13, Filter bits
: CAN0_F15DATA1_FD14 ( -- x addr ) 14 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD14, Filter bits
: CAN0_F15DATA1_FD15 ( -- x addr ) 15 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD15, Filter bits
: CAN0_F15DATA1_FD16 ( -- x addr ) 16 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD16, Filter bits
: CAN0_F15DATA1_FD17 ( -- x addr ) 17 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD17, Filter bits
: CAN0_F15DATA1_FD18 ( -- x addr ) 18 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD18, Filter bits
: CAN0_F15DATA1_FD19 ( -- x addr ) 19 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD19, Filter bits
: CAN0_F15DATA1_FD20 ( -- x addr ) 20 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD20, Filter bits
: CAN0_F15DATA1_FD21 ( -- x addr ) 21 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD21, Filter bits
: CAN0_F15DATA1_FD22 ( -- x addr ) 22 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD22, Filter bits
: CAN0_F15DATA1_FD23 ( -- x addr ) 23 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD23, Filter bits
: CAN0_F15DATA1_FD24 ( -- x addr ) 24 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD24, Filter bits
: CAN0_F15DATA1_FD25 ( -- x addr ) 25 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD25, Filter bits
: CAN0_F15DATA1_FD26 ( -- x addr ) 26 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD26, Filter bits
: CAN0_F15DATA1_FD27 ( -- x addr ) 27 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD27, Filter bits
: CAN0_F15DATA1_FD28 ( -- x addr ) 28 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD28, Filter bits
: CAN0_F15DATA1_FD29 ( -- x addr ) 29 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD29, Filter bits
: CAN0_F15DATA1_FD30 ( -- x addr ) 30 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD30, Filter bits
: CAN0_F15DATA1_FD31 ( -- x addr ) 31 bit CAN0_F15DATA1 ; \ CAN0_F15DATA1_FD31, Filter bits

\ CAN0_F16DATA0 (read-write) Reset:0x00000000
: CAN0_F16DATA0_FD0 ( -- x addr ) 0 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD0, Filter bits
: CAN0_F16DATA0_FD1 ( -- x addr ) 1 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD1, Filter bits
: CAN0_F16DATA0_FD2 ( -- x addr ) 2 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD2, Filter bits
: CAN0_F16DATA0_FD3 ( -- x addr ) 3 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD3, Filter bits
: CAN0_F16DATA0_FD4 ( -- x addr ) 4 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD4, Filter bits
: CAN0_F16DATA0_FD5 ( -- x addr ) 5 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD5, Filter bits
: CAN0_F16DATA0_FD6 ( -- x addr ) 6 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD6, Filter bits
: CAN0_F16DATA0_FD7 ( -- x addr ) 7 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD7, Filter bits
: CAN0_F16DATA0_FD8 ( -- x addr ) 8 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD8, Filter bits
: CAN0_F16DATA0_FD9 ( -- x addr ) 9 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD9, Filter bits
: CAN0_F16DATA0_FD10 ( -- x addr ) 10 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD10, Filter bits
: CAN0_F16DATA0_FD11 ( -- x addr ) 11 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD11, Filter bits
: CAN0_F16DATA0_FD12 ( -- x addr ) 12 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD12, Filter bits
: CAN0_F16DATA0_FD13 ( -- x addr ) 13 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD13, Filter bits
: CAN0_F16DATA0_FD14 ( -- x addr ) 14 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD14, Filter bits
: CAN0_F16DATA0_FD15 ( -- x addr ) 15 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD15, Filter bits
: CAN0_F16DATA0_FD16 ( -- x addr ) 16 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD16, Filter bits
: CAN0_F16DATA0_FD17 ( -- x addr ) 17 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD17, Filter bits
: CAN0_F16DATA0_FD18 ( -- x addr ) 18 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD18, Filter bits
: CAN0_F16DATA0_FD19 ( -- x addr ) 19 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD19, Filter bits
: CAN0_F16DATA0_FD20 ( -- x addr ) 20 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD20, Filter bits
: CAN0_F16DATA0_FD21 ( -- x addr ) 21 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD21, Filter bits
: CAN0_F16DATA0_FD22 ( -- x addr ) 22 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD22, Filter bits
: CAN0_F16DATA0_FD23 ( -- x addr ) 23 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD23, Filter bits
: CAN0_F16DATA0_FD24 ( -- x addr ) 24 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD24, Filter bits
: CAN0_F16DATA0_FD25 ( -- x addr ) 25 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD25, Filter bits
: CAN0_F16DATA0_FD26 ( -- x addr ) 26 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD26, Filter bits
: CAN0_F16DATA0_FD27 ( -- x addr ) 27 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD27, Filter bits
: CAN0_F16DATA0_FD28 ( -- x addr ) 28 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD28, Filter bits
: CAN0_F16DATA0_FD29 ( -- x addr ) 29 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD29, Filter bits
: CAN0_F16DATA0_FD30 ( -- x addr ) 30 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD30, Filter bits
: CAN0_F16DATA0_FD31 ( -- x addr ) 31 bit CAN0_F16DATA0 ; \ CAN0_F16DATA0_FD31, Filter bits

\ CAN0_F16DATA1 (read-write) Reset:0x00000000
: CAN0_F16DATA1_FD0 ( -- x addr ) 0 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD0, Filter bits
: CAN0_F16DATA1_FD1 ( -- x addr ) 1 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD1, Filter bits
: CAN0_F16DATA1_FD2 ( -- x addr ) 2 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD2, Filter bits
: CAN0_F16DATA1_FD3 ( -- x addr ) 3 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD3, Filter bits
: CAN0_F16DATA1_FD4 ( -- x addr ) 4 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD4, Filter bits
: CAN0_F16DATA1_FD5 ( -- x addr ) 5 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD5, Filter bits
: CAN0_F16DATA1_FD6 ( -- x addr ) 6 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD6, Filter bits
: CAN0_F16DATA1_FD7 ( -- x addr ) 7 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD7, Filter bits
: CAN0_F16DATA1_FD8 ( -- x addr ) 8 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD8, Filter bits
: CAN0_F16DATA1_FD9 ( -- x addr ) 9 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD9, Filter bits
: CAN0_F16DATA1_FD10 ( -- x addr ) 10 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD10, Filter bits
: CAN0_F16DATA1_FD11 ( -- x addr ) 11 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD11, Filter bits
: CAN0_F16DATA1_FD12 ( -- x addr ) 12 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD12, Filter bits
: CAN0_F16DATA1_FD13 ( -- x addr ) 13 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD13, Filter bits
: CAN0_F16DATA1_FD14 ( -- x addr ) 14 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD14, Filter bits
: CAN0_F16DATA1_FD15 ( -- x addr ) 15 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD15, Filter bits
: CAN0_F16DATA1_FD16 ( -- x addr ) 16 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD16, Filter bits
: CAN0_F16DATA1_FD17 ( -- x addr ) 17 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD17, Filter bits
: CAN0_F16DATA1_FD18 ( -- x addr ) 18 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD18, Filter bits
: CAN0_F16DATA1_FD19 ( -- x addr ) 19 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD19, Filter bits
: CAN0_F16DATA1_FD20 ( -- x addr ) 20 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD20, Filter bits
: CAN0_F16DATA1_FD21 ( -- x addr ) 21 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD21, Filter bits
: CAN0_F16DATA1_FD22 ( -- x addr ) 22 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD22, Filter bits
: CAN0_F16DATA1_FD23 ( -- x addr ) 23 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD23, Filter bits
: CAN0_F16DATA1_FD24 ( -- x addr ) 24 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD24, Filter bits
: CAN0_F16DATA1_FD25 ( -- x addr ) 25 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD25, Filter bits
: CAN0_F16DATA1_FD26 ( -- x addr ) 26 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD26, Filter bits
: CAN0_F16DATA1_FD27 ( -- x addr ) 27 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD27, Filter bits
: CAN0_F16DATA1_FD28 ( -- x addr ) 28 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD28, Filter bits
: CAN0_F16DATA1_FD29 ( -- x addr ) 29 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD29, Filter bits
: CAN0_F16DATA1_FD30 ( -- x addr ) 30 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD30, Filter bits
: CAN0_F16DATA1_FD31 ( -- x addr ) 31 bit CAN0_F16DATA1 ; \ CAN0_F16DATA1_FD31, Filter bits

\ CAN0_F17DATA0 (read-write) Reset:0x00000000
: CAN0_F17DATA0_FD0 ( -- x addr ) 0 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD0, Filter bits
: CAN0_F17DATA0_FD1 ( -- x addr ) 1 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD1, Filter bits
: CAN0_F17DATA0_FD2 ( -- x addr ) 2 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD2, Filter bits
: CAN0_F17DATA0_FD3 ( -- x addr ) 3 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD3, Filter bits
: CAN0_F17DATA0_FD4 ( -- x addr ) 4 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD4, Filter bits
: CAN0_F17DATA0_FD5 ( -- x addr ) 5 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD5, Filter bits
: CAN0_F17DATA0_FD6 ( -- x addr ) 6 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD6, Filter bits
: CAN0_F17DATA0_FD7 ( -- x addr ) 7 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD7, Filter bits
: CAN0_F17DATA0_FD8 ( -- x addr ) 8 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD8, Filter bits
: CAN0_F17DATA0_FD9 ( -- x addr ) 9 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD9, Filter bits
: CAN0_F17DATA0_FD10 ( -- x addr ) 10 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD10, Filter bits
: CAN0_F17DATA0_FD11 ( -- x addr ) 11 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD11, Filter bits
: CAN0_F17DATA0_FD12 ( -- x addr ) 12 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD12, Filter bits
: CAN0_F17DATA0_FD13 ( -- x addr ) 13 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD13, Filter bits
: CAN0_F17DATA0_FD14 ( -- x addr ) 14 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD14, Filter bits
: CAN0_F17DATA0_FD15 ( -- x addr ) 15 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD15, Filter bits
: CAN0_F17DATA0_FD16 ( -- x addr ) 16 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD16, Filter bits
: CAN0_F17DATA0_FD17 ( -- x addr ) 17 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD17, Filter bits
: CAN0_F17DATA0_FD18 ( -- x addr ) 18 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD18, Filter bits
: CAN0_F17DATA0_FD19 ( -- x addr ) 19 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD19, Filter bits
: CAN0_F17DATA0_FD20 ( -- x addr ) 20 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD20, Filter bits
: CAN0_F17DATA0_FD21 ( -- x addr ) 21 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD21, Filter bits
: CAN0_F17DATA0_FD22 ( -- x addr ) 22 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD22, Filter bits
: CAN0_F17DATA0_FD23 ( -- x addr ) 23 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD23, Filter bits
: CAN0_F17DATA0_FD24 ( -- x addr ) 24 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD24, Filter bits
: CAN0_F17DATA0_FD25 ( -- x addr ) 25 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD25, Filter bits
: CAN0_F17DATA0_FD26 ( -- x addr ) 26 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD26, Filter bits
: CAN0_F17DATA0_FD27 ( -- x addr ) 27 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD27, Filter bits
: CAN0_F17DATA0_FD28 ( -- x addr ) 28 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD28, Filter bits
: CAN0_F17DATA0_FD29 ( -- x addr ) 29 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD29, Filter bits
: CAN0_F17DATA0_FD30 ( -- x addr ) 30 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD30, Filter bits
: CAN0_F17DATA0_FD31 ( -- x addr ) 31 bit CAN0_F17DATA0 ; \ CAN0_F17DATA0_FD31, Filter bits

\ CAN0_F17DATA1 (read-write) Reset:0x00000000
: CAN0_F17DATA1_FD0 ( -- x addr ) 0 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD0, Filter bits
: CAN0_F17DATA1_FD1 ( -- x addr ) 1 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD1, Filter bits
: CAN0_F17DATA1_FD2 ( -- x addr ) 2 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD2, Filter bits
: CAN0_F17DATA1_FD3 ( -- x addr ) 3 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD3, Filter bits
: CAN0_F17DATA1_FD4 ( -- x addr ) 4 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD4, Filter bits
: CAN0_F17DATA1_FD5 ( -- x addr ) 5 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD5, Filter bits
: CAN0_F17DATA1_FD6 ( -- x addr ) 6 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD6, Filter bits
: CAN0_F17DATA1_FD7 ( -- x addr ) 7 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD7, Filter bits
: CAN0_F17DATA1_FD8 ( -- x addr ) 8 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD8, Filter bits
: CAN0_F17DATA1_FD9 ( -- x addr ) 9 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD9, Filter bits
: CAN0_F17DATA1_FD10 ( -- x addr ) 10 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD10, Filter bits
: CAN0_F17DATA1_FD11 ( -- x addr ) 11 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD11, Filter bits
: CAN0_F17DATA1_FD12 ( -- x addr ) 12 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD12, Filter bits
: CAN0_F17DATA1_FD13 ( -- x addr ) 13 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD13, Filter bits
: CAN0_F17DATA1_FD14 ( -- x addr ) 14 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD14, Filter bits
: CAN0_F17DATA1_FD15 ( -- x addr ) 15 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD15, Filter bits
: CAN0_F17DATA1_FD16 ( -- x addr ) 16 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD16, Filter bits
: CAN0_F17DATA1_FD17 ( -- x addr ) 17 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD17, Filter bits
: CAN0_F17DATA1_FD18 ( -- x addr ) 18 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD18, Filter bits
: CAN0_F17DATA1_FD19 ( -- x addr ) 19 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD19, Filter bits
: CAN0_F17DATA1_FD20 ( -- x addr ) 20 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD20, Filter bits
: CAN0_F17DATA1_FD21 ( -- x addr ) 21 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD21, Filter bits
: CAN0_F17DATA1_FD22 ( -- x addr ) 22 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD22, Filter bits
: CAN0_F17DATA1_FD23 ( -- x addr ) 23 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD23, Filter bits
: CAN0_F17DATA1_FD24 ( -- x addr ) 24 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD24, Filter bits
: CAN0_F17DATA1_FD25 ( -- x addr ) 25 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD25, Filter bits
: CAN0_F17DATA1_FD26 ( -- x addr ) 26 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD26, Filter bits
: CAN0_F17DATA1_FD27 ( -- x addr ) 27 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD27, Filter bits
: CAN0_F17DATA1_FD28 ( -- x addr ) 28 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD28, Filter bits
: CAN0_F17DATA1_FD29 ( -- x addr ) 29 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD29, Filter bits
: CAN0_F17DATA1_FD30 ( -- x addr ) 30 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD30, Filter bits
: CAN0_F17DATA1_FD31 ( -- x addr ) 31 bit CAN0_F17DATA1 ; \ CAN0_F17DATA1_FD31, Filter bits

\ CAN0_F18DATA0 (read-write) Reset:0x00000000
: CAN0_F18DATA0_FD0 ( -- x addr ) 0 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD0, Filter bits
: CAN0_F18DATA0_FD1 ( -- x addr ) 1 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD1, Filter bits
: CAN0_F18DATA0_FD2 ( -- x addr ) 2 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD2, Filter bits
: CAN0_F18DATA0_FD3 ( -- x addr ) 3 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD3, Filter bits
: CAN0_F18DATA0_FD4 ( -- x addr ) 4 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD4, Filter bits
: CAN0_F18DATA0_FD5 ( -- x addr ) 5 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD5, Filter bits
: CAN0_F18DATA0_FD6 ( -- x addr ) 6 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD6, Filter bits
: CAN0_F18DATA0_FD7 ( -- x addr ) 7 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD7, Filter bits
: CAN0_F18DATA0_FD8 ( -- x addr ) 8 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD8, Filter bits
: CAN0_F18DATA0_FD9 ( -- x addr ) 9 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD9, Filter bits
: CAN0_F18DATA0_FD10 ( -- x addr ) 10 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD10, Filter bits
: CAN0_F18DATA0_FD11 ( -- x addr ) 11 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD11, Filter bits
: CAN0_F18DATA0_FD12 ( -- x addr ) 12 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD12, Filter bits
: CAN0_F18DATA0_FD13 ( -- x addr ) 13 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD13, Filter bits
: CAN0_F18DATA0_FD14 ( -- x addr ) 14 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD14, Filter bits
: CAN0_F18DATA0_FD15 ( -- x addr ) 15 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD15, Filter bits
: CAN0_F18DATA0_FD16 ( -- x addr ) 16 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD16, Filter bits
: CAN0_F18DATA0_FD17 ( -- x addr ) 17 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD17, Filter bits
: CAN0_F18DATA0_FD18 ( -- x addr ) 18 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD18, Filter bits
: CAN0_F18DATA0_FD19 ( -- x addr ) 19 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD19, Filter bits
: CAN0_F18DATA0_FD20 ( -- x addr ) 20 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD20, Filter bits
: CAN0_F18DATA0_FD21 ( -- x addr ) 21 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD21, Filter bits
: CAN0_F18DATA0_FD22 ( -- x addr ) 22 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD22, Filter bits
: CAN0_F18DATA0_FD23 ( -- x addr ) 23 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD23, Filter bits
: CAN0_F18DATA0_FD24 ( -- x addr ) 24 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD24, Filter bits
: CAN0_F18DATA0_FD25 ( -- x addr ) 25 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD25, Filter bits
: CAN0_F18DATA0_FD26 ( -- x addr ) 26 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD26, Filter bits
: CAN0_F18DATA0_FD27 ( -- x addr ) 27 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD27, Filter bits
: CAN0_F18DATA0_FD28 ( -- x addr ) 28 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD28, Filter bits
: CAN0_F18DATA0_FD29 ( -- x addr ) 29 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD29, Filter bits
: CAN0_F18DATA0_FD30 ( -- x addr ) 30 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD30, Filter bits
: CAN0_F18DATA0_FD31 ( -- x addr ) 31 bit CAN0_F18DATA0 ; \ CAN0_F18DATA0_FD31, Filter bits

\ CAN0_F18DATA1 (read-write) Reset:0x00000000
: CAN0_F18DATA1_FD0 ( -- x addr ) 0 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD0, Filter bits
: CAN0_F18DATA1_FD1 ( -- x addr ) 1 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD1, Filter bits
: CAN0_F18DATA1_FD2 ( -- x addr ) 2 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD2, Filter bits
: CAN0_F18DATA1_FD3 ( -- x addr ) 3 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD3, Filter bits
: CAN0_F18DATA1_FD4 ( -- x addr ) 4 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD4, Filter bits
: CAN0_F18DATA1_FD5 ( -- x addr ) 5 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD5, Filter bits
: CAN0_F18DATA1_FD6 ( -- x addr ) 6 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD6, Filter bits
: CAN0_F18DATA1_FD7 ( -- x addr ) 7 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD7, Filter bits
: CAN0_F18DATA1_FD8 ( -- x addr ) 8 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD8, Filter bits
: CAN0_F18DATA1_FD9 ( -- x addr ) 9 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD9, Filter bits
: CAN0_F18DATA1_FD10 ( -- x addr ) 10 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD10, Filter bits
: CAN0_F18DATA1_FD11 ( -- x addr ) 11 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD11, Filter bits
: CAN0_F18DATA1_FD12 ( -- x addr ) 12 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD12, Filter bits
: CAN0_F18DATA1_FD13 ( -- x addr ) 13 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD13, Filter bits
: CAN0_F18DATA1_FD14 ( -- x addr ) 14 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD14, Filter bits
: CAN0_F18DATA1_FD15 ( -- x addr ) 15 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD15, Filter bits
: CAN0_F18DATA1_FD16 ( -- x addr ) 16 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD16, Filter bits
: CAN0_F18DATA1_FD17 ( -- x addr ) 17 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD17, Filter bits
: CAN0_F18DATA1_FD18 ( -- x addr ) 18 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD18, Filter bits
: CAN0_F18DATA1_FD19 ( -- x addr ) 19 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD19, Filter bits
: CAN0_F18DATA1_FD20 ( -- x addr ) 20 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD20, Filter bits
: CAN0_F18DATA1_FD21 ( -- x addr ) 21 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD21, Filter bits
: CAN0_F18DATA1_FD22 ( -- x addr ) 22 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD22, Filter bits
: CAN0_F18DATA1_FD23 ( -- x addr ) 23 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD23, Filter bits
: CAN0_F18DATA1_FD24 ( -- x addr ) 24 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD24, Filter bits
: CAN0_F18DATA1_FD25 ( -- x addr ) 25 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD25, Filter bits
: CAN0_F18DATA1_FD26 ( -- x addr ) 26 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD26, Filter bits
: CAN0_F18DATA1_FD27 ( -- x addr ) 27 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD27, Filter bits
: CAN0_F18DATA1_FD28 ( -- x addr ) 28 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD28, Filter bits
: CAN0_F18DATA1_FD29 ( -- x addr ) 29 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD29, Filter bits
: CAN0_F18DATA1_FD30 ( -- x addr ) 30 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD30, Filter bits
: CAN0_F18DATA1_FD31 ( -- x addr ) 31 bit CAN0_F18DATA1 ; \ CAN0_F18DATA1_FD31, Filter bits

\ CAN0_F19DATA0 (read-write) Reset:0x00000000
: CAN0_F19DATA0_FD0 ( -- x addr ) 0 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD0, Filter bits
: CAN0_F19DATA0_FD1 ( -- x addr ) 1 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD1, Filter bits
: CAN0_F19DATA0_FD2 ( -- x addr ) 2 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD2, Filter bits
: CAN0_F19DATA0_FD3 ( -- x addr ) 3 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD3, Filter bits
: CAN0_F19DATA0_FD4 ( -- x addr ) 4 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD4, Filter bits
: CAN0_F19DATA0_FD5 ( -- x addr ) 5 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD5, Filter bits
: CAN0_F19DATA0_FD6 ( -- x addr ) 6 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD6, Filter bits
: CAN0_F19DATA0_FD7 ( -- x addr ) 7 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD7, Filter bits
: CAN0_F19DATA0_FD8 ( -- x addr ) 8 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD8, Filter bits
: CAN0_F19DATA0_FD9 ( -- x addr ) 9 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD9, Filter bits
: CAN0_F19DATA0_FD10 ( -- x addr ) 10 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD10, Filter bits
: CAN0_F19DATA0_FD11 ( -- x addr ) 11 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD11, Filter bits
: CAN0_F19DATA0_FD12 ( -- x addr ) 12 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD12, Filter bits
: CAN0_F19DATA0_FD13 ( -- x addr ) 13 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD13, Filter bits
: CAN0_F19DATA0_FD14 ( -- x addr ) 14 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD14, Filter bits
: CAN0_F19DATA0_FD15 ( -- x addr ) 15 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD15, Filter bits
: CAN0_F19DATA0_FD16 ( -- x addr ) 16 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD16, Filter bits
: CAN0_F19DATA0_FD17 ( -- x addr ) 17 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD17, Filter bits
: CAN0_F19DATA0_FD18 ( -- x addr ) 18 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD18, Filter bits
: CAN0_F19DATA0_FD19 ( -- x addr ) 19 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD19, Filter bits
: CAN0_F19DATA0_FD20 ( -- x addr ) 20 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD20, Filter bits
: CAN0_F19DATA0_FD21 ( -- x addr ) 21 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD21, Filter bits
: CAN0_F19DATA0_FD22 ( -- x addr ) 22 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD22, Filter bits
: CAN0_F19DATA0_FD23 ( -- x addr ) 23 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD23, Filter bits
: CAN0_F19DATA0_FD24 ( -- x addr ) 24 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD24, Filter bits
: CAN0_F19DATA0_FD25 ( -- x addr ) 25 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD25, Filter bits
: CAN0_F19DATA0_FD26 ( -- x addr ) 26 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD26, Filter bits
: CAN0_F19DATA0_FD27 ( -- x addr ) 27 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD27, Filter bits
: CAN0_F19DATA0_FD28 ( -- x addr ) 28 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD28, Filter bits
: CAN0_F19DATA0_FD29 ( -- x addr ) 29 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD29, Filter bits
: CAN0_F19DATA0_FD30 ( -- x addr ) 30 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD30, Filter bits
: CAN0_F19DATA0_FD31 ( -- x addr ) 31 bit CAN0_F19DATA0 ; \ CAN0_F19DATA0_FD31, Filter bits

\ CAN0_F19DATA1 (read-write) Reset:0x00000000
: CAN0_F19DATA1_FD0 ( -- x addr ) 0 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD0, Filter bits
: CAN0_F19DATA1_FD1 ( -- x addr ) 1 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD1, Filter bits
: CAN0_F19DATA1_FD2 ( -- x addr ) 2 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD2, Filter bits
: CAN0_F19DATA1_FD3 ( -- x addr ) 3 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD3, Filter bits
: CAN0_F19DATA1_FD4 ( -- x addr ) 4 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD4, Filter bits
: CAN0_F19DATA1_FD5 ( -- x addr ) 5 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD5, Filter bits
: CAN0_F19DATA1_FD6 ( -- x addr ) 6 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD6, Filter bits
: CAN0_F19DATA1_FD7 ( -- x addr ) 7 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD7, Filter bits
: CAN0_F19DATA1_FD8 ( -- x addr ) 8 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD8, Filter bits
: CAN0_F19DATA1_FD9 ( -- x addr ) 9 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD9, Filter bits
: CAN0_F19DATA1_FD10 ( -- x addr ) 10 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD10, Filter bits
: CAN0_F19DATA1_FD11 ( -- x addr ) 11 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD11, Filter bits
: CAN0_F19DATA1_FD12 ( -- x addr ) 12 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD12, Filter bits
: CAN0_F19DATA1_FD13 ( -- x addr ) 13 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD13, Filter bits
: CAN0_F19DATA1_FD14 ( -- x addr ) 14 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD14, Filter bits
: CAN0_F19DATA1_FD15 ( -- x addr ) 15 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD15, Filter bits
: CAN0_F19DATA1_FD16 ( -- x addr ) 16 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD16, Filter bits
: CAN0_F19DATA1_FD17 ( -- x addr ) 17 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD17, Filter bits
: CAN0_F19DATA1_FD18 ( -- x addr ) 18 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD18, Filter bits
: CAN0_F19DATA1_FD19 ( -- x addr ) 19 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD19, Filter bits
: CAN0_F19DATA1_FD20 ( -- x addr ) 20 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD20, Filter bits
: CAN0_F19DATA1_FD21 ( -- x addr ) 21 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD21, Filter bits
: CAN0_F19DATA1_FD22 ( -- x addr ) 22 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD22, Filter bits
: CAN0_F19DATA1_FD23 ( -- x addr ) 23 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD23, Filter bits
: CAN0_F19DATA1_FD24 ( -- x addr ) 24 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD24, Filter bits
: CAN0_F19DATA1_FD25 ( -- x addr ) 25 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD25, Filter bits
: CAN0_F19DATA1_FD26 ( -- x addr ) 26 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD26, Filter bits
: CAN0_F19DATA1_FD27 ( -- x addr ) 27 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD27, Filter bits
: CAN0_F19DATA1_FD28 ( -- x addr ) 28 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD28, Filter bits
: CAN0_F19DATA1_FD29 ( -- x addr ) 29 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD29, Filter bits
: CAN0_F19DATA1_FD30 ( -- x addr ) 30 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD30, Filter bits
: CAN0_F19DATA1_FD31 ( -- x addr ) 31 bit CAN0_F19DATA1 ; \ CAN0_F19DATA1_FD31, Filter bits

\ CAN0_F20DATA0 (read-write) Reset:0x00000000
: CAN0_F20DATA0_FD0 ( -- x addr ) 0 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD0, Filter bits
: CAN0_F20DATA0_FD1 ( -- x addr ) 1 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD1, Filter bits
: CAN0_F20DATA0_FD2 ( -- x addr ) 2 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD2, Filter bits
: CAN0_F20DATA0_FD3 ( -- x addr ) 3 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD3, Filter bits
: CAN0_F20DATA0_FD4 ( -- x addr ) 4 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD4, Filter bits
: CAN0_F20DATA0_FD5 ( -- x addr ) 5 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD5, Filter bits
: CAN0_F20DATA0_FD6 ( -- x addr ) 6 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD6, Filter bits
: CAN0_F20DATA0_FD7 ( -- x addr ) 7 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD7, Filter bits
: CAN0_F20DATA0_FD8 ( -- x addr ) 8 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD8, Filter bits
: CAN0_F20DATA0_FD9 ( -- x addr ) 9 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD9, Filter bits
: CAN0_F20DATA0_FD10 ( -- x addr ) 10 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD10, Filter bits
: CAN0_F20DATA0_FD11 ( -- x addr ) 11 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD11, Filter bits
: CAN0_F20DATA0_FD12 ( -- x addr ) 12 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD12, Filter bits
: CAN0_F20DATA0_FD13 ( -- x addr ) 13 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD13, Filter bits
: CAN0_F20DATA0_FD14 ( -- x addr ) 14 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD14, Filter bits
: CAN0_F20DATA0_FD15 ( -- x addr ) 15 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD15, Filter bits
: CAN0_F20DATA0_FD16 ( -- x addr ) 16 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD16, Filter bits
: CAN0_F20DATA0_FD17 ( -- x addr ) 17 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD17, Filter bits
: CAN0_F20DATA0_FD18 ( -- x addr ) 18 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD18, Filter bits
: CAN0_F20DATA0_FD19 ( -- x addr ) 19 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD19, Filter bits
: CAN0_F20DATA0_FD20 ( -- x addr ) 20 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD20, Filter bits
: CAN0_F20DATA0_FD21 ( -- x addr ) 21 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD21, Filter bits
: CAN0_F20DATA0_FD22 ( -- x addr ) 22 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD22, Filter bits
: CAN0_F20DATA0_FD23 ( -- x addr ) 23 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD23, Filter bits
: CAN0_F20DATA0_FD24 ( -- x addr ) 24 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD24, Filter bits
: CAN0_F20DATA0_FD25 ( -- x addr ) 25 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD25, Filter bits
: CAN0_F20DATA0_FD26 ( -- x addr ) 26 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD26, Filter bits
: CAN0_F20DATA0_FD27 ( -- x addr ) 27 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD27, Filter bits
: CAN0_F20DATA0_FD28 ( -- x addr ) 28 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD28, Filter bits
: CAN0_F20DATA0_FD29 ( -- x addr ) 29 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD29, Filter bits
: CAN0_F20DATA0_FD30 ( -- x addr ) 30 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD30, Filter bits
: CAN0_F20DATA0_FD31 ( -- x addr ) 31 bit CAN0_F20DATA0 ; \ CAN0_F20DATA0_FD31, Filter bits

\ CAN0_F20DATA1 (read-write) Reset:0x00000000
: CAN0_F20DATA1_FD0 ( -- x addr ) 0 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD0, Filter bits
: CAN0_F20DATA1_FD1 ( -- x addr ) 1 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD1, Filter bits
: CAN0_F20DATA1_FD2 ( -- x addr ) 2 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD2, Filter bits
: CAN0_F20DATA1_FD3 ( -- x addr ) 3 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD3, Filter bits
: CAN0_F20DATA1_FD4 ( -- x addr ) 4 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD4, Filter bits
: CAN0_F20DATA1_FD5 ( -- x addr ) 5 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD5, Filter bits
: CAN0_F20DATA1_FD6 ( -- x addr ) 6 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD6, Filter bits
: CAN0_F20DATA1_FD7 ( -- x addr ) 7 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD7, Filter bits
: CAN0_F20DATA1_FD8 ( -- x addr ) 8 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD8, Filter bits
: CAN0_F20DATA1_FD9 ( -- x addr ) 9 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD9, Filter bits
: CAN0_F20DATA1_FD10 ( -- x addr ) 10 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD10, Filter bits
: CAN0_F20DATA1_FD11 ( -- x addr ) 11 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD11, Filter bits
: CAN0_F20DATA1_FD12 ( -- x addr ) 12 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD12, Filter bits
: CAN0_F20DATA1_FD13 ( -- x addr ) 13 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD13, Filter bits
: CAN0_F20DATA1_FD14 ( -- x addr ) 14 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD14, Filter bits
: CAN0_F20DATA1_FD15 ( -- x addr ) 15 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD15, Filter bits
: CAN0_F20DATA1_FD16 ( -- x addr ) 16 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD16, Filter bits
: CAN0_F20DATA1_FD17 ( -- x addr ) 17 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD17, Filter bits
: CAN0_F20DATA1_FD18 ( -- x addr ) 18 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD18, Filter bits
: CAN0_F20DATA1_FD19 ( -- x addr ) 19 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD19, Filter bits
: CAN0_F20DATA1_FD20 ( -- x addr ) 20 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD20, Filter bits
: CAN0_F20DATA1_FD21 ( -- x addr ) 21 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD21, Filter bits
: CAN0_F20DATA1_FD22 ( -- x addr ) 22 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD22, Filter bits
: CAN0_F20DATA1_FD23 ( -- x addr ) 23 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD23, Filter bits
: CAN0_F20DATA1_FD24 ( -- x addr ) 24 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD24, Filter bits
: CAN0_F20DATA1_FD25 ( -- x addr ) 25 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD25, Filter bits
: CAN0_F20DATA1_FD26 ( -- x addr ) 26 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD26, Filter bits
: CAN0_F20DATA1_FD27 ( -- x addr ) 27 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD27, Filter bits
: CAN0_F20DATA1_FD28 ( -- x addr ) 28 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD28, Filter bits
: CAN0_F20DATA1_FD29 ( -- x addr ) 29 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD29, Filter bits
: CAN0_F20DATA1_FD30 ( -- x addr ) 30 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD30, Filter bits
: CAN0_F20DATA1_FD31 ( -- x addr ) 31 bit CAN0_F20DATA1 ; \ CAN0_F20DATA1_FD31, Filter bits

\ CAN0_F21DATA0 (read-write) Reset:0x00000000
: CAN0_F21DATA0_FD0 ( -- x addr ) 0 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD0, Filter bits
: CAN0_F21DATA0_FD1 ( -- x addr ) 1 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD1, Filter bits
: CAN0_F21DATA0_FD2 ( -- x addr ) 2 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD2, Filter bits
: CAN0_F21DATA0_FD3 ( -- x addr ) 3 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD3, Filter bits
: CAN0_F21DATA0_FD4 ( -- x addr ) 4 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD4, Filter bits
: CAN0_F21DATA0_FD5 ( -- x addr ) 5 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD5, Filter bits
: CAN0_F21DATA0_FD6 ( -- x addr ) 6 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD6, Filter bits
: CAN0_F21DATA0_FD7 ( -- x addr ) 7 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD7, Filter bits
: CAN0_F21DATA0_FD8 ( -- x addr ) 8 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD8, Filter bits
: CAN0_F21DATA0_FD9 ( -- x addr ) 9 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD9, Filter bits
: CAN0_F21DATA0_FD10 ( -- x addr ) 10 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD10, Filter bits
: CAN0_F21DATA0_FD11 ( -- x addr ) 11 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD11, Filter bits
: CAN0_F21DATA0_FD12 ( -- x addr ) 12 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD12, Filter bits
: CAN0_F21DATA0_FD13 ( -- x addr ) 13 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD13, Filter bits
: CAN0_F21DATA0_FD14 ( -- x addr ) 14 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD14, Filter bits
: CAN0_F21DATA0_FD15 ( -- x addr ) 15 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD15, Filter bits
: CAN0_F21DATA0_FD16 ( -- x addr ) 16 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD16, Filter bits
: CAN0_F21DATA0_FD17 ( -- x addr ) 17 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD17, Filter bits
: CAN0_F21DATA0_FD18 ( -- x addr ) 18 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD18, Filter bits
: CAN0_F21DATA0_FD19 ( -- x addr ) 19 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD19, Filter bits
: CAN0_F21DATA0_FD20 ( -- x addr ) 20 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD20, Filter bits
: CAN0_F21DATA0_FD21 ( -- x addr ) 21 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD21, Filter bits
: CAN0_F21DATA0_FD22 ( -- x addr ) 22 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD22, Filter bits
: CAN0_F21DATA0_FD23 ( -- x addr ) 23 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD23, Filter bits
: CAN0_F21DATA0_FD24 ( -- x addr ) 24 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD24, Filter bits
: CAN0_F21DATA0_FD25 ( -- x addr ) 25 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD25, Filter bits
: CAN0_F21DATA0_FD26 ( -- x addr ) 26 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD26, Filter bits
: CAN0_F21DATA0_FD27 ( -- x addr ) 27 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD27, Filter bits
: CAN0_F21DATA0_FD28 ( -- x addr ) 28 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD28, Filter bits
: CAN0_F21DATA0_FD29 ( -- x addr ) 29 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD29, Filter bits
: CAN0_F21DATA0_FD30 ( -- x addr ) 30 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD30, Filter bits
: CAN0_F21DATA0_FD31 ( -- x addr ) 31 bit CAN0_F21DATA0 ; \ CAN0_F21DATA0_FD31, Filter bits

\ CAN0_F21DATA1 (read-write) Reset:0x00000000
: CAN0_F21DATA1_FD0 ( -- x addr ) 0 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD0, Filter bits
: CAN0_F21DATA1_FD1 ( -- x addr ) 1 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD1, Filter bits
: CAN0_F21DATA1_FD2 ( -- x addr ) 2 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD2, Filter bits
: CAN0_F21DATA1_FD3 ( -- x addr ) 3 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD3, Filter bits
: CAN0_F21DATA1_FD4 ( -- x addr ) 4 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD4, Filter bits
: CAN0_F21DATA1_FD5 ( -- x addr ) 5 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD5, Filter bits
: CAN0_F21DATA1_FD6 ( -- x addr ) 6 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD6, Filter bits
: CAN0_F21DATA1_FD7 ( -- x addr ) 7 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD7, Filter bits
: CAN0_F21DATA1_FD8 ( -- x addr ) 8 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD8, Filter bits
: CAN0_F21DATA1_FD9 ( -- x addr ) 9 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD9, Filter bits
: CAN0_F21DATA1_FD10 ( -- x addr ) 10 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD10, Filter bits
: CAN0_F21DATA1_FD11 ( -- x addr ) 11 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD11, Filter bits
: CAN0_F21DATA1_FD12 ( -- x addr ) 12 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD12, Filter bits
: CAN0_F21DATA1_FD13 ( -- x addr ) 13 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD13, Filter bits
: CAN0_F21DATA1_FD14 ( -- x addr ) 14 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD14, Filter bits
: CAN0_F21DATA1_FD15 ( -- x addr ) 15 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD15, Filter bits
: CAN0_F21DATA1_FD16 ( -- x addr ) 16 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD16, Filter bits
: CAN0_F21DATA1_FD17 ( -- x addr ) 17 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD17, Filter bits
: CAN0_F21DATA1_FD18 ( -- x addr ) 18 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD18, Filter bits
: CAN0_F21DATA1_FD19 ( -- x addr ) 19 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD19, Filter bits
: CAN0_F21DATA1_FD20 ( -- x addr ) 20 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD20, Filter bits
: CAN0_F21DATA1_FD21 ( -- x addr ) 21 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD21, Filter bits
: CAN0_F21DATA1_FD22 ( -- x addr ) 22 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD22, Filter bits
: CAN0_F21DATA1_FD23 ( -- x addr ) 23 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD23, Filter bits
: CAN0_F21DATA1_FD24 ( -- x addr ) 24 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD24, Filter bits
: CAN0_F21DATA1_FD25 ( -- x addr ) 25 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD25, Filter bits
: CAN0_F21DATA1_FD26 ( -- x addr ) 26 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD26, Filter bits
: CAN0_F21DATA1_FD27 ( -- x addr ) 27 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD27, Filter bits
: CAN0_F21DATA1_FD28 ( -- x addr ) 28 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD28, Filter bits
: CAN0_F21DATA1_FD29 ( -- x addr ) 29 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD29, Filter bits
: CAN0_F21DATA1_FD30 ( -- x addr ) 30 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD30, Filter bits
: CAN0_F21DATA1_FD31 ( -- x addr ) 31 bit CAN0_F21DATA1 ; \ CAN0_F21DATA1_FD31, Filter bits

\ CAN0_F22DATA0 (read-write) Reset:0x00000000
: CAN0_F22DATA0_FD0 ( -- x addr ) 0 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD0, Filter bits
: CAN0_F22DATA0_FD1 ( -- x addr ) 1 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD1, Filter bits
: CAN0_F22DATA0_FD2 ( -- x addr ) 2 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD2, Filter bits
: CAN0_F22DATA0_FD3 ( -- x addr ) 3 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD3, Filter bits
: CAN0_F22DATA0_FD4 ( -- x addr ) 4 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD4, Filter bits
: CAN0_F22DATA0_FD5 ( -- x addr ) 5 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD5, Filter bits
: CAN0_F22DATA0_FD6 ( -- x addr ) 6 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD6, Filter bits
: CAN0_F22DATA0_FD7 ( -- x addr ) 7 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD7, Filter bits
: CAN0_F22DATA0_FD8 ( -- x addr ) 8 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD8, Filter bits
: CAN0_F22DATA0_FD9 ( -- x addr ) 9 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD9, Filter bits
: CAN0_F22DATA0_FD10 ( -- x addr ) 10 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD10, Filter bits
: CAN0_F22DATA0_FD11 ( -- x addr ) 11 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD11, Filter bits
: CAN0_F22DATA0_FD12 ( -- x addr ) 12 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD12, Filter bits
: CAN0_F22DATA0_FD13 ( -- x addr ) 13 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD13, Filter bits
: CAN0_F22DATA0_FD14 ( -- x addr ) 14 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD14, Filter bits
: CAN0_F22DATA0_FD15 ( -- x addr ) 15 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD15, Filter bits
: CAN0_F22DATA0_FD16 ( -- x addr ) 16 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD16, Filter bits
: CAN0_F22DATA0_FD17 ( -- x addr ) 17 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD17, Filter bits
: CAN0_F22DATA0_FD18 ( -- x addr ) 18 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD18, Filter bits
: CAN0_F22DATA0_FD19 ( -- x addr ) 19 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD19, Filter bits
: CAN0_F22DATA0_FD20 ( -- x addr ) 20 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD20, Filter bits
: CAN0_F22DATA0_FD21 ( -- x addr ) 21 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD21, Filter bits
: CAN0_F22DATA0_FD22 ( -- x addr ) 22 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD22, Filter bits
: CAN0_F22DATA0_FD23 ( -- x addr ) 23 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD23, Filter bits
: CAN0_F22DATA0_FD24 ( -- x addr ) 24 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD24, Filter bits
: CAN0_F22DATA0_FD25 ( -- x addr ) 25 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD25, Filter bits
: CAN0_F22DATA0_FD26 ( -- x addr ) 26 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD26, Filter bits
: CAN0_F22DATA0_FD27 ( -- x addr ) 27 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD27, Filter bits
: CAN0_F22DATA0_FD28 ( -- x addr ) 28 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD28, Filter bits
: CAN0_F22DATA0_FD29 ( -- x addr ) 29 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD29, Filter bits
: CAN0_F22DATA0_FD30 ( -- x addr ) 30 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD30, Filter bits
: CAN0_F22DATA0_FD31 ( -- x addr ) 31 bit CAN0_F22DATA0 ; \ CAN0_F22DATA0_FD31, Filter bits

\ CAN0_F22DATA1 (read-write) Reset:0x00000000
: CAN0_F22DATA1_FD0 ( -- x addr ) 0 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD0, Filter bits
: CAN0_F22DATA1_FD1 ( -- x addr ) 1 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD1, Filter bits
: CAN0_F22DATA1_FD2 ( -- x addr ) 2 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD2, Filter bits
: CAN0_F22DATA1_FD3 ( -- x addr ) 3 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD3, Filter bits
: CAN0_F22DATA1_FD4 ( -- x addr ) 4 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD4, Filter bits
: CAN0_F22DATA1_FD5 ( -- x addr ) 5 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD5, Filter bits
: CAN0_F22DATA1_FD6 ( -- x addr ) 6 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD6, Filter bits
: CAN0_F22DATA1_FD7 ( -- x addr ) 7 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD7, Filter bits
: CAN0_F22DATA1_FD8 ( -- x addr ) 8 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD8, Filter bits
: CAN0_F22DATA1_FD9 ( -- x addr ) 9 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD9, Filter bits
: CAN0_F22DATA1_FD10 ( -- x addr ) 10 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD10, Filter bits
: CAN0_F22DATA1_FD11 ( -- x addr ) 11 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD11, Filter bits
: CAN0_F22DATA1_FD12 ( -- x addr ) 12 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD12, Filter bits
: CAN0_F22DATA1_FD13 ( -- x addr ) 13 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD13, Filter bits
: CAN0_F22DATA1_FD14 ( -- x addr ) 14 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD14, Filter bits
: CAN0_F22DATA1_FD15 ( -- x addr ) 15 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD15, Filter bits
: CAN0_F22DATA1_FD16 ( -- x addr ) 16 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD16, Filter bits
: CAN0_F22DATA1_FD17 ( -- x addr ) 17 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD17, Filter bits
: CAN0_F22DATA1_FD18 ( -- x addr ) 18 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD18, Filter bits
: CAN0_F22DATA1_FD19 ( -- x addr ) 19 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD19, Filter bits
: CAN0_F22DATA1_FD20 ( -- x addr ) 20 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD20, Filter bits
: CAN0_F22DATA1_FD21 ( -- x addr ) 21 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD21, Filter bits
: CAN0_F22DATA1_FD22 ( -- x addr ) 22 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD22, Filter bits
: CAN0_F22DATA1_FD23 ( -- x addr ) 23 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD23, Filter bits
: CAN0_F22DATA1_FD24 ( -- x addr ) 24 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD24, Filter bits
: CAN0_F22DATA1_FD25 ( -- x addr ) 25 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD25, Filter bits
: CAN0_F22DATA1_FD26 ( -- x addr ) 26 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD26, Filter bits
: CAN0_F22DATA1_FD27 ( -- x addr ) 27 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD27, Filter bits
: CAN0_F22DATA1_FD28 ( -- x addr ) 28 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD28, Filter bits
: CAN0_F22DATA1_FD29 ( -- x addr ) 29 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD29, Filter bits
: CAN0_F22DATA1_FD30 ( -- x addr ) 30 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD30, Filter bits
: CAN0_F22DATA1_FD31 ( -- x addr ) 31 bit CAN0_F22DATA1 ; \ CAN0_F22DATA1_FD31, Filter bits

\ CAN0_F23DATA0 (read-write) Reset:0x00000000
: CAN0_F23DATA0_FD0 ( -- x addr ) 0 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD0, Filter bits
: CAN0_F23DATA0_FD1 ( -- x addr ) 1 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD1, Filter bits
: CAN0_F23DATA0_FD2 ( -- x addr ) 2 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD2, Filter bits
: CAN0_F23DATA0_FD3 ( -- x addr ) 3 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD3, Filter bits
: CAN0_F23DATA0_FD4 ( -- x addr ) 4 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD4, Filter bits
: CAN0_F23DATA0_FD5 ( -- x addr ) 5 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD5, Filter bits
: CAN0_F23DATA0_FD6 ( -- x addr ) 6 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD6, Filter bits
: CAN0_F23DATA0_FD7 ( -- x addr ) 7 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD7, Filter bits
: CAN0_F23DATA0_FD8 ( -- x addr ) 8 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD8, Filter bits
: CAN0_F23DATA0_FD9 ( -- x addr ) 9 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD9, Filter bits
: CAN0_F23DATA0_FD10 ( -- x addr ) 10 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD10, Filter bits
: CAN0_F23DATA0_FD11 ( -- x addr ) 11 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD11, Filter bits
: CAN0_F23DATA0_FD12 ( -- x addr ) 12 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD12, Filter bits
: CAN0_F23DATA0_FD13 ( -- x addr ) 13 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD13, Filter bits
: CAN0_F23DATA0_FD14 ( -- x addr ) 14 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD14, Filter bits
: CAN0_F23DATA0_FD15 ( -- x addr ) 15 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD15, Filter bits
: CAN0_F23DATA0_FD16 ( -- x addr ) 16 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD16, Filter bits
: CAN0_F23DATA0_FD17 ( -- x addr ) 17 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD17, Filter bits
: CAN0_F23DATA0_FD18 ( -- x addr ) 18 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD18, Filter bits
: CAN0_F23DATA0_FD19 ( -- x addr ) 19 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD19, Filter bits
: CAN0_F23DATA0_FD20 ( -- x addr ) 20 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD20, Filter bits
: CAN0_F23DATA0_FD21 ( -- x addr ) 21 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD21, Filter bits
: CAN0_F23DATA0_FD22 ( -- x addr ) 22 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD22, Filter bits
: CAN0_F23DATA0_FD23 ( -- x addr ) 23 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD23, Filter bits
: CAN0_F23DATA0_FD24 ( -- x addr ) 24 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD24, Filter bits
: CAN0_F23DATA0_FD25 ( -- x addr ) 25 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD25, Filter bits
: CAN0_F23DATA0_FD26 ( -- x addr ) 26 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD26, Filter bits
: CAN0_F23DATA0_FD27 ( -- x addr ) 27 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD27, Filter bits
: CAN0_F23DATA0_FD28 ( -- x addr ) 28 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD28, Filter bits
: CAN0_F23DATA0_FD29 ( -- x addr ) 29 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD29, Filter bits
: CAN0_F23DATA0_FD30 ( -- x addr ) 30 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD30, Filter bits
: CAN0_F23DATA0_FD31 ( -- x addr ) 31 bit CAN0_F23DATA0 ; \ CAN0_F23DATA0_FD31, Filter bits

\ CAN0_F23DATA1 (read-write) Reset:0x00000000
: CAN0_F23DATA1_FD0 ( -- x addr ) 0 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD0, Filter bits
: CAN0_F23DATA1_FD1 ( -- x addr ) 1 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD1, Filter bits
: CAN0_F23DATA1_FD2 ( -- x addr ) 2 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD2, Filter bits
: CAN0_F23DATA1_FD3 ( -- x addr ) 3 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD3, Filter bits
: CAN0_F23DATA1_FD4 ( -- x addr ) 4 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD4, Filter bits
: CAN0_F23DATA1_FD5 ( -- x addr ) 5 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD5, Filter bits
: CAN0_F23DATA1_FD6 ( -- x addr ) 6 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD6, Filter bits
: CAN0_F23DATA1_FD7 ( -- x addr ) 7 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD7, Filter bits
: CAN0_F23DATA1_FD8 ( -- x addr ) 8 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD8, Filter bits
: CAN0_F23DATA1_FD9 ( -- x addr ) 9 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD9, Filter bits
: CAN0_F23DATA1_FD10 ( -- x addr ) 10 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD10, Filter bits
: CAN0_F23DATA1_FD11 ( -- x addr ) 11 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD11, Filter bits
: CAN0_F23DATA1_FD12 ( -- x addr ) 12 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD12, Filter bits
: CAN0_F23DATA1_FD13 ( -- x addr ) 13 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD13, Filter bits
: CAN0_F23DATA1_FD14 ( -- x addr ) 14 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD14, Filter bits
: CAN0_F23DATA1_FD15 ( -- x addr ) 15 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD15, Filter bits
: CAN0_F23DATA1_FD16 ( -- x addr ) 16 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD16, Filter bits
: CAN0_F23DATA1_FD17 ( -- x addr ) 17 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD17, Filter bits
: CAN0_F23DATA1_FD18 ( -- x addr ) 18 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD18, Filter bits
: CAN0_F23DATA1_FD19 ( -- x addr ) 19 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD19, Filter bits
: CAN0_F23DATA1_FD20 ( -- x addr ) 20 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD20, Filter bits
: CAN0_F23DATA1_FD21 ( -- x addr ) 21 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD21, Filter bits
: CAN0_F23DATA1_FD22 ( -- x addr ) 22 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD22, Filter bits
: CAN0_F23DATA1_FD23 ( -- x addr ) 23 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD23, Filter bits
: CAN0_F23DATA1_FD24 ( -- x addr ) 24 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD24, Filter bits
: CAN0_F23DATA1_FD25 ( -- x addr ) 25 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD25, Filter bits
: CAN0_F23DATA1_FD26 ( -- x addr ) 26 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD26, Filter bits
: CAN0_F23DATA1_FD27 ( -- x addr ) 27 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD27, Filter bits
: CAN0_F23DATA1_FD28 ( -- x addr ) 28 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD28, Filter bits
: CAN0_F23DATA1_FD29 ( -- x addr ) 29 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD29, Filter bits
: CAN0_F23DATA1_FD30 ( -- x addr ) 30 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD30, Filter bits
: CAN0_F23DATA1_FD31 ( -- x addr ) 31 bit CAN0_F23DATA1 ; \ CAN0_F23DATA1_FD31, Filter bits

\ CAN0_F24DATA0 (read-write) Reset:0x00000000
: CAN0_F24DATA0_FD0 ( -- x addr ) 0 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD0, Filter bits
: CAN0_F24DATA0_FD1 ( -- x addr ) 1 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD1, Filter bits
: CAN0_F24DATA0_FD2 ( -- x addr ) 2 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD2, Filter bits
: CAN0_F24DATA0_FD3 ( -- x addr ) 3 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD3, Filter bits
: CAN0_F24DATA0_FD4 ( -- x addr ) 4 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD4, Filter bits
: CAN0_F24DATA0_FD5 ( -- x addr ) 5 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD5, Filter bits
: CAN0_F24DATA0_FD6 ( -- x addr ) 6 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD6, Filter bits
: CAN0_F24DATA0_FD7 ( -- x addr ) 7 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD7, Filter bits
: CAN0_F24DATA0_FD8 ( -- x addr ) 8 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD8, Filter bits
: CAN0_F24DATA0_FD9 ( -- x addr ) 9 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD9, Filter bits
: CAN0_F24DATA0_FD10 ( -- x addr ) 10 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD10, Filter bits
: CAN0_F24DATA0_FD11 ( -- x addr ) 11 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD11, Filter bits
: CAN0_F24DATA0_FD12 ( -- x addr ) 12 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD12, Filter bits
: CAN0_F24DATA0_FD13 ( -- x addr ) 13 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD13, Filter bits
: CAN0_F24DATA0_FD14 ( -- x addr ) 14 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD14, Filter bits
: CAN0_F24DATA0_FD15 ( -- x addr ) 15 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD15, Filter bits
: CAN0_F24DATA0_FD16 ( -- x addr ) 16 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD16, Filter bits
: CAN0_F24DATA0_FD17 ( -- x addr ) 17 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD17, Filter bits
: CAN0_F24DATA0_FD18 ( -- x addr ) 18 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD18, Filter bits
: CAN0_F24DATA0_FD19 ( -- x addr ) 19 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD19, Filter bits
: CAN0_F24DATA0_FD20 ( -- x addr ) 20 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD20, Filter bits
: CAN0_F24DATA0_FD21 ( -- x addr ) 21 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD21, Filter bits
: CAN0_F24DATA0_FD22 ( -- x addr ) 22 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD22, Filter bits
: CAN0_F24DATA0_FD23 ( -- x addr ) 23 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD23, Filter bits
: CAN0_F24DATA0_FD24 ( -- x addr ) 24 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD24, Filter bits
: CAN0_F24DATA0_FD25 ( -- x addr ) 25 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD25, Filter bits
: CAN0_F24DATA0_FD26 ( -- x addr ) 26 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD26, Filter bits
: CAN0_F24DATA0_FD27 ( -- x addr ) 27 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD27, Filter bits
: CAN0_F24DATA0_FD28 ( -- x addr ) 28 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD28, Filter bits
: CAN0_F24DATA0_FD29 ( -- x addr ) 29 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD29, Filter bits
: CAN0_F24DATA0_FD30 ( -- x addr ) 30 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD30, Filter bits
: CAN0_F24DATA0_FD31 ( -- x addr ) 31 bit CAN0_F24DATA0 ; \ CAN0_F24DATA0_FD31, Filter bits

\ CAN0_F24DATA1 (read-write) Reset:0x00000000
: CAN0_F24DATA1_FD0 ( -- x addr ) 0 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD0, Filter bits
: CAN0_F24DATA1_FD1 ( -- x addr ) 1 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD1, Filter bits
: CAN0_F24DATA1_FD2 ( -- x addr ) 2 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD2, Filter bits
: CAN0_F24DATA1_FD3 ( -- x addr ) 3 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD3, Filter bits
: CAN0_F24DATA1_FD4 ( -- x addr ) 4 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD4, Filter bits
: CAN0_F24DATA1_FD5 ( -- x addr ) 5 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD5, Filter bits
: CAN0_F24DATA1_FD6 ( -- x addr ) 6 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD6, Filter bits
: CAN0_F24DATA1_FD7 ( -- x addr ) 7 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD7, Filter bits
: CAN0_F24DATA1_FD8 ( -- x addr ) 8 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD8, Filter bits
: CAN0_F24DATA1_FD9 ( -- x addr ) 9 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD9, Filter bits
: CAN0_F24DATA1_FD10 ( -- x addr ) 10 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD10, Filter bits
: CAN0_F24DATA1_FD11 ( -- x addr ) 11 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD11, Filter bits
: CAN0_F24DATA1_FD12 ( -- x addr ) 12 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD12, Filter bits
: CAN0_F24DATA1_FD13 ( -- x addr ) 13 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD13, Filter bits
: CAN0_F24DATA1_FD14 ( -- x addr ) 14 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD14, Filter bits
: CAN0_F24DATA1_FD15 ( -- x addr ) 15 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD15, Filter bits
: CAN0_F24DATA1_FD16 ( -- x addr ) 16 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD16, Filter bits
: CAN0_F24DATA1_FD17 ( -- x addr ) 17 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD17, Filter bits
: CAN0_F24DATA1_FD18 ( -- x addr ) 18 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD18, Filter bits
: CAN0_F24DATA1_FD19 ( -- x addr ) 19 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD19, Filter bits
: CAN0_F24DATA1_FD20 ( -- x addr ) 20 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD20, Filter bits
: CAN0_F24DATA1_FD21 ( -- x addr ) 21 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD21, Filter bits
: CAN0_F24DATA1_FD22 ( -- x addr ) 22 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD22, Filter bits
: CAN0_F24DATA1_FD23 ( -- x addr ) 23 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD23, Filter bits
: CAN0_F24DATA1_FD24 ( -- x addr ) 24 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD24, Filter bits
: CAN0_F24DATA1_FD25 ( -- x addr ) 25 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD25, Filter bits
: CAN0_F24DATA1_FD26 ( -- x addr ) 26 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD26, Filter bits
: CAN0_F24DATA1_FD27 ( -- x addr ) 27 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD27, Filter bits
: CAN0_F24DATA1_FD28 ( -- x addr ) 28 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD28, Filter bits
: CAN0_F24DATA1_FD29 ( -- x addr ) 29 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD29, Filter bits
: CAN0_F24DATA1_FD30 ( -- x addr ) 30 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD30, Filter bits
: CAN0_F24DATA1_FD31 ( -- x addr ) 31 bit CAN0_F24DATA1 ; \ CAN0_F24DATA1_FD31, Filter bits

\ CAN0_F25DATA0 (read-write) Reset:0x00000000
: CAN0_F25DATA0_FD0 ( -- x addr ) 0 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD0, Filter bits
: CAN0_F25DATA0_FD1 ( -- x addr ) 1 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD1, Filter bits
: CAN0_F25DATA0_FD2 ( -- x addr ) 2 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD2, Filter bits
: CAN0_F25DATA0_FD3 ( -- x addr ) 3 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD3, Filter bits
: CAN0_F25DATA0_FD4 ( -- x addr ) 4 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD4, Filter bits
: CAN0_F25DATA0_FD5 ( -- x addr ) 5 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD5, Filter bits
: CAN0_F25DATA0_FD6 ( -- x addr ) 6 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD6, Filter bits
: CAN0_F25DATA0_FD7 ( -- x addr ) 7 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD7, Filter bits
: CAN0_F25DATA0_FD8 ( -- x addr ) 8 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD8, Filter bits
: CAN0_F25DATA0_FD9 ( -- x addr ) 9 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD9, Filter bits
: CAN0_F25DATA0_FD10 ( -- x addr ) 10 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD10, Filter bits
: CAN0_F25DATA0_FD11 ( -- x addr ) 11 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD11, Filter bits
: CAN0_F25DATA0_FD12 ( -- x addr ) 12 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD12, Filter bits
: CAN0_F25DATA0_FD13 ( -- x addr ) 13 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD13, Filter bits
: CAN0_F25DATA0_FD14 ( -- x addr ) 14 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD14, Filter bits
: CAN0_F25DATA0_FD15 ( -- x addr ) 15 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD15, Filter bits
: CAN0_F25DATA0_FD16 ( -- x addr ) 16 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD16, Filter bits
: CAN0_F25DATA0_FD17 ( -- x addr ) 17 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD17, Filter bits
: CAN0_F25DATA0_FD18 ( -- x addr ) 18 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD18, Filter bits
: CAN0_F25DATA0_FD19 ( -- x addr ) 19 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD19, Filter bits
: CAN0_F25DATA0_FD20 ( -- x addr ) 20 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD20, Filter bits
: CAN0_F25DATA0_FD21 ( -- x addr ) 21 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD21, Filter bits
: CAN0_F25DATA0_FD22 ( -- x addr ) 22 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD22, Filter bits
: CAN0_F25DATA0_FD23 ( -- x addr ) 23 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD23, Filter bits
: CAN0_F25DATA0_FD24 ( -- x addr ) 24 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD24, Filter bits
: CAN0_F25DATA0_FD25 ( -- x addr ) 25 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD25, Filter bits
: CAN0_F25DATA0_FD26 ( -- x addr ) 26 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD26, Filter bits
: CAN0_F25DATA0_FD27 ( -- x addr ) 27 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD27, Filter bits
: CAN0_F25DATA0_FD28 ( -- x addr ) 28 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD28, Filter bits
: CAN0_F25DATA0_FD29 ( -- x addr ) 29 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD29, Filter bits
: CAN0_F25DATA0_FD30 ( -- x addr ) 30 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD30, Filter bits
: CAN0_F25DATA0_FD31 ( -- x addr ) 31 bit CAN0_F25DATA0 ; \ CAN0_F25DATA0_FD31, Filter bits

\ CAN0_F25DATA1 (read-write) Reset:0x00000000
: CAN0_F25DATA1_FD0 ( -- x addr ) 0 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD0, Filter bits
: CAN0_F25DATA1_FD1 ( -- x addr ) 1 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD1, Filter bits
: CAN0_F25DATA1_FD2 ( -- x addr ) 2 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD2, Filter bits
: CAN0_F25DATA1_FD3 ( -- x addr ) 3 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD3, Filter bits
: CAN0_F25DATA1_FD4 ( -- x addr ) 4 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD4, Filter bits
: CAN0_F25DATA1_FD5 ( -- x addr ) 5 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD5, Filter bits
: CAN0_F25DATA1_FD6 ( -- x addr ) 6 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD6, Filter bits
: CAN0_F25DATA1_FD7 ( -- x addr ) 7 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD7, Filter bits
: CAN0_F25DATA1_FD8 ( -- x addr ) 8 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD8, Filter bits
: CAN0_F25DATA1_FD9 ( -- x addr ) 9 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD9, Filter bits
: CAN0_F25DATA1_FD10 ( -- x addr ) 10 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD10, Filter bits
: CAN0_F25DATA1_FD11 ( -- x addr ) 11 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD11, Filter bits
: CAN0_F25DATA1_FD12 ( -- x addr ) 12 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD12, Filter bits
: CAN0_F25DATA1_FD13 ( -- x addr ) 13 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD13, Filter bits
: CAN0_F25DATA1_FD14 ( -- x addr ) 14 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD14, Filter bits
: CAN0_F25DATA1_FD15 ( -- x addr ) 15 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD15, Filter bits
: CAN0_F25DATA1_FD16 ( -- x addr ) 16 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD16, Filter bits
: CAN0_F25DATA1_FD17 ( -- x addr ) 17 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD17, Filter bits
: CAN0_F25DATA1_FD18 ( -- x addr ) 18 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD18, Filter bits
: CAN0_F25DATA1_FD19 ( -- x addr ) 19 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD19, Filter bits
: CAN0_F25DATA1_FD20 ( -- x addr ) 20 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD20, Filter bits
: CAN0_F25DATA1_FD21 ( -- x addr ) 21 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD21, Filter bits
: CAN0_F25DATA1_FD22 ( -- x addr ) 22 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD22, Filter bits
: CAN0_F25DATA1_FD23 ( -- x addr ) 23 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD23, Filter bits
: CAN0_F25DATA1_FD24 ( -- x addr ) 24 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD24, Filter bits
: CAN0_F25DATA1_FD25 ( -- x addr ) 25 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD25, Filter bits
: CAN0_F25DATA1_FD26 ( -- x addr ) 26 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD26, Filter bits
: CAN0_F25DATA1_FD27 ( -- x addr ) 27 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD27, Filter bits
: CAN0_F25DATA1_FD28 ( -- x addr ) 28 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD28, Filter bits
: CAN0_F25DATA1_FD29 ( -- x addr ) 29 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD29, Filter bits
: CAN0_F25DATA1_FD30 ( -- x addr ) 30 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD30, Filter bits
: CAN0_F25DATA1_FD31 ( -- x addr ) 31 bit CAN0_F25DATA1 ; \ CAN0_F25DATA1_FD31, Filter bits

\ CAN0_F26DATA0 (read-write) Reset:0x00000000
: CAN0_F26DATA0_FD0 ( -- x addr ) 0 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD0, Filter bits
: CAN0_F26DATA0_FD1 ( -- x addr ) 1 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD1, Filter bits
: CAN0_F26DATA0_FD2 ( -- x addr ) 2 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD2, Filter bits
: CAN0_F26DATA0_FD3 ( -- x addr ) 3 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD3, Filter bits
: CAN0_F26DATA0_FD4 ( -- x addr ) 4 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD4, Filter bits
: CAN0_F26DATA0_FD5 ( -- x addr ) 5 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD5, Filter bits
: CAN0_F26DATA0_FD6 ( -- x addr ) 6 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD6, Filter bits
: CAN0_F26DATA0_FD7 ( -- x addr ) 7 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD7, Filter bits
: CAN0_F26DATA0_FD8 ( -- x addr ) 8 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD8, Filter bits
: CAN0_F26DATA0_FD9 ( -- x addr ) 9 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD9, Filter bits
: CAN0_F26DATA0_FD10 ( -- x addr ) 10 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD10, Filter bits
: CAN0_F26DATA0_FD11 ( -- x addr ) 11 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD11, Filter bits
: CAN0_F26DATA0_FD12 ( -- x addr ) 12 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD12, Filter bits
: CAN0_F26DATA0_FD13 ( -- x addr ) 13 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD13, Filter bits
: CAN0_F26DATA0_FD14 ( -- x addr ) 14 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD14, Filter bits
: CAN0_F26DATA0_FD15 ( -- x addr ) 15 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD15, Filter bits
: CAN0_F26DATA0_FD16 ( -- x addr ) 16 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD16, Filter bits
: CAN0_F26DATA0_FD17 ( -- x addr ) 17 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD17, Filter bits
: CAN0_F26DATA0_FD18 ( -- x addr ) 18 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD18, Filter bits
: CAN0_F26DATA0_FD19 ( -- x addr ) 19 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD19, Filter bits
: CAN0_F26DATA0_FD20 ( -- x addr ) 20 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD20, Filter bits
: CAN0_F26DATA0_FD21 ( -- x addr ) 21 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD21, Filter bits
: CAN0_F26DATA0_FD22 ( -- x addr ) 22 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD22, Filter bits
: CAN0_F26DATA0_FD23 ( -- x addr ) 23 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD23, Filter bits
: CAN0_F26DATA0_FD24 ( -- x addr ) 24 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD24, Filter bits
: CAN0_F26DATA0_FD25 ( -- x addr ) 25 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD25, Filter bits
: CAN0_F26DATA0_FD26 ( -- x addr ) 26 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD26, Filter bits
: CAN0_F26DATA0_FD27 ( -- x addr ) 27 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD27, Filter bits
: CAN0_F26DATA0_FD28 ( -- x addr ) 28 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD28, Filter bits
: CAN0_F26DATA0_FD29 ( -- x addr ) 29 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD29, Filter bits
: CAN0_F26DATA0_FD30 ( -- x addr ) 30 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD30, Filter bits
: CAN0_F26DATA0_FD31 ( -- x addr ) 31 bit CAN0_F26DATA0 ; \ CAN0_F26DATA0_FD31, Filter bits

\ CAN0_F26DATA1 (read-write) Reset:0x00000000
: CAN0_F26DATA1_FD0 ( -- x addr ) 0 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD0, Filter bits
: CAN0_F26DATA1_FD1 ( -- x addr ) 1 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD1, Filter bits
: CAN0_F26DATA1_FD2 ( -- x addr ) 2 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD2, Filter bits
: CAN0_F26DATA1_FD3 ( -- x addr ) 3 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD3, Filter bits
: CAN0_F26DATA1_FD4 ( -- x addr ) 4 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD4, Filter bits
: CAN0_F26DATA1_FD5 ( -- x addr ) 5 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD5, Filter bits
: CAN0_F26DATA1_FD6 ( -- x addr ) 6 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD6, Filter bits
: CAN0_F26DATA1_FD7 ( -- x addr ) 7 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD7, Filter bits
: CAN0_F26DATA1_FD8 ( -- x addr ) 8 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD8, Filter bits
: CAN0_F26DATA1_FD9 ( -- x addr ) 9 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD9, Filter bits
: CAN0_F26DATA1_FD10 ( -- x addr ) 10 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD10, Filter bits
: CAN0_F26DATA1_FD11 ( -- x addr ) 11 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD11, Filter bits
: CAN0_F26DATA1_FD12 ( -- x addr ) 12 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD12, Filter bits
: CAN0_F26DATA1_FD13 ( -- x addr ) 13 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD13, Filter bits
: CAN0_F26DATA1_FD14 ( -- x addr ) 14 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD14, Filter bits
: CAN0_F26DATA1_FD15 ( -- x addr ) 15 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD15, Filter bits
: CAN0_F26DATA1_FD16 ( -- x addr ) 16 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD16, Filter bits
: CAN0_F26DATA1_FD17 ( -- x addr ) 17 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD17, Filter bits
: CAN0_F26DATA1_FD18 ( -- x addr ) 18 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD18, Filter bits
: CAN0_F26DATA1_FD19 ( -- x addr ) 19 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD19, Filter bits
: CAN0_F26DATA1_FD20 ( -- x addr ) 20 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD20, Filter bits
: CAN0_F26DATA1_FD21 ( -- x addr ) 21 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD21, Filter bits
: CAN0_F26DATA1_FD22 ( -- x addr ) 22 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD22, Filter bits
: CAN0_F26DATA1_FD23 ( -- x addr ) 23 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD23, Filter bits
: CAN0_F26DATA1_FD24 ( -- x addr ) 24 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD24, Filter bits
: CAN0_F26DATA1_FD25 ( -- x addr ) 25 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD25, Filter bits
: CAN0_F26DATA1_FD26 ( -- x addr ) 26 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD26, Filter bits
: CAN0_F26DATA1_FD27 ( -- x addr ) 27 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD27, Filter bits
: CAN0_F26DATA1_FD28 ( -- x addr ) 28 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD28, Filter bits
: CAN0_F26DATA1_FD29 ( -- x addr ) 29 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD29, Filter bits
: CAN0_F26DATA1_FD30 ( -- x addr ) 30 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD30, Filter bits
: CAN0_F26DATA1_FD31 ( -- x addr ) 31 bit CAN0_F26DATA1 ; \ CAN0_F26DATA1_FD31, Filter bits

\ CAN0_F27DATA0 (read-write) Reset:0x00000000
: CAN0_F27DATA0_FD0 ( -- x addr ) 0 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD0, Filter bits
: CAN0_F27DATA0_FD1 ( -- x addr ) 1 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD1, Filter bits
: CAN0_F27DATA0_FD2 ( -- x addr ) 2 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD2, Filter bits
: CAN0_F27DATA0_FD3 ( -- x addr ) 3 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD3, Filter bits
: CAN0_F27DATA0_FD4 ( -- x addr ) 4 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD4, Filter bits
: CAN0_F27DATA0_FD5 ( -- x addr ) 5 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD5, Filter bits
: CAN0_F27DATA0_FD6 ( -- x addr ) 6 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD6, Filter bits
: CAN0_F27DATA0_FD7 ( -- x addr ) 7 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD7, Filter bits
: CAN0_F27DATA0_FD8 ( -- x addr ) 8 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD8, Filter bits
: CAN0_F27DATA0_FD9 ( -- x addr ) 9 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD9, Filter bits
: CAN0_F27DATA0_FD10 ( -- x addr ) 10 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD10, Filter bits
: CAN0_F27DATA0_FD11 ( -- x addr ) 11 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD11, Filter bits
: CAN0_F27DATA0_FD12 ( -- x addr ) 12 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD12, Filter bits
: CAN0_F27DATA0_FD13 ( -- x addr ) 13 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD13, Filter bits
: CAN0_F27DATA0_FD14 ( -- x addr ) 14 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD14, Filter bits
: CAN0_F27DATA0_FD15 ( -- x addr ) 15 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD15, Filter bits
: CAN0_F27DATA0_FD16 ( -- x addr ) 16 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD16, Filter bits
: CAN0_F27DATA0_FD17 ( -- x addr ) 17 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD17, Filter bits
: CAN0_F27DATA0_FD18 ( -- x addr ) 18 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD18, Filter bits
: CAN0_F27DATA0_FD19 ( -- x addr ) 19 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD19, Filter bits
: CAN0_F27DATA0_FD20 ( -- x addr ) 20 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD20, Filter bits
: CAN0_F27DATA0_FD21 ( -- x addr ) 21 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD21, Filter bits
: CAN0_F27DATA0_FD22 ( -- x addr ) 22 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD22, Filter bits
: CAN0_F27DATA0_FD23 ( -- x addr ) 23 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD23, Filter bits
: CAN0_F27DATA0_FD24 ( -- x addr ) 24 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD24, Filter bits
: CAN0_F27DATA0_FD25 ( -- x addr ) 25 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD25, Filter bits
: CAN0_F27DATA0_FD26 ( -- x addr ) 26 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD26, Filter bits
: CAN0_F27DATA0_FD27 ( -- x addr ) 27 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD27, Filter bits
: CAN0_F27DATA0_FD28 ( -- x addr ) 28 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD28, Filter bits
: CAN0_F27DATA0_FD29 ( -- x addr ) 29 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD29, Filter bits
: CAN0_F27DATA0_FD30 ( -- x addr ) 30 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD30, Filter bits
: CAN0_F27DATA0_FD31 ( -- x addr ) 31 bit CAN0_F27DATA0 ; \ CAN0_F27DATA0_FD31, Filter bits

\ CAN0_F27DATA1 (read-write) Reset:0x00000000
: CAN0_F27DATA1_FD0 ( -- x addr ) 0 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD0, Filter bits
: CAN0_F27DATA1_FD1 ( -- x addr ) 1 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD1, Filter bits
: CAN0_F27DATA1_FD2 ( -- x addr ) 2 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD2, Filter bits
: CAN0_F27DATA1_FD3 ( -- x addr ) 3 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD3, Filter bits
: CAN0_F27DATA1_FD4 ( -- x addr ) 4 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD4, Filter bits
: CAN0_F27DATA1_FD5 ( -- x addr ) 5 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD5, Filter bits
: CAN0_F27DATA1_FD6 ( -- x addr ) 6 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD6, Filter bits
: CAN0_F27DATA1_FD7 ( -- x addr ) 7 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD7, Filter bits
: CAN0_F27DATA1_FD8 ( -- x addr ) 8 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD8, Filter bits
: CAN0_F27DATA1_FD9 ( -- x addr ) 9 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD9, Filter bits
: CAN0_F27DATA1_FD10 ( -- x addr ) 10 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD10, Filter bits
: CAN0_F27DATA1_FD11 ( -- x addr ) 11 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD11, Filter bits
: CAN0_F27DATA1_FD12 ( -- x addr ) 12 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD12, Filter bits
: CAN0_F27DATA1_FD13 ( -- x addr ) 13 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD13, Filter bits
: CAN0_F27DATA1_FD14 ( -- x addr ) 14 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD14, Filter bits
: CAN0_F27DATA1_FD15 ( -- x addr ) 15 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD15, Filter bits
: CAN0_F27DATA1_FD16 ( -- x addr ) 16 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD16, Filter bits
: CAN0_F27DATA1_FD17 ( -- x addr ) 17 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD17, Filter bits
: CAN0_F27DATA1_FD18 ( -- x addr ) 18 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD18, Filter bits
: CAN0_F27DATA1_FD19 ( -- x addr ) 19 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD19, Filter bits
: CAN0_F27DATA1_FD20 ( -- x addr ) 20 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD20, Filter bits
: CAN0_F27DATA1_FD21 ( -- x addr ) 21 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD21, Filter bits
: CAN0_F27DATA1_FD22 ( -- x addr ) 22 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD22, Filter bits
: CAN0_F27DATA1_FD23 ( -- x addr ) 23 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD23, Filter bits
: CAN0_F27DATA1_FD24 ( -- x addr ) 24 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD24, Filter bits
: CAN0_F27DATA1_FD25 ( -- x addr ) 25 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD25, Filter bits
: CAN0_F27DATA1_FD26 ( -- x addr ) 26 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD26, Filter bits
: CAN0_F27DATA1_FD27 ( -- x addr ) 27 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD27, Filter bits
: CAN0_F27DATA1_FD28 ( -- x addr ) 28 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD28, Filter bits
: CAN0_F27DATA1_FD29 ( -- x addr ) 29 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD29, Filter bits
: CAN0_F27DATA1_FD30 ( -- x addr ) 30 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD30, Filter bits
: CAN0_F27DATA1_FD31 ( -- x addr ) 31 bit CAN0_F27DATA1 ; \ CAN0_F27DATA1_FD31, Filter bits

\ CAN1_CTL (read-write) Reset:0x00010002
: CAN1_CTL_DFZ ( -- x addr ) 16 bit CAN1_CTL ; \ CAN1_CTL_DFZ, Debug freeze
: CAN1_CTL_SWRST ( -- x addr ) 15 bit CAN1_CTL ; \ CAN1_CTL_SWRST, Software reset
: CAN1_CTL_TTC ( -- x addr ) 7 bit CAN1_CTL ; \ CAN1_CTL_TTC, Time-triggered communication
: CAN1_CTL_ABOR ( -- x addr ) 6 bit CAN1_CTL ; \ CAN1_CTL_ABOR, Automatic bus-off recovery
: CAN1_CTL_AWU ( -- x addr ) 5 bit CAN1_CTL ; \ CAN1_CTL_AWU, Automatic wakeup
: CAN1_CTL_ARD ( -- x addr ) 4 bit CAN1_CTL ; \ CAN1_CTL_ARD, Automatic retransmission disable
: CAN1_CTL_RFOD ( -- x addr ) 3 bit CAN1_CTL ; \ CAN1_CTL_RFOD, Receive FIFO overwrite disable
: CAN1_CTL_TFO ( -- x addr ) 2 bit CAN1_CTL ; \ CAN1_CTL_TFO, Transmit FIFO order
: CAN1_CTL_SLPWMOD ( -- x addr ) 1 bit CAN1_CTL ; \ CAN1_CTL_SLPWMOD, Sleep working mode
: CAN1_CTL_IWMOD ( -- x addr ) 0 bit CAN1_CTL ; \ CAN1_CTL_IWMOD, Initial working mode

\ CAN1_STAT (multiple-access)  Reset:0x00000C02
: CAN1_STAT_RXL ( -- x addr ) 11 bit CAN1_STAT ; \ CAN1_STAT_RXL, RX level
: CAN1_STAT_LASTRX ( -- x addr ) 10 bit CAN1_STAT ; \ CAN1_STAT_LASTRX, Last sample value of RX pin
: CAN1_STAT_RS ( -- x addr ) 9 bit CAN1_STAT ; \ CAN1_STAT_RS, Receiving state
: CAN1_STAT_TS ( -- x addr ) 8 bit CAN1_STAT ; \ CAN1_STAT_TS, Transmitting state
: CAN1_STAT_SLPIF? ( -- 1|0 ) 4 bit CAN1_STAT bit@ ; \ CAN1_STAT_SLPIF, Status change interrupt flag of sleep  	 working mode entering
: CAN1_STAT_WUIF? ( -- 1|0 ) 3 bit CAN1_STAT bit@ ; \ CAN1_STAT_WUIF, Status change interrupt flag of wakeup  	 from sleep working mode
: CAN1_STAT_ERRIF? ( -- 1|0 ) 2 bit CAN1_STAT bit@ ; \ CAN1_STAT_ERRIF, Error interrupt flag
: CAN1_STAT_SLPWS ( -- x addr ) 1 bit CAN1_STAT ; \ CAN1_STAT_SLPWS, Sleep working state
: CAN1_STAT_IWS ( -- x addr ) 0 bit CAN1_STAT ; \ CAN1_STAT_IWS, Initial working state

\ CAN1_TSTAT (multiple-access)  Reset:0x1C000000
: CAN1_TSTAT_TMLS2 ( -- x addr ) 31 bit CAN1_TSTAT ; \ CAN1_TSTAT_TMLS2, Transmit mailbox 2 last sending  	 in transmit FIFO
: CAN1_TSTAT_TMLS1 ( -- x addr ) 30 bit CAN1_TSTAT ; \ CAN1_TSTAT_TMLS1, Transmit mailbox 1 last sending  	 in transmit FIFO
: CAN1_TSTAT_TMLS0 ( -- x addr ) 29 bit CAN1_TSTAT ; \ CAN1_TSTAT_TMLS0, Transmit mailbox 0 last sending  	 in transmit FIFO
: CAN1_TSTAT_TME2 ( -- x addr ) 28 bit CAN1_TSTAT ; \ CAN1_TSTAT_TME2, Transmit mailbox 2 empty
: CAN1_TSTAT_TME1 ( -- x addr ) 27 bit CAN1_TSTAT ; \ CAN1_TSTAT_TME1, Transmit mailbox 1 empty
: CAN1_TSTAT_TME0 ( -- x addr ) 26 bit CAN1_TSTAT ; \ CAN1_TSTAT_TME0, Transmit mailbox 0 empty
: CAN1_TSTAT_NUM ( %bb -- x addr ) 24 lshift CAN1_TSTAT ; \ CAN1_TSTAT_NUM, number of the transmit FIFO mailbox in  	 which the frame will be transmitted if at least one mailbox is empty
: CAN1_TSTAT_MST2 ( -- x addr ) 23 bit CAN1_TSTAT ; \ CAN1_TSTAT_MST2, Mailbox 2 stop transmitting
: CAN1_TSTAT_MTE2 ( -- x addr ) 19 bit CAN1_TSTAT ; \ CAN1_TSTAT_MTE2, Mailbox 2 transmit error
: CAN1_TSTAT_MAL2 ( -- x addr ) 18 bit CAN1_TSTAT ; \ CAN1_TSTAT_MAL2, Mailbox 2 arbitration lost
: CAN1_TSTAT_MTFNERR2 ( -- x addr ) 17 bit CAN1_TSTAT ; \ CAN1_TSTAT_MTFNERR2, Mailbox 2 transmit finished and no error
: CAN1_TSTAT_MTF2 ( -- x addr ) 16 bit CAN1_TSTAT ; \ CAN1_TSTAT_MTF2, Mailbox 2 transmit finished
: CAN1_TSTAT_MST1 ( -- x addr ) 15 bit CAN1_TSTAT ; \ CAN1_TSTAT_MST1, Mailbox 1 stop transmitting
: CAN1_TSTAT_MTE1 ( -- x addr ) 11 bit CAN1_TSTAT ; \ CAN1_TSTAT_MTE1, Mailbox 1 transmit error
: CAN1_TSTAT_MAL1 ( -- x addr ) 10 bit CAN1_TSTAT ; \ CAN1_TSTAT_MAL1, Mailbox 1 arbitration lost
: CAN1_TSTAT_MTFNERR1 ( -- x addr ) 9 bit CAN1_TSTAT ; \ CAN1_TSTAT_MTFNERR1, Mailbox 1 transmit finished and no error
: CAN1_TSTAT_MTF1 ( -- x addr ) 8 bit CAN1_TSTAT ; \ CAN1_TSTAT_MTF1, Mailbox 1 transmit finished
: CAN1_TSTAT_MST0 ( -- x addr ) 7 bit CAN1_TSTAT ; \ CAN1_TSTAT_MST0, Mailbox 0 stop transmitting
: CAN1_TSTAT_MTE0 ( -- x addr ) 3 bit CAN1_TSTAT ; \ CAN1_TSTAT_MTE0, Mailbox 0 transmit error
: CAN1_TSTAT_MAL0 ( -- x addr ) 2 bit CAN1_TSTAT ; \ CAN1_TSTAT_MAL0, Mailbox 0 arbitration lost
: CAN1_TSTAT_MTFNERR0 ( -- x addr ) 1 bit CAN1_TSTAT ; \ CAN1_TSTAT_MTFNERR0, Mailbox 0 transmit finished and no error
: CAN1_TSTAT_MTF0 ( -- x addr ) 0 bit CAN1_TSTAT ; \ CAN1_TSTAT_MTF0, Mailbox 0 transmit finished

\ CAN1_RFIFO0 (multiple-access)  Reset:0x00000000
: CAN1_RFIFO0_RFD0 ( -- x addr ) 5 bit CAN1_RFIFO0 ; \ CAN1_RFIFO0_RFD0, Receive FIFO0 dequeue
: CAN1_RFIFO0_RFO0 ( -- x addr ) 4 bit CAN1_RFIFO0 ; \ CAN1_RFIFO0_RFO0, Receive FIFO0 overfull
: CAN1_RFIFO0_RFF0 ( -- x addr ) 3 bit CAN1_RFIFO0 ; \ CAN1_RFIFO0_RFF0, Receive FIFO0 full
: CAN1_RFIFO0_RFL0 ( %bb -- x addr ) CAN1_RFIFO0 ; \ CAN1_RFIFO0_RFL0, Receive FIFO0 length

\ CAN1_RFIFO1 (multiple-access)  Reset:0x00000000
: CAN1_RFIFO1_RFD1 ( -- x addr ) 5 bit CAN1_RFIFO1 ; \ CAN1_RFIFO1_RFD1, Receive FIFO1 dequeue
: CAN1_RFIFO1_RFO1 ( -- x addr ) 4 bit CAN1_RFIFO1 ; \ CAN1_RFIFO1_RFO1, Receive FIFO1 overfull
: CAN1_RFIFO1_RFF1 ( -- x addr ) 3 bit CAN1_RFIFO1 ; \ CAN1_RFIFO1_RFF1, Receive FIFO1 full
: CAN1_RFIFO1_RFL1 ( %bb -- x addr ) CAN1_RFIFO1 ; \ CAN1_RFIFO1_RFL1, Receive FIFO1 length

\ CAN1_INTEN (read-write) Reset:0x00000000
: CAN1_INTEN_SLPWIE ( -- x addr ) 17 bit CAN1_INTEN ; \ CAN1_INTEN_SLPWIE, Sleep working interrupt enable
: CAN1_INTEN_WIE ( -- x addr ) 16 bit CAN1_INTEN ; \ CAN1_INTEN_WIE, Wakeup interrupt enable
: CAN1_INTEN_ERRIE ( -- x addr ) 15 bit CAN1_INTEN ; \ CAN1_INTEN_ERRIE, Error interrupt enable
: CAN1_INTEN_ERRNIE ( -- x addr ) 11 bit CAN1_INTEN ; \ CAN1_INTEN_ERRNIE, Error number interrupt enable
: CAN1_INTEN_BOIE ( -- x addr ) 10 bit CAN1_INTEN ; \ CAN1_INTEN_BOIE, Bus-off interrupt enable
: CAN1_INTEN_PERRIE ( -- x addr ) 9 bit CAN1_INTEN ; \ CAN1_INTEN_PERRIE, Passive error interrupt enable
: CAN1_INTEN_WERRIE ( -- x addr ) 8 bit CAN1_INTEN ; \ CAN1_INTEN_WERRIE, Warning error interrupt enable
: CAN1_INTEN_RFOIE1 ( -- x addr ) 6 bit CAN1_INTEN ; \ CAN1_INTEN_RFOIE1, Receive FIFO1 overfull interrupt enable
: CAN1_INTEN_RFFIE1 ( -- x addr ) 5 bit CAN1_INTEN ; \ CAN1_INTEN_RFFIE1, Receive FIFO1 full interrupt enable
: CAN1_INTEN_RFNEIE1 ( -- x addr ) 4 bit CAN1_INTEN ; \ CAN1_INTEN_RFNEIE1, Receive FIFO1 not empty interrupt enable
: CAN1_INTEN_RFOIE0 ( -- x addr ) 3 bit CAN1_INTEN ; \ CAN1_INTEN_RFOIE0, Receive FIFO0 overfull interrupt enable
: CAN1_INTEN_RFFIE0 ( -- x addr ) 2 bit CAN1_INTEN ; \ CAN1_INTEN_RFFIE0, Receive FIFO0 full interrupt enable
: CAN1_INTEN_RFNEIE0 ( -- x addr ) 1 bit CAN1_INTEN ; \ CAN1_INTEN_RFNEIE0, Receive FIFO0 not empty interrupt enable
: CAN1_INTEN_TMEIE ( -- x addr ) 0 bit CAN1_INTEN ; \ CAN1_INTEN_TMEIE, Transmit mailbox empty interrupt enable

\ CAN1_ERR (multiple-access)  Reset:0x00000000
: CAN1_ERR_RECNT ( %bbbbbbbb -- x addr ) 24 lshift CAN1_ERR ; \ CAN1_ERR_RECNT, Receive Error Count defined  	 by the CAN standard
: CAN1_ERR_TECNT ( %bbbbbbbb -- x addr ) 16 lshift CAN1_ERR ; \ CAN1_ERR_TECNT, Transmit Error Count defined  	 by the CAN standard
: CAN1_ERR_ERRN ( %bbb -- x addr ) 4 lshift CAN1_ERR ; \ CAN1_ERR_ERRN, Error number
: CAN1_ERR_BOERR ( -- x addr ) 2 bit CAN1_ERR ; \ CAN1_ERR_BOERR, Bus-off error
: CAN1_ERR_PERR ( -- x addr ) 1 bit CAN1_ERR ; \ CAN1_ERR_PERR, Passive error
: CAN1_ERR_WERR ( -- x addr ) 0 bit CAN1_ERR ; \ CAN1_ERR_WERR, Warning error

\ CAN1_BT (read-write) Reset:0x01230000
: CAN1_BT_SCMOD ( -- x addr ) 31 bit CAN1_BT ; \ CAN1_BT_SCMOD, Silent communication mode
: CAN1_BT_LCMOD ( -- x addr ) 30 bit CAN1_BT ; \ CAN1_BT_LCMOD, Loopback communication mode
: CAN1_BT_SJW ( %bb -- x addr ) 24 lshift CAN1_BT ; \ CAN1_BT_SJW, Resynchronization jump width
: CAN1_BT_BS2 ( %bbb -- x addr ) 20 lshift CAN1_BT ; \ CAN1_BT_BS2, Bit segment 2
: CAN1_BT_BS1 ( %bbbb -- x addr ) 16 lshift CAN1_BT ; \ CAN1_BT_BS1, Bit segment 1
: CAN1_BT_BAUDPSC ( %bbbbbbbbbb -- x addr ) CAN1_BT ; \ CAN1_BT_BAUDPSC, Baud rate prescaler

\ CAN1_TMI0 (read-write) Reset:0x00000000
: CAN1_TMI0_SFID_EFID x addr ) 21 lshift CAN1_TMI0 ; \ CAN1_TMI0_SFID_EFID, The frame identifier
: CAN1_TMI0_EFID x addr ) 3 lshift CAN1_TMI0 ; \ CAN1_TMI0_EFID, The frame identifier
: CAN1_TMI0_FF ( -- x addr ) 2 bit CAN1_TMI0 ; \ CAN1_TMI0_FF, Frame format
: CAN1_TMI0_FT ( -- x addr ) 1 bit CAN1_TMI0 ; \ CAN1_TMI0_FT, Frame type
: CAN1_TMI0_TEN ( -- x addr ) 0 bit CAN1_TMI0 ; \ CAN1_TMI0_TEN, Transmit enable

\ CAN1_TMP0 (read-write) Reset:0x00000000
: CAN1_TMP0_TS ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift CAN1_TMP0 ; \ CAN1_TMP0_TS, Time stamp
: CAN1_TMP0_TSEN ( -- x addr ) 8 bit CAN1_TMP0 ; \ CAN1_TMP0_TSEN, Time stamp enable
: CAN1_TMP0_DLENC ( %bbbb -- x addr ) CAN1_TMP0 ; \ CAN1_TMP0_DLENC, Data length code

\ CAN1_TMDATA00 (read-write) Reset:0x00000000
: CAN1_TMDATA00_DB3 ( %bbbbbbbb -- x addr ) 24 lshift CAN1_TMDATA00 ; \ CAN1_TMDATA00_DB3, Data byte 3
: CAN1_TMDATA00_DB2 ( %bbbbbbbb -- x addr ) 16 lshift CAN1_TMDATA00 ; \ CAN1_TMDATA00_DB2, Data byte 2
: CAN1_TMDATA00_DB1 ( %bbbbbbbb -- x addr ) 8 lshift CAN1_TMDATA00 ; \ CAN1_TMDATA00_DB1, Data byte 1
: CAN1_TMDATA00_DB0 ( %bbbbbbbb -- x addr ) CAN1_TMDATA00 ; \ CAN1_TMDATA00_DB0, Data byte 0

\ CAN1_TMDATA10 (read-write) Reset:0x00000000
: CAN1_TMDATA10_DB7 ( %bbbbbbbb -- x addr ) 24 lshift CAN1_TMDATA10 ; \ CAN1_TMDATA10_DB7, Data byte 7
: CAN1_TMDATA10_DB6 ( %bbbbbbbb -- x addr ) 16 lshift CAN1_TMDATA10 ; \ CAN1_TMDATA10_DB6, Data byte 6
: CAN1_TMDATA10_DB5 ( %bbbbbbbb -- x addr ) 8 lshift CAN1_TMDATA10 ; \ CAN1_TMDATA10_DB5, Data byte 5
: CAN1_TMDATA10_DB4 ( %bbbbbbbb -- x addr ) CAN1_TMDATA10 ; \ CAN1_TMDATA10_DB4, Data byte 4

\ CAN1_TMI1 (read-write) Reset:0x00000000
: CAN1_TMI1_SFID_EFID x addr ) 21 lshift CAN1_TMI1 ; \ CAN1_TMI1_SFID_EFID, The frame identifier
: CAN1_TMI1_EFID x addr ) 3 lshift CAN1_TMI1 ; \ CAN1_TMI1_EFID, The frame identifier
: CAN1_TMI1_FF ( -- x addr ) 2 bit CAN1_TMI1 ; \ CAN1_TMI1_FF, Frame format
: CAN1_TMI1_FT ( -- x addr ) 1 bit CAN1_TMI1 ; \ CAN1_TMI1_FT, Frame type
: CAN1_TMI1_TEN ( -- x addr ) 0 bit CAN1_TMI1 ; \ CAN1_TMI1_TEN, Transmit enable

\ CAN1_TMP1 (read-write) Reset:0x00000000
: CAN1_TMP1_TS ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift CAN1_TMP1 ; \ CAN1_TMP1_TS, Time stamp
: CAN1_TMP1_TSEN ( -- x addr ) 8 bit CAN1_TMP1 ; \ CAN1_TMP1_TSEN, Time stamp enable
: CAN1_TMP1_DLENC ( %bbbb -- x addr ) CAN1_TMP1 ; \ CAN1_TMP1_DLENC, Data length code

\ CAN1_TMDATA01 (read-write) Reset:0x00000000
: CAN1_TMDATA01_DB3 ( %bbbbbbbb -- x addr ) 24 lshift CAN1_TMDATA01 ; \ CAN1_TMDATA01_DB3, Data byte 3
: CAN1_TMDATA01_DB2 ( %bbbbbbbb -- x addr ) 16 lshift CAN1_TMDATA01 ; \ CAN1_TMDATA01_DB2, Data byte 2
: CAN1_TMDATA01_DB1 ( %bbbbbbbb -- x addr ) 8 lshift CAN1_TMDATA01 ; \ CAN1_TMDATA01_DB1, Data byte 1
: CAN1_TMDATA01_DB0 ( %bbbbbbbb -- x addr ) CAN1_TMDATA01 ; \ CAN1_TMDATA01_DB0, Data byte 0

\ CAN1_TMDATA11 (read-write) Reset:0x00000000
: CAN1_TMDATA11_DB7 ( %bbbbbbbb -- x addr ) 24 lshift CAN1_TMDATA11 ; \ CAN1_TMDATA11_DB7, Data byte 7
: CAN1_TMDATA11_DB6 ( %bbbbbbbb -- x addr ) 16 lshift CAN1_TMDATA11 ; \ CAN1_TMDATA11_DB6, Data byte 6
: CAN1_TMDATA11_DB5 ( %bbbbbbbb -- x addr ) 8 lshift CAN1_TMDATA11 ; \ CAN1_TMDATA11_DB5, Data byte 5
: CAN1_TMDATA11_DB4 ( %bbbbbbbb -- x addr ) CAN1_TMDATA11 ; \ CAN1_TMDATA11_DB4, Data byte 4

\ CAN1_TMI2 (read-write) Reset:0x00000000
: CAN1_TMI2_SFID_EFID x addr ) 21 lshift CAN1_TMI2 ; \ CAN1_TMI2_SFID_EFID, The frame identifier
: CAN1_TMI2_EFID x addr ) 3 lshift CAN1_TMI2 ; \ CAN1_TMI2_EFID, The frame identifier
: CAN1_TMI2_FF ( -- x addr ) 2 bit CAN1_TMI2 ; \ CAN1_TMI2_FF, Frame format
: CAN1_TMI2_FT ( -- x addr ) 1 bit CAN1_TMI2 ; \ CAN1_TMI2_FT, Frame type
: CAN1_TMI2_TEN ( -- x addr ) 0 bit CAN1_TMI2 ; \ CAN1_TMI2_TEN, Transmit enable

\ CAN1_TMP2 (read-write) Reset:0x00000000
: CAN1_TMP2_TS ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift CAN1_TMP2 ; \ CAN1_TMP2_TS, Time stamp
: CAN1_TMP2_TSEN ( -- x addr ) 8 bit CAN1_TMP2 ; \ CAN1_TMP2_TSEN, Time stamp enable
: CAN1_TMP2_DLENC ( %bbbb -- x addr ) CAN1_TMP2 ; \ CAN1_TMP2_DLENC, Data length code

\ CAN1_TMDATA02 (read-write) Reset:0x00000000
: CAN1_TMDATA02_DB3 ( %bbbbbbbb -- x addr ) 24 lshift CAN1_TMDATA02 ; \ CAN1_TMDATA02_DB3, Data byte 3
: CAN1_TMDATA02_DB2 ( %bbbbbbbb -- x addr ) 16 lshift CAN1_TMDATA02 ; \ CAN1_TMDATA02_DB2, Data byte 2
: CAN1_TMDATA02_DB1 ( %bbbbbbbb -- x addr ) 8 lshift CAN1_TMDATA02 ; \ CAN1_TMDATA02_DB1, Data byte 1
: CAN1_TMDATA02_DB0 ( %bbbbbbbb -- x addr ) CAN1_TMDATA02 ; \ CAN1_TMDATA02_DB0, Data byte 0

\ CAN1_TMDATA12 (read-write) Reset:0x00000000
: CAN1_TMDATA12_DB7 ( %bbbbbbbb -- x addr ) 24 lshift CAN1_TMDATA12 ; \ CAN1_TMDATA12_DB7, Data byte 7
: CAN1_TMDATA12_DB6 ( %bbbbbbbb -- x addr ) 16 lshift CAN1_TMDATA12 ; \ CAN1_TMDATA12_DB6, Data byte 6
: CAN1_TMDATA12_DB5 ( %bbbbbbbb -- x addr ) 8 lshift CAN1_TMDATA12 ; \ CAN1_TMDATA12_DB5, Data byte 5
: CAN1_TMDATA12_DB4 ( %bbbbbbbb -- x addr ) CAN1_TMDATA12 ; \ CAN1_TMDATA12_DB4, Data byte 4

\ CAN1_RFIFOMI0 (read-only) Reset:0x00000000
: CAN1_RFIFOMI0_SFID_EFID? ( --  x ) 21 lshift CAN1_RFIFOMI0 @ ; \ CAN1_RFIFOMI0_SFID_EFID, The frame identifier
: CAN1_RFIFOMI0_EFID? ( --  x ) 3 lshift CAN1_RFIFOMI0 @ ; \ CAN1_RFIFOMI0_EFID, The frame identifier
: CAN1_RFIFOMI0_FF? ( --  1|0 ) 2 bit CAN1_RFIFOMI0 bit@ ; \ CAN1_RFIFOMI0_FF, Frame format
: CAN1_RFIFOMI0_FT? ( --  1|0 ) 1 bit CAN1_RFIFOMI0 bit@ ; \ CAN1_RFIFOMI0_FT, Frame type

\ CAN1_RFIFOMP0 (read-only) Reset:0x00000000
: CAN1_RFIFOMP0_TS? ( --  x ) 16 lshift CAN1_RFIFOMP0 @ ; \ CAN1_RFIFOMP0_TS, Time stamp
: CAN1_RFIFOMP0_FI? ( --  x ) 8 lshift CAN1_RFIFOMP0 @ ; \ CAN1_RFIFOMP0_FI, Filtering index
: CAN1_RFIFOMP0_DLENC? ( --  x ) CAN1_RFIFOMP0 @ ; \ CAN1_RFIFOMP0_DLENC, Data length code

\ CAN1_RFIFOMDATA00 (read-only) Reset:0x00000000
: CAN1_RFIFOMDATA00_DB3? ( --  x ) 24 lshift CAN1_RFIFOMDATA00 @ ; \ CAN1_RFIFOMDATA00_DB3, Data byte 3
: CAN1_RFIFOMDATA00_DB2? ( --  x ) 16 lshift CAN1_RFIFOMDATA00 @ ; \ CAN1_RFIFOMDATA00_DB2, Data byte 2
: CAN1_RFIFOMDATA00_DB1? ( --  x ) 8 lshift CAN1_RFIFOMDATA00 @ ; \ CAN1_RFIFOMDATA00_DB1, Data byte 1
: CAN1_RFIFOMDATA00_DB0? ( --  x ) CAN1_RFIFOMDATA00 @ ; \ CAN1_RFIFOMDATA00_DB0, Data byte 0

\ CAN1_RFIFOMDATA10 (read-only) Reset:0x00000000
: CAN1_RFIFOMDATA10_DB7? ( --  x ) 24 lshift CAN1_RFIFOMDATA10 @ ; \ CAN1_RFIFOMDATA10_DB7, Data byte 7
: CAN1_RFIFOMDATA10_DB6? ( --  x ) 16 lshift CAN1_RFIFOMDATA10 @ ; \ CAN1_RFIFOMDATA10_DB6, Data byte 6
: CAN1_RFIFOMDATA10_DB5? ( --  x ) 8 lshift CAN1_RFIFOMDATA10 @ ; \ CAN1_RFIFOMDATA10_DB5, Data byte 5
: CAN1_RFIFOMDATA10_DB4? ( --  x ) CAN1_RFIFOMDATA10 @ ; \ CAN1_RFIFOMDATA10_DB4, Data byte 4

\ CAN1_RFIFOMI1 (read-only) Reset:0x00000000
: CAN1_RFIFOMI1_SFID_EFID? ( --  x ) 21 lshift CAN1_RFIFOMI1 @ ; \ CAN1_RFIFOMI1_SFID_EFID, The frame identifier
: CAN1_RFIFOMI1_EFID? ( --  x ) 3 lshift CAN1_RFIFOMI1 @ ; \ CAN1_RFIFOMI1_EFID, The frame identifier
: CAN1_RFIFOMI1_FF? ( --  1|0 ) 2 bit CAN1_RFIFOMI1 bit@ ; \ CAN1_RFIFOMI1_FF, Frame format
: CAN1_RFIFOMI1_FT? ( --  1|0 ) 1 bit CAN1_RFIFOMI1 bit@ ; \ CAN1_RFIFOMI1_FT, Frame type

\ CAN1_RFIFOMP1 (read-only) Reset:0x00000000
: CAN1_RFIFOMP1_TS? ( --  x ) 16 lshift CAN1_RFIFOMP1 @ ; \ CAN1_RFIFOMP1_TS, Time stamp
: CAN1_RFIFOMP1_FI? ( --  x ) 8 lshift CAN1_RFIFOMP1 @ ; \ CAN1_RFIFOMP1_FI, Filtering index
: CAN1_RFIFOMP1_DLENC? ( --  x ) CAN1_RFIFOMP1 @ ; \ CAN1_RFIFOMP1_DLENC, Data length code

\ CAN1_RFIFOMDATA01 (read-only) Reset:0x00000000
: CAN1_RFIFOMDATA01_DB3? ( --  x ) 24 lshift CAN1_RFIFOMDATA01 @ ; \ CAN1_RFIFOMDATA01_DB3, Data byte 3
: CAN1_RFIFOMDATA01_DB2? ( --  x ) 16 lshift CAN1_RFIFOMDATA01 @ ; \ CAN1_RFIFOMDATA01_DB2, Data byte 2
: CAN1_RFIFOMDATA01_DB1? ( --  x ) 8 lshift CAN1_RFIFOMDATA01 @ ; \ CAN1_RFIFOMDATA01_DB1, Data byte 1
: CAN1_RFIFOMDATA01_DB0? ( --  x ) CAN1_RFIFOMDATA01 @ ; \ CAN1_RFIFOMDATA01_DB0, Data byte 0

\ CAN1_RFIFOMDATA11 (read-only) Reset:0x00000000
: CAN1_RFIFOMDATA11_DB7? ( --  x ) 24 lshift CAN1_RFIFOMDATA11 @ ; \ CAN1_RFIFOMDATA11_DB7, Data byte 7
: CAN1_RFIFOMDATA11_DB6? ( --  x ) 16 lshift CAN1_RFIFOMDATA11 @ ; \ CAN1_RFIFOMDATA11_DB6, Data byte 6
: CAN1_RFIFOMDATA11_DB5? ( --  x ) 8 lshift CAN1_RFIFOMDATA11 @ ; \ CAN1_RFIFOMDATA11_DB5, Data byte 5
: CAN1_RFIFOMDATA11_DB4? ( --  x ) CAN1_RFIFOMDATA11 @ ; \ CAN1_RFIFOMDATA11_DB4, Data byte 4

\ CAN1_FCTL (read-write) Reset:0x2A1C0E01
: CAN1_FCTL_HBC1F ( %bbbbbb -- x addr ) 8 lshift CAN1_FCTL ; \ CAN1_FCTL_HBC1F, Header bank of CAN1 filter
: CAN1_FCTL_FLD ( -- x addr ) 0 bit CAN1_FCTL ; \ CAN1_FCTL_FLD, Filter lock disable

\ CAN1_FMCFG (read-write) Reset:0x00000000
: CAN1_FMCFG_FMOD27 ( -- x addr ) 27 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD27, Filter mode
: CAN1_FMCFG_FMOD26 ( -- x addr ) 26 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD26, Filter mode
: CAN1_FMCFG_FMOD25 ( -- x addr ) 25 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD25, Filter mode
: CAN1_FMCFG_FMOD24 ( -- x addr ) 24 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD24, Filter mode
: CAN1_FMCFG_FMOD23 ( -- x addr ) 23 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD23, Filter mode
: CAN1_FMCFG_FMOD22 ( -- x addr ) 22 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD22, Filter mode
: CAN1_FMCFG_FMOD21 ( -- x addr ) 21 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD21, Filter mode
: CAN1_FMCFG_FMOD20 ( -- x addr ) 20 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD20, Filter mode
: CAN1_FMCFG_FMOD19 ( -- x addr ) 19 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD19, Filter mode
: CAN1_FMCFG_FMOD18 ( -- x addr ) 18 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD18, Filter mode
: CAN1_FMCFG_FMOD17 ( -- x addr ) 17 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD17, Filter mode
: CAN1_FMCFG_FMOD16 ( -- x addr ) 16 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD16, Filter mode
: CAN1_FMCFG_FMOD15 ( -- x addr ) 15 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD15, Filter mode
: CAN1_FMCFG_FMOD14 ( -- x addr ) 14 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD14, Filter mode
: CAN1_FMCFG_FMOD13 ( -- x addr ) 13 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD13, Filter mode
: CAN1_FMCFG_FMOD12 ( -- x addr ) 12 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD12, Filter mode
: CAN1_FMCFG_FMOD11 ( -- x addr ) 11 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD11, Filter mode
: CAN1_FMCFG_FMOD10 ( -- x addr ) 10 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD10, Filter mode
: CAN1_FMCFG_FMOD9 ( -- x addr ) 9 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD9, Filter mode
: CAN1_FMCFG_FMOD8 ( -- x addr ) 8 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD8, Filter mode
: CAN1_FMCFG_FMOD7 ( -- x addr ) 7 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD7, Filter mode
: CAN1_FMCFG_FMOD6 ( -- x addr ) 6 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD6, Filter mode
: CAN1_FMCFG_FMOD5 ( -- x addr ) 5 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD5, Filter mode
: CAN1_FMCFG_FMOD4 ( -- x addr ) 4 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD4, Filter mode
: CAN1_FMCFG_FMOD3 ( -- x addr ) 3 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD3, Filter mode
: CAN1_FMCFG_FMOD2 ( -- x addr ) 2 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD2, Filter mode
: CAN1_FMCFG_FMOD1 ( -- x addr ) 1 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD1, Filter mode
: CAN1_FMCFG_FMOD0 ( -- x addr ) 0 bit CAN1_FMCFG ; \ CAN1_FMCFG_FMOD0, Filter mode

\ CAN1_FSCFG (read-write) Reset:0x00000000
: CAN1_FSCFG_FS0 ( -- x addr ) 0 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS0, Filter scale configuration
: CAN1_FSCFG_FS1 ( -- x addr ) 1 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS1, Filter scale configuration
: CAN1_FSCFG_FS2 ( -- x addr ) 2 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS2, Filter scale configuration
: CAN1_FSCFG_FS3 ( -- x addr ) 3 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS3, Filter scale configuration
: CAN1_FSCFG_FS4 ( -- x addr ) 4 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS4, Filter scale configuration
: CAN1_FSCFG_FS5 ( -- x addr ) 5 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS5, Filter scale configuration
: CAN1_FSCFG_FS6 ( -- x addr ) 6 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS6, Filter scale configuration
: CAN1_FSCFG_FS7 ( -- x addr ) 7 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS7, Filter scale configuration
: CAN1_FSCFG_FS8 ( -- x addr ) 8 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS8, Filter scale configuration
: CAN1_FSCFG_FS9 ( -- x addr ) 9 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS9, Filter scale configuration
: CAN1_FSCFG_FS10 ( -- x addr ) 10 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS10, Filter scale configuration
: CAN1_FSCFG_FS11 ( -- x addr ) 11 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS11, Filter scale configuration
: CAN1_FSCFG_FS12 ( -- x addr ) 12 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS12, Filter scale configuration
: CAN1_FSCFG_FS13 ( -- x addr ) 13 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS13, Filter scale configuration
: CAN1_FSCFG_FS14 ( -- x addr ) 14 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS14, Filter scale configuration
: CAN1_FSCFG_FS15 ( -- x addr ) 15 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS15, Filter scale configuration
: CAN1_FSCFG_FS16 ( -- x addr ) 16 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS16, Filter scale configuration
: CAN1_FSCFG_FS17 ( -- x addr ) 17 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS17, Filter scale configuration
: CAN1_FSCFG_FS18 ( -- x addr ) 18 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS18, Filter scale configuration
: CAN1_FSCFG_FS19 ( -- x addr ) 19 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS19, Filter scale configuration
: CAN1_FSCFG_FS20 ( -- x addr ) 20 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS20, Filter scale configuration
: CAN1_FSCFG_FS21 ( -- x addr ) 21 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS21, Filter scale configuration
: CAN1_FSCFG_FS22 ( -- x addr ) 22 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS22, Filter scale configuration
: CAN1_FSCFG_FS23 ( -- x addr ) 23 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS23, Filter scale configuration
: CAN1_FSCFG_FS24 ( -- x addr ) 24 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS24, Filter scale configuration
: CAN1_FSCFG_FS25 ( -- x addr ) 25 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS25, Filter scale configuration
: CAN1_FSCFG_FS26 ( -- x addr ) 26 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS26, Filter scale configuration
: CAN1_FSCFG_FS27 ( -- x addr ) 27 bit CAN1_FSCFG ; \ CAN1_FSCFG_FS27, Filter scale configuration

\ CAN1_FAFIFO (read-write) Reset:0x00000000
: CAN1_FAFIFO_FAF0 ( -- x addr ) 0 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF0, Filter 0 associated with FIFO
: CAN1_FAFIFO_FAF1 ( -- x addr ) 1 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF1, Filter 1 associated with FIFO
: CAN1_FAFIFO_FAF2 ( -- x addr ) 2 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF2, Filter 2 associated with FIFO
: CAN1_FAFIFO_FAF3 ( -- x addr ) 3 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF3, Filter 3 associated with FIFO
: CAN1_FAFIFO_FAF4 ( -- x addr ) 4 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF4, Filter 4 associated with FIFO
: CAN1_FAFIFO_FAF5 ( -- x addr ) 5 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF5, Filter 5 associated with FIFO
: CAN1_FAFIFO_FAF6 ( -- x addr ) 6 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF6, Filter 6 associated with FIFO
: CAN1_FAFIFO_FAF7 ( -- x addr ) 7 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF7, Filter 7 associated with FIFO
: CAN1_FAFIFO_FAF8 ( -- x addr ) 8 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF8, Filter 8 associated with FIFO
: CAN1_FAFIFO_FAF9 ( -- x addr ) 9 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF9, Filter 9 associated with FIFO
: CAN1_FAFIFO_FAF10 ( -- x addr ) 10 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF10, Filter 10 associated with FIFO
: CAN1_FAFIFO_FAF11 ( -- x addr ) 11 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF11, Filter 11 associated with FIFO
: CAN1_FAFIFO_FAF12 ( -- x addr ) 12 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF12, Filter 12 associated with FIFO
: CAN1_FAFIFO_FAF13 ( -- x addr ) 13 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF13, Filter 13 associated with FIFO
: CAN1_FAFIFO_FAF14 ( -- x addr ) 14 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF14, Filter 14 associated with FIFO
: CAN1_FAFIFO_FAF15 ( -- x addr ) 15 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF15, Filter 15 associated with FIFO
: CAN1_FAFIFO_FAF16 ( -- x addr ) 16 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF16, Filter 16 associated with FIFO
: CAN1_FAFIFO_FAF17 ( -- x addr ) 17 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF17, Filter 17 associated with FIFO
: CAN1_FAFIFO_FAF18 ( -- x addr ) 18 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF18, Filter 18 associated with FIFO
: CAN1_FAFIFO_FAF19 ( -- x addr ) 19 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF19, Filter 19 associated with FIFO
: CAN1_FAFIFO_FAF20 ( -- x addr ) 20 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF20, Filter 20 associated with FIFO
: CAN1_FAFIFO_FAF21 ( -- x addr ) 21 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF21, Filter 21 associated with FIFO
: CAN1_FAFIFO_FAF22 ( -- x addr ) 22 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF22, Filter 22 associated with FIFO
: CAN1_FAFIFO_FAF23 ( -- x addr ) 23 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF23, Filter 23 associated with FIFO
: CAN1_FAFIFO_FAF24 ( -- x addr ) 24 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF24, Filter 24 associated with FIFO
: CAN1_FAFIFO_FAF25 ( -- x addr ) 25 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF25, Filter 25 associated with FIFO
: CAN1_FAFIFO_FAF26 ( -- x addr ) 26 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF26, Filter 26 associated with FIFO
: CAN1_FAFIFO_FAF27 ( -- x addr ) 27 bit CAN1_FAFIFO ; \ CAN1_FAFIFO_FAF27, Filter 27 associated with FIFO

\ CAN1_FW (read-write) Reset:0x00000000
: CAN1_FW_FW0 ( -- x addr ) 0 bit CAN1_FW ; \ CAN1_FW_FW0, Filter working
: CAN1_FW_FW1 ( -- x addr ) 1 bit CAN1_FW ; \ CAN1_FW_FW1, Filter working
: CAN1_FW_FW2 ( -- x addr ) 2 bit CAN1_FW ; \ CAN1_FW_FW2, Filter working
: CAN1_FW_FW3 ( -- x addr ) 3 bit CAN1_FW ; \ CAN1_FW_FW3, Filter working
: CAN1_FW_FW4 ( -- x addr ) 4 bit CAN1_FW ; \ CAN1_FW_FW4, Filter working
: CAN1_FW_FW5 ( -- x addr ) 5 bit CAN1_FW ; \ CAN1_FW_FW5, Filter working
: CAN1_FW_FW6 ( -- x addr ) 6 bit CAN1_FW ; \ CAN1_FW_FW6, Filter working
: CAN1_FW_FW7 ( -- x addr ) 7 bit CAN1_FW ; \ CAN1_FW_FW7, Filter working
: CAN1_FW_FW8 ( -- x addr ) 8 bit CAN1_FW ; \ CAN1_FW_FW8, Filter working
: CAN1_FW_FW9 ( -- x addr ) 9 bit CAN1_FW ; \ CAN1_FW_FW9, Filter working
: CAN1_FW_FW10 ( -- x addr ) 10 bit CAN1_FW ; \ CAN1_FW_FW10, Filter working
: CAN1_FW_FW11 ( -- x addr ) 11 bit CAN1_FW ; \ CAN1_FW_FW11, Filter working
: CAN1_FW_FW12 ( -- x addr ) 12 bit CAN1_FW ; \ CAN1_FW_FW12, Filter working
: CAN1_FW_FW13 ( -- x addr ) 13 bit CAN1_FW ; \ CAN1_FW_FW13, Filter working
: CAN1_FW_FW14 ( -- x addr ) 14 bit CAN1_FW ; \ CAN1_FW_FW14, Filter working
: CAN1_FW_FW15 ( -- x addr ) 15 bit CAN1_FW ; \ CAN1_FW_FW15, Filter working
: CAN1_FW_FW16 ( -- x addr ) 16 bit CAN1_FW ; \ CAN1_FW_FW16, Filter working
: CAN1_FW_FW17 ( -- x addr ) 17 bit CAN1_FW ; \ CAN1_FW_FW17, Filter working
: CAN1_FW_FW18 ( -- x addr ) 18 bit CAN1_FW ; \ CAN1_FW_FW18, Filter working
: CAN1_FW_FW19 ( -- x addr ) 19 bit CAN1_FW ; \ CAN1_FW_FW19, Filter working
: CAN1_FW_FW20 ( -- x addr ) 20 bit CAN1_FW ; \ CAN1_FW_FW20, Filter working
: CAN1_FW_FW21 ( -- x addr ) 21 bit CAN1_FW ; \ CAN1_FW_FW21, Filter working
: CAN1_FW_FW22 ( -- x addr ) 22 bit CAN1_FW ; \ CAN1_FW_FW22, Filter working
: CAN1_FW_FW23 ( -- x addr ) 23 bit CAN1_FW ; \ CAN1_FW_FW23, Filter working
: CAN1_FW_FW24 ( -- x addr ) 24 bit CAN1_FW ; \ CAN1_FW_FW24, Filter working
: CAN1_FW_FW25 ( -- x addr ) 25 bit CAN1_FW ; \ CAN1_FW_FW25, Filter working
: CAN1_FW_FW26 ( -- x addr ) 26 bit CAN1_FW ; \ CAN1_FW_FW26, Filter working
: CAN1_FW_FW27 ( -- x addr ) 27 bit CAN1_FW ; \ CAN1_FW_FW27, Filter working

\ CAN1_F0DATA0 (read-write) Reset:0x00000000
: CAN1_F0DATA0_FD0 ( -- x addr ) 0 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD0, Filter bits
: CAN1_F0DATA0_FD1 ( -- x addr ) 1 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD1, Filter bits
: CAN1_F0DATA0_FD2 ( -- x addr ) 2 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD2, Filter bits
: CAN1_F0DATA0_FD3 ( -- x addr ) 3 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD3, Filter bits
: CAN1_F0DATA0_FD4 ( -- x addr ) 4 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD4, Filter bits
: CAN1_F0DATA0_FD5 ( -- x addr ) 5 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD5, Filter bits
: CAN1_F0DATA0_FD6 ( -- x addr ) 6 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD6, Filter bits
: CAN1_F0DATA0_FD7 ( -- x addr ) 7 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD7, Filter bits
: CAN1_F0DATA0_FD8 ( -- x addr ) 8 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD8, Filter bits
: CAN1_F0DATA0_FD9 ( -- x addr ) 9 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD9, Filter bits
: CAN1_F0DATA0_FD10 ( -- x addr ) 10 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD10, Filter bits
: CAN1_F0DATA0_FD11 ( -- x addr ) 11 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD11, Filter bits
: CAN1_F0DATA0_FD12 ( -- x addr ) 12 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD12, Filter bits
: CAN1_F0DATA0_FD13 ( -- x addr ) 13 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD13, Filter bits
: CAN1_F0DATA0_FD14 ( -- x addr ) 14 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD14, Filter bits
: CAN1_F0DATA0_FD15 ( -- x addr ) 15 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD15, Filter bits
: CAN1_F0DATA0_FD16 ( -- x addr ) 16 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD16, Filter bits
: CAN1_F0DATA0_FD17 ( -- x addr ) 17 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD17, Filter bits
: CAN1_F0DATA0_FD18 ( -- x addr ) 18 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD18, Filter bits
: CAN1_F0DATA0_FD19 ( -- x addr ) 19 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD19, Filter bits
: CAN1_F0DATA0_FD20 ( -- x addr ) 20 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD20, Filter bits
: CAN1_F0DATA0_FD21 ( -- x addr ) 21 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD21, Filter bits
: CAN1_F0DATA0_FD22 ( -- x addr ) 22 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD22, Filter bits
: CAN1_F0DATA0_FD23 ( -- x addr ) 23 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD23, Filter bits
: CAN1_F0DATA0_FD24 ( -- x addr ) 24 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD24, Filter bits
: CAN1_F0DATA0_FD25 ( -- x addr ) 25 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD25, Filter bits
: CAN1_F0DATA0_FD26 ( -- x addr ) 26 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD26, Filter bits
: CAN1_F0DATA0_FD27 ( -- x addr ) 27 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD27, Filter bits
: CAN1_F0DATA0_FD28 ( -- x addr ) 28 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD28, Filter bits
: CAN1_F0DATA0_FD29 ( -- x addr ) 29 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD29, Filter bits
: CAN1_F0DATA0_FD30 ( -- x addr ) 30 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD30, Filter bits
: CAN1_F0DATA0_FD31 ( -- x addr ) 31 bit CAN1_F0DATA0 ; \ CAN1_F0DATA0_FD31, Filter bits

\ CAN1_F0DATA1 (read-write) Reset:0x00000000
: CAN1_F0DATA1_FD0 ( -- x addr ) 0 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD0, Filter bits
: CAN1_F0DATA1_FD1 ( -- x addr ) 1 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD1, Filter bits
: CAN1_F0DATA1_FD2 ( -- x addr ) 2 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD2, Filter bits
: CAN1_F0DATA1_FD3 ( -- x addr ) 3 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD3, Filter bits
: CAN1_F0DATA1_FD4 ( -- x addr ) 4 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD4, Filter bits
: CAN1_F0DATA1_FD5 ( -- x addr ) 5 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD5, Filter bits
: CAN1_F0DATA1_FD6 ( -- x addr ) 6 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD6, Filter bits
: CAN1_F0DATA1_FD7 ( -- x addr ) 7 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD7, Filter bits
: CAN1_F0DATA1_FD8 ( -- x addr ) 8 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD8, Filter bits
: CAN1_F0DATA1_FD9 ( -- x addr ) 9 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD9, Filter bits
: CAN1_F0DATA1_FD10 ( -- x addr ) 10 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD10, Filter bits
: CAN1_F0DATA1_FD11 ( -- x addr ) 11 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD11, Filter bits
: CAN1_F0DATA1_FD12 ( -- x addr ) 12 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD12, Filter bits
: CAN1_F0DATA1_FD13 ( -- x addr ) 13 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD13, Filter bits
: CAN1_F0DATA1_FD14 ( -- x addr ) 14 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD14, Filter bits
: CAN1_F0DATA1_FD15 ( -- x addr ) 15 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD15, Filter bits
: CAN1_F0DATA1_FD16 ( -- x addr ) 16 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD16, Filter bits
: CAN1_F0DATA1_FD17 ( -- x addr ) 17 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD17, Filter bits
: CAN1_F0DATA1_FD18 ( -- x addr ) 18 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD18, Filter bits
: CAN1_F0DATA1_FD19 ( -- x addr ) 19 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD19, Filter bits
: CAN1_F0DATA1_FD20 ( -- x addr ) 20 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD20, Filter bits
: CAN1_F0DATA1_FD21 ( -- x addr ) 21 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD21, Filter bits
: CAN1_F0DATA1_FD22 ( -- x addr ) 22 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD22, Filter bits
: CAN1_F0DATA1_FD23 ( -- x addr ) 23 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD23, Filter bits
: CAN1_F0DATA1_FD24 ( -- x addr ) 24 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD24, Filter bits
: CAN1_F0DATA1_FD25 ( -- x addr ) 25 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD25, Filter bits
: CAN1_F0DATA1_FD26 ( -- x addr ) 26 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD26, Filter bits
: CAN1_F0DATA1_FD27 ( -- x addr ) 27 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD27, Filter bits
: CAN1_F0DATA1_FD28 ( -- x addr ) 28 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD28, Filter bits
: CAN1_F0DATA1_FD29 ( -- x addr ) 29 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD29, Filter bits
: CAN1_F0DATA1_FD30 ( -- x addr ) 30 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD30, Filter bits
: CAN1_F0DATA1_FD31 ( -- x addr ) 31 bit CAN1_F0DATA1 ; \ CAN1_F0DATA1_FD31, Filter bits

\ CAN1_F1DATA0 (read-write) Reset:0x00000000
: CAN1_F1DATA0_FD0 ( -- x addr ) 0 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD0, Filter bits
: CAN1_F1DATA0_FD1 ( -- x addr ) 1 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD1, Filter bits
: CAN1_F1DATA0_FD2 ( -- x addr ) 2 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD2, Filter bits
: CAN1_F1DATA0_FD3 ( -- x addr ) 3 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD3, Filter bits
: CAN1_F1DATA0_FD4 ( -- x addr ) 4 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD4, Filter bits
: CAN1_F1DATA0_FD5 ( -- x addr ) 5 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD5, Filter bits
: CAN1_F1DATA0_FD6 ( -- x addr ) 6 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD6, Filter bits
: CAN1_F1DATA0_FD7 ( -- x addr ) 7 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD7, Filter bits
: CAN1_F1DATA0_FD8 ( -- x addr ) 8 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD8, Filter bits
: CAN1_F1DATA0_FD9 ( -- x addr ) 9 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD9, Filter bits
: CAN1_F1DATA0_FD10 ( -- x addr ) 10 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD10, Filter bits
: CAN1_F1DATA0_FD11 ( -- x addr ) 11 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD11, Filter bits
: CAN1_F1DATA0_FD12 ( -- x addr ) 12 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD12, Filter bits
: CAN1_F1DATA0_FD13 ( -- x addr ) 13 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD13, Filter bits
: CAN1_F1DATA0_FD14 ( -- x addr ) 14 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD14, Filter bits
: CAN1_F1DATA0_FD15 ( -- x addr ) 15 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD15, Filter bits
: CAN1_F1DATA0_FD16 ( -- x addr ) 16 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD16, Filter bits
: CAN1_F1DATA0_FD17 ( -- x addr ) 17 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD17, Filter bits
: CAN1_F1DATA0_FD18 ( -- x addr ) 18 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD18, Filter bits
: CAN1_F1DATA0_FD19 ( -- x addr ) 19 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD19, Filter bits
: CAN1_F1DATA0_FD20 ( -- x addr ) 20 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD20, Filter bits
: CAN1_F1DATA0_FD21 ( -- x addr ) 21 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD21, Filter bits
: CAN1_F1DATA0_FD22 ( -- x addr ) 22 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD22, Filter bits
: CAN1_F1DATA0_FD23 ( -- x addr ) 23 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD23, Filter bits
: CAN1_F1DATA0_FD24 ( -- x addr ) 24 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD24, Filter bits
: CAN1_F1DATA0_FD25 ( -- x addr ) 25 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD25, Filter bits
: CAN1_F1DATA0_FD26 ( -- x addr ) 26 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD26, Filter bits
: CAN1_F1DATA0_FD27 ( -- x addr ) 27 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD27, Filter bits
: CAN1_F1DATA0_FD28 ( -- x addr ) 28 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD28, Filter bits
: CAN1_F1DATA0_FD29 ( -- x addr ) 29 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD29, Filter bits
: CAN1_F1DATA0_FD30 ( -- x addr ) 30 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD30, Filter bits
: CAN1_F1DATA0_FD31 ( -- x addr ) 31 bit CAN1_F1DATA0 ; \ CAN1_F1DATA0_FD31, Filter bits

\ CAN1_F1DATA1 (read-write) Reset:0x00000000
: CAN1_F1DATA1_FD0 ( -- x addr ) 0 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD0, Filter bits
: CAN1_F1DATA1_FD1 ( -- x addr ) 1 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD1, Filter bits
: CAN1_F1DATA1_FD2 ( -- x addr ) 2 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD2, Filter bits
: CAN1_F1DATA1_FD3 ( -- x addr ) 3 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD3, Filter bits
: CAN1_F1DATA1_FD4 ( -- x addr ) 4 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD4, Filter bits
: CAN1_F1DATA1_FD5 ( -- x addr ) 5 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD5, Filter bits
: CAN1_F1DATA1_FD6 ( -- x addr ) 6 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD6, Filter bits
: CAN1_F1DATA1_FD7 ( -- x addr ) 7 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD7, Filter bits
: CAN1_F1DATA1_FD8 ( -- x addr ) 8 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD8, Filter bits
: CAN1_F1DATA1_FD9 ( -- x addr ) 9 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD9, Filter bits
: CAN1_F1DATA1_FD10 ( -- x addr ) 10 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD10, Filter bits
: CAN1_F1DATA1_FD11 ( -- x addr ) 11 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD11, Filter bits
: CAN1_F1DATA1_FD12 ( -- x addr ) 12 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD12, Filter bits
: CAN1_F1DATA1_FD13 ( -- x addr ) 13 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD13, Filter bits
: CAN1_F1DATA1_FD14 ( -- x addr ) 14 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD14, Filter bits
: CAN1_F1DATA1_FD15 ( -- x addr ) 15 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD15, Filter bits
: CAN1_F1DATA1_FD16 ( -- x addr ) 16 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD16, Filter bits
: CAN1_F1DATA1_FD17 ( -- x addr ) 17 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD17, Filter bits
: CAN1_F1DATA1_FD18 ( -- x addr ) 18 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD18, Filter bits
: CAN1_F1DATA1_FD19 ( -- x addr ) 19 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD19, Filter bits
: CAN1_F1DATA1_FD20 ( -- x addr ) 20 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD20, Filter bits
: CAN1_F1DATA1_FD21 ( -- x addr ) 21 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD21, Filter bits
: CAN1_F1DATA1_FD22 ( -- x addr ) 22 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD22, Filter bits
: CAN1_F1DATA1_FD23 ( -- x addr ) 23 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD23, Filter bits
: CAN1_F1DATA1_FD24 ( -- x addr ) 24 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD24, Filter bits
: CAN1_F1DATA1_FD25 ( -- x addr ) 25 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD25, Filter bits
: CAN1_F1DATA1_FD26 ( -- x addr ) 26 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD26, Filter bits
: CAN1_F1DATA1_FD27 ( -- x addr ) 27 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD27, Filter bits
: CAN1_F1DATA1_FD28 ( -- x addr ) 28 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD28, Filter bits
: CAN1_F1DATA1_FD29 ( -- x addr ) 29 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD29, Filter bits
: CAN1_F1DATA1_FD30 ( -- x addr ) 30 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD30, Filter bits
: CAN1_F1DATA1_FD31 ( -- x addr ) 31 bit CAN1_F1DATA1 ; \ CAN1_F1DATA1_FD31, Filter bits

\ CAN1_F2DATA0 (read-write) Reset:0x00000000
: CAN1_F2DATA0_FD0 ( -- x addr ) 0 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD0, Filter bits
: CAN1_F2DATA0_FD1 ( -- x addr ) 1 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD1, Filter bits
: CAN1_F2DATA0_FD2 ( -- x addr ) 2 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD2, Filter bits
: CAN1_F2DATA0_FD3 ( -- x addr ) 3 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD3, Filter bits
: CAN1_F2DATA0_FD4 ( -- x addr ) 4 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD4, Filter bits
: CAN1_F2DATA0_FD5 ( -- x addr ) 5 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD5, Filter bits
: CAN1_F2DATA0_FD6 ( -- x addr ) 6 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD6, Filter bits
: CAN1_F2DATA0_FD7 ( -- x addr ) 7 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD7, Filter bits
: CAN1_F2DATA0_FD8 ( -- x addr ) 8 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD8, Filter bits
: CAN1_F2DATA0_FD9 ( -- x addr ) 9 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD9, Filter bits
: CAN1_F2DATA0_FD10 ( -- x addr ) 10 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD10, Filter bits
: CAN1_F2DATA0_FD11 ( -- x addr ) 11 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD11, Filter bits
: CAN1_F2DATA0_FD12 ( -- x addr ) 12 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD12, Filter bits
: CAN1_F2DATA0_FD13 ( -- x addr ) 13 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD13, Filter bits
: CAN1_F2DATA0_FD14 ( -- x addr ) 14 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD14, Filter bits
: CAN1_F2DATA0_FD15 ( -- x addr ) 15 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD15, Filter bits
: CAN1_F2DATA0_FD16 ( -- x addr ) 16 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD16, Filter bits
: CAN1_F2DATA0_FD17 ( -- x addr ) 17 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD17, Filter bits
: CAN1_F2DATA0_FD18 ( -- x addr ) 18 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD18, Filter bits
: CAN1_F2DATA0_FD19 ( -- x addr ) 19 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD19, Filter bits
: CAN1_F2DATA0_FD20 ( -- x addr ) 20 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD20, Filter bits
: CAN1_F2DATA0_FD21 ( -- x addr ) 21 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD21, Filter bits
: CAN1_F2DATA0_FD22 ( -- x addr ) 22 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD22, Filter bits
: CAN1_F2DATA0_FD23 ( -- x addr ) 23 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD23, Filter bits
: CAN1_F2DATA0_FD24 ( -- x addr ) 24 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD24, Filter bits
: CAN1_F2DATA0_FD25 ( -- x addr ) 25 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD25, Filter bits
: CAN1_F2DATA0_FD26 ( -- x addr ) 26 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD26, Filter bits
: CAN1_F2DATA0_FD27 ( -- x addr ) 27 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD27, Filter bits
: CAN1_F2DATA0_FD28 ( -- x addr ) 28 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD28, Filter bits
: CAN1_F2DATA0_FD29 ( -- x addr ) 29 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD29, Filter bits
: CAN1_F2DATA0_FD30 ( -- x addr ) 30 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD30, Filter bits
: CAN1_F2DATA0_FD31 ( -- x addr ) 31 bit CAN1_F2DATA0 ; \ CAN1_F2DATA0_FD31, Filter bits

\ CAN1_F2DATA1 (read-write) Reset:0x00000000
: CAN1_F2DATA1_FD0 ( -- x addr ) 0 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD0, Filter bits
: CAN1_F2DATA1_FD1 ( -- x addr ) 1 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD1, Filter bits
: CAN1_F2DATA1_FD2 ( -- x addr ) 2 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD2, Filter bits
: CAN1_F2DATA1_FD3 ( -- x addr ) 3 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD3, Filter bits
: CAN1_F2DATA1_FD4 ( -- x addr ) 4 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD4, Filter bits
: CAN1_F2DATA1_FD5 ( -- x addr ) 5 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD5, Filter bits
: CAN1_F2DATA1_FD6 ( -- x addr ) 6 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD6, Filter bits
: CAN1_F2DATA1_FD7 ( -- x addr ) 7 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD7, Filter bits
: CAN1_F2DATA1_FD8 ( -- x addr ) 8 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD8, Filter bits
: CAN1_F2DATA1_FD9 ( -- x addr ) 9 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD9, Filter bits
: CAN1_F2DATA1_FD10 ( -- x addr ) 10 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD10, Filter bits
: CAN1_F2DATA1_FD11 ( -- x addr ) 11 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD11, Filter bits
: CAN1_F2DATA1_FD12 ( -- x addr ) 12 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD12, Filter bits
: CAN1_F2DATA1_FD13 ( -- x addr ) 13 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD13, Filter bits
: CAN1_F2DATA1_FD14 ( -- x addr ) 14 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD14, Filter bits
: CAN1_F2DATA1_FD15 ( -- x addr ) 15 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD15, Filter bits
: CAN1_F2DATA1_FD16 ( -- x addr ) 16 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD16, Filter bits
: CAN1_F2DATA1_FD17 ( -- x addr ) 17 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD17, Filter bits
: CAN1_F2DATA1_FD18 ( -- x addr ) 18 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD18, Filter bits
: CAN1_F2DATA1_FD19 ( -- x addr ) 19 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD19, Filter bits
: CAN1_F2DATA1_FD20 ( -- x addr ) 20 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD20, Filter bits
: CAN1_F2DATA1_FD21 ( -- x addr ) 21 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD21, Filter bits
: CAN1_F2DATA1_FD22 ( -- x addr ) 22 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD22, Filter bits
: CAN1_F2DATA1_FD23 ( -- x addr ) 23 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD23, Filter bits
: CAN1_F2DATA1_FD24 ( -- x addr ) 24 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD24, Filter bits
: CAN1_F2DATA1_FD25 ( -- x addr ) 25 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD25, Filter bits
: CAN1_F2DATA1_FD26 ( -- x addr ) 26 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD26, Filter bits
: CAN1_F2DATA1_FD27 ( -- x addr ) 27 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD27, Filter bits
: CAN1_F2DATA1_FD28 ( -- x addr ) 28 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD28, Filter bits
: CAN1_F2DATA1_FD29 ( -- x addr ) 29 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD29, Filter bits
: CAN1_F2DATA1_FD30 ( -- x addr ) 30 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD30, Filter bits
: CAN1_F2DATA1_FD31 ( -- x addr ) 31 bit CAN1_F2DATA1 ; \ CAN1_F2DATA1_FD31, Filter bits

\ CAN1_F3DATA0 (read-write) Reset:0x00000000
: CAN1_F3DATA0_FD0 ( -- x addr ) 0 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD0, Filter bits
: CAN1_F3DATA0_FD1 ( -- x addr ) 1 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD1, Filter bits
: CAN1_F3DATA0_FD2 ( -- x addr ) 2 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD2, Filter bits
: CAN1_F3DATA0_FD3 ( -- x addr ) 3 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD3, Filter bits
: CAN1_F3DATA0_FD4 ( -- x addr ) 4 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD4, Filter bits
: CAN1_F3DATA0_FD5 ( -- x addr ) 5 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD5, Filter bits
: CAN1_F3DATA0_FD6 ( -- x addr ) 6 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD6, Filter bits
: CAN1_F3DATA0_FD7 ( -- x addr ) 7 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD7, Filter bits
: CAN1_F3DATA0_FD8 ( -- x addr ) 8 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD8, Filter bits
: CAN1_F3DATA0_FD9 ( -- x addr ) 9 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD9, Filter bits
: CAN1_F3DATA0_FD10 ( -- x addr ) 10 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD10, Filter bits
: CAN1_F3DATA0_FD11 ( -- x addr ) 11 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD11, Filter bits
: CAN1_F3DATA0_FD12 ( -- x addr ) 12 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD12, Filter bits
: CAN1_F3DATA0_FD13 ( -- x addr ) 13 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD13, Filter bits
: CAN1_F3DATA0_FD14 ( -- x addr ) 14 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD14, Filter bits
: CAN1_F3DATA0_FD15 ( -- x addr ) 15 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD15, Filter bits
: CAN1_F3DATA0_FD16 ( -- x addr ) 16 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD16, Filter bits
: CAN1_F3DATA0_FD17 ( -- x addr ) 17 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD17, Filter bits
: CAN1_F3DATA0_FD18 ( -- x addr ) 18 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD18, Filter bits
: CAN1_F3DATA0_FD19 ( -- x addr ) 19 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD19, Filter bits
: CAN1_F3DATA0_FD20 ( -- x addr ) 20 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD20, Filter bits
: CAN1_F3DATA0_FD21 ( -- x addr ) 21 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD21, Filter bits
: CAN1_F3DATA0_FD22 ( -- x addr ) 22 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD22, Filter bits
: CAN1_F3DATA0_FD23 ( -- x addr ) 23 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD23, Filter bits
: CAN1_F3DATA0_FD24 ( -- x addr ) 24 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD24, Filter bits
: CAN1_F3DATA0_FD25 ( -- x addr ) 25 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD25, Filter bits
: CAN1_F3DATA0_FD26 ( -- x addr ) 26 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD26, Filter bits
: CAN1_F3DATA0_FD27 ( -- x addr ) 27 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD27, Filter bits
: CAN1_F3DATA0_FD28 ( -- x addr ) 28 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD28, Filter bits
: CAN1_F3DATA0_FD29 ( -- x addr ) 29 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD29, Filter bits
: CAN1_F3DATA0_FD30 ( -- x addr ) 30 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD30, Filter bits
: CAN1_F3DATA0_FD31 ( -- x addr ) 31 bit CAN1_F3DATA0 ; \ CAN1_F3DATA0_FD31, Filter bits

\ CAN1_F3DATA1 (read-write) Reset:0x00000000
: CAN1_F3DATA1_FD0 ( -- x addr ) 0 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD0, Filter bits
: CAN1_F3DATA1_FD1 ( -- x addr ) 1 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD1, Filter bits
: CAN1_F3DATA1_FD2 ( -- x addr ) 2 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD2, Filter bits
: CAN1_F3DATA1_FD3 ( -- x addr ) 3 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD3, Filter bits
: CAN1_F3DATA1_FD4 ( -- x addr ) 4 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD4, Filter bits
: CAN1_F3DATA1_FD5 ( -- x addr ) 5 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD5, Filter bits
: CAN1_F3DATA1_FD6 ( -- x addr ) 6 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD6, Filter bits
: CAN1_F3DATA1_FD7 ( -- x addr ) 7 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD7, Filter bits
: CAN1_F3DATA1_FD8 ( -- x addr ) 8 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD8, Filter bits
: CAN1_F3DATA1_FD9 ( -- x addr ) 9 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD9, Filter bits
: CAN1_F3DATA1_FD10 ( -- x addr ) 10 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD10, Filter bits
: CAN1_F3DATA1_FD11 ( -- x addr ) 11 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD11, Filter bits
: CAN1_F3DATA1_FD12 ( -- x addr ) 12 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD12, Filter bits
: CAN1_F3DATA1_FD13 ( -- x addr ) 13 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD13, Filter bits
: CAN1_F3DATA1_FD14 ( -- x addr ) 14 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD14, Filter bits
: CAN1_F3DATA1_FD15 ( -- x addr ) 15 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD15, Filter bits
: CAN1_F3DATA1_FD16 ( -- x addr ) 16 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD16, Filter bits
: CAN1_F3DATA1_FD17 ( -- x addr ) 17 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD17, Filter bits
: CAN1_F3DATA1_FD18 ( -- x addr ) 18 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD18, Filter bits
: CAN1_F3DATA1_FD19 ( -- x addr ) 19 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD19, Filter bits
: CAN1_F3DATA1_FD20 ( -- x addr ) 20 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD20, Filter bits
: CAN1_F3DATA1_FD21 ( -- x addr ) 21 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD21, Filter bits
: CAN1_F3DATA1_FD22 ( -- x addr ) 22 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD22, Filter bits
: CAN1_F3DATA1_FD23 ( -- x addr ) 23 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD23, Filter bits
: CAN1_F3DATA1_FD24 ( -- x addr ) 24 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD24, Filter bits
: CAN1_F3DATA1_FD25 ( -- x addr ) 25 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD25, Filter bits
: CAN1_F3DATA1_FD26 ( -- x addr ) 26 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD26, Filter bits
: CAN1_F3DATA1_FD27 ( -- x addr ) 27 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD27, Filter bits
: CAN1_F3DATA1_FD28 ( -- x addr ) 28 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD28, Filter bits
: CAN1_F3DATA1_FD29 ( -- x addr ) 29 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD29, Filter bits
: CAN1_F3DATA1_FD30 ( -- x addr ) 30 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD30, Filter bits
: CAN1_F3DATA1_FD31 ( -- x addr ) 31 bit CAN1_F3DATA1 ; \ CAN1_F3DATA1_FD31, Filter bits

\ CAN1_F4DATA0 (read-write) Reset:0x00000000
: CAN1_F4DATA0_FD0 ( -- x addr ) 0 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD0, Filter bits
: CAN1_F4DATA0_FD1 ( -- x addr ) 1 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD1, Filter bits
: CAN1_F4DATA0_FD2 ( -- x addr ) 2 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD2, Filter bits
: CAN1_F4DATA0_FD3 ( -- x addr ) 3 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD3, Filter bits
: CAN1_F4DATA0_FD4 ( -- x addr ) 4 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD4, Filter bits
: CAN1_F4DATA0_FD5 ( -- x addr ) 5 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD5, Filter bits
: CAN1_F4DATA0_FD6 ( -- x addr ) 6 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD6, Filter bits
: CAN1_F4DATA0_FD7 ( -- x addr ) 7 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD7, Filter bits
: CAN1_F4DATA0_FD8 ( -- x addr ) 8 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD8, Filter bits
: CAN1_F4DATA0_FD9 ( -- x addr ) 9 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD9, Filter bits
: CAN1_F4DATA0_FD10 ( -- x addr ) 10 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD10, Filter bits
: CAN1_F4DATA0_FD11 ( -- x addr ) 11 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD11, Filter bits
: CAN1_F4DATA0_FD12 ( -- x addr ) 12 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD12, Filter bits
: CAN1_F4DATA0_FD13 ( -- x addr ) 13 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD13, Filter bits
: CAN1_F4DATA0_FD14 ( -- x addr ) 14 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD14, Filter bits
: CAN1_F4DATA0_FD15 ( -- x addr ) 15 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD15, Filter bits
: CAN1_F4DATA0_FD16 ( -- x addr ) 16 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD16, Filter bits
: CAN1_F4DATA0_FD17 ( -- x addr ) 17 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD17, Filter bits
: CAN1_F4DATA0_FD18 ( -- x addr ) 18 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD18, Filter bits
: CAN1_F4DATA0_FD19 ( -- x addr ) 19 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD19, Filter bits
: CAN1_F4DATA0_FD20 ( -- x addr ) 20 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD20, Filter bits
: CAN1_F4DATA0_FD21 ( -- x addr ) 21 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD21, Filter bits
: CAN1_F4DATA0_FD22 ( -- x addr ) 22 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD22, Filter bits
: CAN1_F4DATA0_FD23 ( -- x addr ) 23 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD23, Filter bits
: CAN1_F4DATA0_FD24 ( -- x addr ) 24 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD24, Filter bits
: CAN1_F4DATA0_FD25 ( -- x addr ) 25 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD25, Filter bits
: CAN1_F4DATA0_FD26 ( -- x addr ) 26 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD26, Filter bits
: CAN1_F4DATA0_FD27 ( -- x addr ) 27 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD27, Filter bits
: CAN1_F4DATA0_FD28 ( -- x addr ) 28 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD28, Filter bits
: CAN1_F4DATA0_FD29 ( -- x addr ) 29 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD29, Filter bits
: CAN1_F4DATA0_FD30 ( -- x addr ) 30 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD30, Filter bits
: CAN1_F4DATA0_FD31 ( -- x addr ) 31 bit CAN1_F4DATA0 ; \ CAN1_F4DATA0_FD31, Filter bits

\ CAN1_F4DATA1 (read-write) Reset:0x00000000
: CAN1_F4DATA1_FD0 ( -- x addr ) 0 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD0, Filter bits
: CAN1_F4DATA1_FD1 ( -- x addr ) 1 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD1, Filter bits
: CAN1_F4DATA1_FD2 ( -- x addr ) 2 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD2, Filter bits
: CAN1_F4DATA1_FD3 ( -- x addr ) 3 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD3, Filter bits
: CAN1_F4DATA1_FD4 ( -- x addr ) 4 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD4, Filter bits
: CAN1_F4DATA1_FD5 ( -- x addr ) 5 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD5, Filter bits
: CAN1_F4DATA1_FD6 ( -- x addr ) 6 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD6, Filter bits
: CAN1_F4DATA1_FD7 ( -- x addr ) 7 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD7, Filter bits
: CAN1_F4DATA1_FD8 ( -- x addr ) 8 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD8, Filter bits
: CAN1_F4DATA1_FD9 ( -- x addr ) 9 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD9, Filter bits
: CAN1_F4DATA1_FD10 ( -- x addr ) 10 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD10, Filter bits
: CAN1_F4DATA1_FD11 ( -- x addr ) 11 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD11, Filter bits
: CAN1_F4DATA1_FD12 ( -- x addr ) 12 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD12, Filter bits
: CAN1_F4DATA1_FD13 ( -- x addr ) 13 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD13, Filter bits
: CAN1_F4DATA1_FD14 ( -- x addr ) 14 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD14, Filter bits
: CAN1_F4DATA1_FD15 ( -- x addr ) 15 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD15, Filter bits
: CAN1_F4DATA1_FD16 ( -- x addr ) 16 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD16, Filter bits
: CAN1_F4DATA1_FD17 ( -- x addr ) 17 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD17, Filter bits
: CAN1_F4DATA1_FD18 ( -- x addr ) 18 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD18, Filter bits
: CAN1_F4DATA1_FD19 ( -- x addr ) 19 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD19, Filter bits
: CAN1_F4DATA1_FD20 ( -- x addr ) 20 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD20, Filter bits
: CAN1_F4DATA1_FD21 ( -- x addr ) 21 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD21, Filter bits
: CAN1_F4DATA1_FD22 ( -- x addr ) 22 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD22, Filter bits
: CAN1_F4DATA1_FD23 ( -- x addr ) 23 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD23, Filter bits
: CAN1_F4DATA1_FD24 ( -- x addr ) 24 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD24, Filter bits
: CAN1_F4DATA1_FD25 ( -- x addr ) 25 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD25, Filter bits
: CAN1_F4DATA1_FD26 ( -- x addr ) 26 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD26, Filter bits
: CAN1_F4DATA1_FD27 ( -- x addr ) 27 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD27, Filter bits
: CAN1_F4DATA1_FD28 ( -- x addr ) 28 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD28, Filter bits
: CAN1_F4DATA1_FD29 ( -- x addr ) 29 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD29, Filter bits
: CAN1_F4DATA1_FD30 ( -- x addr ) 30 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD30, Filter bits
: CAN1_F4DATA1_FD31 ( -- x addr ) 31 bit CAN1_F4DATA1 ; \ CAN1_F4DATA1_FD31, Filter bits

\ CAN1_F5DATA0 (read-write) Reset:0x00000000
: CAN1_F5DATA0_FD0 ( -- x addr ) 0 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD0, Filter bits
: CAN1_F5DATA0_FD1 ( -- x addr ) 1 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD1, Filter bits
: CAN1_F5DATA0_FD2 ( -- x addr ) 2 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD2, Filter bits
: CAN1_F5DATA0_FD3 ( -- x addr ) 3 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD3, Filter bits
: CAN1_F5DATA0_FD4 ( -- x addr ) 4 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD4, Filter bits
: CAN1_F5DATA0_FD5 ( -- x addr ) 5 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD5, Filter bits
: CAN1_F5DATA0_FD6 ( -- x addr ) 6 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD6, Filter bits
: CAN1_F5DATA0_FD7 ( -- x addr ) 7 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD7, Filter bits
: CAN1_F5DATA0_FD8 ( -- x addr ) 8 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD8, Filter bits
: CAN1_F5DATA0_FD9 ( -- x addr ) 9 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD9, Filter bits
: CAN1_F5DATA0_FD10 ( -- x addr ) 10 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD10, Filter bits
: CAN1_F5DATA0_FD11 ( -- x addr ) 11 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD11, Filter bits
: CAN1_F5DATA0_FD12 ( -- x addr ) 12 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD12, Filter bits
: CAN1_F5DATA0_FD13 ( -- x addr ) 13 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD13, Filter bits
: CAN1_F5DATA0_FD14 ( -- x addr ) 14 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD14, Filter bits
: CAN1_F5DATA0_FD15 ( -- x addr ) 15 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD15, Filter bits
: CAN1_F5DATA0_FD16 ( -- x addr ) 16 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD16, Filter bits
: CAN1_F5DATA0_FD17 ( -- x addr ) 17 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD17, Filter bits
: CAN1_F5DATA0_FD18 ( -- x addr ) 18 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD18, Filter bits
: CAN1_F5DATA0_FD19 ( -- x addr ) 19 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD19, Filter bits
: CAN1_F5DATA0_FD20 ( -- x addr ) 20 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD20, Filter bits
: CAN1_F5DATA0_FD21 ( -- x addr ) 21 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD21, Filter bits
: CAN1_F5DATA0_FD22 ( -- x addr ) 22 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD22, Filter bits
: CAN1_F5DATA0_FD23 ( -- x addr ) 23 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD23, Filter bits
: CAN1_F5DATA0_FD24 ( -- x addr ) 24 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD24, Filter bits
: CAN1_F5DATA0_FD25 ( -- x addr ) 25 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD25, Filter bits
: CAN1_F5DATA0_FD26 ( -- x addr ) 26 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD26, Filter bits
: CAN1_F5DATA0_FD27 ( -- x addr ) 27 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD27, Filter bits
: CAN1_F5DATA0_FD28 ( -- x addr ) 28 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD28, Filter bits
: CAN1_F5DATA0_FD29 ( -- x addr ) 29 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD29, Filter bits
: CAN1_F5DATA0_FD30 ( -- x addr ) 30 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD30, Filter bits
: CAN1_F5DATA0_FD31 ( -- x addr ) 31 bit CAN1_F5DATA0 ; \ CAN1_F5DATA0_FD31, Filter bits

\ CAN1_F5DATA1 (read-write) Reset:0x00000000
: CAN1_F5DATA1_FD0 ( -- x addr ) 0 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD0, Filter bits
: CAN1_F5DATA1_FD1 ( -- x addr ) 1 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD1, Filter bits
: CAN1_F5DATA1_FD2 ( -- x addr ) 2 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD2, Filter bits
: CAN1_F5DATA1_FD3 ( -- x addr ) 3 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD3, Filter bits
: CAN1_F5DATA1_FD4 ( -- x addr ) 4 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD4, Filter bits
: CAN1_F5DATA1_FD5 ( -- x addr ) 5 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD5, Filter bits
: CAN1_F5DATA1_FD6 ( -- x addr ) 6 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD6, Filter bits
: CAN1_F5DATA1_FD7 ( -- x addr ) 7 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD7, Filter bits
: CAN1_F5DATA1_FD8 ( -- x addr ) 8 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD8, Filter bits
: CAN1_F5DATA1_FD9 ( -- x addr ) 9 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD9, Filter bits
: CAN1_F5DATA1_FD10 ( -- x addr ) 10 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD10, Filter bits
: CAN1_F5DATA1_FD11 ( -- x addr ) 11 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD11, Filter bits
: CAN1_F5DATA1_FD12 ( -- x addr ) 12 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD12, Filter bits
: CAN1_F5DATA1_FD13 ( -- x addr ) 13 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD13, Filter bits
: CAN1_F5DATA1_FD14 ( -- x addr ) 14 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD14, Filter bits
: CAN1_F5DATA1_FD15 ( -- x addr ) 15 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD15, Filter bits
: CAN1_F5DATA1_FD16 ( -- x addr ) 16 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD16, Filter bits
: CAN1_F5DATA1_FD17 ( -- x addr ) 17 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD17, Filter bits
: CAN1_F5DATA1_FD18 ( -- x addr ) 18 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD18, Filter bits
: CAN1_F5DATA1_FD19 ( -- x addr ) 19 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD19, Filter bits
: CAN1_F5DATA1_FD20 ( -- x addr ) 20 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD20, Filter bits
: CAN1_F5DATA1_FD21 ( -- x addr ) 21 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD21, Filter bits
: CAN1_F5DATA1_FD22 ( -- x addr ) 22 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD22, Filter bits
: CAN1_F5DATA1_FD23 ( -- x addr ) 23 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD23, Filter bits
: CAN1_F5DATA1_FD24 ( -- x addr ) 24 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD24, Filter bits
: CAN1_F5DATA1_FD25 ( -- x addr ) 25 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD25, Filter bits
: CAN1_F5DATA1_FD26 ( -- x addr ) 26 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD26, Filter bits
: CAN1_F5DATA1_FD27 ( -- x addr ) 27 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD27, Filter bits
: CAN1_F5DATA1_FD28 ( -- x addr ) 28 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD28, Filter bits
: CAN1_F5DATA1_FD29 ( -- x addr ) 29 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD29, Filter bits
: CAN1_F5DATA1_FD30 ( -- x addr ) 30 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD30, Filter bits
: CAN1_F5DATA1_FD31 ( -- x addr ) 31 bit CAN1_F5DATA1 ; \ CAN1_F5DATA1_FD31, Filter bits

\ CAN1_F6DATA0 (read-write) Reset:0x00000000
: CAN1_F6DATA0_FD0 ( -- x addr ) 0 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD0, Filter bits
: CAN1_F6DATA0_FD1 ( -- x addr ) 1 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD1, Filter bits
: CAN1_F6DATA0_FD2 ( -- x addr ) 2 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD2, Filter bits
: CAN1_F6DATA0_FD3 ( -- x addr ) 3 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD3, Filter bits
: CAN1_F6DATA0_FD4 ( -- x addr ) 4 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD4, Filter bits
: CAN1_F6DATA0_FD5 ( -- x addr ) 5 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD5, Filter bits
: CAN1_F6DATA0_FD6 ( -- x addr ) 6 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD6, Filter bits
: CAN1_F6DATA0_FD7 ( -- x addr ) 7 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD7, Filter bits
: CAN1_F6DATA0_FD8 ( -- x addr ) 8 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD8, Filter bits
: CAN1_F6DATA0_FD9 ( -- x addr ) 9 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD9, Filter bits
: CAN1_F6DATA0_FD10 ( -- x addr ) 10 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD10, Filter bits
: CAN1_F6DATA0_FD11 ( -- x addr ) 11 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD11, Filter bits
: CAN1_F6DATA0_FD12 ( -- x addr ) 12 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD12, Filter bits
: CAN1_F6DATA0_FD13 ( -- x addr ) 13 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD13, Filter bits
: CAN1_F6DATA0_FD14 ( -- x addr ) 14 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD14, Filter bits
: CAN1_F6DATA0_FD15 ( -- x addr ) 15 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD15, Filter bits
: CAN1_F6DATA0_FD16 ( -- x addr ) 16 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD16, Filter bits
: CAN1_F6DATA0_FD17 ( -- x addr ) 17 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD17, Filter bits
: CAN1_F6DATA0_FD18 ( -- x addr ) 18 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD18, Filter bits
: CAN1_F6DATA0_FD19 ( -- x addr ) 19 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD19, Filter bits
: CAN1_F6DATA0_FD20 ( -- x addr ) 20 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD20, Filter bits
: CAN1_F6DATA0_FD21 ( -- x addr ) 21 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD21, Filter bits
: CAN1_F6DATA0_FD22 ( -- x addr ) 22 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD22, Filter bits
: CAN1_F6DATA0_FD23 ( -- x addr ) 23 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD23, Filter bits
: CAN1_F6DATA0_FD24 ( -- x addr ) 24 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD24, Filter bits
: CAN1_F6DATA0_FD25 ( -- x addr ) 25 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD25, Filter bits
: CAN1_F6DATA0_FD26 ( -- x addr ) 26 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD26, Filter bits
: CAN1_F6DATA0_FD27 ( -- x addr ) 27 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD27, Filter bits
: CAN1_F6DATA0_FD28 ( -- x addr ) 28 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD28, Filter bits
: CAN1_F6DATA0_FD29 ( -- x addr ) 29 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD29, Filter bits
: CAN1_F6DATA0_FD30 ( -- x addr ) 30 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD30, Filter bits
: CAN1_F6DATA0_FD31 ( -- x addr ) 31 bit CAN1_F6DATA0 ; \ CAN1_F6DATA0_FD31, Filter bits

\ CAN1_F6DATA1 (read-write) Reset:0x00000000
: CAN1_F6DATA1_FD0 ( -- x addr ) 0 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD0, Filter bits
: CAN1_F6DATA1_FD1 ( -- x addr ) 1 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD1, Filter bits
: CAN1_F6DATA1_FD2 ( -- x addr ) 2 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD2, Filter bits
: CAN1_F6DATA1_FD3 ( -- x addr ) 3 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD3, Filter bits
: CAN1_F6DATA1_FD4 ( -- x addr ) 4 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD4, Filter bits
: CAN1_F6DATA1_FD5 ( -- x addr ) 5 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD5, Filter bits
: CAN1_F6DATA1_FD6 ( -- x addr ) 6 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD6, Filter bits
: CAN1_F6DATA1_FD7 ( -- x addr ) 7 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD7, Filter bits
: CAN1_F6DATA1_FD8 ( -- x addr ) 8 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD8, Filter bits
: CAN1_F6DATA1_FD9 ( -- x addr ) 9 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD9, Filter bits
: CAN1_F6DATA1_FD10 ( -- x addr ) 10 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD10, Filter bits
: CAN1_F6DATA1_FD11 ( -- x addr ) 11 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD11, Filter bits
: CAN1_F6DATA1_FD12 ( -- x addr ) 12 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD12, Filter bits
: CAN1_F6DATA1_FD13 ( -- x addr ) 13 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD13, Filter bits
: CAN1_F6DATA1_FD14 ( -- x addr ) 14 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD14, Filter bits
: CAN1_F6DATA1_FD15 ( -- x addr ) 15 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD15, Filter bits
: CAN1_F6DATA1_FD16 ( -- x addr ) 16 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD16, Filter bits
: CAN1_F6DATA1_FD17 ( -- x addr ) 17 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD17, Filter bits
: CAN1_F6DATA1_FD18 ( -- x addr ) 18 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD18, Filter bits
: CAN1_F6DATA1_FD19 ( -- x addr ) 19 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD19, Filter bits
: CAN1_F6DATA1_FD20 ( -- x addr ) 20 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD20, Filter bits
: CAN1_F6DATA1_FD21 ( -- x addr ) 21 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD21, Filter bits
: CAN1_F6DATA1_FD22 ( -- x addr ) 22 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD22, Filter bits
: CAN1_F6DATA1_FD23 ( -- x addr ) 23 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD23, Filter bits
: CAN1_F6DATA1_FD24 ( -- x addr ) 24 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD24, Filter bits
: CAN1_F6DATA1_FD25 ( -- x addr ) 25 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD25, Filter bits
: CAN1_F6DATA1_FD26 ( -- x addr ) 26 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD26, Filter bits
: CAN1_F6DATA1_FD27 ( -- x addr ) 27 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD27, Filter bits
: CAN1_F6DATA1_FD28 ( -- x addr ) 28 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD28, Filter bits
: CAN1_F6DATA1_FD29 ( -- x addr ) 29 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD29, Filter bits
: CAN1_F6DATA1_FD30 ( -- x addr ) 30 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD30, Filter bits
: CAN1_F6DATA1_FD31 ( -- x addr ) 31 bit CAN1_F6DATA1 ; \ CAN1_F6DATA1_FD31, Filter bits

\ CAN1_F7DATA0 (read-write) Reset:0x00000000
: CAN1_F7DATA0_FD0 ( -- x addr ) 0 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD0, Filter bits
: CAN1_F7DATA0_FD1 ( -- x addr ) 1 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD1, Filter bits
: CAN1_F7DATA0_FD2 ( -- x addr ) 2 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD2, Filter bits
: CAN1_F7DATA0_FD3 ( -- x addr ) 3 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD3, Filter bits
: CAN1_F7DATA0_FD4 ( -- x addr ) 4 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD4, Filter bits
: CAN1_F7DATA0_FD5 ( -- x addr ) 5 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD5, Filter bits
: CAN1_F7DATA0_FD6 ( -- x addr ) 6 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD6, Filter bits
: CAN1_F7DATA0_FD7 ( -- x addr ) 7 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD7, Filter bits
: CAN1_F7DATA0_FD8 ( -- x addr ) 8 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD8, Filter bits
: CAN1_F7DATA0_FD9 ( -- x addr ) 9 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD9, Filter bits
: CAN1_F7DATA0_FD10 ( -- x addr ) 10 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD10, Filter bits
: CAN1_F7DATA0_FD11 ( -- x addr ) 11 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD11, Filter bits
: CAN1_F7DATA0_FD12 ( -- x addr ) 12 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD12, Filter bits
: CAN1_F7DATA0_FD13 ( -- x addr ) 13 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD13, Filter bits
: CAN1_F7DATA0_FD14 ( -- x addr ) 14 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD14, Filter bits
: CAN1_F7DATA0_FD15 ( -- x addr ) 15 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD15, Filter bits
: CAN1_F7DATA0_FD16 ( -- x addr ) 16 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD16, Filter bits
: CAN1_F7DATA0_FD17 ( -- x addr ) 17 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD17, Filter bits
: CAN1_F7DATA0_FD18 ( -- x addr ) 18 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD18, Filter bits
: CAN1_F7DATA0_FD19 ( -- x addr ) 19 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD19, Filter bits
: CAN1_F7DATA0_FD20 ( -- x addr ) 20 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD20, Filter bits
: CAN1_F7DATA0_FD21 ( -- x addr ) 21 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD21, Filter bits
: CAN1_F7DATA0_FD22 ( -- x addr ) 22 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD22, Filter bits
: CAN1_F7DATA0_FD23 ( -- x addr ) 23 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD23, Filter bits
: CAN1_F7DATA0_FD24 ( -- x addr ) 24 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD24, Filter bits
: CAN1_F7DATA0_FD25 ( -- x addr ) 25 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD25, Filter bits
: CAN1_F7DATA0_FD26 ( -- x addr ) 26 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD26, Filter bits
: CAN1_F7DATA0_FD27 ( -- x addr ) 27 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD27, Filter bits
: CAN1_F7DATA0_FD28 ( -- x addr ) 28 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD28, Filter bits
: CAN1_F7DATA0_FD29 ( -- x addr ) 29 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD29, Filter bits
: CAN1_F7DATA0_FD30 ( -- x addr ) 30 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD30, Filter bits
: CAN1_F7DATA0_FD31 ( -- x addr ) 31 bit CAN1_F7DATA0 ; \ CAN1_F7DATA0_FD31, Filter bits

\ CAN1_F7DATA1 (read-write) Reset:0x00000000
: CAN1_F7DATA1_FD0 ( -- x addr ) 0 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD0, Filter bits
: CAN1_F7DATA1_FD1 ( -- x addr ) 1 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD1, Filter bits
: CAN1_F7DATA1_FD2 ( -- x addr ) 2 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD2, Filter bits
: CAN1_F7DATA1_FD3 ( -- x addr ) 3 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD3, Filter bits
: CAN1_F7DATA1_FD4 ( -- x addr ) 4 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD4, Filter bits
: CAN1_F7DATA1_FD5 ( -- x addr ) 5 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD5, Filter bits
: CAN1_F7DATA1_FD6 ( -- x addr ) 6 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD6, Filter bits
: CAN1_F7DATA1_FD7 ( -- x addr ) 7 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD7, Filter bits
: CAN1_F7DATA1_FD8 ( -- x addr ) 8 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD8, Filter bits
: CAN1_F7DATA1_FD9 ( -- x addr ) 9 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD9, Filter bits
: CAN1_F7DATA1_FD10 ( -- x addr ) 10 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD10, Filter bits
: CAN1_F7DATA1_FD11 ( -- x addr ) 11 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD11, Filter bits
: CAN1_F7DATA1_FD12 ( -- x addr ) 12 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD12, Filter bits
: CAN1_F7DATA1_FD13 ( -- x addr ) 13 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD13, Filter bits
: CAN1_F7DATA1_FD14 ( -- x addr ) 14 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD14, Filter bits
: CAN1_F7DATA1_FD15 ( -- x addr ) 15 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD15, Filter bits
: CAN1_F7DATA1_FD16 ( -- x addr ) 16 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD16, Filter bits
: CAN1_F7DATA1_FD17 ( -- x addr ) 17 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD17, Filter bits
: CAN1_F7DATA1_FD18 ( -- x addr ) 18 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD18, Filter bits
: CAN1_F7DATA1_FD19 ( -- x addr ) 19 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD19, Filter bits
: CAN1_F7DATA1_FD20 ( -- x addr ) 20 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD20, Filter bits
: CAN1_F7DATA1_FD21 ( -- x addr ) 21 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD21, Filter bits
: CAN1_F7DATA1_FD22 ( -- x addr ) 22 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD22, Filter bits
: CAN1_F7DATA1_FD23 ( -- x addr ) 23 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD23, Filter bits
: CAN1_F7DATA1_FD24 ( -- x addr ) 24 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD24, Filter bits
: CAN1_F7DATA1_FD25 ( -- x addr ) 25 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD25, Filter bits
: CAN1_F7DATA1_FD26 ( -- x addr ) 26 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD26, Filter bits
: CAN1_F7DATA1_FD27 ( -- x addr ) 27 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD27, Filter bits
: CAN1_F7DATA1_FD28 ( -- x addr ) 28 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD28, Filter bits
: CAN1_F7DATA1_FD29 ( -- x addr ) 29 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD29, Filter bits
: CAN1_F7DATA1_FD30 ( -- x addr ) 30 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD30, Filter bits
: CAN1_F7DATA1_FD31 ( -- x addr ) 31 bit CAN1_F7DATA1 ; \ CAN1_F7DATA1_FD31, Filter bits

\ CAN1_F8DATA0 (read-write) Reset:0x00000000
: CAN1_F8DATA0_FD0 ( -- x addr ) 0 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD0, Filter bits
: CAN1_F8DATA0_FD1 ( -- x addr ) 1 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD1, Filter bits
: CAN1_F8DATA0_FD2 ( -- x addr ) 2 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD2, Filter bits
: CAN1_F8DATA0_FD3 ( -- x addr ) 3 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD3, Filter bits
: CAN1_F8DATA0_FD4 ( -- x addr ) 4 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD4, Filter bits
: CAN1_F8DATA0_FD5 ( -- x addr ) 5 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD5, Filter bits
: CAN1_F8DATA0_FD6 ( -- x addr ) 6 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD6, Filter bits
: CAN1_F8DATA0_FD7 ( -- x addr ) 7 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD7, Filter bits
: CAN1_F8DATA0_FD8 ( -- x addr ) 8 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD8, Filter bits
: CAN1_F8DATA0_FD9 ( -- x addr ) 9 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD9, Filter bits
: CAN1_F8DATA0_FD10 ( -- x addr ) 10 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD10, Filter bits
: CAN1_F8DATA0_FD11 ( -- x addr ) 11 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD11, Filter bits
: CAN1_F8DATA0_FD12 ( -- x addr ) 12 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD12, Filter bits
: CAN1_F8DATA0_FD13 ( -- x addr ) 13 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD13, Filter bits
: CAN1_F8DATA0_FD14 ( -- x addr ) 14 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD14, Filter bits
: CAN1_F8DATA0_FD15 ( -- x addr ) 15 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD15, Filter bits
: CAN1_F8DATA0_FD16 ( -- x addr ) 16 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD16, Filter bits
: CAN1_F8DATA0_FD17 ( -- x addr ) 17 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD17, Filter bits
: CAN1_F8DATA0_FD18 ( -- x addr ) 18 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD18, Filter bits
: CAN1_F8DATA0_FD19 ( -- x addr ) 19 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD19, Filter bits
: CAN1_F8DATA0_FD20 ( -- x addr ) 20 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD20, Filter bits
: CAN1_F8DATA0_FD21 ( -- x addr ) 21 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD21, Filter bits
: CAN1_F8DATA0_FD22 ( -- x addr ) 22 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD22, Filter bits
: CAN1_F8DATA0_FD23 ( -- x addr ) 23 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD23, Filter bits
: CAN1_F8DATA0_FD24 ( -- x addr ) 24 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD24, Filter bits
: CAN1_F8DATA0_FD25 ( -- x addr ) 25 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD25, Filter bits
: CAN1_F8DATA0_FD26 ( -- x addr ) 26 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD26, Filter bits
: CAN1_F8DATA0_FD27 ( -- x addr ) 27 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD27, Filter bits
: CAN1_F8DATA0_FD28 ( -- x addr ) 28 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD28, Filter bits
: CAN1_F8DATA0_FD29 ( -- x addr ) 29 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD29, Filter bits
: CAN1_F8DATA0_FD30 ( -- x addr ) 30 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD30, Filter bits
: CAN1_F8DATA0_FD31 ( -- x addr ) 31 bit CAN1_F8DATA0 ; \ CAN1_F8DATA0_FD31, Filter bits

\ CAN1_F8DATA1 (read-write) Reset:0x00000000
: CAN1_F8DATA1_FD0 ( -- x addr ) 0 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD0, Filter bits
: CAN1_F8DATA1_FD1 ( -- x addr ) 1 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD1, Filter bits
: CAN1_F8DATA1_FD2 ( -- x addr ) 2 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD2, Filter bits
: CAN1_F8DATA1_FD3 ( -- x addr ) 3 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD3, Filter bits
: CAN1_F8DATA1_FD4 ( -- x addr ) 4 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD4, Filter bits
: CAN1_F8DATA1_FD5 ( -- x addr ) 5 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD5, Filter bits
: CAN1_F8DATA1_FD6 ( -- x addr ) 6 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD6, Filter bits
: CAN1_F8DATA1_FD7 ( -- x addr ) 7 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD7, Filter bits
: CAN1_F8DATA1_FD8 ( -- x addr ) 8 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD8, Filter bits
: CAN1_F8DATA1_FD9 ( -- x addr ) 9 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD9, Filter bits
: CAN1_F8DATA1_FD10 ( -- x addr ) 10 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD10, Filter bits
: CAN1_F8DATA1_FD11 ( -- x addr ) 11 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD11, Filter bits
: CAN1_F8DATA1_FD12 ( -- x addr ) 12 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD12, Filter bits
: CAN1_F8DATA1_FD13 ( -- x addr ) 13 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD13, Filter bits
: CAN1_F8DATA1_FD14 ( -- x addr ) 14 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD14, Filter bits
: CAN1_F8DATA1_FD15 ( -- x addr ) 15 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD15, Filter bits
: CAN1_F8DATA1_FD16 ( -- x addr ) 16 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD16, Filter bits
: CAN1_F8DATA1_FD17 ( -- x addr ) 17 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD17, Filter bits
: CAN1_F8DATA1_FD18 ( -- x addr ) 18 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD18, Filter bits
: CAN1_F8DATA1_FD19 ( -- x addr ) 19 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD19, Filter bits
: CAN1_F8DATA1_FD20 ( -- x addr ) 20 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD20, Filter bits
: CAN1_F8DATA1_FD21 ( -- x addr ) 21 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD21, Filter bits
: CAN1_F8DATA1_FD22 ( -- x addr ) 22 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD22, Filter bits
: CAN1_F8DATA1_FD23 ( -- x addr ) 23 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD23, Filter bits
: CAN1_F8DATA1_FD24 ( -- x addr ) 24 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD24, Filter bits
: CAN1_F8DATA1_FD25 ( -- x addr ) 25 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD25, Filter bits
: CAN1_F8DATA1_FD26 ( -- x addr ) 26 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD26, Filter bits
: CAN1_F8DATA1_FD27 ( -- x addr ) 27 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD27, Filter bits
: CAN1_F8DATA1_FD28 ( -- x addr ) 28 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD28, Filter bits
: CAN1_F8DATA1_FD29 ( -- x addr ) 29 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD29, Filter bits
: CAN1_F8DATA1_FD30 ( -- x addr ) 30 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD30, Filter bits
: CAN1_F8DATA1_FD31 ( -- x addr ) 31 bit CAN1_F8DATA1 ; \ CAN1_F8DATA1_FD31, Filter bits

\ CAN1_F9DATA0 (read-write) Reset:0x00000000
: CAN1_F9DATA0_FD0 ( -- x addr ) 0 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD0, Filter bits
: CAN1_F9DATA0_FD1 ( -- x addr ) 1 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD1, Filter bits
: CAN1_F9DATA0_FD2 ( -- x addr ) 2 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD2, Filter bits
: CAN1_F9DATA0_FD3 ( -- x addr ) 3 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD3, Filter bits
: CAN1_F9DATA0_FD4 ( -- x addr ) 4 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD4, Filter bits
: CAN1_F9DATA0_FD5 ( -- x addr ) 5 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD5, Filter bits
: CAN1_F9DATA0_FD6 ( -- x addr ) 6 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD6, Filter bits
: CAN1_F9DATA0_FD7 ( -- x addr ) 7 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD7, Filter bits
: CAN1_F9DATA0_FD8 ( -- x addr ) 8 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD8, Filter bits
: CAN1_F9DATA0_FD9 ( -- x addr ) 9 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD9, Filter bits
: CAN1_F9DATA0_FD10 ( -- x addr ) 10 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD10, Filter bits
: CAN1_F9DATA0_FD11 ( -- x addr ) 11 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD11, Filter bits
: CAN1_F9DATA0_FD12 ( -- x addr ) 12 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD12, Filter bits
: CAN1_F9DATA0_FD13 ( -- x addr ) 13 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD13, Filter bits
: CAN1_F9DATA0_FD14 ( -- x addr ) 14 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD14, Filter bits
: CAN1_F9DATA0_FD15 ( -- x addr ) 15 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD15, Filter bits
: CAN1_F9DATA0_FD16 ( -- x addr ) 16 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD16, Filter bits
: CAN1_F9DATA0_FD17 ( -- x addr ) 17 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD17, Filter bits
: CAN1_F9DATA0_FD18 ( -- x addr ) 18 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD18, Filter bits
: CAN1_F9DATA0_FD19 ( -- x addr ) 19 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD19, Filter bits
: CAN1_F9DATA0_FD20 ( -- x addr ) 20 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD20, Filter bits
: CAN1_F9DATA0_FD21 ( -- x addr ) 21 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD21, Filter bits
: CAN1_F9DATA0_FD22 ( -- x addr ) 22 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD22, Filter bits
: CAN1_F9DATA0_FD23 ( -- x addr ) 23 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD23, Filter bits
: CAN1_F9DATA0_FD24 ( -- x addr ) 24 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD24, Filter bits
: CAN1_F9DATA0_FD25 ( -- x addr ) 25 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD25, Filter bits
: CAN1_F9DATA0_FD26 ( -- x addr ) 26 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD26, Filter bits
: CAN1_F9DATA0_FD27 ( -- x addr ) 27 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD27, Filter bits
: CAN1_F9DATA0_FD28 ( -- x addr ) 28 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD28, Filter bits
: CAN1_F9DATA0_FD29 ( -- x addr ) 29 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD29, Filter bits
: CAN1_F9DATA0_FD30 ( -- x addr ) 30 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD30, Filter bits
: CAN1_F9DATA0_FD31 ( -- x addr ) 31 bit CAN1_F9DATA0 ; \ CAN1_F9DATA0_FD31, Filter bits

\ CAN1_F9DATA1 (read-write) Reset:0x00000000
: CAN1_F9DATA1_FD0 ( -- x addr ) 0 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD0, Filter bits
: CAN1_F9DATA1_FD1 ( -- x addr ) 1 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD1, Filter bits
: CAN1_F9DATA1_FD2 ( -- x addr ) 2 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD2, Filter bits
: CAN1_F9DATA1_FD3 ( -- x addr ) 3 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD3, Filter bits
: CAN1_F9DATA1_FD4 ( -- x addr ) 4 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD4, Filter bits
: CAN1_F9DATA1_FD5 ( -- x addr ) 5 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD5, Filter bits
: CAN1_F9DATA1_FD6 ( -- x addr ) 6 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD6, Filter bits
: CAN1_F9DATA1_FD7 ( -- x addr ) 7 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD7, Filter bits
: CAN1_F9DATA1_FD8 ( -- x addr ) 8 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD8, Filter bits
: CAN1_F9DATA1_FD9 ( -- x addr ) 9 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD9, Filter bits
: CAN1_F9DATA1_FD10 ( -- x addr ) 10 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD10, Filter bits
: CAN1_F9DATA1_FD11 ( -- x addr ) 11 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD11, Filter bits
: CAN1_F9DATA1_FD12 ( -- x addr ) 12 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD12, Filter bits
: CAN1_F9DATA1_FD13 ( -- x addr ) 13 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD13, Filter bits
: CAN1_F9DATA1_FD14 ( -- x addr ) 14 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD14, Filter bits
: CAN1_F9DATA1_FD15 ( -- x addr ) 15 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD15, Filter bits
: CAN1_F9DATA1_FD16 ( -- x addr ) 16 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD16, Filter bits
: CAN1_F9DATA1_FD17 ( -- x addr ) 17 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD17, Filter bits
: CAN1_F9DATA1_FD18 ( -- x addr ) 18 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD18, Filter bits
: CAN1_F9DATA1_FD19 ( -- x addr ) 19 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD19, Filter bits
: CAN1_F9DATA1_FD20 ( -- x addr ) 20 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD20, Filter bits
: CAN1_F9DATA1_FD21 ( -- x addr ) 21 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD21, Filter bits
: CAN1_F9DATA1_FD22 ( -- x addr ) 22 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD22, Filter bits
: CAN1_F9DATA1_FD23 ( -- x addr ) 23 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD23, Filter bits
: CAN1_F9DATA1_FD24 ( -- x addr ) 24 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD24, Filter bits
: CAN1_F9DATA1_FD25 ( -- x addr ) 25 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD25, Filter bits
: CAN1_F9DATA1_FD26 ( -- x addr ) 26 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD26, Filter bits
: CAN1_F9DATA1_FD27 ( -- x addr ) 27 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD27, Filter bits
: CAN1_F9DATA1_FD28 ( -- x addr ) 28 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD28, Filter bits
: CAN1_F9DATA1_FD29 ( -- x addr ) 29 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD29, Filter bits
: CAN1_F9DATA1_FD30 ( -- x addr ) 30 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD30, Filter bits
: CAN1_F9DATA1_FD31 ( -- x addr ) 31 bit CAN1_F9DATA1 ; \ CAN1_F9DATA1_FD31, Filter bits

\ CAN1_F10DATA0 (read-write) Reset:0x00000000
: CAN1_F10DATA0_FD0 ( -- x addr ) 0 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD0, Filter bits
: CAN1_F10DATA0_FD1 ( -- x addr ) 1 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD1, Filter bits
: CAN1_F10DATA0_FD2 ( -- x addr ) 2 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD2, Filter bits
: CAN1_F10DATA0_FD3 ( -- x addr ) 3 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD3, Filter bits
: CAN1_F10DATA0_FD4 ( -- x addr ) 4 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD4, Filter bits
: CAN1_F10DATA0_FD5 ( -- x addr ) 5 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD5, Filter bits
: CAN1_F10DATA0_FD6 ( -- x addr ) 6 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD6, Filter bits
: CAN1_F10DATA0_FD7 ( -- x addr ) 7 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD7, Filter bits
: CAN1_F10DATA0_FD8 ( -- x addr ) 8 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD8, Filter bits
: CAN1_F10DATA0_FD9 ( -- x addr ) 9 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD9, Filter bits
: CAN1_F10DATA0_FD10 ( -- x addr ) 10 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD10, Filter bits
: CAN1_F10DATA0_FD11 ( -- x addr ) 11 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD11, Filter bits
: CAN1_F10DATA0_FD12 ( -- x addr ) 12 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD12, Filter bits
: CAN1_F10DATA0_FD13 ( -- x addr ) 13 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD13, Filter bits
: CAN1_F10DATA0_FD14 ( -- x addr ) 14 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD14, Filter bits
: CAN1_F10DATA0_FD15 ( -- x addr ) 15 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD15, Filter bits
: CAN1_F10DATA0_FD16 ( -- x addr ) 16 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD16, Filter bits
: CAN1_F10DATA0_FD17 ( -- x addr ) 17 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD17, Filter bits
: CAN1_F10DATA0_FD18 ( -- x addr ) 18 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD18, Filter bits
: CAN1_F10DATA0_FD19 ( -- x addr ) 19 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD19, Filter bits
: CAN1_F10DATA0_FD20 ( -- x addr ) 20 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD20, Filter bits
: CAN1_F10DATA0_FD21 ( -- x addr ) 21 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD21, Filter bits
: CAN1_F10DATA0_FD22 ( -- x addr ) 22 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD22, Filter bits
: CAN1_F10DATA0_FD23 ( -- x addr ) 23 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD23, Filter bits
: CAN1_F10DATA0_FD24 ( -- x addr ) 24 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD24, Filter bits
: CAN1_F10DATA0_FD25 ( -- x addr ) 25 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD25, Filter bits
: CAN1_F10DATA0_FD26 ( -- x addr ) 26 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD26, Filter bits
: CAN1_F10DATA0_FD27 ( -- x addr ) 27 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD27, Filter bits
: CAN1_F10DATA0_FD28 ( -- x addr ) 28 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD28, Filter bits
: CAN1_F10DATA0_FD29 ( -- x addr ) 29 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD29, Filter bits
: CAN1_F10DATA0_FD30 ( -- x addr ) 30 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD30, Filter bits
: CAN1_F10DATA0_FD31 ( -- x addr ) 31 bit CAN1_F10DATA0 ; \ CAN1_F10DATA0_FD31, Filter bits

\ CAN1_F10DATA1 (read-write) Reset:0x00000000
: CAN1_F10DATA1_FD0 ( -- x addr ) 0 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD0, Filter bits
: CAN1_F10DATA1_FD1 ( -- x addr ) 1 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD1, Filter bits
: CAN1_F10DATA1_FD2 ( -- x addr ) 2 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD2, Filter bits
: CAN1_F10DATA1_FD3 ( -- x addr ) 3 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD3, Filter bits
: CAN1_F10DATA1_FD4 ( -- x addr ) 4 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD4, Filter bits
: CAN1_F10DATA1_FD5 ( -- x addr ) 5 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD5, Filter bits
: CAN1_F10DATA1_FD6 ( -- x addr ) 6 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD6, Filter bits
: CAN1_F10DATA1_FD7 ( -- x addr ) 7 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD7, Filter bits
: CAN1_F10DATA1_FD8 ( -- x addr ) 8 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD8, Filter bits
: CAN1_F10DATA1_FD9 ( -- x addr ) 9 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD9, Filter bits
: CAN1_F10DATA1_FD10 ( -- x addr ) 10 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD10, Filter bits
: CAN1_F10DATA1_FD11 ( -- x addr ) 11 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD11, Filter bits
: CAN1_F10DATA1_FD12 ( -- x addr ) 12 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD12, Filter bits
: CAN1_F10DATA1_FD13 ( -- x addr ) 13 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD13, Filter bits
: CAN1_F10DATA1_FD14 ( -- x addr ) 14 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD14, Filter bits
: CAN1_F10DATA1_FD15 ( -- x addr ) 15 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD15, Filter bits
: CAN1_F10DATA1_FD16 ( -- x addr ) 16 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD16, Filter bits
: CAN1_F10DATA1_FD17 ( -- x addr ) 17 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD17, Filter bits
: CAN1_F10DATA1_FD18 ( -- x addr ) 18 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD18, Filter bits
: CAN1_F10DATA1_FD19 ( -- x addr ) 19 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD19, Filter bits
: CAN1_F10DATA1_FD20 ( -- x addr ) 20 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD20, Filter bits
: CAN1_F10DATA1_FD21 ( -- x addr ) 21 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD21, Filter bits
: CAN1_F10DATA1_FD22 ( -- x addr ) 22 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD22, Filter bits
: CAN1_F10DATA1_FD23 ( -- x addr ) 23 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD23, Filter bits
: CAN1_F10DATA1_FD24 ( -- x addr ) 24 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD24, Filter bits
: CAN1_F10DATA1_FD25 ( -- x addr ) 25 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD25, Filter bits
: CAN1_F10DATA1_FD26 ( -- x addr ) 26 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD26, Filter bits
: CAN1_F10DATA1_FD27 ( -- x addr ) 27 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD27, Filter bits
: CAN1_F10DATA1_FD28 ( -- x addr ) 28 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD28, Filter bits
: CAN1_F10DATA1_FD29 ( -- x addr ) 29 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD29, Filter bits
: CAN1_F10DATA1_FD30 ( -- x addr ) 30 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD30, Filter bits
: CAN1_F10DATA1_FD31 ( -- x addr ) 31 bit CAN1_F10DATA1 ; \ CAN1_F10DATA1_FD31, Filter bits

\ CAN1_F11DATA0 (read-write) Reset:0x00000000
: CAN1_F11DATA0_FD0 ( -- x addr ) 0 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD0, Filter bits
: CAN1_F11DATA0_FD1 ( -- x addr ) 1 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD1, Filter bits
: CAN1_F11DATA0_FD2 ( -- x addr ) 2 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD2, Filter bits
: CAN1_F11DATA0_FD3 ( -- x addr ) 3 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD3, Filter bits
: CAN1_F11DATA0_FD4 ( -- x addr ) 4 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD4, Filter bits
: CAN1_F11DATA0_FD5 ( -- x addr ) 5 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD5, Filter bits
: CAN1_F11DATA0_FD6 ( -- x addr ) 6 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD6, Filter bits
: CAN1_F11DATA0_FD7 ( -- x addr ) 7 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD7, Filter bits
: CAN1_F11DATA0_FD8 ( -- x addr ) 8 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD8, Filter bits
: CAN1_F11DATA0_FD9 ( -- x addr ) 9 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD9, Filter bits
: CAN1_F11DATA0_FD10 ( -- x addr ) 10 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD10, Filter bits
: CAN1_F11DATA0_FD11 ( -- x addr ) 11 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD11, Filter bits
: CAN1_F11DATA0_FD12 ( -- x addr ) 12 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD12, Filter bits
: CAN1_F11DATA0_FD13 ( -- x addr ) 13 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD13, Filter bits
: CAN1_F11DATA0_FD14 ( -- x addr ) 14 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD14, Filter bits
: CAN1_F11DATA0_FD15 ( -- x addr ) 15 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD15, Filter bits
: CAN1_F11DATA0_FD16 ( -- x addr ) 16 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD16, Filter bits
: CAN1_F11DATA0_FD17 ( -- x addr ) 17 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD17, Filter bits
: CAN1_F11DATA0_FD18 ( -- x addr ) 18 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD18, Filter bits
: CAN1_F11DATA0_FD19 ( -- x addr ) 19 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD19, Filter bits
: CAN1_F11DATA0_FD20 ( -- x addr ) 20 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD20, Filter bits
: CAN1_F11DATA0_FD21 ( -- x addr ) 21 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD21, Filter bits
: CAN1_F11DATA0_FD22 ( -- x addr ) 22 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD22, Filter bits
: CAN1_F11DATA0_FD23 ( -- x addr ) 23 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD23, Filter bits
: CAN1_F11DATA0_FD24 ( -- x addr ) 24 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD24, Filter bits
: CAN1_F11DATA0_FD25 ( -- x addr ) 25 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD25, Filter bits
: CAN1_F11DATA0_FD26 ( -- x addr ) 26 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD26, Filter bits
: CAN1_F11DATA0_FD27 ( -- x addr ) 27 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD27, Filter bits
: CAN1_F11DATA0_FD28 ( -- x addr ) 28 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD28, Filter bits
: CAN1_F11DATA0_FD29 ( -- x addr ) 29 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD29, Filter bits
: CAN1_F11DATA0_FD30 ( -- x addr ) 30 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD30, Filter bits
: CAN1_F11DATA0_FD31 ( -- x addr ) 31 bit CAN1_F11DATA0 ; \ CAN1_F11DATA0_FD31, Filter bits

\ CAN1_F11DATA1 (read-write) Reset:0x00000000
: CAN1_F11DATA1_FD0 ( -- x addr ) 0 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD0, Filter bits
: CAN1_F11DATA1_FD1 ( -- x addr ) 1 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD1, Filter bits
: CAN1_F11DATA1_FD2 ( -- x addr ) 2 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD2, Filter bits
: CAN1_F11DATA1_FD3 ( -- x addr ) 3 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD3, Filter bits
: CAN1_F11DATA1_FD4 ( -- x addr ) 4 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD4, Filter bits
: CAN1_F11DATA1_FD5 ( -- x addr ) 5 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD5, Filter bits
: CAN1_F11DATA1_FD6 ( -- x addr ) 6 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD6, Filter bits
: CAN1_F11DATA1_FD7 ( -- x addr ) 7 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD7, Filter bits
: CAN1_F11DATA1_FD8 ( -- x addr ) 8 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD8, Filter bits
: CAN1_F11DATA1_FD9 ( -- x addr ) 9 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD9, Filter bits
: CAN1_F11DATA1_FD10 ( -- x addr ) 10 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD10, Filter bits
: CAN1_F11DATA1_FD11 ( -- x addr ) 11 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD11, Filter bits
: CAN1_F11DATA1_FD12 ( -- x addr ) 12 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD12, Filter bits
: CAN1_F11DATA1_FD13 ( -- x addr ) 13 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD13, Filter bits
: CAN1_F11DATA1_FD14 ( -- x addr ) 14 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD14, Filter bits
: CAN1_F11DATA1_FD15 ( -- x addr ) 15 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD15, Filter bits
: CAN1_F11DATA1_FD16 ( -- x addr ) 16 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD16, Filter bits
: CAN1_F11DATA1_FD17 ( -- x addr ) 17 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD17, Filter bits
: CAN1_F11DATA1_FD18 ( -- x addr ) 18 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD18, Filter bits
: CAN1_F11DATA1_FD19 ( -- x addr ) 19 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD19, Filter bits
: CAN1_F11DATA1_FD20 ( -- x addr ) 20 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD20, Filter bits
: CAN1_F11DATA1_FD21 ( -- x addr ) 21 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD21, Filter bits
: CAN1_F11DATA1_FD22 ( -- x addr ) 22 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD22, Filter bits
: CAN1_F11DATA1_FD23 ( -- x addr ) 23 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD23, Filter bits
: CAN1_F11DATA1_FD24 ( -- x addr ) 24 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD24, Filter bits
: CAN1_F11DATA1_FD25 ( -- x addr ) 25 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD25, Filter bits
: CAN1_F11DATA1_FD26 ( -- x addr ) 26 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD26, Filter bits
: CAN1_F11DATA1_FD27 ( -- x addr ) 27 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD27, Filter bits
: CAN1_F11DATA1_FD28 ( -- x addr ) 28 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD28, Filter bits
: CAN1_F11DATA1_FD29 ( -- x addr ) 29 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD29, Filter bits
: CAN1_F11DATA1_FD30 ( -- x addr ) 30 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD30, Filter bits
: CAN1_F11DATA1_FD31 ( -- x addr ) 31 bit CAN1_F11DATA1 ; \ CAN1_F11DATA1_FD31, Filter bits

\ CAN1_F12DATA0 (read-write) Reset:0x00000000
: CAN1_F12DATA0_FD0 ( -- x addr ) 0 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD0, Filter bits
: CAN1_F12DATA0_FD1 ( -- x addr ) 1 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD1, Filter bits
: CAN1_F12DATA0_FD2 ( -- x addr ) 2 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD2, Filter bits
: CAN1_F12DATA0_FD3 ( -- x addr ) 3 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD3, Filter bits
: CAN1_F12DATA0_FD4 ( -- x addr ) 4 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD4, Filter bits
: CAN1_F12DATA0_FD5 ( -- x addr ) 5 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD5, Filter bits
: CAN1_F12DATA0_FD6 ( -- x addr ) 6 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD6, Filter bits
: CAN1_F12DATA0_FD7 ( -- x addr ) 7 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD7, Filter bits
: CAN1_F12DATA0_FD8 ( -- x addr ) 8 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD8, Filter bits
: CAN1_F12DATA0_FD9 ( -- x addr ) 9 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD9, Filter bits
: CAN1_F12DATA0_FD10 ( -- x addr ) 10 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD10, Filter bits
: CAN1_F12DATA0_FD11 ( -- x addr ) 11 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD11, Filter bits
: CAN1_F12DATA0_FD12 ( -- x addr ) 12 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD12, Filter bits
: CAN1_F12DATA0_FD13 ( -- x addr ) 13 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD13, Filter bits
: CAN1_F12DATA0_FD14 ( -- x addr ) 14 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD14, Filter bits
: CAN1_F12DATA0_FD15 ( -- x addr ) 15 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD15, Filter bits
: CAN1_F12DATA0_FD16 ( -- x addr ) 16 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD16, Filter bits
: CAN1_F12DATA0_FD17 ( -- x addr ) 17 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD17, Filter bits
: CAN1_F12DATA0_FD18 ( -- x addr ) 18 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD18, Filter bits
: CAN1_F12DATA0_FD19 ( -- x addr ) 19 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD19, Filter bits
: CAN1_F12DATA0_FD20 ( -- x addr ) 20 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD20, Filter bits
: CAN1_F12DATA0_FD21 ( -- x addr ) 21 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD21, Filter bits
: CAN1_F12DATA0_FD22 ( -- x addr ) 22 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD22, Filter bits
: CAN1_F12DATA0_FD23 ( -- x addr ) 23 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD23, Filter bits
: CAN1_F12DATA0_FD24 ( -- x addr ) 24 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD24, Filter bits
: CAN1_F12DATA0_FD25 ( -- x addr ) 25 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD25, Filter bits
: CAN1_F12DATA0_FD26 ( -- x addr ) 26 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD26, Filter bits
: CAN1_F12DATA0_FD27 ( -- x addr ) 27 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD27, Filter bits
: CAN1_F12DATA0_FD28 ( -- x addr ) 28 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD28, Filter bits
: CAN1_F12DATA0_FD29 ( -- x addr ) 29 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD29, Filter bits
: CAN1_F12DATA0_FD30 ( -- x addr ) 30 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD30, Filter bits
: CAN1_F12DATA0_FD31 ( -- x addr ) 31 bit CAN1_F12DATA0 ; \ CAN1_F12DATA0_FD31, Filter bits

\ CAN1_F12DATA1 (read-write) Reset:0x00000000
: CAN1_F12DATA1_FD0 ( -- x addr ) 0 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD0, Filter bits
: CAN1_F12DATA1_FD1 ( -- x addr ) 1 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD1, Filter bits
: CAN1_F12DATA1_FD2 ( -- x addr ) 2 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD2, Filter bits
: CAN1_F12DATA1_FD3 ( -- x addr ) 3 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD3, Filter bits
: CAN1_F12DATA1_FD4 ( -- x addr ) 4 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD4, Filter bits
: CAN1_F12DATA1_FD5 ( -- x addr ) 5 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD5, Filter bits
: CAN1_F12DATA1_FD6 ( -- x addr ) 6 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD6, Filter bits
: CAN1_F12DATA1_FD7 ( -- x addr ) 7 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD7, Filter bits
: CAN1_F12DATA1_FD8 ( -- x addr ) 8 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD8, Filter bits
: CAN1_F12DATA1_FD9 ( -- x addr ) 9 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD9, Filter bits
: CAN1_F12DATA1_FD10 ( -- x addr ) 10 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD10, Filter bits
: CAN1_F12DATA1_FD11 ( -- x addr ) 11 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD11, Filter bits
: CAN1_F12DATA1_FD12 ( -- x addr ) 12 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD12, Filter bits
: CAN1_F12DATA1_FD13 ( -- x addr ) 13 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD13, Filter bits
: CAN1_F12DATA1_FD14 ( -- x addr ) 14 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD14, Filter bits
: CAN1_F12DATA1_FD15 ( -- x addr ) 15 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD15, Filter bits
: CAN1_F12DATA1_FD16 ( -- x addr ) 16 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD16, Filter bits
: CAN1_F12DATA1_FD17 ( -- x addr ) 17 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD17, Filter bits
: CAN1_F12DATA1_FD18 ( -- x addr ) 18 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD18, Filter bits
: CAN1_F12DATA1_FD19 ( -- x addr ) 19 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD19, Filter bits
: CAN1_F12DATA1_FD20 ( -- x addr ) 20 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD20, Filter bits
: CAN1_F12DATA1_FD21 ( -- x addr ) 21 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD21, Filter bits
: CAN1_F12DATA1_FD22 ( -- x addr ) 22 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD22, Filter bits
: CAN1_F12DATA1_FD23 ( -- x addr ) 23 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD23, Filter bits
: CAN1_F12DATA1_FD24 ( -- x addr ) 24 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD24, Filter bits
: CAN1_F12DATA1_FD25 ( -- x addr ) 25 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD25, Filter bits
: CAN1_F12DATA1_FD26 ( -- x addr ) 26 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD26, Filter bits
: CAN1_F12DATA1_FD27 ( -- x addr ) 27 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD27, Filter bits
: CAN1_F12DATA1_FD28 ( -- x addr ) 28 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD28, Filter bits
: CAN1_F12DATA1_FD29 ( -- x addr ) 29 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD29, Filter bits
: CAN1_F12DATA1_FD30 ( -- x addr ) 30 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD30, Filter bits
: CAN1_F12DATA1_FD31 ( -- x addr ) 31 bit CAN1_F12DATA1 ; \ CAN1_F12DATA1_FD31, Filter bits

\ CAN1_F13DATA0 (read-write) Reset:0x00000000
: CAN1_F13DATA0_FD0 ( -- x addr ) 0 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD0, Filter bits
: CAN1_F13DATA0_FD1 ( -- x addr ) 1 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD1, Filter bits
: CAN1_F13DATA0_FD2 ( -- x addr ) 2 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD2, Filter bits
: CAN1_F13DATA0_FD3 ( -- x addr ) 3 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD3, Filter bits
: CAN1_F13DATA0_FD4 ( -- x addr ) 4 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD4, Filter bits
: CAN1_F13DATA0_FD5 ( -- x addr ) 5 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD5, Filter bits
: CAN1_F13DATA0_FD6 ( -- x addr ) 6 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD6, Filter bits
: CAN1_F13DATA0_FD7 ( -- x addr ) 7 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD7, Filter bits
: CAN1_F13DATA0_FD8 ( -- x addr ) 8 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD8, Filter bits
: CAN1_F13DATA0_FD9 ( -- x addr ) 9 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD9, Filter bits
: CAN1_F13DATA0_FD10 ( -- x addr ) 10 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD10, Filter bits
: CAN1_F13DATA0_FD11 ( -- x addr ) 11 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD11, Filter bits
: CAN1_F13DATA0_FD12 ( -- x addr ) 12 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD12, Filter bits
: CAN1_F13DATA0_FD13 ( -- x addr ) 13 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD13, Filter bits
: CAN1_F13DATA0_FD14 ( -- x addr ) 14 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD14, Filter bits
: CAN1_F13DATA0_FD15 ( -- x addr ) 15 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD15, Filter bits
: CAN1_F13DATA0_FD16 ( -- x addr ) 16 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD16, Filter bits
: CAN1_F13DATA0_FD17 ( -- x addr ) 17 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD17, Filter bits
: CAN1_F13DATA0_FD18 ( -- x addr ) 18 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD18, Filter bits
: CAN1_F13DATA0_FD19 ( -- x addr ) 19 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD19, Filter bits
: CAN1_F13DATA0_FD20 ( -- x addr ) 20 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD20, Filter bits
: CAN1_F13DATA0_FD21 ( -- x addr ) 21 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD21, Filter bits
: CAN1_F13DATA0_FD22 ( -- x addr ) 22 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD22, Filter bits
: CAN1_F13DATA0_FD23 ( -- x addr ) 23 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD23, Filter bits
: CAN1_F13DATA0_FD24 ( -- x addr ) 24 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD24, Filter bits
: CAN1_F13DATA0_FD25 ( -- x addr ) 25 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD25, Filter bits
: CAN1_F13DATA0_FD26 ( -- x addr ) 26 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD26, Filter bits
: CAN1_F13DATA0_FD27 ( -- x addr ) 27 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD27, Filter bits
: CAN1_F13DATA0_FD28 ( -- x addr ) 28 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD28, Filter bits
: CAN1_F13DATA0_FD29 ( -- x addr ) 29 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD29, Filter bits
: CAN1_F13DATA0_FD30 ( -- x addr ) 30 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD30, Filter bits
: CAN1_F13DATA0_FD31 ( -- x addr ) 31 bit CAN1_F13DATA0 ; \ CAN1_F13DATA0_FD31, Filter bits

\ CAN1_F13DATA1 (read-write) Reset:0x00000000
: CAN1_F13DATA1_FD0 ( -- x addr ) 0 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD0, Filter bits
: CAN1_F13DATA1_FD1 ( -- x addr ) 1 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD1, Filter bits
: CAN1_F13DATA1_FD2 ( -- x addr ) 2 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD2, Filter bits
: CAN1_F13DATA1_FD3 ( -- x addr ) 3 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD3, Filter bits
: CAN1_F13DATA1_FD4 ( -- x addr ) 4 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD4, Filter bits
: CAN1_F13DATA1_FD5 ( -- x addr ) 5 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD5, Filter bits
: CAN1_F13DATA1_FD6 ( -- x addr ) 6 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD6, Filter bits
: CAN1_F13DATA1_FD7 ( -- x addr ) 7 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD7, Filter bits
: CAN1_F13DATA1_FD8 ( -- x addr ) 8 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD8, Filter bits
: CAN1_F13DATA1_FD9 ( -- x addr ) 9 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD9, Filter bits
: CAN1_F13DATA1_FD10 ( -- x addr ) 10 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD10, Filter bits
: CAN1_F13DATA1_FD11 ( -- x addr ) 11 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD11, Filter bits
: CAN1_F13DATA1_FD12 ( -- x addr ) 12 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD12, Filter bits
: CAN1_F13DATA1_FD13 ( -- x addr ) 13 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD13, Filter bits
: CAN1_F13DATA1_FD14 ( -- x addr ) 14 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD14, Filter bits
: CAN1_F13DATA1_FD15 ( -- x addr ) 15 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD15, Filter bits
: CAN1_F13DATA1_FD16 ( -- x addr ) 16 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD16, Filter bits
: CAN1_F13DATA1_FD17 ( -- x addr ) 17 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD17, Filter bits
: CAN1_F13DATA1_FD18 ( -- x addr ) 18 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD18, Filter bits
: CAN1_F13DATA1_FD19 ( -- x addr ) 19 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD19, Filter bits
: CAN1_F13DATA1_FD20 ( -- x addr ) 20 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD20, Filter bits
: CAN1_F13DATA1_FD21 ( -- x addr ) 21 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD21, Filter bits
: CAN1_F13DATA1_FD22 ( -- x addr ) 22 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD22, Filter bits
: CAN1_F13DATA1_FD23 ( -- x addr ) 23 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD23, Filter bits
: CAN1_F13DATA1_FD24 ( -- x addr ) 24 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD24, Filter bits
: CAN1_F13DATA1_FD25 ( -- x addr ) 25 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD25, Filter bits
: CAN1_F13DATA1_FD26 ( -- x addr ) 26 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD26, Filter bits
: CAN1_F13DATA1_FD27 ( -- x addr ) 27 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD27, Filter bits
: CAN1_F13DATA1_FD28 ( -- x addr ) 28 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD28, Filter bits
: CAN1_F13DATA1_FD29 ( -- x addr ) 29 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD29, Filter bits
: CAN1_F13DATA1_FD30 ( -- x addr ) 30 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD30, Filter bits
: CAN1_F13DATA1_FD31 ( -- x addr ) 31 bit CAN1_F13DATA1 ; \ CAN1_F13DATA1_FD31, Filter bits

\ CAN1_F14DATA0 (read-write) Reset:0x00000000
: CAN1_F14DATA0_FD0 ( -- x addr ) 0 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD0, Filter bits
: CAN1_F14DATA0_FD1 ( -- x addr ) 1 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD1, Filter bits
: CAN1_F14DATA0_FD2 ( -- x addr ) 2 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD2, Filter bits
: CAN1_F14DATA0_FD3 ( -- x addr ) 3 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD3, Filter bits
: CAN1_F14DATA0_FD4 ( -- x addr ) 4 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD4, Filter bits
: CAN1_F14DATA0_FD5 ( -- x addr ) 5 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD5, Filter bits
: CAN1_F14DATA0_FD6 ( -- x addr ) 6 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD6, Filter bits
: CAN1_F14DATA0_FD7 ( -- x addr ) 7 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD7, Filter bits
: CAN1_F14DATA0_FD8 ( -- x addr ) 8 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD8, Filter bits
: CAN1_F14DATA0_FD9 ( -- x addr ) 9 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD9, Filter bits
: CAN1_F14DATA0_FD10 ( -- x addr ) 10 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD10, Filter bits
: CAN1_F14DATA0_FD11 ( -- x addr ) 11 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD11, Filter bits
: CAN1_F14DATA0_FD12 ( -- x addr ) 12 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD12, Filter bits
: CAN1_F14DATA0_FD13 ( -- x addr ) 13 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD13, Filter bits
: CAN1_F14DATA0_FD14 ( -- x addr ) 14 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD14, Filter bits
: CAN1_F14DATA0_FD15 ( -- x addr ) 15 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD15, Filter bits
: CAN1_F14DATA0_FD16 ( -- x addr ) 16 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD16, Filter bits
: CAN1_F14DATA0_FD17 ( -- x addr ) 17 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD17, Filter bits
: CAN1_F14DATA0_FD18 ( -- x addr ) 18 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD18, Filter bits
: CAN1_F14DATA0_FD19 ( -- x addr ) 19 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD19, Filter bits
: CAN1_F14DATA0_FD20 ( -- x addr ) 20 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD20, Filter bits
: CAN1_F14DATA0_FD21 ( -- x addr ) 21 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD21, Filter bits
: CAN1_F14DATA0_FD22 ( -- x addr ) 22 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD22, Filter bits
: CAN1_F14DATA0_FD23 ( -- x addr ) 23 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD23, Filter bits
: CAN1_F14DATA0_FD24 ( -- x addr ) 24 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD24, Filter bits
: CAN1_F14DATA0_FD25 ( -- x addr ) 25 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD25, Filter bits
: CAN1_F14DATA0_FD26 ( -- x addr ) 26 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD26, Filter bits
: CAN1_F14DATA0_FD27 ( -- x addr ) 27 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD27, Filter bits
: CAN1_F14DATA0_FD28 ( -- x addr ) 28 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD28, Filter bits
: CAN1_F14DATA0_FD29 ( -- x addr ) 29 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD29, Filter bits
: CAN1_F14DATA0_FD30 ( -- x addr ) 30 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD30, Filter bits
: CAN1_F14DATA0_FD31 ( -- x addr ) 31 bit CAN1_F14DATA0 ; \ CAN1_F14DATA0_FD31, Filter bits

\ CAN1_F14DATA1 (read-write) Reset:0x00000000
: CAN1_F14DATA1_FD0 ( -- x addr ) 0 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD0, Filter bits
: CAN1_F14DATA1_FD1 ( -- x addr ) 1 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD1, Filter bits
: CAN1_F14DATA1_FD2 ( -- x addr ) 2 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD2, Filter bits
: CAN1_F14DATA1_FD3 ( -- x addr ) 3 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD3, Filter bits
: CAN1_F14DATA1_FD4 ( -- x addr ) 4 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD4, Filter bits
: CAN1_F14DATA1_FD5 ( -- x addr ) 5 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD5, Filter bits
: CAN1_F14DATA1_FD6 ( -- x addr ) 6 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD6, Filter bits
: CAN1_F14DATA1_FD7 ( -- x addr ) 7 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD7, Filter bits
: CAN1_F14DATA1_FD8 ( -- x addr ) 8 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD8, Filter bits
: CAN1_F14DATA1_FD9 ( -- x addr ) 9 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD9, Filter bits
: CAN1_F14DATA1_FD10 ( -- x addr ) 10 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD10, Filter bits
: CAN1_F14DATA1_FD11 ( -- x addr ) 11 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD11, Filter bits
: CAN1_F14DATA1_FD12 ( -- x addr ) 12 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD12, Filter bits
: CAN1_F14DATA1_FD13 ( -- x addr ) 13 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD13, Filter bits
: CAN1_F14DATA1_FD14 ( -- x addr ) 14 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD14, Filter bits
: CAN1_F14DATA1_FD15 ( -- x addr ) 15 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD15, Filter bits
: CAN1_F14DATA1_FD16 ( -- x addr ) 16 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD16, Filter bits
: CAN1_F14DATA1_FD17 ( -- x addr ) 17 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD17, Filter bits
: CAN1_F14DATA1_FD18 ( -- x addr ) 18 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD18, Filter bits
: CAN1_F14DATA1_FD19 ( -- x addr ) 19 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD19, Filter bits
: CAN1_F14DATA1_FD20 ( -- x addr ) 20 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD20, Filter bits
: CAN1_F14DATA1_FD21 ( -- x addr ) 21 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD21, Filter bits
: CAN1_F14DATA1_FD22 ( -- x addr ) 22 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD22, Filter bits
: CAN1_F14DATA1_FD23 ( -- x addr ) 23 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD23, Filter bits
: CAN1_F14DATA1_FD24 ( -- x addr ) 24 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD24, Filter bits
: CAN1_F14DATA1_FD25 ( -- x addr ) 25 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD25, Filter bits
: CAN1_F14DATA1_FD26 ( -- x addr ) 26 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD26, Filter bits
: CAN1_F14DATA1_FD27 ( -- x addr ) 27 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD27, Filter bits
: CAN1_F14DATA1_FD28 ( -- x addr ) 28 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD28, Filter bits
: CAN1_F14DATA1_FD29 ( -- x addr ) 29 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD29, Filter bits
: CAN1_F14DATA1_FD30 ( -- x addr ) 30 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD30, Filter bits
: CAN1_F14DATA1_FD31 ( -- x addr ) 31 bit CAN1_F14DATA1 ; \ CAN1_F14DATA1_FD31, Filter bits

\ CAN1_F15DATA0 (read-write) Reset:0x00000000
: CAN1_F15DATA0_FD0 ( -- x addr ) 0 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD0, Filter bits
: CAN1_F15DATA0_FD1 ( -- x addr ) 1 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD1, Filter bits
: CAN1_F15DATA0_FD2 ( -- x addr ) 2 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD2, Filter bits
: CAN1_F15DATA0_FD3 ( -- x addr ) 3 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD3, Filter bits
: CAN1_F15DATA0_FD4 ( -- x addr ) 4 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD4, Filter bits
: CAN1_F15DATA0_FD5 ( -- x addr ) 5 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD5, Filter bits
: CAN1_F15DATA0_FD6 ( -- x addr ) 6 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD6, Filter bits
: CAN1_F15DATA0_FD7 ( -- x addr ) 7 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD7, Filter bits
: CAN1_F15DATA0_FD8 ( -- x addr ) 8 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD8, Filter bits
: CAN1_F15DATA0_FD9 ( -- x addr ) 9 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD9, Filter bits
: CAN1_F15DATA0_FD10 ( -- x addr ) 10 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD10, Filter bits
: CAN1_F15DATA0_FD11 ( -- x addr ) 11 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD11, Filter bits
: CAN1_F15DATA0_FD12 ( -- x addr ) 12 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD12, Filter bits
: CAN1_F15DATA0_FD13 ( -- x addr ) 13 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD13, Filter bits
: CAN1_F15DATA0_FD14 ( -- x addr ) 14 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD14, Filter bits
: CAN1_F15DATA0_FD15 ( -- x addr ) 15 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD15, Filter bits
: CAN1_F15DATA0_FD16 ( -- x addr ) 16 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD16, Filter bits
: CAN1_F15DATA0_FD17 ( -- x addr ) 17 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD17, Filter bits
: CAN1_F15DATA0_FD18 ( -- x addr ) 18 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD18, Filter bits
: CAN1_F15DATA0_FD19 ( -- x addr ) 19 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD19, Filter bits
: CAN1_F15DATA0_FD20 ( -- x addr ) 20 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD20, Filter bits
: CAN1_F15DATA0_FD21 ( -- x addr ) 21 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD21, Filter bits
: CAN1_F15DATA0_FD22 ( -- x addr ) 22 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD22, Filter bits
: CAN1_F15DATA0_FD23 ( -- x addr ) 23 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD23, Filter bits
: CAN1_F15DATA0_FD24 ( -- x addr ) 24 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD24, Filter bits
: CAN1_F15DATA0_FD25 ( -- x addr ) 25 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD25, Filter bits
: CAN1_F15DATA0_FD26 ( -- x addr ) 26 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD26, Filter bits
: CAN1_F15DATA0_FD27 ( -- x addr ) 27 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD27, Filter bits
: CAN1_F15DATA0_FD28 ( -- x addr ) 28 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD28, Filter bits
: CAN1_F15DATA0_FD29 ( -- x addr ) 29 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD29, Filter bits
: CAN1_F15DATA0_FD30 ( -- x addr ) 30 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD30, Filter bits
: CAN1_F15DATA0_FD31 ( -- x addr ) 31 bit CAN1_F15DATA0 ; \ CAN1_F15DATA0_FD31, Filter bits

\ CAN1_F15DATA1 (read-write) Reset:0x00000000
: CAN1_F15DATA1_FD0 ( -- x addr ) 0 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD0, Filter bits
: CAN1_F15DATA1_FD1 ( -- x addr ) 1 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD1, Filter bits
: CAN1_F15DATA1_FD2 ( -- x addr ) 2 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD2, Filter bits
: CAN1_F15DATA1_FD3 ( -- x addr ) 3 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD3, Filter bits
: CAN1_F15DATA1_FD4 ( -- x addr ) 4 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD4, Filter bits
: CAN1_F15DATA1_FD5 ( -- x addr ) 5 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD5, Filter bits
: CAN1_F15DATA1_FD6 ( -- x addr ) 6 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD6, Filter bits
: CAN1_F15DATA1_FD7 ( -- x addr ) 7 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD7, Filter bits
: CAN1_F15DATA1_FD8 ( -- x addr ) 8 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD8, Filter bits
: CAN1_F15DATA1_FD9 ( -- x addr ) 9 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD9, Filter bits
: CAN1_F15DATA1_FD10 ( -- x addr ) 10 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD10, Filter bits
: CAN1_F15DATA1_FD11 ( -- x addr ) 11 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD11, Filter bits
: CAN1_F15DATA1_FD12 ( -- x addr ) 12 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD12, Filter bits
: CAN1_F15DATA1_FD13 ( -- x addr ) 13 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD13, Filter bits
: CAN1_F15DATA1_FD14 ( -- x addr ) 14 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD14, Filter bits
: CAN1_F15DATA1_FD15 ( -- x addr ) 15 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD15, Filter bits
: CAN1_F15DATA1_FD16 ( -- x addr ) 16 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD16, Filter bits
: CAN1_F15DATA1_FD17 ( -- x addr ) 17 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD17, Filter bits
: CAN1_F15DATA1_FD18 ( -- x addr ) 18 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD18, Filter bits
: CAN1_F15DATA1_FD19 ( -- x addr ) 19 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD19, Filter bits
: CAN1_F15DATA1_FD20 ( -- x addr ) 20 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD20, Filter bits
: CAN1_F15DATA1_FD21 ( -- x addr ) 21 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD21, Filter bits
: CAN1_F15DATA1_FD22 ( -- x addr ) 22 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD22, Filter bits
: CAN1_F15DATA1_FD23 ( -- x addr ) 23 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD23, Filter bits
: CAN1_F15DATA1_FD24 ( -- x addr ) 24 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD24, Filter bits
: CAN1_F15DATA1_FD25 ( -- x addr ) 25 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD25, Filter bits
: CAN1_F15DATA1_FD26 ( -- x addr ) 26 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD26, Filter bits
: CAN1_F15DATA1_FD27 ( -- x addr ) 27 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD27, Filter bits
: CAN1_F15DATA1_FD28 ( -- x addr ) 28 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD28, Filter bits
: CAN1_F15DATA1_FD29 ( -- x addr ) 29 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD29, Filter bits
: CAN1_F15DATA1_FD30 ( -- x addr ) 30 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD30, Filter bits
: CAN1_F15DATA1_FD31 ( -- x addr ) 31 bit CAN1_F15DATA1 ; \ CAN1_F15DATA1_FD31, Filter bits

\ CAN1_F16DATA0 (read-write) Reset:0x00000000
: CAN1_F16DATA0_FD0 ( -- x addr ) 0 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD0, Filter bits
: CAN1_F16DATA0_FD1 ( -- x addr ) 1 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD1, Filter bits
: CAN1_F16DATA0_FD2 ( -- x addr ) 2 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD2, Filter bits
: CAN1_F16DATA0_FD3 ( -- x addr ) 3 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD3, Filter bits
: CAN1_F16DATA0_FD4 ( -- x addr ) 4 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD4, Filter bits
: CAN1_F16DATA0_FD5 ( -- x addr ) 5 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD5, Filter bits
: CAN1_F16DATA0_FD6 ( -- x addr ) 6 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD6, Filter bits
: CAN1_F16DATA0_FD7 ( -- x addr ) 7 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD7, Filter bits
: CAN1_F16DATA0_FD8 ( -- x addr ) 8 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD8, Filter bits
: CAN1_F16DATA0_FD9 ( -- x addr ) 9 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD9, Filter bits
: CAN1_F16DATA0_FD10 ( -- x addr ) 10 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD10, Filter bits
: CAN1_F16DATA0_FD11 ( -- x addr ) 11 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD11, Filter bits
: CAN1_F16DATA0_FD12 ( -- x addr ) 12 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD12, Filter bits
: CAN1_F16DATA0_FD13 ( -- x addr ) 13 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD13, Filter bits
: CAN1_F16DATA0_FD14 ( -- x addr ) 14 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD14, Filter bits
: CAN1_F16DATA0_FD15 ( -- x addr ) 15 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD15, Filter bits
: CAN1_F16DATA0_FD16 ( -- x addr ) 16 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD16, Filter bits
: CAN1_F16DATA0_FD17 ( -- x addr ) 17 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD17, Filter bits
: CAN1_F16DATA0_FD18 ( -- x addr ) 18 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD18, Filter bits
: CAN1_F16DATA0_FD19 ( -- x addr ) 19 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD19, Filter bits
: CAN1_F16DATA0_FD20 ( -- x addr ) 20 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD20, Filter bits
: CAN1_F16DATA0_FD21 ( -- x addr ) 21 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD21, Filter bits
: CAN1_F16DATA0_FD22 ( -- x addr ) 22 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD22, Filter bits
: CAN1_F16DATA0_FD23 ( -- x addr ) 23 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD23, Filter bits
: CAN1_F16DATA0_FD24 ( -- x addr ) 24 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD24, Filter bits
: CAN1_F16DATA0_FD25 ( -- x addr ) 25 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD25, Filter bits
: CAN1_F16DATA0_FD26 ( -- x addr ) 26 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD26, Filter bits
: CAN1_F16DATA0_FD27 ( -- x addr ) 27 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD27, Filter bits
: CAN1_F16DATA0_FD28 ( -- x addr ) 28 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD28, Filter bits
: CAN1_F16DATA0_FD29 ( -- x addr ) 29 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD29, Filter bits
: CAN1_F16DATA0_FD30 ( -- x addr ) 30 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD30, Filter bits
: CAN1_F16DATA0_FD31 ( -- x addr ) 31 bit CAN1_F16DATA0 ; \ CAN1_F16DATA0_FD31, Filter bits

\ CAN1_F16DATA1 (read-write) Reset:0x00000000
: CAN1_F16DATA1_FD0 ( -- x addr ) 0 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD0, Filter bits
: CAN1_F16DATA1_FD1 ( -- x addr ) 1 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD1, Filter bits
: CAN1_F16DATA1_FD2 ( -- x addr ) 2 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD2, Filter bits
: CAN1_F16DATA1_FD3 ( -- x addr ) 3 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD3, Filter bits
: CAN1_F16DATA1_FD4 ( -- x addr ) 4 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD4, Filter bits
: CAN1_F16DATA1_FD5 ( -- x addr ) 5 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD5, Filter bits
: CAN1_F16DATA1_FD6 ( -- x addr ) 6 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD6, Filter bits
: CAN1_F16DATA1_FD7 ( -- x addr ) 7 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD7, Filter bits
: CAN1_F16DATA1_FD8 ( -- x addr ) 8 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD8, Filter bits
: CAN1_F16DATA1_FD9 ( -- x addr ) 9 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD9, Filter bits
: CAN1_F16DATA1_FD10 ( -- x addr ) 10 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD10, Filter bits
: CAN1_F16DATA1_FD11 ( -- x addr ) 11 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD11, Filter bits
: CAN1_F16DATA1_FD12 ( -- x addr ) 12 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD12, Filter bits
: CAN1_F16DATA1_FD13 ( -- x addr ) 13 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD13, Filter bits
: CAN1_F16DATA1_FD14 ( -- x addr ) 14 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD14, Filter bits
: CAN1_F16DATA1_FD15 ( -- x addr ) 15 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD15, Filter bits
: CAN1_F16DATA1_FD16 ( -- x addr ) 16 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD16, Filter bits
: CAN1_F16DATA1_FD17 ( -- x addr ) 17 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD17, Filter bits
: CAN1_F16DATA1_FD18 ( -- x addr ) 18 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD18, Filter bits
: CAN1_F16DATA1_FD19 ( -- x addr ) 19 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD19, Filter bits
: CAN1_F16DATA1_FD20 ( -- x addr ) 20 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD20, Filter bits
: CAN1_F16DATA1_FD21 ( -- x addr ) 21 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD21, Filter bits
: CAN1_F16DATA1_FD22 ( -- x addr ) 22 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD22, Filter bits
: CAN1_F16DATA1_FD23 ( -- x addr ) 23 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD23, Filter bits
: CAN1_F16DATA1_FD24 ( -- x addr ) 24 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD24, Filter bits
: CAN1_F16DATA1_FD25 ( -- x addr ) 25 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD25, Filter bits
: CAN1_F16DATA1_FD26 ( -- x addr ) 26 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD26, Filter bits
: CAN1_F16DATA1_FD27 ( -- x addr ) 27 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD27, Filter bits
: CAN1_F16DATA1_FD28 ( -- x addr ) 28 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD28, Filter bits
: CAN1_F16DATA1_FD29 ( -- x addr ) 29 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD29, Filter bits
: CAN1_F16DATA1_FD30 ( -- x addr ) 30 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD30, Filter bits
: CAN1_F16DATA1_FD31 ( -- x addr ) 31 bit CAN1_F16DATA1 ; \ CAN1_F16DATA1_FD31, Filter bits

\ CAN1_F17DATA0 (read-write) Reset:0x00000000
: CAN1_F17DATA0_FD0 ( -- x addr ) 0 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD0, Filter bits
: CAN1_F17DATA0_FD1 ( -- x addr ) 1 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD1, Filter bits
: CAN1_F17DATA0_FD2 ( -- x addr ) 2 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD2, Filter bits
: CAN1_F17DATA0_FD3 ( -- x addr ) 3 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD3, Filter bits
: CAN1_F17DATA0_FD4 ( -- x addr ) 4 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD4, Filter bits
: CAN1_F17DATA0_FD5 ( -- x addr ) 5 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD5, Filter bits
: CAN1_F17DATA0_FD6 ( -- x addr ) 6 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD6, Filter bits
: CAN1_F17DATA0_FD7 ( -- x addr ) 7 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD7, Filter bits
: CAN1_F17DATA0_FD8 ( -- x addr ) 8 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD8, Filter bits
: CAN1_F17DATA0_FD9 ( -- x addr ) 9 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD9, Filter bits
: CAN1_F17DATA0_FD10 ( -- x addr ) 10 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD10, Filter bits
: CAN1_F17DATA0_FD11 ( -- x addr ) 11 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD11, Filter bits
: CAN1_F17DATA0_FD12 ( -- x addr ) 12 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD12, Filter bits
: CAN1_F17DATA0_FD13 ( -- x addr ) 13 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD13, Filter bits
: CAN1_F17DATA0_FD14 ( -- x addr ) 14 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD14, Filter bits
: CAN1_F17DATA0_FD15 ( -- x addr ) 15 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD15, Filter bits
: CAN1_F17DATA0_FD16 ( -- x addr ) 16 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD16, Filter bits
: CAN1_F17DATA0_FD17 ( -- x addr ) 17 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD17, Filter bits
: CAN1_F17DATA0_FD18 ( -- x addr ) 18 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD18, Filter bits
: CAN1_F17DATA0_FD19 ( -- x addr ) 19 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD19, Filter bits
: CAN1_F17DATA0_FD20 ( -- x addr ) 20 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD20, Filter bits
: CAN1_F17DATA0_FD21 ( -- x addr ) 21 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD21, Filter bits
: CAN1_F17DATA0_FD22 ( -- x addr ) 22 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD22, Filter bits
: CAN1_F17DATA0_FD23 ( -- x addr ) 23 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD23, Filter bits
: CAN1_F17DATA0_FD24 ( -- x addr ) 24 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD24, Filter bits
: CAN1_F17DATA0_FD25 ( -- x addr ) 25 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD25, Filter bits
: CAN1_F17DATA0_FD26 ( -- x addr ) 26 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD26, Filter bits
: CAN1_F17DATA0_FD27 ( -- x addr ) 27 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD27, Filter bits
: CAN1_F17DATA0_FD28 ( -- x addr ) 28 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD28, Filter bits
: CAN1_F17DATA0_FD29 ( -- x addr ) 29 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD29, Filter bits
: CAN1_F17DATA0_FD30 ( -- x addr ) 30 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD30, Filter bits
: CAN1_F17DATA0_FD31 ( -- x addr ) 31 bit CAN1_F17DATA0 ; \ CAN1_F17DATA0_FD31, Filter bits

\ CAN1_F17DATA1 (read-write) Reset:0x00000000
: CAN1_F17DATA1_FD0 ( -- x addr ) 0 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD0, Filter bits
: CAN1_F17DATA1_FD1 ( -- x addr ) 1 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD1, Filter bits
: CAN1_F17DATA1_FD2 ( -- x addr ) 2 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD2, Filter bits
: CAN1_F17DATA1_FD3 ( -- x addr ) 3 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD3, Filter bits
: CAN1_F17DATA1_FD4 ( -- x addr ) 4 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD4, Filter bits
: CAN1_F17DATA1_FD5 ( -- x addr ) 5 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD5, Filter bits
: CAN1_F17DATA1_FD6 ( -- x addr ) 6 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD6, Filter bits
: CAN1_F17DATA1_FD7 ( -- x addr ) 7 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD7, Filter bits
: CAN1_F17DATA1_FD8 ( -- x addr ) 8 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD8, Filter bits
: CAN1_F17DATA1_FD9 ( -- x addr ) 9 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD9, Filter bits
: CAN1_F17DATA1_FD10 ( -- x addr ) 10 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD10, Filter bits
: CAN1_F17DATA1_FD11 ( -- x addr ) 11 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD11, Filter bits
: CAN1_F17DATA1_FD12 ( -- x addr ) 12 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD12, Filter bits
: CAN1_F17DATA1_FD13 ( -- x addr ) 13 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD13, Filter bits
: CAN1_F17DATA1_FD14 ( -- x addr ) 14 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD14, Filter bits
: CAN1_F17DATA1_FD15 ( -- x addr ) 15 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD15, Filter bits
: CAN1_F17DATA1_FD16 ( -- x addr ) 16 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD16, Filter bits
: CAN1_F17DATA1_FD17 ( -- x addr ) 17 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD17, Filter bits
: CAN1_F17DATA1_FD18 ( -- x addr ) 18 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD18, Filter bits
: CAN1_F17DATA1_FD19 ( -- x addr ) 19 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD19, Filter bits
: CAN1_F17DATA1_FD20 ( -- x addr ) 20 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD20, Filter bits
: CAN1_F17DATA1_FD21 ( -- x addr ) 21 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD21, Filter bits
: CAN1_F17DATA1_FD22 ( -- x addr ) 22 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD22, Filter bits
: CAN1_F17DATA1_FD23 ( -- x addr ) 23 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD23, Filter bits
: CAN1_F17DATA1_FD24 ( -- x addr ) 24 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD24, Filter bits
: CAN1_F17DATA1_FD25 ( -- x addr ) 25 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD25, Filter bits
: CAN1_F17DATA1_FD26 ( -- x addr ) 26 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD26, Filter bits
: CAN1_F17DATA1_FD27 ( -- x addr ) 27 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD27, Filter bits
: CAN1_F17DATA1_FD28 ( -- x addr ) 28 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD28, Filter bits
: CAN1_F17DATA1_FD29 ( -- x addr ) 29 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD29, Filter bits
: CAN1_F17DATA1_FD30 ( -- x addr ) 30 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD30, Filter bits
: CAN1_F17DATA1_FD31 ( -- x addr ) 31 bit CAN1_F17DATA1 ; \ CAN1_F17DATA1_FD31, Filter bits

\ CAN1_F18DATA0 (read-write) Reset:0x00000000
: CAN1_F18DATA0_FD0 ( -- x addr ) 0 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD0, Filter bits
: CAN1_F18DATA0_FD1 ( -- x addr ) 1 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD1, Filter bits
: CAN1_F18DATA0_FD2 ( -- x addr ) 2 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD2, Filter bits
: CAN1_F18DATA0_FD3 ( -- x addr ) 3 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD3, Filter bits
: CAN1_F18DATA0_FD4 ( -- x addr ) 4 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD4, Filter bits
: CAN1_F18DATA0_FD5 ( -- x addr ) 5 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD5, Filter bits
: CAN1_F18DATA0_FD6 ( -- x addr ) 6 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD6, Filter bits
: CAN1_F18DATA0_FD7 ( -- x addr ) 7 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD7, Filter bits
: CAN1_F18DATA0_FD8 ( -- x addr ) 8 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD8, Filter bits
: CAN1_F18DATA0_FD9 ( -- x addr ) 9 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD9, Filter bits
: CAN1_F18DATA0_FD10 ( -- x addr ) 10 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD10, Filter bits
: CAN1_F18DATA0_FD11 ( -- x addr ) 11 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD11, Filter bits
: CAN1_F18DATA0_FD12 ( -- x addr ) 12 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD12, Filter bits
: CAN1_F18DATA0_FD13 ( -- x addr ) 13 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD13, Filter bits
: CAN1_F18DATA0_FD14 ( -- x addr ) 14 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD14, Filter bits
: CAN1_F18DATA0_FD15 ( -- x addr ) 15 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD15, Filter bits
: CAN1_F18DATA0_FD16 ( -- x addr ) 16 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD16, Filter bits
: CAN1_F18DATA0_FD17 ( -- x addr ) 17 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD17, Filter bits
: CAN1_F18DATA0_FD18 ( -- x addr ) 18 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD18, Filter bits
: CAN1_F18DATA0_FD19 ( -- x addr ) 19 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD19, Filter bits
: CAN1_F18DATA0_FD20 ( -- x addr ) 20 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD20, Filter bits
: CAN1_F18DATA0_FD21 ( -- x addr ) 21 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD21, Filter bits
: CAN1_F18DATA0_FD22 ( -- x addr ) 22 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD22, Filter bits
: CAN1_F18DATA0_FD23 ( -- x addr ) 23 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD23, Filter bits
: CAN1_F18DATA0_FD24 ( -- x addr ) 24 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD24, Filter bits
: CAN1_F18DATA0_FD25 ( -- x addr ) 25 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD25, Filter bits
: CAN1_F18DATA0_FD26 ( -- x addr ) 26 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD26, Filter bits
: CAN1_F18DATA0_FD27 ( -- x addr ) 27 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD27, Filter bits
: CAN1_F18DATA0_FD28 ( -- x addr ) 28 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD28, Filter bits
: CAN1_F18DATA0_FD29 ( -- x addr ) 29 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD29, Filter bits
: CAN1_F18DATA0_FD30 ( -- x addr ) 30 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD30, Filter bits
: CAN1_F18DATA0_FD31 ( -- x addr ) 31 bit CAN1_F18DATA0 ; \ CAN1_F18DATA0_FD31, Filter bits

\ CAN1_F18DATA1 (read-write) Reset:0x00000000
: CAN1_F18DATA1_FD0 ( -- x addr ) 0 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD0, Filter bits
: CAN1_F18DATA1_FD1 ( -- x addr ) 1 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD1, Filter bits
: CAN1_F18DATA1_FD2 ( -- x addr ) 2 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD2, Filter bits
: CAN1_F18DATA1_FD3 ( -- x addr ) 3 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD3, Filter bits
: CAN1_F18DATA1_FD4 ( -- x addr ) 4 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD4, Filter bits
: CAN1_F18DATA1_FD5 ( -- x addr ) 5 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD5, Filter bits
: CAN1_F18DATA1_FD6 ( -- x addr ) 6 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD6, Filter bits
: CAN1_F18DATA1_FD7 ( -- x addr ) 7 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD7, Filter bits
: CAN1_F18DATA1_FD8 ( -- x addr ) 8 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD8, Filter bits
: CAN1_F18DATA1_FD9 ( -- x addr ) 9 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD9, Filter bits
: CAN1_F18DATA1_FD10 ( -- x addr ) 10 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD10, Filter bits
: CAN1_F18DATA1_FD11 ( -- x addr ) 11 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD11, Filter bits
: CAN1_F18DATA1_FD12 ( -- x addr ) 12 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD12, Filter bits
: CAN1_F18DATA1_FD13 ( -- x addr ) 13 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD13, Filter bits
: CAN1_F18DATA1_FD14 ( -- x addr ) 14 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD14, Filter bits
: CAN1_F18DATA1_FD15 ( -- x addr ) 15 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD15, Filter bits
: CAN1_F18DATA1_FD16 ( -- x addr ) 16 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD16, Filter bits
: CAN1_F18DATA1_FD17 ( -- x addr ) 17 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD17, Filter bits
: CAN1_F18DATA1_FD18 ( -- x addr ) 18 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD18, Filter bits
: CAN1_F18DATA1_FD19 ( -- x addr ) 19 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD19, Filter bits
: CAN1_F18DATA1_FD20 ( -- x addr ) 20 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD20, Filter bits
: CAN1_F18DATA1_FD21 ( -- x addr ) 21 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD21, Filter bits
: CAN1_F18DATA1_FD22 ( -- x addr ) 22 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD22, Filter bits
: CAN1_F18DATA1_FD23 ( -- x addr ) 23 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD23, Filter bits
: CAN1_F18DATA1_FD24 ( -- x addr ) 24 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD24, Filter bits
: CAN1_F18DATA1_FD25 ( -- x addr ) 25 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD25, Filter bits
: CAN1_F18DATA1_FD26 ( -- x addr ) 26 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD26, Filter bits
: CAN1_F18DATA1_FD27 ( -- x addr ) 27 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD27, Filter bits
: CAN1_F18DATA1_FD28 ( -- x addr ) 28 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD28, Filter bits
: CAN1_F18DATA1_FD29 ( -- x addr ) 29 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD29, Filter bits
: CAN1_F18DATA1_FD30 ( -- x addr ) 30 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD30, Filter bits
: CAN1_F18DATA1_FD31 ( -- x addr ) 31 bit CAN1_F18DATA1 ; \ CAN1_F18DATA1_FD31, Filter bits

\ CAN1_F19DATA0 (read-write) Reset:0x00000000
: CAN1_F19DATA0_FD0 ( -- x addr ) 0 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD0, Filter bits
: CAN1_F19DATA0_FD1 ( -- x addr ) 1 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD1, Filter bits
: CAN1_F19DATA0_FD2 ( -- x addr ) 2 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD2, Filter bits
: CAN1_F19DATA0_FD3 ( -- x addr ) 3 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD3, Filter bits
: CAN1_F19DATA0_FD4 ( -- x addr ) 4 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD4, Filter bits
: CAN1_F19DATA0_FD5 ( -- x addr ) 5 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD5, Filter bits
: CAN1_F19DATA0_FD6 ( -- x addr ) 6 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD6, Filter bits
: CAN1_F19DATA0_FD7 ( -- x addr ) 7 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD7, Filter bits
: CAN1_F19DATA0_FD8 ( -- x addr ) 8 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD8, Filter bits
: CAN1_F19DATA0_FD9 ( -- x addr ) 9 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD9, Filter bits
: CAN1_F19DATA0_FD10 ( -- x addr ) 10 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD10, Filter bits
: CAN1_F19DATA0_FD11 ( -- x addr ) 11 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD11, Filter bits
: CAN1_F19DATA0_FD12 ( -- x addr ) 12 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD12, Filter bits
: CAN1_F19DATA0_FD13 ( -- x addr ) 13 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD13, Filter bits
: CAN1_F19DATA0_FD14 ( -- x addr ) 14 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD14, Filter bits
: CAN1_F19DATA0_FD15 ( -- x addr ) 15 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD15, Filter bits
: CAN1_F19DATA0_FD16 ( -- x addr ) 16 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD16, Filter bits
: CAN1_F19DATA0_FD17 ( -- x addr ) 17 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD17, Filter bits
: CAN1_F19DATA0_FD18 ( -- x addr ) 18 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD18, Filter bits
: CAN1_F19DATA0_FD19 ( -- x addr ) 19 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD19, Filter bits
: CAN1_F19DATA0_FD20 ( -- x addr ) 20 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD20, Filter bits
: CAN1_F19DATA0_FD21 ( -- x addr ) 21 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD21, Filter bits
: CAN1_F19DATA0_FD22 ( -- x addr ) 22 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD22, Filter bits
: CAN1_F19DATA0_FD23 ( -- x addr ) 23 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD23, Filter bits
: CAN1_F19DATA0_FD24 ( -- x addr ) 24 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD24, Filter bits
: CAN1_F19DATA0_FD25 ( -- x addr ) 25 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD25, Filter bits
: CAN1_F19DATA0_FD26 ( -- x addr ) 26 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD26, Filter bits
: CAN1_F19DATA0_FD27 ( -- x addr ) 27 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD27, Filter bits
: CAN1_F19DATA0_FD28 ( -- x addr ) 28 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD28, Filter bits
: CAN1_F19DATA0_FD29 ( -- x addr ) 29 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD29, Filter bits
: CAN1_F19DATA0_FD30 ( -- x addr ) 30 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD30, Filter bits
: CAN1_F19DATA0_FD31 ( -- x addr ) 31 bit CAN1_F19DATA0 ; \ CAN1_F19DATA0_FD31, Filter bits

\ CAN1_F19DATA1 (read-write) Reset:0x00000000
: CAN1_F19DATA1_FD0 ( -- x addr ) 0 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD0, Filter bits
: CAN1_F19DATA1_FD1 ( -- x addr ) 1 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD1, Filter bits
: CAN1_F19DATA1_FD2 ( -- x addr ) 2 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD2, Filter bits
: CAN1_F19DATA1_FD3 ( -- x addr ) 3 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD3, Filter bits
: CAN1_F19DATA1_FD4 ( -- x addr ) 4 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD4, Filter bits
: CAN1_F19DATA1_FD5 ( -- x addr ) 5 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD5, Filter bits
: CAN1_F19DATA1_FD6 ( -- x addr ) 6 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD6, Filter bits
: CAN1_F19DATA1_FD7 ( -- x addr ) 7 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD7, Filter bits
: CAN1_F19DATA1_FD8 ( -- x addr ) 8 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD8, Filter bits
: CAN1_F19DATA1_FD9 ( -- x addr ) 9 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD9, Filter bits
: CAN1_F19DATA1_FD10 ( -- x addr ) 10 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD10, Filter bits
: CAN1_F19DATA1_FD11 ( -- x addr ) 11 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD11, Filter bits
: CAN1_F19DATA1_FD12 ( -- x addr ) 12 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD12, Filter bits
: CAN1_F19DATA1_FD13 ( -- x addr ) 13 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD13, Filter bits
: CAN1_F19DATA1_FD14 ( -- x addr ) 14 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD14, Filter bits
: CAN1_F19DATA1_FD15 ( -- x addr ) 15 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD15, Filter bits
: CAN1_F19DATA1_FD16 ( -- x addr ) 16 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD16, Filter bits
: CAN1_F19DATA1_FD17 ( -- x addr ) 17 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD17, Filter bits
: CAN1_F19DATA1_FD18 ( -- x addr ) 18 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD18, Filter bits
: CAN1_F19DATA1_FD19 ( -- x addr ) 19 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD19, Filter bits
: CAN1_F19DATA1_FD20 ( -- x addr ) 20 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD20, Filter bits
: CAN1_F19DATA1_FD21 ( -- x addr ) 21 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD21, Filter bits
: CAN1_F19DATA1_FD22 ( -- x addr ) 22 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD22, Filter bits
: CAN1_F19DATA1_FD23 ( -- x addr ) 23 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD23, Filter bits
: CAN1_F19DATA1_FD24 ( -- x addr ) 24 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD24, Filter bits
: CAN1_F19DATA1_FD25 ( -- x addr ) 25 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD25, Filter bits
: CAN1_F19DATA1_FD26 ( -- x addr ) 26 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD26, Filter bits
: CAN1_F19DATA1_FD27 ( -- x addr ) 27 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD27, Filter bits
: CAN1_F19DATA1_FD28 ( -- x addr ) 28 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD28, Filter bits
: CAN1_F19DATA1_FD29 ( -- x addr ) 29 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD29, Filter bits
: CAN1_F19DATA1_FD30 ( -- x addr ) 30 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD30, Filter bits
: CAN1_F19DATA1_FD31 ( -- x addr ) 31 bit CAN1_F19DATA1 ; \ CAN1_F19DATA1_FD31, Filter bits

\ CAN1_F20DATA0 (read-write) Reset:0x00000000
: CAN1_F20DATA0_FD0 ( -- x addr ) 0 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD0, Filter bits
: CAN1_F20DATA0_FD1 ( -- x addr ) 1 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD1, Filter bits
: CAN1_F20DATA0_FD2 ( -- x addr ) 2 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD2, Filter bits
: CAN1_F20DATA0_FD3 ( -- x addr ) 3 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD3, Filter bits
: CAN1_F20DATA0_FD4 ( -- x addr ) 4 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD4, Filter bits
: CAN1_F20DATA0_FD5 ( -- x addr ) 5 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD5, Filter bits
: CAN1_F20DATA0_FD6 ( -- x addr ) 6 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD6, Filter bits
: CAN1_F20DATA0_FD7 ( -- x addr ) 7 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD7, Filter bits
: CAN1_F20DATA0_FD8 ( -- x addr ) 8 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD8, Filter bits
: CAN1_F20DATA0_FD9 ( -- x addr ) 9 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD9, Filter bits
: CAN1_F20DATA0_FD10 ( -- x addr ) 10 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD10, Filter bits
: CAN1_F20DATA0_FD11 ( -- x addr ) 11 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD11, Filter bits
: CAN1_F20DATA0_FD12 ( -- x addr ) 12 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD12, Filter bits
: CAN1_F20DATA0_FD13 ( -- x addr ) 13 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD13, Filter bits
: CAN1_F20DATA0_FD14 ( -- x addr ) 14 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD14, Filter bits
: CAN1_F20DATA0_FD15 ( -- x addr ) 15 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD15, Filter bits
: CAN1_F20DATA0_FD16 ( -- x addr ) 16 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD16, Filter bits
: CAN1_F20DATA0_FD17 ( -- x addr ) 17 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD17, Filter bits
: CAN1_F20DATA0_FD18 ( -- x addr ) 18 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD18, Filter bits
: CAN1_F20DATA0_FD19 ( -- x addr ) 19 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD19, Filter bits
: CAN1_F20DATA0_FD20 ( -- x addr ) 20 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD20, Filter bits
: CAN1_F20DATA0_FD21 ( -- x addr ) 21 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD21, Filter bits
: CAN1_F20DATA0_FD22 ( -- x addr ) 22 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD22, Filter bits
: CAN1_F20DATA0_FD23 ( -- x addr ) 23 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD23, Filter bits
: CAN1_F20DATA0_FD24 ( -- x addr ) 24 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD24, Filter bits
: CAN1_F20DATA0_FD25 ( -- x addr ) 25 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD25, Filter bits
: CAN1_F20DATA0_FD26 ( -- x addr ) 26 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD26, Filter bits
: CAN1_F20DATA0_FD27 ( -- x addr ) 27 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD27, Filter bits
: CAN1_F20DATA0_FD28 ( -- x addr ) 28 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD28, Filter bits
: CAN1_F20DATA0_FD29 ( -- x addr ) 29 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD29, Filter bits
: CAN1_F20DATA0_FD30 ( -- x addr ) 30 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD30, Filter bits
: CAN1_F20DATA0_FD31 ( -- x addr ) 31 bit CAN1_F20DATA0 ; \ CAN1_F20DATA0_FD31, Filter bits

\ CAN1_F20DATA1 (read-write) Reset:0x00000000
: CAN1_F20DATA1_FD0 ( -- x addr ) 0 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD0, Filter bits
: CAN1_F20DATA1_FD1 ( -- x addr ) 1 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD1, Filter bits
: CAN1_F20DATA1_FD2 ( -- x addr ) 2 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD2, Filter bits
: CAN1_F20DATA1_FD3 ( -- x addr ) 3 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD3, Filter bits
: CAN1_F20DATA1_FD4 ( -- x addr ) 4 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD4, Filter bits
: CAN1_F20DATA1_FD5 ( -- x addr ) 5 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD5, Filter bits
: CAN1_F20DATA1_FD6 ( -- x addr ) 6 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD6, Filter bits
: CAN1_F20DATA1_FD7 ( -- x addr ) 7 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD7, Filter bits
: CAN1_F20DATA1_FD8 ( -- x addr ) 8 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD8, Filter bits
: CAN1_F20DATA1_FD9 ( -- x addr ) 9 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD9, Filter bits
: CAN1_F20DATA1_FD10 ( -- x addr ) 10 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD10, Filter bits
: CAN1_F20DATA1_FD11 ( -- x addr ) 11 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD11, Filter bits
: CAN1_F20DATA1_FD12 ( -- x addr ) 12 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD12, Filter bits
: CAN1_F20DATA1_FD13 ( -- x addr ) 13 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD13, Filter bits
: CAN1_F20DATA1_FD14 ( -- x addr ) 14 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD14, Filter bits
: CAN1_F20DATA1_FD15 ( -- x addr ) 15 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD15, Filter bits
: CAN1_F20DATA1_FD16 ( -- x addr ) 16 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD16, Filter bits
: CAN1_F20DATA1_FD17 ( -- x addr ) 17 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD17, Filter bits
: CAN1_F20DATA1_FD18 ( -- x addr ) 18 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD18, Filter bits
: CAN1_F20DATA1_FD19 ( -- x addr ) 19 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD19, Filter bits
: CAN1_F20DATA1_FD20 ( -- x addr ) 20 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD20, Filter bits
: CAN1_F20DATA1_FD21 ( -- x addr ) 21 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD21, Filter bits
: CAN1_F20DATA1_FD22 ( -- x addr ) 22 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD22, Filter bits
: CAN1_F20DATA1_FD23 ( -- x addr ) 23 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD23, Filter bits
: CAN1_F20DATA1_FD24 ( -- x addr ) 24 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD24, Filter bits
: CAN1_F20DATA1_FD25 ( -- x addr ) 25 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD25, Filter bits
: CAN1_F20DATA1_FD26 ( -- x addr ) 26 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD26, Filter bits
: CAN1_F20DATA1_FD27 ( -- x addr ) 27 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD27, Filter bits
: CAN1_F20DATA1_FD28 ( -- x addr ) 28 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD28, Filter bits
: CAN1_F20DATA1_FD29 ( -- x addr ) 29 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD29, Filter bits
: CAN1_F20DATA1_FD30 ( -- x addr ) 30 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD30, Filter bits
: CAN1_F20DATA1_FD31 ( -- x addr ) 31 bit CAN1_F20DATA1 ; \ CAN1_F20DATA1_FD31, Filter bits

\ CAN1_F21DATA0 (read-write) Reset:0x00000000
: CAN1_F21DATA0_FD0 ( -- x addr ) 0 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD0, Filter bits
: CAN1_F21DATA0_FD1 ( -- x addr ) 1 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD1, Filter bits
: CAN1_F21DATA0_FD2 ( -- x addr ) 2 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD2, Filter bits
: CAN1_F21DATA0_FD3 ( -- x addr ) 3 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD3, Filter bits
: CAN1_F21DATA0_FD4 ( -- x addr ) 4 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD4, Filter bits
: CAN1_F21DATA0_FD5 ( -- x addr ) 5 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD5, Filter bits
: CAN1_F21DATA0_FD6 ( -- x addr ) 6 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD6, Filter bits
: CAN1_F21DATA0_FD7 ( -- x addr ) 7 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD7, Filter bits
: CAN1_F21DATA0_FD8 ( -- x addr ) 8 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD8, Filter bits
: CAN1_F21DATA0_FD9 ( -- x addr ) 9 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD9, Filter bits
: CAN1_F21DATA0_FD10 ( -- x addr ) 10 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD10, Filter bits
: CAN1_F21DATA0_FD11 ( -- x addr ) 11 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD11, Filter bits
: CAN1_F21DATA0_FD12 ( -- x addr ) 12 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD12, Filter bits
: CAN1_F21DATA0_FD13 ( -- x addr ) 13 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD13, Filter bits
: CAN1_F21DATA0_FD14 ( -- x addr ) 14 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD14, Filter bits
: CAN1_F21DATA0_FD15 ( -- x addr ) 15 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD15, Filter bits
: CAN1_F21DATA0_FD16 ( -- x addr ) 16 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD16, Filter bits
: CAN1_F21DATA0_FD17 ( -- x addr ) 17 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD17, Filter bits
: CAN1_F21DATA0_FD18 ( -- x addr ) 18 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD18, Filter bits
: CAN1_F21DATA0_FD19 ( -- x addr ) 19 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD19, Filter bits
: CAN1_F21DATA0_FD20 ( -- x addr ) 20 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD20, Filter bits
: CAN1_F21DATA0_FD21 ( -- x addr ) 21 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD21, Filter bits
: CAN1_F21DATA0_FD22 ( -- x addr ) 22 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD22, Filter bits
: CAN1_F21DATA0_FD23 ( -- x addr ) 23 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD23, Filter bits
: CAN1_F21DATA0_FD24 ( -- x addr ) 24 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD24, Filter bits
: CAN1_F21DATA0_FD25 ( -- x addr ) 25 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD25, Filter bits
: CAN1_F21DATA0_FD26 ( -- x addr ) 26 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD26, Filter bits
: CAN1_F21DATA0_FD27 ( -- x addr ) 27 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD27, Filter bits
: CAN1_F21DATA0_FD28 ( -- x addr ) 28 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD28, Filter bits
: CAN1_F21DATA0_FD29 ( -- x addr ) 29 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD29, Filter bits
: CAN1_F21DATA0_FD30 ( -- x addr ) 30 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD30, Filter bits
: CAN1_F21DATA0_FD31 ( -- x addr ) 31 bit CAN1_F21DATA0 ; \ CAN1_F21DATA0_FD31, Filter bits

\ CAN1_F21DATA1 (read-write) Reset:0x00000000
: CAN1_F21DATA1_FD0 ( -- x addr ) 0 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD0, Filter bits
: CAN1_F21DATA1_FD1 ( -- x addr ) 1 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD1, Filter bits
: CAN1_F21DATA1_FD2 ( -- x addr ) 2 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD2, Filter bits
: CAN1_F21DATA1_FD3 ( -- x addr ) 3 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD3, Filter bits
: CAN1_F21DATA1_FD4 ( -- x addr ) 4 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD4, Filter bits
: CAN1_F21DATA1_FD5 ( -- x addr ) 5 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD5, Filter bits
: CAN1_F21DATA1_FD6 ( -- x addr ) 6 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD6, Filter bits
: CAN1_F21DATA1_FD7 ( -- x addr ) 7 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD7, Filter bits
: CAN1_F21DATA1_FD8 ( -- x addr ) 8 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD8, Filter bits
: CAN1_F21DATA1_FD9 ( -- x addr ) 9 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD9, Filter bits
: CAN1_F21DATA1_FD10 ( -- x addr ) 10 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD10, Filter bits
: CAN1_F21DATA1_FD11 ( -- x addr ) 11 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD11, Filter bits
: CAN1_F21DATA1_FD12 ( -- x addr ) 12 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD12, Filter bits
: CAN1_F21DATA1_FD13 ( -- x addr ) 13 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD13, Filter bits
: CAN1_F21DATA1_FD14 ( -- x addr ) 14 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD14, Filter bits
: CAN1_F21DATA1_FD15 ( -- x addr ) 15 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD15, Filter bits
: CAN1_F21DATA1_FD16 ( -- x addr ) 16 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD16, Filter bits
: CAN1_F21DATA1_FD17 ( -- x addr ) 17 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD17, Filter bits
: CAN1_F21DATA1_FD18 ( -- x addr ) 18 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD18, Filter bits
: CAN1_F21DATA1_FD19 ( -- x addr ) 19 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD19, Filter bits
: CAN1_F21DATA1_FD20 ( -- x addr ) 20 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD20, Filter bits
: CAN1_F21DATA1_FD21 ( -- x addr ) 21 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD21, Filter bits
: CAN1_F21DATA1_FD22 ( -- x addr ) 22 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD22, Filter bits
: CAN1_F21DATA1_FD23 ( -- x addr ) 23 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD23, Filter bits
: CAN1_F21DATA1_FD24 ( -- x addr ) 24 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD24, Filter bits
: CAN1_F21DATA1_FD25 ( -- x addr ) 25 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD25, Filter bits
: CAN1_F21DATA1_FD26 ( -- x addr ) 26 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD26, Filter bits
: CAN1_F21DATA1_FD27 ( -- x addr ) 27 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD27, Filter bits
: CAN1_F21DATA1_FD28 ( -- x addr ) 28 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD28, Filter bits
: CAN1_F21DATA1_FD29 ( -- x addr ) 29 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD29, Filter bits
: CAN1_F21DATA1_FD30 ( -- x addr ) 30 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD30, Filter bits
: CAN1_F21DATA1_FD31 ( -- x addr ) 31 bit CAN1_F21DATA1 ; \ CAN1_F21DATA1_FD31, Filter bits

\ CAN1_F22DATA0 (read-write) Reset:0x00000000
: CAN1_F22DATA0_FD0 ( -- x addr ) 0 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD0, Filter bits
: CAN1_F22DATA0_FD1 ( -- x addr ) 1 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD1, Filter bits
: CAN1_F22DATA0_FD2 ( -- x addr ) 2 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD2, Filter bits
: CAN1_F22DATA0_FD3 ( -- x addr ) 3 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD3, Filter bits
: CAN1_F22DATA0_FD4 ( -- x addr ) 4 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD4, Filter bits
: CAN1_F22DATA0_FD5 ( -- x addr ) 5 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD5, Filter bits
: CAN1_F22DATA0_FD6 ( -- x addr ) 6 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD6, Filter bits
: CAN1_F22DATA0_FD7 ( -- x addr ) 7 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD7, Filter bits
: CAN1_F22DATA0_FD8 ( -- x addr ) 8 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD8, Filter bits
: CAN1_F22DATA0_FD9 ( -- x addr ) 9 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD9, Filter bits
: CAN1_F22DATA0_FD10 ( -- x addr ) 10 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD10, Filter bits
: CAN1_F22DATA0_FD11 ( -- x addr ) 11 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD11, Filter bits
: CAN1_F22DATA0_FD12 ( -- x addr ) 12 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD12, Filter bits
: CAN1_F22DATA0_FD13 ( -- x addr ) 13 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD13, Filter bits
: CAN1_F22DATA0_FD14 ( -- x addr ) 14 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD14, Filter bits
: CAN1_F22DATA0_FD15 ( -- x addr ) 15 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD15, Filter bits
: CAN1_F22DATA0_FD16 ( -- x addr ) 16 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD16, Filter bits
: CAN1_F22DATA0_FD17 ( -- x addr ) 17 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD17, Filter bits
: CAN1_F22DATA0_FD18 ( -- x addr ) 18 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD18, Filter bits
: CAN1_F22DATA0_FD19 ( -- x addr ) 19 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD19, Filter bits
: CAN1_F22DATA0_FD20 ( -- x addr ) 20 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD20, Filter bits
: CAN1_F22DATA0_FD21 ( -- x addr ) 21 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD21, Filter bits
: CAN1_F22DATA0_FD22 ( -- x addr ) 22 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD22, Filter bits
: CAN1_F22DATA0_FD23 ( -- x addr ) 23 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD23, Filter bits
: CAN1_F22DATA0_FD24 ( -- x addr ) 24 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD24, Filter bits
: CAN1_F22DATA0_FD25 ( -- x addr ) 25 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD25, Filter bits
: CAN1_F22DATA0_FD26 ( -- x addr ) 26 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD26, Filter bits
: CAN1_F22DATA0_FD27 ( -- x addr ) 27 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD27, Filter bits
: CAN1_F22DATA0_FD28 ( -- x addr ) 28 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD28, Filter bits
: CAN1_F22DATA0_FD29 ( -- x addr ) 29 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD29, Filter bits
: CAN1_F22DATA0_FD30 ( -- x addr ) 30 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD30, Filter bits
: CAN1_F22DATA0_FD31 ( -- x addr ) 31 bit CAN1_F22DATA0 ; \ CAN1_F22DATA0_FD31, Filter bits

\ CAN1_F22DATA1 (read-write) Reset:0x00000000
: CAN1_F22DATA1_FD0 ( -- x addr ) 0 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD0, Filter bits
: CAN1_F22DATA1_FD1 ( -- x addr ) 1 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD1, Filter bits
: CAN1_F22DATA1_FD2 ( -- x addr ) 2 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD2, Filter bits
: CAN1_F22DATA1_FD3 ( -- x addr ) 3 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD3, Filter bits
: CAN1_F22DATA1_FD4 ( -- x addr ) 4 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD4, Filter bits
: CAN1_F22DATA1_FD5 ( -- x addr ) 5 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD5, Filter bits
: CAN1_F22DATA1_FD6 ( -- x addr ) 6 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD6, Filter bits
: CAN1_F22DATA1_FD7 ( -- x addr ) 7 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD7, Filter bits
: CAN1_F22DATA1_FD8 ( -- x addr ) 8 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD8, Filter bits
: CAN1_F22DATA1_FD9 ( -- x addr ) 9 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD9, Filter bits
: CAN1_F22DATA1_FD10 ( -- x addr ) 10 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD10, Filter bits
: CAN1_F22DATA1_FD11 ( -- x addr ) 11 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD11, Filter bits
: CAN1_F22DATA1_FD12 ( -- x addr ) 12 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD12, Filter bits
: CAN1_F22DATA1_FD13 ( -- x addr ) 13 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD13, Filter bits
: CAN1_F22DATA1_FD14 ( -- x addr ) 14 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD14, Filter bits
: CAN1_F22DATA1_FD15 ( -- x addr ) 15 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD15, Filter bits
: CAN1_F22DATA1_FD16 ( -- x addr ) 16 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD16, Filter bits
: CAN1_F22DATA1_FD17 ( -- x addr ) 17 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD17, Filter bits
: CAN1_F22DATA1_FD18 ( -- x addr ) 18 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD18, Filter bits
: CAN1_F22DATA1_FD19 ( -- x addr ) 19 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD19, Filter bits
: CAN1_F22DATA1_FD20 ( -- x addr ) 20 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD20, Filter bits
: CAN1_F22DATA1_FD21 ( -- x addr ) 21 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD21, Filter bits
: CAN1_F22DATA1_FD22 ( -- x addr ) 22 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD22, Filter bits
: CAN1_F22DATA1_FD23 ( -- x addr ) 23 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD23, Filter bits
: CAN1_F22DATA1_FD24 ( -- x addr ) 24 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD24, Filter bits
: CAN1_F22DATA1_FD25 ( -- x addr ) 25 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD25, Filter bits
: CAN1_F22DATA1_FD26 ( -- x addr ) 26 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD26, Filter bits
: CAN1_F22DATA1_FD27 ( -- x addr ) 27 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD27, Filter bits
: CAN1_F22DATA1_FD28 ( -- x addr ) 28 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD28, Filter bits
: CAN1_F22DATA1_FD29 ( -- x addr ) 29 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD29, Filter bits
: CAN1_F22DATA1_FD30 ( -- x addr ) 30 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD30, Filter bits
: CAN1_F22DATA1_FD31 ( -- x addr ) 31 bit CAN1_F22DATA1 ; \ CAN1_F22DATA1_FD31, Filter bits

\ CAN1_F23DATA0 (read-write) Reset:0x00000000
: CAN1_F23DATA0_FD0 ( -- x addr ) 0 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD0, Filter bits
: CAN1_F23DATA0_FD1 ( -- x addr ) 1 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD1, Filter bits
: CAN1_F23DATA0_FD2 ( -- x addr ) 2 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD2, Filter bits
: CAN1_F23DATA0_FD3 ( -- x addr ) 3 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD3, Filter bits
: CAN1_F23DATA0_FD4 ( -- x addr ) 4 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD4, Filter bits
: CAN1_F23DATA0_FD5 ( -- x addr ) 5 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD5, Filter bits
: CAN1_F23DATA0_FD6 ( -- x addr ) 6 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD6, Filter bits
: CAN1_F23DATA0_FD7 ( -- x addr ) 7 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD7, Filter bits
: CAN1_F23DATA0_FD8 ( -- x addr ) 8 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD8, Filter bits
: CAN1_F23DATA0_FD9 ( -- x addr ) 9 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD9, Filter bits
: CAN1_F23DATA0_FD10 ( -- x addr ) 10 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD10, Filter bits
: CAN1_F23DATA0_FD11 ( -- x addr ) 11 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD11, Filter bits
: CAN1_F23DATA0_FD12 ( -- x addr ) 12 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD12, Filter bits
: CAN1_F23DATA0_FD13 ( -- x addr ) 13 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD13, Filter bits
: CAN1_F23DATA0_FD14 ( -- x addr ) 14 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD14, Filter bits
: CAN1_F23DATA0_FD15 ( -- x addr ) 15 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD15, Filter bits
: CAN1_F23DATA0_FD16 ( -- x addr ) 16 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD16, Filter bits
: CAN1_F23DATA0_FD17 ( -- x addr ) 17 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD17, Filter bits
: CAN1_F23DATA0_FD18 ( -- x addr ) 18 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD18, Filter bits
: CAN1_F23DATA0_FD19 ( -- x addr ) 19 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD19, Filter bits
: CAN1_F23DATA0_FD20 ( -- x addr ) 20 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD20, Filter bits
: CAN1_F23DATA0_FD21 ( -- x addr ) 21 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD21, Filter bits
: CAN1_F23DATA0_FD22 ( -- x addr ) 22 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD22, Filter bits
: CAN1_F23DATA0_FD23 ( -- x addr ) 23 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD23, Filter bits
: CAN1_F23DATA0_FD24 ( -- x addr ) 24 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD24, Filter bits
: CAN1_F23DATA0_FD25 ( -- x addr ) 25 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD25, Filter bits
: CAN1_F23DATA0_FD26 ( -- x addr ) 26 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD26, Filter bits
: CAN1_F23DATA0_FD27 ( -- x addr ) 27 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD27, Filter bits
: CAN1_F23DATA0_FD28 ( -- x addr ) 28 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD28, Filter bits
: CAN1_F23DATA0_FD29 ( -- x addr ) 29 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD29, Filter bits
: CAN1_F23DATA0_FD30 ( -- x addr ) 30 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD30, Filter bits
: CAN1_F23DATA0_FD31 ( -- x addr ) 31 bit CAN1_F23DATA0 ; \ CAN1_F23DATA0_FD31, Filter bits

\ CAN1_F23DATA1 (read-write) Reset:0x00000000
: CAN1_F23DATA1_FD0 ( -- x addr ) 0 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD0, Filter bits
: CAN1_F23DATA1_FD1 ( -- x addr ) 1 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD1, Filter bits
: CAN1_F23DATA1_FD2 ( -- x addr ) 2 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD2, Filter bits
: CAN1_F23DATA1_FD3 ( -- x addr ) 3 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD3, Filter bits
: CAN1_F23DATA1_FD4 ( -- x addr ) 4 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD4, Filter bits
: CAN1_F23DATA1_FD5 ( -- x addr ) 5 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD5, Filter bits
: CAN1_F23DATA1_FD6 ( -- x addr ) 6 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD6, Filter bits
: CAN1_F23DATA1_FD7 ( -- x addr ) 7 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD7, Filter bits
: CAN1_F23DATA1_FD8 ( -- x addr ) 8 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD8, Filter bits
: CAN1_F23DATA1_FD9 ( -- x addr ) 9 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD9, Filter bits
: CAN1_F23DATA1_FD10 ( -- x addr ) 10 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD10, Filter bits
: CAN1_F23DATA1_FD11 ( -- x addr ) 11 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD11, Filter bits
: CAN1_F23DATA1_FD12 ( -- x addr ) 12 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD12, Filter bits
: CAN1_F23DATA1_FD13 ( -- x addr ) 13 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD13, Filter bits
: CAN1_F23DATA1_FD14 ( -- x addr ) 14 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD14, Filter bits
: CAN1_F23DATA1_FD15 ( -- x addr ) 15 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD15, Filter bits
: CAN1_F23DATA1_FD16 ( -- x addr ) 16 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD16, Filter bits
: CAN1_F23DATA1_FD17 ( -- x addr ) 17 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD17, Filter bits
: CAN1_F23DATA1_FD18 ( -- x addr ) 18 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD18, Filter bits
: CAN1_F23DATA1_FD19 ( -- x addr ) 19 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD19, Filter bits
: CAN1_F23DATA1_FD20 ( -- x addr ) 20 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD20, Filter bits
: CAN1_F23DATA1_FD21 ( -- x addr ) 21 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD21, Filter bits
: CAN1_F23DATA1_FD22 ( -- x addr ) 22 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD22, Filter bits
: CAN1_F23DATA1_FD23 ( -- x addr ) 23 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD23, Filter bits
: CAN1_F23DATA1_FD24 ( -- x addr ) 24 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD24, Filter bits
: CAN1_F23DATA1_FD25 ( -- x addr ) 25 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD25, Filter bits
: CAN1_F23DATA1_FD26 ( -- x addr ) 26 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD26, Filter bits
: CAN1_F23DATA1_FD27 ( -- x addr ) 27 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD27, Filter bits
: CAN1_F23DATA1_FD28 ( -- x addr ) 28 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD28, Filter bits
: CAN1_F23DATA1_FD29 ( -- x addr ) 29 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD29, Filter bits
: CAN1_F23DATA1_FD30 ( -- x addr ) 30 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD30, Filter bits
: CAN1_F23DATA1_FD31 ( -- x addr ) 31 bit CAN1_F23DATA1 ; \ CAN1_F23DATA1_FD31, Filter bits

\ CAN1_F24DATA0 (read-write) Reset:0x00000000
: CAN1_F24DATA0_FD0 ( -- x addr ) 0 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD0, Filter bits
: CAN1_F24DATA0_FD1 ( -- x addr ) 1 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD1, Filter bits
: CAN1_F24DATA0_FD2 ( -- x addr ) 2 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD2, Filter bits
: CAN1_F24DATA0_FD3 ( -- x addr ) 3 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD3, Filter bits
: CAN1_F24DATA0_FD4 ( -- x addr ) 4 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD4, Filter bits
: CAN1_F24DATA0_FD5 ( -- x addr ) 5 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD5, Filter bits
: CAN1_F24DATA0_FD6 ( -- x addr ) 6 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD6, Filter bits
: CAN1_F24DATA0_FD7 ( -- x addr ) 7 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD7, Filter bits
: CAN1_F24DATA0_FD8 ( -- x addr ) 8 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD8, Filter bits
: CAN1_F24DATA0_FD9 ( -- x addr ) 9 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD9, Filter bits
: CAN1_F24DATA0_FD10 ( -- x addr ) 10 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD10, Filter bits
: CAN1_F24DATA0_FD11 ( -- x addr ) 11 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD11, Filter bits
: CAN1_F24DATA0_FD12 ( -- x addr ) 12 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD12, Filter bits
: CAN1_F24DATA0_FD13 ( -- x addr ) 13 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD13, Filter bits
: CAN1_F24DATA0_FD14 ( -- x addr ) 14 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD14, Filter bits
: CAN1_F24DATA0_FD15 ( -- x addr ) 15 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD15, Filter bits
: CAN1_F24DATA0_FD16 ( -- x addr ) 16 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD16, Filter bits
: CAN1_F24DATA0_FD17 ( -- x addr ) 17 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD17, Filter bits
: CAN1_F24DATA0_FD18 ( -- x addr ) 18 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD18, Filter bits
: CAN1_F24DATA0_FD19 ( -- x addr ) 19 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD19, Filter bits
: CAN1_F24DATA0_FD20 ( -- x addr ) 20 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD20, Filter bits
: CAN1_F24DATA0_FD21 ( -- x addr ) 21 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD21, Filter bits
: CAN1_F24DATA0_FD22 ( -- x addr ) 22 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD22, Filter bits
: CAN1_F24DATA0_FD23 ( -- x addr ) 23 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD23, Filter bits
: CAN1_F24DATA0_FD24 ( -- x addr ) 24 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD24, Filter bits
: CAN1_F24DATA0_FD25 ( -- x addr ) 25 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD25, Filter bits
: CAN1_F24DATA0_FD26 ( -- x addr ) 26 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD26, Filter bits
: CAN1_F24DATA0_FD27 ( -- x addr ) 27 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD27, Filter bits
: CAN1_F24DATA0_FD28 ( -- x addr ) 28 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD28, Filter bits
: CAN1_F24DATA0_FD29 ( -- x addr ) 29 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD29, Filter bits
: CAN1_F24DATA0_FD30 ( -- x addr ) 30 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD30, Filter bits
: CAN1_F24DATA0_FD31 ( -- x addr ) 31 bit CAN1_F24DATA0 ; \ CAN1_F24DATA0_FD31, Filter bits

\ CAN1_F24DATA1 (read-write) Reset:0x00000000
: CAN1_F24DATA1_FD0 ( -- x addr ) 0 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD0, Filter bits
: CAN1_F24DATA1_FD1 ( -- x addr ) 1 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD1, Filter bits
: CAN1_F24DATA1_FD2 ( -- x addr ) 2 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD2, Filter bits
: CAN1_F24DATA1_FD3 ( -- x addr ) 3 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD3, Filter bits
: CAN1_F24DATA1_FD4 ( -- x addr ) 4 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD4, Filter bits
: CAN1_F24DATA1_FD5 ( -- x addr ) 5 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD5, Filter bits
: CAN1_F24DATA1_FD6 ( -- x addr ) 6 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD6, Filter bits
: CAN1_F24DATA1_FD7 ( -- x addr ) 7 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD7, Filter bits
: CAN1_F24DATA1_FD8 ( -- x addr ) 8 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD8, Filter bits
: CAN1_F24DATA1_FD9 ( -- x addr ) 9 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD9, Filter bits
: CAN1_F24DATA1_FD10 ( -- x addr ) 10 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD10, Filter bits
: CAN1_F24DATA1_FD11 ( -- x addr ) 11 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD11, Filter bits
: CAN1_F24DATA1_FD12 ( -- x addr ) 12 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD12, Filter bits
: CAN1_F24DATA1_FD13 ( -- x addr ) 13 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD13, Filter bits
: CAN1_F24DATA1_FD14 ( -- x addr ) 14 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD14, Filter bits
: CAN1_F24DATA1_FD15 ( -- x addr ) 15 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD15, Filter bits
: CAN1_F24DATA1_FD16 ( -- x addr ) 16 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD16, Filter bits
: CAN1_F24DATA1_FD17 ( -- x addr ) 17 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD17, Filter bits
: CAN1_F24DATA1_FD18 ( -- x addr ) 18 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD18, Filter bits
: CAN1_F24DATA1_FD19 ( -- x addr ) 19 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD19, Filter bits
: CAN1_F24DATA1_FD20 ( -- x addr ) 20 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD20, Filter bits
: CAN1_F24DATA1_FD21 ( -- x addr ) 21 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD21, Filter bits
: CAN1_F24DATA1_FD22 ( -- x addr ) 22 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD22, Filter bits
: CAN1_F24DATA1_FD23 ( -- x addr ) 23 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD23, Filter bits
: CAN1_F24DATA1_FD24 ( -- x addr ) 24 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD24, Filter bits
: CAN1_F24DATA1_FD25 ( -- x addr ) 25 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD25, Filter bits
: CAN1_F24DATA1_FD26 ( -- x addr ) 26 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD26, Filter bits
: CAN1_F24DATA1_FD27 ( -- x addr ) 27 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD27, Filter bits
: CAN1_F24DATA1_FD28 ( -- x addr ) 28 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD28, Filter bits
: CAN1_F24DATA1_FD29 ( -- x addr ) 29 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD29, Filter bits
: CAN1_F24DATA1_FD30 ( -- x addr ) 30 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD30, Filter bits
: CAN1_F24DATA1_FD31 ( -- x addr ) 31 bit CAN1_F24DATA1 ; \ CAN1_F24DATA1_FD31, Filter bits

\ CAN1_F25DATA0 (read-write) Reset:0x00000000
: CAN1_F25DATA0_FD0 ( -- x addr ) 0 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD0, Filter bits
: CAN1_F25DATA0_FD1 ( -- x addr ) 1 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD1, Filter bits
: CAN1_F25DATA0_FD2 ( -- x addr ) 2 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD2, Filter bits
: CAN1_F25DATA0_FD3 ( -- x addr ) 3 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD3, Filter bits
: CAN1_F25DATA0_FD4 ( -- x addr ) 4 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD4, Filter bits
: CAN1_F25DATA0_FD5 ( -- x addr ) 5 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD5, Filter bits
: CAN1_F25DATA0_FD6 ( -- x addr ) 6 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD6, Filter bits
: CAN1_F25DATA0_FD7 ( -- x addr ) 7 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD7, Filter bits
: CAN1_F25DATA0_FD8 ( -- x addr ) 8 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD8, Filter bits
: CAN1_F25DATA0_FD9 ( -- x addr ) 9 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD9, Filter bits
: CAN1_F25DATA0_FD10 ( -- x addr ) 10 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD10, Filter bits
: CAN1_F25DATA0_FD11 ( -- x addr ) 11 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD11, Filter bits
: CAN1_F25DATA0_FD12 ( -- x addr ) 12 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD12, Filter bits
: CAN1_F25DATA0_FD13 ( -- x addr ) 13 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD13, Filter bits
: CAN1_F25DATA0_FD14 ( -- x addr ) 14 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD14, Filter bits
: CAN1_F25DATA0_FD15 ( -- x addr ) 15 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD15, Filter bits
: CAN1_F25DATA0_FD16 ( -- x addr ) 16 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD16, Filter bits
: CAN1_F25DATA0_FD17 ( -- x addr ) 17 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD17, Filter bits
: CAN1_F25DATA0_FD18 ( -- x addr ) 18 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD18, Filter bits
: CAN1_F25DATA0_FD19 ( -- x addr ) 19 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD19, Filter bits
: CAN1_F25DATA0_FD20 ( -- x addr ) 20 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD20, Filter bits
: CAN1_F25DATA0_FD21 ( -- x addr ) 21 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD21, Filter bits
: CAN1_F25DATA0_FD22 ( -- x addr ) 22 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD22, Filter bits
: CAN1_F25DATA0_FD23 ( -- x addr ) 23 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD23, Filter bits
: CAN1_F25DATA0_FD24 ( -- x addr ) 24 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD24, Filter bits
: CAN1_F25DATA0_FD25 ( -- x addr ) 25 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD25, Filter bits
: CAN1_F25DATA0_FD26 ( -- x addr ) 26 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD26, Filter bits
: CAN1_F25DATA0_FD27 ( -- x addr ) 27 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD27, Filter bits
: CAN1_F25DATA0_FD28 ( -- x addr ) 28 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD28, Filter bits
: CAN1_F25DATA0_FD29 ( -- x addr ) 29 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD29, Filter bits
: CAN1_F25DATA0_FD30 ( -- x addr ) 30 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD30, Filter bits
: CAN1_F25DATA0_FD31 ( -- x addr ) 31 bit CAN1_F25DATA0 ; \ CAN1_F25DATA0_FD31, Filter bits

\ CAN1_F25DATA1 (read-write) Reset:0x00000000
: CAN1_F25DATA1_FD0 ( -- x addr ) 0 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD0, Filter bits
: CAN1_F25DATA1_FD1 ( -- x addr ) 1 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD1, Filter bits
: CAN1_F25DATA1_FD2 ( -- x addr ) 2 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD2, Filter bits
: CAN1_F25DATA1_FD3 ( -- x addr ) 3 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD3, Filter bits
: CAN1_F25DATA1_FD4 ( -- x addr ) 4 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD4, Filter bits
: CAN1_F25DATA1_FD5 ( -- x addr ) 5 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD5, Filter bits
: CAN1_F25DATA1_FD6 ( -- x addr ) 6 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD6, Filter bits
: CAN1_F25DATA1_FD7 ( -- x addr ) 7 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD7, Filter bits
: CAN1_F25DATA1_FD8 ( -- x addr ) 8 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD8, Filter bits
: CAN1_F25DATA1_FD9 ( -- x addr ) 9 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD9, Filter bits
: CAN1_F25DATA1_FD10 ( -- x addr ) 10 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD10, Filter bits
: CAN1_F25DATA1_FD11 ( -- x addr ) 11 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD11, Filter bits
: CAN1_F25DATA1_FD12 ( -- x addr ) 12 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD12, Filter bits
: CAN1_F25DATA1_FD13 ( -- x addr ) 13 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD13, Filter bits
: CAN1_F25DATA1_FD14 ( -- x addr ) 14 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD14, Filter bits
: CAN1_F25DATA1_FD15 ( -- x addr ) 15 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD15, Filter bits
: CAN1_F25DATA1_FD16 ( -- x addr ) 16 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD16, Filter bits
: CAN1_F25DATA1_FD17 ( -- x addr ) 17 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD17, Filter bits
: CAN1_F25DATA1_FD18 ( -- x addr ) 18 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD18, Filter bits
: CAN1_F25DATA1_FD19 ( -- x addr ) 19 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD19, Filter bits
: CAN1_F25DATA1_FD20 ( -- x addr ) 20 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD20, Filter bits
: CAN1_F25DATA1_FD21 ( -- x addr ) 21 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD21, Filter bits
: CAN1_F25DATA1_FD22 ( -- x addr ) 22 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD22, Filter bits
: CAN1_F25DATA1_FD23 ( -- x addr ) 23 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD23, Filter bits
: CAN1_F25DATA1_FD24 ( -- x addr ) 24 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD24, Filter bits
: CAN1_F25DATA1_FD25 ( -- x addr ) 25 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD25, Filter bits
: CAN1_F25DATA1_FD26 ( -- x addr ) 26 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD26, Filter bits
: CAN1_F25DATA1_FD27 ( -- x addr ) 27 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD27, Filter bits
: CAN1_F25DATA1_FD28 ( -- x addr ) 28 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD28, Filter bits
: CAN1_F25DATA1_FD29 ( -- x addr ) 29 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD29, Filter bits
: CAN1_F25DATA1_FD30 ( -- x addr ) 30 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD30, Filter bits
: CAN1_F25DATA1_FD31 ( -- x addr ) 31 bit CAN1_F25DATA1 ; \ CAN1_F25DATA1_FD31, Filter bits

\ CAN1_F26DATA0 (read-write) Reset:0x00000000
: CAN1_F26DATA0_FD0 ( -- x addr ) 0 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD0, Filter bits
: CAN1_F26DATA0_FD1 ( -- x addr ) 1 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD1, Filter bits
: CAN1_F26DATA0_FD2 ( -- x addr ) 2 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD2, Filter bits
: CAN1_F26DATA0_FD3 ( -- x addr ) 3 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD3, Filter bits
: CAN1_F26DATA0_FD4 ( -- x addr ) 4 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD4, Filter bits
: CAN1_F26DATA0_FD5 ( -- x addr ) 5 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD5, Filter bits
: CAN1_F26DATA0_FD6 ( -- x addr ) 6 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD6, Filter bits
: CAN1_F26DATA0_FD7 ( -- x addr ) 7 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD7, Filter bits
: CAN1_F26DATA0_FD8 ( -- x addr ) 8 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD8, Filter bits
: CAN1_F26DATA0_FD9 ( -- x addr ) 9 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD9, Filter bits
: CAN1_F26DATA0_FD10 ( -- x addr ) 10 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD10, Filter bits
: CAN1_F26DATA0_FD11 ( -- x addr ) 11 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD11, Filter bits
: CAN1_F26DATA0_FD12 ( -- x addr ) 12 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD12, Filter bits
: CAN1_F26DATA0_FD13 ( -- x addr ) 13 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD13, Filter bits
: CAN1_F26DATA0_FD14 ( -- x addr ) 14 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD14, Filter bits
: CAN1_F26DATA0_FD15 ( -- x addr ) 15 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD15, Filter bits
: CAN1_F26DATA0_FD16 ( -- x addr ) 16 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD16, Filter bits
: CAN1_F26DATA0_FD17 ( -- x addr ) 17 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD17, Filter bits
: CAN1_F26DATA0_FD18 ( -- x addr ) 18 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD18, Filter bits
: CAN1_F26DATA0_FD19 ( -- x addr ) 19 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD19, Filter bits
: CAN1_F26DATA0_FD20 ( -- x addr ) 20 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD20, Filter bits
: CAN1_F26DATA0_FD21 ( -- x addr ) 21 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD21, Filter bits
: CAN1_F26DATA0_FD22 ( -- x addr ) 22 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD22, Filter bits
: CAN1_F26DATA0_FD23 ( -- x addr ) 23 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD23, Filter bits
: CAN1_F26DATA0_FD24 ( -- x addr ) 24 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD24, Filter bits
: CAN1_F26DATA0_FD25 ( -- x addr ) 25 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD25, Filter bits
: CAN1_F26DATA0_FD26 ( -- x addr ) 26 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD26, Filter bits
: CAN1_F26DATA0_FD27 ( -- x addr ) 27 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD27, Filter bits
: CAN1_F26DATA0_FD28 ( -- x addr ) 28 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD28, Filter bits
: CAN1_F26DATA0_FD29 ( -- x addr ) 29 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD29, Filter bits
: CAN1_F26DATA0_FD30 ( -- x addr ) 30 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD30, Filter bits
: CAN1_F26DATA0_FD31 ( -- x addr ) 31 bit CAN1_F26DATA0 ; \ CAN1_F26DATA0_FD31, Filter bits

\ CAN1_F26DATA1 (read-write) Reset:0x00000000
: CAN1_F26DATA1_FD0 ( -- x addr ) 0 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD0, Filter bits
: CAN1_F26DATA1_FD1 ( -- x addr ) 1 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD1, Filter bits
: CAN1_F26DATA1_FD2 ( -- x addr ) 2 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD2, Filter bits
: CAN1_F26DATA1_FD3 ( -- x addr ) 3 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD3, Filter bits
: CAN1_F26DATA1_FD4 ( -- x addr ) 4 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD4, Filter bits
: CAN1_F26DATA1_FD5 ( -- x addr ) 5 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD5, Filter bits
: CAN1_F26DATA1_FD6 ( -- x addr ) 6 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD6, Filter bits
: CAN1_F26DATA1_FD7 ( -- x addr ) 7 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD7, Filter bits
: CAN1_F26DATA1_FD8 ( -- x addr ) 8 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD8, Filter bits
: CAN1_F26DATA1_FD9 ( -- x addr ) 9 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD9, Filter bits
: CAN1_F26DATA1_FD10 ( -- x addr ) 10 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD10, Filter bits
: CAN1_F26DATA1_FD11 ( -- x addr ) 11 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD11, Filter bits
: CAN1_F26DATA1_FD12 ( -- x addr ) 12 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD12, Filter bits
: CAN1_F26DATA1_FD13 ( -- x addr ) 13 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD13, Filter bits
: CAN1_F26DATA1_FD14 ( -- x addr ) 14 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD14, Filter bits
: CAN1_F26DATA1_FD15 ( -- x addr ) 15 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD15, Filter bits
: CAN1_F26DATA1_FD16 ( -- x addr ) 16 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD16, Filter bits
: CAN1_F26DATA1_FD17 ( -- x addr ) 17 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD17, Filter bits
: CAN1_F26DATA1_FD18 ( -- x addr ) 18 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD18, Filter bits
: CAN1_F26DATA1_FD19 ( -- x addr ) 19 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD19, Filter bits
: CAN1_F26DATA1_FD20 ( -- x addr ) 20 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD20, Filter bits
: CAN1_F26DATA1_FD21 ( -- x addr ) 21 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD21, Filter bits
: CAN1_F26DATA1_FD22 ( -- x addr ) 22 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD22, Filter bits
: CAN1_F26DATA1_FD23 ( -- x addr ) 23 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD23, Filter bits
: CAN1_F26DATA1_FD24 ( -- x addr ) 24 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD24, Filter bits
: CAN1_F26DATA1_FD25 ( -- x addr ) 25 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD25, Filter bits
: CAN1_F26DATA1_FD26 ( -- x addr ) 26 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD26, Filter bits
: CAN1_F26DATA1_FD27 ( -- x addr ) 27 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD27, Filter bits
: CAN1_F26DATA1_FD28 ( -- x addr ) 28 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD28, Filter bits
: CAN1_F26DATA1_FD29 ( -- x addr ) 29 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD29, Filter bits
: CAN1_F26DATA1_FD30 ( -- x addr ) 30 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD30, Filter bits
: CAN1_F26DATA1_FD31 ( -- x addr ) 31 bit CAN1_F26DATA1 ; \ CAN1_F26DATA1_FD31, Filter bits

\ CAN1_F27DATA0 (read-write) Reset:0x00000000
: CAN1_F27DATA0_FD0 ( -- x addr ) 0 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD0, Filter bits
: CAN1_F27DATA0_FD1 ( -- x addr ) 1 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD1, Filter bits
: CAN1_F27DATA0_FD2 ( -- x addr ) 2 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD2, Filter bits
: CAN1_F27DATA0_FD3 ( -- x addr ) 3 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD3, Filter bits
: CAN1_F27DATA0_FD4 ( -- x addr ) 4 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD4, Filter bits
: CAN1_F27DATA0_FD5 ( -- x addr ) 5 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD5, Filter bits
: CAN1_F27DATA0_FD6 ( -- x addr ) 6 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD6, Filter bits
: CAN1_F27DATA0_FD7 ( -- x addr ) 7 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD7, Filter bits
: CAN1_F27DATA0_FD8 ( -- x addr ) 8 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD8, Filter bits
: CAN1_F27DATA0_FD9 ( -- x addr ) 9 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD9, Filter bits
: CAN1_F27DATA0_FD10 ( -- x addr ) 10 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD10, Filter bits
: CAN1_F27DATA0_FD11 ( -- x addr ) 11 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD11, Filter bits
: CAN1_F27DATA0_FD12 ( -- x addr ) 12 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD12, Filter bits
: CAN1_F27DATA0_FD13 ( -- x addr ) 13 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD13, Filter bits
: CAN1_F27DATA0_FD14 ( -- x addr ) 14 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD14, Filter bits
: CAN1_F27DATA0_FD15 ( -- x addr ) 15 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD15, Filter bits
: CAN1_F27DATA0_FD16 ( -- x addr ) 16 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD16, Filter bits
: CAN1_F27DATA0_FD17 ( -- x addr ) 17 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD17, Filter bits
: CAN1_F27DATA0_FD18 ( -- x addr ) 18 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD18, Filter bits
: CAN1_F27DATA0_FD19 ( -- x addr ) 19 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD19, Filter bits
: CAN1_F27DATA0_FD20 ( -- x addr ) 20 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD20, Filter bits
: CAN1_F27DATA0_FD21 ( -- x addr ) 21 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD21, Filter bits
: CAN1_F27DATA0_FD22 ( -- x addr ) 22 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD22, Filter bits
: CAN1_F27DATA0_FD23 ( -- x addr ) 23 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD23, Filter bits
: CAN1_F27DATA0_FD24 ( -- x addr ) 24 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD24, Filter bits
: CAN1_F27DATA0_FD25 ( -- x addr ) 25 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD25, Filter bits
: CAN1_F27DATA0_FD26 ( -- x addr ) 26 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD26, Filter bits
: CAN1_F27DATA0_FD27 ( -- x addr ) 27 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD27, Filter bits
: CAN1_F27DATA0_FD28 ( -- x addr ) 28 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD28, Filter bits
: CAN1_F27DATA0_FD29 ( -- x addr ) 29 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD29, Filter bits
: CAN1_F27DATA0_FD30 ( -- x addr ) 30 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD30, Filter bits
: CAN1_F27DATA0_FD31 ( -- x addr ) 31 bit CAN1_F27DATA0 ; \ CAN1_F27DATA0_FD31, Filter bits

\ CAN1_F27DATA1 (read-write) Reset:0x00000000
: CAN1_F27DATA1_FD0 ( -- x addr ) 0 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD0, Filter bits
: CAN1_F27DATA1_FD1 ( -- x addr ) 1 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD1, Filter bits
: CAN1_F27DATA1_FD2 ( -- x addr ) 2 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD2, Filter bits
: CAN1_F27DATA1_FD3 ( -- x addr ) 3 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD3, Filter bits
: CAN1_F27DATA1_FD4 ( -- x addr ) 4 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD4, Filter bits
: CAN1_F27DATA1_FD5 ( -- x addr ) 5 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD5, Filter bits
: CAN1_F27DATA1_FD6 ( -- x addr ) 6 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD6, Filter bits
: CAN1_F27DATA1_FD7 ( -- x addr ) 7 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD7, Filter bits
: CAN1_F27DATA1_FD8 ( -- x addr ) 8 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD8, Filter bits
: CAN1_F27DATA1_FD9 ( -- x addr ) 9 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD9, Filter bits
: CAN1_F27DATA1_FD10 ( -- x addr ) 10 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD10, Filter bits
: CAN1_F27DATA1_FD11 ( -- x addr ) 11 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD11, Filter bits
: CAN1_F27DATA1_FD12 ( -- x addr ) 12 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD12, Filter bits
: CAN1_F27DATA1_FD13 ( -- x addr ) 13 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD13, Filter bits
: CAN1_F27DATA1_FD14 ( -- x addr ) 14 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD14, Filter bits
: CAN1_F27DATA1_FD15 ( -- x addr ) 15 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD15, Filter bits
: CAN1_F27DATA1_FD16 ( -- x addr ) 16 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD16, Filter bits
: CAN1_F27DATA1_FD17 ( -- x addr ) 17 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD17, Filter bits
: CAN1_F27DATA1_FD18 ( -- x addr ) 18 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD18, Filter bits
: CAN1_F27DATA1_FD19 ( -- x addr ) 19 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD19, Filter bits
: CAN1_F27DATA1_FD20 ( -- x addr ) 20 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD20, Filter bits
: CAN1_F27DATA1_FD21 ( -- x addr ) 21 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD21, Filter bits
: CAN1_F27DATA1_FD22 ( -- x addr ) 22 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD22, Filter bits
: CAN1_F27DATA1_FD23 ( -- x addr ) 23 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD23, Filter bits
: CAN1_F27DATA1_FD24 ( -- x addr ) 24 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD24, Filter bits
: CAN1_F27DATA1_FD25 ( -- x addr ) 25 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD25, Filter bits
: CAN1_F27DATA1_FD26 ( -- x addr ) 26 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD26, Filter bits
: CAN1_F27DATA1_FD27 ( -- x addr ) 27 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD27, Filter bits
: CAN1_F27DATA1_FD28 ( -- x addr ) 28 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD28, Filter bits
: CAN1_F27DATA1_FD29 ( -- x addr ) 29 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD29, Filter bits
: CAN1_F27DATA1_FD30 ( -- x addr ) 30 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD30, Filter bits
: CAN1_F27DATA1_FD31 ( -- x addr ) 31 bit CAN1_F27DATA1 ; \ CAN1_F27DATA1_FD31, Filter bits

\ CRC_DATA (read-write) Reset:0xFFFFFFFF
: CRC_DATA_DATA ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) CRC_DATA ; \ CRC_DATA_DATA, CRC calculation result bits

\ CRC_FDATA (read-write) Reset:0x00000000
: CRC_FDATA_FDATA ( %bbbbbbbb -- x addr ) CRC_FDATA ; \ CRC_FDATA_FDATA, Free Data Register bits

\ CRC_CTL (read-write) Reset:0x00000000
: CRC_CTL_RST ( -- x addr ) 0 bit CRC_CTL ; \ CRC_CTL_RST, reset bit

\ DAC_CTL (read-write) Reset:0x00000000
: DAC_CTL_DEN0 ( -- x addr ) 0 bit DAC_CTL ; \ DAC_CTL_DEN0, DAC0 enable
: DAC_CTL_DBOFF0 ( -- x addr ) 1 bit DAC_CTL ; \ DAC_CTL_DBOFF0, DAC0 output buffer turn off
: DAC_CTL_DTEN0 ( -- x addr ) 2 bit DAC_CTL ; \ DAC_CTL_DTEN0, DAC0 trigger enable
: DAC_CTL_DTSEL0 ( %bbb -- x addr ) 3 lshift DAC_CTL ; \ DAC_CTL_DTSEL0, DAC0 trigger selection
: DAC_CTL_DWM0 ( %bb -- x addr ) 6 lshift DAC_CTL ; \ DAC_CTL_DWM0, DAC0 noise wave mode
: DAC_CTL_DWBW0 ( %bbbb -- x addr ) 8 lshift DAC_CTL ; \ DAC_CTL_DWBW0, DAC0 noise wave bit width
: DAC_CTL_DDMAEN0 ( -- x addr ) 12 bit DAC_CTL ; \ DAC_CTL_DDMAEN0, DAC0 DMA enable
: DAC_CTL_DEN1 ( -- x addr ) 16 bit DAC_CTL ; \ DAC_CTL_DEN1, DAC1 enable
: DAC_CTL_DBOFF1 ( -- x addr ) 17 bit DAC_CTL ; \ DAC_CTL_DBOFF1, DAC1 output buffer turn off
: DAC_CTL_DTEN1 ( -- x addr ) 18 bit DAC_CTL ; \ DAC_CTL_DTEN1, DAC1 trigger enable
: DAC_CTL_DTSEL1 ( %bbb -- x addr ) 19 lshift DAC_CTL ; \ DAC_CTL_DTSEL1, DAC1 trigger selection
: DAC_CTL_DWM1 ( %bb -- x addr ) 22 lshift DAC_CTL ; \ DAC_CTL_DWM1, DAC1 noise wave mode
: DAC_CTL_DWBW1 ( %bbbb -- x addr ) 24 lshift DAC_CTL ; \ DAC_CTL_DWBW1, DAC1 noise wave bit width
: DAC_CTL_DDMAEN1 ( -- x addr ) 28 bit DAC_CTL ; \ DAC_CTL_DDMAEN1, DAC1 DMA enable

\ DAC_SWT (write-only) Reset:0x00000000
: DAC_SWT_SWTR0 ( -- x addr ) 0 bit DAC_SWT ; \ DAC_SWT_SWTR0, DAC0 software trigger
: DAC_SWT_SWTR1 ( -- x addr ) 1 bit DAC_SWT ; \ DAC_SWT_SWTR1, DAC1 software trigger

\ DAC_DAC0_R12DH (read-write) Reset:0x00000000
: DAC_DAC0_R12DH_DAC0_DH ( %bbbbbbbbbbb -- x addr ) DAC_DAC0_R12DH ; \ DAC_DAC0_R12DH_DAC0_DH, DAC0 12-bit right-aligned  data

\ DAC_DAC0_L12DH (read-write) Reset:0x00000000
: DAC_DAC0_L12DH_DAC0_DH ( %bbbbbbbbbbb -- x addr ) 4 lshift DAC_DAC0_L12DH ; \ DAC_DAC0_L12DH_DAC0_DH, DAC0 12-bit left-aligned  data

\ DAC_DAC0_R8DH (read-write) Reset:0x00000000
: DAC_DAC0_R8DH_DAC0_DH ( %bbbbbbbb -- x addr ) DAC_DAC0_R8DH ; \ DAC_DAC0_R8DH_DAC0_DH, DAC0 8-bit right-aligned  data

\ DAC_DAC1_R12DH (read-write) Reset:0x00000000
: DAC_DAC1_R12DH_DAC1_DH ( %bbbbbbbbbbb -- x addr ) DAC_DAC1_R12DH ; \ DAC_DAC1_R12DH_DAC1_DH, DAC1 12-bit right-aligned  data

\ DAC_DAC1_L12DH (read-write) Reset:0x00000000
: DAC_DAC1_L12DH_DAC1_DH ( %bbbbbbbbbbb -- x addr ) 4 lshift DAC_DAC1_L12DH ; \ DAC_DAC1_L12DH_DAC1_DH, DAC1 12-bit left-aligned  data

\ DAC_DAC1_R8DH (read-write) Reset:0x00000000
: DAC_DAC1_R8DH_DAC1_DH ( %bbbbbbbb -- x addr ) DAC_DAC1_R8DH ; \ DAC_DAC1_R8DH_DAC1_DH, DAC1 8-bit right-aligned  data

\ DAC_DACC_R12DH (read-write) Reset:0x00000000
: DAC_DACC_R12DH_DAC0_DH ( %bbbbbbbbbbb -- x addr ) DAC_DACC_R12DH ; \ DAC_DACC_R12DH_DAC0_DH, DAC0 12-bit right-aligned  data
: DAC_DACC_R12DH_DAC1_DH ( %bbbbbbbbbbb -- x addr ) 16 lshift DAC_DACC_R12DH ; \ DAC_DACC_R12DH_DAC1_DH, DAC1 12-bit right-aligned  data

\ DAC_DACC_L12DH (read-write) Reset:0x00000000
: DAC_DACC_L12DH_DAC0_DH ( %bbbbbbbbbbb -- x addr ) 4 lshift DAC_DACC_L12DH ; \ DAC_DACC_L12DH_DAC0_DH, DAC0 12-bit left-aligned  data
: DAC_DACC_L12DH_DAC1_DH ( %bbbbbbbbbbb -- x addr ) 20 lshift DAC_DACC_L12DH ; \ DAC_DACC_L12DH_DAC1_DH, DAC1 12-bit left-aligned  data

\ DAC_DACC_R8DH (read-write) Reset:0x00000000
: DAC_DACC_R8DH_DAC0_DH ( %bbbbbbbb -- x addr ) DAC_DACC_R8DH ; \ DAC_DACC_R8DH_DAC0_DH, DAC0 8-bit right-aligned  data
: DAC_DACC_R8DH_DAC1_DH ( %bbbbbbbb -- x addr ) 8 lshift DAC_DACC_R8DH ; \ DAC_DACC_R8DH_DAC1_DH, DAC1 8-bit right-aligned  data

\ DAC_DAC0_DO (read-only) Reset:0x00000000
: DAC_DAC0_DO_DAC0_DO? ( --  x ) DAC_DAC0_DO @ ; \ DAC_DAC0_DO_DAC0_DO, DAC0 data output

\ DAC_DAC1_DO (read-only) Reset:0x00000000
: DAC_DAC1_DO_DAC1_DO? ( --  x ) DAC_DAC1_DO @ ; \ DAC_DAC1_DO_DAC1_DO, DAC1 data output

\ DBG_ID (read-only) Reset:0x00000000
: DBG_ID_ID_CODE? ( --  x ) DBG_ID @ ; \ DBG_ID_ID_CODE, DBG ID code register

\ DBG_CTL (read-write) Reset:0x00000000
: DBG_CTL_SLP_HOLD ( -- x addr ) 0 bit DBG_CTL ; \ DBG_CTL_SLP_HOLD, Sleep mode hold register
: DBG_CTL_DSLP_HOLD ( -- x addr ) 1 bit DBG_CTL ; \ DBG_CTL_DSLP_HOLD, Deep-sleep mode hold register
: DBG_CTL_STB_HOLD ( -- x addr ) 2 bit DBG_CTL ; \ DBG_CTL_STB_HOLD, Standby mode hold register
: DBG_CTL_FWDGT_HOLD ( -- x addr ) 8 bit DBG_CTL ; \ DBG_CTL_FWDGT_HOLD, FWDGT hold bit
: DBG_CTL_WWDGT_HOLD ( -- x addr ) 9 bit DBG_CTL ; \ DBG_CTL_WWDGT_HOLD, WWDGT hold bit
: DBG_CTL_TIMER0_HOLD ( -- x addr ) 10 bit DBG_CTL ; \ DBG_CTL_TIMER0_HOLD, TIMER 0 hold bit
: DBG_CTL_TIMER1_HOLD ( -- x addr ) 11 bit DBG_CTL ; \ DBG_CTL_TIMER1_HOLD, TIMER 1 hold bit
: DBG_CTL_TIMER2_HOLD ( -- x addr ) 12 bit DBG_CTL ; \ DBG_CTL_TIMER2_HOLD, TIMER 2 hold bit
: DBG_CTL_TIMER3_HOLD ( -- x addr ) 13 bit DBG_CTL ; \ DBG_CTL_TIMER3_HOLD, TIMER 23 hold bit
: DBG_CTL_CAN0_HOLD ( -- x addr ) 14 bit DBG_CTL ; \ DBG_CTL_CAN0_HOLD, CAN0 hold bit
: DBG_CTL_I2C0_HOLD ( -- x addr ) 15 bit DBG_CTL ; \ DBG_CTL_I2C0_HOLD, I2C0 hold bit
: DBG_CTL_I2C1_HOLD ( -- x addr ) 16 bit DBG_CTL ; \ DBG_CTL_I2C1_HOLD, I2C1 hold bit
: DBG_CTL_TIMER4_HOLD ( -- x addr ) 18 bit DBG_CTL ; \ DBG_CTL_TIMER4_HOLD, TIMER4_HOLD
: DBG_CTL_TIMER5_HOLD ( -- x addr ) 19 bit DBG_CTL ; \ DBG_CTL_TIMER5_HOLD, TIMER 5 hold bit
: DBG_CTL_TIMER6_HOLD ( -- x addr ) 20 bit DBG_CTL ; \ DBG_CTL_TIMER6_HOLD, TIMER 6 hold bit
: DBG_CTL_CAN1_HOLD ( -- x addr ) 21 bit DBG_CTL ; \ DBG_CTL_CAN1_HOLD, CAN1 hold bit

\ DMA0_INTF (read-only) Reset:0x00000000
: DMA0_INTF_GIF0? ( --  1|0 ) 0 bit DMA0_INTF bit@ ; \ DMA0_INTF_GIF0, Global interrupt flag of channel 0
: DMA0_INTF_FTFIF0? ( --  1|0 ) 1 bit DMA0_INTF bit@ ; \ DMA0_INTF_FTFIF0, Full Transfer finish flag of channe 0
: DMA0_INTF_HTFIF0? ( --  1|0 ) 2 bit DMA0_INTF bit@ ; \ DMA0_INTF_HTFIF0, Half transfer finish flag of channel 0
: DMA0_INTF_ERRIF0? ( --  1|0 ) 3 bit DMA0_INTF bit@ ; \ DMA0_INTF_ERRIF0, Error flag of channel 0
: DMA0_INTF_GIF1? ( --  1|0 ) 4 bit DMA0_INTF bit@ ; \ DMA0_INTF_GIF1, Global interrupt flag of channel 1
: DMA0_INTF_FTFIF1? ( --  1|0 ) 5 bit DMA0_INTF bit@ ; \ DMA0_INTF_FTFIF1, Full Transfer finish flag of channe 1
: DMA0_INTF_HTFIF1? ( --  1|0 ) 6 bit DMA0_INTF bit@ ; \ DMA0_INTF_HTFIF1, Half transfer finish flag of channel 1
: DMA0_INTF_ERRIF1? ( --  1|0 ) 7 bit DMA0_INTF bit@ ; \ DMA0_INTF_ERRIF1, Error flag of channel 1
: DMA0_INTF_GIF2? ( --  1|0 ) 8 bit DMA0_INTF bit@ ; \ DMA0_INTF_GIF2, Global interrupt flag of channel 2
: DMA0_INTF_FTFIF2? ( --  1|0 ) 9 bit DMA0_INTF bit@ ; \ DMA0_INTF_FTFIF2, Full Transfer finish flag of channe 2
: DMA0_INTF_HTFIF2? ( --  1|0 ) 10 bit DMA0_INTF bit@ ; \ DMA0_INTF_HTFIF2, Half transfer finish flag of channel 2
: DMA0_INTF_ERRIF2? ( --  1|0 ) 11 bit DMA0_INTF bit@ ; \ DMA0_INTF_ERRIF2, Error flag of channel 2
: DMA0_INTF_GIF3? ( --  1|0 ) 12 bit DMA0_INTF bit@ ; \ DMA0_INTF_GIF3, Global interrupt flag of channel 3
: DMA0_INTF_FTFIF3? ( --  1|0 ) 13 bit DMA0_INTF bit@ ; \ DMA0_INTF_FTFIF3, Full Transfer finish flag of channe 3
: DMA0_INTF_HTFIF3? ( --  1|0 ) 14 bit DMA0_INTF bit@ ; \ DMA0_INTF_HTFIF3, Half transfer finish flag of channel 3
: DMA0_INTF_ERRIF3? ( --  1|0 ) 15 bit DMA0_INTF bit@ ; \ DMA0_INTF_ERRIF3, Error flag of channel 3
: DMA0_INTF_GIF4? ( --  1|0 ) 16 bit DMA0_INTF bit@ ; \ DMA0_INTF_GIF4, Global interrupt flag of channel 4
: DMA0_INTF_FTFIF4? ( --  1|0 ) 17 bit DMA0_INTF bit@ ; \ DMA0_INTF_FTFIF4, Full Transfer finish flag of channe 4
: DMA0_INTF_HTFIF4? ( --  1|0 ) 18 bit DMA0_INTF bit@ ; \ DMA0_INTF_HTFIF4, Half transfer finish flag of channel 4
: DMA0_INTF_ERRIF4? ( --  1|0 ) 19 bit DMA0_INTF bit@ ; \ DMA0_INTF_ERRIF4, Error flag of channel 4
: DMA0_INTF_GIF5? ( --  1|0 ) 20 bit DMA0_INTF bit@ ; \ DMA0_INTF_GIF5, Global interrupt flag of channel 5
: DMA0_INTF_FTFIF5? ( --  1|0 ) 21 bit DMA0_INTF bit@ ; \ DMA0_INTF_FTFIF5, Full Transfer finish flag of channe 5
: DMA0_INTF_HTFIF5? ( --  1|0 ) 22 bit DMA0_INTF bit@ ; \ DMA0_INTF_HTFIF5, Half transfer finish flag of channel 5
: DMA0_INTF_ERRIF5? ( --  1|0 ) 23 bit DMA0_INTF bit@ ; \ DMA0_INTF_ERRIF5, Error flag of channel 5
: DMA0_INTF_GIF6? ( --  1|0 ) 24 bit DMA0_INTF bit@ ; \ DMA0_INTF_GIF6, Global interrupt flag of channel 6
: DMA0_INTF_FTFIF6? ( --  1|0 ) 25 bit DMA0_INTF bit@ ; \ DMA0_INTF_FTFIF6, Full Transfer finish flag of channe 6
: DMA0_INTF_HTFIF6? ( --  1|0 ) 26 bit DMA0_INTF bit@ ; \ DMA0_INTF_HTFIF6, Half transfer finish flag of channel 6
: DMA0_INTF_ERRIF6? ( --  1|0 ) 27 bit DMA0_INTF bit@ ; \ DMA0_INTF_ERRIF6, Error flag of channel 6

\ DMA0_INTC (write-only) Reset:0x00000000
: DMA0_INTC_GIFC0 ( -- x addr ) 0 bit DMA0_INTC ; \ DMA0_INTC_GIFC0, Clear global interrupt flag of channel 0
: DMA0_INTC_FTFIFC0 ( -- x addr ) 1 bit DMA0_INTC ; \ DMA0_INTC_FTFIFC0, Clear bit for full transfer finish flag of channel 0
: DMA0_INTC_HTFIFC0 ( -- x addr ) 2 bit DMA0_INTC ; \ DMA0_INTC_HTFIFC0, Clear bit for half transfer finish flag of channel 0
: DMA0_INTC_ERRIFC0 ( -- x addr ) 3 bit DMA0_INTC ; \ DMA0_INTC_ERRIFC0, Clear bit for error flag of channel 0
: DMA0_INTC_GIFC1 ( -- x addr ) 4 bit DMA0_INTC ; \ DMA0_INTC_GIFC1, Clear global interrupt flag of channel 1
: DMA0_INTC_FTFIFC1 ( -- x addr ) 5 bit DMA0_INTC ; \ DMA0_INTC_FTFIFC1, Clear bit for full transfer finish flag of channel 1
: DMA0_INTC_HTFIFC1 ( -- x addr ) 6 bit DMA0_INTC ; \ DMA0_INTC_HTFIFC1, Clear bit for half transfer finish flag of channel 1
: DMA0_INTC_ERRIFC1 ( -- x addr ) 7 bit DMA0_INTC ; \ DMA0_INTC_ERRIFC1, Clear bit for error flag of channel 1
: DMA0_INTC_GIFC2 ( -- x addr ) 8 bit DMA0_INTC ; \ DMA0_INTC_GIFC2, Clear global interrupt flag of channel 2
: DMA0_INTC_FTFIFC2 ( -- x addr ) 9 bit DMA0_INTC ; \ DMA0_INTC_FTFIFC2, Clear bit for full transfer finish flag of channel 2
: DMA0_INTC_HTFIFC2 ( -- x addr ) 10 bit DMA0_INTC ; \ DMA0_INTC_HTFIFC2, Clear bit for half transfer finish flag of channel 2
: DMA0_INTC_ERRIFC2 ( -- x addr ) 11 bit DMA0_INTC ; \ DMA0_INTC_ERRIFC2, Clear bit for error flag of channel 2
: DMA0_INTC_GIFC3 ( -- x addr ) 12 bit DMA0_INTC ; \ DMA0_INTC_GIFC3, Clear global interrupt flag of channel 3
: DMA0_INTC_FTFIFC3 ( -- x addr ) 13 bit DMA0_INTC ; \ DMA0_INTC_FTFIFC3, Clear bit for full transfer finish flag of channel 3
: DMA0_INTC_HTFIFC3 ( -- x addr ) 14 bit DMA0_INTC ; \ DMA0_INTC_HTFIFC3, Clear bit for half transfer finish flag of channel 3
: DMA0_INTC_ERRIFC3 ( -- x addr ) 15 bit DMA0_INTC ; \ DMA0_INTC_ERRIFC3, Clear bit for error flag of channel 3
: DMA0_INTC_GIFC4 ( -- x addr ) 16 bit DMA0_INTC ; \ DMA0_INTC_GIFC4, Clear global interrupt flag of channel 4
: DMA0_INTC_FTFIFC4 ( -- x addr ) 17 bit DMA0_INTC ; \ DMA0_INTC_FTFIFC4, Clear bit for full transfer finish flag of channel 4
: DMA0_INTC_HTFIFC4 ( -- x addr ) 18 bit DMA0_INTC ; \ DMA0_INTC_HTFIFC4, Clear bit for half transfer finish flag of channel 4
: DMA0_INTC_ERRIFC4 ( -- x addr ) 19 bit DMA0_INTC ; \ DMA0_INTC_ERRIFC4, Clear bit for error flag of channel 4
: DMA0_INTC_GIFC5 ( -- x addr ) 20 bit DMA0_INTC ; \ DMA0_INTC_GIFC5, Clear global interrupt flag of channel 5
: DMA0_INTC_FTFIFC5 ( -- x addr ) 21 bit DMA0_INTC ; \ DMA0_INTC_FTFIFC5, Clear bit for full transfer finish flag of channel 5
: DMA0_INTC_HTFIFC5 ( -- x addr ) 22 bit DMA0_INTC ; \ DMA0_INTC_HTFIFC5, Clear bit for half transfer finish flag of channel 5
: DMA0_INTC_ERRIFC5 ( -- x addr ) 23 bit DMA0_INTC ; \ DMA0_INTC_ERRIFC5, Clear bit for error flag of channel 5
: DMA0_INTC_GIFC6 ( -- x addr ) 24 bit DMA0_INTC ; \ DMA0_INTC_GIFC6, Clear global interrupt flag of channel 6
: DMA0_INTC_FTFIFC6 ( -- x addr ) 25 bit DMA0_INTC ; \ DMA0_INTC_FTFIFC6, Clear bit for full transfer finish flag of channel 6
: DMA0_INTC_HTFIFC6 ( -- x addr ) 26 bit DMA0_INTC ; \ DMA0_INTC_HTFIFC6, Clear bit for half transfer finish flag of channel 6
: DMA0_INTC_ERRIFC6 ( -- x addr ) 27 bit DMA0_INTC ; \ DMA0_INTC_ERRIFC6, Clear bit for error flag of channel 6

\ DMA0_CH0CTL (read-write) Reset:0x00000000
: DMA0_CH0CTL_CHEN ( -- x addr ) 0 bit DMA0_CH0CTL ; \ DMA0_CH0CTL_CHEN, Channel enable
: DMA0_CH0CTL_FTFIE ( -- x addr ) 1 bit DMA0_CH0CTL ; \ DMA0_CH0CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA0_CH0CTL_HTFIE ( -- x addr ) 2 bit DMA0_CH0CTL ; \ DMA0_CH0CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA0_CH0CTL_ERRIE ( -- x addr ) 3 bit DMA0_CH0CTL ; \ DMA0_CH0CTL_ERRIE, Enable bit for channel error interrupt
: DMA0_CH0CTL_DIR ( -- x addr ) 4 bit DMA0_CH0CTL ; \ DMA0_CH0CTL_DIR, Transfer direction
: DMA0_CH0CTL_CMEN ( -- x addr ) 5 bit DMA0_CH0CTL ; \ DMA0_CH0CTL_CMEN, Circular mode enable
: DMA0_CH0CTL_PNAGA ( -- x addr ) 6 bit DMA0_CH0CTL ; \ DMA0_CH0CTL_PNAGA, Next address generation algorithm of peripheral
: DMA0_CH0CTL_MNAGA ( -- x addr ) 7 bit DMA0_CH0CTL ; \ DMA0_CH0CTL_MNAGA, Next address generation algorithm of memory
: DMA0_CH0CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA0_CH0CTL ; \ DMA0_CH0CTL_PWIDTH, Transfer data size of peripheral
: DMA0_CH0CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA0_CH0CTL ; \ DMA0_CH0CTL_MWIDTH, Transfer data size of memory
: DMA0_CH0CTL_PRIO ( %bb -- x addr ) 12 lshift DMA0_CH0CTL ; \ DMA0_CH0CTL_PRIO, Priority level
: DMA0_CH0CTL_M2M ( -- x addr ) 14 bit DMA0_CH0CTL ; \ DMA0_CH0CTL_M2M, Memory to Memory Mode

\ DMA0_CH0CNT (read-write) Reset:0x00000000
: DMA0_CH0CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA0_CH0CNT ; \ DMA0_CH0CNT_CNT, Transfer counter

\ DMA0_CH0PADDR (read-write) Reset:0x00000000
: DMA0_CH0PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH0PADDR ; \ DMA0_CH0PADDR_PADDR, Peripheral base address

\ DMA0_CH0MADDR (read-write) Reset:0x00000000
: DMA0_CH0MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH0MADDR ; \ DMA0_CH0MADDR_MADDR, Memory base address

\ DMA0_CH1CTL (read-write) Reset:0x00000000
: DMA0_CH1CTL_CHEN ( -- x addr ) 0 bit DMA0_CH1CTL ; \ DMA0_CH1CTL_CHEN, Channel enable
: DMA0_CH1CTL_FTFIE ( -- x addr ) 1 bit DMA0_CH1CTL ; \ DMA0_CH1CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA0_CH1CTL_HTFIE ( -- x addr ) 2 bit DMA0_CH1CTL ; \ DMA0_CH1CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA0_CH1CTL_ERRIE ( -- x addr ) 3 bit DMA0_CH1CTL ; \ DMA0_CH1CTL_ERRIE, Enable bit for channel error interrupt
: DMA0_CH1CTL_DIR ( -- x addr ) 4 bit DMA0_CH1CTL ; \ DMA0_CH1CTL_DIR, Transfer direction
: DMA0_CH1CTL_CMEN ( -- x addr ) 5 bit DMA0_CH1CTL ; \ DMA0_CH1CTL_CMEN, Circular mode enable
: DMA0_CH1CTL_PNAGA ( -- x addr ) 6 bit DMA0_CH1CTL ; \ DMA0_CH1CTL_PNAGA, Next address generation algorithm of peripheral
: DMA0_CH1CTL_MNAGA ( -- x addr ) 7 bit DMA0_CH1CTL ; \ DMA0_CH1CTL_MNAGA, Next address generation algorithm of memory
: DMA0_CH1CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA0_CH1CTL ; \ DMA0_CH1CTL_PWIDTH, Transfer data size of peripheral
: DMA0_CH1CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA0_CH1CTL ; \ DMA0_CH1CTL_MWIDTH, Transfer data size of memory
: DMA0_CH1CTL_PRIO ( %bb -- x addr ) 12 lshift DMA0_CH1CTL ; \ DMA0_CH1CTL_PRIO, Priority level
: DMA0_CH1CTL_M2M ( -- x addr ) 14 bit DMA0_CH1CTL ; \ DMA0_CH1CTL_M2M, Memory to Memory Mode

\ DMA0_CH1CNT (read-write) Reset:0x00000000
: DMA0_CH1CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA0_CH1CNT ; \ DMA0_CH1CNT_CNT, Transfer counter

\ DMA0_CH1PADDR (read-write) Reset:0x00000000
: DMA0_CH1PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH1PADDR ; \ DMA0_CH1PADDR_PADDR, Peripheral base address

\ DMA0_CH1MADDR (read-write) Reset:0x00000000
: DMA0_CH1MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH1MADDR ; \ DMA0_CH1MADDR_MADDR, Memory base address

\ DMA0_CH2CTL (read-write) Reset:0x00000000
: DMA0_CH2CTL_CHEN ( -- x addr ) 0 bit DMA0_CH2CTL ; \ DMA0_CH2CTL_CHEN, Channel enable
: DMA0_CH2CTL_FTFIE ( -- x addr ) 1 bit DMA0_CH2CTL ; \ DMA0_CH2CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA0_CH2CTL_HTFIE ( -- x addr ) 2 bit DMA0_CH2CTL ; \ DMA0_CH2CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA0_CH2CTL_ERRIE ( -- x addr ) 3 bit DMA0_CH2CTL ; \ DMA0_CH2CTL_ERRIE, Enable bit for channel error interrupt
: DMA0_CH2CTL_DIR ( -- x addr ) 4 bit DMA0_CH2CTL ; \ DMA0_CH2CTL_DIR, Transfer direction
: DMA0_CH2CTL_CMEN ( -- x addr ) 5 bit DMA0_CH2CTL ; \ DMA0_CH2CTL_CMEN, Circular mode enable
: DMA0_CH2CTL_PNAGA ( -- x addr ) 6 bit DMA0_CH2CTL ; \ DMA0_CH2CTL_PNAGA, Next address generation algorithm of peripheral
: DMA0_CH2CTL_MNAGA ( -- x addr ) 7 bit DMA0_CH2CTL ; \ DMA0_CH2CTL_MNAGA, Next address generation algorithm of memory
: DMA0_CH2CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA0_CH2CTL ; \ DMA0_CH2CTL_PWIDTH, Transfer data size of peripheral
: DMA0_CH2CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA0_CH2CTL ; \ DMA0_CH2CTL_MWIDTH, Transfer data size of memory
: DMA0_CH2CTL_PRIO ( %bb -- x addr ) 12 lshift DMA0_CH2CTL ; \ DMA0_CH2CTL_PRIO, Priority level
: DMA0_CH2CTL_M2M ( -- x addr ) 14 bit DMA0_CH2CTL ; \ DMA0_CH2CTL_M2M, Memory to Memory Mode

\ DMA0_CH2CNT (read-write) Reset:0x00000000
: DMA0_CH2CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA0_CH2CNT ; \ DMA0_CH2CNT_CNT, Transfer counter

\ DMA0_CH2PADDR (read-write) Reset:0x00000000
: DMA0_CH2PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH2PADDR ; \ DMA0_CH2PADDR_PADDR, Peripheral base address

\ DMA0_CH2MADDR (read-write) Reset:0x00000000
: DMA0_CH2MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH2MADDR ; \ DMA0_CH2MADDR_MADDR, Memory base address

\ DMA0_CH3CTL (read-write) Reset:0x00000000
: DMA0_CH3CTL_CHEN ( -- x addr ) 0 bit DMA0_CH3CTL ; \ DMA0_CH3CTL_CHEN, Channel enable
: DMA0_CH3CTL_FTFIE ( -- x addr ) 1 bit DMA0_CH3CTL ; \ DMA0_CH3CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA0_CH3CTL_HTFIE ( -- x addr ) 2 bit DMA0_CH3CTL ; \ DMA0_CH3CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA0_CH3CTL_ERRIE ( -- x addr ) 3 bit DMA0_CH3CTL ; \ DMA0_CH3CTL_ERRIE, Enable bit for channel error interrupt
: DMA0_CH3CTL_DIR ( -- x addr ) 4 bit DMA0_CH3CTL ; \ DMA0_CH3CTL_DIR, Transfer direction
: DMA0_CH3CTL_CMEN ( -- x addr ) 5 bit DMA0_CH3CTL ; \ DMA0_CH3CTL_CMEN, Circular mode enable
: DMA0_CH3CTL_PNAGA ( -- x addr ) 6 bit DMA0_CH3CTL ; \ DMA0_CH3CTL_PNAGA, Next address generation algorithm of peripheral
: DMA0_CH3CTL_MNAGA ( -- x addr ) 7 bit DMA0_CH3CTL ; \ DMA0_CH3CTL_MNAGA, Next address generation algorithm of memory
: DMA0_CH3CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA0_CH3CTL ; \ DMA0_CH3CTL_PWIDTH, Transfer data size of peripheral
: DMA0_CH3CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA0_CH3CTL ; \ DMA0_CH3CTL_MWIDTH, Transfer data size of memory
: DMA0_CH3CTL_PRIO ( %bb -- x addr ) 12 lshift DMA0_CH3CTL ; \ DMA0_CH3CTL_PRIO, Priority level
: DMA0_CH3CTL_M2M ( -- x addr ) 14 bit DMA0_CH3CTL ; \ DMA0_CH3CTL_M2M, Memory to Memory Mode

\ DMA0_CH3CNT (read-write) Reset:0x00000000
: DMA0_CH3CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA0_CH3CNT ; \ DMA0_CH3CNT_CNT, Transfer counter

\ DMA0_CH3PADDR (read-write) Reset:0x00000000
: DMA0_CH3PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH3PADDR ; \ DMA0_CH3PADDR_PADDR, Peripheral base address

\ DMA0_CH3MADDR (read-write) Reset:0x00000000
: DMA0_CH3MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH3MADDR ; \ DMA0_CH3MADDR_MADDR, Memory base address

\ DMA0_CH4CTL (read-write) Reset:0x00000000
: DMA0_CH4CTL_CHEN ( -- x addr ) 0 bit DMA0_CH4CTL ; \ DMA0_CH4CTL_CHEN, Channel enable
: DMA0_CH4CTL_FTFIE ( -- x addr ) 1 bit DMA0_CH4CTL ; \ DMA0_CH4CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA0_CH4CTL_HTFIE ( -- x addr ) 2 bit DMA0_CH4CTL ; \ DMA0_CH4CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA0_CH4CTL_ERRIE ( -- x addr ) 3 bit DMA0_CH4CTL ; \ DMA0_CH4CTL_ERRIE, Enable bit for channel error interrupt
: DMA0_CH4CTL_DIR ( -- x addr ) 4 bit DMA0_CH4CTL ; \ DMA0_CH4CTL_DIR, Transfer direction
: DMA0_CH4CTL_CMEN ( -- x addr ) 5 bit DMA0_CH4CTL ; \ DMA0_CH4CTL_CMEN, Circular mode enable
: DMA0_CH4CTL_PNAGA ( -- x addr ) 6 bit DMA0_CH4CTL ; \ DMA0_CH4CTL_PNAGA, Next address generation algorithm of peripheral
: DMA0_CH4CTL_MNAGA ( -- x addr ) 7 bit DMA0_CH4CTL ; \ DMA0_CH4CTL_MNAGA, Next address generation algorithm of memory
: DMA0_CH4CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA0_CH4CTL ; \ DMA0_CH4CTL_PWIDTH, Transfer data size of peripheral
: DMA0_CH4CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA0_CH4CTL ; \ DMA0_CH4CTL_MWIDTH, Transfer data size of memory
: DMA0_CH4CTL_PRIO ( %bb -- x addr ) 12 lshift DMA0_CH4CTL ; \ DMA0_CH4CTL_PRIO, Priority level
: DMA0_CH4CTL_M2M ( -- x addr ) 14 bit DMA0_CH4CTL ; \ DMA0_CH4CTL_M2M, Memory to Memory Mode

\ DMA0_CH4CNT (read-write) Reset:0x00000000
: DMA0_CH4CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA0_CH4CNT ; \ DMA0_CH4CNT_CNT, Transfer counter

\ DMA0_CH4PADDR (read-write) Reset:0x00000000
: DMA0_CH4PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH4PADDR ; \ DMA0_CH4PADDR_PADDR, Peripheral base address

\ DMA0_CH4MADDR (read-write) Reset:0x00000000
: DMA0_CH4MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH4MADDR ; \ DMA0_CH4MADDR_MADDR, Memory base address

\ DMA0_CH5CTL (read-write) Reset:0x00000000
: DMA0_CH5CTL_CHEN ( -- x addr ) 0 bit DMA0_CH5CTL ; \ DMA0_CH5CTL_CHEN, Channel enable
: DMA0_CH5CTL_FTFIE ( -- x addr ) 1 bit DMA0_CH5CTL ; \ DMA0_CH5CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA0_CH5CTL_HTFIE ( -- x addr ) 2 bit DMA0_CH5CTL ; \ DMA0_CH5CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA0_CH5CTL_ERRIE ( -- x addr ) 3 bit DMA0_CH5CTL ; \ DMA0_CH5CTL_ERRIE, Enable bit for channel error interrupt
: DMA0_CH5CTL_DIR ( -- x addr ) 4 bit DMA0_CH5CTL ; \ DMA0_CH5CTL_DIR, Transfer direction
: DMA0_CH5CTL_CMEN ( -- x addr ) 5 bit DMA0_CH5CTL ; \ DMA0_CH5CTL_CMEN, Circular mode enable
: DMA0_CH5CTL_PNAGA ( -- x addr ) 6 bit DMA0_CH5CTL ; \ DMA0_CH5CTL_PNAGA, Next address generation algorithm of peripheral
: DMA0_CH5CTL_MNAGA ( -- x addr ) 7 bit DMA0_CH5CTL ; \ DMA0_CH5CTL_MNAGA, Next address generation algorithm of memory
: DMA0_CH5CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA0_CH5CTL ; \ DMA0_CH5CTL_PWIDTH, Transfer data size of peripheral
: DMA0_CH5CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA0_CH5CTL ; \ DMA0_CH5CTL_MWIDTH, Transfer data size of memory
: DMA0_CH5CTL_PRIO ( %bb -- x addr ) 12 lshift DMA0_CH5CTL ; \ DMA0_CH5CTL_PRIO, Priority level
: DMA0_CH5CTL_M2M ( -- x addr ) 14 bit DMA0_CH5CTL ; \ DMA0_CH5CTL_M2M, Memory to Memory Mode

\ DMA0_CH5CNT (read-write) Reset:0x00000000
: DMA0_CH5CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA0_CH5CNT ; \ DMA0_CH5CNT_CNT, Transfer counter

\ DMA0_CH5PADDR (read-write) Reset:0x00000000
: DMA0_CH5PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH5PADDR ; \ DMA0_CH5PADDR_PADDR, Peripheral base address

\ DMA0_CH5MADDR (read-write) Reset:0x00000000
: DMA0_CH5MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH5MADDR ; \ DMA0_CH5MADDR_MADDR, Memory base address

\ DMA0_CH6CTL (read-write) Reset:0x00000000
: DMA0_CH6CTL_CHEN ( -- x addr ) 0 bit DMA0_CH6CTL ; \ DMA0_CH6CTL_CHEN, Channel enable
: DMA0_CH6CTL_FTFIE ( -- x addr ) 1 bit DMA0_CH6CTL ; \ DMA0_CH6CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA0_CH6CTL_HTFIE ( -- x addr ) 2 bit DMA0_CH6CTL ; \ DMA0_CH6CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA0_CH6CTL_ERRIE ( -- x addr ) 3 bit DMA0_CH6CTL ; \ DMA0_CH6CTL_ERRIE, Enable bit for channel error interrupt
: DMA0_CH6CTL_DIR ( -- x addr ) 4 bit DMA0_CH6CTL ; \ DMA0_CH6CTL_DIR, Transfer direction
: DMA0_CH6CTL_CMEN ( -- x addr ) 5 bit DMA0_CH6CTL ; \ DMA0_CH6CTL_CMEN, Circular mode enable
: DMA0_CH6CTL_PNAGA ( -- x addr ) 6 bit DMA0_CH6CTL ; \ DMA0_CH6CTL_PNAGA, Next address generation algorithm of peripheral
: DMA0_CH6CTL_MNAGA ( -- x addr ) 7 bit DMA0_CH6CTL ; \ DMA0_CH6CTL_MNAGA, Next address generation algorithm of memory
: DMA0_CH6CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA0_CH6CTL ; \ DMA0_CH6CTL_PWIDTH, Transfer data size of peripheral
: DMA0_CH6CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA0_CH6CTL ; \ DMA0_CH6CTL_MWIDTH, Transfer data size of memory
: DMA0_CH6CTL_PRIO ( %bb -- x addr ) 12 lshift DMA0_CH6CTL ; \ DMA0_CH6CTL_PRIO, Priority level
: DMA0_CH6CTL_M2M ( -- x addr ) 14 bit DMA0_CH6CTL ; \ DMA0_CH6CTL_M2M, Memory to Memory Mode

\ DMA0_CH6CNT (read-write) Reset:0x00000000
: DMA0_CH6CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA0_CH6CNT ; \ DMA0_CH6CNT_CNT, Transfer counter

\ DMA0_CH6PADDR (read-write) Reset:0x00000000
: DMA0_CH6PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH6PADDR ; \ DMA0_CH6PADDR_PADDR, Peripheral base address

\ DMA0_CH6MADDR (read-write) Reset:0x00000000
: DMA0_CH6MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA0_CH6MADDR ; \ DMA0_CH6MADDR_MADDR, Memory base address

\ DMA1_INTF (read-only) Reset:0x00000000
: DMA1_INTF_GIF0? ( --  1|0 ) 0 bit DMA1_INTF bit@ ; \ DMA1_INTF_GIF0, Global interrupt flag of channel 0
: DMA1_INTF_FTFIF0? ( --  1|0 ) 1 bit DMA1_INTF bit@ ; \ DMA1_INTF_FTFIF0, Full Transfer finish flag of channe 0
: DMA1_INTF_HTFIF0? ( --  1|0 ) 2 bit DMA1_INTF bit@ ; \ DMA1_INTF_HTFIF0, Half transfer finish flag of channel 0
: DMA1_INTF_ERRIF0? ( --  1|0 ) 3 bit DMA1_INTF bit@ ; \ DMA1_INTF_ERRIF0, Error flag of channel 0
: DMA1_INTF_GIF1? ( --  1|0 ) 4 bit DMA1_INTF bit@ ; \ DMA1_INTF_GIF1, Global interrupt flag of channel 1
: DMA1_INTF_FTFIF1? ( --  1|0 ) 5 bit DMA1_INTF bit@ ; \ DMA1_INTF_FTFIF1, Full Transfer finish flag of channe 1
: DMA1_INTF_HTFIF1? ( --  1|0 ) 6 bit DMA1_INTF bit@ ; \ DMA1_INTF_HTFIF1, Half transfer finish flag of channel 1
: DMA1_INTF_ERRIF1? ( --  1|0 ) 7 bit DMA1_INTF bit@ ; \ DMA1_INTF_ERRIF1, Error flag of channel 1
: DMA1_INTF_GIF2? ( --  1|0 ) 8 bit DMA1_INTF bit@ ; \ DMA1_INTF_GIF2, Global interrupt flag of channel 2
: DMA1_INTF_FTFIF2? ( --  1|0 ) 9 bit DMA1_INTF bit@ ; \ DMA1_INTF_FTFIF2, Full Transfer finish flag of channe 2
: DMA1_INTF_HTFIF2? ( --  1|0 ) 10 bit DMA1_INTF bit@ ; \ DMA1_INTF_HTFIF2, Half transfer finish flag of channel 2
: DMA1_INTF_ERRIF2? ( --  1|0 ) 11 bit DMA1_INTF bit@ ; \ DMA1_INTF_ERRIF2, Error flag of channel 2
: DMA1_INTF_GIF3? ( --  1|0 ) 12 bit DMA1_INTF bit@ ; \ DMA1_INTF_GIF3, Global interrupt flag of channel 3
: DMA1_INTF_FTFIF3? ( --  1|0 ) 13 bit DMA1_INTF bit@ ; \ DMA1_INTF_FTFIF3, Full Transfer finish flag of channe 3
: DMA1_INTF_HTFIF3? ( --  1|0 ) 14 bit DMA1_INTF bit@ ; \ DMA1_INTF_HTFIF3, Half transfer finish flag of channel 3
: DMA1_INTF_ERRIF3? ( --  1|0 ) 15 bit DMA1_INTF bit@ ; \ DMA1_INTF_ERRIF3, Error flag of channel 3
: DMA1_INTF_GIF4? ( --  1|0 ) 16 bit DMA1_INTF bit@ ; \ DMA1_INTF_GIF4, Global interrupt flag of channel 4
: DMA1_INTF_FTFIF4? ( --  1|0 ) 17 bit DMA1_INTF bit@ ; \ DMA1_INTF_FTFIF4, Full Transfer finish flag of channe 4
: DMA1_INTF_HTFIF4? ( --  1|0 ) 18 bit DMA1_INTF bit@ ; \ DMA1_INTF_HTFIF4, Half transfer finish flag of channel 4
: DMA1_INTF_ERRIF4? ( --  1|0 ) 19 bit DMA1_INTF bit@ ; \ DMA1_INTF_ERRIF4, Error flag of channel 4

\ DMA1_INTC (write-only) Reset:0x00000000
: DMA1_INTC_GIFC0 ( -- x addr ) 0 bit DMA1_INTC ; \ DMA1_INTC_GIFC0, Clear global interrupt flag of channel 0
: DMA1_INTC_FTFIFC0 ( -- x addr ) 1 bit DMA1_INTC ; \ DMA1_INTC_FTFIFC0, Clear bit for full transfer finish flag of channel 0
: DMA1_INTC_HTFIFC0 ( -- x addr ) 2 bit DMA1_INTC ; \ DMA1_INTC_HTFIFC0, Clear bit for half transfer finish flag of channel 0
: DMA1_INTC_ERRIFC0 ( -- x addr ) 3 bit DMA1_INTC ; \ DMA1_INTC_ERRIFC0, Clear bit for error flag of channel 0
: DMA1_INTC_GIFC1 ( -- x addr ) 4 bit DMA1_INTC ; \ DMA1_INTC_GIFC1, Clear global interrupt flag of channel 1
: DMA1_INTC_FTFIFC1 ( -- x addr ) 5 bit DMA1_INTC ; \ DMA1_INTC_FTFIFC1, Clear bit for full transfer finish flag of channel 1
: DMA1_INTC_HTFIFC1 ( -- x addr ) 6 bit DMA1_INTC ; \ DMA1_INTC_HTFIFC1, Clear bit for half transfer finish flag of channel 1
: DMA1_INTC_ERRIFC1 ( -- x addr ) 7 bit DMA1_INTC ; \ DMA1_INTC_ERRIFC1, Clear bit for error flag of channel 1
: DMA1_INTC_GIFC2 ( -- x addr ) 8 bit DMA1_INTC ; \ DMA1_INTC_GIFC2, Clear global interrupt flag of channel 2
: DMA1_INTC_FTFIFC2 ( -- x addr ) 9 bit DMA1_INTC ; \ DMA1_INTC_FTFIFC2, Clear bit for full transfer finish flag of channel 2
: DMA1_INTC_HTFIFC2 ( -- x addr ) 10 bit DMA1_INTC ; \ DMA1_INTC_HTFIFC2, Clear bit for half transfer finish flag of channel 2
: DMA1_INTC_ERRIFC2 ( -- x addr ) 11 bit DMA1_INTC ; \ DMA1_INTC_ERRIFC2, Clear bit for error flag of channel 2
: DMA1_INTC_GIFC3 ( -- x addr ) 12 bit DMA1_INTC ; \ DMA1_INTC_GIFC3, Clear global interrupt flag of channel 3
: DMA1_INTC_FTFIFC3 ( -- x addr ) 13 bit DMA1_INTC ; \ DMA1_INTC_FTFIFC3, Clear bit for full transfer finish flag of channel 3
: DMA1_INTC_HTFIFC3 ( -- x addr ) 14 bit DMA1_INTC ; \ DMA1_INTC_HTFIFC3, Clear bit for half transfer finish flag of channel 3
: DMA1_INTC_ERRIFC3 ( -- x addr ) 15 bit DMA1_INTC ; \ DMA1_INTC_ERRIFC3, Clear bit for error flag of channel 3
: DMA1_INTC_GIFC4 ( -- x addr ) 16 bit DMA1_INTC ; \ DMA1_INTC_GIFC4, Clear global interrupt flag of channel 4
: DMA1_INTC_FTFIFC4 ( -- x addr ) 17 bit DMA1_INTC ; \ DMA1_INTC_FTFIFC4, Clear bit for full transfer finish flag of channel 4
: DMA1_INTC_HTFIFC4 ( -- x addr ) 18 bit DMA1_INTC ; \ DMA1_INTC_HTFIFC4, Clear bit for half transfer finish flag of channel 4
: DMA1_INTC_ERRIFC4 ( -- x addr ) 19 bit DMA1_INTC ; \ DMA1_INTC_ERRIFC4, Clear bit for error flag of channel 4

\ DMA1_CH0CTL (read-write) Reset:0x00000000
: DMA1_CH0CTL_CHEN ( -- x addr ) 0 bit DMA1_CH0CTL ; \ DMA1_CH0CTL_CHEN, Channel enable
: DMA1_CH0CTL_FTFIE ( -- x addr ) 1 bit DMA1_CH0CTL ; \ DMA1_CH0CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA1_CH0CTL_HTFIE ( -- x addr ) 2 bit DMA1_CH0CTL ; \ DMA1_CH0CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA1_CH0CTL_ERRIE ( -- x addr ) 3 bit DMA1_CH0CTL ; \ DMA1_CH0CTL_ERRIE, Enable bit for channel error interrupt
: DMA1_CH0CTL_DIR ( -- x addr ) 4 bit DMA1_CH0CTL ; \ DMA1_CH0CTL_DIR, Transfer direction
: DMA1_CH0CTL_CMEN ( -- x addr ) 5 bit DMA1_CH0CTL ; \ DMA1_CH0CTL_CMEN, Circular mode enable
: DMA1_CH0CTL_PNAGA ( -- x addr ) 6 bit DMA1_CH0CTL ; \ DMA1_CH0CTL_PNAGA, Next address generation algorithm of peripheral
: DMA1_CH0CTL_MNAGA ( -- x addr ) 7 bit DMA1_CH0CTL ; \ DMA1_CH0CTL_MNAGA, Next address generation algorithm of memory
: DMA1_CH0CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA1_CH0CTL ; \ DMA1_CH0CTL_PWIDTH, Transfer data size of peripheral
: DMA1_CH0CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA1_CH0CTL ; \ DMA1_CH0CTL_MWIDTH, Transfer data size of memory
: DMA1_CH0CTL_PRIO ( %bb -- x addr ) 12 lshift DMA1_CH0CTL ; \ DMA1_CH0CTL_PRIO, Priority level
: DMA1_CH0CTL_M2M ( -- x addr ) 14 bit DMA1_CH0CTL ; \ DMA1_CH0CTL_M2M, Memory to Memory Mode

\ DMA1_CH0CNT (read-write) Reset:0x00000000
: DMA1_CH0CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CH0CNT ; \ DMA1_CH0CNT_CNT, Transfer counter

\ DMA1_CH0PADDR (read-write) Reset:0x00000000
: DMA1_CH0PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH0PADDR ; \ DMA1_CH0PADDR_PADDR, Peripheral base address

\ DMA1_CH0MADDR (read-write) Reset:0x00000000
: DMA1_CH0MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH0MADDR ; \ DMA1_CH0MADDR_MADDR, Memory base address

\ DMA1_CH1CTL (read-write) Reset:0x00000000
: DMA1_CH1CTL_CHEN ( -- x addr ) 0 bit DMA1_CH1CTL ; \ DMA1_CH1CTL_CHEN, Channel enable
: DMA1_CH1CTL_FTFIE ( -- x addr ) 1 bit DMA1_CH1CTL ; \ DMA1_CH1CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA1_CH1CTL_HTFIE ( -- x addr ) 2 bit DMA1_CH1CTL ; \ DMA1_CH1CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA1_CH1CTL_ERRIE ( -- x addr ) 3 bit DMA1_CH1CTL ; \ DMA1_CH1CTL_ERRIE, Enable bit for channel error interrupt
: DMA1_CH1CTL_DIR ( -- x addr ) 4 bit DMA1_CH1CTL ; \ DMA1_CH1CTL_DIR, Transfer direction
: DMA1_CH1CTL_CMEN ( -- x addr ) 5 bit DMA1_CH1CTL ; \ DMA1_CH1CTL_CMEN, Circular mode enable
: DMA1_CH1CTL_PNAGA ( -- x addr ) 6 bit DMA1_CH1CTL ; \ DMA1_CH1CTL_PNAGA, Next address generation algorithm of peripheral
: DMA1_CH1CTL_MNAGA ( -- x addr ) 7 bit DMA1_CH1CTL ; \ DMA1_CH1CTL_MNAGA, Next address generation algorithm of memory
: DMA1_CH1CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA1_CH1CTL ; \ DMA1_CH1CTL_PWIDTH, Transfer data size of peripheral
: DMA1_CH1CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA1_CH1CTL ; \ DMA1_CH1CTL_MWIDTH, Transfer data size of memory
: DMA1_CH1CTL_PRIO ( %bb -- x addr ) 12 lshift DMA1_CH1CTL ; \ DMA1_CH1CTL_PRIO, Priority level
: DMA1_CH1CTL_M2M ( -- x addr ) 14 bit DMA1_CH1CTL ; \ DMA1_CH1CTL_M2M, Memory to Memory Mode

\ DMA1_CH1CNT (read-write) Reset:0x00000000
: DMA1_CH1CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CH1CNT ; \ DMA1_CH1CNT_CNT, Transfer counter

\ DMA1_CH1PADDR (read-write) Reset:0x00000000
: DMA1_CH1PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH1PADDR ; \ DMA1_CH1PADDR_PADDR, Peripheral base address

\ DMA1_CH1MADDR (read-write) Reset:0x00000000
: DMA1_CH1MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH1MADDR ; \ DMA1_CH1MADDR_MADDR, Memory base address

\ DMA1_CH2CTL (read-write) Reset:0x00000000
: DMA1_CH2CTL_CHEN ( -- x addr ) 0 bit DMA1_CH2CTL ; \ DMA1_CH2CTL_CHEN, Channel enable
: DMA1_CH2CTL_FTFIE ( -- x addr ) 1 bit DMA1_CH2CTL ; \ DMA1_CH2CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA1_CH2CTL_HTFIE ( -- x addr ) 2 bit DMA1_CH2CTL ; \ DMA1_CH2CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA1_CH2CTL_ERRIE ( -- x addr ) 3 bit DMA1_CH2CTL ; \ DMA1_CH2CTL_ERRIE, Enable bit for channel error interrupt
: DMA1_CH2CTL_DIR ( -- x addr ) 4 bit DMA1_CH2CTL ; \ DMA1_CH2CTL_DIR, Transfer direction
: DMA1_CH2CTL_CMEN ( -- x addr ) 5 bit DMA1_CH2CTL ; \ DMA1_CH2CTL_CMEN, Circular mode enable
: DMA1_CH2CTL_PNAGA ( -- x addr ) 6 bit DMA1_CH2CTL ; \ DMA1_CH2CTL_PNAGA, Next address generation algorithm of peripheral
: DMA1_CH2CTL_MNAGA ( -- x addr ) 7 bit DMA1_CH2CTL ; \ DMA1_CH2CTL_MNAGA, Next address generation algorithm of memory
: DMA1_CH2CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA1_CH2CTL ; \ DMA1_CH2CTL_PWIDTH, Transfer data size of peripheral
: DMA1_CH2CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA1_CH2CTL ; \ DMA1_CH2CTL_MWIDTH, Transfer data size of memory
: DMA1_CH2CTL_PRIO ( %bb -- x addr ) 12 lshift DMA1_CH2CTL ; \ DMA1_CH2CTL_PRIO, Priority level
: DMA1_CH2CTL_M2M ( -- x addr ) 14 bit DMA1_CH2CTL ; \ DMA1_CH2CTL_M2M, Memory to Memory Mode

\ DMA1_CH2CNT (read-write) Reset:0x00000000
: DMA1_CH2CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CH2CNT ; \ DMA1_CH2CNT_CNT, Transfer counter

\ DMA1_CH2PADDR (read-write) Reset:0x00000000
: DMA1_CH2PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH2PADDR ; \ DMA1_CH2PADDR_PADDR, Peripheral base address

\ DMA1_CH2MADDR (read-write) Reset:0x00000000
: DMA1_CH2MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH2MADDR ; \ DMA1_CH2MADDR_MADDR, Memory base address

\ DMA1_CH3CTL (read-write) Reset:0x00000000
: DMA1_CH3CTL_CHEN ( -- x addr ) 0 bit DMA1_CH3CTL ; \ DMA1_CH3CTL_CHEN, Channel enable
: DMA1_CH3CTL_FTFIE ( -- x addr ) 1 bit DMA1_CH3CTL ; \ DMA1_CH3CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA1_CH3CTL_HTFIE ( -- x addr ) 2 bit DMA1_CH3CTL ; \ DMA1_CH3CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA1_CH3CTL_ERRIE ( -- x addr ) 3 bit DMA1_CH3CTL ; \ DMA1_CH3CTL_ERRIE, Enable bit for channel error interrupt
: DMA1_CH3CTL_DIR ( -- x addr ) 4 bit DMA1_CH3CTL ; \ DMA1_CH3CTL_DIR, Transfer direction
: DMA1_CH3CTL_CMEN ( -- x addr ) 5 bit DMA1_CH3CTL ; \ DMA1_CH3CTL_CMEN, Circular mode enable
: DMA1_CH3CTL_PNAGA ( -- x addr ) 6 bit DMA1_CH3CTL ; \ DMA1_CH3CTL_PNAGA, Next address generation algorithm of peripheral
: DMA1_CH3CTL_MNAGA ( -- x addr ) 7 bit DMA1_CH3CTL ; \ DMA1_CH3CTL_MNAGA, Next address generation algorithm of memory
: DMA1_CH3CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA1_CH3CTL ; \ DMA1_CH3CTL_PWIDTH, Transfer data size of peripheral
: DMA1_CH3CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA1_CH3CTL ; \ DMA1_CH3CTL_MWIDTH, Transfer data size of memory
: DMA1_CH3CTL_PRIO ( %bb -- x addr ) 12 lshift DMA1_CH3CTL ; \ DMA1_CH3CTL_PRIO, Priority level
: DMA1_CH3CTL_M2M ( -- x addr ) 14 bit DMA1_CH3CTL ; \ DMA1_CH3CTL_M2M, Memory to Memory Mode

\ DMA1_CH3CNT (read-write) Reset:0x00000000
: DMA1_CH3CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CH3CNT ; \ DMA1_CH3CNT_CNT, Transfer counter

\ DMA1_CH3PADDR (read-write) Reset:0x00000000
: DMA1_CH3PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH3PADDR ; \ DMA1_CH3PADDR_PADDR, Peripheral base address

\ DMA1_CH3MADDR (read-write) Reset:0x00000000
: DMA1_CH3MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH3MADDR ; \ DMA1_CH3MADDR_MADDR, Memory base address

\ DMA1_CH4CTL (read-write) Reset:0x00000000
: DMA1_CH4CTL_CHEN ( -- x addr ) 0 bit DMA1_CH4CTL ; \ DMA1_CH4CTL_CHEN, Channel enable
: DMA1_CH4CTL_FTFIE ( -- x addr ) 1 bit DMA1_CH4CTL ; \ DMA1_CH4CTL_FTFIE, Enable bit for channel full transfer finish interrupt
: DMA1_CH4CTL_HTFIE ( -- x addr ) 2 bit DMA1_CH4CTL ; \ DMA1_CH4CTL_HTFIE, Enable bit for channel half transfer finish interrupt
: DMA1_CH4CTL_ERRIE ( -- x addr ) 3 bit DMA1_CH4CTL ; \ DMA1_CH4CTL_ERRIE, Enable bit for channel error interrupt
: DMA1_CH4CTL_DIR ( -- x addr ) 4 bit DMA1_CH4CTL ; \ DMA1_CH4CTL_DIR, Transfer direction
: DMA1_CH4CTL_CMEN ( -- x addr ) 5 bit DMA1_CH4CTL ; \ DMA1_CH4CTL_CMEN, Circular mode enable
: DMA1_CH4CTL_PNAGA ( -- x addr ) 6 bit DMA1_CH4CTL ; \ DMA1_CH4CTL_PNAGA, Next address generation algorithm of peripheral
: DMA1_CH4CTL_MNAGA ( -- x addr ) 7 bit DMA1_CH4CTL ; \ DMA1_CH4CTL_MNAGA, Next address generation algorithm of memory
: DMA1_CH4CTL_PWIDTH ( %bb -- x addr ) 8 lshift DMA1_CH4CTL ; \ DMA1_CH4CTL_PWIDTH, Transfer data size of peripheral
: DMA1_CH4CTL_MWIDTH ( %bb -- x addr ) 10 lshift DMA1_CH4CTL ; \ DMA1_CH4CTL_MWIDTH, Transfer data size of memory
: DMA1_CH4CTL_PRIO ( %bb -- x addr ) 12 lshift DMA1_CH4CTL ; \ DMA1_CH4CTL_PRIO, Priority level
: DMA1_CH4CTL_M2M ( -- x addr ) 14 bit DMA1_CH4CTL ; \ DMA1_CH4CTL_M2M, Memory to Memory Mode

\ DMA1_CH4CNT (read-write) Reset:0x00000000
: DMA1_CH4CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) DMA1_CH4CNT ; \ DMA1_CH4CNT_CNT, Transfer counter

\ DMA1_CH4PADDR (read-write) Reset:0x00000000
: DMA1_CH4PADDR_PADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH4PADDR ; \ DMA1_CH4PADDR_PADDR, Peripheral base address

\ DMA1_CH4MADDR (read-write) Reset:0x00000000
: DMA1_CH4MADDR_MADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) DMA1_CH4MADDR ; \ DMA1_CH4MADDR_MADDR, Memory base address

\ EXMC_SNCTL0 (read-write) Reset:0x000030DA
: EXMC_SNCTL0_ASYNCWAIT ( -- x addr ) 15 bit EXMC_SNCTL0 ; \ EXMC_SNCTL0_ASYNCWAIT, Asynchronous wait
: EXMC_SNCTL0_NRWTEN ( -- x addr ) 13 bit EXMC_SNCTL0 ; \ EXMC_SNCTL0_NRWTEN, NWAIT signal enable
: EXMC_SNCTL0_WREN ( -- x addr ) 12 bit EXMC_SNCTL0 ; \ EXMC_SNCTL0_WREN, Write enable
: EXMC_SNCTL0_NRWTPOL ( -- x addr ) 9 bit EXMC_SNCTL0 ; \ EXMC_SNCTL0_NRWTPOL, NWAIT signal polarity
: EXMC_SNCTL0_NREN ( -- x addr ) 6 bit EXMC_SNCTL0 ; \ EXMC_SNCTL0_NREN, NOR Flash access enable
: EXMC_SNCTL0_NRW ( %bb -- x addr ) 4 lshift EXMC_SNCTL0 ; \ EXMC_SNCTL0_NRW, NOR bank memory data bus width
: EXMC_SNCTL0_NRTP ( %bb -- x addr ) 2 lshift EXMC_SNCTL0 ; \ EXMC_SNCTL0_NRTP, NOR bank memory type
: EXMC_SNCTL0_NRMUX ( -- x addr ) 1 bit EXMC_SNCTL0 ; \ EXMC_SNCTL0_NRMUX, NOR bank memory address/data multiplexing
: EXMC_SNCTL0_NRBKEN ( -- x addr ) 0 bit EXMC_SNCTL0 ; \ EXMC_SNCTL0_NRBKEN, NOR bank enable

\ EXMC_SNTCFG0 (read-write) Reset:0x0FFFFFFF
: EXMC_SNTCFG0_BUSLAT ( %bbbb -- x addr ) 16 lshift EXMC_SNTCFG0 ; \ EXMC_SNTCFG0_BUSLAT, Bus latency
: EXMC_SNTCFG0_DSET ( %bbbbbbbb -- x addr ) 8 lshift EXMC_SNTCFG0 ; \ EXMC_SNTCFG0_DSET, Data setup time
: EXMC_SNTCFG0_AHLD ( %bbbb -- x addr ) 4 lshift EXMC_SNTCFG0 ; \ EXMC_SNTCFG0_AHLD, Address hold time
: EXMC_SNTCFG0_ASET ( %bbbb -- x addr ) EXMC_SNTCFG0 ; \ EXMC_SNTCFG0_ASET, Address setup time

\ EXMC_SNCTL1 (read-write) Reset:0x000030DA
: EXMC_SNCTL1_ASYNCWAIT ( -- x addr ) 15 bit EXMC_SNCTL1 ; \ EXMC_SNCTL1_ASYNCWAIT, Asynchronous wait
: EXMC_SNCTL1_NRWTEN ( -- x addr ) 13 bit EXMC_SNCTL1 ; \ EXMC_SNCTL1_NRWTEN, NWAIT signal enable
: EXMC_SNCTL1_WREN ( -- x addr ) 12 bit EXMC_SNCTL1 ; \ EXMC_SNCTL1_WREN, Write enable
: EXMC_SNCTL1_NRWTPOL ( -- x addr ) 9 bit EXMC_SNCTL1 ; \ EXMC_SNCTL1_NRWTPOL, NWAIT signal polarity
: EXMC_SNCTL1_NREN ( -- x addr ) 6 bit EXMC_SNCTL1 ; \ EXMC_SNCTL1_NREN, NOR Flash access enable
: EXMC_SNCTL1_NRW ( %bb -- x addr ) 4 lshift EXMC_SNCTL1 ; \ EXMC_SNCTL1_NRW, NOR bank memory data bus width
: EXMC_SNCTL1_NRTP ( %bb -- x addr ) 2 lshift EXMC_SNCTL1 ; \ EXMC_SNCTL1_NRTP, NOR bank memory type
: EXMC_SNCTL1_NRMUX ( -- x addr ) 1 bit EXMC_SNCTL1 ; \ EXMC_SNCTL1_NRMUX, NOR bank memory address/data multiplexing
: EXMC_SNCTL1_NRBKEN ( -- x addr ) 0 bit EXMC_SNCTL1 ; \ EXMC_SNCTL1_NRBKEN, NOR bank enable

\ EXTI_INTEN (read-write) Reset:0x00000000
: EXTI_INTEN_INTEN0 ( -- x addr ) 0 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN0, Enable Interrupt on line 0
: EXTI_INTEN_INTEN1 ( -- x addr ) 1 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN1, Enable Interrupt on line 1
: EXTI_INTEN_INTEN2 ( -- x addr ) 2 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN2, Enable Interrupt on line 2
: EXTI_INTEN_INTEN3 ( -- x addr ) 3 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN3, Enable Interrupt on line 3
: EXTI_INTEN_INTEN4 ( -- x addr ) 4 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN4, Enable Interrupt on line 4
: EXTI_INTEN_INTEN5 ( -- x addr ) 5 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN5, Enable Interrupt on line 5
: EXTI_INTEN_INTEN6 ( -- x addr ) 6 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN6, Enable Interrupt on line 6
: EXTI_INTEN_INTEN7 ( -- x addr ) 7 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN7, Enable Interrupt on line 7
: EXTI_INTEN_INTEN8 ( -- x addr ) 8 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN8, Enable Interrupt on line 8
: EXTI_INTEN_INTEN9 ( -- x addr ) 9 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN9, Enable Interrupt on line 9
: EXTI_INTEN_INTEN10 ( -- x addr ) 10 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN10, Enable Interrupt on line 10
: EXTI_INTEN_INTEN11 ( -- x addr ) 11 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN11, Enable Interrupt on line 11
: EXTI_INTEN_INTEN12 ( -- x addr ) 12 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN12, Enable Interrupt on line 12
: EXTI_INTEN_INTEN13 ( -- x addr ) 13 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN13, Enable Interrupt on line 13
: EXTI_INTEN_INTEN14 ( -- x addr ) 14 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN14, Enable Interrupt on line 14
: EXTI_INTEN_INTEN15 ( -- x addr ) 15 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN15, Enable Interrupt on line 15
: EXTI_INTEN_INTEN16 ( -- x addr ) 16 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN16, Enable Interrupt on line 16
: EXTI_INTEN_INTEN17 ( -- x addr ) 17 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN17, Enable Interrupt on line 17
: EXTI_INTEN_INTEN18 ( -- x addr ) 18 bit EXTI_INTEN ; \ EXTI_INTEN_INTEN18, Enable Interrupt on line 18

\ EXTI_EVEN (read-write) Reset:0x00000000
: EXTI_EVEN_EVEN0 ( -- x addr ) 0 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN0, Enable Event on line 0
: EXTI_EVEN_EVEN1 ( -- x addr ) 1 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN1, Enable Event on line 1
: EXTI_EVEN_EVEN2 ( -- x addr ) 2 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN2, Enable Event on line 2
: EXTI_EVEN_EVEN3 ( -- x addr ) 3 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN3, Enable Event on line 3
: EXTI_EVEN_EVEN4 ( -- x addr ) 4 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN4, Enable Event on line 4
: EXTI_EVEN_EVEN5 ( -- x addr ) 5 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN5, Enable Event on line 5
: EXTI_EVEN_EVEN6 ( -- x addr ) 6 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN6, Enable Event on line 6
: EXTI_EVEN_EVEN7 ( -- x addr ) 7 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN7, Enable Event on line 7
: EXTI_EVEN_EVEN8 ( -- x addr ) 8 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN8, Enable Event on line 8
: EXTI_EVEN_EVEN9 ( -- x addr ) 9 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN9, Enable Event on line 9
: EXTI_EVEN_EVEN10 ( -- x addr ) 10 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN10, Enable Event on line 10
: EXTI_EVEN_EVEN11 ( -- x addr ) 11 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN11, Enable Event on line 11
: EXTI_EVEN_EVEN12 ( -- x addr ) 12 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN12, Enable Event on line 12
: EXTI_EVEN_EVEN13 ( -- x addr ) 13 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN13, Enable Event on line 13
: EXTI_EVEN_EVEN14 ( -- x addr ) 14 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN14, Enable Event on line 14
: EXTI_EVEN_EVEN15 ( -- x addr ) 15 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN15, Enable Event on line 15
: EXTI_EVEN_EVEN16 ( -- x addr ) 16 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN16, Enable Event on line 16
: EXTI_EVEN_EVEN17 ( -- x addr ) 17 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN17, Enable Event on line 17
: EXTI_EVEN_EVEN18 ( -- x addr ) 18 bit EXTI_EVEN ; \ EXTI_EVEN_EVEN18, Enable Event on line 18

\ EXTI_RTEN (read-write) Reset:0x00000000
: EXTI_RTEN_RTEN0 ( -- x addr ) 0 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN0, Rising edge trigger enable of  line 0
: EXTI_RTEN_RTEN1 ( -- x addr ) 1 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN1, Rising edge trigger enable of  line 1
: EXTI_RTEN_RTEN2 ( -- x addr ) 2 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN2, Rising edge trigger enable of  line 2
: EXTI_RTEN_RTEN3 ( -- x addr ) 3 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN3, Rising edge trigger enable of  line 3
: EXTI_RTEN_RTEN4 ( -- x addr ) 4 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN4, Rising edge trigger enable of  line 4
: EXTI_RTEN_RTEN5 ( -- x addr ) 5 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN5, Rising edge trigger enable of  line 5
: EXTI_RTEN_RTEN6 ( -- x addr ) 6 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN6, Rising edge trigger enable of  line 6
: EXTI_RTEN_RTEN7 ( -- x addr ) 7 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN7, Rising edge trigger enable of  line 7
: EXTI_RTEN_RTEN8 ( -- x addr ) 8 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN8, Rising edge trigger enable of  line 8
: EXTI_RTEN_RTEN9 ( -- x addr ) 9 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN9, Rising edge trigger enable of  line 9
: EXTI_RTEN_RTEN10 ( -- x addr ) 10 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN10, Rising edge trigger enable of  line 10
: EXTI_RTEN_RTEN11 ( -- x addr ) 11 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN11, Rising edge trigger enable of  line 11
: EXTI_RTEN_RTEN12 ( -- x addr ) 12 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN12, Rising edge trigger enable of  line 12
: EXTI_RTEN_RTEN13 ( -- x addr ) 13 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN13, Rising edge trigger enable of  line 13
: EXTI_RTEN_RTEN14 ( -- x addr ) 14 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN14, Rising edge trigger enable of  line 14
: EXTI_RTEN_RTEN15 ( -- x addr ) 15 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN15, Rising edge trigger enable of  line 15
: EXTI_RTEN_RTEN16 ( -- x addr ) 16 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN16, Rising edge trigger enable of  line 16
: EXTI_RTEN_RTEN17 ( -- x addr ) 17 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN17, Rising edge trigger enable of  line 17
: EXTI_RTEN_RTEN18 ( -- x addr ) 18 bit EXTI_RTEN ; \ EXTI_RTEN_RTEN18, Rising edge trigger enable of  line 18

\ EXTI_FTEN (read-write) Reset:0x00000000
: EXTI_FTEN_FTEN0 ( -- x addr ) 0 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN0, Falling edge trigger enable of  line 0
: EXTI_FTEN_FTEN1 ( -- x addr ) 1 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN1, Falling edge trigger enable of  line 1
: EXTI_FTEN_FTEN2 ( -- x addr ) 2 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN2, Falling edge trigger enable of  line 2
: EXTI_FTEN_FTEN3 ( -- x addr ) 3 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN3, Falling edge trigger enable of  line 3
: EXTI_FTEN_FTEN4 ( -- x addr ) 4 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN4, Falling edge trigger enable of  line 4
: EXTI_FTEN_FTEN5 ( -- x addr ) 5 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN5, Falling edge trigger enable of  line 5
: EXTI_FTEN_FTEN6 ( -- x addr ) 6 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN6, Falling edge trigger enable of  line 6
: EXTI_FTEN_FTEN7 ( -- x addr ) 7 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN7, Falling edge trigger enable of  line 7
: EXTI_FTEN_FTEN8 ( -- x addr ) 8 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN8, Falling edge trigger enable of  line 8
: EXTI_FTEN_FTEN9 ( -- x addr ) 9 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN9, Falling edge trigger enable of  line 9
: EXTI_FTEN_FTEN10 ( -- x addr ) 10 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN10, Falling edge trigger enable of  line 10
: EXTI_FTEN_FTEN11 ( -- x addr ) 11 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN11, Falling edge trigger enable of  line 11
: EXTI_FTEN_FTEN12 ( -- x addr ) 12 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN12, Falling edge trigger enable of  line 12
: EXTI_FTEN_FTEN13 ( -- x addr ) 13 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN13, Falling edge trigger enable of  line 13
: EXTI_FTEN_FTEN14 ( -- x addr ) 14 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN14, Falling edge trigger enable of  line 14
: EXTI_FTEN_FTEN15 ( -- x addr ) 15 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN15, Falling edge trigger enable of  line 15
: EXTI_FTEN_FTEN16 ( -- x addr ) 16 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN16, Falling edge trigger enable of  line 16
: EXTI_FTEN_FTEN17 ( -- x addr ) 17 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN17, Falling edge trigger enable of  line 17
: EXTI_FTEN_FTEN18 ( -- x addr ) 18 bit EXTI_FTEN ; \ EXTI_FTEN_FTEN18, Falling edge trigger enable of  line 18

\ EXTI_SWIEV (read-write) Reset:0x00000000
: EXTI_SWIEV_SWIEV0 ( -- x addr ) 0 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV0, Interrupt/Event software trigger on line  0
: EXTI_SWIEV_SWIEV1 ( -- x addr ) 1 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV1, Interrupt/Event software trigger on line  1
: EXTI_SWIEV_SWIEV2 ( -- x addr ) 2 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV2, Interrupt/Event software trigger on line  2
: EXTI_SWIEV_SWIEV3 ( -- x addr ) 3 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV3, Interrupt/Event software trigger on line  3
: EXTI_SWIEV_SWIEV4 ( -- x addr ) 4 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV4, Interrupt/Event software trigger on line  4
: EXTI_SWIEV_SWIEV5 ( -- x addr ) 5 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV5, Interrupt/Event software trigger on line  5
: EXTI_SWIEV_SWIEV6 ( -- x addr ) 6 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV6, Interrupt/Event software trigger on line  6
: EXTI_SWIEV_SWIEV7 ( -- x addr ) 7 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV7, Interrupt/Event software trigger on line  7
: EXTI_SWIEV_SWIEV8 ( -- x addr ) 8 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV8, Interrupt/Event software trigger on line  8
: EXTI_SWIEV_SWIEV9 ( -- x addr ) 9 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV9, Interrupt/Event software trigger on line  9
: EXTI_SWIEV_SWIEV10 ( -- x addr ) 10 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV10, Interrupt/Event software trigger on line  10
: EXTI_SWIEV_SWIEV11 ( -- x addr ) 11 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV11, Interrupt/Event software trigger on line  11
: EXTI_SWIEV_SWIEV12 ( -- x addr ) 12 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV12, Interrupt/Event software trigger on line  12
: EXTI_SWIEV_SWIEV13 ( -- x addr ) 13 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV13, Interrupt/Event software trigger on line  13
: EXTI_SWIEV_SWIEV14 ( -- x addr ) 14 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV14, Interrupt/Event software trigger on line  14
: EXTI_SWIEV_SWIEV15 ( -- x addr ) 15 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV15, Interrupt/Event software trigger on line  15
: EXTI_SWIEV_SWIEV16 ( -- x addr ) 16 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV16, Interrupt/Event software trigger on line  16
: EXTI_SWIEV_SWIEV17 ( -- x addr ) 17 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV17, Interrupt/Event software trigger on line  17
: EXTI_SWIEV_SWIEV18 ( -- x addr ) 18 bit EXTI_SWIEV ; \ EXTI_SWIEV_SWIEV18, Interrupt/Event software trigger on line  18

\ EXTI_PD (read-write) Reset:0x00000000
: EXTI_PD_PD0 ( -- x addr ) 0 bit EXTI_PD ; \ EXTI_PD_PD0, Interrupt pending status of line 0
: EXTI_PD_PD1 ( -- x addr ) 1 bit EXTI_PD ; \ EXTI_PD_PD1, Interrupt pending status of line 1
: EXTI_PD_PD2 ( -- x addr ) 2 bit EXTI_PD ; \ EXTI_PD_PD2, Interrupt pending status of line 2
: EXTI_PD_PD3 ( -- x addr ) 3 bit EXTI_PD ; \ EXTI_PD_PD3, Interrupt pending status of line 3
: EXTI_PD_PD4 ( -- x addr ) 4 bit EXTI_PD ; \ EXTI_PD_PD4, Interrupt pending status of line 4
: EXTI_PD_PD5 ( -- x addr ) 5 bit EXTI_PD ; \ EXTI_PD_PD5, Interrupt pending status of line 5
: EXTI_PD_PD6 ( -- x addr ) 6 bit EXTI_PD ; \ EXTI_PD_PD6, Interrupt pending status of line 6
: EXTI_PD_PD7 ( -- x addr ) 7 bit EXTI_PD ; \ EXTI_PD_PD7, Interrupt pending status of line 7
: EXTI_PD_PD8 ( -- x addr ) 8 bit EXTI_PD ; \ EXTI_PD_PD8, Interrupt pending status of line 8
: EXTI_PD_PD9 ( -- x addr ) 9 bit EXTI_PD ; \ EXTI_PD_PD9, Interrupt pending status of line 9
: EXTI_PD_PD10 ( -- x addr ) 10 bit EXTI_PD ; \ EXTI_PD_PD10, Interrupt pending status of line 10
: EXTI_PD_PD11 ( -- x addr ) 11 bit EXTI_PD ; \ EXTI_PD_PD11, Interrupt pending status of line 11
: EXTI_PD_PD12 ( -- x addr ) 12 bit EXTI_PD ; \ EXTI_PD_PD12, Interrupt pending status of line 12
: EXTI_PD_PD13 ( -- x addr ) 13 bit EXTI_PD ; \ EXTI_PD_PD13, Interrupt pending status of line 13
: EXTI_PD_PD14 ( -- x addr ) 14 bit EXTI_PD ; \ EXTI_PD_PD14, Interrupt pending status of line 14
: EXTI_PD_PD15 ( -- x addr ) 15 bit EXTI_PD ; \ EXTI_PD_PD15, Interrupt pending status of line 15
: EXTI_PD_PD16 ( -- x addr ) 16 bit EXTI_PD ; \ EXTI_PD_PD16, Interrupt pending status of line 16
: EXTI_PD_PD17 ( -- x addr ) 17 bit EXTI_PD ; \ EXTI_PD_PD17, Interrupt pending status of line 17
: EXTI_PD_PD18 ( -- x addr ) 18 bit EXTI_PD ; \ EXTI_PD_PD18, Interrupt pending status of line 18

\ FMC_WS (read-write) Reset:0x00000000
: FMC_WS_WSCNT ( %bbb -- x addr ) FMC_WS ; \ FMC_WS_WSCNT, wait state counter register

\ FMC_KEY0 (write-only) Reset:0x00000000
: FMC_KEY0_KEY ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) FMC_KEY0 ; \ FMC_KEY0_KEY, FMC_CTL0 unlock key

\ FMC_OBKEY (write-only) Reset:0x00000000
: FMC_OBKEY_OBKEY ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) FMC_OBKEY ; \ FMC_OBKEY_OBKEY, FMC_ CTL0 option byte operation unlock register

\ FMC_STAT0 (multiple-access)  Reset:0x00000000
: FMC_STAT0_ENDF? ( -- 1|0 ) 5 bit FMC_STAT0 bit@ ; \ FMC_STAT0_ENDF, End of operation flag bit
: FMC_STAT0_WPERR? ( -- 1|0 ) 4 bit FMC_STAT0 bit@ ; \ FMC_STAT0_WPERR, Erase/Program protection error flag bit
: FMC_STAT0_PGERR? ( -- 1|0 ) 2 bit FMC_STAT0 bit@ ; \ FMC_STAT0_PGERR, Program error flag bit
: FMC_STAT0_BUSY ( -- x addr ) 0 bit FMC_STAT0 ; \ FMC_STAT0_BUSY, The flash is busy bit

\ FMC_CTL0 (read-write) Reset:0x00000080
: FMC_CTL0_ENDIE ( -- x addr ) 12 bit FMC_CTL0 ; \ FMC_CTL0_ENDIE, End of operation interrupt enable bit
: FMC_CTL0_ERRIE ( -- x addr ) 10 bit FMC_CTL0 ; \ FMC_CTL0_ERRIE, Error interrupt enable bit
: FMC_CTL0_OBWEN ( -- x addr ) 9 bit FMC_CTL0 ; \ FMC_CTL0_OBWEN, Option byte erase/program enable bit
: FMC_CTL0_LK ( -- x addr ) 7 bit FMC_CTL0 ; \ FMC_CTL0_LK, FMC_CTL0 lock bit
: FMC_CTL0_START ( -- x addr ) 6 bit FMC_CTL0 ; \ FMC_CTL0_START, Send erase command to FMC bit
: FMC_CTL0_OBER ( -- x addr ) 5 bit FMC_CTL0 ; \ FMC_CTL0_OBER, Option bytes erase command bit
: FMC_CTL0_OBPG ( -- x addr ) 4 bit FMC_CTL0 ; \ FMC_CTL0_OBPG, Option bytes program command bit
: FMC_CTL0_MER ( -- x addr ) 2 bit FMC_CTL0 ; \ FMC_CTL0_MER, Main flash mass erase for bank0 command bit
: FMC_CTL0_PER ( -- x addr ) 1 bit FMC_CTL0 ; \ FMC_CTL0_PER, Main flash page erase for bank0 command bit
: FMC_CTL0_PG ( -- x addr ) 0 bit FMC_CTL0 ; \ FMC_CTL0_PG, Main flash program for bank0 command bit

\ FMC_ADDR0 (write-only) Reset:0x00000000
: FMC_ADDR0_ADDR ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) FMC_ADDR0 ; \ FMC_ADDR0_ADDR, Flash erase/program command address bits

\ FMC_OBSTAT (read-only) Reset:0x00000000
: FMC_OBSTAT_OBERR? ( --  1|0 ) 0 bit FMC_OBSTAT bit@ ; \ FMC_OBSTAT_OBERR, Option bytes read error bit
: FMC_OBSTAT_SPC? ( --  1|0 ) 1 bit FMC_OBSTAT bit@ ; \ FMC_OBSTAT_SPC, Option bytes security protection code
: FMC_OBSTAT_USER? ( --  x ) 2 lshift FMC_OBSTAT @ ; \ FMC_OBSTAT_USER, Store USER of option bytes block after system reset
: FMC_OBSTAT_DATA? ( --  x ) 10 lshift FMC_OBSTAT @ ; \ FMC_OBSTAT_DATA, Store DATA[15:0] of option bytes block after system reset

\ FMC_WP (read-only) Reset:0x00000000
: FMC_WP_WP? ( --  x ) FMC_WP @ ; \ FMC_WP_WP, Store WP[31:0] of option bytes block after system reset

\ FMC_PID (read-only) Reset:0x00000000
: FMC_PID_PID? ( --  x ) FMC_PID @ ; \ FMC_PID_PID, Product reserved ID code register

\ FWDGT_CTL (write-only) Reset:0x00000000
: FWDGT_CTL_CMD ( %bbbbbbbbbbbbbbbb -- x addr ) FWDGT_CTL ; \ FWDGT_CTL_CMD, Key value

\ FWDGT_PSC (read-write) Reset:0x00000000
: FWDGT_PSC_PSC ( %bbb -- x addr ) FWDGT_PSC ; \ FWDGT_PSC_PSC, Free watchdog timer prescaler selection

\ FWDGT_RLD (read-write) Reset:0x00000FFF
: FWDGT_RLD_RLD ( %bbbbbbbbbbb -- x addr ) FWDGT_RLD ; \ FWDGT_RLD_RLD, Free watchdog timer counter reload value

\ FWDGT_STAT (read-only) Reset:0x00000000
: FWDGT_STAT_PUD? ( --  1|0 ) 0 bit FWDGT_STAT bit@ ; \ FWDGT_STAT_PUD, Free watchdog timer prescaler value update
: FWDGT_STAT_RUD? ( --  1|0 ) 1 bit FWDGT_STAT bit@ ; \ FWDGT_STAT_RUD, Free watchdog timer counter reload value update

\ GPIOA_CTL0 (read-write) Reset:0x44444444
: GPIOA_CTL0_CTL7 ( %bb -- x addr ) 30 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_CTL7, Port x configuration bits x =  7
: GPIOA_CTL0_MD7 ( %bb -- x addr ) 28 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_MD7, Port x mode bits x =  7
: GPIOA_CTL0_CTL6 ( %bb -- x addr ) 26 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_CTL6, Port x configuration bits x =  6
: GPIOA_CTL0_MD6 ( %bb -- x addr ) 24 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_MD6, Port x mode bits x =  6
: GPIOA_CTL0_CTL5 ( %bb -- x addr ) 22 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_CTL5, Port x configuration bits x =  5
: GPIOA_CTL0_MD5 ( %bb -- x addr ) 20 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_MD5, Port x mode bits x =  5
: GPIOA_CTL0_CTL4 ( %bb -- x addr ) 18 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_CTL4, Port x configuration bits x =  4
: GPIOA_CTL0_MD4 ( %bb -- x addr ) 16 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_MD4, Port x mode bits x =  4
: GPIOA_CTL0_CTL3 ( %bb -- x addr ) 14 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_CTL3, Port x configuration bits x =  3
: GPIOA_CTL0_MD3 ( %bb -- x addr ) 12 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_MD3, Port x mode bits x =  3 
: GPIOA_CTL0_CTL2 ( %bb -- x addr ) 10 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_CTL2, Port x configuration bits x =  2
: GPIOA_CTL0_MD2 ( %bb -- x addr ) 8 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_MD2, Port x mode bits x =  2 
: GPIOA_CTL0_CTL1 ( %bb -- x addr ) 6 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_CTL1, Port x configuration bits x =  1
: GPIOA_CTL0_MD1 ( %bb -- x addr ) 4 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_MD1, Port x mode bits x =  1
: GPIOA_CTL0_CTL0 ( %bb -- x addr ) 2 lshift GPIOA_CTL0 ; \ GPIOA_CTL0_CTL0, Port x configuration bits x =  0
: GPIOA_CTL0_MD0 ( %bb -- x addr ) GPIOA_CTL0 ; \ GPIOA_CTL0_MD0, Port x mode bits x =  0

\ GPIOA_CTL1 (read-write) Reset:0x44444444
: GPIOA_CTL1_CTL15 ( %bb -- x addr ) 30 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_CTL15, Port x configuration bits x =  15
: GPIOA_CTL1_MD15 ( %bb -- x addr ) 28 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_MD15, Port x mode bits x =  15
: GPIOA_CTL1_CTL14 ( %bb -- x addr ) 26 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_CTL14, Port x configuration bits x =  14
: GPIOA_CTL1_MD14 ( %bb -- x addr ) 24 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_MD14, Port x mode bits x =  14
: GPIOA_CTL1_CTL13 ( %bb -- x addr ) 22 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_CTL13, Port x configuration bits x =  13
: GPIOA_CTL1_MD13 ( %bb -- x addr ) 20 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_MD13, Port x mode bits x =  13
: GPIOA_CTL1_CTL12 ( %bb -- x addr ) 18 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_CTL12, Port x configuration bits x =  12
: GPIOA_CTL1_MD12 ( %bb -- x addr ) 16 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_MD12, Port x mode bits x =  12
: GPIOA_CTL1_CTL11 ( %bb -- x addr ) 14 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_CTL11, Port x configuration bits x =  11
: GPIOA_CTL1_MD11 ( %bb -- x addr ) 12 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_MD11, Port x mode bits x =  11 
: GPIOA_CTL1_CTL10 ( %bb -- x addr ) 10 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_CTL10, Port x configuration bits x =  10
: GPIOA_CTL1_MD10 ( %bb -- x addr ) 8 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_MD10, Port x mode bits x =  10 
: GPIOA_CTL1_CTL9 ( %bb -- x addr ) 6 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_CTL9, Port x configuration bits x =  9
: GPIOA_CTL1_MD9 ( %bb -- x addr ) 4 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_MD9, Port x mode bits x =  9
: GPIOA_CTL1_CTL8 ( %bb -- x addr ) 2 lshift GPIOA_CTL1 ; \ GPIOA_CTL1_CTL8, Port x configuration bits x =  8
: GPIOA_CTL1_MD8 ( %bb -- x addr ) GPIOA_CTL1 ; \ GPIOA_CTL1_MD8, Port x mode bits x =  8

\ GPIOA_ISTAT (read-only) Reset:0x00000000
: GPIOA_ISTAT_ISTAT15? ( --  1|0 ) 15 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT15, Port input status
: GPIOA_ISTAT_ISTAT14? ( --  1|0 ) 14 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT14, Port input status
: GPIOA_ISTAT_ISTAT13? ( --  1|0 ) 13 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT13, Port input status
: GPIOA_ISTAT_ISTAT12? ( --  1|0 ) 12 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT12, Port input status
: GPIOA_ISTAT_ISTAT11? ( --  1|0 ) 11 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT11, Port input status
: GPIOA_ISTAT_ISTAT10? ( --  1|0 ) 10 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT10, Port input status
: GPIOA_ISTAT_ISTAT9? ( --  1|0 ) 9 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT9, Port input status
: GPIOA_ISTAT_ISTAT8? ( --  1|0 ) 8 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT8, Port input status
: GPIOA_ISTAT_ISTAT7? ( --  1|0 ) 7 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT7, Port input status
: GPIOA_ISTAT_ISTAT6? ( --  1|0 ) 6 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT6, Port input status
: GPIOA_ISTAT_ISTAT5? ( --  1|0 ) 5 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT5, Port input status
: GPIOA_ISTAT_ISTAT4? ( --  1|0 ) 4 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT4, Port input status
: GPIOA_ISTAT_ISTAT3? ( --  1|0 ) 3 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT3, Port input status
: GPIOA_ISTAT_ISTAT2? ( --  1|0 ) 2 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT2, Port input status
: GPIOA_ISTAT_ISTAT1? ( --  1|0 ) 1 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT1, Port input status
: GPIOA_ISTAT_ISTAT0? ( --  1|0 ) 0 bit GPIOA_ISTAT bit@ ; \ GPIOA_ISTAT_ISTAT0, Port input status

\ GPIOA_OCTL (read-write) Reset:0x00000000
: GPIOA_OCTL_OCTL15 ( -- x addr ) 15 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL15, Port output control
: GPIOA_OCTL_OCTL14 ( -- x addr ) 14 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL14, Port output control
: GPIOA_OCTL_OCTL13 ( -- x addr ) 13 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL13, Port output control
: GPIOA_OCTL_OCTL12 ( -- x addr ) 12 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL12, Port output control
: GPIOA_OCTL_OCTL11 ( -- x addr ) 11 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL11, Port output control
: GPIOA_OCTL_OCTL10 ( -- x addr ) 10 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL10, Port output control
: GPIOA_OCTL_OCTL9 ( -- x addr ) 9 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL9, Port output control
: GPIOA_OCTL_OCTL8 ( -- x addr ) 8 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL8, Port output control
: GPIOA_OCTL_OCTL7 ( -- x addr ) 7 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL7, Port output control
: GPIOA_OCTL_OCTL6 ( -- x addr ) 6 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL6, Port output control
: GPIOA_OCTL_OCTL5 ( -- x addr ) 5 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL5, Port output control
: GPIOA_OCTL_OCTL4 ( -- x addr ) 4 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL4, Port output control
: GPIOA_OCTL_OCTL3 ( -- x addr ) 3 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL3, Port output control
: GPIOA_OCTL_OCTL2 ( -- x addr ) 2 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL2, Port output control
: GPIOA_OCTL_OCTL1 ( -- x addr ) 1 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL1, Port output control
: GPIOA_OCTL_OCTL0 ( -- x addr ) 0 bit GPIOA_OCTL ; \ GPIOA_OCTL_OCTL0, Port output control

\ GPIOA_BOP (write-only) Reset:0x00000000
: GPIOA_BOP_CR15 ( -- x addr ) 31 bit GPIOA_BOP ; \ GPIOA_BOP_CR15, Port 15 Clear bit
: GPIOA_BOP_CR14 ( -- x addr ) 30 bit GPIOA_BOP ; \ GPIOA_BOP_CR14, Port 14 Clear bit
: GPIOA_BOP_CR13 ( -- x addr ) 29 bit GPIOA_BOP ; \ GPIOA_BOP_CR13, Port 13 Clear bit
: GPIOA_BOP_CR12 ( -- x addr ) 28 bit GPIOA_BOP ; \ GPIOA_BOP_CR12, Port 12 Clear bit
: GPIOA_BOP_CR11 ( -- x addr ) 27 bit GPIOA_BOP ; \ GPIOA_BOP_CR11, Port 11 Clear bit
: GPIOA_BOP_CR10 ( -- x addr ) 26 bit GPIOA_BOP ; \ GPIOA_BOP_CR10, Port 10 Clear bit
: GPIOA_BOP_CR9 ( -- x addr ) 25 bit GPIOA_BOP ; \ GPIOA_BOP_CR9, Port 9 Clear bit
: GPIOA_BOP_CR8 ( -- x addr ) 24 bit GPIOA_BOP ; \ GPIOA_BOP_CR8, Port 8 Clear bit
: GPIOA_BOP_CR7 ( -- x addr ) 23 bit GPIOA_BOP ; \ GPIOA_BOP_CR7, Port 7 Clear bit
: GPIOA_BOP_CR6 ( -- x addr ) 22 bit GPIOA_BOP ; \ GPIOA_BOP_CR6, Port 6 Clear bit
: GPIOA_BOP_CR5 ( -- x addr ) 21 bit GPIOA_BOP ; \ GPIOA_BOP_CR5, Port 5 Clear bit
: GPIOA_BOP_CR4 ( -- x addr ) 20 bit GPIOA_BOP ; \ GPIOA_BOP_CR4, Port 4 Clear bit
: GPIOA_BOP_CR3 ( -- x addr ) 19 bit GPIOA_BOP ; \ GPIOA_BOP_CR3, Port 3 Clear bit
: GPIOA_BOP_CR2 ( -- x addr ) 18 bit GPIOA_BOP ; \ GPIOA_BOP_CR2, Port 2 Clear bit
: GPIOA_BOP_CR1 ( -- x addr ) 17 bit GPIOA_BOP ; \ GPIOA_BOP_CR1, Port 1 Clear bit
: GPIOA_BOP_CR0 ( -- x addr ) 16 bit GPIOA_BOP ; \ GPIOA_BOP_CR0, Port 0 Clear bit
: GPIOA_BOP_BOP15 ( -- x addr ) 15 bit GPIOA_BOP ; \ GPIOA_BOP_BOP15, Port 15 Set bit
: GPIOA_BOP_BOP14 ( -- x addr ) 14 bit GPIOA_BOP ; \ GPIOA_BOP_BOP14, Port 14 Set bit
: GPIOA_BOP_BOP13 ( -- x addr ) 13 bit GPIOA_BOP ; \ GPIOA_BOP_BOP13, Port 13 Set bit
: GPIOA_BOP_BOP12 ( -- x addr ) 12 bit GPIOA_BOP ; \ GPIOA_BOP_BOP12, Port 12 Set bit
: GPIOA_BOP_BOP11 ( -- x addr ) 11 bit GPIOA_BOP ; \ GPIOA_BOP_BOP11, Port 11 Set bit
: GPIOA_BOP_BOP10 ( -- x addr ) 10 bit GPIOA_BOP ; \ GPIOA_BOP_BOP10, Port 10 Set bit
: GPIOA_BOP_BOP9 ( -- x addr ) 9 bit GPIOA_BOP ; \ GPIOA_BOP_BOP9, Port 9 Set bit
: GPIOA_BOP_BOP8 ( -- x addr ) 8 bit GPIOA_BOP ; \ GPIOA_BOP_BOP8, Port 8 Set bit
: GPIOA_BOP_BOP7 ( -- x addr ) 7 bit GPIOA_BOP ; \ GPIOA_BOP_BOP7, Port 7 Set bit
: GPIOA_BOP_BOP6 ( -- x addr ) 6 bit GPIOA_BOP ; \ GPIOA_BOP_BOP6, Port 6 Set bit
: GPIOA_BOP_BOP5 ( -- x addr ) 5 bit GPIOA_BOP ; \ GPIOA_BOP_BOP5, Port 5 Set bit
: GPIOA_BOP_BOP4 ( -- x addr ) 4 bit GPIOA_BOP ; \ GPIOA_BOP_BOP4, Port 4 Set bit
: GPIOA_BOP_BOP3 ( -- x addr ) 3 bit GPIOA_BOP ; \ GPIOA_BOP_BOP3, Port 3 Set bit
: GPIOA_BOP_BOP2 ( -- x addr ) 2 bit GPIOA_BOP ; \ GPIOA_BOP_BOP2, Port 2 Set bit
: GPIOA_BOP_BOP1 ( -- x addr ) 1 bit GPIOA_BOP ; \ GPIOA_BOP_BOP1, Port 1 Set bit
: GPIOA_BOP_BOP0 ( -- x addr ) 0 bit GPIOA_BOP ; \ GPIOA_BOP_BOP0, Port 0 Set bit

\ GPIOA_BC (write-only) Reset:0x00000000
: GPIOA_BC_CR15 ( -- x addr ) 15 bit GPIOA_BC ; \ GPIOA_BC_CR15, Port 15 Clear bit
: GPIOA_BC_CR14 ( -- x addr ) 14 bit GPIOA_BC ; \ GPIOA_BC_CR14, Port 14 Clear bit
: GPIOA_BC_CR13 ( -- x addr ) 13 bit GPIOA_BC ; \ GPIOA_BC_CR13, Port 13 Clear bit
: GPIOA_BC_CR12 ( -- x addr ) 12 bit GPIOA_BC ; \ GPIOA_BC_CR12, Port 12 Clear bit
: GPIOA_BC_CR11 ( -- x addr ) 11 bit GPIOA_BC ; \ GPIOA_BC_CR11, Port 11 Clear bit
: GPIOA_BC_CR10 ( -- x addr ) 10 bit GPIOA_BC ; \ GPIOA_BC_CR10, Port 10 Clear bit
: GPIOA_BC_CR9 ( -- x addr ) 9 bit GPIOA_BC ; \ GPIOA_BC_CR9, Port 9 Clear bit
: GPIOA_BC_CR8 ( -- x addr ) 8 bit GPIOA_BC ; \ GPIOA_BC_CR8, Port 8 Clear bit
: GPIOA_BC_CR7 ( -- x addr ) 7 bit GPIOA_BC ; \ GPIOA_BC_CR7, Port 7 Clear bit
: GPIOA_BC_CR6 ( -- x addr ) 6 bit GPIOA_BC ; \ GPIOA_BC_CR6, Port 6 Clear bit
: GPIOA_BC_CR5 ( -- x addr ) 5 bit GPIOA_BC ; \ GPIOA_BC_CR5, Port 5 Clear bit
: GPIOA_BC_CR4 ( -- x addr ) 4 bit GPIOA_BC ; \ GPIOA_BC_CR4, Port 4 Clear bit
: GPIOA_BC_CR3 ( -- x addr ) 3 bit GPIOA_BC ; \ GPIOA_BC_CR3, Port 3 Clear bit
: GPIOA_BC_CR2 ( -- x addr ) 2 bit GPIOA_BC ; \ GPIOA_BC_CR2, Port 2 Clear bit
: GPIOA_BC_CR1 ( -- x addr ) 1 bit GPIOA_BC ; \ GPIOA_BC_CR1, Port 1 Clear bit
: GPIOA_BC_CR0 ( -- x addr ) 0 bit GPIOA_BC ; \ GPIOA_BC_CR0, Port 0 Clear bit

\ GPIOA_LOCK (read-write) Reset:0x00000000
: GPIOA_LOCK_LKK ( -- x addr ) 16 bit GPIOA_LOCK ; \ GPIOA_LOCK_LKK, Lock sequence key  
: GPIOA_LOCK_LK15 ( -- x addr ) 15 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK15, Port Lock bit 15
: GPIOA_LOCK_LK14 ( -- x addr ) 14 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK14, Port Lock bit 14
: GPIOA_LOCK_LK13 ( -- x addr ) 13 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK13, Port Lock bit 13
: GPIOA_LOCK_LK12 ( -- x addr ) 12 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK12, Port Lock bit 12
: GPIOA_LOCK_LK11 ( -- x addr ) 11 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK11, Port Lock bit 11
: GPIOA_LOCK_LK10 ( -- x addr ) 10 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK10, Port Lock bit 10
: GPIOA_LOCK_LK9 ( -- x addr ) 9 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK9, Port Lock bit 9
: GPIOA_LOCK_LK8 ( -- x addr ) 8 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK8, Port Lock bit 8
: GPIOA_LOCK_LK7 ( -- x addr ) 7 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK7, Port Lock bit 7
: GPIOA_LOCK_LK6 ( -- x addr ) 6 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK6, Port Lock bit 6
: GPIOA_LOCK_LK5 ( -- x addr ) 5 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK5, Port Lock bit 5
: GPIOA_LOCK_LK4 ( -- x addr ) 4 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK4, Port Lock bit 4
: GPIOA_LOCK_LK3 ( -- x addr ) 3 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK3, Port Lock bit 3
: GPIOA_LOCK_LK2 ( -- x addr ) 2 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK2, Port Lock bit 2
: GPIOA_LOCK_LK1 ( -- x addr ) 1 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK1, Port Lock bit 1
: GPIOA_LOCK_LK0 ( -- x addr ) 0 bit GPIOA_LOCK ; \ GPIOA_LOCK_LK0, Port Lock bit 0

\ GPIOB_CTL0 (read-write) Reset:0x44444444
: GPIOB_CTL0_CTL7 ( %bb -- x addr ) 30 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_CTL7, Port x configuration bits x =  7
: GPIOB_CTL0_MD7 ( %bb -- x addr ) 28 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_MD7, Port x mode bits x =  7
: GPIOB_CTL0_CTL6 ( %bb -- x addr ) 26 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_CTL6, Port x configuration bits x =  6
: GPIOB_CTL0_MD6 ( %bb -- x addr ) 24 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_MD6, Port x mode bits x =  6
: GPIOB_CTL0_CTL5 ( %bb -- x addr ) 22 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_CTL5, Port x configuration bits x =  5
: GPIOB_CTL0_MD5 ( %bb -- x addr ) 20 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_MD5, Port x mode bits x =  5
: GPIOB_CTL0_CTL4 ( %bb -- x addr ) 18 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_CTL4, Port x configuration bits x =  4
: GPIOB_CTL0_MD4 ( %bb -- x addr ) 16 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_MD4, Port x mode bits x =  4
: GPIOB_CTL0_CTL3 ( %bb -- x addr ) 14 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_CTL3, Port x configuration bits x =  3
: GPIOB_CTL0_MD3 ( %bb -- x addr ) 12 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_MD3, Port x mode bits x =  3 
: GPIOB_CTL0_CTL2 ( %bb -- x addr ) 10 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_CTL2, Port x configuration bits x =  2
: GPIOB_CTL0_MD2 ( %bb -- x addr ) 8 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_MD2, Port x mode bits x =  2 
: GPIOB_CTL0_CTL1 ( %bb -- x addr ) 6 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_CTL1, Port x configuration bits x =  1
: GPIOB_CTL0_MD1 ( %bb -- x addr ) 4 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_MD1, Port x mode bits x =  1
: GPIOB_CTL0_CTL0 ( %bb -- x addr ) 2 lshift GPIOB_CTL0 ; \ GPIOB_CTL0_CTL0, Port x configuration bits x =  0
: GPIOB_CTL0_MD0 ( %bb -- x addr ) GPIOB_CTL0 ; \ GPIOB_CTL0_MD0, Port x mode bits x =  0

\ GPIOB_CTL1 (read-write) Reset:0x44444444
: GPIOB_CTL1_CTL15 ( %bb -- x addr ) 30 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_CTL15, Port x configuration bits x =  15
: GPIOB_CTL1_MD15 ( %bb -- x addr ) 28 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_MD15, Port x mode bits x =  15
: GPIOB_CTL1_CTL14 ( %bb -- x addr ) 26 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_CTL14, Port x configuration bits x =  14
: GPIOB_CTL1_MD14 ( %bb -- x addr ) 24 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_MD14, Port x mode bits x =  14
: GPIOB_CTL1_CTL13 ( %bb -- x addr ) 22 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_CTL13, Port x configuration bits x =  13
: GPIOB_CTL1_MD13 ( %bb -- x addr ) 20 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_MD13, Port x mode bits x =  13
: GPIOB_CTL1_CTL12 ( %bb -- x addr ) 18 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_CTL12, Port x configuration bits x =  12
: GPIOB_CTL1_MD12 ( %bb -- x addr ) 16 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_MD12, Port x mode bits x =  12
: GPIOB_CTL1_CTL11 ( %bb -- x addr ) 14 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_CTL11, Port x configuration bits x =  11
: GPIOB_CTL1_MD11 ( %bb -- x addr ) 12 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_MD11, Port x mode bits x =  11 
: GPIOB_CTL1_CTL10 ( %bb -- x addr ) 10 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_CTL10, Port x configuration bits x =  10
: GPIOB_CTL1_MD10 ( %bb -- x addr ) 8 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_MD10, Port x mode bits x =  10 
: GPIOB_CTL1_CTL9 ( %bb -- x addr ) 6 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_CTL9, Port x configuration bits x =  9
: GPIOB_CTL1_MD9 ( %bb -- x addr ) 4 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_MD9, Port x mode bits x =  9
: GPIOB_CTL1_CTL8 ( %bb -- x addr ) 2 lshift GPIOB_CTL1 ; \ GPIOB_CTL1_CTL8, Port x configuration bits x =  8
: GPIOB_CTL1_MD8 ( %bb -- x addr ) GPIOB_CTL1 ; \ GPIOB_CTL1_MD8, Port x mode bits x =  8

\ GPIOB_ISTAT (read-only) Reset:0x00000000
: GPIOB_ISTAT_ISTAT15? ( --  1|0 ) 15 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT15, Port input status
: GPIOB_ISTAT_ISTAT14? ( --  1|0 ) 14 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT14, Port input status
: GPIOB_ISTAT_ISTAT13? ( --  1|0 ) 13 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT13, Port input status
: GPIOB_ISTAT_ISTAT12? ( --  1|0 ) 12 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT12, Port input status
: GPIOB_ISTAT_ISTAT11? ( --  1|0 ) 11 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT11, Port input status
: GPIOB_ISTAT_ISTAT10? ( --  1|0 ) 10 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT10, Port input status
: GPIOB_ISTAT_ISTAT9? ( --  1|0 ) 9 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT9, Port input status
: GPIOB_ISTAT_ISTAT8? ( --  1|0 ) 8 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT8, Port input status
: GPIOB_ISTAT_ISTAT7? ( --  1|0 ) 7 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT7, Port input status
: GPIOB_ISTAT_ISTAT6? ( --  1|0 ) 6 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT6, Port input status
: GPIOB_ISTAT_ISTAT5? ( --  1|0 ) 5 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT5, Port input status
: GPIOB_ISTAT_ISTAT4? ( --  1|0 ) 4 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT4, Port input status
: GPIOB_ISTAT_ISTAT3? ( --  1|0 ) 3 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT3, Port input status
: GPIOB_ISTAT_ISTAT2? ( --  1|0 ) 2 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT2, Port input status
: GPIOB_ISTAT_ISTAT1? ( --  1|0 ) 1 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT1, Port input status
: GPIOB_ISTAT_ISTAT0? ( --  1|0 ) 0 bit GPIOB_ISTAT bit@ ; \ GPIOB_ISTAT_ISTAT0, Port input status

\ GPIOB_OCTL (read-write) Reset:0x00000000
: GPIOB_OCTL_OCTL15 ( -- x addr ) 15 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL15, Port output control
: GPIOB_OCTL_OCTL14 ( -- x addr ) 14 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL14, Port output control
: GPIOB_OCTL_OCTL13 ( -- x addr ) 13 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL13, Port output control
: GPIOB_OCTL_OCTL12 ( -- x addr ) 12 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL12, Port output control
: GPIOB_OCTL_OCTL11 ( -- x addr ) 11 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL11, Port output control
: GPIOB_OCTL_OCTL10 ( -- x addr ) 10 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL10, Port output control
: GPIOB_OCTL_OCTL9 ( -- x addr ) 9 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL9, Port output control
: GPIOB_OCTL_OCTL8 ( -- x addr ) 8 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL8, Port output control
: GPIOB_OCTL_OCTL7 ( -- x addr ) 7 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL7, Port output control
: GPIOB_OCTL_OCTL6 ( -- x addr ) 6 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL6, Port output control
: GPIOB_OCTL_OCTL5 ( -- x addr ) 5 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL5, Port output control
: GPIOB_OCTL_OCTL4 ( -- x addr ) 4 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL4, Port output control
: GPIOB_OCTL_OCTL3 ( -- x addr ) 3 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL3, Port output control
: GPIOB_OCTL_OCTL2 ( -- x addr ) 2 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL2, Port output control
: GPIOB_OCTL_OCTL1 ( -- x addr ) 1 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL1, Port output control
: GPIOB_OCTL_OCTL0 ( -- x addr ) 0 bit GPIOB_OCTL ; \ GPIOB_OCTL_OCTL0, Port output control

\ GPIOB_BOP (write-only) Reset:0x00000000
: GPIOB_BOP_CR15 ( -- x addr ) 31 bit GPIOB_BOP ; \ GPIOB_BOP_CR15, Port 15 Clear bit
: GPIOB_BOP_CR14 ( -- x addr ) 30 bit GPIOB_BOP ; \ GPIOB_BOP_CR14, Port 14 Clear bit
: GPIOB_BOP_CR13 ( -- x addr ) 29 bit GPIOB_BOP ; \ GPIOB_BOP_CR13, Port 13 Clear bit
: GPIOB_BOP_CR12 ( -- x addr ) 28 bit GPIOB_BOP ; \ GPIOB_BOP_CR12, Port 12 Clear bit
: GPIOB_BOP_CR11 ( -- x addr ) 27 bit GPIOB_BOP ; \ GPIOB_BOP_CR11, Port 11 Clear bit
: GPIOB_BOP_CR10 ( -- x addr ) 26 bit GPIOB_BOP ; \ GPIOB_BOP_CR10, Port 10 Clear bit
: GPIOB_BOP_CR9 ( -- x addr ) 25 bit GPIOB_BOP ; \ GPIOB_BOP_CR9, Port 9 Clear bit
: GPIOB_BOP_CR8 ( -- x addr ) 24 bit GPIOB_BOP ; \ GPIOB_BOP_CR8, Port 8 Clear bit
: GPIOB_BOP_CR7 ( -- x addr ) 23 bit GPIOB_BOP ; \ GPIOB_BOP_CR7, Port 7 Clear bit
: GPIOB_BOP_CR6 ( -- x addr ) 22 bit GPIOB_BOP ; \ GPIOB_BOP_CR6, Port 6 Clear bit
: GPIOB_BOP_CR5 ( -- x addr ) 21 bit GPIOB_BOP ; \ GPIOB_BOP_CR5, Port 5 Clear bit
: GPIOB_BOP_CR4 ( -- x addr ) 20 bit GPIOB_BOP ; \ GPIOB_BOP_CR4, Port 4 Clear bit
: GPIOB_BOP_CR3 ( -- x addr ) 19 bit GPIOB_BOP ; \ GPIOB_BOP_CR3, Port 3 Clear bit
: GPIOB_BOP_CR2 ( -- x addr ) 18 bit GPIOB_BOP ; \ GPIOB_BOP_CR2, Port 2 Clear bit
: GPIOB_BOP_CR1 ( -- x addr ) 17 bit GPIOB_BOP ; \ GPIOB_BOP_CR1, Port 1 Clear bit
: GPIOB_BOP_CR0 ( -- x addr ) 16 bit GPIOB_BOP ; \ GPIOB_BOP_CR0, Port 0 Clear bit
: GPIOB_BOP_BOP15 ( -- x addr ) 15 bit GPIOB_BOP ; \ GPIOB_BOP_BOP15, Port 15 Set bit
: GPIOB_BOP_BOP14 ( -- x addr ) 14 bit GPIOB_BOP ; \ GPIOB_BOP_BOP14, Port 14 Set bit
: GPIOB_BOP_BOP13 ( -- x addr ) 13 bit GPIOB_BOP ; \ GPIOB_BOP_BOP13, Port 13 Set bit
: GPIOB_BOP_BOP12 ( -- x addr ) 12 bit GPIOB_BOP ; \ GPIOB_BOP_BOP12, Port 12 Set bit
: GPIOB_BOP_BOP11 ( -- x addr ) 11 bit GPIOB_BOP ; \ GPIOB_BOP_BOP11, Port 11 Set bit
: GPIOB_BOP_BOP10 ( -- x addr ) 10 bit GPIOB_BOP ; \ GPIOB_BOP_BOP10, Port 10 Set bit
: GPIOB_BOP_BOP9 ( -- x addr ) 9 bit GPIOB_BOP ; \ GPIOB_BOP_BOP9, Port 9 Set bit
: GPIOB_BOP_BOP8 ( -- x addr ) 8 bit GPIOB_BOP ; \ GPIOB_BOP_BOP8, Port 8 Set bit
: GPIOB_BOP_BOP7 ( -- x addr ) 7 bit GPIOB_BOP ; \ GPIOB_BOP_BOP7, Port 7 Set bit
: GPIOB_BOP_BOP6 ( -- x addr ) 6 bit GPIOB_BOP ; \ GPIOB_BOP_BOP6, Port 6 Set bit
: GPIOB_BOP_BOP5 ( -- x addr ) 5 bit GPIOB_BOP ; \ GPIOB_BOP_BOP5, Port 5 Set bit
: GPIOB_BOP_BOP4 ( -- x addr ) 4 bit GPIOB_BOP ; \ GPIOB_BOP_BOP4, Port 4 Set bit
: GPIOB_BOP_BOP3 ( -- x addr ) 3 bit GPIOB_BOP ; \ GPIOB_BOP_BOP3, Port 3 Set bit
: GPIOB_BOP_BOP2 ( -- x addr ) 2 bit GPIOB_BOP ; \ GPIOB_BOP_BOP2, Port 2 Set bit
: GPIOB_BOP_BOP1 ( -- x addr ) 1 bit GPIOB_BOP ; \ GPIOB_BOP_BOP1, Port 1 Set bit
: GPIOB_BOP_BOP0 ( -- x addr ) 0 bit GPIOB_BOP ; \ GPIOB_BOP_BOP0, Port 0 Set bit

\ GPIOB_BC (write-only) Reset:0x00000000
: GPIOB_BC_CR15 ( -- x addr ) 15 bit GPIOB_BC ; \ GPIOB_BC_CR15, Port 15 Clear bit
: GPIOB_BC_CR14 ( -- x addr ) 14 bit GPIOB_BC ; \ GPIOB_BC_CR14, Port 14 Clear bit
: GPIOB_BC_CR13 ( -- x addr ) 13 bit GPIOB_BC ; \ GPIOB_BC_CR13, Port 13 Clear bit
: GPIOB_BC_CR12 ( -- x addr ) 12 bit GPIOB_BC ; \ GPIOB_BC_CR12, Port 12 Clear bit
: GPIOB_BC_CR11 ( -- x addr ) 11 bit GPIOB_BC ; \ GPIOB_BC_CR11, Port 11 Clear bit
: GPIOB_BC_CR10 ( -- x addr ) 10 bit GPIOB_BC ; \ GPIOB_BC_CR10, Port 10 Clear bit
: GPIOB_BC_CR9 ( -- x addr ) 9 bit GPIOB_BC ; \ GPIOB_BC_CR9, Port 9 Clear bit
: GPIOB_BC_CR8 ( -- x addr ) 8 bit GPIOB_BC ; \ GPIOB_BC_CR8, Port 8 Clear bit
: GPIOB_BC_CR7 ( -- x addr ) 7 bit GPIOB_BC ; \ GPIOB_BC_CR7, Port 7 Clear bit
: GPIOB_BC_CR6 ( -- x addr ) 6 bit GPIOB_BC ; \ GPIOB_BC_CR6, Port 6 Clear bit
: GPIOB_BC_CR5 ( -- x addr ) 5 bit GPIOB_BC ; \ GPIOB_BC_CR5, Port 5 Clear bit
: GPIOB_BC_CR4 ( -- x addr ) 4 bit GPIOB_BC ; \ GPIOB_BC_CR4, Port 4 Clear bit
: GPIOB_BC_CR3 ( -- x addr ) 3 bit GPIOB_BC ; \ GPIOB_BC_CR3, Port 3 Clear bit
: GPIOB_BC_CR2 ( -- x addr ) 2 bit GPIOB_BC ; \ GPIOB_BC_CR2, Port 2 Clear bit
: GPIOB_BC_CR1 ( -- x addr ) 1 bit GPIOB_BC ; \ GPIOB_BC_CR1, Port 1 Clear bit
: GPIOB_BC_CR0 ( -- x addr ) 0 bit GPIOB_BC ; \ GPIOB_BC_CR0, Port 0 Clear bit

\ GPIOB_LOCK (read-write) Reset:0x00000000
: GPIOB_LOCK_LKK ( -- x addr ) 16 bit GPIOB_LOCK ; \ GPIOB_LOCK_LKK, Lock sequence key  
: GPIOB_LOCK_LK15 ( -- x addr ) 15 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK15, Port Lock bit 15
: GPIOB_LOCK_LK14 ( -- x addr ) 14 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK14, Port Lock bit 14
: GPIOB_LOCK_LK13 ( -- x addr ) 13 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK13, Port Lock bit 13
: GPIOB_LOCK_LK12 ( -- x addr ) 12 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK12, Port Lock bit 12
: GPIOB_LOCK_LK11 ( -- x addr ) 11 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK11, Port Lock bit 11
: GPIOB_LOCK_LK10 ( -- x addr ) 10 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK10, Port Lock bit 10
: GPIOB_LOCK_LK9 ( -- x addr ) 9 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK9, Port Lock bit 9
: GPIOB_LOCK_LK8 ( -- x addr ) 8 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK8, Port Lock bit 8
: GPIOB_LOCK_LK7 ( -- x addr ) 7 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK7, Port Lock bit 7
: GPIOB_LOCK_LK6 ( -- x addr ) 6 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK6, Port Lock bit 6
: GPIOB_LOCK_LK5 ( -- x addr ) 5 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK5, Port Lock bit 5
: GPIOB_LOCK_LK4 ( -- x addr ) 4 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK4, Port Lock bit 4
: GPIOB_LOCK_LK3 ( -- x addr ) 3 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK3, Port Lock bit 3
: GPIOB_LOCK_LK2 ( -- x addr ) 2 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK2, Port Lock bit 2
: GPIOB_LOCK_LK1 ( -- x addr ) 1 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK1, Port Lock bit 1
: GPIOB_LOCK_LK0 ( -- x addr ) 0 bit GPIOB_LOCK ; \ GPIOB_LOCK_LK0, Port Lock bit 0

\ GPIOC_CTL0 (read-write) Reset:0x44444444
: GPIOC_CTL0_CTL7 ( %bb -- x addr ) 30 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_CTL7, Port x configuration bits x =  7
: GPIOC_CTL0_MD7 ( %bb -- x addr ) 28 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_MD7, Port x mode bits x =  7
: GPIOC_CTL0_CTL6 ( %bb -- x addr ) 26 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_CTL6, Port x configuration bits x =  6
: GPIOC_CTL0_MD6 ( %bb -- x addr ) 24 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_MD6, Port x mode bits x =  6
: GPIOC_CTL0_CTL5 ( %bb -- x addr ) 22 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_CTL5, Port x configuration bits x =  5
: GPIOC_CTL0_MD5 ( %bb -- x addr ) 20 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_MD5, Port x mode bits x =  5
: GPIOC_CTL0_CTL4 ( %bb -- x addr ) 18 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_CTL4, Port x configuration bits x =  4
: GPIOC_CTL0_MD4 ( %bb -- x addr ) 16 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_MD4, Port x mode bits x =  4
: GPIOC_CTL0_CTL3 ( %bb -- x addr ) 14 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_CTL3, Port x configuration bits x =  3
: GPIOC_CTL0_MD3 ( %bb -- x addr ) 12 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_MD3, Port x mode bits x =  3 
: GPIOC_CTL0_CTL2 ( %bb -- x addr ) 10 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_CTL2, Port x configuration bits x =  2
: GPIOC_CTL0_MD2 ( %bb -- x addr ) 8 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_MD2, Port x mode bits x =  2 
: GPIOC_CTL0_CTL1 ( %bb -- x addr ) 6 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_CTL1, Port x configuration bits x =  1
: GPIOC_CTL0_MD1 ( %bb -- x addr ) 4 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_MD1, Port x mode bits x =  1
: GPIOC_CTL0_CTL0 ( %bb -- x addr ) 2 lshift GPIOC_CTL0 ; \ GPIOC_CTL0_CTL0, Port x configuration bits x =  0
: GPIOC_CTL0_MD0 ( %bb -- x addr ) GPIOC_CTL0 ; \ GPIOC_CTL0_MD0, Port x mode bits x =  0

\ GPIOC_CTL1 (read-write) Reset:0x44444444
: GPIOC_CTL1_CTL15 ( %bb -- x addr ) 30 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_CTL15, Port x configuration bits x =  15
: GPIOC_CTL1_MD15 ( %bb -- x addr ) 28 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_MD15, Port x mode bits x =  15
: GPIOC_CTL1_CTL14 ( %bb -- x addr ) 26 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_CTL14, Port x configuration bits x =  14
: GPIOC_CTL1_MD14 ( %bb -- x addr ) 24 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_MD14, Port x mode bits x =  14
: GPIOC_CTL1_CTL13 ( %bb -- x addr ) 22 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_CTL13, Port x configuration bits x =  13
: GPIOC_CTL1_MD13 ( %bb -- x addr ) 20 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_MD13, Port x mode bits x =  13
: GPIOC_CTL1_CTL12 ( %bb -- x addr ) 18 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_CTL12, Port x configuration bits x =  12
: GPIOC_CTL1_MD12 ( %bb -- x addr ) 16 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_MD12, Port x mode bits x =  12
: GPIOC_CTL1_CTL11 ( %bb -- x addr ) 14 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_CTL11, Port x configuration bits x =  11
: GPIOC_CTL1_MD11 ( %bb -- x addr ) 12 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_MD11, Port x mode bits x =  11 
: GPIOC_CTL1_CTL10 ( %bb -- x addr ) 10 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_CTL10, Port x configuration bits x =  10
: GPIOC_CTL1_MD10 ( %bb -- x addr ) 8 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_MD10, Port x mode bits x =  10 
: GPIOC_CTL1_CTL9 ( %bb -- x addr ) 6 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_CTL9, Port x configuration bits x =  9
: GPIOC_CTL1_MD9 ( %bb -- x addr ) 4 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_MD9, Port x mode bits x =  9
: GPIOC_CTL1_CTL8 ( %bb -- x addr ) 2 lshift GPIOC_CTL1 ; \ GPIOC_CTL1_CTL8, Port x configuration bits x =  8
: GPIOC_CTL1_MD8 ( %bb -- x addr ) GPIOC_CTL1 ; \ GPIOC_CTL1_MD8, Port x mode bits x =  8

\ GPIOC_ISTAT (read-only) Reset:0x00000000
: GPIOC_ISTAT_ISTAT15? ( --  1|0 ) 15 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT15, Port input status
: GPIOC_ISTAT_ISTAT14? ( --  1|0 ) 14 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT14, Port input status
: GPIOC_ISTAT_ISTAT13? ( --  1|0 ) 13 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT13, Port input status
: GPIOC_ISTAT_ISTAT12? ( --  1|0 ) 12 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT12, Port input status
: GPIOC_ISTAT_ISTAT11? ( --  1|0 ) 11 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT11, Port input status
: GPIOC_ISTAT_ISTAT10? ( --  1|0 ) 10 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT10, Port input status
: GPIOC_ISTAT_ISTAT9? ( --  1|0 ) 9 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT9, Port input status
: GPIOC_ISTAT_ISTAT8? ( --  1|0 ) 8 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT8, Port input status
: GPIOC_ISTAT_ISTAT7? ( --  1|0 ) 7 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT7, Port input status
: GPIOC_ISTAT_ISTAT6? ( --  1|0 ) 6 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT6, Port input status
: GPIOC_ISTAT_ISTAT5? ( --  1|0 ) 5 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT5, Port input status
: GPIOC_ISTAT_ISTAT4? ( --  1|0 ) 4 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT4, Port input status
: GPIOC_ISTAT_ISTAT3? ( --  1|0 ) 3 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT3, Port input status
: GPIOC_ISTAT_ISTAT2? ( --  1|0 ) 2 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT2, Port input status
: GPIOC_ISTAT_ISTAT1? ( --  1|0 ) 1 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT1, Port input status
: GPIOC_ISTAT_ISTAT0? ( --  1|0 ) 0 bit GPIOC_ISTAT bit@ ; \ GPIOC_ISTAT_ISTAT0, Port input status

\ GPIOC_OCTL (read-write) Reset:0x00000000
: GPIOC_OCTL_OCTL15 ( -- x addr ) 15 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL15, Port output control
: GPIOC_OCTL_OCTL14 ( -- x addr ) 14 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL14, Port output control
: GPIOC_OCTL_OCTL13 ( -- x addr ) 13 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL13, Port output control
: GPIOC_OCTL_OCTL12 ( -- x addr ) 12 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL12, Port output control
: GPIOC_OCTL_OCTL11 ( -- x addr ) 11 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL11, Port output control
: GPIOC_OCTL_OCTL10 ( -- x addr ) 10 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL10, Port output control
: GPIOC_OCTL_OCTL9 ( -- x addr ) 9 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL9, Port output control
: GPIOC_OCTL_OCTL8 ( -- x addr ) 8 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL8, Port output control
: GPIOC_OCTL_OCTL7 ( -- x addr ) 7 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL7, Port output control
: GPIOC_OCTL_OCTL6 ( -- x addr ) 6 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL6, Port output control
: GPIOC_OCTL_OCTL5 ( -- x addr ) 5 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL5, Port output control
: GPIOC_OCTL_OCTL4 ( -- x addr ) 4 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL4, Port output control
: GPIOC_OCTL_OCTL3 ( -- x addr ) 3 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL3, Port output control
: GPIOC_OCTL_OCTL2 ( -- x addr ) 2 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL2, Port output control
: GPIOC_OCTL_OCTL1 ( -- x addr ) 1 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL1, Port output control
: GPIOC_OCTL_OCTL0 ( -- x addr ) 0 bit GPIOC_OCTL ; \ GPIOC_OCTL_OCTL0, Port output control

\ GPIOC_BOP (write-only) Reset:0x00000000
: GPIOC_BOP_CR15 ( -- x addr ) 31 bit GPIOC_BOP ; \ GPIOC_BOP_CR15, Port 15 Clear bit
: GPIOC_BOP_CR14 ( -- x addr ) 30 bit GPIOC_BOP ; \ GPIOC_BOP_CR14, Port 14 Clear bit
: GPIOC_BOP_CR13 ( -- x addr ) 29 bit GPIOC_BOP ; \ GPIOC_BOP_CR13, Port 13 Clear bit
: GPIOC_BOP_CR12 ( -- x addr ) 28 bit GPIOC_BOP ; \ GPIOC_BOP_CR12, Port 12 Clear bit
: GPIOC_BOP_CR11 ( -- x addr ) 27 bit GPIOC_BOP ; \ GPIOC_BOP_CR11, Port 11 Clear bit
: GPIOC_BOP_CR10 ( -- x addr ) 26 bit GPIOC_BOP ; \ GPIOC_BOP_CR10, Port 10 Clear bit
: GPIOC_BOP_CR9 ( -- x addr ) 25 bit GPIOC_BOP ; \ GPIOC_BOP_CR9, Port 9 Clear bit
: GPIOC_BOP_CR8 ( -- x addr ) 24 bit GPIOC_BOP ; \ GPIOC_BOP_CR8, Port 8 Clear bit
: GPIOC_BOP_CR7 ( -- x addr ) 23 bit GPIOC_BOP ; \ GPIOC_BOP_CR7, Port 7 Clear bit
: GPIOC_BOP_CR6 ( -- x addr ) 22 bit GPIOC_BOP ; \ GPIOC_BOP_CR6, Port 6 Clear bit
: GPIOC_BOP_CR5 ( -- x addr ) 21 bit GPIOC_BOP ; \ GPIOC_BOP_CR5, Port 5 Clear bit
: GPIOC_BOP_CR4 ( -- x addr ) 20 bit GPIOC_BOP ; \ GPIOC_BOP_CR4, Port 4 Clear bit
: GPIOC_BOP_CR3 ( -- x addr ) 19 bit GPIOC_BOP ; \ GPIOC_BOP_CR3, Port 3 Clear bit
: GPIOC_BOP_CR2 ( -- x addr ) 18 bit GPIOC_BOP ; \ GPIOC_BOP_CR2, Port 2 Clear bit
: GPIOC_BOP_CR1 ( -- x addr ) 17 bit GPIOC_BOP ; \ GPIOC_BOP_CR1, Port 1 Clear bit
: GPIOC_BOP_CR0 ( -- x addr ) 16 bit GPIOC_BOP ; \ GPIOC_BOP_CR0, Port 0 Clear bit
: GPIOC_BOP_BOP15 ( -- x addr ) 15 bit GPIOC_BOP ; \ GPIOC_BOP_BOP15, Port 15 Set bit
: GPIOC_BOP_BOP14 ( -- x addr ) 14 bit GPIOC_BOP ; \ GPIOC_BOP_BOP14, Port 14 Set bit
: GPIOC_BOP_BOP13 ( -- x addr ) 13 bit GPIOC_BOP ; \ GPIOC_BOP_BOP13, Port 13 Set bit
: GPIOC_BOP_BOP12 ( -- x addr ) 12 bit GPIOC_BOP ; \ GPIOC_BOP_BOP12, Port 12 Set bit
: GPIOC_BOP_BOP11 ( -- x addr ) 11 bit GPIOC_BOP ; \ GPIOC_BOP_BOP11, Port 11 Set bit
: GPIOC_BOP_BOP10 ( -- x addr ) 10 bit GPIOC_BOP ; \ GPIOC_BOP_BOP10, Port 10 Set bit
: GPIOC_BOP_BOP9 ( -- x addr ) 9 bit GPIOC_BOP ; \ GPIOC_BOP_BOP9, Port 9 Set bit
: GPIOC_BOP_BOP8 ( -- x addr ) 8 bit GPIOC_BOP ; \ GPIOC_BOP_BOP8, Port 8 Set bit
: GPIOC_BOP_BOP7 ( -- x addr ) 7 bit GPIOC_BOP ; \ GPIOC_BOP_BOP7, Port 7 Set bit
: GPIOC_BOP_BOP6 ( -- x addr ) 6 bit GPIOC_BOP ; \ GPIOC_BOP_BOP6, Port 6 Set bit
: GPIOC_BOP_BOP5 ( -- x addr ) 5 bit GPIOC_BOP ; \ GPIOC_BOP_BOP5, Port 5 Set bit
: GPIOC_BOP_BOP4 ( -- x addr ) 4 bit GPIOC_BOP ; \ GPIOC_BOP_BOP4, Port 4 Set bit
: GPIOC_BOP_BOP3 ( -- x addr ) 3 bit GPIOC_BOP ; \ GPIOC_BOP_BOP3, Port 3 Set bit
: GPIOC_BOP_BOP2 ( -- x addr ) 2 bit GPIOC_BOP ; \ GPIOC_BOP_BOP2, Port 2 Set bit
: GPIOC_BOP_BOP1 ( -- x addr ) 1 bit GPIOC_BOP ; \ GPIOC_BOP_BOP1, Port 1 Set bit
: GPIOC_BOP_BOP0 ( -- x addr ) 0 bit GPIOC_BOP ; \ GPIOC_BOP_BOP0, Port 0 Set bit

\ GPIOC_BC (write-only) Reset:0x00000000
: GPIOC_BC_CR15 ( -- x addr ) 15 bit GPIOC_BC ; \ GPIOC_BC_CR15, Port 15 Clear bit
: GPIOC_BC_CR14 ( -- x addr ) 14 bit GPIOC_BC ; \ GPIOC_BC_CR14, Port 14 Clear bit
: GPIOC_BC_CR13 ( -- x addr ) 13 bit GPIOC_BC ; \ GPIOC_BC_CR13, Port 13 Clear bit
: GPIOC_BC_CR12 ( -- x addr ) 12 bit GPIOC_BC ; \ GPIOC_BC_CR12, Port 12 Clear bit
: GPIOC_BC_CR11 ( -- x addr ) 11 bit GPIOC_BC ; \ GPIOC_BC_CR11, Port 11 Clear bit
: GPIOC_BC_CR10 ( -- x addr ) 10 bit GPIOC_BC ; \ GPIOC_BC_CR10, Port 10 Clear bit
: GPIOC_BC_CR9 ( -- x addr ) 9 bit GPIOC_BC ; \ GPIOC_BC_CR9, Port 9 Clear bit
: GPIOC_BC_CR8 ( -- x addr ) 8 bit GPIOC_BC ; \ GPIOC_BC_CR8, Port 8 Clear bit
: GPIOC_BC_CR7 ( -- x addr ) 7 bit GPIOC_BC ; \ GPIOC_BC_CR7, Port 7 Clear bit
: GPIOC_BC_CR6 ( -- x addr ) 6 bit GPIOC_BC ; \ GPIOC_BC_CR6, Port 6 Clear bit
: GPIOC_BC_CR5 ( -- x addr ) 5 bit GPIOC_BC ; \ GPIOC_BC_CR5, Port 5 Clear bit
: GPIOC_BC_CR4 ( -- x addr ) 4 bit GPIOC_BC ; \ GPIOC_BC_CR4, Port 4 Clear bit
: GPIOC_BC_CR3 ( -- x addr ) 3 bit GPIOC_BC ; \ GPIOC_BC_CR3, Port 3 Clear bit
: GPIOC_BC_CR2 ( -- x addr ) 2 bit GPIOC_BC ; \ GPIOC_BC_CR2, Port 2 Clear bit
: GPIOC_BC_CR1 ( -- x addr ) 1 bit GPIOC_BC ; \ GPIOC_BC_CR1, Port 1 Clear bit
: GPIOC_BC_CR0 ( -- x addr ) 0 bit GPIOC_BC ; \ GPIOC_BC_CR0, Port 0 Clear bit

\ GPIOC_LOCK (read-write) Reset:0x00000000
: GPIOC_LOCK_LKK ( -- x addr ) 16 bit GPIOC_LOCK ; \ GPIOC_LOCK_LKK, Lock sequence key  
: GPIOC_LOCK_LK15 ( -- x addr ) 15 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK15, Port Lock bit 15
: GPIOC_LOCK_LK14 ( -- x addr ) 14 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK14, Port Lock bit 14
: GPIOC_LOCK_LK13 ( -- x addr ) 13 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK13, Port Lock bit 13
: GPIOC_LOCK_LK12 ( -- x addr ) 12 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK12, Port Lock bit 12
: GPIOC_LOCK_LK11 ( -- x addr ) 11 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK11, Port Lock bit 11
: GPIOC_LOCK_LK10 ( -- x addr ) 10 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK10, Port Lock bit 10
: GPIOC_LOCK_LK9 ( -- x addr ) 9 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK9, Port Lock bit 9
: GPIOC_LOCK_LK8 ( -- x addr ) 8 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK8, Port Lock bit 8
: GPIOC_LOCK_LK7 ( -- x addr ) 7 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK7, Port Lock bit 7
: GPIOC_LOCK_LK6 ( -- x addr ) 6 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK6, Port Lock bit 6
: GPIOC_LOCK_LK5 ( -- x addr ) 5 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK5, Port Lock bit 5
: GPIOC_LOCK_LK4 ( -- x addr ) 4 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK4, Port Lock bit 4
: GPIOC_LOCK_LK3 ( -- x addr ) 3 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK3, Port Lock bit 3
: GPIOC_LOCK_LK2 ( -- x addr ) 2 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK2, Port Lock bit 2
: GPIOC_LOCK_LK1 ( -- x addr ) 1 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK1, Port Lock bit 1
: GPIOC_LOCK_LK0 ( -- x addr ) 0 bit GPIOC_LOCK ; \ GPIOC_LOCK_LK0, Port Lock bit 0

\ GPIOD_CTL0 (read-write) Reset:0x44444444
: GPIOD_CTL0_CTL7 ( %bb -- x addr ) 30 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_CTL7, Port x configuration bits x =  7
: GPIOD_CTL0_MD7 ( %bb -- x addr ) 28 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_MD7, Port x mode bits x =  7
: GPIOD_CTL0_CTL6 ( %bb -- x addr ) 26 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_CTL6, Port x configuration bits x =  6
: GPIOD_CTL0_MD6 ( %bb -- x addr ) 24 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_MD6, Port x mode bits x =  6
: GPIOD_CTL0_CTL5 ( %bb -- x addr ) 22 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_CTL5, Port x configuration bits x =  5
: GPIOD_CTL0_MD5 ( %bb -- x addr ) 20 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_MD5, Port x mode bits x =  5
: GPIOD_CTL0_CTL4 ( %bb -- x addr ) 18 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_CTL4, Port x configuration bits x =  4
: GPIOD_CTL0_MD4 ( %bb -- x addr ) 16 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_MD4, Port x mode bits x =  4
: GPIOD_CTL0_CTL3 ( %bb -- x addr ) 14 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_CTL3, Port x configuration bits x =  3
: GPIOD_CTL0_MD3 ( %bb -- x addr ) 12 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_MD3, Port x mode bits x =  3 
: GPIOD_CTL0_CTL2 ( %bb -- x addr ) 10 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_CTL2, Port x configuration bits x =  2
: GPIOD_CTL0_MD2 ( %bb -- x addr ) 8 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_MD2, Port x mode bits x =  2 
: GPIOD_CTL0_CTL1 ( %bb -- x addr ) 6 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_CTL1, Port x configuration bits x =  1
: GPIOD_CTL0_MD1 ( %bb -- x addr ) 4 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_MD1, Port x mode bits x =  1
: GPIOD_CTL0_CTL0 ( %bb -- x addr ) 2 lshift GPIOD_CTL0 ; \ GPIOD_CTL0_CTL0, Port x configuration bits x =  0
: GPIOD_CTL0_MD0 ( %bb -- x addr ) GPIOD_CTL0 ; \ GPIOD_CTL0_MD0, Port x mode bits x =  0

\ GPIOD_CTL1 (read-write) Reset:0x44444444
: GPIOD_CTL1_CTL15 ( %bb -- x addr ) 30 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_CTL15, Port x configuration bits x =  15
: GPIOD_CTL1_MD15 ( %bb -- x addr ) 28 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_MD15, Port x mode bits x =  15
: GPIOD_CTL1_CTL14 ( %bb -- x addr ) 26 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_CTL14, Port x configuration bits x =  14
: GPIOD_CTL1_MD14 ( %bb -- x addr ) 24 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_MD14, Port x mode bits x =  14
: GPIOD_CTL1_CTL13 ( %bb -- x addr ) 22 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_CTL13, Port x configuration bits x =  13
: GPIOD_CTL1_MD13 ( %bb -- x addr ) 20 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_MD13, Port x mode bits x =  13
: GPIOD_CTL1_CTL12 ( %bb -- x addr ) 18 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_CTL12, Port x configuration bits x =  12
: GPIOD_CTL1_MD12 ( %bb -- x addr ) 16 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_MD12, Port x mode bits x =  12
: GPIOD_CTL1_CTL11 ( %bb -- x addr ) 14 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_CTL11, Port x configuration bits x =  11
: GPIOD_CTL1_MD11 ( %bb -- x addr ) 12 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_MD11, Port x mode bits x =  11 
: GPIOD_CTL1_CTL10 ( %bb -- x addr ) 10 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_CTL10, Port x configuration bits x =  10
: GPIOD_CTL1_MD10 ( %bb -- x addr ) 8 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_MD10, Port x mode bits x =  10 
: GPIOD_CTL1_CTL9 ( %bb -- x addr ) 6 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_CTL9, Port x configuration bits x =  9
: GPIOD_CTL1_MD9 ( %bb -- x addr ) 4 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_MD9, Port x mode bits x =  9
: GPIOD_CTL1_CTL8 ( %bb -- x addr ) 2 lshift GPIOD_CTL1 ; \ GPIOD_CTL1_CTL8, Port x configuration bits x =  8
: GPIOD_CTL1_MD8 ( %bb -- x addr ) GPIOD_CTL1 ; \ GPIOD_CTL1_MD8, Port x mode bits x =  8

\ GPIOD_ISTAT (read-only) Reset:0x00000000
: GPIOD_ISTAT_ISTAT15? ( --  1|0 ) 15 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT15, Port input status
: GPIOD_ISTAT_ISTAT14? ( --  1|0 ) 14 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT14, Port input status
: GPIOD_ISTAT_ISTAT13? ( --  1|0 ) 13 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT13, Port input status
: GPIOD_ISTAT_ISTAT12? ( --  1|0 ) 12 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT12, Port input status
: GPIOD_ISTAT_ISTAT11? ( --  1|0 ) 11 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT11, Port input status
: GPIOD_ISTAT_ISTAT10? ( --  1|0 ) 10 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT10, Port input status
: GPIOD_ISTAT_ISTAT9? ( --  1|0 ) 9 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT9, Port input status
: GPIOD_ISTAT_ISTAT8? ( --  1|0 ) 8 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT8, Port input status
: GPIOD_ISTAT_ISTAT7? ( --  1|0 ) 7 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT7, Port input status
: GPIOD_ISTAT_ISTAT6? ( --  1|0 ) 6 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT6, Port input status
: GPIOD_ISTAT_ISTAT5? ( --  1|0 ) 5 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT5, Port input status
: GPIOD_ISTAT_ISTAT4? ( --  1|0 ) 4 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT4, Port input status
: GPIOD_ISTAT_ISTAT3? ( --  1|0 ) 3 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT3, Port input status
: GPIOD_ISTAT_ISTAT2? ( --  1|0 ) 2 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT2, Port input status
: GPIOD_ISTAT_ISTAT1? ( --  1|0 ) 1 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT1, Port input status
: GPIOD_ISTAT_ISTAT0? ( --  1|0 ) 0 bit GPIOD_ISTAT bit@ ; \ GPIOD_ISTAT_ISTAT0, Port input status

\ GPIOD_OCTL (read-write) Reset:0x00000000
: GPIOD_OCTL_OCTL15 ( -- x addr ) 15 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL15, Port output control
: GPIOD_OCTL_OCTL14 ( -- x addr ) 14 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL14, Port output control
: GPIOD_OCTL_OCTL13 ( -- x addr ) 13 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL13, Port output control
: GPIOD_OCTL_OCTL12 ( -- x addr ) 12 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL12, Port output control
: GPIOD_OCTL_OCTL11 ( -- x addr ) 11 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL11, Port output control
: GPIOD_OCTL_OCTL10 ( -- x addr ) 10 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL10, Port output control
: GPIOD_OCTL_OCTL9 ( -- x addr ) 9 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL9, Port output control
: GPIOD_OCTL_OCTL8 ( -- x addr ) 8 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL8, Port output control
: GPIOD_OCTL_OCTL7 ( -- x addr ) 7 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL7, Port output control
: GPIOD_OCTL_OCTL6 ( -- x addr ) 6 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL6, Port output control
: GPIOD_OCTL_OCTL5 ( -- x addr ) 5 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL5, Port output control
: GPIOD_OCTL_OCTL4 ( -- x addr ) 4 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL4, Port output control
: GPIOD_OCTL_OCTL3 ( -- x addr ) 3 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL3, Port output control
: GPIOD_OCTL_OCTL2 ( -- x addr ) 2 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL2, Port output control
: GPIOD_OCTL_OCTL1 ( -- x addr ) 1 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL1, Port output control
: GPIOD_OCTL_OCTL0 ( -- x addr ) 0 bit GPIOD_OCTL ; \ GPIOD_OCTL_OCTL0, Port output control

\ GPIOD_BOP (write-only) Reset:0x00000000
: GPIOD_BOP_CR15 ( -- x addr ) 31 bit GPIOD_BOP ; \ GPIOD_BOP_CR15, Port 15 Clear bit
: GPIOD_BOP_CR14 ( -- x addr ) 30 bit GPIOD_BOP ; \ GPIOD_BOP_CR14, Port 14 Clear bit
: GPIOD_BOP_CR13 ( -- x addr ) 29 bit GPIOD_BOP ; \ GPIOD_BOP_CR13, Port 13 Clear bit
: GPIOD_BOP_CR12 ( -- x addr ) 28 bit GPIOD_BOP ; \ GPIOD_BOP_CR12, Port 12 Clear bit
: GPIOD_BOP_CR11 ( -- x addr ) 27 bit GPIOD_BOP ; \ GPIOD_BOP_CR11, Port 11 Clear bit
: GPIOD_BOP_CR10 ( -- x addr ) 26 bit GPIOD_BOP ; \ GPIOD_BOP_CR10, Port 10 Clear bit
: GPIOD_BOP_CR9 ( -- x addr ) 25 bit GPIOD_BOP ; \ GPIOD_BOP_CR9, Port 9 Clear bit
: GPIOD_BOP_CR8 ( -- x addr ) 24 bit GPIOD_BOP ; \ GPIOD_BOP_CR8, Port 8 Clear bit
: GPIOD_BOP_CR7 ( -- x addr ) 23 bit GPIOD_BOP ; \ GPIOD_BOP_CR7, Port 7 Clear bit
: GPIOD_BOP_CR6 ( -- x addr ) 22 bit GPIOD_BOP ; \ GPIOD_BOP_CR6, Port 6 Clear bit
: GPIOD_BOP_CR5 ( -- x addr ) 21 bit GPIOD_BOP ; \ GPIOD_BOP_CR5, Port 5 Clear bit
: GPIOD_BOP_CR4 ( -- x addr ) 20 bit GPIOD_BOP ; \ GPIOD_BOP_CR4, Port 4 Clear bit
: GPIOD_BOP_CR3 ( -- x addr ) 19 bit GPIOD_BOP ; \ GPIOD_BOP_CR3, Port 3 Clear bit
: GPIOD_BOP_CR2 ( -- x addr ) 18 bit GPIOD_BOP ; \ GPIOD_BOP_CR2, Port 2 Clear bit
: GPIOD_BOP_CR1 ( -- x addr ) 17 bit GPIOD_BOP ; \ GPIOD_BOP_CR1, Port 1 Clear bit
: GPIOD_BOP_CR0 ( -- x addr ) 16 bit GPIOD_BOP ; \ GPIOD_BOP_CR0, Port 0 Clear bit
: GPIOD_BOP_BOP15 ( -- x addr ) 15 bit GPIOD_BOP ; \ GPIOD_BOP_BOP15, Port 15 Set bit
: GPIOD_BOP_BOP14 ( -- x addr ) 14 bit GPIOD_BOP ; \ GPIOD_BOP_BOP14, Port 14 Set bit
: GPIOD_BOP_BOP13 ( -- x addr ) 13 bit GPIOD_BOP ; \ GPIOD_BOP_BOP13, Port 13 Set bit
: GPIOD_BOP_BOP12 ( -- x addr ) 12 bit GPIOD_BOP ; \ GPIOD_BOP_BOP12, Port 12 Set bit
: GPIOD_BOP_BOP11 ( -- x addr ) 11 bit GPIOD_BOP ; \ GPIOD_BOP_BOP11, Port 11 Set bit
: GPIOD_BOP_BOP10 ( -- x addr ) 10 bit GPIOD_BOP ; \ GPIOD_BOP_BOP10, Port 10 Set bit
: GPIOD_BOP_BOP9 ( -- x addr ) 9 bit GPIOD_BOP ; \ GPIOD_BOP_BOP9, Port 9 Set bit
: GPIOD_BOP_BOP8 ( -- x addr ) 8 bit GPIOD_BOP ; \ GPIOD_BOP_BOP8, Port 8 Set bit
: GPIOD_BOP_BOP7 ( -- x addr ) 7 bit GPIOD_BOP ; \ GPIOD_BOP_BOP7, Port 7 Set bit
: GPIOD_BOP_BOP6 ( -- x addr ) 6 bit GPIOD_BOP ; \ GPIOD_BOP_BOP6, Port 6 Set bit
: GPIOD_BOP_BOP5 ( -- x addr ) 5 bit GPIOD_BOP ; \ GPIOD_BOP_BOP5, Port 5 Set bit
: GPIOD_BOP_BOP4 ( -- x addr ) 4 bit GPIOD_BOP ; \ GPIOD_BOP_BOP4, Port 4 Set bit
: GPIOD_BOP_BOP3 ( -- x addr ) 3 bit GPIOD_BOP ; \ GPIOD_BOP_BOP3, Port 3 Set bit
: GPIOD_BOP_BOP2 ( -- x addr ) 2 bit GPIOD_BOP ; \ GPIOD_BOP_BOP2, Port 2 Set bit
: GPIOD_BOP_BOP1 ( -- x addr ) 1 bit GPIOD_BOP ; \ GPIOD_BOP_BOP1, Port 1 Set bit
: GPIOD_BOP_BOP0 ( -- x addr ) 0 bit GPIOD_BOP ; \ GPIOD_BOP_BOP0, Port 0 Set bit

\ GPIOD_BC (write-only) Reset:0x00000000
: GPIOD_BC_CR15 ( -- x addr ) 15 bit GPIOD_BC ; \ GPIOD_BC_CR15, Port 15 Clear bit
: GPIOD_BC_CR14 ( -- x addr ) 14 bit GPIOD_BC ; \ GPIOD_BC_CR14, Port 14 Clear bit
: GPIOD_BC_CR13 ( -- x addr ) 13 bit GPIOD_BC ; \ GPIOD_BC_CR13, Port 13 Clear bit
: GPIOD_BC_CR12 ( -- x addr ) 12 bit GPIOD_BC ; \ GPIOD_BC_CR12, Port 12 Clear bit
: GPIOD_BC_CR11 ( -- x addr ) 11 bit GPIOD_BC ; \ GPIOD_BC_CR11, Port 11 Clear bit
: GPIOD_BC_CR10 ( -- x addr ) 10 bit GPIOD_BC ; \ GPIOD_BC_CR10, Port 10 Clear bit
: GPIOD_BC_CR9 ( -- x addr ) 9 bit GPIOD_BC ; \ GPIOD_BC_CR9, Port 9 Clear bit
: GPIOD_BC_CR8 ( -- x addr ) 8 bit GPIOD_BC ; \ GPIOD_BC_CR8, Port 8 Clear bit
: GPIOD_BC_CR7 ( -- x addr ) 7 bit GPIOD_BC ; \ GPIOD_BC_CR7, Port 7 Clear bit
: GPIOD_BC_CR6 ( -- x addr ) 6 bit GPIOD_BC ; \ GPIOD_BC_CR6, Port 6 Clear bit
: GPIOD_BC_CR5 ( -- x addr ) 5 bit GPIOD_BC ; \ GPIOD_BC_CR5, Port 5 Clear bit
: GPIOD_BC_CR4 ( -- x addr ) 4 bit GPIOD_BC ; \ GPIOD_BC_CR4, Port 4 Clear bit
: GPIOD_BC_CR3 ( -- x addr ) 3 bit GPIOD_BC ; \ GPIOD_BC_CR3, Port 3 Clear bit
: GPIOD_BC_CR2 ( -- x addr ) 2 bit GPIOD_BC ; \ GPIOD_BC_CR2, Port 2 Clear bit
: GPIOD_BC_CR1 ( -- x addr ) 1 bit GPIOD_BC ; \ GPIOD_BC_CR1, Port 1 Clear bit
: GPIOD_BC_CR0 ( -- x addr ) 0 bit GPIOD_BC ; \ GPIOD_BC_CR0, Port 0 Clear bit

\ GPIOD_LOCK (read-write) Reset:0x00000000
: GPIOD_LOCK_LKK ( -- x addr ) 16 bit GPIOD_LOCK ; \ GPIOD_LOCK_LKK, Lock sequence key  
: GPIOD_LOCK_LK15 ( -- x addr ) 15 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK15, Port Lock bit 15
: GPIOD_LOCK_LK14 ( -- x addr ) 14 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK14, Port Lock bit 14
: GPIOD_LOCK_LK13 ( -- x addr ) 13 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK13, Port Lock bit 13
: GPIOD_LOCK_LK12 ( -- x addr ) 12 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK12, Port Lock bit 12
: GPIOD_LOCK_LK11 ( -- x addr ) 11 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK11, Port Lock bit 11
: GPIOD_LOCK_LK10 ( -- x addr ) 10 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK10, Port Lock bit 10
: GPIOD_LOCK_LK9 ( -- x addr ) 9 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK9, Port Lock bit 9
: GPIOD_LOCK_LK8 ( -- x addr ) 8 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK8, Port Lock bit 8
: GPIOD_LOCK_LK7 ( -- x addr ) 7 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK7, Port Lock bit 7
: GPIOD_LOCK_LK6 ( -- x addr ) 6 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK6, Port Lock bit 6
: GPIOD_LOCK_LK5 ( -- x addr ) 5 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK5, Port Lock bit 5
: GPIOD_LOCK_LK4 ( -- x addr ) 4 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK4, Port Lock bit 4
: GPIOD_LOCK_LK3 ( -- x addr ) 3 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK3, Port Lock bit 3
: GPIOD_LOCK_LK2 ( -- x addr ) 2 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK2, Port Lock bit 2
: GPIOD_LOCK_LK1 ( -- x addr ) 1 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK1, Port Lock bit 1
: GPIOD_LOCK_LK0 ( -- x addr ) 0 bit GPIOD_LOCK ; \ GPIOD_LOCK_LK0, Port Lock bit 0

\ GPIOE_CTL0 (read-write) Reset:0x44444444
: GPIOE_CTL0_CTL7 ( %bb -- x addr ) 30 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_CTL7, Port x configuration bits x =  7
: GPIOE_CTL0_MD7 ( %bb -- x addr ) 28 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_MD7, Port x mode bits x =  7
: GPIOE_CTL0_CTL6 ( %bb -- x addr ) 26 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_CTL6, Port x configuration bits x =  6
: GPIOE_CTL0_MD6 ( %bb -- x addr ) 24 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_MD6, Port x mode bits x =  6
: GPIOE_CTL0_CTL5 ( %bb -- x addr ) 22 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_CTL5, Port x configuration bits x =  5
: GPIOE_CTL0_MD5 ( %bb -- x addr ) 20 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_MD5, Port x mode bits x =  5
: GPIOE_CTL0_CTL4 ( %bb -- x addr ) 18 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_CTL4, Port x configuration bits x =  4
: GPIOE_CTL0_MD4 ( %bb -- x addr ) 16 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_MD4, Port x mode bits x =  4
: GPIOE_CTL0_CTL3 ( %bb -- x addr ) 14 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_CTL3, Port x configuration bits x =  3
: GPIOE_CTL0_MD3 ( %bb -- x addr ) 12 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_MD3, Port x mode bits x =  3 
: GPIOE_CTL0_CTL2 ( %bb -- x addr ) 10 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_CTL2, Port x configuration bits x =  2
: GPIOE_CTL0_MD2 ( %bb -- x addr ) 8 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_MD2, Port x mode bits x =  2 
: GPIOE_CTL0_CTL1 ( %bb -- x addr ) 6 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_CTL1, Port x configuration bits x =  1
: GPIOE_CTL0_MD1 ( %bb -- x addr ) 4 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_MD1, Port x mode bits x =  1
: GPIOE_CTL0_CTL0 ( %bb -- x addr ) 2 lshift GPIOE_CTL0 ; \ GPIOE_CTL0_CTL0, Port x configuration bits x =  0
: GPIOE_CTL0_MD0 ( %bb -- x addr ) GPIOE_CTL0 ; \ GPIOE_CTL0_MD0, Port x mode bits x =  0

\ GPIOE_CTL1 (read-write) Reset:0x44444444
: GPIOE_CTL1_CTL15 ( %bb -- x addr ) 30 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_CTL15, Port x configuration bits x =  15
: GPIOE_CTL1_MD15 ( %bb -- x addr ) 28 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_MD15, Port x mode bits x =  15
: GPIOE_CTL1_CTL14 ( %bb -- x addr ) 26 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_CTL14, Port x configuration bits x =  14
: GPIOE_CTL1_MD14 ( %bb -- x addr ) 24 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_MD14, Port x mode bits x =  14
: GPIOE_CTL1_CTL13 ( %bb -- x addr ) 22 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_CTL13, Port x configuration bits x =  13
: GPIOE_CTL1_MD13 ( %bb -- x addr ) 20 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_MD13, Port x mode bits x =  13
: GPIOE_CTL1_CTL12 ( %bb -- x addr ) 18 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_CTL12, Port x configuration bits x =  12
: GPIOE_CTL1_MD12 ( %bb -- x addr ) 16 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_MD12, Port x mode bits x =  12
: GPIOE_CTL1_CTL11 ( %bb -- x addr ) 14 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_CTL11, Port x configuration bits x =  11
: GPIOE_CTL1_MD11 ( %bb -- x addr ) 12 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_MD11, Port x mode bits x =  11 
: GPIOE_CTL1_CTL10 ( %bb -- x addr ) 10 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_CTL10, Port x configuration bits x =  10
: GPIOE_CTL1_MD10 ( %bb -- x addr ) 8 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_MD10, Port x mode bits x =  10 
: GPIOE_CTL1_CTL9 ( %bb -- x addr ) 6 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_CTL9, Port x configuration bits x =  9
: GPIOE_CTL1_MD9 ( %bb -- x addr ) 4 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_MD9, Port x mode bits x =  9
: GPIOE_CTL1_CTL8 ( %bb -- x addr ) 2 lshift GPIOE_CTL1 ; \ GPIOE_CTL1_CTL8, Port x configuration bits x =  8
: GPIOE_CTL1_MD8 ( %bb -- x addr ) GPIOE_CTL1 ; \ GPIOE_CTL1_MD8, Port x mode bits x =  8

\ GPIOE_ISTAT (read-only) Reset:0x00000000
: GPIOE_ISTAT_ISTAT15? ( --  1|0 ) 15 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT15, Port input status
: GPIOE_ISTAT_ISTAT14? ( --  1|0 ) 14 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT14, Port input status
: GPIOE_ISTAT_ISTAT13? ( --  1|0 ) 13 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT13, Port input status
: GPIOE_ISTAT_ISTAT12? ( --  1|0 ) 12 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT12, Port input status
: GPIOE_ISTAT_ISTAT11? ( --  1|0 ) 11 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT11, Port input status
: GPIOE_ISTAT_ISTAT10? ( --  1|0 ) 10 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT10, Port input status
: GPIOE_ISTAT_ISTAT9? ( --  1|0 ) 9 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT9, Port input status
: GPIOE_ISTAT_ISTAT8? ( --  1|0 ) 8 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT8, Port input status
: GPIOE_ISTAT_ISTAT7? ( --  1|0 ) 7 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT7, Port input status
: GPIOE_ISTAT_ISTAT6? ( --  1|0 ) 6 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT6, Port input status
: GPIOE_ISTAT_ISTAT5? ( --  1|0 ) 5 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT5, Port input status
: GPIOE_ISTAT_ISTAT4? ( --  1|0 ) 4 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT4, Port input status
: GPIOE_ISTAT_ISTAT3? ( --  1|0 ) 3 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT3, Port input status
: GPIOE_ISTAT_ISTAT2? ( --  1|0 ) 2 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT2, Port input status
: GPIOE_ISTAT_ISTAT1? ( --  1|0 ) 1 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT1, Port input status
: GPIOE_ISTAT_ISTAT0? ( --  1|0 ) 0 bit GPIOE_ISTAT bit@ ; \ GPIOE_ISTAT_ISTAT0, Port input status

\ GPIOE_OCTL (read-write) Reset:0x00000000
: GPIOE_OCTL_OCTL15 ( -- x addr ) 15 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL15, Port output control
: GPIOE_OCTL_OCTL14 ( -- x addr ) 14 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL14, Port output control
: GPIOE_OCTL_OCTL13 ( -- x addr ) 13 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL13, Port output control
: GPIOE_OCTL_OCTL12 ( -- x addr ) 12 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL12, Port output control
: GPIOE_OCTL_OCTL11 ( -- x addr ) 11 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL11, Port output control
: GPIOE_OCTL_OCTL10 ( -- x addr ) 10 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL10, Port output control
: GPIOE_OCTL_OCTL9 ( -- x addr ) 9 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL9, Port output control
: GPIOE_OCTL_OCTL8 ( -- x addr ) 8 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL8, Port output control
: GPIOE_OCTL_OCTL7 ( -- x addr ) 7 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL7, Port output control
: GPIOE_OCTL_OCTL6 ( -- x addr ) 6 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL6, Port output control
: GPIOE_OCTL_OCTL5 ( -- x addr ) 5 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL5, Port output control
: GPIOE_OCTL_OCTL4 ( -- x addr ) 4 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL4, Port output control
: GPIOE_OCTL_OCTL3 ( -- x addr ) 3 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL3, Port output control
: GPIOE_OCTL_OCTL2 ( -- x addr ) 2 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL2, Port output control
: GPIOE_OCTL_OCTL1 ( -- x addr ) 1 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL1, Port output control
: GPIOE_OCTL_OCTL0 ( -- x addr ) 0 bit GPIOE_OCTL ; \ GPIOE_OCTL_OCTL0, Port output control

\ GPIOE_BOP (write-only) Reset:0x00000000
: GPIOE_BOP_CR15 ( -- x addr ) 31 bit GPIOE_BOP ; \ GPIOE_BOP_CR15, Port 15 Clear bit
: GPIOE_BOP_CR14 ( -- x addr ) 30 bit GPIOE_BOP ; \ GPIOE_BOP_CR14, Port 14 Clear bit
: GPIOE_BOP_CR13 ( -- x addr ) 29 bit GPIOE_BOP ; \ GPIOE_BOP_CR13, Port 13 Clear bit
: GPIOE_BOP_CR12 ( -- x addr ) 28 bit GPIOE_BOP ; \ GPIOE_BOP_CR12, Port 12 Clear bit
: GPIOE_BOP_CR11 ( -- x addr ) 27 bit GPIOE_BOP ; \ GPIOE_BOP_CR11, Port 11 Clear bit
: GPIOE_BOP_CR10 ( -- x addr ) 26 bit GPIOE_BOP ; \ GPIOE_BOP_CR10, Port 10 Clear bit
: GPIOE_BOP_CR9 ( -- x addr ) 25 bit GPIOE_BOP ; \ GPIOE_BOP_CR9, Port 9 Clear bit
: GPIOE_BOP_CR8 ( -- x addr ) 24 bit GPIOE_BOP ; \ GPIOE_BOP_CR8, Port 8 Clear bit
: GPIOE_BOP_CR7 ( -- x addr ) 23 bit GPIOE_BOP ; \ GPIOE_BOP_CR7, Port 7 Clear bit
: GPIOE_BOP_CR6 ( -- x addr ) 22 bit GPIOE_BOP ; \ GPIOE_BOP_CR6, Port 6 Clear bit
: GPIOE_BOP_CR5 ( -- x addr ) 21 bit GPIOE_BOP ; \ GPIOE_BOP_CR5, Port 5 Clear bit
: GPIOE_BOP_CR4 ( -- x addr ) 20 bit GPIOE_BOP ; \ GPIOE_BOP_CR4, Port 4 Clear bit
: GPIOE_BOP_CR3 ( -- x addr ) 19 bit GPIOE_BOP ; \ GPIOE_BOP_CR3, Port 3 Clear bit
: GPIOE_BOP_CR2 ( -- x addr ) 18 bit GPIOE_BOP ; \ GPIOE_BOP_CR2, Port 2 Clear bit
: GPIOE_BOP_CR1 ( -- x addr ) 17 bit GPIOE_BOP ; \ GPIOE_BOP_CR1, Port 1 Clear bit
: GPIOE_BOP_CR0 ( -- x addr ) 16 bit GPIOE_BOP ; \ GPIOE_BOP_CR0, Port 0 Clear bit
: GPIOE_BOP_BOP15 ( -- x addr ) 15 bit GPIOE_BOP ; \ GPIOE_BOP_BOP15, Port 15 Set bit
: GPIOE_BOP_BOP14 ( -- x addr ) 14 bit GPIOE_BOP ; \ GPIOE_BOP_BOP14, Port 14 Set bit
: GPIOE_BOP_BOP13 ( -- x addr ) 13 bit GPIOE_BOP ; \ GPIOE_BOP_BOP13, Port 13 Set bit
: GPIOE_BOP_BOP12 ( -- x addr ) 12 bit GPIOE_BOP ; \ GPIOE_BOP_BOP12, Port 12 Set bit
: GPIOE_BOP_BOP11 ( -- x addr ) 11 bit GPIOE_BOP ; \ GPIOE_BOP_BOP11, Port 11 Set bit
: GPIOE_BOP_BOP10 ( -- x addr ) 10 bit GPIOE_BOP ; \ GPIOE_BOP_BOP10, Port 10 Set bit
: GPIOE_BOP_BOP9 ( -- x addr ) 9 bit GPIOE_BOP ; \ GPIOE_BOP_BOP9, Port 9 Set bit
: GPIOE_BOP_BOP8 ( -- x addr ) 8 bit GPIOE_BOP ; \ GPIOE_BOP_BOP8, Port 8 Set bit
: GPIOE_BOP_BOP7 ( -- x addr ) 7 bit GPIOE_BOP ; \ GPIOE_BOP_BOP7, Port 7 Set bit
: GPIOE_BOP_BOP6 ( -- x addr ) 6 bit GPIOE_BOP ; \ GPIOE_BOP_BOP6, Port 6 Set bit
: GPIOE_BOP_BOP5 ( -- x addr ) 5 bit GPIOE_BOP ; \ GPIOE_BOP_BOP5, Port 5 Set bit
: GPIOE_BOP_BOP4 ( -- x addr ) 4 bit GPIOE_BOP ; \ GPIOE_BOP_BOP4, Port 4 Set bit
: GPIOE_BOP_BOP3 ( -- x addr ) 3 bit GPIOE_BOP ; \ GPIOE_BOP_BOP3, Port 3 Set bit
: GPIOE_BOP_BOP2 ( -- x addr ) 2 bit GPIOE_BOP ; \ GPIOE_BOP_BOP2, Port 2 Set bit
: GPIOE_BOP_BOP1 ( -- x addr ) 1 bit GPIOE_BOP ; \ GPIOE_BOP_BOP1, Port 1 Set bit
: GPIOE_BOP_BOP0 ( -- x addr ) 0 bit GPIOE_BOP ; \ GPIOE_BOP_BOP0, Port 0 Set bit

\ GPIOE_BC (write-only) Reset:0x00000000
: GPIOE_BC_CR15 ( -- x addr ) 15 bit GPIOE_BC ; \ GPIOE_BC_CR15, Port 15 Clear bit
: GPIOE_BC_CR14 ( -- x addr ) 14 bit GPIOE_BC ; \ GPIOE_BC_CR14, Port 14 Clear bit
: GPIOE_BC_CR13 ( -- x addr ) 13 bit GPIOE_BC ; \ GPIOE_BC_CR13, Port 13 Clear bit
: GPIOE_BC_CR12 ( -- x addr ) 12 bit GPIOE_BC ; \ GPIOE_BC_CR12, Port 12 Clear bit
: GPIOE_BC_CR11 ( -- x addr ) 11 bit GPIOE_BC ; \ GPIOE_BC_CR11, Port 11 Clear bit
: GPIOE_BC_CR10 ( -- x addr ) 10 bit GPIOE_BC ; \ GPIOE_BC_CR10, Port 10 Clear bit
: GPIOE_BC_CR9 ( -- x addr ) 9 bit GPIOE_BC ; \ GPIOE_BC_CR9, Port 9 Clear bit
: GPIOE_BC_CR8 ( -- x addr ) 8 bit GPIOE_BC ; \ GPIOE_BC_CR8, Port 8 Clear bit
: GPIOE_BC_CR7 ( -- x addr ) 7 bit GPIOE_BC ; \ GPIOE_BC_CR7, Port 7 Clear bit
: GPIOE_BC_CR6 ( -- x addr ) 6 bit GPIOE_BC ; \ GPIOE_BC_CR6, Port 6 Clear bit
: GPIOE_BC_CR5 ( -- x addr ) 5 bit GPIOE_BC ; \ GPIOE_BC_CR5, Port 5 Clear bit
: GPIOE_BC_CR4 ( -- x addr ) 4 bit GPIOE_BC ; \ GPIOE_BC_CR4, Port 4 Clear bit
: GPIOE_BC_CR3 ( -- x addr ) 3 bit GPIOE_BC ; \ GPIOE_BC_CR3, Port 3 Clear bit
: GPIOE_BC_CR2 ( -- x addr ) 2 bit GPIOE_BC ; \ GPIOE_BC_CR2, Port 2 Clear bit
: GPIOE_BC_CR1 ( -- x addr ) 1 bit GPIOE_BC ; \ GPIOE_BC_CR1, Port 1 Clear bit
: GPIOE_BC_CR0 ( -- x addr ) 0 bit GPIOE_BC ; \ GPIOE_BC_CR0, Port 0 Clear bit

\ GPIOE_LOCK (read-write) Reset:0x00000000
: GPIOE_LOCK_LKK ( -- x addr ) 16 bit GPIOE_LOCK ; \ GPIOE_LOCK_LKK, Lock sequence key  
: GPIOE_LOCK_LK15 ( -- x addr ) 15 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK15, Port Lock bit 15
: GPIOE_LOCK_LK14 ( -- x addr ) 14 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK14, Port Lock bit 14
: GPIOE_LOCK_LK13 ( -- x addr ) 13 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK13, Port Lock bit 13
: GPIOE_LOCK_LK12 ( -- x addr ) 12 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK12, Port Lock bit 12
: GPIOE_LOCK_LK11 ( -- x addr ) 11 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK11, Port Lock bit 11
: GPIOE_LOCK_LK10 ( -- x addr ) 10 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK10, Port Lock bit 10
: GPIOE_LOCK_LK9 ( -- x addr ) 9 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK9, Port Lock bit 9
: GPIOE_LOCK_LK8 ( -- x addr ) 8 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK8, Port Lock bit 8
: GPIOE_LOCK_LK7 ( -- x addr ) 7 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK7, Port Lock bit 7
: GPIOE_LOCK_LK6 ( -- x addr ) 6 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK6, Port Lock bit 6
: GPIOE_LOCK_LK5 ( -- x addr ) 5 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK5, Port Lock bit 5
: GPIOE_LOCK_LK4 ( -- x addr ) 4 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK4, Port Lock bit 4
: GPIOE_LOCK_LK3 ( -- x addr ) 3 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK3, Port Lock bit 3
: GPIOE_LOCK_LK2 ( -- x addr ) 2 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK2, Port Lock bit 2
: GPIOE_LOCK_LK1 ( -- x addr ) 1 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK1, Port Lock bit 1
: GPIOE_LOCK_LK0 ( -- x addr ) 0 bit GPIOE_LOCK ; \ GPIOE_LOCK_LK0, Port Lock bit 0

\ I2C0_CTL0 (read-write) Reset:0x0000
: I2C0_CTL0_SRESET ( -- x addr ) 15 bit I2C0_CTL0 ; \ I2C0_CTL0_SRESET, Software reset
: I2C0_CTL0_SALT ( -- x addr ) 13 bit I2C0_CTL0 ; \ I2C0_CTL0_SALT, SMBus alert
: I2C0_CTL0_PECTRANS ( -- x addr ) 12 bit I2C0_CTL0 ; \ I2C0_CTL0_PECTRANS, PEC Transfer
: I2C0_CTL0_POAP ( -- x addr ) 11 bit I2C0_CTL0 ; \ I2C0_CTL0_POAP, Position of ACK and PEC when receiving
: I2C0_CTL0_ACKEN ( -- x addr ) 10 bit I2C0_CTL0 ; \ I2C0_CTL0_ACKEN, Whether or not to send an ACK
: I2C0_CTL0_STOP ( -- x addr ) 9 bit I2C0_CTL0 ; \ I2C0_CTL0_STOP, Generate a STOP condition on I2C bus
: I2C0_CTL0_START ( -- x addr ) 8 bit I2C0_CTL0 ; \ I2C0_CTL0_START, Generate a START condition on I2C bus
: I2C0_CTL0_SS ( -- x addr ) 7 bit I2C0_CTL0 ; \ I2C0_CTL0_SS, Whether to stretch SCL low when data is not ready in slave mode
: I2C0_CTL0_GCEN ( -- x addr ) 6 bit I2C0_CTL0 ; \ I2C0_CTL0_GCEN, Whether or not to response to a General Call $00
: I2C0_CTL0_PECEN ( -- x addr ) 5 bit I2C0_CTL0 ; \ I2C0_CTL0_PECEN, PEC Calculation Switch
: I2C0_CTL0_ARPEN ( -- x addr ) 4 bit I2C0_CTL0 ; \ I2C0_CTL0_ARPEN, ARP protocol in SMBus switch
: I2C0_CTL0_SMBSEL ( -- x addr ) 3 bit I2C0_CTL0 ; \ I2C0_CTL0_SMBSEL, SMBusType Selection
: I2C0_CTL0_SMBEN ( -- x addr ) 1 bit I2C0_CTL0 ; \ I2C0_CTL0_SMBEN, SMBus/I2C mode switch
: I2C0_CTL0_I2CEN ( -- x addr ) 0 bit I2C0_CTL0 ; \ I2C0_CTL0_I2CEN, I2C peripheral enable

\ I2C0_CTL1 (read-write) Reset:0x0000
: I2C0_CTL1_DMALST ( -- x addr ) 12 bit I2C0_CTL1 ; \ I2C0_CTL1_DMALST, Flag indicating DMA last transfer
: I2C0_CTL1_DMAON ( -- x addr ) 11 bit I2C0_CTL1 ; \ I2C0_CTL1_DMAON, DMA mode switch
: I2C0_CTL1_BUFIE ( -- x addr ) 10 bit I2C0_CTL1 ; \ I2C0_CTL1_BUFIE, Buffer interrupt enable
: I2C0_CTL1_EVIE ( -- x addr ) 9 bit I2C0_CTL1 ; \ I2C0_CTL1_EVIE, Event interrupt enable
: I2C0_CTL1_ERRIE ( -- x addr ) 8 bit I2C0_CTL1 ; \ I2C0_CTL1_ERRIE, Error interrupt enable
: I2C0_CTL1_I2CCLK ( %bbbbbb -- x addr ) I2C0_CTL1 ; \ I2C0_CTL1_I2CCLK, I2C Peripheral clock frequency

\ I2C0_SADDR0 (read-write) Reset:0x0000
: I2C0_SADDR0_ADDFORMAT ( -- x addr ) 15 bit I2C0_SADDR0 ; \ I2C0_SADDR0_ADDFORMAT, Address mode for the I2C slave
: I2C0_SADDR0_ADDRESS9_8 ( %bb -- x addr ) 8 lshift I2C0_SADDR0 ; \ I2C0_SADDR0_ADDRESS9_8, Highest two bits of a 10-bit address
: I2C0_SADDR0_ADDRESS7_1 ( %bbbbbbb -- x addr ) 1 lshift I2C0_SADDR0 ; \ I2C0_SADDR0_ADDRESS7_1, 7-bit address or bits 7:1 of a 10-bit address
: I2C0_SADDR0_ADDRESS0 ( -- x addr ) 0 bit I2C0_SADDR0 ; \ I2C0_SADDR0_ADDRESS0, Bit 0 of a 10-bit address

\ I2C0_SADDR1 (read-write) Reset:0x0000
: I2C0_SADDR1_ADDRESS2 ( %bbbbbbb -- x addr ) 1 lshift I2C0_SADDR1 ; \ I2C0_SADDR1_ADDRESS2, Second I2C address for the slave in Dual-Address mode
: I2C0_SADDR1_DUADEN ( -- x addr ) 0 bit I2C0_SADDR1 ; \ I2C0_SADDR1_DUADEN, Dual-Address mode switch

\ I2C0_DATA (read-write) Reset:0x0000
: I2C0_DATA_TRB ( %bbbbbbbb -- x addr ) I2C0_DATA ; \ I2C0_DATA_TRB, Transmission or reception data buffer register

\ I2C0_STAT0 (multiple-access)  Reset:0x0000
: I2C0_STAT0_SMBALT? ( -- 1|0 ) 15 bit I2C0_STAT0 bit@ ; \ I2C0_STAT0_SMBALT, SMBus Alert status
: I2C0_STAT0_SMBTO ( -- x addr ) 14 bit I2C0_STAT0 ; \ I2C0_STAT0_SMBTO, Timeout signal in SMBus mode
: I2C0_STAT0_PECERR ( -- x addr ) 12 bit I2C0_STAT0 ; \ I2C0_STAT0_PECERR, PEC error when receiving data
: I2C0_STAT0_OUERR ( -- x addr ) 11 bit I2C0_STAT0 ; \ I2C0_STAT0_OUERR, Over-run or under-run situation occurs in slave mode
: I2C0_STAT0_AERR ( -- x addr ) 10 bit I2C0_STAT0 ; \ I2C0_STAT0_AERR, Acknowledge error
: I2C0_STAT0_LOSTARB ( -- x addr ) 9 bit I2C0_STAT0 ; \ I2C0_STAT0_LOSTARB, Arbitration Lost in master mode
: I2C0_STAT0_BERR ( -- x addr ) 8 bit I2C0_STAT0 ; \ I2C0_STAT0_BERR, A bus error occurs indication a unexpected START or STOP condition on I2C bus
: I2C0_STAT0_TBE ( -- x addr ) 7 bit I2C0_STAT0 ; \ I2C0_STAT0_TBE, I2C_DATA is Empty during transmitting
: I2C0_STAT0_RBNE ( -- x addr ) 6 bit I2C0_STAT0 ; \ I2C0_STAT0_RBNE, I2C_DATA is not Empty during receiving
: I2C0_STAT0_STPDET ( -- x addr ) 4 bit I2C0_STAT0 ; \ I2C0_STAT0_STPDET, STOP condition detected in slave mode
: I2C0_STAT0_ADD10SEND ( -- x addr ) 3 bit I2C0_STAT0 ; \ I2C0_STAT0_ADD10SEND, Header of 10-bit address is sent in master mode
: I2C0_STAT0_BTC ( -- x addr ) 2 bit I2C0_STAT0 ; \ I2C0_STAT0_BTC, Byte transmission completed
: I2C0_STAT0_ADDSEND ( -- x addr ) 1 bit I2C0_STAT0 ; \ I2C0_STAT0_ADDSEND, Address is sent in master mode or received and matches in slave mode
: I2C0_STAT0_SBSEND ( -- x addr ) 0 bit I2C0_STAT0 ; \ I2C0_STAT0_SBSEND, START condition sent out in master mode

\ I2C0_STAT1 (read-only) Reset:0x0000
: I2C0_STAT1_PECV? ( --  x ) 8 lshift I2C0_STAT1 @ ; \ I2C0_STAT1_PECV, Packet Error Checking Value that calculated by hardware when PEC is enabled
: I2C0_STAT1_DUMODF? ( --  1|0 ) 7 bit I2C0_STAT1 bit@ ; \ I2C0_STAT1_DUMODF, Dual Flag in slave mode
: I2C0_STAT1_HSTSMB? ( --  1|0 ) 6 bit I2C0_STAT1 bit@ ; \ I2C0_STAT1_HSTSMB, SMBus Host Header detected in slave mode
: I2C0_STAT1_DEFSMB? ( --  1|0 ) 5 bit I2C0_STAT1 bit@ ; \ I2C0_STAT1_DEFSMB, Default address of SMBusDevice
: I2C0_STAT1_RXGC? ( --  1|0 ) 4 bit I2C0_STAT1 bit@ ; \ I2C0_STAT1_RXGC, General call address 00h received
: I2C0_STAT1_TR? ( --  1|0 ) 2 bit I2C0_STAT1 bit@ ; \ I2C0_STAT1_TR, Whether the I2C is a transmitter or a receiver
: I2C0_STAT1_I2CBSY? ( --  1|0 ) 1 bit I2C0_STAT1 bit@ ; \ I2C0_STAT1_I2CBSY, Busy flag
: I2C0_STAT1_MASTER? ( --  1|0 ) 0 bit I2C0_STAT1 bit@ ; \ I2C0_STAT1_MASTER, A flag indicating whether I2C block is in master or slave mode

\ I2C0_CKCFG (read-write) Reset:0x0000
: I2C0_CKCFG_FAST ( -- x addr ) 15 bit I2C0_CKCFG ; \ I2C0_CKCFG_FAST, I2C speed selection in master mode
: I2C0_CKCFG_DTCY ( -- x addr ) 14 bit I2C0_CKCFG ; \ I2C0_CKCFG_DTCY, Duty cycle in fast mode
: I2C0_CKCFG_CLKC ( %bbbbbbbbbbb -- x addr ) I2C0_CKCFG ; \ I2C0_CKCFG_CLKC, I2C Clock control in master mode

\ I2C0_RT (read-write) Reset:0x0002
: I2C0_RT_RISETIME ( %bbbbbb -- x addr ) I2C0_RT ; \ I2C0_RT_RISETIME, Maximum rise time in master mode

\ I2C1_CTL0 (read-write) Reset:0x0000
: I2C1_CTL0_SRESET ( -- x addr ) 15 bit I2C1_CTL0 ; \ I2C1_CTL0_SRESET, Software reset
: I2C1_CTL0_SALT ( -- x addr ) 13 bit I2C1_CTL0 ; \ I2C1_CTL0_SALT, SMBus alert
: I2C1_CTL0_PECTRANS ( -- x addr ) 12 bit I2C1_CTL0 ; \ I2C1_CTL0_PECTRANS, PEC Transfer
: I2C1_CTL0_POAP ( -- x addr ) 11 bit I2C1_CTL0 ; \ I2C1_CTL0_POAP, Position of ACK and PEC when receiving
: I2C1_CTL0_ACKEN ( -- x addr ) 10 bit I2C1_CTL0 ; \ I2C1_CTL0_ACKEN, Whether or not to send an ACK
: I2C1_CTL0_STOP ( -- x addr ) 9 bit I2C1_CTL0 ; \ I2C1_CTL0_STOP, Generate a STOP condition on I2C bus
: I2C1_CTL0_START ( -- x addr ) 8 bit I2C1_CTL0 ; \ I2C1_CTL0_START, Generate a START condition on I2C bus
: I2C1_CTL0_SS ( -- x addr ) 7 bit I2C1_CTL0 ; \ I2C1_CTL0_SS, Whether to stretch SCL low when data is not ready in slave mode
: I2C1_CTL0_GCEN ( -- x addr ) 6 bit I2C1_CTL0 ; \ I2C1_CTL0_GCEN, Whether or not to response to a General Call $00
: I2C1_CTL0_PECEN ( -- x addr ) 5 bit I2C1_CTL0 ; \ I2C1_CTL0_PECEN, PEC Calculation Switch
: I2C1_CTL0_ARPEN ( -- x addr ) 4 bit I2C1_CTL0 ; \ I2C1_CTL0_ARPEN, ARP protocol in SMBus switch
: I2C1_CTL0_SMBSEL ( -- x addr ) 3 bit I2C1_CTL0 ; \ I2C1_CTL0_SMBSEL, SMBusType Selection
: I2C1_CTL0_SMBEN ( -- x addr ) 1 bit I2C1_CTL0 ; \ I2C1_CTL0_SMBEN, SMBus/I2C mode switch
: I2C1_CTL0_I2CEN ( -- x addr ) 0 bit I2C1_CTL0 ; \ I2C1_CTL0_I2CEN, I2C peripheral enable

\ I2C1_CTL1 (read-write) Reset:0x0000
: I2C1_CTL1_DMALST ( -- x addr ) 12 bit I2C1_CTL1 ; \ I2C1_CTL1_DMALST, Flag indicating DMA last transfer
: I2C1_CTL1_DMAON ( -- x addr ) 11 bit I2C1_CTL1 ; \ I2C1_CTL1_DMAON, DMA mode switch
: I2C1_CTL1_BUFIE ( -- x addr ) 10 bit I2C1_CTL1 ; \ I2C1_CTL1_BUFIE, Buffer interrupt enable
: I2C1_CTL1_EVIE ( -- x addr ) 9 bit I2C1_CTL1 ; \ I2C1_CTL1_EVIE, Event interrupt enable
: I2C1_CTL1_ERRIE ( -- x addr ) 8 bit I2C1_CTL1 ; \ I2C1_CTL1_ERRIE, Error interrupt enable
: I2C1_CTL1_I2CCLK ( %bbbbbb -- x addr ) I2C1_CTL1 ; \ I2C1_CTL1_I2CCLK, I2C Peripheral clock frequency

\ I2C1_SADDR0 (read-write) Reset:0x0000
: I2C1_SADDR0_ADDFORMAT ( -- x addr ) 15 bit I2C1_SADDR0 ; \ I2C1_SADDR0_ADDFORMAT, Address mode for the I2C slave
: I2C1_SADDR0_ADDRESS9_8 ( %bb -- x addr ) 8 lshift I2C1_SADDR0 ; \ I2C1_SADDR0_ADDRESS9_8, Highest two bits of a 10-bit address
: I2C1_SADDR0_ADDRESS7_1 ( %bbbbbbb -- x addr ) 1 lshift I2C1_SADDR0 ; \ I2C1_SADDR0_ADDRESS7_1, 7-bit address or bits 7:1 of a 10-bit address
: I2C1_SADDR0_ADDRESS0 ( -- x addr ) 0 bit I2C1_SADDR0 ; \ I2C1_SADDR0_ADDRESS0, Bit 0 of a 10-bit address

\ I2C1_SADDR1 (read-write) Reset:0x0000
: I2C1_SADDR1_ADDRESS2 ( %bbbbbbb -- x addr ) 1 lshift I2C1_SADDR1 ; \ I2C1_SADDR1_ADDRESS2, Second I2C address for the slave in Dual-Address mode
: I2C1_SADDR1_DUADEN ( -- x addr ) 0 bit I2C1_SADDR1 ; \ I2C1_SADDR1_DUADEN, Dual-Address mode switch

\ I2C1_DATA (read-write) Reset:0x0000
: I2C1_DATA_TRB ( %bbbbbbbb -- x addr ) I2C1_DATA ; \ I2C1_DATA_TRB, Transmission or reception data buffer register

\ I2C1_STAT0 (multiple-access)  Reset:0x0000
: I2C1_STAT0_SMBALT? ( -- 1|0 ) 15 bit I2C1_STAT0 bit@ ; \ I2C1_STAT0_SMBALT, SMBus Alert status
: I2C1_STAT0_SMBTO ( -- x addr ) 14 bit I2C1_STAT0 ; \ I2C1_STAT0_SMBTO, Timeout signal in SMBus mode
: I2C1_STAT0_PECERR ( -- x addr ) 12 bit I2C1_STAT0 ; \ I2C1_STAT0_PECERR, PEC error when receiving data
: I2C1_STAT0_OUERR ( -- x addr ) 11 bit I2C1_STAT0 ; \ I2C1_STAT0_OUERR, Over-run or under-run situation occurs in slave mode
: I2C1_STAT0_AERR ( -- x addr ) 10 bit I2C1_STAT0 ; \ I2C1_STAT0_AERR, Acknowledge error
: I2C1_STAT0_LOSTARB ( -- x addr ) 9 bit I2C1_STAT0 ; \ I2C1_STAT0_LOSTARB, Arbitration Lost in master mode
: I2C1_STAT0_BERR ( -- x addr ) 8 bit I2C1_STAT0 ; \ I2C1_STAT0_BERR, A bus error occurs indication a unexpected START or STOP condition on I2C bus
: I2C1_STAT0_TBE ( -- x addr ) 7 bit I2C1_STAT0 ; \ I2C1_STAT0_TBE, I2C_DATA is Empty during transmitting
: I2C1_STAT0_RBNE ( -- x addr ) 6 bit I2C1_STAT0 ; \ I2C1_STAT0_RBNE, I2C_DATA is not Empty during receiving
: I2C1_STAT0_STPDET ( -- x addr ) 4 bit I2C1_STAT0 ; \ I2C1_STAT0_STPDET, STOP condition detected in slave mode
: I2C1_STAT0_ADD10SEND ( -- x addr ) 3 bit I2C1_STAT0 ; \ I2C1_STAT0_ADD10SEND, Header of 10-bit address is sent in master mode
: I2C1_STAT0_BTC ( -- x addr ) 2 bit I2C1_STAT0 ; \ I2C1_STAT0_BTC, Byte transmission completed
: I2C1_STAT0_ADDSEND ( -- x addr ) 1 bit I2C1_STAT0 ; \ I2C1_STAT0_ADDSEND, Address is sent in master mode or received and matches in slave mode
: I2C1_STAT0_SBSEND ( -- x addr ) 0 bit I2C1_STAT0 ; \ I2C1_STAT0_SBSEND, START condition sent out in master mode

\ I2C1_STAT1 (read-only) Reset:0x0000
: I2C1_STAT1_PECV? ( --  x ) 8 lshift I2C1_STAT1 @ ; \ I2C1_STAT1_PECV, Packet Error Checking Value that calculated by hardware when PEC is enabled
: I2C1_STAT1_DUMODF? ( --  1|0 ) 7 bit I2C1_STAT1 bit@ ; \ I2C1_STAT1_DUMODF, Dual Flag in slave mode
: I2C1_STAT1_HSTSMB? ( --  1|0 ) 6 bit I2C1_STAT1 bit@ ; \ I2C1_STAT1_HSTSMB, SMBus Host Header detected in slave mode
: I2C1_STAT1_DEFSMB? ( --  1|0 ) 5 bit I2C1_STAT1 bit@ ; \ I2C1_STAT1_DEFSMB, Default address of SMBusDevice
: I2C1_STAT1_RXGC? ( --  1|0 ) 4 bit I2C1_STAT1 bit@ ; \ I2C1_STAT1_RXGC, General call address 00h received
: I2C1_STAT1_TR? ( --  1|0 ) 2 bit I2C1_STAT1 bit@ ; \ I2C1_STAT1_TR, Whether the I2C is a transmitter or a receiver
: I2C1_STAT1_I2CBSY? ( --  1|0 ) 1 bit I2C1_STAT1 bit@ ; \ I2C1_STAT1_I2CBSY, Busy flag
: I2C1_STAT1_MASTER? ( --  1|0 ) 0 bit I2C1_STAT1 bit@ ; \ I2C1_STAT1_MASTER, A flag indicating whether I2C block is in master or slave mode

\ I2C1_CKCFG (read-write) Reset:0x0000
: I2C1_CKCFG_FAST ( -- x addr ) 15 bit I2C1_CKCFG ; \ I2C1_CKCFG_FAST, I2C speed selection in master mode
: I2C1_CKCFG_DTCY ( -- x addr ) 14 bit I2C1_CKCFG ; \ I2C1_CKCFG_DTCY, Duty cycle in fast mode
: I2C1_CKCFG_CLKC ( %bbbbbbbbbbb -- x addr ) I2C1_CKCFG ; \ I2C1_CKCFG_CLKC, I2C Clock control in master mode

\ I2C1_RT (read-write) Reset:0x0002
: I2C1_RT_RISETIME ( %bbbbbb -- x addr ) I2C1_RT ; \ I2C1_RT_RISETIME, Maximum rise time in master mode

\ ECLIC_CLICCFG (read-write) Reset:0x00
: ECLIC_CLICCFG_NLBITS ( %bbbb -- x addr ) 1 lshift ECLIC_CLICCFG ; \ ECLIC_CLICCFG_NLBITS, NLBITS

\ ECLIC_CLICINFO (read-only) Reset:0x00000000
: ECLIC_CLICINFO_NUM_INTERRUPT? ( --  x ) ECLIC_CLICINFO @ ; \ ECLIC_CLICINFO_NUM_INTERRUPT, NUM_INTERRUPT
: ECLIC_CLICINFO_VERSION? ( --  x ) 13 lshift ECLIC_CLICINFO @ ; \ ECLIC_CLICINFO_VERSION, VERSION
: ECLIC_CLICINFO_CLICINTCTLBITS? ( --  x ) 21 lshift ECLIC_CLICINFO @ ; \ ECLIC_CLICINFO_CLICINTCTLBITS, CLICINTCTLBITS

\ ECLIC_MTH (read-write) Reset:0x00
: ECLIC_MTH_MTH ( %bbbbbbbb -- x addr ) ECLIC_MTH ; \ ECLIC_MTH_MTH, MTH

\ ECLIC_CLICINTIP_0 (read-write) Reset:0x00
: ECLIC_CLICINTIP_0_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_0 ; \ ECLIC_CLICINTIP_0_IP, IP

\ ECLIC_CLICINTIP_1 (read-write) Reset:0x00
: ECLIC_CLICINTIP_1_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_1 ; \ ECLIC_CLICINTIP_1_IP, IP

\ ECLIC_CLICINTIP_2 (read-write) Reset:0x00
: ECLIC_CLICINTIP_2_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_2 ; \ ECLIC_CLICINTIP_2_IP, IP

\ ECLIC_CLICINTIP_3 (read-write) Reset:0x00
: ECLIC_CLICINTIP_3_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_3 ; \ ECLIC_CLICINTIP_3_IP, IP

\ ECLIC_CLICINTIP_4 (read-write) Reset:0x00
: ECLIC_CLICINTIP_4_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_4 ; \ ECLIC_CLICINTIP_4_IP, IP

\ ECLIC_CLICINTIP_5 (read-write) Reset:0x00
: ECLIC_CLICINTIP_5_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_5 ; \ ECLIC_CLICINTIP_5_IP, IP

\ ECLIC_CLICINTIP_6 (read-write) Reset:0x00
: ECLIC_CLICINTIP_6_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_6 ; \ ECLIC_CLICINTIP_6_IP, IP

\ ECLIC_CLICINTIP_7 (read-write) Reset:0x00
: ECLIC_CLICINTIP_7_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_7 ; \ ECLIC_CLICINTIP_7_IP, IP

\ ECLIC_CLICINTIP_8 (read-write) Reset:0x00
: ECLIC_CLICINTIP_8_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_8 ; \ ECLIC_CLICINTIP_8_IP, IP

\ ECLIC_CLICINTIP_9 (read-write) Reset:0x00
: ECLIC_CLICINTIP_9_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_9 ; \ ECLIC_CLICINTIP_9_IP, IP

\ ECLIC_CLICINTIP_10 (read-write) Reset:0x00
: ECLIC_CLICINTIP_10_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_10 ; \ ECLIC_CLICINTIP_10_IP, IP

\ ECLIC_CLICINTIP_11 (read-write) Reset:0x00
: ECLIC_CLICINTIP_11_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_11 ; \ ECLIC_CLICINTIP_11_IP, IP

\ ECLIC_CLICINTIP_12 (read-write) Reset:0x00
: ECLIC_CLICINTIP_12_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_12 ; \ ECLIC_CLICINTIP_12_IP, IP

\ ECLIC_CLICINTIP_13 (read-write) Reset:0x00
: ECLIC_CLICINTIP_13_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_13 ; \ ECLIC_CLICINTIP_13_IP, IP

\ ECLIC_CLICINTIP_14 (read-write) Reset:0x00
: ECLIC_CLICINTIP_14_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_14 ; \ ECLIC_CLICINTIP_14_IP, IP

\ ECLIC_CLICINTIP_15 (read-write) Reset:0x00
: ECLIC_CLICINTIP_15_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_15 ; \ ECLIC_CLICINTIP_15_IP, IP

\ ECLIC_CLICINTIP_16 (read-write) Reset:0x00
: ECLIC_CLICINTIP_16_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_16 ; \ ECLIC_CLICINTIP_16_IP, IP

\ ECLIC_CLICINTIP_17 (read-write) Reset:0x00
: ECLIC_CLICINTIP_17_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_17 ; \ ECLIC_CLICINTIP_17_IP, IP

\ ECLIC_CLICINTIP_18 (read-write) Reset:0x00
: ECLIC_CLICINTIP_18_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_18 ; \ ECLIC_CLICINTIP_18_IP, IP

\ ECLIC_CLICINTIP_19 (read-write) Reset:0x00
: ECLIC_CLICINTIP_19_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_19 ; \ ECLIC_CLICINTIP_19_IP, IP

\ ECLIC_CLICINTIP_20 (read-write) Reset:0x00
: ECLIC_CLICINTIP_20_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_20 ; \ ECLIC_CLICINTIP_20_IP, IP

\ ECLIC_CLICINTIP_21 (read-write) Reset:0x00
: ECLIC_CLICINTIP_21_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_21 ; \ ECLIC_CLICINTIP_21_IP, IP

\ ECLIC_CLICINTIP_22 (read-write) Reset:0x00
: ECLIC_CLICINTIP_22_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_22 ; \ ECLIC_CLICINTIP_22_IP, IP

\ ECLIC_CLICINTIP_23 (read-write) Reset:0x00
: ECLIC_CLICINTIP_23_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_23 ; \ ECLIC_CLICINTIP_23_IP, IP

\ ECLIC_CLICINTIP_24 (read-write) Reset:0x00
: ECLIC_CLICINTIP_24_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_24 ; \ ECLIC_CLICINTIP_24_IP, IP

\ ECLIC_CLICINTIP_25 (read-write) Reset:0x00
: ECLIC_CLICINTIP_25_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_25 ; \ ECLIC_CLICINTIP_25_IP, IP

\ ECLIC_CLICINTIP_26 (read-write) Reset:0x00
: ECLIC_CLICINTIP_26_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_26 ; \ ECLIC_CLICINTIP_26_IP, IP

\ ECLIC_CLICINTIP_27 (read-write) Reset:0x00
: ECLIC_CLICINTIP_27_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_27 ; \ ECLIC_CLICINTIP_27_IP, IP

\ ECLIC_CLICINTIP_28 (read-write) Reset:0x00
: ECLIC_CLICINTIP_28_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_28 ; \ ECLIC_CLICINTIP_28_IP, IP

\ ECLIC_CLICINTIP_29 (read-write) Reset:0x00
: ECLIC_CLICINTIP_29_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_29 ; \ ECLIC_CLICINTIP_29_IP, IP

\ ECLIC_CLICINTIP_30 (read-write) Reset:0x00
: ECLIC_CLICINTIP_30_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_30 ; \ ECLIC_CLICINTIP_30_IP, IP

\ ECLIC_CLICINTIP_31 (read-write) Reset:0x00
: ECLIC_CLICINTIP_31_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_31 ; \ ECLIC_CLICINTIP_31_IP, IP

\ ECLIC_CLICINTIP_32 (read-write) Reset:0x00
: ECLIC_CLICINTIP_32_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_32 ; \ ECLIC_CLICINTIP_32_IP, IP

\ ECLIC_CLICINTIP_33 (read-write) Reset:0x00
: ECLIC_CLICINTIP_33_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_33 ; \ ECLIC_CLICINTIP_33_IP, IP

\ ECLIC_CLICINTIP_34 (read-write) Reset:0x00
: ECLIC_CLICINTIP_34_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_34 ; \ ECLIC_CLICINTIP_34_IP, IP

\ ECLIC_CLICINTIP_35 (read-write) Reset:0x00
: ECLIC_CLICINTIP_35_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_35 ; \ ECLIC_CLICINTIP_35_IP, IP

\ ECLIC_CLICINTIP_36 (read-write) Reset:0x00
: ECLIC_CLICINTIP_36_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_36 ; \ ECLIC_CLICINTIP_36_IP, IP

\ ECLIC_CLICINTIP_37 (read-write) Reset:0x00
: ECLIC_CLICINTIP_37_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_37 ; \ ECLIC_CLICINTIP_37_IP, IP

\ ECLIC_CLICINTIP_38 (read-write) Reset:0x00
: ECLIC_CLICINTIP_38_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_38 ; \ ECLIC_CLICINTIP_38_IP, IP

\ ECLIC_CLICINTIP_39 (read-write) Reset:0x00
: ECLIC_CLICINTIP_39_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_39 ; \ ECLIC_CLICINTIP_39_IP, IP

\ ECLIC_CLICINTIP_40 (read-write) Reset:0x00
: ECLIC_CLICINTIP_40_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_40 ; \ ECLIC_CLICINTIP_40_IP, IP

\ ECLIC_CLICINTIP_41 (read-write) Reset:0x00
: ECLIC_CLICINTIP_41_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_41 ; \ ECLIC_CLICINTIP_41_IP, IP

\ ECLIC_CLICINTIP_42 (read-write) Reset:0x00
: ECLIC_CLICINTIP_42_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_42 ; \ ECLIC_CLICINTIP_42_IP, IP

\ ECLIC_CLICINTIP_43 (read-write) Reset:0x00
: ECLIC_CLICINTIP_43_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_43 ; \ ECLIC_CLICINTIP_43_IP, IP

\ ECLIC_CLICINTIP_44 (read-write) Reset:0x00
: ECLIC_CLICINTIP_44_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_44 ; \ ECLIC_CLICINTIP_44_IP, IP

\ ECLIC_CLICINTIP_45 (read-write) Reset:0x00
: ECLIC_CLICINTIP_45_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_45 ; \ ECLIC_CLICINTIP_45_IP, IP

\ ECLIC_CLICINTIP_46 (read-write) Reset:0x00
: ECLIC_CLICINTIP_46_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_46 ; \ ECLIC_CLICINTIP_46_IP, IP

\ ECLIC_CLICINTIP_47 (read-write) Reset:0x00
: ECLIC_CLICINTIP_47_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_47 ; \ ECLIC_CLICINTIP_47_IP, IP

\ ECLIC_CLICINTIP_48 (read-write) Reset:0x00
: ECLIC_CLICINTIP_48_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_48 ; \ ECLIC_CLICINTIP_48_IP, IP

\ ECLIC_CLICINTIP_49 (read-write) Reset:0x00
: ECLIC_CLICINTIP_49_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_49 ; \ ECLIC_CLICINTIP_49_IP, IP

\ ECLIC_CLICINTIP_50 (read-write) Reset:0x00
: ECLIC_CLICINTIP_50_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_50 ; \ ECLIC_CLICINTIP_50_IP, IP

\ ECLIC_CLICINTIP_51 (read-write) Reset:0x00
: ECLIC_CLICINTIP_51_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_51 ; \ ECLIC_CLICINTIP_51_IP, IP

\ ECLIC_CLICINTIP_52 (read-write) Reset:0x00
: ECLIC_CLICINTIP_52_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_52 ; \ ECLIC_CLICINTIP_52_IP, IP

\ ECLIC_CLICINTIP_53 (read-write) Reset:0x00
: ECLIC_CLICINTIP_53_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_53 ; \ ECLIC_CLICINTIP_53_IP, IP

\ ECLIC_CLICINTIP_54 (read-write) Reset:0x00
: ECLIC_CLICINTIP_54_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_54 ; \ ECLIC_CLICINTIP_54_IP, IP

\ ECLIC_CLICINTIP_55 (read-write) Reset:0x00
: ECLIC_CLICINTIP_55_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_55 ; \ ECLIC_CLICINTIP_55_IP, IP

\ ECLIC_CLICINTIP_56 (read-write) Reset:0x00
: ECLIC_CLICINTIP_56_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_56 ; \ ECLIC_CLICINTIP_56_IP, IP

\ ECLIC_CLICINTIP_57 (read-write) Reset:0x00
: ECLIC_CLICINTIP_57_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_57 ; \ ECLIC_CLICINTIP_57_IP, IP

\ ECLIC_CLICINTIP_58 (read-write) Reset:0x00
: ECLIC_CLICINTIP_58_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_58 ; \ ECLIC_CLICINTIP_58_IP, IP

\ ECLIC_CLICINTIP_59 (read-write) Reset:0x00
: ECLIC_CLICINTIP_59_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_59 ; \ ECLIC_CLICINTIP_59_IP, IP

\ ECLIC_CLICINTIP_60 (read-write) Reset:0x00
: ECLIC_CLICINTIP_60_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_60 ; \ ECLIC_CLICINTIP_60_IP, IP

\ ECLIC_CLICINTIP_61 (read-write) Reset:0x00
: ECLIC_CLICINTIP_61_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_61 ; \ ECLIC_CLICINTIP_61_IP, IP

\ ECLIC_CLICINTIP_62 (read-write) Reset:0x00
: ECLIC_CLICINTIP_62_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_62 ; \ ECLIC_CLICINTIP_62_IP, IP

\ ECLIC_CLICINTIP_63 (read-write) Reset:0x00
: ECLIC_CLICINTIP_63_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_63 ; \ ECLIC_CLICINTIP_63_IP, IP

\ ECLIC_CLICINTIP_64 (read-write) Reset:0x00
: ECLIC_CLICINTIP_64_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_64 ; \ ECLIC_CLICINTIP_64_IP, IP

\ ECLIC_CLICINTIP_65 (read-write) Reset:0x00
: ECLIC_CLICINTIP_65_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_65 ; \ ECLIC_CLICINTIP_65_IP, IP

\ ECLIC_CLICINTIP_66 (read-write) Reset:0x00
: ECLIC_CLICINTIP_66_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_66 ; \ ECLIC_CLICINTIP_66_IP, IP

\ ECLIC_CLICINTIP_67 (read-write) Reset:0x00
: ECLIC_CLICINTIP_67_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_67 ; \ ECLIC_CLICINTIP_67_IP, IP

\ ECLIC_CLICINTIP_68 (read-write) Reset:0x00
: ECLIC_CLICINTIP_68_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_68 ; \ ECLIC_CLICINTIP_68_IP, IP

\ ECLIC_CLICINTIP_69 (read-write) Reset:0x00
: ECLIC_CLICINTIP_69_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_69 ; \ ECLIC_CLICINTIP_69_IP, IP

\ ECLIC_CLICINTIP_70 (read-write) Reset:0x00
: ECLIC_CLICINTIP_70_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_70 ; \ ECLIC_CLICINTIP_70_IP, IP

\ ECLIC_CLICINTIP_71 (read-write) Reset:0x00
: ECLIC_CLICINTIP_71_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_71 ; \ ECLIC_CLICINTIP_71_IP, IP

\ ECLIC_CLICINTIP_72 (read-write) Reset:0x00
: ECLIC_CLICINTIP_72_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_72 ; \ ECLIC_CLICINTIP_72_IP, IP

\ ECLIC_CLICINTIP_73 (read-write) Reset:0x00
: ECLIC_CLICINTIP_73_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_73 ; \ ECLIC_CLICINTIP_73_IP, IP

\ ECLIC_CLICINTIP_74 (read-write) Reset:0x00
: ECLIC_CLICINTIP_74_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_74 ; \ ECLIC_CLICINTIP_74_IP, IP

\ ECLIC_CLICINTIP_75 (read-write) Reset:0x00
: ECLIC_CLICINTIP_75_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_75 ; \ ECLIC_CLICINTIP_75_IP, IP

\ ECLIC_CLICINTIP_76 (read-write) Reset:0x00
: ECLIC_CLICINTIP_76_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_76 ; \ ECLIC_CLICINTIP_76_IP, IP

\ ECLIC_CLICINTIP_77 (read-write) Reset:0x00
: ECLIC_CLICINTIP_77_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_77 ; \ ECLIC_CLICINTIP_77_IP, IP

\ ECLIC_CLICINTIP_78 (read-write) Reset:0x00
: ECLIC_CLICINTIP_78_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_78 ; \ ECLIC_CLICINTIP_78_IP, IP

\ ECLIC_CLICINTIP_79 (read-write) Reset:0x00
: ECLIC_CLICINTIP_79_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_79 ; \ ECLIC_CLICINTIP_79_IP, IP

\ ECLIC_CLICINTIP_80 (read-write) Reset:0x00
: ECLIC_CLICINTIP_80_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_80 ; \ ECLIC_CLICINTIP_80_IP, IP

\ ECLIC_CLICINTIP_81 (read-write) Reset:0x00
: ECLIC_CLICINTIP_81_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_81 ; \ ECLIC_CLICINTIP_81_IP, IP

\ ECLIC_CLICINTIP_82 (read-write) Reset:0x00
: ECLIC_CLICINTIP_82_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_82 ; \ ECLIC_CLICINTIP_82_IP, IP

\ ECLIC_CLICINTIP_83 (read-write) Reset:0x00
: ECLIC_CLICINTIP_83_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_83 ; \ ECLIC_CLICINTIP_83_IP, IP

\ ECLIC_CLICINTIP_84 (read-write) Reset:0x00
: ECLIC_CLICINTIP_84_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_84 ; \ ECLIC_CLICINTIP_84_IP, IP

\ ECLIC_CLICINTIP_85 (read-write) Reset:0x00
: ECLIC_CLICINTIP_85_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_85 ; \ ECLIC_CLICINTIP_85_IP, IP

\ ECLIC_CLICINTIP_86 (read-write) Reset:0x00
: ECLIC_CLICINTIP_86_IP ( -- x addr ) 0 bit ECLIC_CLICINTIP_86 ; \ ECLIC_CLICINTIP_86_IP, IP

\ ECLIC_CLICINTIE_0 (read-write) Reset:0x00
: ECLIC_CLICINTIE_0_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_0 ; \ ECLIC_CLICINTIE_0_IE, IE

\ ECLIC_CLICINTIE_1 (read-write) Reset:0x00
: ECLIC_CLICINTIE_1_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_1 ; \ ECLIC_CLICINTIE_1_IE, IE

\ ECLIC_CLICINTIE_2 (read-write) Reset:0x00
: ECLIC_CLICINTIE_2_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_2 ; \ ECLIC_CLICINTIE_2_IE, IE

\ ECLIC_CLICINTIE_3 (read-write) Reset:0x00
: ECLIC_CLICINTIE_3_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_3 ; \ ECLIC_CLICINTIE_3_IE, IE

\ ECLIC_CLICINTIE_4 (read-write) Reset:0x00
: ECLIC_CLICINTIE_4_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_4 ; \ ECLIC_CLICINTIE_4_IE, IE

\ ECLIC_CLICINTIE_5 (read-write) Reset:0x00
: ECLIC_CLICINTIE_5_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_5 ; \ ECLIC_CLICINTIE_5_IE, IE

\ ECLIC_CLICINTIE_6 (read-write) Reset:0x00
: ECLIC_CLICINTIE_6_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_6 ; \ ECLIC_CLICINTIE_6_IE, IE

\ ECLIC_CLICINTIE_7 (read-write) Reset:0x00
: ECLIC_CLICINTIE_7_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_7 ; \ ECLIC_CLICINTIE_7_IE, IE

\ ECLIC_CLICINTIE_8 (read-write) Reset:0x00
: ECLIC_CLICINTIE_8_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_8 ; \ ECLIC_CLICINTIE_8_IE, IE

\ ECLIC_CLICINTIE_9 (read-write) Reset:0x00
: ECLIC_CLICINTIE_9_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_9 ; \ ECLIC_CLICINTIE_9_IE, IE

\ ECLIC_CLICINTIE_10 (read-write) Reset:0x00
: ECLIC_CLICINTIE_10_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_10 ; \ ECLIC_CLICINTIE_10_IE, IE

\ ECLIC_CLICINTIE_11 (read-write) Reset:0x00
: ECLIC_CLICINTIE_11_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_11 ; \ ECLIC_CLICINTIE_11_IE, IE

\ ECLIC_CLICINTIE_12 (read-write) Reset:0x00
: ECLIC_CLICINTIE_12_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_12 ; \ ECLIC_CLICINTIE_12_IE, IE

\ ECLIC_CLICINTIE_13 (read-write) Reset:0x00
: ECLIC_CLICINTIE_13_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_13 ; \ ECLIC_CLICINTIE_13_IE, IE

\ ECLIC_CLICINTIE_14 (read-write) Reset:0x00
: ECLIC_CLICINTIE_14_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_14 ; \ ECLIC_CLICINTIE_14_IE, IE

\ ECLIC_CLICINTIE_15 (read-write) Reset:0x00
: ECLIC_CLICINTIE_15_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_15 ; \ ECLIC_CLICINTIE_15_IE, IE

\ ECLIC_CLICINTIE_16 (read-write) Reset:0x00
: ECLIC_CLICINTIE_16_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_16 ; \ ECLIC_CLICINTIE_16_IE, IE

\ ECLIC_CLICINTIE_17 (read-write) Reset:0x00
: ECLIC_CLICINTIE_17_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_17 ; \ ECLIC_CLICINTIE_17_IE, IE

\ ECLIC_CLICINTIE_18 (read-write) Reset:0x00
: ECLIC_CLICINTIE_18_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_18 ; \ ECLIC_CLICINTIE_18_IE, IE

\ ECLIC_CLICINTIE_19 (read-write) Reset:0x00
: ECLIC_CLICINTIE_19_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_19 ; \ ECLIC_CLICINTIE_19_IE, IE

\ ECLIC_CLICINTIE_20 (read-write) Reset:0x00
: ECLIC_CLICINTIE_20_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_20 ; \ ECLIC_CLICINTIE_20_IE, IE

\ ECLIC_CLICINTIE_21 (read-write) Reset:0x00
: ECLIC_CLICINTIE_21_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_21 ; \ ECLIC_CLICINTIE_21_IE, IE

\ ECLIC_CLICINTIE_22 (read-write) Reset:0x00
: ECLIC_CLICINTIE_22_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_22 ; \ ECLIC_CLICINTIE_22_IE, IE

\ ECLIC_CLICINTIE_23 (read-write) Reset:0x00
: ECLIC_CLICINTIE_23_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_23 ; \ ECLIC_CLICINTIE_23_IE, IE

\ ECLIC_CLICINTIE_24 (read-write) Reset:0x00
: ECLIC_CLICINTIE_24_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_24 ; \ ECLIC_CLICINTIE_24_IE, IE

\ ECLIC_CLICINTIE_25 (read-write) Reset:0x00
: ECLIC_CLICINTIE_25_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_25 ; \ ECLIC_CLICINTIE_25_IE, IE

\ ECLIC_CLICINTIE_26 (read-write) Reset:0x00
: ECLIC_CLICINTIE_26_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_26 ; \ ECLIC_CLICINTIE_26_IE, IE

\ ECLIC_CLICINTIE_27 (read-write) Reset:0x00
: ECLIC_CLICINTIE_27_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_27 ; \ ECLIC_CLICINTIE_27_IE, IE

\ ECLIC_CLICINTIE_28 (read-write) Reset:0x00
: ECLIC_CLICINTIE_28_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_28 ; \ ECLIC_CLICINTIE_28_IE, IE

\ ECLIC_CLICINTIE_29 (read-write) Reset:0x00
: ECLIC_CLICINTIE_29_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_29 ; \ ECLIC_CLICINTIE_29_IE, IE

\ ECLIC_CLICINTIE_30 (read-write) Reset:0x00
: ECLIC_CLICINTIE_30_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_30 ; \ ECLIC_CLICINTIE_30_IE, IE

\ ECLIC_CLICINTIE_31 (read-write) Reset:0x00
: ECLIC_CLICINTIE_31_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_31 ; \ ECLIC_CLICINTIE_31_IE, IE

\ ECLIC_CLICINTIE_32 (read-write) Reset:0x00
: ECLIC_CLICINTIE_32_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_32 ; \ ECLIC_CLICINTIE_32_IE, IE

\ ECLIC_CLICINTIE_33 (read-write) Reset:0x00
: ECLIC_CLICINTIE_33_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_33 ; \ ECLIC_CLICINTIE_33_IE, IE

\ ECLIC_CLICINTIE_34 (read-write) Reset:0x00
: ECLIC_CLICINTIE_34_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_34 ; \ ECLIC_CLICINTIE_34_IE, IE

\ ECLIC_CLICINTIE_35 (read-write) Reset:0x00
: ECLIC_CLICINTIE_35_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_35 ; \ ECLIC_CLICINTIE_35_IE, IE

\ ECLIC_CLICINTIE_36 (read-write) Reset:0x00
: ECLIC_CLICINTIE_36_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_36 ; \ ECLIC_CLICINTIE_36_IE, IE

\ ECLIC_CLICINTIE_37 (read-write) Reset:0x00
: ECLIC_CLICINTIE_37_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_37 ; \ ECLIC_CLICINTIE_37_IE, IE

\ ECLIC_CLICINTIE_38 (read-write) Reset:0x00
: ECLIC_CLICINTIE_38_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_38 ; \ ECLIC_CLICINTIE_38_IE, IE

\ ECLIC_CLICINTIE_39 (read-write) Reset:0x00
: ECLIC_CLICINTIE_39_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_39 ; \ ECLIC_CLICINTIE_39_IE, IE

\ ECLIC_CLICINTIE_40 (read-write) Reset:0x00
: ECLIC_CLICINTIE_40_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_40 ; \ ECLIC_CLICINTIE_40_IE, IE

\ ECLIC_CLICINTIE_41 (read-write) Reset:0x00
: ECLIC_CLICINTIE_41_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_41 ; \ ECLIC_CLICINTIE_41_IE, IE

\ ECLIC_CLICINTIE_42 (read-write) Reset:0x00
: ECLIC_CLICINTIE_42_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_42 ; \ ECLIC_CLICINTIE_42_IE, IE

\ ECLIC_CLICINTIE_43 (read-write) Reset:0x00
: ECLIC_CLICINTIE_43_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_43 ; \ ECLIC_CLICINTIE_43_IE, IE

\ ECLIC_CLICINTIE_44 (read-write) Reset:0x00
: ECLIC_CLICINTIE_44_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_44 ; \ ECLIC_CLICINTIE_44_IE, IE

\ ECLIC_CLICINTIE_45 (read-write) Reset:0x00
: ECLIC_CLICINTIE_45_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_45 ; \ ECLIC_CLICINTIE_45_IE, IE

\ ECLIC_CLICINTIE_46 (read-write) Reset:0x00
: ECLIC_CLICINTIE_46_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_46 ; \ ECLIC_CLICINTIE_46_IE, IE

\ ECLIC_CLICINTIE_47 (read-write) Reset:0x00
: ECLIC_CLICINTIE_47_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_47 ; \ ECLIC_CLICINTIE_47_IE, IE

\ ECLIC_CLICINTIE_48 (read-write) Reset:0x00
: ECLIC_CLICINTIE_48_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_48 ; \ ECLIC_CLICINTIE_48_IE, IE

\ ECLIC_CLICINTIE_49 (read-write) Reset:0x00
: ECLIC_CLICINTIE_49_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_49 ; \ ECLIC_CLICINTIE_49_IE, IE

\ ECLIC_CLICINTIE_50 (read-write) Reset:0x00
: ECLIC_CLICINTIE_50_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_50 ; \ ECLIC_CLICINTIE_50_IE, IE

\ ECLIC_CLICINTIE_51 (read-write) Reset:0x00
: ECLIC_CLICINTIE_51_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_51 ; \ ECLIC_CLICINTIE_51_IE, IE

\ ECLIC_CLICINTIE_52 (read-write) Reset:0x00
: ECLIC_CLICINTIE_52_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_52 ; \ ECLIC_CLICINTIE_52_IE, IE

\ ECLIC_CLICINTIE_53 (read-write) Reset:0x00
: ECLIC_CLICINTIE_53_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_53 ; \ ECLIC_CLICINTIE_53_IE, IE

\ ECLIC_CLICINTIE_54 (read-write) Reset:0x00
: ECLIC_CLICINTIE_54_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_54 ; \ ECLIC_CLICINTIE_54_IE, IE

\ ECLIC_CLICINTIE_55 (read-write) Reset:0x00
: ECLIC_CLICINTIE_55_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_55 ; \ ECLIC_CLICINTIE_55_IE, IE

\ ECLIC_CLICINTIE_56 (read-write) Reset:0x00
: ECLIC_CLICINTIE_56_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_56 ; \ ECLIC_CLICINTIE_56_IE, IE

\ ECLIC_CLICINTIE_57 (read-write) Reset:0x00
: ECLIC_CLICINTIE_57_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_57 ; \ ECLIC_CLICINTIE_57_IE, IE

\ ECLIC_CLICINTIE_58 (read-write) Reset:0x00
: ECLIC_CLICINTIE_58_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_58 ; \ ECLIC_CLICINTIE_58_IE, IE

\ ECLIC_CLICINTIE_59 (read-write) Reset:0x00
: ECLIC_CLICINTIE_59_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_59 ; \ ECLIC_CLICINTIE_59_IE, IE

\ ECLIC_CLICINTIE_60 (read-write) Reset:0x00
: ECLIC_CLICINTIE_60_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_60 ; \ ECLIC_CLICINTIE_60_IE, IE

\ ECLIC_CLICINTIE_61 (read-write) Reset:0x00
: ECLIC_CLICINTIE_61_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_61 ; \ ECLIC_CLICINTIE_61_IE, IE

\ ECLIC_CLICINTIE_62 (read-write) Reset:0x00
: ECLIC_CLICINTIE_62_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_62 ; \ ECLIC_CLICINTIE_62_IE, IE

\ ECLIC_CLICINTIE_63 (read-write) Reset:0x00
: ECLIC_CLICINTIE_63_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_63 ; \ ECLIC_CLICINTIE_63_IE, IE

\ ECLIC_CLICINTIE_64 (read-write) Reset:0x00
: ECLIC_CLICINTIE_64_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_64 ; \ ECLIC_CLICINTIE_64_IE, IE

\ ECLIC_CLICINTIE_65 (read-write) Reset:0x00
: ECLIC_CLICINTIE_65_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_65 ; \ ECLIC_CLICINTIE_65_IE, IE

\ ECLIC_CLICINTIE_66 (read-write) Reset:0x00
: ECLIC_CLICINTIE_66_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_66 ; \ ECLIC_CLICINTIE_66_IE, IE

\ ECLIC_CLICINTIE_67 (read-write) Reset:0x00
: ECLIC_CLICINTIE_67_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_67 ; \ ECLIC_CLICINTIE_67_IE, IE

\ ECLIC_CLICINTIE_68 (read-write) Reset:0x00
: ECLIC_CLICINTIE_68_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_68 ; \ ECLIC_CLICINTIE_68_IE, IE

\ ECLIC_CLICINTIE_69 (read-write) Reset:0x00
: ECLIC_CLICINTIE_69_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_69 ; \ ECLIC_CLICINTIE_69_IE, IE

\ ECLIC_CLICINTIE_70 (read-write) Reset:0x00
: ECLIC_CLICINTIE_70_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_70 ; \ ECLIC_CLICINTIE_70_IE, IE

\ ECLIC_CLICINTIE_71 (read-write) Reset:0x00
: ECLIC_CLICINTIE_71_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_71 ; \ ECLIC_CLICINTIE_71_IE, IE

\ ECLIC_CLICINTIE_72 (read-write) Reset:0x00
: ECLIC_CLICINTIE_72_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_72 ; \ ECLIC_CLICINTIE_72_IE, IE

\ ECLIC_CLICINTIE_73 (read-write) Reset:0x00
: ECLIC_CLICINTIE_73_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_73 ; \ ECLIC_CLICINTIE_73_IE, IE

\ ECLIC_CLICINTIE_74 (read-write) Reset:0x00
: ECLIC_CLICINTIE_74_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_74 ; \ ECLIC_CLICINTIE_74_IE, IE

\ ECLIC_CLICINTIE_75 (read-write) Reset:0x00
: ECLIC_CLICINTIE_75_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_75 ; \ ECLIC_CLICINTIE_75_IE, IE

\ ECLIC_CLICINTIE_76 (read-write) Reset:0x00
: ECLIC_CLICINTIE_76_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_76 ; \ ECLIC_CLICINTIE_76_IE, IE

\ ECLIC_CLICINTIE_77 (read-write) Reset:0x00
: ECLIC_CLICINTIE_77_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_77 ; \ ECLIC_CLICINTIE_77_IE, IE

\ ECLIC_CLICINTIE_78 (read-write) Reset:0x00
: ECLIC_CLICINTIE_78_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_78 ; \ ECLIC_CLICINTIE_78_IE, IE

\ ECLIC_CLICINTIE_79 (read-write) Reset:0x00
: ECLIC_CLICINTIE_79_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_79 ; \ ECLIC_CLICINTIE_79_IE, IE

\ ECLIC_CLICINTIE_80 (read-write) Reset:0x00
: ECLIC_CLICINTIE_80_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_80 ; \ ECLIC_CLICINTIE_80_IE, IE

\ ECLIC_CLICINTIE_81 (read-write) Reset:0x00
: ECLIC_CLICINTIE_81_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_81 ; \ ECLIC_CLICINTIE_81_IE, IE

\ ECLIC_CLICINTIE_82 (read-write) Reset:0x00
: ECLIC_CLICINTIE_82_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_82 ; \ ECLIC_CLICINTIE_82_IE, IE

\ ECLIC_CLICINTIE_83 (read-write) Reset:0x00
: ECLIC_CLICINTIE_83_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_83 ; \ ECLIC_CLICINTIE_83_IE, IE

\ ECLIC_CLICINTIE_84 (read-write) Reset:0x00
: ECLIC_CLICINTIE_84_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_84 ; \ ECLIC_CLICINTIE_84_IE, IE

\ ECLIC_CLICINTIE_85 (read-write) Reset:0x00
: ECLIC_CLICINTIE_85_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_85 ; \ ECLIC_CLICINTIE_85_IE, IE

\ ECLIC_CLICINTIE_86 (read-write) Reset:0x00
: ECLIC_CLICINTIE_86_IE ( -- x addr ) 0 bit ECLIC_CLICINTIE_86 ; \ ECLIC_CLICINTIE_86_IE, IE

\ ECLIC_CLICINTATTR_0 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_0_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_0 ; \ ECLIC_CLICINTATTR_0_SHV, SHV
: ECLIC_CLICINTATTR_0_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_0 ; \ ECLIC_CLICINTATTR_0_TRIG, TRIG

\ ECLIC_CLICINTATTR_1 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_1_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_1 ; \ ECLIC_CLICINTATTR_1_SHV, SHV
: ECLIC_CLICINTATTR_1_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_1 ; \ ECLIC_CLICINTATTR_1_TRIG, TRIG

\ ECLIC_CLICINTATTR_2 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_2_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_2 ; \ ECLIC_CLICINTATTR_2_SHV, SHV
: ECLIC_CLICINTATTR_2_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_2 ; \ ECLIC_CLICINTATTR_2_TRIG, TRIG

\ ECLIC_CLICINTATTR_3 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_3_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_3 ; \ ECLIC_CLICINTATTR_3_SHV, SHV
: ECLIC_CLICINTATTR_3_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_3 ; \ ECLIC_CLICINTATTR_3_TRIG, TRIG

\ ECLIC_CLICINTATTR_4 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_4_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_4 ; \ ECLIC_CLICINTATTR_4_SHV, SHV
: ECLIC_CLICINTATTR_4_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_4 ; \ ECLIC_CLICINTATTR_4_TRIG, TRIG

\ ECLIC_CLICINTATTR_5 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_5_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_5 ; \ ECLIC_CLICINTATTR_5_SHV, SHV
: ECLIC_CLICINTATTR_5_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_5 ; \ ECLIC_CLICINTATTR_5_TRIG, TRIG

\ ECLIC_CLICINTATTR_6 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_6_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_6 ; \ ECLIC_CLICINTATTR_6_SHV, SHV
: ECLIC_CLICINTATTR_6_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_6 ; \ ECLIC_CLICINTATTR_6_TRIG, TRIG

\ ECLIC_CLICINTATTR_7 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_7_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_7 ; \ ECLIC_CLICINTATTR_7_SHV, SHV
: ECLIC_CLICINTATTR_7_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_7 ; \ ECLIC_CLICINTATTR_7_TRIG, TRIG

\ ECLIC_CLICINTATTR_8 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_8_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_8 ; \ ECLIC_CLICINTATTR_8_SHV, SHV
: ECLIC_CLICINTATTR_8_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_8 ; \ ECLIC_CLICINTATTR_8_TRIG, TRIG

\ ECLIC_CLICINTATTR_9 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_9_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_9 ; \ ECLIC_CLICINTATTR_9_SHV, SHV
: ECLIC_CLICINTATTR_9_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_9 ; \ ECLIC_CLICINTATTR_9_TRIG, TRIG

\ ECLIC_CLICINTATTR_10 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_10_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_10 ; \ ECLIC_CLICINTATTR_10_SHV, SHV
: ECLIC_CLICINTATTR_10_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_10 ; \ ECLIC_CLICINTATTR_10_TRIG, TRIG

\ ECLIC_CLICINTATTR_11 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_11_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_11 ; \ ECLIC_CLICINTATTR_11_SHV, SHV
: ECLIC_CLICINTATTR_11_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_11 ; \ ECLIC_CLICINTATTR_11_TRIG, TRIG

\ ECLIC_CLICINTATTR_12 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_12_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_12 ; \ ECLIC_CLICINTATTR_12_SHV, SHV
: ECLIC_CLICINTATTR_12_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_12 ; \ ECLIC_CLICINTATTR_12_TRIG, TRIG

\ ECLIC_CLICINTATTR_13 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_13_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_13 ; \ ECLIC_CLICINTATTR_13_SHV, SHV
: ECLIC_CLICINTATTR_13_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_13 ; \ ECLIC_CLICINTATTR_13_TRIG, TRIG

\ ECLIC_CLICINTATTR_14 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_14_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_14 ; \ ECLIC_CLICINTATTR_14_SHV, SHV
: ECLIC_CLICINTATTR_14_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_14 ; \ ECLIC_CLICINTATTR_14_TRIG, TRIG

\ ECLIC_CLICINTATTR_15 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_15_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_15 ; \ ECLIC_CLICINTATTR_15_SHV, SHV
: ECLIC_CLICINTATTR_15_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_15 ; \ ECLIC_CLICINTATTR_15_TRIG, TRIG

\ ECLIC_CLICINTATTR_16 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_16_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_16 ; \ ECLIC_CLICINTATTR_16_SHV, SHV
: ECLIC_CLICINTATTR_16_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_16 ; \ ECLIC_CLICINTATTR_16_TRIG, TRIG

\ ECLIC_CLICINTATTR_17 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_17_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_17 ; \ ECLIC_CLICINTATTR_17_SHV, SHV
: ECLIC_CLICINTATTR_17_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_17 ; \ ECLIC_CLICINTATTR_17_TRIG, TRIG

\ ECLIC_CLICINTATTR_18 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_18_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_18 ; \ ECLIC_CLICINTATTR_18_SHV, SHV
: ECLIC_CLICINTATTR_18_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_18 ; \ ECLIC_CLICINTATTR_18_TRIG, TRIG

\ ECLIC_CLICINTATTR_19 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_19_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_19 ; \ ECLIC_CLICINTATTR_19_SHV, SHV
: ECLIC_CLICINTATTR_19_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_19 ; \ ECLIC_CLICINTATTR_19_TRIG, TRIG

\ ECLIC_CLICINTATTR_20 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_20_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_20 ; \ ECLIC_CLICINTATTR_20_SHV, SHV
: ECLIC_CLICINTATTR_20_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_20 ; \ ECLIC_CLICINTATTR_20_TRIG, TRIG

\ ECLIC_CLICINTATTR_21 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_21_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_21 ; \ ECLIC_CLICINTATTR_21_SHV, SHV
: ECLIC_CLICINTATTR_21_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_21 ; \ ECLIC_CLICINTATTR_21_TRIG, TRIG

\ ECLIC_CLICINTATTR_22 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_22_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_22 ; \ ECLIC_CLICINTATTR_22_SHV, SHV
: ECLIC_CLICINTATTR_22_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_22 ; \ ECLIC_CLICINTATTR_22_TRIG, TRIG

\ ECLIC_CLICINTATTR_23 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_23_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_23 ; \ ECLIC_CLICINTATTR_23_SHV, SHV
: ECLIC_CLICINTATTR_23_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_23 ; \ ECLIC_CLICINTATTR_23_TRIG, TRIG

\ ECLIC_CLICINTATTR_24 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_24_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_24 ; \ ECLIC_CLICINTATTR_24_SHV, SHV
: ECLIC_CLICINTATTR_24_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_24 ; \ ECLIC_CLICINTATTR_24_TRIG, TRIG

\ ECLIC_CLICINTATTR_25 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_25_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_25 ; \ ECLIC_CLICINTATTR_25_SHV, SHV
: ECLIC_CLICINTATTR_25_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_25 ; \ ECLIC_CLICINTATTR_25_TRIG, TRIG

\ ECLIC_CLICINTATTR_26 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_26_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_26 ; \ ECLIC_CLICINTATTR_26_SHV, SHV
: ECLIC_CLICINTATTR_26_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_26 ; \ ECLIC_CLICINTATTR_26_TRIG, TRIG

\ ECLIC_CLICINTATTR_27 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_27_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_27 ; \ ECLIC_CLICINTATTR_27_SHV, SHV
: ECLIC_CLICINTATTR_27_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_27 ; \ ECLIC_CLICINTATTR_27_TRIG, TRIG

\ ECLIC_CLICINTATTR_28 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_28_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_28 ; \ ECLIC_CLICINTATTR_28_SHV, SHV
: ECLIC_CLICINTATTR_28_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_28 ; \ ECLIC_CLICINTATTR_28_TRIG, TRIG

\ ECLIC_CLICINTATTR_29 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_29_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_29 ; \ ECLIC_CLICINTATTR_29_SHV, SHV
: ECLIC_CLICINTATTR_29_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_29 ; \ ECLIC_CLICINTATTR_29_TRIG, TRIG

\ ECLIC_CLICINTATTR_30 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_30_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_30 ; \ ECLIC_CLICINTATTR_30_SHV, SHV
: ECLIC_CLICINTATTR_30_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_30 ; \ ECLIC_CLICINTATTR_30_TRIG, TRIG

\ ECLIC_CLICINTATTR_31 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_31_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_31 ; \ ECLIC_CLICINTATTR_31_SHV, SHV
: ECLIC_CLICINTATTR_31_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_31 ; \ ECLIC_CLICINTATTR_31_TRIG, TRIG

\ ECLIC_CLICINTATTR_32 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_32_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_32 ; \ ECLIC_CLICINTATTR_32_SHV, SHV
: ECLIC_CLICINTATTR_32_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_32 ; \ ECLIC_CLICINTATTR_32_TRIG, TRIG

\ ECLIC_CLICINTATTR_33 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_33_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_33 ; \ ECLIC_CLICINTATTR_33_SHV, SHV
: ECLIC_CLICINTATTR_33_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_33 ; \ ECLIC_CLICINTATTR_33_TRIG, TRIG

\ ECLIC_CLICINTATTR_34 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_34_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_34 ; \ ECLIC_CLICINTATTR_34_SHV, SHV
: ECLIC_CLICINTATTR_34_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_34 ; \ ECLIC_CLICINTATTR_34_TRIG, TRIG

\ ECLIC_CLICINTATTR_35 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_35_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_35 ; \ ECLIC_CLICINTATTR_35_SHV, SHV
: ECLIC_CLICINTATTR_35_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_35 ; \ ECLIC_CLICINTATTR_35_TRIG, TRIG

\ ECLIC_CLICINTATTR_36 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_36_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_36 ; \ ECLIC_CLICINTATTR_36_SHV, SHV
: ECLIC_CLICINTATTR_36_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_36 ; \ ECLIC_CLICINTATTR_36_TRIG, TRIG

\ ECLIC_CLICINTATTR_37 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_37_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_37 ; \ ECLIC_CLICINTATTR_37_SHV, SHV
: ECLIC_CLICINTATTR_37_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_37 ; \ ECLIC_CLICINTATTR_37_TRIG, TRIG

\ ECLIC_CLICINTATTR_38 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_38_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_38 ; \ ECLIC_CLICINTATTR_38_SHV, SHV
: ECLIC_CLICINTATTR_38_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_38 ; \ ECLIC_CLICINTATTR_38_TRIG, TRIG

\ ECLIC_CLICINTATTR_39 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_39_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_39 ; \ ECLIC_CLICINTATTR_39_SHV, SHV
: ECLIC_CLICINTATTR_39_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_39 ; \ ECLIC_CLICINTATTR_39_TRIG, TRIG

\ ECLIC_CLICINTATTR_40 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_40_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_40 ; \ ECLIC_CLICINTATTR_40_SHV, SHV
: ECLIC_CLICINTATTR_40_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_40 ; \ ECLIC_CLICINTATTR_40_TRIG, TRIG

\ ECLIC_CLICINTATTR_41 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_41_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_41 ; \ ECLIC_CLICINTATTR_41_SHV, SHV
: ECLIC_CLICINTATTR_41_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_41 ; \ ECLIC_CLICINTATTR_41_TRIG, TRIG

\ ECLIC_CLICINTATTR_42 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_42_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_42 ; \ ECLIC_CLICINTATTR_42_SHV, SHV
: ECLIC_CLICINTATTR_42_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_42 ; \ ECLIC_CLICINTATTR_42_TRIG, TRIG

\ ECLIC_CLICINTATTR_43 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_43_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_43 ; \ ECLIC_CLICINTATTR_43_SHV, SHV
: ECLIC_CLICINTATTR_43_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_43 ; \ ECLIC_CLICINTATTR_43_TRIG, TRIG

\ ECLIC_CLICINTATTR_44 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_44_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_44 ; \ ECLIC_CLICINTATTR_44_SHV, SHV
: ECLIC_CLICINTATTR_44_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_44 ; \ ECLIC_CLICINTATTR_44_TRIG, TRIG

\ ECLIC_CLICINTATTR_45 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_45_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_45 ; \ ECLIC_CLICINTATTR_45_SHV, SHV
: ECLIC_CLICINTATTR_45_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_45 ; \ ECLIC_CLICINTATTR_45_TRIG, TRIG

\ ECLIC_CLICINTATTR_46 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_46_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_46 ; \ ECLIC_CLICINTATTR_46_SHV, SHV
: ECLIC_CLICINTATTR_46_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_46 ; \ ECLIC_CLICINTATTR_46_TRIG, TRIG

\ ECLIC_CLICINTATTR_47 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_47_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_47 ; \ ECLIC_CLICINTATTR_47_SHV, SHV
: ECLIC_CLICINTATTR_47_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_47 ; \ ECLIC_CLICINTATTR_47_TRIG, TRIG

\ ECLIC_CLICINTATTR_48 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_48_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_48 ; \ ECLIC_CLICINTATTR_48_SHV, SHV
: ECLIC_CLICINTATTR_48_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_48 ; \ ECLIC_CLICINTATTR_48_TRIG, TRIG

\ ECLIC_CLICINTATTR_49 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_49_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_49 ; \ ECLIC_CLICINTATTR_49_SHV, SHV
: ECLIC_CLICINTATTR_49_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_49 ; \ ECLIC_CLICINTATTR_49_TRIG, TRIG

\ ECLIC_CLICINTATTR_50 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_50_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_50 ; \ ECLIC_CLICINTATTR_50_SHV, SHV
: ECLIC_CLICINTATTR_50_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_50 ; \ ECLIC_CLICINTATTR_50_TRIG, TRIG

\ ECLIC_CLICINTATTR_51 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_51_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_51 ; \ ECLIC_CLICINTATTR_51_SHV, SHV
: ECLIC_CLICINTATTR_51_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_51 ; \ ECLIC_CLICINTATTR_51_TRIG, TRIG

\ ECLIC_CLICINTATTR_52 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_52_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_52 ; \ ECLIC_CLICINTATTR_52_SHV, SHV
: ECLIC_CLICINTATTR_52_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_52 ; \ ECLIC_CLICINTATTR_52_TRIG, TRIG

\ ECLIC_CLICINTATTR_53 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_53_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_53 ; \ ECLIC_CLICINTATTR_53_SHV, SHV
: ECLIC_CLICINTATTR_53_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_53 ; \ ECLIC_CLICINTATTR_53_TRIG, TRIG

\ ECLIC_CLICINTATTR_54 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_54_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_54 ; \ ECLIC_CLICINTATTR_54_SHV, SHV
: ECLIC_CLICINTATTR_54_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_54 ; \ ECLIC_CLICINTATTR_54_TRIG, TRIG

\ ECLIC_CLICINTATTR_55 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_55_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_55 ; \ ECLIC_CLICINTATTR_55_SHV, SHV
: ECLIC_CLICINTATTR_55_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_55 ; \ ECLIC_CLICINTATTR_55_TRIG, TRIG

\ ECLIC_CLICINTATTR_56 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_56_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_56 ; \ ECLIC_CLICINTATTR_56_SHV, SHV
: ECLIC_CLICINTATTR_56_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_56 ; \ ECLIC_CLICINTATTR_56_TRIG, TRIG

\ ECLIC_CLICINTATTR_57 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_57_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_57 ; \ ECLIC_CLICINTATTR_57_SHV, SHV
: ECLIC_CLICINTATTR_57_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_57 ; \ ECLIC_CLICINTATTR_57_TRIG, TRIG

\ ECLIC_CLICINTATTR_58 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_58_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_58 ; \ ECLIC_CLICINTATTR_58_SHV, SHV
: ECLIC_CLICINTATTR_58_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_58 ; \ ECLIC_CLICINTATTR_58_TRIG, TRIG

\ ECLIC_CLICINTATTR_59 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_59_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_59 ; \ ECLIC_CLICINTATTR_59_SHV, SHV
: ECLIC_CLICINTATTR_59_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_59 ; \ ECLIC_CLICINTATTR_59_TRIG, TRIG

\ ECLIC_CLICINTATTR_60 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_60_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_60 ; \ ECLIC_CLICINTATTR_60_SHV, SHV
: ECLIC_CLICINTATTR_60_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_60 ; \ ECLIC_CLICINTATTR_60_TRIG, TRIG

\ ECLIC_CLICINTATTR_61 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_61_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_61 ; \ ECLIC_CLICINTATTR_61_SHV, SHV
: ECLIC_CLICINTATTR_61_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_61 ; \ ECLIC_CLICINTATTR_61_TRIG, TRIG

\ ECLIC_CLICINTATTR_62 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_62_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_62 ; \ ECLIC_CLICINTATTR_62_SHV, SHV
: ECLIC_CLICINTATTR_62_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_62 ; \ ECLIC_CLICINTATTR_62_TRIG, TRIG

\ ECLIC_CLICINTATTR_63 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_63_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_63 ; \ ECLIC_CLICINTATTR_63_SHV, SHV
: ECLIC_CLICINTATTR_63_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_63 ; \ ECLIC_CLICINTATTR_63_TRIG, TRIG

\ ECLIC_CLICINTATTR_64 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_64_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_64 ; \ ECLIC_CLICINTATTR_64_SHV, SHV
: ECLIC_CLICINTATTR_64_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_64 ; \ ECLIC_CLICINTATTR_64_TRIG, TRIG

\ ECLIC_CLICINTATTR_65 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_65_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_65 ; \ ECLIC_CLICINTATTR_65_SHV, SHV
: ECLIC_CLICINTATTR_65_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_65 ; \ ECLIC_CLICINTATTR_65_TRIG, TRIG

\ ECLIC_CLICINTATTR_66 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_66_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_66 ; \ ECLIC_CLICINTATTR_66_SHV, SHV
: ECLIC_CLICINTATTR_66_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_66 ; \ ECLIC_CLICINTATTR_66_TRIG, TRIG

\ ECLIC_CLICINTATTR_67 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_67_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_67 ; \ ECLIC_CLICINTATTR_67_SHV, SHV
: ECLIC_CLICINTATTR_67_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_67 ; \ ECLIC_CLICINTATTR_67_TRIG, TRIG

\ ECLIC_CLICINTATTR_68 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_68_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_68 ; \ ECLIC_CLICINTATTR_68_SHV, SHV
: ECLIC_CLICINTATTR_68_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_68 ; \ ECLIC_CLICINTATTR_68_TRIG, TRIG

\ ECLIC_CLICINTATTR_69 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_69_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_69 ; \ ECLIC_CLICINTATTR_69_SHV, SHV
: ECLIC_CLICINTATTR_69_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_69 ; \ ECLIC_CLICINTATTR_69_TRIG, TRIG

\ ECLIC_CLICINTATTR_70 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_70_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_70 ; \ ECLIC_CLICINTATTR_70_SHV, SHV
: ECLIC_CLICINTATTR_70_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_70 ; \ ECLIC_CLICINTATTR_70_TRIG, TRIG

\ ECLIC_CLICINTATTR_71 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_71_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_71 ; \ ECLIC_CLICINTATTR_71_SHV, SHV
: ECLIC_CLICINTATTR_71_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_71 ; \ ECLIC_CLICINTATTR_71_TRIG, TRIG

\ ECLIC_CLICINTATTR_72 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_72_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_72 ; \ ECLIC_CLICINTATTR_72_SHV, SHV
: ECLIC_CLICINTATTR_72_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_72 ; \ ECLIC_CLICINTATTR_72_TRIG, TRIG

\ ECLIC_CLICINTATTR_73 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_73_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_73 ; \ ECLIC_CLICINTATTR_73_SHV, SHV
: ECLIC_CLICINTATTR_73_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_73 ; \ ECLIC_CLICINTATTR_73_TRIG, TRIG

\ ECLIC_CLICINTATTR_74 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_74_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_74 ; \ ECLIC_CLICINTATTR_74_SHV, SHV
: ECLIC_CLICINTATTR_74_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_74 ; \ ECLIC_CLICINTATTR_74_TRIG, TRIG

\ ECLIC_CLICINTATTR_75 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_75_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_75 ; \ ECLIC_CLICINTATTR_75_SHV, SHV
: ECLIC_CLICINTATTR_75_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_75 ; \ ECLIC_CLICINTATTR_75_TRIG, TRIG

\ ECLIC_CLICINTATTR_76 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_76_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_76 ; \ ECLIC_CLICINTATTR_76_SHV, SHV
: ECLIC_CLICINTATTR_76_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_76 ; \ ECLIC_CLICINTATTR_76_TRIG, TRIG

\ ECLIC_CLICINTATTR_77 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_77_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_77 ; \ ECLIC_CLICINTATTR_77_SHV, SHV
: ECLIC_CLICINTATTR_77_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_77 ; \ ECLIC_CLICINTATTR_77_TRIG, TRIG

\ ECLIC_CLICINTATTR_78 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_78_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_78 ; \ ECLIC_CLICINTATTR_78_SHV, SHV
: ECLIC_CLICINTATTR_78_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_78 ; \ ECLIC_CLICINTATTR_78_TRIG, TRIG

\ ECLIC_CLICINTATTR_79 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_79_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_79 ; \ ECLIC_CLICINTATTR_79_SHV, SHV
: ECLIC_CLICINTATTR_79_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_79 ; \ ECLIC_CLICINTATTR_79_TRIG, TRIG

\ ECLIC_CLICINTATTR_80 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_80_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_80 ; \ ECLIC_CLICINTATTR_80_SHV, SHV
: ECLIC_CLICINTATTR_80_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_80 ; \ ECLIC_CLICINTATTR_80_TRIG, TRIG

\ ECLIC_CLICINTATTR_81 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_81_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_81 ; \ ECLIC_CLICINTATTR_81_SHV, SHV
: ECLIC_CLICINTATTR_81_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_81 ; \ ECLIC_CLICINTATTR_81_TRIG, TRIG

\ ECLIC_CLICINTATTR_82 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_82_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_82 ; \ ECLIC_CLICINTATTR_82_SHV, SHV
: ECLIC_CLICINTATTR_82_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_82 ; \ ECLIC_CLICINTATTR_82_TRIG, TRIG

\ ECLIC_CLICINTATTR_83 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_83_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_83 ; \ ECLIC_CLICINTATTR_83_SHV, SHV
: ECLIC_CLICINTATTR_83_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_83 ; \ ECLIC_CLICINTATTR_83_TRIG, TRIG

\ ECLIC_CLICINTATTR_84 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_84_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_84 ; \ ECLIC_CLICINTATTR_84_SHV, SHV
: ECLIC_CLICINTATTR_84_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_84 ; \ ECLIC_CLICINTATTR_84_TRIG, TRIG

\ ECLIC_CLICINTATTR_85 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_85_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_85 ; \ ECLIC_CLICINTATTR_85_SHV, SHV
: ECLIC_CLICINTATTR_85_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_85 ; \ ECLIC_CLICINTATTR_85_TRIG, TRIG

\ ECLIC_CLICINTATTR_86 (read-write) Reset:0x00
: ECLIC_CLICINTATTR_86_SHV ( -- x addr ) 0 bit ECLIC_CLICINTATTR_86 ; \ ECLIC_CLICINTATTR_86_SHV, SHV
: ECLIC_CLICINTATTR_86_TRIG ( %bb -- x addr ) 1 lshift ECLIC_CLICINTATTR_86 ; \ ECLIC_CLICINTATTR_86_TRIG, TRIG

\ ECLIC_CLICINTCTL_0 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_0_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_0 ; \ ECLIC_CLICINTCTL_0_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_1 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_1_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_1 ; \ ECLIC_CLICINTCTL_1_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_2 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_2_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_2 ; \ ECLIC_CLICINTCTL_2_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_3 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_3_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_3 ; \ ECLIC_CLICINTCTL_3_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_4 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_4_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_4 ; \ ECLIC_CLICINTCTL_4_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_5 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_5_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_5 ; \ ECLIC_CLICINTCTL_5_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_6 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_6_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_6 ; \ ECLIC_CLICINTCTL_6_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_7 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_7_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_7 ; \ ECLIC_CLICINTCTL_7_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_8 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_8_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_8 ; \ ECLIC_CLICINTCTL_8_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_9 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_9_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_9 ; \ ECLIC_CLICINTCTL_9_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_10 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_10_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_10 ; \ ECLIC_CLICINTCTL_10_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_11 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_11_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_11 ; \ ECLIC_CLICINTCTL_11_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_12 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_12_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_12 ; \ ECLIC_CLICINTCTL_12_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_13 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_13_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_13 ; \ ECLIC_CLICINTCTL_13_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_14 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_14_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_14 ; \ ECLIC_CLICINTCTL_14_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_15 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_15_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_15 ; \ ECLIC_CLICINTCTL_15_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_16 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_16_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_16 ; \ ECLIC_CLICINTCTL_16_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_17 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_17_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_17 ; \ ECLIC_CLICINTCTL_17_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_18 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_18_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_18 ; \ ECLIC_CLICINTCTL_18_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_19 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_19_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_19 ; \ ECLIC_CLICINTCTL_19_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_20 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_20_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_20 ; \ ECLIC_CLICINTCTL_20_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_21 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_21_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_21 ; \ ECLIC_CLICINTCTL_21_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_22 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_22_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_22 ; \ ECLIC_CLICINTCTL_22_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_23 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_23_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_23 ; \ ECLIC_CLICINTCTL_23_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_24 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_24_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_24 ; \ ECLIC_CLICINTCTL_24_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_25 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_25_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_25 ; \ ECLIC_CLICINTCTL_25_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_26 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_26_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_26 ; \ ECLIC_CLICINTCTL_26_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_27 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_27_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_27 ; \ ECLIC_CLICINTCTL_27_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_28 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_28_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_28 ; \ ECLIC_CLICINTCTL_28_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_29 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_29_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_29 ; \ ECLIC_CLICINTCTL_29_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_30 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_30_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_30 ; \ ECLIC_CLICINTCTL_30_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_31 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_31_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_31 ; \ ECLIC_CLICINTCTL_31_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_32 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_32_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_32 ; \ ECLIC_CLICINTCTL_32_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_33 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_33_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_33 ; \ ECLIC_CLICINTCTL_33_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_34 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_34_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_34 ; \ ECLIC_CLICINTCTL_34_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_35 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_35_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_35 ; \ ECLIC_CLICINTCTL_35_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_36 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_36_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_36 ; \ ECLIC_CLICINTCTL_36_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_37 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_37_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_37 ; \ ECLIC_CLICINTCTL_37_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_38 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_38_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_38 ; \ ECLIC_CLICINTCTL_38_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_39 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_39_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_39 ; \ ECLIC_CLICINTCTL_39_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_40 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_40_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_40 ; \ ECLIC_CLICINTCTL_40_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_41 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_41_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_41 ; \ ECLIC_CLICINTCTL_41_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_42 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_42_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_42 ; \ ECLIC_CLICINTCTL_42_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_43 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_43_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_43 ; \ ECLIC_CLICINTCTL_43_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_44 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_44_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_44 ; \ ECLIC_CLICINTCTL_44_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_45 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_45_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_45 ; \ ECLIC_CLICINTCTL_45_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_46 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_46_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_46 ; \ ECLIC_CLICINTCTL_46_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_47 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_47_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_47 ; \ ECLIC_CLICINTCTL_47_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_48 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_48_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_48 ; \ ECLIC_CLICINTCTL_48_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_49 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_49_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_49 ; \ ECLIC_CLICINTCTL_49_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_50 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_50_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_50 ; \ ECLIC_CLICINTCTL_50_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_51 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_51_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_51 ; \ ECLIC_CLICINTCTL_51_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_52 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_52_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_52 ; \ ECLIC_CLICINTCTL_52_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_53 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_53_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_53 ; \ ECLIC_CLICINTCTL_53_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_54 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_54_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_54 ; \ ECLIC_CLICINTCTL_54_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_55 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_55_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_55 ; \ ECLIC_CLICINTCTL_55_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_56 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_56_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_56 ; \ ECLIC_CLICINTCTL_56_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_57 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_57_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_57 ; \ ECLIC_CLICINTCTL_57_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_58 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_58_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_58 ; \ ECLIC_CLICINTCTL_58_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_59 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_59_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_59 ; \ ECLIC_CLICINTCTL_59_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_60 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_60_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_60 ; \ ECLIC_CLICINTCTL_60_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_61 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_61_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_61 ; \ ECLIC_CLICINTCTL_61_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_62 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_62_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_62 ; \ ECLIC_CLICINTCTL_62_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_63 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_63_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_63 ; \ ECLIC_CLICINTCTL_63_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_64 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_64_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_64 ; \ ECLIC_CLICINTCTL_64_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_65 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_65_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_65 ; \ ECLIC_CLICINTCTL_65_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_66 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_66_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_66 ; \ ECLIC_CLICINTCTL_66_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_67 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_67_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_67 ; \ ECLIC_CLICINTCTL_67_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_68 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_68_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_68 ; \ ECLIC_CLICINTCTL_68_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_69 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_69_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_69 ; \ ECLIC_CLICINTCTL_69_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_70 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_70_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_70 ; \ ECLIC_CLICINTCTL_70_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_71 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_71_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_71 ; \ ECLIC_CLICINTCTL_71_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_72 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_72_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_72 ; \ ECLIC_CLICINTCTL_72_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_73 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_73_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_73 ; \ ECLIC_CLICINTCTL_73_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_74 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_74_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_74 ; \ ECLIC_CLICINTCTL_74_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_75 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_75_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_75 ; \ ECLIC_CLICINTCTL_75_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_76 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_76_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_76 ; \ ECLIC_CLICINTCTL_76_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_77 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_77_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_77 ; \ ECLIC_CLICINTCTL_77_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_78 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_78_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_78 ; \ ECLIC_CLICINTCTL_78_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_79 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_79_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_79 ; \ ECLIC_CLICINTCTL_79_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_80 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_80_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_80 ; \ ECLIC_CLICINTCTL_80_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_81 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_81_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_81 ; \ ECLIC_CLICINTCTL_81_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_82 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_82_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_82 ; \ ECLIC_CLICINTCTL_82_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_83 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_83_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_83 ; \ ECLIC_CLICINTCTL_83_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_84 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_84_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_84 ; \ ECLIC_CLICINTCTL_84_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_85 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_85_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_85 ; \ ECLIC_CLICINTCTL_85_LEVEL_PRIORITY, LEVEL_PRIORITY

\ ECLIC_CLICINTCTL_86 (read-write) Reset:0x00
: ECLIC_CLICINTCTL_86_LEVEL_PRIORITY ( %bbbbbbbb -- x addr ) ECLIC_CLICINTCTL_86 ; \ ECLIC_CLICINTCTL_86_LEVEL_PRIORITY, LEVEL_PRIORITY

\ PMU_CTL (read-write) Reset:0x00000000
: PMU_CTL_BKPWEN ( -- x addr ) 8 bit PMU_CTL ; \ PMU_CTL_BKPWEN, Backup Domain Write Enable
: PMU_CTL_LVDT ( %bbb -- x addr ) 5 lshift PMU_CTL ; \ PMU_CTL_LVDT, Low Voltage Detector Threshold
: PMU_CTL_LVDEN ( -- x addr ) 4 bit PMU_CTL ; \ PMU_CTL_LVDEN, Low Voltage Detector Enable
: PMU_CTL_STBRST ( -- x addr ) 3 bit PMU_CTL ; \ PMU_CTL_STBRST, Standby Flag Reset
: PMU_CTL_WURST ( -- x addr ) 2 bit PMU_CTL ; \ PMU_CTL_WURST, Wakeup Flag Reset
: PMU_CTL_STBMOD ( -- x addr ) 1 bit PMU_CTL ; \ PMU_CTL_STBMOD, Standby Mode
: PMU_CTL_LDOLP ( -- x addr ) 0 bit PMU_CTL ; \ PMU_CTL_LDOLP, LDO Low Power Mode

\ PMU_CS (multiple-access)  Reset:0x00000000
: PMU_CS_WUPEN ( -- x addr ) 8 bit PMU_CS ; \ PMU_CS_WUPEN, Enable WKUP pin
: PMU_CS_LVDF ( -- x addr ) 2 bit PMU_CS ; \ PMU_CS_LVDF, Low Voltage Detector Status Flag
: PMU_CS_STBF? ( -- 1|0 ) 1 bit PMU_CS bit@ ; \ PMU_CS_STBF, Standby flag
: PMU_CS_WUF? ( -- 1|0 ) 0 bit PMU_CS bit@ ; \ PMU_CS_WUF, Wakeup flag

\ RCU_CTL (multiple-access)  Reset:0x00000083
: RCU_CTL_IRC8MEN ( -- x addr ) 0 bit RCU_CTL ; \ RCU_CTL_IRC8MEN, Internal 8MHz RC oscillator Enable
: RCU_CTL_IRC8MSTB ( -- x addr ) 1 bit RCU_CTL ; \ RCU_CTL_IRC8MSTB, IRC8M Internal 8MHz RC Oscillator stabilization Flag
: RCU_CTL_IRC8MADJ ( %bbbbb -- x addr ) 3 lshift RCU_CTL ; \ RCU_CTL_IRC8MADJ, Internal 8MHz RC Oscillator clock trim adjust value
: RCU_CTL_IRC8MCALIB ( %bbbbbbbb -- x addr ) 8 lshift RCU_CTL ; \ RCU_CTL_IRC8MCALIB, Internal 8MHz RC Oscillator calibration value register
: RCU_CTL_HXTALEN ( -- x addr ) 16 bit RCU_CTL ; \ RCU_CTL_HXTALEN, External High Speed oscillator Enable
: RCU_CTL_HXTALSTB? ( -- 1|0 ) 17 bit RCU_CTL bit@ ; \ RCU_CTL_HXTALSTB, External crystal oscillator HXTAL clock stabilization flag
: RCU_CTL_HXTALBPS ( -- x addr ) 18 bit RCU_CTL ; \ RCU_CTL_HXTALBPS, External crystal oscillator HXTAL clock bypass mode enable
: RCU_CTL_CKMEN ( -- x addr ) 19 bit RCU_CTL ; \ RCU_CTL_CKMEN, HXTAL Clock Monitor Enable
: RCU_CTL_PLLEN ( -- x addr ) 24 bit RCU_CTL ; \ RCU_CTL_PLLEN, PLL enable
: RCU_CTL_PLLSTB ( -- x addr ) 25 bit RCU_CTL ; \ RCU_CTL_PLLSTB, PLL Clock Stabilization Flag
: RCU_CTL_PLL1EN ( -- x addr ) 26 bit RCU_CTL ; \ RCU_CTL_PLL1EN, PLL1 enable
: RCU_CTL_PLL1STB ( -- x addr ) 27 bit RCU_CTL ; \ RCU_CTL_PLL1STB, PLL1 Clock Stabilization Flag
: RCU_CTL_PLL2EN ( -- x addr ) 28 bit RCU_CTL ; \ RCU_CTL_PLL2EN, PLL2 enable
: RCU_CTL_PLL2STB ( -- x addr ) 29 bit RCU_CTL ; \ RCU_CTL_PLL2STB, PLL2 Clock Stabilization Flag

\ RCU_CFG0 (multiple-access)  Reset:0x00000000
: RCU_CFG0_SCS ( %bb -- x addr ) RCU_CFG0 ; \ RCU_CFG0_SCS, System clock switch
: RCU_CFG0_SCSS? ( %bb -- 1|0 ) 2 lshift RCU_CFG0 bit@ ; \ RCU_CFG0_SCSS, System clock switch status
: RCU_CFG0_AHBPSC ( %bbbb -- x addr ) 4 lshift RCU_CFG0 ; \ RCU_CFG0_AHBPSC, AHB prescaler selection
: RCU_CFG0_APB1PSC ( %bbb -- x addr ) 8 lshift RCU_CFG0 ; \ RCU_CFG0_APB1PSC, APB1 prescaler selection
: RCU_CFG0_APB2PSC ( %bbb -- x addr ) 11 lshift RCU_CFG0 ; \ RCU_CFG0_APB2PSC, APB2 prescaler selection
: RCU_CFG0_ADCPSC_1_0 ( %bb -- x addr ) 14 lshift RCU_CFG0 ; \ RCU_CFG0_ADCPSC_1_0, ADC clock prescaler selection
: RCU_CFG0_PLLSEL ( -- x addr ) 16 bit RCU_CFG0 ; \ RCU_CFG0_PLLSEL, PLL Clock Source Selection
: RCU_CFG0_PREDV0_LSB ( -- x addr ) 17 bit RCU_CFG0 ; \ RCU_CFG0_PREDV0_LSB, The LSB of PREDV0 division factor
: RCU_CFG0_PLLMF_3_0 ( %bbbb -- x addr ) 18 lshift RCU_CFG0 ; \ RCU_CFG0_PLLMF_3_0, The PLL clock multiplication factor
: RCU_CFG0_USBFSPSC ( %bb -- x addr ) 22 lshift RCU_CFG0 ; \ RCU_CFG0_USBFSPSC, USBFS clock prescaler selection
: RCU_CFG0_CKOUT0SEL ( %bbbb -- x addr ) 24 lshift RCU_CFG0 ; \ RCU_CFG0_CKOUT0SEL, CKOUT0 Clock Source Selection
: RCU_CFG0_ADCPSC_2 ( -- x addr ) 28 bit RCU_CFG0 ; \ RCU_CFG0_ADCPSC_2, Bit 2 of ADCPSC
: RCU_CFG0_PLLMF_4 ( -- x addr ) 29 bit RCU_CFG0 ; \ RCU_CFG0_PLLMF_4, Bit 4 of PLLMF

\ RCU_INT (multiple-access)  Reset:0x00000000
: RCU_INT_IRC40KSTBIF? ( -- 1|0 ) 0 bit RCU_INT bit@ ; \ RCU_INT_IRC40KSTBIF, IRC40K stabilization interrupt flag
: RCU_INT_LXTALSTBIF? ( -- 1|0 ) 1 bit RCU_INT bit@ ; \ RCU_INT_LXTALSTBIF, LXTAL stabilization interrupt flag
: RCU_INT_IRC8MSTBIF? ( -- 1|0 ) 2 bit RCU_INT bit@ ; \ RCU_INT_IRC8MSTBIF, IRC8M stabilization interrupt flag
: RCU_INT_HXTALSTBIF? ( -- 1|0 ) 3 bit RCU_INT bit@ ; \ RCU_INT_HXTALSTBIF, HXTAL stabilization interrupt flag
: RCU_INT_PLLSTBIF? ( -- 1|0 ) 4 bit RCU_INT bit@ ; \ RCU_INT_PLLSTBIF, PLL stabilization interrupt flag
: RCU_INT_PLL1STBIF? ( -- 1|0 ) 5 bit RCU_INT bit@ ; \ RCU_INT_PLL1STBIF, PLL1 stabilization interrupt flag
: RCU_INT_PLL2STBIF? ( -- 1|0 ) 6 bit RCU_INT bit@ ; \ RCU_INT_PLL2STBIF, PLL2 stabilization interrupt flag
: RCU_INT_CKMIF ( -- x addr ) 7 bit RCU_INT ; \ RCU_INT_CKMIF, HXTAL Clock Stuck Interrupt Flag
: RCU_INT_IRC40KSTBIE ( -- x addr ) 8 bit RCU_INT ; \ RCU_INT_IRC40KSTBIE, IRC40K Stabilization interrupt enable
: RCU_INT_LXTALSTBIE ( -- x addr ) 9 bit RCU_INT ; \ RCU_INT_LXTALSTBIE, LXTAL Stabilization Interrupt Enable
: RCU_INT_IRC8MSTBIE ( -- x addr ) 10 bit RCU_INT ; \ RCU_INT_IRC8MSTBIE, IRC8M Stabilization Interrupt Enable
: RCU_INT_HXTALSTBIE ( -- x addr ) 11 bit RCU_INT ; \ RCU_INT_HXTALSTBIE, HXTAL Stabilization Interrupt Enable
: RCU_INT_PLLSTBIE ( -- x addr ) 12 bit RCU_INT ; \ RCU_INT_PLLSTBIE, PLL Stabilization Interrupt Enable
: RCU_INT_PLL1STBIE ( -- x addr ) 13 bit RCU_INT ; \ RCU_INT_PLL1STBIE, PLL1 Stabilization Interrupt Enable
: RCU_INT_PLL2STBIE ( -- x addr ) 14 bit RCU_INT ; \ RCU_INT_PLL2STBIE, PLL2 Stabilization Interrupt Enable
: RCU_INT_IRC40KSTBIC ( -- x addr ) 16 bit RCU_INT ; \ RCU_INT_IRC40KSTBIC, IRC40K Stabilization Interrupt Clear
: RCU_INT_LXTALSTBIC ( -- x addr ) 17 bit RCU_INT ; \ RCU_INT_LXTALSTBIC, LXTAL Stabilization Interrupt Clear
: RCU_INT_IRC8MSTBIC ( -- x addr ) 18 bit RCU_INT ; \ RCU_INT_IRC8MSTBIC, IRC8M Stabilization Interrupt Clear
: RCU_INT_HXTALSTBIC ( -- x addr ) 19 bit RCU_INT ; \ RCU_INT_HXTALSTBIC, HXTAL Stabilization Interrupt Clear
: RCU_INT_PLLSTBIC ( -- x addr ) 20 bit RCU_INT ; \ RCU_INT_PLLSTBIC, PLL stabilization Interrupt Clear
: RCU_INT_PLL1STBIC ( -- x addr ) 21 bit RCU_INT ; \ RCU_INT_PLL1STBIC, PLL1 stabilization Interrupt Clear
: RCU_INT_PLL2STBIC ( -- x addr ) 22 bit RCU_INT ; \ RCU_INT_PLL2STBIC, PLL2 stabilization Interrupt Clear
: RCU_INT_CKMIC ( -- x addr ) 23 bit RCU_INT ; \ RCU_INT_CKMIC, HXTAL Clock Stuck Interrupt Clear

\ RCU_APB2RST (read-write) Reset:0x00000000
: RCU_APB2RST_AFRST ( -- x addr ) 0 bit RCU_APB2RST ; \ RCU_APB2RST_AFRST, Alternate function I/O reset
: RCU_APB2RST_PARST ( -- x addr ) 2 bit RCU_APB2RST ; \ RCU_APB2RST_PARST, GPIO port A reset
: RCU_APB2RST_PBRST ( -- x addr ) 3 bit RCU_APB2RST ; \ RCU_APB2RST_PBRST, GPIO port B reset
: RCU_APB2RST_PCRST ( -- x addr ) 4 bit RCU_APB2RST ; \ RCU_APB2RST_PCRST, GPIO port C reset
: RCU_APB2RST_PDRST ( -- x addr ) 5 bit RCU_APB2RST ; \ RCU_APB2RST_PDRST, GPIO port D reset
: RCU_APB2RST_PERST ( -- x addr ) 6 bit RCU_APB2RST ; \ RCU_APB2RST_PERST, GPIO port E reset
: RCU_APB2RST_ADC0RST ( -- x addr ) 9 bit RCU_APB2RST ; \ RCU_APB2RST_ADC0RST, ADC0 reset
: RCU_APB2RST_ADC1RST ( -- x addr ) 10 bit RCU_APB2RST ; \ RCU_APB2RST_ADC1RST, ADC1 reset
: RCU_APB2RST_TIMER0RST ( -- x addr ) 11 bit RCU_APB2RST ; \ RCU_APB2RST_TIMER0RST, Timer 0 reset
: RCU_APB2RST_SPI0RST ( -- x addr ) 12 bit RCU_APB2RST ; \ RCU_APB2RST_SPI0RST, SPI0 reset
: RCU_APB2RST_USART0RST ( -- x addr ) 14 bit RCU_APB2RST ; \ RCU_APB2RST_USART0RST, USART0 Reset

\ RCU_APB1RST (read-write) Reset:0x00000000
: RCU_APB1RST_TIMER1RST ( -- x addr ) 0 bit RCU_APB1RST ; \ RCU_APB1RST_TIMER1RST, TIMER1 timer reset
: RCU_APB1RST_TIMER2RST ( -- x addr ) 1 bit RCU_APB1RST ; \ RCU_APB1RST_TIMER2RST, TIMER2 timer reset
: RCU_APB1RST_TIMER3RST ( -- x addr ) 2 bit RCU_APB1RST ; \ RCU_APB1RST_TIMER3RST, TIMER3 timer reset
: RCU_APB1RST_TIMER4RST ( -- x addr ) 3 bit RCU_APB1RST ; \ RCU_APB1RST_TIMER4RST, TIMER4 timer reset
: RCU_APB1RST_TIMER5RST ( -- x addr ) 4 bit RCU_APB1RST ; \ RCU_APB1RST_TIMER5RST, TIMER5 timer reset
: RCU_APB1RST_TIMER6RST ( -- x addr ) 5 bit RCU_APB1RST ; \ RCU_APB1RST_TIMER6RST, TIMER6 timer reset
: RCU_APB1RST_WWDGTRST ( -- x addr ) 11 bit RCU_APB1RST ; \ RCU_APB1RST_WWDGTRST, Window watchdog timer reset
: RCU_APB1RST_SPI1RST ( -- x addr ) 14 bit RCU_APB1RST ; \ RCU_APB1RST_SPI1RST, SPI1 reset
: RCU_APB1RST_SPI2RST ( -- x addr ) 15 bit RCU_APB1RST ; \ RCU_APB1RST_SPI2RST, SPI2 reset
: RCU_APB1RST_USART1RST ( -- x addr ) 17 bit RCU_APB1RST ; \ RCU_APB1RST_USART1RST, USART1 reset
: RCU_APB1RST_USART2RST ( -- x addr ) 18 bit RCU_APB1RST ; \ RCU_APB1RST_USART2RST, USART2 reset
: RCU_APB1RST_UART3RST ( -- x addr ) 19 bit RCU_APB1RST ; \ RCU_APB1RST_UART3RST, UART3 reset
: RCU_APB1RST_UART4RST ( -- x addr ) 20 bit RCU_APB1RST ; \ RCU_APB1RST_UART4RST, UART4 reset
: RCU_APB1RST_I2C0RST ( -- x addr ) 21 bit RCU_APB1RST ; \ RCU_APB1RST_I2C0RST, I2C0 reset
: RCU_APB1RST_I2C1RST ( -- x addr ) 22 bit RCU_APB1RST ; \ RCU_APB1RST_I2C1RST, I2C1 reset
: RCU_APB1RST_CAN0RST ( -- x addr ) 25 bit RCU_APB1RST ; \ RCU_APB1RST_CAN0RST, CAN0 reset
: RCU_APB1RST_CAN1RST ( -- x addr ) 26 bit RCU_APB1RST ; \ RCU_APB1RST_CAN1RST, CAN1 reset
: RCU_APB1RST_BKPIRST ( -- x addr ) 27 bit RCU_APB1RST ; \ RCU_APB1RST_BKPIRST, Backup interface reset
: RCU_APB1RST_PMURST ( -- x addr ) 28 bit RCU_APB1RST ; \ RCU_APB1RST_PMURST, Power control reset
: RCU_APB1RST_DACRST ( -- x addr ) 29 bit RCU_APB1RST ; \ RCU_APB1RST_DACRST, DAC reset

\ RCU_AHBEN (read-write) Reset:0x00000014
: RCU_AHBEN_DMA0EN ( -- x addr ) 0 bit RCU_AHBEN ; \ RCU_AHBEN_DMA0EN, DMA0 clock enable
: RCU_AHBEN_DMA1EN ( -- x addr ) 1 bit RCU_AHBEN ; \ RCU_AHBEN_DMA1EN, DMA1 clock enable
: RCU_AHBEN_SRAMSPEN ( -- x addr ) 2 bit RCU_AHBEN ; \ RCU_AHBEN_SRAMSPEN, SRAM interface clock enable when sleep mode
: RCU_AHBEN_FMCSPEN ( -- x addr ) 4 bit RCU_AHBEN ; \ RCU_AHBEN_FMCSPEN, FMC clock enable when sleep mode
: RCU_AHBEN_CRCEN ( -- x addr ) 6 bit RCU_AHBEN ; \ RCU_AHBEN_CRCEN, CRC clock enable
: RCU_AHBEN_EXMCEN ( -- x addr ) 8 bit RCU_AHBEN ; \ RCU_AHBEN_EXMCEN, EXMC clock enable
: RCU_AHBEN_USBFSEN ( -- x addr ) 12 bit RCU_AHBEN ; \ RCU_AHBEN_USBFSEN, USBFS clock enable

\ RCU_APB2EN (read-write) Reset:0x00000000
: RCU_APB2EN_AFEN ( -- x addr ) 0 bit RCU_APB2EN ; \ RCU_APB2EN_AFEN, Alternate function IO clock enable 
: RCU_APB2EN_PAEN ( -- x addr ) 2 bit RCU_APB2EN ; \ RCU_APB2EN_PAEN, GPIO port A clock enable
: RCU_APB2EN_PBEN ( -- x addr ) 3 bit RCU_APB2EN ; \ RCU_APB2EN_PBEN, GPIO port B clock enable
: RCU_APB2EN_PCEN ( -- x addr ) 4 bit RCU_APB2EN ; \ RCU_APB2EN_PCEN, GPIO port C clock enable
: RCU_APB2EN_PDEN ( -- x addr ) 5 bit RCU_APB2EN ; \ RCU_APB2EN_PDEN, GPIO port D clock enable 
: RCU_APB2EN_PEEN ( -- x addr ) 6 bit RCU_APB2EN ; \ RCU_APB2EN_PEEN, GPIO port E clock enable 
: RCU_APB2EN_ADC0EN ( -- x addr ) 9 bit RCU_APB2EN ; \ RCU_APB2EN_ADC0EN, ADC0 clock enable
: RCU_APB2EN_ADC1EN ( -- x addr ) 10 bit RCU_APB2EN ; \ RCU_APB2EN_ADC1EN, ADC1 clock enable
: RCU_APB2EN_TIMER0EN ( -- x addr ) 11 bit RCU_APB2EN ; \ RCU_APB2EN_TIMER0EN, TIMER0 clock enable 
: RCU_APB2EN_SPI0EN ( -- x addr ) 12 bit RCU_APB2EN ; \ RCU_APB2EN_SPI0EN, SPI0 clock enable
: RCU_APB2EN_USART0EN ( -- x addr ) 14 bit RCU_APB2EN ; \ RCU_APB2EN_USART0EN, USART0 clock enable

\ RCU_APB1EN (read-write) Reset:0x00000000
: RCU_APB1EN_TIMER1EN ( -- x addr ) 0 bit RCU_APB1EN ; \ RCU_APB1EN_TIMER1EN, TIMER1 timer clock enable
: RCU_APB1EN_TIMER2EN ( -- x addr ) 1 bit RCU_APB1EN ; \ RCU_APB1EN_TIMER2EN, TIMER2 timer clock enable
: RCU_APB1EN_TIMER3EN ( -- x addr ) 2 bit RCU_APB1EN ; \ RCU_APB1EN_TIMER3EN, TIMER3 timer clock enable
: RCU_APB1EN_TIMER4EN ( -- x addr ) 3 bit RCU_APB1EN ; \ RCU_APB1EN_TIMER4EN, TIMER4 timer clock enable
: RCU_APB1EN_TIMER5EN ( -- x addr ) 4 bit RCU_APB1EN ; \ RCU_APB1EN_TIMER5EN, TIMER5 timer clock enable
: RCU_APB1EN_TIMER6EN ( -- x addr ) 5 bit RCU_APB1EN ; \ RCU_APB1EN_TIMER6EN, TIMER6 timer clock enable
: RCU_APB1EN_WWDGTEN ( -- x addr ) 11 bit RCU_APB1EN ; \ RCU_APB1EN_WWDGTEN, Window watchdog timer clock enable
: RCU_APB1EN_SPI1EN ( -- x addr ) 14 bit RCU_APB1EN ; \ RCU_APB1EN_SPI1EN, SPI1 clock enable
: RCU_APB1EN_SPI2EN ( -- x addr ) 15 bit RCU_APB1EN ; \ RCU_APB1EN_SPI2EN, SPI2 clock enable
: RCU_APB1EN_USART1EN ( -- x addr ) 17 bit RCU_APB1EN ; \ RCU_APB1EN_USART1EN, USART1 clock enable
: RCU_APB1EN_USART2EN ( -- x addr ) 18 bit RCU_APB1EN ; \ RCU_APB1EN_USART2EN, USART2 clock enable
: RCU_APB1EN_UART3EN ( -- x addr ) 19 bit RCU_APB1EN ; \ RCU_APB1EN_UART3EN, UART3 clock enable
: RCU_APB1EN_UART4EN ( -- x addr ) 20 bit RCU_APB1EN ; \ RCU_APB1EN_UART4EN, UART4 clock enable
: RCU_APB1EN_I2C0EN ( -- x addr ) 21 bit RCU_APB1EN ; \ RCU_APB1EN_I2C0EN, I2C0 clock enable
: RCU_APB1EN_I2C1EN ( -- x addr ) 22 bit RCU_APB1EN ; \ RCU_APB1EN_I2C1EN, I2C1 clock enable
: RCU_APB1EN_CAN0EN ( -- x addr ) 25 bit RCU_APB1EN ; \ RCU_APB1EN_CAN0EN, CAN0 clock enable
: RCU_APB1EN_CAN1EN ( -- x addr ) 26 bit RCU_APB1EN ; \ RCU_APB1EN_CAN1EN, CAN1 clock enable
: RCU_APB1EN_BKPIEN ( -- x addr ) 27 bit RCU_APB1EN ; \ RCU_APB1EN_BKPIEN, Backup interface clock enable 
: RCU_APB1EN_PMUEN ( -- x addr ) 28 bit RCU_APB1EN ; \ RCU_APB1EN_PMUEN, Power control clock enable 
: RCU_APB1EN_DACEN ( -- x addr ) 29 bit RCU_APB1EN ; \ RCU_APB1EN_DACEN, DAC clock enable

\ RCU_BDCTL (multiple-access)  Reset:0x00000018
: RCU_BDCTL_LXTALEN ( -- x addr ) 0 bit RCU_BDCTL ; \ RCU_BDCTL_LXTALEN, LXTAL enable
: RCU_BDCTL_LXTALSTB ( -- x addr ) 1 bit RCU_BDCTL ; \ RCU_BDCTL_LXTALSTB, External low-speed oscillator stabilization
: RCU_BDCTL_LXTALBPS ( -- x addr ) 2 bit RCU_BDCTL ; \ RCU_BDCTL_LXTALBPS, LXTAL bypass mode enable
: RCU_BDCTL_RTCSRC ( %bb -- x addr ) 8 lshift RCU_BDCTL ; \ RCU_BDCTL_RTCSRC, RTC clock entry selection
: RCU_BDCTL_RTCEN ( -- x addr ) 15 bit RCU_BDCTL ; \ RCU_BDCTL_RTCEN, RTC clock enable
: RCU_BDCTL_BKPRST ( -- x addr ) 16 bit RCU_BDCTL ; \ RCU_BDCTL_BKPRST, Backup domain reset

\ RCU_RSTSCK (multiple-access)  Reset:0x0C000000
: RCU_RSTSCK_IRC40KEN ( -- x addr ) 0 bit RCU_RSTSCK ; \ RCU_RSTSCK_IRC40KEN, IRC40K enable
: RCU_RSTSCK_IRC40KSTB ( -- x addr ) 1 bit RCU_RSTSCK ; \ RCU_RSTSCK_IRC40KSTB, IRC40K stabilization
: RCU_RSTSCK_RSTFC? ( -- 1|0 ) 24 bit RCU_RSTSCK bit@ ; \ RCU_RSTSCK_RSTFC, Reset flag clear
: RCU_RSTSCK_EPRSTF? ( -- 1|0 ) 26 bit RCU_RSTSCK bit@ ; \ RCU_RSTSCK_EPRSTF, External PIN reset flag
: RCU_RSTSCK_PORRSTF? ( -- 1|0 ) 27 bit RCU_RSTSCK bit@ ; \ RCU_RSTSCK_PORRSTF, Power reset flag
: RCU_RSTSCK_SWRSTF? ( -- 1|0 ) 28 bit RCU_RSTSCK bit@ ; \ RCU_RSTSCK_SWRSTF, Software reset flag
: RCU_RSTSCK_FWDGTRSTF? ( -- 1|0 ) 29 bit RCU_RSTSCK bit@ ; \ RCU_RSTSCK_FWDGTRSTF, Free Watchdog timer reset flag
: RCU_RSTSCK_WWDGTRSTF? ( -- 1|0 ) 30 bit RCU_RSTSCK bit@ ; \ RCU_RSTSCK_WWDGTRSTF, Window watchdog timer reset flag
: RCU_RSTSCK_LPRSTF? ( -- 1|0 ) 31 bit RCU_RSTSCK bit@ ; \ RCU_RSTSCK_LPRSTF, Low-power reset flag

\ RCU_AHBRST (read-write) Reset:0x00000000
: RCU_AHBRST_USBFSRST ( -- x addr ) 12 bit RCU_AHBRST ; \ RCU_AHBRST_USBFSRST, USBFS reset

\ RCU_CFG1 (read-write) Reset:0x00000000
: RCU_CFG1_PREDV0 ( %bbbb -- x addr ) RCU_CFG1 ; \ RCU_CFG1_PREDV0, PREDV0 division factor
: RCU_CFG1_PREDV1 ( %bbbb -- x addr ) 4 lshift RCU_CFG1 ; \ RCU_CFG1_PREDV1, PREDV1 division factor
: RCU_CFG1_PLL1MF ( %bbbb -- x addr ) 8 lshift RCU_CFG1 ; \ RCU_CFG1_PLL1MF, The PLL1 clock multiplication factor
: RCU_CFG1_PLL2MF ( %bbbb -- x addr ) 12 lshift RCU_CFG1 ; \ RCU_CFG1_PLL2MF, The PLL2 clock multiplication factor
: RCU_CFG1_PREDV0SEL ( -- x addr ) 16 bit RCU_CFG1 ; \ RCU_CFG1_PREDV0SEL, PREDV0 input Clock Source Selection
: RCU_CFG1_I2S1SEL ( -- x addr ) 17 bit RCU_CFG1 ; \ RCU_CFG1_I2S1SEL, I2S1 Clock Source Selection
: RCU_CFG1_I2S2SEL ( -- x addr ) 18 bit RCU_CFG1 ; \ RCU_CFG1_I2S2SEL, I2S2 Clock Source Selection

\ RCU_DSV (multiple-access)  Reset:0x00000000
: RCU_DSV_DSLPVS ( %bb -- x addr ) RCU_DSV ; \ RCU_DSV_DSLPVS, Deep-sleep mode voltage select

\ RTC_INTEN (read-write) Reset:0x00000000
: RTC_INTEN_OVIE ( -- x addr ) 2 bit RTC_INTEN ; \ RTC_INTEN_OVIE, Overflow interrupt enable
: RTC_INTEN_ALRMIE ( -- x addr ) 1 bit RTC_INTEN ; \ RTC_INTEN_ALRMIE, Alarm interrupt enable
: RTC_INTEN_SCIE ( -- x addr ) 0 bit RTC_INTEN ; \ RTC_INTEN_SCIE, Second interrupt

\ RTC_CTL (read-write) Reset:0x00000020
: RTC_CTL_LWOFF ( -- x addr ) 5 bit RTC_CTL ; \ RTC_CTL_LWOFF, Last write operation finished flag
: RTC_CTL_CMF ( -- x addr ) 4 bit RTC_CTL ; \ RTC_CTL_CMF, Configuration mode flag
: RTC_CTL_RSYNF ( -- x addr ) 3 bit RTC_CTL ; \ RTC_CTL_RSYNF, Registers synchronized flag
: RTC_CTL_OVIF ( -- x addr ) 2 bit RTC_CTL ; \ RTC_CTL_OVIF, Overflow interrupt flag
: RTC_CTL_ALRMIF ( -- x addr ) 1 bit RTC_CTL ; \ RTC_CTL_ALRMIF, Alarm interrupt flag
: RTC_CTL_SCIF ( -- x addr ) 0 bit RTC_CTL ; \ RTC_CTL_SCIF, Sencond interrupt flag

\ RTC_PSCH (multiple-access)  Reset:0x00000000
: RTC_PSCH_PSC ( %bbbb -- x addr ) RTC_PSCH ; \ RTC_PSCH_PSC, RTC prescaler value high

\ RTC_PSCL (multiple-access)  Reset:0x00008000
: RTC_PSCL_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) RTC_PSCL ; \ RTC_PSCL_PSC, RTC prescaler value low

\ RTC_DIVH (read-only) Reset:0x00000000
: RTC_DIVH_DIV? ( --  x ) RTC_DIVH @ ; \ RTC_DIVH_DIV, RTC divider value high

\ RTC_DIVL (read-only) Reset:0x00008000
: RTC_DIVL_DIV? ( --  x ) RTC_DIVL @ ; \ RTC_DIVL_DIV, RTC divider value low

\ RTC_CNTH (read-write) Reset:0x00000000
: RTC_CNTH_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) RTC_CNTH ; \ RTC_CNTH_CNT, RTC counter value high

\ RTC_CNTL (read-write) Reset:0x00000000
: RTC_CNTL_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) RTC_CNTL ; \ RTC_CNTL_CNT, RTC counter value low

\ RTC_ALRMH (multiple-access)  Reset:0x0000FFFF
: RTC_ALRMH_ALRM ( %bbbbbbbbbbbbbbbb -- x addr ) RTC_ALRMH ; \ RTC_ALRMH_ALRM, Alarm value high

\ RTC_ALRML (multiple-access)  Reset:0x0000FFFF
: RTC_ALRML_ALRM ( %bbbbbbbbbbbbbbbb -- x addr ) RTC_ALRML ; \ RTC_ALRML_ALRM, alarm value low

\ SPI0_CTL0 (read-write) Reset:0x0000
: SPI0_CTL0_BDEN ( -- x addr ) 15 bit SPI0_CTL0 ; \ SPI0_CTL0_BDEN, Bidirectional   enable
: SPI0_CTL0_BDOEN ( -- x addr ) 14 bit SPI0_CTL0 ; \ SPI0_CTL0_BDOEN, Bidirectional Transmit output enable  
: SPI0_CTL0_CRCEN ( -- x addr ) 13 bit SPI0_CTL0 ; \ SPI0_CTL0_CRCEN, CRC Calculation Enable
: SPI0_CTL0_CRCNT ( -- x addr ) 12 bit SPI0_CTL0 ; \ SPI0_CTL0_CRCNT, CRC Next Transfer
: SPI0_CTL0_FF16 ( -- x addr ) 11 bit SPI0_CTL0 ; \ SPI0_CTL0_FF16, Data frame format
: SPI0_CTL0_RO ( -- x addr ) 10 bit SPI0_CTL0 ; \ SPI0_CTL0_RO, Receive only
: SPI0_CTL0_SWNSSEN ( -- x addr ) 9 bit SPI0_CTL0 ; \ SPI0_CTL0_SWNSSEN, NSS Software Mode Selection
: SPI0_CTL0_SWNSS ( -- x addr ) 8 bit SPI0_CTL0 ; \ SPI0_CTL0_SWNSS, NSS Pin Selection In NSS Software Mode
: SPI0_CTL0_LF ( -- x addr ) 7 bit SPI0_CTL0 ; \ SPI0_CTL0_LF, LSB First Mode
: SPI0_CTL0_SPIEN ( -- x addr ) 6 bit SPI0_CTL0 ; \ SPI0_CTL0_SPIEN, SPI enable
: SPI0_CTL0_PSC ( %bbb -- x addr ) 3 lshift SPI0_CTL0 ; \ SPI0_CTL0_PSC, Master Clock Prescaler Selection
: SPI0_CTL0_MSTMOD ( -- x addr ) 2 bit SPI0_CTL0 ; \ SPI0_CTL0_MSTMOD, Master Mode Enable
: SPI0_CTL0_CKPL ( -- x addr ) 1 bit SPI0_CTL0 ; \ SPI0_CTL0_CKPL, Clock polarity Selection
: SPI0_CTL0_CKPH ( -- x addr ) 0 bit SPI0_CTL0 ; \ SPI0_CTL0_CKPH, Clock Phase Selection

\ SPI0_CTL1 (read-write) Reset:0x0000
: SPI0_CTL1_TBEIE ( -- x addr ) 7 bit SPI0_CTL1 ; \ SPI0_CTL1_TBEIE, Tx buffer empty interrupt  enable
: SPI0_CTL1_RBNEIE ( -- x addr ) 6 bit SPI0_CTL1 ; \ SPI0_CTL1_RBNEIE, RX buffer not empty interrupt  enable
: SPI0_CTL1_ERRIE ( -- x addr ) 5 bit SPI0_CTL1 ; \ SPI0_CTL1_ERRIE, Error interrupt enable
: SPI0_CTL1_TMOD ( -- x addr ) 4 bit SPI0_CTL1 ; \ SPI0_CTL1_TMOD, SPI TI mode enable
: SPI0_CTL1_NSSP ( -- x addr ) 3 bit SPI0_CTL1 ; \ SPI0_CTL1_NSSP, SPI NSS pulse mode enable
: SPI0_CTL1_NSSDRV ( -- x addr ) 2 bit SPI0_CTL1 ; \ SPI0_CTL1_NSSDRV, Drive NSS Output
: SPI0_CTL1_DMATEN ( -- x addr ) 1 bit SPI0_CTL1 ; \ SPI0_CTL1_DMATEN, Transmit Buffer DMA Enable
: SPI0_CTL1_DMAREN ( -- x addr ) 0 bit SPI0_CTL1 ; \ SPI0_CTL1_DMAREN, Rx buffer DMA enable

\ SPI0_STAT (multiple-access)  Reset:0x0002
: SPI0_STAT_FERR ( -- x addr ) 8 bit SPI0_STAT ; \ SPI0_STAT_FERR, Format error
: SPI0_STAT_TRANS ( -- x addr ) 7 bit SPI0_STAT ; \ SPI0_STAT_TRANS, Transmitting On-going Bit
: SPI0_STAT_RXORERR ( -- x addr ) 6 bit SPI0_STAT ; \ SPI0_STAT_RXORERR, Reception Overrun Error Bit
: SPI0_STAT_CONFERR ( -- x addr ) 5 bit SPI0_STAT ; \ SPI0_STAT_CONFERR, SPI Configuration error
: SPI0_STAT_CRCERR ( -- x addr ) 4 bit SPI0_STAT ; \ SPI0_STAT_CRCERR, SPI CRC Error Bit
: SPI0_STAT_TXURERR ( -- x addr ) 3 bit SPI0_STAT ; \ SPI0_STAT_TXURERR, Transmission underrun error bit
: SPI0_STAT_I2SCH ( -- x addr ) 2 bit SPI0_STAT ; \ SPI0_STAT_I2SCH, I2S channel side
: SPI0_STAT_TBE ( -- x addr ) 1 bit SPI0_STAT ; \ SPI0_STAT_TBE, Transmit Buffer Empty
: SPI0_STAT_RBNE ( -- x addr ) 0 bit SPI0_STAT ; \ SPI0_STAT_RBNE, Receive Buffer Not Empty

\ SPI0_DATA (read-write) Reset:0x0000
: SPI0_DATA_SPI_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) SPI0_DATA ; \ SPI0_DATA_SPI_DATA, Data transfer register

\ SPI0_CRCPOLY (read-write) Reset:0x0007
: SPI0_CRCPOLY_CRCPOLY ( %bbbbbbbbbbbbbbbb -- x addr ) SPI0_CRCPOLY ; \ SPI0_CRCPOLY_CRCPOLY, CRC polynomial value

\ SPI0_RCRC (read-only) Reset:0x0000
: SPI0_RCRC_RCRC? ( --  x ) SPI0_RCRC @ ; \ SPI0_RCRC_RCRC, RX CRC value

\ SPI0_TCRC (read-only) Reset:0x0000
: SPI0_TCRC_TCRC? ( --  x ) SPI0_TCRC @ ; \ SPI0_TCRC_TCRC, Tx CRC value

\ SPI0_I2SCTL (read-write) Reset:0x0000
: SPI0_I2SCTL_I2SSEL ( -- x addr ) 11 bit SPI0_I2SCTL ; \ SPI0_I2SCTL_I2SSEL, I2S mode selection
: SPI0_I2SCTL_I2SEN ( -- x addr ) 10 bit SPI0_I2SCTL ; \ SPI0_I2SCTL_I2SEN, I2S Enable
: SPI0_I2SCTL_I2SOPMOD ( %bb -- x addr ) 8 lshift SPI0_I2SCTL ; \ SPI0_I2SCTL_I2SOPMOD, I2S operation mode
: SPI0_I2SCTL_PCMSMOD ( -- x addr ) 7 bit SPI0_I2SCTL ; \ SPI0_I2SCTL_PCMSMOD, PCM frame synchronization mode
: SPI0_I2SCTL_I2SSTD ( %bb -- x addr ) 4 lshift SPI0_I2SCTL ; \ SPI0_I2SCTL_I2SSTD, I2S standard selection
: SPI0_I2SCTL_CKPL ( -- x addr ) 3 bit SPI0_I2SCTL ; \ SPI0_I2SCTL_CKPL, Idle state clock polarity
: SPI0_I2SCTL_DTLEN ( %bb -- x addr ) 1 lshift SPI0_I2SCTL ; \ SPI0_I2SCTL_DTLEN, Data length
: SPI0_I2SCTL_CHLEN ( -- x addr ) 0 bit SPI0_I2SCTL ; \ SPI0_I2SCTL_CHLEN, Channel length number of bits per audio  channel

\ SPI0_I2SPSC (read-write) Reset:0x0002
: SPI0_I2SPSC_MCKOEN ( -- x addr ) 9 bit SPI0_I2SPSC ; \ SPI0_I2SPSC_MCKOEN, I2S_MCK output enable
: SPI0_I2SPSC_OF ( -- x addr ) 8 bit SPI0_I2SPSC ; \ SPI0_I2SPSC_OF, Odd factor for the  prescaler
: SPI0_I2SPSC_DIV ( %bbbbbbbb -- x addr ) SPI0_I2SPSC ; \ SPI0_I2SPSC_DIV, Dividing factor for the prescaler

\ SPI1_CTL0 (read-write) Reset:0x0000
: SPI1_CTL0_BDEN ( -- x addr ) 15 bit SPI1_CTL0 ; \ SPI1_CTL0_BDEN, Bidirectional   enable
: SPI1_CTL0_BDOEN ( -- x addr ) 14 bit SPI1_CTL0 ; \ SPI1_CTL0_BDOEN, Bidirectional Transmit output enable  
: SPI1_CTL0_CRCEN ( -- x addr ) 13 bit SPI1_CTL0 ; \ SPI1_CTL0_CRCEN, CRC Calculation Enable
: SPI1_CTL0_CRCNT ( -- x addr ) 12 bit SPI1_CTL0 ; \ SPI1_CTL0_CRCNT, CRC Next Transfer
: SPI1_CTL0_FF16 ( -- x addr ) 11 bit SPI1_CTL0 ; \ SPI1_CTL0_FF16, Data frame format
: SPI1_CTL0_RO ( -- x addr ) 10 bit SPI1_CTL0 ; \ SPI1_CTL0_RO, Receive only
: SPI1_CTL0_SWNSSEN ( -- x addr ) 9 bit SPI1_CTL0 ; \ SPI1_CTL0_SWNSSEN, NSS Software Mode Selection
: SPI1_CTL0_SWNSS ( -- x addr ) 8 bit SPI1_CTL0 ; \ SPI1_CTL0_SWNSS, NSS Pin Selection In NSS Software Mode
: SPI1_CTL0_LF ( -- x addr ) 7 bit SPI1_CTL0 ; \ SPI1_CTL0_LF, LSB First Mode
: SPI1_CTL0_SPIEN ( -- x addr ) 6 bit SPI1_CTL0 ; \ SPI1_CTL0_SPIEN, SPI enable
: SPI1_CTL0_PSC ( %bbb -- x addr ) 3 lshift SPI1_CTL0 ; \ SPI1_CTL0_PSC, Master Clock Prescaler Selection
: SPI1_CTL0_MSTMOD ( -- x addr ) 2 bit SPI1_CTL0 ; \ SPI1_CTL0_MSTMOD, Master Mode Enable
: SPI1_CTL0_CKPL ( -- x addr ) 1 bit SPI1_CTL0 ; \ SPI1_CTL0_CKPL, Clock polarity Selection
: SPI1_CTL0_CKPH ( -- x addr ) 0 bit SPI1_CTL0 ; \ SPI1_CTL0_CKPH, Clock Phase Selection

\ SPI1_CTL1 (read-write) Reset:0x0000
: SPI1_CTL1_TBEIE ( -- x addr ) 7 bit SPI1_CTL1 ; \ SPI1_CTL1_TBEIE, Tx buffer empty interrupt  enable
: SPI1_CTL1_RBNEIE ( -- x addr ) 6 bit SPI1_CTL1 ; \ SPI1_CTL1_RBNEIE, RX buffer not empty interrupt  enable
: SPI1_CTL1_ERRIE ( -- x addr ) 5 bit SPI1_CTL1 ; \ SPI1_CTL1_ERRIE, Error interrupt enable
: SPI1_CTL1_TMOD ( -- x addr ) 4 bit SPI1_CTL1 ; \ SPI1_CTL1_TMOD, SPI TI mode enable
: SPI1_CTL1_NSSP ( -- x addr ) 3 bit SPI1_CTL1 ; \ SPI1_CTL1_NSSP, SPI NSS pulse mode enable
: SPI1_CTL1_NSSDRV ( -- x addr ) 2 bit SPI1_CTL1 ; \ SPI1_CTL1_NSSDRV, Drive NSS Output
: SPI1_CTL1_DMATEN ( -- x addr ) 1 bit SPI1_CTL1 ; \ SPI1_CTL1_DMATEN, Transmit Buffer DMA Enable
: SPI1_CTL1_DMAREN ( -- x addr ) 0 bit SPI1_CTL1 ; \ SPI1_CTL1_DMAREN, Rx buffer DMA enable

\ SPI1_STAT (multiple-access)  Reset:0x0002
: SPI1_STAT_FERR ( -- x addr ) 8 bit SPI1_STAT ; \ SPI1_STAT_FERR, Format error
: SPI1_STAT_TRANS ( -- x addr ) 7 bit SPI1_STAT ; \ SPI1_STAT_TRANS, Transmitting On-going Bit
: SPI1_STAT_RXORERR ( -- x addr ) 6 bit SPI1_STAT ; \ SPI1_STAT_RXORERR, Reception Overrun Error Bit
: SPI1_STAT_CONFERR ( -- x addr ) 5 bit SPI1_STAT ; \ SPI1_STAT_CONFERR, SPI Configuration error
: SPI1_STAT_CRCERR ( -- x addr ) 4 bit SPI1_STAT ; \ SPI1_STAT_CRCERR, SPI CRC Error Bit
: SPI1_STAT_TXURERR ( -- x addr ) 3 bit SPI1_STAT ; \ SPI1_STAT_TXURERR, Transmission underrun error bit
: SPI1_STAT_I2SCH ( -- x addr ) 2 bit SPI1_STAT ; \ SPI1_STAT_I2SCH, I2S channel side
: SPI1_STAT_TBE ( -- x addr ) 1 bit SPI1_STAT ; \ SPI1_STAT_TBE, Transmit Buffer Empty
: SPI1_STAT_RBNE ( -- x addr ) 0 bit SPI1_STAT ; \ SPI1_STAT_RBNE, Receive Buffer Not Empty

\ SPI1_DATA (read-write) Reset:0x0000
: SPI1_DATA_SPI_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) SPI1_DATA ; \ SPI1_DATA_SPI_DATA, Data transfer register

\ SPI1_CRCPOLY (read-write) Reset:0x0007
: SPI1_CRCPOLY_CRCPOLY ( %bbbbbbbbbbbbbbbb -- x addr ) SPI1_CRCPOLY ; \ SPI1_CRCPOLY_CRCPOLY, CRC polynomial value

\ SPI1_RCRC (read-only) Reset:0x0000
: SPI1_RCRC_RCRC? ( --  x ) SPI1_RCRC @ ; \ SPI1_RCRC_RCRC, RX CRC value

\ SPI1_TCRC (read-only) Reset:0x0000
: SPI1_TCRC_TCRC? ( --  x ) SPI1_TCRC @ ; \ SPI1_TCRC_TCRC, Tx CRC value

\ SPI1_I2SCTL (read-write) Reset:0x0000
: SPI1_I2SCTL_I2SSEL ( -- x addr ) 11 bit SPI1_I2SCTL ; \ SPI1_I2SCTL_I2SSEL, I2S mode selection
: SPI1_I2SCTL_I2SEN ( -- x addr ) 10 bit SPI1_I2SCTL ; \ SPI1_I2SCTL_I2SEN, I2S Enable
: SPI1_I2SCTL_I2SOPMOD ( %bb -- x addr ) 8 lshift SPI1_I2SCTL ; \ SPI1_I2SCTL_I2SOPMOD, I2S operation mode
: SPI1_I2SCTL_PCMSMOD ( -- x addr ) 7 bit SPI1_I2SCTL ; \ SPI1_I2SCTL_PCMSMOD, PCM frame synchronization mode
: SPI1_I2SCTL_I2SSTD ( %bb -- x addr ) 4 lshift SPI1_I2SCTL ; \ SPI1_I2SCTL_I2SSTD, I2S standard selection
: SPI1_I2SCTL_CKPL ( -- x addr ) 3 bit SPI1_I2SCTL ; \ SPI1_I2SCTL_CKPL, Idle state clock polarity
: SPI1_I2SCTL_DTLEN ( %bb -- x addr ) 1 lshift SPI1_I2SCTL ; \ SPI1_I2SCTL_DTLEN, Data length
: SPI1_I2SCTL_CHLEN ( -- x addr ) 0 bit SPI1_I2SCTL ; \ SPI1_I2SCTL_CHLEN, Channel length number of bits per audio  channel

\ SPI1_I2SPSC (read-write) Reset:0x0002
: SPI1_I2SPSC_MCKOEN ( -- x addr ) 9 bit SPI1_I2SPSC ; \ SPI1_I2SPSC_MCKOEN, I2S_MCK output enable
: SPI1_I2SPSC_OF ( -- x addr ) 8 bit SPI1_I2SPSC ; \ SPI1_I2SPSC_OF, Odd factor for the  prescaler
: SPI1_I2SPSC_DIV ( %bbbbbbbb -- x addr ) SPI1_I2SPSC ; \ SPI1_I2SPSC_DIV, Dividing factor for the prescaler

\ SPI2_CTL0 (read-write) Reset:0x0000
: SPI2_CTL0_BDEN ( -- x addr ) 15 bit SPI2_CTL0 ; \ SPI2_CTL0_BDEN, Bidirectional   enable
: SPI2_CTL0_BDOEN ( -- x addr ) 14 bit SPI2_CTL0 ; \ SPI2_CTL0_BDOEN, Bidirectional Transmit output enable  
: SPI2_CTL0_CRCEN ( -- x addr ) 13 bit SPI2_CTL0 ; \ SPI2_CTL0_CRCEN, CRC Calculation Enable
: SPI2_CTL0_CRCNT ( -- x addr ) 12 bit SPI2_CTL0 ; \ SPI2_CTL0_CRCNT, CRC Next Transfer
: SPI2_CTL0_FF16 ( -- x addr ) 11 bit SPI2_CTL0 ; \ SPI2_CTL0_FF16, Data frame format
: SPI2_CTL0_RO ( -- x addr ) 10 bit SPI2_CTL0 ; \ SPI2_CTL0_RO, Receive only
: SPI2_CTL0_SWNSSEN ( -- x addr ) 9 bit SPI2_CTL0 ; \ SPI2_CTL0_SWNSSEN, NSS Software Mode Selection
: SPI2_CTL0_SWNSS ( -- x addr ) 8 bit SPI2_CTL0 ; \ SPI2_CTL0_SWNSS, NSS Pin Selection In NSS Software Mode
: SPI2_CTL0_LF ( -- x addr ) 7 bit SPI2_CTL0 ; \ SPI2_CTL0_LF, LSB First Mode
: SPI2_CTL0_SPIEN ( -- x addr ) 6 bit SPI2_CTL0 ; \ SPI2_CTL0_SPIEN, SPI enable
: SPI2_CTL0_PSC ( %bbb -- x addr ) 3 lshift SPI2_CTL0 ; \ SPI2_CTL0_PSC, Master Clock Prescaler Selection
: SPI2_CTL0_MSTMOD ( -- x addr ) 2 bit SPI2_CTL0 ; \ SPI2_CTL0_MSTMOD, Master Mode Enable
: SPI2_CTL0_CKPL ( -- x addr ) 1 bit SPI2_CTL0 ; \ SPI2_CTL0_CKPL, Clock polarity Selection
: SPI2_CTL0_CKPH ( -- x addr ) 0 bit SPI2_CTL0 ; \ SPI2_CTL0_CKPH, Clock Phase Selection

\ SPI2_CTL1 (read-write) Reset:0x0000
: SPI2_CTL1_TBEIE ( -- x addr ) 7 bit SPI2_CTL1 ; \ SPI2_CTL1_TBEIE, Tx buffer empty interrupt  enable
: SPI2_CTL1_RBNEIE ( -- x addr ) 6 bit SPI2_CTL1 ; \ SPI2_CTL1_RBNEIE, RX buffer not empty interrupt  enable
: SPI2_CTL1_ERRIE ( -- x addr ) 5 bit SPI2_CTL1 ; \ SPI2_CTL1_ERRIE, Error interrupt enable
: SPI2_CTL1_TMOD ( -- x addr ) 4 bit SPI2_CTL1 ; \ SPI2_CTL1_TMOD, SPI TI mode enable
: SPI2_CTL1_NSSP ( -- x addr ) 3 bit SPI2_CTL1 ; \ SPI2_CTL1_NSSP, SPI NSS pulse mode enable
: SPI2_CTL1_NSSDRV ( -- x addr ) 2 bit SPI2_CTL1 ; \ SPI2_CTL1_NSSDRV, Drive NSS Output
: SPI2_CTL1_DMATEN ( -- x addr ) 1 bit SPI2_CTL1 ; \ SPI2_CTL1_DMATEN, Transmit Buffer DMA Enable
: SPI2_CTL1_DMAREN ( -- x addr ) 0 bit SPI2_CTL1 ; \ SPI2_CTL1_DMAREN, Rx buffer DMA enable

\ SPI2_STAT (multiple-access)  Reset:0x0002
: SPI2_STAT_FERR ( -- x addr ) 8 bit SPI2_STAT ; \ SPI2_STAT_FERR, Format error
: SPI2_STAT_TRANS ( -- x addr ) 7 bit SPI2_STAT ; \ SPI2_STAT_TRANS, Transmitting On-going Bit
: SPI2_STAT_RXORERR ( -- x addr ) 6 bit SPI2_STAT ; \ SPI2_STAT_RXORERR, Reception Overrun Error Bit
: SPI2_STAT_CONFERR ( -- x addr ) 5 bit SPI2_STAT ; \ SPI2_STAT_CONFERR, SPI Configuration error
: SPI2_STAT_CRCERR ( -- x addr ) 4 bit SPI2_STAT ; \ SPI2_STAT_CRCERR, SPI CRC Error Bit
: SPI2_STAT_TXURERR ( -- x addr ) 3 bit SPI2_STAT ; \ SPI2_STAT_TXURERR, Transmission underrun error bit
: SPI2_STAT_I2SCH ( -- x addr ) 2 bit SPI2_STAT ; \ SPI2_STAT_I2SCH, I2S channel side
: SPI2_STAT_TBE ( -- x addr ) 1 bit SPI2_STAT ; \ SPI2_STAT_TBE, Transmit Buffer Empty
: SPI2_STAT_RBNE ( -- x addr ) 0 bit SPI2_STAT ; \ SPI2_STAT_RBNE, Receive Buffer Not Empty

\ SPI2_DATA (read-write) Reset:0x0000
: SPI2_DATA_SPI_DATA ( %bbbbbbbbbbbbbbbb -- x addr ) SPI2_DATA ; \ SPI2_DATA_SPI_DATA, Data transfer register

\ SPI2_CRCPOLY (read-write) Reset:0x0007
: SPI2_CRCPOLY_CRCPOLY ( %bbbbbbbbbbbbbbbb -- x addr ) SPI2_CRCPOLY ; \ SPI2_CRCPOLY_CRCPOLY, CRC polynomial value

\ SPI2_RCRC (read-only) Reset:0x0000
: SPI2_RCRC_RCRC? ( --  x ) SPI2_RCRC @ ; \ SPI2_RCRC_RCRC, RX CRC value

\ SPI2_TCRC (read-only) Reset:0x0000
: SPI2_TCRC_TCRC? ( --  x ) SPI2_TCRC @ ; \ SPI2_TCRC_TCRC, Tx CRC value

\ SPI2_I2SCTL (read-write) Reset:0x0000
: SPI2_I2SCTL_I2SSEL ( -- x addr ) 11 bit SPI2_I2SCTL ; \ SPI2_I2SCTL_I2SSEL, I2S mode selection
: SPI2_I2SCTL_I2SEN ( -- x addr ) 10 bit SPI2_I2SCTL ; \ SPI2_I2SCTL_I2SEN, I2S Enable
: SPI2_I2SCTL_I2SOPMOD ( %bb -- x addr ) 8 lshift SPI2_I2SCTL ; \ SPI2_I2SCTL_I2SOPMOD, I2S operation mode
: SPI2_I2SCTL_PCMSMOD ( -- x addr ) 7 bit SPI2_I2SCTL ; \ SPI2_I2SCTL_PCMSMOD, PCM frame synchronization mode
: SPI2_I2SCTL_I2SSTD ( %bb -- x addr ) 4 lshift SPI2_I2SCTL ; \ SPI2_I2SCTL_I2SSTD, I2S standard selection
: SPI2_I2SCTL_CKPL ( -- x addr ) 3 bit SPI2_I2SCTL ; \ SPI2_I2SCTL_CKPL, Idle state clock polarity
: SPI2_I2SCTL_DTLEN ( %bb -- x addr ) 1 lshift SPI2_I2SCTL ; \ SPI2_I2SCTL_DTLEN, Data length
: SPI2_I2SCTL_CHLEN ( -- x addr ) 0 bit SPI2_I2SCTL ; \ SPI2_I2SCTL_CHLEN, Channel length number of bits per audio  channel

\ SPI2_I2SPSC (read-write) Reset:0x0002
: SPI2_I2SPSC_MCKOEN ( -- x addr ) 9 bit SPI2_I2SPSC ; \ SPI2_I2SPSC_MCKOEN, I2S_MCK output enable
: SPI2_I2SPSC_OF ( -- x addr ) 8 bit SPI2_I2SPSC ; \ SPI2_I2SPSC_OF, Odd factor for the  prescaler
: SPI2_I2SPSC_DIV ( %bbbbbbbb -- x addr ) SPI2_I2SPSC ; \ SPI2_I2SPSC_DIV, Dividing factor for the prescaler

\ TIMER0_CTL0 (read-write) Reset:0x0000
: TIMER0_CTL0_CKDIV ( %bb -- x addr ) 8 lshift TIMER0_CTL0 ; \ TIMER0_CTL0_CKDIV, Clock division
: TIMER0_CTL0_ARSE ( -- x addr ) 7 bit TIMER0_CTL0 ; \ TIMER0_CTL0_ARSE, Auto-reload shadow enable
: TIMER0_CTL0_CAM ( %bb -- x addr ) 5 lshift TIMER0_CTL0 ; \ TIMER0_CTL0_CAM, Counter aligns mode  selection
: TIMER0_CTL0_DIR ( -- x addr ) 4 bit TIMER0_CTL0 ; \ TIMER0_CTL0_DIR, Direction
: TIMER0_CTL0_SPM ( -- x addr ) 3 bit TIMER0_CTL0 ; \ TIMER0_CTL0_SPM, Single pulse mode
: TIMER0_CTL0_UPS ( -- x addr ) 2 bit TIMER0_CTL0 ; \ TIMER0_CTL0_UPS, Update source
: TIMER0_CTL0_UPDIS ( -- x addr ) 1 bit TIMER0_CTL0 ; \ TIMER0_CTL0_UPDIS, Update disable
: TIMER0_CTL0_CEN ( -- x addr ) 0 bit TIMER0_CTL0 ; \ TIMER0_CTL0_CEN, Counter enable

\ TIMER0_CTL1 (read-write) Reset:0x0000
: TIMER0_CTL1_ISO3 ( -- x addr ) 14 bit TIMER0_CTL1 ; \ TIMER0_CTL1_ISO3, Idle state of channel 3 output
: TIMER0_CTL1_ISO2N ( -- x addr ) 13 bit TIMER0_CTL1 ; \ TIMER0_CTL1_ISO2N, Idle state of channel 2 complementary output
: TIMER0_CTL1_ISO2 ( -- x addr ) 12 bit TIMER0_CTL1 ; \ TIMER0_CTL1_ISO2, Idle state of channel 2 output
: TIMER0_CTL1_ISO1N ( -- x addr ) 11 bit TIMER0_CTL1 ; \ TIMER0_CTL1_ISO1N, Idle state of channel 1 complementary output
: TIMER0_CTL1_ISO1 ( -- x addr ) 10 bit TIMER0_CTL1 ; \ TIMER0_CTL1_ISO1, Idle state of channel 1 output
: TIMER0_CTL1_ISO0N ( -- x addr ) 9 bit TIMER0_CTL1 ; \ TIMER0_CTL1_ISO0N, Idle state of channel 0 complementary output
: TIMER0_CTL1_ISO0 ( -- x addr ) 8 bit TIMER0_CTL1 ; \ TIMER0_CTL1_ISO0, Idle state of channel 0 output
: TIMER0_CTL1_TI0S ( -- x addr ) 7 bit TIMER0_CTL1 ; \ TIMER0_CTL1_TI0S, Channel 0 trigger input selection
: TIMER0_CTL1_MMC ( %bbb -- x addr ) 4 lshift TIMER0_CTL1 ; \ TIMER0_CTL1_MMC, Master mode control
: TIMER0_CTL1_DMAS ( -- x addr ) 3 bit TIMER0_CTL1 ; \ TIMER0_CTL1_DMAS, DMA request source selection
: TIMER0_CTL1_CCUC ( -- x addr ) 2 bit TIMER0_CTL1 ; \ TIMER0_CTL1_CCUC, Commutation control shadow register update control
: TIMER0_CTL1_CCSE ( -- x addr ) 0 bit TIMER0_CTL1 ; \ TIMER0_CTL1_CCSE, Commutation control shadow enable

\ TIMER0_SMCFG (read-write) Reset:0x0000
: TIMER0_SMCFG_ETP ( -- x addr ) 15 bit TIMER0_SMCFG ; \ TIMER0_SMCFG_ETP, External trigger polarity
: TIMER0_SMCFG_SMC1 ( -- x addr ) 14 bit TIMER0_SMCFG ; \ TIMER0_SMCFG_SMC1, Part of SMC for enable External clock mode1
: TIMER0_SMCFG_ETPSC ( %bb -- x addr ) 12 lshift TIMER0_SMCFG ; \ TIMER0_SMCFG_ETPSC, External trigger prescaler
: TIMER0_SMCFG_ETFC ( %bbbb -- x addr ) 8 lshift TIMER0_SMCFG ; \ TIMER0_SMCFG_ETFC, External trigger filter control
: TIMER0_SMCFG_MSM ( -- x addr ) 7 bit TIMER0_SMCFG ; \ TIMER0_SMCFG_MSM, Master/Slave mode
: TIMER0_SMCFG_TRGS ( %bbb -- x addr ) 4 lshift TIMER0_SMCFG ; \ TIMER0_SMCFG_TRGS, Trigger selection
: TIMER0_SMCFG_SMC ( %bbb -- x addr ) TIMER0_SMCFG ; \ TIMER0_SMCFG_SMC, Slave mode selection

\ TIMER0_DMAINTEN (read-write) Reset:0x0000
: TIMER0_DMAINTEN_TRGDEN ( -- x addr ) 14 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_TRGDEN, Trigger DMA request enable
: TIMER0_DMAINTEN_CMTDEN ( -- x addr ) 13 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CMTDEN, Commutation DMA request enable
: TIMER0_DMAINTEN_CH3DEN ( -- x addr ) 12 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CH3DEN, Channel 3 capture/compare DMA request enable
: TIMER0_DMAINTEN_CH2DEN ( -- x addr ) 11 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CH2DEN, Channel 2 capture/compare DMA request enable
: TIMER0_DMAINTEN_CH1DEN ( -- x addr ) 10 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CH1DEN, Channel 1 capture/compare DMA request enable
: TIMER0_DMAINTEN_CH0DEN ( -- x addr ) 9 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CH0DEN, Channel 0 capture/compare DMA request enable
: TIMER0_DMAINTEN_UPDEN ( -- x addr ) 8 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_UPDEN, Update DMA request enable
: TIMER0_DMAINTEN_BRKIE ( -- x addr ) 7 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_BRKIE, Break interrupt enable
: TIMER0_DMAINTEN_TRGIE ( -- x addr ) 6 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_TRGIE, Trigger interrupt enable
: TIMER0_DMAINTEN_CMTIE ( -- x addr ) 5 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CMTIE, commutation interrupt enable
: TIMER0_DMAINTEN_CH3IE ( -- x addr ) 4 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CH3IE, Channel 3 capture/compare interrupt enable
: TIMER0_DMAINTEN_CH2IE ( -- x addr ) 3 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CH2IE, Channel 2 capture/compare interrupt enable
: TIMER0_DMAINTEN_CH1IE ( -- x addr ) 2 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CH1IE, Channel 1 capture/compare interrupt enable
: TIMER0_DMAINTEN_CH0IE ( -- x addr ) 1 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_CH0IE, Channel 0 capture/compare interrupt enable
: TIMER0_DMAINTEN_UPIE ( -- x addr ) 0 bit TIMER0_DMAINTEN ; \ TIMER0_DMAINTEN_UPIE, Update interrupt enable

\ TIMER0_INTF (read-write) Reset:0x0000
: TIMER0_INTF_CH3OF ( -- x addr ) 12 bit TIMER0_INTF ; \ TIMER0_INTF_CH3OF, Channel 3 over capture flag
: TIMER0_INTF_CH2OF ( -- x addr ) 11 bit TIMER0_INTF ; \ TIMER0_INTF_CH2OF, Channel 2 over capture flag
: TIMER0_INTF_CH1OF ( -- x addr ) 10 bit TIMER0_INTF ; \ TIMER0_INTF_CH1OF, Channel 1 over capture flag
: TIMER0_INTF_CH0OF ( -- x addr ) 9 bit TIMER0_INTF ; \ TIMER0_INTF_CH0OF, Channel 0 over capture flag
: TIMER0_INTF_BRKIF ( -- x addr ) 7 bit TIMER0_INTF ; \ TIMER0_INTF_BRKIF, Break interrupt flag
: TIMER0_INTF_TRGIF ( -- x addr ) 6 bit TIMER0_INTF ; \ TIMER0_INTF_TRGIF, Trigger interrupt flag
: TIMER0_INTF_CMTIF ( -- x addr ) 5 bit TIMER0_INTF ; \ TIMER0_INTF_CMTIF, Channel commutation interrupt flag
: TIMER0_INTF_CH3IF ( -- x addr ) 4 bit TIMER0_INTF ; \ TIMER0_INTF_CH3IF, Channel 3 capture/compare interrupt flag
: TIMER0_INTF_CH2IF ( -- x addr ) 3 bit TIMER0_INTF ; \ TIMER0_INTF_CH2IF,  Channel 2 capture/compare interrupt flag
: TIMER0_INTF_CH1IF ( -- x addr ) 2 bit TIMER0_INTF ; \ TIMER0_INTF_CH1IF, Channel 1 capture/compare interrupt flag
: TIMER0_INTF_CH0IF ( -- x addr ) 1 bit TIMER0_INTF ; \ TIMER0_INTF_CH0IF, Channel 0 capture/compare interrupt flag
: TIMER0_INTF_UPIF ( -- x addr ) 0 bit TIMER0_INTF ; \ TIMER0_INTF_UPIF, Update interrupt flag

\ TIMER0_SWEVG (write-only) Reset:0x0000
: TIMER0_SWEVG_BRKG ( -- x addr ) 7 bit TIMER0_SWEVG ; \ TIMER0_SWEVG_BRKG, Break event generation
: TIMER0_SWEVG_TRGG ( -- x addr ) 6 bit TIMER0_SWEVG ; \ TIMER0_SWEVG_TRGG, Trigger event generation
: TIMER0_SWEVG_CMTG ( -- x addr ) 5 bit TIMER0_SWEVG ; \ TIMER0_SWEVG_CMTG, Channel commutation event generation
: TIMER0_SWEVG_CH3G ( -- x addr ) 4 bit TIMER0_SWEVG ; \ TIMER0_SWEVG_CH3G, Channel 3 capture or compare event generation
: TIMER0_SWEVG_CH2G ( -- x addr ) 3 bit TIMER0_SWEVG ; \ TIMER0_SWEVG_CH2G, Channel 2 capture or compare event generation
: TIMER0_SWEVG_CH1G ( -- x addr ) 2 bit TIMER0_SWEVG ; \ TIMER0_SWEVG_CH1G, Channel 1 capture or compare event generation
: TIMER0_SWEVG_CH0G ( -- x addr ) 1 bit TIMER0_SWEVG ; \ TIMER0_SWEVG_CH0G, Channel 0 capture or compare event generation
: TIMER0_SWEVG_UPG ( -- x addr ) 0 bit TIMER0_SWEVG ; \ TIMER0_SWEVG_UPG, Update event generation

\ TIMER0_CHCTL0_Output (read-write) Reset:0x0000
: TIMER0_CHCTL0_Output_CH1COMCEN ( -- x addr ) 15 bit TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH1COMCEN, Channel 1 output compare clear enable
: TIMER0_CHCTL0_Output_CH1COMCTL ( %bbb -- x addr ) 12 lshift TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH1COMCTL, Channel 1 compare output control
: TIMER0_CHCTL0_Output_CH1COMSEN ( -- x addr ) 11 bit TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH1COMSEN, Channel 1 output compare shadow enable
: TIMER0_CHCTL0_Output_CH1COMFEN ( -- x addr ) 10 bit TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH1COMFEN, Channel 1 output compare fast enable
: TIMER0_CHCTL0_Output_CH1MS ( %bb -- x addr ) 8 lshift TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH1MS, Channel 1 mode selection
: TIMER0_CHCTL0_Output_CH0COMCEN ( -- x addr ) 7 bit TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH0COMCEN, Channel 0 output compare clear enable
: TIMER0_CHCTL0_Output_CH0COMCTL ( %bbb -- x addr ) 4 lshift TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH0COMCTL, Channel 0 compare output control
: TIMER0_CHCTL0_Output_CH0COMSEN ( -- x addr ) 3 bit TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH0COMSEN, Channel 0 compare output shadow enable
: TIMER0_CHCTL0_Output_CH0COMFEN ( -- x addr ) 2 bit TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH0COMFEN, Channel 0 output compare fast enable
: TIMER0_CHCTL0_Output_CH0MS ( %bb -- x addr ) TIMER0_CHCTL0_Output ; \ TIMER0_CHCTL0_Output_CH0MS, Channel 0 I/O mode selection

\ TIMER0_CHCTL0_Input (read-write) Reset:0x0000
: TIMER0_CHCTL0_Input_CH1CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER0_CHCTL0_Input ; \ TIMER0_CHCTL0_Input_CH1CAPFLT, Channel 1 input capture filter control
: TIMER0_CHCTL0_Input_CH1CAPPSC ( %bb -- x addr ) 10 lshift TIMER0_CHCTL0_Input ; \ TIMER0_CHCTL0_Input_CH1CAPPSC, Channel 1 input capture prescaler
: TIMER0_CHCTL0_Input_CH1MS ( %bb -- x addr ) 8 lshift TIMER0_CHCTL0_Input ; \ TIMER0_CHCTL0_Input_CH1MS, Channel 1 mode selection
: TIMER0_CHCTL0_Input_CH0CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER0_CHCTL0_Input ; \ TIMER0_CHCTL0_Input_CH0CAPFLT, Channel 0 input capture filter control
: TIMER0_CHCTL0_Input_CH0CAPPSC ( %bb -- x addr ) 2 lshift TIMER0_CHCTL0_Input ; \ TIMER0_CHCTL0_Input_CH0CAPPSC, Channel 0 input capture prescaler
: TIMER0_CHCTL0_Input_CH0MS ( %bb -- x addr ) TIMER0_CHCTL0_Input ; \ TIMER0_CHCTL0_Input_CH0MS, Channel 0 mode selection

\ TIMER0_CHCTL1_Output (read-write) Reset:0x0000
: TIMER0_CHCTL1_Output_CH3COMCEN ( -- x addr ) 15 bit TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH3COMCEN, Channel 3 output compare clear enable
: TIMER0_CHCTL1_Output_CH3COMCTL ( %bbb -- x addr ) 12 lshift TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH3COMCTL, Channel 3 compare output control
: TIMER0_CHCTL1_Output_CH3COMSEN ( -- x addr ) 11 bit TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH3COMSEN, Channel 3 output compare shadow enable
: TIMER0_CHCTL1_Output_CH3COMFEN ( -- x addr ) 10 bit TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH3COMFEN, Channel 3 output compare fast enable
: TIMER0_CHCTL1_Output_CH3MS ( %bb -- x addr ) 8 lshift TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH3MS, Channel 3 mode selection
: TIMER0_CHCTL1_Output_CH2COMCEN ( -- x addr ) 7 bit TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH2COMCEN, Channel 2 output compare clear enable
: TIMER0_CHCTL1_Output_CH2COMCTL ( %bbb -- x addr ) 4 lshift TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH2COMCTL, Channel 2 compare output control
: TIMER0_CHCTL1_Output_CH2COMSEN ( -- x addr ) 3 bit TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH2COMSEN, Channel 2 compare output shadow enable
: TIMER0_CHCTL1_Output_CH2COMFEN ( -- x addr ) 2 bit TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH2COMFEN, Channel 2 output compare fast enable
: TIMER0_CHCTL1_Output_CH2MS ( %bb -- x addr ) TIMER0_CHCTL1_Output ; \ TIMER0_CHCTL1_Output_CH2MS, Channel 2 I/O mode selection

\ TIMER0_CHCTL1_Input (read-write) Reset:0x0000
: TIMER0_CHCTL1_Input_CH3CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER0_CHCTL1_Input ; \ TIMER0_CHCTL1_Input_CH3CAPFLT, Channel 3 input capture filter control
: TIMER0_CHCTL1_Input_CH3CAPPSC ( %bb -- x addr ) 10 lshift TIMER0_CHCTL1_Input ; \ TIMER0_CHCTL1_Input_CH3CAPPSC, Channel 3 input capture prescaler
: TIMER0_CHCTL1_Input_CH3MS ( %bb -- x addr ) 8 lshift TIMER0_CHCTL1_Input ; \ TIMER0_CHCTL1_Input_CH3MS, Channel 3 mode selection
: TIMER0_CHCTL1_Input_CH2CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER0_CHCTL1_Input ; \ TIMER0_CHCTL1_Input_CH2CAPFLT, Channel 2 input capture filter control
: TIMER0_CHCTL1_Input_CH2CAPPSC ( %bb -- x addr ) 2 lshift TIMER0_CHCTL1_Input ; \ TIMER0_CHCTL1_Input_CH2CAPPSC, Channel 2 input capture prescaler
: TIMER0_CHCTL1_Input_CH2MS ( %bb -- x addr ) TIMER0_CHCTL1_Input ; \ TIMER0_CHCTL1_Input_CH2MS, Channel 2 mode selection

\ TIMER0_CHCTL2 (read-write) Reset:0x0000
: TIMER0_CHCTL2_CH3P ( -- x addr ) 13 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH3P, Channel 3 capture/compare function polarity
: TIMER0_CHCTL2_CH3EN ( -- x addr ) 12 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH3EN, Channel 3 capture/compare function enable
: TIMER0_CHCTL2_CH2NP ( -- x addr ) 11 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH2NP, Channel 2 complementary output polarity
: TIMER0_CHCTL2_CH2NEN ( -- x addr ) 10 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH2NEN, Channel 2 complementary output enable
: TIMER0_CHCTL2_CH2P ( -- x addr ) 9 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH2P, Channel 2 capture/compare function polarity
: TIMER0_CHCTL2_CH2EN ( -- x addr ) 8 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH2EN, Channel 2 capture/compare function enable
: TIMER0_CHCTL2_CH1NP ( -- x addr ) 7 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH1NP, Channel 1 complementary output polarity
: TIMER0_CHCTL2_CH1NEN ( -- x addr ) 6 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH1NEN, Channel 1 complementary output enable
: TIMER0_CHCTL2_CH1P ( -- x addr ) 5 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH1P, Channel 1 capture/compare function polarity
: TIMER0_CHCTL2_CH1EN ( -- x addr ) 4 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH1EN, Channel 1 capture/compare function enable
: TIMER0_CHCTL2_CH0NP ( -- x addr ) 3 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH0NP, Channel 0 complementary output polarity
: TIMER0_CHCTL2_CH0NEN ( -- x addr ) 2 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH0NEN, Channel 0 complementary output enable
: TIMER0_CHCTL2_CH0P ( -- x addr ) 1 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH0P, Channel 0 capture/compare function polarity
: TIMER0_CHCTL2_CH0EN ( -- x addr ) 0 bit TIMER0_CHCTL2 ; \ TIMER0_CHCTL2_CH0EN, Channel 0 capture/compare function enable

\ TIMER0_CNT (read-write) Reset:0x0000
: TIMER0_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER0_CNT ; \ TIMER0_CNT_CNT, current counter value

\ TIMER0_PSC (read-write) Reset:0x0000
: TIMER0_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER0_PSC ; \ TIMER0_PSC_PSC, Prescaler value of the counter clock

\ TIMER0_CAR (read-write) Reset:0x0000
: TIMER0_CAR_CARL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER0_CAR ; \ TIMER0_CAR_CARL, Counter auto reload value

\ TIMER0_CREP (read-write) Reset:0x0000
: TIMER0_CREP_CREP ( %bbbbbbbb -- x addr ) TIMER0_CREP ; \ TIMER0_CREP_CREP, Counter repetition value

\ TIMER0_CH0CV (read-write) Reset:0x0000
: TIMER0_CH0CV_CH0VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER0_CH0CV ; \ TIMER0_CH0CV_CH0VAL, Capture or compare value of channel0

\ TIMER0_CH1CV (read-write) Reset:0x0000
: TIMER0_CH1CV_CH1VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER0_CH1CV ; \ TIMER0_CH1CV_CH1VAL, Capture or compare value of channel1

\ TIMER0_CH2CV (read-write) Reset:0x0000
: TIMER0_CH2CV_CH2VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER0_CH2CV ; \ TIMER0_CH2CV_CH2VAL, Capture or compare value of channel 2

\ TIMER0_CH3CV (read-write) Reset:0x0000
: TIMER0_CH3CV_CH3VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER0_CH3CV ; \ TIMER0_CH3CV_CH3VAL, Capture or compare value of channel 3

\ TIMER0_CCHP (read-write) Reset:0x0000
: TIMER0_CCHP_POEN ( -- x addr ) 15 bit TIMER0_CCHP ; \ TIMER0_CCHP_POEN, Primary output enable
: TIMER0_CCHP_OAEN ( -- x addr ) 14 bit TIMER0_CCHP ; \ TIMER0_CCHP_OAEN, Output automatic enable
: TIMER0_CCHP_BRKP ( -- x addr ) 13 bit TIMER0_CCHP ; \ TIMER0_CCHP_BRKP, Break polarity
: TIMER0_CCHP_BRKEN ( -- x addr ) 12 bit TIMER0_CCHP ; \ TIMER0_CCHP_BRKEN, Break enable
: TIMER0_CCHP_ROS ( -- x addr ) 11 bit TIMER0_CCHP ; \ TIMER0_CCHP_ROS, Run mode off-state configure
: TIMER0_CCHP_IOS ( -- x addr ) 10 bit TIMER0_CCHP ; \ TIMER0_CCHP_IOS, Idle mode off-state configure
: TIMER0_CCHP_PROT ( %bb -- x addr ) 8 lshift TIMER0_CCHP ; \ TIMER0_CCHP_PROT, Complementary register protect control
: TIMER0_CCHP_DTCFG ( %bbbbbbbb -- x addr ) TIMER0_CCHP ; \ TIMER0_CCHP_DTCFG, Dead time configure

\ TIMER0_DMACFG (read-write) Reset:0x0000
: TIMER0_DMACFG_DMATC ( %bbbbb -- x addr ) 8 lshift TIMER0_DMACFG ; \ TIMER0_DMACFG_DMATC, DMA transfer count
: TIMER0_DMACFG_DMATA ( %bbbbb -- x addr ) TIMER0_DMACFG ; \ TIMER0_DMACFG_DMATA, DMA transfer access start address

\ TIMER0_DMATB (read-write) Reset:0x0000
: TIMER0_DMATB_DMATB ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER0_DMATB ; \ TIMER0_DMATB_DMATB, DMA transfer buffer

\ TIMER1_CTL0 (read-write) Reset:0x0000
: TIMER1_CTL0_CKDIV ( %bb -- x addr ) 8 lshift TIMER1_CTL0 ; \ TIMER1_CTL0_CKDIV, Clock division
: TIMER1_CTL0_ARSE ( -- x addr ) 7 bit TIMER1_CTL0 ; \ TIMER1_CTL0_ARSE, Auto-reload shadow enable
: TIMER1_CTL0_CAM ( %bb -- x addr ) 5 lshift TIMER1_CTL0 ; \ TIMER1_CTL0_CAM, Counter aligns mode selection
: TIMER1_CTL0_DIR ( -- x addr ) 4 bit TIMER1_CTL0 ; \ TIMER1_CTL0_DIR, Direction
: TIMER1_CTL0_SPM ( -- x addr ) 3 bit TIMER1_CTL0 ; \ TIMER1_CTL0_SPM, Single pulse mode
: TIMER1_CTL0_UPS ( -- x addr ) 2 bit TIMER1_CTL0 ; \ TIMER1_CTL0_UPS, Update source
: TIMER1_CTL0_UPDIS ( -- x addr ) 1 bit TIMER1_CTL0 ; \ TIMER1_CTL0_UPDIS, Update disable
: TIMER1_CTL0_CEN ( -- x addr ) 0 bit TIMER1_CTL0 ; \ TIMER1_CTL0_CEN, Counter enable

\ TIMER1_CTL1 (read-write) Reset:0x0000
: TIMER1_CTL1_TI0S ( -- x addr ) 7 bit TIMER1_CTL1 ; \ TIMER1_CTL1_TI0S, Channel 0 trigger input selection
: TIMER1_CTL1_MMC ( %bbb -- x addr ) 4 lshift TIMER1_CTL1 ; \ TIMER1_CTL1_MMC, Master mode control
: TIMER1_CTL1_DMAS ( -- x addr ) 3 bit TIMER1_CTL1 ; \ TIMER1_CTL1_DMAS, DMA request source selection

\ TIMER1_SMCFG (read-write) Reset:0x0000
: TIMER1_SMCFG_ETP ( -- x addr ) 15 bit TIMER1_SMCFG ; \ TIMER1_SMCFG_ETP, External trigger polarity
: TIMER1_SMCFG_SMC1 ( -- x addr ) 14 bit TIMER1_SMCFG ; \ TIMER1_SMCFG_SMC1, Part of SMC for enable External clock mode1
: TIMER1_SMCFG_ETPSC ( %bb -- x addr ) 12 lshift TIMER1_SMCFG ; \ TIMER1_SMCFG_ETPSC, External trigger prescaler
: TIMER1_SMCFG_ETFC ( %bbbb -- x addr ) 8 lshift TIMER1_SMCFG ; \ TIMER1_SMCFG_ETFC, External trigger filter control
: TIMER1_SMCFG_MSM ( -- x addr ) 7 bit TIMER1_SMCFG ; \ TIMER1_SMCFG_MSM, Master-slave mode
: TIMER1_SMCFG_TRGS ( %bbb -- x addr ) 4 lshift TIMER1_SMCFG ; \ TIMER1_SMCFG_TRGS, Trigger selection
: TIMER1_SMCFG_SMC ( %bbb -- x addr ) TIMER1_SMCFG ; \ TIMER1_SMCFG_SMC, Slave mode control

\ TIMER1_DMAINTEN (read-write) Reset:0x0000
: TIMER1_DMAINTEN_TRGDEN ( -- x addr ) 14 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_TRGDEN, Trigger DMA request enable
: TIMER1_DMAINTEN_CH3DEN ( -- x addr ) 12 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_CH3DEN, Channel 3 capture/compare DMA request enable
: TIMER1_DMAINTEN_CH2DEN ( -- x addr ) 11 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_CH2DEN, Channel 2 capture/compare DMA request enable
: TIMER1_DMAINTEN_CH1DEN ( -- x addr ) 10 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_CH1DEN, Channel 1 capture/compare DMA request enable
: TIMER1_DMAINTEN_CH0DEN ( -- x addr ) 9 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_CH0DEN, Channel 0 capture/compare DMA request enable
: TIMER1_DMAINTEN_UPDEN ( -- x addr ) 8 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_UPDEN, Update DMA request enable
: TIMER1_DMAINTEN_TRGIE ( -- x addr ) 6 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_TRGIE, Trigger interrupt enable
: TIMER1_DMAINTEN_CH3IE ( -- x addr ) 4 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_CH3IE, Channel 3 capture/compare interrupt enable
: TIMER1_DMAINTEN_CH2IE ( -- x addr ) 3 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_CH2IE, Channel 2 capture/compare interrupt enable
: TIMER1_DMAINTEN_CH1IE ( -- x addr ) 2 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_CH1IE, Channel 1 capture/compare interrupt enable
: TIMER1_DMAINTEN_CH0IE ( -- x addr ) 1 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_CH0IE, Channel 0 capture/compare interrupt enable
: TIMER1_DMAINTEN_UPIE ( -- x addr ) 0 bit TIMER1_DMAINTEN ; \ TIMER1_DMAINTEN_UPIE, Update interrupt enable

\ TIMER1_INTF (read-write) Reset:0x0000
: TIMER1_INTF_CH3OF ( -- x addr ) 12 bit TIMER1_INTF ; \ TIMER1_INTF_CH3OF, Channel 3 over capture flag
: TIMER1_INTF_CH2OF ( -- x addr ) 11 bit TIMER1_INTF ; \ TIMER1_INTF_CH2OF, Channel 2 over capture flag
: TIMER1_INTF_CH1OF ( -- x addr ) 10 bit TIMER1_INTF ; \ TIMER1_INTF_CH1OF, Channel 1 over capture flag
: TIMER1_INTF_CH0OF ( -- x addr ) 9 bit TIMER1_INTF ; \ TIMER1_INTF_CH0OF, Channel 0 over capture flag
: TIMER1_INTF_TRGIF ( -- x addr ) 6 bit TIMER1_INTF ; \ TIMER1_INTF_TRGIF, Trigger interrupt flag
: TIMER1_INTF_CH3IF ( -- x addr ) 4 bit TIMER1_INTF ; \ TIMER1_INTF_CH3IF, Channel 3 capture/compare interrupt enable
: TIMER1_INTF_CH2IF ( -- x addr ) 3 bit TIMER1_INTF ; \ TIMER1_INTF_CH2IF, Channel 2 capture/compare interrupt enable
: TIMER1_INTF_CH1IF ( -- x addr ) 2 bit TIMER1_INTF ; \ TIMER1_INTF_CH1IF, Channel 1 capture/compare interrupt flag
: TIMER1_INTF_CH0IF ( -- x addr ) 1 bit TIMER1_INTF ; \ TIMER1_INTF_CH0IF, Channel 0 capture/compare interrupt flag
: TIMER1_INTF_UPIF ( -- x addr ) 0 bit TIMER1_INTF ; \ TIMER1_INTF_UPIF, Update interrupt flag

\ TIMER1_SWEVG (write-only) Reset:0x0000
: TIMER1_SWEVG_TRGG ( -- x addr ) 6 bit TIMER1_SWEVG ; \ TIMER1_SWEVG_TRGG, Trigger event generation
: TIMER1_SWEVG_CH3G ( -- x addr ) 4 bit TIMER1_SWEVG ; \ TIMER1_SWEVG_CH3G, Channel 3 capture or compare event generation
: TIMER1_SWEVG_CH2G ( -- x addr ) 3 bit TIMER1_SWEVG ; \ TIMER1_SWEVG_CH2G, Channel 2 capture or compare event generation
: TIMER1_SWEVG_CH1G ( -- x addr ) 2 bit TIMER1_SWEVG ; \ TIMER1_SWEVG_CH1G, Channel 1 capture or compare event generation
: TIMER1_SWEVG_CH0G ( -- x addr ) 1 bit TIMER1_SWEVG ; \ TIMER1_SWEVG_CH0G, Channel 0 capture or compare event generation
: TIMER1_SWEVG_UPG ( -- x addr ) 0 bit TIMER1_SWEVG ; \ TIMER1_SWEVG_UPG, Update generation

\ TIMER1_CHCTL0_Output (read-write) Reset:0x0000
: TIMER1_CHCTL0_Output_CH1COMCEN ( -- x addr ) 15 bit TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH1COMCEN, Channel 1 output compare clear enable
: TIMER1_CHCTL0_Output_CH1COMCTL ( %bbb -- x addr ) 12 lshift TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH1COMCTL, Channel 1 compare output control
: TIMER1_CHCTL0_Output_CH1COMSEN ( -- x addr ) 11 bit TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH1COMSEN, Channel 1 output compare shadow enable
: TIMER1_CHCTL0_Output_CH1COMFEN ( -- x addr ) 10 bit TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH1COMFEN, Channel 1 output compare fast enable
: TIMER1_CHCTL0_Output_CH1MS ( %bb -- x addr ) 8 lshift TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH1MS, Channel 1 mode selection
: TIMER1_CHCTL0_Output_CH0COMCEN ( -- x addr ) 7 bit TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH0COMCEN, Channel 0 output compare clear enable
: TIMER1_CHCTL0_Output_CH0COMCTL ( %bbb -- x addr ) 4 lshift TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH0COMCTL,  Channel 0 compare output control
: TIMER1_CHCTL0_Output_CH0COMSEN ( -- x addr ) 3 bit TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH0COMSEN, Channel 0 compare output shadow enable
: TIMER1_CHCTL0_Output_CH0COMFEN ( -- x addr ) 2 bit TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH0COMFEN, Channel 0 output compare fast enable
: TIMER1_CHCTL0_Output_CH0MS ( %bb -- x addr ) TIMER1_CHCTL0_Output ; \ TIMER1_CHCTL0_Output_CH0MS, Channel 0 I/O mode selection

\ TIMER1_CHCTL0_Input (read-write) Reset:0x00000000
: TIMER1_CHCTL0_Input_CH1CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER1_CHCTL0_Input ; \ TIMER1_CHCTL0_Input_CH1CAPFLT, Channel 1 input capture filter control
: TIMER1_CHCTL0_Input_CH1CAPPSC ( %bb -- x addr ) 10 lshift TIMER1_CHCTL0_Input ; \ TIMER1_CHCTL0_Input_CH1CAPPSC, Channel 1 input capture prescaler
: TIMER1_CHCTL0_Input_CH1MS ( %bb -- x addr ) 8 lshift TIMER1_CHCTL0_Input ; \ TIMER1_CHCTL0_Input_CH1MS, Channel 1 mode selection
: TIMER1_CHCTL0_Input_CH0CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER1_CHCTL0_Input ; \ TIMER1_CHCTL0_Input_CH0CAPFLT, Channel 0 input capture filter control
: TIMER1_CHCTL0_Input_CH0CAPPSC ( %bb -- x addr ) 2 lshift TIMER1_CHCTL0_Input ; \ TIMER1_CHCTL0_Input_CH0CAPPSC, Channel 0 input capture prescaler
: TIMER1_CHCTL0_Input_CH0MS ( %bb -- x addr ) TIMER1_CHCTL0_Input ; \ TIMER1_CHCTL0_Input_CH0MS, Channel 0 mode selection

\ TIMER1_CHCTL1_Output (read-write) Reset:0x0000
: TIMER1_CHCTL1_Output_CH3COMCEN ( -- x addr ) 15 bit TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH3COMCEN, Channel 3 output compare clear enable
: TIMER1_CHCTL1_Output_CH3COMCTL ( %bbb -- x addr ) 12 lshift TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH3COMCTL, Channel 3 compare output control
: TIMER1_CHCTL1_Output_CH3COMSEN ( -- x addr ) 11 bit TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH3COMSEN, Channel 3 output compare shadow enable
: TIMER1_CHCTL1_Output_CH3COMFEN ( -- x addr ) 10 bit TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH3COMFEN, Channel 3 output compare fast enable
: TIMER1_CHCTL1_Output_CH3MS ( %bb -- x addr ) 8 lshift TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH3MS, Channel 3 mode selection
: TIMER1_CHCTL1_Output_CH2COMCEN ( -- x addr ) 7 bit TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH2COMCEN, Channel 2 output compare clear enable
: TIMER1_CHCTL1_Output_CH2COMCTL ( %bbb -- x addr ) 4 lshift TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH2COMCTL, Channel 2 compare output control
: TIMER1_CHCTL1_Output_CH2COMSEN ( -- x addr ) 3 bit TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH2COMSEN, Channel 2 compare output shadow enable
: TIMER1_CHCTL1_Output_CH2COMFEN ( -- x addr ) 2 bit TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH2COMFEN, Channel 2 output compare fast enable
: TIMER1_CHCTL1_Output_CH2MS ( %bb -- x addr ) TIMER1_CHCTL1_Output ; \ TIMER1_CHCTL1_Output_CH2MS, Channel 2 I/O mode selection

\ TIMER1_CHCTL1_Input (read-write) Reset:0x0000
: TIMER1_CHCTL1_Input_CH3CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER1_CHCTL1_Input ; \ TIMER1_CHCTL1_Input_CH3CAPFLT, Channel 3 input capture filter control
: TIMER1_CHCTL1_Input_CH3CAPPSC ( %bb -- x addr ) 10 lshift TIMER1_CHCTL1_Input ; \ TIMER1_CHCTL1_Input_CH3CAPPSC, Channel 3 input capture prescaler
: TIMER1_CHCTL1_Input_CH3MS ( %bb -- x addr ) 8 lshift TIMER1_CHCTL1_Input ; \ TIMER1_CHCTL1_Input_CH3MS, Channel 3 mode selection
: TIMER1_CHCTL1_Input_CH2CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER1_CHCTL1_Input ; \ TIMER1_CHCTL1_Input_CH2CAPFLT, Channel 2 input capture filter control
: TIMER1_CHCTL1_Input_CH2CAPPSC ( %bb -- x addr ) 2 lshift TIMER1_CHCTL1_Input ; \ TIMER1_CHCTL1_Input_CH2CAPPSC, Channel 2 input capture prescaler
: TIMER1_CHCTL1_Input_CH2MS ( %bb -- x addr ) TIMER1_CHCTL1_Input ; \ TIMER1_CHCTL1_Input_CH2MS, Channel 2 mode selection

\ TIMER1_CHCTL2 (read-write) Reset:0x0000
: TIMER1_CHCTL2_CH3P ( -- x addr ) 13 bit TIMER1_CHCTL2 ; \ TIMER1_CHCTL2_CH3P, Channel 3 capture/compare function polarity
: TIMER1_CHCTL2_CH3EN ( -- x addr ) 12 bit TIMER1_CHCTL2 ; \ TIMER1_CHCTL2_CH3EN, Channel 3 capture/compare function enable
: TIMER1_CHCTL2_CH2P ( -- x addr ) 9 bit TIMER1_CHCTL2 ; \ TIMER1_CHCTL2_CH2P, Channel 2 capture/compare function polarity
: TIMER1_CHCTL2_CH2EN ( -- x addr ) 8 bit TIMER1_CHCTL2 ; \ TIMER1_CHCTL2_CH2EN, Channel 2 capture/compare function enable
: TIMER1_CHCTL2_CH1P ( -- x addr ) 5 bit TIMER1_CHCTL2 ; \ TIMER1_CHCTL2_CH1P, Channel 1 capture/compare function polarity
: TIMER1_CHCTL2_CH1EN ( -- x addr ) 4 bit TIMER1_CHCTL2 ; \ TIMER1_CHCTL2_CH1EN, Channel 1 capture/compare function enable
: TIMER1_CHCTL2_CH0P ( -- x addr ) 1 bit TIMER1_CHCTL2 ; \ TIMER1_CHCTL2_CH0P, Channel 0 capture/compare function polarity
: TIMER1_CHCTL2_CH0EN ( -- x addr ) 0 bit TIMER1_CHCTL2 ; \ TIMER1_CHCTL2_CH0EN, Channel 0 capture/compare function enable

\ TIMER1_CNT (read-write) Reset:0x0000
: TIMER1_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER1_CNT ; \ TIMER1_CNT_CNT, counter value

\ TIMER1_PSC (read-write) Reset:0x0000
: TIMER1_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER1_PSC ; \ TIMER1_PSC_PSC, Prescaler value of the counter clock

\ TIMER1_CAR (read-write) Reset:0x0000
: TIMER1_CAR_CARL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER1_CAR ; \ TIMER1_CAR_CARL, Counter auto reload value

\ TIMER1_CH0CV (read-write) Reset:0x00000000
: TIMER1_CH0CV_CH0VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER1_CH0CV ; \ TIMER1_CH0CV_CH0VAL, Capture or compare value of channel 0

\ TIMER1_CH1CV (read-write) Reset:0x00000000
: TIMER1_CH1CV_CH1VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER1_CH1CV ; \ TIMER1_CH1CV_CH1VAL, Capture or compare value of channel1

\ TIMER1_CH2CV (read-write) Reset:0x00000000
: TIMER1_CH2CV_CH2VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER1_CH2CV ; \ TIMER1_CH2CV_CH2VAL, Capture or compare value of channel 2

\ TIMER1_CH3CV (read-write) Reset:0x00000000
: TIMER1_CH3CV_CH3VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER1_CH3CV ; \ TIMER1_CH3CV_CH3VAL, Capture or compare value of channel 3

\ TIMER1_DMACFG (read-write) Reset:0x0000
: TIMER1_DMACFG_DMATC ( %bbbbb -- x addr ) 8 lshift TIMER1_DMACFG ; \ TIMER1_DMACFG_DMATC, DMA transfer count
: TIMER1_DMACFG_DMATA ( %bbbbb -- x addr ) TIMER1_DMACFG ; \ TIMER1_DMACFG_DMATA, DMA transfer access start address

\ TIMER1_DMATB (read-write) Reset:0x0000
: TIMER1_DMATB_DMATB ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER1_DMATB ; \ TIMER1_DMATB_DMATB, DMA transfer buffer

\ TIMER2_CTL0 (read-write) Reset:0x0000
: TIMER2_CTL0_CKDIV ( %bb -- x addr ) 8 lshift TIMER2_CTL0 ; \ TIMER2_CTL0_CKDIV, Clock division
: TIMER2_CTL0_ARSE ( -- x addr ) 7 bit TIMER2_CTL0 ; \ TIMER2_CTL0_ARSE, Auto-reload shadow enable
: TIMER2_CTL0_CAM ( %bb -- x addr ) 5 lshift TIMER2_CTL0 ; \ TIMER2_CTL0_CAM, Counter aligns mode selection
: TIMER2_CTL0_DIR ( -- x addr ) 4 bit TIMER2_CTL0 ; \ TIMER2_CTL0_DIR, Direction
: TIMER2_CTL0_SPM ( -- x addr ) 3 bit TIMER2_CTL0 ; \ TIMER2_CTL0_SPM, Single pulse mode
: TIMER2_CTL0_UPS ( -- x addr ) 2 bit TIMER2_CTL0 ; \ TIMER2_CTL0_UPS, Update source
: TIMER2_CTL0_UPDIS ( -- x addr ) 1 bit TIMER2_CTL0 ; \ TIMER2_CTL0_UPDIS, Update disable
: TIMER2_CTL0_CEN ( -- x addr ) 0 bit TIMER2_CTL0 ; \ TIMER2_CTL0_CEN, Counter enable

\ TIMER2_CTL1 (read-write) Reset:0x0000
: TIMER2_CTL1_TI0S ( -- x addr ) 7 bit TIMER2_CTL1 ; \ TIMER2_CTL1_TI0S, Channel 0 trigger input selection
: TIMER2_CTL1_MMC ( %bbb -- x addr ) 4 lshift TIMER2_CTL1 ; \ TIMER2_CTL1_MMC, Master mode control
: TIMER2_CTL1_DMAS ( -- x addr ) 3 bit TIMER2_CTL1 ; \ TIMER2_CTL1_DMAS, DMA request source selection

\ TIMER2_SMCFG (read-write) Reset:0x0000
: TIMER2_SMCFG_ETP ( -- x addr ) 15 bit TIMER2_SMCFG ; \ TIMER2_SMCFG_ETP, External trigger polarity
: TIMER2_SMCFG_SMC1 ( -- x addr ) 14 bit TIMER2_SMCFG ; \ TIMER2_SMCFG_SMC1, Part of SMC for enable External clock mode1
: TIMER2_SMCFG_ETPSC ( %bb -- x addr ) 12 lshift TIMER2_SMCFG ; \ TIMER2_SMCFG_ETPSC, External trigger prescaler
: TIMER2_SMCFG_ETFC ( %bbbb -- x addr ) 8 lshift TIMER2_SMCFG ; \ TIMER2_SMCFG_ETFC, External trigger filter control
: TIMER2_SMCFG_MSM ( -- x addr ) 7 bit TIMER2_SMCFG ; \ TIMER2_SMCFG_MSM, Master-slave mode
: TIMER2_SMCFG_TRGS ( %bbb -- x addr ) 4 lshift TIMER2_SMCFG ; \ TIMER2_SMCFG_TRGS, Trigger selection
: TIMER2_SMCFG_SMC ( %bbb -- x addr ) TIMER2_SMCFG ; \ TIMER2_SMCFG_SMC, Slave mode control

\ TIMER2_DMAINTEN (read-write) Reset:0x0000
: TIMER2_DMAINTEN_TRGDEN ( -- x addr ) 14 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_TRGDEN, Trigger DMA request enable
: TIMER2_DMAINTEN_CH3DEN ( -- x addr ) 12 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_CH3DEN, Channel 3 capture/compare DMA request enable
: TIMER2_DMAINTEN_CH2DEN ( -- x addr ) 11 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_CH2DEN, Channel 2 capture/compare DMA request enable
: TIMER2_DMAINTEN_CH1DEN ( -- x addr ) 10 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_CH1DEN, Channel 1 capture/compare DMA request enable
: TIMER2_DMAINTEN_CH0DEN ( -- x addr ) 9 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_CH0DEN, Channel 0 capture/compare DMA request enable
: TIMER2_DMAINTEN_UPDEN ( -- x addr ) 8 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_UPDEN, Update DMA request enable
: TIMER2_DMAINTEN_TRGIE ( -- x addr ) 6 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_TRGIE, Trigger interrupt enable
: TIMER2_DMAINTEN_CH3IE ( -- x addr ) 4 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_CH3IE, Channel 3 capture/compare interrupt enable
: TIMER2_DMAINTEN_CH2IE ( -- x addr ) 3 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_CH2IE, Channel 2 capture/compare interrupt enable
: TIMER2_DMAINTEN_CH1IE ( -- x addr ) 2 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_CH1IE, Channel 1 capture/compare interrupt enable
: TIMER2_DMAINTEN_CH0IE ( -- x addr ) 1 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_CH0IE, Channel 0 capture/compare interrupt enable
: TIMER2_DMAINTEN_UPIE ( -- x addr ) 0 bit TIMER2_DMAINTEN ; \ TIMER2_DMAINTEN_UPIE, Update interrupt enable

\ TIMER2_INTF (read-write) Reset:0x0000
: TIMER2_INTF_CH3OF ( -- x addr ) 12 bit TIMER2_INTF ; \ TIMER2_INTF_CH3OF, Channel 3 over capture flag
: TIMER2_INTF_CH2OF ( -- x addr ) 11 bit TIMER2_INTF ; \ TIMER2_INTF_CH2OF, Channel 2 over capture flag
: TIMER2_INTF_CH1OF ( -- x addr ) 10 bit TIMER2_INTF ; \ TIMER2_INTF_CH1OF, Channel 1 over capture flag
: TIMER2_INTF_CH0OF ( -- x addr ) 9 bit TIMER2_INTF ; \ TIMER2_INTF_CH0OF, Channel 0 over capture flag
: TIMER2_INTF_TRGIF ( -- x addr ) 6 bit TIMER2_INTF ; \ TIMER2_INTF_TRGIF, Trigger interrupt flag
: TIMER2_INTF_CH3IF ( -- x addr ) 4 bit TIMER2_INTF ; \ TIMER2_INTF_CH3IF, Channel 3 capture/compare interrupt enable
: TIMER2_INTF_CH2IF ( -- x addr ) 3 bit TIMER2_INTF ; \ TIMER2_INTF_CH2IF, Channel 2 capture/compare interrupt enable
: TIMER2_INTF_CH1IF ( -- x addr ) 2 bit TIMER2_INTF ; \ TIMER2_INTF_CH1IF, Channel 1 capture/compare interrupt flag
: TIMER2_INTF_CH0IF ( -- x addr ) 1 bit TIMER2_INTF ; \ TIMER2_INTF_CH0IF, Channel 0 capture/compare interrupt flag
: TIMER2_INTF_UPIF ( -- x addr ) 0 bit TIMER2_INTF ; \ TIMER2_INTF_UPIF, Update interrupt flag

\ TIMER2_SWEVG (write-only) Reset:0x0000
: TIMER2_SWEVG_TRGG ( -- x addr ) 6 bit TIMER2_SWEVG ; \ TIMER2_SWEVG_TRGG, Trigger event generation
: TIMER2_SWEVG_CH3G ( -- x addr ) 4 bit TIMER2_SWEVG ; \ TIMER2_SWEVG_CH3G, Channel 3 capture or compare event generation
: TIMER2_SWEVG_CH2G ( -- x addr ) 3 bit TIMER2_SWEVG ; \ TIMER2_SWEVG_CH2G, Channel 2 capture or compare event generation
: TIMER2_SWEVG_CH1G ( -- x addr ) 2 bit TIMER2_SWEVG ; \ TIMER2_SWEVG_CH1G, Channel 1 capture or compare event generation
: TIMER2_SWEVG_CH0G ( -- x addr ) 1 bit TIMER2_SWEVG ; \ TIMER2_SWEVG_CH0G, Channel 0 capture or compare event generation
: TIMER2_SWEVG_UPG ( -- x addr ) 0 bit TIMER2_SWEVG ; \ TIMER2_SWEVG_UPG, Update generation

\ TIMER2_CHCTL0_Output (read-write) Reset:0x0000
: TIMER2_CHCTL0_Output_CH1COMCEN ( -- x addr ) 15 bit TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH1COMCEN, Channel 1 output compare clear enable
: TIMER2_CHCTL0_Output_CH1COMCTL ( %bbb -- x addr ) 12 lshift TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH1COMCTL, Channel 1 compare output control
: TIMER2_CHCTL0_Output_CH1COMSEN ( -- x addr ) 11 bit TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH1COMSEN, Channel 1 output compare shadow enable
: TIMER2_CHCTL0_Output_CH1COMFEN ( -- x addr ) 10 bit TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH1COMFEN, Channel 1 output compare fast enable
: TIMER2_CHCTL0_Output_CH1MS ( %bb -- x addr ) 8 lshift TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH1MS, Channel 1 mode selection
: TIMER2_CHCTL0_Output_CH0COMCEN ( -- x addr ) 7 bit TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH0COMCEN, Channel 0 output compare clear enable
: TIMER2_CHCTL0_Output_CH0COMCTL ( %bbb -- x addr ) 4 lshift TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH0COMCTL,  Channel 0 compare output control
: TIMER2_CHCTL0_Output_CH0COMSEN ( -- x addr ) 3 bit TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH0COMSEN, Channel 0 compare output shadow enable
: TIMER2_CHCTL0_Output_CH0COMFEN ( -- x addr ) 2 bit TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH0COMFEN, Channel 0 output compare fast enable
: TIMER2_CHCTL0_Output_CH0MS ( %bb -- x addr ) TIMER2_CHCTL0_Output ; \ TIMER2_CHCTL0_Output_CH0MS, Channel 0 I/O mode selection

\ TIMER2_CHCTL0_Input (read-write) Reset:0x00000000
: TIMER2_CHCTL0_Input_CH1CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER2_CHCTL0_Input ; \ TIMER2_CHCTL0_Input_CH1CAPFLT, Channel 1 input capture filter control
: TIMER2_CHCTL0_Input_CH1CAPPSC ( %bb -- x addr ) 10 lshift TIMER2_CHCTL0_Input ; \ TIMER2_CHCTL0_Input_CH1CAPPSC, Channel 1 input capture prescaler
: TIMER2_CHCTL0_Input_CH1MS ( %bb -- x addr ) 8 lshift TIMER2_CHCTL0_Input ; \ TIMER2_CHCTL0_Input_CH1MS, Channel 1 mode selection
: TIMER2_CHCTL0_Input_CH0CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER2_CHCTL0_Input ; \ TIMER2_CHCTL0_Input_CH0CAPFLT, Channel 0 input capture filter control
: TIMER2_CHCTL0_Input_CH0CAPPSC ( %bb -- x addr ) 2 lshift TIMER2_CHCTL0_Input ; \ TIMER2_CHCTL0_Input_CH0CAPPSC, Channel 0 input capture prescaler
: TIMER2_CHCTL0_Input_CH0MS ( %bb -- x addr ) TIMER2_CHCTL0_Input ; \ TIMER2_CHCTL0_Input_CH0MS, Channel 0 mode selection

\ TIMER2_CHCTL1_Output (read-write) Reset:0x0000
: TIMER2_CHCTL1_Output_CH3COMCEN ( -- x addr ) 15 bit TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH3COMCEN, Channel 3 output compare clear enable
: TIMER2_CHCTL1_Output_CH3COMCTL ( %bbb -- x addr ) 12 lshift TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH3COMCTL, Channel 3 compare output control
: TIMER2_CHCTL1_Output_CH3COMSEN ( -- x addr ) 11 bit TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH3COMSEN, Channel 3 output compare shadow enable
: TIMER2_CHCTL1_Output_CH3COMFEN ( -- x addr ) 10 bit TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH3COMFEN, Channel 3 output compare fast enable
: TIMER2_CHCTL1_Output_CH3MS ( %bb -- x addr ) 8 lshift TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH3MS, Channel 3 mode selection
: TIMER2_CHCTL1_Output_CH2COMCEN ( -- x addr ) 7 bit TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH2COMCEN, Channel 2 output compare clear enable
: TIMER2_CHCTL1_Output_CH2COMCTL ( %bbb -- x addr ) 4 lshift TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH2COMCTL, Channel 2 compare output control
: TIMER2_CHCTL1_Output_CH2COMSEN ( -- x addr ) 3 bit TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH2COMSEN, Channel 2 compare output shadow enable
: TIMER2_CHCTL1_Output_CH2COMFEN ( -- x addr ) 2 bit TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH2COMFEN, Channel 2 output compare fast enable
: TIMER2_CHCTL1_Output_CH2MS ( %bb -- x addr ) TIMER2_CHCTL1_Output ; \ TIMER2_CHCTL1_Output_CH2MS, Channel 2 I/O mode selection

\ TIMER2_CHCTL1_Input (read-write) Reset:0x0000
: TIMER2_CHCTL1_Input_CH3CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER2_CHCTL1_Input ; \ TIMER2_CHCTL1_Input_CH3CAPFLT, Channel 3 input capture filter control
: TIMER2_CHCTL1_Input_CH3CAPPSC ( %bb -- x addr ) 10 lshift TIMER2_CHCTL1_Input ; \ TIMER2_CHCTL1_Input_CH3CAPPSC, Channel 3 input capture prescaler
: TIMER2_CHCTL1_Input_CH3MS ( %bb -- x addr ) 8 lshift TIMER2_CHCTL1_Input ; \ TIMER2_CHCTL1_Input_CH3MS, Channel 3 mode selection
: TIMER2_CHCTL1_Input_CH2CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER2_CHCTL1_Input ; \ TIMER2_CHCTL1_Input_CH2CAPFLT, Channel 2 input capture filter control
: TIMER2_CHCTL1_Input_CH2CAPPSC ( %bb -- x addr ) 2 lshift TIMER2_CHCTL1_Input ; \ TIMER2_CHCTL1_Input_CH2CAPPSC, Channel 2 input capture prescaler
: TIMER2_CHCTL1_Input_CH2MS ( %bb -- x addr ) TIMER2_CHCTL1_Input ; \ TIMER2_CHCTL1_Input_CH2MS, Channel 2 mode selection

\ TIMER2_CHCTL2 (read-write) Reset:0x0000
: TIMER2_CHCTL2_CH3P ( -- x addr ) 13 bit TIMER2_CHCTL2 ; \ TIMER2_CHCTL2_CH3P, Channel 3 capture/compare function polarity
: TIMER2_CHCTL2_CH3EN ( -- x addr ) 12 bit TIMER2_CHCTL2 ; \ TIMER2_CHCTL2_CH3EN, Channel 3 capture/compare function enable
: TIMER2_CHCTL2_CH2P ( -- x addr ) 9 bit TIMER2_CHCTL2 ; \ TIMER2_CHCTL2_CH2P, Channel 2 capture/compare function polarity
: TIMER2_CHCTL2_CH2EN ( -- x addr ) 8 bit TIMER2_CHCTL2 ; \ TIMER2_CHCTL2_CH2EN, Channel 2 capture/compare function enable
: TIMER2_CHCTL2_CH1P ( -- x addr ) 5 bit TIMER2_CHCTL2 ; \ TIMER2_CHCTL2_CH1P, Channel 1 capture/compare function polarity
: TIMER2_CHCTL2_CH1EN ( -- x addr ) 4 bit TIMER2_CHCTL2 ; \ TIMER2_CHCTL2_CH1EN, Channel 1 capture/compare function enable
: TIMER2_CHCTL2_CH0P ( -- x addr ) 1 bit TIMER2_CHCTL2 ; \ TIMER2_CHCTL2_CH0P, Channel 0 capture/compare function polarity
: TIMER2_CHCTL2_CH0EN ( -- x addr ) 0 bit TIMER2_CHCTL2 ; \ TIMER2_CHCTL2_CH0EN, Channel 0 capture/compare function enable

\ TIMER2_CNT (read-write) Reset:0x0000
: TIMER2_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER2_CNT ; \ TIMER2_CNT_CNT, counter value

\ TIMER2_PSC (read-write) Reset:0x0000
: TIMER2_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER2_PSC ; \ TIMER2_PSC_PSC, Prescaler value of the counter clock

\ TIMER2_CAR (read-write) Reset:0x0000
: TIMER2_CAR_CARL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER2_CAR ; \ TIMER2_CAR_CARL, Counter auto reload value

\ TIMER2_CH0CV (read-write) Reset:0x00000000
: TIMER2_CH0CV_CH0VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER2_CH0CV ; \ TIMER2_CH0CV_CH0VAL, Capture or compare value of channel 0

\ TIMER2_CH1CV (read-write) Reset:0x00000000
: TIMER2_CH1CV_CH1VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER2_CH1CV ; \ TIMER2_CH1CV_CH1VAL, Capture or compare value of channel1

\ TIMER2_CH2CV (read-write) Reset:0x00000000
: TIMER2_CH2CV_CH2VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER2_CH2CV ; \ TIMER2_CH2CV_CH2VAL, Capture or compare value of channel 2

\ TIMER2_CH3CV (read-write) Reset:0x00000000
: TIMER2_CH3CV_CH3VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER2_CH3CV ; \ TIMER2_CH3CV_CH3VAL, Capture or compare value of channel 3

\ TIMER2_DMACFG (read-write) Reset:0x0000
: TIMER2_DMACFG_DMATC ( %bbbbb -- x addr ) 8 lshift TIMER2_DMACFG ; \ TIMER2_DMACFG_DMATC, DMA transfer count
: TIMER2_DMACFG_DMATA ( %bbbbb -- x addr ) TIMER2_DMACFG ; \ TIMER2_DMACFG_DMATA, DMA transfer access start address

\ TIMER2_DMATB (read-write) Reset:0x0000
: TIMER2_DMATB_DMATB ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER2_DMATB ; \ TIMER2_DMATB_DMATB, DMA transfer buffer

\ TIMER3_CTL0 (read-write) Reset:0x0000
: TIMER3_CTL0_CKDIV ( %bb -- x addr ) 8 lshift TIMER3_CTL0 ; \ TIMER3_CTL0_CKDIV, Clock division
: TIMER3_CTL0_ARSE ( -- x addr ) 7 bit TIMER3_CTL0 ; \ TIMER3_CTL0_ARSE, Auto-reload shadow enable
: TIMER3_CTL0_CAM ( %bb -- x addr ) 5 lshift TIMER3_CTL0 ; \ TIMER3_CTL0_CAM, Counter aligns mode selection
: TIMER3_CTL0_DIR ( -- x addr ) 4 bit TIMER3_CTL0 ; \ TIMER3_CTL0_DIR, Direction
: TIMER3_CTL0_SPM ( -- x addr ) 3 bit TIMER3_CTL0 ; \ TIMER3_CTL0_SPM, Single pulse mode
: TIMER3_CTL0_UPS ( -- x addr ) 2 bit TIMER3_CTL0 ; \ TIMER3_CTL0_UPS, Update source
: TIMER3_CTL0_UPDIS ( -- x addr ) 1 bit TIMER3_CTL0 ; \ TIMER3_CTL0_UPDIS, Update disable
: TIMER3_CTL0_CEN ( -- x addr ) 0 bit TIMER3_CTL0 ; \ TIMER3_CTL0_CEN, Counter enable

\ TIMER3_CTL1 (read-write) Reset:0x0000
: TIMER3_CTL1_TI0S ( -- x addr ) 7 bit TIMER3_CTL1 ; \ TIMER3_CTL1_TI0S, Channel 0 trigger input selection
: TIMER3_CTL1_MMC ( %bbb -- x addr ) 4 lshift TIMER3_CTL1 ; \ TIMER3_CTL1_MMC, Master mode control
: TIMER3_CTL1_DMAS ( -- x addr ) 3 bit TIMER3_CTL1 ; \ TIMER3_CTL1_DMAS, DMA request source selection

\ TIMER3_SMCFG (read-write) Reset:0x0000
: TIMER3_SMCFG_ETP ( -- x addr ) 15 bit TIMER3_SMCFG ; \ TIMER3_SMCFG_ETP, External trigger polarity
: TIMER3_SMCFG_SMC1 ( -- x addr ) 14 bit TIMER3_SMCFG ; \ TIMER3_SMCFG_SMC1, Part of SMC for enable External clock mode1
: TIMER3_SMCFG_ETPSC ( %bb -- x addr ) 12 lshift TIMER3_SMCFG ; \ TIMER3_SMCFG_ETPSC, External trigger prescaler
: TIMER3_SMCFG_ETFC ( %bbbb -- x addr ) 8 lshift TIMER3_SMCFG ; \ TIMER3_SMCFG_ETFC, External trigger filter control
: TIMER3_SMCFG_MSM ( -- x addr ) 7 bit TIMER3_SMCFG ; \ TIMER3_SMCFG_MSM, Master-slave mode
: TIMER3_SMCFG_TRGS ( %bbb -- x addr ) 4 lshift TIMER3_SMCFG ; \ TIMER3_SMCFG_TRGS, Trigger selection
: TIMER3_SMCFG_SMC ( %bbb -- x addr ) TIMER3_SMCFG ; \ TIMER3_SMCFG_SMC, Slave mode control

\ TIMER3_DMAINTEN (read-write) Reset:0x0000
: TIMER3_DMAINTEN_TRGDEN ( -- x addr ) 14 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_TRGDEN, Trigger DMA request enable
: TIMER3_DMAINTEN_CH3DEN ( -- x addr ) 12 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_CH3DEN, Channel 3 capture/compare DMA request enable
: TIMER3_DMAINTEN_CH2DEN ( -- x addr ) 11 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_CH2DEN, Channel 2 capture/compare DMA request enable
: TIMER3_DMAINTEN_CH1DEN ( -- x addr ) 10 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_CH1DEN, Channel 1 capture/compare DMA request enable
: TIMER3_DMAINTEN_CH0DEN ( -- x addr ) 9 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_CH0DEN, Channel 0 capture/compare DMA request enable
: TIMER3_DMAINTEN_UPDEN ( -- x addr ) 8 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_UPDEN, Update DMA request enable
: TIMER3_DMAINTEN_TRGIE ( -- x addr ) 6 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_TRGIE, Trigger interrupt enable
: TIMER3_DMAINTEN_CH3IE ( -- x addr ) 4 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_CH3IE, Channel 3 capture/compare interrupt enable
: TIMER3_DMAINTEN_CH2IE ( -- x addr ) 3 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_CH2IE, Channel 2 capture/compare interrupt enable
: TIMER3_DMAINTEN_CH1IE ( -- x addr ) 2 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_CH1IE, Channel 1 capture/compare interrupt enable
: TIMER3_DMAINTEN_CH0IE ( -- x addr ) 1 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_CH0IE, Channel 0 capture/compare interrupt enable
: TIMER3_DMAINTEN_UPIE ( -- x addr ) 0 bit TIMER3_DMAINTEN ; \ TIMER3_DMAINTEN_UPIE, Update interrupt enable

\ TIMER3_INTF (read-write) Reset:0x0000
: TIMER3_INTF_CH3OF ( -- x addr ) 12 bit TIMER3_INTF ; \ TIMER3_INTF_CH3OF, Channel 3 over capture flag
: TIMER3_INTF_CH2OF ( -- x addr ) 11 bit TIMER3_INTF ; \ TIMER3_INTF_CH2OF, Channel 2 over capture flag
: TIMER3_INTF_CH1OF ( -- x addr ) 10 bit TIMER3_INTF ; \ TIMER3_INTF_CH1OF, Channel 1 over capture flag
: TIMER3_INTF_CH0OF ( -- x addr ) 9 bit TIMER3_INTF ; \ TIMER3_INTF_CH0OF, Channel 0 over capture flag
: TIMER3_INTF_TRGIF ( -- x addr ) 6 bit TIMER3_INTF ; \ TIMER3_INTF_TRGIF, Trigger interrupt flag
: TIMER3_INTF_CH3IF ( -- x addr ) 4 bit TIMER3_INTF ; \ TIMER3_INTF_CH3IF, Channel 3 capture/compare interrupt enable
: TIMER3_INTF_CH2IF ( -- x addr ) 3 bit TIMER3_INTF ; \ TIMER3_INTF_CH2IF, Channel 2 capture/compare interrupt enable
: TIMER3_INTF_CH1IF ( -- x addr ) 2 bit TIMER3_INTF ; \ TIMER3_INTF_CH1IF, Channel 1 capture/compare interrupt flag
: TIMER3_INTF_CH0IF ( -- x addr ) 1 bit TIMER3_INTF ; \ TIMER3_INTF_CH0IF, Channel 0 capture/compare interrupt flag
: TIMER3_INTF_UPIF ( -- x addr ) 0 bit TIMER3_INTF ; \ TIMER3_INTF_UPIF, Update interrupt flag

\ TIMER3_SWEVG (write-only) Reset:0x0000
: TIMER3_SWEVG_TRGG ( -- x addr ) 6 bit TIMER3_SWEVG ; \ TIMER3_SWEVG_TRGG, Trigger event generation
: TIMER3_SWEVG_CH3G ( -- x addr ) 4 bit TIMER3_SWEVG ; \ TIMER3_SWEVG_CH3G, Channel 3 capture or compare event generation
: TIMER3_SWEVG_CH2G ( -- x addr ) 3 bit TIMER3_SWEVG ; \ TIMER3_SWEVG_CH2G, Channel 2 capture or compare event generation
: TIMER3_SWEVG_CH1G ( -- x addr ) 2 bit TIMER3_SWEVG ; \ TIMER3_SWEVG_CH1G, Channel 1 capture or compare event generation
: TIMER3_SWEVG_CH0G ( -- x addr ) 1 bit TIMER3_SWEVG ; \ TIMER3_SWEVG_CH0G, Channel 0 capture or compare event generation
: TIMER3_SWEVG_UPG ( -- x addr ) 0 bit TIMER3_SWEVG ; \ TIMER3_SWEVG_UPG, Update generation

\ TIMER3_CHCTL0_Output (read-write) Reset:0x0000
: TIMER3_CHCTL0_Output_CH1COMCEN ( -- x addr ) 15 bit TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH1COMCEN, Channel 1 output compare clear enable
: TIMER3_CHCTL0_Output_CH1COMCTL ( %bbb -- x addr ) 12 lshift TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH1COMCTL, Channel 1 compare output control
: TIMER3_CHCTL0_Output_CH1COMSEN ( -- x addr ) 11 bit TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH1COMSEN, Channel 1 output compare shadow enable
: TIMER3_CHCTL0_Output_CH1COMFEN ( -- x addr ) 10 bit TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH1COMFEN, Channel 1 output compare fast enable
: TIMER3_CHCTL0_Output_CH1MS ( %bb -- x addr ) 8 lshift TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH1MS, Channel 1 mode selection
: TIMER3_CHCTL0_Output_CH0COMCEN ( -- x addr ) 7 bit TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH0COMCEN, Channel 0 output compare clear enable
: TIMER3_CHCTL0_Output_CH0COMCTL ( %bbb -- x addr ) 4 lshift TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH0COMCTL,  Channel 0 compare output control
: TIMER3_CHCTL0_Output_CH0COMSEN ( -- x addr ) 3 bit TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH0COMSEN, Channel 0 compare output shadow enable
: TIMER3_CHCTL0_Output_CH0COMFEN ( -- x addr ) 2 bit TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH0COMFEN, Channel 0 output compare fast enable
: TIMER3_CHCTL0_Output_CH0MS ( %bb -- x addr ) TIMER3_CHCTL0_Output ; \ TIMER3_CHCTL0_Output_CH0MS, Channel 0 I/O mode selection

\ TIMER3_CHCTL0_Input (read-write) Reset:0x00000000
: TIMER3_CHCTL0_Input_CH1CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER3_CHCTL0_Input ; \ TIMER3_CHCTL0_Input_CH1CAPFLT, Channel 1 input capture filter control
: TIMER3_CHCTL0_Input_CH1CAPPSC ( %bb -- x addr ) 10 lshift TIMER3_CHCTL0_Input ; \ TIMER3_CHCTL0_Input_CH1CAPPSC, Channel 1 input capture prescaler
: TIMER3_CHCTL0_Input_CH1MS ( %bb -- x addr ) 8 lshift TIMER3_CHCTL0_Input ; \ TIMER3_CHCTL0_Input_CH1MS, Channel 1 mode selection
: TIMER3_CHCTL0_Input_CH0CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER3_CHCTL0_Input ; \ TIMER3_CHCTL0_Input_CH0CAPFLT, Channel 0 input capture filter control
: TIMER3_CHCTL0_Input_CH0CAPPSC ( %bb -- x addr ) 2 lshift TIMER3_CHCTL0_Input ; \ TIMER3_CHCTL0_Input_CH0CAPPSC, Channel 0 input capture prescaler
: TIMER3_CHCTL0_Input_CH0MS ( %bb -- x addr ) TIMER3_CHCTL0_Input ; \ TIMER3_CHCTL0_Input_CH0MS, Channel 0 mode selection

\ TIMER3_CHCTL1_Output (read-write) Reset:0x0000
: TIMER3_CHCTL1_Output_CH3COMCEN ( -- x addr ) 15 bit TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH3COMCEN, Channel 3 output compare clear enable
: TIMER3_CHCTL1_Output_CH3COMCTL ( %bbb -- x addr ) 12 lshift TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH3COMCTL, Channel 3 compare output control
: TIMER3_CHCTL1_Output_CH3COMSEN ( -- x addr ) 11 bit TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH3COMSEN, Channel 3 output compare shadow enable
: TIMER3_CHCTL1_Output_CH3COMFEN ( -- x addr ) 10 bit TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH3COMFEN, Channel 3 output compare fast enable
: TIMER3_CHCTL1_Output_CH3MS ( %bb -- x addr ) 8 lshift TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH3MS, Channel 3 mode selection
: TIMER3_CHCTL1_Output_CH2COMCEN ( -- x addr ) 7 bit TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH2COMCEN, Channel 2 output compare clear enable
: TIMER3_CHCTL1_Output_CH2COMCTL ( %bbb -- x addr ) 4 lshift TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH2COMCTL, Channel 2 compare output control
: TIMER3_CHCTL1_Output_CH2COMSEN ( -- x addr ) 3 bit TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH2COMSEN, Channel 2 compare output shadow enable
: TIMER3_CHCTL1_Output_CH2COMFEN ( -- x addr ) 2 bit TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH2COMFEN, Channel 2 output compare fast enable
: TIMER3_CHCTL1_Output_CH2MS ( %bb -- x addr ) TIMER3_CHCTL1_Output ; \ TIMER3_CHCTL1_Output_CH2MS, Channel 2 I/O mode selection

\ TIMER3_CHCTL1_Input (read-write) Reset:0x0000
: TIMER3_CHCTL1_Input_CH3CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER3_CHCTL1_Input ; \ TIMER3_CHCTL1_Input_CH3CAPFLT, Channel 3 input capture filter control
: TIMER3_CHCTL1_Input_CH3CAPPSC ( %bb -- x addr ) 10 lshift TIMER3_CHCTL1_Input ; \ TIMER3_CHCTL1_Input_CH3CAPPSC, Channel 3 input capture prescaler
: TIMER3_CHCTL1_Input_CH3MS ( %bb -- x addr ) 8 lshift TIMER3_CHCTL1_Input ; \ TIMER3_CHCTL1_Input_CH3MS, Channel 3 mode selection
: TIMER3_CHCTL1_Input_CH2CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER3_CHCTL1_Input ; \ TIMER3_CHCTL1_Input_CH2CAPFLT, Channel 2 input capture filter control
: TIMER3_CHCTL1_Input_CH2CAPPSC ( %bb -- x addr ) 2 lshift TIMER3_CHCTL1_Input ; \ TIMER3_CHCTL1_Input_CH2CAPPSC, Channel 2 input capture prescaler
: TIMER3_CHCTL1_Input_CH2MS ( %bb -- x addr ) TIMER3_CHCTL1_Input ; \ TIMER3_CHCTL1_Input_CH2MS, Channel 2 mode selection

\ TIMER3_CHCTL2 (read-write) Reset:0x0000
: TIMER3_CHCTL2_CH3P ( -- x addr ) 13 bit TIMER3_CHCTL2 ; \ TIMER3_CHCTL2_CH3P, Channel 3 capture/compare function polarity
: TIMER3_CHCTL2_CH3EN ( -- x addr ) 12 bit TIMER3_CHCTL2 ; \ TIMER3_CHCTL2_CH3EN, Channel 3 capture/compare function enable
: TIMER3_CHCTL2_CH2P ( -- x addr ) 9 bit TIMER3_CHCTL2 ; \ TIMER3_CHCTL2_CH2P, Channel 2 capture/compare function polarity
: TIMER3_CHCTL2_CH2EN ( -- x addr ) 8 bit TIMER3_CHCTL2 ; \ TIMER3_CHCTL2_CH2EN, Channel 2 capture/compare function enable
: TIMER3_CHCTL2_CH1P ( -- x addr ) 5 bit TIMER3_CHCTL2 ; \ TIMER3_CHCTL2_CH1P, Channel 1 capture/compare function polarity
: TIMER3_CHCTL2_CH1EN ( -- x addr ) 4 bit TIMER3_CHCTL2 ; \ TIMER3_CHCTL2_CH1EN, Channel 1 capture/compare function enable
: TIMER3_CHCTL2_CH0P ( -- x addr ) 1 bit TIMER3_CHCTL2 ; \ TIMER3_CHCTL2_CH0P, Channel 0 capture/compare function polarity
: TIMER3_CHCTL2_CH0EN ( -- x addr ) 0 bit TIMER3_CHCTL2 ; \ TIMER3_CHCTL2_CH0EN, Channel 0 capture/compare function enable

\ TIMER3_CNT (read-write) Reset:0x0000
: TIMER3_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER3_CNT ; \ TIMER3_CNT_CNT, counter value

\ TIMER3_PSC (read-write) Reset:0x0000
: TIMER3_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER3_PSC ; \ TIMER3_PSC_PSC, Prescaler value of the counter clock

\ TIMER3_CAR (read-write) Reset:0x0000
: TIMER3_CAR_CARL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER3_CAR ; \ TIMER3_CAR_CARL, Counter auto reload value

\ TIMER3_CH0CV (read-write) Reset:0x00000000
: TIMER3_CH0CV_CH0VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER3_CH0CV ; \ TIMER3_CH0CV_CH0VAL, Capture or compare value of channel 0

\ TIMER3_CH1CV (read-write) Reset:0x00000000
: TIMER3_CH1CV_CH1VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER3_CH1CV ; \ TIMER3_CH1CV_CH1VAL, Capture or compare value of channel1

\ TIMER3_CH2CV (read-write) Reset:0x00000000
: TIMER3_CH2CV_CH2VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER3_CH2CV ; \ TIMER3_CH2CV_CH2VAL, Capture or compare value of channel 2

\ TIMER3_CH3CV (read-write) Reset:0x00000000
: TIMER3_CH3CV_CH3VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER3_CH3CV ; \ TIMER3_CH3CV_CH3VAL, Capture or compare value of channel 3

\ TIMER3_DMACFG (read-write) Reset:0x0000
: TIMER3_DMACFG_DMATC ( %bbbbb -- x addr ) 8 lshift TIMER3_DMACFG ; \ TIMER3_DMACFG_DMATC, DMA transfer count
: TIMER3_DMACFG_DMATA ( %bbbbb -- x addr ) TIMER3_DMACFG ; \ TIMER3_DMACFG_DMATA, DMA transfer access start address

\ TIMER3_DMATB (read-write) Reset:0x0000
: TIMER3_DMATB_DMATB ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER3_DMATB ; \ TIMER3_DMATB_DMATB, DMA transfer buffer

\ TIMER4_CTL0 (read-write) Reset:0x0000
: TIMER4_CTL0_CKDIV ( %bb -- x addr ) 8 lshift TIMER4_CTL0 ; \ TIMER4_CTL0_CKDIV, Clock division
: TIMER4_CTL0_ARSE ( -- x addr ) 7 bit TIMER4_CTL0 ; \ TIMER4_CTL0_ARSE, Auto-reload shadow enable
: TIMER4_CTL0_CAM ( %bb -- x addr ) 5 lshift TIMER4_CTL0 ; \ TIMER4_CTL0_CAM, Counter aligns mode selection
: TIMER4_CTL0_DIR ( -- x addr ) 4 bit TIMER4_CTL0 ; \ TIMER4_CTL0_DIR, Direction
: TIMER4_CTL0_SPM ( -- x addr ) 3 bit TIMER4_CTL0 ; \ TIMER4_CTL0_SPM, Single pulse mode
: TIMER4_CTL0_UPS ( -- x addr ) 2 bit TIMER4_CTL0 ; \ TIMER4_CTL0_UPS, Update source
: TIMER4_CTL0_UPDIS ( -- x addr ) 1 bit TIMER4_CTL0 ; \ TIMER4_CTL0_UPDIS, Update disable
: TIMER4_CTL0_CEN ( -- x addr ) 0 bit TIMER4_CTL0 ; \ TIMER4_CTL0_CEN, Counter enable

\ TIMER4_CTL1 (read-write) Reset:0x0000
: TIMER4_CTL1_TI0S ( -- x addr ) 7 bit TIMER4_CTL1 ; \ TIMER4_CTL1_TI0S, Channel 0 trigger input selection
: TIMER4_CTL1_MMC ( %bbb -- x addr ) 4 lshift TIMER4_CTL1 ; \ TIMER4_CTL1_MMC, Master mode control
: TIMER4_CTL1_DMAS ( -- x addr ) 3 bit TIMER4_CTL1 ; \ TIMER4_CTL1_DMAS, DMA request source selection

\ TIMER4_SMCFG (read-write) Reset:0x0000
: TIMER4_SMCFG_ETP ( -- x addr ) 15 bit TIMER4_SMCFG ; \ TIMER4_SMCFG_ETP, External trigger polarity
: TIMER4_SMCFG_SMC1 ( -- x addr ) 14 bit TIMER4_SMCFG ; \ TIMER4_SMCFG_SMC1, Part of SMC for enable External clock mode1
: TIMER4_SMCFG_ETPSC ( %bb -- x addr ) 12 lshift TIMER4_SMCFG ; \ TIMER4_SMCFG_ETPSC, External trigger prescaler
: TIMER4_SMCFG_ETFC ( %bbbb -- x addr ) 8 lshift TIMER4_SMCFG ; \ TIMER4_SMCFG_ETFC, External trigger filter control
: TIMER4_SMCFG_MSM ( -- x addr ) 7 bit TIMER4_SMCFG ; \ TIMER4_SMCFG_MSM, Master-slave mode
: TIMER4_SMCFG_TRGS ( %bbb -- x addr ) 4 lshift TIMER4_SMCFG ; \ TIMER4_SMCFG_TRGS, Trigger selection
: TIMER4_SMCFG_SMC ( %bbb -- x addr ) TIMER4_SMCFG ; \ TIMER4_SMCFG_SMC, Slave mode control

\ TIMER4_DMAINTEN (read-write) Reset:0x0000
: TIMER4_DMAINTEN_TRGDEN ( -- x addr ) 14 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_TRGDEN, Trigger DMA request enable
: TIMER4_DMAINTEN_CH3DEN ( -- x addr ) 12 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_CH3DEN, Channel 3 capture/compare DMA request enable
: TIMER4_DMAINTEN_CH2DEN ( -- x addr ) 11 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_CH2DEN, Channel 2 capture/compare DMA request enable
: TIMER4_DMAINTEN_CH1DEN ( -- x addr ) 10 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_CH1DEN, Channel 1 capture/compare DMA request enable
: TIMER4_DMAINTEN_CH0DEN ( -- x addr ) 9 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_CH0DEN, Channel 0 capture/compare DMA request enable
: TIMER4_DMAINTEN_UPDEN ( -- x addr ) 8 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_UPDEN, Update DMA request enable
: TIMER4_DMAINTEN_TRGIE ( -- x addr ) 6 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_TRGIE, Trigger interrupt enable
: TIMER4_DMAINTEN_CH3IE ( -- x addr ) 4 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_CH3IE, Channel 3 capture/compare interrupt enable
: TIMER4_DMAINTEN_CH2IE ( -- x addr ) 3 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_CH2IE, Channel 2 capture/compare interrupt enable
: TIMER4_DMAINTEN_CH1IE ( -- x addr ) 2 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_CH1IE, Channel 1 capture/compare interrupt enable
: TIMER4_DMAINTEN_CH0IE ( -- x addr ) 1 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_CH0IE, Channel 0 capture/compare interrupt enable
: TIMER4_DMAINTEN_UPIE ( -- x addr ) 0 bit TIMER4_DMAINTEN ; \ TIMER4_DMAINTEN_UPIE, Update interrupt enable

\ TIMER4_INTF (read-write) Reset:0x0000
: TIMER4_INTF_CH3OF ( -- x addr ) 12 bit TIMER4_INTF ; \ TIMER4_INTF_CH3OF, Channel 3 over capture flag
: TIMER4_INTF_CH2OF ( -- x addr ) 11 bit TIMER4_INTF ; \ TIMER4_INTF_CH2OF, Channel 2 over capture flag
: TIMER4_INTF_CH1OF ( -- x addr ) 10 bit TIMER4_INTF ; \ TIMER4_INTF_CH1OF, Channel 1 over capture flag
: TIMER4_INTF_CH0OF ( -- x addr ) 9 bit TIMER4_INTF ; \ TIMER4_INTF_CH0OF, Channel 0 over capture flag
: TIMER4_INTF_TRGIF ( -- x addr ) 6 bit TIMER4_INTF ; \ TIMER4_INTF_TRGIF, Trigger interrupt flag
: TIMER4_INTF_CH3IF ( -- x addr ) 4 bit TIMER4_INTF ; \ TIMER4_INTF_CH3IF, Channel 3 capture/compare interrupt enable
: TIMER4_INTF_CH2IF ( -- x addr ) 3 bit TIMER4_INTF ; \ TIMER4_INTF_CH2IF, Channel 2 capture/compare interrupt enable
: TIMER4_INTF_CH1IF ( -- x addr ) 2 bit TIMER4_INTF ; \ TIMER4_INTF_CH1IF, Channel 1 capture/compare interrupt flag
: TIMER4_INTF_CH0IF ( -- x addr ) 1 bit TIMER4_INTF ; \ TIMER4_INTF_CH0IF, Channel 0 capture/compare interrupt flag
: TIMER4_INTF_UPIF ( -- x addr ) 0 bit TIMER4_INTF ; \ TIMER4_INTF_UPIF, Update interrupt flag

\ TIMER4_SWEVG (write-only) Reset:0x0000
: TIMER4_SWEVG_TRGG ( -- x addr ) 6 bit TIMER4_SWEVG ; \ TIMER4_SWEVG_TRGG, Trigger event generation
: TIMER4_SWEVG_CH3G ( -- x addr ) 4 bit TIMER4_SWEVG ; \ TIMER4_SWEVG_CH3G, Channel 3 capture or compare event generation
: TIMER4_SWEVG_CH2G ( -- x addr ) 3 bit TIMER4_SWEVG ; \ TIMER4_SWEVG_CH2G, Channel 2 capture or compare event generation
: TIMER4_SWEVG_CH1G ( -- x addr ) 2 bit TIMER4_SWEVG ; \ TIMER4_SWEVG_CH1G, Channel 1 capture or compare event generation
: TIMER4_SWEVG_CH0G ( -- x addr ) 1 bit TIMER4_SWEVG ; \ TIMER4_SWEVG_CH0G, Channel 0 capture or compare event generation
: TIMER4_SWEVG_UPG ( -- x addr ) 0 bit TIMER4_SWEVG ; \ TIMER4_SWEVG_UPG, Update generation

\ TIMER4_CHCTL0_Output (read-write) Reset:0x0000
: TIMER4_CHCTL0_Output_CH1COMCEN ( -- x addr ) 15 bit TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH1COMCEN, Channel 1 output compare clear enable
: TIMER4_CHCTL0_Output_CH1COMCTL ( %bbb -- x addr ) 12 lshift TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH1COMCTL, Channel 1 compare output control
: TIMER4_CHCTL0_Output_CH1COMSEN ( -- x addr ) 11 bit TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH1COMSEN, Channel 1 output compare shadow enable
: TIMER4_CHCTL0_Output_CH1COMFEN ( -- x addr ) 10 bit TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH1COMFEN, Channel 1 output compare fast enable
: TIMER4_CHCTL0_Output_CH1MS ( %bb -- x addr ) 8 lshift TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH1MS, Channel 1 mode selection
: TIMER4_CHCTL0_Output_CH0COMCEN ( -- x addr ) 7 bit TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH0COMCEN, Channel 0 output compare clear enable
: TIMER4_CHCTL0_Output_CH0COMCTL ( %bbb -- x addr ) 4 lshift TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH0COMCTL,  Channel 0 compare output control
: TIMER4_CHCTL0_Output_CH0COMSEN ( -- x addr ) 3 bit TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH0COMSEN, Channel 0 compare output shadow enable
: TIMER4_CHCTL0_Output_CH0COMFEN ( -- x addr ) 2 bit TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH0COMFEN, Channel 0 output compare fast enable
: TIMER4_CHCTL0_Output_CH0MS ( %bb -- x addr ) TIMER4_CHCTL0_Output ; \ TIMER4_CHCTL0_Output_CH0MS, Channel 0 I/O mode selection

\ TIMER4_CHCTL0_Input (read-write) Reset:0x00000000
: TIMER4_CHCTL0_Input_CH1CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER4_CHCTL0_Input ; \ TIMER4_CHCTL0_Input_CH1CAPFLT, Channel 1 input capture filter control
: TIMER4_CHCTL0_Input_CH1CAPPSC ( %bb -- x addr ) 10 lshift TIMER4_CHCTL0_Input ; \ TIMER4_CHCTL0_Input_CH1CAPPSC, Channel 1 input capture prescaler
: TIMER4_CHCTL0_Input_CH1MS ( %bb -- x addr ) 8 lshift TIMER4_CHCTL0_Input ; \ TIMER4_CHCTL0_Input_CH1MS, Channel 1 mode selection
: TIMER4_CHCTL0_Input_CH0CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER4_CHCTL0_Input ; \ TIMER4_CHCTL0_Input_CH0CAPFLT, Channel 0 input capture filter control
: TIMER4_CHCTL0_Input_CH0CAPPSC ( %bb -- x addr ) 2 lshift TIMER4_CHCTL0_Input ; \ TIMER4_CHCTL0_Input_CH0CAPPSC, Channel 0 input capture prescaler
: TIMER4_CHCTL0_Input_CH0MS ( %bb -- x addr ) TIMER4_CHCTL0_Input ; \ TIMER4_CHCTL0_Input_CH0MS, Channel 0 mode selection

\ TIMER4_CHCTL1_Output (read-write) Reset:0x0000
: TIMER4_CHCTL1_Output_CH3COMCEN ( -- x addr ) 15 bit TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH3COMCEN, Channel 3 output compare clear enable
: TIMER4_CHCTL1_Output_CH3COMCTL ( %bbb -- x addr ) 12 lshift TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH3COMCTL, Channel 3 compare output control
: TIMER4_CHCTL1_Output_CH3COMSEN ( -- x addr ) 11 bit TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH3COMSEN, Channel 3 output compare shadow enable
: TIMER4_CHCTL1_Output_CH3COMFEN ( -- x addr ) 10 bit TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH3COMFEN, Channel 3 output compare fast enable
: TIMER4_CHCTL1_Output_CH3MS ( %bb -- x addr ) 8 lshift TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH3MS, Channel 3 mode selection
: TIMER4_CHCTL1_Output_CH2COMCEN ( -- x addr ) 7 bit TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH2COMCEN, Channel 2 output compare clear enable
: TIMER4_CHCTL1_Output_CH2COMCTL ( %bbb -- x addr ) 4 lshift TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH2COMCTL, Channel 2 compare output control
: TIMER4_CHCTL1_Output_CH2COMSEN ( -- x addr ) 3 bit TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH2COMSEN, Channel 2 compare output shadow enable
: TIMER4_CHCTL1_Output_CH2COMFEN ( -- x addr ) 2 bit TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH2COMFEN, Channel 2 output compare fast enable
: TIMER4_CHCTL1_Output_CH2MS ( %bb -- x addr ) TIMER4_CHCTL1_Output ; \ TIMER4_CHCTL1_Output_CH2MS, Channel 2 I/O mode selection

\ TIMER4_CHCTL1_Input (read-write) Reset:0x0000
: TIMER4_CHCTL1_Input_CH3CAPFLT ( %bbbb -- x addr ) 12 lshift TIMER4_CHCTL1_Input ; \ TIMER4_CHCTL1_Input_CH3CAPFLT, Channel 3 input capture filter control
: TIMER4_CHCTL1_Input_CH3CAPPSC ( %bb -- x addr ) 10 lshift TIMER4_CHCTL1_Input ; \ TIMER4_CHCTL1_Input_CH3CAPPSC, Channel 3 input capture prescaler
: TIMER4_CHCTL1_Input_CH3MS ( %bb -- x addr ) 8 lshift TIMER4_CHCTL1_Input ; \ TIMER4_CHCTL1_Input_CH3MS, Channel 3 mode selection
: TIMER4_CHCTL1_Input_CH2CAPFLT ( %bbbb -- x addr ) 4 lshift TIMER4_CHCTL1_Input ; \ TIMER4_CHCTL1_Input_CH2CAPFLT, Channel 2 input capture filter control
: TIMER4_CHCTL1_Input_CH2CAPPSC ( %bb -- x addr ) 2 lshift TIMER4_CHCTL1_Input ; \ TIMER4_CHCTL1_Input_CH2CAPPSC, Channel 2 input capture prescaler
: TIMER4_CHCTL1_Input_CH2MS ( %bb -- x addr ) TIMER4_CHCTL1_Input ; \ TIMER4_CHCTL1_Input_CH2MS, Channel 2 mode selection

\ TIMER4_CHCTL2 (read-write) Reset:0x0000
: TIMER4_CHCTL2_CH3P ( -- x addr ) 13 bit TIMER4_CHCTL2 ; \ TIMER4_CHCTL2_CH3P, Channel 3 capture/compare function polarity
: TIMER4_CHCTL2_CH3EN ( -- x addr ) 12 bit TIMER4_CHCTL2 ; \ TIMER4_CHCTL2_CH3EN, Channel 3 capture/compare function enable
: TIMER4_CHCTL2_CH2P ( -- x addr ) 9 bit TIMER4_CHCTL2 ; \ TIMER4_CHCTL2_CH2P, Channel 2 capture/compare function polarity
: TIMER4_CHCTL2_CH2EN ( -- x addr ) 8 bit TIMER4_CHCTL2 ; \ TIMER4_CHCTL2_CH2EN, Channel 2 capture/compare function enable
: TIMER4_CHCTL2_CH1P ( -- x addr ) 5 bit TIMER4_CHCTL2 ; \ TIMER4_CHCTL2_CH1P, Channel 1 capture/compare function polarity
: TIMER4_CHCTL2_CH1EN ( -- x addr ) 4 bit TIMER4_CHCTL2 ; \ TIMER4_CHCTL2_CH1EN, Channel 1 capture/compare function enable
: TIMER4_CHCTL2_CH0P ( -- x addr ) 1 bit TIMER4_CHCTL2 ; \ TIMER4_CHCTL2_CH0P, Channel 0 capture/compare function polarity
: TIMER4_CHCTL2_CH0EN ( -- x addr ) 0 bit TIMER4_CHCTL2 ; \ TIMER4_CHCTL2_CH0EN, Channel 0 capture/compare function enable

\ TIMER4_CNT (read-write) Reset:0x0000
: TIMER4_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER4_CNT ; \ TIMER4_CNT_CNT, counter value

\ TIMER4_PSC (read-write) Reset:0x0000
: TIMER4_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER4_PSC ; \ TIMER4_PSC_PSC, Prescaler value of the counter clock

\ TIMER4_CAR (read-write) Reset:0x0000
: TIMER4_CAR_CARL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER4_CAR ; \ TIMER4_CAR_CARL, Counter auto reload value

\ TIMER4_CH0CV (read-write) Reset:0x00000000
: TIMER4_CH0CV_CH0VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER4_CH0CV ; \ TIMER4_CH0CV_CH0VAL, Capture or compare value of channel 0

\ TIMER4_CH1CV (read-write) Reset:0x00000000
: TIMER4_CH1CV_CH1VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER4_CH1CV ; \ TIMER4_CH1CV_CH1VAL, Capture or compare value of channel1

\ TIMER4_CH2CV (read-write) Reset:0x00000000
: TIMER4_CH2CV_CH2VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER4_CH2CV ; \ TIMER4_CH2CV_CH2VAL, Capture or compare value of channel 2

\ TIMER4_CH3CV (read-write) Reset:0x00000000
: TIMER4_CH3CV_CH3VAL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER4_CH3CV ; \ TIMER4_CH3CV_CH3VAL, Capture or compare value of channel 3

\ TIMER4_DMACFG (read-write) Reset:0x0000
: TIMER4_DMACFG_DMATC ( %bbbbb -- x addr ) 8 lshift TIMER4_DMACFG ; \ TIMER4_DMACFG_DMATC, DMA transfer count
: TIMER4_DMACFG_DMATA ( %bbbbb -- x addr ) TIMER4_DMACFG ; \ TIMER4_DMACFG_DMATA, DMA transfer access start address

\ TIMER4_DMATB (read-write) Reset:0x0000
: TIMER4_DMATB_DMATB ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER4_DMATB ; \ TIMER4_DMATB_DMATB, DMA transfer buffer

\ TIMER5_CTL0 (read-write) Reset:0x0000
: TIMER5_CTL0_ARSE ( -- x addr ) 7 bit TIMER5_CTL0 ; \ TIMER5_CTL0_ARSE, Auto-reload shadow enable
: TIMER5_CTL0_SPM ( -- x addr ) 3 bit TIMER5_CTL0 ; \ TIMER5_CTL0_SPM, Single pulse mode
: TIMER5_CTL0_UPS ( -- x addr ) 2 bit TIMER5_CTL0 ; \ TIMER5_CTL0_UPS, Update source
: TIMER5_CTL0_UPDIS ( -- x addr ) 1 bit TIMER5_CTL0 ; \ TIMER5_CTL0_UPDIS, Update disable
: TIMER5_CTL0_CEN ( -- x addr ) 0 bit TIMER5_CTL0 ; \ TIMER5_CTL0_CEN, Counter enable

\ TIMER5_CTL1 (read-write) Reset:0x0000
: TIMER5_CTL1_MMC ( %bbb -- x addr ) 4 lshift TIMER5_CTL1 ; \ TIMER5_CTL1_MMC, Master mode control

\ TIMER5_DMAINTEN (read-write) Reset:0x0000
: TIMER5_DMAINTEN_UPDEN ( -- x addr ) 8 bit TIMER5_DMAINTEN ; \ TIMER5_DMAINTEN_UPDEN, Update DMA request enable
: TIMER5_DMAINTEN_UPIE ( -- x addr ) 0 bit TIMER5_DMAINTEN ; \ TIMER5_DMAINTEN_UPIE, Update interrupt enable

\ TIMER5_INTF (read-write) Reset:0x0000
: TIMER5_INTF_UPIF ( -- x addr ) 0 bit TIMER5_INTF ; \ TIMER5_INTF_UPIF, Update interrupt flag

\ TIMER5_SWEVG (write-only) Reset:0x0000
: TIMER5_SWEVG_UPG ( -- x addr ) 0 bit TIMER5_SWEVG ; \ TIMER5_SWEVG_UPG, Update generation

\ TIMER5_CNT (read-write) Reset:0x0000
: TIMER5_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER5_CNT ; \ TIMER5_CNT_CNT, Low counter value

\ TIMER5_PSC (read-write) Reset:0x0000
: TIMER5_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER5_PSC ; \ TIMER5_PSC_PSC, Prescaler value of the counter clock

\ TIMER5_CAR (read-write) Reset:0x0000
: TIMER5_CAR_CARL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER5_CAR ; \ TIMER5_CAR_CARL, Counter auto reload value

\ TIMER6_CTL0 (read-write) Reset:0x0000
: TIMER6_CTL0_ARSE ( -- x addr ) 7 bit TIMER6_CTL0 ; \ TIMER6_CTL0_ARSE, Auto-reload shadow enable
: TIMER6_CTL0_SPM ( -- x addr ) 3 bit TIMER6_CTL0 ; \ TIMER6_CTL0_SPM, Single pulse mode
: TIMER6_CTL0_UPS ( -- x addr ) 2 bit TIMER6_CTL0 ; \ TIMER6_CTL0_UPS, Update source
: TIMER6_CTL0_UPDIS ( -- x addr ) 1 bit TIMER6_CTL0 ; \ TIMER6_CTL0_UPDIS, Update disable
: TIMER6_CTL0_CEN ( -- x addr ) 0 bit TIMER6_CTL0 ; \ TIMER6_CTL0_CEN, Counter enable

\ TIMER6_CTL1 (read-write) Reset:0x0000
: TIMER6_CTL1_MMC ( %bbb -- x addr ) 4 lshift TIMER6_CTL1 ; \ TIMER6_CTL1_MMC, Master mode control

\ TIMER6_DMAINTEN (read-write) Reset:0x0000
: TIMER6_DMAINTEN_UPDEN ( -- x addr ) 8 bit TIMER6_DMAINTEN ; \ TIMER6_DMAINTEN_UPDEN, Update DMA request enable
: TIMER6_DMAINTEN_UPIE ( -- x addr ) 0 bit TIMER6_DMAINTEN ; \ TIMER6_DMAINTEN_UPIE, Update interrupt enable

\ TIMER6_INTF (read-write) Reset:0x0000
: TIMER6_INTF_UPIF ( -- x addr ) 0 bit TIMER6_INTF ; \ TIMER6_INTF_UPIF, Update interrupt flag

\ TIMER6_SWEVG (write-only) Reset:0x0000
: TIMER6_SWEVG_UPG ( -- x addr ) 0 bit TIMER6_SWEVG ; \ TIMER6_SWEVG_UPG, Update generation

\ TIMER6_CNT (read-write) Reset:0x0000
: TIMER6_CNT_CNT ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER6_CNT ; \ TIMER6_CNT_CNT, Low counter value

\ TIMER6_PSC (read-write) Reset:0x0000
: TIMER6_PSC_PSC ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER6_PSC ; \ TIMER6_PSC_PSC, Prescaler value of the counter clock

\ TIMER6_CAR (read-write) Reset:0x0000
: TIMER6_CAR_CARL ( %bbbbbbbbbbbbbbbb -- x addr ) TIMER6_CAR ; \ TIMER6_CAR_CARL, Counter auto reload value

\ USART0_STAT (multiple-access)  Reset:0x000000C0
: USART0_STAT_CTSF? ( -- 1|0 ) 9 bit USART0_STAT bit@ ; \ USART0_STAT_CTSF, CTS change flag
: USART0_STAT_LBDF? ( -- 1|0 ) 8 bit USART0_STAT bit@ ; \ USART0_STAT_LBDF, LIN break detection flag
: USART0_STAT_TBE ( -- x addr ) 7 bit USART0_STAT ; \ USART0_STAT_TBE, Transmit data buffer empty
: USART0_STAT_TC ( -- x addr ) 6 bit USART0_STAT ; \ USART0_STAT_TC, Transmission complete
: USART0_STAT_RBNE ( -- x addr ) 5 bit USART0_STAT ; \ USART0_STAT_RBNE, Read data buffer not empty
: USART0_STAT_IDLEF? ( -- 1|0 ) 4 bit USART0_STAT bit@ ; \ USART0_STAT_IDLEF, IDLE frame detected flag
: USART0_STAT_ORERR ( -- x addr ) 3 bit USART0_STAT ; \ USART0_STAT_ORERR, Overrun error
: USART0_STAT_NERR? ( -- 1|0 ) 2 bit USART0_STAT bit@ ; \ USART0_STAT_NERR, Noise error flag
: USART0_STAT_FERR? ( -- 1|0 ) 1 bit USART0_STAT bit@ ; \ USART0_STAT_FERR, Frame error flag
: USART0_STAT_PERR? ( -- 1|0 ) 0 bit USART0_STAT bit@ ; \ USART0_STAT_PERR, Parity error flag

\ USART0_DATA (read-write) Reset:0x00000000
: USART0_DATA_DATA ( %bbbbbbbbb -- x addr ) USART0_DATA ; \ USART0_DATA_DATA, Transmit or read data value

\ USART0_BAUD (read-write) Reset:0x00000000
: USART0_BAUD_INTDIV ( %bbbbbbbbbbb -- x addr ) 4 lshift USART0_BAUD ; \ USART0_BAUD_INTDIV, Integer part of baud-rate divider
: USART0_BAUD_FRADIV ( %bbbb -- x addr ) USART0_BAUD ; \ USART0_BAUD_FRADIV, Fraction part of baud-rate divider

\ USART0_CTL0 (read-write) Reset:0x00000000
: USART0_CTL0_UEN ( -- x addr ) 13 bit USART0_CTL0 ; \ USART0_CTL0_UEN, USART enable
: USART0_CTL0_WL ( -- x addr ) 12 bit USART0_CTL0 ; \ USART0_CTL0_WL, Word length
: USART0_CTL0_WM ( -- x addr ) 11 bit USART0_CTL0 ; \ USART0_CTL0_WM, Wakeup method in mute mode
: USART0_CTL0_PCEN ( -- x addr ) 10 bit USART0_CTL0 ; \ USART0_CTL0_PCEN, Parity check function enable
: USART0_CTL0_PM ( -- x addr ) 9 bit USART0_CTL0 ; \ USART0_CTL0_PM, Parity mode
: USART0_CTL0_PERRIE ( -- x addr ) 8 bit USART0_CTL0 ; \ USART0_CTL0_PERRIE, Parity error interrupt enable
: USART0_CTL0_TBEIE ( -- x addr ) 7 bit USART0_CTL0 ; \ USART0_CTL0_TBEIE, Transmitter buffer empty interrupt enable
: USART0_CTL0_TCIE ( -- x addr ) 6 bit USART0_CTL0 ; \ USART0_CTL0_TCIE, Transmission complete interrupt enable
: USART0_CTL0_RBNEIE ( -- x addr ) 5 bit USART0_CTL0 ; \ USART0_CTL0_RBNEIE, Read data buffer not empty interrupt and overrun error interrupt enable
: USART0_CTL0_IDLEIE ( -- x addr ) 4 bit USART0_CTL0 ; \ USART0_CTL0_IDLEIE, IDLE line detected interrupt enable
: USART0_CTL0_TEN ( -- x addr ) 3 bit USART0_CTL0 ; \ USART0_CTL0_TEN, Transmitter enable
: USART0_CTL0_REN ( -- x addr ) 2 bit USART0_CTL0 ; \ USART0_CTL0_REN, Receiver enable
: USART0_CTL0_RWU ( -- x addr ) 1 bit USART0_CTL0 ; \ USART0_CTL0_RWU, Receiver wakeup from mute mode
: USART0_CTL0_SBKCMD ( -- x addr ) 0 bit USART0_CTL0 ; \ USART0_CTL0_SBKCMD, Send break command

\ USART0_CTL1 (read-write) Reset:0x00000000
: USART0_CTL1_LMEN ( -- x addr ) 14 bit USART0_CTL1 ; \ USART0_CTL1_LMEN, LIN mode enable
: USART0_CTL1_STB ( %bb -- x addr ) 12 lshift USART0_CTL1 ; \ USART0_CTL1_STB, STOP bits length
: USART0_CTL1_CKEN ( -- x addr ) 11 bit USART0_CTL1 ; \ USART0_CTL1_CKEN, CK pin enable
: USART0_CTL1_CPL ( -- x addr ) 10 bit USART0_CTL1 ; \ USART0_CTL1_CPL, Clock polarity
: USART0_CTL1_CPH ( -- x addr ) 9 bit USART0_CTL1 ; \ USART0_CTL1_CPH, Clock phase
: USART0_CTL1_CLEN ( -- x addr ) 8 bit USART0_CTL1 ; \ USART0_CTL1_CLEN, CK Length
: USART0_CTL1_LBDIE ( -- x addr ) 6 bit USART0_CTL1 ; \ USART0_CTL1_LBDIE, LIN break detection interrupt  enable
: USART0_CTL1_LBLEN ( -- x addr ) 5 bit USART0_CTL1 ; \ USART0_CTL1_LBLEN, LIN break frame length
: USART0_CTL1_ADDR ( %bbbb -- x addr ) USART0_CTL1 ; \ USART0_CTL1_ADDR, Address of the USART

\ USART0_CTL2 (read-write) Reset:0x00000000
: USART0_CTL2_CTSIE ( -- x addr ) 10 bit USART0_CTL2 ; \ USART0_CTL2_CTSIE, CTS interrupt enable
: USART0_CTL2_CTSEN ( -- x addr ) 9 bit USART0_CTL2 ; \ USART0_CTL2_CTSEN, CTS enable
: USART0_CTL2_RTSEN ( -- x addr ) 8 bit USART0_CTL2 ; \ USART0_CTL2_RTSEN, RTS enable
: USART0_CTL2_DENT ( -- x addr ) 7 bit USART0_CTL2 ; \ USART0_CTL2_DENT, DMA request enable for transmission
: USART0_CTL2_DENR ( -- x addr ) 6 bit USART0_CTL2 ; \ USART0_CTL2_DENR, DMA request enable for reception
: USART0_CTL2_SCEN ( -- x addr ) 5 bit USART0_CTL2 ; \ USART0_CTL2_SCEN, Smartcard mode enable
: USART0_CTL2_NKEN ( -- x addr ) 4 bit USART0_CTL2 ; \ USART0_CTL2_NKEN, Smartcard NACK enable
: USART0_CTL2_HDEN ( -- x addr ) 3 bit USART0_CTL2 ; \ USART0_CTL2_HDEN, Half-duplex selection
: USART0_CTL2_IRLP ( -- x addr ) 2 bit USART0_CTL2 ; \ USART0_CTL2_IRLP, IrDA low-power
: USART0_CTL2_IREN ( -- x addr ) 1 bit USART0_CTL2 ; \ USART0_CTL2_IREN, IrDA mode enable
: USART0_CTL2_ERRIE ( -- x addr ) 0 bit USART0_CTL2 ; \ USART0_CTL2_ERRIE, Error interrupt enable

\ USART0_GP (read-write) Reset:0x00000000
: USART0_GP_GUAT ( %bbbbbbbb -- x addr ) 8 lshift USART0_GP ; \ USART0_GP_GUAT, Guard time value in Smartcard mode
: USART0_GP_PSC ( %bbbbbbbb -- x addr ) USART0_GP ; \ USART0_GP_PSC, Prescaler value

\ USART1_STAT (multiple-access)  Reset:0x000000C0
: USART1_STAT_CTSF? ( -- 1|0 ) 9 bit USART1_STAT bit@ ; \ USART1_STAT_CTSF, CTS change flag
: USART1_STAT_LBDF? ( -- 1|0 ) 8 bit USART1_STAT bit@ ; \ USART1_STAT_LBDF, LIN break detection flag
: USART1_STAT_TBE ( -- x addr ) 7 bit USART1_STAT ; \ USART1_STAT_TBE, Transmit data buffer empty
: USART1_STAT_TC ( -- x addr ) 6 bit USART1_STAT ; \ USART1_STAT_TC, Transmission complete
: USART1_STAT_RBNE ( -- x addr ) 5 bit USART1_STAT ; \ USART1_STAT_RBNE, Read data buffer not empty
: USART1_STAT_IDLEF? ( -- 1|0 ) 4 bit USART1_STAT bit@ ; \ USART1_STAT_IDLEF, IDLE frame detected flag
: USART1_STAT_ORERR ( -- x addr ) 3 bit USART1_STAT ; \ USART1_STAT_ORERR, Overrun error
: USART1_STAT_NERR? ( -- 1|0 ) 2 bit USART1_STAT bit@ ; \ USART1_STAT_NERR, Noise error flag
: USART1_STAT_FERR? ( -- 1|0 ) 1 bit USART1_STAT bit@ ; \ USART1_STAT_FERR, Frame error flag
: USART1_STAT_PERR? ( -- 1|0 ) 0 bit USART1_STAT bit@ ; \ USART1_STAT_PERR, Parity error flag

\ USART1_DATA (read-write) Reset:0x00000000
: USART1_DATA_DATA ( %bbbbbbbbb -- x addr ) USART1_DATA ; \ USART1_DATA_DATA, Transmit or read data value

\ USART1_BAUD (read-write) Reset:0x00000000
: USART1_BAUD_INTDIV ( %bbbbbbbbbbb -- x addr ) 4 lshift USART1_BAUD ; \ USART1_BAUD_INTDIV, Integer part of baud-rate divider
: USART1_BAUD_FRADIV ( %bbbb -- x addr ) USART1_BAUD ; \ USART1_BAUD_FRADIV, Fraction part of baud-rate divider

\ USART1_CTL0 (read-write) Reset:0x00000000
: USART1_CTL0_UEN ( -- x addr ) 13 bit USART1_CTL0 ; \ USART1_CTL0_UEN, USART enable
: USART1_CTL0_WL ( -- x addr ) 12 bit USART1_CTL0 ; \ USART1_CTL0_WL, Word length
: USART1_CTL0_WM ( -- x addr ) 11 bit USART1_CTL0 ; \ USART1_CTL0_WM, Wakeup method in mute mode
: USART1_CTL0_PCEN ( -- x addr ) 10 bit USART1_CTL0 ; \ USART1_CTL0_PCEN, Parity check function enable
: USART1_CTL0_PM ( -- x addr ) 9 bit USART1_CTL0 ; \ USART1_CTL0_PM, Parity mode
: USART1_CTL0_PERRIE ( -- x addr ) 8 bit USART1_CTL0 ; \ USART1_CTL0_PERRIE, Parity error interrupt enable
: USART1_CTL0_TBEIE ( -- x addr ) 7 bit USART1_CTL0 ; \ USART1_CTL0_TBEIE, Transmitter buffer empty interrupt enable
: USART1_CTL0_TCIE ( -- x addr ) 6 bit USART1_CTL0 ; \ USART1_CTL0_TCIE, Transmission complete interrupt enable
: USART1_CTL0_RBNEIE ( -- x addr ) 5 bit USART1_CTL0 ; \ USART1_CTL0_RBNEIE, Read data buffer not empty interrupt and overrun error interrupt enable
: USART1_CTL0_IDLEIE ( -- x addr ) 4 bit USART1_CTL0 ; \ USART1_CTL0_IDLEIE, IDLE line detected interrupt enable
: USART1_CTL0_TEN ( -- x addr ) 3 bit USART1_CTL0 ; \ USART1_CTL0_TEN, Transmitter enable
: USART1_CTL0_REN ( -- x addr ) 2 bit USART1_CTL0 ; \ USART1_CTL0_REN, Receiver enable
: USART1_CTL0_RWU ( -- x addr ) 1 bit USART1_CTL0 ; \ USART1_CTL0_RWU, Receiver wakeup from mute mode
: USART1_CTL0_SBKCMD ( -- x addr ) 0 bit USART1_CTL0 ; \ USART1_CTL0_SBKCMD, Send break command

\ USART1_CTL1 (read-write) Reset:0x00000000
: USART1_CTL1_LMEN ( -- x addr ) 14 bit USART1_CTL1 ; \ USART1_CTL1_LMEN, LIN mode enable
: USART1_CTL1_STB ( %bb -- x addr ) 12 lshift USART1_CTL1 ; \ USART1_CTL1_STB, STOP bits length
: USART1_CTL1_CKEN ( -- x addr ) 11 bit USART1_CTL1 ; \ USART1_CTL1_CKEN, CK pin enable
: USART1_CTL1_CPL ( -- x addr ) 10 bit USART1_CTL1 ; \ USART1_CTL1_CPL, Clock polarity
: USART1_CTL1_CPH ( -- x addr ) 9 bit USART1_CTL1 ; \ USART1_CTL1_CPH, Clock phase
: USART1_CTL1_CLEN ( -- x addr ) 8 bit USART1_CTL1 ; \ USART1_CTL1_CLEN, CK Length
: USART1_CTL1_LBDIE ( -- x addr ) 6 bit USART1_CTL1 ; \ USART1_CTL1_LBDIE, LIN break detection interrupt  enable
: USART1_CTL1_LBLEN ( -- x addr ) 5 bit USART1_CTL1 ; \ USART1_CTL1_LBLEN, LIN break frame length
: USART1_CTL1_ADDR ( %bbbb -- x addr ) USART1_CTL1 ; \ USART1_CTL1_ADDR, Address of the USART

\ USART1_CTL2 (read-write) Reset:0x00000000
: USART1_CTL2_CTSIE ( -- x addr ) 10 bit USART1_CTL2 ; \ USART1_CTL2_CTSIE, CTS interrupt enable
: USART1_CTL2_CTSEN ( -- x addr ) 9 bit USART1_CTL2 ; \ USART1_CTL2_CTSEN, CTS enable
: USART1_CTL2_RTSEN ( -- x addr ) 8 bit USART1_CTL2 ; \ USART1_CTL2_RTSEN, RTS enable
: USART1_CTL2_DENT ( -- x addr ) 7 bit USART1_CTL2 ; \ USART1_CTL2_DENT, DMA request enable for transmission
: USART1_CTL2_DENR ( -- x addr ) 6 bit USART1_CTL2 ; \ USART1_CTL2_DENR, DMA request enable for reception
: USART1_CTL2_SCEN ( -- x addr ) 5 bit USART1_CTL2 ; \ USART1_CTL2_SCEN, Smartcard mode enable
: USART1_CTL2_NKEN ( -- x addr ) 4 bit USART1_CTL2 ; \ USART1_CTL2_NKEN, Smartcard NACK enable
: USART1_CTL2_HDEN ( -- x addr ) 3 bit USART1_CTL2 ; \ USART1_CTL2_HDEN, Half-duplex selection
: USART1_CTL2_IRLP ( -- x addr ) 2 bit USART1_CTL2 ; \ USART1_CTL2_IRLP, IrDA low-power
: USART1_CTL2_IREN ( -- x addr ) 1 bit USART1_CTL2 ; \ USART1_CTL2_IREN, IrDA mode enable
: USART1_CTL2_ERRIE ( -- x addr ) 0 bit USART1_CTL2 ; \ USART1_CTL2_ERRIE, Error interrupt enable

\ USART1_GP (read-write) Reset:0x00000000
: USART1_GP_GUAT ( %bbbbbbbb -- x addr ) 8 lshift USART1_GP ; \ USART1_GP_GUAT, Guard time value in Smartcard mode
: USART1_GP_PSC ( %bbbbbbbb -- x addr ) USART1_GP ; \ USART1_GP_PSC, Prescaler value

\ USART2_STAT (multiple-access)  Reset:0x000000C0
: USART2_STAT_CTSF? ( -- 1|0 ) 9 bit USART2_STAT bit@ ; \ USART2_STAT_CTSF, CTS change flag
: USART2_STAT_LBDF? ( -- 1|0 ) 8 bit USART2_STAT bit@ ; \ USART2_STAT_LBDF, LIN break detection flag
: USART2_STAT_TBE ( -- x addr ) 7 bit USART2_STAT ; \ USART2_STAT_TBE, Transmit data buffer empty
: USART2_STAT_TC ( -- x addr ) 6 bit USART2_STAT ; \ USART2_STAT_TC, Transmission complete
: USART2_STAT_RBNE ( -- x addr ) 5 bit USART2_STAT ; \ USART2_STAT_RBNE, Read data buffer not empty
: USART2_STAT_IDLEF? ( -- 1|0 ) 4 bit USART2_STAT bit@ ; \ USART2_STAT_IDLEF, IDLE frame detected flag
: USART2_STAT_ORERR ( -- x addr ) 3 bit USART2_STAT ; \ USART2_STAT_ORERR, Overrun error
: USART2_STAT_NERR? ( -- 1|0 ) 2 bit USART2_STAT bit@ ; \ USART2_STAT_NERR, Noise error flag
: USART2_STAT_FERR? ( -- 1|0 ) 1 bit USART2_STAT bit@ ; \ USART2_STAT_FERR, Frame error flag
: USART2_STAT_PERR? ( -- 1|0 ) 0 bit USART2_STAT bit@ ; \ USART2_STAT_PERR, Parity error flag

\ USART2_DATA (read-write) Reset:0x00000000
: USART2_DATA_DATA ( %bbbbbbbbb -- x addr ) USART2_DATA ; \ USART2_DATA_DATA, Transmit or read data value

\ USART2_BAUD (read-write) Reset:0x00000000
: USART2_BAUD_INTDIV ( %bbbbbbbbbbb -- x addr ) 4 lshift USART2_BAUD ; \ USART2_BAUD_INTDIV, Integer part of baud-rate divider
: USART2_BAUD_FRADIV ( %bbbb -- x addr ) USART2_BAUD ; \ USART2_BAUD_FRADIV, Fraction part of baud-rate divider

\ USART2_CTL0 (read-write) Reset:0x00000000
: USART2_CTL0_UEN ( -- x addr ) 13 bit USART2_CTL0 ; \ USART2_CTL0_UEN, USART enable
: USART2_CTL0_WL ( -- x addr ) 12 bit USART2_CTL0 ; \ USART2_CTL0_WL, Word length
: USART2_CTL0_WM ( -- x addr ) 11 bit USART2_CTL0 ; \ USART2_CTL0_WM, Wakeup method in mute mode
: USART2_CTL0_PCEN ( -- x addr ) 10 bit USART2_CTL0 ; \ USART2_CTL0_PCEN, Parity check function enable
: USART2_CTL0_PM ( -- x addr ) 9 bit USART2_CTL0 ; \ USART2_CTL0_PM, Parity mode
: USART2_CTL0_PERRIE ( -- x addr ) 8 bit USART2_CTL0 ; \ USART2_CTL0_PERRIE, Parity error interrupt enable
: USART2_CTL0_TBEIE ( -- x addr ) 7 bit USART2_CTL0 ; \ USART2_CTL0_TBEIE, Transmitter buffer empty interrupt enable
: USART2_CTL0_TCIE ( -- x addr ) 6 bit USART2_CTL0 ; \ USART2_CTL0_TCIE, Transmission complete interrupt enable
: USART2_CTL0_RBNEIE ( -- x addr ) 5 bit USART2_CTL0 ; \ USART2_CTL0_RBNEIE, Read data buffer not empty interrupt and overrun error interrupt enable
: USART2_CTL0_IDLEIE ( -- x addr ) 4 bit USART2_CTL0 ; \ USART2_CTL0_IDLEIE, IDLE line detected interrupt enable
: USART2_CTL0_TEN ( -- x addr ) 3 bit USART2_CTL0 ; \ USART2_CTL0_TEN, Transmitter enable
: USART2_CTL0_REN ( -- x addr ) 2 bit USART2_CTL0 ; \ USART2_CTL0_REN, Receiver enable
: USART2_CTL0_RWU ( -- x addr ) 1 bit USART2_CTL0 ; \ USART2_CTL0_RWU, Receiver wakeup from mute mode
: USART2_CTL0_SBKCMD ( -- x addr ) 0 bit USART2_CTL0 ; \ USART2_CTL0_SBKCMD, Send break command

\ USART2_CTL1 (read-write) Reset:0x00000000
: USART2_CTL1_LMEN ( -- x addr ) 14 bit USART2_CTL1 ; \ USART2_CTL1_LMEN, LIN mode enable
: USART2_CTL1_STB ( %bb -- x addr ) 12 lshift USART2_CTL1 ; \ USART2_CTL1_STB, STOP bits length
: USART2_CTL1_CKEN ( -- x addr ) 11 bit USART2_CTL1 ; \ USART2_CTL1_CKEN, CK pin enable
: USART2_CTL1_CPL ( -- x addr ) 10 bit USART2_CTL1 ; \ USART2_CTL1_CPL, Clock polarity
: USART2_CTL1_CPH ( -- x addr ) 9 bit USART2_CTL1 ; \ USART2_CTL1_CPH, Clock phase
: USART2_CTL1_CLEN ( -- x addr ) 8 bit USART2_CTL1 ; \ USART2_CTL1_CLEN, CK Length
: USART2_CTL1_LBDIE ( -- x addr ) 6 bit USART2_CTL1 ; \ USART2_CTL1_LBDIE, LIN break detection interrupt  enable
: USART2_CTL1_LBLEN ( -- x addr ) 5 bit USART2_CTL1 ; \ USART2_CTL1_LBLEN, LIN break frame length
: USART2_CTL1_ADDR ( %bbbb -- x addr ) USART2_CTL1 ; \ USART2_CTL1_ADDR, Address of the USART

\ USART2_CTL2 (read-write) Reset:0x00000000
: USART2_CTL2_CTSIE ( -- x addr ) 10 bit USART2_CTL2 ; \ USART2_CTL2_CTSIE, CTS interrupt enable
: USART2_CTL2_CTSEN ( -- x addr ) 9 bit USART2_CTL2 ; \ USART2_CTL2_CTSEN, CTS enable
: USART2_CTL2_RTSEN ( -- x addr ) 8 bit USART2_CTL2 ; \ USART2_CTL2_RTSEN, RTS enable
: USART2_CTL2_DENT ( -- x addr ) 7 bit USART2_CTL2 ; \ USART2_CTL2_DENT, DMA request enable for transmission
: USART2_CTL2_DENR ( -- x addr ) 6 bit USART2_CTL2 ; \ USART2_CTL2_DENR, DMA request enable for reception
: USART2_CTL2_SCEN ( -- x addr ) 5 bit USART2_CTL2 ; \ USART2_CTL2_SCEN, Smartcard mode enable
: USART2_CTL2_NKEN ( -- x addr ) 4 bit USART2_CTL2 ; \ USART2_CTL2_NKEN, Smartcard NACK enable
: USART2_CTL2_HDEN ( -- x addr ) 3 bit USART2_CTL2 ; \ USART2_CTL2_HDEN, Half-duplex selection
: USART2_CTL2_IRLP ( -- x addr ) 2 bit USART2_CTL2 ; \ USART2_CTL2_IRLP, IrDA low-power
: USART2_CTL2_IREN ( -- x addr ) 1 bit USART2_CTL2 ; \ USART2_CTL2_IREN, IrDA mode enable
: USART2_CTL2_ERRIE ( -- x addr ) 0 bit USART2_CTL2 ; \ USART2_CTL2_ERRIE, Error interrupt enable

\ USART2_GP (read-write) Reset:0x00000000
: USART2_GP_GUAT ( %bbbbbbbb -- x addr ) 8 lshift USART2_GP ; \ USART2_GP_GUAT, Guard time value in Smartcard mode
: USART2_GP_PSC ( %bbbbbbbb -- x addr ) USART2_GP ; \ USART2_GP_PSC, Prescaler value

\ UART3_STAT (multiple-access)  Reset:0x000000C0
: UART3_STAT_LBDF? ( -- 1|0 ) 8 bit UART3_STAT bit@ ; \ UART3_STAT_LBDF, LIN break detection flag
: UART3_STAT_TBE ( -- x addr ) 7 bit UART3_STAT ; \ UART3_STAT_TBE, Transmit data buffer empty
: UART3_STAT_TC ( -- x addr ) 6 bit UART3_STAT ; \ UART3_STAT_TC, Transmission complete
: UART3_STAT_RBNE ( -- x addr ) 5 bit UART3_STAT ; \ UART3_STAT_RBNE, Read data buffer not empty
: UART3_STAT_IDLEF? ( -- 1|0 ) 4 bit UART3_STAT bit@ ; \ UART3_STAT_IDLEF, IDLE frame detected flag
: UART3_STAT_ORERR ( -- x addr ) 3 bit UART3_STAT ; \ UART3_STAT_ORERR, Overrun error
: UART3_STAT_NERR? ( -- 1|0 ) 2 bit UART3_STAT bit@ ; \ UART3_STAT_NERR, Noise error flag
: UART3_STAT_FERR? ( -- 1|0 ) 1 bit UART3_STAT bit@ ; \ UART3_STAT_FERR, Frame error flag
: UART3_STAT_PERR? ( -- 1|0 ) 0 bit UART3_STAT bit@ ; \ UART3_STAT_PERR, Parity error flag

\ UART3_DATA (read-write) Reset:0x00000000
: UART3_DATA_DATA ( %bbbbbbbbb -- x addr ) UART3_DATA ; \ UART3_DATA_DATA, Transmit or read data value

\ UART3_BAUD (read-write) Reset:0x00000000
: UART3_BAUD_INTDIV ( %bbbbbbbbbbb -- x addr ) 4 lshift UART3_BAUD ; \ UART3_BAUD_INTDIV, Integer part of baud-rate divider
: UART3_BAUD_FRADIV ( %bbbb -- x addr ) UART3_BAUD ; \ UART3_BAUD_FRADIV, Fraction part of baud-rate divider

\ UART3_CTL0 (read-write) Reset:0x00000000
: UART3_CTL0_UEN ( -- x addr ) 13 bit UART3_CTL0 ; \ UART3_CTL0_UEN, USART enable
: UART3_CTL0_WL ( -- x addr ) 12 bit UART3_CTL0 ; \ UART3_CTL0_WL, Word length
: UART3_CTL0_WM ( -- x addr ) 11 bit UART3_CTL0 ; \ UART3_CTL0_WM, Wakeup method in mute mode
: UART3_CTL0_PCEN ( -- x addr ) 10 bit UART3_CTL0 ; \ UART3_CTL0_PCEN, Parity check function enable
: UART3_CTL0_PM ( -- x addr ) 9 bit UART3_CTL0 ; \ UART3_CTL0_PM, Parity mode
: UART3_CTL0_PERRIE ( -- x addr ) 8 bit UART3_CTL0 ; \ UART3_CTL0_PERRIE, Parity error interrupt enable
: UART3_CTL0_TBEIE ( -- x addr ) 7 bit UART3_CTL0 ; \ UART3_CTL0_TBEIE, Transmitter buffer empty interrupt enable
: UART3_CTL0_TCIE ( -- x addr ) 6 bit UART3_CTL0 ; \ UART3_CTL0_TCIE, Transmission complete interrupt enable
: UART3_CTL0_RBNEIE ( -- x addr ) 5 bit UART3_CTL0 ; \ UART3_CTL0_RBNEIE, Read data buffer not empty interrupt and overrun error interrupt enable
: UART3_CTL0_IDLEIE ( -- x addr ) 4 bit UART3_CTL0 ; \ UART3_CTL0_IDLEIE, IDLE line detected interrupt enable
: UART3_CTL0_TEN ( -- x addr ) 3 bit UART3_CTL0 ; \ UART3_CTL0_TEN, Transmitter enable
: UART3_CTL0_REN ( -- x addr ) 2 bit UART3_CTL0 ; \ UART3_CTL0_REN, Receiver enable
: UART3_CTL0_RWU ( -- x addr ) 1 bit UART3_CTL0 ; \ UART3_CTL0_RWU, Receiver wakeup from mute mode
: UART3_CTL0_SBKCMD ( -- x addr ) 0 bit UART3_CTL0 ; \ UART3_CTL0_SBKCMD, Send break command

\ UART3_CTL1 (read-write) Reset:0x00000000
: UART3_CTL1_LMEN ( -- x addr ) 14 bit UART3_CTL1 ; \ UART3_CTL1_LMEN, LIN mode enable
: UART3_CTL1_STB ( %bb -- x addr ) 12 lshift UART3_CTL1 ; \ UART3_CTL1_STB, STOP bits length
: UART3_CTL1_LBDIE ( -- x addr ) 6 bit UART3_CTL1 ; \ UART3_CTL1_LBDIE, LIN break detection interrupt  enable
: UART3_CTL1_LBLEN ( -- x addr ) 5 bit UART3_CTL1 ; \ UART3_CTL1_LBLEN, LIN break frame length
: UART3_CTL1_ADDR ( %bbbb -- x addr ) UART3_CTL1 ; \ UART3_CTL1_ADDR, Address of the USART

\ UART3_CTL2 (read-write) Reset:0x00000000
: UART3_CTL2_DENT ( -- x addr ) 7 bit UART3_CTL2 ; \ UART3_CTL2_DENT, DMA request enable for transmission
: UART3_CTL2_DENR ( -- x addr ) 6 bit UART3_CTL2 ; \ UART3_CTL2_DENR, DMA request enable for reception
: UART3_CTL2_HDEN ( -- x addr ) 3 bit UART3_CTL2 ; \ UART3_CTL2_HDEN, Half-duplex selection
: UART3_CTL2_IRLP ( -- x addr ) 2 bit UART3_CTL2 ; \ UART3_CTL2_IRLP, IrDA low-power
: UART3_CTL2_IREN ( -- x addr ) 1 bit UART3_CTL2 ; \ UART3_CTL2_IREN, IrDA mode enable
: UART3_CTL2_ERRIE ( -- x addr ) 0 bit UART3_CTL2 ; \ UART3_CTL2_ERRIE, Error interrupt enable

\ UART3_GP (read-write) Reset:0x00000000
: UART3_GP_PSC ( %bbbbbbbb -- x addr ) UART3_GP ; \ UART3_GP_PSC, Prescaler value

\ UART4_STAT (multiple-access)  Reset:0x000000C0
: UART4_STAT_LBDF? ( -- 1|0 ) 8 bit UART4_STAT bit@ ; \ UART4_STAT_LBDF, LIN break detection flag
: UART4_STAT_TBE ( -- x addr ) 7 bit UART4_STAT ; \ UART4_STAT_TBE, Transmit data buffer empty
: UART4_STAT_TC ( -- x addr ) 6 bit UART4_STAT ; \ UART4_STAT_TC, Transmission complete
: UART4_STAT_RBNE ( -- x addr ) 5 bit UART4_STAT ; \ UART4_STAT_RBNE, Read data buffer not empty
: UART4_STAT_IDLEF? ( -- 1|0 ) 4 bit UART4_STAT bit@ ; \ UART4_STAT_IDLEF, IDLE frame detected flag
: UART4_STAT_ORERR ( -- x addr ) 3 bit UART4_STAT ; \ UART4_STAT_ORERR, Overrun error
: UART4_STAT_NERR? ( -- 1|0 ) 2 bit UART4_STAT bit@ ; \ UART4_STAT_NERR, Noise error flag
: UART4_STAT_FERR? ( -- 1|0 ) 1 bit UART4_STAT bit@ ; \ UART4_STAT_FERR, Frame error flag
: UART4_STAT_PERR? ( -- 1|0 ) 0 bit UART4_STAT bit@ ; \ UART4_STAT_PERR, Parity error flag

\ UART4_DATA (read-write) Reset:0x00000000
: UART4_DATA_DATA ( %bbbbbbbbb -- x addr ) UART4_DATA ; \ UART4_DATA_DATA, Transmit or read data value

\ UART4_BAUD (read-write) Reset:0x00000000
: UART4_BAUD_INTDIV ( %bbbbbbbbbbb -- x addr ) 4 lshift UART4_BAUD ; \ UART4_BAUD_INTDIV, Integer part of baud-rate divider
: UART4_BAUD_FRADIV ( %bbbb -- x addr ) UART4_BAUD ; \ UART4_BAUD_FRADIV, Fraction part of baud-rate divider

\ UART4_CTL0 (read-write) Reset:0x00000000
: UART4_CTL0_UEN ( -- x addr ) 13 bit UART4_CTL0 ; \ UART4_CTL0_UEN, USART enable
: UART4_CTL0_WL ( -- x addr ) 12 bit UART4_CTL0 ; \ UART4_CTL0_WL, Word length
: UART4_CTL0_WM ( -- x addr ) 11 bit UART4_CTL0 ; \ UART4_CTL0_WM, Wakeup method in mute mode
: UART4_CTL0_PCEN ( -- x addr ) 10 bit UART4_CTL0 ; \ UART4_CTL0_PCEN, Parity check function enable
: UART4_CTL0_PM ( -- x addr ) 9 bit UART4_CTL0 ; \ UART4_CTL0_PM, Parity mode
: UART4_CTL0_PERRIE ( -- x addr ) 8 bit UART4_CTL0 ; \ UART4_CTL0_PERRIE, Parity error interrupt enable
: UART4_CTL0_TBEIE ( -- x addr ) 7 bit UART4_CTL0 ; \ UART4_CTL0_TBEIE, Transmitter buffer empty interrupt enable
: UART4_CTL0_TCIE ( -- x addr ) 6 bit UART4_CTL0 ; \ UART4_CTL0_TCIE, Transmission complete interrupt enable
: UART4_CTL0_RBNEIE ( -- x addr ) 5 bit UART4_CTL0 ; \ UART4_CTL0_RBNEIE, Read data buffer not empty interrupt and overrun error interrupt enable
: UART4_CTL0_IDLEIE ( -- x addr ) 4 bit UART4_CTL0 ; \ UART4_CTL0_IDLEIE, IDLE line detected interrupt enable
: UART4_CTL0_TEN ( -- x addr ) 3 bit UART4_CTL0 ; \ UART4_CTL0_TEN, Transmitter enable
: UART4_CTL0_REN ( -- x addr ) 2 bit UART4_CTL0 ; \ UART4_CTL0_REN, Receiver enable
: UART4_CTL0_RWU ( -- x addr ) 1 bit UART4_CTL0 ; \ UART4_CTL0_RWU, Receiver wakeup from mute mode
: UART4_CTL0_SBKCMD ( -- x addr ) 0 bit UART4_CTL0 ; \ UART4_CTL0_SBKCMD, Send break command

\ UART4_CTL1 (read-write) Reset:0x00000000
: UART4_CTL1_LMEN ( -- x addr ) 14 bit UART4_CTL1 ; \ UART4_CTL1_LMEN, LIN mode enable
: UART4_CTL1_STB ( %bb -- x addr ) 12 lshift UART4_CTL1 ; \ UART4_CTL1_STB, STOP bits length
: UART4_CTL1_LBDIE ( -- x addr ) 6 bit UART4_CTL1 ; \ UART4_CTL1_LBDIE, LIN break detection interrupt  enable
: UART4_CTL1_LBLEN ( -- x addr ) 5 bit UART4_CTL1 ; \ UART4_CTL1_LBLEN, LIN break frame length
: UART4_CTL1_ADDR ( %bbbb -- x addr ) UART4_CTL1 ; \ UART4_CTL1_ADDR, Address of the USART

\ UART4_CTL2 (read-write) Reset:0x00000000
: UART4_CTL2_DENT ( -- x addr ) 7 bit UART4_CTL2 ; \ UART4_CTL2_DENT, DMA request enable for transmission
: UART4_CTL2_DENR ( -- x addr ) 6 bit UART4_CTL2 ; \ UART4_CTL2_DENR, DMA request enable for reception
: UART4_CTL2_HDEN ( -- x addr ) 3 bit UART4_CTL2 ; \ UART4_CTL2_HDEN, Half-duplex selection
: UART4_CTL2_IRLP ( -- x addr ) 2 bit UART4_CTL2 ; \ UART4_CTL2_IRLP, IrDA low-power
: UART4_CTL2_IREN ( -- x addr ) 1 bit UART4_CTL2 ; \ UART4_CTL2_IREN, IrDA mode enable
: UART4_CTL2_ERRIE ( -- x addr ) 0 bit UART4_CTL2 ; \ UART4_CTL2_ERRIE, Error interrupt enable

\ UART4_GP (read-write) Reset:0x00000000
: UART4_GP_PSC ( %bbbbbbbb -- x addr ) UART4_GP ; \ UART4_GP_PSC, Prescaler value

\ USBFS_GLOBAL_GOTGCS (multiple-access)  Reset:0x00000800
: USBFS_GLOBAL_GOTGCS_SRPS ( -- x addr ) 0 bit USBFS_GLOBAL_GOTGCS ; \ USBFS_GLOBAL_GOTGCS_SRPS, SRP success
: USBFS_GLOBAL_GOTGCS_SRPREQ ( -- x addr ) 1 bit USBFS_GLOBAL_GOTGCS ; \ USBFS_GLOBAL_GOTGCS_SRPREQ, SRP request
: USBFS_GLOBAL_GOTGCS_HNPS ( -- x addr ) 8 bit USBFS_GLOBAL_GOTGCS ; \ USBFS_GLOBAL_GOTGCS_HNPS, Host success
: USBFS_GLOBAL_GOTGCS_HNPREQ ( -- x addr ) 9 bit USBFS_GLOBAL_GOTGCS ; \ USBFS_GLOBAL_GOTGCS_HNPREQ, HNP request
: USBFS_GLOBAL_GOTGCS_HHNPEN ( -- x addr ) 10 bit USBFS_GLOBAL_GOTGCS ; \ USBFS_GLOBAL_GOTGCS_HHNPEN, Host HNP enable
: USBFS_GLOBAL_GOTGCS_DHNPEN ( -- x addr ) 11 bit USBFS_GLOBAL_GOTGCS ; \ USBFS_GLOBAL_GOTGCS_DHNPEN, Device HNP enabled
: USBFS_GLOBAL_GOTGCS_IDPS? ( -- 1|0 ) 16 bit USBFS_GLOBAL_GOTGCS bit@ ; \ USBFS_GLOBAL_GOTGCS_IDPS, ID pin status
: USBFS_GLOBAL_GOTGCS_DI ( -- x addr ) 17 bit USBFS_GLOBAL_GOTGCS ; \ USBFS_GLOBAL_GOTGCS_DI, Debounce interval
: USBFS_GLOBAL_GOTGCS_ASV ( -- x addr ) 18 bit USBFS_GLOBAL_GOTGCS ; \ USBFS_GLOBAL_GOTGCS_ASV, A-session valid
: USBFS_GLOBAL_GOTGCS_BSV ( -- x addr ) 19 bit USBFS_GLOBAL_GOTGCS ; \ USBFS_GLOBAL_GOTGCS_BSV, B-session valid

\ USBFS_GLOBAL_GOTGINTF (read-write) Reset:0x00000000
: USBFS_GLOBAL_GOTGINTF_SESEND ( -- x addr ) 2 bit USBFS_GLOBAL_GOTGINTF ; \ USBFS_GLOBAL_GOTGINTF_SESEND, Session end 
: USBFS_GLOBAL_GOTGINTF_SRPEND ( -- x addr ) 8 bit USBFS_GLOBAL_GOTGINTF ; \ USBFS_GLOBAL_GOTGINTF_SRPEND, Session request success status  change
: USBFS_GLOBAL_GOTGINTF_HNPEND ( -- x addr ) 9 bit USBFS_GLOBAL_GOTGINTF ; \ USBFS_GLOBAL_GOTGINTF_HNPEND, HNP end
: USBFS_GLOBAL_GOTGINTF_HNPDET ( -- x addr ) 17 bit USBFS_GLOBAL_GOTGINTF ; \ USBFS_GLOBAL_GOTGINTF_HNPDET, Host negotiation request detected
: USBFS_GLOBAL_GOTGINTF_ADTO ( -- x addr ) 18 bit USBFS_GLOBAL_GOTGINTF ; \ USBFS_GLOBAL_GOTGINTF_ADTO, A-device timeout
: USBFS_GLOBAL_GOTGINTF_DF ( -- x addr ) 19 bit USBFS_GLOBAL_GOTGINTF ; \ USBFS_GLOBAL_GOTGINTF_DF, Debounce finish

\ USBFS_GLOBAL_GAHBCS (read-write) Reset:0x00000000
: USBFS_GLOBAL_GAHBCS_GINTEN ( -- x addr ) 0 bit USBFS_GLOBAL_GAHBCS ; \ USBFS_GLOBAL_GAHBCS_GINTEN, Global interrupt enable
: USBFS_GLOBAL_GAHBCS_TXFTH ( -- x addr ) 7 bit USBFS_GLOBAL_GAHBCS ; \ USBFS_GLOBAL_GAHBCS_TXFTH, Tx FIFO threshold
: USBFS_GLOBAL_GAHBCS_PTXFTH ( -- x addr ) 8 bit USBFS_GLOBAL_GAHBCS ; \ USBFS_GLOBAL_GAHBCS_PTXFTH, Periodic Tx FIFO threshold

\ USBFS_GLOBAL_GUSBCS (multiple-access)  Reset:0x00000A80
: USBFS_GLOBAL_GUSBCS_TOC ( %bbb -- x addr ) USBFS_GLOBAL_GUSBCS ; \ USBFS_GLOBAL_GUSBCS_TOC, Timeout calibration
: USBFS_GLOBAL_GUSBCS_SRPCEN ( -- x addr ) 8 bit USBFS_GLOBAL_GUSBCS ; \ USBFS_GLOBAL_GUSBCS_SRPCEN, SRP capability enable
: USBFS_GLOBAL_GUSBCS_HNPCEN ( -- x addr ) 9 bit USBFS_GLOBAL_GUSBCS ; \ USBFS_GLOBAL_GUSBCS_HNPCEN, HNP capability enable
: USBFS_GLOBAL_GUSBCS_UTT ( %bbbb -- x addr ) 10 lshift USBFS_GLOBAL_GUSBCS ; \ USBFS_GLOBAL_GUSBCS_UTT, USB turnaround time
: USBFS_GLOBAL_GUSBCS_FHM ( -- x addr ) 29 bit USBFS_GLOBAL_GUSBCS ; \ USBFS_GLOBAL_GUSBCS_FHM, Force host mode
: USBFS_GLOBAL_GUSBCS_FDM ( -- x addr ) 30 bit USBFS_GLOBAL_GUSBCS ; \ USBFS_GLOBAL_GUSBCS_FDM, Force device mode

\ USBFS_GLOBAL_GRSTCTL (multiple-access)  Reset:0x80000000
: USBFS_GLOBAL_GRSTCTL_CSRST ( -- x addr ) 0 bit USBFS_GLOBAL_GRSTCTL ; \ USBFS_GLOBAL_GRSTCTL_CSRST, Core soft reset
: USBFS_GLOBAL_GRSTCTL_HCSRST ( -- x addr ) 1 bit USBFS_GLOBAL_GRSTCTL ; \ USBFS_GLOBAL_GRSTCTL_HCSRST, HCLK soft reset
: USBFS_GLOBAL_GRSTCTL_HFCRST ( -- x addr ) 2 bit USBFS_GLOBAL_GRSTCTL ; \ USBFS_GLOBAL_GRSTCTL_HFCRST, Host frame counter reset
: USBFS_GLOBAL_GRSTCTL_RXFF ( -- x addr ) 4 bit USBFS_GLOBAL_GRSTCTL ; \ USBFS_GLOBAL_GRSTCTL_RXFF, RxFIFO flush
: USBFS_GLOBAL_GRSTCTL_TXFF ( -- x addr ) 5 bit USBFS_GLOBAL_GRSTCTL ; \ USBFS_GLOBAL_GRSTCTL_TXFF, TxFIFO flush
: USBFS_GLOBAL_GRSTCTL_TXFNUM ( %bbbbb -- x addr ) 6 lshift USBFS_GLOBAL_GRSTCTL ; \ USBFS_GLOBAL_GRSTCTL_TXFNUM, TxFIFO number

\ USBFS_GLOBAL_GINTF (multiple-access)  Reset:0x04000021
: USBFS_GLOBAL_GINTF_COPM ( -- x addr ) 0 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_COPM, Current operation mode
: USBFS_GLOBAL_GINTF_MFIF? ( -- 1|0 ) 1 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_MFIF, Mode fault interrupt flag
: USBFS_GLOBAL_GINTF_OTGIF? ( -- 1|0 ) 2 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_OTGIF, OTG interrupt flag
: USBFS_GLOBAL_GINTF_SOF ( -- x addr ) 3 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_SOF, Start of frame
: USBFS_GLOBAL_GINTF_RXFNEIF? ( -- 1|0 ) 4 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_RXFNEIF, RxFIFO non-empty interrupt flag
: USBFS_GLOBAL_GINTF_NPTXFEIF? ( -- 1|0 ) 5 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_NPTXFEIF, Non-periodic TxFIFO empty interrupt flag
: USBFS_GLOBAL_GINTF_GNPINAK ( -- x addr ) 6 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_GNPINAK, Global Non-Periodic IN NAK effective
: USBFS_GLOBAL_GINTF_GONAK ( -- x addr ) 7 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_GONAK, Global OUT NAK effective
: USBFS_GLOBAL_GINTF_ESP ( -- x addr ) 10 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_ESP, Early suspend
: USBFS_GLOBAL_GINTF_SP ( -- x addr ) 11 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_SP, USB suspend
: USBFS_GLOBAL_GINTF_RST ( -- x addr ) 12 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_RST, USB reset
: USBFS_GLOBAL_GINTF_ENUMF ( -- x addr ) 13 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_ENUMF, Enumeration finished
: USBFS_GLOBAL_GINTF_ISOOPDIF ( -- x addr ) 14 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_ISOOPDIF, Isochronous OUT packet dropped  interrupt
: USBFS_GLOBAL_GINTF_EOPFIF? ( -- 1|0 ) 15 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_EOPFIF, End of periodic frame  interrupt flag
: USBFS_GLOBAL_GINTF_IEPIF? ( -- 1|0 ) 18 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_IEPIF, IN endpoint interrupt flag
: USBFS_GLOBAL_GINTF_OEPIF? ( -- 1|0 ) 19 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_OEPIF, OUT endpoint interrupt flag
: USBFS_GLOBAL_GINTF_ISOINCIF ( -- x addr ) 20 bit USBFS_GLOBAL_GINTF ; \ USBFS_GLOBAL_GINTF_ISOINCIF, Isochronous IN transfer Not Complete Interrupt Flag
: USBFS_GLOBAL_GINTF_PXNCIF_ISOONCIF? ( -- 1|0 ) 21 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_PXNCIF_ISOONCIF, periodic transfer not complete interrupt flagHost  mode/isochronous OUT transfer not complete interrupt flagDevice  mode
: USBFS_GLOBAL_GINTF_HPIF? ( -- 1|0 ) 24 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_HPIF, Host port interrupt flag
: USBFS_GLOBAL_GINTF_HCIF? ( -- 1|0 ) 25 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_HCIF, Host channels interrupt flag
: USBFS_GLOBAL_GINTF_PTXFEIF? ( -- 1|0 ) 26 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_PTXFEIF, Periodic TxFIFO empty interrupt flag
: USBFS_GLOBAL_GINTF_IDPSC? ( -- 1|0 ) 28 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_IDPSC, ID pin status change
: USBFS_GLOBAL_GINTF_DISCIF? ( -- 1|0 ) 29 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_DISCIF, Disconnect interrupt flag
: USBFS_GLOBAL_GINTF_SESIF? ( -- 1|0 ) 30 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_SESIF, Session interrupt flag
: USBFS_GLOBAL_GINTF_WKUPIF? ( -- 1|0 ) 31 bit USBFS_GLOBAL_GINTF bit@ ; \ USBFS_GLOBAL_GINTF_WKUPIF, Wakeup interrupt flag

\ USBFS_GLOBAL_GINTEN (multiple-access)  Reset:0x00000000
: USBFS_GLOBAL_GINTEN_MFIE ( -- x addr ) 1 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_MFIE, Mode fault interrupt  enable
: USBFS_GLOBAL_GINTEN_OTGIE ( -- x addr ) 2 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_OTGIE, OTG interrupt enable 
: USBFS_GLOBAL_GINTEN_SOFIE ( -- x addr ) 3 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_SOFIE, Start of frame interrupt enable
: USBFS_GLOBAL_GINTEN_RXFNEIE ( -- x addr ) 4 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_RXFNEIE, Receive FIFO non-empty  interrupt enable
: USBFS_GLOBAL_GINTEN_NPTXFEIE ( -- x addr ) 5 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_NPTXFEIE, Non-periodic TxFIFO empty  interrupt enable
: USBFS_GLOBAL_GINTEN_GNPINAKIE ( -- x addr ) 6 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_GNPINAKIE, Global non-periodic IN NAK effective interrupt enable
: USBFS_GLOBAL_GINTEN_GONAKIE ( -- x addr ) 7 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_GONAKIE, Global OUT NAK effective  interrupt enable
: USBFS_GLOBAL_GINTEN_ESPIE ( -- x addr ) 10 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_ESPIE, Early suspend interrupt enable
: USBFS_GLOBAL_GINTEN_SPIE ( -- x addr ) 11 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_SPIE, USB suspend interrupt enable
: USBFS_GLOBAL_GINTEN_RSTIE ( -- x addr ) 12 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_RSTIE, USB reset interrupt enable
: USBFS_GLOBAL_GINTEN_ENUMFIE ( -- x addr ) 13 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_ENUMFIE, Enumeration finish interrupt enable
: USBFS_GLOBAL_GINTEN_ISOOPDIE ( -- x addr ) 14 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_ISOOPDIE, Isochronous OUT packet dropped interrupt enable
: USBFS_GLOBAL_GINTEN_EOPFIE ( -- x addr ) 15 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_EOPFIE, End of periodic frame interrupt enable
: USBFS_GLOBAL_GINTEN_IEPIE ( -- x addr ) 18 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_IEPIE, IN endpoints interrupt enable
: USBFS_GLOBAL_GINTEN_OEPIE ( -- x addr ) 19 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_OEPIE, OUT endpoints interrupt enable
: USBFS_GLOBAL_GINTEN_ISOINCIE ( -- x addr ) 20 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_ISOINCIE, isochronous IN transfer not complete  interrupt enable
: USBFS_GLOBAL_GINTEN_PXNCIE_ISOONCIE ( -- x addr ) 21 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_PXNCIE_ISOONCIE, periodic transfer not compelete Interrupt enableHost  mode/isochronous OUT transfer not complete interrupt enableDevice  mode
: USBFS_GLOBAL_GINTEN_HPIE ( -- x addr ) 24 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_HPIE, Host port interrupt enable
: USBFS_GLOBAL_GINTEN_HCIE ( -- x addr ) 25 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_HCIE, Host channels interrupt enable
: USBFS_GLOBAL_GINTEN_PTXFEIE ( -- x addr ) 26 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_PTXFEIE, Periodic TxFIFO empty interrupt enable
: USBFS_GLOBAL_GINTEN_IDPSCIE? ( -- 1|0 ) 28 bit USBFS_GLOBAL_GINTEN bit@ ; \ USBFS_GLOBAL_GINTEN_IDPSCIE, ID pin status change interrupt enable
: USBFS_GLOBAL_GINTEN_DISCIE ( -- x addr ) 29 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_DISCIE, Disconnect interrupt enable
: USBFS_GLOBAL_GINTEN_SESIE ( -- x addr ) 30 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_SESIE, Session interrupt enable
: USBFS_GLOBAL_GINTEN_WKUPIE ( -- x addr ) 31 bit USBFS_GLOBAL_GINTEN ; \ USBFS_GLOBAL_GINTEN_WKUPIE, Wakeup interrupt enable

\ USBFS_GLOBAL_GRSTATR_Device (read-only) Reset:0x00000000
: USBFS_GLOBAL_GRSTATR_Device_EPNUM? ( --  x ) USBFS_GLOBAL_GRSTATR_Device @ ; \ USBFS_GLOBAL_GRSTATR_Device_EPNUM, Endpoint number
: USBFS_GLOBAL_GRSTATR_Device_BCOUNT? ( --  x ) 4 lshift USBFS_GLOBAL_GRSTATR_Device @ ; \ USBFS_GLOBAL_GRSTATR_Device_BCOUNT, Byte count
: USBFS_GLOBAL_GRSTATR_Device_DPID? ( --  x ) 15 lshift USBFS_GLOBAL_GRSTATR_Device @ ; \ USBFS_GLOBAL_GRSTATR_Device_DPID, Data PID
: USBFS_GLOBAL_GRSTATR_Device_RPCKST? ( --  x ) 17 lshift USBFS_GLOBAL_GRSTATR_Device @ ; \ USBFS_GLOBAL_GRSTATR_Device_RPCKST, Recieve packet status

\ USBFS_GLOBAL_GRSTATR_Host (read-only) Reset:0x00000000
: USBFS_GLOBAL_GRSTATR_Host_CNUM? ( --  x ) USBFS_GLOBAL_GRSTATR_Host @ ; \ USBFS_GLOBAL_GRSTATR_Host_CNUM, Channel number
: USBFS_GLOBAL_GRSTATR_Host_BCOUNT? ( --  x ) 4 lshift USBFS_GLOBAL_GRSTATR_Host @ ; \ USBFS_GLOBAL_GRSTATR_Host_BCOUNT, Byte count
: USBFS_GLOBAL_GRSTATR_Host_DPID? ( --  x ) 15 lshift USBFS_GLOBAL_GRSTATR_Host @ ; \ USBFS_GLOBAL_GRSTATR_Host_DPID, Data PID
: USBFS_GLOBAL_GRSTATR_Host_RPCKST? ( --  x ) 17 lshift USBFS_GLOBAL_GRSTATR_Host @ ; \ USBFS_GLOBAL_GRSTATR_Host_RPCKST, Reivece packet status

\ USBFS_GLOBAL_GRSTATP_Device (read-only) Reset:0x00000000
: USBFS_GLOBAL_GRSTATP_Device_EPNUM? ( --  x ) USBFS_GLOBAL_GRSTATP_Device @ ; \ USBFS_GLOBAL_GRSTATP_Device_EPNUM, Endpoint number
: USBFS_GLOBAL_GRSTATP_Device_BCOUNT? ( --  x ) 4 lshift USBFS_GLOBAL_GRSTATP_Device @ ; \ USBFS_GLOBAL_GRSTATP_Device_BCOUNT, Byte count
: USBFS_GLOBAL_GRSTATP_Device_DPID? ( --  x ) 15 lshift USBFS_GLOBAL_GRSTATP_Device @ ; \ USBFS_GLOBAL_GRSTATP_Device_DPID, Data PID
: USBFS_GLOBAL_GRSTATP_Device_RPCKST? ( --  x ) 17 lshift USBFS_GLOBAL_GRSTATP_Device @ ; \ USBFS_GLOBAL_GRSTATP_Device_RPCKST, Recieve packet status

\ USBFS_GLOBAL_GRSTATP_Host (read-only) Reset:0x00000000
: USBFS_GLOBAL_GRSTATP_Host_CNUM? ( --  x ) USBFS_GLOBAL_GRSTATP_Host @ ; \ USBFS_GLOBAL_GRSTATP_Host_CNUM, Channel number
: USBFS_GLOBAL_GRSTATP_Host_BCOUNT? ( --  x ) 4 lshift USBFS_GLOBAL_GRSTATP_Host @ ; \ USBFS_GLOBAL_GRSTATP_Host_BCOUNT, Byte count
: USBFS_GLOBAL_GRSTATP_Host_DPID? ( --  x ) 15 lshift USBFS_GLOBAL_GRSTATP_Host @ ; \ USBFS_GLOBAL_GRSTATP_Host_DPID, Data PID
: USBFS_GLOBAL_GRSTATP_Host_RPCKST? ( --  x ) 17 lshift USBFS_GLOBAL_GRSTATP_Host @ ; \ USBFS_GLOBAL_GRSTATP_Host_RPCKST, Reivece packet status

\ USBFS_GLOBAL_GRFLEN (read-write) Reset:0x00000200
: USBFS_GLOBAL_GRFLEN_RXFD ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_GLOBAL_GRFLEN ; \ USBFS_GLOBAL_GRFLEN_RXFD, Rx FIFO depth

\ USBFS_GLOBAL_HNPTFLEN (read-write) Reset:0x02000200
: USBFS_GLOBAL_HNPTFLEN_HNPTXRSAR ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_GLOBAL_HNPTFLEN ; \ USBFS_GLOBAL_HNPTFLEN_HNPTXRSAR, host non-periodic transmit Tx RAM start  address
: USBFS_GLOBAL_HNPTFLEN_HNPTXFD ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift USBFS_GLOBAL_HNPTFLEN ; \ USBFS_GLOBAL_HNPTFLEN_HNPTXFD, host non-periodic TxFIFO depth

\ USBFS_GLOBAL_DIEP0TFLEN (read-write) Reset:0x02000200
: USBFS_GLOBAL_DIEP0TFLEN_IEP0TXFD ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift USBFS_GLOBAL_DIEP0TFLEN ; \ USBFS_GLOBAL_DIEP0TFLEN_IEP0TXFD, in endpoint 0 Tx FIFO depth
: USBFS_GLOBAL_DIEP0TFLEN_IEP0TXRSAR ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_GLOBAL_DIEP0TFLEN ; \ USBFS_GLOBAL_DIEP0TFLEN_IEP0TXRSAR, in endpoint 0 Tx RAM start address

\ USBFS_GLOBAL_HNPTFQSTAT (read-only) Reset:0x00080200
: USBFS_GLOBAL_HNPTFQSTAT_NPTXFS? ( --  x ) USBFS_GLOBAL_HNPTFQSTAT @ ; \ USBFS_GLOBAL_HNPTFQSTAT_NPTXFS, Non-periodic TxFIFO space
: USBFS_GLOBAL_HNPTFQSTAT_NPTXRQS? ( --  x ) 16 lshift USBFS_GLOBAL_HNPTFQSTAT @ ; \ USBFS_GLOBAL_HNPTFQSTAT_NPTXRQS, Non-periodic transmit request queue  space 
: USBFS_GLOBAL_HNPTFQSTAT_NPTXRQTOP? ( --  x ) 24 lshift USBFS_GLOBAL_HNPTFQSTAT @ ; \ USBFS_GLOBAL_HNPTFQSTAT_NPTXRQTOP, Top of the non-periodic transmit request  queue

\ USBFS_GLOBAL_GCCFG (read-write) Reset:0x00000000
: USBFS_GLOBAL_GCCFG_PWRON ( -- x addr ) 16 bit USBFS_GLOBAL_GCCFG ; \ USBFS_GLOBAL_GCCFG_PWRON, Power on
: USBFS_GLOBAL_GCCFG_VBUSACEN ( -- x addr ) 18 bit USBFS_GLOBAL_GCCFG ; \ USBFS_GLOBAL_GCCFG_VBUSACEN, The VBUS A-device Comparer enable
: USBFS_GLOBAL_GCCFG_VBUSBCEN ( -- x addr ) 19 bit USBFS_GLOBAL_GCCFG ; \ USBFS_GLOBAL_GCCFG_VBUSBCEN, The VBUS B-device Comparer enable
: USBFS_GLOBAL_GCCFG_SOFOEN ( -- x addr ) 20 bit USBFS_GLOBAL_GCCFG ; \ USBFS_GLOBAL_GCCFG_SOFOEN, SOF output enable
: USBFS_GLOBAL_GCCFG_VBUSIG ( -- x addr ) 21 bit USBFS_GLOBAL_GCCFG ; \ USBFS_GLOBAL_GCCFG_VBUSIG, VBUS ignored

\ USBFS_GLOBAL_CID (read-write) Reset:0x00001000
: USBFS_GLOBAL_CID_CID ( %bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb -- x addr ) USBFS_GLOBAL_CID ; \ USBFS_GLOBAL_CID_CID, Core ID

\ USBFS_GLOBAL_HPTFLEN (read-write) Reset:0x02000600
: USBFS_GLOBAL_HPTFLEN_HPTXFSAR ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_GLOBAL_HPTFLEN ; \ USBFS_GLOBAL_HPTFLEN_HPTXFSAR, Host periodic TxFIFO start  address
: USBFS_GLOBAL_HPTFLEN_HPTXFD ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift USBFS_GLOBAL_HPTFLEN ; \ USBFS_GLOBAL_HPTFLEN_HPTXFD, Host periodic TxFIFO depth

\ USBFS_GLOBAL_DIEP1TFLEN (read-write) Reset:0x02000400
: USBFS_GLOBAL_DIEP1TFLEN_IEPTXRSAR ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_GLOBAL_DIEP1TFLEN ; \ USBFS_GLOBAL_DIEP1TFLEN_IEPTXRSAR, IN endpoint FIFO transmit RAM start  address
: USBFS_GLOBAL_DIEP1TFLEN_IEPTXFD ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift USBFS_GLOBAL_DIEP1TFLEN ; \ USBFS_GLOBAL_DIEP1TFLEN_IEPTXFD, IN endpoint TxFIFO depth

\ USBFS_GLOBAL_DIEP2TFLEN (read-write) Reset:0x02000400
: USBFS_GLOBAL_DIEP2TFLEN_IEPTXRSAR ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_GLOBAL_DIEP2TFLEN ; \ USBFS_GLOBAL_DIEP2TFLEN_IEPTXRSAR, IN endpoint FIFO transmit RAM start  address
: USBFS_GLOBAL_DIEP2TFLEN_IEPTXFD ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift USBFS_GLOBAL_DIEP2TFLEN ; \ USBFS_GLOBAL_DIEP2TFLEN_IEPTXFD, IN endpoint TxFIFO depth

\ USBFS_GLOBAL_DIEP3TFLEN (read-write) Reset:0x02000400
: USBFS_GLOBAL_DIEP3TFLEN_IEPTXRSAR ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_GLOBAL_DIEP3TFLEN ; \ USBFS_GLOBAL_DIEP3TFLEN_IEPTXRSAR, IN endpoint FIFO4 transmit RAM start  address
: USBFS_GLOBAL_DIEP3TFLEN_IEPTXFD ( %bbbbbbbbbbbbbbbb -- x addr ) 16 lshift USBFS_GLOBAL_DIEP3TFLEN ; \ USBFS_GLOBAL_DIEP3TFLEN_IEPTXFD, IN endpoint TxFIFO depth

\ USBFS_HOST_HCTL (multiple-access)  Reset:0x00000000
: USBFS_HOST_HCTL_CLKSEL ( %bb -- x addr ) USBFS_HOST_HCTL ; \ USBFS_HOST_HCTL_CLKSEL, clock select for USB clock

\ USBFS_HOST_HFT (read-write) Reset:0x0000BB80
: USBFS_HOST_HFT_FRI ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_HOST_HFT ; \ USBFS_HOST_HFT_FRI, Frame interval

\ USBFS_HOST_HFINFR (read-only) Reset:0xBB800000
: USBFS_HOST_HFINFR_FRNUM? ( --  x ) USBFS_HOST_HFINFR @ ; \ USBFS_HOST_HFINFR_FRNUM, Frame number
: USBFS_HOST_HFINFR_FRT? ( --  x ) 16 lshift USBFS_HOST_HFINFR @ ; \ USBFS_HOST_HFINFR_FRT, Frame remaining time

\ USBFS_HOST_HPTFQSTAT (multiple-access)  Reset:0x00080200
: USBFS_HOST_HPTFQSTAT_PTXFS ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_HOST_HPTFQSTAT ; \ USBFS_HOST_HPTFQSTAT_PTXFS, Periodic transmit data FIFO space  available
: USBFS_HOST_HPTFQSTAT_PTXREQS ( %bbbbbbbb -- x addr ) 16 lshift USBFS_HOST_HPTFQSTAT ; \ USBFS_HOST_HPTFQSTAT_PTXREQS, Periodic transmit request queue space  available
: USBFS_HOST_HPTFQSTAT_PTXREQT ( %bbbbbbbb -- x addr ) 24 lshift USBFS_HOST_HPTFQSTAT ; \ USBFS_HOST_HPTFQSTAT_PTXREQT, Top of the periodic transmit request  queue

\ USBFS_HOST_HACHINT (read-only) Reset:0x00000000
: USBFS_HOST_HACHINT_HACHINT? ( --  x ) USBFS_HOST_HACHINT @ ; \ USBFS_HOST_HACHINT_HACHINT, Host all channel interrupts

\ USBFS_HOST_HACHINTEN (read-write) Reset:0x00000000
: USBFS_HOST_HACHINTEN_CINTEN ( %bbbbbbbb -- x addr ) USBFS_HOST_HACHINTEN ; \ USBFS_HOST_HACHINTEN_CINTEN, Channel interrupt enable

\ USBFS_HOST_HPCS (multiple-access)  Reset:0x00000000
: USBFS_HOST_HPCS_PCST? ( -- 1|0 ) 0 bit USBFS_HOST_HPCS bit@ ; \ USBFS_HOST_HPCS_PCST, Port connect status
: USBFS_HOST_HPCS_PCD ( -- x addr ) 1 bit USBFS_HOST_HPCS ; \ USBFS_HOST_HPCS_PCD, Port connect detected
: USBFS_HOST_HPCS_PE ( -- x addr ) 2 bit USBFS_HOST_HPCS ; \ USBFS_HOST_HPCS_PE, Port enable
: USBFS_HOST_HPCS_PEDC ( -- x addr ) 3 bit USBFS_HOST_HPCS ; \ USBFS_HOST_HPCS_PEDC, Port enable/disable change
: USBFS_HOST_HPCS_PREM ( -- x addr ) 6 bit USBFS_HOST_HPCS ; \ USBFS_HOST_HPCS_PREM, Port resume
: USBFS_HOST_HPCS_PSP ( -- x addr ) 7 bit USBFS_HOST_HPCS ; \ USBFS_HOST_HPCS_PSP, Port suspend
: USBFS_HOST_HPCS_PRST ( -- x addr ) 8 bit USBFS_HOST_HPCS ; \ USBFS_HOST_HPCS_PRST, Port reset
: USBFS_HOST_HPCS_PLST? ( %bb -- 1|0 ) 10 lshift USBFS_HOST_HPCS bit@ ; \ USBFS_HOST_HPCS_PLST, Port line status
: USBFS_HOST_HPCS_PP ( -- x addr ) 12 bit USBFS_HOST_HPCS ; \ USBFS_HOST_HPCS_PP, Port power
: USBFS_HOST_HPCS_PS ( %bb -- x addr ) 17 lshift USBFS_HOST_HPCS ; \ USBFS_HOST_HPCS_PS, Port speed

\ USBFS_HOST_HCH0CTL (read-write) Reset:0x00000000
: USBFS_HOST_HCH0CTL_MPL x addr ) USBFS_HOST_HCH0CTL ; \ USBFS_HOST_HCH0CTL_MPL, Maximum packet size
: USBFS_HOST_HCH0CTL_EPNUM ( %bbbb -- x addr ) 11 lshift USBFS_HOST_HCH0CTL ; \ USBFS_HOST_HCH0CTL_EPNUM, Endpoint number
: USBFS_HOST_HCH0CTL_EPDIR ( -- x addr ) 15 bit USBFS_HOST_HCH0CTL ; \ USBFS_HOST_HCH0CTL_EPDIR, Endpoint direction
: USBFS_HOST_HCH0CTL_LSD ( -- x addr ) 17 bit USBFS_HOST_HCH0CTL ; \ USBFS_HOST_HCH0CTL_LSD, Low-speed device
: USBFS_HOST_HCH0CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_HOST_HCH0CTL ; \ USBFS_HOST_HCH0CTL_EPTYPE, Endpoint type
: USBFS_HOST_HCH0CTL_DAR ( %bbbbbbb -- x addr ) 22 lshift USBFS_HOST_HCH0CTL ; \ USBFS_HOST_HCH0CTL_DAR, Device address
: USBFS_HOST_HCH0CTL_ODDFRM ( -- x addr ) 29 bit USBFS_HOST_HCH0CTL ; \ USBFS_HOST_HCH0CTL_ODDFRM, Odd frame
: USBFS_HOST_HCH0CTL_CDIS ( -- x addr ) 30 bit USBFS_HOST_HCH0CTL ; \ USBFS_HOST_HCH0CTL_CDIS, Channel disable
: USBFS_HOST_HCH0CTL_CEN ( -- x addr ) 31 bit USBFS_HOST_HCH0CTL ; \ USBFS_HOST_HCH0CTL_CEN, Channel enable

\ USBFS_HOST_HCH1CTL (read-write) Reset:0x00000000
: USBFS_HOST_HCH1CTL_MPL x addr ) USBFS_HOST_HCH1CTL ; \ USBFS_HOST_HCH1CTL_MPL, Maximum packet size
: USBFS_HOST_HCH1CTL_EPNUM ( %bbbb -- x addr ) 11 lshift USBFS_HOST_HCH1CTL ; \ USBFS_HOST_HCH1CTL_EPNUM, Endpoint number
: USBFS_HOST_HCH1CTL_EPDIR ( -- x addr ) 15 bit USBFS_HOST_HCH1CTL ; \ USBFS_HOST_HCH1CTL_EPDIR, Endpoint direction
: USBFS_HOST_HCH1CTL_LSD ( -- x addr ) 17 bit USBFS_HOST_HCH1CTL ; \ USBFS_HOST_HCH1CTL_LSD, Low-speed device
: USBFS_HOST_HCH1CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_HOST_HCH1CTL ; \ USBFS_HOST_HCH1CTL_EPTYPE, Endpoint type
: USBFS_HOST_HCH1CTL_DAR ( %bbbbbbb -- x addr ) 22 lshift USBFS_HOST_HCH1CTL ; \ USBFS_HOST_HCH1CTL_DAR, Device address
: USBFS_HOST_HCH1CTL_ODDFRM ( -- x addr ) 29 bit USBFS_HOST_HCH1CTL ; \ USBFS_HOST_HCH1CTL_ODDFRM, Odd frame
: USBFS_HOST_HCH1CTL_CDIS ( -- x addr ) 30 bit USBFS_HOST_HCH1CTL ; \ USBFS_HOST_HCH1CTL_CDIS, Channel disable
: USBFS_HOST_HCH1CTL_CEN ( -- x addr ) 31 bit USBFS_HOST_HCH1CTL ; \ USBFS_HOST_HCH1CTL_CEN, Channel enable

\ USBFS_HOST_HCH2CTL (read-write) Reset:0x00000000
: USBFS_HOST_HCH2CTL_MPL x addr ) USBFS_HOST_HCH2CTL ; \ USBFS_HOST_HCH2CTL_MPL, Maximum packet size
: USBFS_HOST_HCH2CTL_EPNUM ( %bbbb -- x addr ) 11 lshift USBFS_HOST_HCH2CTL ; \ USBFS_HOST_HCH2CTL_EPNUM, Endpoint number
: USBFS_HOST_HCH2CTL_EPDIR ( -- x addr ) 15 bit USBFS_HOST_HCH2CTL ; \ USBFS_HOST_HCH2CTL_EPDIR, Endpoint direction
: USBFS_HOST_HCH2CTL_LSD ( -- x addr ) 17 bit USBFS_HOST_HCH2CTL ; \ USBFS_HOST_HCH2CTL_LSD, Low-speed device
: USBFS_HOST_HCH2CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_HOST_HCH2CTL ; \ USBFS_HOST_HCH2CTL_EPTYPE, Endpoint type
: USBFS_HOST_HCH2CTL_DAR ( %bbbbbbb -- x addr ) 22 lshift USBFS_HOST_HCH2CTL ; \ USBFS_HOST_HCH2CTL_DAR, Device address
: USBFS_HOST_HCH2CTL_ODDFRM ( -- x addr ) 29 bit USBFS_HOST_HCH2CTL ; \ USBFS_HOST_HCH2CTL_ODDFRM, Odd frame
: USBFS_HOST_HCH2CTL_CDIS ( -- x addr ) 30 bit USBFS_HOST_HCH2CTL ; \ USBFS_HOST_HCH2CTL_CDIS, Channel disable
: USBFS_HOST_HCH2CTL_CEN ( -- x addr ) 31 bit USBFS_HOST_HCH2CTL ; \ USBFS_HOST_HCH2CTL_CEN, Channel enable

\ USBFS_HOST_HCH3CTL (read-write) Reset:0x00000000
: USBFS_HOST_HCH3CTL_MPL x addr ) USBFS_HOST_HCH3CTL ; \ USBFS_HOST_HCH3CTL_MPL, Maximum packet size
: USBFS_HOST_HCH3CTL_EPNUM ( %bbbb -- x addr ) 11 lshift USBFS_HOST_HCH3CTL ; \ USBFS_HOST_HCH3CTL_EPNUM, Endpoint number
: USBFS_HOST_HCH3CTL_EPDIR ( -- x addr ) 15 bit USBFS_HOST_HCH3CTL ; \ USBFS_HOST_HCH3CTL_EPDIR, Endpoint direction
: USBFS_HOST_HCH3CTL_LSD ( -- x addr ) 17 bit USBFS_HOST_HCH3CTL ; \ USBFS_HOST_HCH3CTL_LSD, Low-speed device
: USBFS_HOST_HCH3CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_HOST_HCH3CTL ; \ USBFS_HOST_HCH3CTL_EPTYPE, Endpoint type
: USBFS_HOST_HCH3CTL_DAR ( %bbbbbbb -- x addr ) 22 lshift USBFS_HOST_HCH3CTL ; \ USBFS_HOST_HCH3CTL_DAR, Device address
: USBFS_HOST_HCH3CTL_ODDFRM ( -- x addr ) 29 bit USBFS_HOST_HCH3CTL ; \ USBFS_HOST_HCH3CTL_ODDFRM, Odd frame
: USBFS_HOST_HCH3CTL_CDIS ( -- x addr ) 30 bit USBFS_HOST_HCH3CTL ; \ USBFS_HOST_HCH3CTL_CDIS, Channel disable
: USBFS_HOST_HCH3CTL_CEN ( -- x addr ) 31 bit USBFS_HOST_HCH3CTL ; \ USBFS_HOST_HCH3CTL_CEN, Channel enable

\ USBFS_HOST_HCH4CTL (read-write) Reset:0x00000000
: USBFS_HOST_HCH4CTL_MPL x addr ) USBFS_HOST_HCH4CTL ; \ USBFS_HOST_HCH4CTL_MPL, Maximum packet size
: USBFS_HOST_HCH4CTL_EPNUM ( %bbbb -- x addr ) 11 lshift USBFS_HOST_HCH4CTL ; \ USBFS_HOST_HCH4CTL_EPNUM, Endpoint number
: USBFS_HOST_HCH4CTL_EPDIR ( -- x addr ) 15 bit USBFS_HOST_HCH4CTL ; \ USBFS_HOST_HCH4CTL_EPDIR, Endpoint direction
: USBFS_HOST_HCH4CTL_LSD ( -- x addr ) 17 bit USBFS_HOST_HCH4CTL ; \ USBFS_HOST_HCH4CTL_LSD, Low-speed device
: USBFS_HOST_HCH4CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_HOST_HCH4CTL ; \ USBFS_HOST_HCH4CTL_EPTYPE, Endpoint type
: USBFS_HOST_HCH4CTL_DAR ( %bbbbbbb -- x addr ) 22 lshift USBFS_HOST_HCH4CTL ; \ USBFS_HOST_HCH4CTL_DAR, Device address
: USBFS_HOST_HCH4CTL_ODDFRM ( -- x addr ) 29 bit USBFS_HOST_HCH4CTL ; \ USBFS_HOST_HCH4CTL_ODDFRM, Odd frame
: USBFS_HOST_HCH4CTL_CDIS ( -- x addr ) 30 bit USBFS_HOST_HCH4CTL ; \ USBFS_HOST_HCH4CTL_CDIS, Channel disable
: USBFS_HOST_HCH4CTL_CEN ( -- x addr ) 31 bit USBFS_HOST_HCH4CTL ; \ USBFS_HOST_HCH4CTL_CEN, Channel enable

\ USBFS_HOST_HCH5CTL (read-write) Reset:0x00000000
: USBFS_HOST_HCH5CTL_MPL x addr ) USBFS_HOST_HCH5CTL ; \ USBFS_HOST_HCH5CTL_MPL, Maximum packet size
: USBFS_HOST_HCH5CTL_EPNUM ( %bbbb -- x addr ) 11 lshift USBFS_HOST_HCH5CTL ; \ USBFS_HOST_HCH5CTL_EPNUM, Endpoint number
: USBFS_HOST_HCH5CTL_EPDIR ( -- x addr ) 15 bit USBFS_HOST_HCH5CTL ; \ USBFS_HOST_HCH5CTL_EPDIR, Endpoint direction
: USBFS_HOST_HCH5CTL_LSD ( -- x addr ) 17 bit USBFS_HOST_HCH5CTL ; \ USBFS_HOST_HCH5CTL_LSD, Low-speed device
: USBFS_HOST_HCH5CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_HOST_HCH5CTL ; \ USBFS_HOST_HCH5CTL_EPTYPE, Endpoint type
: USBFS_HOST_HCH5CTL_DAR ( %bbbbbbb -- x addr ) 22 lshift USBFS_HOST_HCH5CTL ; \ USBFS_HOST_HCH5CTL_DAR, Device address
: USBFS_HOST_HCH5CTL_ODDFRM ( -- x addr ) 29 bit USBFS_HOST_HCH5CTL ; \ USBFS_HOST_HCH5CTL_ODDFRM, Odd frame
: USBFS_HOST_HCH5CTL_CDIS ( -- x addr ) 30 bit USBFS_HOST_HCH5CTL ; \ USBFS_HOST_HCH5CTL_CDIS, Channel disable
: USBFS_HOST_HCH5CTL_CEN ( -- x addr ) 31 bit USBFS_HOST_HCH5CTL ; \ USBFS_HOST_HCH5CTL_CEN, Channel enable

\ USBFS_HOST_HCH6CTL (read-write) Reset:0x00000000
: USBFS_HOST_HCH6CTL_MPL x addr ) USBFS_HOST_HCH6CTL ; \ USBFS_HOST_HCH6CTL_MPL, Maximum packet size
: USBFS_HOST_HCH6CTL_EPNUM ( %bbbb -- x addr ) 11 lshift USBFS_HOST_HCH6CTL ; \ USBFS_HOST_HCH6CTL_EPNUM, Endpoint number
: USBFS_HOST_HCH6CTL_EPDIR ( -- x addr ) 15 bit USBFS_HOST_HCH6CTL ; \ USBFS_HOST_HCH6CTL_EPDIR, Endpoint direction
: USBFS_HOST_HCH6CTL_LSD ( -- x addr ) 17 bit USBFS_HOST_HCH6CTL ; \ USBFS_HOST_HCH6CTL_LSD, Low-speed device
: USBFS_HOST_HCH6CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_HOST_HCH6CTL ; \ USBFS_HOST_HCH6CTL_EPTYPE, Endpoint type
: USBFS_HOST_HCH6CTL_DAR ( %bbbbbbb -- x addr ) 22 lshift USBFS_HOST_HCH6CTL ; \ USBFS_HOST_HCH6CTL_DAR, Device address
: USBFS_HOST_HCH6CTL_ODDFRM ( -- x addr ) 29 bit USBFS_HOST_HCH6CTL ; \ USBFS_HOST_HCH6CTL_ODDFRM, Odd frame
: USBFS_HOST_HCH6CTL_CDIS ( -- x addr ) 30 bit USBFS_HOST_HCH6CTL ; \ USBFS_HOST_HCH6CTL_CDIS, Channel disable
: USBFS_HOST_HCH6CTL_CEN ( -- x addr ) 31 bit USBFS_HOST_HCH6CTL ; \ USBFS_HOST_HCH6CTL_CEN, Channel enable

\ USBFS_HOST_HCH7CTL (read-write) Reset:0x00000000
: USBFS_HOST_HCH7CTL_MPL x addr ) USBFS_HOST_HCH7CTL ; \ USBFS_HOST_HCH7CTL_MPL, Maximum packet size
: USBFS_HOST_HCH7CTL_EPNUM ( %bbbb -- x addr ) 11 lshift USBFS_HOST_HCH7CTL ; \ USBFS_HOST_HCH7CTL_EPNUM, Endpoint number
: USBFS_HOST_HCH7CTL_EPDIR ( -- x addr ) 15 bit USBFS_HOST_HCH7CTL ; \ USBFS_HOST_HCH7CTL_EPDIR, Endpoint direction
: USBFS_HOST_HCH7CTL_LSD ( -- x addr ) 17 bit USBFS_HOST_HCH7CTL ; \ USBFS_HOST_HCH7CTL_LSD, Low-speed device
: USBFS_HOST_HCH7CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_HOST_HCH7CTL ; \ USBFS_HOST_HCH7CTL_EPTYPE, Endpoint type
: USBFS_HOST_HCH7CTL_DAR ( %bbbbbbb -- x addr ) 22 lshift USBFS_HOST_HCH7CTL ; \ USBFS_HOST_HCH7CTL_DAR, Device address
: USBFS_HOST_HCH7CTL_ODDFRM ( -- x addr ) 29 bit USBFS_HOST_HCH7CTL ; \ USBFS_HOST_HCH7CTL_ODDFRM, Odd frame
: USBFS_HOST_HCH7CTL_CDIS ( -- x addr ) 30 bit USBFS_HOST_HCH7CTL ; \ USBFS_HOST_HCH7CTL_CDIS, Channel disable
: USBFS_HOST_HCH7CTL_CEN ( -- x addr ) 31 bit USBFS_HOST_HCH7CTL ; \ USBFS_HOST_HCH7CTL_CEN, Channel enable

\ USBFS_HOST_HCH0INTF (read-write) Reset:0x00000000
: USBFS_HOST_HCH0INTF_TF ( -- x addr ) 0 bit USBFS_HOST_HCH0INTF ; \ USBFS_HOST_HCH0INTF_TF, Transfer finished
: USBFS_HOST_HCH0INTF_CH ( -- x addr ) 1 bit USBFS_HOST_HCH0INTF ; \ USBFS_HOST_HCH0INTF_CH, Channel halted
: USBFS_HOST_HCH0INTF_STALL ( -- x addr ) 3 bit USBFS_HOST_HCH0INTF ; \ USBFS_HOST_HCH0INTF_STALL, STALL response received  interrupt
: USBFS_HOST_HCH0INTF_NAK ( -- x addr ) 4 bit USBFS_HOST_HCH0INTF ; \ USBFS_HOST_HCH0INTF_NAK, NAK response received  interrupt
: USBFS_HOST_HCH0INTF_ACK ( -- x addr ) 5 bit USBFS_HOST_HCH0INTF ; \ USBFS_HOST_HCH0INTF_ACK, ACK response received/transmitted  interrupt
: USBFS_HOST_HCH0INTF_USBER ( -- x addr ) 7 bit USBFS_HOST_HCH0INTF ; \ USBFS_HOST_HCH0INTF_USBER, USB bus error
: USBFS_HOST_HCH0INTF_BBER ( -- x addr ) 8 bit USBFS_HOST_HCH0INTF ; \ USBFS_HOST_HCH0INTF_BBER, Babble error
: USBFS_HOST_HCH0INTF_REQOVR ( -- x addr ) 9 bit USBFS_HOST_HCH0INTF ; \ USBFS_HOST_HCH0INTF_REQOVR, Request queue overrun
: USBFS_HOST_HCH0INTF_DTER ( -- x addr ) 10 bit USBFS_HOST_HCH0INTF ; \ USBFS_HOST_HCH0INTF_DTER, Data toggle error

\ USBFS_HOST_HCH1INTF (read-write) Reset:0x00000000
: USBFS_HOST_HCH1INTF_TF ( -- x addr ) 0 bit USBFS_HOST_HCH1INTF ; \ USBFS_HOST_HCH1INTF_TF, Transfer finished
: USBFS_HOST_HCH1INTF_CH ( -- x addr ) 1 bit USBFS_HOST_HCH1INTF ; \ USBFS_HOST_HCH1INTF_CH, Channel halted
: USBFS_HOST_HCH1INTF_STALL ( -- x addr ) 3 bit USBFS_HOST_HCH1INTF ; \ USBFS_HOST_HCH1INTF_STALL, STALL response received  interrupt
: USBFS_HOST_HCH1INTF_NAK ( -- x addr ) 4 bit USBFS_HOST_HCH1INTF ; \ USBFS_HOST_HCH1INTF_NAK, NAK response received  interrupt
: USBFS_HOST_HCH1INTF_ACK ( -- x addr ) 5 bit USBFS_HOST_HCH1INTF ; \ USBFS_HOST_HCH1INTF_ACK, ACK response received/transmitted  interrupt
: USBFS_HOST_HCH1INTF_USBER ( -- x addr ) 7 bit USBFS_HOST_HCH1INTF ; \ USBFS_HOST_HCH1INTF_USBER, USB bus error
: USBFS_HOST_HCH1INTF_BBER ( -- x addr ) 8 bit USBFS_HOST_HCH1INTF ; \ USBFS_HOST_HCH1INTF_BBER, Babble error
: USBFS_HOST_HCH1INTF_REQOVR ( -- x addr ) 9 bit USBFS_HOST_HCH1INTF ; \ USBFS_HOST_HCH1INTF_REQOVR, Request queue overrun
: USBFS_HOST_HCH1INTF_DTER ( -- x addr ) 10 bit USBFS_HOST_HCH1INTF ; \ USBFS_HOST_HCH1INTF_DTER, Data toggle error

\ USBFS_HOST_HCH2INTF (read-write) Reset:0x00000000
: USBFS_HOST_HCH2INTF_TF ( -- x addr ) 0 bit USBFS_HOST_HCH2INTF ; \ USBFS_HOST_HCH2INTF_TF, Transfer finished
: USBFS_HOST_HCH2INTF_CH ( -- x addr ) 1 bit USBFS_HOST_HCH2INTF ; \ USBFS_HOST_HCH2INTF_CH, Channel halted
: USBFS_HOST_HCH2INTF_STALL ( -- x addr ) 3 bit USBFS_HOST_HCH2INTF ; \ USBFS_HOST_HCH2INTF_STALL, STALL response received  interrupt
: USBFS_HOST_HCH2INTF_NAK ( -- x addr ) 4 bit USBFS_HOST_HCH2INTF ; \ USBFS_HOST_HCH2INTF_NAK, NAK response received  interrupt
: USBFS_HOST_HCH2INTF_ACK ( -- x addr ) 5 bit USBFS_HOST_HCH2INTF ; \ USBFS_HOST_HCH2INTF_ACK, ACK response received/transmitted  interrupt
: USBFS_HOST_HCH2INTF_USBER ( -- x addr ) 7 bit USBFS_HOST_HCH2INTF ; \ USBFS_HOST_HCH2INTF_USBER, USB bus error
: USBFS_HOST_HCH2INTF_BBER ( -- x addr ) 8 bit USBFS_HOST_HCH2INTF ; \ USBFS_HOST_HCH2INTF_BBER, Babble error
: USBFS_HOST_HCH2INTF_REQOVR ( -- x addr ) 9 bit USBFS_HOST_HCH2INTF ; \ USBFS_HOST_HCH2INTF_REQOVR, Request queue overrun
: USBFS_HOST_HCH2INTF_DTER ( -- x addr ) 10 bit USBFS_HOST_HCH2INTF ; \ USBFS_HOST_HCH2INTF_DTER, Data toggle error

\ USBFS_HOST_HCH3INTF (read-write) Reset:0x00000000
: USBFS_HOST_HCH3INTF_TF ( -- x addr ) 0 bit USBFS_HOST_HCH3INTF ; \ USBFS_HOST_HCH3INTF_TF, Transfer finished
: USBFS_HOST_HCH3INTF_CH ( -- x addr ) 1 bit USBFS_HOST_HCH3INTF ; \ USBFS_HOST_HCH3INTF_CH, Channel halted
: USBFS_HOST_HCH3INTF_STALL ( -- x addr ) 3 bit USBFS_HOST_HCH3INTF ; \ USBFS_HOST_HCH3INTF_STALL, STALL response received  interrupt
: USBFS_HOST_HCH3INTF_NAK ( -- x addr ) 4 bit USBFS_HOST_HCH3INTF ; \ USBFS_HOST_HCH3INTF_NAK, NAK response received  interrupt
: USBFS_HOST_HCH3INTF_ACK ( -- x addr ) 5 bit USBFS_HOST_HCH3INTF ; \ USBFS_HOST_HCH3INTF_ACK, ACK response received/transmitted  interrupt
: USBFS_HOST_HCH3INTF_USBER ( -- x addr ) 7 bit USBFS_HOST_HCH3INTF ; \ USBFS_HOST_HCH3INTF_USBER, USB bus error
: USBFS_HOST_HCH3INTF_BBER ( -- x addr ) 8 bit USBFS_HOST_HCH3INTF ; \ USBFS_HOST_HCH3INTF_BBER, Babble error
: USBFS_HOST_HCH3INTF_REQOVR ( -- x addr ) 9 bit USBFS_HOST_HCH3INTF ; \ USBFS_HOST_HCH3INTF_REQOVR, Request queue overrun
: USBFS_HOST_HCH3INTF_DTER ( -- x addr ) 10 bit USBFS_HOST_HCH3INTF ; \ USBFS_HOST_HCH3INTF_DTER, Data toggle error

\ USBFS_HOST_HCH4INTF (read-write) Reset:0x00000000
: USBFS_HOST_HCH4INTF_TF ( -- x addr ) 0 bit USBFS_HOST_HCH4INTF ; \ USBFS_HOST_HCH4INTF_TF, Transfer finished
: USBFS_HOST_HCH4INTF_CH ( -- x addr ) 1 bit USBFS_HOST_HCH4INTF ; \ USBFS_HOST_HCH4INTF_CH, Channel halted
: USBFS_HOST_HCH4INTF_STALL ( -- x addr ) 3 bit USBFS_HOST_HCH4INTF ; \ USBFS_HOST_HCH4INTF_STALL, STALL response received  interrupt
: USBFS_HOST_HCH4INTF_NAK ( -- x addr ) 4 bit USBFS_HOST_HCH4INTF ; \ USBFS_HOST_HCH4INTF_NAK, NAK response received  interrupt
: USBFS_HOST_HCH4INTF_ACK ( -- x addr ) 5 bit USBFS_HOST_HCH4INTF ; \ USBFS_HOST_HCH4INTF_ACK, ACK response received/transmitted  interrupt
: USBFS_HOST_HCH4INTF_USBER ( -- x addr ) 7 bit USBFS_HOST_HCH4INTF ; \ USBFS_HOST_HCH4INTF_USBER, USB bus error
: USBFS_HOST_HCH4INTF_BBER ( -- x addr ) 8 bit USBFS_HOST_HCH4INTF ; \ USBFS_HOST_HCH4INTF_BBER, Babble error
: USBFS_HOST_HCH4INTF_REQOVR ( -- x addr ) 9 bit USBFS_HOST_HCH4INTF ; \ USBFS_HOST_HCH4INTF_REQOVR, Request queue overrun
: USBFS_HOST_HCH4INTF_DTER ( -- x addr ) 10 bit USBFS_HOST_HCH4INTF ; \ USBFS_HOST_HCH4INTF_DTER, Data toggle error

\ USBFS_HOST_HCH5INTF (read-write) Reset:0x00000000
: USBFS_HOST_HCH5INTF_TF ( -- x addr ) 0 bit USBFS_HOST_HCH5INTF ; \ USBFS_HOST_HCH5INTF_TF, Transfer finished
: USBFS_HOST_HCH5INTF_CH ( -- x addr ) 1 bit USBFS_HOST_HCH5INTF ; \ USBFS_HOST_HCH5INTF_CH, Channel halted
: USBFS_HOST_HCH5INTF_STALL ( -- x addr ) 3 bit USBFS_HOST_HCH5INTF ; \ USBFS_HOST_HCH5INTF_STALL, STALL response received  interrupt
: USBFS_HOST_HCH5INTF_NAK ( -- x addr ) 4 bit USBFS_HOST_HCH5INTF ; \ USBFS_HOST_HCH5INTF_NAK, NAK response received  interrupt
: USBFS_HOST_HCH5INTF_ACK ( -- x addr ) 5 bit USBFS_HOST_HCH5INTF ; \ USBFS_HOST_HCH5INTF_ACK, ACK response received/transmitted  interrupt
: USBFS_HOST_HCH5INTF_USBER ( -- x addr ) 7 bit USBFS_HOST_HCH5INTF ; \ USBFS_HOST_HCH5INTF_USBER, USB bus error
: USBFS_HOST_HCH5INTF_BBER ( -- x addr ) 8 bit USBFS_HOST_HCH5INTF ; \ USBFS_HOST_HCH5INTF_BBER, Babble error
: USBFS_HOST_HCH5INTF_REQOVR ( -- x addr ) 9 bit USBFS_HOST_HCH5INTF ; \ USBFS_HOST_HCH5INTF_REQOVR, Request queue overrun
: USBFS_HOST_HCH5INTF_DTER ( -- x addr ) 10 bit USBFS_HOST_HCH5INTF ; \ USBFS_HOST_HCH5INTF_DTER, Data toggle error

\ USBFS_HOST_HCH6INTF (read-write) Reset:0x00000000
: USBFS_HOST_HCH6INTF_TF ( -- x addr ) 0 bit USBFS_HOST_HCH6INTF ; \ USBFS_HOST_HCH6INTF_TF, Transfer finished
: USBFS_HOST_HCH6INTF_CH ( -- x addr ) 1 bit USBFS_HOST_HCH6INTF ; \ USBFS_HOST_HCH6INTF_CH, Channel halted
: USBFS_HOST_HCH6INTF_STALL ( -- x addr ) 3 bit USBFS_HOST_HCH6INTF ; \ USBFS_HOST_HCH6INTF_STALL, STALL response received  interrupt
: USBFS_HOST_HCH6INTF_NAK ( -- x addr ) 4 bit USBFS_HOST_HCH6INTF ; \ USBFS_HOST_HCH6INTF_NAK, NAK response received  interrupt
: USBFS_HOST_HCH6INTF_ACK ( -- x addr ) 5 bit USBFS_HOST_HCH6INTF ; \ USBFS_HOST_HCH6INTF_ACK, ACK response received/transmitted  interrupt
: USBFS_HOST_HCH6INTF_USBER ( -- x addr ) 7 bit USBFS_HOST_HCH6INTF ; \ USBFS_HOST_HCH6INTF_USBER, USB bus error
: USBFS_HOST_HCH6INTF_BBER ( -- x addr ) 8 bit USBFS_HOST_HCH6INTF ; \ USBFS_HOST_HCH6INTF_BBER, Babble error
: USBFS_HOST_HCH6INTF_REQOVR ( -- x addr ) 9 bit USBFS_HOST_HCH6INTF ; \ USBFS_HOST_HCH6INTF_REQOVR, Request queue overrun
: USBFS_HOST_HCH6INTF_DTER ( -- x addr ) 10 bit USBFS_HOST_HCH6INTF ; \ USBFS_HOST_HCH6INTF_DTER, Data toggle error

\ USBFS_HOST_HCH7INTF (read-write) Reset:0x00000000
: USBFS_HOST_HCH7INTF_TF ( -- x addr ) 0 bit USBFS_HOST_HCH7INTF ; \ USBFS_HOST_HCH7INTF_TF, Transfer finished
: USBFS_HOST_HCH7INTF_CH ( -- x addr ) 1 bit USBFS_HOST_HCH7INTF ; \ USBFS_HOST_HCH7INTF_CH, Channel halted
: USBFS_HOST_HCH7INTF_STALL ( -- x addr ) 3 bit USBFS_HOST_HCH7INTF ; \ USBFS_HOST_HCH7INTF_STALL, STALL response received  interrupt
: USBFS_HOST_HCH7INTF_NAK ( -- x addr ) 4 bit USBFS_HOST_HCH7INTF ; \ USBFS_HOST_HCH7INTF_NAK, NAK response received  interrupt
: USBFS_HOST_HCH7INTF_ACK ( -- x addr ) 5 bit USBFS_HOST_HCH7INTF ; \ USBFS_HOST_HCH7INTF_ACK, ACK response received/transmitted  interrupt
: USBFS_HOST_HCH7INTF_USBER ( -- x addr ) 7 bit USBFS_HOST_HCH7INTF ; \ USBFS_HOST_HCH7INTF_USBER, USB bus error
: USBFS_HOST_HCH7INTF_BBER ( -- x addr ) 8 bit USBFS_HOST_HCH7INTF ; \ USBFS_HOST_HCH7INTF_BBER, Babble error
: USBFS_HOST_HCH7INTF_REQOVR ( -- x addr ) 9 bit USBFS_HOST_HCH7INTF ; \ USBFS_HOST_HCH7INTF_REQOVR, Request queue overrun
: USBFS_HOST_HCH7INTF_DTER ( -- x addr ) 10 bit USBFS_HOST_HCH7INTF ; \ USBFS_HOST_HCH7INTF_DTER, Data toggle error

\ USBFS_HOST_HCH0INTEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH0INTEN_TFIE ( -- x addr ) 0 bit USBFS_HOST_HCH0INTEN ; \ USBFS_HOST_HCH0INTEN_TFIE, Transfer completed interrupt enable
: USBFS_HOST_HCH0INTEN_CHIE ( -- x addr ) 1 bit USBFS_HOST_HCH0INTEN ; \ USBFS_HOST_HCH0INTEN_CHIE, Channel halted interrupt enable
: USBFS_HOST_HCH0INTEN_STALLIE ( -- x addr ) 3 bit USBFS_HOST_HCH0INTEN ; \ USBFS_HOST_HCH0INTEN_STALLIE, STALL interrupt enable
: USBFS_HOST_HCH0INTEN_NAKIE ( -- x addr ) 4 bit USBFS_HOST_HCH0INTEN ; \ USBFS_HOST_HCH0INTEN_NAKIE, NAK interrupt enable
: USBFS_HOST_HCH0INTEN_ACKIE ( -- x addr ) 5 bit USBFS_HOST_HCH0INTEN ; \ USBFS_HOST_HCH0INTEN_ACKIE, ACK interrupt enable
: USBFS_HOST_HCH0INTEN_USBERIE ( -- x addr ) 7 bit USBFS_HOST_HCH0INTEN ; \ USBFS_HOST_HCH0INTEN_USBERIE, USB bus error interrupt enable
: USBFS_HOST_HCH0INTEN_BBERIE ( -- x addr ) 8 bit USBFS_HOST_HCH0INTEN ; \ USBFS_HOST_HCH0INTEN_BBERIE, Babble error interrupt enable
: USBFS_HOST_HCH0INTEN_REQOVRIE ( -- x addr ) 9 bit USBFS_HOST_HCH0INTEN ; \ USBFS_HOST_HCH0INTEN_REQOVRIE, request queue overrun interrupt enable
: USBFS_HOST_HCH0INTEN_DTERIE ( -- x addr ) 10 bit USBFS_HOST_HCH0INTEN ; \ USBFS_HOST_HCH0INTEN_DTERIE, Data toggle error interrupt enable

\ USBFS_HOST_HCH1INTEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH1INTEN_TFIE ( -- x addr ) 0 bit USBFS_HOST_HCH1INTEN ; \ USBFS_HOST_HCH1INTEN_TFIE, Transfer completed interrupt enable
: USBFS_HOST_HCH1INTEN_CHIE ( -- x addr ) 1 bit USBFS_HOST_HCH1INTEN ; \ USBFS_HOST_HCH1INTEN_CHIE, Channel halted interrupt enable
: USBFS_HOST_HCH1INTEN_STALLIE ( -- x addr ) 3 bit USBFS_HOST_HCH1INTEN ; \ USBFS_HOST_HCH1INTEN_STALLIE, STALL interrupt enable
: USBFS_HOST_HCH1INTEN_NAKIE ( -- x addr ) 4 bit USBFS_HOST_HCH1INTEN ; \ USBFS_HOST_HCH1INTEN_NAKIE, NAK interrupt enable
: USBFS_HOST_HCH1INTEN_ACKIE ( -- x addr ) 5 bit USBFS_HOST_HCH1INTEN ; \ USBFS_HOST_HCH1INTEN_ACKIE, ACK interrupt enable
: USBFS_HOST_HCH1INTEN_USBERIE ( -- x addr ) 7 bit USBFS_HOST_HCH1INTEN ; \ USBFS_HOST_HCH1INTEN_USBERIE, USB bus error interrupt enable
: USBFS_HOST_HCH1INTEN_BBERIE ( -- x addr ) 8 bit USBFS_HOST_HCH1INTEN ; \ USBFS_HOST_HCH1INTEN_BBERIE, Babble error interrupt enable
: USBFS_HOST_HCH1INTEN_REQOVRIE ( -- x addr ) 9 bit USBFS_HOST_HCH1INTEN ; \ USBFS_HOST_HCH1INTEN_REQOVRIE, request queue overrun interrupt enable
: USBFS_HOST_HCH1INTEN_DTERIE ( -- x addr ) 10 bit USBFS_HOST_HCH1INTEN ; \ USBFS_HOST_HCH1INTEN_DTERIE, Data toggle error interrupt enable

\ USBFS_HOST_HCH2INTEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH2INTEN_TFIE ( -- x addr ) 0 bit USBFS_HOST_HCH2INTEN ; \ USBFS_HOST_HCH2INTEN_TFIE, Transfer completed interrupt enable
: USBFS_HOST_HCH2INTEN_CHIE ( -- x addr ) 1 bit USBFS_HOST_HCH2INTEN ; \ USBFS_HOST_HCH2INTEN_CHIE, Channel halted interrupt enable
: USBFS_HOST_HCH2INTEN_STALLIE ( -- x addr ) 3 bit USBFS_HOST_HCH2INTEN ; \ USBFS_HOST_HCH2INTEN_STALLIE, STALL interrupt enable
: USBFS_HOST_HCH2INTEN_NAKIE ( -- x addr ) 4 bit USBFS_HOST_HCH2INTEN ; \ USBFS_HOST_HCH2INTEN_NAKIE, NAK interrupt enable
: USBFS_HOST_HCH2INTEN_ACKIE ( -- x addr ) 5 bit USBFS_HOST_HCH2INTEN ; \ USBFS_HOST_HCH2INTEN_ACKIE, ACK interrupt enable
: USBFS_HOST_HCH2INTEN_USBERIE ( -- x addr ) 7 bit USBFS_HOST_HCH2INTEN ; \ USBFS_HOST_HCH2INTEN_USBERIE, USB bus error interrupt enable
: USBFS_HOST_HCH2INTEN_BBERIE ( -- x addr ) 8 bit USBFS_HOST_HCH2INTEN ; \ USBFS_HOST_HCH2INTEN_BBERIE, Babble error interrupt enable
: USBFS_HOST_HCH2INTEN_REQOVRIE ( -- x addr ) 9 bit USBFS_HOST_HCH2INTEN ; \ USBFS_HOST_HCH2INTEN_REQOVRIE, request queue overrun interrupt enable
: USBFS_HOST_HCH2INTEN_DTERIE ( -- x addr ) 10 bit USBFS_HOST_HCH2INTEN ; \ USBFS_HOST_HCH2INTEN_DTERIE, Data toggle error interrupt enable

\ USBFS_HOST_HCH3INTEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH3INTEN_TFIE ( -- x addr ) 0 bit USBFS_HOST_HCH3INTEN ; \ USBFS_HOST_HCH3INTEN_TFIE, Transfer completed interrupt enable
: USBFS_HOST_HCH3INTEN_CHIE ( -- x addr ) 1 bit USBFS_HOST_HCH3INTEN ; \ USBFS_HOST_HCH3INTEN_CHIE, Channel halted interrupt enable
: USBFS_HOST_HCH3INTEN_STALLIE ( -- x addr ) 3 bit USBFS_HOST_HCH3INTEN ; \ USBFS_HOST_HCH3INTEN_STALLIE, STALL interrupt enable
: USBFS_HOST_HCH3INTEN_NAKIE ( -- x addr ) 4 bit USBFS_HOST_HCH3INTEN ; \ USBFS_HOST_HCH3INTEN_NAKIE, NAK interrupt enable
: USBFS_HOST_HCH3INTEN_ACKIE ( -- x addr ) 5 bit USBFS_HOST_HCH3INTEN ; \ USBFS_HOST_HCH3INTEN_ACKIE, ACK interrupt enable
: USBFS_HOST_HCH3INTEN_USBERIE ( -- x addr ) 7 bit USBFS_HOST_HCH3INTEN ; \ USBFS_HOST_HCH3INTEN_USBERIE, USB bus error interrupt enable
: USBFS_HOST_HCH3INTEN_BBERIE ( -- x addr ) 8 bit USBFS_HOST_HCH3INTEN ; \ USBFS_HOST_HCH3INTEN_BBERIE, Babble error interrupt enable
: USBFS_HOST_HCH3INTEN_REQOVRIE ( -- x addr ) 9 bit USBFS_HOST_HCH3INTEN ; \ USBFS_HOST_HCH3INTEN_REQOVRIE, request queue overrun interrupt enable
: USBFS_HOST_HCH3INTEN_DTERIE ( -- x addr ) 10 bit USBFS_HOST_HCH3INTEN ; \ USBFS_HOST_HCH3INTEN_DTERIE, Data toggle error interrupt enable

\ USBFS_HOST_HCH4INTEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH4INTEN_TFIE ( -- x addr ) 0 bit USBFS_HOST_HCH4INTEN ; \ USBFS_HOST_HCH4INTEN_TFIE, Transfer completed interrupt enable
: USBFS_HOST_HCH4INTEN_CHIE ( -- x addr ) 1 bit USBFS_HOST_HCH4INTEN ; \ USBFS_HOST_HCH4INTEN_CHIE, Channel halted interrupt enable
: USBFS_HOST_HCH4INTEN_STALLIE ( -- x addr ) 3 bit USBFS_HOST_HCH4INTEN ; \ USBFS_HOST_HCH4INTEN_STALLIE, STALL interrupt enable
: USBFS_HOST_HCH4INTEN_NAKIE ( -- x addr ) 4 bit USBFS_HOST_HCH4INTEN ; \ USBFS_HOST_HCH4INTEN_NAKIE, NAK interrupt enable
: USBFS_HOST_HCH4INTEN_ACKIE ( -- x addr ) 5 bit USBFS_HOST_HCH4INTEN ; \ USBFS_HOST_HCH4INTEN_ACKIE, ACK interrupt enable
: USBFS_HOST_HCH4INTEN_USBERIE ( -- x addr ) 7 bit USBFS_HOST_HCH4INTEN ; \ USBFS_HOST_HCH4INTEN_USBERIE, USB bus error interrupt enable
: USBFS_HOST_HCH4INTEN_BBERIE ( -- x addr ) 8 bit USBFS_HOST_HCH4INTEN ; \ USBFS_HOST_HCH4INTEN_BBERIE, Babble error interrupt enable
: USBFS_HOST_HCH4INTEN_REQOVRIE ( -- x addr ) 9 bit USBFS_HOST_HCH4INTEN ; \ USBFS_HOST_HCH4INTEN_REQOVRIE, request queue overrun interrupt enable
: USBFS_HOST_HCH4INTEN_DTERIE ( -- x addr ) 10 bit USBFS_HOST_HCH4INTEN ; \ USBFS_HOST_HCH4INTEN_DTERIE, Data toggle error interrupt enable

\ USBFS_HOST_HCH5INTEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH5INTEN_TFIE ( -- x addr ) 0 bit USBFS_HOST_HCH5INTEN ; \ USBFS_HOST_HCH5INTEN_TFIE, Transfer completed interrupt enable
: USBFS_HOST_HCH5INTEN_CHIE ( -- x addr ) 1 bit USBFS_HOST_HCH5INTEN ; \ USBFS_HOST_HCH5INTEN_CHIE, Channel halted interrupt enable
: USBFS_HOST_HCH5INTEN_STALLIE ( -- x addr ) 3 bit USBFS_HOST_HCH5INTEN ; \ USBFS_HOST_HCH5INTEN_STALLIE, STALL interrupt enable
: USBFS_HOST_HCH5INTEN_NAKIE ( -- x addr ) 4 bit USBFS_HOST_HCH5INTEN ; \ USBFS_HOST_HCH5INTEN_NAKIE, NAK interrupt enable
: USBFS_HOST_HCH5INTEN_ACKIE ( -- x addr ) 5 bit USBFS_HOST_HCH5INTEN ; \ USBFS_HOST_HCH5INTEN_ACKIE, ACK interrupt enable
: USBFS_HOST_HCH5INTEN_USBERIE ( -- x addr ) 7 bit USBFS_HOST_HCH5INTEN ; \ USBFS_HOST_HCH5INTEN_USBERIE, USB bus error interrupt enable
: USBFS_HOST_HCH5INTEN_BBERIE ( -- x addr ) 8 bit USBFS_HOST_HCH5INTEN ; \ USBFS_HOST_HCH5INTEN_BBERIE, Babble error interrupt enable
: USBFS_HOST_HCH5INTEN_REQOVRIE ( -- x addr ) 9 bit USBFS_HOST_HCH5INTEN ; \ USBFS_HOST_HCH5INTEN_REQOVRIE, request queue overrun interrupt enable
: USBFS_HOST_HCH5INTEN_DTERIE ( -- x addr ) 10 bit USBFS_HOST_HCH5INTEN ; \ USBFS_HOST_HCH5INTEN_DTERIE, Data toggle error interrupt enable

\ USBFS_HOST_HCH6INTEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH6INTEN_TFIE ( -- x addr ) 0 bit USBFS_HOST_HCH6INTEN ; \ USBFS_HOST_HCH6INTEN_TFIE, Transfer completed interrupt enable
: USBFS_HOST_HCH6INTEN_CHIE ( -- x addr ) 1 bit USBFS_HOST_HCH6INTEN ; \ USBFS_HOST_HCH6INTEN_CHIE, Channel halted interrupt enable
: USBFS_HOST_HCH6INTEN_STALLIE ( -- x addr ) 3 bit USBFS_HOST_HCH6INTEN ; \ USBFS_HOST_HCH6INTEN_STALLIE, STALL interrupt enable
: USBFS_HOST_HCH6INTEN_NAKIE ( -- x addr ) 4 bit USBFS_HOST_HCH6INTEN ; \ USBFS_HOST_HCH6INTEN_NAKIE, NAK interrupt enable
: USBFS_HOST_HCH6INTEN_ACKIE ( -- x addr ) 5 bit USBFS_HOST_HCH6INTEN ; \ USBFS_HOST_HCH6INTEN_ACKIE, ACK interrupt enable
: USBFS_HOST_HCH6INTEN_USBERIE ( -- x addr ) 7 bit USBFS_HOST_HCH6INTEN ; \ USBFS_HOST_HCH6INTEN_USBERIE, USB bus error interrupt enable
: USBFS_HOST_HCH6INTEN_BBERIE ( -- x addr ) 8 bit USBFS_HOST_HCH6INTEN ; \ USBFS_HOST_HCH6INTEN_BBERIE, Babble error interrupt enable
: USBFS_HOST_HCH6INTEN_REQOVRIE ( -- x addr ) 9 bit USBFS_HOST_HCH6INTEN ; \ USBFS_HOST_HCH6INTEN_REQOVRIE, request queue overrun interrupt enable
: USBFS_HOST_HCH6INTEN_DTERIE ( -- x addr ) 10 bit USBFS_HOST_HCH6INTEN ; \ USBFS_HOST_HCH6INTEN_DTERIE, Data toggle error interrupt enable

\ USBFS_HOST_HCH7INTEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH7INTEN_TFIE ( -- x addr ) 0 bit USBFS_HOST_HCH7INTEN ; \ USBFS_HOST_HCH7INTEN_TFIE, Transfer completed interrupt enable
: USBFS_HOST_HCH7INTEN_CHIE ( -- x addr ) 1 bit USBFS_HOST_HCH7INTEN ; \ USBFS_HOST_HCH7INTEN_CHIE, Channel halted interrupt enable
: USBFS_HOST_HCH7INTEN_STALLIE ( -- x addr ) 3 bit USBFS_HOST_HCH7INTEN ; \ USBFS_HOST_HCH7INTEN_STALLIE, STALL interrupt enable
: USBFS_HOST_HCH7INTEN_NAKIE ( -- x addr ) 4 bit USBFS_HOST_HCH7INTEN ; \ USBFS_HOST_HCH7INTEN_NAKIE, NAK interrupt enable
: USBFS_HOST_HCH7INTEN_ACKIE ( -- x addr ) 5 bit USBFS_HOST_HCH7INTEN ; \ USBFS_HOST_HCH7INTEN_ACKIE, ACK interrupt enable
: USBFS_HOST_HCH7INTEN_USBERIE ( -- x addr ) 7 bit USBFS_HOST_HCH7INTEN ; \ USBFS_HOST_HCH7INTEN_USBERIE, USB bus error interrupt enable
: USBFS_HOST_HCH7INTEN_BBERIE ( -- x addr ) 8 bit USBFS_HOST_HCH7INTEN ; \ USBFS_HOST_HCH7INTEN_BBERIE, Babble error interrupt enable
: USBFS_HOST_HCH7INTEN_REQOVRIE ( -- x addr ) 9 bit USBFS_HOST_HCH7INTEN ; \ USBFS_HOST_HCH7INTEN_REQOVRIE, request queue overrun interrupt enable
: USBFS_HOST_HCH7INTEN_DTERIE ( -- x addr ) 10 bit USBFS_HOST_HCH7INTEN ; \ USBFS_HOST_HCH7INTEN_DTERIE, Data toggle error interrupt enable

\ USBFS_HOST_HCH0LEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH0LEN_TLEN x addr ) USBFS_HOST_HCH0LEN ; \ USBFS_HOST_HCH0LEN_TLEN, Transfer length
: USBFS_HOST_HCH0LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_HOST_HCH0LEN ; \ USBFS_HOST_HCH0LEN_PCNT, Packet count
: USBFS_HOST_HCH0LEN_DPID ( %bb -- x addr ) 29 lshift USBFS_HOST_HCH0LEN ; \ USBFS_HOST_HCH0LEN_DPID, Data PID

\ USBFS_HOST_HCH1LEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH1LEN_TLEN x addr ) USBFS_HOST_HCH1LEN ; \ USBFS_HOST_HCH1LEN_TLEN, Transfer length
: USBFS_HOST_HCH1LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_HOST_HCH1LEN ; \ USBFS_HOST_HCH1LEN_PCNT, Packet count
: USBFS_HOST_HCH1LEN_DPID ( %bb -- x addr ) 29 lshift USBFS_HOST_HCH1LEN ; \ USBFS_HOST_HCH1LEN_DPID, Data PID

\ USBFS_HOST_HCH2LEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH2LEN_TLEN x addr ) USBFS_HOST_HCH2LEN ; \ USBFS_HOST_HCH2LEN_TLEN, Transfer length
: USBFS_HOST_HCH2LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_HOST_HCH2LEN ; \ USBFS_HOST_HCH2LEN_PCNT, Packet count
: USBFS_HOST_HCH2LEN_DPID ( %bb -- x addr ) 29 lshift USBFS_HOST_HCH2LEN ; \ USBFS_HOST_HCH2LEN_DPID, Data PID

\ USBFS_HOST_HCH3LEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH3LEN_TLEN x addr ) USBFS_HOST_HCH3LEN ; \ USBFS_HOST_HCH3LEN_TLEN, Transfer length
: USBFS_HOST_HCH3LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_HOST_HCH3LEN ; \ USBFS_HOST_HCH3LEN_PCNT, Packet count
: USBFS_HOST_HCH3LEN_DPID ( %bb -- x addr ) 29 lshift USBFS_HOST_HCH3LEN ; \ USBFS_HOST_HCH3LEN_DPID, Data PID

\ USBFS_HOST_HCH4LEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH4LEN_TLEN x addr ) USBFS_HOST_HCH4LEN ; \ USBFS_HOST_HCH4LEN_TLEN, Transfer length
: USBFS_HOST_HCH4LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_HOST_HCH4LEN ; \ USBFS_HOST_HCH4LEN_PCNT, Packet count
: USBFS_HOST_HCH4LEN_DPID ( %bb -- x addr ) 29 lshift USBFS_HOST_HCH4LEN ; \ USBFS_HOST_HCH4LEN_DPID, Data PID

\ USBFS_HOST_HCH5LEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH5LEN_TLEN x addr ) USBFS_HOST_HCH5LEN ; \ USBFS_HOST_HCH5LEN_TLEN, Transfer length
: USBFS_HOST_HCH5LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_HOST_HCH5LEN ; \ USBFS_HOST_HCH5LEN_PCNT, Packet count
: USBFS_HOST_HCH5LEN_DPID ( %bb -- x addr ) 29 lshift USBFS_HOST_HCH5LEN ; \ USBFS_HOST_HCH5LEN_DPID, Data PID

\ USBFS_HOST_HCH6LEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH6LEN_TLEN x addr ) USBFS_HOST_HCH6LEN ; \ USBFS_HOST_HCH6LEN_TLEN, Transfer length
: USBFS_HOST_HCH6LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_HOST_HCH6LEN ; \ USBFS_HOST_HCH6LEN_PCNT, Packet count
: USBFS_HOST_HCH6LEN_DPID ( %bb -- x addr ) 29 lshift USBFS_HOST_HCH6LEN ; \ USBFS_HOST_HCH6LEN_DPID, Data PID

\ USBFS_HOST_HCH7LEN (read-write) Reset:0x00000000
: USBFS_HOST_HCH7LEN_TLEN x addr ) USBFS_HOST_HCH7LEN ; \ USBFS_HOST_HCH7LEN_TLEN, Transfer length
: USBFS_HOST_HCH7LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_HOST_HCH7LEN ; \ USBFS_HOST_HCH7LEN_PCNT, Packet count
: USBFS_HOST_HCH7LEN_DPID ( %bb -- x addr ) 29 lshift USBFS_HOST_HCH7LEN ; \ USBFS_HOST_HCH7LEN_DPID, Data PID

\ USBFS_DEVICE_DCFG (read-write) Reset:0x00000000
: USBFS_DEVICE_DCFG_DS ( %bb -- x addr ) USBFS_DEVICE_DCFG ; \ USBFS_DEVICE_DCFG_DS, Device speed
: USBFS_DEVICE_DCFG_NZLSOH ( -- x addr ) 2 bit USBFS_DEVICE_DCFG ; \ USBFS_DEVICE_DCFG_NZLSOH, Non-zero-length status OUT  handshake
: USBFS_DEVICE_DCFG_DAR ( %bbbbbbb -- x addr ) 4 lshift USBFS_DEVICE_DCFG ; \ USBFS_DEVICE_DCFG_DAR, Device address
: USBFS_DEVICE_DCFG_EOPFT ( %bb -- x addr ) 11 lshift USBFS_DEVICE_DCFG ; \ USBFS_DEVICE_DCFG_EOPFT, end of periodic frame time

\ USBFS_DEVICE_DCTL (multiple-access)  Reset:0x00000000
: USBFS_DEVICE_DCTL_RWKUP ( -- x addr ) 0 bit USBFS_DEVICE_DCTL ; \ USBFS_DEVICE_DCTL_RWKUP, Remote wakeup
: USBFS_DEVICE_DCTL_SD ( -- x addr ) 1 bit USBFS_DEVICE_DCTL ; \ USBFS_DEVICE_DCTL_SD, Soft disconnect
: USBFS_DEVICE_DCTL_GINS? ( -- 1|0 ) 2 bit USBFS_DEVICE_DCTL bit@ ; \ USBFS_DEVICE_DCTL_GINS, Global IN NAK status
: USBFS_DEVICE_DCTL_GONS? ( -- 1|0 ) 3 bit USBFS_DEVICE_DCTL bit@ ; \ USBFS_DEVICE_DCTL_GONS, Global OUT NAK status
: USBFS_DEVICE_DCTL_SGINAK ( -- x addr ) 7 bit USBFS_DEVICE_DCTL ; \ USBFS_DEVICE_DCTL_SGINAK, Set global IN NAK
: USBFS_DEVICE_DCTL_CGINAK ( -- x addr ) 8 bit USBFS_DEVICE_DCTL ; \ USBFS_DEVICE_DCTL_CGINAK, Clear global IN NAK
: USBFS_DEVICE_DCTL_SGONAK ( -- x addr ) 9 bit USBFS_DEVICE_DCTL ; \ USBFS_DEVICE_DCTL_SGONAK, Set global OUT NAK
: USBFS_DEVICE_DCTL_CGONAK ( -- x addr ) 10 bit USBFS_DEVICE_DCTL ; \ USBFS_DEVICE_DCTL_CGONAK, Clear global OUT NAK
: USBFS_DEVICE_DCTL_POIF? ( -- 1|0 ) 11 bit USBFS_DEVICE_DCTL bit@ ; \ USBFS_DEVICE_DCTL_POIF, Power-on initialization flag

\ USBFS_DEVICE_DSTAT (read-only) Reset:0x00000000
: USBFS_DEVICE_DSTAT_SPST? ( --  1|0 ) 0 bit USBFS_DEVICE_DSTAT bit@ ; \ USBFS_DEVICE_DSTAT_SPST, Suspend status
: USBFS_DEVICE_DSTAT_ES? ( --  x ) 1 lshift USBFS_DEVICE_DSTAT @ ; \ USBFS_DEVICE_DSTAT_ES, Enumerated speed
: USBFS_DEVICE_DSTAT_FNRSOF? ( --  x ) 8 lshift USBFS_DEVICE_DSTAT @ ; \ USBFS_DEVICE_DSTAT_FNRSOF, Frame number of the received  SOF

\ USBFS_DEVICE_DIEPINTEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DIEPINTEN_TFEN ( -- x addr ) 0 bit USBFS_DEVICE_DIEPINTEN ; \ USBFS_DEVICE_DIEPINTEN_TFEN, Transfer finished interrupt  enable
: USBFS_DEVICE_DIEPINTEN_EPDISEN ( -- x addr ) 1 bit USBFS_DEVICE_DIEPINTEN ; \ USBFS_DEVICE_DIEPINTEN_EPDISEN, Endpoint disabled interrupt  enable
: USBFS_DEVICE_DIEPINTEN_CITOEN ( -- x addr ) 3 bit USBFS_DEVICE_DIEPINTEN ; \ USBFS_DEVICE_DIEPINTEN_CITOEN, Control IN timeout condition interrupt enable Non-isochronous  endpoints
: USBFS_DEVICE_DIEPINTEN_EPTXFUDEN ( -- x addr ) 4 bit USBFS_DEVICE_DIEPINTEN ; \ USBFS_DEVICE_DIEPINTEN_EPTXFUDEN, Endpoint Tx FIFO underrun interrupt enable bit
: USBFS_DEVICE_DIEPINTEN_IEPNEEN ( -- x addr ) 6 bit USBFS_DEVICE_DIEPINTEN ; \ USBFS_DEVICE_DIEPINTEN_IEPNEEN, IN endpoint NAK effective  interrupt enable

\ USBFS_DEVICE_DOEPINTEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DOEPINTEN_TFEN ( -- x addr ) 0 bit USBFS_DEVICE_DOEPINTEN ; \ USBFS_DEVICE_DOEPINTEN_TFEN, Transfer finished interrupt  enable
: USBFS_DEVICE_DOEPINTEN_EPDISEN ( -- x addr ) 1 bit USBFS_DEVICE_DOEPINTEN ; \ USBFS_DEVICE_DOEPINTEN_EPDISEN, Endpoint disabled interrupt  enable
: USBFS_DEVICE_DOEPINTEN_STPFEN ( -- x addr ) 3 bit USBFS_DEVICE_DOEPINTEN ; \ USBFS_DEVICE_DOEPINTEN_STPFEN, SETUP phase finished interrupt enable
: USBFS_DEVICE_DOEPINTEN_EPRXFOVREN ( -- x addr ) 4 bit USBFS_DEVICE_DOEPINTEN ; \ USBFS_DEVICE_DOEPINTEN_EPRXFOVREN,  Endpoint Rx FIFO overrun interrupt enable
: USBFS_DEVICE_DOEPINTEN_BTBSTPEN ( -- x addr ) 6 bit USBFS_DEVICE_DOEPINTEN ; \ USBFS_DEVICE_DOEPINTEN_BTBSTPEN,  Back-to-back SETUP packets  interrupt enable

\ USBFS_DEVICE_DAEPINT (read-only) Reset:0x00000000
: USBFS_DEVICE_DAEPINT_IEPITB? ( --  x ) USBFS_DEVICE_DAEPINT @ ; \ USBFS_DEVICE_DAEPINT_IEPITB, Device all IN endpoint interrupt bits
: USBFS_DEVICE_DAEPINT_OEPITB? ( --  x ) 16 lshift USBFS_DEVICE_DAEPINT @ ; \ USBFS_DEVICE_DAEPINT_OEPITB, Device all OUT endpoint interrupt bits

\ USBFS_DEVICE_DAEPINTEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DAEPINTEN_IEPIE ( %bbbb -- x addr ) USBFS_DEVICE_DAEPINTEN ; \ USBFS_DEVICE_DAEPINTEN_IEPIE, IN EP interrupt interrupt enable bits
: USBFS_DEVICE_DAEPINTEN_OEPIE ( %bbbb -- x addr ) 16 lshift USBFS_DEVICE_DAEPINTEN ; \ USBFS_DEVICE_DAEPINTEN_OEPIE, OUT endpoint interrupt enable bits

\ USBFS_DEVICE_DVBUSDT (read-write) Reset:0x000017D7
: USBFS_DEVICE_DVBUSDT_DVBUSDT ( %bbbbbbbbbbbbbbbb -- x addr ) USBFS_DEVICE_DVBUSDT ; \ USBFS_DEVICE_DVBUSDT_DVBUSDT, Device VBUS discharge time

\ USBFS_DEVICE_DVBUSPT (read-write) Reset:0x000005B8
: USBFS_DEVICE_DVBUSPT_DVBUSPT ( %bbbbbbbbbbb -- x addr ) USBFS_DEVICE_DVBUSPT ; \ USBFS_DEVICE_DVBUSPT_DVBUSPT, Device VBUS pulsing time

\ USBFS_DEVICE_DIEPFEINTEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DIEPFEINTEN_IEPTXFEIE ( %bbbb -- x addr ) USBFS_DEVICE_DIEPFEINTEN ; \ USBFS_DEVICE_DIEPFEINTEN_IEPTXFEIE, IN EP Tx FIFO empty interrupt enable  bits

\ USBFS_DEVICE_DIEP0CTL (multiple-access)  Reset:0x00008000
: USBFS_DEVICE_DIEP0CTL_MPL ( %bb -- x addr ) USBFS_DEVICE_DIEP0CTL ; \ USBFS_DEVICE_DIEP0CTL_MPL, Maximum packet length
: USBFS_DEVICE_DIEP0CTL_EPACT ( -- x addr ) 15 bit USBFS_DEVICE_DIEP0CTL ; \ USBFS_DEVICE_DIEP0CTL_EPACT, endpoint active
: USBFS_DEVICE_DIEP0CTL_NAKS? ( -- 1|0 ) 17 bit USBFS_DEVICE_DIEP0CTL bit@ ; \ USBFS_DEVICE_DIEP0CTL_NAKS, NAK status
: USBFS_DEVICE_DIEP0CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_DEVICE_DIEP0CTL ; \ USBFS_DEVICE_DIEP0CTL_EPTYPE, Endpoint type
: USBFS_DEVICE_DIEP0CTL_STALL ( -- x addr ) 21 bit USBFS_DEVICE_DIEP0CTL ; \ USBFS_DEVICE_DIEP0CTL_STALL, STALL handshake
: USBFS_DEVICE_DIEP0CTL_TXFNUM ( %bbbb -- x addr ) 22 lshift USBFS_DEVICE_DIEP0CTL ; \ USBFS_DEVICE_DIEP0CTL_TXFNUM, TxFIFO number
: USBFS_DEVICE_DIEP0CTL_CNAK ( -- x addr ) 26 bit USBFS_DEVICE_DIEP0CTL ; \ USBFS_DEVICE_DIEP0CTL_CNAK, Clear NAK
: USBFS_DEVICE_DIEP0CTL_SNAK ( -- x addr ) 27 bit USBFS_DEVICE_DIEP0CTL ; \ USBFS_DEVICE_DIEP0CTL_SNAK, Set NAK
: USBFS_DEVICE_DIEP0CTL_EPD ( -- x addr ) 30 bit USBFS_DEVICE_DIEP0CTL ; \ USBFS_DEVICE_DIEP0CTL_EPD, Endpoint disable
: USBFS_DEVICE_DIEP0CTL_EPEN ( -- x addr ) 31 bit USBFS_DEVICE_DIEP0CTL ; \ USBFS_DEVICE_DIEP0CTL_EPEN, Endpoint enable

\ USBFS_DEVICE_DIEP1CTL (multiple-access)  Reset:0x00000000
: USBFS_DEVICE_DIEP1CTL_EPEN ( -- x addr ) 31 bit USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_EPEN, Endpoint enable
: USBFS_DEVICE_DIEP1CTL_EPD ( -- x addr ) 30 bit USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_EPD, Endpoint disable
: USBFS_DEVICE_DIEP1CTL_SD1PID_SODDFRM ( -- x addr ) 29 bit USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_SD1PID_SODDFRM, Set DATA1 PID/Set odd frame
: USBFS_DEVICE_DIEP1CTL_SD0PID_SEVENFRM ( -- x addr ) 28 bit USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_SD0PID_SEVENFRM, SD0PID/SEVNFRM
: USBFS_DEVICE_DIEP1CTL_SNAK ( -- x addr ) 27 bit USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_SNAK, Set NAK
: USBFS_DEVICE_DIEP1CTL_CNAK ( -- x addr ) 26 bit USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_CNAK, Clear NAK
: USBFS_DEVICE_DIEP1CTL_TXFNUM ( %bbbb -- x addr ) 22 lshift USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_TXFNUM, Tx FIFO number
: USBFS_DEVICE_DIEP1CTL_STALL ( -- x addr ) 21 bit USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_STALL, STALL handshake
: USBFS_DEVICE_DIEP1CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_EPTYPE, Endpoint type
: USBFS_DEVICE_DIEP1CTL_NAKS? ( -- 1|0 ) 17 bit USBFS_DEVICE_DIEP1CTL bit@ ; \ USBFS_DEVICE_DIEP1CTL_NAKS, NAK status
: USBFS_DEVICE_DIEP1CTL_EOFRM_DPID ( -- x addr ) 16 bit USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_EOFRM_DPID, EOFRM/DPID
: USBFS_DEVICE_DIEP1CTL_EPACT ( -- x addr ) 15 bit USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_EPACT, Endpoint active
: USBFS_DEVICE_DIEP1CTL_MPL x addr ) USBFS_DEVICE_DIEP1CTL ; \ USBFS_DEVICE_DIEP1CTL_MPL, maximum packet length

\ USBFS_DEVICE_DIEP2CTL (multiple-access)  Reset:0x00000000
: USBFS_DEVICE_DIEP2CTL_EPEN ( -- x addr ) 31 bit USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_EPEN, Endpoint enable
: USBFS_DEVICE_DIEP2CTL_EPD ( -- x addr ) 30 bit USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_EPD, Endpoint disable
: USBFS_DEVICE_DIEP2CTL_SD1PID_SODDFRM ( -- x addr ) 29 bit USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_SD1PID_SODDFRM, Set DATA1 PID/Set odd frame
: USBFS_DEVICE_DIEP2CTL_SD0PID_SEVENFRM ( -- x addr ) 28 bit USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_SD0PID_SEVENFRM, SD0PID/SEVNFRM
: USBFS_DEVICE_DIEP2CTL_SNAK ( -- x addr ) 27 bit USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_SNAK, Set NAK
: USBFS_DEVICE_DIEP2CTL_CNAK ( -- x addr ) 26 bit USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_CNAK, Clear NAK
: USBFS_DEVICE_DIEP2CTL_TXFNUM ( %bbbb -- x addr ) 22 lshift USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_TXFNUM, Tx FIFO number
: USBFS_DEVICE_DIEP2CTL_STALL ( -- x addr ) 21 bit USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_STALL, STALL handshake
: USBFS_DEVICE_DIEP2CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_EPTYPE, Endpoint type
: USBFS_DEVICE_DIEP2CTL_NAKS? ( -- 1|0 ) 17 bit USBFS_DEVICE_DIEP2CTL bit@ ; \ USBFS_DEVICE_DIEP2CTL_NAKS, NAK status
: USBFS_DEVICE_DIEP2CTL_EOFRM_DPID ( -- x addr ) 16 bit USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_EOFRM_DPID, EOFRM/DPID
: USBFS_DEVICE_DIEP2CTL_EPACT ( -- x addr ) 15 bit USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_EPACT, Endpoint active
: USBFS_DEVICE_DIEP2CTL_MPL x addr ) USBFS_DEVICE_DIEP2CTL ; \ USBFS_DEVICE_DIEP2CTL_MPL, maximum packet length

\ USBFS_DEVICE_DIEP3CTL (multiple-access)  Reset:0x00000000
: USBFS_DEVICE_DIEP3CTL_EPEN ( -- x addr ) 31 bit USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_EPEN, Endpoint enable
: USBFS_DEVICE_DIEP3CTL_EPD ( -- x addr ) 30 bit USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_EPD, Endpoint disable
: USBFS_DEVICE_DIEP3CTL_SD1PID_SODDFRM ( -- x addr ) 29 bit USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_SD1PID_SODDFRM, Set DATA1 PID/Set odd frame
: USBFS_DEVICE_DIEP3CTL_SD0PID_SEVENFRM ( -- x addr ) 28 bit USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_SD0PID_SEVENFRM, SD0PID/SEVNFRM
: USBFS_DEVICE_DIEP3CTL_SNAK ( -- x addr ) 27 bit USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_SNAK, Set NAK
: USBFS_DEVICE_DIEP3CTL_CNAK ( -- x addr ) 26 bit USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_CNAK, Clear NAK
: USBFS_DEVICE_DIEP3CTL_TXFNUM ( %bbbb -- x addr ) 22 lshift USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_TXFNUM, Tx FIFO number
: USBFS_DEVICE_DIEP3CTL_STALL ( -- x addr ) 21 bit USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_STALL, STALL handshake
: USBFS_DEVICE_DIEP3CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_EPTYPE, Endpoint type
: USBFS_DEVICE_DIEP3CTL_NAKS? ( -- 1|0 ) 17 bit USBFS_DEVICE_DIEP3CTL bit@ ; \ USBFS_DEVICE_DIEP3CTL_NAKS, NAK status
: USBFS_DEVICE_DIEP3CTL_EOFRM_DPID ( -- x addr ) 16 bit USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_EOFRM_DPID, EOFRM/DPID
: USBFS_DEVICE_DIEP3CTL_EPACT ( -- x addr ) 15 bit USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_EPACT, Endpoint active
: USBFS_DEVICE_DIEP3CTL_MPL x addr ) USBFS_DEVICE_DIEP3CTL ; \ USBFS_DEVICE_DIEP3CTL_MPL, maximum packet length

\ USBFS_DEVICE_DOEP0CTL (multiple-access)  Reset:0x00008000
: USBFS_DEVICE_DOEP0CTL_EPEN ( -- x addr ) 31 bit USBFS_DEVICE_DOEP0CTL ; \ USBFS_DEVICE_DOEP0CTL_EPEN, Endpoint enable
: USBFS_DEVICE_DOEP0CTL_EPD ( -- x addr ) 30 bit USBFS_DEVICE_DOEP0CTL ; \ USBFS_DEVICE_DOEP0CTL_EPD, Endpoint disable
: USBFS_DEVICE_DOEP0CTL_SNAK ( -- x addr ) 27 bit USBFS_DEVICE_DOEP0CTL ; \ USBFS_DEVICE_DOEP0CTL_SNAK, Set NAK
: USBFS_DEVICE_DOEP0CTL_CNAK ( -- x addr ) 26 bit USBFS_DEVICE_DOEP0CTL ; \ USBFS_DEVICE_DOEP0CTL_CNAK, Clear NAK
: USBFS_DEVICE_DOEP0CTL_STALL ( -- x addr ) 21 bit USBFS_DEVICE_DOEP0CTL ; \ USBFS_DEVICE_DOEP0CTL_STALL, STALL handshake
: USBFS_DEVICE_DOEP0CTL_SNOOP ( -- x addr ) 20 bit USBFS_DEVICE_DOEP0CTL ; \ USBFS_DEVICE_DOEP0CTL_SNOOP, Snoop mode
: USBFS_DEVICE_DOEP0CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_DEVICE_DOEP0CTL ; \ USBFS_DEVICE_DOEP0CTL_EPTYPE, Endpoint type
: USBFS_DEVICE_DOEP0CTL_NAKS? ( -- 1|0 ) 17 bit USBFS_DEVICE_DOEP0CTL bit@ ; \ USBFS_DEVICE_DOEP0CTL_NAKS, NAK status
: USBFS_DEVICE_DOEP0CTL_EPACT ( -- x addr ) 15 bit USBFS_DEVICE_DOEP0CTL ; \ USBFS_DEVICE_DOEP0CTL_EPACT, Endpoint active
: USBFS_DEVICE_DOEP0CTL_MPL ( %bb -- x addr ) USBFS_DEVICE_DOEP0CTL ; \ USBFS_DEVICE_DOEP0CTL_MPL, Maximum packet length

\ USBFS_DEVICE_DOEP1CTL (multiple-access)  Reset:0x00000000
: USBFS_DEVICE_DOEP1CTL_EPEN ( -- x addr ) 31 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_EPEN, Endpoint enable
: USBFS_DEVICE_DOEP1CTL_EPD ( -- x addr ) 30 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_EPD, Endpoint disable
: USBFS_DEVICE_DOEP1CTL_SD1PID_SODDFRM ( -- x addr ) 29 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_SD1PID_SODDFRM, SD1PID/SODDFRM
: USBFS_DEVICE_DOEP1CTL_SD0PID_SEVENFRM ( -- x addr ) 28 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_SD0PID_SEVENFRM, SD0PID/SEVENFRM
: USBFS_DEVICE_DOEP1CTL_SNAK ( -- x addr ) 27 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_SNAK, Set NAK
: USBFS_DEVICE_DOEP1CTL_CNAK ( -- x addr ) 26 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_CNAK, Clear NAK
: USBFS_DEVICE_DOEP1CTL_STALL ( -- x addr ) 21 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_STALL, STALL handshake
: USBFS_DEVICE_DOEP1CTL_SNOOP ( -- x addr ) 20 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_SNOOP, Snoop mode
: USBFS_DEVICE_DOEP1CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_EPTYPE, Endpoint type
: USBFS_DEVICE_DOEP1CTL_NAKS? ( -- 1|0 ) 17 bit USBFS_DEVICE_DOEP1CTL bit@ ; \ USBFS_DEVICE_DOEP1CTL_NAKS, NAK status
: USBFS_DEVICE_DOEP1CTL_EOFRM_DPID ( -- x addr ) 16 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_EOFRM_DPID, EOFRM/DPID
: USBFS_DEVICE_DOEP1CTL_EPACT ( -- x addr ) 15 bit USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_EPACT, Endpoint active
: USBFS_DEVICE_DOEP1CTL_MPL x addr ) USBFS_DEVICE_DOEP1CTL ; \ USBFS_DEVICE_DOEP1CTL_MPL, maximum packet length

\ USBFS_DEVICE_DOEP2CTL (multiple-access)  Reset:0x00000000
: USBFS_DEVICE_DOEP2CTL_EPEN ( -- x addr ) 31 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_EPEN, Endpoint enable
: USBFS_DEVICE_DOEP2CTL_EPD ( -- x addr ) 30 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_EPD, Endpoint disable
: USBFS_DEVICE_DOEP2CTL_SD1PID_SODDFRM ( -- x addr ) 29 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_SD1PID_SODDFRM, SD1PID/SODDFRM
: USBFS_DEVICE_DOEP2CTL_SD0PID_SEVENFRM ( -- x addr ) 28 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_SD0PID_SEVENFRM, SD0PID/SEVENFRM
: USBFS_DEVICE_DOEP2CTL_SNAK ( -- x addr ) 27 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_SNAK, Set NAK
: USBFS_DEVICE_DOEP2CTL_CNAK ( -- x addr ) 26 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_CNAK, Clear NAK
: USBFS_DEVICE_DOEP2CTL_STALL ( -- x addr ) 21 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_STALL, STALL handshake
: USBFS_DEVICE_DOEP2CTL_SNOOP ( -- x addr ) 20 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_SNOOP, Snoop mode
: USBFS_DEVICE_DOEP2CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_EPTYPE, Endpoint type
: USBFS_DEVICE_DOEP2CTL_NAKS? ( -- 1|0 ) 17 bit USBFS_DEVICE_DOEP2CTL bit@ ; \ USBFS_DEVICE_DOEP2CTL_NAKS, NAK status
: USBFS_DEVICE_DOEP2CTL_EOFRM_DPID ( -- x addr ) 16 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_EOFRM_DPID, EOFRM/DPID
: USBFS_DEVICE_DOEP2CTL_EPACT ( -- x addr ) 15 bit USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_EPACT, Endpoint active
: USBFS_DEVICE_DOEP2CTL_MPL x addr ) USBFS_DEVICE_DOEP2CTL ; \ USBFS_DEVICE_DOEP2CTL_MPL, maximum packet length

\ USBFS_DEVICE_DOEP3CTL (multiple-access)  Reset:0x00000000
: USBFS_DEVICE_DOEP3CTL_EPEN ( -- x addr ) 31 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_EPEN, Endpoint enable
: USBFS_DEVICE_DOEP3CTL_EPD ( -- x addr ) 30 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_EPD, Endpoint disable
: USBFS_DEVICE_DOEP3CTL_SD1PID_SODDFRM ( -- x addr ) 29 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_SD1PID_SODDFRM, SD1PID/SODDFRM
: USBFS_DEVICE_DOEP3CTL_SD0PID_SEVENFRM ( -- x addr ) 28 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_SD0PID_SEVENFRM, SD0PID/SEVENFRM
: USBFS_DEVICE_DOEP3CTL_SNAK ( -- x addr ) 27 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_SNAK, Set NAK
: USBFS_DEVICE_DOEP3CTL_CNAK ( -- x addr ) 26 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_CNAK, Clear NAK
: USBFS_DEVICE_DOEP3CTL_STALL ( -- x addr ) 21 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_STALL, STALL handshake
: USBFS_DEVICE_DOEP3CTL_SNOOP ( -- x addr ) 20 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_SNOOP, Snoop mode
: USBFS_DEVICE_DOEP3CTL_EPTYPE ( %bb -- x addr ) 18 lshift USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_EPTYPE, Endpoint type
: USBFS_DEVICE_DOEP3CTL_NAKS? ( -- 1|0 ) 17 bit USBFS_DEVICE_DOEP3CTL bit@ ; \ USBFS_DEVICE_DOEP3CTL_NAKS, NAK status
: USBFS_DEVICE_DOEP3CTL_EOFRM_DPID ( -- x addr ) 16 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_EOFRM_DPID, EOFRM/DPID
: USBFS_DEVICE_DOEP3CTL_EPACT ( -- x addr ) 15 bit USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_EPACT, Endpoint active
: USBFS_DEVICE_DOEP3CTL_MPL x addr ) USBFS_DEVICE_DOEP3CTL ; \ USBFS_DEVICE_DOEP3CTL_MPL, maximum packet length

\ USBFS_DEVICE_DIEP0INTF (multiple-access)  Reset:0x00000080
: USBFS_DEVICE_DIEP0INTF_TXFE ( -- x addr ) 7 bit USBFS_DEVICE_DIEP0INTF ; \ USBFS_DEVICE_DIEP0INTF_TXFE, Transmit FIFO empty
: USBFS_DEVICE_DIEP0INTF_IEPNE ( -- x addr ) 6 bit USBFS_DEVICE_DIEP0INTF ; \ USBFS_DEVICE_DIEP0INTF_IEPNE, IN endpoint NAK effective
: USBFS_DEVICE_DIEP0INTF_EPTXFUD ( -- x addr ) 4 bit USBFS_DEVICE_DIEP0INTF ; \ USBFS_DEVICE_DIEP0INTF_EPTXFUD, Endpoint Tx FIFO underrun
: USBFS_DEVICE_DIEP0INTF_CITO ( -- x addr ) 3 bit USBFS_DEVICE_DIEP0INTF ; \ USBFS_DEVICE_DIEP0INTF_CITO, Control in timeout interrupt
: USBFS_DEVICE_DIEP0INTF_EPDIS ( -- x addr ) 1 bit USBFS_DEVICE_DIEP0INTF ; \ USBFS_DEVICE_DIEP0INTF_EPDIS, Endpoint finished
: USBFS_DEVICE_DIEP0INTF_TF ( -- x addr ) 0 bit USBFS_DEVICE_DIEP0INTF ; \ USBFS_DEVICE_DIEP0INTF_TF, Transfer finished

\ USBFS_DEVICE_DIEP1INTF (multiple-access)  Reset:0x00000080
: USBFS_DEVICE_DIEP1INTF_TXFE ( -- x addr ) 7 bit USBFS_DEVICE_DIEP1INTF ; \ USBFS_DEVICE_DIEP1INTF_TXFE, Transmit FIFO empty
: USBFS_DEVICE_DIEP1INTF_IEPNE ( -- x addr ) 6 bit USBFS_DEVICE_DIEP1INTF ; \ USBFS_DEVICE_DIEP1INTF_IEPNE, IN endpoint NAK effective
: USBFS_DEVICE_DIEP1INTF_EPTXFUD ( -- x addr ) 4 bit USBFS_DEVICE_DIEP1INTF ; \ USBFS_DEVICE_DIEP1INTF_EPTXFUD, Endpoint Tx FIFO underrun
: USBFS_DEVICE_DIEP1INTF_CITO ( -- x addr ) 3 bit USBFS_DEVICE_DIEP1INTF ; \ USBFS_DEVICE_DIEP1INTF_CITO, Control in timeout interrupt
: USBFS_DEVICE_DIEP1INTF_EPDIS ( -- x addr ) 1 bit USBFS_DEVICE_DIEP1INTF ; \ USBFS_DEVICE_DIEP1INTF_EPDIS, Endpoint finished
: USBFS_DEVICE_DIEP1INTF_TF ( -- x addr ) 0 bit USBFS_DEVICE_DIEP1INTF ; \ USBFS_DEVICE_DIEP1INTF_TF, Transfer finished

\ USBFS_DEVICE_DIEP2INTF (multiple-access)  Reset:0x00000080
: USBFS_DEVICE_DIEP2INTF_TXFE ( -- x addr ) 7 bit USBFS_DEVICE_DIEP2INTF ; \ USBFS_DEVICE_DIEP2INTF_TXFE, Transmit FIFO empty
: USBFS_DEVICE_DIEP2INTF_IEPNE ( -- x addr ) 6 bit USBFS_DEVICE_DIEP2INTF ; \ USBFS_DEVICE_DIEP2INTF_IEPNE, IN endpoint NAK effective
: USBFS_DEVICE_DIEP2INTF_EPTXFUD ( -- x addr ) 4 bit USBFS_DEVICE_DIEP2INTF ; \ USBFS_DEVICE_DIEP2INTF_EPTXFUD, Endpoint Tx FIFO underrun
: USBFS_DEVICE_DIEP2INTF_CITO ( -- x addr ) 3 bit USBFS_DEVICE_DIEP2INTF ; \ USBFS_DEVICE_DIEP2INTF_CITO, Control in timeout interrupt
: USBFS_DEVICE_DIEP2INTF_EPDIS ( -- x addr ) 1 bit USBFS_DEVICE_DIEP2INTF ; \ USBFS_DEVICE_DIEP2INTF_EPDIS, Endpoint finished
: USBFS_DEVICE_DIEP2INTF_TF ( -- x addr ) 0 bit USBFS_DEVICE_DIEP2INTF ; \ USBFS_DEVICE_DIEP2INTF_TF, Transfer finished

\ USBFS_DEVICE_DIEP3INTF (multiple-access)  Reset:0x00000080
: USBFS_DEVICE_DIEP3INTF_TXFE ( -- x addr ) 7 bit USBFS_DEVICE_DIEP3INTF ; \ USBFS_DEVICE_DIEP3INTF_TXFE, Transmit FIFO empty
: USBFS_DEVICE_DIEP3INTF_IEPNE ( -- x addr ) 6 bit USBFS_DEVICE_DIEP3INTF ; \ USBFS_DEVICE_DIEP3INTF_IEPNE, IN endpoint NAK effective
: USBFS_DEVICE_DIEP3INTF_EPTXFUD ( -- x addr ) 4 bit USBFS_DEVICE_DIEP3INTF ; \ USBFS_DEVICE_DIEP3INTF_EPTXFUD, Endpoint Tx FIFO underrun
: USBFS_DEVICE_DIEP3INTF_CITO ( -- x addr ) 3 bit USBFS_DEVICE_DIEP3INTF ; \ USBFS_DEVICE_DIEP3INTF_CITO, Control in timeout interrupt
: USBFS_DEVICE_DIEP3INTF_EPDIS ( -- x addr ) 1 bit USBFS_DEVICE_DIEP3INTF ; \ USBFS_DEVICE_DIEP3INTF_EPDIS, Endpoint finished
: USBFS_DEVICE_DIEP3INTF_TF ( -- x addr ) 0 bit USBFS_DEVICE_DIEP3INTF ; \ USBFS_DEVICE_DIEP3INTF_TF, Transfer finished

\ USBFS_DEVICE_DOEP0INTF (read-write) Reset:0x00000000
: USBFS_DEVICE_DOEP0INTF_BTBSTP ( -- x addr ) 6 bit USBFS_DEVICE_DOEP0INTF ; \ USBFS_DEVICE_DOEP0INTF_BTBSTP, Back-to-back SETUP packets
: USBFS_DEVICE_DOEP0INTF_EPRXFOVR ( -- x addr ) 4 bit USBFS_DEVICE_DOEP0INTF ; \ USBFS_DEVICE_DOEP0INTF_EPRXFOVR, Endpoint Rx FIFO overrun
: USBFS_DEVICE_DOEP0INTF_STPF ( -- x addr ) 3 bit USBFS_DEVICE_DOEP0INTF ; \ USBFS_DEVICE_DOEP0INTF_STPF, Setup phase finished
: USBFS_DEVICE_DOEP0INTF_EPDIS ( -- x addr ) 1 bit USBFS_DEVICE_DOEP0INTF ; \ USBFS_DEVICE_DOEP0INTF_EPDIS, Endpoint disabled
: USBFS_DEVICE_DOEP0INTF_TF ( -- x addr ) 0 bit USBFS_DEVICE_DOEP0INTF ; \ USBFS_DEVICE_DOEP0INTF_TF, Transfer finished

\ USBFS_DEVICE_DOEP1INTF (read-write) Reset:0x00000000
: USBFS_DEVICE_DOEP1INTF_BTBSTP ( -- x addr ) 6 bit USBFS_DEVICE_DOEP1INTF ; \ USBFS_DEVICE_DOEP1INTF_BTBSTP, Back-to-back SETUP packets
: USBFS_DEVICE_DOEP1INTF_EPRXFOVR ( -- x addr ) 4 bit USBFS_DEVICE_DOEP1INTF ; \ USBFS_DEVICE_DOEP1INTF_EPRXFOVR, Endpoint Rx FIFO overrun
: USBFS_DEVICE_DOEP1INTF_STPF ( -- x addr ) 3 bit USBFS_DEVICE_DOEP1INTF ; \ USBFS_DEVICE_DOEP1INTF_STPF, Setup phase finished
: USBFS_DEVICE_DOEP1INTF_EPDIS ( -- x addr ) 1 bit USBFS_DEVICE_DOEP1INTF ; \ USBFS_DEVICE_DOEP1INTF_EPDIS, Endpoint disabled
: USBFS_DEVICE_DOEP1INTF_TF ( -- x addr ) 0 bit USBFS_DEVICE_DOEP1INTF ; \ USBFS_DEVICE_DOEP1INTF_TF, Transfer finished

\ USBFS_DEVICE_DOEP2INTF (read-write) Reset:0x00000000
: USBFS_DEVICE_DOEP2INTF_BTBSTP ( -- x addr ) 6 bit USBFS_DEVICE_DOEP2INTF ; \ USBFS_DEVICE_DOEP2INTF_BTBSTP, Back-to-back SETUP packets
: USBFS_DEVICE_DOEP2INTF_EPRXFOVR ( -- x addr ) 4 bit USBFS_DEVICE_DOEP2INTF ; \ USBFS_DEVICE_DOEP2INTF_EPRXFOVR, Endpoint Rx FIFO overrun
: USBFS_DEVICE_DOEP2INTF_STPF ( -- x addr ) 3 bit USBFS_DEVICE_DOEP2INTF ; \ USBFS_DEVICE_DOEP2INTF_STPF, Setup phase finished
: USBFS_DEVICE_DOEP2INTF_EPDIS ( -- x addr ) 1 bit USBFS_DEVICE_DOEP2INTF ; \ USBFS_DEVICE_DOEP2INTF_EPDIS, Endpoint disabled
: USBFS_DEVICE_DOEP2INTF_TF ( -- x addr ) 0 bit USBFS_DEVICE_DOEP2INTF ; \ USBFS_DEVICE_DOEP2INTF_TF, Transfer finished

\ USBFS_DEVICE_DOEP3INTF (read-write) Reset:0x00000000
: USBFS_DEVICE_DOEP3INTF_BTBSTP ( -- x addr ) 6 bit USBFS_DEVICE_DOEP3INTF ; \ USBFS_DEVICE_DOEP3INTF_BTBSTP, Back-to-back SETUP packets
: USBFS_DEVICE_DOEP3INTF_EPRXFOVR ( -- x addr ) 4 bit USBFS_DEVICE_DOEP3INTF ; \ USBFS_DEVICE_DOEP3INTF_EPRXFOVR, Endpoint Rx FIFO overrun
: USBFS_DEVICE_DOEP3INTF_STPF ( -- x addr ) 3 bit USBFS_DEVICE_DOEP3INTF ; \ USBFS_DEVICE_DOEP3INTF_STPF, Setup phase finished
: USBFS_DEVICE_DOEP3INTF_EPDIS ( -- x addr ) 1 bit USBFS_DEVICE_DOEP3INTF ; \ USBFS_DEVICE_DOEP3INTF_EPDIS, Endpoint disabled
: USBFS_DEVICE_DOEP3INTF_TF ( -- x addr ) 0 bit USBFS_DEVICE_DOEP3INTF ; \ USBFS_DEVICE_DOEP3INTF_TF, Transfer finished

\ USBFS_DEVICE_DIEP0LEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DIEP0LEN_PCNT ( %bb -- x addr ) 19 lshift USBFS_DEVICE_DIEP0LEN ; \ USBFS_DEVICE_DIEP0LEN_PCNT, Packet count
: USBFS_DEVICE_DIEP0LEN_TLEN ( %bbbbbbb -- x addr ) USBFS_DEVICE_DIEP0LEN ; \ USBFS_DEVICE_DIEP0LEN_TLEN, Transfer length

\ USBFS_DEVICE_DOEP0LEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DOEP0LEN_STPCNT ( %bb -- x addr ) 29 lshift USBFS_DEVICE_DOEP0LEN ; \ USBFS_DEVICE_DOEP0LEN_STPCNT, SETUP packet count
: USBFS_DEVICE_DOEP0LEN_PCNT ( -- x addr ) 19 bit USBFS_DEVICE_DOEP0LEN ; \ USBFS_DEVICE_DOEP0LEN_PCNT, Packet count
: USBFS_DEVICE_DOEP0LEN_TLEN ( %bbbbbbb -- x addr ) USBFS_DEVICE_DOEP0LEN ; \ USBFS_DEVICE_DOEP0LEN_TLEN, Transfer length

\ USBFS_DEVICE_DIEP1LEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DIEP1LEN_MCPF ( %bb -- x addr ) 29 lshift USBFS_DEVICE_DIEP1LEN ; \ USBFS_DEVICE_DIEP1LEN_MCPF, Multi packet count per frame
: USBFS_DEVICE_DIEP1LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_DEVICE_DIEP1LEN ; \ USBFS_DEVICE_DIEP1LEN_PCNT, Packet count
: USBFS_DEVICE_DIEP1LEN_TLEN x addr ) USBFS_DEVICE_DIEP1LEN ; \ USBFS_DEVICE_DIEP1LEN_TLEN, Transfer length

\ USBFS_DEVICE_DIEP2LEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DIEP2LEN_MCPF ( %bb -- x addr ) 29 lshift USBFS_DEVICE_DIEP2LEN ; \ USBFS_DEVICE_DIEP2LEN_MCPF, Multi packet count per frame
: USBFS_DEVICE_DIEP2LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_DEVICE_DIEP2LEN ; \ USBFS_DEVICE_DIEP2LEN_PCNT, Packet count
: USBFS_DEVICE_DIEP2LEN_TLEN x addr ) USBFS_DEVICE_DIEP2LEN ; \ USBFS_DEVICE_DIEP2LEN_TLEN, Transfer length

\ USBFS_DEVICE_DIEP3LEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DIEP3LEN_MCPF ( %bb -- x addr ) 29 lshift USBFS_DEVICE_DIEP3LEN ; \ USBFS_DEVICE_DIEP3LEN_MCPF, Multi packet count per frame
: USBFS_DEVICE_DIEP3LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_DEVICE_DIEP3LEN ; \ USBFS_DEVICE_DIEP3LEN_PCNT, Packet count
: USBFS_DEVICE_DIEP3LEN_TLEN x addr ) USBFS_DEVICE_DIEP3LEN ; \ USBFS_DEVICE_DIEP3LEN_TLEN, Transfer length

\ USBFS_DEVICE_DOEP1LEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DOEP1LEN_STPCNT_RXDPID ( %bb -- x addr ) 29 lshift USBFS_DEVICE_DOEP1LEN ; \ USBFS_DEVICE_DOEP1LEN_STPCNT_RXDPID, SETUP packet count/Received data PID
: USBFS_DEVICE_DOEP1LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_DEVICE_DOEP1LEN ; \ USBFS_DEVICE_DOEP1LEN_PCNT, Packet count
: USBFS_DEVICE_DOEP1LEN_TLEN x addr ) USBFS_DEVICE_DOEP1LEN ; \ USBFS_DEVICE_DOEP1LEN_TLEN, Transfer length

\ USBFS_DEVICE_DOEP2LEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DOEP2LEN_STPCNT_RXDPID ( %bb -- x addr ) 29 lshift USBFS_DEVICE_DOEP2LEN ; \ USBFS_DEVICE_DOEP2LEN_STPCNT_RXDPID, SETUP packet count/Received data PID
: USBFS_DEVICE_DOEP2LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_DEVICE_DOEP2LEN ; \ USBFS_DEVICE_DOEP2LEN_PCNT, Packet count
: USBFS_DEVICE_DOEP2LEN_TLEN x addr ) USBFS_DEVICE_DOEP2LEN ; \ USBFS_DEVICE_DOEP2LEN_TLEN, Transfer length

\ USBFS_DEVICE_DOEP3LEN (read-write) Reset:0x00000000
: USBFS_DEVICE_DOEP3LEN_STPCNT_RXDPID ( %bb -- x addr ) 29 lshift USBFS_DEVICE_DOEP3LEN ; \ USBFS_DEVICE_DOEP3LEN_STPCNT_RXDPID, SETUP packet count/Received data PID
: USBFS_DEVICE_DOEP3LEN_PCNT ( %bbbbbbbbbb -- x addr ) 19 lshift USBFS_DEVICE_DOEP3LEN ; \ USBFS_DEVICE_DOEP3LEN_PCNT, Packet count
: USBFS_DEVICE_DOEP3LEN_TLEN x addr ) USBFS_DEVICE_DOEP3LEN ; \ USBFS_DEVICE_DOEP3LEN_TLEN, Transfer length

\ USBFS_DEVICE_DIEP0TFSTAT (read-only) Reset:0x00000200
: USBFS_DEVICE_DIEP0TFSTAT_IEPTFS? ( --  x ) USBFS_DEVICE_DIEP0TFSTAT @ ; \ USBFS_DEVICE_DIEP0TFSTAT_IEPTFS, IN endpoint TxFIFO space  remaining

\ USBFS_DEVICE_DIEP1TFSTAT (read-only) Reset:0x00000200
: USBFS_DEVICE_DIEP1TFSTAT_IEPTFS? ( --  x ) USBFS_DEVICE_DIEP1TFSTAT @ ; \ USBFS_DEVICE_DIEP1TFSTAT_IEPTFS, IN endpoint TxFIFO space  remaining

\ USBFS_DEVICE_DIEP2TFSTAT (read-only) Reset:0x00000200
: USBFS_DEVICE_DIEP2TFSTAT_IEPTFS? ( --  x ) USBFS_DEVICE_DIEP2TFSTAT @ ; \ USBFS_DEVICE_DIEP2TFSTAT_IEPTFS, IN endpoint TxFIFO space  remaining

\ USBFS_DEVICE_DIEP3TFSTAT (read-only) Reset:0x00000200
: USBFS_DEVICE_DIEP3TFSTAT_IEPTFS? ( --  x ) USBFS_DEVICE_DIEP3TFSTAT @ ; \ USBFS_DEVICE_DIEP3TFSTAT_IEPTFS, IN endpoint TxFIFO space  remaining

\ USBFS_PWRCLK_PWRCLKCTL (read-write) Reset:0x00000000
: USBFS_PWRCLK_PWRCLKCTL_SUCLK ( -- x addr ) 0 bit USBFS_PWRCLK_PWRCLKCTL ; \ USBFS_PWRCLK_PWRCLKCTL_SUCLK, Stop the USB clock
: USBFS_PWRCLK_PWRCLKCTL_SHCLK ( -- x addr ) 1 bit USBFS_PWRCLK_PWRCLKCTL ; \ USBFS_PWRCLK_PWRCLKCTL_SHCLK, Stop HCLK

\ WWDGT_CTL (read-write) Reset:0x0000007F
: WWDGT_CTL_WDGTEN ( -- x addr ) 7 bit WWDGT_CTL ; \ WWDGT_CTL_WDGTEN, Activation bit
: WWDGT_CTL_CNT ( %bbbbbbb -- x addr ) WWDGT_CTL ; \ WWDGT_CTL_CNT, 7-bit counter

\ WWDGT_CFG (read-write) Reset:0x0000007F
: WWDGT_CFG_EWIE ( -- x addr ) 9 bit WWDGT_CFG ; \ WWDGT_CFG_EWIE, Early wakeup interrupt
: WWDGT_CFG_PSC ( %bb -- x addr ) 7 lshift WWDGT_CFG ; \ WWDGT_CFG_PSC, Prescaler
: WWDGT_CFG_WIN ( %bbbbbbb -- x addr ) WWDGT_CFG ; \ WWDGT_CFG_WIN, 7-bit window value

\ WWDGT_STAT (read-write) Reset:0x00000000
: WWDGT_STAT_EWIF ( -- x addr ) 0 bit WWDGT_STAT ; \ WWDGT_STAT_EWIF, Early wakeup interrupt  flag
