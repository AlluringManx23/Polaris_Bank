
namespace BankSYS
{
    partial class FrmCreateAccount
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
            this.MnuCreateCustomer = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.MnuCreateCustomer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuCreateCustomer
            // 
            this.MnuCreateCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.moneyToolStripMenuItem,
            this.MnuClose});
            this.MnuCreateCustomer.Location = new System.Drawing.Point(0, 0);
            this.MnuCreateCustomer.Name = "MnuCreateCustomer";
            this.MnuCreateCustomer.Size = new System.Drawing.Size(800, 24);
            this.MnuCreateCustomer.TabIndex = 0;
            this.MnuCreateCustomer.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCreateAccount,
            this.MnuUpdateAccount,
            this.MnuCloseAccount});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // MnuCreateAccount
            // 
            this.MnuCreateAccount.Name = "MnuCreateAccount";
            this.MnuCreateAccount.Size = new System.Drawing.Size(160, 22);
            this.MnuCreateAccount.Text = "Create Account";
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
            // MnuClose
            // 
            this.MnuClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MnuClose.Name = "MnuClose";
            this.MnuClose.Size = new System.Drawing.Size(48, 20);
            this.MnuClose.Text = "Close";
            this.MnuClose.Click += new System.EventHandler(this.MnuClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.287F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 5, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 411);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(8, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(231, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(8, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(231, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(8, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(231, 235);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(8, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(231, 293);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(8, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(573, 61);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(8, 20);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(573, 119);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(8, 20);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(573, 177);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(8, 20);
            this.textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(573, 235);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(10, 20);
            this.textBox9.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(573, 293);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(8, 20);
            this.textBox10.TabIndex = 19;
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MnuCreateCustomer);
            this.MainMenuStrip = this.MnuCreateCustomer;
            this.Name = "FrmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Customer";
            this.MnuCreateCustomer.ResumeLayout(false);
            this.MnuCreateCustomer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuCreateCustomer;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem moneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuDeposit;
        private System.Windows.Forms.ToolStripMenuItem MnuWithdraw;
        private System.Windows.Forms.ToolStripMenuItem MnuTransfer;
        private System.Windows.Forms.ToolStripMenuItem MnuUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem MnuCloseAccount;
        private System.Windows.Forms.ToolStripMenuItem MnuClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
    }
}