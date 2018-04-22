namespace VectorFontEditor
{
  partial class FontTester
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtSource = new System.Windows.Forms.TextBox();
      this.numScale = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(16, 48);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(616, 320);
      this.panel1.TabIndex = 0;
      // 
      // txtSource
      // 
      this.txtSource.Font = new System.Drawing.Font("Courier New", 8.25F);
      this.txtSource.Location = new System.Drawing.Point(16, 8);
      this.txtSource.Name = "txtSource";
      this.txtSource.Size = new System.Drawing.Size(392, 20);
      this.txtSource.TabIndex = 1;
      this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
      // 
      // numScale
      // 
      this.numScale.Location = new System.Drawing.Point(432, 8);
      this.numScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.numScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numScale.Name = "numScale";
      this.numScale.Size = new System.Drawing.Size(88, 20);
      this.numScale.TabIndex = 2;
      this.numScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numScale.ValueChanged += new System.EventHandler(this.numScale_ValueChanged);
      // 
      // FontTester
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.numScale);
      this.Controls.Add(this.txtSource);
      this.Controls.Add(this.panel1);
      this.Name = "FontTester";
      this.Size = new System.Drawing.Size(668, 389);
      ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtSource;
    private System.Windows.Forms.NumericUpDown numScale;
  }
}
