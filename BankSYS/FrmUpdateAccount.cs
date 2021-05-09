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
    public partial class FrmUpdateAccount : Form
    {
        public FrmUpdateAccount()
        {
            InitializeComponent();
        }

        private void FrmUpdateAccount_Load(object sender, EventArgs e)
        {
            string[] Accountarr = { "accountid", "CONCAT(Name,CONCAT(' - ',accountid)) AS display_name", "account WHERE Status = 'A' AND CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID" };
            string[] Accounttypearr = { "Code", "Name", "account_type" };
            DataSet Accountds = new DataSet();
            DataSet Accounttypeds = new DataSet();
            try
            {
                Accountds = Reusable.dsfromDB(Accountarr);
                cboAccount.ValueMember = "accountid";
                cboAccount.DisplayMember = "display_name";
                cboAccount.DataSource = Accountds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 006: Could not connect to database. Please contact an administratior");
            }

            try
            {
                Accounttypeds = Reusable.dsfromDB(Accounttypearr);
                cboType.ValueMember = "CODE";
                cboType.DisplayMember = "NAME";
                cboType.DataSource = Accounttypeds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 006: Could not connect to database. Please contact an administratior");
            }
        }

        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Accountinfoarr = { "accountid", "Name","Type", "account WHERE AccountID = " + cboAccount.SelectedValue};
            DataSet Accountinfo = new DataSet();
            try
            {
                Accountinfo = Reusable.dsfromDB(Accountinfoarr);
                txtAccountNumber.Text = Accountinfo.Tables[0].Rows[0][0].ToString();
                txtName.Text = Accountinfo.Tables[0].Rows[0][1].ToString();
                cboType.SelectedValue = Accountinfo.Tables[0].Rows[0][2].ToString();
            }
            catch
            {
                MessageBox.Show("Error 006: Could not connect to database. Please contact an administratior");
            }
        }
    }
}
