
namespace BankSYS
{
    partial class FrmStartScreen
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
            this.MnuStartScreen = new System.Windows.Forms.MenuStrip();
            this.MnuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStartScreen.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStartScreen
            // 
            this.MnuStartScreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAccount,
            this.moneyToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.MnuClose});
            this.MnuStartScreen.Location = new System.Drawing.Point(0, 0);
            this.MnuStartScreen.Name = "MnuStartScreen";
            this.MnuStartScreen.Size = new System.Drawing.Size(800, 24);
            this.MnuStartScreen.TabIndex = 0;
            this.MnuStartScreen.Text = "menuStrip1";
            // 
            // MnuAccount
            // 
            this.MnuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCreateAccount,
            this.MnuUpdateAccount,
            this.MnuCloseAccount});
            this.MnuAccount.Name = "MnuAccount";
            this.MnuAccount.Size = new System.Drawing.Size(64, 20);
            this.MnuAccount.Text = "Account";
            // 
            // MnuCreateAccount
            // 
            this.MnuCreateAccount.Name = "MnuCreateAccount";
            this.MnuCreateAccount.Size = new System.Drawing.Size(180, 22);
            this.MnuCreateAccount.Text = "Create Account";
            this.MnuCreateAccount.Click += new System.EventHandler(this.MnuCreateAccount_Click);
            // 
            // MnuUpdateAccount
            // 
            this.MnuUpdateAccount.Name = "MnuUpdateAccount";
            this.MnuUpdateAccount.Size = new System.Drawing.Size(180, 22);
            this.MnuUpdateAccount.Text = "Update Account";
            // 
            // MnuCloseAccount
            // 
            this.MnuCloseAccount.Name = "MnuCloseAccount";
            this.MnuCloseAccount.Size = new System.Drawing.Size(180, 22);
            this.MnuCloseAccount.Text = "Close Account";
            // 
            // moneyToolStripMenuItem
            // 
            this.moneyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDeposit,
            this.MnuWithdraw,
            this.MnuTransfer});
            this.moneyToolStripMenuItem.Name = "moneyToolStripMenuItem";
            this.moneyToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.moneyToolStripMenuItem.Text = "Money";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // MnuDeposit
            // 
            this.MnuDeposit.Name = "MnuDeposit";
            this.MnuDeposit.Size = new System.Drawing.Size(180, 22);
            this.MnuDeposit.Text = "Deposit";
            // 
            // MnuWithdraw
            // 
            this.MnuWithdraw.Name = "MnuWithdraw";
            this.MnuWithdraw.Size = new System.Drawing.Size(180, 22);
            this.MnuWithdraw.Text = "Withdraw";
            // 
            // MnuTransfer
            // 
            this.MnuTransfer.Name = "MnuTransfer";
            this.MnuTransfer.Size = new System.Drawing.Size(180, 22);
            this.MnuTransfer.Text = "Transfer";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(160, 140);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(480, 140);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Polaris Bank";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 422);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MnuClose
            // 
            this.MnuClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MnuClose.Name = "MnuClose";
            this.MnuClose.Size = new System.Drawing.Size(48, 20);
            this.MnuClose.Text = "Close";
            this.MnuClose.Click += new System.EventHandler(this.MnuClose_Click);
            // 
            // FrmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MnuStartScreen);
            this.MainMenuStrip = this.MnuStartScreen;
            this.Name = "FrmStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Start screen";
            this.MnuStartScreen.ResumeLayout(false);
            this.MnuStartScreen.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStartScreen;
        private System.Windows.Forms.ToolStripMenuItem MnuAccount;
        private System.Windows.Forms.ToolStripMenuItem MnuCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem MnuUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem MnuCloseAccount;
        private System.Windows.Forms.ToolStripMenuItem moneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuDeposit;
        private System.Windows.Forms.ToolStripMenuItem MnuWithdraw;
        private System.Windows.Forms.ToolStripMenuItem MnuTransfer;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem MnuClose;
    }
}

