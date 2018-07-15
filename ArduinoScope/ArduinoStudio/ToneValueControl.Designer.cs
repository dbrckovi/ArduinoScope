namespace ArduinoStudio
{
  partial class ToneValueControl
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
      this.txtDuration = new System.Windows.Forms.TextBox();
      this.lblDuration = new System.Windows.Forms.Label();
      this.txtFrequency = new System.Windows.Forms.TextBox();
      this.lblFrequency = new System.Windows.Forms.Label();
      this.trackFrequency = new System.Windows.Forms.TrackBar();
      ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).BeginInit();
      this.SuspendLayout();
      // 
      // txtDuration
      // 
      this.txtDuration.Dock = System.Windows.Forms.DockStyle.Right;
      this.txtDuration.Location = new System.Drawing.Point(372, 0);
      this.txtDuration.MaxLength = 5;
      this.txtDuration.Name = "txtDuration";
      this.txtDuration.Size = new System.Drawing.Size(32, 20);
      this.txtDuration.TabIndex = 1;
      this.txtDuration.Text = "0";
      this.txtDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtDuration_Validating);
      this.txtDuration.Validated += new System.EventHandler(this.txtDuration_Validated);
      // 
      // lblDuration
      // 
      this.lblDuration.AutoSize = true;
      this.lblDuration.Dock = System.Windows.Forms.DockStyle.Right;
      this.lblDuration.Location = new System.Drawing.Point(325, 0);
      this.lblDuration.Name = "lblDuration";
      this.lblDuration.Size = new System.Drawing.Size(47, 13);
      this.lblDuration.TabIndex = 2;
      this.lblDuration.Text = "Duration";
      // 
      // txtFrequency
      // 
      this.txtFrequency.Dock = System.Windows.Forms.DockStyle.Right;
      this.txtFrequency.Location = new System.Drawing.Point(269, 0);
      this.txtFrequency.MaxLength = 6;
      this.txtFrequency.Name = "txtFrequency";
      this.txtFrequency.Size = new System.Drawing.Size(56, 20);
      this.txtFrequency.TabIndex = 3;
      this.txtFrequency.Text = "440";
      this.txtFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.txtFrequency_Validating);
      this.txtFrequency.Validated += new System.EventHandler(this.txtFrequency_Validated);
      // 
      // lblFrequency
      // 
      this.lblFrequency.AutoSize = true;
      this.lblFrequency.Dock = System.Windows.Forms.DockStyle.Right;
      this.lblFrequency.Location = new System.Drawing.Point(212, 0);
      this.lblFrequency.Name = "lblFrequency";
      this.lblFrequency.Size = new System.Drawing.Size(57, 13);
      this.lblFrequency.TabIndex = 4;
      this.lblFrequency.Text = "Frequency";
      // 
      // trackFrequency
      // 
      this.trackFrequency.AutoSize = false;
      this.trackFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trackFrequency.LargeChange = 100;
      this.trackFrequency.Location = new System.Drawing.Point(0, 0);
      this.trackFrequency.Maximum = 20000;
      this.trackFrequency.Minimum = 31;
      this.trackFrequency.Name = "trackFrequency";
      this.trackFrequency.Size = new System.Drawing.Size(212, 22);
      this.trackFrequency.TabIndex = 5;
      this.trackFrequency.TickFrequency = 1000;
      this.trackFrequency.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trackFrequency.Value = 31;
      this.trackFrequency.ValueChanged += new System.EventHandler(this.trackFrequency_ValueChanged);
      // 
      // ToneValueControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.trackFrequency);
      this.Controls.Add(this.lblFrequency);
      this.Controls.Add(this.txtFrequency);
      this.Controls.Add(this.lblDuration);
      this.Controls.Add(this.txtDuration);
      this.Name = "ToneValueControl";
      this.Size = new System.Drawing.Size(404, 22);
      this.Load += new System.EventHandler(this.ToneValueControl_Load);
      ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtDuration;
    private System.Windows.Forms.Label lblDuration;
    private System.Windows.Forms.TextBox txtFrequency;
    private System.Windows.Forms.Label lblFrequency;
    private System.Windows.Forms.TrackBar trackFrequency;
  }
}
