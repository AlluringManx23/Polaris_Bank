
namespace BankSYS
{
    partial class FrmRegesterUserData
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
            this.txteir = new System.Windows.Forms.TextBox();
            this.txttown = new System.Windows.Forms.TextBox();
            this.txtAddl1 = new System.Windows.Forms.TextBox();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtAddl2 = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.LblAddl2 = new System.Windows.Forms.Label();
            this.Lbleir = new System.Windows.Forms.Label();
            this.LblCounty = new System.Windows.Forms.Label();
            this.Lbltown = new System.Windows.Forms.Label();
            this.LblAddl1 = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.LblPhoneNo = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.LblFname = new System.Windows.Forms.Label();
            this.cboCountryCode = new System.Windows.Forms.ComboBox();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtAddl3 = new System.Windows.Forms.TextBox();
            this.LblAddl3 = new System.Windows.Forms.Label();
            this.errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MnuCreateCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).BeginInit();
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
            this.dtpdob.Location = new System.Drawing.Point(197, 126);
            this.dtpdob.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.dtpdob.MinDate = new System.DateTime(1903, 1, 1, 0, 0, 0, 0);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(147, 20);
            this.dtpdob.TabIndex = 12;
            this.dtpdob.Value = new System.DateTime(2021, 3, 18, 0, 49, 33, 0);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(640, 390);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(148, 48);
            this.BtnSubmit.TabIndex = 29;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txteir
            // 
            this.txteir.Location = new System.Drawing.Point(536, 122);
            this.txteir.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txteir.MaxLength = 8;
            this.txteir.Name = "txteir";
            this.txteir.Size = new System.Drawing.Size(95, 20);
            this.txteir.TabIndex = 28;
            // 
            // txttown
            // 
            this.txttown.Location = new System.Drawing.Point(536, 77);
            this.txttown.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txttown.MaxLength = 22;
            this.txttown.Name = "txttown";
            this.txttown.Size = new System.Drawing.Size(143, 20);
            this.txttown.TabIndex = 24;
            // 
            // txtAddl1
            // 
            this.txtAddl1.Location = new System.Drawing.Point(198, 32);
            this.txtAddl1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtAddl1.MaxLength = 50;
            this.txtAddl1.Name = "txtAddl1";
            this.txtAddl1.Size = new System.Drawing.Size(146, 20);
            this.txtAddl1.TabIndex = 18;
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(536, 86);
            this.txtphoneno.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtphoneno.MaxLength = 14;
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(143, 20);
            this.txtphoneno.TabIndex = 10;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(536, 38);
            this.txtlname.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtlname.MaxLength = 40;
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(143, 20);
            this.txtlname.TabIndex = 6;
            // 
            // txtAddl2
            // 
            this.txtAddl2.Location = new System.Drawing.Point(536, 32);
            this.txtAddl2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtAddl2.MaxLength = 50;
            this.txtAddl2.Name = "txtAddl2";
            this.txtAddl2.Size = new System.Drawing.Size(143, 20);
            this.txtAddl2.TabIndex = 20;
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.SystemColors.Window;
            this.txtfname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtfname.Location = new System.Drawing.Point(198, 38);
            this.txtfname.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtfname.MaxLength = 40;
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(146, 20);
            this.txtfname.TabIndex = 4;
            // 
            // LblAddl2
            // 
            this.LblAddl2.AutoSize = true;
            this.LblAddl2.Location = new System.Drawing.Point(443, 35);
            this.LblAddl2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblAddl2.Name = "LblAddl2";
            this.LblAddl2.Size = new System.Drawing.Size(80, 13);
            this.LblAddl2.TabIndex = 19;
            this.LblAddl2.Text = "Address Line 2:";
            // 
            // Lbleir
            // 
            this.Lbleir.AutoSize = true;
            this.Lbleir.Location = new System.Drawing.Point(443, 125);
            this.Lbleir.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbleir.Name = "Lbleir";
            this.Lbleir.Size = new System.Drawing.Size(50, 13);
            this.Lbleir.TabIndex = 27;
            this.Lbleir.Text = "Eir Code:";
            // 
            // LblCounty
            // 
            this.LblCounty.AutoSize = true;
            this.LblCounty.Location = new System.Drawing.Point(105, 125);
            this.LblCounty.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblCounty.Name = "LblCounty";
            this.LblCounty.Size = new System.Drawing.Size(43, 13);
            this.LblCounty.TabIndex = 25;
            this.LblCounty.Text = "County:";
            // 
            // Lbltown
            // 
            this.Lbltown.AutoSize = true;
            this.Lbltown.Location = new System.Drawing.Point(443, 80);
            this.Lbltown.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbltown.Name = "Lbltown";
            this.Lbltown.Size = new System.Drawing.Size(37, 13);
            this.Lbltown.TabIndex = 23;
            this.Lbltown.Text = "Town:";
            // 
            // LblAddl1
            // 
            this.LblAddl1.AutoSize = true;
            this.LblAddl1.Location = new System.Drawing.Point(105, 35);
            this.LblAddl1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblAddl1.Name = "LblAddl1";
            this.LblAddl1.Size = new System.Drawing.Size(80, 13);
            this.LblAddl1.TabIndex = 17;
            this.LblAddl1.Text = "Address Line 1:";
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.Location = new System.Drawing.Point(105, 129);
            this.LblDOB.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(71, 13);
            this.LblDOB.TabIndex = 11;
            this.LblDOB.Text = "Date Of Birth:";
            // 
            // LblPhoneNo
            // 
            this.LblPhoneNo.AutoSize = true;
            this.LblPhoneNo.Location = new System.Drawing.Point(443, 89);
            this.LblPhoneNo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblPhoneNo.Name = "LblPhoneNo";
            this.LblPhoneNo.Size = new System.Drawing.Size(81, 13);
            this.LblPhoneNo.TabIndex = 9;
            this.LblPhoneNo.Text = "Phone Number:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(443, 41);
            this.lblLname.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(61, 13);
            this.lblLname.TabIndex = 5;
            this.lblLname.Text = "Last Name:";
            // 
            // LblFname
            // 
            this.LblFname.AutoSize = true;
            this.LblFname.Location = new System.Drawing.Point(105, 41);
            this.LblFname.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblFname.Name = "LblFname";
            this.LblFname.Size = new System.Drawing.Size(60, 13);
            this.LblFname.TabIndex = 3;
            this.LblFname.Text = "First Name:";
            // 
            // cboCountryCode
            // 
            this.cboCountryCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountryCode.FormattingEnabled = true;
            this.cboCountryCode.Location = new System.Drawing.Point(198, 85);
            this.cboCountryCode.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.cboCountryCode.Name = "cboCountryCode";
            this.cboCountryCode.Size = new System.Drawing.Size(174, 21);
            this.cboCountryCode.TabIndex = 8;
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.Location = new System.Drawing.Point(105, 85);
            this.lblCountryCode.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(74, 13);
            this.lblCountryCode.TabIndex = 7;
            this.lblCountryCode.Text = "Country Code:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDOB);
            this.groupBox1.Controls.Add(this.txtphoneno);
            this.groupBox1.Controls.Add(this.LblFname);
            this.groupBox1.Controls.Add(this.cboCountryCode);
            this.groupBox1.Controls.Add(this.txtfname);
            this.groupBox1.Controls.Add(this.lblLname);
            this.groupBox1.Controls.Add(this.lblCountryCode);
            this.groupBox1.Controls.Add(this.dtpdob);
            this.groupBox1.Controls.Add(this.txtlname);
            this.groupBox1.Controls.Add(this.LblPhoneNo);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblAddl1);
            this.groupBox2.Controls.Add(this.Lbleir);
            this.groupBox2.Controls.Add(this.cboCounty);
            this.groupBox2.Controls.Add(this.txtAddl1);
            this.groupBox2.Controls.Add(this.txttown);
            this.groupBox2.Controls.Add(this.txtAddl3);
            this.groupBox2.Controls.Add(this.LblAddl2);
            this.groupBox2.Controls.Add(this.Lbltown);
            this.groupBox2.Controls.Add(this.LblAddl3);
            this.groupBox2.Controls.Add(this.txtAddl2);
            this.groupBox2.Controls.Add(this.LblCounty);
            this.groupBox2.Controls.Add(this.txteir);
            this.groupBox2.Location = new System.Drawing.Point(0, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 177);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // cboCounty
            // 
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
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
            this.cboCounty.Location = new System.Drawing.Point(198, 122);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(83, 21);
            this.cboCounty.TabIndex = 26;
            // 
            // txtAddl3
            // 
            this.txtAddl3.Location = new System.Drawing.Point(198, 77);
            this.txtAddl3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtAddl3.MaxLength = 50;
            this.txtAddl3.Name = "txtAddl3";
            this.txtAddl3.Size = new System.Drawing.Size(143, 20);
            this.txtAddl3.TabIndex = 22;
            // 
            // LblAddl3
            // 
            this.LblAddl3.AutoSize = true;
            this.LblAddl3.Location = new System.Drawing.Point(105, 80);
            this.LblAddl3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblAddl3.Name = "LblAddl3";
            this.LblAddl3.Size = new System.Drawing.Size(80, 13);
            this.LblAddl3.TabIndex = 21;
            this.LblAddl3.Text = "Address Line 3:";
            // 
            // errorprovider
            // 
            this.errorprovider.BlinkRate = 0;
            this.errorprovider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorprovider.ContainerControl = this;
            // 
            // FrmRegesterUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MnuCreateCustomer);
            this.Controls.Add(this.BtnSubmit);
            this.MainMenuStrip = this.MnuCreateCustomer;
            this.Name = "FrmRegesterUserData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Customer";
            this.Load += new System.EventHandler(this.FrmCreateAccount_Load);
            this.MnuCreateCustomer.ResumeLayout(false);
            this.MnuCreateCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).EndInit();
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
        private System.Windows.Forms.TextBox txteir;
        private System.Windows.Forms.TextBox txttown;
        private System.Windows.Forms.TextBox txtAddl1;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtAddl2;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label LblAddl2;
        private System.Windows.Forms.Label Lbleir;
        private System.Windows.Forms.Label LblCounty;
        private System.Windows.Forms.Label Lbltown;
        private System.Windows.Forms.Label LblAddl1;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.Label LblPhoneNo;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label LblFname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.ErrorProvider errorprovider;
        private System.Windows.Forms.ComboBox cboCountryCode;
        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label LblAddl3;
        private System.Windows.Forms.TextBox txtAddl3;
    }
}