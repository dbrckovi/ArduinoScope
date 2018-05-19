using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace ArduinoStudio
{
  public class ArduinoCommunicator
  {
    int _currentBaud = 500000;
    SerialPort _port = null;

    public ArduinoCommunicator(string comPort, int timeout = 1000)
    {
      _port = new SerialPort(comPort, _currentBaud);
      _port.ReadTimeout = timeout;
      _port.WriteTimeout = timeout;
      _port.Open();
    }

    public void Stop()
    {
      _port.Close();
    }

    /// <summary>
    /// Sends request and receives response
    /// </summary>
    /// <param name="request">Byte array which will be sent to the serial port</param>
    /// <param name="waitTimeMs">Wait time in miliseconds, after which the exception will be thrown if nothing was received</param>
    /// <returns>Byte array which was received after the request has been sent</returns>
    private byte[] SendRequest(byte[] request, int waitTimeMs = 100)
    {
      _port.Write(request, 0, request.Length);
      Thread.Sleep(waitTimeMs);
      if (_port.BytesToRead == 0) throw new Exception(string.Format("No data received on serial port after {0} ms", waitTimeMs));
      else
      {
        byte[] response = new byte[_port.BytesToRead];
        _port.Read(response, 0, response.Length);
        return response;
      }
    }

    public string SendRequest(string request, int waitTimeMs = 100)
    {
      _port.WriteLine(request);
      return _port.ReadLine();
    }

    public byte[] Test(int i)
    {
      byte[] request = BitConverter.GetBytes(i);
      return SendRequest(request);
    }
  }
}
