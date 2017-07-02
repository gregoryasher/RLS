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
LIBS:RLS-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 5 5
Title ""
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
P 6700 2300
F 0 "U11" H 6750 2800 60  0000 C CNN
F 1 "LT1963" H 6750 2900 60  0000 C CNN
F 2 "" H 6750 2800 60  0001 C CNN
F 3 "" H 6750 2800 60  0001 C CNN
	1    6700 2300
	-1   0    0    -1  
$EndComp
$Comp
L LT1963 U10
U 1 1 59530279
P 5000 4850
F 0 "U10" H 5050 5350 60  0000 C CNN
F 1 "LT1963" H 5050 5450 60  0000 C CNN
F 2 "" H 5050 5350 60  0001 C CNN
F 3 "" H 5050 5350 60  0001 C CNN
	1    5000 4850
	1    0    0    -1  
$EndComp
$Comp
L AD5293-RESCUE-RLS U8
U 1 1 595A3981
P 3100 5300
F 0 "U8" H 2550 5700 50  0000 L CNN
F 1 "AD5293" H 3400 5700 50  0000 L CNN
F 2 "" H 3100 5300 50  0001 C CNN
F 3 "" H 3100 5300 50  0001 C CNN
	1    3100 5300
	1    0    0    -1  
$EndComp
$Comp
L AD5293-RESCUE-RLS U9
U 1 1 595A3988
P 3100 2650
F 0 "U9" H 2550 3050 50  0000 L CNN
F 1 "AD5293" H 3400 3050 50  0000 L CNN
F 2 "" H 3100 2650 50  0001 C CNN
F 3 "" H 3100 2650 50  0001 C CNN
	1    3100 2650
	1    0    0    -1  
$EndComp
$Comp
L CP1 C33
U 1 1 595A398F
P 2350 3150
F 0 "C33" H 2375 3250 50  0000 L CNN
F 1 "1uF" H 2375 3050 50  0000 L CNN
F 2 "" H 2350 3150 50  0001 C CNN
F 3 "" H 2350 3150 50  0001 C CNN
	1    2350 3150
	1    0    0    -1  
$EndComp
$Comp
L CP1 C35
U 1 1 595A3996
P 2350 5800
F 0 "C35" H 2375 5900 50  0000 L CNN
F 1 "1uF" H 2375 5700 50  0000 L CNN
F 2 "" H 2350 5800 50  0001 C CNN
F 3 "" H 2350 5800 50  0001 C CNN
	1    2350 5800
	1    0    0    -1  
$EndComp
$Comp
L CP1 C21
U 1 1 595A399D
P 3450 4350
F 0 "C21" H 3475 4450 50  0000 L CNN
F 1 "10uF" H 3475 4250 50  0000 L CNN
F 2 "" H 3450 4350 50  0001 C CNN
F 3 "" H 3450 4350 50  0001 C CNN
	1    3450 4350
	0    -1   -1   0   
$EndComp
$Comp
L C C22
U 1 1 595A39A4
P 3450 4650
F 0 "C22" H 3475 4750 50  0000 L CNN
F 1 "0.1uF" H 3475 4550 50  0000 L CNN
F 2 "" H 3488 4500 50  0001 C CNN
F 3 "" H 3450 4650 50  0001 C CNN
	1    3450 4650
	0    -1   -1   0   
$EndComp
$Comp
L R R?
U 1 1 595A39AB
P 1900 4950
F 0 "R?" V 1980 4950 50  0000 C CNN
F 1 "4.7K" V 1900 4950 50  0000 C CNN
F 2 "" V 1830 4950 50  0001 C CNN
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
F 0 "C25" H 2775 4450 50  0000 L CNN
F 1 "10uF" H 2775 4250 50  0000 L CNN
F 2 "" H 2750 4350 50  0001 C CNN
F 3 "" H 2750 4350 50  0001 C CNN
	1    2750 4350
	0    1    -1   0   
$EndComp
$Comp
L C C26
U 1 1 595A39BD
P 2750 4650
F 0 "C26" H 2775 4750 50  0000 L CNN
F 1 "0.1uF" H 2775 4550 50  0000 L CNN
F 2 "" H 2788 4500 50  0001 C CNN
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
	3200 4250 3200 4800
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
F 0 "C27" H 3475 1750 50  0000 L CNN
F 1 "10uF" H 3475 1550 50  0000 L CNN
F 2 "" H 3450 1650 50  0001 C CNN
F 3 "" H 3450 1650 50  0001 C CNN
	1    3450 1650
	0    -1   -1   0   
$EndComp
$Comp
L C C28
U 1 1 595A39E3
P 3450 1950
F 0 "C28" H 3475 2050 50  0000 L CNN
F 1 "0.1uF" H 3475 1850 50  0000 L CNN
F 2 "" H 3488 1800 50  0001 C CNN
F 3 "" H 3450 1950 50  0001 C CNN
	1    3450 1950
	0    -1   -1   0   
$EndComp
$Comp
L C C32
U 1 1 595A39F1
P 2750 1950
F 0 "C32" H 2775 2050 50  0000 L CNN
F 1 "0.1uF" H 2775 1850 50  0000 L CNN
F 2 "" H 2788 1800 50  0001 C CNN
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
Text GLabel 3000 3150 3    60   Input ~ 0
AGND
$Comp
L CP1 C29
U 1 1 595A3A12
P 3450 3600
F 0 "C29" H 3475 3700 50  0000 L CNN
F 1 "10uF" H 3475 3500 50  0000 L CNN
F 2 "" H 3450 3600 50  0001 C CNN
F 3 "" H 3450 3600 50  0001 C CNN
	1    3450 3600
	0    1    1    0   
$EndComp
$Comp
L C C30
U 1 1 595A3A19
P 3450 3300
F 0 "C30" H 3475 3400 50  0000 L CNN
F 1 "0.1uF" H 3450 3200 50  0000 L CNN
F 2 "" H 3488 3150 50  0001 C CNN
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
-15v
$Comp
L CP1 C23
U 1 1 595A3A2C
P 3450 6300
F 0 "C23" H 3475 6400 50  0000 L CNN
F 1 "10uF" H 3475 6200 50  0000 L CNN
F 2 "" H 3450 6300 50  0001 C CNN
F 3 "" H 3450 6300 50  0001 C CNN
	1    3450 6300
	0    1    1    0   
$EndComp
$Comp
L C C24
U 1 1 595A3A33
P 3450 6000
F 0 "C24" H 3475 6100 50  0000 L CNN
F 1 "0.1uF" H 3450 5900 50  0000 L CNN
F 2 "" H 3488 5850 50  0001 C CNN
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
Wire Wire Line
	3200 5800 3200 6300
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
F 0 "C31" H 2775 1750 50  0000 L CNN
F 1 "10uF" H 2775 1550 50  0000 L CNN
F 2 "" H 2750 1650 50  0001 C CNN
F 3 "" H 2750 1650 50  0001 C CNN
	1    2750 1650
	0    1    -1   0   
$EndComp
Wire Wire Line
	6450 2850 6450 2800
Wire Wire Line
	6550 3050 6550 2800
$Comp
L R R?
U 1 1 595A712D
P 6100 3300
F 0 "R?" V 6180 3300 50  0000 C CNN
F 1 "1K" V 6100 3300 50  0000 C CNN
F 2 "" V 6030 3300 50  0001 C CNN
F 3 "" H 6100 3300 50  0001 C CNN
	1    6100 3300
	-1   0    0    -1  
$EndComp
$Comp
L CP1 C?
U 1 1 595A7134
P 6400 3300
F 0 "C?" H 6425 3400 50  0000 L CNN
F 1 "10uF" H 6425 3200 50  0000 L CNN
F 2 "" H 6400 3300 50  0001 C CNN
F 3 "" H 6400 3300 50  0001 C CNN
	1    6400 3300
	-1   0    0    -1  
$EndComp
$Comp
L CP1 C?
U 1 1 595A713B
P 6900 3300
F 0 "C?" H 6925 3400 50  0000 L CNN
F 1 "10uF" H 6925 3200 50  0000 L CNN
F 2 "" H 6900 3300 50  0001 C CNN
F 3 "" H 6900 3300 50  0001 C CNN
	1    6900 3300
	1    0    0    -1  
$EndComp
Wire Wire Line
	6400 3150 6400 3050
Connection ~ 6400 3050
Wire Wire Line
	6100 3450 6100 3600
Wire Wire Line
	6100 3600 6900 3600
Wire Wire Line
	6750 3100 6750 2800
Wire Wire Line
	6400 3450 6400 3700
Connection ~ 6400 3600
Wire Wire Line
	6850 2800 6850 2900
Wire Wire Line
	6850 2900 6950 2900
Text GLabel 6950 2900 2    60   Input ~ 0
-V2_SHDN
Text GLabel 6400 3700 3    60   Input ~ 0
AGND
Text GLabel 7100 3100 2    60   Input ~ 0
+15V
Text GLabel 6250 2700 1    60   Input ~ 0
-V2
Wire Wire Line
	5350 2850 6450 2850
Wire Wire Line
	5350 3050 6550 3050
Wire Wire Line
	6900 3150 6900 3100
Wire Wire Line
	6750 3100 7100 3100
Connection ~ 6900 3100
Wire Wire Line
	6650 2800 6650 3600
Connection ~ 6650 3600
Wire Wire Line
	6250 2700 6250 3050
Connection ~ 6250 3050
Wire Wire Line
	6100 3150 6100 2850
Connection ~ 6100 2850
Wire Wire Line
	6900 3600 6900 3450
$EndSCHEMATC
