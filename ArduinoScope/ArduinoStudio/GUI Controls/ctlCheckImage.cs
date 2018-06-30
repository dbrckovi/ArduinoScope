using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoStudio.GUI_Controls
{
  public partial class ctlCheckImage : UserControl
  {
    private bool _isMouseOver = false;
    private bool _value = false;
    private Image _on_Image = null;
    private Image _off_Highlight_Image = null;
    private Image _off_Image = null;

    public bool Value
    {
      get { return _value; }
      set
      {
        _value = value;
        Redraw();
      }
    }

    public Image On_Image
    {
      get { return _on_Image; }
      set
      {
        _on_Image = value;
        Redraw();
      }
    }

    public Image Off_Highlight_Image
    {
      get { return _off_Highlight_Image; }
      set
      {
        _off_Highlight_Image = value;
        Redraw();
      }
    }

    public Image Off_Image
    {
      get { return _off_Image; }
      set
      {
        _off_Image = value;
        Redraw();
      }
    }

    public ctlCheckImage()
    {
      InitializeComponent();
    }

    private void Redraw()
    {
      if (_value)
      {
        picCheck.Image = _on_Image;
      }
      else
      {
        picCheck.Image = _isMouseOver ? _off_Highlight_Image : _off_Image;
      }
    }

    private void picCheck_Click(object sender, EventArgs e)
    {
      this.OnClick(e);
    }

    private void picCheck_MouseEnter(object sender, EventArgs e)
    {
      _isMouseOver = true;
      Redraw();
    }

    private void picCheck_MouseLeave(object sender, EventArgs e)
    {
      _isMouseOver = false;
      Redraw();
    }
  }
}
