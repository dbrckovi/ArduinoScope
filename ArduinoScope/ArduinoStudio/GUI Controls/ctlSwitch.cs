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
  public partial class ctlSwitch : UserControl
  {
    public bool Value
    {
      get
      {
        return chkTrue.Value;
      }
      set
      {
        chkTrue.Value = value;
        chkFalse.Value = !value;
      }
    }

    public Image True_On_Image
    {
      get { return chkTrue.On_Image; }
      set { chkTrue.On_Image = value; }
    }

    public Image True_Off_Highlight_Image
    {
      get { return chkTrue.Off_Highlight_Image; }
      set { chkTrue.Off_Highlight_Image = value; }
    }

    public Image True_Off_Image
    {
      get { return chkTrue.Off_Image; }
      set { chkTrue.Off_Image = value; }
    }

    public Image False_On_Image
    {
      get { return chkFalse.On_Image; }
      set { chkFalse.On_Image = value; }
    }

    public Image False_Off_Highlight_Image
    {
      get { return chkFalse.Off_Highlight_Image; }
      set { chkFalse.Off_Highlight_Image = value; }
    }

    public Image False_Off_Image
    {
      get { return chkFalse.Off_Image; }
      set { chkFalse.Off_Image = value; }
    }

    public ctlSwitch()
    {
      InitializeComponent();
    }

    private void chkTrue_Click(object sender, EventArgs e)
    {
      Value = true;
    }

    private void chkFalse_Click(object sender, EventArgs e)
    {
      Value = false;
    }
  }
}
