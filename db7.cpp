/******************************************************************************
	db7.cpp
	This implementation file contains code for Daugherboard 7,
	part of the Remote Lab System at the University of
	Washington Bothell. See db7.h.
	This code is designed to run on an Arduino Mega 2560.
	
	Created by Ellery Walsh, April 2016
	Reseased into the public domain.
******************************************************************************/

#include "Arduino.h"
#include "db7.h"

//set up connections between arduino and switches, and arduino and dffs
  const int switchU1_In1_In2 = 22; // Connect or bypass XOR7
  const int switchU1_In3_In4 = 23; // Connect or bypass XOR6
  
  const int switchU2_In1_In2 = 24; // Connect or bypass XOR5
  const int switchU2_In3_In4 = 25; // Connect or bypass XOR4
  
  const int switchU3_In1_In2 = 30; // Connect or bypass XOR3
  const int switchU3_In3_In4 = 31; // Connect or bypass XOR2
  
  const int switchU4_In1_In2 = 32; // Connect or bypass XOR1
  
  const int dff1Preset = 36; // Preset 2 on DFF4
  const int dff2Preset = 35; // Preset 1 on DFF4
  const int dff3Preset = 34; // Preset 2 on DFF3
  const int dff4Preset = 33; // Preset 1 on DFF3
  const int dff5Preset = 29; // Preset 2 on DFF2
  const int dff6Preset = 28; // Preset 1 on DFF2
  const int dff7Preset = 27; // Preset 2 on DFF1
  const int dff8Preset = 26; // Preset 1 on DFF1
	
  const int clearAllPresets = 39; // used to reset all flipflop presets to 0
  
  const int connectClock = 37; // determines whether clock signal is connected to all dffs

// set up variables used for parsing input from user interface
  bool XOR1Connected = 0;
  bool XOR2Connected = 0;
  bool XOR3Connected = 0;
  bool XOR4Connected = 0;
  bool XOR5Connected = 0;
  bool XOR6Connected = 0;
  bool XOR7Connected = 0;
  
  bool dff1PresetState = 0;
  bool dff2PresetState = 0;
  bool dff3PresetState = 0;
  bool dff4PresetState = 0;
  bool dff5PresetState = 0;
  bool dff6PresetState = 0;
  bool dff7PresetState = 0;
  bool dff8PresetState = 0;
  
  bool clearState = 0;

void DB7::configurePins() {
  pinMode(switchU1_In1_In2, OUTPUT);
  pinMode(switchU1_In3_In4, OUTPUT);
  
  pinMode(switchU2_In1_In2, OUTPUT);
  pinMode(switchU2_In3_In4, OUTPUT);

  pinMode(switchU3_In1_In2, OUTPUT);
  pinMode(switchU3_In3_In4, OUTPUT);
  
  pinMode(switchU4_In1_In2, OUTPUT);
  
  pinMode(dff1Preset, OUTPUT);
  pinMode(dff2Preset, OUTPUT);
  pinMode(dff3Preset, OUTPUT);
  pinMode(dff4Preset, OUTPUT);
  pinMode(dff5Preset, OUTPUT);
  pinMode(dff6Preset, OUTPUT);
  pinMode(dff7Preset, OUTPUT);
  pinMode(dff8Preset, OUTPUT);
  
  pinMode(clearAllPresets, OUTPUT);
  
  pinMode(connectClock, OUTPUT); // determines whether clock signal is connected to all dffs
  
  // Disconnect clock from circuit
  digitalWrite(connectClock, 0);
  
  // clear all dffs
  digitalWrite(clearAllPresets, HIGH);
  digitalWrite(clearAllPresets, LOW);
  digitalWrite(clearAllPresets, HIGH);
  
  // set up all presets to zero
    digitalWrite(dff1Preset, HIGH);
	digitalWrite(dff2Preset, HIGH);
	digitalWrite(dff3Preset, HIGH);
	digitalWrite(dff4Preset, HIGH);
	digitalWrite(dff5Preset, HIGH);
	digitalWrite(dff6Preset, HIGH);
	digitalWrite(dff7Preset, HIGH);
	digitalWrite(dff8Preset, HIGH);
}

void DB7::execute(String Board_7_Serial) {
  // variables used for parsing input from interface
  // the default message is board_7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
  // index                  01234567890123456789012345678901234567890
  XOR1Connected = Board_7_Serial.substring(8,9).toInt();
  XOR2Connected = Board_7_Serial.substring(10,11).toInt();
  XOR3Connected = Board_7_Serial.substring(12,13).toInt();
  XOR4Connected = Board_7_Serial.substring(14,15).toInt();
  XOR5Connected = Board_7_Serial.substring(16,17).toInt();
  XOR6Connected = Board_7_Serial.substring(18,19).toInt();
  XOR7Connected = Board_7_Serial.substring(20,21).toInt();
  
  dff1PresetState = Board_7_Serial.substring(22,23).toInt();
  dff2PresetState = Board_7_Serial.substring(24,25).toInt();
  dff3PresetState = Board_7_Serial.substring(26,27).toInt();
  dff4PresetState = Board_7_Serial.substring(28,29).toInt();
  dff5PresetState = Board_7_Serial.substring(30,31).toInt();
  dff6PresetState = Board_7_Serial.substring(32,33).toInt();
  dff7PresetState = Board_7_Serial.substring(34,35).toInt();
  dff8PresetState = Board_7_Serial.substring(36,37).toInt();
  
  clockConnectedState = Board_7_Serial.substring(38,39).toInt();
  
  clearState = Board_7_Serial.substring(40,41).toInt();
  
  //XOR connections
    // State of XOR1
  if (XOR1Connected == 0) { //XOR connected
	  digitalWrite(switchU4_In1_In2, HIGH);  
  }
  else if (XOR1Connected == 1) { //XOR bypassed
	  digitalWrite(switchU4_In1_In2, LOW);  
  }
  
      // State of XOR2
  if (XOR2Connected == 0) { //XOR connected
	  digitalWrite(switchU3_In3_In4, HIGH);  
  }
  else if (XOR2Connected == 1) { //XOR bypassed
	  digitalWrite(switchU3_In3_In4, LOW);  
  }
      // State of XOR3
  if (XOR3Connected == 0) { //XOR connected
	  digitalWrite(switchU3_In1_In2, HIGH);  
  }
  else if (XOR3Connected == 1) { //XOR bypassed
	  digitalWrite(switchU3_In1_In2, LOW);  
  }
      // State of XOR4
  if (XOR4Connected == 0) { //XOR connected
	  digitalWrite(switchU2_In3_In4, HIGH);  
  }
  else if (XOR4Connected == 1) { //XOR bypassed
	  digitalWrite(switchU2_In3_In4, LOW);  
  }
      // State of XOR5
  if (XOR5Connected == 0) { //XOR connected
	  digitalWrite(switchU2_In1_In2, HIGH);  
  }
  else if (XOR5Connected == 1) { //XOR bypassed
	  digitalWrite(switchU2_In1_In2, LOW);  
  }
      // State of XOR6
  if (XOR6Connected == 0) { //XOR connected
	  digitalWrite(switchU1_In3_In4, HIGH);  
  }
  else if (XOR6Connected == 1) { //XOR bypassed
	  digitalWrite(switchU1_In3_In4, LOW);  
  }
        // State of XOR7
  if (XOR7Connected == 0) { //XOR connected
	  digitalWrite(switchU1_In1_In2, HIGH);  
  }
  else if (XOR7Connected == 1) { //XOR bypassed
	  digitalWrite(switchU1_In1_In2, LOW);  
  }
  
  //dff presets
  // note: state of 0 means no signals have been sent, 
  // so no need to check for that case
      // State of dff1
  if (dff1PresetState == 1) { //dff preset to 1
	  digitalWrite(dff1Preset, LOW);
	  digitalWrite(dff1Preset, HIGH);
  }
  
        // State of dff2
  if (dff2PresetState == 1) { //dff preset to 1
	  digitalWrite(dff2Preset, LOW);
	  digitalWrite(dff2Preset, HIGH); 
  }
        // State of dff3
  if (dff3PresetState == 1) { //dff preset to 1
	  digitalWrite(dff3Preset, LOW);
	  digitalWrite(dff3Preset, HIGH);
  }
        // State of dff4
  if (dff4PresetState == 1) { //dff preset to 1
	  digitalWrite(dff4Preset, LOW);
	  digitalWrite(dff4Preset, HIGH);  
  }
        // State of dff5
  if (dff5PresetState == 1) { //dff preset to 1
	  digitalWrite(dff5Preset, LOW);
	  digitalWrite(dff5Preset, HIGH);
  }
        // State of dff6
  if (dff6PresetState == 1) { //dff preset to 1
	  digitalWrite(dff6Preset, LOW);
	  digitalWrite(dff6Preset, HIGH);
  }
        // State of dff7
  if (dff7PresetState == 1) { //dff preset to 1
	  digitalWrite(dff7Preset, LOW);
	  digitalWrite(dff7Preset, HIGH); 
  }
        // State of dff8
  if (dff8PresetState == 1) { //dff preset to 1
	  digitalWrite(dff8Preset, LOW);
	  digitalWrite(dff8Preset, HIGH);
  }
  
  // state of clock
  if (clockConnectedState == 0) { // clock disconnected
	  digitalWrite(connectClock, LOW);
  }
  else if (clockConnectedState == 1) { // clock connected
	  digitalWrite(connectClock, HIGH);
  }
  
  // state of clear button
  // if button is not pressed, a zero will be received
  // this means nothing needs to be done, so we don't need
  // to check for this case
  if (clearState == 1) {
	digitalWrite(clearAllPresets, HIGH);
    digitalWrite(clearAllPresets, LOW);
    digitalWrite(clearAllPresets, HIGH);
  }
  
}
