/******************************************************************************
  DigitalPot.h
  This header file contains code to control the negative and positive set of 
  digital potentiometers based on a daughterboard requested input voltage.
  
  Created by Paolo Sebastian, July 2017
  Reseased into the public domain.
******************************************************************************/

#ifndef DigitalPot_h
#define DigitalPot_h

#include "Arduino.h"

class DigitalPot {
  public:
  
  //sets the chip select pin for the appropriate set of positive or 
  //negative linear regulators 
  DigitalPot();

  void setRes1(int resistor1);
  void setRes2(int resistor2);
  void setCS(byte chipSel);

  //writes the requested resistor value to the set of potentiometers
  void writeValues(byte shdn1, byte shdn2);

  //shuts down regulators while writing to potentiometers
  void checkShutdowns(byte shdn1, byte shdn2);
  
  private:
  byte chipSel;
  int res1;
  int res2;
  boolean noVout1 = true;
  boolean noVout2 = true;
};

#endif
