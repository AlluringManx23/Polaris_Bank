
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
            this.MnuCreateAccount = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAccountType = new System.Windows.Forms.ComboBox();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MnuCreateAccount.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuCreateAccount
            // 
            this.MnuCreateAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnu_exit});
            this.MnuCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.MnuCreateAccount.Name = "MnuCreateAccount";
            this.MnuCreateAccount.Size = new System.Drawing.Size(510, 24);
            this.MnuCreateAccount.TabIndex = 0;
            this.MnuCreateAccount.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnu_exit
            // 
            this.mnu_exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.Size = new System.Drawing.Size(38, 20);
            this.mnu_exit.Text = "Exit";
            this.mnu_exit.Click += new System.EventHandler(this.mnu_exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAccountName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboAccountType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnCreateAccount, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDisplayName, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 351);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the name of your Account:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountName.Location = new System.Drawing.Point(31, 65);
            this.txtAccountName.MaxLength = 40;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(447, 20);
            this.txtAccountName.TabIndex = 3;
            this.txtAccountName.TextChanged += new System.EventHandler(this.txtAccountName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select your acocunt type:";
            // 
            // cboAccountType
            // 
            this.cboAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccountType.FormattingEnabled = true;
            this.cboAccountType.Location = new System.Drawing.Point(194, 214);
            this.cboAccountType.Name = "cboAccountType";
            this.cboAccountType.Size = new System.Drawing.Size(121, 21);
            this.cboAccountType.TabIndex = 2;
            this.cboAccountType.SelectedIndexChanged += new System.EventHandler(this.cboAccountType_SelectedIndexChanged);
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCreateAccount.Location = new System.Drawing.Point(200, 307);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(109, 37);
            this.BtnCreateAccount.TabIndex = 4;
            this.BtnCreateAccount.Text = "Create Account";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(255, 268);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayName.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MnuCreateAccount);
            this.MainMenuStrip = this.MnuCreateAccount;
            this.Name = "FrmCreateAccount";
            this.Text = "Create An Account";
            this.Load += new System.EventHandler(this.FrmCreatAccount_Load);
            this.MnuCreateAccount.ResumeLayout(false);
            this.MnuCreateAccount.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnu_exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}