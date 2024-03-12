namespace Chicken_Farmer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEgg1.Text, out int egg1) &&
                int.TryParse(txtEgg2.Text, out int egg2) &&
                int.TryParse(txtEgg3.Text, out int egg3) &&
                int.TryParse(txtEgg4.Text, out int egg4))
            {
                int totalEggs = egg1 + egg2 + egg3 + egg4;
                int dozen = totalEggs / 12;
                int remainingEggs = totalEggs % 12;

                lblResult.Text = $"{totalEggs} eggs total, or {dozen} dozen and {remainingEggs} eggs";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for all chickens.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
