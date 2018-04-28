using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoScope
{
  public partial class frmMain : Form
  {
    GraphVisualizer _visualizer = null;
    SerialPort _port = new SerialPort();
    Thread _thread = null;
    bool _threadShouldStop = true;
    
    public frmMain()
    {
      InitializeComponent();
    }

    private void StartReadThread()
    {
      if (_thread != null) return;
      _threadShouldStop = false;
      ThreadStart start = new ThreadStart(ReadLoop);
      _thread = new Thread(start);
      _thread.Name = "Read serial";
      _thread.IsBackground = true;
      _thread.Start();
    }

    private void StopReadThread()
    {
      if (_thread == null) return;
      _threadShouldStop = true;
      _thread.Join(5000);

      _port.Close();
    }

    private void ReadLoop()
    {
      while (!_threadShouldStop)
      {
        if (_port.IsOpen)
        {
          int bytesToRead = _port.BytesToRead;
          if (bytesToRead > 0)
          {
            byte[] buffer = new byte[bytesToRead];
            _port.Read(buffer, 0, bytesToRead);

            SamplePoint[] samples = new SamplePoint[bytesToRead];
            for (int x = 0; x < bytesToRead; x++)
            {
              samples[x].Value = ((double)buffer[x] / 255) * 5;
              samples[x].TimeOffset = 20 * Utility.MICROSECOND;
            }

            _visualizer.Channel.WriteSamples(samples);
          }
        }

        Thread.Sleep(10);
      }

      _thread = null;
    }

    private void PopulateCombos()
    {
      #region Voltage unit
      //foreach (VoltageUnit unit in Enum.GetValues(typeof(VoltageUnit)))
      //{
      //  cmbVoltageScaleUnit.Items.Add(unit);
      //}

      //cmbVoltageScaleUnit.SelectedItem = VoltageUnit.Volts;
      #endregion Voltage unit

      #region Time unit
      //foreach (TimeUnit unit in Enum.GetValues(typeof(TimeUnit)))
      //{
      //  cmbTimeScaleUnit.Items.Add(unit);
      //}
      //cmbTimeScaleUnit.SelectedItem = TimeUnit.Seconds;
      #endregion Time unit
    }

    private void RunVisualizer()
    {
      _visualizer = new GraphVisualizer();
      _visualizer.Run(120,120);

      this.BeginInvoke(new MethodInvoker(delegate { this.Close(); }));
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        Task.Run(new Action(delegate { RunVisualizer(); }));
        WaitForVisualizer();

        _visualizer.CreateChannel();
        PopulateCombos();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Loading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Application.Exit();
      }
    }

    private void WaitForVisualizer()
    {
      DateTime start = DateTime.Now;
      while (_visualizer == null)
      {
        TimeSpan span = DateTime.Now - start;
        if (span.TotalSeconds > 5) throw new Exception("Visualizer failed to start");
        Thread.Sleep(10);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show(Utility.GetEnumDescription<TimeUnit>(TimeUnit.Miliseconds));
    }

    private void infoTimer_Tick(object sender, EventArgs e)
    {
      if (_visualizer != null)
      {
        txtFPS.Text = Convert.ToInt32(_visualizer.RenderFrequency).ToString();
      }
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      StopReadThread();
      if (_visualizer != null) _visualizer.Close();
    }

    private void cmbTimeScaleUnit_Format(object sender, ListControlConvertEventArgs e)
    {
      e.Value = Utility.GetEnumDescription<TimeUnit>((TimeUnit)e.ListItem);
    }

    private void cmbVoltageScaleUnit_Format(object sender, ListControlConvertEventArgs e)
    {
      e.Value = Utility.GetEnumDescription<VoltageUnit>((VoltageUnit)e.ListItem);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      colorDialog1.ShowDialog();
    }

    private void clrBackgroundColor_SelectedColorChanged(object sender, EventArgs e)
    {

    }

    private void clrGraphColor_SelectedColorChanged(object sender, EventArgs e)
    {

    }

    private void clrGridColor_SelectedColorChanged(object sender, EventArgs e)
    {

    }

    private void frmMain_Shown(object sender, EventArgs e)
    {
      this.Activate();
    }

    private void btnDummyProbe_Click(object sender, EventArgs e)
    {
      SamplePoint[] points = new SamplePoint[10];

      for (int x = 0; x < points.Length; x++)
      {
        points[x].Value = x / 10d;
        points[x].TimeOffset = 20 * Utility.MICROSECOND;
      }

      _visualizer.Channel.WriteSamples(points);
    }

    private void btnT2_Click(object sender, EventArgs e)
    {
      _visualizer.SecondsPerDiv *= 2;
    }

    private void btnTHalf_Click(object sender, EventArgs e)
    {
      _visualizer.SecondsPerDiv /= 2;
    }

    private void numMicrosecondsPerDiv_ValueChanged(object sender, EventArgs e)
    {
      _visualizer.SecondsPerDiv = Convert.ToDouble(numMicrosecondsPerDiv.Value) * Utility.MICROSECOND;
    }

    private void numvoltagePerDiv_ValueChanged(object sender, EventArgs e)
    {
      _visualizer.VoltsPerDiv = Convert.ToDouble(numvoltagePerDiv.Value);
    }

    private void btnStartSerial_Click(object sender, EventArgs e)
    {
      _port.PortName = "COM3";
      _port.BaudRate = 500000;
      _port.Open();

      StartReadThread();
    }

    private void btnStopSerial_Click(object sender, EventArgs e)
    {
      StopReadThread();
    }

    private void radDC_CheckedChanged(object sender, EventArgs e)
    {
      if (radAC.Checked && !_visualizer.ACCoupled) _visualizer.ACCoupled = true;
    }

    private void radAC_CheckedChanged(object sender, EventArgs e)
    {
      if (radDC.Checked && _visualizer.ACCoupled) _visualizer.ACCoupled = false;
    }
  }
}
