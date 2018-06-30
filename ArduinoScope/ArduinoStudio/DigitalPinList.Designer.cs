namespace ArduinoStudio
{
  partial class DigitalPinList
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
      this.grpPins = new System.Windows.Forms.GroupBox();
      this.SuspendLayout();
      // 
      // grpPins
      // 
      this.grpPins.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpPins.Location = new System.Drawing.Point(0, 0);
      this.grpPins.Name = "grpPins";
      this.grpPins.Size = new System.Drawing.Size(948, 477);
      this.grpPins.TabIndex = 0;
      this.grpPins.TabStop = false;
      this.grpPins.Text = "Digital Pins";
      // 
      // DigitalPinList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.grpPins);
      this.Name = "DigitalPinList";
      this.Size = new System.Drawing.Size(948, 477);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpPins;
  }
}
