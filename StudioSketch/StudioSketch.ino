const byte VERSION = 66;
const byte COMMAND_GET_VERSION = 1;

bool a = true;

void setup() 
{
  Serial.begin(500000);
  Serial.setTimeout(50);
  pinMode(3, OUTPUT);
}

void loop() 
{
  if (Serial.available() > 0) readSerial();
  delay(1);
}

void readSerial()
{
  int start = millis();
  
  String text = Serial.readString();
  
  int endTime = millis() - start;
  
  Serial.println(endTime);

  if (a) a = false;
  else a = true;

  if (a) digitalWrite(3, HIGH);
  else digitalWrite(3, LOW);
}

