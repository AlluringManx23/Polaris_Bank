
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
            this.components = new System.ComponentModel.Container();
            this.mnuStartScreen = new System.Windows.Forms.MenuStrip();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblPUC = new System.Windows.Forms.Label();
            this.lnkRegesterCustomer = new System.Windows.Forms.LinkLabel();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.txtPUC = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.mnuStartScreen.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tlpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStartScreen
            // 
            this.mnuStartScreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExit});
            this.mnuStartScreen.Location = new System.Drawing.Point(0, 0);
            this.mnuStartScreen.Name = "mnuStartScreen";
            this.mnuStartScreen.Size = new System.Drawing.Size(784, 24);
            this.mnuStartScreen.TabIndex = 0;
            this.mnuStartScreen.Text = "menuStrip1";
            // 
            // MnuExit
            // 
            this.MnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(38, 20);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(261, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(261, 50);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Polaris Bank";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 3;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTitle.Controls.Add(this.lblName, 1, 0);
            this.tlpTitle.Location = new System.Drawing.Point(0, 24);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTitle.Size = new System.Drawing.Size(784, 100);
            this.tlpTitle.TabIndex = 1;
            // 
            // lblCustId
            // 
            this.lblCustId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(282, 88);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(68, 13);
            this.lblCustId.TabIndex = 4;
            this.lblCustId.Text = "Customer ID:";
            // 
            // lblPUC
            // 
            this.lblPUC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPUC.AutoSize = true;
            this.lblPUC.Location = new System.Drawing.Point(318, 152);
            this.lblPUC.Name = "lblPUC";
            this.lblPUC.Size = new System.Drawing.Size(32, 13);
            this.lblPUC.TabIndex = 6;
            this.lblPUC.Text = "PUC:";
            // 
            // lnkRegesterCustomer
            // 
            this.lnkRegesterCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkRegesterCustomer.AutoSize = true;
            this.lnkRegesterCustomer.Location = new System.Drawing.Point(314, 0);
            this.lnkRegesterCustomer.Name = "lnkRegesterCustomer";
            this.lnkRegesterCustomer.Size = new System.Drawing.Size(154, 13);
            this.lnkRegesterCustomer.TabIndex = 9;
            this.lnkRegesterCustomer.TabStop = true;
            this.lnkRegesterCustomer.Text = "Not Regestered yet? click here";
            this.lnkRegesterCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegesterCustomer_LinkClicked);
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustomerid.Location = new System.Drawing.Point(356, 85);
            this.txtCustomerid.MaxLength = 8;
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(83, 20);
            this.txtCustomerid.TabIndex = 5;
            // 
            // txtPUC
            // 
            this.txtPUC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPUC.Location = new System.Drawing.Point(356, 148);
            this.txtPUC.MaxLength = 5;
            this.txtPUC.Name = "txtPUC";
            this.txtPUC.PasswordChar = '*';
            this.txtPUC.Size = new System.Drawing.Size(51, 20);
            this.txtPUC.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(326, 70);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 40);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 4;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.125F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.875F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpInfo.Controls.Add(this.lblCustId, 1, 1);
            this.tlpInfo.Controls.Add(this.txtCustomerid, 2, 1);
            this.tlpInfo.Controls.Add(this.txtPUC, 2, 2);
            this.tlpInfo.Controls.Add(this.lblPUC, 1, 2);
            this.tlpInfo.Location = new System.Drawing.Point(0, 130);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 3;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.88312F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.23377F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInfo.Size = new System.Drawing.Size(784, 191);
            this.tlpInfo.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpButton.Controls.Add(this.lnkRegesterCustomer, 1, 0);
            this.tlpButton.Controls.Add(this.btnLogin, 1, 1);
            this.tlpButton.Location = new System.Drawing.Point(0, 304);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 2;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.32836F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.67164F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButton.Size = new System.Drawing.Size(784, 134);
            this.tlpButton.TabIndex = 8;
            // 
            // FrmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tlpButton);
            this.Controls.Add(this.tlpInfo);
            this.Controls.Add(this.tlpTitle);
            this.Controls.Add(this.mnuStartScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuStartScreen;
            this.MaximizeBox = false;
            this.Name = "FrmStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Start screen";
            this.Load += new System.EventHandler(this.FrmStartScreen_Load);
            this.mnuStartScreen.ResumeLayout(false);
            this.mnuStartScreen.PerformLayout();
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tlpButton.ResumeLayout(false);
            this.tlpButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStartScreen;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblPUC;
        private System.Windows.Forms.LinkLabel lnkRegesterCustomer;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.TextBox txtPUC;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
    }
}

