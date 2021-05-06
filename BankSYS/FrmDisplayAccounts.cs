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
            CheckAndDisplayAccounts(UpdateForm.ClosedAccount);
            if(!UpdateForm.ClosedAccount)
            {
                UpdateForm.i++;
            }
        }

        public void CheckAndDisplayAccounts(bool b)
        {
            int count = AccountSQL.FindActiveAccounts();
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
                    Accountinfo[6] = "ACCOUNT A INNER JOIN ACCOUNT_TYPE T ON A.TYPE = T.ID WHERE CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID ASC";
                }
                else if(!b)
                {
                    Accountinfo[0] = "A.ACCOUNTID";
                    Accountinfo[1] = "A.STATUS";
                    Accountinfo[2] = "A.NAME";
                    Accountinfo[3] = "T.NAME Type";
                    Accountinfo[4] = "A.BALANCE";
                    Accountinfo[5] = "A.DATE_created";
                    Accountinfo[6] = "ACCOUNT A INNER JOIN ACCOUNT_TYPE T ON A.TYPE = T.ID WHERE STATUS = 'A' AND CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID ASC";
                }
                
                DataSet Accounts = new DataSet();
                Accounts = Reusable.dsfromDB(Accountinfo);
                for (int i = 0; i < Accounts.Tables[0].Rows.Count; i++)
                {
                    //Create label
                    Label Account_Name_ID = new Label();
                    Label Account_Status = new Label();
                    Label Account_Type = new Label();
                    Label Account_Balance = new Label();
                    
                    //fill label with data
                    Account_Name_ID.Text = Accounts.Tables[0].Rows[i]["Name"].ToString() + " - " + Accounts.Tables[0].Rows[i]["ACCOUNTID"].ToString();
                    
                    if(Accounts.Tables[0].Rows[i]["STATUS"].ToString() == "A")
                    {
                        Account_Status.Text = "Active";
                    }
                    else if(Accounts.Tables[0].Rows[i]["STATUS"].ToString() == "C")
                    {
                        Account_Status.Text = "Closed";
                    }
                    else
                    {
                        Account_Status.Text = "Unknow";
                    }
                    
                    Account_Type.Text = Accounts.Tables[0].Rows[i]["Type"].ToString();
                    Account_Balance.Text = "€" + Accounts.Tables[0].Rows[i]["BALANCE"].ToString();
                    
                    //lable properties
                    Account_Name_ID.Left = 250;
                    Account_Name_ID.Top = ((i + 1) * 50) + 125;
                    Account_Name_ID.Width = 300;
                    Account_Name_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Account_Name_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    Account_Status.Left = 50;
                    Account_Status.Top = ((i + 1) * 50) + 145;

                    Account_Type.Left = 350;
                    Account_Type.Top = ((i + 1) * 50) + 145;
                    Account_Type.AutoSize = false;
                    Account_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    Account_Type.Width = 100;


                    Account_Balance.AutoSize = false;
                    Account_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    Account_Balance.Top = ((i + 1) * 50) + 145;
                    Account_Balance.Width = 100;
                    Account_Balance.Left = 650;
                    Account_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                    //Add controls to form
                    this.Controls.Add(Account_Name_ID);
                    this.Controls.Add(Account_Status);
                    this.Controls.Add(Account_Type);
                    this.Controls.Add(Account_Balance);
                }
            }
        }
        private void chkClosedAcc_CheckedChanged(object sender, EventArgs e)
        {
            if(!UpdateForm.ClosedAccount)
            {
                UpdateForm.i++;
            }
            
            if (UpdateForm.i % 2 == 0)
            { 
                if (UpdateForm.ClosedAccount)
                {
                    UpdateForm.ClosedAccount = false;
                }
                else
                {
                    UpdateForm.ClosedAccount = true;
                    UpdateForm.i++;
                }
                Controls.Clear();
                InitializeComponent();
                lblFullName.Text = Customer.Fname + " " + Customer.Lname;
                CheckAndDisplayAccounts(UpdateForm.ClosedAccount);
                chkClosedAcc.Checked = UpdateForm.ClosedAccount;
                UpdateForm.i++;
            }
        }

        private void llbCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reusable.resetupdate();
            FrmCreateAccount create = new FrmCreateAccount();
            create.Show();
            this.Hide();
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

        private void closeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tableLayoutPanel1.Visible)
            {
                Reusable.resetupdate();
                FrmCloseAccount close = new FrmCloseAccount();
                close.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You do not curently have an Active account.\nPlease Create one before continuing");
            }
        }

        private void transferToolStripMenuItem1_Click(object sender, EventArgs e)
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
