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

        private void MnuExit_Click(object sender, EventArgs e)
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
            lblname.Text = Customer.Fname + " " + Customer.Lname;
            DataSet Accounts = new DataSet(); 
            //Accounts = FillfromDB.getAccounts();
            if(Accounts.Equals(null))
            {
                LblNoAcc.Text = "You don't have an account ";
            }
        }

        private void lnkRegesterAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCreateAccount start = new FrmCreateAccount();
            start.Show();
            this.Hide();
        }
    }
}
