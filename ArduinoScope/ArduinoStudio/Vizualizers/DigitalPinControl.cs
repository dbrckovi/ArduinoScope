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
  public partial class DigitalPinControl : UserControl, IDisposable
  {
    private int _pinNumber = -1;
    ArduinoCommunicator _communicator = null;

    public int PinNumber
    {
      get { return _pinNumber; }
    }

    public ArduinoCommunicator Communicator
    {
      get { return _communicator; }
    }

    public DigitalPinControl()
    {
      InitializeComponent();
      this.Disposed += AnalogPinControl_Disposed;
    }

    public DigitalPinControl(ArduinoCommunicator communicator, int pinNumber) : this()
    {
      _communicator = communicator;
      _pinNumber = pinNumber;

      _communicator.PinStatusChanged += _communicator_PinStatusChanged;

      lblPinNumber.Text = pinNumber.ToString();
      lblPinNumber.ForeColor = Program.PrimaryLightColor;
    }

    private void AnalogPinControl_Disposed(object sender, EventArgs e)
    {
      _communicator.PinStatusChanged -= _communicator_PinStatusChanged;
    }

    private void _communicator_PinStatusChanged()
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(RefreshGUI));
        return;
      }

      RefreshGUI();
    }

    private void RefreshGUI()
    {
      DigitalPin pin = _communicator.DigitalPins[_pinNumber];
      //pwmValueControl1.Value = pin.PwmValue;
      //toneValueControl1.Frequency = pin.Frequency;
      //toneValueControl1.Duration = pin.Duration;
      ledIndicator1.Value = pin.PinMode == DigitalPinMode.BoolRead && pin.BoolValue;

      DrawButton(btnSetHigh, pin.PinMode == DigitalPinMode.BoolWrite && pin.BoolValue);
      DrawButton(btnSetLow, pin.PinMode == DigitalPinMode.BoolWrite && !pin.BoolValue);
      DrawButton(btnRead, pin.PinMode == DigitalPinMode.BoolRead);
      DrawButton(btnSetPWM, pin.PinMode == DigitalPinMode.Pwm);
      DrawButton(btnSetTone, pin.PinMode == DigitalPinMode.Tone);
      DrawButton(btnNoTone, pin.PinMode == DigitalPinMode.NoTone);

      if (!pin.SupportsPwm)
      {
        if (pin.PinMode != DigitalPinMode.Pwm) DrawButtonDisabled(btnSetPWM);
        if (pin.PinMode != DigitalPinMode.Tone) DrawButtonDisabled(btnSetTone);
        if (pin.PinMode != DigitalPinMode.NoTone) DrawButtonDisabled(btnNoTone);
      }
    }

    private void DrawButton(Button button, bool accented)
    {
      if (accented)
      {
        button.BackColor = Program.AccentLightColor;
        button.ForeColor = Program.AccentColor;
      }
      else
      {
        button.BackColor = Program.PrimaryLightColor;
        button.ForeColor = Program.PrimaryColor;
      }
    }

    private void DrawButtonDisabled(Button button)
    {
      button.BackColor = Program.DisabledColor;
      button.ForeColor = Program.PrimaryLightColor;
    }

    private void DrawBorder()
    {
      Graphics g = this.CreateGraphics();
      g.Clear(this.BackColor);
      g.DrawRectangle(Program.PrimaryPen, 0, 0, this.Width - 1, this.Height - 1);
    }

    private void DigitalPinControl_SizeChanged(object sender, EventArgs e)
    {
      DrawBorder();
    }

    private void DigitalPinControl_Paint(object sender, PaintEventArgs e)
    {
      DrawBorder();
    }

    private void btnSetHigh_Click(object sender, EventArgs e)
    {
      try
      {
        _communicator.DigitalWrite(_pinNumber, true);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this.ParentForm ,ex);
      }
    }

    private void btnSetLow_Click(object sender, EventArgs e)
    {
      try
      {
        _communicator.DigitalWrite(_pinNumber, false);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this.ParentForm, ex);
      }
    }

    private void btnSetPWM_Click(object sender, EventArgs e)
    {
      try
      {
        _communicator.AnalogWrite(_pinNumber, pwmValueControl1.Value);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this.ParentForm, ex);
      }
    }

    private void btnSetTone_Click(object sender, EventArgs e)
    {
      try
      {
        _communicator.Tone(_pinNumber, toneValueControl1.Frequency, toneValueControl1.Duration);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this.ParentForm, ex);
      }
    }

    private void btnNoTone_Click(object sender, EventArgs e)
    {
      try
      {
        _communicator.NoTone(_pinNumber);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this.ParentForm, ex);
      }
    }

    private void btnRead_Click(object sender, EventArgs e)
    {
      try
      {
        _communicator.DigitalRead(_pinNumber);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this.ParentForm, ex);
      }
    }
  }
}
