namespace LB1
{
    public partial class frmLetterDelivery : Form
    {
        private List<string> transactionLog = new List<string>();
        private int totalLetterSent = 0;
        public frmLetterDelivery()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (totalLetterSent >= 10)
            {
                MessageBox.Show("You have reached the limit of 10 letters.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string recipient = txtRecipient.Text;
            string trackingNumber = txtTracking.Text;
            string dateInput = txtDate.Text;
            DateTime date;

            bool isValidDate = DateTime.TryParse(dateInput, out date);
            if (!isValidDate)
            {
                MessageBox.Show("Invalid date format. Please use MM/DD/YYYY", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Letter letter = string.IsNullOrEmpty(trackingNumber) ? new StandardLetter() : new CertifiedLetter(trackingNumber);
            double totalCost = letter.CalculateCost();

            totalLetterSent++;

            string logEntry = $"{date.ToShortDateString()}, {recipient}, ${totalCost:0.00}";
            if (letter is CertifiedLetter certifiedLetter)
            {
                logEntry += $", {trackingNumber}";
            }
            transactionLog.Insert(0, logEntry);
            UpdateLogDisplay();

            txtDate.Clear();
            txtRecipient.Clear();
            txtTracking.Clear();
            txtRecipient.Focus();
        }

        private void UpdateLogDisplay()
        {
            logListBox.Items.Clear();
            foreach (string logEntry in transactionLog)
            {
                logListBox.Items.Add(logEntry);
            }
        }
    }

    public abstract class Letter 
    {
        public abstract double CalculateCost();
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    public class StandardLetter : Letter
    {
        public override double CalculateCost()
        {
            return 0.50;
        }
    }

    public class CertifiedLetter : Letter
    {
        private readonly string TrackingNumber;

        public CertifiedLetter(string trackingNumber)
        {
            TrackingNumber = trackingNumber;
        }

        public override double CalculateCost()
        {
            return 0.65;
        }

        public override string ToString()
        {
            return base.ToString() + $" ({TrackingNumber})";
        }
    }
}
