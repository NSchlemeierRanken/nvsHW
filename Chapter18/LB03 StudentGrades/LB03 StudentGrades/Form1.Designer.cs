namespace LB03_StudentGrades
{
    partial class frmStudentGrades
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
            lblStudentName = new Label();
            lblLabGrade = new Label();
            lblTestGrade = new Label();
            lblOverallGrade = new Label();
            txtStudentName = new TextBox();
            btnSearch = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(22, 76);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(86, 15);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name:";
            // 
            // lblLabGrade
            // 
            lblLabGrade.AutoSize = true;
            lblLabGrade.Location = new Point(22, 121);
            lblLabGrade.Name = "lblLabGrade";
            lblLabGrade.Size = new Size(63, 15);
            lblLabGrade.TabIndex = 2;
            lblLabGrade.Text = "Lab Grade:";
            // 
            // lblTestGrade
            // 
            lblTestGrade.AutoSize = true;
            lblTestGrade.Location = new Point(22, 162);
            lblTestGrade.Name = "lblTestGrade";
            lblTestGrade.Size = new Size(64, 15);
            lblTestGrade.TabIndex = 3;
            lblTestGrade.Text = "Test Grade:";
            // 
            // lblOverallGrade
            // 
            lblOverallGrade.AutoSize = true;
            lblOverallGrade.Location = new Point(22, 215);
            lblOverallGrade.Name = "lblOverallGrade";
            lblOverallGrade.Size = new Size(81, 15);
            lblOverallGrade.TabIndex = 4;
            lblOverallGrade.Text = "Overall Grade:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(127, 28);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(122, 23);
            txtStudentName.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(280, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(280, 72);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmStudentGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 302);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(txtStudentName);
            Controls.Add(lblOverallGrade);
            Controls.Add(lblTestGrade);
            Controls.Add(lblLabGrade);
            Controls.Add(lblStudentName);
            Controls.Add(label1);
            Name = "frmStudentGrades";
            Text = "Student Grades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStudentName;
        private Label lblLabGrade;
        private Label lblTestGrade;
        private Label lblOverallGrade;
        private TextBox txtStudentName;
        private Button btnSearch;
        private Button btnExit;
    }
}
