using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoStudio
{
  /// <summary>
  /// Describes the output mode of digital pin
  /// </summary>
  public enum DigitalOutMode
  {
    /// <summary>
    /// The pin can be directly turned on or off 
    /// </summary>
    Boolean,

    /// <summary>
    /// The pin continuously outputs the PWM signal of the specified duty cycle
    /// </summary>
    PWM,

    /// <summary>
    /// The pin outputs the square wave of the specified frequency and duration.
    /// </summary>
    Tone
  }
}
