/******************************************************************************
	db3.cpp
	This implementation file contains code for Daugherboard 3,
	part of the Remote Lab System at the University of
	Washington Bothell. See db3.h.
	This code is designed to run on an Arduino Mega 2560.
	
	Created by Ellery Walsh, April 2016
	Reseased into the public domain.
******************************************************************************/


/* IMPORTANT NOTE: 
When this daughterboard was first designed, we tried to use this digital potentiometer:
https://www.intersil.com/content/dam/Intersil/documents/x9c1/x9c102-103-104-503.pdf

However, when testing, we found that this pot was extremely unstable and difficult to control.
So, we switched to using this digital pot:
http://datasheet.octopart.com/AD5171BRJZ10-R2-Analog-Devices-datasheet-8546.pdf

The new digital pot has its pins located in different places than the old one.
In addition, the new digital pot requires two pull-up resistors and a filtering capacitor.
To accommodate these changes, we made a tiny breakout board for the new pot that
re-routed the pin connections and included the two resistors and the capacitor.

When testing the new pot on its own, we found it was very stable and easy to control
using code from this Arduino tutorial:
https://www.arduino.cc/en/Tutorial/DigitalPotentiometer

However, we ran into problems when we tried to connect this digital pot to the daughterboard.
To control I2C devices with Arduino's built-in I2C hardware, you must use specific pins. 
Since this board was not originally designed with those pins in mind, we need to use a
software I2C library that allows I2C communication on other pins through bit-banging. 

The Arduino Software I2C library (http://playground.arduino.cc/Main/SoftwareI2CLibrary)
can only control one I2C device. To control multiple devices, you need a different library.
Arduino does not provide one, so we have been using this library from a hobbyist: 
https://todbot.com/blog/2010/09/25/softi2cmaster-add-i2c-to-any-arduino-pins/

However, we found that we are not able to control the digital potentiometers with this
library in the way we expected. Probing with the oscilloscope showed that the bits sent
by the original Arduino SoftwareI2CLibrary were not the same as the bits sent by Todbot's
SoftwareI2CLibrary. We are not certain of the cause of this difference.

We leave it to future teams to research this problem and find the solution. In the meantime,
this board can operate in current mirror mode only, by using the original Arduino 
SoftwareI2CLibrary to control just one digital potentiometer. However, this will require
changes to this file. Good luck!
*/

#include "Arduino.h"
#include "db3.h"

//set up connection between arduino and switch
//to change between current mirror and widlar reducing current source
const int switch_In1 = 28;

//set up connections between arduino and digital pots
const byte pot1_sdaPin =  22;
const byte pot1_sclPin =  23;
const int  pot1_address = 24;

const byte pot2_sdaPin =  25;
const byte pot2_sclPin =  26;
const int  pot2_address = 27;

// instantiate objects for I2C communication to each digital pot
SoftI2CMaster i2c1 = SoftI2CMaster( pot1_sdaPin,pot1_sclPin ); // top pot
SoftI2CMaster i2c2 = SoftI2CMaster( pot2_sdaPin,pot2_sclPin ); // bottom pot

// variables used for parsing input from user interface
int r2_state = 1;  // top potentiometer
int r3_state = 1;  // bottom potentiometer


void DB3::configurePins() {
  pinMode(switch_In1, OUTPUT); 
	pinMode(pot1_sdaPin, OUTPUT);
	pinMode(pot1_sclPin, OUTPUT);
	pinMode(pot1_address, OUTPUT);
	pinMode(pot2_sdaPin, OUTPUT);
	pinMode(pot2_sclPin, OUTPUT);
	pinMode(pot2_address, OUTPUT);
	
	// set the address of both pots to be different
	digitalWrite(pot1_address, LOW);
	digitalWrite(pot2_address, HIGH);

  //When requesting voltages from V1 and V2 +/-
  //create a new regulator object with either one 
  //or two arguments (PosReg for positive voltage 
  //and NegReg for negative) to set the regulators 
  //to output the specified voltage. Objects must 
  //also be deleted within the same function.
    
  PosReg *posReg = new PosReg(6.0);
  NegReg *negReg = new NegReg(-6.0);

  delete posReg;
  delete negReg;
}

void DB3::execute(String Board_3_Serial) {
  // variables used for parsing input from interface
  // the default message is board_3,1,1
  r2_state = Board_3_Serial.substring(8,9).toInt();
  r3_state = Board_3_Serial.substring(10,11).toInt();
  
  byte val = 0;
  
  // Top digital pot
  if (r2_state == 1) {
    i2c1.beginTransmission(44); // transmit to device #44 (0x2c) (device address is specified in datasheet)
    i2c1.write(byte(0x00));     // sends instruction byte
    i2c1.write(val);            // sends potentiometer value byte; change this value to match the UI dropdown
    i2c1.endTransmission();     // stop transmitting
  }
  else if (r2_state == 2) {
	i2c1.beginTransmission(44); // transmit to device #44 (0x2c) (device address is specified in datasheet)
    i2c1.write(byte(0x00));     // sends instruction byte
    i2c1.write(val);            // sends potentiometer value byte; change this value to match the UI dropdown
    i2c1.endTransmission();     // stop transmitting
  }
  else if (r2_state == 3) {
    i2c1.beginTransmission(44); // transmit to device #44 (0x2c) (device address is specified in datasheet)
    i2c1.write(byte(0x00));     // sends instruction byte
    i2c1.write(val);            // sends potentiometer value byte; change this value to match the UI dropdown
    i2c1.endTransmission();     // stop transmitting
  }
  else if (r2_state == 4) {
    i2c1.beginTransmission(44); // transmit to device #44 (0x2c) (device address is specified in datasheet)
    i2c1.write(byte(0x00));     // sends instruction byte
    i2c1.write(val);            // sends potentiometer value byte; change this value to match the UI dropdown
    i2c1.endTransmission();     // stop transmitting
  }
  else if (r2_state == 5) {
    i2c1.beginTransmission(44); // transmit to device #44 (0x2c) (device address is specified in datasheet)
    i2c1.write(byte(0x00));     // sends instruction byte
    i2c1.write(val);            // sends potentiometer value byte; change this value to match the UI dropdown
    i2c1.endTransmission();     // stop transmitting
  }
  
  // Bottom digital pot
  // Close the switch if the user selects "Short" for R3
  if(r3_state == 1) {
    digitalWrite(switch_In1, LOW);
  }
  else if(r3_state == 2) {
    i2c2.beginTransmission(44); // transmit to device #44 (0x2c) (device address is specified in datasheet)
    i2c2.write(byte(0x00));     // sends instruction byte
    i2c2.write(val);            // sends potentiometer value byte; change this value to match the UI dropdown
    i2c2.endTransmission();     // stop transmitting
  }
  else if(r3_state == 3) {
	i2c2.beginTransmission(44); // transmit to device #44 (0x2c) (device address is specified in datasheet)
    i2c2.write(byte(0x00));     // sends instruction byte
    i2c2.write(val);            // sends potentiometer value byte; change this value to match the UI dropdown
    i2c2.endTransmission();     // stop transmitting
  }
  else if(r3_state == 4) {
	i2c2.beginTransmission(44); // transmit to device #44 (0x2c) (device address is specified in datasheet)
    i2c2.write(byte(0x00));     // sends instruction byte
    i2c2.write(val);            // sends potentiometer value byte; change this value to match the UI dropdown
    i2c2.endTransmission();     // stop transmitting
  }
  else if(r3_state == 5) {
	i2c2.beginTransmission(44); // transmit to device #44 (0x2c) (device address is specified in datasheet)
    i2c2.write(byte(0x00));     // sends instruction byte
    i2c2.write(val);            // sends potentiometer value byte; change this value to match the UI dropdown
    i2c2.endTransmission();     // stop transmitting
  }
}
