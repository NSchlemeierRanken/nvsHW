namespace LB6_TileEstimate
{
    partial class Tiling_Estimator
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
            txtName = new TextBox();
            txtWidth = new TextBox();
            txtLength = new TextBox();
            btnAdd = new Button();
            lblRoom = new Label();
            lblBoxes = new Label();
            lblResults = new Label();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 21);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Width";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 21);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Length";
            // 
            // txtName
            // 
            txtName.Location = new Point(11, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(118, 50);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 4;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(229, 50);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(365, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(11, 118);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(73, 15);
            lblRoom.TabIndex = 7;
            lblRoom.Text = "Rooms: 0/20";
            // 
            // lblBoxes
            // 
            lblBoxes.AutoSize = true;
            lblBoxes.Location = new Point(11, 159);
            lblBoxes.Name = "lblBoxes";
            lblBoxes.Size = new Size(122, 15);
            lblBoxes.TabIndex = 8;
            lblBoxes.Text = "Total Boxes Needed: 0";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(11, 231);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(44, 15);
            lblResults.TabIndex = 9;
            lblResults.Text = "Results";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(462, 50);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(562, 50);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Tiling_Estimator
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 420);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(lblResults);
            Controls.Add(lblBoxes);
            Controls.Add(lblRoom);
            Controls.Add(btnAdd);
            Controls.Add(txtLength);
            Controls.Add(txtWidth);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tiling_Estimator";
            Text = "Tiling Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtWidth;
        private TextBox txtLength;
        private Button btnAdd;
        private Label lblRoom;
        private Label lblBoxes;
        private Label lblResults;
        private Button btnClear;
        private Button btnExit;
    }
}
