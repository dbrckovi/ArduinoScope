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
      this.btnPlay = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).BeginInit();
      this.SuspendLayout();
      // 
      // txtDuration
      // 
      this.txtDuration.Dock = System.Windows.Forms.DockStyle.Left;
      this.txtDuration.Location = new System.Drawing.Point(47, 0);
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
      this.lblDuration.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblDuration.Location = new System.Drawing.Point(0, 0);
      this.lblDuration.Name = "lblDuration";
      this.lblDuration.Size = new System.Drawing.Size(47, 13);
      this.lblDuration.TabIndex = 2;
      this.lblDuration.Text = "Duration";
      // 
      // txtFrequency
      // 
      this.txtFrequency.Dock = System.Windows.Forms.DockStyle.Left;
      this.txtFrequency.Location = new System.Drawing.Point(136, 0);
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
      this.lblFrequency.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblFrequency.Location = new System.Drawing.Point(79, 0);
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
      this.trackFrequency.Location = new System.Drawing.Point(192, 0);
      this.trackFrequency.Maximum = 20000;
      this.trackFrequency.Minimum = 31;
      this.trackFrequency.Name = "trackFrequency";
      this.trackFrequency.Size = new System.Drawing.Size(132, 22);
      this.trackFrequency.TabIndex = 5;
      this.trackFrequency.TickFrequency = 1000;
      this.trackFrequency.TickStyle = System.Windows.Forms.TickStyle.None;
      this.trackFrequency.Value = 31;
      this.trackFrequency.ValueChanged += new System.EventHandler(this.trackFrequency_ValueChanged);
      // 
      // btnPlay
      // 
      this.btnPlay.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnPlay.Location = new System.Drawing.Point(324, 0);
      this.btnPlay.Name = "btnPlay";
      this.btnPlay.Size = new System.Drawing.Size(36, 22);
      this.btnPlay.TabIndex = 6;
      this.btnPlay.Text = "Play";
      this.btnPlay.UseVisualStyleBackColor = true;
      this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
      // 
      // btnStop
      // 
      this.btnStop.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnStop.Location = new System.Drawing.Point(360, 0);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(44, 22);
      this.btnStop.TabIndex = 7;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // ToneValueControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
      this.Controls.Add(this.trackFrequency);
      this.Controls.Add(this.btnPlay);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.txtFrequency);
      this.Controls.Add(this.lblFrequency);
      this.Controls.Add(this.txtDuration);
      this.Controls.Add(this.lblDuration);
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
    private System.Windows.Forms.Button btnPlay;
    private System.Windows.Forms.Button btnStop;
  }
}
