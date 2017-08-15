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
#include <math.h>

/*********************************************
   Constructor for negative linear regulators.
   Sets the negative digital potentiometer pin
   to the appropriate chip enable.
**********************************************/
NegReg::NegReg(double volt1, double volt2) {
  pinMode(NEG_CS, OUTPUT);
  pinMode(V1_MINUS_SHDN, OUTPUT);
  pinMode(V2_MINUS_SHDN, OUTPUT);

  digitalWrite(V1_MINUS_SHDN, HIGH);
  digitalWrite(V2_MINUS_SHDN, HIGH);

  v1 = volt1;
  v2 = volt2;

  calculatePotValue(v1, v2);
}

/*********************************************
   Constructor for regulators if only one
   voltage is requrested.
**********************************************/
NegReg::NegReg(double volt1) {
  pinMode(NEG_CS, OUTPUT);
  pinMode(V1_MINUS_SHDN, OUTPUT);
  pinMode(V2_MINUS_SHDN, OUTPUT);

  digitalWrite(V1_MINUS_SHDN, HIGH);

  v1 = volt1;
  v2 = 0.0;

  calculatePotValue(v1, v2);
}

/*********************************************
   Setter for requested voltage input 1.
**********************************************/
void NegReg::setV1(double volt1) {
  v1 = volt1;
}

/*********************************************
   Setter for requested voltage input 2.
**********************************************/
void NegReg::setV2(double volt2) {
  v2 = volt2;
}

/*********************************************
   Getter for requested voltage input 1.
**********************************************/
double NegReg::getV1() {
  return v1;
}

/*********************************************
   Getter for requested voltage input 2.
**********************************************/
double NegReg::getV2() {
  return v2;
}

/*********************************************
   Getter for requested chip select.
**********************************************/
int NegReg::getCS() {
  return NEG_CS;
}

/*********************************************
   Setter for v1's shutdown pin
**********************************************/
int NegReg::getv1shdn() {
  return V1_MINUS_SHDN;
}

/*********************************************
   Setter for v2's shutdown pin
**********************************************/
int NegReg::getv2shdn() {
  return V2_MINUS_SHDN;
}

/*********************************************
   Takes in requested voltage values and
   converts them into the appropriate
   integer potentiometer resistance values.
   It then sets the potentiometer to the requested
   resistance(s).
**********************************************/
void NegReg::calculatePotValue(double volt1, double volt2) {

  //sets the associated potentiometer to
  //appropriate chip select pin
  negPot.setCS(getCS());

  //calculates pot values as an integer
  int negDigRes1 = negPotCalc(volt1);
  int negDigRes2 = negPotCalc(volt2);

  //shuts down associated regulator if
  //user does not request a voltage
  if ((negDigRes1) == 399) {
    digitalWrite(V1_MINUS_SHDN, LOW);
  }
  else {

    negPot.setRes1(negDigRes1);
  }

  if ((negDigRes2) == 399) {
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
int NegReg::negPotCalc(double vout) {
  double vReq;
  int negPotRes;

  //calculation to determine potentiometer
  //resistance for the particular negative regulator
  if (vout < -1.22) {
    vReq = ((vout + 1.22) / ((-1.22 / 1780.0) + 0.00000003));
  }
  else {
    vReq = 0.0;
    negPotRes = 399;
    return negPotRes;
  }

  //determines the data that will be sent
  //through the digital potentiometer bus
  double resDataVal = ((vReq / 20000.0) * 1024.0) + 0.5;
  negPotRes = round(resDataVal) + 1024;

  //if data is not within appropriate bounds to send,
  //it is clipped
  if (negPotRes > 2047)
  {
    negPotRes = 2047;
  }
  if (negPotRes < 400)
  {
    negPotRes = 400;
  }

  //returns the negative pot resistance data to step
  //the digital potentiometer to the closest bit
  return negPotRes;
}
