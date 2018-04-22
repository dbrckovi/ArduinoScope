//http://yaab-arduino.blogspot.hr/2015/02/fast-sampling-from-analog-input.html

#define cbi(sfr, bit) (_SFR_BYTE(sfr) &= ~_BV(bit))
#define sbi(sfr, bit) (_SFR_BYTE(sfr) |= _BV(bit))

unsigned long start = 0;
unsigned long duration = 0;
byte value = 0;

void setup() 
{
  sbi(ADCSRA, ADPS2);
  cbi(ADCSRA, ADPS1);
  cbi(ADCSRA, ADPS0);
  
  Serial.begin(500000);
}

void loop() 
{
  value = (byte)(analogRead(0) >> 2);
  Serial.write(value);
}
