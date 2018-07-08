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
    public DigitalPinMode PinMode = DigitalPinMode.BoolRead;

    /// <summary>
    /// Contains pin value for BoolRead and BoolWrite modes
    /// </summary>
    public bool BoolValue = false;

    /// <summary>
    /// Holds pwm value when pin is in Pwm mode
    /// </summary>
    public byte PwmValue = 0;

    /// <summary>
    /// Holds tone frequency when pin is in Tone mode
    /// </summary>
    public int Frequency = 440;

    /// <summary>
    /// Holds tone duration when pin is in Tone mode
    /// </summary>
    public int Duration = 0;

    /// <summary>
    /// Indicates whether pin supports pwm/tone modes
    /// </summary>
    public bool SupportsPwm = false;

    /// <summary>
    /// Constructs new DigitalPin
    /// </summary>
    /// <param name="number">Pin number</param>
    /// <param name="supportsPwm">Indicates whether pin supports PWM and TONE modes</param>
    public DigitalPin(int number, bool supportsPwm)
    {
      PinNumber = number;
      SupportsPwm = supportsPwm;
    }

    /// <summary>
    /// Constructs new Digital with values parsed from config string received from arduino
    /// </summary>
    /// <param name="configString">String containing digital pin configuration information</param>
    public DigitalPin(string configString)
    {
      string[] props = configString.Split(':');

      foreach (string prop in props)
      {
        string key = prop.Substring(0, 1);
        string value = prop.Substring(1, prop.Length - 1);

        switch (key)
        {
          case "D": PinNumber = int.Parse(value); break;
          case "S": SupportsPwm = value == "1"; break;
          default: throw new Exception(string.Format("Config string '{0}' contains properties which don't belong to digital pin configuration", configString));
        }
      }
    }

    /// <summary>
    /// Updates pin status/value from status string received from arduino
    /// </summary>
    /// <param name="statusString">String containing digital pin status information</param>
    public void UpdateStatus(string statusString)
    {
      string[] props = statusString.Split(':');

      string valueTemp = ""; //holds value of V property so it can be parsed at the end when pin mode is known
      
      foreach (string prop in props)
      {
        string key = prop.Substring(0, 1);
        string value = prop.Substring(1, prop.Length - 1);

        switch (key)
        {
          case "D":
            {
              int pinNumber = int.Parse(value);
              if (pinNumber != PinNumber) throw new Exception(string.Format("Status string '{0}' does not correspond to digita pin {1}", statusString, PinNumber));
              break;
            }
          case "M":
            {
              int modeValue = int.Parse(value);
              PinMode = (DigitalPinMode)modeValue;
              break;
            }
          case "V":
            {
              valueTemp = value; //save to valueTemp because it is possible that PinMode was not yet updated at this point
              break;
            }
          case "F":
            {
              Frequency = int.Parse(value);
              break;
            }
          case "L":
            {
              Duration = int.Parse(value);
              break;
            }
          default: throw new Exception(string.Format("Status string '{0}' contains properties which don't belong to analog pin status", statusString));
        }
      }

      if (PinMode == DigitalPinMode.BoolRead || PinMode == DigitalPinMode.BoolWrite)
      {
        BoolValue = valueTemp == "1";
      }
      else if (PinMode == DigitalPinMode.Pwm)
      {
        PwmValue = byte.Parse(valueTemp);
      }
    }

  }
}
