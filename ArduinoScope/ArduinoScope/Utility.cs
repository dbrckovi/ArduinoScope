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
    public const double MICROSECOND = 1d / 1000000d;
    public const double MILISECOND = 1d / 1000d;

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
  }
}
