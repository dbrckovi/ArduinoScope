﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorFontEditor
{
  public class FontLine
  {
    public PointF P1 = new PointF();
    public PointF P2 = new PointF();

    public FontLine(PointF p1, PointF p2)
    {
      P1 = p1;
      P2 = p2;
    }

    public FontLine Copy()
    {
      FontLine copy = new FontLine(P1, P2);
      return copy;
    }
  }
}
