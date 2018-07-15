namespace ArduinoStudio
{
  partial class DigitalPinControl
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
      this.btnSetHigh = new System.Windows.Forms.Button();
      this.btnSetLow = new System.Windows.Forms.Button();
      this.btnSetPWM = new System.Windows.Forms.Button();
      this.btnSetTone = new System.Windows.Forms.Button();
      this.btnNoTone = new System.Windows.Forms.Button();
      this.btnRead = new System.Windows.Forms.Button();
      this.ledIndicator1 = new ArduinoStudio.LedIndicator();
      this.toneValueControl1 = new ArduinoStudio.ToneValueControl();
      this.pwmValueControl1 = new ArduinoStudio.PwmValueControl();
      this.SuspendLayout();
      // 
      // lblPinNumber
      // 
      this.lblPinNumber.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblPinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPinNumber.Location = new System.Drawing.Point(2, 2);
      this.lblPinNumber.Name = "lblPinNumber";
      this.lblPinNumber.Size = new System.Drawing.Size(22, 24);
      this.lblPinNumber.TabIndex = 1;
      this.lblPinNumber.Text = "12";
      this.lblPinNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnSetHigh
      // 
      this.btnSetHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnSetHigh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnSetHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSetHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnSetHigh.Location = new System.Drawing.Point(32, 2);
      this.btnSetHigh.Name = "btnSetHigh";
      this.btnSetHigh.Size = new System.Drawing.Size(64, 24);
      this.btnSetHigh.TabIndex = 8;
      this.btnSetHigh.Text = "Set High";
      this.btnSetHigh.UseVisualStyleBackColor = false;
      this.btnSetHigh.Click += new System.EventHandler(this.btnSetHigh_Click);
      // 
      // btnSetLow
      // 
      this.btnSetLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnSetLow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnSetLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSetLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnSetLow.Location = new System.Drawing.Point(97, 2);
      this.btnSetLow.Name = "btnSetLow";
      this.btnSetLow.Size = new System.Drawing.Size(64, 24);
      this.btnSetLow.TabIndex = 9;
      this.btnSetLow.Text = "Set Low";
      this.btnSetLow.UseVisualStyleBackColor = false;
      this.btnSetLow.Click += new System.EventHandler(this.btnSetLow_Click);
      // 
      // btnSetPWM
      // 
      this.btnSetPWM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnSetPWM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnSetPWM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSetPWM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnSetPWM.Location = new System.Drawing.Point(314, 2);
      this.btnSetPWM.Name = "btnSetPWM";
      this.btnSetPWM.Size = new System.Drawing.Size(64, 24);
      this.btnSetPWM.TabIndex = 11;
      this.btnSetPWM.Text = "Set Pwm";
      this.btnSetPWM.UseVisualStyleBackColor = false;
      this.btnSetPWM.Click += new System.EventHandler(this.btnSetPWM_Click);
      // 
      // btnSetTone
      // 
      this.btnSetTone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnSetTone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnSetTone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSetTone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnSetTone.Location = new System.Drawing.Point(722, 2);
      this.btnSetTone.Name = "btnSetTone";
      this.btnSetTone.Size = new System.Drawing.Size(64, 24);
      this.btnSetTone.TabIndex = 14;
      this.btnSetTone.Text = "Set Tone";
      this.btnSetTone.UseVisualStyleBackColor = false;
      this.btnSetTone.Click += new System.EventHandler(this.btnSetTone_Click);
      // 
      // btnNoTone
      // 
      this.btnNoTone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnNoTone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnNoTone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNoTone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnNoTone.Location = new System.Drawing.Point(787, 2);
      this.btnNoTone.Name = "btnNoTone";
      this.btnNoTone.Size = new System.Drawing.Size(64, 24);
      this.btnNoTone.TabIndex = 15;
      this.btnNoTone.Text = "No Tone";
      this.btnNoTone.UseVisualStyleBackColor = false;
      this.btnNoTone.Click += new System.EventHandler(this.btnNoTone_Click);
      // 
      // btnRead
      // 
      this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnRead.Location = new System.Drawing.Point(872, 2);
      this.btnRead.Name = "btnRead";
      this.btnRead.Size = new System.Drawing.Size(64, 24);
      this.btnRead.TabIndex = 16;
      this.btnRead.Text = "Read";
      this.btnRead.UseVisualStyleBackColor = false;
      this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
      // 
      // ledIndicator1
      // 
      this.ledIndicator1.Location = new System.Drawing.Point(944, 2);
      this.ledIndicator1.Name = "ledIndicator1";
      this.ledIndicator1.Size = new System.Drawing.Size(24, 24);
      this.ledIndicator1.TabIndex = 17;
      this.ledIndicator1.Value = false;
      // 
      // toneValueControl1
      // 
      this.toneValueControl1.BackColor = System.Drawing.Color.White;
      this.toneValueControl1.Duration = 0;
      this.toneValueControl1.Frequency = 440;
      this.toneValueControl1.Location = new System.Drawing.Point(392, 3);
      this.toneValueControl1.Name = "toneValueControl1";
      this.toneValueControl1.Size = new System.Drawing.Size(328, 24);
      this.toneValueControl1.TabIndex = 13;
      // 
      // pwmValueControl1
      // 
      this.pwmValueControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
      this.pwmValueControl1.Location = new System.Drawing.Point(192, 3);
      this.pwmValueControl1.Name = "pwmValueControl1";
      this.pwmValueControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.pwmValueControl1.Size = new System.Drawing.Size(120, 24);
      this.pwmValueControl1.TabIndex = 12;
      this.pwmValueControl1.Value = ((byte)(0));
      // 
      // DigitalPinControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.ledIndicator1);
      this.Controls.Add(this.btnRead);
      this.Controls.Add(this.btnNoTone);
      this.Controls.Add(this.btnSetTone);
      this.Controls.Add(this.toneValueControl1);
      this.Controls.Add(this.pwmValueControl1);
      this.Controls.Add(this.btnSetPWM);
      this.Controls.Add(this.btnSetLow);
      this.Controls.Add(this.btnSetHigh);
      this.Controls.Add(this.lblPinNumber);
      this.Name = "DigitalPinControl";
      this.Padding = new System.Windows.Forms.Padding(2);
      this.Size = new System.Drawing.Size(974, 28);
      this.SizeChanged += new System.EventHandler(this.DigitalPinControl_SizeChanged);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.DigitalPinControl_Paint);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblPinNumber;
    private System.Windows.Forms.Button btnSetHigh;
    private System.Windows.Forms.Button btnSetLow;
    private System.Windows.Forms.Button btnSetPWM;
    private PwmValueControl pwmValueControl1;
    private ToneValueControl toneValueControl1;
    private System.Windows.Forms.Button btnSetTone;
    private System.Windows.Forms.Button btnNoTone;
    private System.Windows.Forms.Button btnRead;
    private LedIndicator ledIndicator1;
  }
}
