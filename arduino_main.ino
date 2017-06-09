/******************************************************************************
  arduino_main.ino
  This is the main Arduino code that calls all libraries
  needed to run the Remote Lab System project for the 
  Universtiy of Washington Bothell. 
  This code is designed to run on an Arduino Mega 2560.
  
  Created by Ellery Walsh, March 2016
  Reseased into the public domain.
******************************************************************************/

// TODO:
// Need to include power regulator stuff from original code but updated for new motherboard
// check pin numbers of arduino mega analog write pins
// check signatures of functions inside all .h files to make sure no const, private, &, etc. are missing
// refactor helper methods in daughterboard execute functions?
// create keywords file to turn some function names orange in Arduino IDE (https://www.arduino.cc/en/Hacking/LibraryTutorial)
// consider making an interface that each DB object implements, so you can force each of them
//    to have an execute() method and a configurePins() method

#include <dbControl.h>
//#include <db1.h>
//#include <db2.h>
#include <db3.h>
#include <db4.h>
#include <db5.h>
#include <db6.h>
#include <db7.h>

// instantiate board controller object
DBControl boardController;

// setup runs once when Arduino is powered on
void setup() {
  Serial.begin(9600);  

  // Determine which board is plugged in 
  //TODO: TEST THE ORDER OF THESE LINES TO SEE IF IT MATTERS 
  
  boardController.configureDaughterboardPins();
  boardController.configureBoardIdPins();
  boardController.readBoardID();
  
  // Need to include power regulator stuff here later, but not now for testing a few boards only
  Serial.println("Finished Setup successfully.");
}

// the loop routine runs over and over again forever
void loop() {
  boardController.serialControl();
  boardController.safetyCheck();   
}


