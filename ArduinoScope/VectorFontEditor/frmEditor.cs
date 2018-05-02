using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorFontEditor
{
  public partial class frmEditor : Form
  {
    Graphics _surfaceG = null;
    Graphics _g = null;
    Bitmap _buffer = null;
    PointF? _indicator = null;
    Pen _gridPen = Pens.LightGray;
    Pen _gridHighlightedPen = Pens.Gray;
    Pen _fontLinePen = new Pen(Color.Black, 2);
    Pen _newLinePen = new Pen(Color.Blue, 2);
    Pen _nearestLinePen = new Pen(Color.Red, 2);
    List<FontLine> _fontLines = new List<FontLine>();
    PointF? _newLineStart = null;
    FontLine _nearestLine = null;
    FontFile _file = new FontFile(Application.StartupPath + "\\font.ffs");

    public frmEditor()
    {
      InitializeComponent();
      _surfaceG = pnlEditor.CreateGraphics();
      _buffer = new Bitmap(pnlEditor.Width, pnlEditor.Height);
      _g = Graphics.FromImage(_buffer);
    }

    private void pnlEditor_Paint(object sender, PaintEventArgs e)
    {
      DrawEverything();
    }

    private void DrawEverything()
    {
      _g.Clear(Color.White);
      DrawGrid();
      DrawFontLines();
      DrawIndicator();
      DrawNewLine();
      DrawNearestLine();

      _surfaceG.DrawImage(_buffer, new Point(0, 0));
      pnlPreview.CreateGraphics().DrawImage(_buffer, new Rectangle(0, 0, pnlPreview.Width, pnlPreview.Height));
    }

    private void DrawGrid()
    {
      for (float x = 1; x <= 7; x++)
      {
        Pen pen = _gridPen;
        if (x == 4) pen = _gridHighlightedPen;
        DrawGridLine(pen, new PointF(x, 0f), new PointF(x, 12f));
      }

      for (float y = 1; y <= 11; y++)
      {
        Pen pen = _gridPen;
        if (y == 6) pen = _gridHighlightedPen;
        DrawGridLine(pen, new PointF(0f, y), new PointF(8f, y));
      }
    }

    private void DrawGridLine(Pen pen, PointF point1, PointF point2)
    {
      Point p1 = ToPhysical(point1);
      Point p2 = ToPhysical(point2);

      _g.DrawLine(pen, p1, p2);
    }

    private void DrawFontLines()
    {
      foreach (FontLine line in _fontLines)
      {
        Point p1 = ToPhysical(line.P1);
        Point p2 = ToPhysical(line.P2);
        _g.DrawLine(_fontLinePen, p1, p2);
      }
    }

    private void DrawIndicator()
    {
      if (_indicator != null)
      {
        Point physical = ToPhysical(_indicator.Value);
        Rectangle rect = new Rectangle(physical.X - 5, physical.Y - 5, 10, 10);
        _g.DrawEllipse(Pens.Blue, rect);
      }
    }

    private void DrawNewLine()
    {
      if (!_indicator.HasValue || !_newLineStart.HasValue) return;
      Point p1 = ToPhysical(_newLineStart.Value);
      Point p2 = ToPhysical(_indicator.Value);
      _g.DrawLine(_newLinePen, p1, p2);
    }

    private void DrawNearestLine()
    {
      if (_nearestLine == null) return;
      Point p1 = ToPhysical(_nearestLine.P1);
      Point p2 = ToPhysical(_nearestLine.P2);
      _g.DrawLine(_nearestLinePen, p1, p2);
    }

    private PointF ToLogical(Point point)
    {
      float logicalX = (float)point.X / (float)pnlEditor.Width * 8;
      float logicalY = 12 - (float)point.Y / (float)pnlEditor.Height * 12;

      return new PointF(logicalX, logicalY);
    }

    private Point ToPhysical(PointF point)
    {
      int physicalX = Convert.ToInt32((point.X / 8) * (float)pnlEditor.Width);
      int physicalY = pnlEditor.Height - Convert.ToInt32((point.Y / 12) * (float)pnlEditor.Height);

      return new Point(physicalX, physicalY);
    }

    private FontLine FindNearestLine(PointF point)
    {
      if (_fontLines.Count == 0) return null;
      FontLine ret = null;
      float closestDistance = float.MaxValue;

      foreach (FontLine line in _fontLines)
      {
        float distance = FindDistanceToSegment(point, line.P1, line.P2);
        if (distance < .1 && distance < closestDistance) ret = line;
      }

      return ret;
    }

    private float FindDistanceToSegment(PointF pt, PointF p1, PointF p2)
    {
      PointF closest = new PointF();
      float dx = p2.X - p1.X;
      float dy = p2.Y - p1.Y;
      if ((dx == 0) && (dy == 0))
      {
        // It's a point not a line segment.
        closest = p1;
        dx = pt.X - p1.X;
        dy = pt.Y - p1.Y;
        return (float)Math.Sqrt(dx * dx + dy * dy);
      }

      // Calculate the t that minimizes the distance.
      float t = ((pt.X - p1.X) * dx + (pt.Y - p1.Y) * dy) /
          (dx * dx + dy * dy);

      // See if this represents one of the segment's
      // end points or a point in the middle.
      if (t < 0)
      {
        closest = new PointF(p1.X, p1.Y);
        dx = pt.X - p1.X;
        dy = pt.Y - p1.Y;
      }
      else if (t > 1)
      {
        closest = new PointF(p2.X, p2.Y);
        dx = pt.X - p2.X;
        dy = pt.Y - p2.Y;
      }
      else
      {
        closest = new PointF(p1.X + t * dx, p1.Y + t * dy);
        dx = pt.X - closest.X;
        dy = pt.Y - closest.Y;
      }

      return (float)Math.Sqrt(dx * dx + dy * dy);
    }

    private void pnlEditor_MouseMove(object sender, MouseEventArgs e)
    {
      bool drawNeeded = false;
      PointF logical = ToLogical(new Point(e.X, e.Y));

      float nearestX = (float)Math.Round(logical.X);
      float nearestY = (float)Math.Round(logical.Y);

      if (_indicator.Value.X != nearestX || _indicator.Value.Y != nearestY)
      {
        _indicator = new PointF(nearestX, nearestY);
        drawNeeded = true;
      }


      FontLine _newNearest = FindNearestLine(logical);
      if (
        (_newNearest == null && _nearestLine != null)
        || (_newNearest != null && _nearestLine == null)
        || (_newNearest != null && _nearestLine != null && _newNearest != _nearestLine)
        )
      {
        _nearestLine = _newNearest;
        drawNeeded = true;
      }

      if (drawNeeded) DrawEverything();

      lblLogicalCoordinate.Text = logical.ToString() + "|   " + nearestX.ToString() + ",    " + nearestY.ToString();
    }

    private void pnlEditor_MouseEnter(object sender, EventArgs e)
    {
      _indicator = new PointF(3, 4);
      DrawEverything();
    }

    private void pnlEditor_MouseLeave(object sender, EventArgs e)
    {
      _indicator = null;
      _nearestLine = null;
      _newLineStart = null;
      DrawEverything();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      char character = txtCharacter.Text.ToCharArray()[0];
      _file.SaveCharacter(character, _fontLines);
      _file.Save();
      fontTester1.DrawText();
    }

    private void pnlEditor_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        if (_indicator == null)
        {
          _newLineStart = null;
          return;
        }

        if (_newLineStart == null)
        {
          _newLineStart = new PointF(_indicator.Value.X, _indicator.Value.Y);
        }
        else
        {
          if (_newLineStart.Value.X != _indicator.Value.X || _newLineStart.Value.Y != _indicator.Value.Y)
          {
            _fontLines.Add(new FontLine(_newLineStart.Value, _indicator.Value));
            _newLineStart = null;
          }
        }
      }
      else if (e.Button == MouseButtons.Right)
      {
        if (_newLineStart != null) _newLineStart = null;
        else
        {
          if (_nearestLine != null)
          {
            _fontLines.Remove(_nearestLine);
            _nearestLine = null;
          }
        }
      }

      DrawEverything();
    }

    private void frmEditor_Load(object sender, EventArgs e)
    {
      _file.Load();
      fontTester1._file = _file;
    }

    private void txtCharacter_TextChanged(object sender, EventArgs e)
    {
      btnSave.Enabled = pnlEditor.Enabled = txtCharacter.Text.Length == 1;

      if (txtCharacter.Text.Length > 0)
      {
        char c = txtCharacter.Text.ToCharArray()[0];
        _fontLines = _file.LoadCharacter(c);
      }
      else
      {
        _fontLines = null;
        _nearestLine = null;
        _indicator = null;
        _newLineStart = null;
      }
      DrawEverything();
    }

    private void frmEditor_FormClosing(object sender, FormClosingEventArgs e)
    {
      _file.Save();
    }

    private void txtCharacter_KeyPress(object sender, KeyPressEventArgs e)
    {
      txtCharacter.Text = e.KeyChar.ToString();
    }
  }
}

