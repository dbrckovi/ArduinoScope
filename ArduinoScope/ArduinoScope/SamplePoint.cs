using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoScope
{
  public struct SamplePoint
  {
    /// <summary>
    /// Sample value in Volts
    /// </summary>
    public double Value;

    /// <summary>
    /// Time offset (in seconds) since previous sample
    /// </summary>
    public double TimeOffset;
  }
}
