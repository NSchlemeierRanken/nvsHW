namespace Sales_Windows_Form
{
    public partial class Form1 : Form
    {
        private decimal totalSalesD = 0m, totalSalesE = 0m, totalSalesF = 0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDanielle_Click(object sender, EventArgs e)
        {
            ProcessSale("Danielle");
        }

        private void btnEdward_Click(object sender, EventArgs e)
        {
            ProcessSale("Edward");
        }

        private void btnFrancis_Click(object sender, EventArgs e)
        {
            ProcessSale("Francis");
        }

        private void ProcessSale(string salespersonName)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal saleAmount) && saleAmount >= 0)
            {
                switch (salespersonName.ToLower())
                {
                    case "danielle":
                        totalSalesD += saleAmount;
                        UpdateResults();
                        break;
                    case "edward":
                        totalSalesE += saleAmount;
                        UpdateResults();
                        break;
                    case "francis":
                        totalSalesF += saleAmount;
                        UpdateResults();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid sales amount.");
            }

            txtAmount.Clear();
        }

        private void UpdateResults()
        {
            decimal grandTotal = totalSalesD + totalSalesE + totalSalesF;

            string highestSalesperson = "None";
            decimal highestSales = 0;
            if (totalSalesD >= highestSales && totalSalesD >= totalSalesE && totalSalesD >= totalSalesF)
            {
                highestSalesperson = "Danielle";
                highestSales = totalSalesD;
            }
            if (totalSalesE > highestSales && totalSalesE >= totalSalesD && totalSalesE >= totalSalesF)
            {
                highestSalesperson = "Edward";
                highestSales = totalSalesE;
            }
            if (totalSalesF > highestSales && totalSalesF >= totalSalesD && totalSalesF >= totalSalesE)
            {
                highestSalesperson = "Francis";
                highestSales = totalSalesF;
            }

            lblResults.Text = $"Danielle's Total Sales: {totalSalesD:C}\n" +
                              $"Edward's Total Sales: {totalSalesE:C}\n" +
                              $"Francis's Total Sales: {totalSalesF:C}\n" +
                              $"Grand Total: {grandTotal:C}\n" +
                              $"Highest Sales: {highestSalesperson} with {highestSales:C}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
