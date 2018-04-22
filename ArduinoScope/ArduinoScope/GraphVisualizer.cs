using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace ArduinoScope
{
  public class GraphVisualizer : GameWindow
  {
    private bool _rescaleNeeded = false;
    private Color _backColor = Color.SlateGray;
    private Color _gridColor = Color.DarkSlateGray;
    private Color _graphColor = Color.PapayaWhip;
    private double _voltsPerDiv = 0.5d;
    private int _microsecondsPerDiv = 20;

    public int MicrosecondsPerDiv
    {
      get { return _microsecondsPerDiv; }
      set
      {
        _microsecondsPerDiv = value;
        _rescaleNeeded = true;
      }
    }

    public double VoltsPerDiv
    {
      get { return _voltsPerDiv; }
      set
      {
        _voltsPerDiv = value;
        _rescaleNeeded = true;
      }
    }

    private int VisibleMicroseconds
    {
      get { return _microsecondsPerDiv * 10; }
    }

    private double VisibleVolts
    {
      get { return _voltsPerDiv * 10; }
    }

    private SignalChannel _channel = null;

    public SignalChannel Channel
    {
      get { return _channel; }
    }

    #region Constructors
    public GraphVisualizer() : base()
    {

    }
    #endregion Constructors

    protected override void OnLoad(EventArgs e)
    {
      Title = "Arduino Scope";
      base.OnLoad(e);
    }

    public void CreateChannel(int microsecondsPerSample, int bufferLengthMicroseconds)
    {
      _channel = new SignalChannel(microsecondsPerSample, bufferLengthMicroseconds);
    }

    public void CreateChannel()
    {
      _channel = new SignalChannel();
    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
      if (_rescaleNeeded)
      {
        Rescale();
        _rescaleNeeded = false;
      }

      GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

      Matrix4 modelview = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);
      GL.MatrixMode(MatrixMode.Modelview);
      GL.LoadMatrix(ref modelview);

      RenderGrid();
      RenderGraph();

      SwapBuffers();
      base.OnRenderFrame(e);
    }

    private void Rescale()
    {
      GL.ClearColor(_backColor);
      GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

      //Specify view in natural coordinates (positive X is right, positive Y is up). This works only if Scale is set properly below
      Matrix4 ortoMatrix = Matrix4.CreateOrthographicOffCenter(0f, VisibleMicroseconds, 0f, Convert.ToSingle(VisibleVolts), 0.0f, 1.0f);
      GL.MatrixMode(MatrixMode.Projection);
      GL.LoadMatrix(ref ortoMatrix);

      //Invert X so view can be specified naturally (above)
      Vector3 scaleVector = new Vector3(-1f, 1f, 1f);
      GL.Scale(scaleVector);
    }

    private void RenderGrid()
    {
      GL.Begin(PrimitiveType.Lines);

      GL.Color3(_gridColor);

      for (double x = _microsecondsPerDiv; x <= _microsecondsPerDiv * 9; x += _microsecondsPerDiv)
      {
        GL.Vertex3(x, 0, 0.0f);
        GL.Vertex3(x, VisibleVolts, 0.0f);
      }

      for (double y = _voltsPerDiv; y <= _voltsPerDiv * 9; y += _voltsPerDiv)
      {
        GL.Vertex3(0, y, 0.0f);
        GL.Vertex3(VisibleMicroseconds, y, 0.0f);
      }

      GL.End();
    }

    private void RenderGraph()
    {
      int microsecondsToTake = VisibleMicroseconds * 2;
      byte[] data = Channel.ReadSamples(microsecondsToTake);

      GL.Begin(PrimitiveType.LineStrip);

      GL.Color3(_graphColor);

      int _microsecondsOffset = 0;
      for (int x = data.Length - 1; x >= 0; x--)
      {
        double posX = VisibleMicroseconds + _microsecondsOffset;
        double posY = (Convert.ToDouble(data[x]) / 255) * VisibleVolts;

        GL.Vertex3(posX, posY, 0.0f);
        _microsecondsOffset -= Channel.MicrosecondsPerSample;
      }

      GL.End();
    }

    protected override void OnResize(EventArgs e)
    {
      Rescale();

      base.OnResize(e);
    }
  }
}
