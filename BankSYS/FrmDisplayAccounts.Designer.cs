
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
            this.lblname = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transferBetweenAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblNoAcc = new System.Windows.Forms.Label();
            this.lnkRegesterAccount = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(739, 37);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 13);
            this.lblname.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExit,
            this.customerToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuExit
            // 
            this.MnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(38, 20);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDetailsToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.updateDetailsToolStripMenuItem.Text = "Update Details";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.updateAccountToolStripMenuItem,
            this.transferAccountToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            // 
            // transferAccountToolStripMenuItem
            // 
            this.transferAccountToolStripMenuItem.Name = "transferAccountToolStripMenuItem";
            this.transferAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transferAccountToolStripMenuItem.Text = "Transfer Account";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.depositToolStripMenuItem1,
            this.transferBetweenAccountsToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.depositToolStripMenuItem.Text = "Withdraw";
            // 
            // depositToolStripMenuItem1
            // 
            this.depositToolStripMenuItem1.Name = "depositToolStripMenuItem1";
            this.depositToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.depositToolStripMenuItem1.Text = "Deposit";
            // 
            // transferBetweenAccountsToolStripMenuItem
            // 
            this.transferBetweenAccountsToolStripMenuItem.Name = "transferBetweenAccountsToolStripMenuItem";
            this.transferBetweenAccountsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.transferBetweenAccountsToolStripMenuItem.Text = "Transfer Between Accounts";
            // 
            // LblNoAcc
            // 
            this.LblNoAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNoAcc.AutoSize = true;
            this.LblNoAcc.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblNoAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoAcc.Location = new System.Drawing.Point(89, 109);
            this.LblNoAcc.Name = "LblNoAcc";
            this.LblNoAcc.Size = new System.Drawing.Size(621, 31);
            this.LblNoAcc.TabIndex = 2;
            this.LblNoAcc.Text = "You do not currently have an open account with us";
            // 
            // lnkRegesterAccount
            // 
            this.lnkRegesterAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkRegesterAccount.AutoSize = true;
            this.lnkRegesterAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegesterAccount.Location = new System.Drawing.Point(169, 272);
            this.lnkRegesterAccount.Name = "lnkRegesterAccount";
            this.lnkRegesterAccount.Size = new System.Drawing.Size(462, 37);
            this.lnkRegesterAccount.TabIndex = 3;
            this.lnkRegesterAccount.TabStop = true;
            this.lnkRegesterAccount.Text = "Click here to create an Account";
            this.lnkRegesterAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegesterAccount_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.lnkRegesterAccount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblNoAcc, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 418);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // FrmDisplayAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDisplayAccounts";
            this.Text = "FrmDisplayAccounts";
            this.Load += new System.EventHandler(this.FrmDisplayAccounts_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transferBetweenAccountsToolStripMenuItem;
        private System.Windows.Forms.Label LblNoAcc;
        private System.Windows.Forms.LinkLabel lnkRegesterAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}