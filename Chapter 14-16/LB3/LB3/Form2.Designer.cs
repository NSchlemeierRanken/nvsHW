namespace LB3
{
    partial class frmStatement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            transactionsListBox = new ListBox();
            SuspendLayout();
            // 
            // transactionsListBox
            // 
            transactionsListBox.FormattingEnabled = true;
            transactionsListBox.ItemHeight = 15;
            transactionsListBox.Location = new Point(12, 12);
            transactionsListBox.Name = "transactionsListBox";
            transactionsListBox.Size = new Size(260, 424);
            transactionsListBox.TabIndex = 0;
            // 
            // frmStatement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 450);
            Controls.Add(transactionsListBox);
            Name = "frmStatement";
            Text = "Statement";
            ResumeLayout(false);
        }

        #endregion

        private ListBox transactionsListBox;
    }
}