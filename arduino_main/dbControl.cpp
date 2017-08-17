/******************************************************************************
  dbControl.cpp
  This implementation file contains code that is common to all daughterboards
  that are part of the Remote Lab System at the University of
  Washington Bothell. See dbControl.cpp for implementation.
  This code is designed to run on an Arduino Mega 2560.

  Created by Ellery Walsh, March 2016
  Reseased into the public domain.
******************************************************************************/

#include "Arduino.h"
#include "dbControl.h"

#include "db3.h"
#include "db4.h"
#include "db5.h"
#include "db6.h"
#include "db7.h"
#include "db10.h"

// instantiate board objects

DB3 board3;
DB4 board4;
DB5 board5;
DB6 board6;
DB7 board7;
DB10 board10;

// Pins of Board ID are Arduino Mega's analog input pins
int boardIdPinState[8] = {0};

String bID = ""; //global variable used for comparison of each bit represented in boardIdPinState
String bIDCheck = ""; //global variable used to check if the same board is plugged in with each serial control iteration

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
      //Serial.flush();
      //Serial.println("1"); //success
      configureDaughterboardPins();
      board3.execute(outputFromUI);
//      Serial.flush();
//      Serial.println("1"); //success
    }
    else if (boardIDsubstring.equalsIgnoreCase("board_4")) // Board 4 is addressed (the default message is board_4,1,1,1)
    {
//      Serial.flush();
//      Serial.println("1"); //success
      configureDaughterboardPins();
      board4.execute(outputFromUI);
//      Serial.flush();
//      Serial.println("1"); //success
    }
    else if (boardIDsubstring.equalsIgnoreCase("board_5"))//Board 5 is addressed (the default message is board_5,1,1,1)
    {
//      Serial.flush();
//      Serial.println("1"); //success
      configureDaughterboardPins();
      board5.execute(outputFromUI);
//      Serial.flush();
//      Serial.println("1"); //success
    }
    else if (boardIDsubstring.equalsIgnoreCase("board_6"))//Board 5 is addressed (the default message is board_5,1,1,1)
    {
//      Serial.flush();
//      Serial.println("1"); //success
      configureDaughterboardPins();
      board6.execute(outputFromUI);
//      Serial.flush();
//      Serial.println("1"); //success
    }
    else if (boardIDsubstring.equalsIgnoreCase("board_7"))//Board 7 is addressed (the default message is board_5,1,1,1)
    {
//      Serial.flush();
//      Serial.println("1"); //success
      configureDaughterboardPins();
      board7.execute(outputFromUI);
//      Serial.flush();
//      Serial.println("1"); //success
    }
    else if (boardIDsubstring.equalsIgnoreCase("Board10"))
    {
      //Serial.write("1");
      configureDaughterboardPins();
      board10.execute();
    }
    else
    {
      Serial.flush();
      Serial.println("No board dectected. Check Board again"); //failure
    }
  }
}

/*****************************************************************************
    Configure Pins makes sure that each board has the
    correct digital pins marked as outputFromUI

    Note: Daughterboard 1 and daughterboard 2 files do not exist (or are missing)
          Thier configuration settings have been commented out.
*****************************************************************************/
void DBControl::configureDaughterboardPins() {
  
  //empty if statement that checks if the same board is connected as previous
  //serial control implementation and skips board configuration if the same
  //board is connected
  
  // Configure pins correctly for the given board
  if (bID.equalsIgnoreCase("00000011")) {
    bIDCheck = bID;
    board3.configurePins();
  }
  else if (bID.equalsIgnoreCase("00000100")) {
    bIDCheck = bID;
    board4.configurePins();
  }
  else if (bID.equalsIgnoreCase("00000101")) {
    bIDCheck = bID;
    board5.configurePins();
  }
  else if (bID.equalsIgnoreCase("00000110")) {
    bIDCheck = bID;
    board6.configurePins();
  }
  else if (bID.equalsIgnoreCase("00000111")) {
    bIDCheck = bID;
    board7.configurePins();
  }
  else if (bID.equalsIgnoreCase("00001010")){
    bIDCheck = bID;
    board10.configurePins();
  }
  
 // Serial.println(bID);
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


