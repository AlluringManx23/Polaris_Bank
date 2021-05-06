using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmCloseAccount : Form
    {
        public FrmCloseAccount()
        {
            InitializeComponent();
            UpdateForm.i = 2;
        }

        private void FrmCloseAccount_Load(object sender, EventArgs e)
        {
            
            FillcboBox();
        }

        public void FillcboBox()
        {
            string[] Account = { "accountid", "CONCAT(Name,CONCAT(' - ',accountid)) AS display_name", "account WHERE Status = 'A' AND CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID" };
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
        public void DisplayTransactionhistory()
        {
            string[] Transactioninfo = new string[5];
            Transactioninfo[0] = "T.TransactionID";
            Transactioninfo[1] = "Y.name";
            Transactioninfo[2] = "T.Amount";
            Transactioninfo[3] = "T.Note";
            Transactioninfo[4] = "Transaction T INNER JOIN Transaction_TYPE Y ON T.TYPE = Y.Type_code WHERE AccountID = " + cboAccount.SelectedValue + " ORDER BY TransactionID DESC";

            DataSet Transactions = new DataSet();
            Transactions = Reusable.dsfromDB(Transactioninfo);
            for (int i = 0; i < Transactions.Tables[0].Rows.Count && i < 10; i++)
            {
                //Create label
                Label TransactionID = new Label();
                Label Transaction_Type = new Label();
                Label Transaction_Amount = new Label();
                Label Transaction_Note = new Label();
                TransactionID.Text = Transactions.Tables[0].Rows[i]["TransactionID"].ToString();
                Transaction_Type.Text = Transactions.Tables[0].Rows[i]["name"].ToString();
                Transaction_Amount.Text = "€" + Transactions.Tables[0].Rows[i]["Amount"].ToString();
                Transaction_Note.Text = Transactions.Tables[0].Rows[i]["Note"].ToString();
                //Position label on screen
                TransactionID.Left = 0;
                TransactionID.Top = ((i + 1) * 25) + 75;
                //TransactionID.Width = 100;

                Transaction_Type.Left = 100;
                Transaction_Type.Top = ((i + 1) * 25) + 75;
                //Transaction_Type.Width = 100;

                Transaction_Amount.Left = 500;
                Transaction_Amount.Top = ((i + 1) * 25) + 75;
                Transaction_Amount.Width = 75;
                Transaction_Amount.AutoSize = false;
                Transaction_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                
                Transaction_Note.Top = ((i + 1) * 25) + 75;
                Transaction_Note.Left = 200;
                Transaction_Note.Width = 350;
                //Add controls to form
                this.Controls.Add(TransactionID);
                this.Controls.Add(Transaction_Type);
                this.Controls.Add(Transaction_Amount);
                this.Controls.Add(Transaction_Note);
            }
        }
        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm.i++;
            if (UpdateForm.i % 3 == 0)
            {
                UpdateForm.SelectedIndex = cboAccount.SelectedIndex;
                Controls.Clear();
                InitializeComponent();
                FillcboBox();
                cboAccount.SelectedIndex = UpdateForm.SelectedIndex;
                if(UpdateForm.SelectedIndex == 0)
                {
                    UpdateForm.i++;
                }
                DisplayTransactionhistory();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] findbalance = { "balance", "account where accountid = " + cboAccount.SelectedValue.ToString()};
            string balance = Reusable.stringfromDB(findbalance);
            if(balance.Equals("0.00"))
            {
                if (MessageBox.Show("Are you sure you want to close this account?", "Close Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AccountSQL.CloseAccount(cboAccount.SelectedValue.ToString());
                    MessageBox.Show("Your Account has been closed");
                    FrmDisplayAccounts back = new FrmDisplayAccounts();
                    back.Show();
                    this.Hide();
                }
                else
                {
 
                }
                
            }
            else
            {
                MessageBox.Show("Please empty your account of money before closing your account");
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisplayAccounts back = new FrmDisplayAccounts();
            back.Show();
            this.Hide();
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

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tableLayoutPanel1.Visible)
            {
                Reusable.resetupdate();
                FrmDeposit deposit = new FrmDeposit();
                deposit.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You do not curently have an Active account.\nPlease Create one before continuing");
            }
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tableLayoutPanel1.Visible)
            {
                FrmWithdraw withdraw = new FrmWithdraw();
                withdraw.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You do not curently have an Active account.\nPlease Create one before continuing");
            }
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reusable.resetupdate();
            FrmCreateAccount create = new FrmCreateAccount();
            create.Show();
            this.Hide();
        }
        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tableLayoutPanel1.Visible)
            {
                Reusable.resetupdate();
                FrmTransfer transfer = new FrmTransfer();
                transfer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You do not curently have an Active account.\nPlease Create one before continuing");
            }
        }
    }
}
