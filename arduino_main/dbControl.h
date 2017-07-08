/******************************************************************************
  dbControl.h
  This header file contains code that is common to all daughterboards
  that are part of the Remote Lab System at the University of
  Washington Bothell. See dbControl.cpp for implementation.
  This code is designed to run on an Arduino Mega 2560.
  
  Created by Ellery Walsh, March 2016
  Reseased into the public domain.
******************************************************************************/

#ifndef dbControl_h
#define dbControl_h

#include "Arduino.h"

class DBControl {
  public: 
  void serialControl();
  void configureDaughterboardPins();
  boolean safetyCheck();
  void readBoardID();
  void configureBoardIdPins();
  void shutDownRegs();
  
  private:
  // Arduino Pins used for reading Board ID

  //Changed array to byte array as int array is too big for arduino pins
  const byte boardIdPins[8] = {A7, A6, A5, A4, A3, A2, A1, A0};
  int boardIdPinState[8];
};

#endif
