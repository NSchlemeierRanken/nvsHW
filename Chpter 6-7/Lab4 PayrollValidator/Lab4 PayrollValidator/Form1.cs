namespace Lab4_PayrollValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                decimal hoursWorked = decimal.Parse(txtHours.Text);
                decimal hourlyRate = decimal.Parse(txtRate.Text);
                decimal grossPay = CalculateGrossPay(hoursWorked, hourlyRate);
                lblResult.Text = $"Employee Gross Pay: {grossPay:C2}";
            }
        }

        private decimal CalculateGrossPay(decimal hours, decimal rate)
        {
            if (hours <= 40)
                return hours * rate;
            else
                return (40 * rate) + ((hours - 40) * rate * 2); // Overtime calculation
        }

        private bool IsValidData()
        {
            return IsPresent(txtHours, "Hours Worked") &&
                   IsDecimal(txtHours, "Hours Worked") &&
                   IsWithinRange(txtHours, "Hours Worked", 0, 84) &&
                   IsPresent(txtRate, "Hourly Rate") &&
                   IsDecimal(txtRate, "Hourly Rate") &&
                   IsWithinRange(txtRate, "Hourly Rate", 0, 99);
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsDecimal(TextBox textBox, string name)
        {
            if (!decimal.TryParse(textBox.Text, out decimal number))
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            if (decimal.TryParse(textBox.Text, out decimal value))
            {
                if (value < min || value > max)
                {
                    MessageBox.Show(name + $" must be between {min} and {max}.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Clear();
            txtRate.Clear();
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
