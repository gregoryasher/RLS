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
   Mutator for chip select associated with set
   of digital potentiometers. 
**********************************************/
DigitalPot::DigitalPot(byte chipSelect) {
  chipSel = chipSelect;
}

/*********************************************
   Mutator for required resistance 1.
**********************************************/
void DigitalPot::setRes1(int resistor1) {
  res1 = resistor1;
}

/*********************************************
   Mutator for required resistance 2.
**********************************************/
void DigitalPot::setRes2(int resistor2) {
  res2 = resistor2;
}

/*********************************************
   Writes the calculated resistor values to the 
   digital potentiometers.
**********************************************/
void DigitalPot::writeValues(byte shdn1, byte shdn2) {

  //converts integer resistances to hex
  byte res1hex[] {res1 >> 8, res1};
  byte res2hex[] {res2 >> 8, res2};

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
  SPI.transfer16(res1hex);
  SPI.transfer16(res2hex);
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

