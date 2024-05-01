namespace LB01_SongSearch
{
    partial class FrmSongSearch
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
            lblSearch = new Label();
            listBoxResults = new ListBox();
            comboBoxSearchType = new ComboBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F);
            lblSearch.Location = new Point(36, 28);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(103, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Searching By:";
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(36, 61);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(483, 364);
            listBoxResults.TabIndex = 1;
            // 
            // comboBoxSearchType
            // 
            comboBoxSearchType.FormattingEnabled = true;
            comboBoxSearchType.Location = new Point(575, 28);
            comboBoxSearchType.Name = "comboBoxSearchType";
            comboBoxSearchType.Size = new Size(190, 23);
            comboBoxSearchType.TabIndex = 2;
            comboBoxSearchType.SelectedIndexChanged += comboBoxSearchType_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(575, 181);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(190, 52);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(575, 259);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 40);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(575, 327);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(575, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(190, 23);
            txtSearch.TabIndex = 6;
            // 
            // FrmSongSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(comboBoxSearchType);
            Controls.Add(listBoxResults);
            Controls.Add(lblSearch);
            Name = "FrmSongSearch";
            Text = "SongSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private ListBox listBoxResults;
        private ComboBox comboBoxSearchType;
        private Button btnSearch;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtSearch;
    }
}
