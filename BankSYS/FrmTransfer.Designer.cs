
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCreditorAccount = new System.Windows.Forms.Label();
            this.lblCreditorNote = new System.Windows.Forms.Label();
            this.lblCreditorAmount = new System.Windows.Forms.Label();
            this.lblDebtorAccount = new System.Windows.Forms.Label();
            this.cboCreditorAccount = new System.Windows.Forms.ComboBox();
            this.txtCreditorNote = new System.Windows.Forms.TextBox();
            this.txtCreditorAmount = new System.Windows.Forms.TextBox();
            this.txtDebtorAccount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
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
            this.createAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.lblCreditorAccount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCreditorNote, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCreditorAmount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDebtorAccount, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboCreditorAccount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCreditorNote, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCreditorAmount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDebtorAccount, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 313);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCreditorAccount
            // 
            this.lblCreditorAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCreditorAccount.AutoSize = true;
            this.lblCreditorAccount.Location = new System.Drawing.Point(347, 71);
            this.lblCreditorAccount.Name = "lblCreditorAccount";
            this.lblCreditorAccount.Size = new System.Drawing.Size(50, 13);
            this.lblCreditorAccount.TabIndex = 0;
            this.lblCreditorAccount.Text = "Account:";
            // 
            // lblCreditorNote
            // 
            this.lblCreditorNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCreditorNote.AutoSize = true;
            this.lblCreditorNote.Location = new System.Drawing.Point(316, 123);
            this.lblCreditorNote.Name = "lblCreditorNote";
            this.lblCreditorNote.Size = new System.Drawing.Size(81, 13);
            this.lblCreditorNote.TabIndex = 1;
            this.lblCreditorNote.Text = "(Optional) Note:";
            // 
            // lblCreditorAmount
            // 
            this.lblCreditorAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCreditorAmount.AutoSize = true;
            this.lblCreditorAmount.Location = new System.Drawing.Point(351, 175);
            this.lblCreditorAmount.Name = "lblCreditorAmount";
            this.lblCreditorAmount.Size = new System.Drawing.Size(46, 13);
            this.lblCreditorAmount.TabIndex = 2;
            this.lblCreditorAmount.Text = "Amount:";
            // 
            // lblDebtorAccount
            // 
            this.lblDebtorAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDebtorAccount.AutoSize = true;
            this.lblDebtorAccount.Location = new System.Drawing.Point(314, 227);
            this.lblDebtorAccount.Name = "lblDebtorAccount";
            this.lblDebtorAccount.Size = new System.Drawing.Size(83, 13);
            this.lblDebtorAccount.TabIndex = 3;
            this.lblDebtorAccount.Text = "Account to Pay:";
            // 
            // cboCreditorAccount
            // 
            this.cboCreditorAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCreditorAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCreditorAccount.FormattingEnabled = true;
            this.cboCreditorAccount.Location = new System.Drawing.Point(403, 67);
            this.cboCreditorAccount.Name = "cboCreditorAccount";
            this.cboCreditorAccount.Size = new System.Drawing.Size(258, 21);
            this.cboCreditorAccount.TabIndex = 5;
            // 
            // txtCreditorNote
            // 
            this.txtCreditorNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCreditorNote.Location = new System.Drawing.Point(403, 120);
            this.txtCreditorNote.MaxLength = 15;
            this.txtCreditorNote.Name = "txtCreditorNote";
            this.txtCreditorNote.Size = new System.Drawing.Size(121, 20);
            this.txtCreditorNote.TabIndex = 6;
            // 
            // txtCreditorAmount
            // 
            this.txtCreditorAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCreditorAmount.Location = new System.Drawing.Point(403, 172);
            this.txtCreditorAmount.MaxLength = 10;
            this.txtCreditorAmount.Name = "txtCreditorAmount";
            this.txtCreditorAmount.Size = new System.Drawing.Size(121, 20);
            this.txtCreditorAmount.TabIndex = 7;
            // 
            // txtDebtorAccount
            // 
            this.txtDebtorAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDebtorAccount.Location = new System.Drawing.Point(403, 224);
            this.txtDebtorAccount.MaxLength = 32;
            this.txtDebtorAccount.Name = "txtDebtorAccount";
            this.txtDebtorAccount.Size = new System.Drawing.Size(228, 20);
            this.txtDebtorAccount.TabIndex = 8;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTransfer.Location = new System.Drawing.Point(335, 3);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransfer";
            this.Load += new System.EventHandler(this.FrmTransfer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDebtorAccount;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateCustomerToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}