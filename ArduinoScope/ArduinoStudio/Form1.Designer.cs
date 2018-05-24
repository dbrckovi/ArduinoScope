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
      this.txtCurrentBaud = new System.Windows.Forms.TextBox();
      this.lblCurrentBaud = new System.Windows.Forms.Label();
      this.txtVersion = new System.Windows.Forms.TextBox();
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
      this.grpDigitalPins = new System.Windows.Forms.GroupBox();
      this.digitalPinController14 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController13 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController12 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController11 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController10 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController9 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController8 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController7 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController6 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController5 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController4 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController3 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController2 = new ArduinoStudio.DigitalPinController();
      this.digitalPinController1 = new ArduinoStudio.DigitalPinController();
      this.tabPageDebug = new System.Windows.Forms.TabPage();
      this.btnNoTone = new System.Windows.Forms.Button();
      this.trackFrequency = new System.Windows.Forms.TrackBar();
      this.btnTone = new System.Windows.Forms.Button();
      this.btnAnalogRead = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.txtResponse = new System.Windows.Forms.RichTextBox();
      this.btnTestBaud = new System.Windows.Forms.Button();
      this.sliderAnalogWrite = new System.Windows.Forms.TrackBar();
      this.txtInt = new System.Windows.Forms.TextBox();
      this.btnSetLow = new System.Windows.Forms.Button();
      this.btnTest = new System.Windows.Forms.Button();
      this.btnSetHigh = new System.Windows.Forms.Button();
      this.btnError = new System.Windows.Forms.Button();
      this.btnSetInput = new System.Windows.Forms.Button();
      this.btnDebug = new System.Windows.Forms.Button();
      this.btnSetOutput = new System.Windows.Forms.Button();
      this.tabPageLog = new System.Windows.Forms.TabPage();
      this.txtLog = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnClearLog = new System.Windows.Forms.Button();
      this.pnlSerialConnection.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutSubsequentBytes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutFirstByte)).BeginInit();
      this.pnlControlPanel.SuspendLayout();
      this.tabControlPanel.SuspendLayout();
      this.tabPageMain.SuspendLayout();
      this.grpDigitalPins.SuspendLayout();
      this.tabPageDebug.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackFrequency)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sliderAnalogWrite)).BeginInit();
      this.tabPageLog.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlSerialConnection
      // 
      this.pnlSerialConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlSerialConnection.Controls.Add(this.txtCurrentBaud);
      this.pnlSerialConnection.Controls.Add(this.lblCurrentBaud);
      this.pnlSerialConnection.Controls.Add(this.txtVersion);
      this.pnlSerialConnection.Controls.Add(this.lblVersion);
      this.pnlSerialConnection.Controls.Add(this.numResponseTimeoutSubsequentBytes);
      this.pnlSerialConnection.Controls.Add(this.lblResponseTimeoutSubsequentBytes);
      this.pnlSerialConnection.Controls.Add(this.numResponseTimeoutFirstByte);
      this.pnlSerialConnection.Controls.Add(this.lblResponseTimeoutFirstByte);
      this.pnlSerialConnection.Controls.Add(this.btnSerialConnectDisconnect);
      this.pnlSerialConnection.Controls.Add(this.lblSerialPort);
      this.pnlSerialConnection.Controls.Add(this.cmbSerialPort);
      this.pnlSerialConnection.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlSerialConnection.Location = new System.Drawing.Point(0, 0);
      this.pnlSerialConnection.Name = "pnlSerialConnection";
      this.pnlSerialConnection.Size = new System.Drawing.Size(1161, 40);
      this.pnlSerialConnection.TabIndex = 0;
      // 
      // txtCurrentBaud
      // 
      this.txtCurrentBaud.Enabled = false;
      this.txtCurrentBaud.Location = new System.Drawing.Point(840, 8);
      this.txtCurrentBaud.Name = "txtCurrentBaud";
      this.txtCurrentBaud.Size = new System.Drawing.Size(80, 20);
      this.txtCurrentBaud.TabIndex = 11;
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
      // txtVersion
      // 
      this.txtVersion.Enabled = false;
      this.txtVersion.Location = new System.Drawing.Point(728, 8);
      this.txtVersion.Name = "txtVersion";
      this.txtVersion.Size = new System.Drawing.Size(32, 20);
      this.txtVersion.TabIndex = 9;
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
            100,
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
            1000,
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
      this.btnSerialConnectDisconnect.Enabled = false;
      this.btnSerialConnectDisconnect.Location = new System.Drawing.Point(584, 8);
      this.btnSerialConnectDisconnect.Name = "btnSerialConnectDisconnect";
      this.btnSerialConnectDisconnect.Size = new System.Drawing.Size(80, 24);
      this.btnSerialConnectDisconnect.TabIndex = 2;
      this.btnSerialConnectDisconnect.Text = "Connect";
      this.btnSerialConnectDisconnect.UseVisualStyleBackColor = true;
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
      this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialPort.FormattingEnabled = true;
      this.cmbSerialPort.Location = new System.Drawing.Point(48, 8);
      this.cmbSerialPort.Name = "cmbSerialPort";
      this.cmbSerialPort.Size = new System.Drawing.Size(104, 21);
      this.cmbSerialPort.TabIndex = 0;
      this.cmbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cmbSerialPort_SelectedIndexChanged);
      // 
      // pnlControlPanel
      // 
      this.pnlControlPanel.Controls.Add(this.tabControlPanel);
      this.pnlControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlControlPanel.Enabled = false;
      this.pnlControlPanel.Location = new System.Drawing.Point(0, 40);
      this.pnlControlPanel.Name = "pnlControlPanel";
      this.pnlControlPanel.Size = new System.Drawing.Size(1161, 505);
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
      this.tabControlPanel.Size = new System.Drawing.Size(1161, 505);
      this.tabControlPanel.TabIndex = 5;
      // 
      // tabPageMain
      // 
      this.tabPageMain.BackColor = System.Drawing.SystemColors.Control;
      this.tabPageMain.Controls.Add(this.grpDigitalPins);
      this.tabPageMain.Location = new System.Drawing.Point(4, 4);
      this.tabPageMain.Name = "tabPageMain";
      this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMain.Size = new System.Drawing.Size(1153, 479);
      this.tabPageMain.TabIndex = 2;
      this.tabPageMain.Text = "Main";
      // 
      // grpDigitalPins
      // 
      this.grpDigitalPins.Controls.Add(this.digitalPinController14);
      this.grpDigitalPins.Controls.Add(this.digitalPinController13);
      this.grpDigitalPins.Controls.Add(this.digitalPinController12);
      this.grpDigitalPins.Controls.Add(this.digitalPinController11);
      this.grpDigitalPins.Controls.Add(this.digitalPinController10);
      this.grpDigitalPins.Controls.Add(this.digitalPinController9);
      this.grpDigitalPins.Controls.Add(this.digitalPinController8);
      this.grpDigitalPins.Controls.Add(this.digitalPinController7);
      this.grpDigitalPins.Controls.Add(this.digitalPinController6);
      this.grpDigitalPins.Controls.Add(this.digitalPinController5);
      this.grpDigitalPins.Controls.Add(this.digitalPinController4);
      this.grpDigitalPins.Controls.Add(this.digitalPinController3);
      this.grpDigitalPins.Controls.Add(this.digitalPinController2);
      this.grpDigitalPins.Controls.Add(this.digitalPinController1);
      this.grpDigitalPins.Location = new System.Drawing.Point(8, 8);
      this.grpDigitalPins.Name = "grpDigitalPins";
      this.grpDigitalPins.Size = new System.Drawing.Size(304, 408);
      this.grpDigitalPins.TabIndex = 1;
      this.grpDigitalPins.TabStop = false;
      this.grpDigitalPins.Text = "Digital Pins";
      // 
      // digitalPinController14
      // 
      this.digitalPinController14.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController14.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController14.Location = new System.Drawing.Point(3, 341);
      this.digitalPinController14.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController14.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController14.Name = "digitalPinController14";
      this.digitalPinController14.PinNumber = 13;
      this.digitalPinController14.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController14.TabIndex = 13;
      // 
      // digitalPinController13
      // 
      this.digitalPinController13.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController13.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController13.Location = new System.Drawing.Point(3, 316);
      this.digitalPinController13.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController13.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController13.Name = "digitalPinController13";
      this.digitalPinController13.PinNumber = 12;
      this.digitalPinController13.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController13.TabIndex = 12;
      // 
      // digitalPinController12
      // 
      this.digitalPinController12.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController12.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController12.Location = new System.Drawing.Point(3, 291);
      this.digitalPinController12.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController12.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController12.Name = "digitalPinController12";
      this.digitalPinController12.PinNumber = 11;
      this.digitalPinController12.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController12.TabIndex = 11;
      // 
      // digitalPinController11
      // 
      this.digitalPinController11.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController11.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController11.Location = new System.Drawing.Point(3, 266);
      this.digitalPinController11.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController11.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController11.Name = "digitalPinController11";
      this.digitalPinController11.PinNumber = 10;
      this.digitalPinController11.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController11.TabIndex = 10;
      // 
      // digitalPinController10
      // 
      this.digitalPinController10.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController10.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController10.Location = new System.Drawing.Point(3, 241);
      this.digitalPinController10.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController10.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController10.Name = "digitalPinController10";
      this.digitalPinController10.PinNumber = 9;
      this.digitalPinController10.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController10.TabIndex = 9;
      // 
      // digitalPinController9
      // 
      this.digitalPinController9.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController9.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController9.Location = new System.Drawing.Point(3, 216);
      this.digitalPinController9.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController9.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController9.Name = "digitalPinController9";
      this.digitalPinController9.PinNumber = 8;
      this.digitalPinController9.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController9.TabIndex = 8;
      // 
      // digitalPinController8
      // 
      this.digitalPinController8.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController8.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController8.Location = new System.Drawing.Point(3, 191);
      this.digitalPinController8.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController8.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController8.Name = "digitalPinController8";
      this.digitalPinController8.PinNumber = 7;
      this.digitalPinController8.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController8.TabIndex = 7;
      // 
      // digitalPinController7
      // 
      this.digitalPinController7.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController7.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController7.Location = new System.Drawing.Point(3, 166);
      this.digitalPinController7.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController7.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController7.Name = "digitalPinController7";
      this.digitalPinController7.PinNumber = 6;
      this.digitalPinController7.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController7.TabIndex = 6;
      // 
      // digitalPinController6
      // 
      this.digitalPinController6.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController6.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController6.Location = new System.Drawing.Point(3, 141);
      this.digitalPinController6.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController6.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController6.Name = "digitalPinController6";
      this.digitalPinController6.PinNumber = 5;
      this.digitalPinController6.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController6.TabIndex = 5;
      // 
      // digitalPinController5
      // 
      this.digitalPinController5.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController5.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController5.Location = new System.Drawing.Point(3, 116);
      this.digitalPinController5.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController5.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController5.Name = "digitalPinController5";
      this.digitalPinController5.PinNumber = 4;
      this.digitalPinController5.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController5.TabIndex = 4;
      // 
      // digitalPinController4
      // 
      this.digitalPinController4.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController4.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController4.Location = new System.Drawing.Point(3, 91);
      this.digitalPinController4.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController4.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController4.Name = "digitalPinController4";
      this.digitalPinController4.PinNumber = 3;
      this.digitalPinController4.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController4.TabIndex = 3;
      // 
      // digitalPinController3
      // 
      this.digitalPinController3.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController3.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController3.Location = new System.Drawing.Point(3, 66);
      this.digitalPinController3.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController3.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController3.Name = "digitalPinController3";
      this.digitalPinController3.PinNumber = 2;
      this.digitalPinController3.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController3.TabIndex = 2;
      // 
      // digitalPinController2
      // 
      this.digitalPinController2.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController2.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController2.Location = new System.Drawing.Point(3, 41);
      this.digitalPinController2.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController2.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController2.Name = "digitalPinController2";
      this.digitalPinController2.PinNumber = 1;
      this.digitalPinController2.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController2.TabIndex = 1;
      // 
      // digitalPinController1
      // 
      this.digitalPinController1.BackColor = System.Drawing.SystemColors.Control;
      this.digitalPinController1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.digitalPinController1.Dock = System.Windows.Forms.DockStyle.Top;
      this.digitalPinController1.Location = new System.Drawing.Point(3, 16);
      this.digitalPinController1.MaximumSize = new System.Drawing.Size(1000, 25);
      this.digitalPinController1.MinimumSize = new System.Drawing.Size(100, 25);
      this.digitalPinController1.Name = "digitalPinController1";
      this.digitalPinController1.PinNumber = 0;
      this.digitalPinController1.Size = new System.Drawing.Size(298, 25);
      this.digitalPinController1.TabIndex = 0;
      // 
      // tabPageDebug
      // 
      this.tabPageDebug.BackColor = System.Drawing.SystemColors.Control;
      this.tabPageDebug.Controls.Add(this.btnNoTone);
      this.tabPageDebug.Controls.Add(this.trackFrequency);
      this.tabPageDebug.Controls.Add(this.btnTone);
      this.tabPageDebug.Controls.Add(this.btnAnalogRead);
      this.tabPageDebug.Controls.Add(this.textBox1);
      this.tabPageDebug.Controls.Add(this.txtResponse);
      this.tabPageDebug.Controls.Add(this.btnTestBaud);
      this.tabPageDebug.Controls.Add(this.sliderAnalogWrite);
      this.tabPageDebug.Controls.Add(this.txtInt);
      this.tabPageDebug.Controls.Add(this.btnSetLow);
      this.tabPageDebug.Controls.Add(this.btnTest);
      this.tabPageDebug.Controls.Add(this.btnSetHigh);
      this.tabPageDebug.Controls.Add(this.btnError);
      this.tabPageDebug.Controls.Add(this.btnSetInput);
      this.tabPageDebug.Controls.Add(this.btnDebug);
      this.tabPageDebug.Controls.Add(this.btnSetOutput);
      this.tabPageDebug.Location = new System.Drawing.Point(4, 4);
      this.tabPageDebug.Name = "tabPageDebug";
      this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageDebug.Size = new System.Drawing.Size(1153, 479);
      this.tabPageDebug.TabIndex = 0;
      this.tabPageDebug.Text = "Debug";
      // 
      // btnNoTone
      // 
      this.btnNoTone.Location = new System.Drawing.Point(472, 128);
      this.btnNoTone.Name = "btnNoTone";
      this.btnNoTone.Size = new System.Drawing.Size(112, 40);
      this.btnNoTone.TabIndex = 15;
      this.btnNoTone.Text = "No Tone";
      this.btnNoTone.UseVisualStyleBackColor = true;
      this.btnNoTone.Click += new System.EventHandler(this.btnNoTone_Click);
      // 
      // trackFrequency
      // 
      this.trackFrequency.LargeChange = 32;
      this.trackFrequency.Location = new System.Drawing.Point(352, 176);
      this.trackFrequency.Maximum = 20000;
      this.trackFrequency.Minimum = 31;
      this.trackFrequency.Name = "trackFrequency";
      this.trackFrequency.Size = new System.Drawing.Size(112, 45);
      this.trackFrequency.TabIndex = 14;
      this.trackFrequency.TickFrequency = 64;
      this.trackFrequency.Value = 31;
      // 
      // btnTone
      // 
      this.btnTone.Location = new System.Drawing.Point(352, 128);
      this.btnTone.Name = "btnTone";
      this.btnTone.Size = new System.Drawing.Size(112, 40);
      this.btnTone.TabIndex = 13;
      this.btnTone.Text = "Tone";
      this.btnTone.UseVisualStyleBackColor = true;
      this.btnTone.Click += new System.EventHandler(this.btnTone_Click);
      // 
      // btnAnalogRead
      // 
      this.btnAnalogRead.Location = new System.Drawing.Point(232, 128);
      this.btnAnalogRead.Name = "btnAnalogRead";
      this.btnAnalogRead.Size = new System.Drawing.Size(112, 40);
      this.btnAnalogRead.TabIndex = 12;
      this.btnAnalogRead.Text = "Analog read";
      this.btnAnalogRead.UseVisualStyleBackColor = true;
      this.btnAnalogRead.Click += new System.EventHandler(this.btnAnalogRead_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(109, 133);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(104, 20);
      this.textBox1.TabIndex = 11;
      // 
      // txtResponse
      // 
      this.txtResponse.Location = new System.Drawing.Point(8, 240);
      this.txtResponse.Name = "txtResponse";
      this.txtResponse.Size = new System.Drawing.Size(472, 80);
      this.txtResponse.TabIndex = 0;
      this.txtResponse.Text = "";
      // 
      // btnTestBaud
      // 
      this.btnTestBaud.Location = new System.Drawing.Point(4, 74);
      this.btnTestBaud.Name = "btnTestBaud";
      this.btnTestBaud.Size = new System.Drawing.Size(112, 40);
      this.btnTestBaud.TabIndex = 9;
      this.btnTestBaud.Text = "Test baud";
      this.btnTestBaud.UseVisualStyleBackColor = true;
      this.btnTestBaud.Click += new System.EventHandler(this.btnTestBaud_Click);
      // 
      // sliderAnalogWrite
      // 
      this.sliderAnalogWrite.LargeChange = 32;
      this.sliderAnalogWrite.Location = new System.Drawing.Point(8, 128);
      this.sliderAnalogWrite.Maximum = 255;
      this.sliderAnalogWrite.Name = "sliderAnalogWrite";
      this.sliderAnalogWrite.Size = new System.Drawing.Size(93, 45);
      this.sliderAnalogWrite.TabIndex = 10;
      this.sliderAnalogWrite.TickFrequency = 64;
      this.sliderAnalogWrite.Scroll += new System.EventHandler(this.sliderAnalogWrite_Scroll);
      // 
      // txtInt
      // 
      this.txtInt.Location = new System.Drawing.Point(4, 2);
      this.txtInt.Name = "txtInt";
      this.txtInt.Size = new System.Drawing.Size(400, 20);
      this.txtInt.TabIndex = 2;
      // 
      // btnSetLow
      // 
      this.btnSetLow.Location = new System.Drawing.Point(316, 74);
      this.btnSetLow.Name = "btnSetLow";
      this.btnSetLow.Size = new System.Drawing.Size(112, 40);
      this.btnSetLow.TabIndex = 8;
      this.btnSetLow.Text = "Set low";
      this.btnSetLow.UseVisualStyleBackColor = true;
      this.btnSetLow.Click += new System.EventHandler(this.btnSetLow_Click);
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(412, 2);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(56, 24);
      this.btnTest.TabIndex = 1;
      this.btnTest.Text = "Test";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnSetHigh
      // 
      this.btnSetHigh.Location = new System.Drawing.Point(316, 26);
      this.btnSetHigh.Name = "btnSetHigh";
      this.btnSetHigh.Size = new System.Drawing.Size(112, 40);
      this.btnSetHigh.TabIndex = 7;
      this.btnSetHigh.Text = "Set high";
      this.btnSetHigh.UseVisualStyleBackColor = true;
      this.btnSetHigh.Click += new System.EventHandler(this.btnSetHigh_Click);
      // 
      // btnError
      // 
      this.btnError.Location = new System.Drawing.Point(4, 26);
      this.btnError.Name = "btnError";
      this.btnError.Size = new System.Drawing.Size(72, 40);
      this.btnError.TabIndex = 3;
      this.btnError.Text = "Error";
      this.btnError.UseVisualStyleBackColor = true;
      this.btnError.Click += new System.EventHandler(this.btnError_Click);
      // 
      // btnSetInput
      // 
      this.btnSetInput.Location = new System.Drawing.Point(196, 74);
      this.btnSetInput.Name = "btnSetInput";
      this.btnSetInput.Size = new System.Drawing.Size(112, 40);
      this.btnSetInput.TabIndex = 6;
      this.btnSetInput.Text = "Set as input";
      this.btnSetInput.UseVisualStyleBackColor = true;
      this.btnSetInput.Click += new System.EventHandler(this.btnSetInput_Click);
      // 
      // btnDebug
      // 
      this.btnDebug.Location = new System.Drawing.Point(84, 26);
      this.btnDebug.Name = "btnDebug";
      this.btnDebug.Size = new System.Drawing.Size(72, 40);
      this.btnDebug.TabIndex = 4;
      this.btnDebug.Text = "Debug";
      this.btnDebug.UseVisualStyleBackColor = true;
      this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
      // 
      // btnSetOutput
      // 
      this.btnSetOutput.Location = new System.Drawing.Point(196, 26);
      this.btnSetOutput.Name = "btnSetOutput";
      this.btnSetOutput.Size = new System.Drawing.Size(112, 40);
      this.btnSetOutput.TabIndex = 5;
      this.btnSetOutput.Text = "Set as output";
      this.btnSetOutput.UseVisualStyleBackColor = true;
      this.btnSetOutput.Click += new System.EventHandler(this.btnSetOutput_Click);
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1161, 545);
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
      this.grpDigitalPins.ResumeLayout(false);
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
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.NumericUpDown numResponseTimeoutFirstByte;
        private System.Windows.Forms.Label lblResponseTimeoutFirstByte;
    private System.Windows.Forms.RichTextBox txtLog;
    private System.Windows.Forms.Button btnClearLog;
    private System.Windows.Forms.NumericUpDown numResponseTimeoutSubsequentBytes;
    private System.Windows.Forms.Label lblResponseTimeoutSubsequentBytes;
    private System.Windows.Forms.Button btnError;
    private System.Windows.Forms.Button btnDebug;
    private System.Windows.Forms.Button btnSetLow;
    private System.Windows.Forms.Button btnSetHigh;
    private System.Windows.Forms.Button btnSetInput;
    private System.Windows.Forms.Button btnSetOutput;
    private System.Windows.Forms.TextBox txtCurrentBaud;
    private System.Windows.Forms.Label lblCurrentBaud;
    private System.Windows.Forms.TextBox txtVersion;
    private System.Windows.Forms.Label lblVersion;
    private System.Windows.Forms.Button btnTestBaud;
    private System.Windows.Forms.TabControl tabControlPanel;
    private System.Windows.Forms.TabPage tabPageMain;
    private System.Windows.Forms.TabPage tabPageDebug;
    private System.Windows.Forms.TabPage tabPageLog;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TrackBar sliderAnalogWrite;
    private System.Windows.Forms.Button btnAnalogRead;
    private System.Windows.Forms.Button btnTone;
    private System.Windows.Forms.TrackBar trackFrequency;
    private System.Windows.Forms.Button btnNoTone;
    private DigitalPinController digitalPinController1;
    private System.Windows.Forms.GroupBox grpDigitalPins;
    private DigitalPinController digitalPinController14;
    private DigitalPinController digitalPinController13;
    private DigitalPinController digitalPinController12;
    private DigitalPinController digitalPinController11;
    private DigitalPinController digitalPinController10;
    private DigitalPinController digitalPinController9;
    private DigitalPinController digitalPinController8;
    private DigitalPinController digitalPinController7;
    private DigitalPinController digitalPinController6;
    private DigitalPinController digitalPinController5;
    private DigitalPinController digitalPinController4;
    private DigitalPinController digitalPinController3;
    private DigitalPinController digitalPinController2;
  }
}

