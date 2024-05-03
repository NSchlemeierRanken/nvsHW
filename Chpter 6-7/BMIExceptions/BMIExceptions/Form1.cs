namespace BMIExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int weight = int.Parse(txtWeight.Text);
                int height = int.Parse(txtHeight.Text);
                if (weight < 1 || weight > 777 || height < 12 || height > 96)
                    throw new ArgumentOutOfRangeException("Values out of range.");
                double bmi = (weight / (Math.Pow(height, 2))) * 703;
                lblResult.Text = bmi.ToString("f2");
                lblStatus.Text = GetHealthStatus(bmi);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input.Please enter valid integers for weight and height.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            txtHeight.Clear();
            txtWeight.Clear();
            lblResult.Text = "";
            lblStatus.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
