
namespace BankSYS
{
    partial class FrmTerminateCustomer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddressL1 = new System.Windows.Forms.TextBox();
            this.txtAddressL2 = new System.Windows.Forms.TextBox();
            this.txtAddressL3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.transactionToolStripMenuItem});
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Terminate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Line 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Line 2:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(117, 57);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(154, 20);
            this.txtLName.TabIndex = 7;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(117, 91);
            this.txtPhoneNo.MaxLength = 20;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.ReadOnly = true;
            this.txtPhoneNo.Size = new System.Drawing.Size(131, 20);
            this.txtPhoneNo.TabIndex = 8;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(117, 26);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(154, 20);
            this.txtFName.TabIndex = 9;
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            this.updateAccountToolStripMenuItem.Click += new System.EventHandler(this.updateAccountToolStripMenuItem_Click);
            // 
            // closeAccountToolStripMenuItem
            // 
            this.closeAccountToolStripMenuItem.Name = "closeAccountToolStripMenuItem";
            this.closeAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeAccountToolStripMenuItem.Text = "Close Account";
            this.closeAccountToolStripMenuItem.Click += new System.EventHandler(this.closeAccountToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Line 3:";
            // 
            // txtAddressL1
            // 
            this.txtAddressL1.Location = new System.Drawing.Point(94, 19);
            this.txtAddressL1.Name = "txtAddressL1";
            this.txtAddressL1.ReadOnly = true;
            this.txtAddressL1.Size = new System.Drawing.Size(100, 20);
            this.txtAddressL1.TabIndex = 11;
            // 
            // txtAddressL2
            // 
            this.txtAddressL2.Location = new System.Drawing.Point(94, 52);
            this.txtAddressL2.Name = "txtAddressL2";
            this.txtAddressL2.ReadOnly = true;
            this.txtAddressL2.Size = new System.Drawing.Size(100, 20);
            this.txtAddressL2.TabIndex = 12;
            // 
            // txtAddressL3
            // 
            this.txtAddressL3.Location = new System.Drawing.Point(94, 92);
            this.txtAddressL3.Name = "txtAddressL3";
            this.txtAddressL3.ReadOnly = true;
            this.txtAddressL3.Size = new System.Drawing.Size(100, 20);
            this.txtAddressL3.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(88, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 180);
            this.dataGridView1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtPhoneNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 155);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date Of Birth: ";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(117, 120);
            this.txtDOB.MaxLength = 10;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(70, 20);
            this.txtDOB.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEircode);
            this.groupBox2.Controls.Add(this.txtCounty);
            this.groupBox2.Controls.Add(this.txtTown);
            this.groupBox2.Controls.Add(this.txtAddressL1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAddressL3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAddressL2);
            this.groupBox2.Location = new System.Drawing.Point(347, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 130);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(274, 20);
            this.txtTown.Name = "txtTown";
            this.txtTown.ReadOnly = true;
            this.txtTown.Size = new System.Drawing.Size(100, 20);
            this.txtTown.TabIndex = 14;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(274, 64);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
            this.txtCounty.Size = new System.Drawing.Size(100, 20);
            this.txtCounty.TabIndex = 15;
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(274, 100);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(62, 20);
            this.txtEircode.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Town:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "County:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Eircode: ";
            // 
            // FrmTerminateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTerminateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminate Customer";
            this.Load += new System.EventHandler(this.FrmTerminateCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddressL1;
        private System.Windows.Forms.TextBox txtAddressL2;
        private System.Windows.Forms.TextBox txtAddressL3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label7;
    }
}