using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoStudio
{
  public class AnalogPin
  {
    public int PinNumber = 0;
    public int Value = 0;

    /// <summary>
    /// Constructs new AnalogPin
    /// </summary>
    /// <param name="pinNumber">Pin number</param>
    public AnalogPin(int pinNumber)
    {
      PinNumber = pinNumber;
    }

    /// <summary>
    /// Constructs new AnalogPin with values parsed from config string received from arduino
    /// </summary>
    /// <param name="configString">String containing analog pin configuration information</param>
    public AnalogPin(string configString)
    {
      string key = configString.Substring(0, 1);
      string value = configString.Substring(1, configString.Length - 1);
      if (key != "A") throw new Exception(string.Format("Config string '{0}' does not represent analog pin", configString));
      PinNumber = int.Parse(value);
    }

    /// <summary>
    /// Updates pin status/value from status string received from arduino
    /// </summary>
    /// <param name="statusString">String containing analog pin status information</param>
    public void UpdateStatus(string statusString)
    {
      string[] props = statusString.Split(':');
      foreach (string prop in props)
      {
        string key = prop.Substring(0, 1);
        string value = prop.Substring(1, prop.Length - 1);

        switch (key)
        {
          case "A":
            {
              int pinNumber = int.Parse(value);
              if (pinNumber != PinNumber) throw new Exception(string.Format("Status string '{0}' does not correspond to analog pin {1}", statusString, PinNumber));
              break;
            }
          case "V":
            {
              Value = int.Parse(value);
              break;
            }
          default: throw new Exception(string.Format("Status string '{0}' contains properties which don't belong to analog pin status", statusString));
        }
      }
    }
  }
}
