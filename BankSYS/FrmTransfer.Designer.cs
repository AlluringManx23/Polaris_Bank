
namespace BankSYS
{
    partial class FrmTransfer
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
            this.components = new System.ComponentModel.Container();
            this.mnuTransfer = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTerminateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCreditorNote = new System.Windows.Forms.Label();
            this.lblCreditorAmount = new System.Windows.Forms.Label();
            this.lblDebtorAccount = new System.Windows.Forms.Label();
            this.txtCreditorNote = new System.Windows.Forms.TextBox();
            this.txtCreditorAmount = new System.Windows.Forms.TextBox();
            this.txtDebtorAccount = new System.Windows.Forms.TextBox();
            this.lblCreditorAccount = new System.Windows.Forms.Label();
            this.cboCreditorAccount = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransfer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuTransfer
            // 
            this.mnuTransfer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuCustomer,
            this.mnuAccount,
            this.transactionToolStripMenuItem,
            this.mnuExit});
            this.mnuTransfer.Location = new System.Drawing.Point(0, 0);
            this.mnuTransfer.Name = "mnuTransfer";
            this.mnuTransfer.Size = new System.Drawing.Size(804, 24);
            this.mnuTransfer.TabIndex = 0;
            this.mnuTransfer.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
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
            // 
            // mnuTerminateCustomer
            // 
            this.mnuTerminateCustomer.Name = "mnuTerminateCustomer";
            this.mnuTerminateCustomer.Size = new System.Drawing.Size(181, 22);
            this.mnuTerminateCustomer.Text = "Terminate Customer";
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
            this.mnuCreateAccount.Size = new System.Drawing.Size(180, 22);
            this.mnuCreateAccount.Text = "Create Account";
            this.mnuCreateAccount.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeposit,
            this.mnuWithdraw});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // mnuDeposit
            // 
            this.mnuDeposit.Name = "mnuDeposit";
            this.mnuDeposit.Size = new System.Drawing.Size(180, 22);
            this.mnuDeposit.Text = "Deposit";
            this.mnuDeposit.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // mnuWithdraw
            // 
            this.mnuWithdraw.Name = "mnuWithdraw";
            this.mnuWithdraw.Size = new System.Drawing.Size(180, 22);
            this.mnuWithdraw.Text = "Withdraw";
            this.mnuWithdraw.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblCreditorNote, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCreditorAmount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDebtorAccount, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCreditorNote, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCreditorAmount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDebtorAccount, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCreditorAccount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboCreditorAccount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBalance, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBalanceAmount, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 313);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCreditorNote
            // 
            this.lblCreditorNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCreditorNote.AutoSize = true;
            this.lblCreditorNote.Location = new System.Drawing.Point(318, 123);
            this.lblCreditorNote.Name = "lblCreditorNote";
            this.lblCreditorNote.Size = new System.Drawing.Size(81, 13);
            this.lblCreditorNote.TabIndex = 1;
            this.lblCreditorNote.Text = "(Optional) Note:";
            // 
            // lblCreditorAmount
            // 
            this.lblCreditorAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCreditorAmount.AutoSize = true;
            this.lblCreditorAmount.Location = new System.Drawing.Point(353, 175);
            this.lblCreditorAmount.Name = "lblCreditorAmount";
            this.lblCreditorAmount.Size = new System.Drawing.Size(46, 13);
            this.lblCreditorAmount.TabIndex = 2;
            this.lblCreditorAmount.Text = "Amount:";
            // 
            // lblDebtorAccount
            // 
            this.lblDebtorAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDebtorAccount.AutoSize = true;
            this.lblDebtorAccount.Location = new System.Drawing.Point(316, 227);
            this.lblDebtorAccount.Name = "lblDebtorAccount";
            this.lblDebtorAccount.Size = new System.Drawing.Size(83, 13);
            this.lblDebtorAccount.TabIndex = 3;
            this.lblDebtorAccount.Text = "Account to Pay:";
            // 
            // txtCreditorNote
            // 
            this.txtCreditorNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCreditorNote.Location = new System.Drawing.Point(405, 120);
            this.txtCreditorNote.MaxLength = 15;
            this.txtCreditorNote.Name = "txtCreditorNote";
            this.txtCreditorNote.Size = new System.Drawing.Size(121, 20);
            this.txtCreditorNote.TabIndex = 6;
            // 
            // txtCreditorAmount
            // 
            this.txtCreditorAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCreditorAmount.Location = new System.Drawing.Point(405, 172);
            this.txtCreditorAmount.MaxLength = 10;
            this.txtCreditorAmount.Name = "txtCreditorAmount";
            this.txtCreditorAmount.Size = new System.Drawing.Size(121, 20);
            this.txtCreditorAmount.TabIndex = 7;
            // 
            // txtDebtorAccount
            // 
            this.txtDebtorAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDebtorAccount.Location = new System.Drawing.Point(405, 224);
            this.txtDebtorAccount.MaxLength = 32;
            this.txtDebtorAccount.Name = "txtDebtorAccount";
            this.txtDebtorAccount.Size = new System.Drawing.Size(228, 20);
            this.txtDebtorAccount.TabIndex = 8;
            // 
            // lblCreditorAccount
            // 
            this.lblCreditorAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreditorAccount.AutoSize = true;
            this.lblCreditorAccount.Location = new System.Drawing.Point(349, 39);
            this.lblCreditorAccount.Name = "lblCreditorAccount";
            this.lblCreditorAccount.Size = new System.Drawing.Size(50, 13);
            this.lblCreditorAccount.TabIndex = 0;
            this.lblCreditorAccount.Text = "Account:";
            // 
            // cboCreditorAccount
            // 
            this.cboCreditorAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCreditorAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCreditorAccount.FormattingEnabled = true;
            this.cboCreditorAccount.Location = new System.Drawing.Point(405, 28);
            this.cboCreditorAccount.Name = "cboCreditorAccount";
            this.cboCreditorAccount.Size = new System.Drawing.Size(258, 21);
            this.cboCreditorAccount.TabIndex = 5;
            this.cboCreditorAccount.SelectedIndexChanged += new System.EventHandler(this.cboCreditorAccount_SelectedIndexChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(350, 71);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.Text = "Balance:";
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.Location = new System.Drawing.Point(405, 71);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(0, 13);
            this.lblBalanceAmount.TabIndex = 10;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTransfer.Location = new System.Drawing.Point(338, 3);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(127, 57);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnTransfer, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 346);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 113);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
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
            // FrmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mnuTransfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuTransfer;
            this.MaximizeBox = false;
            this.Name = "FrmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransfer";
            this.Load += new System.EventHandler(this.FrmTransfer_Load);
            this.mnuTransfer.ResumeLayout(false);
            this.mnuTransfer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTransfer;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAccount;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDeposit;
        private System.Windows.Forms.ToolStripMenuItem mnuWithdraw;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCreditorAccount;
        private System.Windows.Forms.Label lblCreditorNote;
        private System.Windows.Forms.Label lblCreditorAmount;
        private System.Windows.Forms.Label lblDebtorAccount;
        private System.Windows.Forms.ComboBox cboCreditorAccount;
        private System.Windows.Forms.TextBox txtCreditorNote;
        private System.Windows.Forms.TextBox txtCreditorAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateAccount;
        private System.Windows.Forms.TextBox txtDebtorAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminateCustomer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAccount;
    }
}