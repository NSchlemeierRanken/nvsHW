namespace Sales_Windows_Form
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
            btnDanielle = new Button();
            btnEdward = new Button();
            btnFrancis = new Button();
            lblResults = new Label();
            txtAmount = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "How much was the sale?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 89);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Who made the sale?";
            // 
            // btnDanielle
            // 
            btnDanielle.Location = new Point(15, 116);
            btnDanielle.Name = "btnDanielle";
            btnDanielle.Size = new Size(75, 23);
            btnDanielle.TabIndex = 2;
            btnDanielle.Text = "Danielle";
            btnDanielle.UseVisualStyleBackColor = true;
            btnDanielle.Click += btnDanielle_Click;
            // 
            // btnEdward
            // 
            btnEdward.Location = new Point(113, 116);
            btnEdward.Name = "btnEdward";
            btnEdward.Size = new Size(75, 23);
            btnEdward.TabIndex = 3;
            btnEdward.Text = "Edward";
            btnEdward.UseVisualStyleBackColor = true;
            btnEdward.Click += btnEdward_Click;
            // 
            // btnFrancis
            // 
            btnFrancis.Location = new Point(211, 116);
            btnFrancis.Name = "btnFrancis";
            btnFrancis.Size = new Size(75, 23);
            btnFrancis.TabIndex = 4;
            btnFrancis.Text = "Francis";
            btnFrancis.UseVisualStyleBackColor = true;
            btnFrancis.Click += btnFrancis_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(17, 205);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 15);
            lblResults.TabIndex = 9;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(17, 42);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(171, 23);
            txtAmount.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(15, 346);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(btnExit);
            Controls.Add(txtAmount);
            Controls.Add(lblResults);
            Controls.Add(btnFrancis);
            Controls.Add(btnEdward);
            Controls.Add(btnDanielle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Home Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnDanielle;
        private Button btnEdward;
        private Button btnFrancis;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblResults;
        private TextBox txtAmount;
        private Button btnExit;
    }
}
