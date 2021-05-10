using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmTerminateCustomer : Form
    {
        public FrmTerminateCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(AccountSQL.AllBalanceEmpty())
            {
                if (MessageBox.Show("Are you sure you want to terminate your account?\n\nYou will not be able to login again and all open accounts will be closed!", "Terminate Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AccountSQL.CloseCustAccounts();
                    CustomerSQL.TerminateAccount(Customer.CustomerId);

                    Customer.Clear();
                    FrmStartScreen start = new FrmStartScreen();
                    start.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please Empty all open accounts of funds");
            }
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisplayAccounts Display = new FrmDisplayAccounts();
            Display.Show();
            this.Hide();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateCustomer updateCust = new FrmUpdateCustomer();
            updateCust.Show();
            this.Hide();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreateAccount create = new FrmCreateAccount();
            create.Show();
            this.Hide();
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateAccount updateAcc = new FrmUpdateAccount();
            updateAcc.Show();
            this.Hide();
        }

        private void closeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCloseAccount close = new FrmCloseAccount();
            close.Show();
            this.Hide();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeposit deposit = new FrmDeposit();
            deposit.Show();
            this.Hide();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWithdraw withdraw = new FrmWithdraw();
            withdraw.Show();
            this.Hide();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransfer transfer = new FrmTransfer();
            transfer.Show();
            this.Hide();
        }

        private void FrmTerminateCustomer_Load(object sender, EventArgs e)
        {
            txtFName.Text = Customer.Fname;
            txtLName.Text = Customer.Lname;
            txtPhoneNo.Text = Customer.CountryCode + Customer.PhoneNo;
            txtDOB.Text = Customer.DOB;
            txtAddressL1.Text = Customer.AddressL1;
            txtAddressL2.Text = Customer.AddressL2;
            txtAddressL3.Text = Customer.AddressL3;
            txtTown.Text = Customer.Town;
            txtCounty.Text = Customer.County;
            txtEircode.Text = Customer.Eir;
            txtPhoneNo.Text = Customer.CountryCode + Customer.PhoneNo;
            txtDOB.Text = Customer.DOB;



            string[] accountsarr = { "A.ACCOUNTID","A.Name", "A.STATUS", "T.NAME Type", "A.BALANCE", "A.DATE_created \"Date Created\"", "ACCOUNT A INNER JOIN ACCOUNT_TYPE T ON A.TYPE = T.ID WHERE CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID ASC"};
            DataSet accounts = new DataSet();
            try
            {
                accounts = Reusable.dsfromDB(accountsarr);
                dataGridView1.DataSource = accounts.Tables[0];
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[1].Width = 175;
                dataGridView1.Columns[2].Width = 75;
                dataGridView1.Columns[3].Width = 50;
                dataGridView1.Columns[4].Width = 75;
                dataGridView1.Columns[5].Width = 100;
            }
            catch
            {
                MessageBox.Show("Error 002: Could not connect to database. Please contact an administratior");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
