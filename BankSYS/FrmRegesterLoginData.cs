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
    public partial class FrmRegesterLoginData : Form
    {
        public FrmRegesterLoginData()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void FrmRegesterLoginData_Load(object sender, EventArgs e)
        {
            txtpacno1.Focus();
        }

        private void txtpacno1_TextChanged(object sender, EventArgs e)
        {
            txtpacno2.Focus();
        }

        private void txtpacno2_TextChanged(object sender, EventArgs e)
        {
            txtpacno3.Focus();
        }

        private void txtpacno3_TextChanged(object sender, EventArgs e)
        {
            txtpacno4.Focus();
        }

        private void txtpacno4_TextChanged(object sender, EventArgs e)
        {
            txtpacno5.Focus();
        }

        private void txtpacno5_TextChanged(object sender, EventArgs e)
        {
            txtppsno.Focus();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
            Data.PPSNo = txtppsno.Text;
            bool valid = true;
            string puc = txtpacno1.Text + txtpacno2.Text + txtpacno3.Text + txtpacno4.Text + txtpacno5.Text;
            Validation v = new Validation();
            errorProvider.Clear();

            if (!v.IsNumeric(puc))
            {
                errorProvider.SetError(txtpacno5, "PAC must only contain numbers");
                valid = false;
            }
            if(!v.IsPPS(Data.PPSNo))
            {
                errorProvider.SetError(txtppsno, "Please enter a valid pps number");
                valid = false;
            }

            if(valid.Equals(true))
            {
                try
                {
                    if(UserSQL.IsInUse(Data.PPSNo))
                    {
                        MessageBox.Show("This PPS number is already regestered to an account.");
                    }
                    else
                    {
                        
                    }
                }
                catch
                {
                    MessageBox.Show("A Database Connection could not be established: Please contact an administer");
                }
            }

        }
    }
}
