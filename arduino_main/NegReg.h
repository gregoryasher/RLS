#ifndef NegReg_h
#define NegReg_h
#define SHDN1 ___
#define SHDN2 ___

#include "Arduino.h"
#include "DigitalPot.h"

class NegReg {
  public:
  NegReg(double volt1, double volt2 = 0);
  void setV1(double volt1);
  void setV2(double volt2);
  void reset();
  void calculatePotValue(double volt1, double volt2); 
  
  private:
  double v1;
  double v2;
  DigitalPot negPot;
};

#endif
