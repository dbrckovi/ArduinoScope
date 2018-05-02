using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoScope
{
  public static class Utility
  {
    public const float MICROSECOND = 1f / 1000000f;
    public const float MILISECOND = 1f / 1000f;

    public static readonly float GIGA_MULTIPLIER = (float)Math.Pow(10, 9);
    public static readonly float MEGA_MULTIPLIER = (float)Math.Pow(10, 6);
    public static readonly float KILO_MULTIPLIER = (float)Math.Pow(10, 3);
    public static readonly float MILI_MULTIPLIER = (float)Math.Pow(10, -3);
    public static readonly float MICRO_MULTIPLIER = (float)Math.Pow(10, -6);
    public static readonly float NANO_MULTIPLIER = (float)Math.Pow(10, -9);
    public static readonly float PICO_MULTIPLIER = (float)Math.Pow(10, -12);

    public const string GIGA_SIGN = "G";
    public const string MEGA_SIGN = "M";
    public const string KILO_SIGN = "k";
    public const string MILI_SIGN = "m";
    public const string MICRO_SIGN = "µ";
    public const string NANO_SIGN = "n";
    public const string PICO_SIGN = "p";

    public static string GetEnumDescription<T>(T value)
    {
      Type type = typeof(T);

      MemberInfo[] memInfo = type.GetMember(value.ToString());

      if (memInfo != null && memInfo.Length > 0)
      {
        object[] attrs = (object[])memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
        if (attrs != null && attrs.Length > 0)
        {
          return ((DescriptionAttribute)attrs[0]).Description;
        }
      }

      return value.ToString();
    }

    /// <summary>
    /// Expresses in the value human-readable format (multiplies with magnitude and attaches the magnitude sign)
    /// </summary>
    /// <param name="value">Voltage expressed in Volts</param>
    /// <param name="unitSign">Unit sign</param>
    /// <param name="decimalPlaces">Number of decimal places which will be displayed and rounded to</param>
    /// <returns></returns>
    public static string VisualizeWithMagnitude(float value, string unitSign, int decimalPlaces)
    {
      string magnitudeSign = "";
      bool wasNegative = value < 0;
      value = Math.Abs(value);
      if (value >= GIGA_MULTIPLIER)
      {
        magnitudeSign = GIGA_SIGN;
        value = value / GIGA_MULTIPLIER;
      }
      else if (value >= MEGA_MULTIPLIER)
      {
        magnitudeSign = MEGA_SIGN;
        value = value / MEGA_MULTIPLIER;
      }
      else if (value >= KILO_MULTIPLIER)
      {
        magnitudeSign = KILO_SIGN;
        value = value / KILO_MULTIPLIER;
      }
      else if (value < NANO_MULTIPLIER)
      {
        magnitudeSign = PICO_SIGN;
        value = value / PICO_MULTIPLIER;
      }
      else if (value < MICRO_MULTIPLIER)
      {
        magnitudeSign = NANO_SIGN;
        value = value / NANO_MULTIPLIER;
      }
      else if (value < MILI_MULTIPLIER)
      {
        magnitudeSign = MICRO_SIGN;
        value = value / MICRO_MULTIPLIER;
      }
      else if (value < 1f)
      {
        magnitudeSign = MILI_SIGN;
        value = value / MILI_MULTIPLIER;
      }

      if (wasNegative) value = -value;
      return string.Format("{0} {1}{2}", Math.Round(Convert.ToDecimal(value), decimalPlaces), magnitudeSign, unitSign);
    }
  }
}
