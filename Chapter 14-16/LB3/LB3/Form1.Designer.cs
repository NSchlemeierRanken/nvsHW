
namespace LB3
{
    partial class frmBank
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
            lblWelcome = new Label();
            lblBalance = new Label();
            lblType = new Label();
            lblDeposit = new Label();
            lblWithdraw = new Label();
            txtAccountNumber = new TextBox();
            txtPin = new TextBox();
            txtDeposit = new TextBox();
            txtWithdraw = new TextBox();
            btnLogin = new Button();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnStatement = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Account #";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 91);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Pin #";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(95, 147);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(57, 15);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome";
            lblWelcome.Visible = false;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(95, 187);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(48, 15);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "Balance";
            lblBalance.Visible = false;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(95, 226);
            lblType.Name = "lblType";
            lblType.Size = new Size(79, 15);
            lblType.TabIndex = 4;
            lblType.Text = "Account Type";
            lblType.Visible = false;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(22, 252);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(188, 15);
            lblDeposit.TabIndex = 5;
            lblDeposit.Text = "Would you like to make a deposit?";
            lblDeposit.Visible = false;
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Location = new Point(22, 308);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(207, 15);
            lblWithdraw.TabIndex = 6;
            lblWithdraw.Text = "Would you like to make a withdrawal?";
            lblWithdraw.Visible = false;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(90, 34);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(100, 23);
            txtAccountNumber.TabIndex = 7;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(90, 91);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(100, 23);
            txtPin.TabIndex = 8;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(22, 270);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(188, 23);
            txtDeposit.TabIndex = 9;
            txtDeposit.Visible = false;
            // 
            // txtWithdraw
            // 
            txtWithdraw.Location = new Point(22, 327);
            txtWithdraw.Name = "txtWithdraw";
            txtWithdraw.Size = new Size(188, 23);
            txtWithdraw.TabIndex = 10;
            txtWithdraw.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(225, 61);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(225, 269);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(75, 23);
            btnDeposit.TabIndex = 12;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Visible = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(225, 326);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(75, 23);
            btnWithdraw.TabIndex = 13;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Visible = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnStatement
            // 
            btnStatement.Location = new Point(145, 366);
            btnStatement.Name = "btnStatement";
            btnStatement.Size = new Size(111, 23);
            btnStatement.TabIndex = 14;
            btnStatement.Text = "Print Statement";
            btnStatement.UseVisualStyleBackColor = true;
            btnStatement.Visible = false;
            btnStatement.Click += btnStatement_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(164, 415);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnStatement);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(btnLogin);
            Controls.Add(txtWithdraw);
            Controls.Add(txtDeposit);
            Controls.Add(txtPin);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblWithdraw);
            Controls.Add(lblDeposit);
            Controls.Add(lblType);
            Controls.Add(lblBalance);
            Controls.Add(lblWelcome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBank";
            Text = "Bank";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private Label label2;
        private Label lblWelcome;
        private Label lblBalance;
        private Label lblType;
        private Label lblDeposit;
        private Label lblWithdraw;
        private TextBox txtAccountNumber;
        private TextBox txtPin;
        private TextBox txtDeposit;
        private TextBox txtWithdraw;
        private Button btnLogin;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnStatement;
        private Button btnLogout;
    }
}
