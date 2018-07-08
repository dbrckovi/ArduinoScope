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
  public partial class PwmValueControl : UserControl
  {
    byte _value = 0;

    public byte Value
    {
      get { return _value; }
      set
      {
        if (_value == value) return;
        _value = value;
        txtValue.Text = value.ToString();
        trackValue.Value = _value;
        OnValueChanged();
      }
    }

    public event Delegates.ControlDelegate ValueChanged;
    private void OnValueChanged()
    {
      ValueChanged?.Invoke(this);
    }

    public PwmValueControl()
    {
      InitializeComponent();
    }

    private void trackValue_ValueChanged(object sender, EventArgs e)
    {
      Value = Convert.ToByte(trackValue.Value);
    }

    private void txtValue_Validated(object sender, EventArgs e)
    {
      byte value = 0;
      byte.TryParse(txtValue.Text, out value);
      Value = value;
    }

    private void txtValue_Validating(object sender, CancelEventArgs e)
    {
      byte value = 0;
      if (!byte.TryParse(txtValue.Text, out value)) e.Cancel = true;
    }

    private void PwmValueControl_Load(object sender, EventArgs e)
    {
      txtValue.Text = _value.ToString();
      trackValue.Value = Value;
    }
  }
}
