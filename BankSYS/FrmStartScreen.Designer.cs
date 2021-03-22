
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
            this.MnuDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MnuStartScreen.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.MnuCreateAccount.Size = new System.Drawing.Size(160, 22);
            this.MnuCreateAccount.Text = "Create Account";
            this.MnuCreateAccount.Click += new System.EventHandler(this.MnuCreateAccount_Click);
            // 
            // MnuUpdateAccount
            // 
            this.MnuUpdateAccount.Name = "MnuUpdateAccount";
            this.MnuUpdateAccount.Size = new System.Drawing.Size(160, 22);
            this.MnuUpdateAccount.Text = "Update Account";
            // 
            // MnuCloseAccount
            // 
            this.MnuCloseAccount.Name = "MnuCloseAccount";
            this.MnuCloseAccount.Size = new System.Drawing.Size(160, 22);
            this.MnuCloseAccount.Text = "Close Account";
            this.MnuCloseAccount.Click += new System.EventHandler(this.MnuCloseAccount_Click);
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
            // MnuDeposit
            // 
            this.MnuDeposit.Name = "MnuDeposit";
            this.MnuDeposit.Size = new System.Drawing.Size(125, 22);
            this.MnuDeposit.Text = "Deposit";
            // 
            // MnuWithdraw
            // 
            this.MnuWithdraw.Name = "MnuWithdraw";
            this.MnuWithdraw.Size = new System.Drawing.Size(125, 22);
            this.MnuWithdraw.Text = "Withdraw";
            // 
            // MnuTransfer
            // 
            this.MnuTransfer.Name = "MnuTransfer";
            this.MnuTransfer.Size = new System.Drawing.Size(125, 22);
            this.MnuTransfer.Text = "Transfer";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // MnuClose
            // 
            this.MnuClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MnuClose.Name = "MnuClose";
            this.MnuClose.Size = new System.Drawing.Size(48, 20);
            this.MnuClose.Text = "Close";
            this.MnuClose.Click += new System.EventHandler(this.MnuClose_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(267, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(261, 79);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Polaris Bank";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.lblName);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(531, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(261, 73);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(261, 73);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.3125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.6875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.63006F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.36994F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 344);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(323, 171);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // FrmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MnuStartScreen);
            this.MainMenuStrip = this.MnuStartScreen;
            this.Name = "FrmStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Start screen";
            this.MnuStartScreen.ResumeLayout(false);
            this.MnuStartScreen.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem MnuClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

