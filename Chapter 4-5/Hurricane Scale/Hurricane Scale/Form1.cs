using System.ComponentModel;

namespace Hurricane_Scale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            string category;
            if (int.TryParse(txtWind.Text, out int windSpeed))
            {
                if (windSpeed >= 157)
                {
                    category = "Category 5 Hurricane";
                }
                else if (windSpeed >= 130)
                {
                    category = "Category 4 Hurricane";
                }
                else if (windSpeed >= 111)
                {
                    category = "Category 3 Hurricane";
                }
                else if (windSpeed >= 96)
                {
                    category = "Category 2 Hurricane";
                }
                else if (windSpeed >= 74)
                {
                    category = "Category 1 Hurricane";
                }
                else
                {
                    category = "Not classified as a hurricane";
                }

                lblResult.Text = category;
            }
            else
            {
                MessageBox.Show("Please enter a valid wind speed.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
