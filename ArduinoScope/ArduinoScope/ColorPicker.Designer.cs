namespace ArduinoScope
{
  partial class ColorPicker
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
      this.lblColor = new System.Windows.Forms.Label();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.SuspendLayout();
      // 
      // lblColor
      // 
      this.lblColor.BackColor = System.Drawing.SystemColors.Control;
      this.lblColor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblColor.Location = new System.Drawing.Point(0, 0);
      this.lblColor.Name = "lblColor";
      this.lblColor.Size = new System.Drawing.Size(155, 43);
      this.lblColor.TabIndex = 0;
      this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
      // 
      // ColorPicker
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.lblColor);
      this.Name = "ColorPicker";
      this.Size = new System.Drawing.Size(155, 43);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblColor;
    private System.Windows.Forms.ColorDialog colorDialog1;
  }
}
