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
  public partial class SmallGraph : UserControl
  {
    List<int> _values = new List<int>();
    Bitmap _buffer = null;
    Graphics _bufferGraphics = null;
    Graphics _surfaceGraphics = null;
    int _maximum = 1023;

    public SmallGraph()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Adds value to the end of the graph
    /// </summary>
    /// <param name="value"></param>
    public void AddValue(int value)
    {
      _values.Add(value);
      if (_values.Count > _buffer.Width) _values.RemoveAt(0);
      RedrawGraph();
    }

    private void InitializeGraphics()
    {
      _buffer = new Bitmap(this.Width, this.Height);
      _bufferGraphics = Graphics.FromImage(_buffer);
      _surfaceGraphics = this.CreateGraphics();
    }

    private void RedrawGraph()
    {
      if (!this.Visible) return;

      if (_buffer == null || _bufferGraphics == null || _surfaceGraphics == null) InitializeGraphics();

      _bufferGraphics.Clear(Program.BackgroundLightColor);

      _bufferGraphics.DrawRectangle(Program.PrimaryPen, 0, 0, _buffer.Width - 1, _buffer.Height - 1);

      if (_values.Count > 0)
      {
        int currentX = this.Width - 1;

        for (int x = _values.Count - 1; x >= 0; x--)
        {
          int value = ScaleValue(_values[x]);

          //TODO: fill path instead of a bunch of lines
          _bufferGraphics.DrawLine(Program.PrimaryLightPen, new Point(currentX, _buffer.Height - value), new Point(currentX, _buffer.Height));

          currentX--;
          if (currentX < 0) break;
        }

        int lastValue = ScaleValue(_values[_values.Count - 1]);
        _bufferGraphics.DrawLine(Program.AccentPen, new Point(0, _buffer.Height - lastValue), new Point(_buffer.Width-1, _buffer.Height - lastValue));
      }

      _surfaceGraphics.DrawImage(_buffer, new Point(0, 0));
    }

    private int ScaleValue (int unscaledValue)
    {
      return Convert.ToInt32((float)unscaledValue / (float)_maximum * (float)_buffer.Height);
    }

    private void SmallGraph_Paint(object sender, PaintEventArgs e)
    {
      RedrawGraph();
    }

    private void SmallGraph_SizeChanged(object sender, EventArgs e)
    {
      InitializeGraphics();
    }
  }
}
