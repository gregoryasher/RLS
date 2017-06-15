EESchema Schematic File Version 2
LIBS:arduino_shieldsNCL
LIBS:Capstone_Motherboard-rescue
LIBS:interface
LIBS:Conn120
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
LIBS:digital-audio
LIBS:philips
LIBS:display
LIBS:cypress
LIBS:siliconi
LIBS:opto
LIBS:atmel
LIBS:contrib
LIBS:valves
LIBS:Capstone_Motherboard-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 4 4
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
L RELAY_2RT TSC_relay1
U 1 1 56C0FCFB
P 5450 2200
F 0 "TSC_relay1" H 5400 2600 50  0000 C CNN
F 1 "RELAY_2RT" H 5600 1700 50  0000 C CNN
F 2 "10MSOP:TSC" H 5450 2250 50  0001 C CNN
F 3 "" H 5450 2250 50  0000 C CNN
	1    5450 2200
	1    0    0    -1  
$EndComp
$Comp
L RELAY_2RT TSC_relay2
U 1 1 56C0FD2E
P 5450 3600
F 0 "TSC_relay2" H 5400 4000 50  0000 C CNN
F 1 "RELAY_2RT" H 5600 3100 50  0000 C CNN
F 2 "10MSOP:TSC" H 5450 3650 50  0001 C CNN
F 3 "" H 5450 3650 50  0000 C CNN
	1    5450 3600
	1    0    0    -1  
$EndComp
$Comp
L R R18
U 1 1 56C0FD58
P 4550 2100
F 0 "R18" V 4630 2100 50  0000 C CNN
F 1 "9M" V 4550 2100 50  0000 C CNN
F 2 "Resistors_ThroughHole:Resistor_Horizontal_RM10mm" V 4480 2100 50  0001 C CNN
F 3 "" H 4550 2100 50  0000 C CNN
	1    4550 2100
	0    1    -1   0   
$EndComp
$Comp
L R R19
U 1 1 56C0FD9D
P 4550 3500
F 0 "R19" V 4630 3500 50  0000 C CNN
F 1 "9M" V 4550 3500 50  0000 C CNN
F 2 "Resistors_ThroughHole:Resistor_Horizontal_RM10mm" V 4480 3500 50  0001 C CNN
F 3 "" H 4550 3500 50  0000 C CNN
	1    4550 3500
	0    1    -1   0   
$EndComp
$Comp
L C_Small 15pf1
U 1 1 56C0FDE3
P 4550 1900
F 0 "15pf1" H 4560 1970 50  0000 L CNN
F 1 "C_Small" H 4560 1820 50  0000 L CNN
F 2 "Capacitors_ThroughHole:C_Disc_D6_P5" H 4550 1900 50  0001 C CNN
F 3 "" H 4550 1900 50  0000 C CNN
	1    4550 1900
	0    1    -1   0   
$EndComp
$Comp
L C_Small 15pf2
U 1 1 56C0FE17
P 4550 3300
F 0 "15pf2" H 4560 3370 50  0000 L CNN
F 1 "C_Small" H 4560 3220 50  0000 L CNN
F 2 "Capacitors_ThroughHole:C_Disc_D6_P5" H 4550 3300 50  0001 C CNN
F 3 "" H 4550 3300 50  0000 C CNN
	1    4550 3300
	0    1    -1   0   
$EndComp
Text GLabel 3900 2100 0    47   Input ~ 0
Scope1+
Wire Wire Line
	4700 2100 5050 2100
Wire Wire Line
	4650 1900 4800 1900
Wire Wire Line
	4800 1900 4800 2100
Connection ~ 4800 2100
Wire Wire Line
	4700 3500 5050 3500
Wire Wire Line
	4650 3300 4800 3300
Wire Wire Line
	4800 3300 4800 3500
Connection ~ 4800 3500
Wire Wire Line
	4450 1900 4250 1900
Wire Wire Line
	4250 1900 4250 2100
Wire Wire Line
	3900 2100 4400 2100
Wire Wire Line
	5050 2300 4100 2300
Wire Wire Line
	4100 2300 4100 2100
Connection ~ 4250 2100
Wire Wire Line
	4450 3300 4250 3300
Wire Wire Line
	4250 3300 4250 3500
Wire Wire Line
	3900 3500 4400 3500
Wire Wire Line
	5050 3700 4100 3700
Wire Wire Line
	4100 3700 4100 3500
Connection ~ 4250 3500
Text GLabel 3900 3500 0    47   Input ~ 0
Scope2+
Connection ~ 4100 2100
Connection ~ 4100 3500
Text GLabel 6400 2300 3    47   Input ~ 0
Scope1-
Text GLabel 6400 3700 3    47   Input ~ 0
Scope2-
Wire Wire Line
	6400 3500 6400 3700
Wire Wire Line
	6400 2100 6400 2300
Wire Wire Line
	5850 2100 6300 2100
Wire Wire Line
	6300 3500 5850 3500
NoConn ~ 5850 2300
NoConn ~ 5850 3700
Text GLabel 5550 2550 2    47   Input ~ 0
Relay1
Text GLabel 5550 3950 2    47   Input ~ 0
Relay2
Text GLabel 5550 2450 2    47   Input ~ 0
5V+
Text GLabel 5550 3850 2    47   Input ~ 0
5V+
$Comp
L CONN_01X02 P10
U 1 1 57240285
P 6350 1900
F 0 "P10" H 6350 2050 50  0000 C CNN
F 1 "Vellemen_prob1" V 6450 1900 50  0000 C CNN
F 2 "Pin_Headers:Pin_Header_Straight_1x02" H 6350 1900 50  0001 C CNN
F 3 "" H 6350 1900 50  0000 C CNN
	1    6350 1900
	0    -1   -1   0   
$EndComp
$Comp
L CONN_01X02 P11
U 1 1 572402BD
P 6350 3300
F 0 "P11" H 6350 3450 50  0000 C CNN
F 1 "Vellemen_prob2" V 6450 3300 50  0000 C CNN
F 2 "Pin_Headers:Pin_Header_Straight_1x02" H 6350 3300 50  0001 C CNN
F 3 "" H 6350 3300 50  0000 C CNN
	1    6350 3300
	0    -1   -1   0   
$EndComp
$EndSCHEMATC
