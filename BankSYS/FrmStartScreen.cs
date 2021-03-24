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
            FrmRegesterLoginData Reg = new FrmRegesterLoginData();
            Reg.Show();
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

        private void MnuCloseAccount_Click(object sender, EventArgs e)
        {
            FrmCloseAccount Close = new FrmCloseAccount();
            Close.Show();
            this.Hide();
        }

        private void lnkRegesterCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegesterLoginData Reg = new FrmRegesterLoginData();
            Reg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
