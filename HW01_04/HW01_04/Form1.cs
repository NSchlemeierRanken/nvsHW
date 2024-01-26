namespace HW01_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double dailyPrice = 100;
            const double milePrice = 0.50;
            int days = int.Parse(textDays.Text);
            double miles = double.Parse(textMiles.Text);
            double totalPrice = (days * dailyPrice) + (miles * milePrice);
            lblTotalPrice.Text = $"Total Rental Price: ${totalPrice:F2}";
        }
    }
}
