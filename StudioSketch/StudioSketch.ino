const int VERSION = 1;

const int REQUEST_MAX_PARTS = 8;
const int REQUEST_ERROR = 0;
const int REQUEST_TEST = 1;
const int REQUEST_GET_VERSION = 2;

const int RESPONSE_ERROR = 0;
const int RESPONSE_OK = 1;

void setup() 
{
  Serial.begin(9600);
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
  }
    
  /*
  String response;
  for (int x = 0; x <= lastPartIndex; x++)
  {
    if (parts[x].length() > 0) response += parts[x];
  }
  
  Serial.print(response);
  */
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

