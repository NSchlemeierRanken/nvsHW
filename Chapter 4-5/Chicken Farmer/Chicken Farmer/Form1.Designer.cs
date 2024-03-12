namespace Chicken_Farmer
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
            txtEgg1 = new TextBox();
            txtEgg2 = new TextBox();
            txtEgg3 = new TextBox();
            txtEgg4 = new TextBox();
            btnCalc = new Button();
            lblResult = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 36);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter number of eggs laid by each chicken";
            // 
            // txtEgg1
            // 
            txtEgg1.Location = new Point(40, 81);
            txtEgg1.Name = "txtEgg1";
            txtEgg1.Size = new Size(100, 23);
            txtEgg1.TabIndex = 1;
            // 
            // txtEgg2
            // 
            txtEgg2.Location = new Point(190, 81);
            txtEgg2.Name = "txtEgg2";
            txtEgg2.Size = new Size(100, 23);
            txtEgg2.TabIndex = 2;
            // 
            // txtEgg3
            // 
            txtEgg3.Location = new Point(345, 81);
            txtEgg3.Name = "txtEgg3";
            txtEgg3.Size = new Size(100, 23);
            txtEgg3.TabIndex = 3;
            // 
            // txtEgg4
            // 
            txtEgg4.Location = new Point(489, 81);
            txtEgg4.Name = "txtEgg4";
            txtEgg4.Size = new Size(100, 23);
            txtEgg4.TabIndex = 4;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(215, 174);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(215, 244);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(345, 174);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 371);
            Controls.Add(btnExit);
            Controls.Add(lblResult);
            Controls.Add(btnCalc);
            Controls.Add(txtEgg4);
            Controls.Add(txtEgg3);
            Controls.Add(txtEgg2);
            Controls.Add(txtEgg1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Chicken Farmer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEgg1;
        private TextBox txtEgg2;
        private TextBox txtEgg3;
        private TextBox txtEgg4;
        private Button btnCalc;
        private Label lblResult;
        private Button btnExit;
    }
}
