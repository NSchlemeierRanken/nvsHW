namespace Vowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text.ToLower();
            int vowelCount = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                string character = phrase.Substring(i, 1);

                switch (character)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        vowelCount++;
                        break;
                }
            }

            lblResults.Text = $"The number of vowels in the phrase is {vowelCount}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
