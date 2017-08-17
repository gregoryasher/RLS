/******************************************************************************
	db6.h
	This header file contains code for Daugherboard 6,
	part of the Remote Lab System at the University of
	Washington Bothell. See db6.cpp for implementation.
	This code is designed to run on an Arduino Mega 2560.
	
	Created by Ellery Walsh, April 2016
	Reseased into the public domain.
******************************************************************************/


#ifndef db6_h
#define db6_h

#include "Arduino.h"

class DB6 {
	public: 
  void execute(String);
  void configurePins();
  
	private:

  
  // variables used for parsing input from user interface

};

#endif

