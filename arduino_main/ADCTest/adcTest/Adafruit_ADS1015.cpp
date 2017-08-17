/**************************************************************************/
/*!
    @file     Adafruit_ADS1015.cpp
    @author   K.Townsend (Adafruit Industries)
    @license  BSD (see license.txt)

    Driver for the ADS1015/ADS1115 ADC

    This is a library for the Adafruit MPL115A2 breakout
    ----> https://www.adafruit.com/products/???

    Adafruit invests time and resources providing this open source code,
    please support Adafruit and open-source hardware by purchasing
    products from Adafruit!

    @section  HISTORY

    v1.0 - First release
*/
/**************************************************************************/
#if ARDUINO >= 100
 #include "Arduino.h"
#else
 #include "WProgram.h"
#endif

#include <Wire.h>

#include "Adafruit_ADS1015.h"
/**************************************************************************/
/*!
    @brief  Abstract away platform differences in Arduino wire library
*/
/**************************************************************************/
static uint8_t i2cread(void) {
  #if ARDUINO >= 100
  return Wire.read();
  #else
  return Wire.receive();
  #endif
}

/**************************************************************************/
/*!
    @brief  Abstract away platform differences in Arduino wire library
*/
/**************************************************************************/
static void i2cwrite(uint8_t x) {
  #if ARDUINO >= 100
  Wire.write((uint8_t)x);
  #else
  Wire.send(x);
  #endif
}

/**************************************************************************/
/*!
    @brief  Writes 16-bits to the specified destination register
*/
/**************************************************************************/
static void writeRegister(uint8_t i2cAddress, uint8_t reg, uint16_t value) {
  Wire.beginTransmission(i2cAddress);
  i2cwrite((uint8_t)reg);
  i2cwrite((uint8_t)(value>>8));
  i2cwrite((uint8_t)(value & 0xFF));
  Wire.endTransmission();
}

/**************************************************************************/
/*!
    @brief  Writes 16-bits to the specified destination register
*/
/**************************************************************************/
static uint16_t readRegister(uint8_t i2cAddress, uint8_t reg) {
  Wire.beginTransmission(i2cAddress);
  i2cwrite(ADS1015_REG_POINTER_CONVERT);
  Wire.endTransmission();
  Wire.requestFrom(i2cAddress, (uint8_t)2);
  return ((i2cread() << 8) | i2cread());  
}

/**************************************************************************/
/*!
    @brief  Instantiates a new ADS1015 class w/appropriate properties
*/
/**************************************************************************/
Adafruit_ADS1015::Adafruit_ADS1015(uint8_t i2cAddress) 
{
   m_i2cAddress = i2cAddress;
   m_conversionDelay = ADS1015_CONVERSIONDELAY;
   m_bitShift = 4;
   m_gain = GAIN_TWOTHIRDS; /* +/- 6.144V range (limited to VDD +0.3V max!) */
}

/**************************************************************************/
/*!
    @brief  Instantiates a new ADS1115 class w/appropriate properties
*/
/**************************************************************************/
Adafruit_ADS1115::Adafruit_ADS1115(uint8_t i2cAddress)
{
   m_i2cAddress = i2cAddress;
   m_conversionDelay = ADS1115_CONVERSIONDELAY;
   m_bitShift = 0;
   m_gain = GAIN_TWOTHIRDS; /* +/- 6.144V range (limited to VDD +0.3V max!) */
}

/**************************************************************************/
/*!
    @brief  Sets up the HW (reads coefficients values, etc.)
*/
/**************************************************************************/
void Adafruit_ADS1015::begin() {
  Wire.begin();
}

/**************************************************************************/
/*!
    @brief  Sets the gain and input voltage range
*/
/**************************************************************************/
void Adafruit_ADS1015::setGain(adsGain_t gain)
{
  m_gain = gain;
}

/**************************************************************************/
/*!
    @brief  Gets a gain and input voltage range
*/
/**************************************************************************/
adsGain_t Adafruit_ADS1015::getGain()
{
  return m_gain;
}

/**************************************************************************/
/*!
    @brief  Gets a single-ended ADC reading from the specified channel
*/
/**************************************************************************/
uint16_t Adafruit_ADS1015::readADC_SingleEnded(uint8_t channel) {
  if (channel > 3)
  {
    return 0;
  }
  
  // Start with default values
  uint16_t config = ADS1015_REG_CONFIG_CQUE_NONE    | // Disable the comparator (default val)
                    ADS1015_REG_CONFIG_CLAT_NONLAT  | // Non-latching (default val)
                    ADS1015_REG_CONFIG_CPOL_ACTVLOW | // Alert/Rdy active low   (default val)
                    ADS1015_REG_CONFIG_CMODE_TRAD   | // Traditional comparator (default val)
                    ADS1015_REG_CONFIG_DR_1600SPS   | // 1600 samples per second (default)
                    ADS1015_REG_CONFIG_MODE_SINGLE;   // Single-shot mode (default)

  // Set PGA/voltage range
  config |= m_gain;

  // Set single-ended input channel
  switch (channel)
  {
    case (0):
      config |= ADS1015_REG_CONFIG_MUX_SINGLE_0;
      break;
    case (1):
      config |= ADS1015_REG_CONFIG_MUX_SINGLE_1;
      break;
    case (2):
      config |= ADS1015_REG_CONFIG_MUX_SINGLE_2;
      break;
    case (3):
      config |= ADS1015_REG_CONFIG_MUX_SINGLE_3;
      break;
  }

  // Set 'start single-conversion' bit
  config |= ADS1015_REG_CONFIG_OS_SINGLE;

  // Write config register to the ADC
  writeRegister(m_i2cAddress, ADS1015_REG_POINTER_CONFIG, config);

  // Wait for the conversion to complete
  delay(m_conversionDelay);

  // Read the conversion results
  // Shift 12-bit results right 4 bits for the ADS1015
  return readRegister(m_i2cAddress, ADS1015_REG_POINTER_CONVERT) >> m_bitShift;  
}

/**************************************************************************/
/*! 
    @brief  Reads the conversion results, measuring the voltage
            difference between the P (AIN0) and N (AIN1) input.  Generates
            a signed value since the difference can be either
            positive or negative.
*/
/**************************************************************************/
int16_t Adafruit_ADS1015::readADC_Differential_0_1() {
  // Start with default values
  uint16_t config = ADS1015_REG_CONFIG_CQUE_NONE    | // Disable the comparator (default val)
                    ADS1015_REG_CONFIG_CLAT_NONLAT  | // Non-latching (default val)
                    ADS1015_REG_CONFIG_CPOL_ACTVLOW | // Alert/Rdy active low   (default val)
                    ADS1015_REG_CONFIG_CMODE_TRAD   | // Traditional comparator (default val)
                    ADS1015_REG_CONFIG_DR_1600SPS   | // 1600 samples per second (default)
                    ADS1015_REG_CONFIG_MODE_SINGLE;   // Single-shot mode (default)

  // Set PGA/voltage range
  config |= m_gain;
                    
  // Set channels
  config |= ADS1015_REG_CONFIG_MUX_DIFF_0_1;          // AIN0 = P, AIN1 = N

  // Set 'start single-conversion' bit
  config |= ADS1015_REG_CONFIG_OS_SINGLE;

  // Write config register to the ADC
  writeRegister(m_i2cAddress, ADS1015_REG_POINTER_CONFIG, config);

  // Wait for the conversion to complete
  delay(m_conversionDelay);

  // Read the conversion results
  uint16_t res = readRegister(m_i2cAddress, ADS1015_REG_POINTER_CONVERT) >> m_bitShift;
  if (m_bitShift == 0)
  {
    return (int16_t)res;
  }
  else
  {
    // Shift 12-bit results right 4 bits for the ADS1015,
    // making sure we keep the sign bit intact
    if (res > 0x07FF)
    {
      // negative number - extend the sign to 16th bit
      res |= 0xF000;
    }
    return (int16_t)res;
  }
}

/**************************************************************************/
/*! 
    @brief  Reads the conversion results, measuring the voltage
            difference between the P (AIN2) and N (AIN3) input.  Generates
            a signed value since the difference can be either
            positive or negative.
*/
/**************************************************************************/
int16_t Adafruit_ADS1015::readADC_Differential_2_3() {
  // Start with default values
  uint16_t config = ADS1015_REG_CONFIG_CQUE_NONE    | // Disable the comparator (default val)
                    ADS1015_REG_CONFIG_CLAT_NONLAT  | // Non-latching (default val)
                    ADS1015_REG_CONFIG_CPOL_ACTVLOW | // Alert/Rdy active low   (default val)
                    ADS1015_REG_CONFIG_CMODE_TRAD   | // Traditional comparator (default val)
                    ADS1015_REG_CONFIG_DR_1600SPS   | // 1600 samples per second (default)
                    ADS1015_REG_CONFIG_MODE_SINGLE;   // Single-shot mode (default)

  // Set PGA/voltage range
  config |= m_gain;

  // Set channels
  config |= ADS1015_REG_CONFIG_MUX_DIFF_2_3;          // AIN2 = P, AIN3 = N

  // Set 'start single-conversion' bit
  config |= ADS1015_REG_CONFIG_OS_SINGLE;

  // Write config register to the ADC
  writeRegister(m_i2cAddress, ADS1015_REG_POINTER_CONFIG, config);

  // Wait for the conversion to complete
  delay(m_conversionDelay);

  // Read the conversion results
  uint16_t res = readRegister(m_i2cAddress, ADS1015_REG_POINTER_CONVERT) >> m_bitShift;
  if (m_bitShift == 0)
  {
    return (int16_t)res;
  }
  else
  {
    // Shift 12-bit results right 4 bits for the ADS1015,
    // making sure we keep the sign bit intact
    if (res > 0x07FF)
    {
      // negative number - extend the sign to 16th bit
      res |= 0xF000;
    }
    return (int16_t)res;
  }
}

/**************************************************************************/
/*!
    @brief  Sets up the comparator to operate in basic mode, causing the
            ALERT/RDY pin to assert (go from high to low) when the ADC
            value exceeds the specified threshold.

            This will also set the ADC in continuous conversion mode.
*/
/**************************************************************************/
void Adafruit_ADS1015::startComparator_SingleEnded(uint8_t channel, int16_t threshold)
{
  // Start with default values
  uint16_t config = ADS1015_REG_CONFIG_CQUE_1CONV   | // Comparator enabled and asserts on 1 match
                    ADS1015_REG_CONFIG_CLAT_LATCH   | // Latching mode
                    ADS1015_REG_CONFIG_CPOL_ACTVLOW | // Alert/Rdy active low   (default val)
                    ADS1015_REG_CONFIG_CMODE_TRAD   | // Traditional comparator (default val)
                    ADS1015_REG_CONFIG_DR_1600SPS   | // 1600 samples per second (default)
                    ADS1015_REG_CONFIG_MODE_CONTIN  | // Continuous conversion mode
                    ADS1015_REG_CONFIG_MODE_CONTIN;   // Continuous conversion mode

  // Set PGA/voltage range
  config |= m_gain;
                    
  // Set single-ended input channel
  switch (channel)
  {
    case (0):
      config |= ADS1015_REG_CONFIG_MUX_SINGLE_0;
      break;
    case (1):
      config |= ADS1015_REG_CONFIG_MUX_SINGLE_1;
      break;
    case (2):
      config |= ADS1015_REG_CONFIG_MUX_SINGLE_2;
      break;
    case (3):
      config |= ADS1015_REG_CONFIG_MUX_SINGLE_3;
      break;
  }

  // Set the high threshold register
  // Shift 12-bit results left 4 bits for the ADS1015
  writeRegister(m_i2cAddress, ADS1015_REG_POINTER_HITHRESH, threshold << m_bitShift);

  // Write config register to the ADC
  writeRegister(m_i2cAddress, ADS1015_REG_POINTER_CONFIG, config);
}

/**************************************************************************/
/*!
    @brief  In order to clear the comparator, we need to read the
            conversion results.  This function reads the last conversion
            results without changing the config value.
*/
/**************************************************************************/
int16_t Adafruit_ADS1015::getLastConversionResults()
{
  // Wait for the conversion to complete
  delay(m_conversionDelay);

  // Read the conversion results
  uint16_t res = readRegister(m_i2cAddress, ADS1015_REG_POINTER_CONVERT) >> m_bitShift;
  if (m_bitShift == 0)
  {
    return (int16_t)res;
  }
  else
  {
    // Shift 12-bit results right 4 bits for the ADS1015,
    // making sure we keep the sign bit intact
    if (res > 0x07FF)
    {
      // negative number - extend the sign to 16th bit
      res |= 0xF000;
    }
    return (int16_t)res;
  }
}


double getCh0()
{
  double adc0;
  Adafruit_ADS1115 ads;  /* Use this for the 16-bit version */
  ads.begin();
  //adc0////////////////////////////////////////////////////////////////////////////////////////////////////////////
  ads.setGain(GAIN_SIXTEEN);    // 16x gain  +/- 0.256V  1 bit = 0.125mV  0.0078125mV
  adc0 = ads.readADC_SingleEnded(0);
  if(adc0*0.0078125 > 250)
  {
    ads.setGain(GAIN_EIGHT);    // 8x gain   +/- 0.512V  1 bit = 0.25mV   0.015625mV
    adc0 = ads.readADC_SingleEnded(0);
    if(adc0*0.015625 > 500)
    {
      ads.setGain(GAIN_FOUR);   // 4x gain   +/- 1.024V  1 bit = 0.5mV    0.03125mV max 1023.97
      adc0 = ads.readADC_SingleEnded(0);
      if(adc0*.03125 > 1000)
      {
        ads.setGain(GAIN_TWO);  // 2x gain   +/- 2.048V  1 bit = 1mV      0.0625mV max 2047.94
        adc0 = ads.readADC_SingleEnded(0);
        if(adc0*.0625 > 2000)
        {
          ads.setGain(GAIN_ONE); // 1x gain   +/- 4.096V  1 bit = 2mV      0.125mV max 4095.87
          adc0 = ads.readADC_SingleEnded(0);
          if(adc0*.125 > 4000)
          {
            ads.setGain(GAIN_TWOTHIRDS); // 2/3x gain +/- 6.144V  1 bit = 3mV      0.1875mV (default) max 5534.44
            adc0 = ads.readADC_SingleEnded(0);
            return adc0*.1875;
            //Serial.print("AIN0: "); Serial.println(adc0*.1875);
          }
          else
          {
            return adc0*.125;
            //Serial.print("AIN0: "); Serial.println(adc0*.125);
          }
        }
        else
        {
          return adc0*.0625;
          //Serial.print("AIN0: "); Serial.println(adc0*.0625);
        }
      }
      else
      {
        return adc0*.03125;
        //Serial.print("AIN0: "); Serial.println(adc0*.03125);
      }
    }
    else
    {
      return adc0*.015625;
      //Serial.print("AIN0: "); Serial.println(adc0*.015625);
    }
  }
  else
  {
    return adc0*.0078125;
    //Serial.print("AIN0: "); Serial.println(adc0*.0078125);
  }
}

double getCh1()
{
  double adc1;
  Adafruit_ADS1115 ads;  /* Use this for the 16-bit version */
  ads.begin();
  //adc1///////////////////////////////////////////////////////////////////////////////////////////////////
  ads.setGain(GAIN_SIXTEEN);    // 16x gain  +/- 0.256V  1 bit = 0.125mV  0.0078125mV
  adc1 = ads.readADC_SingleEnded(1);
  if(adc1*0.0078125 > 250)
  {
    ads.setGain(GAIN_EIGHT);    // 8x gain   +/- 0.512V  1 bit = 0.25mV   0.015625mV
    adc1 = ads.readADC_SingleEnded(1);
    if(adc1*0.015625 > 500)
    {
      ads.setGain(GAIN_FOUR);   // 4x gain   +/- 1.024V  1 bit = 0.5mV    0.03125mV max 1023.97
      adc1 = ads.readADC_SingleEnded(1);
      if(adc1*.03125 > 1000)
      {
        ads.setGain(GAIN_TWO);  // 2x gain   +/- 2.048V  1 bit = 1mV      0.0625mV max 2047.94
        adc1 = ads.readADC_SingleEnded(1);
        if(adc1*.0625 > 2000)
        {
          ads.setGain(GAIN_ONE); // 1x gain   +/- 4.096V  1 bit = 2mV      0.125mV max 4095.87
          adc1 = ads.readADC_SingleEnded(1);
          if(adc1*.125 > 4000)
          {
            ads.setGain(GAIN_TWOTHIRDS); // 2/3x gain +/- 6.144V  1 bit = 3mV      0.1875mV (default) max 5534.44
            adc1 = ads.readADC_SingleEnded(1);
            return ((((adc1*.1875*3)/.924357)-874.42));
            //Serial.print("AIN1: "); Serial.println(((((adc1*.1875*3)/.924357)-874.42)));
          }
          else
          {
            return (((((adc1*.125*3)/.924357)-874.42)));
            //Serial.print("AIN1: "); Serial.println(((((adc1*.125*3)/.924357)-874.42)));
          }
        }
        else
        {
            return (((((adc1*.0625*3)/.924357)-874.42)));
            //Serial.print("AIN1: "); Serial.println(((((adc1*.0625*3)/.924357)-874.42)));
            //Serial.print("AIN1: "); Serial.println(mathFun);
        }
      }
      else
      {
            return (((((adc1*.03125*3)/.924357)-874.42)));
            //Serial.print("AIN1: "); Serial.println(((((adc1*.03125*3)/.924357)-874.42)));
      }
    }
    else
    {
      return (((((adc1*.015625*3)/.924357)-874.42)));
      //Serial.print("AIN1: "); Serial.println(((((adc1*.015625*3)/.924357)-874.42)));
    }
  }
  else
  {
    return (((((adc1*.0078125*3)/.924357)-874.42)));
    //Serial.print("AIN1: "); Serial.println(((((adc1*.0078125*3)/.924357)-874.42)));
  }
}

double getCh2()
{
  double adc2;
  Adafruit_ADS1115 ads;  /* Use this for the 16-bit version */
  ads.begin();
    //adc2///////////////////////////////////////////////////////////////////////////////////////////////////
  ads.setGain(GAIN_SIXTEEN);    // 16x gain  +/- 0.256V  1 bit = 0.125mV  0.0078125mV
  adc2 = ads.readADC_SingleEnded(2);
  if(adc2*0.0078125 > 250)
  {
    ads.setGain(GAIN_EIGHT);    // 8x gain   +/- 0.512V  1 bit = 0.25mV   0.015625mV
    adc2 = ads.readADC_SingleEnded(2);
    if(adc2*0.015625 > 500)
    {
      ads.setGain(GAIN_FOUR);   // 4x gain   +/- 1.024V  1 bit = 0.5mV    0.03125mV max 1023.97
      adc2 = ads.readADC_SingleEnded(2);
      if(adc2*.03125 > 1000)
      {
        ads.setGain(GAIN_TWO);  // 2x gain   +/- 2.048V  1 bit = 1mV      0.0625mV max 2047.94
        adc2 = ads.readADC_SingleEnded(2);
        if(adc2*.0625 > 2000)
        {
          ads.setGain(GAIN_ONE); // 1x gain   +/- 4.096V  1 bit = 2mV      0.125mV max 4095.87
          adc2 = ads.readADC_SingleEnded(2);
          if(adc2*.125 > 4000)
          {
            ads.setGain(GAIN_TWOTHIRDS); // 2/3x gain +/- 6.144V  1 bit = 3mV      0.1875mV (default) max 5534.44
            adc2 = ads.readADC_SingleEnded(2);
            return adc2*-.1875;
            //Serial.print("AIN2: "); Serial.println(adc2*-.1875);
          }
          else
          {
            return adc2*-.125;
           // Serial.print("AIN2: "); Serial.println(adc2*-.125);
          }
        }
        else
        {
          return adc2*-.0625;
          //Serial.print("AIN2: "); Serial.println(adc2*-.0625);
        }
      }
      else
      {
        return adc2*-.03125;
        //Serial.print("AIN2: "); Serial.println(adc2*-.03125);
      }
    }
    else
    {
      return adc2*-.015625;
      //Serial.print("AIN2: "); Serial.println(adc2*-.015625);
    }
  }
  else
  {
    return adc2*-.0078125;
    //Serial.print("AIN2: "); Serial.println(adc2*-.0078125);
  }
}

double getCh3()
{
  double adc3;
  Adafruit_ADS1115 ads;  /* Use this for the 16-bit version */
  ads.begin();
  //adc3///////////////////////////////////////////////////////////////////////////////////////////////////
  ads.setGain(GAIN_SIXTEEN);    // 16x gain  +/- 0.256V  1 bit = 0.125mV  0.0078125mV
  adc3 = ads.readADC_SingleEnded(3);
  if(adc3*0.0078125 > 250)
  {
    ads.setGain(GAIN_EIGHT);    // 8x gain   +/- 0.512V  1 bit = 0.25mV   0.015625mV
    adc3 = ads.readADC_SingleEnded(3);
    if(adc3*0.015625 > 500)
    {
      ads.setGain(GAIN_FOUR);   // 4x gain   +/- 1.024V  1 bit = 0.5mV    0.03125mV max 1023.97
      adc3 = ads.readADC_SingleEnded(3);
      if(adc3*.03125 > 1000)
      {
        ads.setGain(GAIN_TWO);  // 2x gain   +/- 2.048V  1 bit = 1mV      0.0625mV max 2047.94
        adc3 = ads.readADC_SingleEnded(3);
        if(adc3*.0625 > 2000)
        {
          ads.setGain(GAIN_ONE); // 1x gain   +/- 4.096V  1 bit = 2mV      0.125mV max 4095.87
          adc3 = ads.readADC_SingleEnded(3);
          if(adc3*.125 > 4000)
          {
            ads.setGain(GAIN_TWOTHIRDS); // 2/3x gain +/- 6.144V  1 bit = 3mV      0.1875mV (default) max 5534.44
            adc3 = ads.readADC_SingleEnded(3);
            return (((adc3*-.1875*3)/.912929)+886.575);
            //Serial.print("AIN3: "); Serial.println(((adc3*-.1875*3)/.912929)+886.575);
          }
          else
          {
            return (((adc3*-.125*3)/.912929)+886.575);
            //Serial.print("AIN3: "); Serial.println(((adc3*-.125*3)/.912929)+886.575);
          }
        }
        else
        {
          return (((adc3*-.0625*3)/.912929)+886.575);
          //Serial.print("AIN3: "); Serial.println(((adc3*-.0625*3)/.912929)+886.575);
        }
      }
      else
      {
        return (((adc3*-.03125*3)/.912929)+886.575);
        //Serial.print("AIN3: "); Serial.println(((adc3*-.03125*3)/.912929)+886.575);
      }
    }
    else
    {
      return (((adc3*-.015625*3)/.912929)+886.575);
      //Serial.print("AIN3: "); Serial.println(((adc3*-.015625*3)/.912929)+886.575);
    }
  }
  else
  {
    return (((adc3*-.0078125*3)/.912929)+886.575);
    //Serial.print("AIN3: "); Serial.println(((adc3*-.0078125*3)/.912929)+886.575);
  }
}

