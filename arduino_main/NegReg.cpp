/******************************************************************************
  NegReg.cpp
  This implementation file contains implementation code for the negative 
  linear regulators.

  Created by Paolo Sebastian, July 2017
  Reseased into the public domain.
******************************************************************************/

#include "Arduino.h"
#include "NegReg.h"
#include "DigitalPot.h"

/*********************************************
   Constructor for negative linear regulators.
   Sets the negative digital potentiometer pin  
   to the appropriate chip enable.    
**********************************************/
NegReg::NegReg(double volt1, double volt2 = 0.0) {
  v1 = volt1;
  v2 = volt2;
  negPot = new DigitalPot(NEG_CS);
}

/*********************************************
   Mutator for requested voltage input 1.  
**********************************************/
void NegReg::setV1(double volt1) {
  v1 = volt1;
}

/*********************************************
   Mutator for requested voltage input 2.  
**********************************************/
void NegReg::setV2(double volt2) {
  v2 = volt2;
}

/*********************************************
   Takes in requested voltage values and 
   converts them into the appropriate 
   integer potentiometer resistance values.
   It then sets the potentiometer to the requested
   resistance(s).
**********************************************/
void NegReg::calculatePotValue(double volt1, double volt2) {  

  //calculates pot values as an integer
  int negDigRes1 = negPotCalc(volt1);
  int negDigRes2 = negPotCalc(volt2);

  //shuts down associated regulator if 
  //user does not request a voltage
  if ((negDigRes1) == 0) {
    digitalWrite(V1_MINUS_SHDN, LOW);
  }
  else {
    negPot.setRes1(negDigRes1);
  }

  if ((negDigRes2) == 0) {
    digitalWrite(V2_MINUS_SHDN, LOW);
  }
  else {
    negPot.setRes2(negDigRes2);
  }

  //writes resistor values to the potentiomter 
  negPot.writeValues(V1_MINUS_SHDN, V2_MINUS_SHDN);
}

/*********************************************
   Computes the required digital potentiometer
   resitance and returns the value as an 
   integer.
**********************************************/
int NegReg::negPotCalc(double vin){  
  int negPotRes;

  //calculation to determine potentiometer 
  //resistance for the particular negative regulator
  if (vin < -1.22) {
    negPotRes = ((vin + 1.22) / ((-1.22 / 1780.0) + 0.00000003));
  }
  else {
    negPotRes = 0;
  }
  
  return negPotRes;
}
