namespace VectorFontEditor
{
  partial class frmEditor
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
      this.pnlEditor = new System.Windows.Forms.Panel();
      this.lblLogicalCoordinate = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtCharacter = new System.Windows.Forms.TextBox();
      this.pnlPreview = new System.Windows.Forms.Panel();
      this.fontTester1 = new VectorFontEditor.FontTester();
      this.SuspendLayout();
      // 
      // pnlEditor
      // 
      this.pnlEditor.BackColor = System.Drawing.Color.White;
      this.pnlEditor.Enabled = false;
      this.pnlEditor.Location = new System.Drawing.Point(8, 64);
      this.pnlEditor.Name = "pnlEditor";
      this.pnlEditor.Size = new System.Drawing.Size(400, 600);
      this.pnlEditor.TabIndex = 0;
      this.pnlEditor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditor_Paint);
      this.pnlEditor.MouseEnter += new System.EventHandler(this.pnlEditor_MouseEnter);
      this.pnlEditor.MouseLeave += new System.EventHandler(this.pnlEditor_MouseLeave);
      this.pnlEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlEditor_MouseMove);
      this.pnlEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlEditor_MouseUp);
      // 
      // lblLogicalCoordinate
      // 
      this.lblLogicalCoordinate.AutoSize = true;
      this.lblLogicalCoordinate.Location = new System.Drawing.Point(8, 680);
      this.lblLogicalCoordinate.Name = "lblLogicalCoordinate";
      this.lblLogicalCoordinate.Size = new System.Drawing.Size(35, 13);
      this.lblLogicalCoordinate.TabIndex = 1;
      this.lblLogicalCoordinate.Text = "label1";
      // 
      // btnSave
      // 
      this.btnSave.Enabled = false;
      this.btnSave.Location = new System.Drawing.Point(96, 8);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(104, 24);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtCharacter
      // 
      this.txtCharacter.Location = new System.Drawing.Point(16, 8);
      this.txtCharacter.MaxLength = 1;
      this.txtCharacter.Name = "txtCharacter";
      this.txtCharacter.ReadOnly = true;
      this.txtCharacter.Size = new System.Drawing.Size(72, 20);
      this.txtCharacter.TabIndex = 3;
      this.txtCharacter.TextChanged += new System.EventHandler(this.txtCharacter_TextChanged);
      this.txtCharacter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCharacter_KeyPress);
      // 
      // pnlPreview
      // 
      this.pnlPreview.Location = new System.Drawing.Point(288, 8);
      this.pnlPreview.Name = "pnlPreview";
      this.pnlPreview.Size = new System.Drawing.Size(16, 24);
      this.pnlPreview.TabIndex = 4;
      // 
      // fontTester1
      // 
      this.fontTester1.Location = new System.Drawing.Point(432, 24);
      this.fontTester1.Name = "fontTester1";
      this.fontTester1.Size = new System.Drawing.Size(536, 352);
      this.fontTester1.TabIndex = 5;
      // 
      // frmEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(969, 733);
      this.Controls.Add(this.fontTester1);
      this.Controls.Add(this.pnlPreview);
      this.Controls.Add(this.txtCharacter);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.lblLogicalCoordinate);
      this.Controls.Add(this.pnlEditor);
      this.Name = "frmEditor";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditor_FormClosing);
      this.Load += new System.EventHandler(this.frmEditor_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlEditor;
    private System.Windows.Forms.Label lblLogicalCoordinate;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtCharacter;
    private System.Windows.Forms.Panel pnlPreview;
    private FontTester fontTester1;
  }
}

