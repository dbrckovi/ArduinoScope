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
  public partial class DigitalPinList : UserControl
  {
    private ArduinoCommunicator _communicator = null;

    public ArduinoCommunicator Communicator
    {
      get { return _communicator; }
      set
      {
        if (_communicator != null) _communicator.PinStatusChanged -= _communicator_PinStatusChanged;

        _communicator = value;

        if (_communicator != null)
        {
          _communicator.PinStatusChanged += _communicator_PinStatusChanged;
        }

        GeneratePins();
      }
    }

    private void _communicator_PinStatusChanged()
    {
      UpdatePinValues();
    }

    /// <summary>
    /// Creates pin controllers based on pins present on the _communicator
    /// </summary>
    private void GeneratePins()
    {
      grpPins.SuspendLayout();

      //unsubscribe

      grpPins.Controls.Clear();
      
      if (_communicator != null)
      {
        foreach (DigitalPin pin in _communicator.DigitalPins)
        {
          DigitalPinController control = new DigitalPinController(pin.PinNumber, _communicator);
          grpPins.Controls.Add(control);
          control.BringToFront();
          control.Dock = DockStyle.Top;
          control.UpdateGUI();
        }
      }

      //populate and subscribe

      grpPins.ResumeLayout();
    }

    /// <summary>
    /// Updates pin values based on values on the _communicator
    /// </summary>
    private void UpdatePinValues()
    {

    }

    public DigitalPinList()
    {
      InitializeComponent();
    }
  }
}
