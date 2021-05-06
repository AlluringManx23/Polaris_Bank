using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmTransfer : Form
    {
        public FrmTransfer()
        {
            InitializeComponent();
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

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreateAccount create = new FrmCreateAccount();
            create.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisplayAccounts Display = new FrmDisplayAccounts();
            Display.Show();
            this.Hide();
        }

        private void FrmTransfer_Load(object sender, EventArgs e)
        {
            {
                string[] Account = { "accountid", "CONCAT(Name,CONCAT(' - ',accountid)) AS display_name", "account WHERE Status = 'A' AND CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID" };
                DataSet Accountds = new DataSet();
                try
                {
                    Accountds = Reusable.dsfromDB(Account);
                    cboCreditorAccount.ValueMember = "accountid";
                    cboCreditorAccount.DisplayMember = "display_name";
                    cboCreditorAccount.DataSource = Accountds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Error 006: Could not connect to database. Please contact an administratior");
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Validation v = new Validation();
            Transaction T = new Transaction();
            bool valid = true;
            T.account = cboCreditorAccount.SelectedValue.ToString();
            T.amount = txtCreditorAmount.Text;
            T.note = txtCreditorNote.Text;
            T.debtor = txtDebtorAccount.Text;

            if (!v.IsAmount(T.amount))
            {
                valid = false;
                errorProvider1.SetError(txtCreditorAmount, "Amount must only be numbers and in the format 0.00 and greater then 0.01");
            }

            if (!v.IsEmpty(T.note) && !v.IsAccount(T.note))
            {
                valid = false;
                errorProvider1.SetError(txtCreditorNote, "Note must not contain special characters");
            }
            if (!v.isAccountNumber(T.debtor) && !v.isIBAN(T.debtor))
            {
                valid = false;
                errorProvider1.SetError(txtDebtorAccount, "Please enter a valid account number or IBAN");
            }
            else if (T.debtor == T.account)
            {
                valid = false;
                errorProvider1.SetError(txtDebtorAccount, "Please select a different account");
            }
            if (valid)
            {
                if (TransactionSQL.CheckBalance(ref T))
                {
                    if (v.isIBAN(T.debtor))
                    {
                        try
                        {
                        if (MessageBox.Show("Are you sure?", "Pay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            T.type = "P";
                            TransactionSQL.Pay(ref T);
                            MessageBox.Show("You just made a payment too " + T.debtor);

                            FrmDisplayAccounts Display = new FrmDisplayAccounts();
                            Display.Show();
                            this.Hide();
                        }
                        }
                        catch
                        {
                            MessageBox.Show("Error 007: Could not connect to database. Please contact an administratior");
                        }
                    }
                    else if (v.isAccountNumber(T.debtor) && AccountSQL.AccountExists(T.debtor))
                    {
                        if (MessageBox.Show("Are you sure?", "Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                            T.type = "T";
                            TransactionSQL.Transfer(ref T);
                            MessageBox.Show("You transfered money too " + T.debtor);

                            FrmDisplayAccounts Display = new FrmDisplayAccounts();
                            Display.Show();
                            this.Hide();
                            }
                            catch
                            {
                                MessageBox.Show("Error 007: Could not connect to database. Please contact an administratior");
                            }
                        }

                    }
                    else
                    {
                        errorProvider1.SetError(txtDebtorAccount, "That Account doesn't exist or has been closed");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtCreditorAmount, "You do not currently have enough money in your account to make that transaction");
                }
            }
        }
            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {

                }
            }
    }
}
