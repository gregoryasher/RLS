/******************************************************************************
  dbControl.cpp
  This implementation file contains code that is common to all daughterboards
  that are part of the Remote Lab System at the University of
  Washington Bothell. See dbControl.cpp for implementation.
  This code is designed to run on an Arduino Mega 2560.

  Created by Ellery Walsh, March 2016
  Reseased into the public domain.
******************************************************************************/

/*
   Error messages:
   -1 = bad board id
   -2 = bad serial command recieved from GUI
*/

#include "Arduino.h"
#include "dbControl.h"
//#include "db1.h"
//#include "db2.h"
#include "db3.h"
#include "db4.h"
#include "db5.h"
#include "db6.h"
#include "db7.h"

// instantiate board objects
// DB1 board1;
// DB2 board2;
DB3 board3;
DB4 board4;
DB5 board5;
DB6 board6;
DB7 board7;

// Pins of Board ID are Arduino Mega's analog input pins
int boardIdPinState[8] = {0};

String bID = ""; //global variable used for comparison of each bit represented in boardIdPinState

/*****************************

   serialControl handles the commands sent from the GUI


*****************************/
void DBControl::serialControl() {
  configureDaughterboardPins();
  safetyCheck();

  if (Serial.available()) {

     //(7/19/2017) - CONTINUALLY CHECKS FOR AND RECONFIGURES PINS BASED ON DAUGHTER BOARD CONNECTED
    configureDaughterboardPins();

    String outputFromUI = Serial.readString();
    Serial.flush();
    Serial.println(outputFromUI);
    String boardIDsubstring = outputFromUI.substring(0, 7);
    if (outputFromUI.equalsIgnoreCase("boardID")) //Board ID is requested
    {
       //(7/19/2017) - NO LONGER NEEDS TO CHECK AGAIN AS ITS ALREADY DONE IN THE BEGINNING OF FUNCTION
      //readBoardID();
      
      Serial.flush();
      //if (bID.equals("00000000")) // if all zeros error
        //Serial.println("-1");     //send -1: no board present

      //(7/19/2017) - DOES A SAFETY CHECK WHEN USER SELECTS "CHECK BOARD" FROM GUI AND THERE 
      //IS NO DAUGHTER BOARD PRESENT
      
      //safetyCheck();
       
      Serial.println(bID);
    }
    else if (boardIDsubstring == "board_3")//Board 3 is addressed (the default message is board_3,1,1)
    {
      board3.execute(outputFromUI);
      //outputMessage = outputFromUI; //Configure board_3
    }
    else if (boardIDsubstring == "board_4") // Board 4 is addressed (the default message is board_4,1,1,1)
    {
      board4.execute(outputFromUI);
    }
    else if (boardIDsubstring == "board_5")//Board 5 is addressed (the default message is board_5,1,1,1)
    {
      board5.execute(outputFromUI);
    }
    else if (boardIDsubstring == "board_6")//Board 5 is addressed (the default message is board_5,1,1,1)
    {
      board6.execute(outputFromUI);
    }
    else if (boardIDsubstring == "board_7")//Board 5 is addressed (the default message is board_5,1,1,1)
    {
      board7.execute(outputFromUI);
    }
    /*
      else if(outputFromUI.substring(0,9) == "power_reg")
      {
      Power_Regulation(outputFromUI); //power_reg,111
      }
    */
    else
    {
      //safetyCheck();
      
      // error -2: bad serial command received
      Serial.println("-2");
    }
  }
}

/************************

    Configure Pins makes sure that each board has the
    correct digital pins marked as outputFromUI

    Note: Daughterboard 1 and daughterboard 2 files do not exist (or are missing)
          Thier configuration settings have been commented out.

*************************/
void DBControl::configureDaughterboardPins() {
  readBoardID();

  // Configure pins correctly for the given board
  //Note: Daughterboard 1 and daughterboard 2 configuration commented out
  /*
    if (boardID == "Board_ID,00000001") {
    board1.configurePins();
    }
    else if (boardID == "Board_ID,00000010") {
    board2.configurePins();
    }
    else*/
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
  Serial.println(bID);
}

/*****************************

   Check if the daughter board is present,
   if it isnt, disable the Power Regulator relay
   returns true if passes saftey
   returns false if fails

*****************************/
boolean DBControl::safetyCheck() {

  //commented out readBoardID()  since serial control now continually does this function  
  //readBoardID(); 

  if (bID.equalsIgnoreCase("00000000")) {
      shutDownRegs();
      return false;
    /*
       error, no board in place
       clear buffer, write
       -1: bad board ID.

       edit: this was changed to reduce buffer filling.
              now only writes in the loop of arduino_main class
    */
  
//    Serial.flush();
//    Serial.println("-1");
//    digitalWrite(Power_Relay_Enable, LOW);
  }
  return true;
}


/*****************************

   Reads daughterboard ID pin states and populates array
   then writes the global board ID string with new value.


*****************************/
void DBControl::readBoardID() {
  bID = "";
  //first clear all values
  for (int i = 0; i < 8; i++)
    boardIdPinState[i] = 0;

  //then obtain new values read from board
  for (int i = 0; i < 8; i++) {
    boardIdPinState[i] = digitalRead(boardIdPins[i]);
    //Serial.print("loop: ");
    //Serial.print(i);
    //Serial.print(" ");
    //Serial.println(boardIdPins[i]);
    bID += boardIdPinState[i];
  }
}

/*****************************

   Sets daughterboard ID pins to input.
   Pins are determined by array boardIdPins

*****************************/
void DBControl::configureBoardIdPins() {
  for (int i = 0; i < 8; i++) {
    pinMode(boardIdPins[i], INPUT);
  }
}

/**********************************************
 * Function that shuts down all linear regulators.
 * ********************************************/
void DBControl::shutDownRegs() {
  configureShutdownRegPins();

  digitalWrite(A8, LOW);
  digitalWrite(A9, LOW);
  digitalWrite(A10, LOW);
  digitalWrite(A11, LOW);
}

void DBControl::configureShutdownRegPins() {
  pinMode(A8, OUTPUT);
  pinMode(A9, OUTPUT);
  pinMode(A10, OUTPUT);
  pinMode(A11, OUTPUT);
}

