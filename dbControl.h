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
  void safetyCheck();
  void readBoardID();
  String stringifyBoardID();
  void configureBoardIdPins();
  
  private:
  // Arduino Pins used for reading Board ID
  const int boardIdPins[8] = {51, 49, 47, 45, 43, 41, 53, 52};
  int boardIdPinState[8];
};

#endif
