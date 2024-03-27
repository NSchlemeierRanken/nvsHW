namespace LB3
{
    partial class frmFancyStatement
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
            fancyListBox = new ListBox();
            SuspendLayout();
            // 
            // fancyListBox
            // 
            fancyListBox.BackColor = Color.Gold;
            fancyListBox.FormattingEnabled = true;
            fancyListBox.ItemHeight = 15;
            fancyListBox.Location = new Point(12, 12);
            fancyListBox.Name = "fancyListBox";
            fancyListBox.Size = new Size(304, 409);
            fancyListBox.TabIndex = 0;
            // 
            // frmFancyStatement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(328, 450);
            Controls.Add(fancyListBox);
            Name = "frmFancyStatement";
            Text = "GOLD STATEMENT";
            ResumeLayout(false);
        }

        #endregion

        private ListBox fancyListBox;
    }
}