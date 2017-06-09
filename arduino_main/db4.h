/******************************************************************************
	db4.h
	This header file contains code for Daugherboard 4,
	part of the Remote Lab System at the University of
	Washington Bothell. See db4.cpp for implementation.
	This code is designed to run on an Arduino Mega 2560.
	
	Created by Ellery Walsh, March 2016
	Reseased into the public domain.
******************************************************************************/

#ifndef db4_h
#define db4_h

#include "Arduino.h"

class DB4 {
	public: 
  void execute(String);
  void configurePins();
  
	private:
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
  
  // variables used for parsing input from user interface
  int resistor;
  int diode1; // this one is in parallel to resistor
  int diode2; // this one is in series with resistor
};

#endif
