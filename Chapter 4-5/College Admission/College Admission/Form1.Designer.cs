namespace College_Admission
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtGpa = new TextBox();
            txtScore = new TextBox();
            btnAdmit = new Button();
            lblResult = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "GPA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 24);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Admission Test Score";
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(22, 52);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(100, 23);
            txtGpa.TabIndex = 2;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(151, 52);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(118, 23);
            txtScore.TabIndex = 3;
            // 
            // btnAdmit
            // 
            btnAdmit.Location = new Point(22, 106);
            btnAdmit.Name = "btnAdmit";
            btnAdmit.Size = new Size(75, 23);
            btnAdmit.TabIndex = 4;
            btnAdmit.Text = "Admit";
            btnAdmit.UseVisualStyleBackColor = true;
            btnAdmit.Click += btnAdmit_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(124, 110);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "label3";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(22, 147);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 238);
            Controls.Add(btnExit);
            Controls.Add(lblResult);
            Controls.Add(btnAdmit);
            Controls.Add(txtScore);
            Controls.Add(txtGpa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "College Admission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtGpa;
        private TextBox txtScore;
        private Button btnAdmit;
        private Label lblResult;
        private Button btnExit;
    }
}
