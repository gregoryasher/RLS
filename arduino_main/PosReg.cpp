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
#include <math.h>

/*********************************************
   Constructor for positive linear regulators.
   Sets the positive digital potentiometer pin
   to the appropriate chip enable.
**********************************************/
PosReg::PosReg(double volt1, double volt2) {
  pinMode(POS_CS, OUTPUT);
  pinMode(V1_PLUS_SHDN, OUTPUT);
  pinMode(V2_PLUS_SHDN, OUTPUT);

  digitalWrite(V1_PLUS_SHDN, HIGH);
  digitalWrite(V2_PLUS_SHDN, HIGH);

  v1 = volt1;
  v2 = volt2;

  calculatePotValue(v1, v2);
}

/*********************************************
   Constructor for regulators if only one
   voltage is requrested.
**********************************************/
PosReg::PosReg(double volt1) {
  pinMode(POS_CS, OUTPUT);
  pinMode(V1_PLUS_SHDN, OUTPUT);
  pinMode(V2_PLUS_SHDN, OUTPUT);

  digitalWrite(V1_PLUS_SHDN, HIGH);

  v1 = volt1;
  v2 = 0.0;

  calculatePotValue(v1, v2);
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
   Getter for requested voltage input 1.
**********************************************/
double PosReg::getV1() {
  return v1;
}

/*********************************************
   Getter for requested voltage input 2.
**********************************************/
double PosReg::getV2() {
  return v2;
}

/*********************************************
   Getter for requested chip select.
**********************************************/
int PosReg::getCS() {
  return POS_CS;
}

/*********************************************
   Setter for v1's shutdown pin
**********************************************/
int PosReg::getv1shdn() {
  return V1_PLUS_SHDN;
}

/*********************************************
   Setter for v2's shutdown pin
**********************************************/
int PosReg::getv2shdn() {
  return V2_PLUS_SHDN;
}

/*********************************************
   Takes in requested voltage values and
   converts them into the appropriate
   integer potentiometer resistance values.
   It then sets the potentiometer to the requested
   resistance(s).
**********************************************/
void PosReg::calculatePotValue(double volt1, double volt2) {

  //sets the associated potentiometer to
  //appropriate chip select pin
  posPot.setCS(getCS());

  //calculates pot values as an integer
  int posDigRes1 = posPotCalc(volt1);
  int posDigRes2 = posPotCalc(volt2);

  //shuts down associated regulator if
  //user does not request a voltage
  if ((posDigRes1) == 399) {
    digitalWrite(V1_PLUS_SHDN, LOW);
  }
  else {
    posPot.setRes1(posDigRes1);
  }

  if ((posDigRes2) == 399) {
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
int PosReg::posPotCalc(double vout) {
  double vReq;
  int posPotRes;

  //calculation to determine potentiometer
  //resistance for the particular positive regulator
  if (vout > 1.21) {
    vReq = ((vout - 1.21) / ((1.21 / 1780.0) + 0.000003));
  }
  else {
    vReq = 0.0;
    posPotRes = 399;
    return posPotRes;
  }

  //determines the data that will be sent
  //through the digital potentiometer bus
  double resDataVal = ((vReq / 20000.0) * 1024.0) + 0.5;
  posPotRes = round(resDataVal) + 1024;

  //if data is not within appropriate bounds to send,
  //it is clipped
  if (posPotRes > 2047)
  {
    posPotRes = 2047;
  }
  if (posPotRes < 400)
  {
    posPotRes = 400;
  }

  //returns the positive pot resistance data to step
  //the digital potentiometer to the closest bit
  return posPotRes;
}

