using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoStudio
{
  public static class Delegates
  {
    public delegate void VoidDelegate();
    public delegate void StringDelegate(string text);
    public delegate void ControlDelegate(Control control);
  }
}
