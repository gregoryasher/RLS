#include <SPI.h>

//const byte CSS = 53;


void setup() {
  Serial.begin(9600);

}
void loop() {

   setPot(20000);
}

void setPot(double resVal)
{
  int dVal = ((resVal*1024) / 20000);
  if(resVal > 19980)
  {
    dVal = 1023; 
  } 
  Serial.println(dVal);
  
  //String stringOne = String(dVal, HEX);
  String stringOne = String(dVal, BIN);
  Serial.println(stringOne);
  String headerString = "000001";
  String fullString = headerString + stringOne;
  Serial.println(fullString);
  //Serial.println(fullString);

  char c[17];
  fullString.toCharArray(c, 17);
  
  int finalDec = 0;
  for(int i = 0; i < 16; i++)
  {
    finalDec = finalDec + ((c[15-i])-48) * notRetardedAsFuckPowerFunction(2,i);
//    Serial.print((c[15-i])-48);
//    Serial.print(" * ");
//    Serial.print(notRetardedAsFuckPowerFunction(2,i));
//    Serial.print(" = ");
//    Serial.print(((c[15-i])-48) * notRetardedAsFuckPowerFunction(2,i));
//    Serial.println();
//    //Serial.println(finalDec);
//    delay(500);
  }

  Serial.println(finalDec);
 
  String doneString = String(finalDec, HEX);
  Serial.println(doneString);
  delay(500);
}

int notRetardedAsFuckPowerFunction(int base, int power)
{
  int retVal = 1;
  for(int i = 0; i < power; i++)
  {
    retVal *= base;
  }
  return retVal;
}


