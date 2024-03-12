namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const double KM_PER_MILE = 1.6;
        private void btnConvertKm_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMiles.Text, out double miles))
            {
                double kilometers = miles * KM_PER_MILE;
                lblResult.Text = $"{miles:F1} miles is {kilometers:F1} kilometers";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for miles.");
            }
        }

        private void btnConvertMiles_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtKm.Text, out double kilometers))
            {
                double miles = kilometers / KM_PER_MILE;
                lblResult.Text = $"{kilometers:F1} kilometers is {miles:F1} miles";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for kilometers.");
            }
        }
    }
}
