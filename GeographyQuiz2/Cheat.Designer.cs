namespace GeographyQuiz2
{
  partial class Cheat
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
      this.btnLazy = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.lblCheatAnswer = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnLazy
      // 
      this.btnLazy.Location = new System.Drawing.Point(12, 133);
      this.btnLazy.Name = "btnLazy";
      this.btnLazy.Size = new System.Drawing.Size(123, 41);
      this.btnLazy.TabIndex = 0;
      this.btnLazy.Text = "I\'m Lazy";
      this.btnLazy.UseVisualStyleBackColor = true;
      this.btnLazy.Click += new System.EventHandler(this.btnLazy_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(141, 133);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(110, 41);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lblCheatAnswer
      // 
      this.lblCheatAnswer.Location = new System.Drawing.Point(12, 9);
      this.lblCheatAnswer.Name = "lblCheatAnswer";
      this.lblCheatAnswer.Size = new System.Drawing.Size(227, 106);
      this.lblCheatAnswer.TabIndex = 2;
      // 
      // Cheat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(273, 187);
      this.Controls.Add(this.lblCheatAnswer);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnLazy);
      this.Name = "Cheat";
      this.Text = "Cheat";
      this.Load += new System.EventHandler(this.Cheat_Load);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button btnLazy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCheatAnswer;
    }
}