/******************************************************************************
	db7.h
	This header file contains code for Daugherboard 7,
	part of the Remote Lab System at the University of
	Washington Bothell. See db7.cpp for implementation.
	This code is designed to run on an Arduino Mega 2560.
	
	Created by Ellery Walsh, April 2016
	Reseased into the public domain.
******************************************************************************/


#ifndef db7_h
#define db7_h

#include "Arduino.h"

class DB7 {
	public: 
  void execute(String);
  void configurePins();
  
	private:
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
  
  // variables used for parsing input from user interface
  bool XOR1Connected;
  bool XOR2Connected;
  bool XOR3Connected;
  bool XOR4Connected;
  bool XOR5Connected;
  bool XOR6Connected;
  bool XOR7Connected;
  
  bool dff1PresetState;
  bool dff2PresetState;
  bool dff3PresetState;
  bool dff4PresetState;
  bool dff5PresetState;
  bool dff6PresetState;
  bool dff7PresetState;
  bool dff8PresetState;
  
  bool clockConnectedState;
  
  bool clearState;
};

#endif

