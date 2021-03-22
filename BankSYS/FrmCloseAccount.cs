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
    public partial class FrmCloseAccount : Form
    {
        public FrmCloseAccount()
        {
            InitializeComponent();
        }

        private void FrmCloseAccount_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < grdAccount.Columns.Count - 1; i++)
            {
                grdAccount.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            grdAccount.Columns[grdAccount.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < grdAccount.Columns.Count; i++)
            {
                int colw = grdAccount.Columns[i].Width;
                grdAccount.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                grdAccount.Columns[i].Width = colw;
            }
        }
    }
}
