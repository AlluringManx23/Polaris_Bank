
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.llbCreateAccount = new System.Windows.Forms.LinkLabel();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lblAccountSum = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkClosedAcc
            // 
            this.chkClosedAcc.AutoSize = true;
            this.chkClosedAcc.Location = new System.Drawing.Point(610, 38);
            this.chkClosedAcc.Name = "chkClosedAcc";
            this.chkClosedAcc.Size = new System.Drawing.Size(136, 17);
            this.chkClosedAcc.TabIndex = 0;
            this.chkClosedAcc.Text = "Show Closed Accounts";
            this.chkClosedAcc.UseVisualStyleBackColor = true;
            this.chkClosedAcc.CheckedChanged += new System.EventHandler(this.chkClosedAcc_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCustomerToolStripMenuItem,
            this.terminateCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            // 
            // terminateCustomerToolStripMenuItem
            // 
            this.terminateCustomerToolStripMenuItem.Name = "terminateCustomerToolStripMenuItem";
            this.terminateCustomerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.terminateCustomerToolStripMenuItem.Text = "Terminate Customer";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.updateAccountToolStripMenuItem,
            this.closeAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            // 
            // closeAccountToolStripMenuItem
            // 
            this.closeAccountToolStripMenuItem.Name = "closeAccountToolStripMenuItem";
            this.closeAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.closeAccountToolStripMenuItem.Text = "Close Account";
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.transferToolStripMenuItem.Text = "Transfer";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.llbCreateAccount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNoAccount, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 423);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // llbCreateAccount
            // 
            this.llbCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llbCreateAccount.AutoSize = true;
            this.llbCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCreateAccount.Location = new System.Drawing.Point(146, 246);
            this.llbCreateAccount.Name = "llbCreateAccount";
            this.llbCreateAccount.Size = new System.Drawing.Size(508, 33);
            this.llbCreateAccount.TabIndex = 3;
            this.llbCreateAccount.TabStop = true;
            this.llbCreateAccount.Text = "Please click here to create an account";
            this.llbCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCreateAccount_LinkClicked);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.Location = new System.Drawing.Point(98, 141);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(604, 33);
            this.lblNoAccount.TabIndex = 4;
            this.lblNoAccount.Text = "You do not currently have an account with us!";
            // 
            // lblAccountSum
            // 
            this.lblAccountSum.AutoSize = true;
            this.lblAccountSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountSum.Location = new System.Drawing.Point(10, 38);
            this.lblAccountSum.Name = "lblAccountSum";
            this.lblAccountSum.Size = new System.Drawing.Size(235, 31);
            this.lblAccountSum.TabIndex = 3;
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
            this.lblFullName.TabIndex = 4;
            // 
            // FrmDisplayAccounts
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblAccountSum);
            this.Controls.Add(this.chkClosedAcc);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDisplayAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Accounts";
            this.Load += new System.EventHandler(this.FrmDisplayAccounts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox chkClosedAcc;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel llbCreateAccount;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Label lblAccountSum;
        private System.Windows.Forms.Label lblFullName;
    }
}