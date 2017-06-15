EESchema Schematic File Version 2
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
LIBS:Motherboard_Test-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 1 1
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
L AD5272 U1
U 1 1 56BE2A87
P 5300 2500
F 0 "U1" H 4850 2900 50  0000 L CNN
F 1 "AD5272" H 5500 2900 50  0000 L CNN
F 2 "" H 5300 2500 50  0000 C CNN
F 3 "" H 5300 2500 50  0000 C CNN
	1    5300 2500
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR01
U 1 1 56BE2AAE
P 4400 3250
F 0 "#PWR01" H 4400 3000 50  0001 C CNN
F 1 "GND" H 4400 3100 50  0000 C CNN
F 2 "" H 4400 3250 50  0000 C CNN
F 3 "" H 4400 3250 50  0000 C CNN
	1    4400 3250
	1    0    0    -1  
$EndComp
$Comp
L C_Small C1
U 1 1 56BE2AC5
P 4650 1800
F 0 "C1" H 4660 1870 50  0000 L CNN
F 1 "C_Small" H 4660 1720 50  0000 L CNN
F 2 "" H 4650 1800 50  0000 C CNN
F 3 "" H 4650 1800 50  0000 C CNN
	1    4650 1800
	1    0    0    -1  
$EndComp
$Comp
L C_Small C2
U 1 1 56BE2AEF
P 5000 1800
F 0 "C2" H 5010 1870 50  0000 L CNN
F 1 "C_Small" H 5010 1720 50  0000 L CNN
F 2 "" H 5000 1800 50  0000 C CNN
F 3 "" H 5000 1800 50  0000 C CNN
	1    5000 1800
	1    0    0    -1  
$EndComp
$Comp
L R R1_100
U 1 1 56BE2B15
P 4150 2000
F 0 "R1_100" V 4230 2000 50  0000 C CNN
F 1 "R" V 4150 2000 50  0000 C CNN
F 2 "" V 4080 2000 50  0000 C CNN
F 3 "" H 4150 2000 50  0000 C CNN
	1    4150 2000
	1    0    0    -1  
$EndComp
$Comp
L C_Small C3
U 1 1 56BE2B4C
P 4550 2900
F 0 "C3" H 4560 2970 50  0000 L CNN
F 1 "C_Small" H 4560 2820 50  0000 L CNN
F 2 "" H 4550 2900 50  0000 C CNN
F 3 "" H 4550 2900 50  0000 C CNN
	1    4550 2900
	1    0    0    -1  
$EndComp
$Comp
L R R2_100
U 1 1 56BE2B82
P 4350 2000
F 0 "R2_100" V 4430 2000 50  0000 C CNN
F 1 "R" V 4350 2000 50  0000 C CNN
F 2 "" V 4280 2000 50  0000 C CNN
F 3 "" H 4350 2000 50  0000 C CNN
	1    4350 2000
	1    0    0    -1  
$EndComp
$Comp
L +5V #PWR02
U 1 1 56BE2BB3
P 3850 1600
F 0 "#PWR02" H 3850 1450 50  0001 C CNN
F 1 "+5V" H 3850 1740 50  0000 C CNN
F 2 "" H 3850 1600 50  0000 C CNN
F 3 "" H 3850 1600 50  0000 C CNN
	1    3850 1600
	1    0    0    -1  
$EndComp
Wire Wire Line
	5200 3000 5200 3100
Wire Wire Line
	4400 3100 5950 3100
Wire Wire Line
	4400 3100 4400 3250
Wire Wire Line
	3850 1600 3850 1700
Wire Wire Line
	3850 1700 5300 1700
Connection ~ 4650 1700
Wire Wire Line
	5300 1700 5300 2000
Connection ~ 5000 1700
Connection ~ 4150 1700
Wire Wire Line
	4150 1850 4150 1700
Wire Wire Line
	4150 2150 4150 2300
Wire Wire Line
	3500 2300 4700 2300
Connection ~ 4150 2300
Wire Wire Line
	4350 1850 4350 1700
Connection ~ 4350 1700
Wire Wire Line
	4350 2150 4350 2400
Wire Wire Line
	3500 2400 4700 2400
Text GLabel 3500 2300 0    47   Input ~ 0
Clk
Text GLabel 3500 2400 0    47   Input ~ 0
SDA
Connection ~ 4350 2400
Wire Wire Line
	4700 2700 3950 2700
Wire Wire Line
	3950 2700 3950 1700
Connection ~ 3950 1700
Wire Wire Line
	4700 2500 4550 2500
Wire Wire Line
	4550 2500 4550 2800
Wire Wire Line
	4550 3000 4550 3100
Connection ~ 4550 3100
Wire Wire Line
	5400 3100 5400 3000
Connection ~ 5200 3100
Wire Wire Line
	5900 2500 5950 2500
Wire Wire Line
	5950 2500 5950 3100
Connection ~ 5400 3100
Text GLabel 6300 2300 2    47   Input ~ 0
A
Text GLabel 6300 2700 2    47   Input ~ 0
W
Wire Wire Line
	5900 2300 6300 2300
Wire Wire Line
	5900 2700 6300 2700
Wire Wire Line
	5000 1900 5000 2000
Wire Wire Line
	5000 2000 4650 2000
Wire Wire Line
	4650 1900 4650 3100
Connection ~ 4650 2000
Connection ~ 4650 3100
$EndSCHEMATC
