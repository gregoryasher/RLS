EESchema Schematic File Version 2
LIBS:RLS-rescue
LIBS:power
LIBS:device
LIBS:transistors
LIBS:conn
LIBS:linear
LIBS:regul
LIBS:74xx
LIBS:cmos4000
LIBS:adc-dac
LIBS:memory
LIBS:xilinx
LIBS:microcontrollers
LIBS:dsp
LIBS:microchip
LIBS:analog_switches
LIBS:motorola
LIBS:texas
LIBS:intel
LIBS:audio
LIBS:interface
LIBS:digital-audio
LIBS:philips
LIBS:display
LIBS:cypress
LIBS:siliconi
LIBS:opto
LIBS:atmel
LIBS:contrib
LIBS:valves
LIBS:arduino_shield
LIBS:RA30421051
LIBS:RB496EATR
LIBS:Daughterboard_Connector
LIBS:RLS-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 5 7
Title "Remote Lab System"
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L LT1963 U11
U 1 1 5953022A
P 5200 2200
AR Path="/5952FCB2/5953022A" Ref="U11"  Part="1" 
AR Path="/59595696/5953022A" Ref="U11"  Part="1" 
F 0 "U11" H 5250 2700 60  0000 C CNN
F 1 "LT1963" H 5250 2800 60  0000 C CNN
F 2 "TO_SOT_Packages_THT:TO-220-5_Pentawatt_Multiwatt-5_Vertical_StaggeredType1" H 5250 2700 60  0001 C CNN
F 3 "" H 5250 2700 60  0001 C CNN
	1    5200 2200
	-1   0    0    -1  
$EndComp
$Comp
L LT1963 U10
U 1 1 59530279
P 5200 4850
AR Path="/5952FCB2/59530279" Ref="U10"  Part="1" 
AR Path="/59595696/59530279" Ref="U10"  Part="1" 
F 0 "U10" H 5250 5350 60  0000 C CNN
F 1 "LT1963" H 5250 5450 60  0000 C CNN
F 2 "TO_SOT_Packages_THT:TO-220-5_Pentawatt_Multiwatt-5_Vertical_StaggeredType1" H 5250 5350 60  0001 C CNN
F 3 "" H 5250 5350 60  0001 C CNN
	1    5200 4850
	-1   0    0    -1  
$EndComp
$Comp
L AD5293-RESCUE-RLS U8
U 1 1 595A3981
P 3100 5300
AR Path="/5952FCB2/595A3981" Ref="U8"  Part="1" 
AR Path="/59595696/595A3981" Ref="U8"  Part="1" 
F 0 "U8" H 2550 5700 50  0000 L CNN
F 1 "AD5293" H 3400 5700 50  0000 L CNN
F 2 "SMD_Packages:SSOP-14" H 3100 5300 50  0001 C CNN
F 3 "" H 3100 5300 50  0001 C CNN
	1    3100 5300
	1    0    0    -1  
$EndComp
$Comp
L AD5293-RESCUE-RLS U9
U 1 1 595A3988
P 3100 2650
AR Path="/5952FCB2/595A3988" Ref="U9"  Part="1" 
AR Path="/59595696/595A3988" Ref="U9"  Part="1" 
F 0 "U9" H 2550 3050 50  0000 L CNN
F 1 "AD5293" H 3400 3050 50  0000 L CNN
F 2 "SMD_Packages:SSOP-14" H 3100 2650 50  0001 C CNN
F 3 "" H 3100 2650 50  0001 C CNN
	1    3100 2650
	1    0    0    -1  
$EndComp
$Comp
L CP1 C33
U 1 1 595A398F
P 2350 3150
AR Path="/5952FCB2/595A398F" Ref="C33"  Part="1" 
AR Path="/59595696/595A398F" Ref="C33"  Part="1" 
F 0 "C33" H 2375 3250 50  0000 L CNN
F 1 "1uF" H 2375 3050 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 2350 3150 50  0001 C CNN
F 3 "" H 2350 3150 50  0001 C CNN
	1    2350 3150
	1    0    0    -1  
$EndComp
$Comp
L CP1 C34
U 1 1 595A3996
P 2350 5800
AR Path="/5952FCB2/595A3996" Ref="C34"  Part="1" 
AR Path="/59595696/595A3996" Ref="C34"  Part="1" 
F 0 "C34" H 2375 5900 50  0000 L CNN
F 1 "1uF" H 2375 5700 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 2350 5800 50  0001 C CNN
F 3 "" H 2350 5800 50  0001 C CNN
	1    2350 5800
	1    0    0    -1  
$EndComp
$Comp
L CP1 C21
U 1 1 595A399D
P 3450 4350
AR Path="/5952FCB2/595A399D" Ref="C21"  Part="1" 
AR Path="/59595696/595A399D" Ref="C21"  Part="1" 
F 0 "C21" H 3475 4450 50  0000 L CNN
F 1 "10uF" H 3475 4250 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 3450 4350 50  0001 C CNN
F 3 "" H 3450 4350 50  0001 C CNN
	1    3450 4350
	0    -1   -1   0   
$EndComp
$Comp
L C C22
U 1 1 595A39A4
P 3450 4650
AR Path="/5952FCB2/595A39A4" Ref="C22"  Part="1" 
AR Path="/59595696/595A39A4" Ref="C22"  Part="1" 
F 0 "C22" H 3475 4750 50  0000 L CNN
F 1 "0.1uF" H 3475 4550 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 3488 4500 50  0001 C CNN
F 3 "" H 3450 4650 50  0001 C CNN
	1    3450 4650
	0    -1   -1   0   
$EndComp
$Comp
L R R22
U 1 1 595A39AB
P 1900 4950
AR Path="/5952FCB2/595A39AB" Ref="R22"  Part="1" 
AR Path="/59595696/595A39AB" Ref="R22"  Part="1" 
F 0 "R22" V 1980 4950 50  0000 C CNN
F 1 "4.7K" V 1900 4950 50  0000 C CNN
F 2 "Resistors_SMD:R_0805_HandSoldering" V 1830 4950 50  0001 C CNN
F 3 "" H 1900 4950 50  0001 C CNN
	1    1900 4950
	-1   0    0    1   
$EndComp
Wire Wire Line
	2400 5600 2350 5600
Wire Wire Line
	2350 5600 2350 5650
Wire Wire Line
	2400 2950 2350 2950
Wire Wire Line
	2350 2950 2350 3000
$Comp
L CP1 C25
U 1 1 595A39B6
P 2750 4350
AR Path="/5952FCB2/595A39B6" Ref="C25"  Part="1" 
AR Path="/59595696/595A39B6" Ref="C25"  Part="1" 
F 0 "C25" H 2775 4450 50  0000 L CNN
F 1 "10uF" H 2775 4250 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 2750 4350 50  0001 C CNN
F 3 "" H 2750 4350 50  0001 C CNN
	1    2750 4350
	0    1    -1   0   
$EndComp
$Comp
L C C26
U 1 1 595A39BD
P 2750 4650
AR Path="/5952FCB2/595A39BD" Ref="C26"  Part="1" 
AR Path="/59595696/595A39BD" Ref="C26"  Part="1" 
F 0 "C26" H 2775 4750 50  0000 L CNN
F 1 "0.1uF" H 2775 4550 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 2788 4500 50  0001 C CNN
F 3 "" H 2750 4650 50  0001 C CNN
	1    2750 4650
	0    1    -1   0   
$EndComp
Wire Wire Line
	3000 4250 3000 4800
Wire Wire Line
	3000 4650 2900 4650
Wire Wire Line
	2900 4350 3000 4350
Connection ~ 3000 4650
Wire Wire Line
	2600 4350 2500 4350
Wire Wire Line
	2500 4350 2500 4650
Wire Wire Line
	2500 4650 2600 4650
Wire Wire Line
	3600 4350 3700 4350
Wire Wire Line
	3700 4350 3700 4650
Wire Wire Line
	3700 4650 3600 4650
Wire Wire Line
	3300 4350 3200 4350
Wire Wire Line
	3300 4650 3200 4650
Connection ~ 3200 4650
Text GLabel 3200 4250 1    60   Input ~ 0
+15V
Text GLabel 3000 4250 1    60   Input ~ 0
+5V
Text GLabel 3750 4500 2    60   Input ~ 0
AGND
Text GLabel 2450 4500 0    60   Input ~ 0
AGND
Wire Wire Line
	2450 4500 2500 4500
Connection ~ 2500 4500
Wire Wire Line
	3750 4500 3700 4500
Connection ~ 3700 4500
Connection ~ 3000 4350
Connection ~ 3200 4350
$Comp
L CP1 C27
U 1 1 595A39DC
P 3450 1650
AR Path="/5952FCB2/595A39DC" Ref="C27"  Part="1" 
AR Path="/59595696/595A39DC" Ref="C27"  Part="1" 
F 0 "C27" H 3475 1750 50  0000 L CNN
F 1 "10uF" H 3475 1550 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 3450 1650 50  0001 C CNN
F 3 "" H 3450 1650 50  0001 C CNN
	1    3450 1650
	0    -1   -1   0   
$EndComp
$Comp
L C C28
U 1 1 595A39E3
P 3450 1950
AR Path="/5952FCB2/595A39E3" Ref="C28"  Part="1" 
AR Path="/59595696/595A39E3" Ref="C28"  Part="1" 
F 0 "C28" H 3475 2050 50  0000 L CNN
F 1 "0.1uF" H 3475 1850 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 3488 1800 50  0001 C CNN
F 3 "" H 3450 1950 50  0001 C CNN
	1    3450 1950
	0    -1   -1   0   
$EndComp
$Comp
L C C32
U 1 1 595A39F1
P 2750 1950
AR Path="/5952FCB2/595A39F1" Ref="C32"  Part="1" 
AR Path="/59595696/595A39F1" Ref="C32"  Part="1" 
F 0 "C32" H 2775 2050 50  0000 L CNN
F 1 "0.1uF" H 2775 1850 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 2788 1800 50  0001 C CNN
F 3 "" H 2750 1950 50  0001 C CNN
	1    2750 1950
	0    1    -1   0   
$EndComp
Wire Wire Line
	3000 1550 3000 2150
Wire Wire Line
	3000 1950 2900 1950
Wire Wire Line
	2900 1650 3000 1650
Connection ~ 3000 1950
Wire Wire Line
	2600 1650 2500 1650
Wire Wire Line
	2500 1650 2500 1950
Wire Wire Line
	2500 1950 2600 1950
Wire Wire Line
	3600 1650 3700 1650
Wire Wire Line
	3700 1650 3700 1950
Wire Wire Line
	3700 1950 3600 1950
Wire Wire Line
	3300 1650 3200 1650
Wire Wire Line
	3200 1550 3200 2150
Wire Wire Line
	3200 1950 3300 1950
Connection ~ 3200 1950
Text GLabel 3200 1550 1    60   Input ~ 0
+15V
Text GLabel 3000 1550 1    60   Input ~ 0
+5V
Text GLabel 3750 1800 2    60   Input ~ 0
AGND
Text GLabel 2450 1800 0    60   Input ~ 0
AGND
Wire Wire Line
	2450 1800 2500 1800
Connection ~ 2500 1800
Wire Wire Line
	3750 1800 3700 1800
Connection ~ 3700 1800
Connection ~ 3000 1650
Connection ~ 3200 1650
Text GLabel 3000 5800 3    60   Input ~ 0
AGND
Text GLabel 2950 3250 0    60   Input ~ 0
AGND
$Comp
L CP1 C29
U 1 1 595A3A12
P 3450 3600
AR Path="/5952FCB2/595A3A12" Ref="C29"  Part="1" 
AR Path="/59595696/595A3A12" Ref="C29"  Part="1" 
F 0 "C29" H 3475 3700 50  0000 L CNN
F 1 "10uF" H 3475 3500 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 3450 3600 50  0001 C CNN
F 3 "" H 3450 3600 50  0001 C CNN
	1    3450 3600
	0    1    1    0   
$EndComp
$Comp
L C C30
U 1 1 595A3A19
P 3450 3300
AR Path="/5952FCB2/595A3A19" Ref="C30"  Part="1" 
AR Path="/59595696/595A3A19" Ref="C30"  Part="1" 
F 0 "C30" H 3475 3400 50  0000 L CNN
F 1 "0.1uF" H 3450 3200 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 3488 3150 50  0001 C CNN
F 3 "" H 3450 3300 50  0001 C CNN
	1    3450 3300
	0    -1   1    0   
$EndComp
Wire Wire Line
	3700 3600 3600 3600
Wire Wire Line
	3700 3300 3700 3600
Wire Wire Line
	3700 3300 3600 3300
Wire Wire Line
	3100 3600 3300 3600
Wire Wire Line
	3300 3300 3200 3300
Connection ~ 3200 3300
Text GLabel 3750 3450 2    60   Input ~ 0
AGND
Wire Wire Line
	3750 3450 3700 3450
Connection ~ 3700 3450
Connection ~ 3200 3600
Wire Wire Line
	3200 3150 3200 3600
Text GLabel 3100 3600 0    60   Input ~ 0
-15V
$Comp
L CP1 C23
U 1 1 595A3A2C
P 3450 6300
AR Path="/5952FCB2/595A3A2C" Ref="C23"  Part="1" 
AR Path="/59595696/595A3A2C" Ref="C23"  Part="1" 
F 0 "C23" H 3475 6400 50  0000 L CNN
F 1 "10uF" H 3475 6200 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 3450 6300 50  0001 C CNN
F 3 "" H 3450 6300 50  0001 C CNN
	1    3450 6300
	0    1    1    0   
$EndComp
$Comp
L C C24
U 1 1 595A3A33
P 3450 6000
AR Path="/5952FCB2/595A3A33" Ref="C24"  Part="1" 
AR Path="/59595696/595A3A33" Ref="C24"  Part="1" 
F 0 "C24" H 3475 6100 50  0000 L CNN
F 1 "0.1uF" H 3450 5900 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 3488 5850 50  0001 C CNN
F 3 "" H 3450 6000 50  0001 C CNN
	1    3450 6000
	0    -1   1    0   
$EndComp
Wire Wire Line
	3700 6300 3600 6300
Wire Wire Line
	3700 6000 3700 6300
Wire Wire Line
	3700 6000 3600 6000
Wire Wire Line
	3100 6300 3300 6300
Wire Wire Line
	3300 6000 3200 6000
Connection ~ 3200 6000
Text GLabel 3750 6150 2    60   Input ~ 0
AGND
Wire Wire Line
	3750 6150 3700 6150
Connection ~ 3700 6150
Connection ~ 3200 6300
Text GLabel 3100 6300 0    60   Input ~ 0
-15V
Wire Wire Line
	2400 5200 1650 5200
Wire Wire Line
	1650 5200 1650 2550
Wire Wire Line
	1650 2550 2400 2550
Wire Wire Line
	2400 2650 1750 2650
Wire Wire Line
	1750 2650 1750 5300
Wire Wire Line
	1750 5300 2400 5300
NoConn ~ 2400 5400
NoConn ~ 2400 2750
Text GLabel 2300 2850 0    60   Input ~ 0
+5V
Wire Wire Line
	2300 2850 2400 2850
Text GLabel 2300 5500 0    60   Input ~ 0
+5V
Wire Wire Line
	2300 5500 2400 5500
Text GLabel 2350 5000 0    60   Input ~ 0
MOSI
Wire Wire Line
	2350 5000 2400 5000
Wire Wire Line
	1900 5100 2400 5100
Text GLabel 1900 4600 1    60   Input ~ 0
+5V
Wire Wire Line
	1900 4600 1900 4800
Wire Wire Line
	2000 5100 2000 2350
Wire Wire Line
	2000 2350 2400 2350
Connection ~ 2000 5100
NoConn ~ 2400 2450
Text GLabel 1750 5300 0    60   Input ~ 0
P_POT_CE
Text GLabel 1650 2550 0    60   Input ~ 0
SCLK
Text GLabel 2350 3300 3    60   Input ~ 0
AGND
Text GLabel 2350 5950 3    60   Input ~ 0
AGND
$Comp
L CP1 C31
U 1 1 595A39EA
P 2750 1650
AR Path="/5952FCB2/595A39EA" Ref="C31"  Part="1" 
AR Path="/59595696/595A39EA" Ref="C31"  Part="1" 
F 0 "C31" H 2775 1750 50  0000 L CNN
F 1 "10uF" H 2775 1550 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 2750 1650 50  0001 C CNN
F 3 "" H 2750 1650 50  0001 C CNN
	1    2750 1650
	0    1    -1   0   
$EndComp
Wire Wire Line
	4950 2650 4950 2600
Wire Wire Line
	5050 2850 5050 2600
$Comp
L R R23
U 1 1 595A712D
P 4600 3100
AR Path="/5952FCB2/595A712D" Ref="R23"  Part="1" 
AR Path="/59595696/595A712D" Ref="R23"  Part="1" 
F 0 "R23" V 4680 3100 50  0000 C CNN
F 1 "1.78K" V 4600 3100 47  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 4530 3100 50  0001 C CNN
F 3 "" H 4600 3100 50  0001 C CNN
	1    4600 3100
	-1   0    0    -1  
$EndComp
$Comp
L CP1 C37
U 1 1 595A7134
P 4900 3100
AR Path="/5952FCB2/595A7134" Ref="C37"  Part="1" 
AR Path="/59595696/595A7134" Ref="C37"  Part="1" 
F 0 "C37" H 4925 3200 50  0000 L CNN
F 1 "10uF" H 4925 3000 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 4900 3100 50  0001 C CNN
F 3 "" H 4900 3100 50  0001 C CNN
	1    4900 3100
	-1   0    0    -1  
$EndComp
$Comp
L CP1 C38
U 1 1 595A713B
P 5400 3100
AR Path="/5952FCB2/595A713B" Ref="C38"  Part="1" 
AR Path="/59595696/595A713B" Ref="C38"  Part="1" 
F 0 "C38" H 5425 3200 50  0000 L CNN
F 1 "10uF" H 5425 3000 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 5400 3100 50  0001 C CNN
F 3 "" H 5400 3100 50  0001 C CNN
	1    5400 3100
	1    0    0    -1  
$EndComp
Wire Wire Line
	4900 2950 4900 2850
Connection ~ 4900 2850
Wire Wire Line
	4600 3250 4600 3400
Wire Wire Line
	4600 3400 5400 3400
Wire Wire Line
	5250 2900 5250 2600
Wire Wire Line
	4900 3250 4900 3500
Connection ~ 4900 3400
Wire Wire Line
	5350 2600 5350 2700
Wire Wire Line
	5350 2700 5450 2700
Text GLabel 5450 2700 2    60   Input ~ 0
+V1_SHDN
Text GLabel 4900 3500 3    60   Input ~ 0
AGND
Text GLabel 5600 2900 2    60   Input ~ 0
+15V
Text GLabel 4350 2500 1    60   Input ~ 0
+V1
Wire Wire Line
	3800 2650 4950 2650
Wire Wire Line
	3800 2850 5050 2850
Wire Wire Line
	5400 2950 5400 2900
Wire Wire Line
	5250 2900 5600 2900
Connection ~ 5400 2900
Wire Wire Line
	5150 2600 5150 3400
Connection ~ 5150 3400
Wire Wire Line
	4600 2950 4600 2650
Connection ~ 4600 2650
Wire Wire Line
	5400 3400 5400 3250
Wire Wire Line
	4350 2500 4350 2850
Connection ~ 4350 2850
Wire Wire Line
	4950 5300 4950 5250
Wire Wire Line
	5050 5500 5050 5250
$Comp
L R R24
U 1 1 5958D2DA
P 4600 5750
AR Path="/5952FCB2/5958D2DA" Ref="R24"  Part="1" 
AR Path="/59595696/5958D2DA" Ref="R24"  Part="1" 
F 0 "R24" V 4680 5750 50  0000 C CNN
F 1 "1.78K" V 4600 5750 47  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 4530 5750 50  0001 C CNN
F 3 "" H 4600 5750 50  0001 C CNN
	1    4600 5750
	-1   0    0    -1  
$EndComp
$Comp
L CP1 C35
U 1 1 5958D2E1
P 4900 5750
AR Path="/5952FCB2/5958D2E1" Ref="C35"  Part="1" 
AR Path="/59595696/5958D2E1" Ref="C35"  Part="1" 
F 0 "C35" H 4925 5850 50  0000 L CNN
F 1 "10uF" H 4925 5650 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 4900 5750 50  0001 C CNN
F 3 "" H 4900 5750 50  0001 C CNN
	1    4900 5750
	-1   0    0    -1  
$EndComp
$Comp
L CP1 C36
U 1 1 5958D2E8
P 5400 5750
AR Path="/5952FCB2/5958D2E8" Ref="C36"  Part="1" 
AR Path="/59595696/5958D2E8" Ref="C36"  Part="1" 
F 0 "C36" H 5425 5850 50  0000 L CNN
F 1 "10uF" H 5425 5650 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 5400 5750 50  0001 C CNN
F 3 "" H 5400 5750 50  0001 C CNN
	1    5400 5750
	1    0    0    -1  
$EndComp
Wire Wire Line
	4900 5600 4900 5500
Connection ~ 4900 5500
Wire Wire Line
	4600 5900 4600 6050
Wire Wire Line
	4600 6050 5400 6050
Wire Wire Line
	5250 5550 5250 5250
Wire Wire Line
	4900 5900 4900 6150
Connection ~ 4900 6050
Wire Wire Line
	5350 5250 5350 5350
Wire Wire Line
	5350 5350 5450 5350
Text GLabel 5450 5350 2    60   Input ~ 0
+V2_SHDN
Text GLabel 4900 6150 3    60   Input ~ 0
AGND
Text GLabel 5600 5550 2    60   Input ~ 0
+15V
Text GLabel 4350 5150 1    60   Input ~ 0
+V2
Wire Wire Line
	3800 5300 4950 5300
Wire Wire Line
	3800 5500 5050 5500
Wire Wire Line
	5400 5600 5400 5550
Wire Wire Line
	5250 5550 5600 5550
Connection ~ 5400 5550
Wire Wire Line
	5150 5250 5150 6050
Connection ~ 5150 6050
Wire Wire Line
	4600 5600 4600 5300
Connection ~ 4600 5300
Wire Wire Line
	5400 6050 5400 5900
Wire Wire Line
	4350 5150 4350 5500
Connection ~ 4350 5500
NoConn ~ 3800 5100
NoConn ~ 3800 2450
Wire Wire Line
	3200 4250 3200 4800
Wire Wire Line
	3200 5800 3200 6300
Wire Wire Line
	3000 3150 3000 3250
Wire Wire Line
	3000 3250 2950 3250
Text Label 4650 5300 0    40   ~ 0
+V2_ADJ
Text Label 4650 2650 0    40   ~ 0
+V1_ADJ
Text Label 2350 3000 2    40   ~ 0
+V1_EX_C
Text Label 2350 5650 2    40   ~ 0
+V2_EX_C
Text Label 2000 4200 1    40   ~ 0
+SDO_SDI
$EndSCHEMATC
