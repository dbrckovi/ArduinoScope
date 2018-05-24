using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoStudio
{
  public enum RequestType
  {
    //Comments list parameter types and usage. TODO: Convert to some kind of object which will handle parameters automatically

    Error = 0,              //No
    Test = 1,               //Any string
    GetVersion = 2,         //No
    PinMode = 3,            //int (pin number), bool (1 = OUTPUT, 0 = INPUT)
    DigitalWrite = 4,       //int (pon number), bool (1 = HIGH, 0 = LOW)
    Debug = 5,              //No
    TestBaud = 6,           //int (baud rate), any string
    SetBaud = 7,            //int (baud rate)
    AnalogWrite = 8,        //int (pin number), byte (value)
    AnalogRead = 9,         //int (analog pin number), int (value)
    Tone = 10,              //int (pin number), int (frequency), int (duration in miliseconds)
    NoTone = 11,            //int (pin number)
  }
}
