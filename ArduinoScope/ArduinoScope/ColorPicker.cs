using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoScope
{
  [DefaultEvent("SelectedColorChanged")]
  public partial class ColorPicker : UserControl
  {
    public Color SelectedColor
    {
      get { return lblColor.BackColor; }
      set
      {
        lblColor.BackColor = value;
        OnSelectedColorChanged();
      }
    }

    public event EventHandler SelectedColorChanged;
    private void OnSelectedColorChanged()
    {
      if (SelectedColorChanged != null) SelectedColorChanged(this, new EventArgs());
    }

    public ColorPicker()
    {
      InitializeComponent();
    }

    private void lblColor_Click(object sender, EventArgs e)
    {
      colorDialog1.Color = SelectedColor;
      DialogResult result = colorDialog1.ShowDialog(this.ParentForm);
      if (result == DialogResult.OK)
      {
        SelectedColor = colorDialog1.Color;
      }
    }
  }
}
