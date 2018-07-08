using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoStudio
{
  public enum DigitalPinMode
  {
    BoolRead = 0,
    BoolWrite = 1,
    Pwm = 2,
    Tone = 3,
    NoTone = 4
  }
}
