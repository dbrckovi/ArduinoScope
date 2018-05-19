const int VERSION = 1;

const int REQUEST_MAX_PARTS = 8;
const int REQUEST_ERROR = 0;
const int REQUEST_TEST = 1;
const int REQUEST_GET_VERSION = 2;
const int REQUEST_PIN_MODE = 3;
const int REQUEST_DIGITAL_WRITE = 4;
const int REQUEST_DEBUG = 5;

const int RESPONSE_ERROR = 0;
const int RESPONSE_OK = 1;

String _debug = "";

void Debug()
{
  //response may contain anything. Useful for various debugging purposes
  SendResponse(RESPONSE_OK, _debug);
}

void setup() 
{
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
  String parts[REQUEST_MAX_PARTS];
  int lastPartIndex = SplitString(request, '|', parts);

  int requestType = parts[0].toInt();

  switch (requestType)
  {
    case REQUEST_DEBUG:
    {
      Debug();
      break;
    }
    case REQUEST_ERROR:
    {
      SendResponse(RESPONSE_ERROR, "Error requested, error returned");
      break;
    }
    case REQUEST_TEST:
    {
      SendResponse(RESPONSE_OK, parts[1]);
      break;
    }
    case REQUEST_PIN_MODE:
    {
      int pin = parts[1].toInt();
      int mode = parts[2].toInt();
      pinMode(pin, mode);
      SendResponse(RESPONSE_OK);
      break;
    }
    case REQUEST_DIGITAL_WRITE:
    {
      int pin = parts[1].toInt();
      int value = parts[2].toInt();
      digitalWrite(pin, value);
      SendResponse(RESPONSE_OK);
      break;
    }
    case REQUEST_GET_VERSION:
    {
      SendResponse(RESPONSE_OK, String(VERSION));
      break;
    }
  }
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
      if (currentPart >= REQUEST_MAX_PARTS) 
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

