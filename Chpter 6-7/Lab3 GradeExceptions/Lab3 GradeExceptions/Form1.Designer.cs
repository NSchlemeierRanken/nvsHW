namespace Lab3_GradeExceptions
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
            label3 = new Label();
            lblResult = new Label();
            txtTest1 = new TextBox();
            txtTest2 = new TextBox();
            txtTest3 = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 33);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Test #1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 88);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Test #2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 128);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Test #3:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(157, 181);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(113, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Text Average/Grade:";
            // 
            // txtTest1
            // 
            txtTest1.Location = new Point(271, 33);
            txtTest1.Name = "txtTest1";
            txtTest1.Size = new Size(100, 23);
            txtTest1.TabIndex = 4;
            // 
            // txtTest2
            // 
            txtTest2.Location = new Point(271, 80);
            txtTest2.Name = "txtTest2";
            txtTest2.Size = new Size(100, 23);
            txtTest2.TabIndex = 5;
            // 
            // txtTest3
            // 
            txtTest3.Location = new Point(271, 128);
            txtTest3.Name = "txtTest3";
            txtTest3.Size = new Size(100, 23);
            txtTest3.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(32, 229);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(85, 33);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(157, 229);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 33);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(271, 229);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 33);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 274);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtTest3);
            Controls.Add(txtTest2);
            Controls.Add(txtTest1);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Grade Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResult;
        private TextBox txtTest1;
        private TextBox txtTest2;
        private TextBox txtTest3;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
