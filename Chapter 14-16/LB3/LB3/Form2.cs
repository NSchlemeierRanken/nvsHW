using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class frmStatement : Form
    {
        public frmStatement()
        {
            InitializeComponent();
        }

        public void PopulateStatement(List<Transaction> transactions)
        {
            transactionsListBox.Items.Clear();
            var lastTransactions = transactions.OrderByDescending(t => t.Date).Take(10);

            foreach ( var transaction in lastTransactions )
            {
                string transactionDetails = $"{transaction.Date.ToShortDateString()} - {transaction.Type}: ${transaction.Amount}";
                transactionsListBox.Items.Add(transactionDetails);
            }
        }
    }
}
