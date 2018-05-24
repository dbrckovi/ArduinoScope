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
  public partial class DigitalPinController : UserControl
  {
    bool _loading = false;
    int _pinNumber = 0;
    bool _digitalOutValue = false;

    public int PinNumber
    {
      get { return _pinNumber; }
      set
      {
        _pinNumber = value;
        lblPinNumber.Text = _pinNumber.ToString();
      }
    }

    public DigitalPinController()
    {
      InitializeComponent();
    }

    private void RefreshGUI()
    {
      PinMode selectedMode = (PinMode)cmbPinMode.SelectedItem;

      if (selectedMode == PinMode.Output)
      {
        pnlInput.Visible = false;
        pnlOutput.Visible = true;
      }
      else
      {
        pnlInput.Visible = true;
        pnlOutput.Visible = false;
      }

      btnDigitalOut.BackColor = _digitalOutValue ? Color.Green : Color.Transparent;
      btnDigitalOut.Text = _digitalOutValue ? "HIGH" : "LOW";
    }

    private void DigitalPinController_Load(object sender, EventArgs e)
    {
      if (Program.DesignTime) return;

      _loading = true;

      cmbPinMode.Items.Add(PinMode.Input);
      cmbPinMode.Items.Add(PinMode.Output);
      cmbPinMode.SelectedIndex = 1;

      _loading = false;
    }

    private void cmbPinMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      RefreshGUI();

      if (!_loading)
      {
        
      }
    }
  }
}
