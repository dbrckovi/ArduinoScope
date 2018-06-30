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
  public partial class OutputModeControl : UserControl
  {
    private Color OFF_COLOR = Color.White;
    private Color BOOL_COLOR = Color.FromArgb(192, 255, 192);
    private Color PWM_COLOR = Color.FromArgb(128, 255, 128);
    private Color TONE_COLOR = Color.FromArgb(128, 255, 128);

    private DigitalOutMode _outputMode = DigitalOutMode.Boolean;

    public DigitalOutMode OutputMode
    {
      get { return _outputMode; }
      set
      {
        bool changed = _outputMode != value;
        _outputMode = value;
        Redraw();
        if (changed) OnOutputModeChanged();
      }
    }

    public event Delegates.ControlDelegate OutputModeChanged;
    private void OnOutputModeChanged()
    {
      OutputModeChanged?.Invoke(this);
    }

    public OutputModeControl()
    {
      InitializeComponent();
    }

    private void Redraw()
    {
      lblBoolean.BackColor = _outputMode == DigitalOutMode.Boolean ? BOOL_COLOR : OFF_COLOR;
      lblPWM.BackColor = _outputMode == DigitalOutMode.PWM ? PWM_COLOR : OFF_COLOR;
      lblTone.BackColor = _outputMode == DigitalOutMode.Tone ? TONE_COLOR : OFF_COLOR;
    }

    private void lblBoolean_Click(object sender, EventArgs e)
    {
      OutputMode = DigitalOutMode.Boolean;
    }

    private void lblPWM_Click(object sender, EventArgs e)
    {
      OutputMode = DigitalOutMode.PWM;
    }

    private void lblTone_Click(object sender, EventArgs e)
    {
      OutputMode = DigitalOutMode.Tone;
    }

    private void OutputModeControl_Load(object sender, EventArgs e)
    {
      Redraw();
    }
  }
}
