namespace WindowsFormsApplication1 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.urlTextBox = new System.Windows.Forms.TextBox();
      this.contentTextBox = new System.Windows.Forms.TextBox();
      this.selectorTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "URL";
      // 
      // urlTextBox
      // 
      this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.urlTextBox.Location = new System.Drawing.Point(143, 40);
      this.urlTextBox.Name = "urlTextBox";
      this.urlTextBox.Size = new System.Drawing.Size(900, 31);
      this.urlTextBox.TabIndex = 1;
      this.urlTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyDown);
      // 
      // contentTextBox
      // 
      this.contentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.contentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.contentTextBox.Location = new System.Drawing.Point(12, 149);
      this.contentTextBox.Multiline = true;
      this.contentTextBox.Name = "contentTextBox";
      this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.contentTextBox.Size = new System.Drawing.Size(1031, 616);
      this.contentTextBox.TabIndex = 4;
      // 
      // selectorTextBox
      // 
      this.selectorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.selectorTextBox.Location = new System.Drawing.Point(143, 86);
      this.selectorTextBox.Name = "selectorTextBox";
      this.selectorTextBox.Size = new System.Drawing.Size(900, 31);
      this.selectorTextBox.TabIndex = 3;
      this.selectorTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.selectorTextBox_KeyDown);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 86);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 25);
      this.label2.TabIndex = 2;
      this.label2.Text = "Selector";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1055, 777);
      this.Controls.Add(this.selectorTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.contentTextBox);
      this.Controls.Add(this.urlTextBox);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox urlTextBox;
    private System.Windows.Forms.TextBox contentTextBox;
    private System.Windows.Forms.TextBox selectorTextBox;
    private System.Windows.Forms.Label label2;
  }
}

