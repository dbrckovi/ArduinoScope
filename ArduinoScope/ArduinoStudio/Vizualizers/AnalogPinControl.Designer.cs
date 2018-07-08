namespace ArduinoStudio
{
  partial class AnalogPinControl
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
      this.lblPinNumber = new System.Windows.Forms.Label();
      this.lblValue = new System.Windows.Forms.Label();
      this.smallGraph1 = new ArduinoStudio.SmallGraph();
      this.SuspendLayout();
      // 
      // lblPinNumber
      // 
      this.lblPinNumber.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblPinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPinNumber.Location = new System.Drawing.Point(2, 2);
      this.lblPinNumber.Name = "lblPinNumber";
      this.lblPinNumber.Size = new System.Drawing.Size(22, 30);
      this.lblPinNumber.TabIndex = 0;
      this.lblPinNumber.Text = "12";
      this.lblPinNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblValue
      // 
      this.lblValue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblValue.Location = new System.Drawing.Point(24, 2);
      this.lblValue.Name = "lblValue";
      this.lblValue.Size = new System.Drawing.Size(61, 30);
      this.lblValue.TabIndex = 1;
      this.lblValue.Text = "1023";
      this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // smallGraph1
      // 
      this.smallGraph1.Dock = System.Windows.Forms.DockStyle.Right;
      this.smallGraph1.Location = new System.Drawing.Point(85, 2);
      this.smallGraph1.Name = "smallGraph1";
      this.smallGraph1.Size = new System.Drawing.Size(45, 30);
      this.smallGraph1.TabIndex = 2;
      // 
      // AnalogPinControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.lblValue);
      this.Controls.Add(this.smallGraph1);
      this.Controls.Add(this.lblPinNumber);
      this.Name = "AnalogPinControl";
      this.Padding = new System.Windows.Forms.Padding(2);
      this.Size = new System.Drawing.Size(132, 34);
      this.Load += new System.EventHandler(this.AnalogPinControl_Load);
      this.SizeChanged += new System.EventHandler(this.AnalogPinControl_SizeChanged);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.AnalogPinControl_Paint);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblPinNumber;
    private System.Windows.Forms.Label lblValue;
    private SmallGraph smallGraph1;
  }
}
