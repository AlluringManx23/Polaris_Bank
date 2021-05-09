
namespace BankSYS
{
    partial class FrmRegisterUserData
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
            this.mnuRegisterUserData = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtAddl3 = new System.Windows.Forms.TextBox();
            this.LblAddl3 = new System.Windows.Forms.Label();
            this.errorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuRegisterUserData.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.grpAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuRegisterUserData
            // 
            this.mnuRegisterUserData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegisterUserData.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterUserData.Name = "mnuRegisterUserData";
            this.mnuRegisterUserData.Size = new System.Drawing.Size(784, 24);
            this.mnuRegisterUserData.TabIndex = 0;
            this.mnuRegisterUserData.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(624, 390);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 48);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            // grpPersonal
            // 
            this.grpPersonal.Controls.Add(this.LblDOB);
            this.grpPersonal.Controls.Add(this.txtphoneno);
            this.grpPersonal.Controls.Add(this.LblFname);
            this.grpPersonal.Controls.Add(this.cboCountryCode);
            this.grpPersonal.Controls.Add(this.txtfname);
            this.grpPersonal.Controls.Add(this.lblLname);
            this.grpPersonal.Controls.Add(this.lblCountryCode);
            this.grpPersonal.Controls.Add(this.dtpdob);
            this.grpPersonal.Controls.Add(this.txtlname);
            this.grpPersonal.Controls.Add(this.LblPhoneNo);
            this.grpPersonal.Location = new System.Drawing.Point(0, 27);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(784, 174);
            this.grpPersonal.TabIndex = 1;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Personal Information";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.LblAddl1);
            this.grpAddress.Controls.Add(this.Lbleir);
            this.grpAddress.Controls.Add(this.cboCounty);
            this.grpAddress.Controls.Add(this.txtAddl1);
            this.grpAddress.Controls.Add(this.txttown);
            this.grpAddress.Controls.Add(this.txtAddl3);
            this.grpAddress.Controls.Add(this.LblAddl2);
            this.grpAddress.Controls.Add(this.Lbltown);
            this.grpAddress.Controls.Add(this.LblAddl3);
            this.grpAddress.Controls.Add(this.txtAddl2);
            this.grpAddress.Controls.Add(this.LblCounty);
            this.grpAddress.Controls.Add(this.txteir);
            this.grpAddress.Location = new System.Drawing.Point(0, 207);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(784, 177);
            this.grpAddress.TabIndex = 15;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // cboCounty
            // 
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.FormattingEnabled = true;
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
            // FrmRegisterUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.mnuRegisterUserData);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuRegisterUserData;
            this.MaximizeBox = false;
            this.Name = "FrmRegisterUserData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Create Customer";
            this.Load += new System.EventHandler(this.FrmCreateAccount_Load);
            this.mnuRegisterUserData.ResumeLayout(false);
            this.mnuRegisterUserData.PerformLayout();
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorprovider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegisterUserData;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Button btnSubmit;
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
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.ErrorProvider errorprovider;
        private System.Windows.Forms.ComboBox cboCountryCode;
        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label LblAddl3;
        private System.Windows.Forms.TextBox txtAddl3;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}