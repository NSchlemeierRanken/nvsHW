namespace Lab3_GradeExceptions
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
                int grade1 = ValidateGrade(txtTest1.Text);
                int grade2 = ValidateGrade(txtTest2.Text);
                int grade3 = ValidateGrade(txtTest3.Text);

                double average = (grade1 + grade2 + grade3) / 3.0;
                lblResult.Text = "Test Grade/Average: " + average.ToString("N2") + " = " + GetLetterGrade(average);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error");
            }
        }

        private int ValidateGrade(string gradeText)
        {
            if (!int.TryParse(gradeText, out int grade))
                throw new FormatException("Grade must be a valid integer.");

            if (grade < 0 || grade > 100)
                throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");

            return grade;
        }

        private string GetLetterGrade(double average)
        {
            if (average >= 90) return "A";
            else if (average >= 80) return "B";
            else if (average >= 70) return "C";
            else if (average >= 60) return "D";
            else return "F";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Clear();
            txtTest2.Clear();
            txtTest3.Clear();
            lblResult.Text = "Text Average/Grade: ";
        }
    }
}
