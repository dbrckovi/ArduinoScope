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
      this.numResponseTimeoutSubsequentBytes = new System.Windows.Forms.NumericUpDown();
      this.lblResponseTimeoutSubsequentBytes = new System.Windows.Forms.Label();
      this.numResponseTimeoutFirstByte = new System.Windows.Forms.NumericUpDown();
      this.lblResponseTimeoutFirstByte = new System.Windows.Forms.Label();
      this.btnSerialConnectDisconnect = new System.Windows.Forms.Button();
      this.lblSerialPort = new System.Windows.Forms.Label();
      this.cmbSerialPort = new System.Windows.Forms.ComboBox();
      this.pnlControlPanel = new System.Windows.Forms.Panel();
      this.txtInt = new System.Windows.Forms.TextBox();
      this.btnTest = new System.Windows.Forms.Button();
      this.txtResponse = new System.Windows.Forms.RichTextBox();
      this.txtLog = new System.Windows.Forms.RichTextBox();
      this.btnClearLog = new System.Windows.Forms.Button();
      this.btnError = new System.Windows.Forms.Button();
      this.btnDebug = new System.Windows.Forms.Button();
      this.btnSetOutput = new System.Windows.Forms.Button();
      this.btnSetInput = new System.Windows.Forms.Button();
      this.btnSetHigh = new System.Windows.Forms.Button();
      this.btnSetLow = new System.Windows.Forms.Button();
      this.lblVersion = new System.Windows.Forms.Label();
      this.txtVersion = new System.Windows.Forms.TextBox();
      this.txtCurrentBaud = new System.Windows.Forms.TextBox();
      this.lblCurrentBaud = new System.Windows.Forms.Label();
      this.btnTestBaud = new System.Windows.Forms.Button();
      this.pnlSerialConnection.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutSubsequentBytes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numResponseTimeoutFirstByte)).BeginInit();
      this.pnlControlPanel.SuspendLayout();
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
      this.lblResponseTimeoutSubsequentBytes.Size = new System.Drawing.Size(132, 13);
      this.lblResponseTimeoutSubsequentBytes.TabIndex = 6;
      this.lblResponseTimeoutSubsequentBytes.Text = "First byte response timeout";
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
      this.pnlControlPanel.Controls.Add(this.btnTestBaud);
      this.pnlControlPanel.Controls.Add(this.btnSetLow);
      this.pnlControlPanel.Controls.Add(this.btnSetHigh);
      this.pnlControlPanel.Controls.Add(this.btnSetInput);
      this.pnlControlPanel.Controls.Add(this.btnSetOutput);
      this.pnlControlPanel.Controls.Add(this.btnDebug);
      this.pnlControlPanel.Controls.Add(this.btnError);
      this.pnlControlPanel.Controls.Add(this.txtInt);
      this.pnlControlPanel.Controls.Add(this.btnTest);
      this.pnlControlPanel.Controls.Add(this.txtResponse);
      this.pnlControlPanel.Enabled = false;
      this.pnlControlPanel.Location = new System.Drawing.Point(8, 64);
      this.pnlControlPanel.Name = "pnlControlPanel";
      this.pnlControlPanel.Size = new System.Drawing.Size(488, 472);
      this.pnlControlPanel.TabIndex = 1;
      // 
      // txtInt
      // 
      this.txtInt.Location = new System.Drawing.Point(8, 8);
      this.txtInt.Name = "txtInt";
      this.txtInt.Size = new System.Drawing.Size(400, 20);
      this.txtInt.TabIndex = 2;
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(416, 8);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(56, 24);
      this.btnTest.TabIndex = 1;
      this.btnTest.Text = "Test";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtResponse
      // 
      this.txtResponse.Location = new System.Drawing.Point(8, 400);
      this.txtResponse.Name = "txtResponse";
      this.txtResponse.Size = new System.Drawing.Size(472, 80);
      this.txtResponse.TabIndex = 0;
      this.txtResponse.Text = "";
      // 
      // txtLog
      // 
      this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtLog.Location = new System.Drawing.Point(512, 104);
      this.txtLog.Name = "txtLog";
      this.txtLog.Size = new System.Drawing.Size(632, 432);
      this.txtLog.TabIndex = 2;
      this.txtLog.Text = "";
      this.txtLog.WordWrap = false;
      // 
      // btnClearLog
      // 
      this.btnClearLog.Location = new System.Drawing.Point(536, 64);
      this.btnClearLog.Name = "btnClearLog";
      this.btnClearLog.Size = new System.Drawing.Size(88, 24);
      this.btnClearLog.TabIndex = 4;
      this.btnClearLog.Text = "Clear";
      this.btnClearLog.UseVisualStyleBackColor = true;
      this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
      // 
      // btnError
      // 
      this.btnError.Location = new System.Drawing.Point(8, 32);
      this.btnError.Name = "btnError";
      this.btnError.Size = new System.Drawing.Size(72, 40);
      this.btnError.TabIndex = 3;
      this.btnError.Text = "Error";
      this.btnError.UseVisualStyleBackColor = true;
      this.btnError.Click += new System.EventHandler(this.btnError_Click);
      // 
      // btnDebug
      // 
      this.btnDebug.Location = new System.Drawing.Point(88, 32);
      this.btnDebug.Name = "btnDebug";
      this.btnDebug.Size = new System.Drawing.Size(72, 40);
      this.btnDebug.TabIndex = 4;
      this.btnDebug.Text = "Debug";
      this.btnDebug.UseVisualStyleBackColor = true;
      this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
      // 
      // btnSetOutput
      // 
      this.btnSetOutput.Location = new System.Drawing.Point(200, 32);
      this.btnSetOutput.Name = "btnSetOutput";
      this.btnSetOutput.Size = new System.Drawing.Size(112, 40);
      this.btnSetOutput.TabIndex = 5;
      this.btnSetOutput.Text = "Set as output";
      this.btnSetOutput.UseVisualStyleBackColor = true;
      this.btnSetOutput.Click += new System.EventHandler(this.btnSetOutput_Click);
      // 
      // btnSetInput
      // 
      this.btnSetInput.Location = new System.Drawing.Point(200, 80);
      this.btnSetInput.Name = "btnSetInput";
      this.btnSetInput.Size = new System.Drawing.Size(112, 40);
      this.btnSetInput.TabIndex = 6;
      this.btnSetInput.Text = "Set as input";
      this.btnSetInput.UseVisualStyleBackColor = true;
      this.btnSetInput.Click += new System.EventHandler(this.btnSetInput_Click);
      // 
      // btnSetHigh
      // 
      this.btnSetHigh.Location = new System.Drawing.Point(320, 32);
      this.btnSetHigh.Name = "btnSetHigh";
      this.btnSetHigh.Size = new System.Drawing.Size(112, 40);
      this.btnSetHigh.TabIndex = 7;
      this.btnSetHigh.Text = "Set high";
      this.btnSetHigh.UseVisualStyleBackColor = true;
      this.btnSetHigh.Click += new System.EventHandler(this.btnSetHigh_Click);
      // 
      // btnSetLow
      // 
      this.btnSetLow.Location = new System.Drawing.Point(320, 80);
      this.btnSetLow.Name = "btnSetLow";
      this.btnSetLow.Size = new System.Drawing.Size(112, 40);
      this.btnSetLow.TabIndex = 8;
      this.btnSetLow.Text = "Set low";
      this.btnSetLow.UseVisualStyleBackColor = true;
      this.btnSetLow.Click += new System.EventHandler(this.btnSetLow_Click);
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
      // txtVersion
      // 
      this.txtVersion.Enabled = false;
      this.txtVersion.Location = new System.Drawing.Point(728, 8);
      this.txtVersion.Name = "txtVersion";
      this.txtVersion.Size = new System.Drawing.Size(32, 20);
      this.txtVersion.TabIndex = 9;
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
      // btnTestBaud
      // 
      this.btnTestBaud.Location = new System.Drawing.Point(8, 80);
      this.btnTestBaud.Name = "btnTestBaud";
      this.btnTestBaud.Size = new System.Drawing.Size(112, 40);
      this.btnTestBaud.TabIndex = 9;
      this.btnTestBaud.Text = "Test baud";
      this.btnTestBaud.UseVisualStyleBackColor = true;
      this.btnTestBaud.Click += new System.EventHandler(this.btnTestBaud_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1161, 618);
      this.Controls.Add(this.btnClearLog);
      this.Controls.Add(this.txtLog);
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
      this.pnlControlPanel.PerformLayout();
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
  }
}

