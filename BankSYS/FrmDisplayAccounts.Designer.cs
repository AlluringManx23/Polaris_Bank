
namespace BankSYS
{
    partial class FrmDisplayAccounts
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
            this.chkClosedAcc = new System.Windows.Forms.CheckBox();
            this.mnuDisplayAccounts = new System.Windows.Forms.MenuStrip();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTerminateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpNoAccount = new System.Windows.Forms.TableLayoutPanel();
            this.llbCreateAccount = new System.Windows.Forms.LinkLabel();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lblAccountSum = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayAccounts.SuspendLayout();
            this.tlpNoAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkClosedAcc
            // 
            this.chkClosedAcc.AutoSize = true;
            this.chkClosedAcc.Location = new System.Drawing.Point(610, 38);
            this.chkClosedAcc.Name = "chkClosedAcc";
            this.chkClosedAcc.Size = new System.Drawing.Size(136, 17);
            this.chkClosedAcc.TabIndex = 6;
            this.chkClosedAcc.Text = "Show Closed Accounts";
            this.chkClosedAcc.UseVisualStyleBackColor = true;
            this.chkClosedAcc.CheckedChanged += new System.EventHandler(this.chkClosedAcc_CheckedChanged);
            // 
            // mnuDisplayAccounts
            // 
            this.mnuDisplayAccounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomer,
            this.mnuAccount,
            this.mnuTransaction,
            this.mnuExit,
            this.reportToolStripMenuItem});
            this.mnuDisplayAccounts.Location = new System.Drawing.Point(0, 0);
            this.mnuDisplayAccounts.Name = "mnuDisplayAccounts";
            this.mnuDisplayAccounts.Size = new System.Drawing.Size(784, 24);
            this.mnuDisplayAccounts.TabIndex = 1;
            this.mnuDisplayAccounts.Text = "menuStrip2";
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdateCustomer,
            this.mnuTerminateCustomer});
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(71, 20);
            this.mnuCustomer.Text = "Customer";
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(181, 22);
            this.mnuUpdateCustomer.Text = "Update Customer";
            this.mnuUpdateCustomer.Click += new System.EventHandler(this.mnuUpdateCustomer_Click);
            // 
            // mnuTerminateCustomer
            // 
            this.mnuTerminateCustomer.Name = "mnuTerminateCustomer";
            this.mnuTerminateCustomer.Size = new System.Drawing.Size(181, 22);
            this.mnuTerminateCustomer.Text = "Terminate Customer";
            this.mnuTerminateCustomer.Click += new System.EventHandler(this.mnuTerminateCustomer_Click);
            // 
            // mnuAccount
            // 
            this.mnuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateAccount,
            this.mnuUpdateAccount,
            this.mnuCloseAccount});
            this.mnuAccount.Name = "mnuAccount";
            this.mnuAccount.Size = new System.Drawing.Size(64, 20);
            this.mnuAccount.Text = "Account";
            // 
            // mnuCreateAccount
            // 
            this.mnuCreateAccount.Name = "mnuCreateAccount";
            this.mnuCreateAccount.Size = new System.Drawing.Size(160, 22);
            this.mnuCreateAccount.Text = "Create Account";
            this.mnuCreateAccount.Click += new System.EventHandler(this.mnuCreateAccount_Click);
            // 
            // mnuUpdateAccount
            // 
            this.mnuUpdateAccount.Name = "mnuUpdateAccount";
            this.mnuUpdateAccount.Size = new System.Drawing.Size(160, 22);
            this.mnuUpdateAccount.Text = "Update Account";
            this.mnuUpdateAccount.Click += new System.EventHandler(this.mnuUpdateAccount_Click);
            // 
            // mnuCloseAccount
            // 
            this.mnuCloseAccount.Name = "mnuCloseAccount";
            this.mnuCloseAccount.Size = new System.Drawing.Size(160, 22);
            this.mnuCloseAccount.Text = "Close Account";
            this.mnuCloseAccount.Click += new System.EventHandler(this.mnuCloseAccount_Click);
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
            this.mnuDeposit.Size = new System.Drawing.Size(125, 22);
            this.mnuDeposit.Text = "Deposit";
            this.mnuDeposit.Click += new System.EventHandler(this.mnuDeposit_Click);
            // 
            // mnuWithdraw
            // 
            this.mnuWithdraw.Name = "mnuWithdraw";
            this.mnuWithdraw.Size = new System.Drawing.Size(125, 22);
            this.mnuWithdraw.Text = "Withdraw";
            this.mnuWithdraw.Click += new System.EventHandler(this.mnuWithdraw_Click);
            // 
            // mnuTransfer
            // 
            this.mnuTransfer.Name = "mnuTransfer";
            this.mnuTransfer.Size = new System.Drawing.Size(125, 22);
            this.mnuTransfer.Text = "Transfer";
            this.mnuTransfer.Click += new System.EventHandler(this.mnuTransfer_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tlpNoAccount
            // 
            this.tlpNoAccount.ColumnCount = 3;
            this.tlpNoAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNoAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpNoAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNoAccount.Controls.Add(this.llbCreateAccount, 1, 2);
            this.tlpNoAccount.Controls.Add(this.lblNoAccount, 1, 1);
            this.tlpNoAccount.Location = new System.Drawing.Point(0, 27);
            this.tlpNoAccount.Name = "tlpNoAccount";
            this.tlpNoAccount.RowCount = 4;
            this.tlpNoAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNoAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNoAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNoAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNoAccount.Size = new System.Drawing.Size(784, 433);
            this.tlpNoAccount.TabIndex = 0;
            // 
            // llbCreateAccount
            // 
            this.llbCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llbCreateAccount.AutoSize = true;
            this.llbCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCreateAccount.Location = new System.Drawing.Point(137, 253);
            this.llbCreateAccount.Name = "llbCreateAccount";
            this.llbCreateAccount.Size = new System.Drawing.Size(508, 33);
            this.llbCreateAccount.TabIndex = 2;
            this.llbCreateAccount.TabStop = true;
            this.llbCreateAccount.Text = "Please click here to create an account";
            this.llbCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCreateAccount_LinkClicked);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.Location = new System.Drawing.Point(89, 145);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(604, 33);
            this.lblNoAccount.TabIndex = 1;
            this.lblNoAccount.Text = "You do not currently have an account with us!";
            this.lblNoAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountSum
            // 
            this.lblAccountSum.AutoSize = true;
            this.lblAccountSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountSum.Location = new System.Drawing.Point(10, 38);
            this.lblAccountSum.Name = "lblAccountSum";
            this.lblAccountSum.Size = new System.Drawing.Size(235, 31);
            this.lblAccountSum.TabIndex = 4;
            this.lblAccountSum.Text = "Account Summary";
            this.lblAccountSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(10, 82);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 31);
            this.lblFullName.TabIndex = 5;
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyBalanceToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // monthlyBalanceToolStripMenuItem
            // 
            this.monthlyBalanceToolStripMenuItem.Name = "monthlyBalanceToolStripMenuItem";
            this.monthlyBalanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthlyBalanceToolStripMenuItem.Text = "Monthly Balance";
            this.monthlyBalanceToolStripMenuItem.Click += new System.EventHandler(this.monthlyBalanceToolStripMenuItem_Click);
            // 
            // FrmDisplayAccounts
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tlpNoAccount);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblAccountSum);
            this.Controls.Add(this.chkClosedAcc);
            this.Controls.Add(this.mnuDisplayAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuDisplayAccounts;
            this.MaximizeBox = false;
            this.Name = "FrmDisplayAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Display Accounts";
            this.Load += new System.EventHandler(this.FrmDisplayAccounts_Load);
            this.mnuDisplayAccounts.ResumeLayout(false);
            this.mnuDisplayAccounts.PerformLayout();
            this.tlpNoAccount.ResumeLayout(false);
            this.tlpNoAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDisplayAccounts;
        private System.Windows.Forms.CheckBox chkClosedAcc;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TableLayoutPanel tlpNoAccount;
        private System.Windows.Forms.LinkLabel llbCreateAccount;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Label lblAccountSum;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.ToolStripMenuItem mnuDeposit;
        private System.Windows.Forms.ToolStripMenuItem mnuWithdraw;
        private System.Windows.Forms.ToolStripMenuItem mnuTransfer;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyBalanceToolStripMenuItem;
    }
}