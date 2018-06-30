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
  public partial class PinModeControl : UserControl
  {
    private Color OFF_COLOR = Color.White;
    private Color INPUT_ON_COLOR = Color.FromArgb(255, 224, 192);
    private Color OUTPUT_ON_COLOR = Color.FromArgb(192, 255, 192);

    private PinMode _pinMode = PinMode.Input;
   
    public PinMode PinMode
    {
      get { return _pinMode; }
      set
      {
        bool changed = _pinMode != value;
        _pinMode = value;
        Redraw();
        if (changed) OnPinModeChanged();
      }
    }

    public event Delegates.ControlDelegate PinModeChanged;
    private void OnPinModeChanged()
    {
      PinModeChanged?.Invoke(this);
    }

    public PinModeControl()
    {
      InitializeComponent();
    }

    private void Redraw()
    {
      lblInput.BackColor = _pinMode == PinMode.Input ? INPUT_ON_COLOR : OFF_COLOR;
      lblOutput.BackColor = _pinMode == PinMode.Output ? OUTPUT_ON_COLOR : OFF_COLOR;
    }

    private void PinModeControl_Load(object sender, EventArgs e)
    {
      Redraw();
    }

    private void lblInput_Click(object sender, EventArgs e)
    {
      PinMode = PinMode.Input;
    }

    private void lblOutput_Click(object sender, EventArgs e)
    {
      PinMode = PinMode.Output;
    }
  }
}
