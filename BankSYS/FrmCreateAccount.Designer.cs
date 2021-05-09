
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
            this.mnuCreateAccount = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpCreateAccount = new System.Windows.Forms.TableLayoutPanel();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.cboAccountType = new System.Windows.Forms.ComboBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuCreateAccount.SuspendLayout();
            this.tlpCreateAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuCreateAccount
            // 
            this.mnuCreateAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateAccount.Name = "mnuCreateAccount";
            this.mnuCreateAccount.Size = new System.Drawing.Size(504, 24);
            this.mnuCreateAccount.TabIndex = 0;
            this.mnuCreateAccount.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tlpCreateAccount
            // 
            this.tlpCreateAccount.ColumnCount = 1;
            this.tlpCreateAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCreateAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCreateAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCreateAccount.Controls.Add(this.lblAccountName, 0, 0);
            this.tlpCreateAccount.Controls.Add(this.txtAccountName, 0, 1);
            this.tlpCreateAccount.Controls.Add(this.lblAccountType, 0, 3);
            this.tlpCreateAccount.Controls.Add(this.cboAccountType, 0, 4);
            this.tlpCreateAccount.Controls.Add(this.btnCreateAccount, 0, 6);
            this.tlpCreateAccount.Controls.Add(this.lblDisplayName, 0, 5);
            this.tlpCreateAccount.Location = new System.Drawing.Point(0, 27);
            this.tlpCreateAccount.Name = "tlpCreateAccount";
            this.tlpCreateAccount.RowCount = 7;
            this.tlpCreateAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpCreateAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpCreateAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpCreateAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpCreateAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpCreateAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpCreateAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpCreateAccount.Size = new System.Drawing.Size(504, 353);
            this.tlpCreateAccount.TabIndex = 0;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(7, 9);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(489, 31);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Please enter the name of your Account:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountName.Location = new System.Drawing.Point(28, 65);
            this.txtAccountName.MaxLength = 40;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(447, 20);
            this.txtAccountName.TabIndex = 2;
            this.txtAccountName.TextChanged += new System.EventHandler(this.txtAccountName_TextChanged);
            // 
            // lblAccountType
            // 
            this.lblAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(49, 159);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(406, 31);
            this.lblAccountType.TabIndex = 3;
            this.lblAccountType.Text = "Please select your acocunt type:";
            // 
            // cboAccountType
            // 
            this.cboAccountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccountType.FormattingEnabled = true;
            this.cboAccountType.Location = new System.Drawing.Point(191, 214);
            this.cboAccountType.Name = "cboAccountType";
            this.cboAccountType.Size = new System.Drawing.Size(121, 21);
            this.cboAccountType.TabIndex = 4;
            this.cboAccountType.SelectedIndexChanged += new System.EventHandler(this.cboAccountType_SelectedIndexChanged);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateAccount.Location = new System.Drawing.Point(197, 308);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(109, 37);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(252, 268);
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
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.tlpCreateAccount);
            this.Controls.Add(this.mnuCreateAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuCreateAccount;
            this.MaximizeBox = false;
            this.Name = "FrmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Create An Account";
            this.Load += new System.EventHandler(this.FrmCreatAccount_Load);
            this.mnuCreateAccount.ResumeLayout(false);
            this.mnuCreateAccount.PerformLayout();
            this.tlpCreateAccount.ResumeLayout(false);
            this.tlpCreateAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TableLayoutPanel tlpCreateAccount;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}