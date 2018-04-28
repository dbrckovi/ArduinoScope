using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoScope
{
  /// <summary>
  /// Simple circular buffer.
  /// </summary>
  public class CircularBuffer
  {
    private SamplePoint[] _buffer = null;
    private int _pointer = 0;
    private object _locker = new object();

    /// <summary>
    /// Gets the length of the buffer
    /// </summary>
    public int Length
    {
      get { return _buffer.Length; }
    }

    /// <summary>
    /// Constructs new instance of the CircularBuffer.
    /// </summary>
    /// <param name="length">Total number of bytes in the buffer</param>
    public CircularBuffer(int length)
    {
      _buffer = new SamplePoint[length];
    }

    /// <summary>
    /// Adds new samples to the end of the buffer. When the buffer is full, internal pointer starts from the beginning, rewriting the old bytes
    /// </summary>
    /// <param name="array"></param>
    public void Add(SamplePoint[] array)
    {
      //TODO: refactor... this can be much simpler in a simple loop which copies what it can and remembers the indexes for next pass
      if (array == null || array.Length == 0) return;

      lock (_locker)
      {
        if (array.Length > _buffer.Length)
        {
          //more bytes were sent than the length of the buffer
          //add only the last part of the array to the buffer (efectivelly overwritting the entire buffer)
          CopyArray(array, array.Length - _buffer.Length, _buffer, 0, _buffer.Length);
          _pointer = 0;
        }
        else  
        {
          //less then lenght of the buffer was sent
          int lenToEnd = _buffer.Length - _pointer;
          if (array.Length <= lenToEnd)
          {
            //if entire array fits without overflow, add and update pointer
            CopyArray(array, 0, _buffer, _pointer, array.Length);
            _pointer += array.Length;
            if (_pointer == _buffer.Length) _pointer = 0;
          }
          else
          {
            //not everything fits, copy what we can to the end
            CopyArray(array, 0, _buffer, _pointer, lenToEnd);
            _pointer = 0;

            //copy the rest to the beginning of the buffer
            int rest = array.Length - lenToEnd;
            CopyArray(array, lenToEnd, _buffer, _pointer, rest);
            _pointer += rest;
          }
        }
      }
    }

    /// <summary>
    /// Gets specified amount of samples from the end of the buffer.
    /// </summary>
    /// <param name="length">Number of samples to copy from the current end of the buffer.</param>
    public SamplePoint[] GetLast(int length)
    {
      if (length > _buffer.Length) length = _buffer.Length;
      //TODO: refactor... this can be done simpler, in a loop
      SamplePoint[] ret = new SamplePoint[length];

      lock (_locker)
      {
        if (length <= _pointer)
        {
          //if we have enough in front of the pointer, just return it 
          CopyArray(_buffer, _pointer - length, ret, 0, length);
        }
        else
        {
          //overflow on the left side
          //first take the part from the end of the buffer
          int lenToStart = _pointer;
          int partOnTheEnd = length - lenToStart;
          CopyArray(_buffer, _buffer.Length - partOnTheEnd, ret, 0, partOnTheEnd);

          //take the rest from the beginning of the buffer
          CopyArray(_buffer, 0, ret, partOnTheEnd, lenToStart);
        }
      }

      return ret;
    }

    /// <summary>
    /// Gets samples from the end of the buffer which are within a specified time period (+ 1 additional sample)
    /// </summary>
    /// <param name="seconds">Time perdiod from the end of the buffer</param>
    /// <returns></returns>
    public SamplePoint[] GetLast(double seconds)
    {
      int length = 0;
      double totalTime = 0;
      int localPointer = _pointer - 1;
      if (localPointer < 0) localPointer = _buffer.Length -1;

      while(true)
      {
        if (totalTime > seconds) break;
        if (localPointer == _pointer) break;
        totalTime += _buffer[localPointer].TimeOffset;
        length++;
        localPointer--;
        if (localPointer < 0) localPointer = _buffer.Length - 1;
      }

      return GetLast(length);
    }

    /// <summary>
    /// Copies a specified number of sample points from source array, starting at a particular offset, to a destination array, starting at a particular offset
    /// </summary>
    /// <param name="src"></param>
    /// <param name="srcOffset"></param>
    /// <param name="dst"></param>
    /// <param name="dstOffset"></param>
    /// <param name="count"></param>
    public static void CopyArray(SamplePoint[] src, int srcOffset, SamplePoint[] dst, int dstOffset, int count)
    {
      for (int x = 1; x <= count; x++)
      {
        dst[dstOffset] = src[srcOffset];
        dstOffset++;
        srcOffset++;
      }
    }
  }
}
