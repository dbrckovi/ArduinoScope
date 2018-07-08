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
  public partial class AnalogPinControl : UserControl, IDisposable
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

    public AnalogPinControl()
    {
      InitializeComponent();
      this.Disposed += AnalogPinControl_Disposed;
    }

    public AnalogPinControl(ArduinoCommunicator communicator, int pinNumber) : this()
    {
      _communicator = communicator;
      _pinNumber = pinNumber;

      _communicator.PinStatusChanged += _communicator_PinStatusChanged;

      lblPinNumber.Text = pinNumber.ToString();
      lblPinNumber.ForeColor = Program.PrimaryLightColor;
      lblValue.ForeColor = Program.PrimaryColor;
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
      lblValue.Text = _communicator.AnalogPins[_pinNumber].Value.ToString();
      smallGraph1.AddValue(_communicator.AnalogPins[_pinNumber].Value);
    }

    private void DrawBorder()
    {
      Graphics g = this.CreateGraphics();
      g.Clear(this.BackColor);
      g.DrawRectangle(Program.PrimaryPen, 0, 0, this.Width - 1, this.Height - 1);
    }

    private void AnalogPinControl_Load(object sender, EventArgs e)
    {
      
    }

    private void AnalogPinControl_SizeChanged(object sender, EventArgs e)
    {
      DrawBorder();
    }

    private void AnalogPinControl_Paint(object sender, PaintEventArgs e)
    {
      DrawBorder();
    }
  }
}
