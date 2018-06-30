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
  public partial class BoolControl : UserControl
  {
    private Color OFF_COLOR = Color.White;
    private Color LOW_COLOR = Color.FromArgb(192, 192, 255);
    private Color HIGH_COLOR = Color.FromArgb(192, 255, 192);

    private bool _value = false;

    public bool Value
    {
      get { return _value; }
      set
      {
        bool changed = _value != value;
        _value = value;
        Redraw();
        if (changed) OnValueChanged();
      }
    }

    public event Delegates.ControlDelegate ValueChanged;
    private void OnValueChanged()
    {
      ValueChanged?.Invoke(this);
    }

    public BoolControl()
    {
      InitializeComponent();
    }

    private void Redraw()
    {
      lblLow.BackColor = !_value ? LOW_COLOR : OFF_COLOR;
      lblHigh.BackColor = _value ? HIGH_COLOR : OFF_COLOR;
    }

    private void PinModeControl_Load(object sender, EventArgs e)
    {
      Redraw();
    }

    private void lblLow_Click(object sender, EventArgs e)
    {
      Value = false;
    }

    private void lblHigh_Click(object sender, EventArgs e)
    {
      Value = true;
    }

  }
}
