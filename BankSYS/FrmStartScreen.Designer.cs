
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
            this.MnuStartScreen = new System.Windows.Forms.MenuStrip();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblPUC = new System.Windows.Forms.Label();
            this.lnkRegesterCustomer = new System.Windows.Forms.LinkLabel();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.txtPUC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MnuStartScreen.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuStartScreen
            // 
            this.MnuStartScreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExit});
            this.MnuStartScreen.Location = new System.Drawing.Point(0, 0);
            this.MnuStartScreen.Name = "MnuStartScreen";
            this.MnuStartScreen.Size = new System.Drawing.Size(800, 24);
            this.MnuStartScreen.TabIndex = 0;
            this.MnuStartScreen.Text = "menuStrip1";
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
            this.lblName.Location = new System.Drawing.Point(268, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(261, 50);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Polaris Bank";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblCustId
            // 
            this.lblCustId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(290, 70);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(68, 13);
            this.lblCustId.TabIndex = 3;
            this.lblCustId.Text = "Customer ID:";
            // 
            // lblPUC
            // 
            this.lblPUC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPUC.AutoSize = true;
            this.lblPUC.Location = new System.Drawing.Point(326, 121);
            this.lblPUC.Name = "lblPUC";
            this.lblPUC.Size = new System.Drawing.Size(32, 13);
            this.lblPUC.TabIndex = 4;
            this.lblPUC.Text = "PUC:";
            // 
            // lnkRegesterCustomer
            // 
            this.lnkRegesterCustomer.AutoSize = true;
            this.lnkRegesterCustomer.Location = new System.Drawing.Point(364, 153);
            this.lnkRegesterCustomer.Name = "lnkRegesterCustomer";
            this.lnkRegesterCustomer.Size = new System.Drawing.Size(154, 13);
            this.lnkRegesterCustomer.TabIndex = 5;
            this.lnkRegesterCustomer.TabStop = true;
            this.lnkRegesterCustomer.Text = "Not Regestered yet? click here";
            this.lnkRegesterCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegesterCustomer_LinkClicked);
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustomerid.Location = new System.Drawing.Point(364, 67);
            this.txtCustomerid.MaxLength = 8;
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerid.TabIndex = 6;
            // 
            // txtPUC
            // 
            this.txtPUC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPUC.Location = new System.Drawing.Point(364, 117);
            this.txtPUC.MaxLength = 5;
            this.txtPUC.Name = "txtPUC";
            this.txtPUC.PasswordChar = '*';
            this.txtPUC.Size = new System.Drawing.Size(100, 20);
            this.txtPUC.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.875F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblCustId, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCustomerid, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPUC, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPUC, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lnkRegesterCustomer, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 130);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.88312F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.23377F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 308);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FrmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MnuStartScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MnuStartScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Start screen";
            this.Load += new System.EventHandler(this.FrmStartScreen_Load);
            this.MnuStartScreen.ResumeLayout(false);
            this.MnuStartScreen.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStartScreen;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblPUC;
        private System.Windows.Forms.LinkLabel lnkRegesterCustomer;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.TextBox txtPUC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

