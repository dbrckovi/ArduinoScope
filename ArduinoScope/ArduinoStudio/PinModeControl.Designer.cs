namespace ArduinoStudio
{
  partial class PinModeControl
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
      this.lblInput = new System.Windows.Forms.Label();
      this.lblOutput = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblInput
      // 
      this.lblInput.BackColor = System.Drawing.Color.White;
      this.lblInput.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblInput.Location = new System.Drawing.Point(0, 0);
      this.lblInput.Margin = new System.Windows.Forms.Padding(0);
      this.lblInput.Name = "lblInput";
      this.lblInput.Size = new System.Drawing.Size(24, 17);
      this.lblInput.TabIndex = 0;
      this.lblInput.Text = "IN";
      this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblInput.Click += new System.EventHandler(this.lblInput_Click);
      // 
      // lblOutput
      // 
      this.lblOutput.BackColor = System.Drawing.Color.White;
      this.lblOutput.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblOutput.Location = new System.Drawing.Point(24, 0);
      this.lblOutput.Margin = new System.Windows.Forms.Padding(0);
      this.lblOutput.Name = "lblOutput";
      this.lblOutput.Size = new System.Drawing.Size(40, 17);
      this.lblOutput.TabIndex = 1;
      this.lblOutput.Text = "OUT";
      this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
      // 
      // PinModeControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.lblOutput);
      this.Controls.Add(this.lblInput);
      this.Name = "PinModeControl";
      this.Size = new System.Drawing.Size(185, 17);
      this.Load += new System.EventHandler(this.PinModeControl_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblInput;
    private System.Windows.Forms.Label lblOutput;
  }
}
