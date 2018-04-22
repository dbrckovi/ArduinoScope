namespace ArduinoScope
{
  partial class frmMain
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
      this.components = new System.ComponentModel.Container();
      this.button1 = new System.Windows.Forms.Button();
      this.grpInfo = new System.Windows.Forms.GroupBox();
      this.txtFPS = new System.Windows.Forms.Label();
      this.lblFPS = new System.Windows.Forms.Label();
      this.infoTimer = new System.Windows.Forms.Timer(this.components);
      this.grpView = new System.Windows.Forms.GroupBox();
      this.btnTHalf = new System.Windows.Forms.Button();
      this.btnT2 = new System.Windows.Forms.Button();
      this.btnDummyProbe = new System.Windows.Forms.Button();
      this.lblGridColor = new System.Windows.Forms.Label();
      this.lblGraphColor = new System.Windows.Forms.Label();
      this.lblBackgroundColor = new System.Windows.Forms.Label();
      this.numvoltagePerDiv = new System.Windows.Forms.NumericUpDown();
      this.numMicrosecondsPerDiv = new System.Windows.Forms.NumericUpDown();
      this.lblVoltagePerDiv = new System.Windows.Forms.Label();
      this.lblMicrosecondsPerDiv = new System.Windows.Forms.Label();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.btnStartSerial = new System.Windows.Forms.Button();
      this.btnStopSerial = new System.Windows.Forms.Button();
      this.clrGridColor = new ArduinoScope.ColorPicker();
      this.clrGraphColor = new ArduinoScope.ColorPicker();
      this.clrBackgroundColor = new ArduinoScope.ColorPicker();
      this.grpInfo.SuspendLayout();
      this.grpView.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numvoltagePerDiv)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMicrosecondsPerDiv)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(144, 408);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(96, 40);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // grpInfo
      // 
      this.grpInfo.Controls.Add(this.txtFPS);
      this.grpInfo.Controls.Add(this.lblFPS);
      this.grpInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.grpInfo.Location = new System.Drawing.Point(0, 468);
      this.grpInfo.Name = "grpInfo";
      this.grpInfo.Size = new System.Drawing.Size(392, 144);
      this.grpInfo.TabIndex = 1;
      this.grpInfo.TabStop = false;
      this.grpInfo.Text = "Info";
      // 
      // txtFPS
      // 
      this.txtFPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.txtFPS.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFPS.Location = new System.Drawing.Point(40, 16);
      this.txtFPS.Margin = new System.Windows.Forms.Padding(0);
      this.txtFPS.Name = "txtFPS";
      this.txtFPS.Size = new System.Drawing.Size(40, 16);
      this.txtFPS.TabIndex = 1;
      // 
      // lblFPS
      // 
      this.lblFPS.AutoSize = true;
      this.lblFPS.Location = new System.Drawing.Point(8, 16);
      this.lblFPS.Name = "lblFPS";
      this.lblFPS.Size = new System.Drawing.Size(27, 13);
      this.lblFPS.TabIndex = 0;
      this.lblFPS.Text = "FPS";
      // 
      // infoTimer
      // 
      this.infoTimer.Enabled = true;
      this.infoTimer.Tick += new System.EventHandler(this.infoTimer_Tick);
      // 
      // grpView
      // 
      this.grpView.Controls.Add(this.btnTHalf);
      this.grpView.Controls.Add(this.btnT2);
      this.grpView.Controls.Add(this.btnDummyProbe);
      this.grpView.Controls.Add(this.clrGridColor);
      this.grpView.Controls.Add(this.lblGridColor);
      this.grpView.Controls.Add(this.clrGraphColor);
      this.grpView.Controls.Add(this.lblGraphColor);
      this.grpView.Controls.Add(this.clrBackgroundColor);
      this.grpView.Controls.Add(this.lblBackgroundColor);
      this.grpView.Controls.Add(this.numvoltagePerDiv);
      this.grpView.Controls.Add(this.numMicrosecondsPerDiv);
      this.grpView.Controls.Add(this.lblVoltagePerDiv);
      this.grpView.Controls.Add(this.lblMicrosecondsPerDiv);
      this.grpView.Dock = System.Windows.Forms.DockStyle.Top;
      this.grpView.Location = new System.Drawing.Point(0, 0);
      this.grpView.Name = "grpView";
      this.grpView.Size = new System.Drawing.Size(392, 304);
      this.grpView.TabIndex = 2;
      this.grpView.TabStop = false;
      this.grpView.Text = "View";
      // 
      // btnTHalf
      // 
      this.btnTHalf.Location = new System.Drawing.Point(240, 104);
      this.btnTHalf.Name = "btnTHalf";
      this.btnTHalf.Size = new System.Drawing.Size(56, 32);
      this.btnTHalf.TabIndex = 14;
      this.btnTHalf.Text = "T / 2";
      this.btnTHalf.UseVisualStyleBackColor = true;
      this.btnTHalf.Click += new System.EventHandler(this.btnTHalf_Click);
      // 
      // btnT2
      // 
      this.btnT2.Location = new System.Drawing.Point(304, 104);
      this.btnT2.Name = "btnT2";
      this.btnT2.Size = new System.Drawing.Size(56, 32);
      this.btnT2.TabIndex = 13;
      this.btnT2.Text = "T X 2";
      this.btnT2.UseVisualStyleBackColor = true;
      this.btnT2.Click += new System.EventHandler(this.btnT2_Click);
      // 
      // btnDummyProbe
      // 
      this.btnDummyProbe.Location = new System.Drawing.Point(240, 176);
      this.btnDummyProbe.Name = "btnDummyProbe";
      this.btnDummyProbe.Size = new System.Drawing.Size(112, 40);
      this.btnDummyProbe.TabIndex = 12;
      this.btnDummyProbe.Text = "Dummy probe";
      this.btnDummyProbe.UseVisualStyleBackColor = true;
      this.btnDummyProbe.Click += new System.EventHandler(this.btnDummyProbe_Click);
      // 
      // lblGridColor
      // 
      this.lblGridColor.AutoSize = true;
      this.lblGridColor.Location = new System.Drawing.Point(8, 120);
      this.lblGridColor.Name = "lblGridColor";
      this.lblGridColor.Size = new System.Drawing.Size(50, 13);
      this.lblGridColor.TabIndex = 10;
      this.lblGridColor.Text = "GridColor";
      // 
      // lblGraphColor
      // 
      this.lblGraphColor.AutoSize = true;
      this.lblGraphColor.Location = new System.Drawing.Point(8, 96);
      this.lblGraphColor.Name = "lblGraphColor";
      this.lblGraphColor.Size = new System.Drawing.Size(63, 13);
      this.lblGraphColor.TabIndex = 8;
      this.lblGraphColor.Text = "Graph Color";
      // 
      // lblBackgroundColor
      // 
      this.lblBackgroundColor.AutoSize = true;
      this.lblBackgroundColor.Location = new System.Drawing.Point(8, 72);
      this.lblBackgroundColor.Name = "lblBackgroundColor";
      this.lblBackgroundColor.Size = new System.Drawing.Size(92, 13);
      this.lblBackgroundColor.TabIndex = 6;
      this.lblBackgroundColor.Text = "Background Color";
      // 
      // numvoltagePerDiv
      // 
      this.numvoltagePerDiv.DecimalPlaces = 3;
      this.numvoltagePerDiv.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.numvoltagePerDiv.Location = new System.Drawing.Point(112, 48);
      this.numvoltagePerDiv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
      this.numvoltagePerDiv.Name = "numvoltagePerDiv";
      this.numvoltagePerDiv.Size = new System.Drawing.Size(64, 20);
      this.numvoltagePerDiv.TabIndex = 3;
      this.numvoltagePerDiv.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.numvoltagePerDiv.ValueChanged += new System.EventHandler(this.numvoltagePerDiv_ValueChanged);
      // 
      // numMicrosecondsPerDiv
      // 
      this.numMicrosecondsPerDiv.Location = new System.Drawing.Point(112, 24);
      this.numMicrosecondsPerDiv.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.numMicrosecondsPerDiv.Name = "numMicrosecondsPerDiv";
      this.numMicrosecondsPerDiv.Size = new System.Drawing.Size(64, 20);
      this.numMicrosecondsPerDiv.TabIndex = 2;
      this.numMicrosecondsPerDiv.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numMicrosecondsPerDiv.ValueChanged += new System.EventHandler(this.numMicrosecondsPerDiv_ValueChanged);
      // 
      // lblVoltagePerDiv
      // 
      this.lblVoltagePerDiv.AutoSize = true;
      this.lblVoltagePerDiv.Location = new System.Drawing.Point(8, 48);
      this.lblVoltagePerDiv.Name = "lblVoltagePerDiv";
      this.lblVoltagePerDiv.Size = new System.Drawing.Size(39, 13);
      this.lblVoltagePerDiv.TabIndex = 1;
      this.lblVoltagePerDiv.Text = "V / div";
      // 
      // lblMicrosecondsPerDiv
      // 
      this.lblMicrosecondsPerDiv.AutoSize = true;
      this.lblMicrosecondsPerDiv.Location = new System.Drawing.Point(8, 24);
      this.lblMicrosecondsPerDiv.Name = "lblMicrosecondsPerDiv";
      this.lblMicrosecondsPerDiv.Size = new System.Drawing.Size(43, 13);
      this.lblMicrosecondsPerDiv.TabIndex = 0;
      this.lblMicrosecondsPerDiv.Text = "µs / div";
      // 
      // btnStartSerial
      // 
      this.btnStartSerial.Location = new System.Drawing.Point(32, 328);
      this.btnStartSerial.Name = "btnStartSerial";
      this.btnStartSerial.Size = new System.Drawing.Size(88, 40);
      this.btnStartSerial.TabIndex = 3;
      this.btnStartSerial.Text = "Start Serial";
      this.btnStartSerial.UseVisualStyleBackColor = true;
      this.btnStartSerial.Click += new System.EventHandler(this.btnStartSerial_Click);
      // 
      // btnStopSerial
      // 
      this.btnStopSerial.Location = new System.Drawing.Point(128, 328);
      this.btnStopSerial.Name = "btnStopSerial";
      this.btnStopSerial.Size = new System.Drawing.Size(88, 40);
      this.btnStopSerial.TabIndex = 4;
      this.btnStopSerial.Text = "Stop Serial";
      this.btnStopSerial.UseVisualStyleBackColor = true;
      this.btnStopSerial.Click += new System.EventHandler(this.btnStopSerial_Click);
      // 
      // clrGridColor
      // 
      this.clrGridColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.clrGridColor.Location = new System.Drawing.Point(112, 120);
      this.clrGridColor.Name = "clrGridColor";
      this.clrGridColor.SelectedColor = System.Drawing.Color.Black;
      this.clrGridColor.Size = new System.Drawing.Size(16, 16);
      this.clrGridColor.TabIndex = 11;
      this.clrGridColor.SelectedColorChanged += new System.EventHandler(this.clrGridColor_SelectedColorChanged);
      // 
      // clrGraphColor
      // 
      this.clrGraphColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.clrGraphColor.Location = new System.Drawing.Point(112, 96);
      this.clrGraphColor.Name = "clrGraphColor";
      this.clrGraphColor.SelectedColor = System.Drawing.Color.Black;
      this.clrGraphColor.Size = new System.Drawing.Size(16, 16);
      this.clrGraphColor.TabIndex = 9;
      this.clrGraphColor.SelectedColorChanged += new System.EventHandler(this.clrGraphColor_SelectedColorChanged);
      // 
      // clrBackgroundColor
      // 
      this.clrBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.clrBackgroundColor.Location = new System.Drawing.Point(112, 72);
      this.clrBackgroundColor.Name = "clrBackgroundColor";
      this.clrBackgroundColor.SelectedColor = System.Drawing.Color.Black;
      this.clrBackgroundColor.Size = new System.Drawing.Size(16, 16);
      this.clrBackgroundColor.TabIndex = 7;
      this.clrBackgroundColor.SelectedColorChanged += new System.EventHandler(this.clrBackgroundColor_SelectedColorChanged);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(392, 612);
      this.Controls.Add(this.btnStopSerial);
      this.Controls.Add(this.btnStartSerial);
      this.Controls.Add(this.grpView);
      this.Controls.Add(this.grpInfo);
      this.Controls.Add(this.button1);
      this.Name = "frmMain";
      this.Text = "Arduino Scope";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Shown += new System.EventHandler(this.frmMain_Shown);
      this.grpInfo.ResumeLayout(false);
      this.grpInfo.PerformLayout();
      this.grpView.ResumeLayout(false);
      this.grpView.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numvoltagePerDiv)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMicrosecondsPerDiv)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox grpInfo;
    private System.Windows.Forms.Label txtFPS;
    private System.Windows.Forms.Label lblFPS;
    private System.Windows.Forms.Timer infoTimer;
    private System.Windows.Forms.GroupBox grpView;
    private System.Windows.Forms.NumericUpDown numvoltagePerDiv;
    private System.Windows.Forms.NumericUpDown numMicrosecondsPerDiv;
    private System.Windows.Forms.Label lblVoltagePerDiv;
    private System.Windows.Forms.Label lblMicrosecondsPerDiv;
    private System.Windows.Forms.Label lblBackgroundColor;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private ColorPicker clrBackgroundColor;
    private ColorPicker clrGridColor;
    private System.Windows.Forms.Label lblGridColor;
    private ColorPicker clrGraphColor;
    private System.Windows.Forms.Label lblGraphColor;
    private System.Windows.Forms.Button btnDummyProbe;
    private System.Windows.Forms.Button btnTHalf;
    private System.Windows.Forms.Button btnT2;
    private System.Windows.Forms.Button btnStartSerial;
    private System.Windows.Forms.Button btnStopSerial;
  }
}