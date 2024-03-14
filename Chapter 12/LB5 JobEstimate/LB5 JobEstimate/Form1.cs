namespace LB5_JobEstimate
{
    public partial class Job_Estimate : Form
    {
        private Job currentJob;
        public class Job
        {
            private decimal hoursToComplete;
            private decimal hourlyFee;
            private const decimal TripFee = 35m;
            public string Description { get; set; }
            public decimal TotalFee { get; private set; }

            public Job(decimal hours, decimal rate, string description)
            {
                HoursToComplete = hours;
                HourlyFee = rate;
                Description = description;
                CalculateTotalFee();
            }

            public decimal HoursToComplete
            {
                get => hoursToComplete;
                set
                {
                    hoursToComplete = value;
                    CalculateTotalFee();
                }
            }

            public decimal HourlyFee
            {
                get => hourlyFee;
                set
                {
                    hourlyFee = value;
                    CalculateTotalFee();
                }
            }

            private void CalculateTotalFee()
            {
                TotalFee = (HoursToComplete * HourlyFee) + TripFee;
            }
        }
        public Job_Estimate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal hours = decimal.TryParse(txtHours.Text, out decimal h) ? h : 0;
            decimal fee = decimal.TryParse(txtHourlyRate.Text, out decimal f) ? f : 0;
            string description = txtDescription.Text.Trim();

            if (currentJob == null)
            {
                currentJob = new Job(hours, fee, description);
            }
            else
            {
                currentJob.HoursToComplete = hours;
                currentJob.HourlyFee = fee;
                currentJob.Description = description;
            }

            lblDescription.Text = $"{currentJob.Description}";
            lblHours.Text = $"{currentJob.HoursToComplete} hours";
            lblHourlyRate.Text = $"{currentJob.HourlyFee:C}";
            lblTotal.Text = $"{currentJob.TotalFee:C}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtHourlyRate.Text = "";
            txtHours.Text = "";
            lblDescription.Text = "";
            lblHourlyRate.Text = "";
            lblHours.Text = "";
            lblTotal.Text = "";
            txtDescription.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
