﻿
namespace BankSYS
{
    partial class FrmRegisterLoginData
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
            this.txtpacno1 = new System.Windows.Forms.TextBox();
            this.mnuRegisterUserLogin = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tblpacnum = new System.Windows.Forms.TableLayoutPanel();
            this.txtpacno5 = new System.Windows.Forms.TextBox();
            this.txtpacno4 = new System.Windows.Forms.TextBox();
            this.txtpacno3 = new System.Windows.Forms.TextBox();
            this.txtpacno2 = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lblpac = new System.Windows.Forms.Label();
            this.txtppsno = new System.Windows.Forms.TextBox();
            this.lblppsno = new System.Windows.Forms.Label();
            this.tblpac = new System.Windows.Forms.TableLayoutPanel();
            this.tblppsno = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuRegisterUserLogin.SuspendLayout();
            this.tblpacnum.SuspendLayout();
            this.tblpac.SuspendLayout();
            this.tblppsno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpacno1
            // 
            this.txtpacno1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpacno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpacno1.Location = new System.Drawing.Point(116, 7);
            this.txtpacno1.MaxLength = 1;
            this.txtpacno1.Name = "txtpacno1";
            this.txtpacno1.PasswordChar = '*';
            this.txtpacno1.Size = new System.Drawing.Size(16, 31);
            this.txtpacno1.TabIndex = 3;
            this.txtpacno1.TextChanged += new System.EventHandler(this.txtpacno1_TextChanged);
            // 
            // mnuRegisterUserLogin
            // 
            this.mnuRegisterUserLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.MnuExit});
            this.mnuRegisterUserLogin.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterUserLogin.Name = "mnuRegisterUserLogin";
            this.mnuRegisterUserLogin.Size = new System.Drawing.Size(584, 24);
            this.mnuRegisterUserLogin.TabIndex = 1;
            this.mnuRegisterUserLogin.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(38, 20);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tblpacnum
            // 
            this.tblpacnum.ColumnCount = 7;
            this.tblpacnum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblpacnum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tblpacnum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tblpacnum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tblpacnum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tblpacnum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tblpacnum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tblpacnum.Controls.Add(this.txtpacno5, 5, 0);
            this.tblpacnum.Controls.Add(this.txtpacno4, 4, 0);
            this.tblpacnum.Controls.Add(this.txtpacno3, 3, 0);
            this.tblpacnum.Controls.Add(this.txtpacno2, 2, 0);
            this.tblpacnum.Controls.Add(this.txtpacno1, 1, 0);
            this.tblpacnum.Location = new System.Drawing.Point(0, 104);
            this.tblpacnum.Name = "tblpacnum";
            this.tblpacnum.RowCount = 1;
            this.tblpacnum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpacnum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblpacnum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblpacnum.Size = new System.Drawing.Size(584, 46);
            this.tblpacnum.TabIndex = 2;
            // 
            // txtpacno5
            // 
            this.txtpacno5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpacno5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpacno5.Location = new System.Drawing.Point(448, 7);
            this.txtpacno5.MaxLength = 1;
            this.txtpacno5.Name = "txtpacno5";
            this.txtpacno5.PasswordChar = '*';
            this.txtpacno5.Size = new System.Drawing.Size(16, 31);
            this.txtpacno5.TabIndex = 7;
            this.txtpacno5.TextChanged += new System.EventHandler(this.txtpacno5_TextChanged);
            // 
            // txtpacno4
            // 
            this.txtpacno4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpacno4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpacno4.Location = new System.Drawing.Point(365, 7);
            this.txtpacno4.MaxLength = 1;
            this.txtpacno4.Name = "txtpacno4";
            this.txtpacno4.PasswordChar = '*';
            this.txtpacno4.Size = new System.Drawing.Size(16, 31);
            this.txtpacno4.TabIndex = 6;
            this.txtpacno4.TextChanged += new System.EventHandler(this.txtpacno4_TextChanged);
            // 
            // txtpacno3
            // 
            this.txtpacno3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpacno3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpacno3.Location = new System.Drawing.Point(282, 7);
            this.txtpacno3.MaxLength = 1;
            this.txtpacno3.Name = "txtpacno3";
            this.txtpacno3.PasswordChar = '*';
            this.txtpacno3.Size = new System.Drawing.Size(16, 31);
            this.txtpacno3.TabIndex = 5;
            this.txtpacno3.TextChanged += new System.EventHandler(this.txtpacno3_TextChanged);
            // 
            // txtpacno2
            // 
            this.txtpacno2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpacno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpacno2.Location = new System.Drawing.Point(199, 7);
            this.txtpacno2.MaxLength = 1;
            this.txtpacno2.Name = "txtpacno2";
            this.txtpacno2.PasswordChar = '*';
            this.txtpacno2.Size = new System.Drawing.Size(16, 31);
            this.txtpacno2.TabIndex = 4;
            this.txtpacno2.TextChanged += new System.EventHandler(this.txtpacno2_TextChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsubmit.Location = new System.Drawing.Point(202, 178);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(178, 48);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lblpac
            // 
            this.lblpac.AutoSize = true;
            this.lblpac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpac.Location = new System.Drawing.Point(50, 23);
            this.lblpac.Name = "lblpac";
            this.lblpac.Size = new System.Drawing.Size(472, 23);
            this.lblpac.TabIndex = 1;
            this.lblpac.Text = "Please enter a Personal Access Code(PAC)";
            // 
            // txtppsno
            // 
            this.txtppsno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtppsno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtppsno.Location = new System.Drawing.Point(226, 110);
            this.txtppsno.MaxLength = 9;
            this.txtppsno.Name = "txtppsno";
            this.txtppsno.Size = new System.Drawing.Size(131, 31);
            this.txtppsno.TabIndex = 10;
            this.txtppsno.TextChanged += new System.EventHandler(this.txtppsno_TextChanged);
            // 
            // lblppsno
            // 
            this.lblppsno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblppsno.AutoSize = true;
            this.lblppsno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblppsno.Location = new System.Drawing.Point(120, 36);
            this.lblppsno.Name = "lblppsno";
            this.lblppsno.Size = new System.Drawing.Size(342, 25);
            this.lblppsno.TabIndex = 9;
            this.lblppsno.Text = "Please enter your PPS number:";
            // 
            // tblpac
            // 
            this.tblpac.ColumnCount = 3;
            this.tblpac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.116791F));
            this.tblpac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.76642F));
            this.tblpac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.116791F));
            this.tblpac.Controls.Add(this.lblpac, 1, 1);
            this.tblpac.Location = new System.Drawing.Point(0, 27);
            this.tblpac.Name = "tblpac";
            this.tblpac.RowCount = 3;
            this.tblpac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpac.Size = new System.Drawing.Size(584, 71);
            this.tblpac.TabIndex = 0;
            // 
            // tblppsno
            // 
            this.tblppsno.ColumnCount = 3;
            this.tblppsno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tblppsno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tblppsno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tblppsno.Controls.Add(this.btnsubmit, 1, 5);
            this.tblppsno.Controls.Add(this.lblppsno, 1, 1);
            this.tblppsno.Controls.Add(this.txtppsno, 1, 3);
            this.tblppsno.Location = new System.Drawing.Point(0, 156);
            this.tblppsno.Name = "tblppsno";
            this.tblppsno.RowCount = 7;
            this.tblppsno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.954546F));
            this.tblppsno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tblppsno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.954546F));
            this.tblppsno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tblppsno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.954546F));
            this.tblppsno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tblppsno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.954546F));
            this.tblppsno.Size = new System.Drawing.Size(584, 254);
            this.tblppsno.TabIndex = 8;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FrmRegisterLoginData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.tblppsno);
            this.Controls.Add(this.tblpac);
            this.Controls.Add(this.tblpacnum);
            this.Controls.Add(this.mnuRegisterUserLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuRegisterUserLogin;
            this.MaximizeBox = false;
            this.Name = "FrmRegisterLoginData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris Bank - Register Login";
            this.Load += new System.EventHandler(this.FrmRegesterLoginData_Load);
            this.mnuRegisterUserLogin.ResumeLayout(false);
            this.mnuRegisterUserLogin.PerformLayout();
            this.tblpacnum.ResumeLayout(false);
            this.tblpacnum.PerformLayout();
            this.tblpac.ResumeLayout(false);
            this.tblpac.PerformLayout();
            this.tblppsno.ResumeLayout(false);
            this.tblppsno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpacno1;
        private System.Windows.Forms.MenuStrip mnuRegisterUserLogin;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.TableLayoutPanel tblpacnum;
        private System.Windows.Forms.TextBox txtpacno2;
        private System.Windows.Forms.TextBox txtpacno3;
        private System.Windows.Forms.TextBox txtpacno4;
        private System.Windows.Forms.TextBox txtpacno5;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lblpac;
        private System.Windows.Forms.TextBox txtppsno;
        private System.Windows.Forms.Label lblppsno;
        private System.Windows.Forms.TableLayoutPanel tblpac;
        private System.Windows.Forms.TableLayoutPanel tblppsno;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}