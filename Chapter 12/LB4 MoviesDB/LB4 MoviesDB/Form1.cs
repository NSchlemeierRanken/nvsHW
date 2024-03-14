namespace LB4_MoviesDB
{
    public partial class Movie_Database : Form
    {
        Movie[] movies = new Movie[]
        {
            new Movie("Fast and Furious", "Justin Lin", "A former cop and a street racer team up."),
            new Movie("Transformers", "Michael Bay", "An epic battle between robots."),
            new Movie("Dune", "Denis Villeneuve", "A war over the galaxy's most valuable asset."),
            new Movie("Avengers: Endgame", "Anthony and Joe Russo", "The Avengers team up to take down Thanos"),
            new Movie("Barbie", "Greta Gerwig", "Barbie and Ken explore the real world."),
            new Movie("Oppenheimer", "Christopher Nolan", "The story of the devlopment of the atomic bomb."),
            new Movie("Spider-Man: Across the Spider-Verse","Kemp Powers", "Miles Morales teams up to take on a new threat."),
            new Movie("The Dark Knight", "Christopher Nolan", "Batman takes on the Joker."),
            new Movie("Madame Web", "S.J. Clarkson", "Cassandra Web protects three young women."),
            new Movie("Trolls Band Together", "Walt Dohrn", "Poppy and Branch embark to save Branch's brother."),
        };
        public Movie_Database()
        {
            InitializeComponent();
        }

        public class Movie
        {
            public string Name { get; set; }
            public string Director { get; set; }
            public string Description { get; set; }

            public Movie(string name, string director, string description)
            {
                Name = name;
                Director = director;
                Description = description;
            }
        }

        private void SearchMovie(string query)
        {
            query = query.ToLower();
            foreach (var movie in movies)
            {
                if (movie.Name.ToLower().Contains(query) || movie.Director.ToLower().Contains(query))
                {
                    lblInfo.Text = $"Name: {movie.Name}\nDirector: {movie.Director}\nDescription: {movie.Description}";
                    return;
                }
            }
            lblInfo.Text = "Error: Movie not found.";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMovie(txtMovie.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMovie.Text = "";
            lblInfo.Text = "";
            txtMovie.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
