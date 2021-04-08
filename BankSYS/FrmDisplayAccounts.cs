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
        }
    }
}
