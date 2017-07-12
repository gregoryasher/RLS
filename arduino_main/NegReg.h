/******************************************************************************
  NegReg.h
  This header file contains code to control the negative set of linear 
  regulators based on a daughterboard requested input voltage.
  
  Created by Paolo Sebastian, July 2017
  Reseased into the public domain.
******************************************************************************/

#ifndef NegReg_h
#define NegReg_h

#include "Arduino.h"
#include "DigitalPot.h"

class NegReg {
  public:

  //defaults second positive regulator to 0.0 if daughterboard does not
  //request an input voltage for it
  NegReg(double volt1, double volt2);
  NegReg(double volt1);
  
  void setV1(double volt1);
  void setV2(double volt2);

  //getters for all regulator variables 
  int getv1shdn();
  int getv2shdn();
  double getV1();
  double getV2();
  int getcs();

  //calculates required digital potentiometer values for the requested
  //input voltages and sets the digital potentiometer to calculated value 
  void calculatePotValue(double volt1, double volt2);

  //helper function that calculates the digitial potentiometer resistance
  //as an int
  int negPotCalc(double vin); 
  
  private:

  //requested voltages
  double v1;
  double v2;

  //digital potentiometer associated with the negative regulators
  DigitalPot negPot;

  //appropriate pin allocations for the shutdown pins of both 
  //negative linear regulators as well as the chip enable for the 
  //negative digital potentiometer attached to them 
  const byte V1_MINUS_SHDN = A10;
  const byte V2_MINUS_SHDN = A11;
  const byte NEG_CS = 53;
};

#endif
