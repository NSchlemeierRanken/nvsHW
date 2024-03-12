namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int userScore = 0;
        int computerScore = 0;
        int roundsPlayed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private string GetComputerChoice()
        {
            int choice = rand.Next(1, 4);
            return choice switch
            {
                1 => "Rock",
                2 => "Paper",
                3 => "Scissors",
                _ => "Rock",
            };
        }
        private void EvaluateRound(string userChoice)
        {
            string computerChoice = GetComputerChoice();
            roundsPlayed++;

            if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                (userChoice == "Paper" && computerChoice == "Rock") ||
                (userChoice == "Scissors" && computerChoice == "Paper"))
            {
                userScore++;
                lblRounds.Text = $"Round {roundsPlayed}: You win! {userChoice} beats {computerChoice}";
            }
            else if (userChoice == computerChoice)
            {
                lblRounds.Text = $"Round {roundsPlayed}: It's a tie. Both chose {userChoice}";
            }
            else
            {
                computerScore++;
                lblRounds.Text = $"Round {roundsPlayed}: You lose! {computerChoice} beats {userChoice}";
            }

            lblUserScore.Text = $"Player Score: {userScore}";
            lblComputerScore.Text = $"Computer Score: {computerScore}";

            if (roundsPlayed == 3)
            {
                string winner = userScore > computerScore ? "You win the game!" : computerScore > userScore ? "Computer wins the game!" : "The game is a tie!";
                lblWinner.Text = winner;
                DisableGameButtons();
                btnPlayAgain.Visible = true;
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            EvaluateRound("Rock");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            EvaluateRound("Paper");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            EvaluateRound("Scissors");
        }

        private void DisableGameButtons()
        {
            btnRock.Enabled = false;
            btnPaper.Enabled = false;
            btnScissors.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            userScore = 0;
            computerScore = 0;
            roundsPlayed = 0;

            lblUserScore.Text = "User Score: 0";
            lblComputerScore.Text = "Computer Score: 0";
            lblWinner.Text = "";
            lblRounds.Text = "";
            btnPlayAgain.Visible = false;

            EnableGameButtons();
        }

        private void EnableGameButtons()
        {
            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
        }
    }
}
