namespace Payroll_Projections
{
    public partial class Form1 : Form
    {
        private const double PERCENT_RAISE = 1.04;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                string employeeName = this.Controls["txtName" + i].Text;
                if (double.TryParse(this.Controls["txtSalary" + i].Text, out double currentSalary))
                {
                    double year1Salary = currentSalary * PERCENT_RAISE;
                    double year2Salary = year1Salary * PERCENT_RAISE;

                    this.Controls["lblName" + i].Text = employeeName;
                    this.Controls["lblInitialSalary" + i].Text = $"{currentSalary:C}";
                    this.Controls["lblYear1Salary" + i].Text = $"{year1Salary:C}";
                    this.Controls["lblYear2Salary" + i].Text = $"{year2Salary:C}";
                }
                else
                {
                    MessageBox.Show($"Please enter a valid salary for Employee {i}.");
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
