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
P 4150 2100
F 0 "R11" V 4230 2100 50  0000 C CNN
F 1 "20K" V 4150 2100 50  0000 C CNN
F 2 "" V 4080 2100 50  0001 C CNN
F 3 "" H 4150 2100 50  0001 C CNN
	1    4150 2100
	0    -1   -1   0   
$EndComp
$Comp
L R R12
U 1 1 594D6CB0
P 4400 2250
F 0 "R12" V 4480 2250 50  0000 C CNN
F 1 "10K" V 4400 2250 50  0000 C CNN
F 2 "" V 4330 2250 50  0001 C CNN
F 3 "" H 4400 2250 50  0001 C CNN
	1    4400 2250
	1    0    0    -1  
$EndComp
$Comp
L R R13
U 1 1 594D6CC9
P 5050 2100
F 0 "R13" V 5130 2100 50  0000 C CNN
F 1 "20K" V 5050 2100 50  0000 C CNN
F 2 "" V 4980 2100 50  0001 C CNN
F 3 "" H 5050 2100 50  0001 C CNN
	1    5050 2100
	0    -1   -1   0   
$EndComp
$Comp
L R R14
U 1 1 594D6CE4
P 5300 2250
F 0 "R14" V 5380 2250 50  0000 C CNN
F 1 "10K" V 5300 2250 50  0000 C CNN
F 2 "" V 5230 2250 50  0001 C CNN
F 3 "" H 5300 2250 50  0001 C CNN
	1    5300 2250
	1    0    0    -1  
$EndComp
$Comp
L R R15
U 1 1 594D6D29
P 5950 2100
F 0 "R15" V 6030 2100 50  0000 C CNN
F 1 "10K" V 5950 2100 50  0000 C CNN
F 2 "" V 5880 2100 50  0001 C CNN
F 3 "" H 5950 2100 50  0001 C CNN
	1    5950 2100
	0    -1   -1   0   
$EndComp
$Comp
L R R16
U 1 1 594D6D48
P 6200 2250
F 0 "R16" V 6280 2250 50  0000 C CNN
F 1 "10K" V 6200 2250 50  0000 C CNN
F 2 "" V 6130 2250 50  0001 C CNN
F 3 "" H 6200 2250 50  0001 C CNN
	1    6200 2250
	1    0    0    -1  
$EndComp
Wire Wire Line
	4300 2100 4400 2100
Wire Wire Line
	5200 2100 5300 2100
Wire Wire Line
	6100 2100 6200 2100
Text GLabel 5800 2100 0    60   Input ~ 0
VM01
Text GLabel 4900 2100 0    60   Input ~ 0
VM02
Text GLabel 4000 2100 0    60   Input ~ 0
VM03
Text GLabel 4400 2000 1    60   Input ~ 0
VD03
Text GLabel 5300 2000 1    60   Input ~ 0
VD02
Text GLabel 6200 2000 1    60   Input ~ 0
VD01
Wire Wire Line
	5300 2100 5300 2000
Wire Wire Line
	6200 2100 6200 2000
Wire Wire Line
	4400 2100 4400 2000
Wire Wire Line
	4400 2400 4400 2500
Wire Wire Line
	5300 2400 5300 2500
Wire Wire Line
	6200 2400 6200 2500
Text GLabel 6200 2500 3    60   Input ~ 0
AGND
Text GLabel 5300 2500 3    60   Input ~ 0
AGND
Text GLabel 4400 2500 3    60   Input ~ 0
AGND
$EndSCHEMATC
