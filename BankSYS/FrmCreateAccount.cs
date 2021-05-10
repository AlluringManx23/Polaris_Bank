using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount()
        {
            InitializeComponent();
        }

        Account Acc = new Account();

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            string[] AccountTypes = { "id", "name", "Account_type" };
            DataSet AccountTypesds = new DataSet();
            try
            {
                AccountTypesds = Reusable.dsfromDB(AccountTypes);
                cboAccountType.ValueMember = "id";
                cboAccountType.DisplayMember = "name";
                cboAccountType.DataSource = AccountTypesds.Tables[0];
                lblDisplayName.Text = cboAccountType.Text;
            }
            catch
            {
                cboAccountType.Text = "Error!";
                MessageBox.Show("Error 008: Could not connect to database. Please contact an administratior");
            }
            
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

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Validation v = new Validation();
            Acc.Name = txtAccountName.Text;
            Acc.Type = cboAccountType.SelectedValue.ToString();
            Acc.Creation = DateTime.Today.ToString("dd/MM/yyyy");
            if(v.IsEmpty(Acc.Name))
            {
                errorProvider.SetError(txtAccountName, "Please enter an account name");
            }
            else if(!v.IsAccount(Acc.Name))
            {
                errorProvider.SetError(txtAccountName, "Account name cannot contain special characters");
            }
            else if(AccountSQL.AccountNameExists(Acc.Name))
            {
                errorProvider.SetError(txtAccountName, "Account with this name already exists");
            }
            else
            {
                try
                {
                    AccountSQL.AddAccount(ref Acc);
                    MessageBox.Show("You Created a " + cboAccountType.Text + " Account\nwith the name " + Acc.Name);

                    FrmDisplayAccounts start = new FrmDisplayAccounts();
                    start.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Error 009: Could not connect to database. Please contact an administratior\n\nAccount Not Created");
                }
            }
        }
    }
}
