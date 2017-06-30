#ifndef PosReg_h
#define PosReg_h
#define SHDN1 ___
#define SHDN2 ___

#include "Arduino.h"
#include "DigitalPot.h"

class PosReg {
  public:
  PosReg(double volt1, double volt2);
  void setV1(double volt1);
  void setV2(double volt2);
  void reset();
  void calculatePotValue(double volt1, double volt2 = 0); 
  
  private:
  double v1;
  double v2;
  DigitalPot posPot;
};

#endif
