namespace LB01_SongSearch
{
    public partial class FrmSongSearch : Form
    {
        private List<Song> songs;
        public FrmSongSearch()
        {
            InitializeComponent();
            InitializeSongs();
            SetupComboBox();
        }

        private void InitializeSongs()
        {
            songs = new List<Song>
            {
                new Song("Shape of You", "Ed Sheeran", "Pop"),
                new Song("Super Bass", "Nicki Minaj", "Pop"),
                new Song("Hotline Bling", "Drake", "Hip-Hop/Rap"),
                new Song("Believer", "Imagine Dragons", "Rock"),
                new Song("Blinding Lights", "The Weeknd", "R&B/Soul"),
                new Song("Domino", "Jessie J", "Pop"),
                new Song("That's My Kinda Night", "Luke Bryan", "Country"),
                new Song("TEXAS HOLD 'EM", "Beyonce", "Country"),
                new Song("Thinkin' Bout Me", "Morgan Wallen", "Country"),
                new Song("How Deep is Your Love", "Bee Gees", "Soft Rock"),
                new Song("You Give Love a Bad Name", "Bon Jovi", "Hard Rock"),
                new Song("Party In The U.S.A", "Miley Cyrus", "Pop"),
                new Song("Firework", "Katy Perry", "Pop"),
                new Song("We Found Love (feat. Calvin Harris)", "Rhianna", "Pop"),
                new Song("Summer", "Calvin Harris", "Dance"),
                new Song("Let's Go (feat. Ne-Yo)", "Calvin Harris", "R&B/Soul"),
            };
        }

        private void SetupComboBox()
        {
            comboBoxSearchType.Items.AddRange(new string[] { "Name", "Artist", "Genre" });
            comboBoxSearchType.SelectedIndex = 0; // Default to 'Name'
        }



        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxSearchType.SelectedIndex = 0;
            listBoxResults.Items.Clear();
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchType = comboBoxSearchType.SelectedItem.ToString();
            string searchTerm = txtSearch.Text.ToLower();

            var filteredSongs = songs.Where(song =>
            {
                switch (searchType)
                {
                    case "Name":
                        return song.Name.ToLower().Contains(searchTerm);
                    case "Artist":
                        return song.Artist.ToLower().Contains(searchTerm);
                    case "Genre":
                        return song.Genre.ToLower().Contains(searchTerm);
                    default:
                        return false;
                }
            });

            DisplaySongs(filteredSongs);

            if (!filteredSongs.Any())
            {
                MessageBox.Show("No songs matched your search.");
            }
        }

        private void DisplaySongs(IEnumerable<Song> filteredSongs)
        {
            listBoxResults.Items.Clear();
            foreach (var song in filteredSongs)
            {
                listBoxResults.Items.Add($"{song.Name} by {song.Artist} ({song.Genre})");
            }
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSearch.Text = $"Searching By: {comboBoxSearchType.SelectedItem.ToString()}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }

        public Song(string name, string artist, string genre)
        {
            Name = name;
            Artist = artist;
            Genre = genre;
        }
    }
}
