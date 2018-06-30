namespace ArduinoStudio
{
  partial class PwmValueControl
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
      this.txtValue = new System.Windows.Forms.TextBox();
      this.trackValue = new System.Windows.Forms.TrackBar();
      ((System.ComponentModel.ISupportInitialize)(this.trackValue)).BeginInit();
      this.SuspendLayout();
      // 
      // txtValue
      // 
      this.txtValue.Dock = System.Windows.Forms.DockStyle.Left;
      this.txtValue.Location = new System.Drawing.Point(0, 0);
      this.txtValue.MaxLength = 3;
      this.txtValue.Name = "txtValue";
      this.txtValue.Size = new System.Drawing.Size(32, 20);
      this.txtValue.TabIndex = 0;
      this.txtValue.Text = "0";
      this.txtValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtValue_Validating);
      this.txtValue.Validated += new System.EventHandler(this.txtValue_Validated);
      // 
      // trackValue
      // 
      this.trackValue.AutoSize = false;
      this.trackValue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackValue.LargeChange = 32;
      this.trackValue.Location = new System.Drawing.Point(32, 0);
      this.trackValue.Maximum = 255;
      this.trackValue.Name = "trackValue";
      this.trackValue.Size = new System.Drawing.Size(321, 20);
      this.trackValue.TabIndex = 1;
      this.trackValue.TickFrequency = 32;
      this.trackValue.ValueChanged += new System.EventHandler(this.trackValue_ValueChanged);
      // 
      // PwmValueControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
      this.Controls.Add(this.trackValue);
      this.Controls.Add(this.txtValue);
      this.Name = "PwmValueControl";
      this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
      this.Size = new System.Drawing.Size(353, 23);
      this.Load += new System.EventHandler(this.PwmValueControl_Load);
      ((System.ComponentModel.ISupportInitialize)(this.trackValue)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtValue;
    private System.Windows.Forms.TrackBar trackValue;
  }
}
