
reset
set terminal png enhanced size 1000, 800

set xlabel "Spannung [mV]"
set ylabel "Strom [mA]"
set key left

set xrange [-3500:3500]

avg = 256
vcc = 3294

# 1  2    3    4    5
# i PA6H PA6L PA0H PA0L

set output "1N4148-Grob.png"

plot "1N4148.dat" u ( ($1-($5 / avg)) * vcc/4096):(( ($5 / avg)       * vcc/4096) /   675) w lp title "675 Ohm Low", \
     "1N4148.dat" u ( ($1-($4 / avg)) * vcc/4096):(((($4 / avg)-4096) * vcc/4096) /   675) w lp title "675 Ohm High"

set output "1N4148-Fein.png"

plot "1N4148.dat" u ( ($1-($3 / avg)) * vcc/4096):(( ($3 / avg)       * vcc/4096) / 14830) w lp title "14830 Ohm Low", \
     "1N4148.dat" u ( ($1-($2 / avg)) * vcc/4096):(((($2 / avg)-4096) * vcc/4096) / 14830) w lp title "14830 Ohm High"

set output "1N4148-Fein-Sperrbereich.png"

set ylabel "Strom [uA]"
plot "1N4148.dat" u ( ($1-($2 / avg)) * vcc/4096):(((($2 / avg)-4096) * vcc/4096) / 14830  * 1000) w lp title "14830 Ohm High"
