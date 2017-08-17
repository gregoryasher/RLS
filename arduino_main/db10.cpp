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
    byte test = 0x01;
    //Get high addr
    if (Serial.available() && continuePls == true) { //reads in what the user requested from GUI
      Serial.readBytes(tempByte, 2);
      if((tempByte[0]) == test)
      {
        Serial.println("It reads it valid");
      }
      
      Serial.flush();
      if(tempByte[0] == 0xFF)
      {
        continuePls = false;
        break;
      }
      digitalWrite(MBRST, LOW);
      digitalWrite(MBWR, LOW);
      digitalWrite(L1, LOW);
      digitalWrite(L2, LOW);
      digitalWrite(L3, LOW);
      togglePins(tempByte, 1);
      //Serial.write("1");
    }

    if (Serial.available() && continuePls == true) { //reads in what the user requested from GUI
      Serial.readBytes(tempByte, 2);
      Serial.flush();
      togglePins(tempByte, 2);
      //Serial.write("1");
    }

    if (Serial.available() && continuePls == true) { //reads in what the user requested from GUI
      Serial.readBytes(tempByte, 2);
      Serial.flush();
      togglePins(tempByte, 3);
      //Serial.write("1");
    }
    digitalWrite(MBWR, HIGH);
    digitalWrite(OE, LOW);
    digitalWrite(MBLD,LOW);
    digitalWrite(OE, HIGH);
    digitalWrite(MBLD, HIGH);
    digitalWrite(MBRST, HIGH);
  }

}

void DB10::togglePins(byte tempByte[], int latch)
{
  if (bitRead(tempByte[0], 0) == 1)
  {
    digitalWrite(ard0, HIGH);
  }
  else
  {
    digitalWrite(ard0, LOW);
  }

  if (bitRead(tempByte[0], 1) == 1)
  {
    digitalWrite(ard1, HIGH);
  }
  else
  {
    digitalWrite(ard1, LOW);
  }

  if (bitRead(tempByte[0], 2) == 1)
  {
    digitalWrite(ard2, HIGH);
  }
  else
  {
    digitalWrite(ard2, LOW);
  }

  if (bitRead(tempByte[0], 3) == 1)
  {
    digitalWrite(ard3, HIGH);
  }
  else
  {
    digitalWrite(ard3, LOW);
  }

  if (bitRead(tempByte[0], 4) == 1)
  {
    digitalWrite(ard4, HIGH);
  }
  else
  {
    digitalWrite(ard4, LOW);
  }

  if (bitRead(tempByte[0], 5) == 1)
  {
    digitalWrite(ard5, HIGH);
  }
  else
  {
    digitalWrite(ard5, LOW);
  }

  if (bitRead(tempByte[0], 6) == 1)
  {
    digitalWrite(ard6, HIGH);
  }
  else
  {
    digitalWrite(ard6, LOW);
  }

  if (bitRead(tempByte[0], 7) == 1)
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



