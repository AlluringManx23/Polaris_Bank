
namespace BankSYS
{
    partial class FrmUpdateCustomer
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
            this.terminateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.cboCountryCode = new System.Windows.Forms.ComboBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtPPSNo = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtAddressL3 = new System.Windows.Forms.TextBox();
            this.txtAddressL1 = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtAddressL2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.terminateCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
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
            this.createAccountToolStripMenuItem,
            this.updateAccountToolStripMenuItem,
            this.closeAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            // 
            // closeAccountToolStripMenuItem
            // 
            this.closeAccountToolStripMenuItem.Name = "closeAccountToolStripMenuItem";
            this.closeAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.closeAccountToolStripMenuItem.Text = "Close Account";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.depositToolStripMenuItem.Text = "Deposit";
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.transferToolStripMenuItem.Text = "Transfer";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCreationDate);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.cboCountryCode);
            this.groupBox1.Controls.Add(this.txtPhoneNo);
            this.groupBox1.Controls.Add(this.txtPPSNo);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.Location = new System.Drawing.Point(584, 49);
            this.txtCreationDate.MaxLength = 10;
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.ReadOnly = true;
            this.txtCreationDate.Size = new System.Drawing.Size(66, 20);
            this.txtCreationDate.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(493, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Creation Date:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(584, 91);
            this.txtDOB.MaxLength = 10;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(66, 20);
            this.txtDOB.TabIndex = 22;
            // 
            // cboCountryCode
            // 
            this.cboCountryCode.FormattingEnabled = true;
            this.cboCountryCode.Location = new System.Drawing.Point(301, 130);
            this.cboCountryCode.Name = "cboCountryCode";
            this.cboCountryCode.Size = new System.Drawing.Size(174, 21);
            this.cboCountryCode.TabIndex = 21;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(577, 133);
            this.txtPhoneNo.MaxLength = 12;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.TabIndex = 19;
            // 
            // txtPPSNo
            // 
            this.txtPPSNo.Location = new System.Drawing.Point(108, 129);
            this.txtPPSNo.MaxLength = 9;
            this.txtPPSNo.Name = "txtPPSNo";
            this.txtPPSNo.ReadOnly = true;
            this.txtPPSNo.Size = new System.Drawing.Size(73, 20);
            this.txtPPSNo.TabIndex = 18;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(108, 88);
            this.txtFName.MaxLength = 40;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 17;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(301, 88);
            this.txtLName.MaxLength = 40;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(497, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Date Of Birth:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Phone Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 13;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(301, 46);
            this.txtStatus.MaxLength = 1;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(71, 20);
            this.txtStatus.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Prefix:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PPS Numer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(108, 46);
            this.txtCustomerID.MaxLength = 8;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(64, 20);
            this.txtCustomerID.TabIndex = 2;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(358, 399);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(109, 39);
            this.btnUpdateCustomer.TabIndex = 3;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEircode);
            this.groupBox2.Controls.Add(this.txtAddressL3);
            this.groupBox2.Controls.Add(this.txtAddressL1);
            this.groupBox2.Controls.Add(this.txtTown);
            this.groupBox2.Controls.Add(this.txtAddressL2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboCounty);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 179);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(571, 132);
            this.txtEircode.MaxLength = 8;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(79, 20);
            this.txtEircode.TabIndex = 11;
            // 
            // txtAddressL3
            // 
            this.txtAddressL3.Location = new System.Drawing.Point(153, 132);
            this.txtAddressL3.MaxLength = 50;
            this.txtAddressL3.Name = "txtAddressL3";
            this.txtAddressL3.Size = new System.Drawing.Size(100, 20);
            this.txtAddressL3.TabIndex = 10;
            // 
            // txtAddressL1
            // 
            this.txtAddressL1.Location = new System.Drawing.Point(153, 39);
            this.txtAddressL1.MaxLength = 50;
            this.txtAddressL1.Name = "txtAddressL1";
            this.txtAddressL1.Size = new System.Drawing.Size(100, 20);
            this.txtAddressL1.TabIndex = 9;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(571, 45);
            this.txtTown.MaxLength = 22;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(100, 20);
            this.txtTown.TabIndex = 8;
            // 
            // txtAddressL2
            // 
            this.txtAddressL2.Location = new System.Drawing.Point(153, 93);
            this.txtAddressL2.MaxLength = 50;
            this.txtAddressL2.Name = "txtAddressL2";
            this.txtAddressL2.Size = new System.Drawing.Size(100, 20);
            this.txtAddressL2.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(512, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Eircode:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(512, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "County:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(517, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Town";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Address Line 3:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Address Line 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Address Line 1:";
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(571, 79);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(90, 21);
            this.cboCounty.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUpdateCustomer";
            this.Text = "FrmUpdateCustomer";
            this.Load += new System.EventHandler(this.FrmUpdateCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCountryCode;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtPPSNo;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtAddressL3;
        private System.Windows.Forms.TextBox txtAddressL1;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtAddressL2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtCreationDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}