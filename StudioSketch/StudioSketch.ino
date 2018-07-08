const int VERSION = 1;



//STATUS VARIABLES
//These hold current status (mode and value) of each pin

int _digital_mode[14];                       //holds current digital pin mode 
bool _digital_bool[14];                      //holds last bool value on the digital pin (both input or output. Depending on pin mode)
int _digital_pwm[14];                        //holds last pwm value that was sent to the pin
unsigned int _digital_tone_frequency[14];    //holds last tone frequency that was sent to the pin
long _digital_tone_duration[14];             //holds last tone duration that was sent to the pin
int _analog_value[6];                        //holds last value on each analog pin

const int DIGITAL_PIN_MODE_BOOL_READ = 0;       //pin is in boolean read mode
const int DIGITAL_PIN_MODE_BOOL_WRITE = 1;      //pin is in boolean write mode
const int DIGITAL_PIN_MODE_PWM = 2;           //pin is in pwm output mode 
const int DIGITAL_PIN_MODE_TONE = 3;          //pin is in tone output mode
const int DIGITAL_PIN_MODE_NO_TONE = 4;       //pin is in no tone output mode 

const int MAX_REQUEST_PARTS = 8;

const int REQUEST_GET_VERSION = 0;
const int REQUEST_RESET_PINS = 1;
const int REQUEST_GET_PIN_STATUS = 2;
const int REQUEST_DIGITAL_READ = 3;
const int REQUEST_DIGITAL_WRITE = 4;
const int REQUEST_PWM = 5;
const int REQUEST_TONE = 6;
const int REQUEST_NO_TONE = 7;
const int REQUEST_ANALOG_READ = 8;
const int REQUEST_GET_PIN_CONFIG = 9;
const int REQUEST_DEBUG = 10;

const int RESPONSE_ERROR = 0;
const int RESPONSE_OK = 1;

String _debug = "";

// Tells whether pin supports PWM and Tone modes
bool supportsPwm (int pin)
{
  int arduinoUno_pwmPins[] = { 3,5,6,9,10,11 };

  for (int x = 0; x < sizeof(arduinoUno_pwmPins) / sizeof(int); x++)
  {
    if (arduinoUno_pwmPins[x] == pin) return true;
  }
  
  return false;
}

void setup() 
{
  ResetPins(true);
  Serial.begin(500000);
  Serial.setTimeout(50);
}

void loop() 
{
  if (Serial.available() > 0) 
  {
    GetAndParseRequest();
  }
  
  delay(1);
}

//Parses request sent from host application and performs the requested action
void GetAndParseRequest()
{
  String request = Serial.readString();
  String parts[MAX_REQUEST_PARTS];
  int lastPartIndex = SplitString(request, '|', parts);

  int requestType = parts[0].toInt();

  switch (requestType)
  {
    case REQUEST_GET_VERSION:
    {
      SendResponse(RESPONSE_OK, String(VERSION));
      break;
    }
    
    case REQUEST_RESET_PINS:
    {
      ResetPins(false);
      SendResponse(RESPONSE_OK);
      break;
    }
    
    case REQUEST_GET_PIN_STATUS:
    {
      SendResponse(RESPONSE_OK, GeneratePinStatus());
      break;
    }

    case REQUEST_DIGITAL_READ:
    {
      int pin = parts[1].toInt();
      if (!CheckDigitalPinNumber(pin)) return;
      
      int value = My_DigitalRead(pin);
      SendResponse(RESPONSE_OK, String(value));
      break;
    }
    
    case REQUEST_DIGITAL_WRITE:
    {
      int pin = parts[1].toInt();
      if (!CheckDigitalPinNumber(pin)) return;
      
      int value = parts[2].toInt();
      My_DigitalWrite(pin, value);
      SendResponse(RESPONSE_OK);
      break;
    }

    case REQUEST_PWM:
    {
      int pin = parts[1].toInt();
      if (!CheckDigitalPinNumber(pin)) return;
      
      int value = parts[2].toInt();
      My_Pwm(pin, value);
      SendResponse(RESPONSE_OK);
      break;
    }

    case REQUEST_TONE:
    {
      int pin = parts[1].toInt();
      if (!CheckDigitalPinNumber(pin)) return;
      
      unsigned int frequency = parts[2].toInt();
      unsigned long duration = parts[3].toInt();
      My_Tone(pin, frequency, duration);
      SendResponse(RESPONSE_OK);
      break;
    }
    
    case REQUEST_NO_TONE:
    {
      int pin = parts[1].toInt();
      if (!CheckDigitalPinNumber(pin)) return;
      
      My_NoTone(pin);
      SendResponse(RESPONSE_OK);
      break;
    }
    
    case REQUEST_ANALOG_READ:
    {
      int pin = parts[1].toInt();
      if (!CheckAnalogPinNumber(pin)) return;
      
      int value = My_AnalogRead(pin);
      SendResponse(RESPONSE_OK, String(value));
      break;
    }

    case REQUEST_GET_PIN_CONFIG:
    {
      SendResponse(RESPONSE_OK, GeneratePinConfig());
      break;
    }

    case REQUEST_DEBUG:
    {
      SendResponse(RESPONSE_OK, Debug());
      break;
    }
  }
}

String Debug()
{
  int pin = 2;
  
  String ret = "D" + String(pin);
  ret += ":M" + String(_digital_mode[pin]);

  switch (_digital_mode[pin])
  {
    case DIGITAL_PIN_MODE_BOOL_READ:
    case DIGITAL_PIN_MODE_BOOL_WRITE:
    {
      String temp = _digital_bool[pin] ? "1" : "0";
      ret += ":V" + temp;
      break;
    }
    case DIGITAL_PIN_MODE_PWM:
    {
      ret += ":V" + String(_digital_pwm[pin]);
      break;
    }
    case DIGITAL_PIN_MODE_TONE:
    {
      ret += ":F" + String(_digital_tone_frequency[pin]);
      ret += ":L" + String(_digital_tone_duration[pin]);
      break;
    }
  }

  return ret;

}

int SplitString(String input, char separator, String outputParts[])
{
  int currentPart = 0;
  int x = 0;
  int inputLength = input.length();

  while (x < inputLength)
  {
    char character = input.charAt(x);
    if (character == '|') 
    {
      currentPart++;
      if (currentPart >= MAX_REQUEST_PARTS) 
      {
        currentPart--;
        break;
      }
    }
    else
    {
      outputParts[currentPart] += character;
    }
    x++;
  }

  return currentPart;
}

void SendResponse(int responseType, String text)
{
  Serial.print(String(responseType) + "|" + text);
}

void SendResponse(int responseType)
{
  Serial.print(String(responseType));
}

void SendError(String errorText)
{
  SendResponse(RESPONSE_ERROR, errorText);
}

//Checks whether digital pin exists and sends appropriate error response if it doesn't
bool CheckDigitalPinNumber(int pin)
{
  if (pin < 0 || pin >= sizeof(_digital_bool))
  {
    SendError("Digital pin '" + String(pin) + "' doesn't exist");
    return false;
  }
  else return true;
}

//Checks whether digital pin exists and sends appropriate error response if it doesn't
bool CheckAnalogPinNumber(int pin)
{
  if (pin < 0 || pin >= sizeof(_analog_value) / sizeof(int))
  {
    SendError("Analog pin '" + String(pin) + "' doesn't exist");
    return false;
  }
  else return true;
}

//Initializes pins to default modes and values
void ResetPins(bool showEffect)
{
  int pinCount = sizeof(_digital_bool);

  if (showEffect)
  {
  
    for (int x = 0; x < pinCount; x++)
    {
      My_DigitalWrite(x, false);
    }

    for (int x = 0; x < pinCount; x++)
    {
      if (x > 0) My_DigitalWrite(x-1, false);
      My_DigitalWrite(x, true);
      delay(20);
    }

    for (int x = pinCount; x >= 0; x--)
    {
      if (x < pinCount) My_DigitalWrite(x+1, false);
      My_DigitalWrite(x, true);
      delay(20);
    }

    My_DigitalWrite(0, false);
  }
  else
  {
    for (int x = 0; x < pinCount; x++)
    {
      My_DigitalWrite(x, false);
    }
  }
}

//Generates string for transfering status of all digital and analog pins
String GeneratePinStatus()
{
  int digitalPinCount = sizeof(_digital_bool);
  int analogPinCount = sizeof(_analog_value) / sizeof(int);
  
  String ret = "";

  for (int x = 0; x < digitalPinCount; x++)
  {
    ret += GenerateDigitalPinStatus(x) + ",";
  }

  for (int x = 0; x < analogPinCount; x++)
  {
    ret += GenerateAnalogPinStatus(x);
    if (x < analogPinCount - 1) ret += ",";
  }
    
  return ret;
}

//Generates string for transfering pin status of a single digital pin
String GenerateDigitalPinStatus(int pin)
{
  if (_digital_mode[pin] == DIGITAL_PIN_MODE_BOOL_READ) My_DigitalRead(pin);
  
  String ret = "D" + String(pin);
  ret += ":M" + String(_digital_mode[pin]);

  switch (_digital_mode[pin])
  {
    case DIGITAL_PIN_MODE_BOOL_READ:
    case DIGITAL_PIN_MODE_BOOL_WRITE:
    {
      String value = _digital_bool[pin] ? "1" : "0";
      ret += ":V" + value;
      break;
    }
    case DIGITAL_PIN_MODE_PWM:
    {
      ret += ":V" + String(_digital_pwm[pin]);
      break;
    }
    case DIGITAL_PIN_MODE_TONE:
    {
      ret += ":F" + String(_digital_tone_frequency[pin]);
      ret += ":L" + String(_digital_tone_duration[pin]);
      break;
    }
  }

  return ret;
}

//Generates string for transfering pin status of a single analog pin
String GenerateAnalogPinStatus(int pin)
{
  My_AnalogRead(pin);
  
  String ret = "A" + String(pin);
  ret += ":V" + String(_analog_value[pin]);
  return ret;
}

//Generates string for transfering configuration of all digital and analog pins
String GeneratePinConfig()
{
  int digitalPinCount = sizeof(_digital_bool);
  int analogPinCount = sizeof(_analog_value) / sizeof(int);

  String ret = "";

  for (int x = 0; x < digitalPinCount; x++)
  {
    ret += "D" + String(x) + ":";
    String supports = supportsPwm(x) ? "1" : "0";
    ret += "S" + supports + ",";
  }

  for (int x = 0; x < analogPinCount; x++)
  {
    ret += "A" + String(x);
    if (x < analogPinCount - 1) ret += ",";
  }

  return ret;
}

//all functions which begin with "My" are wrappers which call the underlaying arduino method, update the global variables and change the pin mode if required




//sets digital pin into specified mode. If pin was in tone mode, sends the NoTone first
void My_PinMode(int pin, int mode)
{
  if (mode != DIGITAL_PIN_MODE_TONE && _digital_mode[pin] == DIGITAL_PIN_MODE_TONE) noTone(pin);
  
  if (mode == DIGITAL_PIN_MODE_BOOL_READ) pinMode(pin, INPUT);
  else pinMode(pin, OUTPUT);
  
  _digital_mode[pin] = mode;
}

//Reads bool value from digital pin
bool My_DigitalRead(int pin)
{
  if (_digital_mode[pin] != DIGITAL_PIN_MODE_BOOL_READ) My_PinMode(pin, DIGITAL_PIN_MODE_BOOL_READ);
  
  int value = digitalRead(pin);
  _digital_bool[pin] = value == HIGH;
  
  return _digital_bool[pin];
}

//Outputs HIGH or LOW on digital pin
void My_DigitalWrite(int pin, bool value)
{
  if (_digital_mode[pin] != DIGITAL_PIN_MODE_BOOL_WRITE) My_PinMode(pin, DIGITAL_PIN_MODE_BOOL_WRITE);
  
  _digital_bool[pin] = value;
  digitalWrite(pin, value ? HIGH : LOW);
}

//Outputs PWM signal on digital pin
void My_Pwm(int pin, int value)
{
  if (_digital_mode[pin] != DIGITAL_PIN_MODE_PWM) My_PinMode(pin, DIGITAL_PIN_MODE_PWM);

  if (value < 0) value = 0;
  else if (value > 255) value = 255;

  _digital_pwm[pin] = value;
  analogWrite(pin, value);
}

//Outputs tone signal on digital pin
void My_Tone(int pin, unsigned int frequency, long duration)
{
  if (_digital_mode[pin] != DIGITAL_PIN_MODE_TONE) My_PinMode(pin, DIGITAL_PIN_MODE_TONE);

  if (frequency < 31) frequency = 31;
  else if (frequency > 20000) frequency = 20000;

  if (duration < 0) duration = 0;

  _digital_tone_frequency[pin] = frequency;
  _digital_tone_duration[pin] = duration;
  
  tone(pin, frequency, duration);
}

//Stops the tone on digital pin
void My_NoTone(int pin)
{
  if (_digital_mode[pin] != DIGITAL_PIN_MODE_NO_TONE) My_PinMode(pin, DIGITAL_PIN_MODE_NO_TONE);
  else noTone(pin);
  //My_PinMode calls noTone() when mode is chnaged, so it's not needed to set it in the first case
}


//Reads the value on the analog pin
int My_AnalogRead(int pin)
{
  int value = analogRead(pin);
  _analog_value[pin] = value;

  return value;
}








/*      TODO....

 - change _digital_bool to bit field because it's consuming 1 byte of memory for 1 bit value

*/














