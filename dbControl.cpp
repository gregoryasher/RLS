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
const int boardIdPins[8] = {51, 49, 47, 45, 43, 41, 53, 52};
int boardIdPinState[8] = {0};

void DBControl::serialControl() {
      //String outputMessage = "";
      if (Serial.available()) 
      {
        String outputFromUI = Serial.readString();
        String boardIDsubstring = outputFromUI.substring(0,7);
        if (outputFromUI == "boardID") //Board ID is requested
        {
          readBoardID();
          String boardID = stringifyBoardID();
          //Serial.print("Board ID: "); // DELETE THIS LINE LATER IF WEIRD SERIAL PRINT THINGS ARE HAPPENING!!!!!
          Serial.println(boardID); 
          //outputMessage = "IdChecked";
        }
        /*else if (boardIDsubstring == "board_1") //Board_1 is addressed
        {
			board1.execute(outputFromUI);
          //Serial.println(outputFromUI); 
          //outputMessage = outputFromUI; //Configure board_1 (the default message is board_1,01,1,4,4,01,01)
        }      
        else if (boardIDsubstring == "board_2")//Board 2 is addressed
        {
          Serial.println(outputFromUI); 
          outputMessage = outputFromUI; //Configure board_2 (the default message is board_2,1,1,1,1,1,1,01,01)
        } */
		else if (boardIDsubstring == "board_3")//Board 3 is addressed (the default message is board_3,1,1)
        {
          board3.execute(outputFromUI);
          //outputMessage = outputFromUI; //Configure board_3
        }
		else if (boardIDsubstring == "board_4") // Board 4 is addressed (the default message is board_4,1,1,1)
		{
		  board4.execute(outputFromUI);
		  //Serial.println(outputFromUI);           
          //outputMessage = outputFromUI;; //Configure board_4
		}
        else if (boardIDsubstring == "board_5")//Board 5 is addressed (the default message is board_5,1,1,1)
        {
			board5.execute(outputFromUI);
          //Serial.println(outputFromUI);           
          //outputMessage = outputFromUI;; //Configure board_5
        }
		else if (boardIDsubstring == "board_6")//Board 5 is addressed (the default message is board_5,1,1,1)
        {
			board6.execute(outputFromUI);
          //Serial.println(outputFromUI);           
          //outputMessage = outputFromUI;; //Configure board_6
        }
		else if (boardIDsubstring == "board_7")//Board 5 is addressed (the default message is board_5,1,1,1)
        {
			board7.execute(outputFromUI);
          //Serial.println(outputFromUI);           
          //outputMessage = outputFromUI;; //Configure board_7
        }
        /*
        else if(outputFromUI.substring(0,9) == "power_reg")
        {
          Power_Regulation(outputFromUI); //power_reg,111
        }
        */
        else
        {
          safetyCheck();
          Serial.println("Error");
          //outputMessage = "Error";
        }
      }
    //return outputMessage;
}

// Configure Pins makes sure that each board has the 
// correct digital pins marked as outputFromUI
void DBControl::configureDaughterboardPins() {
	readBoardID();
	String boardID = stringifyBoardID();

  // Configure pins correctly for the given board
  /*
  if (boardID == "Board_ID,00000001") {
    board1.configurePins();
  }
  else if (boardID == "Board_ID,00000010") {
    board2.configurePins();
  }
  else*/ if (boardID == "Board_ID,00000011") {
    board3.configurePins();
  }
  else if (boardID == "Board_ID,00000100") {
    board4.configurePins();
  }
  else if (boardID == "Board_ID,00000101") {
    board5.configurePins();
  }
  else if (boardID == "Board_ID,00000110") {
    board6.configurePins();
  }
  else if (boardID == "Board_ID,00000111") {
    board7.configurePins();
  }
  Serial.println(boardID);
}

//Check if the daughter board is present,
//if it isnt, disable the Power Regulator relay
void DBControl::safetyCheck(){
    readBoardID();
    int sumOfIdStates = 0;
    for (int i = 0; i < 8; i++) {
      sumOfIdStates += boardIdPinState[i];
    }
    if (sumOfIdStates == 0)
    {
      Serial.println("No board in place!!");
      //digitalWrite(Power_Relay_Enable, LOW);
    }
 }

void DBControl::readBoardID() {
  // Read the voltage on all 8 pins of the board ID
  // and save their state into the array boardIDPinState
  for (int i = 0; i < 8; i++) {
    boardIdPinState[i] = digitalRead(boardIdPins[i]);
  }
}

String DBControl::stringifyBoardID() {
  // Build up a string from all the board ID pin states
  String boardID = "Board_ID,";
  for (int i = 0; i < 8; i++) {
     boardID = boardID + String(boardIdPinState[i]);
  }
  return boardID;
}

void DBControl::configureBoardIdPins() {
  for (int i = 0; i < 8; i++) {
     pinMode(boardIdPins[i], INPUT);
  }
}

