using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace ArduinoStudio
{
  public partial class ScopeControl : UserControl
  {
    //Variables

    private bool _rescaleNeeded = false;
    private Color _backColor = Color.SlateGray;
    private Color _gridColor = Color.DarkSlateGray;
    private Color _graphColor = Color.PapayaWhip;
    private float _voltsPerDiv = 0.5f;
    private float _secondsPerDiv = 0.1f;
    private bool _acCoupled = false;
    private float _bottomVolts = 0f;
    private float _topVolts = 0f;
    //private SignalChannel _channel = null;


    //Properties

    public float SecondsPerDiv
    {
      get { return _secondsPerDiv; }
      set
      {
        _secondsPerDiv = value;
        _rescaleNeeded = true;
      }
    }

    public float VoltsPerDiv
    {
      get { return _voltsPerDiv; }
      set
      {
        _voltsPerDiv = value;
        _rescaleNeeded = true;
      }
    }

    private float VisibleSeconds
    {
      get { return _secondsPerDiv * 10; }
    }

    private float VisibleVolts
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

    //public SignalChannel Channel
    //{
    //  get { return _channel; }
    //}

    #region Constructors
    public ScopeControl()
    {
      InitializeComponent();
      
    }
    #endregion Constructors

    public void CreateChannel()
    {
      //_channel = new SignalChannel();
    }

    private void Rescale()
    {
      if (Program.DesignTime) return;

      glCtl.MakeCurrent();
      GL.ClearColor(_backColor);
      GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

      //Specify view in natural coordinates (positive X is right, positive Y is up). This works only if Scale is set properly below
      Matrix4 ortoMatrix;

      if (_acCoupled)
      {
        _bottomVolts = -(float)VisibleVolts / 2;
        _topVolts = (float)VisibleVolts / 2;
      }
      else
      {
        _bottomVolts = 0f;
        _topVolts = (float)VisibleVolts;
      }

      ortoMatrix = Matrix4.CreateOrthographicOffCenter(0f, (float)VisibleSeconds, _bottomVolts, _topVolts, 0.0f, 1.0f);

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

      for (float x = _secondsPerDiv; x < VisibleSeconds; x += _secondsPerDiv)
      {
        GL.Vertex3(x, _bottomVolts, 0.0f);
        GL.Vertex3(x, _topVolts, 0.0f);
      }

      for (float y = _bottomVolts + _voltsPerDiv; y < _topVolts; y += _voltsPerDiv)
      {
        GL.Vertex3(0, y, 0.0f);
        GL.Vertex3(VisibleSeconds, y, 0.0f);
      }

      GL.End();
    }

    private void RenderGraph()
    {
      //SamplePoint[] data = Channel.ReadSamples(VisibleSeconds);

      GL.Begin(PrimitiveType.LineStrip);

      GL.Color3(_graphColor);

      //float _secondOffset = 0f;
      //for (int x = data.Length - 1; x >= 0; x--)
      //{
      //  float posX = VisibleSeconds + _secondOffset;
      //  float posY = data[x].Value;

      //  GL.Vertex3(posX, posY, 0.0f);
      //  _secondOffset -= data[x].TimeOffset;
      //}

      GL.End();
    }

    private void DrawString()
    {

    }

    Point GLToScreen(PointF samplePointCoordinates)
    {
      float x = ClientRectangle.Width * (samplePointCoordinates.X / VisibleSeconds);
      float y = ClientRectangle.Height * (_topVolts - samplePointCoordinates.Y) / VisibleVolts;

      return new Point(Convert.ToInt32(x), Convert.ToInt32(y));
    }

    PointF ScreenToGL(Point screenCoordinates)
    {
      float x = VisibleSeconds * ((float)screenCoordinates.X / ClientRectangle.Width);
      float y = VisibleVolts * ((float)(ClientRectangle.Height - screenCoordinates.Y) / ClientRectangle.Height) + _bottomVolts;
      return new PointF(x, y);
    }

    private void glCtl_Paint(object sender, PaintEventArgs e)
    {
      if (Program.DesignTime) return;

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

      glCtl.SwapBuffers();
    }

    private void glCtl_Resize(object sender, EventArgs e)
    {
      Rescale();
    }
  }
}
