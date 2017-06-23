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
LIBS:RLS-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 3 3
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
L ULN2803A U?
U 1 1 594DCBE5
P 4450 1900
F 0 "U?" H 4450 2425 50  0000 C CNN
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
Wire Wire Line
	4850 2400 5700 2400
Wire Wire Line
	5700 2400 5700 950 
Wire Wire Line
	5700 950  3350 950 
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
Text GLabel 4850 1600 2    60   Input ~ 0
RLY1
Text GLabel 4850 1700 2    60   Input ~ 0
RLY2
$EndSCHEMATC
