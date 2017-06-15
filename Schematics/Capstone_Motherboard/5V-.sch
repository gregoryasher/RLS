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
Sheet 3 4
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
L LM337T U10
U 1 1 56BEBDA2
P 4100 3300
F 0 "U10" H 3900 3100 50  0000 C CNN
F 1 "LM337T" H 4100 3100 50  0000 L CNN
F 2 "TO_SOT_Packages_THT:TO-220_Neutral123_Horizontal" H 4100 3200 50  0000 C CIN
F 3 "" H 4100 3300 50  0000 C CNN
	1    4100 3300
	1    0    0    -1  
$EndComp
Text GLabel 3050 3350 0    47   Input ~ 0
15V-
Text GLabel 5150 3350 2    47   Input ~ 0
5V-
$Comp
L CP1 C38
U 1 1 56BED04F
P 5100 3050
F 0 "C38" H 5125 3150 50  0000 L CNN
F 1 "10uf" H 5125 2950 50  0000 L CNN
F 2 "Capacitors_SMD:c_elec_4x5.8" H 5100 3050 50  0001 C CNN
F 3 "" H 5100 3050 50  0000 C CNN
	1    5100 3050
	1    0    0    -1  
$EndComp
$Comp
L R R17
U 1 1 56BED091
P 4700 3050
F 0 "R17" V 4780 3050 50  0000 C CNN
F 1 "R" V 4700 3050 50  0000 C CNN
F 2 "Resistors_SMD:R_1206" V 4630 3050 50  0001 C CNN
F 3 "" H 4700 3050 50  0000 C CNN
	1    4700 3050
	1    0    0    -1  
$EndComp
$Comp
L POT RV1
U 1 1 56BED0E7
P 4700 2600
F 0 "RV1" H 4700 2500 50  0000 C CNN
F 1 "POT" H 4700 2600 50  0000 C CNN
F 2 "Potentiometers:Potentiometer_Bourns_3296X_3-8Zoll_Inline_ScrewFront" H 4700 2600 50  0001 C CNN
F 3 "" H 4700 2600 50  0000 C CNN
	1    4700 2600
	-1   0    0    1   
$EndComp
$Comp
L GND #PWR030
U 1 1 56BED135
P 3050 2600
F 0 "#PWR030" H 3050 2350 50  0001 C CNN
F 1 "GND" H 3050 2450 50  0000 C CNN
F 2 "" H 3050 2600 50  0000 C CNN
F 3 "" H 3050 2600 50  0000 C CNN
	1    3050 2600
	1    0    0    -1  
$EndComp
$Comp
L CP1 C37
U 1 1 56BED15D
P 3500 2950
F 0 "C37" H 3525 3050 50  0000 L CNN
F 1 "1uf" H 3525 2850 50  0000 L CNN
F 2 "Capacitors_SMD:c_elec_4x5.8" H 3500 2950 50  0001 C CNN
F 3 "" H 3500 2950 50  0000 C CNN
	1    3500 2950
	1    0    0    -1  
$EndComp
Wire Wire Line
	3050 3350 3700 3350
Wire Wire Line
	3500 3100 3500 3350
Connection ~ 3500 3350
Wire Wire Line
	4500 3350 5150 3350
Wire Wire Line
	4700 3200 4700 3350
Connection ~ 4700 3350
Wire Wire Line
	4100 3050 4100 2900
Wire Wire Line
	4100 2900 4700 2900
Wire Wire Line
	5100 2400 5100 2900
Wire Wire Line
	5100 2600 4950 2600
Wire Wire Line
	4700 2900 4700 2750
Wire Wire Line
	3050 2600 4200 2600
Wire Wire Line
	3500 2600 3500 2800
Wire Wire Line
	4200 2600 4200 2400
Wire Wire Line
	4200 2400 5100 2400
Connection ~ 3500 2600
Connection ~ 5100 3350
Connection ~ 5100 2600
Connection ~ 3050 2600
NoConn ~ 4450 2600
Wire Wire Line
	5100 3200 5100 3350
$EndSCHEMATC
