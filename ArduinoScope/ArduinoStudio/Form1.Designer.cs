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
      this.btnSerialConnectDisconnect = new System.Windows.Forms.Button();
      this.lblSerialPorts = new System.Windows.Forms.Label();
      this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
      this.pnlControlPanel = new System.Windows.Forms.Panel();
      this.txtResponse = new System.Windows.Forms.RichTextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.txtInt = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.pnlSerialConnection.SuspendLayout();
      this.pnlControlPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlSerialConnection
      // 
      this.pnlSerialConnection.Controls.Add(this.btnSerialConnectDisconnect);
      this.pnlSerialConnection.Controls.Add(this.lblSerialPorts);
      this.pnlSerialConnection.Controls.Add(this.cmbSerialPorts);
      this.pnlSerialConnection.Location = new System.Drawing.Point(8, 8);
      this.pnlSerialConnection.Name = "pnlSerialConnection";
      this.pnlSerialConnection.Size = new System.Drawing.Size(392, 32);
      this.pnlSerialConnection.TabIndex = 0;
      // 
      // btnSerialConnectDisconnect
      // 
      this.btnSerialConnectDisconnect.Enabled = false;
      this.btnSerialConnectDisconnect.Location = new System.Drawing.Point(240, 0);
      this.btnSerialConnectDisconnect.Name = "btnSerialConnectDisconnect";
      this.btnSerialConnectDisconnect.Size = new System.Drawing.Size(80, 24);
      this.btnSerialConnectDisconnect.TabIndex = 2;
      this.btnSerialConnectDisconnect.Text = "Connect";
      this.btnSerialConnectDisconnect.UseVisualStyleBackColor = true;
      this.btnSerialConnectDisconnect.Click += new System.EventHandler(this.btnSerialConnectDisconnect_Click);
      // 
      // lblSerialPorts
      // 
      this.lblSerialPorts.AutoSize = true;
      this.lblSerialPorts.Location = new System.Drawing.Point(8, 0);
      this.lblSerialPorts.Name = "lblSerialPorts";
      this.lblSerialPorts.Size = new System.Drawing.Size(31, 13);
      this.lblSerialPorts.TabIndex = 1;
      this.lblSerialPorts.Text = "Ports";
      // 
      // cmbSerialPorts
      // 
      this.cmbSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSerialPorts.FormattingEnabled = true;
      this.cmbSerialPorts.Location = new System.Drawing.Point(48, 0);
      this.cmbSerialPorts.Name = "cmbSerialPorts";
      this.cmbSerialPorts.Size = new System.Drawing.Size(184, 21);
      this.cmbSerialPorts.TabIndex = 0;
      this.cmbSerialPorts.SelectedIndexChanged += new System.EventHandler(this.cmbSerialPorts_SelectedIndexChanged);
      // 
      // pnlControlPanel
      // 
      this.pnlControlPanel.Controls.Add(this.button2);
      this.pnlControlPanel.Controls.Add(this.txtInt);
      this.pnlControlPanel.Controls.Add(this.button1);
      this.pnlControlPanel.Controls.Add(this.txtResponse);
      this.pnlControlPanel.Enabled = false;
      this.pnlControlPanel.Location = new System.Drawing.Point(8, 48);
      this.pnlControlPanel.Name = "pnlControlPanel";
      this.pnlControlPanel.Size = new System.Drawing.Size(712, 488);
      this.pnlControlPanel.TabIndex = 1;
      // 
      // txtResponse
      // 
      this.txtResponse.Location = new System.Drawing.Point(168, 200);
      this.txtResponse.Name = "txtResponse";
      this.txtResponse.Size = new System.Drawing.Size(296, 168);
      this.txtResponse.TabIndex = 0;
      this.txtResponse.Text = "";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(264, 128);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(88, 32);
      this.button1.TabIndex = 1;
      this.button1.Text = "Send";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtInt
      // 
      this.txtInt.Location = new System.Drawing.Point(176, 136);
      this.txtInt.Name = "txtInt";
      this.txtInt.Size = new System.Drawing.Size(72, 20);
      this.txtInt.TabIndex = 2;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(168, 48);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(88, 32);
      this.button2.TabIndex = 3;
      this.button2.Text = "Send";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(916, 618);
      this.Controls.Add(this.pnlControlPanel);
      this.Controls.Add(this.pnlSerialConnection);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.pnlSerialConnection.ResumeLayout(false);
      this.pnlSerialConnection.PerformLayout();
      this.pnlControlPanel.ResumeLayout(false);
      this.pnlControlPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlSerialConnection;
    private System.Windows.Forms.ComboBox cmbSerialPorts;
    private System.Windows.Forms.Button btnSerialConnectDisconnect;
    private System.Windows.Forms.Label lblSerialPorts;
    private System.Windows.Forms.Panel pnlControlPanel;
    private System.Windows.Forms.TextBox txtInt;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.RichTextBox txtResponse;
    private System.Windows.Forms.Button button2;
  }
}

