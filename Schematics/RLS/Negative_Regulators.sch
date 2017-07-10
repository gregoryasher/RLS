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
Sheet 4 7
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
L LT3015 U6
U 1 1 5952FBCC
P 6100 4250
F 0 "U6" H 6150 4750 60  0000 C CNN
F 1 "LT3015" H 6150 4850 60  0000 C CNN
F 2 "TO_SOT_Packages_THT:TO-220-5_Pentawatt_Multiwatt-5_Vertical_StaggeredType1" H 6150 4750 60  0001 C CNN
F 3 "" H 6150 4750 60  0001 C CNN
	1    6100 4250
	-1   0    0    -1  
$EndComp
$Comp
L AD5293-RESCUE-RLS U4
U 1 1 595305F7
P 4050 4700
AR Path="/595305F7" Ref="U4"  Part="1" 
AR Path="/5952F710/595305F7" Ref="U4"  Part="1" 
F 0 "U4" H 3500 5100 50  0000 L CNN
F 1 "AD5293" H 4350 5100 50  0000 L CNN
F 2 "SMD_Packages:SSOP-14" H 4050 4700 50  0001 C CNN
F 3 "" H 4050 4700 50  0001 C CNN
	1    4050 4700
	1    0    0    -1  
$EndComp
$Comp
L AD5293-RESCUE-RLS U5
U 1 1 59530648
P 4050 2050
AR Path="/59530648" Ref="U5"  Part="1" 
AR Path="/5952F710/59530648" Ref="U5"  Part="1" 
F 0 "U5" H 3500 2450 50  0000 L CNN
F 1 "AD5293" H 4350 2450 50  0000 L CNN
F 2 "SMD_Packages:SSOP-14" H 4050 2050 50  0001 C CNN
F 3 "" H 4050 2050 50  0001 C CNN
	1    4050 2050
	1    0    0    -1  
$EndComp
$Comp
L CP1 C15
U 1 1 59582C1E
P 3300 2550
F 0 "C15" H 3325 2650 50  0000 L CNN
F 1 "1uF" H 3325 2450 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 3300 2550 50  0001 C CNN
F 3 "" H 3300 2550 50  0001 C CNN
	1    3300 2550
	1    0    0    -1  
$EndComp
$Comp
L CP1 C16
U 1 1 59582C25
P 3300 5200
F 0 "C16" H 3325 5300 50  0000 L CNN
F 1 "1uF" H 3325 5100 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 3300 5200 50  0001 C CNN
F 3 "" H 3300 5200 50  0001 C CNN
	1    3300 5200
	1    0    0    -1  
$EndComp
$Comp
L CP1 C3
U 1 1 59582C2C
P 4400 3750
F 0 "C3" H 4425 3850 50  0000 L CNN
F 1 "10uF" H 4425 3650 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 4400 3750 50  0001 C CNN
F 3 "" H 4400 3750 50  0001 C CNN
	1    4400 3750
	0    -1   -1   0   
$EndComp
$Comp
L C C4
U 1 1 5958315B
P 4400 4050
F 0 "C4" H 4425 4150 50  0000 L CNN
F 1 "0.1uF" H 4425 3950 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 4438 3900 50  0001 C CNN
F 3 "" H 4400 4050 50  0001 C CNN
	1    4400 4050
	0    -1   -1   0   
$EndComp
$Comp
L R R19
U 1 1 5958317D
P 2850 4350
F 0 "R19" V 2930 4350 50  0000 C CNN
F 1 "4.7K" V 2850 4350 50  0000 C CNN
F 2 "Resistors_SMD:R_0805_HandSoldering" V 2780 4350 50  0001 C CNN
F 3 "" H 2850 4350 50  0001 C CNN
	1    2850 4350
	-1   0    0    1   
$EndComp
$Comp
L CP1 C7
U 1 1 5958F709
P 3700 3750
F 0 "C7" H 3725 3850 50  0000 L CNN
F 1 "10uF" H 3725 3650 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 3700 3750 50  0001 C CNN
F 3 "" H 3700 3750 50  0001 C CNN
	1    3700 3750
	0    1    -1   0   
$EndComp
$Comp
L C C8
U 1 1 5958F710
P 3700 4050
F 0 "C8" H 3725 4150 50  0000 L CNN
F 1 "0.1uF" H 3725 3950 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 3738 3900 50  0001 C CNN
F 3 "" H 3700 4050 50  0001 C CNN
	1    3700 4050
	0    1    -1   0   
$EndComp
Text GLabel 4150 3650 1    60   Input ~ 0
+15V
Text GLabel 3950 3650 1    60   Input ~ 0
+5V
Text GLabel 4700 3900 2    60   Input ~ 0
AGND
Text GLabel 3400 3900 0    60   Input ~ 0
AGND
$Comp
L CP1 C9
U 1 1 59590FE8
P 4400 1050
F 0 "C9" H 4425 1150 50  0000 L CNN
F 1 "10uF" H 4425 950 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 4400 1050 50  0001 C CNN
F 3 "" H 4400 1050 50  0001 C CNN
	1    4400 1050
	0    -1   -1   0   
$EndComp
$Comp
L C C10
U 1 1 59590FEF
P 4400 1350
F 0 "C10" H 4425 1450 50  0000 L CNN
F 1 "0.1uF" H 4425 1250 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 4438 1200 50  0001 C CNN
F 3 "" H 4400 1350 50  0001 C CNN
	1    4400 1350
	0    -1   -1   0   
$EndComp
$Comp
L CP1 C13
U 1 1 59590FF6
P 3700 1050
F 0 "C13" H 3725 1150 50  0000 L CNN
F 1 "10uF" H 3725 950 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 3700 1050 50  0001 C CNN
F 3 "" H 3700 1050 50  0001 C CNN
	1    3700 1050
	0    1    -1   0   
$EndComp
$Comp
L C C14
U 1 1 59590FFD
P 3700 1350
F 0 "C14" H 3725 1450 50  0000 L CNN
F 1 "0.1uF" H 3725 1250 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 3738 1200 50  0001 C CNN
F 3 "" H 3700 1350 50  0001 C CNN
	1    3700 1350
	0    1    -1   0   
$EndComp
Text GLabel 4150 950  1    60   Input ~ 0
+15V
Text GLabel 3950 950  1    60   Input ~ 0
+5V
Text GLabel 4700 1200 2    60   Input ~ 0
AGND
Text GLabel 3400 1200 0    60   Input ~ 0
AGND
Text GLabel 3950 5250 3    60   Input ~ 0
AGND
Text GLabel 3900 2650 0    60   Input ~ 0
AGND
$Comp
L CP1 C11
U 1 1 59593FD8
P 4400 3000
F 0 "C11" H 4425 3100 50  0000 L CNN
F 1 "10uF" H 4425 2900 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 4400 3000 50  0001 C CNN
F 3 "" H 4400 3000 50  0001 C CNN
	1    4400 3000
	0    1    1    0   
$EndComp
$Comp
L C C12
U 1 1 59593FDF
P 4400 2700
F 0 "C12" H 4425 2800 50  0000 L CNN
F 1 "0.1uF" H 4400 2600 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 4438 2550 50  0001 C CNN
F 3 "" H 4400 2700 50  0001 C CNN
	1    4400 2700
	0    -1   1    0   
$EndComp
Text GLabel 4700 2850 2    60   Input ~ 0
AGND
Text GLabel 4050 3000 0    60   Input ~ 0
-15V
$Comp
L CP1 C5
U 1 1 59594AB0
P 4400 5700
F 0 "C5" H 4425 5800 50  0000 L CNN
F 1 "10uF" H 4425 5600 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 4400 5700 50  0001 C CNN
F 3 "" H 4400 5700 50  0001 C CNN
	1    4400 5700
	0    1    1    0   
$EndComp
$Comp
L C C6
U 1 1 59594AB7
P 4400 5400
F 0 "C6" H 4425 5500 50  0000 L CNN
F 1 "0.1uF" H 4400 5300 50  0000 L CNN
F 2 "Capacitors_SMD:C_0603_HandSoldering" H 4438 5250 50  0001 C CNN
F 3 "" H 4400 5400 50  0001 C CNN
	1    4400 5400
	0    -1   1    0   
$EndComp
Text GLabel 4700 5550 2    60   Input ~ 0
AGND
Text GLabel 4050 5700 0    60   Input ~ 0
-15V
NoConn ~ 3350 4800
NoConn ~ 3350 2150
Text GLabel 3250 2250 0    60   Input ~ 0
+5V
Text GLabel 3250 4900 0    60   Input ~ 0
+5V
Text GLabel 3300 4400 0    60   Input ~ 0
MOSI
Text GLabel 2850 4000 1    60   Input ~ 0
+5V
NoConn ~ 3350 1850
Text GLabel 2700 4700 0    60   Input ~ 0
N_POT_CE
Text GLabel 2600 1950 0    60   Input ~ 0
SCLK
Text GLabel 3300 2700 3    60   Input ~ 0
AGND
Text GLabel 3300 5350 3    60   Input ~ 0
AGND
$Comp
L R R20
U 1 1 5959FDF4
P 5800 5150
F 0 "R20" V 5880 5150 50  0000 C CNN
F 1 "1.78K" V 5800 5150 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 5730 5150 50  0001 C CNN
F 3 "" H 5800 5150 50  0001 C CNN
	1    5800 5150
	1    0    0    -1  
$EndComp
$Comp
L CP1 C17
U 1 1 5959FE9D
P 5500 5150
F 0 "C17" H 5525 5250 50  0000 L CNN
F 1 "10uF" H 5525 5050 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 5500 5150 50  0001 C CNN
F 3 "" H 5500 5150 50  0001 C CNN
	1    5500 5150
	1    0    0    1   
$EndComp
$Comp
L CP1 C18
U 1 1 5959FFA5
P 6050 5150
F 0 "C18" H 6075 5250 50  0000 L CNN
F 1 "10uF" H 6075 5050 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 6050 5150 50  0001 C CNN
F 3 "" H 6050 5150 50  0001 C CNN
	1    6050 5150
	1    0    0    1   
$EndComp
Text GLabel 6350 4750 2    60   Input ~ 0
-V2_SHDN
Text GLabel 5800 5550 3    60   Input ~ 0
AGND
Text GLabel 6400 4900 2    60   Input ~ 0
-15V
Text GLabel 5500 4550 1    60   Input ~ 0
-V2
$Comp
L LT3015 U7
U 1 1 595A20C2
P 6100 1600
F 0 "U7" H 6150 2100 60  0000 C CNN
F 1 "LT3015" H 6150 2200 60  0000 C CNN
F 2 "TO_SOT_Packages_THT:TO-220-5_Pentawatt_Multiwatt-5_Vertical_StaggeredType1" H 6150 2100 60  0001 C CNN
F 3 "" H 6150 2100 60  0001 C CNN
	1    6100 1600
	-1   0    0    -1  
$EndComp
$Comp
L R R21
U 1 1 595A20CD
P 5800 2500
F 0 "R21" V 5880 2500 50  0000 C CNN
F 1 "1.78K" V 5800 2500 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 5730 2500 50  0001 C CNN
F 3 "" H 5800 2500 50  0001 C CNN
	1    5800 2500
	1    0    0    -1  
$EndComp
$Comp
L CP1 C19
U 1 1 595A20D4
P 5500 2500
F 0 "C19" H 5525 2600 50  0000 L CNN
F 1 "10uF" H 5525 2400 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 5500 2500 50  0001 C CNN
F 3 "" H 5500 2500 50  0001 C CNN
	1    5500 2500
	1    0    0    1   
$EndComp
$Comp
L CP1 C20
U 1 1 595A20DB
P 6050 2500
F 0 "C20" H 6075 2600 50  0000 L CNN
F 1 "10uF" H 6075 2400 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 6050 2500 50  0001 C CNN
F 3 "" H 6050 2500 50  0001 C CNN
	1    6050 2500
	1    0    0    1   
$EndComp
Text GLabel 6350 2100 2    60   Input ~ 0
-V1_SHDN
Text GLabel 5800 2900 3    60   Input ~ 0
AGND
Text GLabel 6400 2250 2    60   Input ~ 0
-15V
Text GLabel 5500 1900 1    60   Input ~ 0
-V1
Wire Wire Line
	3350 5000 3300 5000
Wire Wire Line
	3300 5000 3300 5050
Wire Wire Line
	3350 2350 3300 2350
Wire Wire Line
	3300 2350 3300 2400
Wire Wire Line
	3950 3650 3950 4200
Wire Wire Line
	3950 4050 3850 4050
Wire Wire Line
	3850 3750 3950 3750
Connection ~ 3950 4050
Wire Wire Line
	3550 3750 3450 3750
Wire Wire Line
	3450 3750 3450 4050
Wire Wire Line
	3450 4050 3550 4050
Wire Wire Line
	4550 3750 4650 3750
Wire Wire Line
	4650 3750 4650 4050
Wire Wire Line
	4650 4050 4550 4050
Wire Wire Line
	4250 3750 4150 3750
Wire Wire Line
	4150 3650 4150 4200
Wire Wire Line
	4250 4050 4150 4050
Connection ~ 4150 4050
Wire Wire Line
	3400 3900 3450 3900
Connection ~ 3450 3900
Wire Wire Line
	4700 3900 4650 3900
Connection ~ 4650 3900
Connection ~ 3950 3750
Connection ~ 4150 3750
Wire Wire Line
	3950 950  3950 1550
Wire Wire Line
	3950 1350 3850 1350
Wire Wire Line
	3850 1050 3950 1050
Connection ~ 3950 1350
Wire Wire Line
	3550 1050 3450 1050
Wire Wire Line
	3450 1050 3450 1350
Wire Wire Line
	3450 1350 3550 1350
Wire Wire Line
	4550 1050 4650 1050
Wire Wire Line
	4650 1050 4650 1350
Wire Wire Line
	4650 1350 4550 1350
Wire Wire Line
	4250 1050 4150 1050
Wire Wire Line
	4150 950  4150 1550
Wire Wire Line
	4150 1350 4250 1350
Connection ~ 4150 1350
Wire Wire Line
	3400 1200 3450 1200
Connection ~ 3450 1200
Wire Wire Line
	4700 1200 4650 1200
Connection ~ 4650 1200
Connection ~ 3950 1050
Connection ~ 4150 1050
Wire Wire Line
	4650 3000 4550 3000
Wire Wire Line
	4650 2700 4650 3000
Wire Wire Line
	4650 2700 4550 2700
Wire Wire Line
	4250 2700 4150 2700
Wire Wire Line
	4700 2850 4650 2850
Connection ~ 4650 2850
Wire Wire Line
	4650 5700 4550 5700
Wire Wire Line
	4650 5400 4650 5700
Wire Wire Line
	4650 5400 4550 5400
Wire Wire Line
	4050 5700 4250 5700
Wire Wire Line
	4250 5400 4150 5400
Connection ~ 4150 5400
Wire Wire Line
	4700 5550 4650 5550
Connection ~ 4650 5550
Connection ~ 4150 5700
Wire Wire Line
	4150 5200 4150 5700
Wire Wire Line
	3350 4600 2600 4600
Wire Wire Line
	2600 4600 2600 1950
Wire Wire Line
	2600 1950 3350 1950
Wire Wire Line
	3350 2050 2700 2050
Wire Wire Line
	2700 2050 2700 4700
Wire Wire Line
	2700 4700 3350 4700
Wire Wire Line
	3250 2250 3350 2250
Wire Wire Line
	3250 4900 3350 4900
Wire Wire Line
	3300 4400 3350 4400
Wire Wire Line
	2850 4500 3350 4500
Wire Wire Line
	2850 4000 2850 4200
Wire Wire Line
	2950 4500 2950 1750
Wire Wire Line
	2950 1750 3350 1750
Connection ~ 2950 4500
Wire Wire Line
	4750 4700 5850 4700
Wire Wire Line
	5850 4700 5850 4650
Wire Wire Line
	4750 4900 5950 4900
Wire Wire Line
	5950 4900 5950 4650
Wire Wire Line
	5500 4550 5500 5000
Connection ~ 5500 4700
Wire Wire Line
	5800 5000 5800 4900
Connection ~ 5800 4900
Wire Wire Line
	6050 4650 6050 5000
Wire Wire Line
	5500 5300 5500 5450
Wire Wire Line
	5500 5450 6300 5450
Wire Wire Line
	6300 5450 6300 4950
Wire Wire Line
	6150 4950 6150 4650
Wire Wire Line
	6050 5300 6050 5450
Connection ~ 6050 5450
Wire Wire Line
	5800 5300 5800 5550
Connection ~ 5800 5450
Wire Wire Line
	6250 4650 6250 4750
Wire Wire Line
	6250 4750 6350 4750
Wire Wire Line
	5850 2050 5850 2000
Wire Wire Line
	5950 2250 5950 2000
Wire Wire Line
	5500 1900 5500 2350
Connection ~ 5500 2050
Wire Wire Line
	5800 2350 5800 2250
Connection ~ 5800 2250
Wire Wire Line
	6050 2000 6050 2350
Wire Wire Line
	5500 2650 5500 2800
Wire Wire Line
	5500 2800 6300 2800
Wire Wire Line
	6150 2300 6150 2000
Wire Wire Line
	6050 2650 6050 2800
Connection ~ 6050 2800
Wire Wire Line
	5800 2650 5800 2900
Connection ~ 5800 2800
Wire Wire Line
	6250 2000 6250 2100
Wire Wire Line
	6250 2100 6350 2100
Wire Wire Line
	4750 2050 5850 2050
Wire Wire Line
	4750 2250 5950 2250
Wire Wire Line
	6150 2300 6300 2300
Wire Wire Line
	6300 2300 6300 2800
Wire Wire Line
	6050 2250 6400 2250
Connection ~ 6050 2250
Wire Wire Line
	6300 4950 6150 4950
Wire Wire Line
	6400 4900 6050 4900
Connection ~ 6050 4900
NoConn ~ 4750 1850
NoConn ~ 4750 4500
Wire Wire Line
	3950 5200 3950 5250
Wire Wire Line
	4050 3000 4250 3000
Wire Wire Line
	4150 2550 4150 3000
Connection ~ 4150 3000
Connection ~ 4150 2700
Wire Wire Line
	3900 2650 3950 2650
Wire Wire Line
	3950 2650 3950 2550
Text Label 5950 2250 1    40   ~ 0
-V1_ADJ
Text Label 5950 4900 1    40   ~ 0
-V2_ADJ
Text Label 3300 5050 2    40   ~ 0
-V2_EX_C
Text Label 3300 2400 2    40   ~ 0
-V1_EX_C
Text Label 2950 3500 1    40   ~ 0
-SDO_SDI
$EndSCHEMATC
