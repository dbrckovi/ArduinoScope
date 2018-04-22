using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoScope
{
  public enum TimeUnit
  {
    [Description("µs")]
    MicroSeconds = 0,

    [Description("ms")]
    Miliseconds = 1,

    [Description("s")]
    Seconds = 2,
  }
}
