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
    private byte[] _buffer = null;
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
      _buffer = new byte[length];
    }

    /// <summary>
    /// Adds specified bytes to the buffer. When the buffer is full, internal pointer starts from the beginning, rewriting the old bytes
    /// </summary>
    /// <param name="array"></param>
    public void Add(byte[] array)
    {
      //TODO: refactor... this can be much simpler in a simple loop which copies what it can and remembers the indexes for next pass

      if (array == null || array.Length == 0) return;

      lock (_locker)
      {
        if (array.Length > _buffer.Length)
        {
          //more bytes were sent than the length of the buffer
          //add the entire length of the buffer from the end of the bytes array and set pointer to the end
          Buffer.BlockCopy(array, array.Length - _buffer.Length, _buffer, 0, _buffer.Length);
          _pointer = 0;
        }
        else  
        {
          //less then lenght of the buffer was sent
          int lenToEnd = _buffer.Length - _pointer;
          if (array.Length <= lenToEnd)
          {
            //if entire array fits without overflow, add and update pointer
            Buffer.BlockCopy(array, 0, _buffer, _pointer, array.Length);
            _pointer += array.Length;
            if (_pointer == _buffer.Length) _pointer = 0;
          }
          else
          {
            //not everything fits, copy what we can to the end
            Buffer.BlockCopy(array, 0, _buffer, _pointer, lenToEnd);
            _pointer = 0;

            //copy the rest to the beginning of the buffer
            int rest = array.Length - lenToEnd;
            Buffer.BlockCopy(array, lenToEnd, _buffer, _pointer, rest);
            _pointer += rest;
          }
        }
      }
    }

    /// <summary>
    /// Gets specified amount of bytes from the buffer. Bytes are ordered chronologically as they were written to the buffer. Oldest first. Last byte in the returned array is always the last written to the buffer
    /// </summary>
    /// <param name="length">Number of bytes to copy from the current end of the buffer. Must be smaller than the length of the buffer</param>
    public byte[] GetLast(int length)
    {
      //TODO: refactor... this can be done simpler, in a loop

      if (length > _buffer.Length) throw new Exception("Requested length is larger than the buffer");
      byte[] ret = new byte[length];

      lock (_locker)
      {
        if (length <= _pointer)
        {
          //if we have enough in front of the pointer, just return it 
          Buffer.BlockCopy(_buffer, _pointer - length, ret, 0, length);
        }
        else
        {
          //overflow on the left side
          //first take the part from the end of the buffer
          int lenToStart = _pointer;
          int partOnTheEnd = length - lenToStart;
          Buffer.BlockCopy(_buffer, _buffer.Length - partOnTheEnd, ret, 0, partOnTheEnd);

          //take the rest from the beginning of the buffer
          Buffer.BlockCopy(_buffer, 0, ret, partOnTheEnd, lenToStart);
        }
      }

      return ret;
    }

  }
}
