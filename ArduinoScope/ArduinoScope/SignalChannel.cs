using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoScope
{
  public class SignalChannel
  {
    private CircularBuffer _buffer = null;

    /// <summary>
    /// Initializes the buffer with one million samples
    /// </summary>
    public SignalChannel() : this(100000)
    {
      
    }

    /// <summary>
    /// Initializes the buffer with arbitrary number of samples
    /// </summary>
    /// <param name="bufferSize"></param>
    public SignalChannel (int bufferSize)
    {
      _buffer = new CircularBuffer(bufferSize);
    }

    public void WriteSamples(SamplePoint[] samples)
    {
      _buffer.Add(samples);
    }

    public SamplePoint[] ReadSamples(float seconds)
    {
      return _buffer.GetLast(seconds);
    }
  }
}
