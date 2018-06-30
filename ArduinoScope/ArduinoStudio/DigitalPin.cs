using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoStudio
{
  /// <summary>
  /// Describes a state of digital pin
  /// </summary>
  public class DigitalPin
  {
    public int PinNumber = 0;
    public PinMode PinMode = PinMode.Output;
    public DigitalOutMode OutputMode = DigitalOutMode.Boolean;

    /// <summary>
    /// When PinMode is Input, holds the last received boolean value on the pin
    /// </summary>
    public bool InputBool = false;

    /// <summary>
    /// When PinMode is Output and OutputMode is Boolean, holds the last boolean value the pin was set to
    /// </summary>
    public bool OutputBool = false;

    /// <summary>
    /// When PinMode is Output and OutputMode is PWM, holds the last duty cycle the pin was set to
    /// </summary>
    public byte OutputPwm = 0;

    /// <summary>
    /// When PinMode is Output and OutputMode is Tone, holds the last frequency the pin tone signal was set to
    /// </summary>
    public int OutputToneFrequency = 440;

    /// <summary>
    /// When PinMode is Output and OutputMode is Tone, holds the duration of the last tone signal
    /// </summary>
    public int OutputToneDuration = 0;

    public DigitalPin(int number)
    {
      PinNumber = number;
    }
  }
}
