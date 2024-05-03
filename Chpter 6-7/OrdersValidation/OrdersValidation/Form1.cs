namespace OrdersValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                lblMessage.Text = "Order is valid!";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemNumber.Clear();
            txtQuantity.Clear();
            txtDeliveryDays.Clear();
        }

        private bool IsValidData()
        {
            return
                IsPresent(txtItemNumber, "Item Number") &&
                IsInt32(txtItemNumber, "Item Number") &&
                IsWithinRange(txtItemNumber, "Item Number", 100, 999) &&
                IsPresent(txtQuantity, "Quantity") &&
                IsInt32(txtQuantity, "Quantity") &&
                IsWithinRange(txtQuantity, "Quantity", 1, 12) &&
                IsPresent(txtDeliveryDays, "Estimated Delivery Days") &&
                IsInt32(txtDeliveryDays, "Estimated Delivery Days") &&
                IsWithinRange(txtDeliveryDays, "Estimated Delivery Days", 1, 30);
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsInt32(TextBox textBox, string name)
        {
            if (!int.TryParse(textBox.Text, out int number))
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsWithinRange(TextBox textBox, string name, int min, int max)
        {
            if (int.TryParse(textBox.Text, out int number))
            {
                if (number < min || number > max)
                {
                    MessageBox.Show(name + $" must be between {min} and {max}.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
