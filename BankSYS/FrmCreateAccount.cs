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
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount()
        {
            InitializeComponent();
        }

        private void mnu_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            FrmDisplayAccounts start = new FrmDisplayAccounts();
            start.Show();
            this.Hide();
        }

        private void FrmCreatAccount_Load(object sender, EventArgs e)
        { 
            string[] AccountTypes = { "typeid", "type_name", "Account_type" };
            DataSet AccountTypesds = new DataSet();
            try
            {
                AccountTypesds = FillfromDB.dsfromsql(AccountTypes);
                cboAccountType.ValueMember = "typeid";
                cboAccountType.DisplayMember = "type_name";
                cboAccountType.DataSource = AccountTypesds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 00: Could not connect to database. Please contact an administratior");
            }
            lblDisplayName.Text = cboAccountType.Text;
        }

        private void txtAccountName_TextChanged(object sender, EventArgs e)
        {
            if(txtAccountName.Text.Length.Equals(0))
            {
                lblDisplayName.Text = cboAccountType.Text;
            }
            else
            {
                lblDisplayName.Text = txtAccountName.Text + " - " + cboAccountType.Text;
            }
            
        }

        private void cboAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lblDisplayName.Text.IndexOf(" - ").Equals(-1))
            {
                lblDisplayName.Text = cboAccountType.Text;
            }
            else
            {
                lblDisplayName.Text = txtAccountName.Text + " - " + cboAccountType.Text;
            }
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Validation v = new Validation();
            String AccountName = txtAccountName.Text;
            String AccountType = cboAccountType.SelectedValue.ToString();
            String DateCreated = DateTime.Today.ToString();
            if(v.IsEmpty(AccountName))
            {
                errorProvider.SetError(txtAccountName, "Please enter an account name");
            }
            else if(v.IsAccount(AccountName))
            {
                MessageBox.Show("valid account");
            }
            else
            {
                errorProvider.SetError(txtAccountName, "Account name cannot contain special characters");
            }


        }
    }
}
