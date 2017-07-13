/******************************************************************************
  DigitalPot.cpp
  This implementation file contains implementation code for the digital 
  potentiometers.

  Created by Paolo Sebastian, July 2017
  Reseased into the public domain.
******************************************************************************/

#include "Arduino.h"
#include "DigitalPot.h"
#include <SPI.h>

/*********************************************
   Default constructor for digital pot.
**********************************************/
DigitalPot::DigitalPot() {};

/*********************************************
   Setters for required resistance 1.
**********************************************/
void DigitalPot::setRes1(int resistor1) {
  res1 = resistor1;
}

/*********************************************
   Setter for required resistance 2.
**********************************************/
void DigitalPot::setRes2(int resistor2) {
  res2 = resistor2;
}

/*********************************************
   Setter for required chip enable.
**********************************************/
void DigitalPot::setCS(byte chipsel) {
  chipSel = chipsel;
}

/*********************************************
   Writes the calculated resistor values to the 
   digital potentiometers.
**********************************************/
void DigitalPot::writeValues(byte shdn1, byte shdn2) {

  //shuts down regulators while writing to pots
  checkShutdowns(shdn1, shdn2);
  delay(100);

  //adjusts the wipers of both digital pots to 
  //the middle before writing
  digitalWrite(chipSel, LOW);
  SPI.transfer16(0x1802);
  SPI.transfer16(0x1802);
  digitalWrite(chipSel, HIGH);

  //writes the requested resistance to the pots
  digitalWrite(chipSel, LOW);
  SPI.transfer16(res1);
  SPI.transfer16(res2);
  digitalWrite(chipSel, HIGH); 
  
  delay(50);

  //turns on regulators once writing is complete
  digitalWrite(shdn1, HIGH);
  digitalWrite(shdn2, HIGH);
}

/*********************************************
   Checks to see if the redgulators need to be 
   shut down before writing to the digital
   potentiometers.
**********************************************/
void DigitalPot::checkShutdowns(byte shdn1, byte shdn2) {  
  if (shdn1 == HIGH) {
    digitalWrite(shdn1, LOW);
  }
  if (shdn2 == HIGH) {
    digitalWrite(shdn2, LOW);
  }
}

