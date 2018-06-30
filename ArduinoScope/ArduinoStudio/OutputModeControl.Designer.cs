namespace ArduinoStudio
{
  partial class OutputModeControl
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
      this.lblPWM = new System.Windows.Forms.Label();
      this.lblBoolean = new System.Windows.Forms.Label();
      this.lblTone = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblPWM
      // 
      this.lblPWM.BackColor = System.Drawing.Color.White;
      this.lblPWM.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblPWM.Location = new System.Drawing.Point(48, 0);
      this.lblPWM.Margin = new System.Windows.Forms.Padding(0);
      this.lblPWM.Name = "lblPWM";
      this.lblPWM.Size = new System.Drawing.Size(48, 17);
      this.lblPWM.TabIndex = 3;
      this.lblPWM.Text = "PWM";
      this.lblPWM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblPWM.Click += new System.EventHandler(this.lblPWM_Click);
      // 
      // lblBoolean
      // 
      this.lblBoolean.BackColor = System.Drawing.Color.White;
      this.lblBoolean.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblBoolean.Location = new System.Drawing.Point(0, 0);
      this.lblBoolean.Margin = new System.Windows.Forms.Padding(0);
      this.lblBoolean.Name = "lblBoolean";
      this.lblBoolean.Size = new System.Drawing.Size(48, 17);
      this.lblBoolean.TabIndex = 2;
      this.lblBoolean.Text = "BOOL";
      this.lblBoolean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblBoolean.Click += new System.EventHandler(this.lblBoolean_Click);
      // 
      // lblTone
      // 
      this.lblTone.BackColor = System.Drawing.Color.White;
      this.lblTone.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblTone.Location = new System.Drawing.Point(96, 0);
      this.lblTone.Margin = new System.Windows.Forms.Padding(0);
      this.lblTone.Name = "lblTone";
      this.lblTone.Size = new System.Drawing.Size(48, 17);
      this.lblTone.TabIndex = 4;
      this.lblTone.Text = "TONE";
      this.lblTone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblTone.Click += new System.EventHandler(this.lblTone_Click);
      // 
      // OutputModeControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.lblTone);
      this.Controls.Add(this.lblPWM);
      this.Controls.Add(this.lblBoolean);
      this.Name = "OutputModeControl";
      this.Size = new System.Drawing.Size(197, 17);
      this.Load += new System.EventHandler(this.OutputModeControl_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblPWM;
    private System.Windows.Forms.Label lblBoolean;
    private System.Windows.Forms.Label lblTone;
  }
}
