#ifndef DigitalPot_h
#define DigitalPot_h

#include "Arduino.h"

class DigitalPot {
  public:
  DigitalPot(int chipSelect);
  void setRes1(double res1);
  void setRes2(double res2);
  void writeValues();
  
  private:
  double res1;
  double res2;
};

#endif
