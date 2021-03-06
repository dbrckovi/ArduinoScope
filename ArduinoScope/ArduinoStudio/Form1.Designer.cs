﻿namespace ArduinoStudio
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
      this.txtCurrentBaud = new System.Windows.Forms.Label();
      this.txtVersion = new System.Windows.Forms.Label();
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
      this.grpDigitalPins = new System.Windows.Forms.GroupBox();
      this.pnlDigitalPins = new System.Windows.Forms.FlowLayoutPanel();
      this.grpAnalogPins = new System.Windows.Forms.GroupBox();
      this.pnlAnalogPins = new System.Windows.Forms.FlowLayoutPanel();
      this.pnlButtons = new System.Windows.Forms.Panel();
      this.btnResetPins = new System.Windows.Forms.Button();
      this.tabPageLog = new System.Windows.Forms.TabPage();
      this.txtLog = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.chkEnableLog = new System.Windows.Forms.CheckBox();
      this.btnClearLog = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.pnlSerialConnection.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutSubsequentBytes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutFirstByte)).BeginInit();
      this.pnlControlPanel.SuspendLayout();
      this.tabControlPanel.SuspendLayout();
      this.tabPageMain.SuspendLayout();
      this.grpDigitalPins.SuspendLayout();
      this.grpAnalogPins.SuspendLayout();
      this.pnlButtons.SuspendLayout();
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
      this.pnlSerialConnection.Size = new System.Drawing.Size(1152, 40);
      this.pnlSerialConnection.TabIndex = 0;
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
      this.pnlControlPanel.Size = new System.Drawing.Size(1152, 656);
      this.pnlControlPanel.TabIndex = 1;
      // 
      // tabControlPanel
      // 
      this.tabControlPanel.Alignment = System.Windows.Forms.TabAlignment.Bottom;
      this.tabControlPanel.Controls.Add(this.tabPageMain);
      this.tabControlPanel.Controls.Add(this.tabPageLog);
      this.tabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlPanel.Location = new System.Drawing.Point(0, 0);
      this.tabControlPanel.Name = "tabControlPanel";
      this.tabControlPanel.SelectedIndex = 0;
      this.tabControlPanel.Size = new System.Drawing.Size(1152, 656);
      this.tabControlPanel.TabIndex = 5;
      // 
      // tabPageMain
      // 
      this.tabPageMain.BackColor = System.Drawing.Color.White;
      this.tabPageMain.Controls.Add(this.grpDigitalPins);
      this.tabPageMain.Controls.Add(this.grpAnalogPins);
      this.tabPageMain.Controls.Add(this.pnlButtons);
      this.tabPageMain.Location = new System.Drawing.Point(4, 4);
      this.tabPageMain.Margin = new System.Windows.Forms.Padding(0);
      this.tabPageMain.Name = "tabPageMain";
      this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMain.Size = new System.Drawing.Size(1144, 630);
      this.tabPageMain.TabIndex = 2;
      this.tabPageMain.Text = "Main";
      // 
      // grpDigitalPins
      // 
      this.grpDigitalPins.BackColor = System.Drawing.Color.White;
      this.grpDigitalPins.Controls.Add(this.pnlDigitalPins);
      this.grpDigitalPins.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpDigitalPins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.grpDigitalPins.Location = new System.Drawing.Point(147, 32);
      this.grpDigitalPins.Name = "grpDigitalPins";
      this.grpDigitalPins.Size = new System.Drawing.Size(994, 595);
      this.grpDigitalPins.TabIndex = 7;
      this.grpDigitalPins.TabStop = false;
      this.grpDigitalPins.Text = "Digital pins";
      // 
      // pnlDigitalPins
      // 
      this.pnlDigitalPins.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlDigitalPins.Location = new System.Drawing.Point(3, 16);
      this.pnlDigitalPins.Name = "pnlDigitalPins";
      this.pnlDigitalPins.Size = new System.Drawing.Size(988, 576);
      this.pnlDigitalPins.TabIndex = 0;
      // 
      // grpAnalogPins
      // 
      this.grpAnalogPins.BackColor = System.Drawing.Color.White;
      this.grpAnalogPins.Controls.Add(this.pnlAnalogPins);
      this.grpAnalogPins.Dock = System.Windows.Forms.DockStyle.Left;
      this.grpAnalogPins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.grpAnalogPins.Location = new System.Drawing.Point(3, 32);
      this.grpAnalogPins.Name = "grpAnalogPins";
      this.grpAnalogPins.Size = new System.Drawing.Size(144, 595);
      this.grpAnalogPins.TabIndex = 0;
      this.grpAnalogPins.TabStop = false;
      this.grpAnalogPins.Text = "Analog pins";
      // 
      // pnlAnalogPins
      // 
      this.pnlAnalogPins.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlAnalogPins.Location = new System.Drawing.Point(3, 16);
      this.pnlAnalogPins.Name = "pnlAnalogPins";
      this.pnlAnalogPins.Size = new System.Drawing.Size(138, 576);
      this.pnlAnalogPins.TabIndex = 0;
      // 
      // pnlButtons
      // 
      this.pnlButtons.Controls.Add(this.btnResetPins);
      this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlButtons.Location = new System.Drawing.Point(3, 3);
      this.pnlButtons.Name = "pnlButtons";
      this.pnlButtons.Size = new System.Drawing.Size(1138, 29);
      this.pnlButtons.TabIndex = 8;
      // 
      // btnResetPins
      // 
      this.btnResetPins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnResetPins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(161)))), ((int)(((byte)(165)))));
      this.btnResetPins.FlatAppearance.BorderSize = 0;
      this.btnResetPins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnResetPins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
      this.btnResetPins.Location = new System.Drawing.Point(2, 2);
      this.btnResetPins.Name = "btnResetPins";
      this.btnResetPins.Size = new System.Drawing.Size(80, 24);
      this.btnResetPins.TabIndex = 3;
      this.btnResetPins.Text = "Reset pins";
      this.btnResetPins.UseVisualStyleBackColor = false;
      this.btnResetPins.Click += new System.EventHandler(this.btnResetPins_Click);
      // 
      // tabPageLog
      // 
      this.tabPageLog.BackColor = System.Drawing.SystemColors.Control;
      this.tabPageLog.Controls.Add(this.txtLog);
      this.tabPageLog.Controls.Add(this.panel1);
      this.tabPageLog.Location = new System.Drawing.Point(4, 4);
      this.tabPageLog.Name = "tabPageLog";
      this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageLog.Size = new System.Drawing.Size(1144, 630);
      this.tabPageLog.TabIndex = 1;
      this.tabPageLog.Text = "Log";
      // 
      // txtLog
      // 
      this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtLog.Location = new System.Drawing.Point(3, 32);
      this.txtLog.Name = "txtLog";
      this.txtLog.Size = new System.Drawing.Size(1138, 595);
      this.txtLog.TabIndex = 2;
      this.txtLog.Text = "";
      this.txtLog.WordWrap = false;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.chkEnableLog);
      this.panel1.Controls.Add(this.btnClearLog);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1138, 29);
      this.panel1.TabIndex = 5;
      // 
      // chkEnableLog
      // 
      this.chkEnableLog.AutoSize = true;
      this.chkEnableLog.Location = new System.Drawing.Point(8, 6);
      this.chkEnableLog.Name = "chkEnableLog";
      this.chkEnableLog.Size = new System.Drawing.Size(76, 17);
      this.chkEnableLog.TabIndex = 5;
      this.chkEnableLog.Text = "Enable log";
      this.chkEnableLog.UseVisualStyleBackColor = true;
      // 
      // btnClearLog
      // 
      this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnClearLog.Location = new System.Drawing.Point(1050, 0);
      this.btnClearLog.Name = "btnClearLog";
      this.btnClearLog.Size = new System.Drawing.Size(88, 29);
      this.btnClearLog.TabIndex = 4;
      this.btnClearLog.Text = "Clear";
      this.btnClearLog.UseVisualStyleBackColor = true;
      this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(1056, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Test";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1152, 696);
      this.Controls.Add(this.button1);
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
      this.grpAnalogPins.ResumeLayout(false);
      this.pnlButtons.ResumeLayout(false);
      this.tabPageLog.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlSerialConnection;
    private System.Windows.Forms.ComboBox cmbSerialPort;
    private System.Windows.Forms.Button btnSerialConnectDisconnect;
    private System.Windows.Forms.Label lblSerialPort;
    private System.Windows.Forms.Panel pnlControlPanel;
        private System.Windows.Forms.NumericUpDown numResponseTimeoutFirstByte;
        private System.Windows.Forms.Label lblResponseTimeoutFirstByte;
    private System.Windows.Forms.RichTextBox txtLog;
    private System.Windows.Forms.Button btnClearLog;
    private System.Windows.Forms.NumericUpDown numResponseTimeoutSubsequentBytes;
    private System.Windows.Forms.Label lblResponseTimeoutSubsequentBytes;
    private System.Windows.Forms.Label lblCurrentBaud;
    private System.Windows.Forms.Label lblVersion;
    private System.Windows.Forms.TabControl tabControlPanel;
    private System.Windows.Forms.TabPage tabPageMain;
    private System.Windows.Forms.TabPage tabPageLog;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.GroupBox grpAnalogPins;
    private System.Windows.Forms.FlowLayoutPanel pnlAnalogPins;
    private System.Windows.Forms.Label txtCurrentBaud;
    private System.Windows.Forms.Label txtVersion;
    private System.Windows.Forms.GroupBox grpDigitalPins;
    private System.Windows.Forms.FlowLayoutPanel pnlDigitalPins;
    private System.Windows.Forms.Panel pnlButtons;
    private System.Windows.Forms.Button btnResetPins;
    private System.Windows.Forms.CheckBox chkEnableLog;
    private System.Windows.Forms.Button button1;
  }
}

