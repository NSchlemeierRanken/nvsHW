namespace College_Admission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtGpa.Text, out double gpa) && int.TryParse(txtScore.Text, out int score))
            {
                if ((gpa >= 3.0 && score >= 60) || (gpa < 3.0 && score >= 80))
                {
                    lblResult.Text = "Accept";
                }
                else
                {
                    lblResult.Text = "Reject";
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for GPA and test score");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
