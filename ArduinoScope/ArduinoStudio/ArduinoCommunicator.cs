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
    #region Variables
    int _currentBaud = 9600;
    int _responseFirstByteTimeout = 1000;
    int _responseLastByteTimeout = 100;
    SerialPort _port = null;
    Encoding _serialEncoding = new UTF8Encoding();
    #endregion Variables

    #region Events
    public event Delegates.StringDelegate Log;
    private void OnLog(string text)
    {
      if (Log != null)
      {
        text = string.Format("{0} - {1}", DateTime.Now.ToString("HH:mm:ss.fff"), text);
        Log(text);
      }
    }
    #endregion Events

    #region Constructor
    /// <summary>
    /// Creates a new instance and connects it to specified port
    /// </summary>
    /// <param name="comPort">Name ot the COM port</param>
    /// <param name="responseFirstByteTimeout">After the request is sent, communicator will wait for this amount of miliseconds for first byte of the response to arrive</param>
    /// <param name="responseLastByteTimeout">Number of miliseconds, after the last byte of the response was received, in which the communicator will wait for next byte to arrive</param>
    public ArduinoCommunicator(string comPort, int responseFirstByteTimeout = 1000, int responseLastByteTimeout = 100)
    {
      _responseFirstByteTimeout = responseFirstByteTimeout;
      _responseLastByteTimeout = responseLastByteTimeout;

      _port = new SerialPort(comPort, _currentBaud);
      _port.Open();
    }
    #endregion Constructor

    #region Infrastructure
    public void Stop()
    {
      _port.Close();
    }

    /// <summary>
    /// Sends request and receives response in raw byte format
    /// </summary>
    /// <param name="request">Byte array which will be sent to the serial port</param>
    /// <returns>Byte array which was received after the request has been sent</returns>
    private byte[] SendRequest(byte[] request)
    {
      List<byte> responseBytesList = new List<byte>();
      _port.DiscardInBuffer();
      _port.DiscardOutBuffer();

      _port.Write(request, 0, request.Length);
      if (!WaitForBytes(_responseFirstByteTimeout)) throw new TimeoutException("Timeout was reached while waiting for response");

      while (true)
      {
        byte[] response = new byte[_port.BytesToRead];
        _port.Read(response, 0, response.Length);
        responseBytesList.AddRange(response);
        if (!WaitForBytes(_responseLastByteTimeout)) break;
      }

      return responseBytesList.ToArray();
    }

    /// <summary>
    /// Sends request and receives response in string format
    /// </summary>
    /// <param name="request">Request which will be sent</param>
    /// <returns>Response which was sent by Arduino</returns>
    private string SendRequest(string request)
    {
      OnLog(string.Format("Request... {0}", request));
      byte[] requestBytes = _serialEncoding.GetBytes(request);
      byte[] responseBytes = SendRequest(requestBytes);
      string response = _serialEncoding.GetString(responseBytes);
      OnLog(string.Format("Response.. {0}", response));
      return response;
    }

    /// <summary>
    /// Waits for specified number of miliseconds for some byte to arrive on serial port
    /// </summary>
    /// <returns>True if some bytes arrived or False if no bytes arrived before timeout was reached</returns>
    private bool WaitForBytes(int waitTimeMiliseconds)
    {
      DateTime start = DateTime.Now;
      while (true)
      {
        if (_port.BytesToRead > 0) return true;
        TimeSpan span = DateTime.Now - start;
        if (span.TotalMilliseconds > waitTimeMiliseconds) return false;
      }
    }

    /// <summary>
    /// Constructs a request with arbitrary number of string parameters
    /// </summary>
    /// <param name="requestType">Type of the request</param>
    /// <param name="args">Optional list of arguments</param>
    /// <returns></returns>
    private string BuildRequest(RequestType requestType, params string[] args)
    {
      List<string> parts = new List<string>();
      parts.Add(((int)requestType).ToString());
      foreach (string argument in args)
      {
        parts.Add(argument);
      }
      return string.Join("|", parts.ToArray());
    }

    /// <summary>
    /// Parses response, validates the first parameter (code) and returns the rest of the arguments as a list of strings
    /// Throws exception on any error, or if Arduino returned and error response
    /// </summary>
    /// <param name="response">Raw string response from Arduino</param>
    /// <returns></returns>
    private List<string> ParseResponse(string response)
    {
      if (!response.Contains("|")) throw new Exception("Response is invalid");
      List<string> ret = response.Split('|').ToList();
      string first = ret[0];
      ret.RemoveAt(0);

      if (first == "1") return ret;
      else if (first == "0")
      {
        throw new Exception(string.Join("", ret.ToArray()));
      }
      else throw new Exception("Invalid response code");
    }
    #endregion Infrastructure

    #region Requests
    /// <summary>
    /// Performs a basic communication test. Arduino will return the received text.
    /// </summary>
    /// <param name="text">Text to be sent to, and received from, Arduino</param>
    /// <returns>The text which was sent</returns>
    public string Test(string text)
    {
      if (text.Contains("|")) throw new Exception("Text may not contain '|' character");
      string request = BuildRequest(RequestType.Test, text);
      string response = SendRequest(request);
      return ParseResponse(response)[0];
    }

    /// <summary>
    /// Sends error request. Only for debugging purposes
    /// </summary>
    /// <returns></returns>
    public void Error()
    {
      string request = BuildRequest(RequestType.Error);
      ParseResponse(SendRequest(request));
    }

    /// <summary>
    /// Requests the software version from the Arduino
    /// </summary>
    /// <returns>The version number</returns>
    public int GetVersion()
    {
      string request = BuildRequest(RequestType.GetVersion);
      string response = SendRequest(request);
      return int.Parse(response);
    }
    #endregion Requests
  }
}
