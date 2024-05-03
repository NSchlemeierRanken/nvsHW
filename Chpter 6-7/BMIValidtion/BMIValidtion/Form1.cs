using System.Diagnostics.Eventing.Reader;

namespace BMIValidtion
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
                int weight = int.Parse(txtWeight.Text);
                int height = int.Parse(txtHeight.Text);
                double bmi = (weight / (Math.Pow(height, 2))) * 703;
                lblResult.Text = bmi.ToString("f2");
                lblStatus.Text = GetHealthStatus(bmi);
            }
        }

        private bool IsValidData()
        {
            return
                IsPresent(txtWeight, "Weight") &&
                IsInt32(txtWeight, "Weight") &&
                IsWithinRange(txtWeight, "Weight", 1, 777) &&
                IsPresent(txtHeight, "Height") &&
                IsInt32(txtHeight, "Height") &&
                IsWithinRange(txtHeight, "Height", 12, 96);
        }

        private string GetHealthStatus(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            else if (bmi < 25) return "Optimal Weight";
            else if (bmi < 30) return "Overweight";
            else return "Obese";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWeight.Clear();
            txtHeight.Clear();
            lblResult.Text = "";
            lblStatus.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (!Int32.TryParse(textBox.Text, out int number))
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsWithinRange(TextBox textBox, string name, int min, int max)
        {
            if (Int32.TryParse(textBox.Text, out int number))
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
    }
}
