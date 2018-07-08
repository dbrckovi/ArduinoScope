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
    private const int PIN_STATUS_REFRESH_MS = 100;    //UpdatePinStatuses() takes cca 170 ms on baud 500000

    #region Variables
    private int _responseFirstByteTimeout = 1000;
    private int _responseLastByteTimeout = 100;
    private SerialPort _port = null;
    private Encoding _serialEncoding = new UTF8Encoding();
    private int _version = -1;
    private int[] _viableBaudRates = { 9600, 14400, 19200, 28800, 38400, 57600, 115200, 230400, 500000 };
    private DigitalPin[] _digitalPins = null;
    private AnalogPin[] _analogPins = null;
    private Thread _thread = null;
    private bool _threadShouldAbort = true;
    private DateTime _lastPinStatusRefreshTime = DateTime.Now.AddDays(-1);
    private object _locker = new object();
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
    /// Contains states and last values of all digital pins
    /// </summary>
    public DigitalPin[] DigitalPins
    {
      get
      {
        return _digitalPins;
      }
    }

    /// <summary>
    /// Contains states and last values of all analog pins
    /// </summary>
    public AnalogPin[] AnalogPins
    {
      get
      {
        return _analogPins;
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
    /// Raised when status or value of one or more pins changes
    /// </summary>
    public event Delegates.VoidDelegate PinStatusChanged;
    private void OnPinStatusChanged()
    {
      PinStatusChanged?.Invoke();
    }

    /// <summary>
    /// Raised when critical exception occurs which prevents the communicator from operating normally.
    /// </summary>
    public event Delegates.ExceptionDelegate CriticalException;
    private void OnCriticalException(Exception ex)
    {
      CriticalException?.Invoke(ex);
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

        #region Open serial port
        _port = new SerialPort(comPort, DEFAULT_BAUD);
        _port.Open();
        Thread.Sleep(100); //because reasons. GetVersion doesn't work without this    TODO: better sleep
        #endregion Open serial port

        #region Get data from arduino
        _version = GetVersion();
        GenerateDigitalPins();
        UpdatePinStatuses();
        #endregion Get data from arduino

        #region Start worker thread
        _threadShouldAbort = false;
        ThreadStart start = new ThreadStart(Work);
        _thread = new Thread(start);
        _thread.Name = "ArduinoCommunicator worker thread";
        _thread.IsBackground = true;
        _thread.Start();
        #endregion Start worker thread
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
    /// <summary>
    /// Stops the ArduinoCommunicator
    /// </summary>
    /// <param name="forceStopTimeout">Time (in miliseconds) to wait for background thread to stop before forcing it to stop</param>
    public void Stop(int forceStopTimeout = 5000)
    {
      _threadShouldAbort = true;
      DateTime stopCalledTime = DateTime.Now;

      while(_thread != null)
      {
        TimeSpan span = DateTime.Now - stopCalledTime;
        if (span.TotalMilliseconds > forceStopTimeout) break;
        Thread.Sleep(1);  //TODO: better sleep
      }

      if (_thread != null)
      {
        try
        {
          _thread.Abort();
        } catch { }

        try
        {
          _thread.Interrupt();
        }
        catch { }
      }

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
        if (_thread != null && _threadShouldAbort) return false;
        if (_port.BytesToRead > 0) return true;
        TimeSpan span = DateTime.Now - start;
        if (span.TotalMilliseconds > waitTimeMiliseconds) return false;
        Thread.Sleep(1); //TODO: better sleep
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
    /// Gets a list of pins from Arduino and populates DigitalPins property
    /// </summary>
    private void GenerateDigitalPins()
    {
      //D0:S0,D1:S0,D2:S0,D3:S1,D4:S0,D5:S1,D6:S1,D7:S0,D8:S0,D9:S1,D10:S1,D11:S1,D12:S0,D13:S0,A0,A1,A2,A3,A4,A5

      string configString = GetPinConfig();
      string[] pinStrings = configString.Split(',');
      List<DigitalPin> digitalPins = new List<DigitalPin>();
      List<AnalogPin> analogPins = new List<AnalogPin>();

      foreach (string pinString in pinStrings)
      {
        if (pinString.StartsWith("D")) digitalPins.Add(new DigitalPin(pinString));
        else if (pinString.StartsWith("A")) analogPins.Add(new AnalogPin(pinString));
      }

      _digitalPins = digitalPins.ToArray();
      _analogPins = analogPins.ToArray();
    }

    /// <summary>
    /// Gets statuses and values of each pin from arduino and updates local lists
    /// </summary>
    private void UpdatePinStatuses()
    {
      string pinsStatusString = GetPinStatus();
      string[] statusStrings = pinsStatusString.Split(',');

      foreach (string statusString in statusStrings)
      {
        string[] props = statusString.Split(':');
        string key = props[0].Substring(0, 1);
        string value = props[0].Substring(1, props[0].Length - 1);
        int pinNumber = int.Parse(value);

        if (key == "D") DigitalPins[pinNumber].UpdateStatus(statusString);
        else if (key == "A") AnalogPins[pinNumber].UpdateStatus(statusString);
      }
      _lastPinStatusRefreshTime = DateTime.Now;
    }

    /// <summary>
    /// Runs in background thread. Periodically refreshes pin statuses and values
    /// </summary>
    private void Work()
    {
      try
      {
        while (!_threadShouldAbort)
        {
          TimeSpan span = DateTime.Now - _lastPinStatusRefreshTime;
          if (span.TotalMilliseconds > PIN_STATUS_REFRESH_MS)
          {
            lock (_locker)
            {
              UpdatePinStatuses();
            }
            OnPinStatusChanged();
          }

          Thread.Sleep(1);  //TODO: use better sleep
        }
      }
      catch (ThreadAbortException)
      {
        OnLog("ArduinoCommunicator worker thread was forcibly aborted");
      }
      catch (ThreadInterruptedException)
      {
        OnLog("ArduinoCommunicator worker thread was forcibly interrupted and stopped");
      }
      catch (Exception ex)
      {
        OnLog(string.Format("Critial ArduinoCommunicator error. {0}", ex.Message));
      }
      finally
      {
        _threadShouldAbort = true;
        _thread = null;
      }
    }

    #endregion Infrastructure

    #region Requests
    /// <summary>
    /// Requests the software version from the Arduino
    /// </summary>
    /// <returns>The version number</returns>
    private int GetVersion()
    {
      string request = BuildRequest(RequestType.GetVersion);
      string response = SendRequest(request);
      return int.Parse(ParseResponse(response)[0]);
    }

    public void ResetPins()
    {
      lock (_locker)
      {
        string request = BuildRequest(RequestType.ResetPins);
        string response = SendRequest(request);
        ParseResponse(response);

        UpdatePinStatuses();
      }

      OnPinStatusChanged();
    }

    private string GetPinConfig()
    {
      string request = BuildRequest(RequestType.GetPinConfig);
      string response = SendRequest(request);
      List<string> responseValues = ParseResponse(response);
      return responseValues[0];
    }

    /// <summary>
    /// Gets statuses and values of each pin from arduino in string format
    /// </summary>
    /// <returns></returns>
    private string GetPinStatus()
    {
      string request = BuildRequest(RequestType.GetPinStatus);
      string response = SendRequest(request);
      List<string> responseValues = ParseResponse(response);
      return responseValues[0];
    }

    /// <summary>
    /// Writes a boolean value to the digital pin. Sets the pin to boolean output mode if required
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="value"></param>
    public void DigitalWrite(int pin, bool value)
    {
      lock (_locker)
      {
        string request = BuildRequest(RequestType.DigitalWrite, pin.ToString(), value ? "1" : "0");
        string response = SendRequest(request);
        ParseResponse(response);

        _digitalPins[pin].PinMode = DigitalPinMode.BoolWrite;
        _digitalPins[pin].BoolValue = value;
      }
      OnPinStatusChanged();
    }

    public bool DigitalRead(int pin)
    {
      bool value = false;

      lock (_locker)
      {
        string request = BuildRequest(RequestType.DigitalRead, pin.ToString());
        string response = SendRequest(request);
        List<string> responseValues = ParseResponse(response);

        value = responseValues[0] == "1";

        _digitalPins[pin].PinMode = DigitalPinMode.BoolRead;
        _digitalPins[pin].BoolValue = value;
      }

      OnPinStatusChanged();

      return value;
    }


    /// <summary>
    /// Writes a pwm value to the digital pin. Sets the pin to pwm output mode if required
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="value"></param>
    public void AnalogWrite(int pin, byte value)
    {
      lock (_locker)
      {
        string request = BuildRequest(RequestType.Pwm, pin.ToString(), value.ToString());
        string response = SendRequest(request);
        ParseResponse(response);

        _digitalPins[pin].PinMode = DigitalPinMode.Pwm;
        _digitalPins[pin].PwmValue = value;
      }

      OnPinStatusChanged();
    }

    public int AnalogRead(int pin)
    {
      int value = 0;

      lock (_locker)
      {
        string request = BuildRequest(RequestType.AnalogRead, pin.ToString());
        string response = SendRequest(request);
        List<string> responseValues = ParseResponse(response);

        value = int.Parse(responseValues[0]);
        _analogPins[pin].Value = value;
      }

      OnPinStatusChanged();

      return value;
    }

    /// <summary>
    /// Writes a tone value to the digital pin. Sets the pin to Tone output moed if required
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="frequency"></param>
    /// <param name="duration"></param>
    public void Tone(int pin, int frequency, int duration)
    {
      lock (_locker)
      {
        string request = BuildRequest(RequestType.Tone, pin.ToString(), frequency.ToString(), duration.ToString());
        string response = SendRequest(request);
        ParseResponse(response);

        _digitalPins[pin].PinMode = DigitalPinMode.Tone;
        _digitalPins[pin].Frequency = frequency;
        _digitalPins[pin].Duration = duration;
      }

      OnPinStatusChanged();
    }


    /// <summary>
    /// Stops the tone output on the pin. Sets the pin to the tone output mode if required
    /// </summary>
    /// <param name="pin"></param>
    public void NoTone(int pin)
    {
      lock (_locker)
      {
        string request = BuildRequest(RequestType.NoTone, pin.ToString());
        string response = SendRequest(request);
        ParseResponse(response);

        _digitalPins[pin].PinMode = DigitalPinMode.Tone;
      }

      OnPinStatusChanged();
    }

    public string Debug()
    {
      lock (_locker)
      {
        string request = BuildRequest(RequestType.Debug);
        string response = SendRequest(request);
        List<string> responseValues = ParseResponse(response);
        return responseValues[0];
      }
    }
    #endregion Requests
  }
}
