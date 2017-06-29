#include <SPI.h>
const byte CSS = 53;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(CSS, OUTPUT);
  SPI.begin();
  SPI.setBitOrder(MSBFIRST);
  SPI.setClockDivider(SPI_CLOCK_DIV4);
  SPI.setDataMode(SPI_MODE1);
  delay(5);
  

}

void loop() {

  delay(5000);

  digitalWrite(CSS, LOW);
  SPI.transfer16(0x1802);
  SPI.transfer16(0x1802);
  digitalWrite(CSS, HIGH);
  
  digitalWrite(CSS, LOW);
  SPI.transfer16(0x0700);
  SPI.transfer16(0x0500);
  digitalWrite(CSS, HIGH);

  delay(20000);
  
  digitalWrite(CSS, LOW);
  SPI.transfer16(0x2001);
  SPI.transfer16(0x1000);
  digitalWrite(CSS, HIGH);

  delay(10000);

  digitalWrite(CSS, LOW);
  SPI.transfer16(0x2000);
  SPI.transfer16(0x0000);
  digitalWrite(CSS, HIGH);
  
}
