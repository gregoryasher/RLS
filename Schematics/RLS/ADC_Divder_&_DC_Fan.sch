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
LIBS:RA30421051
LIBS:RB496EATR
LIBS:Daughterboard_Connector
LIBS:RLS-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 2 7
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
L BS170 Q1
U 1 1 595B0816
P 9300 2150
F 0 "Q1" H 9500 2225 50  0000 L CNN
F 1 "BS170" H 9500 2150 50  0000 L CNN
F 2 "TO_SOT_Packages_SMD:SOT-23" H 9500 2075 50  0001 L CIN
F 3 "" H 9300 2150 50  0001 L CNN
	1    9300 2150
	1    0    0    -1  
$EndComp
$Comp
L R R23
U 1 1 595B0B7F
P 8900 2650
F 0 "R23" V 8980 2650 50  0000 C CNN
F 1 "1K" V 8900 2650 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 8830 2650 50  0001 C CNN
F 3 "" H 8900 2650 50  0001 C CNN
	1    8900 2650
	1    0    0    -1  
$EndComp
$Comp
L Thermistor_NTC TH1
U 1 1 595B0BDC
P 8900 1700
F 0 "TH1" V 8725 1700 50  0000 C CNN
F 1 "3K_NTC" V 9025 1700 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0411_L9.9mm_D3.6mm_P12.70mm_Horizontal" H 8900 1750 50  0001 C CNN
F 3 "" H 8900 1750 50  0001 C CNN
	1    8900 1700
	1    0    0    -1  
$EndComp
$Comp
L CP1 C1
U 1 1 595B0C17
P 9700 1600
F 0 "C1" H 9725 1700 50  0000 L CNN
F 1 "10uF" H 9725 1500 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 9700 1600 50  0001 C CNN
F 3 "" H 9700 1600 50  0001 C CNN
	1    9700 1600
	1    0    0    -1  
$EndComp
$Comp
L CONN_01X03 J2
U 1 1 595B0EFE
P 10350 1350
F 0 "J2" H 10350 1550 50  0000 C CNN
F 1 "DC_Fan" V 10450 1350 50  0000 C CNN
F 2 "Pin_Headers:Pin_Header_Straight_1x03_Pitch2.54mm" H 10350 1350 50  0001 C CNN
F 3 "" H 10350 1350 50  0001 C CNN
	1    10350 1350
	1    0    0    1   
$EndComp
Text GLabel 9150 3050 0    60   Input ~ 0
AGND
Text GLabel 9300 1200 2    60   Input ~ 0
+5V
NoConn ~ 10150 1250
$Comp
L NE5532 U4
U 1 1 59630AD8
P 2550 2200
F 0 "U4" H 2550 2400 50  0000 L CNN
F 1 "NE5532" H 2550 2000 50  0000 L CNN
F 2 "Housings_SOIC:SOIC-8_3.9x4.9mm_Pitch1.27mm" H 2550 2200 50  0001 C CNN
F 3 "" H 2550 2200 50  0001 C CNN
	1    2550 2200
	1    0    0    -1  
$EndComp
$Comp
L NE5532 U4
U 2 1 59630C05
P 7200 1950
F 0 "U4" H 7200 2150 50  0000 L CNN
F 1 "NE5532" H 7200 1750 50  0000 L CNN
F 2 "Housings_SOIC:SOIC-8_3.9x4.9mm_Pitch1.27mm" H 7200 1950 50  0001 C CNN
F 3 "" H 7200 1950 50  0001 C CNN
	2    7200 1950
	1    0    0    -1  
$EndComp
$Comp
L NE5532 U5
U 2 1 59630DE7
P 4400 4800
F 0 "U5" H 4400 5000 50  0000 L CNN
F 1 "NE5532" H 4400 4600 50  0000 L CNN
F 2 "Housings_SOIC:SOIC-8_3.9x4.9mm_Pitch1.27mm" H 4400 4800 50  0001 C CNN
F 3 "" H 4400 4800 50  0001 C CNN
	2    4400 4800
	1    0    0    -1  
$EndComp
$Comp
L NE5532 U8
U 1 1 59630E33
P 8450 5400
F 0 "U8" H 8450 5600 50  0000 L CNN
F 1 "NE5532" H 8450 5200 50  0000 L CNN
F 2 "Housings_SOIC:SOIC-8_3.9x4.9mm_Pitch1.27mm" H 8450 5400 50  0001 C CNN
F 3 "" H 8450 5400 50  0001 C CNN
	1    8450 5400
	1    0    0    -1  
$EndComp
$Comp
L NE5532 U5
U 1 1 59630FE7
P 2550 4900
F 0 "U5" H 2550 5100 50  0000 L CNN
F 1 "NE5532" H 2550 4700 50  0000 L CNN
F 2 "Housings_SOIC:SOIC-8_3.9x4.9mm_Pitch1.27mm" H 2550 4900 50  0001 C CNN
F 3 "" H 2550 4900 50  0001 C CNN
	1    2550 4900
	1    0    0    -1  
$EndComp
$Comp
L NE5532 U8
U 2 1 596310A4
P 9900 5300
F 0 "U8" H 9900 5500 50  0000 L CNN
F 1 "NE5532" H 9900 5100 50  0000 L CNN
F 2 "Housings_SOIC:SOIC-8_3.9x4.9mm_Pitch1.27mm" H 9900 5300 50  0001 C CNN
F 3 "" H 9900 5300 50  0001 C CNN
	2    9900 5300
	1    0    0    -1  
$EndComp
$Comp
L RB496EATR U3
U 1 1 59631B31
P 2000 1250
F 0 "U3" H 2000 1325 60  0000 C CNN
F 1 "RB496EATR" H 2000 725 60  0000 C CNN
F 2 "TO_SOT_Packages_SMD:SOT-23-5_HandSoldering" H 2000 1250 60  0001 C CNN
F 3 "" H 2000 1250 60  0001 C CNN
	1    2000 1250
	1    0    0    -1  
$EndComp
$Comp
L RB496EATR U6
U 1 1 59631C99
P 5850 1000
F 0 "U6" H 5850 1075 60  0000 C CNN
F 1 "RB496EATR" H 5850 475 60  0000 C CNN
F 2 "TO_SOT_Packages_SMD:SOT-23-5_HandSoldering" H 5850 1000 60  0001 C CNN
F 3 "" H 5850 1000 60  0001 C CNN
	1    5850 1000
	1    0    0    -1  
$EndComp
$Comp
L RB496EATR U2
U 1 1 59631CCA
P 1950 4000
F 0 "U2" H 1950 4075 60  0000 C CNN
F 1 "RB496EATR" H 1950 3475 60  0000 C CNN
F 2 "TO_SOT_Packages_SMD:SOT-23-5_HandSoldering" H 1950 4000 60  0001 C CNN
F 3 "" H 1950 4000 60  0001 C CNN
	1    1950 4000
	1    0    0    -1  
$EndComp
$Comp
L RB496EATR U7
U 1 1 59631D11
P 6650 4500
F 0 "U7" H 6650 4575 60  0000 C CNN
F 1 "RB496EATR" H 6650 3975 60  0000 C CNN
F 2 "TO_SOT_Packages_SMD:SOT-23-5_HandSoldering" H 6650 4500 60  0001 C CNN
F 3 "" H 6650 4500 60  0001 C CNN
	1    6650 4500
	1    0    0    -1  
$EndComp
Text GLabel 7950 5800 3    60   Input ~ 0
AGND
Text GLabel 6400 4800 0    60   Input ~ 0
-15V
Text GLabel 6100 1100 2    60   Input ~ 0
+15V
Text GLabel 1700 4300 0    60   Input ~ 0
-5V_R
Text GLabel 3100 2200 2    60   Input ~ 0
AIN0
Text GLabel 7800 1950 2    60   Input ~ 0
AIN1
Text GLabel 10500 5300 2    60   Input ~ 0
AIN3
Text GLabel 1400 2100 0    60   Input ~ 0
VM00
Text GLabel 5000 1850 0    60   Input ~ 0
VM01
Text GLabel 1300 4800 0    60   Input ~ 0
VM02
Text GLabel 6300 5300 0    60   Input ~ 0
VM03
$Comp
L R R17
U 1 1 5963265D
P 6450 5300
F 0 "R17" V 6530 5300 50  0000 C CNN
F 1 "10K" V 6450 5300 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 6380 5300 50  0001 C CNN
F 3 "" H 6450 5300 50  0001 C CNN
	1    6450 5300
	0    1    1    0   
$EndComp
Text GLabel 2450 1900 2    60   Input ~ 0
+15V
Text GLabel 2450 2500 2    60   Input ~ 0
-15V
Text GLabel 7100 2250 2    60   Input ~ 0
-15V
Text GLabel 7100 1650 2    60   Input ~ 0
+15V
$Comp
L R R12
U 1 1 5963319D
P 1550 2100
F 0 "R12" V 1630 2100 50  0000 C CNN
F 1 "120" V 1550 2100 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 1480 2100 50  0001 C CNN
F 3 "" H 1550 2100 50  0001 C CNN
	1    1550 2100
	0    1    1    0   
$EndComp
Text GLabel 1700 1550 0    60   Input ~ 0
AGND
Text GLabel 2350 1350 2    60   Input ~ 0
+5V_R
Text GLabel 2200 4100 2    60   Input ~ 0
AGND
Text GLabel 6900 4600 2    60   Input ~ 0
AGND
Text GLabel 5600 1300 0    60   Input ~ 0
AGND
$Comp
L R R15
U 1 1 5962F3FA
P 5150 1850
F 0 "R15" V 5230 1850 50  0000 C CNN
F 1 "10K" V 5150 1850 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 5080 1850 50  0001 C CNN
F 3 "" H 5150 1850 50  0001 C CNN
	1    5150 1850
	0    1    1    0   
$EndComp
$Comp
L R R16
U 1 1 5962F822
P 5650 1850
F 0 "R16" V 5730 1850 50  0000 C CNN
F 1 "9.76K" V 5650 1850 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 5580 1850 50  0001 C CNN
F 3 "" H 5650 1850 50  0001 C CNN
	1    5650 1850
	0    1    1    0   
$EndComp
$Comp
L R R18
U 1 1 5962F8AF
P 6650 2100
F 0 "R18" V 6730 2100 50  0000 C CNN
F 1 "10K" V 6650 2100 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 6580 2100 50  0001 C CNN
F 3 "" H 6650 2100 50  0001 C CNN
	1    6650 2100
	-1   0    0    1   
$EndComp
Text GLabel 6650 2250 3    60   Input ~ 0
AGND
Text GLabel 2450 5200 2    60   Input ~ 0
-15V
Text GLabel 2450 4600 2    60   Input ~ 0
+15V
Text GLabel 4300 4500 2    60   Input ~ 0
+15V
Text GLabel 8350 5100 2    60   Input ~ 0
+15V
Text GLabel 9800 5000 2    60   Input ~ 0
+15V
Text GLabel 4300 5100 2    60   Input ~ 0
-15V
Text GLabel 8350 5700 2    60   Input ~ 0
-15V
Text GLabel 9800 5600 2    60   Input ~ 0
-15V
$Comp
L R R13
U 1 1 59632BCF
P 3800 4900
F 0 "R13" V 3880 4900 50  0000 C CNN
F 1 "768" V 3800 4900 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 3730 4900 50  0001 C CNN
F 3 "" H 3800 4900 50  0001 C CNN
	1    3800 4900
	0    1    1    0   
$EndComp
$Comp
L R R14
U 1 1 59632EE4
P 4350 5300
F 0 "R14" V 4430 5300 50  0000 C CNN
F 1 "1K" V 4350 5300 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 4280 5300 50  0001 C CNN
F 3 "" H 4350 5300 50  0001 C CNN
	1    4350 5300
	0    1    1    0   
$EndComp
Text GLabel 5050 4800 2    60   Input ~ 0
AIN2
$Comp
L R R11
U 1 1 59633F6A
P 1450 4800
F 0 "R11" V 1530 4800 50  0000 C CNN
F 1 "120" V 1450 4800 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 1380 4800 50  0001 C CNN
F 3 "" H 1450 4800 50  0001 C CNN
	1    1450 4800
	0    1    1    0   
$EndComp
$Comp
L R R21
U 1 1 59635907
P 9200 5400
F 0 "R21" V 9280 5400 50  0000 C CNN
F 1 "1K" V 9200 5400 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 9130 5400 50  0001 C CNN
F 3 "" H 9200 5400 50  0001 C CNN
	1    9200 5400
	0    1    1    0   
$EndComp
$Comp
L R R22
U 1 1 59635A67
P 9850 5850
F 0 "R22" V 9930 5850 50  0000 C CNN
F 1 "1K" V 9850 5850 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 9780 5850 50  0001 C CNN
F 3 "" H 9850 5850 50  0001 C CNN
	1    9850 5850
	0    1    1    0   
$EndComp
$Comp
L R R19
U 1 1 59635DCB
P 7050 5300
F 0 "R19" V 7130 5300 50  0000 C CNN
F 1 "9.76K" V 7050 5300 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 6980 5300 50  0001 C CNN
F 3 "" H 7050 5300 50  0001 C CNN
	1    7050 5300
	0    1    1    0   
$EndComp
$Comp
L R R20
U 1 1 59635F7D
P 7950 5650
F 0 "R20" V 8030 5650 50  0000 C CNN
F 1 "10K" V 7950 5650 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 7880 5650 50  0001 C CNN
F 3 "" H 7950 5650 50  0001 C CNN
	1    7950 5650
	-1   0    0    1   
$EndComp
Text GLabel 9600 5200 0    60   Input ~ 0
AGND
Text GLabel 4100 4700 0    60   Input ~ 0
AGND
Text Notes 1350 900  0    118  ~ 0
+5V Buffer Circuit
Text Notes 5050 850  0    118  ~ 0
+15V Buffer Circuit
Text Notes 1400 3650 0    118  ~ 0
-5V Buffer and Inverting Circuit
Text Notes 6550 4200 0    118  ~ 0
-15V Buffer and Inverting Circuit
Text Notes 8550 1000 0    118  ~ 0
5V DC Fan with Thermal\nVoltage Control Circuit
Text Label 2000 2100 2    60   ~ 0
+5_OVP
Text Label 6650 1850 0    40   ~ 0
+15_DIV
Text Label 5350 1800 0    40   ~ 0
+15_OVP
Text Label 8900 2200 1    40   ~ 0
VGS_FAN
Text Label 10150 1800 1    40   ~ 0
FAN_GND
Text Label 1750 4800 0    40   ~ 0
-5_OVP
Text Label 2150 5350 0    40   ~ 0
-5_BUFF
Text Label 4050 5050 3    40   ~ 0
-5_INV
Text Label 6700 5200 0    40   ~ 0
-15_OVP
Text Label 7850 5300 0    40   ~ 0
-15_DIV
Text Label 8250 5850 0    40   ~ 0
-15_BUFF
Text Label 9500 5550 3    40   ~ 0
-15_INV
$Comp
L POT RV1
U 1 1 596D3156
P 3350 4900
F 0 "RV1" V 3250 4900 50  0000 C CNN
F 1 "500" V 3350 4900 50  0000 C CNN
F 2 "RLS_CustomFootprints:Potentiometer_Trimmer_Bourns_PVG5A" H 3350 4900 50  0001 C CNN
F 3 "" H 3350 4900 50  0001 C CNN
	1    3350 4900
	0    1    1    0   
$EndComp
$Comp
L POT RV2
U 1 1 596D31E1
P 6250 1850
F 0 "RV2" V 6150 1850 50  0000 C CNN
F 1 "500" V 6250 1850 50  0000 C CNN
F 2 "RLS_CustomFootprints:Potentiometer_Trimmer_Bourns_PVG5A" H 6250 1850 50  0001 C CNN
F 3 "" H 6250 1850 50  0001 C CNN
	1    6250 1850
	0    -1   1    0   
$EndComp
$Comp
L POT RV3
U 1 1 596D3280
P 7500 5300
F 0 "RV3" V 7400 5300 50  0000 C CNN
F 1 "500" V 7500 5300 50  0000 C CNN
F 2 "RLS_CustomFootprints:Potentiometer_Trimmer_Bourns_PVG5A" H 7500 5300 50  0001 C CNN
F 3 "" H 7500 5300 50  0001 C CNN
	1    7500 5300
	0    1    1    0   
$EndComp
Wire Wire Line
	9100 2200 8900 2200
Wire Wire Line
	8900 1850 8900 2500
Connection ~ 8900 2200
Wire Wire Line
	9400 2900 9400 2350
Wire Wire Line
	8900 2900 9400 2900
Wire Wire Line
	8900 2900 8900 2800
Wire Wire Line
	8900 1550 8900 1350
Wire Wire Line
	8900 1350 10150 1350
Wire Wire Line
	9700 1350 9700 1450
Wire Wire Line
	9400 1950 9400 1800
Connection ~ 9700 1350
Wire Wire Line
	9700 1750 9700 1800
Wire Wire Line
	9400 1800 10150 1800
Wire Wire Line
	10150 1800 10150 1450
Connection ~ 9700 1800
Wire Wire Line
	9300 1200 9300 1350
Connection ~ 9300 1350
Wire Wire Line
	9150 3050 9150 2900
Connection ~ 9150 2900
Wire Wire Line
	1700 2100 2250 2100
Wire Wire Line
	2250 2300 2150 2300
Wire Wire Line
	2150 2300 2150 2700
Wire Wire Line
	2150 2700 3000 2700
Wire Wire Line
	3000 2700 3000 2200
Wire Wire Line
	2850 2200 3100 2200
Wire Wire Line
	1750 1550 1700 1550
Wire Wire Line
	2250 1350 2350 1350
Wire Wire Line
	1750 1350 1350 1350
Wire Wire Line
	1350 1350 1350 1950
Wire Wire Line
	1350 1950 2350 1950
Wire Wire Line
	2000 1950 2000 2100
Connection ~ 2000 2100
Wire Wire Line
	2250 1550 2350 1550
Wire Wire Line
	2350 1550 2350 1950
Connection ~ 2000 1950
Wire Wire Line
	7500 1950 7800 1950
Wire Wire Line
	7700 1950 7700 2400
Wire Wire Line
	7700 2400 6800 2400
Wire Wire Line
	6800 2400 6800 2050
Wire Wire Line
	6800 2050 6900 2050
Connection ~ 3000 2200
Connection ~ 7700 1950
Wire Wire Line
	6100 1300 6200 1300
Wire Wire Line
	6200 1300 6200 1600
Wire Wire Line
	6200 1600 5250 1600
Wire Wire Line
	5250 1600 5250 1100
Wire Wire Line
	5250 1100 5600 1100
Wire Wire Line
	6500 1850 6900 1850
Wire Wire Line
	6650 1850 6650 1950
Connection ~ 6650 1850
Wire Wire Line
	5300 1850 5500 1850
Wire Wire Line
	5350 1850 5350 1600
Connection ~ 5350 1600
Connection ~ 5350 1850
Wire Wire Line
	2250 5000 2150 5000
Wire Wire Line
	2150 5000 2150 5350
Wire Wire Line
	2150 5350 3000 5350
Wire Wire Line
	3950 4900 4100 4900
Wire Wire Line
	4050 4900 4050 5300
Wire Wire Line
	4050 5300 4200 5300
Connection ~ 4050 4900
Wire Wire Line
	4500 5300 4900 5300
Wire Wire Line
	4900 5300 4900 4800
Wire Wire Line
	4700 4800 5050 4800
Connection ~ 4900 4800
Wire Wire Line
	2200 4300 2300 4300
Wire Wire Line
	2300 4300 2300 4600
Wire Wire Line
	2300 4600 1300 4600
Wire Wire Line
	1300 4600 1300 4100
Wire Wire Line
	1600 4800 2250 4800
Wire Wire Line
	1700 4800 1700 4600
Connection ~ 1700 4600
Connection ~ 1700 4800
Wire Wire Line
	1300 4100 1700 4100
Wire Wire Line
	8150 5500 8100 5500
Wire Wire Line
	8100 5500 8100 5850
Wire Wire Line
	8100 5850 8900 5850
Wire Wire Line
	8900 5850 8900 5400
Wire Wire Line
	8750 5400 9050 5400
Wire Wire Line
	9350 5400 9600 5400
Connection ~ 8900 5400
Wire Wire Line
	9500 5400 9500 5850
Wire Wire Line
	9500 5850 9700 5850
Connection ~ 9500 5400
Wire Wire Line
	10000 5850 10350 5850
Wire Wire Line
	10350 5850 10350 5300
Wire Wire Line
	10200 5300 10500 5300
Connection ~ 10350 5300
Wire Wire Line
	7750 5300 8150 5300
Wire Wire Line
	7950 5300 7950 5500
Connection ~ 7950 5300
Wire Wire Line
	6400 4600 6050 4600
Wire Wire Line
	6050 4600 6050 5100
Wire Wire Line
	6050 5100 7000 5100
Wire Wire Line
	7000 5100 7000 4800
Wire Wire Line
	7000 4800 6900 4800
Wire Wire Line
	6600 5300 6900 5300
Wire Wire Line
	6700 5300 6700 5100
Connection ~ 6700 5100
Connection ~ 6700 5300
Wire Wire Line
	5800 1850 6100 1850
Wire Wire Line
	6250 2000 6250 2050
Wire Wire Line
	6250 2050 6500 2050
Wire Wire Line
	6500 2050 6500 1850
NoConn ~ 6400 1850
Wire Wire Line
	7200 5300 7350 5300
Wire Wire Line
	7500 5450 7500 5550
Wire Wire Line
	7500 5550 7750 5550
Wire Wire Line
	7750 5550 7750 5300
NoConn ~ 7650 5300
Wire Wire Line
	3650 4900 3600 4900
Wire Wire Line
	3600 4900 3600 5150
Wire Wire Line
	3600 5150 3350 5150
Wire Wire Line
	3350 5150 3350 5050
Wire Wire Line
	3200 4900 2850 4900
Wire Wire Line
	3000 5350 3000 4900
Connection ~ 3000 4900
NoConn ~ 3500 4900
Text Label 3500 5150 3    60   ~ 0
-5_ADJ
Text Label 6000 1850 3    60   ~ 0
+15_ADJ
Text Label 7300 5300 1    60   ~ 0
-15_ADJ
$EndSCHEMATC
