using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace ArduinoStudio
{
  public class ArduinoCommunicator
  {
    private const int DEFAULT_BAUD = 500000;

    private void Dummy()
    {
      
    }

    #region Variables
    private int _responseFirstByteTimeout = 1000;
    private int _responseLastByteTimeout = 100;
    private SerialPort _port = null;
    private Encoding _serialEncoding = new UTF8Encoding();
    private int _version = -1;
    private int[] _viableBaudRates = { 9600, 14400, 19200, 28800, 38400, 57600, 115200, 230400, 500000 };
    private DigitalPin[] _digitalPins = new DigitalPin[13];
    #endregion Variables

    #region Properties
    public int Version
    {
      get { return _version; }
    }

    public int CurrentBaud
    {
      get { return _port.BaudRate; }
    }

    /// <summary>
    /// Gets the states and values of all digital pins
    /// </summary>
    public DigitalPin[] DigitalPins
    {
      get
      {
        return _digitalPins;
      }
    }
    #endregion Properties

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

    /// <summary>
    /// Raised when status of one or more pins changes or gets updated
    /// </summary>
    public event Delegates.VoidDelegate PinStatusChanged;
    private void OnPinStatusChanged()
    {
      PinStatusChanged?.Invoke();
    }
    #endregion Events

    #region Constructor
    /// <summary>
    /// Creates a new instance and connects it to specified port and gets version information
    /// </summary>
    /// <param name="comPort">Name ot the COM port</param>
    /// <param name="responseFirstByteTimeout">After the request is sent, communicator will wait for this amount of miliseconds for first byte of the response to arrive</param>
    /// <param name="responseLastByteTimeout">Number of miliseconds, after the last byte of the response was received, in which the communicator will wait for next byte to arrive</param>
    public ArduinoCommunicator(string comPort, int responseFirstByteTimeout = 1000, int responseLastByteTimeout = 100)
    {
      try
      {
        _responseFirstByteTimeout = responseFirstByteTimeout;
        _responseLastByteTimeout = responseLastByteTimeout;

        _port = new SerialPort(comPort, DEFAULT_BAUD);
        _port.Open();
        Thread.Sleep(100); //because reasons. GetVersion doesn't work without this
        _version = GetVersion();
        GenerateDigitalPins();
        InitializeDigitalPins();
      }
      catch (Exception ex)
      {
        try
        {
          _port.Close();
        }
        catch { }

        throw ex;
      }
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
      List<string> ret = null;
      string first;
      if (response.Contains("|"))
      {
        ret = response.Split('|').ToList();
        first = ret[0];
        ret.RemoveAt(0);
      }
      else first = response;

      if (first == "1") return ret;
      else if (first == "0")
      {
        throw new Exception(string.Join("", ret.ToArray()));
      }
      else throw new Exception("Invalid response code");
    }

    /// <summary>
    /// Creates a list of digital pins.
    /// </summary>
    private void GenerateDigitalPins()
    {
      //The list is now hardcoded for Arduino Uno
      //TODO: Check if it's possible to acquire the pin list dynamically

      _digitalPins = new DigitalPin[14];

      for (int x = 0; x < _digitalPins.Length; x++)
      {
        _digitalPins[x] = new DigitalPin(x);
      }
    }

    /// <summary>
    /// Initializes digital pins to default modes and values
    /// </summary>
    private void InitializeDigitalPins()
    {
      //TODO: Get mode and value of each digital pin from Arduino (support for this must be implemented into sketch first)
      //For now, each pin is initialized to Digital boolean output and turned off

      foreach (DigitalPin pin in _digitalPins)
      {
        NoTone(pin.PinNumber);
        DigitalWrite(pin.PinNumber, false);
      }
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
      return int.Parse(ParseResponse(response)[0]);
    }

    /// <summary>
    /// For debug purposes. Arduino should output some text
    /// </summary>
    /// <returns></returns>
    public string Debug()
    {
      string request = BuildRequest(RequestType.Debug);
      string response = SendRequest(request);
      return ParseResponse(response)[0];
    }

    /// <summary>
    /// Sets the mode of the digital pin
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="mode"></param>
    public void PinMode(int pin, PinMode mode)
    {
      string request = BuildRequest(RequestType.PinMode, pin.ToString(), ((int)mode).ToString());
      string response = SendRequest(request);
      ParseResponse(response);

      _digitalPins[pin].PinMode = mode;
      OnPinStatusChanged();
    }

    /// <summary>
    /// Writes a boolean value to the digital pin. Sets the pin to boolean output mode if required
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="value"></param>
    public void DigitalWrite(int pin, bool value)
    {
      if (_digitalPins[pin].PinMode != ArduinoStudio.PinMode.Output) PinMode(pin, ArduinoStudio.PinMode.Output);
      if (_digitalPins[pin].OutputMode == DigitalOutMode.Tone) NoTone(pin);

      string request = BuildRequest(RequestType.DigitalWrite, pin.ToString(), value ? "1" : "0");
      string response = SendRequest(request);
      ParseResponse(response);

      _digitalPins[pin].OutputMode = DigitalOutMode.Boolean;
      _digitalPins[pin].OutputBool = value;

      OnPinStatusChanged();
    }


    /// <summary>
    /// Writes a pwm value to the digital pin. Sets the pin to pwm output mode if required
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="value"></param>
    public void AnalogWrite(int pin, byte value)
    {
      if (_digitalPins[pin].PinMode != ArduinoStudio.PinMode.Output) PinMode(pin, ArduinoStudio.PinMode.Output);
      if (_digitalPins[pin].OutputMode == DigitalOutMode.Tone) NoTone(pin);

      string request = BuildRequest(RequestType.AnalogWrite, pin.ToString(), value.ToString());
      string response = SendRequest(request);
      ParseResponse(response);

      _digitalPins[pin].OutputMode = DigitalOutMode.PWM;
      _digitalPins[pin].OutputPwm = value;

      OnPinStatusChanged();
    }


    public int AnalogRead(int pin)
    {
      string request = BuildRequest(RequestType.AnalogRead, pin.ToString());
      string response = SendRequest(request);
      List<string> responseValues = ParseResponse(response);
      return int.Parse(responseValues[0]);
    }

    /// <summary>
    /// Writes a tone value to the digital pin. Sets the pin to Tone output moed if required
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="frequency"></param>
    /// <param name="duration"></param>
    public void Tone (int pin, int frequency, int duration)
    {
      if (_digitalPins[pin].PinMode != ArduinoStudio.PinMode.Output) PinMode(pin, ArduinoStudio.PinMode.Output);

      string request = BuildRequest(RequestType.Tone, pin.ToString(), frequency.ToString(), duration.ToString());
      string response = SendRequest(request);
      ParseResponse(response);

      _digitalPins[pin].OutputMode = DigitalOutMode.Tone;
      _digitalPins[pin].OutputToneFrequency = frequency;
      _digitalPins[pin].OutputToneDuration = duration;

      OnPinStatusChanged();
    }


    /// <summary>
    /// Stops the tone output on the pin. Sets the pin to the tone output mode if required
    /// </summary>
    /// <param name="pin"></param>
    public void NoTone(int pin)
    {
      if (_digitalPins[pin].PinMode != ArduinoStudio.PinMode.Output) PinMode(pin, ArduinoStudio.PinMode.Output);

      string request = BuildRequest(RequestType.NoTone, pin.ToString());
      string response = SendRequest(request);
      ParseResponse(response);

      _digitalPins[pin].OutputMode = DigitalOutMode.Tone;

      OnPinStatusChanged();
    }
    #endregion Requests
  }
}
