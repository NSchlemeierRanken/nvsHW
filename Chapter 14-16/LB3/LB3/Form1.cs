namespace LB3
{
    public partial class frmBank : Form
    {
        public frmBank()
        {
            InitializeComponent();
        }

        private Account currentUser;
        public void UpdateUI()
        {
            if (currentUser != null)
            {
                lblWelcome.Text = $"Welcome, {currentUser.Username}";
                lblBalance.Text = $"Current Balance: ${currentUser.Balance}";
                lblType.Text = $"Account Type: {GetAccountType(currentUser)}";
                lblWelcome.Visible = true;
                lblBalance.Visible = true;
                lblType.Visible = true;
                lblDeposit.Visible = true;
                btnDeposit.Visible = true;
                lblWithdraw.Visible = true;
                btnWithdraw.Visible = true;
                btnStatement.Visible = true;
                btnLogout.Visible = true;
                txtDeposit.Visible = true;
                txtWithdraw.Visible = true;

                btnLogin.Visible = false;
            }
        }

        private string GetAccountType(Account account)
        {
            if (account is GoldAccount) return "Gold";
            if (account is SilverAccount) return "Silver";
            if (account is BronzeAccount) return "Bronze";
            return "Unknown";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isAccountNumberValid = int.TryParse(txtAccountNumber.Text, out int accountNumber);
            bool isPinValid = int.TryParse(txtPin.Text, out int pin);

            if (!isAccountNumberValid || !isPinValid)
            {
                MessageBox.Show("Please enter valid numeric values for the account number and pin number.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Account account = AccountManager.Login(accountNumber, pin);

            if (account != null)
            {
                currentUser = account;
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your account number and PIN.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            currentUser = null;
            ResetUI();
            txtAccountNumber.Focus();
        }

        private void ResetUI()
        {
            lblWelcome.Visible = false;
            lblBalance.Visible = false;
            lblType.Visible = false;
            lblDeposit.Visible = false;
            lblWithdraw.Visible = false;
            btnWithdraw.Visible = false;
            btnDeposit.Visible = false;
            btnStatement.Visible = false;
            btnLogout.Visible = false;
            txtDeposit.Visible = false;
            txtWithdraw.Visible = false;

            lblWelcome.Text = "";
            lblBalance.Text = "";
            lblType.Text = "";

            txtAccountNumber.Clear();
            txtPin.Clear();
            txtDeposit.Clear();
            txtWithdraw.Clear();

            btnLogin.Visible = true;
        }

        private void btnStatement_Click(object sender, EventArgs e)
        {
            currentUser?.PrintStatement();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDeposit.Text, out decimal amount) && amount > 0)
            {
                currentUser.Deposit(amount);
                UpdateUI();
                MessageBox.Show($"Successfully deposited ${amount}.", "Deposit Successful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeposit.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for the deposit amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeposit.Focus();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWithdraw.Text, out decimal amount) && amount > 0)
            {
                bool success = currentUser.Withdraw(amount);
                if (success)
                {
                    UpdateUI();
                    MessageBox.Show($"Successfully withdrew ${amount}.", "Withdraw Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtWithdraw.Clear();
                }
                else
                {
                    MessageBox.Show("Withdrawal failed. Please check if you have sufficient funds and meet the withdrawal conditions.", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for the withdrawal amount", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtWithdraw.Focus();
            }
        }
    }

    public static class AccountManager
    {
        public static List<Account> Accounts = new List<Account>();
        private static int nextAccountNumber = 10001;

        static AccountManager()
        {
            CreateAccount("John Doe", 1111, 500);
            CreateAccount("Jane Doe", 2222, 1000);
            CreateAccount("Will Smith", 3333, 2000);
            CreateAccount("Tom Cruise", 4444, 6000);
            CreateAccount("Charlie Brown", 5555, 10000);
        }

        private static void CreateAccount(string username, int pin, decimal initialBalance)
        {
            int accountNumber = nextAccountNumber++;
            Account account = initialBalance < 1000 ? new BronzeAccount(username, accountNumber, pin, initialBalance) :
                              initialBalance < 5000 ? new SilverAccount(username, accountNumber, pin, initialBalance) :
                              new GoldAccount(username, accountNumber, pin, initialBalance);
            Accounts.Add(account);
        }

        public static Account Login(int accountNumber, int pin)
        {
            return Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber && a.PIN == pin);
        }
    }

    public abstract class Account
    {
        public string Username { get; set; }
        public int AccountNumber { get; set; }
        public int PIN { get; set; }
        protected decimal balance;
        public decimal Balance { get { return balance; } }
        public List<Transaction> Transactions { get; protected set; } = new List<Transaction>();

        public Account(string username, int accountNumber, int pin, decimal initialBalance)
        {
            Username = username;
            AccountNumber = accountNumber;
            PIN = pin;
            this.balance = initialBalance;
        }

        public virtual bool Deposit(decimal amount)
        {
            if (amount <= 0) return false;
            balance += amount;
            Transactions.Add(new Transaction { Date = DateTime.Now, Amount = amount, Type = "Deposit" });
            return true;
        }

        public virtual bool Withdraw(decimal amount)
        {
            decimal fee = CalculateWithdrawalFee(amount);
            decimal totalDeduction = amount + fee;
            if (amount <= 0 || balance - totalDeduction < 0) return false;
            balance -= totalDeduction;
            Transactions.Add(new Transaction { Date = DateTime.Now, Amount = amount, Type = "Withdrawal" });
            return true;
        }

        protected virtual decimal CalculateWithdrawalFee(decimal amount) => amount * 0.01m;

        public abstract void PrintStatement();
    }

    public class BronzeAccount : Account
    {
        public BronzeAccount(string username, int accountNumber, int pin, decimal initialBalance) : base(username, accountNumber, pin, initialBalance) { }

        public override void PrintStatement()
        {
            MessageBox.Show("Bronze accounts cannot view statements.", "Restriction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class SilverAccount : Account
    {
        private const decimal MinimumBalance = 1000m;
        public SilverAccount(string username, int accountNumber, int pin, decimal initialBalance) : base(username, accountNumber, pin, initialBalance) { }

        public override bool Withdraw(decimal amount)
        {
            decimal fee = CalculateWithdrawalFee(amount);
            decimal totalDeduction = amount + fee;

            if (balance - totalDeduction >= MinimumBalance)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return false;
            }
        }

        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return base.CalculateWithdrawalFee(amount);
        }
        public override void PrintStatement() 
        {
            frmStatement statementForm = new frmStatement();
            statementForm.PopulateStatement(this.Transactions);
            statementForm.ShowDialog();
        }
    }

    public class GoldAccount : Account
    {
        private const decimal MinimumBalance = 5000m;

        public override bool Withdraw(decimal amount)
        {
            if (balance - amount >= MinimumBalance)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return false;
            }
        }
        public GoldAccount(string username, int accountNumber, int pin, decimal initialBalance) : base(username, accountNumber, pin, initialBalance) { }

        protected override decimal CalculateWithdrawalFee(decimal amount)
        {
            return 0m;
        }

        public override void PrintStatement()
        {
            frmFancyStatement statementForm = new frmFancyStatement();
            statementForm.PopulateStatement(this.Transactions);
            statementForm.ShowDialog();
        }
    }

    public class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
    }
}
