using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoStudio
{
  public partial class ToneValueControl : UserControl
  {
    int _frequency = 440;
    int _duration = 0;

    public int Frequency
    {
      get { return _frequency; }
      set
      {
        if (_frequency == value) return;
        _frequency = value;
        if (_frequency < 31) _frequency = 31;
        if (_frequency > 20000) _frequency = 20000;
        txtFrequency.Text = value.ToString();
        trackFrequency.Value = value;
        OnValueChanged();
      }
    }

    public int Duration
    {
      get { return _duration; }
      set
      {
        if (_duration == value) return;
        _duration = value;
        txtDuration.Text = value.ToString();
        OnValueChanged();
      }
    }

    public event Delegates.ControlDelegate ValueChanged;
    private void OnValueChanged()
    {
      ValueChanged?.Invoke(this);
    }

    public ToneValueControl()
    {
      InitializeComponent();
    }

    private void trackFrequency_ValueChanged(object sender, EventArgs e)
    {
      Frequency = Convert.ToInt32(trackFrequency.Value);
    }

    private void txtFrequency_Validated(object sender, EventArgs e)
    {
      int frequency = 440;
      int.TryParse(txtFrequency.Text, out frequency);
      Frequency = frequency;
    }

    private void txtDuration_Validated(object sender, EventArgs e)
    {
      int duration = 0;
      int.TryParse(txtDuration.Text, out duration);
      Duration = duration;
    }

    private void txtDuration_Validating(object sender, CancelEventArgs e)
    {
      int duration = 0;
      if (!int.TryParse(txtDuration.Text, out duration)) e.Cancel = true;
    }

    private void txtFrequency_Validating(object sender, CancelEventArgs e)
    {
      int frequency = 0;
      if (!int.TryParse(txtFrequency.Text, out frequency)) e.Cancel = true;
      if (frequency < trackFrequency.Minimum || frequency > trackFrequency.Maximum) e.Cancel = true;
    }

    private void ToneValueControl_Load(object sender, EventArgs e)
    {
      txtFrequency.Text = Frequency.ToString();
      trackFrequency.Value = Frequency;
      txtDuration.Text = Duration.ToString();
    }
  }
}
