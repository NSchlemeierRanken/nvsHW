namespace LB03_StudentGrades
{
    public partial class frmStudentGrades : Form
    {
        private GradeManager gradeManager;
        public frmStudentGrades()
        {
            InitializeComponent();
            gradeManager = new GradeManager();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            var student = gradeManager.FindStudent(studentName);
            if (student != null)
            {
                lblStudentName.Text = $"Student Name: {student.Name}";
                lblLabGrade.Text = "Lab Grade: " + gradeManager.CalculateAverage(student.LabGrades).ToString("N1");
                lblTestGrade.Text = "Test Grade: " + gradeManager.CalculateAverage(student.TestGrades).ToString("N1");
                lblOverallGrade.Text = "Overall Grade: " + gradeManager.CalculateOverallAverage(student).ToString("N1");
            }
            else
            {
                MessageBox.Show($"{studentName} not found");
            }
        }

        public class Student
        {
            public string Name { get; set; }
            public List<double> LabGrades { get; set; }
            public List<double> TestGrades { get; set; }

            public Student(string name, List<double> labGrades, List<double> testGrades)
            {
                Name = name;
                LabGrades = labGrades;
                TestGrades = testGrades;
            }
        }

        public class GradeManager
        {
            public List<Student> Students { get; set; }

            public GradeManager()
            {
                Students = new List<Student>
                {
                    new Student("John Doe", new List<double> { 80, 90, 85}, new List<double> { 75, 95, 82}),
                    new Student("Jane Foster", new List<double> { 88, 92, 87}, new List<double> { 78, 88, 90}),
                    new Student("Tony Stark", new List<double> { 95, 92, 90}, new List<double> { 88, 84, 91}),
                    new Student("Steve Rogers", new List<double> { 70, 75, 80}, new List<double> { 65, 70, 68})
                };
            }

            public Student FindStudent(string name)
            {
                return Students.FirstOrDefault(s => s.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            public double CalculateAverage(List<double> grades)
            {
                return grades.Average();
            }

            public double CalculateOverallAverage(Student student)
            {
                double labAverage = CalculateAverage(student.LabGrades);
                double testAverage = CalculateAverage(student.TestGrades);
                return (labAverage * 0.4) + (testAverage * 0.6);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
