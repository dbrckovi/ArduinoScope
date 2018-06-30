namespace ArduinoStudio.GUI_Controls
{
  partial class ctlCheckImage
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
      this.picCheck = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
      this.SuspendLayout();
      // 
      // picCheck
      // 
      this.picCheck.Location = new System.Drawing.Point(0, 0);
      this.picCheck.Margin = new System.Windows.Forms.Padding(0);
      this.picCheck.Name = "picCheck";
      this.picCheck.Size = new System.Drawing.Size(16, 16);
      this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picCheck.TabIndex = 0;
      this.picCheck.TabStop = false;
      this.picCheck.Click += new System.EventHandler(this.picCheck_Click);
      this.picCheck.MouseEnter += new System.EventHandler(this.picCheck_MouseEnter);
      this.picCheck.MouseLeave += new System.EventHandler(this.picCheck_MouseLeave);
      // 
      // ctlCheckImage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.picCheck);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "ctlCheckImage";
      this.Size = new System.Drawing.Size(16, 16);
      ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picCheck;
  }
}
