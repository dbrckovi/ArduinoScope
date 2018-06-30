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
    private bool _updating = true;
    int _pinNumber = 0;
    ArduinoCommunicator _communicator = null;

    private DigitalPin Pin
    {
      get
      {
        return _communicator.DigitalPins[_pinNumber];
      }
    }

    public ArduinoCommunicator Communicator
    {
      get { return _communicator; }
      set
      {
        if (_communicator != null) _communicator.PinStatusChanged -= _communicator_PinStatusChanged;
        _communicator = value;
        if (_communicator != null) _communicator.PinStatusChanged += _communicator_PinStatusChanged;
      }
    }

    private void _communicator_PinStatusChanged()
    {
      UpdateGUI();
    }

    public int PinNumber
    {
      get { return _pinNumber; }
      set
      {
        _pinNumber = value;
        lblPinNumber.Text = value.ToString();
      }
    }

    public DigitalPinController()
    {
      InitializeComponent();
    }

    public DigitalPinController(int pinNumber, ArduinoCommunicator communicator) :this()
    {
      PinNumber = pinNumber;
      Communicator = communicator;
    }

    private void DigitalPinController_Load(object sender, EventArgs e)
    {
      pwmValueControl1.Dock = DockStyle.Fill;
      toneValueControl1.Dock = DockStyle.Fill;
    }

    public void UpdateGUI()
    {
      _updating = true;

      pinModeControl1.PinMode = Pin.PinMode;
      outputModeControl1.Visible = Pin.PinMode == PinMode.Output;
      outputModeControl1.OutputMode = Pin.OutputMode;

      outputBool.Visible = Pin.PinMode == PinMode.Output && Pin.OutputMode == DigitalOutMode.Boolean;
      outputBool.Value = Pin.OutputBool;

      pwmValueControl1.Visible = Pin.PinMode == PinMode.Output && Pin.OutputMode == DigitalOutMode.PWM;
      pwmValueControl1.Value = Pin.OutputPwm;

      toneValueControl1.Visible = Pin.PinMode == PinMode.Output && Pin.OutputMode == DigitalOutMode.Tone;
      toneValueControl1.Frequency = Pin.OutputToneFrequency;
      toneValueControl1.Duration = Pin.OutputToneDuration;

      _updating = false;
    }

    private void pinModeControl1_PinModeChanged(Control control)
    {
      if (!_updating)
      {
        _communicator.PinMode(_pinNumber, pinModeControl1.PinMode);
        UpdateGUI();
      }
    }

    private void outputModeControl1_OutputModeChanged(Control control)
    {
      if (!_updating)
      {

        switch (outputModeControl1.OutputMode)
        {
          case DigitalOutMode.Boolean: _communicator.DigitalWrite(_pinNumber, Pin.OutputBool); break;
          case DigitalOutMode.PWM: _communicator.AnalogWrite(_pinNumber, Pin.OutputPwm); break;
          case DigitalOutMode.Tone:
            {
              if (Pin.OutputToneDuration == 0) _communicator.Tone(_pinNumber, Pin.OutputToneFrequency, Pin.OutputToneDuration);
              else _communicator.NoTone(_pinNumber); break;
            }
        }

        //_communicator.PinMode(_pinNumber, pinModeControl1.PinMode);
        UpdateGUI();
      }
    }

    private void outputBool_ValueChanged(Control control)
    {
      if (!_updating)
      {
        _communicator.DigitalWrite(_pinNumber, outputBool.Value);
        UpdateGUI();
      }
    }

    private void pwmValueControl1_ValueChanged(Control control)
    {
      if (!_updating)
      {
        _communicator.AnalogWrite(_pinNumber, pwmValueControl1.Value);
        UpdateGUI();
      }
    }

    private void toneValueControl1_ValueChanged(Control control)
    {
      if (!_updating)
      {
        _communicator.Tone(_pinNumber, toneValueControl1.Frequency, toneValueControl1.Duration);
        UpdateGUI();
      }
    }

    private void toneValueControl1_NoTone(Control control)
    {
      if (!_updating)
      {
        _communicator.NoTone(_pinNumber);
        UpdateGUI();
      }
    }
  }
}
