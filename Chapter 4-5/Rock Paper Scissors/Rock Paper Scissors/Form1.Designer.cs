namespace Rock_Paper_Scissors
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
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblRounds = new Label();
            lblUserScore = new Label();
            lblComputerScore = new Label();
            lblWinner = new Label();
            btnExit = new Button();
            btnPlayAgain = new Button();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(17, 24);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(75, 23);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(127, 24);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(75, 23);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(241, 24);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(75, 23);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // lblRounds
            // 
            lblRounds.AutoSize = true;
            lblRounds.Location = new Point(17, 78);
            lblRounds.Name = "lblRounds";
            lblRounds.Size = new Size(0, 15);
            lblRounds.TabIndex = 3;
            // 
            // lblUserScore
            // 
            lblUserScore.AutoSize = true;
            lblUserScore.Location = new Point(17, 125);
            lblUserScore.Name = "lblUserScore";
            lblUserScore.Size = new Size(83, 15);
            lblUserScore.TabIndex = 4;
            lblUserScore.Text = "Player Score: 0";
            // 
            // lblComputerScore
            // 
            lblComputerScore.AutoSize = true;
            lblComputerScore.Location = new Point(127, 125);
            lblComputerScore.Name = "lblComputerScore";
            lblComputerScore.Size = new Size(105, 15);
            lblComputerScore.TabIndex = 5;
            lblComputerScore.Text = "Computer Score: 0";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Location = new Point(17, 180);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(0, 15);
            lblWinner.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(17, 230);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(117, 230);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(75, 23);
            btnPlayAgain.TabIndex = 8;
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Visible = false;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 308);
            Controls.Add(btnPlayAgain);
            Controls.Add(btnExit);
            Controls.Add(lblWinner);
            Controls.Add(lblComputerScore);
            Controls.Add(lblUserScore);
            Controls.Add(lblRounds);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Rock Paper Scissors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblRounds;
        private Label lblUserScore;
        private Label lblComputerScore;
        private Label lblWinner;
        private Button btnExit;
        private Button btnPlayAgain;
    }
}
