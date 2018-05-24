using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoStudio
{
  static class Program
  {
    public static readonly Color COLOR_OUTPUT = Color.FromArgb(209, 211, 224);
    public static readonly Color COLOR_INPUT = Color.FromArgb(232, 219, 221);

    public static bool DesignTime = true;

    [STAThread]
    static void Main()
    {
      DesignTime = false;
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
