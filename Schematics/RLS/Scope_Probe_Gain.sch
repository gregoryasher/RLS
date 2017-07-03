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
Sheet 3 7
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
L ULN2803A U12
U 1 1 594DCBE5
P 4450 1900
F 0 "U12" H 4450 2425 50  0000 C CNN
F 1 "ULN2803A" H 4450 2350 50  0000 C CNN
F 2 "" H 4500 1250 50  0001 L CNN
F 3 "" H 4550 1800 50  0001 C CNN
	1    4450 1900
	1    0    0    -1  
$EndComp
Text GLabel 4450 2600 3    60   Input ~ 0
AGND
Text GLabel 3350 950  0    60   Input ~ 0
+5V
Text GLabel 3250 1600 0    60   Input ~ 0
AA12
Text GLabel 3250 1700 0    60   Input ~ 0
AA13
$Comp
L R R1
U 1 1 594DCDC0
P 3500 1250
F 0 "R1" V 3580 1250 50  0000 C CNN
F 1 "4.7K" V 3500 1250 50  0000 C CNN
F 2 "" V 3430 1250 50  0001 C CNN
F 3 "" H 3500 1250 50  0001 C CNN
	1    3500 1250
	1    0    0    -1  
$EndComp
$Comp
L R R2
U 1 1 594DCE13
P 3700 1250
F 0 "R2" V 3780 1250 50  0000 C CNN
F 1 "4.7K" V 3700 1250 50  0000 C CNN
F 2 "" V 3630 1250 50  0001 C CNN
F 3 "" H 3700 1250 50  0001 C CNN
	1    3700 1250
	1    0    0    -1  
$EndComp
Text GLabel 4850 1600 2    60   Input ~ 0
RLY1
Text GLabel 4850 1700 2    60   Input ~ 0
RLY2
$Comp
L R70-5D1-3 U13
U 1 1 595850A9
P 7250 1800
F 0 "U13" H 7350 2000 60  0000 C CNN
F 1 "R70-5D1-3" V 7100 2000 60  0000 C CNN
F 2 "" H 7250 1800 60  0001 C CNN
F 3 "" H 7250 1800 60  0001 C CNN
	1    7250 1800
	-1   0    0    -1  
$EndComp
$Comp
L R70-5D1-3 U14
U 1 1 59585156
P 7200 3150
F 0 "U14" H 7300 3350 60  0000 C CNN
F 1 "R70-5D1-3" V 7050 3350 60  0000 C CNN
F 2 "" H 7200 3150 60  0001 C CNN
F 3 "" H 7200 3150 60  0001 C CNN
	1    7200 3150
	-1   0    0    -1  
$EndComp
Text GLabel 6050 1600 0    60   Input ~ 0
POS_SCP1
Text GLabel 6050 2950 0    60   Input ~ 0
POS_SCP2
Text GLabel 7500 2200 0    60   Input ~ 0
NEG_SCP1
Text GLabel 7400 3600 0    60   Input ~ 0
NEG_SCP2
$Comp
L R R17
U 1 1 595881BF
P 6600 1850
F 0 "R17" V 6680 1850 50  0000 C CNN
F 1 "9M" V 6600 1850 50  0000 C CNN
F 2 "" V 6530 1850 50  0001 C CNN
F 3 "" H 6600 1850 50  0001 C CNN
	1    6600 1850
	0    -1   -1   0   
$EndComp
$Comp
L R R18
U 1 1 59588224
P 6550 3200
F 0 "R18" V 6630 3200 50  0000 C CNN
F 1 "9M" V 6550 3200 50  0000 C CNN
F 2 "" V 6480 3200 50  0001 C CNN
F 3 "" H 6550 3200 50  0001 C CNN
	1    6550 3200
	0    -1   -1   0   
$EndComp
$Comp
L C_Small C1
U 1 1 595882C2
P 6600 2050
F 0 "C1" H 6610 2120 50  0000 L CNN
F 1 "15pF" H 6610 1970 50  0000 L CNN
F 2 "" H 6600 2050 50  0001 C CNN
F 3 "" H 6600 2050 50  0001 C CNN
	1    6600 2050
	0    1    1    0   
$EndComp
$Comp
L C_Small C2
U 1 1 595883A5
P 6550 3400
F 0 "C2" H 6560 3470 50  0000 L CNN
F 1 "15pF" H 6560 3320 50  0000 L CNN
F 2 "" H 6550 3400 50  0001 C CNN
F 3 "" H 6550 3400 50  0001 C CNN
	1    6550 3400
	0    1    1    0   
$EndComp
$Comp
L CONN_01X03 J1
U 1 1 595883FC
P 7700 2200
F 0 "J1" H 7700 2400 50  0000 C CNN
F 1 "Velleman_Probe1" V 7800 2200 50  0000 C CNN
F 2 "" H 7700 2200 50  0001 C CNN
F 3 "" H 7700 2200 50  0001 C CNN
	1    7700 2200
	1    0    0    -1  
$EndComp
$Comp
L CONN_01X03 J2
U 1 1 5958858D
P 7600 3600
F 0 "J2" H 7600 3800 50  0000 C CNN
F 1 "Velleman_Probe2" V 7700 3600 50  0000 C CNN
F 2 "" H 7600 3600 50  0001 C CNN
F 3 "" H 7600 3600 50  0001 C CNN
	1    7600 3600
	1    0    0    -1  
$EndComp
NoConn ~ 7250 2700
NoConn ~ 7300 1350
NoConn ~ 7500 2300
NoConn ~ 7400 3700
Text GLabel 7050 2700 1    60   Input ~ 0
RLY2
Text GLabel 7100 1350 1    60   Input ~ 0
RLY1
Text GLabel 7100 1850 3    60   Input ~ 0
+5V
Text GLabel 7050 3200 3    60   Input ~ 0
+5V
Wire Wire Line
	4850 2400 5300 2400
Wire Wire Line
	5300 2400 5300 950 
Wire Wire Line
	5300 950  3350 950 
Wire Wire Line
	3700 1400 3700 1700
Wire Wire Line
	3250 1700 4050 1700
Wire Wire Line
	3250 1600 4050 1600
Wire Wire Line
	3500 1400 3500 1600
Wire Wire Line
	3500 1100 3500 950 
Connection ~ 3500 950 
Wire Wire Line
	3700 1100 3700 950 
Connection ~ 3700 950 
Connection ~ 3500 1600
Connection ~ 3700 1700
Wire Wire Line
	7500 2100 7300 2100
Wire Wire Line
	7300 2100 7300 1850
Wire Wire Line
	7400 3500 7250 3500
Wire Wire Line
	7250 3500 7250 3200
Wire Wire Line
	6700 3200 6950 3200
Wire Wire Line
	6800 3200 6800 3400
Wire Wire Line
	6800 3400 6650 3400
Connection ~ 6800 3200
Wire Wire Line
	6200 3200 6400 3200
Wire Wire Line
	6300 3200 6300 3400
Wire Wire Line
	6300 3400 6450 3400
Wire Wire Line
	6950 2700 6200 2700
Wire Wire Line
	6200 2700 6200 3200
Connection ~ 6300 3200
Wire Wire Line
	6200 2950 6050 2950
Connection ~ 6200 2950
Wire Wire Line
	6750 1850 7000 1850
Wire Wire Line
	6850 1850 6850 2050
Wire Wire Line
	6850 2050 6700 2050
Connection ~ 6850 1850
Wire Wire Line
	6200 1850 6450 1850
Wire Wire Line
	6300 1850 6300 2050
Wire Wire Line
	6300 2050 6500 2050
Wire Wire Line
	6200 1350 6200 1850
Wire Wire Line
	6200 1350 7000 1350
Connection ~ 6300 1850
Wire Wire Line
	6200 1600 6050 1600
Connection ~ 6200 1600
$Comp
L CONN_01X03 J3
U 1 1 595A5435
P 8650 2800
F 0 "J3" H 8650 3000 50  0000 C CNN
F 1 "Velleman_FuncGen" V 8750 2800 50  0000 C CNN
F 2 "" H 8650 2800 50  0001 C CNN
F 3 "" H 8650 2800 50  0001 C CNN
	1    8650 2800
	1    0    0    -1  
$EndComp
Text GLabel 8450 2700 0    60   Input ~ 0
POS_GEN
Text GLabel 8450 2800 0    60   Input ~ 0
NEG_GEN
NoConn ~ 8450 2900
NoConn ~ 4850 1800
NoConn ~ 4850 1900
NoConn ~ 4850 2000
NoConn ~ 4850 2100
NoConn ~ 4850 2200
NoConn ~ 4850 2300
NoConn ~ 4050 2300
NoConn ~ 4050 2200
NoConn ~ 4050 2100
NoConn ~ 4050 2000
NoConn ~ 4050 1900
NoConn ~ 4050 1800
$EndSCHEMATC
