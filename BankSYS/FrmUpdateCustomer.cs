using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmUpdateCustomer : Form
    {
        public FrmUpdateCustomer()
        {
            InitializeComponent();
        }

        private void FrmUpdateCustomer_Load(object sender, EventArgs e)
        {
            string[] infoarr = { "Status", "Country_Code","county", "Customer Where Customerid = " + Customer.CustomerId };
            string[] countryarr = { "countryid", "CONCAT(country,CONCAT(' ',CONCAT('(',CONCAT(code,')')))) AS country", "country_code" };
            string[] countyarr = { "countyid", "county", "county" };
            DataSet info = new DataSet();
            DataSet countryds = new DataSet();
            DataSet countyds = new DataSet();
            try
            {
                countryds = Reusable.dsfromDB(countryarr);
                cboCountryCode.ValueMember = "countryid";
                cboCountryCode.DisplayMember = "country";
                cboCountryCode.DataSource = countryds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 002: Could not connect to database. Please contact an administratior");
            }
            try
            {
                countyds = Reusable.dsfromDB(countyarr);
                cboCounty.ValueMember = "countyid";
                cboCounty.DisplayMember = "county";
                cboCounty.DataSource = countyds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 003: Could not connect to database. Please contact an administratior");
            }
            try
            {
                info = Reusable.dsfromDB(infoarr);
            }
            catch
            {
                MessageBox.Show("Error 003: Could not connect to database. Please contact an administratior");
            }

            txtCustomerID.Text = Customer.CustomerId;
            if(info.Tables[0].Rows[0][0].ToString().Equals("A"))
            {
                txtStatus.Text = "Active";
            }
            else
            {
                txtStatus.Text = "Terminated";
            }
            txtCreationDate.Text = Customer.DateCreated;
            txtFName.Text = Customer.Fname;
            txtLName.Text = Customer.Lname;
            txtDOB.Text = Customer.DOB;
            txtPPSNo.Text = Customer.PPSNo;
            cboCountryCode.SelectedValue = info.Tables[0].Rows[0][1].ToString();
            txtPhoneNo.Text = Customer.PhoneNo;
            txtAddressL1.Text = Customer.AddressL1;
            txtAddressL2.Text = Customer.AddressL2;
            txtAddressL3.Text = Customer.AddressL3;
            txtTown.Text = Customer.Town;
            cboCounty.SelectedValue = info.Tables[0].Rows[0][2].ToString();
            txtEircode.Text = Customer.Eir;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            Validation v = new Validation();
            bool valid = true;

            //making things uppercase
            Customer.Eir = Customer.Eir.ToUpper();

            errorProvider1.Clear();

            if (!v.IsAlphabeticNoSpace(txtFName.Text))
            {
                errorProvider1.SetError(txtFName, "First name must only contain letters");
                valid = false;
            }
            if (!v.IsAlphabeticNoSpace(txtLName.Text))
            {
                errorProvider1.SetError(txtLName, "Last name must only contain letters");
                valid = false;
            }
            if (!v.IsNumeric(txtPhoneNo.Text))
            {
                errorProvider1.SetError(txtPhoneNo, "phone number must only contain numbers");
                valid = false;
            }
            if (v.IsEmpty(txtAddressL1.Text))
            {
                errorProvider1.SetError(txtAddressL1, "Please enter an address");
                valid = false;
            }
            if (!v.IsAlphabetic(txtTown.Text))
            {
                errorProvider1.SetError(txtTown, "Town must only be alphabetic");
                valid = false;
            }
            if (!v.IsEir(txtEircode.Text))
            {
                errorProvider1.SetError(txtEircode, "Please enter a valid eircode");
                valid = false;
            }

            if (valid.Equals(true))
            {

                Customer.Fname = txtFName.Text;
                Customer.Lname = txtLName.Text;
                Customer.CountryCode = cboCountryCode.SelectedValue.ToString();
                Customer.PhoneNo = txtPhoneNo.Text;
                Customer.AddressL1 = txtAddressL1.Text;
                Customer.AddressL2 = txtAddressL2.Text;
                Customer.AddressL3 = txtAddressL3.Text;
                Customer.County = cboCounty.SelectedValue.ToString();
                Customer.Town = txtTown.Text;
                Customer.Eir = txtEircode.Text;

                Customer.Fname = char.ToUpper(Customer.Fname[0]) + Customer.Fname.Substring(1);
                Customer.Lname = char.ToUpper(Customer.Lname[0]) + Customer.Lname.Substring(1);
                Customer.Lname = Customer.Lname.Replace("'", "''");
                if (!Customer.Eir.Contains(" "))
                {
                    Customer.Eir = Customer.Eir.Substring(0, 3) + " " + Customer.Eir.Substring(3, 4);
                }
                    CustomerSQL.UpdateInfo();

                    MessageBox.Show("Your Information has been updated");

                    CustomerSQL.GetCustInfo();

                    FrmDisplayAccounts Display = new FrmDisplayAccounts();
                    Display.Show();
                    this.Hide();
                    MessageBox.Show("Error 004: Could not connect to database. Please contact an administratior");

            }
        }
    }
}
