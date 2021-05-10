using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmTransactionChart : Form
    {
        public FrmTransactionChart()
        {
            InitializeComponent();
        }
        public void PopulateChart(string s)
        {
            String MonthlyInSQL = "SELECT to_Char(TIMESTAMP,'MM') AS MONTH,SUM(to_number(Amount, '9999999.99')) From Transaction WHERE (Accountid = '" + cboAccount.SelectedValue + "' AND TYPE = 'D') OR debtorid = '" + cboAccount.SelectedValue + "' AND to_Char(TIMESTAMP,'DD/MM/YYYY') LIKE '%2021' GROUP BY to_Char(TIMESTAMP,'MM') ORDER BY to_Char(TIMESTAMP,'MM')";
            String MonthlyOutSQL = "SELECT SUM(to_number(Amount, '9999999.99')) From Transaction WHERE (TYPE = 'W' OR Type = 'T') AND Accountid = '" + cboAccount.SelectedValue + "' AND to_Char(TIMESTAMP,'DD/MM/YYYY') LIKE '%2020' GROUP BY to_Char(TIMESTAMP,'MM') ORDER BY to_Char(TIMESTAMP,'MM')";
            DataTable MonthlyIn = new DataTable();
            DataTable MonthlyOut = new DataTable();
            MonthlyIn = TransactionSQL.dtForChart(MonthlyInSQL);
            MonthlyOut = TransactionSQL.dtForChart(MonthlyOutSQL);
            string[] N = new string[MonthlyIn.Rows.Count];
            decimal[] M = new decimal[MonthlyIn.Rows.Count];
            for (int i = 0; i < MonthlyIn.Rows.Count; i++)
            {
                N[i] = getMonth(Convert.ToInt32(MonthlyIn.Rows[i][0]));
                try
                {
                    M[i] = Convert.ToDecimal(MonthlyIn.Rows[i][1]) - Convert.ToDecimal(MonthlyOut.Rows[i][0]);
                }
                catch
                {
                    M[i] = Convert.ToDecimal(MonthlyIn.Rows[i][1]) - Convert.ToDecimal(0.00);
                }
                
            }
            chtTransactions.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtTransactions.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtTransactions.Series[0].LegendText = "Income in €"; chtTransactions.Series[0].Points.DataBindXY(N, M);
            chtTransactions.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            chtTransactions.Series[0].Label = "#VALY";
            chtTransactions.Visible = true;
        }
        private void FrmTransactionChart_Load(object sender, EventArgs e)
        {
            //string[] MinDateSQL = { "Min(to_Char(DATE_Created, 'YYYY'))", "account WHERE status = 'A' AND CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID" };
            string[] AccountSQL = { "accountid", "CONCAT(Name,CONCAT(' - ',accountid)) AS display_name", "account WHERE status = 'A' AND CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID" };
            
            //nudYear.Maximum = Convert.ToDecimal(DateTime.Now.ToString("yyyy"));
            //nudYear.Minimum = Convert.ToDecimal(Reusable.stringfromDB(MinDateSQL));
            
            DataSet Accountds = new DataSet();
            chtTransactions.Titles.Add("Monthly Balance");
            try
            {
                Accountds = Reusable.dsfromDB(AccountSQL);
                cboAccount.ValueMember = "accountid";
                cboAccount.DisplayMember = "display_name";
                cboAccount.DataSource = Accountds.Tables[0];
                nudYear.Value = Convert.ToDecimal(DateTime.Now.ToString("yyyy"));
                PopulateChart(cboAccount.SelectedValue.ToString());
            }
            catch
            {
                cboAccount.Text = "Error!";
                MessageBox.Show("Error 010: Could not connect to database. Please contact an administratior");
            }
        }
        public String getMonth(int month)
        {
            switch(month)
            {
                case 1:
                {
                    return "JAN";
                }
                case 2:
                {
                    return "FEB";
                }
                case 3:
                {
                    return "MAR";
                }
                case 4:
                {
                    return "APR";
                }
                case 5:
                {
                    return "MAY";
                }
                case 6:
                {
                    return "JUN";
                }
                case 7:
                {
                    return "JUL";
                }
                case 8:
                {
                    return "AUG";
                }
                case 9:
                {
                    return "SEP";
                }
                case 10:
                {
                    return "OCT";
                }
                case 11:
                {
                    return "NOV";
                }
                case 12:
                {
                    return "DEC";
                }
                default:
                    return "OTH";
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            FrmDisplayAccounts Display = new FrmDisplayAccounts();
            Display.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateChart(cboAccount.SelectedValue.ToString());
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuUpdateCustomer_Click(object sender, EventArgs e)
        {
            FrmUpdateCustomer UpdateCustomer = new FrmUpdateCustomer();
            UpdateCustomer.Show();
            this.Hide();
        }

        private void mnuTerminate_Click(object sender, EventArgs e)
        {
            FrmTerminateCustomer Terminate = new FrmTerminateCustomer();
            Terminate.Show();
            this.Hide();
        }

        private void mnuCreateAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount Create = new FrmCreateAccount();
            Create.Show();
            this.Hide();
        }

        private void mnuUpdateAccount_Click(object sender, EventArgs e)
        {
            FrmUpdateAccount UpdateAccount = new FrmUpdateAccount();
            UpdateAccount.Show();
            this.Hide();
        }

        private void mnuCloseAccount_Click(object sender, EventArgs e)
        {
            FrmCloseAccount close = new FrmCloseAccount();
            close.Show();
            this.Hide();
        }

        private void mnuDeposit_Click(object sender, EventArgs e)
        {
            FrmDeposit Deposit = new FrmDeposit();
            Deposit.Show();
            this.Hide();
        }

        private void mnuWithdraw_Click(object sender, EventArgs e)
        {
            FrmWithdraw Withdraw = new FrmWithdraw();
            Withdraw.Show();
            this.Hide();
        }

        private void mnuTransfer_Click(object sender, EventArgs e)
        {
            FrmTransfer Transfer = new FrmTransfer();
            Transfer.Show();
            this.Hide();
        }
    }
}
