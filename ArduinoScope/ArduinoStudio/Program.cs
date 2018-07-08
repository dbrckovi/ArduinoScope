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

    public static Color PrimaryColor = Color.FromArgb(0, 100, 104);
    public static Color PrimaryLightColor = Color.FromArgb(23, 161, 165);
    public static Color AccentColor = Color.FromArgb(232, 80, 31);
    public static Color AccentLightColor = Color.FromArgb(240, 181, 52);
    public static Color BackgroundColor = Color.FromArgb(241, 255, 255);
    public static Color BackgroundLightColor = Color.FromArgb(255,255,255);

    public static Brush PrimaryBrush = new SolidBrush(PrimaryColor);
    public static Brush PrimaryLightBrush = new SolidBrush(PrimaryLightColor);
    public static Brush AccentBrush = new SolidBrush(AccentColor);
    public static Brush AccentLightBrush = new SolidBrush(AccentLightColor);
    public static Brush BackgroundBrush = new SolidBrush(BackgroundColor);
    public static Brush BackgroundLightBrush = new SolidBrush(BackgroundLightColor);

    public static Pen PrimaryPen = new Pen(PrimaryColor);
    public static Pen PrimaryLightPen = new Pen(PrimaryLightColor);
    public static Pen AccentPen = new Pen(AccentColor);
    public static Pen AccentLightPen = new Pen(AccentLightColor);
    public static Pen BackgroundPen = new Pen(BackgroundColor);
    public static Pen BackgroundLightPen = new Pen(BackgroundLightColor);

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
