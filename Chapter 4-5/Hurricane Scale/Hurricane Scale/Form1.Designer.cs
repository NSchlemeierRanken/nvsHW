namespace Hurricane_Scale
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
            txtWind = new TextBox();
            btnEstimate = new Button();
            label2 = new Label();
            lblResult = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Wind Speed";
            // 
            // txtWind
            // 
            txtWind.Location = new Point(13, 40);
            txtWind.Name = "txtWind";
            txtWind.Size = new Size(100, 23);
            txtWind.TabIndex = 1;
            // 
            // btnEstimate
            // 
            btnEstimate.Location = new Point(133, 40);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(75, 23);
            btnEstimate.TabIndex = 2;
            btnEstimate.Text = "Estimate";
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 15);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(214, 42);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(133, 82);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 226);
            Controls.Add(btnExit);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(btnEstimate);
            Controls.Add(txtWind);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hurricane Scale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWind;
        private Button btnEstimate;
        private Label label2;
        private Label lblResult;
        private Button btnExit;
    }
}
