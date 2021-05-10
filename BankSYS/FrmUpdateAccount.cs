using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmUpdateAccount : Form
    {
        public FrmUpdateAccount()
        {
            InitializeComponent();
        }
        private void FrmUpdateAccount_Load(object sender, EventArgs e)
        {
            string[] Accountarr = { "accountid", "CONCAT(Name,CONCAT(' - ',accountid)) AS display_name", "account WHERE Status = 'A' AND CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID" };
            string[] Accounttypearr = { "id", "Name", "account_type" };
            DataSet Accountds = new DataSet();
            DataSet Accounttypeds = new DataSet();
            try
            {
                Accountds = Reusable.dsfromDB(Accountarr);
                cboAccount.ValueMember = "accountid";
                cboAccount.DisplayMember = "display_name";
                cboAccount.DataSource = Accountds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 006: Could not connect to database. Please contact an administratior");
            }

            try
            {
                Accounttypeds = Reusable.dsfromDB(Accounttypearr);
                cboType.ValueMember = "id";
                cboType.DisplayMember = "NAME";
                cboType.DataSource = Accounttypeds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 006: Could not connect to database. Please contact an administratior");
            }
            
        }

        public void FillGroupBox()
        {
            string[] Transactionsarr = { "T.TransactionID", "Y.NAME", "T.note", "T.Amount", "T.Timestamp", "Transaction T INNER JOIN Transaction_Type Y ON T.TYPE = Y.Type_Code WHERE AccountID = " + cboAccount.SelectedValue + " ORDER BY TransactionID DESC" };
            DataSet accounts = new DataSet();
            try
            {
                accounts = Reusable.dsfromDB(Transactionsarr);
                dataGridView1.DataSource = accounts.Tables[0];

            }
            catch
            {
                MessageBox.Show("Error 002: Could not connect to database. Please contact an administratior");
            }
        }
        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Accountinfoarr = { "accountid", "Name","Type", "account WHERE AccountID = " + cboAccount.SelectedValue};
            DataSet Accountinfo = new DataSet();
            try
            {
                FillGroupBox();
                Accountinfo = Reusable.dsfromDB(Accountinfoarr);
                txtAccountNumber.Text = Accountinfo.Tables[0].Rows[0][0].ToString();
                txtName.Text = Accountinfo.Tables[0].Rows[0][1].ToString();
                cboType.SelectedValue = Convert.ToInt32(Accountinfo.Tables[0].Rows[0][2].ToString());
            }
            catch
            {
                MessageBox.Show("Error 006: Could not connect to database. Please contact an administratior");
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            FrmDisplayAccounts Back = new FrmDisplayAccounts();
            Back.Show();
            this.Hide();
        }

        private void mnuUpdateCustomer_Click(object sender, EventArgs e)
        {
            FrmUpdateCustomer UpdateCustomer = new FrmUpdateCustomer();
            UpdateCustomer.Show();
            this.Hide();
        }

        private void mnuTerminateCustomer_Click(object sender, EventArgs e)
        {
            FrmTerminateCustomer Terminate = new FrmTerminateCustomer();
            Terminate.Show();
            this.Hide();
        }

        private void mnuCreateAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount CreateAccount = new FrmCreateAccount();
            CreateAccount.Show();
            this.Hide();
        }

        private void mnuCloseAccount_Click(object sender, EventArgs e)
        {
            FrmCloseAccount CloseAccount = new FrmCloseAccount();
            CloseAccount.Show();
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

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                AccountSQL.UpdateAccount(txtName.Text, cboAccount.SelectedValue.ToString(), cboType.SelectedValue.ToString());
                MessageBox.Show("Account Updated");

                FrmDisplayAccounts Display = new FrmDisplayAccounts();
                Display.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Error 000: Could not connect to database. Please contact an administratior");
            }
        }
    }
}
