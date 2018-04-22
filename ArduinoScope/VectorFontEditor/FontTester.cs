using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorFontEditor
{
  public partial class FontTester : UserControl
  {
    public FontFile _file = null;

    public FontTester()
    {
      InitializeComponent();
    }

    public void DrawText()
    {
      
      Graphics g = panel1.CreateGraphics();
      g.Clear(Color.White);

      if (txtSource.Text.Length == 0) return;

      int charWidth = Convert.ToInt32(8 * Convert.ToSingle(numScale.Value));
      int charHeight = Convert.ToInt32(12 * Convert.ToSingle(numScale.Value));
      int currentX = 0;


      foreach (char c in txtSource.Text.ToCharArray())
      {
        List<FontLine> lines = _file.LoadCharacter(c);

        foreach (FontLine line in lines)
        {
          Point p1 = ToPhysical(line.P1, new Size(charWidth, charHeight));
          Point p2 = ToPhysical(line.P2, new Size(charWidth, charHeight));

          p1 = new Point(p1.X + currentX, p1.Y);
          p2 = new Point(p2.X + currentX, p2.Y);

          g.DrawLine(Pens.Black, p1, p2);
        }

        currentX += Convert.ToInt32(charWidth);
      }

    }

    private Point ToPhysical(PointF point, Size margin)
    {
      int physicalX = Convert.ToInt32((point.X / 8) * (float)margin.Width);
      int physicalY = margin.Height - Convert.ToInt32((point.Y / 12) * (float)margin.Height);

      return new Point(physicalX, physicalY);
    }

    private void txtSource_TextChanged(object sender, EventArgs e)
    {
      DrawText();
    }

    private void numScale_ValueChanged(object sender, EventArgs e)
    {
      DrawText();
    }
  }
}
