using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tester
{
  public partial class Form1 : Form
  {
    SamplePoint[] _buffer = new SamplePoint[1000000];
    SamplePoint[] _newSamples = new SamplePoint[1000000];
    Random _rand = new Random();

    public Form1()
    {
      InitializeComponent();
    }

    private void NormalCopy()
    {
      for (int x = 0; x < _newSamples.Length; x++)
      {
        _buffer[x] = _newSamples[x];
      }
    }

    private void ValueCopy()
    {
      for (int x = 0; x < _newSamples.Length; x++)
      {
        _buffer[x].Value = _newSamples[x].Value;
        _buffer[x].TimeOffset = _newSamples[x].TimeOffset;
      }
    }

    private void btnCopyNormal_Click(object sender, EventArgs e)
    {
      float total = 0;
      for (int x = 1; x <= 100; x++)
      {
        DateTime start = DateTime.Now;
        NormalCopy();
        TimeSpan span = DateTime.Now - start;
        total += (float)span.TotalMilliseconds;
      }
      richTextBox1.AppendText(string.Format("Normal average: {0}\r\n", total / 100));
    }

    private void btnBlockCopy_Click(object sender, EventArgs e)
    {
      float total = 0;
      for (int x = 1; x <= 100; x++)
      {
        DateTime start = DateTime.Now;
        ValueCopy();
        TimeSpan span = DateTime.Now - start;
        total += (float)span.TotalMilliseconds;
      }
      richTextBox1.AppendText(string.Format("Value average: {0}\r\n", total / 100));
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      for (int x = 0; x < _newSamples.Length; x++)
      {
        _newSamples[x].Value = (float)_rand.NextDouble();
        _newSamples[x].TimeOffset = (float)_rand.NextDouble();
      }
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      richTextBox1.Text = "";
    }
  }
}
