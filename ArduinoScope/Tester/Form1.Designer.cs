namespace Tester
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
      this.btnCopyNormal = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.btnBlockCopy = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnCopyNormal
      // 
      this.btnCopyNormal.Location = new System.Drawing.Point(24, 24);
      this.btnCopyNormal.Name = "btnCopyNormal";
      this.btnCopyNormal.Size = new System.Drawing.Size(104, 48);
      this.btnCopyNormal.TabIndex = 0;
      this.btnCopyNormal.Text = "Copy Normal";
      this.btnCopyNormal.UseVisualStyleBackColor = true;
      this.btnCopyNormal.Click += new System.EventHandler(this.btnCopyNormal_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(200, 24);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(344, 384);
      this.richTextBox1.TabIndex = 1;
      this.richTextBox1.Text = "";
      this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
      // 
      // btnBlockCopy
      // 
      this.btnBlockCopy.Location = new System.Drawing.Point(24, 80);
      this.btnBlockCopy.Name = "btnBlockCopy";
      this.btnBlockCopy.Size = new System.Drawing.Size(104, 48);
      this.btnBlockCopy.TabIndex = 2;
      this.btnBlockCopy.Text = "Value Copy";
      this.btnBlockCopy.UseVisualStyleBackColor = true;
      this.btnBlockCopy.Click += new System.EventHandler(this.btnBlockCopy_Click);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(32, 192);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(104, 48);
      this.btnClear.TabIndex = 3;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(627, 429);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnBlockCopy);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.btnCopyNormal);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnCopyNormal;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button btnBlockCopy;
    private System.Windows.Forms.Button btnClear;
  }
}

