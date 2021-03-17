
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
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtppsno = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.LblPhoneNo = new System.Windows.Forms.Label();
            this.LblPPSNo = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.LblFname = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MnuCreateCustomer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // dtpdob
            // 
            this.dtpdob.Location = new System.Drawing.Point(186, 100);
            this.dtpdob.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.dtpdob.MinDate = new System.DateTime(1903, 1, 1, 0, 0, 0, 0);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(147, 20);
            this.dtpdob.TabIndex = 5;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(640, 390);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(148, 48);
            this.BtnSubmit.TabIndex = 20;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(186, 102);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(146, 20);
            this.textBox10.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(524, 57);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(143, 20);
            this.textBox9.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(186, 12);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(146, 20);
            this.textBox8.TabIndex = 17;
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(524, 56);
            this.txtphoneno.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtphoneno.MaxLength = 14;
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(143, 20);
            this.txtphoneno.TabIndex = 4;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(524, 12);
            this.txtlname.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(143, 20);
            this.txtlname.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(524, 12);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 20);
            this.textBox4.TabIndex = 5;
            // 
            // txtppsno
            // 
            this.txtppsno.Location = new System.Drawing.Point(186, 56);
            this.txtppsno.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtppsno.MaxLength = 9;
            this.txtppsno.Name = "txtppsno";
            this.txtppsno.Size = new System.Drawing.Size(146, 20);
            this.txtppsno.TabIndex = 3;
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.SystemColors.Window;
            this.txtfname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtfname.Location = new System.Drawing.Point(186, 12);
            this.txtfname.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(146, 20);
            this.txtfname.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address Line 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Eir Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "County:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Town:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address Line 1:";
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.Location = new System.Drawing.Point(93, 103);
            this.LblDOB.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(71, 13);
            this.LblDOB.TabIndex = 4;
            this.LblDOB.Text = "Date Of Birth:";
            // 
            // LblPhoneNo
            // 
            this.LblPhoneNo.AutoSize = true;
            this.LblPhoneNo.Location = new System.Drawing.Point(431, 59);
            this.LblPhoneNo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblPhoneNo.Name = "LblPhoneNo";
            this.LblPhoneNo.Size = new System.Drawing.Size(81, 13);
            this.LblPhoneNo.TabIndex = 3;
            this.LblPhoneNo.Text = "Phone Number:";
            // 
            // LblPPSNo
            // 
            this.LblPPSNo.AutoSize = true;
            this.LblPPSNo.Location = new System.Drawing.Point(93, 59);
            this.LblPPSNo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblPPSNo.Name = "LblPPSNo";
            this.LblPPSNo.Size = new System.Drawing.Size(71, 13);
            this.LblPPSNo.TabIndex = 2;
            this.LblPPSNo.Text = "PPS Number:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(431, 15);
            this.lblLname.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(61, 13);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name:";
            // 
            // LblFname
            // 
            this.LblFname.AutoSize = true;
            this.LblFname.Location = new System.Drawing.Point(93, 15);
            this.LblFname.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblFname.Name = "LblFname";
            this.LblFname.Size = new System.Drawing.Size(60, 13);
            this.LblFname.TabIndex = 0;
            this.LblFname.Text = "First Name:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.00114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00589F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.00114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00589F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66373F));
            this.tableLayoutPanel1.Controls.Add(this.txtfname, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLname, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtlname, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtppsno, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtphoneno, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblPhoneNo, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblPPSNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblDOB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpdob, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblFname, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 134);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(0, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 177);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6611F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.00114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00589F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6611F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.00114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00589F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66373F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox9, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox10, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 135);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.comboBox1.Location = new System.Drawing.Point(186, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MnuCreateCustomer);
            this.Controls.Add(this.BtnSubmit);
            this.MainMenuStrip = this.MnuCreateCustomer;
            this.Name = "FrmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Customer";
            this.MnuCreateCustomer.ResumeLayout(false);
            this.MnuCreateCustomer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtppsno;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.Label LblPhoneNo;
        private System.Windows.Forms.Label LblPPSNo;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label LblFname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}