using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoScope
{
  public class SignalChannel
  {
    private int _microsecondsPerSample;
    private int _bufferLengthMicroseconds;
    private CircularBuffer _buffer = null;

    public int MicrosecondsPerSample
    {
      get { return _microsecondsPerSample; }
    }

    public int BufferLengthMicroseconds
    {
      get { return _bufferLengthMicroseconds; }
    }

    public int TotalBytes
    {
      get { return _buffer.Length; }
    }

    public SignalChannel() : this(20, 20 * 1000 * 1000)
    {
      //20 microseconds per sample
      //20 seconds total
    }

    public SignalChannel (int microsecondsPerSample, int bufferLengthMicroseconds)
    {
      _microsecondsPerSample = microsecondsPerSample;
      _bufferLengthMicroseconds = bufferLengthMicroseconds;
      _buffer = new CircularBuffer(bufferLengthMicroseconds / _microsecondsPerSample);
    }

    public void WriteSamples(byte[] samples)
    {
      _buffer.Add(samples);
    }

    public byte[] ReadSamples(int lengthMicroseconds)
    {
      int bufferReadLength = lengthMicroseconds / _microsecondsPerSample;
      return _buffer.GetLast(bufferReadLength);
    }
  }
}
