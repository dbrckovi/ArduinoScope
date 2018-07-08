namespace ArduinoStudio
{
  partial class Form1
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
      this.pnlSerialConnection = new System.Windows.Forms.Panel();
      this.lblCurrentBaud = new System.Windows.Forms.Label();
      this.lblVersion = new System.Windows.Forms.Label();
      this.numResponseTimeoutSubsequentBytes = new System.Windows.Forms.NumericUpDown();
      this.lblResponseTimeoutSubsequentBytes = new System.Windows.Forms.Label();
      this.numResponseTimeoutFirstByte = new System.Windows.Forms.NumericUpDown();
      this.lblResponseTimeoutFirstByte = new System.Windows.Forms.Label();
      this.btnSerialConnectDisconnect = new System.Windows.Forms.Button();
      this.lblSerialPort = new System.Windows.Forms.Label();
      this.cmbSerialPort = new System.Windows.Forms.ComboBox();
      this.pnlControlPanel = new System.Windows.Forms.Panel();
      this.tabControlPanel = new System.Windows.Forms.TabControl();
      this.tabPageMain = new System.Windows.Forms.TabPage();
      this.grpAnalogPins = new System.Windows.Forms.GroupBox();
      this.pnlAnalogPins = new System.Windows.Forms.FlowLayoutPanel();
      this.tabPageDebug = new System.Windows.Forms.TabPage();
      this.button6 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.btnNoTone = new System.Windows.Forms.Button();
      this.trackFrequency = new System.Windows.Forms.TrackBar();
      this.btnTone = new System.Windows.Forms.Button();
      this.btnAnalogRead = new System.Windows.Forms.Button();
      this.txtResponse = new System.Windows.Forms.RichTextBox();
      this.sliderAnalogWrite = new System.Windows.Forms.TrackBar();
      this.txtInt = new System.Windows.Forms.TextBox();
      this.btnSetLow = new System.Windows.Forms.Button();
      this.btnSetHigh = new System.Windows.Forms.Button();
      this.tabPageLog = new System.Windows.Forms.TabPage();
      this.txtLog = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnClearLog = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.txtVersion = new System.Windows.Forms.Label();
      this.txtCurrentBaud = new System.Windows.Forms.Label();
      this.pnlSerialConnection.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutSubsequentBytes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutFirstByte)).BeginInit();
      this.pnlControlPanel.SuspendLayout();
      this.tabControlPanel.SuspendLayout();
      this.tabPageMain.SuspendLayout();
      this.grpAnalogPins.SuspendLayout();
      this.tabPageDebug.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sliderAnalogWrite)).BeginInit();
      this.tabPageLog.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlSerialConnection
      // 
      this.pnlSerialConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.pnlSerialConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlSerialConnection.Controls.Add(this.txtCurrentBaud);
      this.pnlSerialConnection.Controls.Add(this.txtVersion);
      this.pnlSerialConnection.Controls.Add(this.lblCurrentBaud);
      this.pnlSerialConnection.Controls.Add(this.lblVersion);
      this.pnlSerialConnection.Controls.Add(this.numResponseTimeoutSubsequentBytes);
      this.pnlSerialConnection.Controls.Add(this.lblResponseTimeoutSubsequentBytes);
      this.pnlSerialConnection.Controls.Add(this.numResponseTimeoutFirstByte);
      this.pnlSerialConnection.Controls.Add(this.lblResponseTimeoutFirstByte);
      this.pnlSerialConnection.Controls.Add(this.btnSerialConnectDisconnect);
      this.pnlSerialConnection.Controls.Add(this.lblSerialPort);
      this.pnlSerialConnection.Controls.Add(this.cmbSerialPort);
      this.pnlSerialConnection.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlSerialConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.pnlSerialConnection.Location = new System.Drawing.Point(0, 0);
      this.pnlSerialConnection.Name = "pnlSerialConnection";
      this.pnlSerialConnection.Size = new System.Drawing.Size(945, 40);
      this.pnlSerialConnection.TabIndex = 0;
      // 
      // lblCurrentBaud
      // 
      this.lblCurrentBaud.AutoSize = true;
      this.lblCurrentBaud.Location = new System.Drawing.Point(768, 8);
      this.lblCurrentBaud.Name = "lblCurrentBaud";
      this.lblCurrentBaud.Size = new System.Drawing.Size(68, 13);
      this.lblCurrentBaud.TabIndex = 10;
      this.lblCurrentBaud.Text = "Current baud";
      // 
      // lblVersion
      // 
      this.lblVersion.AutoSize = true;
      this.lblVersion.Location = new System.Drawing.Point(680, 8);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(42, 13);
      this.lblVersion.TabIndex = 8;
      this.lblVersion.Text = "Version";
      // 
      // numResponseTimeoutSubsequentBytes
      // 
      this.numResponseTimeoutSubsequentBytes.Location = new System.Drawing.Point(504, 8);
      this.numResponseTimeoutSubsequentBytes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numResponseTimeoutSubsequentBytes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numResponseTimeoutSubsequentBytes.Name = "numResponseTimeoutSubsequentBytes";
      this.numResponseTimeoutSubsequentBytes.Size = new System.Drawing.Size(64, 20);
      this.numResponseTimeoutSubsequentBytes.TabIndex = 7;
      this.numResponseTimeoutSubsequentBytes.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
      // 
      // lblResponseTimeoutSubsequentBytes
      // 
      this.lblResponseTimeoutSubsequentBytes.AutoSize = true;
      this.lblResponseTimeoutSubsequentBytes.Location = new System.Drawing.Point(368, 8);
      this.lblResponseTimeoutSubsequentBytes.Name = "lblResponseTimeoutSubsequentBytes";
      this.lblResponseTimeoutSubsequentBytes.Size = new System.Drawing.Size(133, 13);
      this.lblResponseTimeoutSubsequentBytes.TabIndex = 6;
      this.lblResponseTimeoutSubsequentBytes.Text = "Last byte response timeout";
      // 
      // numResponseTimeoutFirstByte
      // 
      this.numResponseTimeoutFirstByte.Location = new System.Drawing.Point(296, 8);
      this.numResponseTimeoutFirstByte.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numResponseTimeoutFirstByte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numResponseTimeoutFirstByte.Name = "numResponseTimeoutFirstByte";
      this.numResponseTimeoutFirstByte.Size = new System.Drawing.Size(64, 20);
      this.numResponseTimeoutFirstByte.TabIndex = 5;
      this.numResponseTimeoutFirstByte.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
      // 
      // lblResponseTimeoutFirstByte
      // 
      this.lblResponseTimeoutFirstByte.AutoSize = true;
      this.lblResponseTimeoutFirstByte.Location = new System.Drawing.Point(160, 8);
      this.lblResponseTimeoutFirstByte.Name = "lblResponseTimeoutFirstByte";
      this.lblResponseTimeoutFirstByte.Size = new System.Drawing.Size(132, 13);
      this.lblResponseTimeoutFirstByte.TabIndex = 4;
      this.lblResponseTimeoutFirstByte.Text = "First byte response timeout";
      // 
      // btnSerialConnectDisconnect
      // 
      this.btnSerialConnectDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnSerialConnectDisconnect.Enabled = false;
      this.btnSerialConnectDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnSerialConnectDisconnect.FlatAppearance.BorderSize = 0;
      this.btnSerialConnectDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSerialConnectDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnSerialConnectDisconnect.Location = new System.Drawing.Point(584, 8);
      this.btnSerialConnectDisconnect.Name = "btnSerialConnectDisconnect";
      this.btnSerialConnectDisconnect.Size = new System.Drawing.Size(80, 24);
      this.btnSerialConnectDisconnect.TabIndex = 2;
      this.btnSerialConnectDisconnect.Text = "Connect";
      this.btnSerialConnectDisconnect.UseVisualStyleBackColor = false;
      this.btnSerialConnectDisconnect.Click += new System.EventHandler(this.btnSerialConnectDisconnect_Click);
      // 
      // lblSerialPort
      // 
      this.lblSerialPort.AutoSize = true;
      this.lblSerialPort.Location = new System.Drawing.Point(8, 8);
      this.lblSerialPort.Name = "lblSerialPort";
      this.lblSerialPort.Size = new System.Drawing.Size(26, 13);
      this.lblSerialPort.TabIndex = 1;
      this.lblSerialPort.Text = "Port";
      // 
      // cmbSerialPort
      // 
      this.cmbSerialPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.cmbSerialPort.FormattingEnabled = true;
      this.cmbSerialPort.Location = new System.Drawing.Point(48, 8);
      this.cmbSerialPort.Name = "cmbSerialPort";
      this.cmbSerialPort.Size = new System.Drawing.Size(104, 21);
      this.cmbSerialPort.TabIndex = 0;
      this.cmbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cmbSerialPort_SelectedIndexChanged);
      // 
      // pnlControlPanel
      // 
      this.pnlControlPanel.BackColor = System.Drawing.Color.White;
      this.pnlControlPanel.Controls.Add(this.tabControlPanel);
      this.pnlControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlControlPanel.Enabled = false;
      this.pnlControlPanel.Location = new System.Drawing.Point(0, 40);
      this.pnlControlPanel.Name = "pnlControlPanel";
      this.pnlControlPanel.Size = new System.Drawing.Size(945, 334);
      this.pnlControlPanel.TabIndex = 1;
      // 
      // tabControlPanel
      // 
      this.tabControlPanel.Alignment = System.Windows.Forms.TabAlignment.Bottom;
      this.tabControlPanel.Controls.Add(this.tabPageMain);
      this.tabControlPanel.Controls.Add(this.tabPageDebug);
      this.tabControlPanel.Controls.Add(this.tabPageLog);
      this.tabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlPanel.Location = new System.Drawing.Point(0, 0);
      this.tabControlPanel.Name = "tabControlPanel";
      this.tabControlPanel.SelectedIndex = 0;
      this.tabControlPanel.Size = new System.Drawing.Size(945, 334);
      this.tabControlPanel.TabIndex = 5;
      // 
      // tabPageMain
      // 
      this.tabPageMain.BackColor = System.Drawing.Color.White;
      this.tabPageMain.Controls.Add(this.label5);
      this.tabPageMain.Controls.Add(this.label6);
      this.tabPageMain.Controls.Add(this.label4);
      this.tabPageMain.Controls.Add(this.label3);
      this.tabPageMain.Controls.Add(this.label2);
      this.tabPageMain.Controls.Add(this.label1);
      this.tabPageMain.Controls.Add(this.grpAnalogPins);
      this.tabPageMain.Location = new System.Drawing.Point(4, 4);
      this.tabPageMain.Margin = new System.Windows.Forms.Padding(0);
      this.tabPageMain.Name = "tabPageMain";
      this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMain.Size = new System.Drawing.Size(937, 308);
      this.tabPageMain.TabIndex = 2;
      this.tabPageMain.Text = "Main";
      // 
      // grpAnalogPins
      // 
      this.grpAnalogPins.BackColor = System.Drawing.Color.White;
      this.grpAnalogPins.Controls.Add(this.pnlAnalogPins);
      this.grpAnalogPins.Dock = System.Windows.Forms.DockStyle.Left;
      this.grpAnalogPins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.grpAnalogPins.Location = new System.Drawing.Point(3, 3);
      this.grpAnalogPins.Name = "grpAnalogPins";
      this.grpAnalogPins.Size = new System.Drawing.Size(144, 302);
      this.grpAnalogPins.TabIndex = 0;
      this.grpAnalogPins.TabStop = false;
      this.grpAnalogPins.Text = "Analog pins";
      // 
      // pnlAnalogPins
      // 
      this.pnlAnalogPins.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlAnalogPins.Location = new System.Drawing.Point(3, 16);
      this.pnlAnalogPins.Name = "pnlAnalogPins";
      this.pnlAnalogPins.Size = new System.Drawing.Size(138, 283);
      this.pnlAnalogPins.TabIndex = 0;
      // 
      // tabPageDebug
      // 
      this.tabPageDebug.BackColor = System.Drawing.SystemColors.Control;
      this.tabPageDebug.Controls.Add(this.button6);
      this.tabPageDebug.Controls.Add(this.button5);
      this.tabPageDebug.Controls.Add(this.button2);
      this.tabPageDebug.Controls.Add(this.button1);
      this.tabPageDebug.Controls.Add(this.btnNoTone);
      this.tabPageDebug.Controls.Add(this.trackFrequency);
      this.tabPageDebug.Controls.Add(this.btnTone);
      this.tabPageDebug.Controls.Add(this.btnAnalogRead);
      this.tabPageDebug.Controls.Add(this.txtResponse);
      this.tabPageDebug.Controls.Add(this.sliderAnalogWrite);
      this.tabPageDebug.Controls.Add(this.txtInt);
      this.tabPageDebug.Controls.Add(this.btnSetLow);
      this.tabPageDebug.Controls.Add(this.btnSetHigh);
      this.tabPageDebug.Location = new System.Drawing.Point(4, 4);
      this.tabPageDebug.Name = "tabPageDebug";
      this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageDebug.Size = new System.Drawing.Size(1153, 479);
      this.tabPageDebug.TabIndex = 0;
      this.tabPageDebug.Text = "Debug";
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(120, 176);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(88, 32);
      this.button6.TabIndex = 21;
      this.button6.Text = "Digital read";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(480, 104);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(88, 32);
      this.button5.TabIndex = 20;
      this.button5.Text = "Debug";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(280, 176);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(88, 32);
      this.button2.TabIndex = 17;
      this.button2.Text = "Reset pins";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click_1);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(144, 72);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(64, 24);
      this.button1.TabIndex = 16;
      this.button1.Text = "Set pwm";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnNoTone
      // 
      this.btnNoTone.Location = new System.Drawing.Point(216, 120);
      this.btnNoTone.Name = "btnNoTone";
      this.btnNoTone.Size = new System.Drawing.Size(72, 24);
      this.btnNoTone.TabIndex = 15;
      this.btnNoTone.Text = "No Tone";
      this.btnNoTone.UseVisualStyleBackColor = true;
      this.btnNoTone.Click += new System.EventHandler(this.btnNoTone_Click);
      // 
      // trackFrequency
      // 
      this.trackFrequency.LargeChange = 32;
      this.trackFrequency.Location = new System.Drawing.Point(8, 120);
      this.trackFrequency.Maximum = 20000;
      this.trackFrequency.Minimum = 31;
      this.trackFrequency.Name = "trackFrequency";
      this.trackFrequency.Size = new System.Drawing.Size(128, 45);
      this.trackFrequency.TabIndex = 14;
      this.trackFrequency.TickFrequency = 64;
      this.trackFrequency.Value = 31;
      // 
      // btnTone
      // 
      this.btnTone.Location = new System.Drawing.Point(144, 120);
      this.btnTone.Name = "btnTone";
      this.btnTone.Size = new System.Drawing.Size(64, 24);
      this.btnTone.TabIndex = 13;
      this.btnTone.Text = "Tone";
      this.btnTone.UseVisualStyleBackColor = true;
      this.btnTone.Click += new System.EventHandler(this.btnTone_Click);
      // 
      // btnAnalogRead
      // 
      this.btnAnalogRead.Location = new System.Drawing.Point(16, 176);
      this.btnAnalogRead.Name = "btnAnalogRead";
      this.btnAnalogRead.Size = new System.Drawing.Size(88, 32);
      this.btnAnalogRead.TabIndex = 12;
      this.btnAnalogRead.Text = "Analog read";
      this.btnAnalogRead.UseVisualStyleBackColor = true;
      this.btnAnalogRead.Click += new System.EventHandler(this.btnAnalogRead_Click);
      // 
      // txtResponse
      // 
      this.txtResponse.Location = new System.Drawing.Point(8, 240);
      this.txtResponse.Name = "txtResponse";
      this.txtResponse.Size = new System.Drawing.Size(472, 80);
      this.txtResponse.TabIndex = 0;
      this.txtResponse.Text = "";
      // 
      // sliderAnalogWrite
      // 
      this.sliderAnalogWrite.LargeChange = 32;
      this.sliderAnalogWrite.Location = new System.Drawing.Point(8, 72);
      this.sliderAnalogWrite.Maximum = 255;
      this.sliderAnalogWrite.Name = "sliderAnalogWrite";
      this.sliderAnalogWrite.Size = new System.Drawing.Size(128, 45);
      this.sliderAnalogWrite.TabIndex = 10;
      this.sliderAnalogWrite.TickFrequency = 64;
      // 
      // txtInt
      // 
      this.txtInt.Location = new System.Drawing.Point(8, 8);
      this.txtInt.Name = "txtInt";
      this.txtInt.Size = new System.Drawing.Size(112, 20);
      this.txtInt.TabIndex = 2;
      // 
      // btnSetLow
      // 
      this.btnSetLow.Location = new System.Drawing.Point(72, 40);
      this.btnSetLow.Name = "btnSetLow";
      this.btnSetLow.Size = new System.Drawing.Size(64, 24);
      this.btnSetLow.TabIndex = 8;
      this.btnSetLow.Text = "Set low";
      this.btnSetLow.UseVisualStyleBackColor = true;
      this.btnSetLow.Click += new System.EventHandler(this.btnSetLow_Click);
      // 
      // btnSetHigh
      // 
      this.btnSetHigh.Location = new System.Drawing.Point(8, 40);
      this.btnSetHigh.Name = "btnSetHigh";
      this.btnSetHigh.Size = new System.Drawing.Size(64, 24);
      this.btnSetHigh.TabIndex = 7;
      this.btnSetHigh.Text = "Set high";
      this.btnSetHigh.UseVisualStyleBackColor = true;
      this.btnSetHigh.Click += new System.EventHandler(this.btnSetHigh_Click);
      // 
      // tabPageLog
      // 
      this.tabPageLog.BackColor = System.Drawing.SystemColors.Control;
      this.tabPageLog.Controls.Add(this.txtLog);
      this.tabPageLog.Controls.Add(this.panel1);
      this.tabPageLog.Location = new System.Drawing.Point(4, 4);
      this.tabPageLog.Name = "tabPageLog";
      this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageLog.Size = new System.Drawing.Size(1153, 479);
      this.tabPageLog.TabIndex = 1;
      this.tabPageLog.Text = "Log";
      // 
      // txtLog
      // 
      this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtLog.Location = new System.Drawing.Point(3, 32);
      this.txtLog.Name = "txtLog";
      this.txtLog.Size = new System.Drawing.Size(1147, 444);
      this.txtLog.TabIndex = 2;
      this.txtLog.Text = "";
      this.txtLog.WordWrap = false;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnClearLog);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1147, 29);
      this.panel1.TabIndex = 5;
      // 
      // btnClearLog
      // 
      this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnClearLog.Location = new System.Drawing.Point(1059, 0);
      this.btnClearLog.Name = "btnClearLog";
      this.btnClearLog.Size = new System.Drawing.Size(88, 29);
      this.btnClearLog.TabIndex = 4;
      this.btnClearLog.Text = "Clear";
      this.btnClearLog.UseVisualStyleBackColor = true;
      this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.label1.Location = new System.Drawing.Point(680, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 32);
      this.label1.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label2.Location = new System.Drawing.Point(739, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 32);
      this.label2.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(31)))));
      this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label3.Location = new System.Drawing.Point(680, 80);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(48, 32);
      this.label3.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(181)))), ((int)(((byte)(52)))));
      this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label4.Location = new System.Drawing.Point(739, 80);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 32);
      this.label4.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.Color.White;
      this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label5.Location = new System.Drawing.Point(739, 120);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(48, 32);
      this.label5.TabIndex = 6;
      // 
      // label6
      // 
      this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label6.Location = new System.Drawing.Point(680, 120);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(48, 32);
      this.label6.TabIndex = 5;
      // 
      // txtVersion
      // 
      this.txtVersion.AutoSize = true;
      this.txtVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtVersion.Location = new System.Drawing.Point(728, 8);
      this.txtVersion.Name = "txtVersion";
      this.txtVersion.Size = new System.Drawing.Size(10, 13);
      this.txtVersion.TabIndex = 11;
      this.txtVersion.Text = "-";
      // 
      // txtCurrentBaud
      // 
      this.txtCurrentBaud.AutoSize = true;
      this.txtCurrentBaud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtCurrentBaud.Location = new System.Drawing.Point(840, 8);
      this.txtCurrentBaud.Name = "txtCurrentBaud";
      this.txtCurrentBaud.Size = new System.Drawing.Size(10, 13);
      this.txtCurrentBaud.TabIndex = 12;
      this.txtCurrentBaud.Text = "-";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(945, 374);
      this.Controls.Add(this.pnlControlPanel);
      this.Controls.Add(this.pnlSerialConnection);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.pnlSerialConnection.ResumeLayout(false);
      this.pnlSerialConnection.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutSubsequentBytes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutFirstByte)).EndInit();
      this.pnlControlPanel.ResumeLayout(false);
      this.tabControlPanel.ResumeLayout(false);
      this.tabPageMain.ResumeLayout(false);
      this.grpAnalogPins.ResumeLayout(false);
      this.tabPageDebug.ResumeLayout(false);
      this.tabPageDebug.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sliderAnalogWrite)).EndInit();
      this.tabPageLog.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlSerialConnection;
    private System.Windows.Forms.ComboBox cmbSerialPort;
    private System.Windows.Forms.Button btnSerialConnectDisconnect;
    private System.Windows.Forms.Label lblSerialPort;
    private System.Windows.Forms.Panel pnlControlPanel;
    private System.Windows.Forms.TextBox txtInt;
    private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.NumericUpDown numResponseTimeoutFirstByte;
        private System.Windows.Forms.Label lblResponseTimeoutFirstByte;
    private System.Windows.Forms.RichTextBox txtLog;
    private System.Windows.Forms.Button btnClearLog;
    private System.Windows.Forms.NumericUpDown numResponseTimeoutSubsequentBytes;
    private System.Windows.Forms.Label lblResponseTimeoutSubsequentBytes;
    private System.Windows.Forms.Button btnSetLow;
    private System.Windows.Forms.Button btnSetHigh;
    private System.Windows.Forms.Label lblCurrentBaud;
    private System.Windows.Forms.Label lblVersion;
    private System.Windows.Forms.TabControl tabControlPanel;
    private System.Windows.Forms.TabPage tabPageMain;
    private System.Windows.Forms.TabPage tabPageDebug;
    private System.Windows.Forms.TabPage tabPageLog;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TrackBar sliderAnalogWrite;
    private System.Windows.Forms.Button btnAnalogRead;
    private System.Windows.Forms.Button btnTone;
    private System.Windows.Forms.TrackBar trackFrequency;
    private System.Windows.Forms.Button btnNoTone;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.GroupBox grpAnalogPins;
    private System.Windows.Forms.FlowLayoutPanel pnlAnalogPins;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label txtCurrentBaud;
    private System.Windows.Forms.Label txtVersion;
  }
}

