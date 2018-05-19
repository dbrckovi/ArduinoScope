using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoStudio
{
  public static class Msgbox
  {
    public static DialogResult Show (IWin32Window owner, Exception ex)
    {
      return Show(owner, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static DialogResult Show(IWin32Window owner, string message)
    {
      return Show(owner, message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult Show(IWin32Window owner, string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
      return MessageBox.Show(owner, message, title, buttons, icon);
    }
  }
}
