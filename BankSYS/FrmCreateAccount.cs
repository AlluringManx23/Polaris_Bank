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
            string fname, lname, ppsno, phoneno,dob,addressl1, addressl2, county, town,eircode;

            fname = txtfname.Text;
            if(!v.IsAlphabeticNoSpace(fname))
            {
                txtfname.BackColor =;
            }
            lname = txtlname.Text;
            ppsno = txtppsno.Text;
            phoneno = txtphoneno.Text;
            dob = dtpdob.Value.ToString("dd-MM-yyyy");
            
            if(v.IsAlphabeticNoSpace(fname) && v.IsAlphabeticNoSpace(lname) && v.IsPPS(ppsno) && v.IsNumeric(phoneno))
            {
                MessageBox.Show(fname + " " + lname + " " + ppsno + " " + phoneno + " " + dob);
            }
            else
            {
                MessageBox.Show("Validation failed");
            }

        }
    }
}
