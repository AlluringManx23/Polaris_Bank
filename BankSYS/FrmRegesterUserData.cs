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

        private void MnuClose_Click(object sender, EventArgs e)
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

            Data.Fname = txtfname.Text;
            Data.Lname = txtlname.Text;
            Data.CountryCode = cboCountryCode.SelectedValue.ToString();
            Data.PhoneNo = txtphoneno.Text;
            Data.DOB = dtpdob.Value.ToString("dd-MM-yyyy");
            Data.AddressL1 = txtAddl1.Text;
            Data.AddressL2 = txtAddl2.Text;
            Data.AddressL3 = txtAddl3.Text;
            Data.County = cboCounty.SelectedValue.ToString();
            Data.Town = txttown.Text;
            Data.Eir = txteir.Text;

            //making things uppercase
            Data.Eir = Data.Eir.ToUpper();

            errorprovider.Clear();

            if (!v.IsAlphabeticNoSpace(Data.Fname))
            {
                errorprovider.SetError(txtfname, "First name must only contain letters");
                valid = false;
            }
            if (!v.IsAlphabeticNoSpace(Data.Lname))
            {
                errorprovider.SetError(txtlname, "Last name must only contain letters");
                valid = false;
            }
            if (!v.IsNumeric(Data.PhoneNo))
            {
                errorprovider.SetError(txtphoneno, "phone number must only contain numbers");
                valid = false;
            }
            if (v.IsEmpty(Data.CountryCode))
            {
                errorprovider.SetError(cboCountryCode, "Please select a country code");
                valid = false;
            }
            if (v.IsEmpty(Data.AddressL1))
            {
                errorprovider.SetError(txtAddl1, "Please enter an address");
                valid = false;
            }
            if (v.IsEmpty(Data.County))
            {
                errorprovider.SetError(cboCounty, "Please select a county");
                valid = false;
            }
            if (!v.IsAlphabetic(Data.Town))
            {
                errorprovider.SetError(txttown, "Town must only be alphabetic");
                valid = false;
            }
            if (!v.IsEir(Data.Eir))
            {
                errorprovider.SetError(txteir, "Please enter a valid eircode");
                valid = false;
            }

            if (valid.Equals(true))
            {
                Data.Fname = char.ToUpper(Data.Fname[0]) + Data.Fname.Substring(1);
                Data.Lname = char.ToUpper(Data.Lname[0]) + Data.Lname.Substring(1);

                if (!Data.Eir.Contains(" "))
                {
                    Data.Eir = Data.Eir.Substring(0, 3) + " " + Data.Eir.Substring(3, 4);
                }
                Data.DateCreated = DateTime.Now.ToString("dd-MM-yyyy");
               //try
                //{
                    Data.Lname = Data.Lname.Replace("'", "''");
                    UserSQL.AddUser();
                    
                    MessageBox.Show("Your Customer ID is " + Data.Id + ". \nPlease use this to login");
                    
                    FrmStartScreen s = new FrmStartScreen();
                    s.Show();
                    this.Hide();

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
            countryds = FillfromDB.dsfromsql(countryarr);
            cboCountryCode.ValueMember = "countryid";
            cboCountryCode.DisplayMember = "country";
            cboCountryCode.DataSource = countryds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 002: Could not connect to database. Please contact an administratior");
            }
            try { 
            countyds = FillfromDB.dsfromsql(countyarr);
            cboCounty.ValueMember = "countyid";
            cboCounty.DisplayMember = "county";
            cboCounty.DataSource = countyds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 003: Could not connect to database. Please contact an administratior");
            }
        }
    }
}