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
        }
        _commuinicator = value;
        btnSerialConnectDisconnect.Text = _commuinicator != null ? "Disconnect" : "Connect";
        EnableDisableControls();

        if (_commuinicator != null)
        {
          _commuinicator.Log += _commuinicator_Log;
        }
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

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        txtResponse.Text = _commuinicator.Test(txtInt.Text);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void btnClearLog_Click(object sender, EventArgs e)
    {
      txtLog.Text = "";
    }

    private void btnError_Click(object sender, EventArgs e)
    {
      try
      {
        _commuinicator.Error();
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }
  }
}
