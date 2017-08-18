#include "Arduino.h"
#include "db10.h"

void DB10::configurePins() {
  pinMode(ard0, OUTPUT);
  pinMode(ard1, OUTPUT);
  pinMode(ard2, OUTPUT);
  pinMode(ard3, OUTPUT);
  pinMode(ard4, OUTPUT);
  pinMode(ard5, OUTPUT);
  pinMode(ard6, OUTPUT);
  pinMode(ard7, OUTPUT);
  pinMode(OE, OUTPUT);
  pinMode(MBRST, OUTPUT);
  pinMode(MBLD, OUTPUT);
  pinMode(MBWR, OUTPUT);
  pinMode(L1, OUTPUT);
  pinMode(L2, OUTPUT);
  pinMode(L3, OUTPUT);

  digitalWrite(ard0, HIGH); //Least sig
  digitalWrite(ard1, HIGH);
  digitalWrite(ard2, HIGH);
  digitalWrite(ard3, HIGH);
  digitalWrite(ard4, HIGH);
  digitalWrite(ard5, HIGH);
  digitalWrite(ard6, HIGH);
  digitalWrite(ard7, HIGH); //Most sig
  digitalWrite(OE, HIGH);
  digitalWrite(MBRST, HIGH);
  digitalWrite(MBLD, HIGH);
  digitalWrite(MBWR, HIGH);
  digitalWrite(L1, LOW); //High addr
  digitalWrite(L2, LOW); //Low addr
  digitalWrite(L3, LOW); //Data
}

void DB10::execute()
{
  byte tempByte[2];

  while (true)
  {
    bool continuePls = true;
    String tempString = "";
    int convertedVal = 0;
    //byte test = 0x01;
    //Get high addr
    if (Serial.available() && continuePls == true) { //reads in what the user requested from GUI
      tempString = Serial.readString();
      convertedVal = stringToInt(tempString);
      if(convertedVal == 255)
      {
        //Serial.println("Breaking FF in high order address");
        continuePls = false;
        break;
      }
      //Serial.print(convertedVal);
      Serial.flush();

      
      digitalWrite(MBRST, LOW);
      digitalWrite(MBWR, LOW);
      digitalWrite(L1, LOW);
      digitalWrite(L2, LOW);
      digitalWrite(L3, LOW);
      // Put 1 bytes in for latch 1
      togglePins(convertedVal, 1);
    }

    if (Serial.available() && continuePls == true) { //reads in what the user requested from GUI
      tempString = Serial.readString();
      convertedVal = stringToInt(tempString);
      //Serial.print(convertedVal);
      Serial.flush();
      //put 1 byte in for latch 2
      togglePins(convertedVal, 2);
    }

    if (Serial.available() && continuePls == true) { //reads in what the user requested from GUI
      tempString = Serial.readString();
      convertedVal = stringToInt(tempString);
      //Serial.println(convertedVal);
      Serial.flush();
      //put 1 byte in for latch 3
      togglePins(convertedVal, 3);
    }
    digitalWrite(MBWR, HIGH);
    digitalWrite(OE, LOW);
    digitalWrite(MBLD,LOW);
    digitalWrite(OE, HIGH);
    digitalWrite(MBLD, HIGH);
    digitalWrite(MBRST, HIGH);
  }

}

//Sorry this is badly done but its easy enough
int DB10::stringToInt(String stringVal)
{
  int returnVal = 0;
  switch(stringVal.charAt(0)){
  case '1': 
  returnVal += 16;
  break;
  case '2': 
  returnVal += 32;
  break;
  case '3': 
  returnVal += 48;
  break;
  case '4': 
  returnVal += 64;
  break;
  case '5': 
  returnVal += 80;
  break;
  case '6': 
  returnVal += 96;
  break;
  case '7': 
  returnVal += 112;
  break;
  case '8': 
  returnVal += 128;
  break;
  case '9': 
  returnVal += 144;
  break; 
  case 'A': 
  returnVal += 160;
  break;
  case 'B': 
  returnVal += 176;
  break;
  case 'C': 
  returnVal += 192;
  break;
  case 'D': 
  returnVal += 208;
  break;
  case 'E': 
  returnVal += 224;
  break;
  case 'F': 
  returnVal += 240;
  break;
  default:
  break;
  }

  switch(stringVal.charAt(1)){
  case '1': 
  returnVal += 1;
  break;
  case '2': 
  returnVal += 2;
  break;
  case '3': 
  returnVal += 3;
  break;
  case '4': 
  returnVal += 4;
  break;
  case '5': 
  returnVal += 5;
  break;
  case '6': 
  returnVal += 6;
  break;
  case '7': 
  returnVal += 7;
  break;
  case '8': 
  returnVal += 8;
  break;
  case '9': 
  returnVal += 9;
  break; 
  case 'A': 
  returnVal += 10;
  break;
  case 'B': 
  returnVal += 11;
  break;
  case 'C': 
  returnVal += 12;
  break;
  case 'D': 
  returnVal += 13;
  break;
  case 'E': 
  returnVal += 14;
  break;
  case 'F': 
  returnVal += 15;
  break;
  default:
  break;
  }

  return returnVal;
}


void DB10::togglePins(int ValSent, int latch)
{
  if (bitRead(ValSent, 0) == 1)
  {
    digitalWrite(ard0, HIGH);
  }
  else
  {
    digitalWrite(ard0, LOW);
  }

  if (bitRead(ValSent, 1) == 1)
  {
    digitalWrite(ard1, HIGH);
  }
  else
  {
    digitalWrite(ard1, LOW);
  }

  if (bitRead(ValSent, 2) == 1)
  {
    digitalWrite(ard2, HIGH);
  }
  else
  {
    digitalWrite(ard2, LOW);
  }

  if (bitRead(ValSent, 3) == 1)
  {
    digitalWrite(ard3, HIGH);
  }
  else
  {
    digitalWrite(ard3, LOW);
  }

  if (bitRead(ValSent, 4) == 1)
  {
    digitalWrite(ard4, HIGH);
  }
  else
  {
    digitalWrite(ard4, LOW);
  }

  if (bitRead(ValSent, 5) == 1)
  {
    digitalWrite(ard5, HIGH);
  }
  else
  {
    digitalWrite(ard5, LOW);
  }

  if (bitRead(ValSent, 6) == 1)
  {
    digitalWrite(ard6, HIGH);
  }
  else
  {
    digitalWrite(ard6, LOW);
  }

  if (bitRead(ValSent, 7) == 1)
  {
    digitalWrite(ard7, HIGH);
  }
  else
  {
    digitalWrite(ard7, LOW);
  }


  if (latch == 1)
  {
    digitalWrite(L1, HIGH);
  }
  else if (latch == 2)
  {
    digitalWrite(L2, HIGH);
  }
  else if (latch == 3)
  {
    digitalWrite(L3, HIGH);
  }


}



