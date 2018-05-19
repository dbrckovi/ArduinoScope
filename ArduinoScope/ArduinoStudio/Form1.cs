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
        if (value == null && _commuinicator != null) _commuinicator.Stop();
        _commuinicator = value;
        btnSerialConnectDisconnect.Text = _commuinicator != null ? "Disconnect" : "Connect";
        cmbSerialPorts.Enabled = _commuinicator == null;
        pnlControlPanel.Enabled = _commuinicator != null;
      }
    }

    public Form1()
    {
      InitializeComponent();
    }

    private void LoadPorts()
    {
      cmbSerialPorts.Items.Clear();
      foreach (string port in SerialPort.GetPortNames())
      {
        cmbSerialPorts.Items.Add(port);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        LoadPorts();
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void cmbSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
    {
      btnSerialConnectDisconnect.Enabled = cmbSerialPorts.SelectedItem != null;
    }

    private void btnSerialConnectDisconnect_Click(object sender, EventArgs e)
    {
      try
      {
        if (_commuinicator == null) Communicator = new ArduinoCommunicator((string)cmbSerialPorts.SelectedItem);
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
        txtResponse.Text = _commuinicator.SendRequest(txtInt.Text);
      }
      catch (Exception ex)
      {
        Msgbox.Show(this, ex);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }
  }
}
