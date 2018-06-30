namespace ArduinoStudio
{
  partial class DigitalPinController
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblPinNumber = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.toneValueControl1 = new ArduinoStudio.ToneValueControl();
      this.pwmValueControl1 = new ArduinoStudio.PwmValueControl();
      this.outputBool = new ArduinoStudio.BoolControl();
      this.outputModeControl1 = new ArduinoStudio.OutputModeControl();
      this.pinModeControl1 = new ArduinoStudio.PinModeControl();
      this.SuspendLayout();
      // 
      // lblPinNumber
      // 
      this.lblPinNumber.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblPinNumber.Location = new System.Drawing.Point(2, 2);
      this.lblPinNumber.Name = "lblPinNumber";
      this.lblPinNumber.Size = new System.Drawing.Size(24, 21);
      this.lblPinNumber.TabIndex = 0;
      this.lblPinNumber.Text = "0\r\n";
      this.lblPinNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(92, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(11, 21);
      this.panel1.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(249, 2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(11, 21);
      this.panel2.TabIndex = 4;
      // 
      // panel3
      // 
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(342, 2);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(11, 21);
      this.panel3.TabIndex = 7;
      // 
      // toneValueControl1
      // 
      this.toneValueControl1.Duration = 0;
      this.toneValueControl1.Frequency = 440;
      this.toneValueControl1.Location = new System.Drawing.Point(640, 0);
      this.toneValueControl1.Name = "toneValueControl1";
      this.toneValueControl1.Size = new System.Drawing.Size(392, 22);
      this.toneValueControl1.TabIndex = 8;
      this.toneValueControl1.Visible = false;
      this.toneValueControl1.NoTone += new ArduinoStudio.Delegates.ControlDelegate(this.toneValueControl1_NoTone);
      this.toneValueControl1.ValueChanged += new ArduinoStudio.Delegates.ControlDelegate(this.toneValueControl1_ValueChanged);
      // 
      // pwmValueControl1
      // 
      this.pwmValueControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
      this.pwmValueControl1.Location = new System.Drawing.Point(400, 0);
      this.pwmValueControl1.Name = "pwmValueControl1";
      this.pwmValueControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.pwmValueControl1.Size = new System.Drawing.Size(232, 24);
      this.pwmValueControl1.TabIndex = 6;
      this.pwmValueControl1.Value = ((byte)(0));
      this.pwmValueControl1.Visible = false;
      this.pwmValueControl1.ValueChanged += new ArduinoStudio.Delegates.ControlDelegate(this.pwmValueControl1_ValueChanged);
      // 
      // outputBool
      // 
      this.outputBool.AutoSize = true;
      this.outputBool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.outputBool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.outputBool.Dock = System.Windows.Forms.DockStyle.Left;
      this.outputBool.Location = new System.Drawing.Point(260, 2);
      this.outputBool.Name = "outputBool";
      this.outputBool.Size = new System.Drawing.Size(82, 21);
      this.outputBool.TabIndex = 5;
      this.outputBool.Value = false;
      this.outputBool.Visible = false;
      this.outputBool.ValueChanged += new ArduinoStudio.Delegates.ControlDelegate(this.outputBool_ValueChanged);
      // 
      // outputModeControl1
      // 
      this.outputModeControl1.AutoSize = true;
      this.outputModeControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.outputModeControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.outputModeControl1.Dock = System.Windows.Forms.DockStyle.Left;
      this.outputModeControl1.Location = new System.Drawing.Point(103, 2);
      this.outputModeControl1.Name = "outputModeControl1";
      this.outputModeControl1.OutputMode = ArduinoStudio.DigitalOutMode.Boolean;
      this.outputModeControl1.Size = new System.Drawing.Size(146, 21);
      this.outputModeControl1.TabIndex = 2;
      this.outputModeControl1.Visible = false;
      this.outputModeControl1.OutputModeChanged += new ArduinoStudio.Delegates.ControlDelegate(this.outputModeControl1_OutputModeChanged);
      // 
      // pinModeControl1
      // 
      this.pinModeControl1.AutoSize = true;
      this.pinModeControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.pinModeControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pinModeControl1.Dock = System.Windows.Forms.DockStyle.Left;
      this.pinModeControl1.Location = new System.Drawing.Point(26, 2);
      this.pinModeControl1.Name = "pinModeControl1";
      this.pinModeControl1.PinMode = ArduinoStudio.PinMode.Output;
      this.pinModeControl1.Size = new System.Drawing.Size(66, 21);
      this.pinModeControl1.TabIndex = 1;
      this.pinModeControl1.PinModeChanged += new ArduinoStudio.Delegates.ControlDelegate(this.pinModeControl1_PinModeChanged);
      // 
      // DigitalPinController
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.toneValueControl1);
      this.Controls.Add(this.pwmValueControl1);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.outputBool);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.outputModeControl1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.pinModeControl1);
      this.Controls.Add(this.lblPinNumber);
      this.Name = "DigitalPinController";
      this.Padding = new System.Windows.Forms.Padding(2);
      this.Size = new System.Drawing.Size(1043, 25);
      this.Load += new System.EventHandler(this.DigitalPinController_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblPinNumber;
    private PinModeControl pinModeControl1;
    private OutputModeControl outputModeControl1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private BoolControl outputBool;
    private PwmValueControl pwmValueControl1;
    private System.Windows.Forms.Panel panel3;
    private ToneValueControl toneValueControl1;
  }
}
