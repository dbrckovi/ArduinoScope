using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoScope
{
  public enum VoltageUnit
  {
    [Description("µV")]
    MicroVolts = 0,

    [Description("mV")]
    MiliVolts = 1,

    [Description("V")]
    Volts = 2
  }
}
