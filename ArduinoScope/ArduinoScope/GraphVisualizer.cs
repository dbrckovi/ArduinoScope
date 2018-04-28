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
    private double _secondsPerDiv = 0.1d;
    private bool _acCoupled = false;

    public double SecondsPerDiv
    {
      get { return _secondsPerDiv; }
      set
      {
        _secondsPerDiv = value;
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

    private double VisibleSeconds
    {
      get { return _secondsPerDiv * 10; }
    }

    private double VisibleVolts
    {
      get { return _voltsPerDiv * 10; }
    }

    /// <summary>
    /// When true, zero volts will be at the center of the graph.
    /// When true, zero volts will be at the bottom of the graph.
    /// </summary>
    public bool ACCoupled
    {
      get { return _acCoupled; }
      set
      {
        _acCoupled = value;
        _rescaleNeeded = true;
      }
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
      Matrix4 ortoMatrix;

      if (_acCoupled)
      {
        ortoMatrix = Matrix4.CreateOrthographicOffCenter(0f, (float)VisibleSeconds, 0f, (float)VisibleVolts, 0.0f, 1.0f);
      }
      else
      {
        ortoMatrix = Matrix4.CreateOrthographicOffCenter(0f, (float)VisibleSeconds, -(float)VisibleVolts / 2, (float)VisibleVolts / 2, 0.0f, 1.0f);
      }

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

      for (double x = _secondsPerDiv; x <= _secondsPerDiv * 9; x += _secondsPerDiv)
      {
        GL.Vertex3(x, 0, 0.0f);
        GL.Vertex3(x, VisibleVolts, 0.0f);
      }

      for (double y = _voltsPerDiv; y <= _voltsPerDiv * 9; y += _voltsPerDiv)
      {
        GL.Vertex3(0, y, 0.0f);
        GL.Vertex3(VisibleSeconds, y, 0.0f);
      }

      GL.End();
    }

    private void RenderGraph()
    {
      SamplePoint[] data = Channel.ReadSamples(VisibleSeconds);

      GL.Begin(PrimitiveType.LineStrip);

      GL.Color3(_graphColor);

      double _secondOffset = 0d;
      for (int x = data.Length - 1; x >= 0; x--)
      {
        double posX = VisibleSeconds + _secondOffset;
        double posY = data[x].Value;

        GL.Vertex3(posX, posY, 0.0f);
        _secondOffset -= data[x].TimeOffset;
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
