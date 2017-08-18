
#ifndef db10_h
#define db10_h

#include "Arduino.h"

class DB10 {
  public: 
  void execute();
  void configurePins();
  void togglePins(int, int);
  int stringToInt(String);
  
  private:
  const int ard0 = 32; 
  const int ard1 = 33; 
  const int ard2 = 34; 
  const int ard3 = 35; 
  const int ard4 = 36; 
  const int ard5 = 37; 
  const int ard6 = 38; 
  const int ard7 = 39;
  const int OE = 40;
  const int MBRST = 41;
  const int MBLD = 42;
  const int MBWR = 43;
  const int L1 = 44;
  const int L2 = 45;
  const int L3 = 46;
  
};

#endif

