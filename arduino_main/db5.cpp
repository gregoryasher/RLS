/******************************************************************************
	db5.h
	This implementation file contains code for Daugherboard 5,
	part of the Remote Lab System at the University of
	Washington Bothell. See db5.h.
	This code is designed to run on an Arduino Mega 2560.
	
	Created by Ellery Walsh, March 2016
	Reseased into the public domain.
******************************************************************************/

#include "Arduino.h"
#include "db5.h"

//set up connections between arduino and switches
//R1
const int switch2_In4 = 23;
//R2
const int switch2_In3 = 25;
//R3
const int switch1_In1 = 26;
//C1
const int switch2_In1 = 22;
//C2
const int switch2_In2 = 24;

// set up variables used for parsing input from user interface
int top_resistor = 0;
int bottom_resistor = 0;
int capacitor = 0;

void DB5::configurePins() {
  pinMode(switch2_In4, OUTPUT); //R1
  pinMode(switch2_In3, OUTPUT); //R2
  pinMode(switch1_In1, OUTPUT); //R3
  pinMode(switch2_In1, OUTPUT); //C1
  pinMode(switch2_In2, OUTPUT); //C2
}

void DB5::execute(String Board_5_Serial) {
  // variables used for parsing input from interface
  // the default message is board_5,1,1,1
  top_resistor    = Board_5_Serial.substring(8,9).toInt(); //1
  bottom_resistor = Board_5_Serial.substring(10,11).toInt(); //1
  capacitor       = Board_5_Serial.substring(12,13).toInt(); //0
  
  // State of top resistor
  if(top_resistor == 0) {
    digitalWrite(switch2_In4, HIGH);
    digitalWrite(switch2_In3, LOW);
  }
  else if (top_resistor == 1) {
    digitalWrite(switch2_In4, LOW);
    digitalWrite(switch2_In3, HIGH);
  }
  
  
  // State of bottom resistor
  if(bottom_resistor == 0) {
    digitalWrite(switch1_In1, LOW);
  }
  else if (bottom_resistor == 1) {
    digitalWrite(switch1_In1, HIGH);
  }

  
  // State of capacitor
  if(capacitor == 0) {
    digitalWrite(switch2_In1, LOW);
    digitalWrite(switch2_In2, HIGH);
  }
  else if (capacitor == 1) {
    digitalWrite(switch2_In1, HIGH);
    digitalWrite(switch2_In2, LOW);
  }
}


