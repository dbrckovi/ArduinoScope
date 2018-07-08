using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoStudio
{
  public partial class Form1 : Form
  {
    private ArduinoCommunicator _commuinicator = null;

    private ArduinoCommunicator Communicator
    {
      get
      {
        return _commuinicator;
      }
      set
      {
        if (value == null && _commuinicator != null)
        {
          _commuinicator.Stop();
          _commuinicator.Log -= _commuinicator_Log;
        }

        _commuinicator = value;

        if (_commuinicator != null)
        {
          _commuinicator.Log += _commuinicator_Log;
        }

        txtVersion.Text = _commuinicator != null ? _commuinicator.Version.ToString() : "";
        txtCurrentBaud.Text = _commuinicator != null ? _commuinicator.CurrentBaud.ToString() : "";
        btnSerialConnectDisconnect.Text = _commuinicator != null ? "Disconnect" : "Connect";
        EnableDisableControls();
        GenerateAnalogPins();
        GenerateDigitalPins();
      }
    }

    private void _commuinicator_Log(string text)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new MethodInvoker(delegate { _commuinicator_Log(text); }));
        return;
      }

      txtLog.AppendText(text + "\r\n");
    }

    public Form1()
    {
      InitializeComponent();
    }

    private void EnableDisableControls()
    {
      cmbSerialPort.Enabled = _commuinicator == null;
      pnlControlPanel.Enabled = _commuinicator != null;
      btnSerialConnectDisconnect.Enabled = cmbSerialPort.SelectedItem != null;
      numResponseTimeoutFirstByte.Enabled = numResponseTimeoutSubsequentBytes.Enabled = cmbSerialPort.SelectedItem != null && _commuinicator == null;
    }

    private void GenerateAnalogPins()
    {
      if (_commuinicator == null)
      {
        foreach (AnalogPinControl ctl in pnlAnalogPins.Controls)
        {
          ctl.Dispose();
        }

        pnlAnalogPins.Controls.Clear();
      }
      else
      {
        foreach (AnalogPin pin in _commuinicator.AnalogPins)
        {
          pnlAnalogPins.Controls.Add(new AnalogPinControl(_commuinicator, pin.PinNumber));
        }
      }
    }

    private void GenerateDigitalPins()
    {

    }

    private void LoadPorts()
    {
      cmbSerialPort.Items.Clear();
      foreach (string port in SerialPort.GetPortNames())
      {
        cmbSerialPort.Items.Add(port);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        LoadPorts();
        EnableDisableControls();
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void cmbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
    {
      EnableDisableControls();
    }

    private void btnSerialConnectDisconnect_Click(object sender, EventArgs e)
    {
      try
      {
        if (_commuinicator == null)
        {
          int firstByteTimeout = Convert.ToInt32(numResponseTimeoutFirstByte.Value);
          int lastByteTimeout = Convert.ToInt32(numResponseTimeoutSubsequentBytes.Value);
          Communicator = new ArduinoCommunicator((string)cmbSerialPort.SelectedItem, firstByteTimeout, lastByteTimeout);
        }
        else Communicator = null;
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (Communicator != null) Communicator = null;
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void btnClearLog_Click(object sender, EventArgs e)
    {
      txtLog.Text = "";
    }

    private void btnSetHigh_Click(object sender, EventArgs e)
    {
      try
      {
        int pin = int.Parse(txtInt.Text);
        _commuinicator.DigitalWrite(pin, true);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void btnSetLow_Click(object sender, EventArgs e)
    {
      try
      {
        int pin = int.Parse(txtInt.Text);
        _commuinicator.DigitalWrite(pin, false);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void btnAnalogRead_Click(object sender, EventArgs e)
    {
      try
      {
        int pin = int.Parse(txtInt.Text);
        txtResponse.Text = _commuinicator.AnalogRead(pin).ToString();
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void btnTone_Click(object sender, EventArgs e)
    {
      try
      {
        int pin = int.Parse(txtInt.Text);
        int frequency = Convert.ToInt32(trackFrequency.Value);
        _commuinicator.Tone(pin, frequency, 2000);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void btnNoTone_Click(object sender, EventArgs e)
    {
      try
      {
        int pin = int.Parse(txtInt.Text);
        _commuinicator.NoTone(pin);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        int pin = int.Parse(txtInt.Text);
        byte value = Convert.ToByte(sliderAnalogWrite.Value);
        _commuinicator.AnalogWrite(pin, value);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      try
      {
        _commuinicator.ResetPins();
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      try
      {
        txtResponse.Text = _commuinicator.Debug();
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void button6_Click(object sender, EventArgs e)
    {
      try
      {
        int pin = int.Parse(txtInt.Text);
        txtResponse.Text = _commuinicator.DigitalRead(pin).ToString();
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }
  }
}
