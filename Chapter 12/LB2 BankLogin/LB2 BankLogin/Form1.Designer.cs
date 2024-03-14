namespace LB2_BankLogin
{
    partial class Bank_Login
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
            txtAccount = new TextBox();
            txtPin = new TextBox();
            txtDeposit = new TextBox();
            txtWithdraw = new TextBox();
            btnLogin = new Button();
            btnLogout = new Button();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            lblMessage = new Label();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Account #";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Pin #";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 201);
            label3.Name = "label3";
            label3.Size = new Size(188, 15);
            label3.TabIndex = 2;
            label3.Text = "Would you like to make a deposit?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 296);
            label4.Name = "label4";
            label4.Size = new Size(207, 15);
            label4.TabIndex = 3;
            label4.Text = "Would you like to make a withdrawal?";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(78, 14);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(100, 23);
            txtAccount.TabIndex = 4;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(78, 62);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(100, 23);
            txtPin.TabIndex = 5;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(10, 219);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(132, 23);
            txtDeposit.TabIndex = 6;
            // 
            // txtWithdraw
            // 
            txtWithdraw.Location = new Point(10, 314);
            txtWithdraw.Name = "txtWithdraw";
            txtWithdraw.Size = new Size(134, 23);
            txtWithdraw.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(199, 37);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(21, 397);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(157, 219);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(75, 23);
            btnDeposit.TabIndex = 10;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(157, 314);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(75, 23);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(75, 153);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 12;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(123, 397);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(231, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Bank_Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(lblMessage);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Controls.Add(txtWithdraw);
            Controls.Add(txtDeposit);
            Controls.Add(txtPin);
            Controls.Add(txtAccount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bank_Login";
            Text = "Weyland Bank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAccount;
        private TextBox txtPin;
        private TextBox txtDeposit;
        private TextBox txtWithdraw;
        private Button btnLogin;
        private Button btnLogout;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Label lblMessage;
        private Button btnClear;
        private Button btnExit;
    }
}
