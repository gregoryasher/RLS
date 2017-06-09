/******************************************************************************
	db3.h
	This header file contains code for Daugherboard 3,
	part of the Remote Lab System at the University of
	Washington Bothell. See db3.cpp for implementation.
	This code is designed to run on an Arduino Mega 2560.
	
	Created by Ellery Walsh, April 2016
	Reseased into the public domain.
******************************************************************************/

// For Daughterboard 3, the Software I2C library is needed
// see reference at https://todbot.com/blog/2010/09/25/softi2cmaster-add-i2c-to-any-arduino-pins/
#include "SoftI2CMaster.h"

#ifndef db3_h
#define db3_h

#include "Arduino.h"

class DB3 {
	public: 
  void execute(String);
  void configurePins();
  
	private:
	//set up connection between arduino and switch
	const int switch_In1 = 28;

	//set up connections between arduino and digital pots
	const byte pot1_sdaPin =  22;
	const byte pot1_sclPin =  23;
	const int  pot1_address = 24;

	const byte pot2_sdaPin =  25;
	const byte pot2_sclPin =  26;
	const int  pot2_address = 27;
	
  // variables used for parsing input from user interface
  int r2_state;  // top potentiometer
  int r3_state;  // bottom potentiometer

};

#endif
