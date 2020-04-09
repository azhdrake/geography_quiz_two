namespace GeographyQuiz2
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
      this.components = new System.ComponentModel.Container();
      this.txtAnswer = new System.Windows.Forms.TextBox();
      this.btnSubmit = new System.Windows.Forms.Button();
      this.lblQuestion = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.lblTime = new System.Windows.Forms.Label();
      this.btnCheat = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtAnswer
      // 
      this.txtAnswer.Location = new System.Drawing.Point(40, 174);
      this.txtAnswer.MaxLength = 15;
      this.txtAnswer.Name = "txtAnswer";
      this.txtAnswer.Size = new System.Drawing.Size(189, 31);
      this.txtAnswer.TabIndex = 0;
      // 
      // btnSubmit
      // 
      this.btnSubmit.Location = new System.Drawing.Point(262, 169);
      this.btnSubmit.Name = "btnSubmit";
      this.btnSubmit.Size = new System.Drawing.Size(106, 40);
      this.btnSubmit.TabIndex = 1;
      this.btnSubmit.Text = "Submit";
      this.btnSubmit.UseVisualStyleBackColor = true;
      this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
      // 
      // lblQuestion
      // 
      this.lblQuestion.Location = new System.Drawing.Point(35, 41);
      this.lblQuestion.Name = "lblQuestion";
      this.lblQuestion.Size = new System.Drawing.Size(332, 128);
      this.lblQuestion.TabIndex = 2;
      this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.Location = new System.Drawing.Point(301, 238);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(66, 25);
      this.lblTime.TabIndex = 3;
      this.lblTime.Text = "00:00";
      this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnCheat
      // 
      this.btnCheat.Location = new System.Drawing.Point(40, 223);
      this.btnCheat.Name = "btnCheat";
      this.btnCheat.Size = new System.Drawing.Size(105, 40);
      this.btnCheat.TabIndex = 4;
      this.btnCheat.Text = "Cheat";
      this.btnCheat.UseVisualStyleBackColor = true;
      this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(388, 285);
      this.Controls.Add(this.btnCheat);
      this.Controls.Add(this.lblTime);
      this.Controls.Add(this.lblQuestion);
      this.Controls.Add(this.btnSubmit);
      this.Controls.Add(this.txtAnswer);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCheat;
    }
}

