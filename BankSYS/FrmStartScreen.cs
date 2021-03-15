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
    public partial class FrmStartScreen : Form
    {
        public FrmStartScreen()
        {
            InitializeComponent();
        }

        private void MnuCreateAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount Account = new FrmCreateAccount();
            Account.Show();
            this.Hide();
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
    }
}
