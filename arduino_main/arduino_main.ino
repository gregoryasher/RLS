 /******************************************************************************
  arduino_main.ino
  This is the main Arduino code that calls all libraries
  needed to run the Remote Lab System project for the
  Universtiy of Washington Bothell.
  This code is designed to run on an Arduino Mega 2560.

  Released into the public domain.
******************************************************************************/

#include "dbControl.h"
//#include "db1.h"
//#include "db2.h"
#include "db3.h"
#include "db4.h"
#include "db5.h"
#include "db6.h"
#include "db7.h"

// instantiate board controller object
DBControl boardController;

//unsigned long used for reducing error message spam
unsigned long lastMsg = 1;

// setup runs once when Arduino is powered on
void setup() {
  Serial.begin(9600);
  Serial.flush();

  //configures the initial boardId and daughterboard pins 
  boardController.configureBoardIdPins();
  boardController.configureDaughterboardPins();

  //shuts down regulators on setup
  boardController.shutDownRegs(); 
}

// the loop routine runs over and over again forever
void loop() {
  boardController.serialControl();

  //if statement that runs safety check. If no board is 
  //connected, print "00000000" to indicate that no board
  //is connected and shut down all regulators
  if ( !(boardController.safetyCheck()) ) {
    if ((millis() - lastMsg) > 2000) {
      Serial.println("00000000");
      lastMsg = millis();
    }
  }
}


