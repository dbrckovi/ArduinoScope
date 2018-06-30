namespace ArduinoStudio.GUI_Controls
{
  partial class ctlSwitch
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
      this.chkTrue = new ArduinoStudio.GUI_Controls.ctlCheckImage();
      this.chkFalse = new ArduinoStudio.GUI_Controls.ctlCheckImage();
      this.SuspendLayout();
      // 
      // chkTrue
      // 
      this.chkTrue.AutoSize = true;
      this.chkTrue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.chkTrue.BackColor = System.Drawing.Color.White;
      this.chkTrue.Dock = System.Windows.Forms.DockStyle.Left;
      this.chkTrue.Location = new System.Drawing.Point(0, 0);
      this.chkTrue.Margin = new System.Windows.Forms.Padding(0);
      this.chkTrue.Name = "chkTrue";
      this.chkTrue.Off_Image = null;
      this.chkTrue.Off_Highlight_Image = null;
      this.chkTrue.On_Image = null;
      this.chkTrue.Size = new System.Drawing.Size(16, 18);
      this.chkTrue.TabIndex = 0;
      this.chkTrue.Value = true;
      this.chkTrue.Click += new System.EventHandler(this.chkTrue_Click);
      // 
      // chkFalse
      // 
      this.chkFalse.AutoSize = true;
      this.chkFalse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.chkFalse.BackColor = System.Drawing.Color.White;
      this.chkFalse.Dock = System.Windows.Forms.DockStyle.Left;
      this.chkFalse.Location = new System.Drawing.Point(16, 0);
      this.chkFalse.Margin = new System.Windows.Forms.Padding(0);
      this.chkFalse.Name = "chkFalse";
      this.chkFalse.Off_Image = null;
      this.chkFalse.Off_Highlight_Image = null;
      this.chkFalse.On_Image = null;
      this.chkFalse.Size = new System.Drawing.Size(16, 18);
      this.chkFalse.TabIndex = 1;
      this.chkFalse.Value = false;
      this.chkFalse.Click += new System.EventHandler(this.chkFalse_Click);
      // 
      // ctlSwitch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.chkFalse);
      this.Controls.Add(this.chkTrue);
      this.Name = "ctlSwitch";
      this.Size = new System.Drawing.Size(330, 18);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ctlCheckImage chkTrue;
    private ctlCheckImage chkFalse;
  }
}
