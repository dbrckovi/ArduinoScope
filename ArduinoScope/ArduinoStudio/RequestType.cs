using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoStudio
{
  public enum RequestType
  {
    //This must match request statuses in StudioSketch.ino
    //Comments list parameter types and usage. TODO: Convert to some kind of object which will handle parameters automatically

    GetVersion = 0,         //No
    ResetPins = 1,          //No
    GetPinStatus = 2,       //No
    DigitalRead = 3,        //int (pin number)
    DigitalWrite = 4,       //int (pin number), bool (1 = HIGH, 0 = LOW)
    Pwm = 5,                //int (pin number), byte (value)
    Tone = 6,               //int (pin number), int (frequency), int (duration in miliseconds)
    NoTone = 7,             //int (pin number)
    AnalogRead = 8,         //int (analog pin number)
    GetPinConfig = 9,       //No
    Debug = 10,             //No
  }
}
