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
Sheet 2 7
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
L R R11
U 1 1 594D6C41
P 2100 1550
F 0 "R11" V 2180 1550 50  0000 C CNN
F 1 "20K" V 2100 1550 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 2030 1550 50  0001 C CNN
F 3 "" H 2100 1550 50  0001 C CNN
	1    2100 1550
	0    -1   -1   0   
$EndComp
$Comp
L R R12
U 1 1 594D6CB0
P 2350 1700
F 0 "R12" V 2430 1700 50  0000 C CNN
F 1 "10K" V 2350 1700 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 2280 1700 50  0001 C CNN
F 3 "" H 2350 1700 50  0001 C CNN
	1    2350 1700
	1    0    0    -1  
$EndComp
$Comp
L R R13
U 1 1 594D6CC9
P 3000 1550
F 0 "R13" V 3080 1550 50  0000 C CNN
F 1 "20K" V 3000 1550 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 2930 1550 50  0001 C CNN
F 3 "" H 3000 1550 50  0001 C CNN
	1    3000 1550
	0    -1   -1   0   
$EndComp
$Comp
L R R14
U 1 1 594D6CE4
P 3250 1700
F 0 "R14" V 3330 1700 50  0000 C CNN
F 1 "10K" V 3250 1700 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 3180 1700 50  0001 C CNN
F 3 "" H 3250 1700 50  0001 C CNN
	1    3250 1700
	1    0    0    -1  
$EndComp
$Comp
L R R15
U 1 1 594D6D29
P 3900 1550
F 0 "R15" V 3980 1550 50  0000 C CNN
F 1 "10K" V 3900 1550 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 3830 1550 50  0001 C CNN
F 3 "" H 3900 1550 50  0001 C CNN
	1    3900 1550
	0    -1   -1   0   
$EndComp
$Comp
L R R16
U 1 1 594D6D48
P 4150 1700
F 0 "R16" V 4230 1700 50  0000 C CNN
F 1 "10K" V 4150 1700 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 4080 1700 50  0001 C CNN
F 3 "" H 4150 1700 50  0001 C CNN
	1    4150 1700
	1    0    0    -1  
$EndComp
Text GLabel 3750 1550 0    60   Input ~ 0
VM01
Text GLabel 2850 1550 0    60   Input ~ 0
VM02
Text GLabel 1950 1550 0    60   Input ~ 0
VM03
Text GLabel 2350 1450 1    60   Input ~ 0
VD03
Text GLabel 3250 1450 1    60   Input ~ 0
VD02
Text GLabel 4150 1450 1    60   Input ~ 0
VD01
Text GLabel 4150 1950 3    60   Input ~ 0
AGND
Text GLabel 3250 1950 3    60   Input ~ 0
AGND
Text GLabel 2350 1950 3    60   Input ~ 0
AGND
$Comp
L BS170 Q1
U 1 1 595B0816
P 7200 2950
F 0 "Q1" H 7400 3025 50  0000 L CNN
F 1 "BS170" H 7400 2950 50  0000 L CNN
F 2 "TO_SOT_Packages_SMD:SOT-23" H 7400 2875 50  0001 L CIN
F 3 "" H 7200 2950 50  0001 L CNN
	1    7200 2950
	1    0    0    -1  
$EndComp
$Comp
L R R29
U 1 1 595B0B7F
P 6800 3450
F 0 "R29" V 6880 3450 50  0000 C CNN
F 1 "1K" V 6800 3450 50  0000 C CNN
F 2 "Resistors_SMD:R_1206_HandSoldering" V 6730 3450 50  0001 C CNN
F 3 "" H 6800 3450 50  0001 C CNN
	1    6800 3450
	1    0    0    -1  
$EndComp
$Comp
L Thermistor_NTC TH1
U 1 1 595B0BDC
P 6800 2500
F 0 "TH1" V 6625 2500 50  0000 C CNN
F 1 "3K_NTC" V 6925 2500 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0411_L9.9mm_D3.6mm_P12.70mm_Horizontal" H 6800 2550 50  0001 C CNN
F 3 "" H 6800 2550 50  0001 C CNN
	1    6800 2500
	1    0    0    -1  
$EndComp
$Comp
L CP1 C45
U 1 1 595B0C17
P 7600 2400
F 0 "C45" H 7625 2500 50  0000 L CNN
F 1 "10uF" H 7625 2300 50  0000 L CNN
F 2 "Capacitors_SMD:CP_Elec_4x5.3" H 7600 2400 50  0001 C CNN
F 3 "" H 7600 2400 50  0001 C CNN
	1    7600 2400
	1    0    0    -1  
$EndComp
$Comp
L CONN_01X03 J7
U 1 1 595B0EFE
P 8250 2150
F 0 "J7" H 8250 2350 50  0000 C CNN
F 1 "DC_Fan" V 8350 2150 50  0000 C CNN
F 2 "Pin_Headers:Pin_Header_Straight_1x03_Pitch2.54mm" H 8250 2150 50  0001 C CNN
F 3 "" H 8250 2150 50  0001 C CNN
	1    8250 2150
	1    0    0    1   
$EndComp
Wire Wire Line
	2250 1550 2350 1550
Wire Wire Line
	3150 1550 3250 1550
Wire Wire Line
	4050 1550 4150 1550
Wire Wire Line
	3250 1550 3250 1450
Wire Wire Line
	4150 1550 4150 1450
Wire Wire Line
	2350 1550 2350 1450
Wire Wire Line
	2350 1850 2350 1950
Wire Wire Line
	3250 1850 3250 1950
Wire Wire Line
	4150 1850 4150 1950
Wire Wire Line
	7000 3000 6800 3000
Wire Wire Line
	6800 2650 6800 3300
Connection ~ 6800 3000
Wire Wire Line
	7300 3150 7300 3700
Wire Wire Line
	7300 3700 6800 3700
Wire Wire Line
	6800 3700 6800 3600
Wire Wire Line
	6800 2350 6800 2150
Wire Wire Line
	6800 2150 8050 2150
Wire Wire Line
	7600 2150 7600 2250
Wire Wire Line
	7300 2750 7300 2600
Connection ~ 7600 2150
Wire Wire Line
	7600 2550 7600 2600
Wire Wire Line
	7300 2600 8050 2600
Wire Wire Line
	8050 2600 8050 2250
Connection ~ 7600 2600
Text GLabel 7050 3850 0    60   Input ~ 0
AGND
Text GLabel 7200 2000 2    60   Input ~ 0
+5V
Wire Wire Line
	7200 2000 7200 2150
Connection ~ 7200 2150
Wire Wire Line
	7050 3850 7050 3700
Connection ~ 7050 3700
NoConn ~ 8050 2050
$EndSCHEMATC
