/******************************************************************************
  PosReg.h
  This header file contains code to control the positive set of linear 
  regulators based on a daughterboard requested input voltage.
  
  Created by Paolo Sebastian, July 2017
  Reseased into the public domain.
******************************************************************************/

#ifndef PosReg_h
#define PosReg_h

#include "Arduino.h"
#include "DigitalPot.h"

class PosReg {
  public:

  //defaults second positive regulator to 0.0 if daughterboard does not
  //request an input voltage for it
  PosReg(double volt1, double volt2 = 0.0);
  
  void setV1(double volt1);
  void setV2(double volt2);

  //calculates required digital potentiometer values for the requested
  //input voltages and sets the digital potentiometer to calculated value 
  void calculatePotValue(double volt1, double volt2); 

  //helper function that calculates the digitial potentiometer resistance
  //as an int
  int posPotCalc(double vin); 
  
  private:

  //requested voltages
  double v1;
  double v2;

  //digital potentiometer associated with the positive regulators
  DigitalPot posPot;

  //appropriate pin allocations for the shutdown pins of both 
  //positive linear regulators as well as the chip enable for the 
  //positive digital potentiometer attached to them 
  const byte V1_PLUS_SHDN = A8;
  const byte V2_PLUS_SHDN = A9;
  const byte POS_CS = 50;
};

#endif
