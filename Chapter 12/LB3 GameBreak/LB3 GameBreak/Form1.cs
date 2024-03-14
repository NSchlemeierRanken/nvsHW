using System.Diagnostics.Eventing.Reader;

namespace LB3_GameBreak
{
    public partial class Game_Break : Form
    {
        public Game_Break()
        {
            InitializeComponent();
        }

        public class Game
        {
            public string Name { get; set; }
            public string Publisher { get; set; }
            public float Price { get; set; }

            public Game(string name, string publisher, float price)
            {
                Name = name;
                Publisher = publisher;
                Price = price;
            }
        }

        List<Game> games = new List<Game>
        {
            new Game("Player Unknown's Battlegrounds (PUBG)", "Bluehole", 35),
            new Game("League of Legends", "Riot Games", 0),
            new Game ("Call of Duty: Black Ops III", "Activision", 60),
            new Game("Battlefield 4", "Electronic Arts (EA)", 20),
            new Game("Super Mario Odyssey", "Nintendo", 60),
        };

        private int SearchForGame(string query)
        {
            string lowerCaseQuery = query.ToLower();

            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Name.ToLower().Contains(lowerCaseQuery) ||
                    games[i].Publisher.ToLower().Contains(lowerCaseQuery))
                {
                    return i;
                }
            }
            return -1;
        }

        private void ShowGameInfo(int index)
        {
            if (index != -1)
            {
                Game game = games[index];
                lblInfo.Text = $"Name: {game.Name}\nPublisher: {game.Publisher}\nPrice: {game.Price.ToString("C")}";
            }
            else
            {
                lblInfo.Text = "Error: Game not found.";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            int index = SearchForGame(query);
            ShowGameInfo(index);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            lblInfo.Text = "";
            txtSearch.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
