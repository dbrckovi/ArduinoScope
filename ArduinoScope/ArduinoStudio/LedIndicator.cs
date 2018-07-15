using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoStudio
{
  public partial class LedIndicator : UserControl
  {
    private bool _value = false;

    public bool Value
    {
      get { return _value; }
      set
      {
        _value = value;
        RefreshGUI();
      }
    }

    public LedIndicator()
    {
      InitializeComponent();
    }

    private void DrawBorder()
    {

    }

    private void RefreshGUI()
    {
      Graphics g = this.CreateGraphics();
      g.Clear(_value ? Program.AccentColor : Program.BackgroundColor);
      g.DrawRectangle(Program.PrimaryPen, 0, 0, this.Width - 1, this.Height - 1);
    }

    private void LedIndicator_Paint(object sender, PaintEventArgs e)
    {
      RefreshGUI();
    }

    private void LedIndicator_SizeChanged(object sender, EventArgs e)
    {
      RefreshGUI();
    }
  }
}
