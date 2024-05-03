namespace OrderException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemNumber.Clear();
            txtQuantity.Clear();
            txtDeliveryDays.Clear();
            lblMessage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                int itemNumber = int.Parse(txtItemNumber.Text);
                int quantity = int.Parse(txtQuantity.Text);
                int deliveryDays = int.Parse(txtDeliveryDays.Text);

                if (itemNumber < 100 || itemNumber > 999 || quantity < 1 || quantity > 12 || deliveryDays < 1 || deliveryDays > 30)
                    throw new ArgumentOutOfRangeException("Values out of range.");

                lblMessage.Text = "Order is valid!";
            }
            catch (FormatException)
            {
                MessageBox.Show("All fields must be valid integers.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
