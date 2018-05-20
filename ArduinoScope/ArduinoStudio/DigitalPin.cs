using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoStudio
{
  public class DigitalPin
  {
    private PinMode _pinMode = PinMode.Input;
    private int _pinIndex = -1;
    private bool _supportsPWM = false;
    
    public PinMode PinMode
    {
      get { return _pinMode; }
      set { _pinMode = value; }
    }

    public int PinIndex
    {
      get { return _pinIndex; }
      set { _pinIndex = value; }
    }

    public bool SupportsPWM
    {
      get { return _supportsPWM; }
      set { _supportsPWM = value; }
    }
  }
}
