
namespace BankSYS
{
    partial class FrmDeposit
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
            this.mnuDeposit = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTerminateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDepositNote = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.tlpDepositInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.tlpDepositButton = new System.Windows.Forms.TableLayoutPanel();
            this.mnuDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tlpDepositInfo.SuspendLayout();
            this.tlpDepositButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuDeposit
            // 
            this.mnuDeposit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit,
            this.mnuCustomer,
            this.mnuAccount,
            this.mnuTransaction});
            this.mnuDeposit.Location = new System.Drawing.Point(0, 0);
            this.mnuDeposit.Name = "mnuDeposit";
            this.mnuDeposit.Size = new System.Drawing.Size(784, 24);
            this.mnuDeposit.TabIndex = 0;
            this.mnuDeposit.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
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
            this.mnuCreateAccount.Size = new System.Drawing.Size(180, 22);
            this.mnuCreateAccount.Text = "Create Account";
            this.mnuCreateAccount.Click += new System.EventHandler(this.mnuCreateAccount_Click);
            // 
            // mnuUpdateAccount
            // 
            this.mnuUpdateAccount.Name = "mnuUpdateAccount";
            this.mnuUpdateAccount.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateAccount.Text = "Update Account";
            this.mnuUpdateAccount.Click += new System.EventHandler(this.mnuUpdateAccount_Click);
            // 
            // mnuCloseAccount
            // 
            this.mnuCloseAccount.Name = "mnuCloseAccount";
            this.mnuCloseAccount.Size = new System.Drawing.Size(180, 22);
            this.mnuCloseAccount.Text = "Close Account";
            this.mnuCloseAccount.Click += new System.EventHandler(this.mnuCloseAccount_Click);
            // 
            // mnuTransaction
            // 
            this.mnuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWithdraw,
            this.mnuTransfer});
            this.mnuTransaction.Name = "mnuTransaction";
            this.mnuTransaction.Size = new System.Drawing.Size(79, 20);
            this.mnuTransaction.Text = "Transaction";
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
            this.mnuTransfer.Size = new System.Drawing.Size(180, 22);
            this.mnuTransfer.Text = "Transfer";
            this.mnuTransfer.Click += new System.EventHandler(this.mnuTransfer_Click);
            // 
            // txtDepositNote
            // 
            this.txtDepositNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDepositNote.Location = new System.Drawing.Point(393, 172);
            this.txtDepositNote.MaxLength = 15;
            this.txtDepositNote.Name = "txtDepositNote";
            this.txtDepositNote.Size = new System.Drawing.Size(172, 20);
            this.txtDepositNote.TabIndex = 5;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.Location = new System.Drawing.Point(332, 26);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(119, 49);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(337, 60);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(50, 13);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "Account:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboAccount
            // 
            this.cboAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(393, 49);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(262, 21);
            this.cboAccount.TabIndex = 3;
            this.cboAccount.SelectedIndexChanged += new System.EventHandler(this.cboAccount_SelectedIndexChanged);
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(308, 176);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(79, 13);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "(optional) Note:";
            // 
            // tlpDepositInfo
            // 
            this.tlpDepositInfo.ColumnCount = 4;
            this.tlpDepositInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDepositInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDepositInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.31123F));
            this.tlpDepositInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.94388F));
            this.tlpDepositInfo.Controls.Add(this.txtDepositNote, 2, 2);
            this.tlpDepositInfo.Controls.Add(this.lblNote, 1, 2);
            this.tlpDepositInfo.Controls.Add(this.txtDepositAmount, 2, 3);
            this.tlpDepositInfo.Controls.Add(this.lblAmount, 1, 3);
            this.tlpDepositInfo.Controls.Add(this.lblAccount, 1, 0);
            this.tlpDepositInfo.Controls.Add(this.cboAccount, 2, 0);
            this.tlpDepositInfo.Controls.Add(this.lblBalance, 1, 1);
            this.tlpDepositInfo.Controls.Add(this.lblBalanceAmount, 2, 1);
            this.tlpDepositInfo.Location = new System.Drawing.Point(0, 27);
            this.tlpDepositInfo.Name = "tlpDepositInfo";
            this.tlpDepositInfo.RowCount = 4;
            this.tlpDepositInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDepositInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDepositInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDepositInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDepositInfo.Size = new System.Drawing.Size(784, 294);
            this.tlpDepositInfo.TabIndex = 1;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDepositAmount.Location = new System.Drawing.Point(393, 246);
            this.txtDepositAmount.MaxLength = 10;
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(66, 20);
            this.txtDepositAmount.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(341, 250);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(338, 103);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Balance:";
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.Location = new System.Drawing.Point(393, 103);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(0, 13);
            this.lblBalanceAmount.TabIndex = 9;
            // 
            // tlpDepositButton
            // 
            this.tlpDepositButton.ColumnCount = 3;
            this.tlpDepositButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDepositButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDepositButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDepositButton.Controls.Add(this.btnDeposit, 1, 0);
            this.tlpDepositButton.Location = new System.Drawing.Point(0, 327);
            this.tlpDepositButton.Name = "tlpDepositButton";
            this.tlpDepositButton.RowCount = 1;
            this.tlpDepositButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDepositButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpDepositButton.Size = new System.Drawing.Size(784, 102);
            this.tlpDepositButton.TabIndex = 8;
            // 
            // FrmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tlpDepositButton);
            this.Controls.Add(this.tlpDepositInfo);
            this.Controls.Add(this.mnuDeposit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuDeposit;
            this.MaximizeBox = false;
            this.Name = "FrmDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Deposit";
            this.Load += new System.EventHandler(this.FrmDeposit_Load);
            this.mnuDeposit.ResumeLayout(false);
            this.mnuDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tlpDepositInfo.ResumeLayout(false);
            this.tlpDepositInfo.PerformLayout();
            this.tlpDepositButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDeposit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuWithdraw;
        private System.Windows.Forms.ToolStripMenuItem mnuTransfer;
        private System.Windows.Forms.TextBox txtDepositNote;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboAccount;
        private System.Windows.Forms.TableLayoutPanel tlpDepositButton;
        private System.Windows.Forms.TableLayoutPanel tlpDepositInfo;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAccount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminateCustomer;
    }
}