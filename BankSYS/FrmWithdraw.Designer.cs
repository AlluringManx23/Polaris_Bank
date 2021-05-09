
namespace BankSYS
{
    partial class FrmWithdraw
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
            this.mnuWithdraw = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTerminateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpWithdrawInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtWithdrawNote = new System.Windows.Forms.TextBox();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuWithdraw.SuspendLayout();
            this.tlpWithdrawInfo.SuspendLayout();
            this.tlpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuWithdraw
            // 
            this.mnuWithdraw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuCustomer,
            this.mnuAccount,
            this.mnuTransaction,
            this.mnuExit});
            this.mnuWithdraw.Location = new System.Drawing.Point(0, 0);
            this.mnuWithdraw.Name = "mnuWithdraw";
            this.mnuWithdraw.Size = new System.Drawing.Size(784, 24);
            this.mnuWithdraw.TabIndex = 0;
            this.mnuWithdraw.Text = "menuStrip1";
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
            // 
            // mnuTransaction
            // 
            this.mnuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeposit,
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
            this.mnuDeposit.Click += new System.EventHandler(this.mnuDeposit_Click);
            // 
            // mnuTransfer
            // 
            this.mnuTransfer.Name = "mnuTransfer";
            this.mnuTransfer.Size = new System.Drawing.Size(180, 22);
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
            // tlpWithdrawInfo
            // 
            this.tlpWithdrawInfo.ColumnCount = 4;
            this.tlpWithdrawInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpWithdrawInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpWithdrawInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.77551F));
            this.tlpWithdrawInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.47959F));
            this.tlpWithdrawInfo.Controls.Add(this.lblNote, 1, 2);
            this.tlpWithdrawInfo.Controls.Add(this.lblAmount, 1, 3);
            this.tlpWithdrawInfo.Controls.Add(this.txtWithdrawNote, 2, 2);
            this.tlpWithdrawInfo.Controls.Add(this.txtWithdrawAmount, 2, 3);
            this.tlpWithdrawInfo.Controls.Add(this.lblAccount, 1, 0);
            this.tlpWithdrawInfo.Controls.Add(this.cboAccount, 2, 0);
            this.tlpWithdrawInfo.Controls.Add(this.lblBalance, 1, 1);
            this.tlpWithdrawInfo.Controls.Add(this.lblBalanceAmount, 2, 1);
            this.tlpWithdrawInfo.Location = new System.Drawing.Point(0, 27);
            this.tlpWithdrawInfo.Name = "tlpWithdrawInfo";
            this.tlpWithdrawInfo.RowCount = 4;
            this.tlpWithdrawInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpWithdrawInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpWithdrawInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpWithdrawInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpWithdrawInfo.Size = new System.Drawing.Size(784, 281);
            this.tlpWithdrawInfo.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(308, 168);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(79, 13);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "(optional) Note:";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(341, 239);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // txtWithdrawNote
            // 
            this.txtWithdrawNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtWithdrawNote.Location = new System.Drawing.Point(393, 165);
            this.txtWithdrawNote.MaxLength = 15;
            this.txtWithdrawNote.Name = "txtWithdrawNote";
            this.txtWithdrawNote.Size = new System.Drawing.Size(172, 20);
            this.txtWithdrawNote.TabIndex = 4;
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtWithdrawAmount.Location = new System.Drawing.Point(393, 235);
            this.txtWithdrawAmount.MaxLength = 10;
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(64, 20);
            this.txtWithdrawAmount.TabIndex = 5;
            // 
            // lblAccount
            // 
            this.lblAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(337, 57);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(50, 13);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account:";
            // 
            // cboAccount
            // 
            this.cboAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(393, 46);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(261, 21);
            this.cboAccount.TabIndex = 3;
            this.cboAccount.SelectedIndexChanged += new System.EventHandler(this.cboAccount_SelectedIndexChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(338, 98);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance:";
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.Location = new System.Drawing.Point(393, 98);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(0, 13);
            this.lblBalanceAmount.TabIndex = 6;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.Controls.Add(this.btnWithdraw, 1, 0);
            this.tlpButton.Location = new System.Drawing.Point(0, 314);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(784, 115);
            this.tlpButton.TabIndex = 2;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWithdraw.Location = new System.Drawing.Point(334, 33);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(115, 49);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tlpButton);
            this.Controls.Add(this.tlpWithdrawInfo);
            this.Controls.Add(this.mnuWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuWithdraw;
            this.MaximizeBox = false;
            this.Name = "FrmWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Withdraw";
            this.Load += new System.EventHandler(this.FrmWithdraw_Load);
            this.mnuWithdraw.ResumeLayout(false);
            this.mnuWithdraw.PerformLayout();
            this.tlpWithdrawInfo.ResumeLayout(false);
            this.tlpWithdrawInfo.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuWithdraw;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaction;
        private System.Windows.Forms.TableLayoutPanel tlpWithdrawInfo;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cboAccount;
        private System.Windows.Forms.TextBox txtWithdrawNote;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDeposit;
        private System.Windows.Forms.ToolStripMenuItem mnuTransfer;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateAccount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuTerminateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAccount;
    }
}