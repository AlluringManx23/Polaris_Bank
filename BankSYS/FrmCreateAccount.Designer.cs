
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
            this.txtppsno = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.LblAddl2 = new System.Windows.Forms.Label();
            this.Lbleir = new System.Windows.Forms.Label();
            this.LblCounty = new System.Windows.Forms.Label();
            this.Lbltown = new System.Windows.Forms.Label();
            this.LblAddl1 = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.LblPhoneNo = new System.Windows.Forms.Label();
            this.LblPPSNo = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.LblFname = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboCountryCode = new System.Windows.Forms.ComboBox();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.LblAddl3 = new System.Windows.Forms.Label();
            this.txtAddl3 = new System.Windows.Forms.TextBox();
            this.MnuCreateCustomer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.MnuCreateAccount.Size = new System.Drawing.Size(180, 22);
            this.MnuCreateAccount.Text = "Create Account";
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
            this.dtpdob.Location = new System.Drawing.Point(524, 56);
            this.dtpdob.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.dtpdob.MinDate = new System.DateTime(1903, 1, 1, 0, 0, 0, 0);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(147, 20);
            this.dtpdob.TabIndex = 10;
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
            this.txteir.Location = new System.Drawing.Point(524, 102);
            this.txteir.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txteir.MaxLength = 8;
            this.txteir.Name = "txteir";
            this.txteir.Size = new System.Drawing.Size(146, 20);
            this.txteir.TabIndex = 28;
            // 
            // txttown
            // 
            this.txttown.Location = new System.Drawing.Point(524, 57);
            this.txttown.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txttown.MaxLength = 22;
            this.txttown.Name = "txttown";
            this.txttown.Size = new System.Drawing.Size(143, 20);
            this.txttown.TabIndex = 24;
            // 
            // txtAddl1
            // 
            this.txtAddl1.Location = new System.Drawing.Point(186, 12);
            this.txtAddl1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtAddl1.MaxLength = 50;
            this.txtAddl1.Name = "txtAddl1";
            this.txtAddl1.Size = new System.Drawing.Size(146, 20);
            this.txtAddl1.TabIndex = 18;
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(524, 100);
            this.txtphoneno.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtphoneno.MaxLength = 14;
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(143, 20);
            this.txtphoneno.TabIndex = 14;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(524, 12);
            this.txtlname.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtlname.MaxLength = 40;
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(143, 20);
            this.txtlname.TabIndex = 6;
            // 
            // txtAddl2
            // 
            this.txtAddl2.Location = new System.Drawing.Point(524, 12);
            this.txtAddl2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtAddl2.MaxLength = 50;
            this.txtAddl2.Name = "txtAddl2";
            this.txtAddl2.Size = new System.Drawing.Size(143, 20);
            this.txtAddl2.TabIndex = 20;
            // 
            // txtppsno
            // 
            this.txtppsno.Location = new System.Drawing.Point(186, 56);
            this.txtppsno.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtppsno.MaxLength = 9;
            this.txtppsno.Name = "txtppsno";
            this.txtppsno.Size = new System.Drawing.Size(146, 20);
            this.txtppsno.TabIndex = 8;
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.SystemColors.Window;
            this.txtfname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtfname.Location = new System.Drawing.Point(186, 12);
            this.txtfname.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtfname.MaxLength = 40;
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(146, 20);
            this.txtfname.TabIndex = 4;
            // 
            // LblAddl2
            // 
            this.LblAddl2.AutoSize = true;
            this.LblAddl2.Location = new System.Drawing.Point(431, 15);
            this.LblAddl2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblAddl2.Name = "LblAddl2";
            this.LblAddl2.Size = new System.Drawing.Size(80, 13);
            this.LblAddl2.TabIndex = 19;
            this.LblAddl2.Text = "Address Line 2:";
            // 
            // Lbleir
            // 
            this.Lbleir.AutoSize = true;
            this.Lbleir.Location = new System.Drawing.Point(431, 105);
            this.Lbleir.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbleir.Name = "Lbleir";
            this.Lbleir.Size = new System.Drawing.Size(50, 13);
            this.Lbleir.TabIndex = 27;
            this.Lbleir.Text = "Eir Code:";
            // 
            // LblCounty
            // 
            this.LblCounty.AutoSize = true;
            this.LblCounty.Location = new System.Drawing.Point(93, 105);
            this.LblCounty.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblCounty.Name = "LblCounty";
            this.LblCounty.Size = new System.Drawing.Size(43, 13);
            this.LblCounty.TabIndex = 25;
            this.LblCounty.Text = "County:";
            // 
            // Lbltown
            // 
            this.Lbltown.AutoSize = true;
            this.Lbltown.Location = new System.Drawing.Point(431, 60);
            this.Lbltown.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.Lbltown.Name = "Lbltown";
            this.Lbltown.Size = new System.Drawing.Size(37, 13);
            this.Lbltown.TabIndex = 23;
            this.Lbltown.Text = "Town:";
            // 
            // LblAddl1
            // 
            this.LblAddl1.AutoSize = true;
            this.LblAddl1.Location = new System.Drawing.Point(93, 15);
            this.LblAddl1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblAddl1.Name = "LblAddl1";
            this.LblAddl1.Size = new System.Drawing.Size(80, 13);
            this.LblAddl1.TabIndex = 17;
            this.LblAddl1.Text = "Address Line 1:";
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.Location = new System.Drawing.Point(431, 59);
            this.LblDOB.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(71, 13);
            this.LblDOB.TabIndex = 9;
            this.LblDOB.Text = "Date Of Birth:";
            // 
            // LblPhoneNo
            // 
            this.LblPhoneNo.AutoSize = true;
            this.LblPhoneNo.Location = new System.Drawing.Point(431, 103);
            this.LblPhoneNo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblPhoneNo.Name = "LblPhoneNo";
            this.LblPhoneNo.Size = new System.Drawing.Size(81, 13);
            this.LblPhoneNo.TabIndex = 13;
            this.LblPhoneNo.Text = "Phone Number:";
            // 
            // LblPPSNo
            // 
            this.LblPPSNo.AutoSize = true;
            this.LblPPSNo.Location = new System.Drawing.Point(93, 59);
            this.LblPPSNo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblPPSNo.Name = "LblPPSNo";
            this.LblPPSNo.Size = new System.Drawing.Size(71, 13);
            this.LblPPSNo.TabIndex = 7;
            this.LblPPSNo.Text = "PPS Number:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(431, 15);
            this.lblLname.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(61, 13);
            this.lblLname.TabIndex = 5;
            this.lblLname.Text = "Last Name:";
            // 
            // LblFname
            // 
            this.LblFname.AutoSize = true;
            this.LblFname.Location = new System.Drawing.Point(93, 15);
            this.LblFname.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblFname.Name = "LblFname";
            this.LblFname.Size = new System.Drawing.Size(60, 13);
            this.LblFname.TabIndex = 3;
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
            this.tableLayoutPanel1.Controls.Add(this.LblPPSNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblFname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpdob, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblDOB, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtphoneno, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblPhoneNo, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboCountryCode, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCountryCode, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 134);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(0, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 177);
            this.groupBox2.TabIndex = 15;
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
            this.tableLayoutPanel2.Controls.Add(this.LblAddl1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAddl1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblAddl2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAddl2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txteir, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.Lbleir, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.LblAddl3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAddl3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboCounty, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txttown, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.Lbltown, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblCounty, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 135);
            this.tableLayoutPanel2.TabIndex = 16;
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
            this.cboCounty.Location = new System.Drawing.Point(186, 102);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(146, 21);
            this.cboCounty.TabIndex = 26;
            // 
            // errorprovider
            // 
            this.errorprovider.BlinkRate = 0;
            this.errorprovider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorprovider.ContainerControl = this;
            // 
            // cboCountryCode
            // 
            this.cboCountryCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountryCode.FormattingEnabled = true;
            this.cboCountryCode.Items.AddRange(new object[] {
            "Algeria (+213)",
            "Andorra (+376)",
            "Angola (+244)",
            "Anguilla (+1264)",
            "Antigua Barbuda (+1268)",
            "Argentina (+54)",
            "Armenia (+374)",
            "Aruba (+297)",
            "Australia (+61)",
            "Austria (+43)",
            "Azerbaijan (+994)",
            "Bahamas (+1242)",
            "Bahrain (+973)",
            "Bangladesh (+880)",
            "Barbados (+1246)",
            "Belarus (+375)",
            "Belgium (+32)",
            "Belize (+501)",
            "Benin (+229)",
            "Bermuda (+1441)",
            "Bhutan (+975)",
            "Bolivia (+591)",
            "Bosnia Herzegovina (+387)",
            "Botswana (+267)",
            "Brazil (+55)",
            "Brunei (+673)",
            "Bulgaria (+359)",
            "Burkina Faso (+226)",
            "Burundi (+257)",
            "Cambodia (+855)",
            "Cameroon (+237)",
            "Canada (+1)",
            "Cape Verde Islands (+238)",
            "Cayman Islands (+1345)",
            "Central African Republic (+236)",
            "Chile (+56)",
            "China (+86)",
            "Colombia (+57)",
            "Comoros (+269)",
            "Congo (+242)",
            "Cook Islands (+682)",
            "Costa Rica (+506)",
            "Croatia (+385)",
            "Cuba (+53)",
            "Cyprus North (+90392)",
            "Cyprus South (+357)",
            "Czech Republic (+42)",
            "Denmark (+45)",
            "Djibouti (+253)",
            "Dominica (+1809)",
            "Dominican Republic (+1809)",
            "Ecuador (+593)",
            "Egypt (+20)",
            "El Salvador (+503)",
            "Equatorial Guinea (+240)",
            "Eritrea (+291)",
            "Estonia (+372)",
            "Ethiopia (+251)",
            "Falkland Islands (+500)",
            "Faroe Islands (+298)",
            "Fiji (+679)",
            "Finland (+358)",
            "France (+33)",
            "French Guiana (+594)",
            "French Polynesia (+689)",
            "Gabon (+241)",
            "Gambia (+220)",
            "Georgia (+7880)",
            "Germany (+49)",
            "Ghana (+233)",
            "Gibraltar (+350)",
            "Greece (+30)",
            "Greenland (+299)",
            "Grenada (+1473)",
            "Guadeloupe (+590)",
            "Guam (+671)",
            "Guatemala (+502)",
            "Guinea (+224)",
            "Guinea - Bissau (+245)",
            "Guyana (+592)",
            "Haiti (+509)",
            "Honduras (+504)",
            "Hong Kong (+852)",
            "Hungary (+36)",
            "Iceland (+354)",
            "India (+91)",
            "Indonesia (+62)",
            "Iran (+98)",
            "Iraq (+964)",
            "Ireland (+353)",
            "Israel (+972)",
            "Italy (+39)",
            "Jamaica (+1876)",
            "Japan (+81)",
            "Jordan (+962)",
            "Kazakhstan (+7)",
            "Kenya (+254)",
            "Kiribati (+686)",
            "Korea North (+850)",
            "Korea South (+82)",
            "Kuwait (+965)",
            "Kyrgyzstan (+996)",
            "Laos (+856)",
            "Latvia (+371)",
            "Lebanon (+961)",
            "Lesotho (+266)",
            "Liberia (+231)",
            "Libya (+218)",
            "Liechtenstein (+417)",
            "Lithuania (+370)",
            "Luxembourg (+352)",
            "Macao (+853)",
            "Macedonia (+389)",
            "Madagascar (+261)",
            "Malawi (+265)",
            "Malaysia (+60)",
            "Maldives (+960)",
            "Mali (+223)",
            "Malta (+356)",
            "Marshall Islands (+692)",
            "Martinique (+596)",
            "Mauritania (+222)",
            "Mayotte (+269)",
            "Mexico (+52)",
            "Micronesia (+691)",
            "Moldova (+373)",
            "Monaco (+377)",
            "Mongolia (+976)",
            "Montserrat (+1664)",
            "Morocco (+212)",
            "Mozambique (+258)",
            "Myanmar (+95)",
            "Namibia (+264)",
            "Nauru (+674)",
            "Nepal (+977)",
            "Netherlands (+31)",
            "New Caledonia (+687)",
            "New Zealand (+64)",
            "Nicaragua (+505)",
            "Niger (+227)",
            "Nigeria (+234)",
            "Niue (+683)",
            "Norfolk Islands (+672)",
            "Northern Marianas (+670)",
            "Norway (+47)",
            "Oman (+968)",
            "Palau (+680)",
            "Panama (+507)",
            "Papua New Guinea (+675)",
            "Paraguay (+595)",
            "Peru (+51)",
            "Philippines (+63)",
            "Poland (+48)",
            "Portugal (+351)",
            "Puerto Rico (+1787)",
            "Qatar (+974)",
            "Reunion (+262)",
            "Romania (+40)",
            "Russia (+7)",
            "Rwanda (+250)",
            "San Marino (+378)",
            "Sao Tome Principe (+239)",
            "Saudi Arabia (+966)",
            "Senegal (+221)",
            "Serbia (+381)",
            "Seychelles (+248)",
            "Sierra Leone (+232)",
            "Singapore (+65)",
            "Slovak Republic (+421)",
            "Slovenia (+386)",
            "Solomon Islands (+677)",
            "Somalia (+252)",
            "South Africa (+27)",
            "Spain (+34)",
            "Sri Lanka (+94)",
            "St. Helena (+290)",
            "St. Kitts (+1869)",
            "St. Lucia (+1758)",
            "Sudan (+249)",
            "Suriname (+597)",
            "Swaziland (+268)",
            "Sweden (+46)",
            "Switzerland (+41)",
            "Syria (+963)",
            "Taiwan (+886)",
            "Tajikstan (+7)",
            "Thailand (+66)",
            "Togo (+228)",
            "Tonga (+676)",
            "Trinidad Tobago (+1868)",
            "Tunisia (+216)",
            "Turkey (+90)",
            "Turkmenistan (+7)",
            "Turkmenistan (+993)",
            "Turks Caicos Islands (+1649)",
            "Tuvalu (+688)",
            "Uganda (+256)",
            "UK (+44)",
            "Ukraine (+380)",
            "United Arab Emirates (+971)",
            "Uruguay (+598)",
            "USA (+1)",
            "Uzbekistan (+7)",
            "Vanuatu (+678)",
            "Vatican City (+379)",
            "Venezuela (+58)",
            "Vietnam (+84)",
            "Virgin Islands - British (+1284)",
            "Virgin Islands - US (+1340)",
            "Wallis Futuna (+681)",
            "Yemen (North)(+969)",
            "Yemen (South)(+967)",
            "Zambia (+260)",
            "Zimbabwe (+263)"});
            this.cboCountryCode.Location = new System.Drawing.Point(186, 100);
            this.cboCountryCode.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.cboCountryCode.Name = "cboCountryCode";
            this.cboCountryCode.Size = new System.Drawing.Size(146, 21);
            this.cboCountryCode.TabIndex = 12;
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.Location = new System.Drawing.Point(93, 103);
            this.lblCountryCode.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(74, 13);
            this.lblCountryCode.TabIndex = 11;
            this.lblCountryCode.Text = "Country Code:";
            // 
            // LblAddl3
            // 
            this.LblAddl3.AutoSize = true;
            this.LblAddl3.Location = new System.Drawing.Point(93, 60);
            this.LblAddl3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.LblAddl3.Name = "LblAddl3";
            this.LblAddl3.Size = new System.Drawing.Size(80, 13);
            this.LblAddl3.TabIndex = 21;
            this.LblAddl3.Text = "Address Line 3:";
            // 
            // txtAddl3
            // 
            this.txtAddl3.Location = new System.Drawing.Point(186, 57);
            this.txtAddl3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtAddl3.MaxLength = 50;
            this.txtAddl3.Name = "txtAddl3";
            this.txtAddl3.Size = new System.Drawing.Size(143, 20);
            this.txtAddl3.TabIndex = 22;
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
            this.Load += new System.EventHandler(this.FrmCreateAccount_Load);
            this.MnuCreateCustomer.ResumeLayout(false);
            this.MnuCreateCustomer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtppsno;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label LblAddl2;
        private System.Windows.Forms.Label Lbleir;
        private System.Windows.Forms.Label LblCounty;
        private System.Windows.Forms.Label Lbltown;
        private System.Windows.Forms.Label LblAddl1;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.Label LblPhoneNo;
        private System.Windows.Forms.Label LblPPSNo;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label LblFname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.ErrorProvider errorprovider;
        private System.Windows.Forms.ComboBox cboCountryCode;
        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label LblAddl3;
        private System.Windows.Forms.TextBox txtAddl3;
    }
}