
namespace BankSYS
{
    partial class FrmTransactionChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTerminate = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chtTransactions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuCustomer,
            this.accountToolStripMenuItem,
            this.mnuTransaction,
            this.mnuExit});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(804, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateCustomer,
            this.mnuTerminate});
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(71, 20);
            this.mnuCustomer.Text = "Customer";
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(181, 22);
            this.mnuUpdateCustomer.Text = "Update Customer";
            // 
            // mnuTerminate
            // 
            this.mnuTerminate.Name = "mnuTerminate";
            this.mnuTerminate.Size = new System.Drawing.Size(181, 22);
            this.mnuTerminate.Text = "Terminate Customer";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateAccount,
            this.mnuUpdateAccount,
            this.mnuCloseAccount});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // mnuCreateAccount
            // 
            this.mnuCreateAccount.Name = "mnuCreateAccount";
            this.mnuCreateAccount.Size = new System.Drawing.Size(180, 22);
            this.mnuCreateAccount.Text = "Create Account";
            // 
            // mnuUpdateAccount
            // 
            this.mnuUpdateAccount.Name = "mnuUpdateAccount";
            this.mnuUpdateAccount.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateAccount.Text = "Update Account";
            // 
            // mnuCloseAccount
            // 
            this.mnuCloseAccount.Name = "mnuCloseAccount";
            this.mnuCloseAccount.Size = new System.Drawing.Size(180, 22);
            this.mnuCloseAccount.Text = "Close Account";
            // 
            // mnuTransaction
            // 
            this.mnuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeposit,
            this.mnuWithdraw,
            this.mnuTransfer});
            this.mnuTransaction.Name = "mnuTransaction";
            this.mnuTransaction.Size = new System.Drawing.Size(79, 20);
            this.mnuTransaction.Text = "Transaction";
            // 
            // mnuDeposit
            // 
            this.mnuDeposit.Name = "mnuDeposit";
            this.mnuDeposit.Size = new System.Drawing.Size(180, 22);
            this.mnuDeposit.Text = "Deposit";
            // 
            // mnuWithdraw
            // 
            this.mnuWithdraw.Name = "mnuWithdraw";
            this.mnuWithdraw.Size = new System.Drawing.Size(180, 22);
            this.mnuWithdraw.Text = "Withdraw";
            // 
            // mnuTransfer
            // 
            this.mnuTransfer.Name = "mnuTransfer";
            this.mnuTransfer.Size = new System.Drawing.Size(180, 22);
            this.mnuTransfer.Text = "Transfer";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            // 
            // chtTransactions
            // 
            chartArea2.Name = "ChartArea1";
            this.chtTransactions.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtTransactions.Legends.Add(legend2);
            this.chtTransactions.Location = new System.Drawing.Point(0, 121);
            this.chtTransactions.Name = "chtTransactions";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtTransactions.Series.Add(series2);
            this.chtTransactions.Size = new System.Drawing.Size(804, 338);
            this.chtTransactions.TabIndex = 2;
            this.chtTransactions.Text = "chart1";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(83, 73);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(50, 13);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = "Account:";
            // 
            // cboAccount
            // 
            this.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(139, 70);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(121, 21);
            this.cboAccount.TabIndex = 4;
            this.cboAccount.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(504, 73);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year:";
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(542, 70);
            this.nudYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(120, 20);
            this.nudYear.TabIndex = 6;
            this.nudYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // FrmTransactionChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.chtTransactions);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTransactionChart";
            this.Text = "Polaris Bank - Transaction Chart";
            this.Load += new System.EventHandler(this.FrmTransactionChart_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminate;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuDeposit;
        private System.Windows.Forms.ToolStripMenuItem mnuWithdraw;
        private System.Windows.Forms.ToolStripMenuItem mnuTransfer;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTransactions;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cboAccount;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown nudYear;
    }
}