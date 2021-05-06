﻿using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmDeposit : Form
    {
        public FrmDeposit()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Transaction T = new Transaction();
            T.amount = txtDepositAmount.Text;
            T.note = txtDepositNote.Text;
            T.account = cboAccount.SelectedValue.ToString();
            T.type = "D";
            Validation v = new Validation();
            bool valid = true;
            if (!v.IsAmount(T.amount) || decimal.Parse(T.amount).Equals(0))
            {
                errorProvider1.SetError(txtDepositAmount, "Amount must only be numbers and in the format 0.00 and greater then 0.01");
                valid = false;
            }
            if ((!v.IsAccount(T.note)) && (!T.note.Equals("")))
            {
                errorProvider1.SetError(txtDepositNote, "Note must not contain any special characters");
                valid = false;
            }

            if (valid)
            {
                string[] findbalance = { "balance", "account where accountid = " + cboAccount.SelectedValue.ToString() };
                string balance = Reusable.stringfromDB(findbalance);
                decimal d1 = decimal.Parse(balance);
                decimal d2 = decimal.Parse(txtDepositAmount.Text);
                decimal d4 = decimal.Parse("9999999.99");
                decimal d3 = d1 + d2;

                if (d3 <= d4)
                {
                    if (MessageBox.Show("Are you sure you want to Deposit €" + T.amount, "Confirm Deposit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            TransactionSQL.Deposit(ref T);
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
                    MessageBox.Show("Woah there! with this deposit you'll have too much money in your account.\nPlease deposit that into another Account");
                }

            }
        }

        private void FrmDeposit_Load(object sender, EventArgs e)
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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisplayAccounts Display = new FrmDisplayAccounts();
            Display.Show();
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

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWithdraw withdraw = new FrmWithdraw();
            withdraw.Show();
            this.Hide();
        }
    }
}
