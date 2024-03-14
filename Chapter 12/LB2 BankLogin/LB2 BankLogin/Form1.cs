using System.Security.Cryptography.X509Certificates;

namespace LB2_BankLogin
{
    public partial class Bank_Login : Form
    {
        private List<Account> accounts = new List<Account>()
        {
            new Account("12345", "1111", 10000m, "Mr. Smith"),
            new Account("23456", "2222", 20000m, "Mrs. Johnson"),
            new Account("34567", "3333", 30000m, "Mr. Brown"),
            new Account("45678", "4444", 40000m, "Mr. Stark"),
            new Account("56789", "5555", 50000m, "Mrs. Carter"),
        };

        private Account currentAccount = null;
        public Bank_Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccount.Text;
            string pinNumber = txtPin.Text;

            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber && a.PinNumber == pinNumber);

            if (account != null)
            {
                currentAccount = account;
                lblMessage.Text = $"Welcome {currentAccount.Name}! Your balance is {currentAccount.Balance.ToString("C")}";
            }
            else
            {
                MessageBox.Show("Invalid account number or PIN.");
                Logout();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            currentAccount = null;
            lblMessage.Text = "Logged out.";
            txtAccount.Text = "";
            txtPin.Text = "";
            txtDeposit.Text = "";
            txtWithdraw.Text = "";
            txtAccount.Focus();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (currentAccount == null) return;

            decimal amount = decimal.Parse(txtDeposit.Text);
            currentAccount.Balance += amount;
            lblMessage.Text = $"Deposit Succesful. New balance is {currentAccount.Balance.ToString("C")}";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (currentAccount == null) return;

            decimal amount = decimal.Parse(txtWithdraw.Text);
            if (amount > currentAccount.Balance)
            {
                lblMessage.Text = "Insufficient Funds.";
                return;
            }

            currentAccount.Balance -= amount;
            lblMessage.Text = $"Withdrawal succesful. New balance is {currentAccount.Balance.ToString("C")}";
        }

        public class Account
        {
            public string AccountNumber { get; set; }
            public string PinNumber { get; set; }
            public decimal Balance { get; set; }
            public string Name { get; set; }

            public Account(string accountNumber, string pinNumber, decimal balance, string name)
            {
                AccountNumber = accountNumber;
                PinNumber = pinNumber;
                Balance = balance;
                Name = name;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "";
            txtPin.Text = "";
            txtDeposit.Text = "";
            txtWithdraw.Text = "";
            lblMessage.Text = "";
            txtAccount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
