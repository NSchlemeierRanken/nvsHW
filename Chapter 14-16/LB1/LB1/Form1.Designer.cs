namespace LB1
{
    partial class frmLetterDelivery
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
            txtRecipient = new TextBox();
            txtDate = new TextBox();
            txtTracking = new TextBox();
            btnSend = new Button();
            logListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Recipient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 65);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Sent Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 130);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Tracking Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(17, 202);
            label4.Name = "label4";
            label4.Size = new Size(243, 21);
            label4.TabIndex = 3;
            label4.Text = "(Additional Fee for certified letter)";
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(120, 18);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(100, 23);
            txtRecipient.TabIndex = 5;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(120, 65);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(100, 23);
            txtDate.TabIndex = 6;
            // 
            // txtTracking
            // 
            txtTracking.Location = new Point(120, 130);
            txtTracking.Name = "txtTracking";
            txtTracking.Size = new Size(100, 23);
            txtTracking.TabIndex = 7;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(120, 253);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 23);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 15;
            logListBox.Location = new Point(278, 18);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(510, 424);
            logListBox.TabIndex = 9;
            // 
            // frmLetterDelivery
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logListBox);
            Controls.Add(btnSend);
            Controls.Add(txtTracking);
            Controls.Add(txtDate);
            Controls.Add(txtRecipient);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLetterDelivery";
            Text = "Letter Delivery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRecipient;
        private TextBox txtDate;
        private TextBox txtTracking;
        private Button btnSend;
        private ListBox logListBox;
    }
}
