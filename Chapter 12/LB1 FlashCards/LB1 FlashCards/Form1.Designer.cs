namespace LB1_FlashCards
{
    partial class Flash_Cards
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
            lblDefinition = new Label();
            txtSearch = new TextBox();
            txtAdd = new TextBox();
            btnDefine = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 0;
            label1.Text = "What term do you want me to define?";
            // 
            // lblDefinition
            // 
            lblDefinition.AutoSize = true;
            lblDefinition.Font = new Font("Segoe UI", 12F);
            lblDefinition.Location = new Point(21, 137);
            lblDefinition.Name = "lblDefinition";
            lblDefinition.Size = new Size(0, 21);
            lblDefinition.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(22, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 23);
            txtSearch.TabIndex = 2;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(21, 166);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(207, 23);
            txtAdd.TabIndex = 3;
            txtAdd.Visible = false;
            // 
            // btnDefine
            // 
            btnDefine.Location = new Point(238, 37);
            btnDefine.Name = "btnDefine";
            btnDefine.Size = new Size(75, 23);
            btnDefine.TabIndex = 4;
            btnDefine.Text = "Define";
            btnDefine.UseVisualStyleBackColor = true;
            btnDefine.Click += btnDefine_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(238, 165);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(319, 37);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(400, 37);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Flash_Cards
            // 
            AcceptButton = btnDefine;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 373);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnDefine);
            Controls.Add(txtAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblDefinition);
            Controls.Add(label1);
            Name = "Flash_Cards";
            Text = "Flash Cards";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private TextBox txtAdd;
        private Button btnDefine;
        private Button btnAdd;
        private Button btnClear;
        private Button btnExit;
        private Label lblDefinition;
    }
}
