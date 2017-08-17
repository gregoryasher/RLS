/******************************************************************************
  dbControl.cpp
  This implementation file contains code that is common to all daughterboards
  that are part of the Remote Lab System at the University of
  Washington Bothell. Contains functions to control daughterboards, linear
  regulators, and oscilloscope probe gain. This code is designed to run on 
  an Arduino Mega 2560.

  Created by Ellery Walsh, March 2016

  Further revisions made by Paolo Sebastian, August 2017
  RLS Capstone, Summer 2017 Motherboard Team  
  
  Version 8/17/2017
  
  Reseased into the public domain.
******************************************************************************/

#include "Arduino.h"
#include "dbControl.h"

/******************************************************************************
  Includes daughterboard files of previous daughterboard teams prior to 
  Summer 2017.
******************************************************************************/
#include "db3.h"
#include "db4.h"
#include "db5.h"
#include "db6.h"
#include "db7.h"

/******************************************************************************
  Includes header and implementation files of Daughterboards 8,9,10, and 11
  created by the sister daughterboard team of Capstone Summer 2017. Daughterboard 
  files are commented out due to daughterboard software being incomplete and 
  incompatible with completed motherboard software at the completion of Summer 2017.  
******************************************************************************/
//#include "db8.h"
//#include "db9.h"
#include "db10.h"
//#nclude "db11.h"

//instantiate board objects
DB3 board3;
DB4 board4;
DB5 board5;
DB6 board6;
DB7 board7;
DB10 board10;

//Pins of Board ID are Arduino Mega's analog input pins
int boardIdPinState[8] = {0};

String bID = ""; //global variable used for comparison of each bit represented in boardIdPinState

/*****************************************************************************
   serialControl handles the commands sent from the GUI
*****************************************************************************/
void DBControl::serialControl() {
  safetyCheck();

  if (Serial.available()) { //reads in what the user requested from GUI
    String outputFromUI = Serial.readString();
    Serial.flush();
    Serial.println(outputFromUI);
    String boardIDsubstring = outputFromUI.substring(0, 7);
    if (outputFromUI.equalsIgnoreCase("boardID")) //Board ID is requested
    { 
      readBoardID();
      Serial.flush();
      Serial.println(bID);
    }
    else if (boardIDsubstring.equalsIgnoreCase("board_3"))//Board 3 is addressed (the default message is board_3,1,1)
    {
      configureDaughterboardPins();
      board3.execute(outputFromUI);
    }
    else if (boardIDsubstring.equalsIgnoreCase("board_4")) // Board 4 is addressed (the default message is board_4,1,1,1)
    {
      configureDaughterboardPins();
      board4.execute(outputFromUI);
    }
    else if (boardIDsubstring.equalsIgnoreCase("board_5"))//Board 5 is addressed (the default message is board_5,1,1,1)
    {
      configureDaughterboardPins();
      board5.execute(outputFromUI);
    }
    else if (boardIDsubstring.equalsIgnoreCase("board_6"))//Board 5 is addressed (the default message is board_5,1,1,1)
    {
      configureDaughterboardPins();
      board6.execute(outputFromUI);
    }
    else if (boardIDsubstring.equalsIgnoreCase("board_7"))//Board 7 is addressed (the default message is board_5,1,1,1)
    {
      configureDaughterboardPins();
      board7.execute(outputFromUI);
    }
    else if (boardIDsubstring.equalsIgnoreCase("Board10"))
    {
      configureDaughterboardPins();
      board10.execute();
    }
    else
    {
      Serial.flush();
      Serial.println("No board dectected. Check Board again"); //no board detected when "update board" was selected in GUI 
    }
  }
}

/*****************************************************************************
    Configure Pins makes sure that each board has the
    correct digital pins marked as outputFromUI

    Note: Daughterboard 1 and daughterboard 2 files do not exist (or are missing)
          Their configuration settings have been commented out.
*****************************************************************************/
void DBControl::configureDaughterboardPins() {
  
  // Configure pins correctly for the given board
  if (bID.equalsIgnoreCase("00000011")) {
    board3.configurePins();
  }
  else if (bID.equalsIgnoreCase("00000100")) {
    board4.configurePins();
  }
  else if (bID.equalsIgnoreCase("00000101")) {
    board5.configurePins();
  }
  else if (bID.equalsIgnoreCase("00000110")) {
    board6.configurePins();
  }
  else if (bID.equalsIgnoreCase("00000111")) {
    board7.configurePins();
  }
  else if (bID.equalsIgnoreCase("00001010")){
    board10.configurePins();
  }
}

/***********************************************************************
   Check if the daughter board is present. If it isnt, disable the linear 
   regulators.
***********************************************************************/
boolean DBControl::safetyCheck() {

  if (bID.equalsIgnoreCase("11111111")) { //if no board is connected, turn off regulators and report error
      shutDownRegs();
      return false;
  }
  return true;
}

/***********************************************************************
   Reads daughterboard ID pin states and populates array
   then writes the global board ID string with new value.
***********************************************************************/
void DBControl::readBoardID() {
  bID = "";
  //first clear all values
  for (int i = 0; i < 8; i++)
    boardIdPinState[i] = 0;

  //then obtain new values read from board
  for (int i = 0; i < 8; i++) {
    boardIdPinState[i] = digitalRead(boardIdPins[i]);
    bID += boardIdPinState[i];
  }
}

/***********************************************************************
   Sets daughterboard ID pins to input.
   Pins are determined by array boardIdPins
***********************************************************************/
void DBControl::configureBoardIdPins() {
  for (int i = 0; i < 8; i++) {
    pinMode(boardIdPins[i], INPUT);
  }
}

/***********************************************************************
 Function that shuts down all linear regulators.
***********************************************************************/
void DBControl::shutDownRegs() {
  pinMode(A8, OUTPUT);
  pinMode(A9, OUTPUT);
  pinMode(A10, OUTPUT);
  pinMode(A11, OUTPUT);

  digitalWrite(A8, LOW);
  digitalWrite(A9, LOW);
  digitalWrite(A10, LOW);
  digitalWrite(A11, LOW);
}

/***********************************************************************
 Function that sets the oscilloscope probe gain to X1.
***********************************************************************/
void DBControl::setScopeGainX1() {
  pinMode(A12, OUTPUT);
  pinMode(A13, OUTPUT);

  digitalWrite(A12, LOW);
  digitalWrite(A13, LOW);
}


