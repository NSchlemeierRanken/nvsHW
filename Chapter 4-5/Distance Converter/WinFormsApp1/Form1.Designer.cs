namespace WinFormsApp1
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
            txtMiles = new TextBox();
            txtKm = new TextBox();
            btnConvertKm = new Button();
            btnConvertMiles = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Distance in miles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 18);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Distance in kilometers";
            // 
            // txtMiles
            // 
            txtMiles.Location = new Point(19, 39);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(100, 23);
            txtMiles.TabIndex = 2;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(189, 39);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(120, 23);
            txtKm.TabIndex = 3;
            // 
            // btnConvertKm
            // 
            btnConvertKm.Location = new Point(19, 117);
            btnConvertKm.Name = "btnConvertKm";
            btnConvertKm.Size = new Size(104, 23);
            btnConvertKm.TabIndex = 4;
            btnConvertKm.Text = "Convert to km";
            btnConvertKm.UseVisualStyleBackColor = true;
            btnConvertKm.Click += btnConvertKm_Click;
            // 
            // btnConvertMiles
            // 
            btnConvertMiles.Location = new Point(189, 117);
            btnConvertMiles.Name = "btnConvertMiles";
            btnConvertMiles.Size = new Size(123, 23);
            btnConvertMiles.TabIndex = 5;
            btnConvertMiles.Text = "Convert to miles";
            btnConvertMiles.UseVisualStyleBackColor = true;
            btnConvertMiles.Click += btnConvertMiles_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(19, 195);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 294);
            Controls.Add(lblResult);
            Controls.Add(btnConvertMiles);
            Controls.Add(btnConvertKm);
            Controls.Add(txtKm);
            Controls.Add(txtMiles);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMiles;
        private TextBox txtKm;
        private Button btnConvertKm;
        private Button btnConvertMiles;
        private Label lblResult;
    }
}
