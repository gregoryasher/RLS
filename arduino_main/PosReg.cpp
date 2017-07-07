/******************************************************************************
  PosReg.cpp
  This implementation file contains implementation code for the positive 
  linear regulators.

  Created by Paolo Sebastian, July 2017
  Reseased into the public domain.
******************************************************************************/

#include "Arduino.h"
#include "PosReg.h"
#include "DigitalPot.h"

/*********************************************
   Constructor for positive linear regulators.
   Sets the positive digital potentiometer pin  
   to the appropriate chip enable.    
**********************************************/
PosReg::PosReg(double volt1, double volt2 = 0.0) {
  v1 = volt1;
  v2 = volt2;
  posPot = new DigitalPot(POS_CS);
}

/*********************************************
   Mutator for requested voltage input 1.  
**********************************************/
void PosReg::setV1(double volt1) {
  v1 = volt1;
}

/*********************************************
   Mutator for requested voltage input 2.  
**********************************************/
void PosReg::setV2(double volt2) {
  v2 = volt2;
}

/*********************************************
   Takes in requested voltage values and 
   converts them into the appropriate 
   integer potentiometer resistance values.
   It then sets the potentiometer to the requested
   resistance(s).
**********************************************/
void PosReg::calculatePotValue(double volt1, double volt2) {

  //calculates pot values as an integer
  int posDigRes1 = posPotCalc(volt1);
  int posDigRes2 = posPotCalc(volt2);

  //shuts down associated regulator if 
  //user does not request a voltage
  if ((posDigRes1) == 0) {
    digitalWrite(V1_PLUS_SHDN, LOW);
  }
  else {
    posPot.setRes1(posDigRes1);
  }

  if ((posDigRes2) == 0) {
    digitalWrite(V2_PLUS_SHDN, LOW);
  }
  else {
    posPot.setRes2(posDigRes2);
  }

  //writes resistor values to the potentiomter 
  posPot.writeValues(V1_PLUS_SHDN, V2_PLUS_SHDN);
}

/*********************************************
   Computes the required digital potentiometer
   resitance and returns the value as an 
   integer.
**********************************************/
int PosReg::posPotCalc(double vin){  
  int posPotRes;

  //calculation to determine potentiometer 
  //resistance for the particular positive regulator
  if (vin > 1.21) {
    posPotRes = ((vin - 1.21) / ((1.21 / 1780.0) + 0.000003));
  }
  else {
    posPotRes = 0;
  }
  
  return posPotRes;
}

