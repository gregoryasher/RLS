//#include <Wire.h>
//#include "Adafruit_ADS1015.h"
//
//Adafruit_ADS1115 ads;  /* Use this for the 16-bit version */
////Adafruit_ADS1015 ads;     /* Use thi for the 12-bit version */
//
//void setup(void) 
//{
//  Serial.begin(9600);
//  Serial.println("Hello!");
//  
//  Serial.println("Getting single-ended readings from AIN0..3");
//  Serial.println("ADC Range: +/- 6.144V (1 bit = 3mV/ADS1015, 0.1875mV/ADS1115)");
//  
//  // The ADC input range (or gain) can be changed via the following
//  // functions, but be careful never to exceed VDD +0.3V max, or to
//  // exceed the upper and lower limits if you adjust the input range!
//  // Setting these values incorrectly may destroy your ADC!
//  //                                                                ADS1015  ADS1115
//  //                                                                -------  -------
//  // ads.setGain(GAIN_TWOTHIRDS);  // 2/3x gain +/- 6.144V  1 bit = 3mV      0.1875mV (default) max 5534.44 use < 5500
//  // ads.setGain(GAIN_ONE);        // 1x gain   +/- 4.096V  1 bit = 2mV      0.125mV max 4095.87
//  // ads.setGain(GAIN_TWO);        // 2x gain   +/- 2.048V  1 bit = 1mV      0.0625mV max 2047.94
//  // ads.setGain(GAIN_FOUR);       // 4x gain   +/- 1.024V  1 bit = 0.5mV    0.03125mV max 1023.97
//  // ads.setGain(GAIN_EIGHT);      // 8x gain   +/- 0.512V  1 bit = 0.25mV   0.015625mV max 511.98
//  // ads.setGain(GAIN_SIXTEEN);    // 16x gain  +/- 0.256V  1 bit = 0.125mV  0.0078125mV max 255.99
//  
//  ads.begin();
//}
//
//void loop(void) 
//{
//  //volatile int16_t adc0, adc1, adc2, adc3;
//  double adc0, adc1, adc2, adc3;
//
//  //adc0////////////////////////////////////////////////////////////////////////////////////////////////////////////
//  ads.setGain(GAIN_SIXTEEN);    // 16x gain  +/- 0.256V  1 bit = 0.125mV  0.0078125mV
//  adc0 = ads.readADC_SingleEnded(0);
//  if(adc0*0.0078125 > 250)
//  {
//    ads.setGain(GAIN_EIGHT);    // 8x gain   +/- 0.512V  1 bit = 0.25mV   0.015625mV
//    adc0 = ads.readADC_SingleEnded(0);
//    if(adc0*0.015625 > 500)
//    {
//      ads.setGain(GAIN_FOUR);   // 4x gain   +/- 1.024V  1 bit = 0.5mV    0.03125mV max 1023.97
//      adc0 = ads.readADC_SingleEnded(0);
//      if(adc0*.03125 > 1000)
//      {
//        ads.setGain(GAIN_TWO);  // 2x gain   +/- 2.048V  1 bit = 1mV      0.0625mV max 2047.94
//        adc0 = ads.readADC_SingleEnded(0);
//        if(adc0*.0625 > 2000)
//        {
//          ads.setGain(GAIN_ONE); // 1x gain   +/- 4.096V  1 bit = 2mV      0.125mV max 4095.87
//          adc0 = ads.readADC_SingleEnded(0);
//          if(adc0*.125 > 4000)
//          {
//            ads.setGain(GAIN_TWOTHIRDS); // 2/3x gain +/- 6.144V  1 bit = 3mV      0.1875mV (default) max 5534.44
//            adc0 = ads.readADC_SingleEnded(0);
//            Serial.print("AIN0: "); Serial.println(adc0*.1875);
//          }
//          else
//          {
//            Serial.print("AIN0: "); Serial.println(adc0*.125);
//          }
//        }
//        else
//        {
//          Serial.print("AIN0: "); Serial.println(adc0*.0625);
//        }
//      }
//      else
//      {
//        Serial.print("AIN0: "); Serial.println(adc0*.03125);
//      }
//    }
//    else
//    {
//      Serial.print("AIN0: "); Serial.println(adc0*.015625);
//    }
//  }
//  else
//  {
//    Serial.print("AIN0: "); Serial.println(adc0*.0078125);
//  }
//
//
//  //adc1///////////////////////////////////////////////////////////////////////////////////////////////////
//  ads.setGain(GAIN_SIXTEEN);    // 16x gain  +/- 0.256V  1 bit = 0.125mV  0.0078125mV
//  adc1 = ads.readADC_SingleEnded(1);
//  if(adc1*0.0078125 > 250)
//  {
//    ads.setGain(GAIN_EIGHT);    // 8x gain   +/- 0.512V  1 bit = 0.25mV   0.015625mV
//    adc1 = ads.readADC_SingleEnded(1);
//    if(adc1*0.015625 > 500)
//    {
//      ads.setGain(GAIN_FOUR);   // 4x gain   +/- 1.024V  1 bit = 0.5mV    0.03125mV max 1023.97
//      adc1 = ads.readADC_SingleEnded(1);
//      if(adc1*.03125 > 1000)
//      {
//        ads.setGain(GAIN_TWO);  // 2x gain   +/- 2.048V  1 bit = 1mV      0.0625mV max 2047.94
//        adc1 = ads.readADC_SingleEnded(1);
//        if(adc1*.0625 > 2000)
//        {
//          ads.setGain(GAIN_ONE); // 1x gain   +/- 4.096V  1 bit = 2mV      0.125mV max 4095.87
//          adc1 = ads.readADC_SingleEnded(1);
//          if(adc1*.125 > 4000)
//          {
//            ads.setGain(GAIN_TWOTHIRDS); // 2/3x gain +/- 6.144V  1 bit = 3mV      0.1875mV (default) max 5534.44
//            adc1 = ads.readADC_SingleEnded(1);
//            Serial.print("AIN1: "); Serial.println(((((adc1*.1875*3)/.924357)-874.42)));
//          }
//          else
//          {
//            Serial.print("AIN1: "); Serial.println(((((adc1*.125*3)/.924357)-874.42)));
//          }
//        }
//        else
//        {
//            Serial.print("AIN1: "); Serial.println(((((adc1*.0625*3)/.924357)-874.42)));
//            //Serial.print("AIN1: "); Serial.println(mathFun);
//        }
//      }
//      else
//      {
//            Serial.print("AIN1: "); Serial.println(((((adc1*.03125*3)/.924357)-874.42)));
//      }
//    }
//    else
//    {
//      Serial.print("AIN1: "); Serial.println(((((adc1*.015625*3)/.924357)-874.42)));
//    }
//  }
//  else
//  {
//    Serial.print("AIN1: "); Serial.println(((((adc1*.0078125*3)/.924357)-874.42)));
//  }
//
//
//  //adc2///////////////////////////////////////////////////////////////////////////////////////////////////
//  ads.setGain(GAIN_SIXTEEN);    // 16x gain  +/- 0.256V  1 bit = 0.125mV  0.0078125mV
//  adc2 = ads.readADC_SingleEnded(2);
//  if(adc2*0.0078125 > 250)
//  {
//    ads.setGain(GAIN_EIGHT);    // 8x gain   +/- 0.512V  1 bit = 0.25mV   0.015625mV
//    adc2 = ads.readADC_SingleEnded(2);
//    if(adc2*0.015625 > 500)
//    {
//      ads.setGain(GAIN_FOUR);   // 4x gain   +/- 1.024V  1 bit = 0.5mV    0.03125mV max 1023.97
//      adc2 = ads.readADC_SingleEnded(2);
//      if(adc2*.03125 > 1000)
//      {
//        ads.setGain(GAIN_TWO);  // 2x gain   +/- 2.048V  1 bit = 1mV      0.0625mV max 2047.94
//        adc2 = ads.readADC_SingleEnded(2);
//        if(adc2*.0625 > 2000)
//        {
//          ads.setGain(GAIN_ONE); // 1x gain   +/- 4.096V  1 bit = 2mV      0.125mV max 4095.87
//          adc2 = ads.readADC_SingleEnded(2);
//          if(adc2*.125 > 4000)
//          {
//            ads.setGain(GAIN_TWOTHIRDS); // 2/3x gain +/- 6.144V  1 bit = 3mV      0.1875mV (default) max 5534.44
//            adc2 = ads.readADC_SingleEnded(2);
//            Serial.print("AIN2: "); Serial.println(adc2*-.1875);
//          }
//          else
//          {
//            Serial.print("AIN2: "); Serial.println(adc2*-.125);
//          }
//        }
//        else
//        {
//          Serial.print("AIN2: "); Serial.println(adc2*-.0625);
//        }
//      }
//      else
//      {
//        Serial.print("AIN2: "); Serial.println(adc2*-.03125);
//      }
//    }
//    else
//    {
//      Serial.print("AIN2: "); Serial.println(adc2*-.015625);
//    }
//  }
//  else
//  {
//    Serial.print("AIN2: "); Serial.println(adc2*-.0078125);
//  }
//
//  //adc3///////////////////////////////////////////////////////////////////////////////////////////////////
//  ads.setGain(GAIN_SIXTEEN);    // 16x gain  +/- 0.256V  1 bit = 0.125mV  0.0078125mV
//  adc3 = ads.readADC_SingleEnded(3);
//  if(adc3*0.0078125 > 250)
//  {
//    ads.setGain(GAIN_EIGHT);    // 8x gain   +/- 0.512V  1 bit = 0.25mV   0.015625mV
//    adc3 = ads.readADC_SingleEnded(3);
//    if(adc3*0.015625 > 500)
//    {
//      ads.setGain(GAIN_FOUR);   // 4x gain   +/- 1.024V  1 bit = 0.5mV    0.03125mV max 1023.97
//      adc3 = ads.readADC_SingleEnded(3);
//      if(adc3*.03125 > 1000)
//      {
//        ads.setGain(GAIN_TWO);  // 2x gain   +/- 2.048V  1 bit = 1mV      0.0625mV max 2047.94
//        adc3 = ads.readADC_SingleEnded(3);
//        if(adc3*.0625 > 2000)
//        {
//          ads.setGain(GAIN_ONE); // 1x gain   +/- 4.096V  1 bit = 2mV      0.125mV max 4095.87
//          adc3 = ads.readADC_SingleEnded(3);
//          if(adc3*.125 > 4000)
//          {
//            ads.setGain(GAIN_TWOTHIRDS); // 2/3x gain +/- 6.144V  1 bit = 3mV      0.1875mV (default) max 5534.44
//            adc3 = ads.readADC_SingleEnded(3);
//            Serial.print("AIN3: "); Serial.println(((adc3*-.1875*3)/.912929)+886.575);
//          }
//          else
//          {
//            Serial.print("AIN3: "); Serial.println(((adc3*-.125*3)/.912929)+886.575);
//          }
//        }
//        else
//        {
//          Serial.print("AIN3: "); Serial.println(((adc3*-.0625*3)/.912929)+886.575);
//        }
//      }
//      else
//      {
//        Serial.print("AIN3: "); Serial.println(((adc3*-.03125*3)/.912929)+886.575);
//      }
//    }
//    else
//    {
//      Serial.print("AIN3: "); Serial.println(((adc3*-.015625*3)/.912929)+886.575);
//    }
//  }
//  else
//  {
//    Serial.print("AIN3: "); Serial.println(((adc3*-.0078125*3)/.912929)+886.575);
//  }
//
//  Serial.println(" ");
//  
//  delay(1000);
//}

