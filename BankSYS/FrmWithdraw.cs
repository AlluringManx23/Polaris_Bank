using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Error 006: Could not connect to database. Please contact an administratior");
            }
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
                        TransactionSQL.Withdraw(ref T);
                    }
                    else
                    {
                        MessageBox.Show("You do not have enough money in your account to process this transaction");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Error 007: Could not connect to database. Please contact an administratior");
                }
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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisplayAccounts Display = new FrmDisplayAccounts();
            Display.Show();
            this.Hide();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeposit deposit = new FrmDeposit();
            deposit.Show();
            this.Hide();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransfer transfer = new FrmTransfer();
            transfer.Show();
            this.Hide();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreateAccount create = new FrmCreateAccount();
            create.Show();
            this.Hide();
        }
    }
}
