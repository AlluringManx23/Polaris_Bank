using System;
using System.Data;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmRegesterUserData : Form
    {
        public FrmRegesterUserData()
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Validation v = new Validation();
            bool valid = true;

            Customer.Fname = txtfname.Text;
            Customer.Lname = txtlname.Text;
            Customer.CountryCode = cboCountryCode.SelectedValue.ToString();
            Customer.PhoneNo = txtphoneno.Text;
            Customer.DOB = dtpdob.Value.ToString("dd-MM-yyyy");
            Customer.AddressL1 = txtAddl1.Text;
            Customer.AddressL2 = txtAddl2.Text;
            Customer.AddressL3 = txtAddl3.Text;
            Customer.County = cboCounty.SelectedValue.ToString();
            Customer.Town = txttown.Text;
            Customer.Eir = txteir.Text;

            //making things uppercase
            Customer.Eir = Customer.Eir.ToUpper();

            errorprovider.Clear();

            if (!v.IsAlphabeticNoSpace(Customer.Fname))
            {
                errorprovider.SetError(txtfname, "First name must only contain letters");
                valid = false;
            }
            if (!v.IsAlphabeticNoSpace(Customer.Lname))
            {
                errorprovider.SetError(txtlname, "Last name must only contain letters");
                valid = false;
            }
            if (!v.IsNumeric(Customer.PhoneNo))
            {
                errorprovider.SetError(txtphoneno, "phone number must only contain numbers");
                valid = false;
            }
            if (v.IsEmpty(Customer.CountryCode))
            {
                errorprovider.SetError(cboCountryCode, "Please select a country code");
                valid = false;
            }
            if (v.IsEmpty(Customer.AddressL1))
            {
                errorprovider.SetError(txtAddl1, "Please enter an address");
                valid = false;
            }
            if (v.IsEmpty(Customer.County))
            {
                errorprovider.SetError(cboCounty, "Please select a county");
                valid = false;
            }
            if (!v.IsAlphabetic(Customer.Town))
            {
                errorprovider.SetError(txttown, "Town must only be alphabetic");
                valid = false;
            }
            if (!v.IsEir(Customer.Eir))
            {
                errorprovider.SetError(txteir, "Please enter a valid eircode");
                valid = false;
            }

            if (valid.Equals(true))
            {
                Customer.Fname = char.ToUpper(Customer.Fname[0]) + Customer.Fname.Substring(1);
                Customer.Lname = char.ToUpper(Customer.Lname[0]) + Customer.Lname.Substring(1);

                if (!Customer.Eir.Contains(" "))
                {
                    Customer.Eir = Customer.Eir.Substring(0, 3) + " " + Customer.Eir.Substring(3, 4);
                }
                Customer.DateCreated = DateTime.Now.ToString("dd-MM-yyyy");
                try
                {
                    Customer.Lname = Customer.Lname.Replace("'", "''");
                    CustomerSQL.AddUser();

                    MessageBox.Show("Your Customer ID is " + Customer.CustomerId + ". \nPlease use this to login");

                    FrmStartScreen s = new FrmStartScreen();
                    s.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Error 004: Could not connect to database. Please contact an administratior");
                }

            }
        }

        private void FrmCreateAccount_Load(object sender, EventArgs e)
        {
            dtpdob.MaxDate = DateTime.Today;
            
            string[] countryarr = { "countryid", "CONCAT(country,CONCAT(' ',CONCAT('(',CONCAT(code,')')))) AS country", "country_code" };
            string[] countyarr = { "countyid", "county", "county" };
            DataSet countryds = new DataSet();
            DataSet countyds = new DataSet();
            try
            {
            countryds = ReusableSQL.dsfromsql(countryarr);
            cboCountryCode.ValueMember = "countryid";
            cboCountryCode.DisplayMember = "country";
            cboCountryCode.DataSource = countryds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 002: Could not connect to database. Please contact an administratior");
            }
            try { 
            countyds = ReusableSQL.dsfromsql(countyarr);
            cboCounty.ValueMember = "countyid";
            cboCounty.DisplayMember = "county";
            cboCounty.DataSource = countyds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 003: Could not connect to database. Please contact an administratior");
            }
        }

        private void MnuBack_Click(object sender, EventArgs e)
        {
            FrmRegesterLoginData Reg = new FrmRegesterLoginData();
            Reg.Show();
            this.Hide();
        }
    }
}