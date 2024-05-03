namespace Lab4_PayrollValidator
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
            lblResult = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtHours = new TextBox();
            txtRate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee Hours Worked:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 83);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Employee Hourly Rate:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(35, 131);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(116, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Employee Gross Pay:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(30, 184);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(149, 184);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(262, 184);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(182, 38);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(100, 23);
            txtHours.TabIndex = 6;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(182, 83);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 242);
            Controls.Add(txtRate);
            Controls.Add(txtHours);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Employee Payroll Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblResult;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtHours;
        private TextBox txtRate;
    }
}
