using System;
using System.Windows.Forms;

namespace BankSYS
{
    public partial class FrmTerminateCustomer : Form
    {
        public FrmTerminateCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to terminate your account?", "Terminate Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CustomerSQL.TerminateAccount(Customer.CustomerId);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
