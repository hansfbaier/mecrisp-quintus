<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<!-- Peripheral Lister by Terry Porter "terry@tjporter.com.au" -->
<!-- <xsl:param name="parameters" select=" 'file:///parameters.txt' " /> -->


<xsl:variable name="fileA" select="document('template.xml')"/>
<xsl:output method="text"/>

<xsl:template match="/device">
<xsl:text>\ TEMPLATE FILE for </xsl:text>
<xsl:value-of select="name"/>
<xsl:text>
</xsl:text>
<xsl:text>\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch</xsl:text>
<xsl:text>
</xsl:text>
<xsl:text>\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input </xsl:text>
<xsl:text>
</xsl:text>
<xsl:text>\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence</xsl:text>
<xsl:text>
</xsl:text>
<xsl:text>\ Available forth template words as selected by config.xm </xsl:text>
<xsl:text>
</xsl:text>

<xsl:text>
compiletoflash
</xsl:text>

<xsl:text>: WRITEONLY ( -- ) ." WO" cr ;</xsl:text>
<xsl:text>
		
</xsl:text>

<xsl:for-each select="peripherals/peripheral">
<!-- <xsl:value-of select="name"></xsl:value-of> -->
<xsl:choose>
<xsl:when test=" name = $fileA/peripherals/name">

<xsl:variable name="device" select="name" />
<xsl:value-of select="baseAddress" /> constant <xsl:value-of select="$device" /> 
<xsl:text> \ </xsl:text>
<xsl:value-of select="description"/>
<xsl:text>
</xsl:text>

<!-- Register Constants Start -->
<xsl:for-each select="registers/register" >
<xsl:variable name="accesstype" select="access"/>
<xsl:value-of select="$device"/>
<xsl:text> </xsl:text>
<xsl:value-of select="addressOffset" />
<xsl:text> </xsl:text>
<xsl:text>+</xsl:text>
<xsl:text> </xsl:text>
<xsl:text>constant</xsl:text>
<xsl:text> </xsl:text>
<xsl:value-of select="$device"/><xsl:text>_</xsl:text><xsl:value-of select="name" />
<xsl:text> ( </xsl:text>
<xsl:value-of select="$accesstype"/><xsl:text> ) </xsl:text>
<xsl:text> \ </xsl:text>
<xsl:value-of select="description"/>
<xsl:text>
</xsl:text>
</xsl:for-each>
<!-- Register Constants Finish -->

<!-- Register Print Words Start -->
<xsl:text></xsl:text>
<xsl:for-each select="registers/register" >
<xsl:variable name="accesstype1" select="access"/>
<xsl:text>: </xsl:text>
<xsl:value-of select="$device"/><xsl:text>_</xsl:text><xsl:value-of select="name" /> 
<xsl:text>. cr </xsl:text>

<!-- Eliminate 'write-only' defaults  -->
<xsl:choose>
<xsl:when test="not ($accesstype1 = 'write-only') ">
<xsl:text></xsl:text>


<xsl:text>." </xsl:text>
<xsl:value-of select="$device"/><xsl:text>_</xsl:text><xsl:value-of select="name" />
<xsl:text>. </xsl:text>

<!-- read-write  -->
<xsl:choose>
<xsl:when test="($accesstype1 = 'read-write') ">
<xsl:text> RW </xsl:text>
</xsl:when>
</xsl:choose>
<!-- read-only  -->
<xsl:choose>
<xsl:when test="($accesstype1 = 'read-only') ">
<xsl:text> RO </xsl:text>
</xsl:when>
</xsl:choose>

<xsl:text> </xsl:text>
<xsl:text> $" </xsl:text>
<xsl:value-of select="$device"/><xsl:text>_</xsl:text><xsl:value-of select="name" />
<xsl:text> @ hex. </xsl:text>
<xsl:value-of select="$device"/><xsl:text>_</xsl:text><xsl:value-of select="name" />
<!-- Register Print Words Finish -->


<!-- Custom Register Print Words START -->
<xsl:choose>
<xsl:when test="$device = 'COMP' ">
<xsl:choose>
<!-- note COMP only has the COMP_CSR register -->
<xsl:when test="name = 'CSR' "><xsl:text> COMP_CSR.. </xsl:text></xsl:when>
</xsl:choose>
</xsl:when>
</xsl:choose>

<xsl:choose>
<xsl:when test="$device = 'GPIOA' ">
  <xsl:choose>
    <xsl:when test="name = 'MODER'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OTYPER' "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OSPEEDR'"><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'PUPDR'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'IDR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'ODR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'BSRR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'LCKR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRL'   "><xsl:text> 4bl. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRH'   "><xsl:text> 4bh. </xsl:text></xsl:when>
    <xsl:when test="name = 'BRR'    "><xsl:text>  16b. </xsl:text></xsl:when>
  </xsl:choose>
  </xsl:when>
</xsl:choose>

<xsl:choose>
<xsl:when test="$device = 'GPIOB' ">
  <xsl:choose>
    <xsl:when test="name = 'MODER'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OTYPER' "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OSPEEDR'"><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'PUPDR'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'IDR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'ODR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'BSRR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'LCKR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRL'   "><xsl:text> 4bl. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRH'   "><xsl:text> 4bh. </xsl:text></xsl:when>
    <xsl:when test="name = 'BRR'    "><xsl:text>  16b. </xsl:text></xsl:when>
  </xsl:choose>
  </xsl:when>
</xsl:choose>

<xsl:choose>
<xsl:when test="$device = 'GPIOC' ">
  <xsl:choose>
    <xsl:when test="name = 'MODER'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OTYPER' "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OSPEEDR'"><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'PUPDR'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'IDR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'ODR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'BSRR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'LCKR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRL'   "><xsl:text> 4bl. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRH'   "><xsl:text> 4bh. </xsl:text></xsl:when>
    <xsl:when test="name = 'BRR'    "><xsl:text>  16b. </xsl:text></xsl:when>
  </xsl:choose>
  </xsl:when>
</xsl:choose>

<xsl:choose>
<xsl:when test="$device = 'GPIOD' ">
  <xsl:choose>
    <xsl:when test="name = 'MODER'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OTYPER' "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OSPEEDR'"><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'PUPDR'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'IDR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'ODR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'BSRR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'LCKR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRL'   "><xsl:text> 4bl. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRH'   "><xsl:text> 4bh. </xsl:text></xsl:when>
    <xsl:when test="name = 'BRR'    "><xsl:text>  16b. </xsl:text></xsl:when>
  </xsl:choose>
  </xsl:when>
</xsl:choose>

<xsl:choose>
<xsl:when test="$device = 'GPIOF' ">
  <xsl:choose>
    <xsl:when test="name = 'MODER'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OTYPER' "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'OSPEEDR'"><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'PUPDR'  "><xsl:text> 2b. </xsl:text></xsl:when>
    <xsl:when test="name = 'IDR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'ODR'    "><xsl:text>  16b. </xsl:text></xsl:when>
    <xsl:when test="name = 'BSRR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'LCKR'   "><xsl:text> 1b. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRL'   "><xsl:text> 4bl. </xsl:text></xsl:when>
    <xsl:when test="name = 'AFRH'   "><xsl:text> 4bh. </xsl:text></xsl:when>
    <xsl:when test="name = 'BRR'    "><xsl:text>  16b. </xsl:text></xsl:when>
  </xsl:choose>
  </xsl:when>
</xsl:choose>


<xsl:choose>
<xsl:when test="$device = 'RCC' ">
<xsl:choose>
<xsl:when test="name = 'CR'       "><xsl:text> RCC_CR.. </xsl:text></xsl:when>
<xsl:when test="name = 'CFGR'     "><xsl:text> RCC_CFGR.. </xsl:text></xsl:when>
<xsl:when test="name = 'CIR'      "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'APB2RSTR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'APB1RSTR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'AHBENR'   "><xsl:text> RCC_AHBENR.. </xsl:text></xsl:when>
<xsl:when test="name = 'APB2ENR'  "><xsl:text> RCC_APB2ENR.. </xsl:text></xsl:when>
<xsl:when test="name = 'APB1ENR'  "><xsl:text> RCC_APB1ENR.. </xsl:text></xsl:when>
<xsl:when test="name = 'BDCR'     "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'CSR'      "><xsl:text> RCC_CSR.. </xsl:text></xsl:when>
<xsl:when test="name = 'AHBRSTR'  "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'CFGR2'    "><xsl:text> RCC_CFGR2.. </xsl:text></xsl:when>
<xsl:when test="name = 'CFGR3'    "><xsl:text> RCC_CFGR3.. </xsl:text></xsl:when>
<xsl:when test="name = 'CR2'      "><xsl:text> RCC_CR2.. </xsl:text></xsl:when>
</xsl:choose>
</xsl:when>
</xsl:choose>

<xsl:choose>
<xsl:when test="$device = 'TIM3' ">
<xsl:choose>
<xsl:when test="name = 'CR1'	       "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'CR2'	       "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'SMCR'	       "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'DIER'	       "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'SR'	       "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'EGR'	       "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'CCMR1_Output'  "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'CCMR1_Input'   "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'CCMR2_Output'  "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'CCMR2_Input'   "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'CCER'	       "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'CNT'	       "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'PSC'	       "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'ARR'	       "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'CCR1'	       "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'CCR2'	       "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'CCR3'	       "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'CCR4'	       "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'DCR'	       "><xsl:text>  16b. </xsl:text></xsl:when>
<xsl:when test="name = 'DMAR'	       "><xsl:text>  16b. </xsl:text></xsl:when>
</xsl:choose>
</xsl:when>
</xsl:choose>

<xsl:choose>
<xsl:when test="$device = 'TSC' ">
<xsl:choose>
<xsl:when test="name = 'CR' "><xsl:text> TSC_CR.. </xsl:text></xsl:when>
<xsl:when test="name = 'IER' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'ICR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'ISR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOHCR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOASCR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOSCR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOCCR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOGCSR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOG1CR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOG2CR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOG3CR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOG4CR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOG5CR' "><xsl:text> 1b. </xsl:text></xsl:when>
<xsl:when test="name = 'IOG6CR' "><xsl:text> 1b. </xsl:text></xsl:when>
</xsl:choose>
</xsl:when>
</xsl:choose>



<!-- Custom Register Print Words Finish -->

<!-- Unspecified Register Print Words Fall Through -->
<xsl:choose> <!-- Except for these registers listed above -->
<xsl:when test="not 

(
$device = 'COMP' or
$device = 'GPIOA' or
$device = 'GPIOB' or
$device = 'GPIOC' or
$device = 'GPIOD' or
$device = 'GPIOF' or
$device = 'RCC' or
$device = 'TIM3' or
$device = 'TSC'
 )
  
"><xsl:text> 1b. </xsl:text></xsl:when>
</xsl:choose>

<!-- Register print Words Finish--> 

<!-- end of sub-registers register select code -->
<xsl:text>;
</xsl:text>


<!-- end of eliminate write-only register printouts -->
</xsl:when>
</xsl:choose>
<xsl:text></xsl:text>

<xsl:choose>
   <xsl:when test=" ($accesstype1 = 'write-only') ">
   <xsl:text>." </xsl:text>	    
   <xsl:value-of select="$device"/><xsl:text>_</xsl:text><xsl:value-of select="name" />
   <xsl:text> " WRITEONLY ; </xsl:text>
<xsl:text>
</xsl:text>
</xsl:when>
</xsl:choose>
</xsl:for-each>


<!-- Register Prints -->
<xsl:text>: </xsl:text>
<xsl:value-of select="$device"/><xsl:text>.
</xsl:text>
<xsl:for-each select="registers/register" >
<xsl:value-of select="$device"/><xsl:text>_</xsl:text><xsl:value-of select="name" />
<xsl:text>.
</xsl:text>
</xsl:for-each>
<xsl:text>;

</xsl:text>

</xsl:when>
</xsl:choose>
</xsl:for-each>

<xsl:text>
compiletoram
</xsl:text>

</xsl:template>
</xsl:stylesheet>
