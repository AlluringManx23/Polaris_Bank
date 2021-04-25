using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmDisplayAccounts : Form
    {
        public FrmDisplayAccounts()
        {
            InitializeComponent();
        } 

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void FrmDisplayAccounts_Load(object sender, EventArgs e)
        {
            lblFullName.Text = Customer.Fname + " " + Customer.Lname;
            CheckAndDisplayAccounts(DisplayAccount.ClosedAccount);
            if(!DisplayAccount.ClosedAccount)
            {
                DisplayAccount.i++;
            }
        }

        public void CheckAndDisplayAccounts(bool b)
        {
            int count = AccountSQL.FindAccounts();
            if (count >= 1)
            {
                string[] Accountinfo = new string[7];
                tableLayoutPanel1.Visible = false;
                if(b)
                {
                    Accountinfo[0] = "A.ACCOUNTID";
                    Accountinfo[1] = "A.STATUS";
                    Accountinfo[2] = "A.NAME";
                    Accountinfo[3] = "T.NAME Type";
                    Accountinfo[4] = "A.BALANCE";
                    Accountinfo[5] = "A.DATE_created";
                    Accountinfo[6] = "ACCOUNT A INNER JOIN ACCOUNT_TYPE T ON A.TYPE = T.ID WHERE CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID";
                }
                else if(!b)
                {
                    Accountinfo[0] = "A.ACCOUNTID";
                    Accountinfo[1] = "A.STATUS";
                    Accountinfo[2] = "A.NAME";
                    Accountinfo[3] = "T.NAME Type";
                    Accountinfo[4] = "A.BALANCE";
                    Accountinfo[5] = "A.DATE_created";
                    Accountinfo[6] = "ACCOUNT A INNER JOIN ACCOUNT_TYPE T ON A.TYPE = T.ID WHERE STATUS = 'A' AND CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID";
                }
                
                DataSet Accounts = new DataSet();
                Accounts = ReusableSQL.dsfromsql(Accountinfo);
                for (int i = 0; i < Accounts.Tables[0].Rows.Count; i++)
                {
                    //Create label
                    Label Account_Name_ID = new Label();
                    Label Account_Status = new Label();
                    Label Account_Type = new Label();
                    Label Account_Balance = new Label();
                    Account_Name_ID.Text = Accounts.Tables[0].Rows[i]["NAME"].ToString() + " - " + Accounts.Tables[0].Rows[i]["ACCOUNTID"].ToString();
                    Account_Status.Text = Accounts.Tables[0].Rows[i]["STATUS"].ToString();
                    Account_Type.Text = Accounts.Tables[0].Rows[i]["Type"].ToString();
                    Account_Balance.Text = Accounts.Tables[0].Rows[i]["BALANCE"].ToString();
                    //Position label on screen
                    Account_Name_ID.Left = 10;
                    Account_Name_ID.Top = ((i + 1) * 50) + 125;

                    /*Account_Status.Left = 10;
                    Account_Status.Top = ((i + 1) * 50) + 125;
*/
                    Account_Type.Left = 200;
                    Account_Type.Top = ((i + 1) * 50) + 125;

                    Account_Balance.AutoSize = false;
                    Account_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight; ;
                    Account_Balance.Anchor = AnchorStyles.Right;
                    Account_Balance.Top = ((i + 1) * 50) + 145;
                    Account_Balance.Width = 100;
                    Account_Balance.Left = 0;
                    //Add controls to form
                    this.Controls.Add(Account_Name_ID);
                    this.Controls.Add(Account_Status);
                    this.Controls.Add(Account_Type);
                    this.Controls.Add(Account_Balance);
                }
            }
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreateAccount start = new FrmCreateAccount();
            start.Show();
            this.Hide();
        }

        private void chkClosedAcc_CheckedChanged(object sender, EventArgs e)
        {
            if(!DisplayAccount.ClosedAccount)
            {
                DisplayAccount.i++;
            }
            
            if (DisplayAccount.i % 2 == 0)
            { 
                if (DisplayAccount.ClosedAccount)
                {
                    DisplayAccount.ClosedAccount = false;
                }
                else
                {
                    DisplayAccount.ClosedAccount = true;
                    DisplayAccount.i++;
                }
                Controls.Clear();
                InitializeComponent();
                lblFullName.Text = Customer.Fname + " " + Customer.Lname;
                CheckAndDisplayAccounts(DisplayAccount.ClosedAccount);
                chkClosedAcc.Checked = DisplayAccount.ClosedAccount;
                DisplayAccount.i++;
            }
        }

        private void llbCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCreateAccount start = new FrmCreateAccount();
            start.Show();
            this.Hide();
        }
    }
}
