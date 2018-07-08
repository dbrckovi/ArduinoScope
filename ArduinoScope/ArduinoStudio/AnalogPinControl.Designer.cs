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
      this.SuspendLayout();
      // 
      // lblPinNumber
      // 
      this.lblPinNumber.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblPinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPinNumber.Location = new System.Drawing.Point(2, 2);
      this.lblPinNumber.Name = "lblPinNumber";
      this.lblPinNumber.Size = new System.Drawing.Size(30, 15);
      this.lblPinNumber.TabIndex = 0;
      this.lblPinNumber.Text = "0";
      this.lblPinNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblValue
      // 
      this.lblValue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblValue.Location = new System.Drawing.Point(32, 2);
      this.lblValue.Name = "lblValue";
      this.lblValue.Size = new System.Drawing.Size(59, 15);
      this.lblValue.TabIndex = 1;
      this.lblValue.Text = "0";
      this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // AnalogPinControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Controls.Add(this.lblValue);
      this.Controls.Add(this.lblPinNumber);
      this.Name = "AnalogPinControl";
      this.Padding = new System.Windows.Forms.Padding(2);
      this.Size = new System.Drawing.Size(93, 19);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblPinNumber;
    private System.Windows.Forms.Label lblValue;
  }
}
