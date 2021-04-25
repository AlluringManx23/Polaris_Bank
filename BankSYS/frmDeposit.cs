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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string amount = textBox1.Text;
            Validation v = new Validation();
            if(v.IsAmount(amount))
            {
                MessageBox.Show("valid amount");
            }
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            string[] Account = { "accountid", "CONCAT(Account_Name,CONCAT(' - ',accountid)) AS display_name", "account WHERE CUSTOMERID = " + Customer.CustomerId + " ORDER BY ACCOUNTID;" };
            DataSet Accountds = new DataSet();
            try
            {
                Accountds = ReusableSQL.dsfromsql(Account);
                comboBox1.ValueMember = "accountid";
                comboBox1.DisplayMember = "display_name";
                comboBox1.DataSource = Accountds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Error 006: Could not connect to database. Please contact an administratior");
            }
        }
    }
}
