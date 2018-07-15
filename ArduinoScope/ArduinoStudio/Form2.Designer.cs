namespace ArduinoStudio
{
  partial class Form2
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.glCtl = new OpenTK.GLControl();
      this.SuspendLayout();
      // 
      // glCtl
      // 
      this.glCtl.BackColor = System.Drawing.Color.Black;
      this.glCtl.Location = new System.Drawing.Point(40, 32);
      this.glCtl.Name = "glCtl";
      this.glCtl.Size = new System.Drawing.Size(696, 384);
      this.glCtl.TabIndex = 0;
      this.glCtl.VSync = false;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1059, 551);
      this.Controls.Add(this.glCtl);
      this.Name = "Form2";
      this.Text = "Form2";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
      this.ResumeLayout(false);

    }

    #endregion

    private OpenTK.GLControl glCtl;
  }
}