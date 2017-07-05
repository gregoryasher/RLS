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
Sheet 6 7
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
L LM337T U3
U 1 1 595958FD
P 4900 3650
AR Path="/5959581C/595958FD" Ref="U3"  Part="1" 
AR Path="/595AEFB9/595958FD" Ref="U13"  Part="1" 
F 0 "U3" H 4700 3450 50  0000 C CNN
F 1 "LM337T" H 4900 3450 50  0000 L CNN
F 2 "TO_SOT_Packages_THT:TO-220_Vertical" H 4900 3550 50  0001 C CIN
F 3 "" H 4900 3650 50  0001 C CNN
	1    4900 3650
	1    0    0    -1  
$EndComp
$Comp
L LM317T U2
U 1 1 59595954
P 4900 1750
AR Path="/5959581C/59595954" Ref="U2"  Part="1" 
AR Path="/595AEFB9/59595954" Ref="U12"  Part="1" 
F 0 "U2" H 4700 1950 50  0000 C CNN
F 1 "LM317T" H 4900 1950 50  0000 L CNN
F 2 "TO_SOT_Packages_THT:TO-220_Vertical" H 4900 1850 50  0001 C CIN
F 3 "" H 4900 1750 50  0001 C CNN
	1    4900 1750
	1    0    0    -1  
$EndComp
$Comp
L CP1 C41
U 1 1 59596610
P 4900 2450
AR Path="/5959581C/59596610" Ref="C41"  Part="1" 
AR Path="/595AEFB9/59596610" Ref="C41"  Part="1" 
F 0 "C41" H 4925 2550 50  0000 L CNN
F 1 "10uF" H 4925 2350 50  0000 L CNN
F 2 "" H 4900 2450 50  0001 C CNN
F 3 "" H 4900 2450 50  0001 C CNN
	1    4900 2450
	1    0    0    -1  
$EndComp
$Comp
L C C39
U 1 1 59596655
P 4300 2150
AR Path="/5959581C/59596655" Ref="C39"  Part="1" 
AR Path="/595AEFB9/59596655" Ref="C39"  Part="1" 
F 0 "C39" H 4325 2250 50  0000 L CNN
F 1 "0.1uF" H 4325 2050 50  0000 L CNN
F 2 "" H 4338 2000 50  0001 C CNN
F 3 "" H 4300 2150 50  0001 C CNN
	1    4300 2150
	1    0    0    -1  
$EndComp
$Comp
L R R25
U 1 1 59596672
P 5500 1950
AR Path="/5959581C/59596672" Ref="R25"  Part="1" 
AR Path="/595AEFB9/59596672" Ref="R25"  Part="1" 
F 0 "R25" V 5580 1950 50  0000 C CNN
F 1 "120" V 5500 1950 50  0000 C CNN
F 2 "" V 5430 1950 50  0001 C CNN
F 3 "" H 5500 1950 50  0001 C CNN
	1    5500 1950
	1    0    0    -1  
$EndComp
$Comp
L C C40
U 1 1 59596B6C
P 4300 3250
AR Path="/5959581C/59596B6C" Ref="C40"  Part="1" 
AR Path="/595AEFB9/59596B6C" Ref="C40"  Part="1" 
F 0 "C40" H 4325 3350 50  0000 L CNN
F 1 "0.1uF" H 4325 3150 50  0000 L CNN
F 2 "" H 4338 3100 50  0001 C CNN
F 3 "" H 4300 3250 50  0001 C CNN
	1    4300 3250
	1    0    0    -1  
$EndComp
Wire Wire Line
	4300 2300 4300 3100
Wire Wire Line
	4300 3400 4300 3700
Wire Wire Line
	4150 3700 4500 3700
Wire Wire Line
	4300 2000 4300 1700
Wire Wire Line
	4150 1700 4500 1700
Wire Wire Line
	4150 2700 5900 2700
Connection ~ 4300 2700
Text GLabel 4150 2700 0    60   Input ~ 0
AGND
$Comp
L CP1 C42
U 1 1 59597317
P 4900 2950
AR Path="/5959581C/59597317" Ref="C42"  Part="1" 
AR Path="/595AEFB9/59597317" Ref="C42"  Part="1" 
F 0 "C42" H 4925 3050 50  0000 L CNN
F 1 "10uF" H 4925 2850 50  0000 L CNN
F 2 "" H 4900 2950 50  0001 C CNN
F 3 "" H 4900 2950 50  0001 C CNN
	1    4900 2950
	1    0    0    -1  
$EndComp
Wire Wire Line
	4900 2600 4900 2800
Connection ~ 4900 2700
Wire Wire Line
	4900 2300 4900 2000
Wire Wire Line
	4900 3100 4900 3400
$Comp
L R R28
U 1 1 59597526
P 5500 3450
AR Path="/5959581C/59597526" Ref="R28"  Part="1" 
AR Path="/595AEFB9/59597526" Ref="R28"  Part="1" 
F 0 "R28" V 5580 3450 50  0000 C CNN
F 1 "120" V 5500 3450 50  0000 C CNN
F 2 "" V 5430 3450 50  0001 C CNN
F 3 "" H 5500 3450 50  0001 C CNN
	1    5500 3450
	1    0    0    -1  
$EndComp
Wire Wire Line
	5500 3600 5500 3700
Wire Wire Line
	5300 3700 6050 3700
Wire Wire Line
	5500 2550 5500 2850
Connection ~ 5500 2700
Wire Wire Line
	5500 1800 5500 1700
Wire Wire Line
	5300 1700 6050 1700
Wire Wire Line
	4900 2200 5650 2200
Connection ~ 4900 2200
Connection ~ 5500 2200
Wire Wire Line
	4900 3250 5650 3250
Connection ~ 4900 3250
Connection ~ 5500 3250
$Comp
L CP1 C43
U 1 1 59597677
P 5900 2200
AR Path="/5959581C/59597677" Ref="C43"  Part="1" 
AR Path="/595AEFB9/59597677" Ref="C43"  Part="1" 
F 0 "C43" H 5925 2300 50  0000 L CNN
F 1 "1uF" H 5925 2100 50  0000 L CNN
F 2 "" H 5900 2200 50  0001 C CNN
F 3 "" H 5900 2200 50  0001 C CNN
	1    5900 2200
	1    0    0    -1  
$EndComp
$Comp
L CP1 C44
U 1 1 595976C7
P 5900 3250
AR Path="/5959581C/595976C7" Ref="C44"  Part="1" 
AR Path="/595AEFB9/595976C7" Ref="C44"  Part="1" 
F 0 "C44" H 5925 3350 50  0000 L CNN
F 1 "1uF" H 5925 3150 50  0000 L CNN
F 2 "" H 5900 3250 50  0001 C CNN
F 3 "" H 5900 3250 50  0001 C CNN
	1    5900 3250
	1    0    0    -1  
$EndComp
Wire Wire Line
	5900 2350 5900 3100
Connection ~ 5900 2700
Wire Wire Line
	5900 1700 5900 2050
Connection ~ 5500 1700
Wire Wire Line
	5900 3700 5900 3400
Connection ~ 5500 3700
Connection ~ 5900 3700
Connection ~ 5900 1700
Connection ~ 4300 1700
Connection ~ 4300 3700
Text GLabel 6050 3700 2    60   Input ~ 0
-5V_R
Text GLabel 6050 1700 2    60   Input ~ 0
+5V_R
Text GLabel 4150 3700 0    60   Input ~ 0
-15V
Text GLabel 4150 1700 0    60   Input ~ 0
+15V
$Comp
L POT R26
U 1 1 595AB1DA
P 5500 2400
F 0 "R26" V 5325 2400 50  0000 C CNN
F 1 "1K_POT" V 5400 2400 50  0000 C CNN
F 2 "" H 5500 2400 50  0001 C CNN
F 3 "" H 5500 2400 50  0001 C CNN
	1    5500 2400
	1    0    0    -1  
$EndComp
$Comp
L POT R27
U 1 1 595AB23B
P 5500 3000
F 0 "R27" V 5325 3000 50  0000 C CNN
F 1 "1K_POT" V 5400 3000 50  0000 C CNN
F 2 "" H 5500 3000 50  0001 C CNN
F 3 "" H 5500 3000 50  0001 C CNN
	1    5500 3000
	1    0    0    -1  
$EndComp
Wire Wire Line
	5500 2100 5500 2200
Wire Wire Line
	5650 2200 5650 2400
Wire Wire Line
	5650 3250 5650 3000
Wire Wire Line
	5500 3300 5500 3250
NoConn ~ 5500 3150
NoConn ~ 5500 2250
$EndSCHEMATC
