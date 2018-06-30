namespace ArduinoStudio
{
  partial class BoolControl
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
      this.lblHigh = new System.Windows.Forms.Label();
      this.lblLow = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblHigh
      // 
      this.lblHigh.BackColor = System.Drawing.Color.White;
      this.lblHigh.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblHigh.Location = new System.Drawing.Point(40, 0);
      this.lblHigh.Margin = new System.Windows.Forms.Padding(0);
      this.lblHigh.Name = "lblHigh";
      this.lblHigh.Size = new System.Drawing.Size(40, 18);
      this.lblHigh.TabIndex = 3;
      this.lblHigh.Text = "HIGH";
      this.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblHigh.Click += new System.EventHandler(this.lblHigh_Click);
      // 
      // lblLow
      // 
      this.lblLow.BackColor = System.Drawing.Color.White;
      this.lblLow.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblLow.Location = new System.Drawing.Point(0, 0);
      this.lblLow.Margin = new System.Windows.Forms.Padding(0);
      this.lblLow.Name = "lblLow";
      this.lblLow.Size = new System.Drawing.Size(40, 18);
      this.lblLow.TabIndex = 2;
      this.lblLow.Text = "LOW";
      this.lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblLow.Click += new System.EventHandler(this.lblLow_Click);
      // 
      // BoolControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.lblHigh);
      this.Controls.Add(this.lblLow);
      this.Name = "BoolControl";
      this.Size = new System.Drawing.Size(81, 18);
      this.Load += new System.EventHandler(this.PinModeControl_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblHigh;
    private System.Windows.Forms.Label lblLow;
  }
}
