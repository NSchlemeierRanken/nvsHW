namespace LB5_JobEstimate
{
    partial class Job_Estimate
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblDescription = new Label();
            lblHours = new Label();
            lblHourlyRate = new Label();
            lblTotal = new Label();
            txtDescription = new TextBox();
            txtHours = new TextBox();
            txtHourlyRate = new TextBox();
            btnUpdate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "New Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 19);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Current Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 65);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 112);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 3;
            label4.Text = "Hours to Complete";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 150);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 4;
            label5.Text = "Hourly Rate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 194);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "Total Fee";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(227, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(227, 109);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(39, 15);
            lblHours.TabIndex = 7;
            lblHours.Text = "Hours";
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.AutoSize = true;
            lblHourlyRate.Location = new Point(229, 150);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(69, 15);
            lblHourlyRate.TabIndex = 8;
            lblHourlyRate.Text = "Hourly Rate";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(227, 194);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(121, 65);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 10;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(121, 109);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(100, 23);
            txtHours.TabIndex = 11;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(121, 147);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(100, 23);
            txtHourlyRate.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(58, 286);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(146, 286);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(232, 286);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(121, 194);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 16;
            label11.Text = "-";
            // 
            // Job_Estimate
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(label11);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(txtHourlyRate);
            Controls.Add(txtHours);
            Controls.Add(txtDescription);
            Controls.Add(lblTotal);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblHours);
            Controls.Add(lblDescription);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Job_Estimate";
            Text = "Harold's Home Services";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblDescription;
        private Label lblHours;
        private Label lblHourlyRate;
        private Label lblTotal;
        private TextBox txtDescription;
        private TextBox txtHours;
        private TextBox txtHourlyRate;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnExit;
        private Label label11;
    }
}
