using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmWithdraw : Form
    {
        public FrmWithdraw()
        {
            InitializeComponent();
        }

        private void FrmWithdraw_Load(object sender, EventArgs e)
        {
            string[] Account = { "accountid", "CONCAT(Name,CONCAT(' - ',accountid)) AS display_name", "account WHERE status = 'A' AND CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID" };
            DataSet Accountds = new DataSet();
            try
            {
                Accountds = Reusable.dsfromDB(Account);
                cboAccount.ValueMember = "accountid";
                cboAccount.DisplayMember = "display_name";
                cboAccount.DataSource = Accountds.Tables[0];
            }
            catch
            {
                cboAccount.Text = "Error!";
                MessageBox.Show("Error 014: Could not connect to database. Please contact an administratior");
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            FrmDisplayAccounts Display = new FrmDisplayAccounts();
            Display.Show();
            this.Hide();
        }

        private void mnuDeposit_Click(object sender, EventArgs e)
        {
            FrmDeposit deposit = new FrmDeposit();
            deposit.Show();
            this.Hide();
        }

        private void mnuTransfer_Click(object sender, EventArgs e)
        {
            FrmTransfer transfer = new FrmTransfer();
            transfer.Show();
            this.Hide();
        }

        private void mnuCreateAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount create = new FrmCreateAccount();
            create.Show();
            this.Hide();
        }
        private void mnuUpdateCustomer_Click(object sender, EventArgs e)
        {
            FrmCreateAccount UpdateCustomer = new FrmCreateAccount();
            UpdateCustomer.Show();
            this.Hide();
        }

        private void mnuTerminateCustomer_Click(object sender, EventArgs e)
        {
            FrmCreateAccount Terminate = new FrmCreateAccount();
            Terminate.Show();
            this.Hide();
        }

        private void mnuUpdateAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount UpdateAccount = new FrmCreateAccount();
            UpdateAccount.Show();
            this.Hide();
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Transaction T = new Transaction();
            T.amount = txtWithdrawAmount.Text;
            T.note = txtWithdrawNote.Text;
            T.account = cboAccount.SelectedValue.ToString();
            T.type = "W";
            Validation v = new Validation();
            bool valid = true;
            if (!v.IsAmount(T.amount) || decimal.Parse(T.amount).Equals(0))
            {
                errorProvider1.SetError(txtWithdrawAmount, "Amount must only be numbers and in the format 0.00 and greater then 0.01");
                valid = false;
            }
            if ((!v.IsAccount(T.note)) && (!T.note.Equals("")))
            {
                errorProvider1.SetError(txtWithdrawNote, "Note must not contain any special characters");
                valid = false;
            }

            if (valid)
            {
                try
                {
                    if(TransactionSQL.CheckBalance(ref T))
                    {
                        try
                        {
                            TransactionSQL.Withdraw(ref T);
                            MessageBox.Show("You just withdrew €" + T.amount);

                            FrmDisplayAccounts Display = new FrmDisplayAccounts();
                            Display.Show();
                            this.Hide();
                        }
                        catch
                        {
                            MessageBox.Show("Error 017: Could not connect to database. Your Withdrawal Has not been processed \nPlease contact an administratior");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have enough money in your account to process this Withdrawal");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Error 016: Could not connect to database. Please contact an administratior");
                }
            }
        }

        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Accountinfo = { "Balance", "ACCOUNT WHERE AccountID = " + cboAccount.SelectedValue};
            DataSet Accounts = new DataSet();
            try
            {
                Accounts = Reusable.dsfromDB(Accountinfo);
                lblBalanceAmount.Text = "€" + Accounts.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                lblBalanceAmount.Text = "Error!";
                MessageBox.Show("Error 015: Could not connect to database. Please contact an administratior");
            }
        }
    }
}
