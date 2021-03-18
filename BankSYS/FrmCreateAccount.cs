using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Data d = new Data();
            bool valid = true;
            
            d.fname = txtfname.Text;
            d.lname = txtlname.Text;
            d.ppsno = txtppsno.Text;
            d.countrycode = cboCountryCode.Text;
            d.phoneno = txtphoneno.Text;
            d.dob = dtpdob.Value.ToString("dd-MM-yyyy");
            d.addressl1 = txtAddl1.Text;
            d.addressl2 = txtAddl2.Text;
            d.addressl3 = txtAddl3.Text;
            d.county = cboCounty.Text;
            d.town = txttown.Text;
            d.eir = txteir.Text;

            //making things uppercase
            d.ppsno = d.ppsno.ToUpper();
            d.eir = d.eir.ToUpper();

            errorprovider.Clear();

            if (!v.IsAlphabeticNoSpace(d.fname))
            {
                errorprovider.SetError(txtfname, "First name must only contain letters");
                valid = false;
            }
            if (!v.IsAlphabeticNoSpace(d.lname))
            {
                errorprovider.SetError(txtlname, "Last name must only contain letters");
                valid = false;
            }
            if (!v.IsPPS(d.ppsno))
            {
                errorprovider.SetError(txtppsno, "PPS number must have 7 numbers and one or 2 letters at the end");
                valid = false;
            }
            if (!v.IsNumeric(d.phoneno))
            {
                errorprovider.SetError(txtphoneno, "phone number must only contain numbers");
                valid = false;
            }
            if (v.IsEmpty(d.countrycode))
            {
                errorprovider.SetError(cboCountryCode, "Please select a country code");
                valid = false;
            }
            if (v.IsEmpty(d.addressl1))
            {
                errorprovider.SetError(txtAddl1, "Please enter an address");
                valid = false;
            }
            if (v.IsEmpty(d.county))
            {
                errorprovider.SetError(cboCounty, "Please select a county");
                valid = false;
            }
            if (!v.IsAlphabetic(d.town))
            {
                errorprovider.SetError(txttown, "Town must only be alphabetic");
                valid = false;
            }
            if (!v.IsEir(d.eir))
            {
                errorprovider.SetError(txteir, "Please enter a valid eircode");
                valid = false;
            }

            if (valid.Equals(true))
            {
                d.fname = char.ToUpper(d.fname[0]) + d.fname.Substring(1);
                d.lname = char.ToUpper(d.lname[0]) + d.lname.Substring(1);
                //getting country phone code from cbobox
                int start = d.countrycode.IndexOf("(") + 1;
                int end = d.countrycode.IndexOf(")", start);
                d.countrycode = d.countrycode.Substring(start, end - start);

                if(!d.eir.Contains(" "))
                {
                    d.eir = d.eir.Substring(0,3) + " " + d.eir.Substring(3, 4);
                }
                d.datecreated = DateTime.Now.ToString("dd-MM-yyyy");
                AccountSQL.AddAccount(d);
                MessageBox.Show("Account created Id=" + d.id.ToString());
                
                FrmStartScreen s = new FrmStartScreen();
                s.Show();
                this.Hide();
                

            }
        }

        private void FrmCreateAccount_Load(object sender, EventArgs e)
        {
            dtpdob.MaxDate = DateTime.Today;
        }
    }
}
