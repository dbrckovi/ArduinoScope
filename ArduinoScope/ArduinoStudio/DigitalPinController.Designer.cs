namespace ArduinoStudio
{
  partial class DigitalPinController
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
      this.cmbPinMode = new System.Windows.Forms.ComboBox();
      this.lblPinNumber = new System.Windows.Forms.Label();
      this.pnlInput = new System.Windows.Forms.Panel();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.trackPwm = new System.Windows.Forms.TrackBar();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pnlOutput = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnDigitalOut = new System.Windows.Forms.Button();
      this.pnlInput.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackPwm)).BeginInit();
      this.panel1.SuspendLayout();
      this.pnlOutput.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmbPinMode
      // 
      this.cmbPinMode.BackColor = System.Drawing.SystemColors.Window;
      this.cmbPinMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbPinMode.FormattingEnabled = true;
      this.cmbPinMode.Location = new System.Drawing.Point(24, 1);
      this.cmbPinMode.Name = "cmbPinMode";
      this.cmbPinMode.Size = new System.Drawing.Size(56, 21);
      this.cmbPinMode.TabIndex = 0;
      this.cmbPinMode.SelectedIndexChanged += new System.EventHandler(this.cmbPinMode_SelectedIndexChanged);
      // 
      // lblPinNumber
      // 
      this.lblPinNumber.Location = new System.Drawing.Point(0, 0);
      this.lblPinNumber.Name = "lblPinNumber";
      this.lblPinNumber.Size = new System.Drawing.Size(24, 24);
      this.lblPinNumber.TabIndex = 1;
      this.lblPinNumber.Text = "0";
      this.lblPinNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnlInput
      // 
      this.pnlInput.BackColor = System.Drawing.Color.Transparent;
      this.pnlInput.Controls.Add(this.txtInput);
      this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlInput.Location = new System.Drawing.Point(88, 0);
      this.pnlInput.Name = "pnlInput";
      this.pnlInput.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
      this.pnlInput.Size = new System.Drawing.Size(72, 23);
      this.pnlInput.TabIndex = 2;
      this.pnlInput.Visible = false;
      // 
      // txtInput
      // 
      this.txtInput.Location = new System.Drawing.Point(8, 1);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(32, 20);
      this.txtInput.TabIndex = 0;
      // 
      // trackPwm
      // 
      this.trackPwm.AutoSize = false;
      this.trackPwm.Location = new System.Drawing.Point(320, 0);
      this.trackPwm.Maximum = 1023;
      this.trackPwm.Name = "trackPwm";
      this.trackPwm.Size = new System.Drawing.Size(104, 16);
      this.trackPwm.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lblPinNumber);
      this.panel1.Controls.Add(this.cmbPinMode);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(88, 23);
      this.panel1.TabIndex = 3;
      // 
      // pnlOutput
      // 
      this.pnlOutput.BackColor = System.Drawing.Color.Transparent;
      this.pnlOutput.Controls.Add(this.btnDigitalOut);
      this.pnlOutput.Controls.Add(this.label1);
      this.pnlOutput.Controls.Add(this.textBox1);
      this.pnlOutput.Controls.Add(this.trackPwm);
      this.pnlOutput.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlOutput.Location = new System.Drawing.Point(160, 0);
      this.pnlOutput.Name = "pnlOutput";
      this.pnlOutput.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
      this.pnlOutput.Size = new System.Drawing.Size(448, 23);
      this.pnlOutput.TabIndex = 4;
      this.pnlOutput.Visible = false;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(288, 0);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(32, 20);
      this.textBox1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(8, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 24);
      this.label1.TabIndex = 2;
      this.label1.Text = "Digital";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnDigitalOut
      // 
      this.btnDigitalOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDigitalOut.Location = new System.Drawing.Point(48, 1);
      this.btnDigitalOut.Name = "btnDigitalOut";
      this.btnDigitalOut.Size = new System.Drawing.Size(48, 21);
      this.btnDigitalOut.TabIndex = 3;
      this.btnDigitalOut.Text = "LOW";
      this.btnDigitalOut.UseVisualStyleBackColor = true;
      // 
      // DigitalPinController
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.pnlOutput);
      this.Controls.Add(this.pnlInput);
      this.Controls.Add(this.panel1);
      this.MaximumSize = new System.Drawing.Size(1000, 25);
      this.MinimumSize = new System.Drawing.Size(100, 25);
      this.Name = "DigitalPinController";
      this.Size = new System.Drawing.Size(673, 23);
      this.Load += new System.EventHandler(this.DigitalPinController_Load);
      this.pnlInput.ResumeLayout(false);
      this.pnlInput.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackPwm)).EndInit();
      this.panel1.ResumeLayout(false);
      this.pnlOutput.ResumeLayout(false);
      this.pnlOutput.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbPinMode;
    private System.Windows.Forms.Label lblPinNumber;
    private System.Windows.Forms.Panel pnlInput;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.TrackBar trackPwm;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel pnlOutput;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnDigitalOut;
    private System.Windows.Forms.Label label1;
  }
}
