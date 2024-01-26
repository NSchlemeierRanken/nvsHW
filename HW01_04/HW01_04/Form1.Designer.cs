namespace HW01_04
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
            textMiles = new TextBox();
            textDays = new TextBox();
            btnCalculate = new Button();
            lblTotalPrice = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 8);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Rental Car Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 35);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Days:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 35);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Miles:";
            // 
            // textMiles
            // 
            textMiles.Location = new Point(344, 53);
            textMiles.Name = "textMiles";
            textMiles.Size = new Size(100, 23);
            textMiles.TabIndex = 3;
            // 
            // textDays
            // 
            textDays.Location = new Point(20, 53);
            textDays.Name = "textDays";
            textDays.Size = new Size(100, 23);
            textDays.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(117, 96);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(229, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate!";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(205, 134);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 15);
            lblTotalPrice.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 175);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnCalculate);
            Controls.Add(textDays);
            Controls.Add(textMiles);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Rental Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textMiles;
        private TextBox textDays;
        private Button btnCalculate;
        private Label lblTotalPrice;
    }
}
