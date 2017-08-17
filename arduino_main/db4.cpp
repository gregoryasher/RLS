/******************************************************************************
	db4.cpp
	This implementation file contains code for Daugherboard 4,
	part of the Remote Lab System at the University of
	Washington Bothell. See db4.h.
	This code is designed to run on an Arduino Mega 2560.
	
	Created by Ellery Walsh, March 2016
	Reseased into the public domain.
******************************************************************************/

#include "Arduino.h"
#include "db4.h"

//set up connections between arduino and switches
// Note: resistor number matches UI picture and KiCad schematic
// Diode numbering matches UI picture but not KiCad schematic
const int switchU1_In1 = 30; //R4 = 1.5K
const int switchU1_In2 = 29; //R2 = 1K
const int switchU1_In3 = 28; //R3 = 0.5K
const int switchU1_In4 = 31; //R5 = 5K
const int switchU3_In1 = 22; //diode1 backwards
const int switchU3_In2 = 25; //diode2 backwards
const int switchU3_In3 = 24; //diode2 forwards
const int switchU3_In4 = 23; //diode1 forwards

// set up variables used for parsing input from user interface
int resistor;
int diode1; // this one is in parallel to resistor
int diode2; // this one is in series with resistor

void DB4::configurePins() {
  pinMode(switchU1_In1, OUTPUT); //R4 = 1.5K
  pinMode(switchU1_In2, OUTPUT); //R2 = 1K
  pinMode(switchU1_In3, OUTPUT); //R3 = 0.5K
  pinMode(switchU1_In4, OUTPUT); //R5 = 5K
  pinMode(switchU3_In1, OUTPUT); //diode1 backwards
  pinMode(switchU3_In2, OUTPUT); //diode2 backwards
  pinMode(switchU3_In3, OUTPUT); //diode2 forwards
  pinMode(switchU3_In4, OUTPUT); //diode1 forwards
  //Serial.println("Pins configured.");
}

void DB4::execute(String Board_4_Serial) {
	  // variables used for parsing input from interface
	  // the default message is board_4,1,1,1
  resistor = Board_4_Serial.substring(8,9).toInt();
  diode1 = Board_4_Serial.substring(10,11).toInt();
  diode2 = Board_4_Serial.substring(12,13).toInt();
  // State of resistor
  if (resistor == 1) { // R3 = 0.5K is in circuit
	  digitalWrite(switchU1_In1, HIGH);
	  digitalWrite(switchU1_In2, HIGH);
	  digitalWrite(switchU1_In3, LOW);
	  digitalWrite(switchU1_In4, HIGH);
  }
  else if (resistor == 2) { // R2 = 1K is in circuit
	  digitalWrite(switchU1_In1, HIGH);
	  digitalWrite(switchU1_In2, LOW);
	  digitalWrite(switchU1_In3, HIGH);
	  digitalWrite(switchU1_In4, HIGH);
  }
  else if (resistor == 3) { // R4 = 1.5K is in circuit
	  digitalWrite(switchU1_In1, LOW);
	  digitalWrite(switchU1_In2, HIGH);
	  digitalWrite(switchU1_In3, HIGH);
	  digitalWrite(switchU1_In4, HIGH);
  }
  else if (resistor == 4) { // R5 = 5K is in circuit
	  digitalWrite(switchU1_In1, HIGH);
	  digitalWrite(switchU1_In2, HIGH);
	  digitalWrite(switchU1_In3, HIGH);
	  digitalWrite(switchU1_In4, LOW);
  }
  
  
  // State of diode 1
  if (diode1 == 0) { //diode1 backwards
	  digitalWrite(switchU3_In1, LOW);
	  digitalWrite(switchU3_In4, HIGH);
  }
  else if (diode1 == 1) { //diode1 forwards
	  digitalWrite(switchU3_In1, HIGH);
	  digitalWrite(switchU3_In4, LOW);	  
  }
  
  
  // State of diode2
  if (diode2 == 0) { //diode2 backwards
	  digitalWrite(switchU3_In2, LOW);
	  digitalWrite(switchU3_In3, HIGH);	  
  }
  else if (diode2 == 1) { //diode2 forwards
	  digitalWrite(switchU3_In2, HIGH);
	  digitalWrite(switchU3_In3, LOW);	  
  }
}

