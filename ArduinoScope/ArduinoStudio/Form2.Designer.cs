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
      this.scopeControl1 = new ArduinoStudio.ScopeControl();
      this.SuspendLayout();
      // 
      // scopeControl1
      // 
      this.scopeControl1.Location = new System.Drawing.Point(40, 16);
      this.scopeControl1.Name = "scopeControl1";
      this.scopeControl1.Size = new System.Drawing.Size(944, 472);
      this.scopeControl1.TabIndex = 0;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1180, 713);
      this.Controls.Add(this.scopeControl1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
      this.ResumeLayout(false);

    }

    #endregion

    private ScopeControl scopeControl1;
  }
}