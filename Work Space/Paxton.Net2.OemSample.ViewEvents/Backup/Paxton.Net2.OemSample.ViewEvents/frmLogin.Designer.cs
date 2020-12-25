namespace Paxton.Net2.OemSample.ViewEvents
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.cmbOperators = new System.Windows.Forms.ComboBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lnkFindServer = new System.Windows.Forms.LinkLabel();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblPassword = new System.Windows.Forms.Label();
			this.OperatorName = new System.Windows.Forms.Label();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.lblServerName = new System.Windows.Forms.Label();
			this.gpbLogin = new System.Windows.Forms.GroupBox();
			this.statusStrip.SuspendLayout();
			this.gpbLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbOperators
			// 
			this.cmbOperators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOperators.Enabled = false;
			this.cmbOperators.FormattingEnabled = true;
			this.cmbOperators.Location = new System.Drawing.Point(97, 45);
			this.cmbOperators.Name = "cmbOperators";
			this.cmbOperators.Size = new System.Drawing.Size(149, 21);
			this.cmbOperators.TabIndex = 11;
			// 
			// btnLogin
			// 
			this.btnLogin.Enabled = false;
			this.btnLogin.Location = new System.Drawing.Point(264, 71);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(68, 20);
			this.btnLogin.TabIndex = 10;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lnkFindServer
			// 
			this.lnkFindServer.AutoSize = true;
			this.lnkFindServer.Location = new System.Drawing.Point(261, 26);
			this.lnkFindServer.Name = "lnkFindServer";
			this.lnkFindServer.Size = new System.Drawing.Size(61, 13);
			this.lnkFindServer.TabIndex = 9;
			this.lnkFindServer.TabStop = true;
			this.lnkFindServer.Text = "Find Server";
			this.lnkFindServer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFindServer_LinkClicked);
			// 
			// txtPassword
			// 
			this.txtPassword.Enabled = false;
			this.txtPassword.Location = new System.Drawing.Point(97, 72);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(149, 20);
			this.txtPassword.TabIndex = 4;
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 136);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(380, 22);
			this.statusStrip.TabIndex = 6;
			this.statusStrip.Text = "statusStrip1";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(42, 17);
			this.statusLabel.Text = "Ready.";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(17, 75);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 5;
			this.lblPassword.Text = "Password";
			// 
			// OperatorName
			// 
			this.OperatorName.AutoSize = true;
			this.OperatorName.Location = new System.Drawing.Point(17, 48);
			this.OperatorName.Name = "OperatorName";
			this.OperatorName.Size = new System.Drawing.Size(74, 13);
			this.OperatorName.TabIndex = 3;
			this.OperatorName.Text = "Net2 Operator";
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(97, 19);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(149, 20);
			this.txtServer.TabIndex = 1;
			// 
			// lblServerName
			// 
			this.lblServerName.AutoSize = true;
			this.lblServerName.Location = new System.Drawing.Point(17, 22);
			this.lblServerName.Name = "lblServerName";
			this.lblServerName.Size = new System.Drawing.Size(64, 13);
			this.lblServerName.TabIndex = 0;
			this.lblServerName.Text = "Net2 Server";
			// 
			// gpbLogin
			// 
			this.gpbLogin.Controls.Add(this.cmbOperators);
			this.gpbLogin.Controls.Add(this.btnLogin);
			this.gpbLogin.Controls.Add(this.lnkFindServer);
			this.gpbLogin.Controls.Add(this.lblPassword);
			this.gpbLogin.Controls.Add(this.txtPassword);
			this.gpbLogin.Controls.Add(this.OperatorName);
			this.gpbLogin.Controls.Add(this.txtServer);
			this.gpbLogin.Controls.Add(this.lblServerName);
			this.gpbLogin.Location = new System.Drawing.Point(12, 12);
			this.gpbLogin.Name = "gpbLogin";
			this.gpbLogin.Size = new System.Drawing.Size(353, 109);
			this.gpbLogin.TabIndex = 5;
			this.gpbLogin.TabStop = false;
			this.gpbLogin.Text = "Login example...";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 158);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.gpbLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmLogin";
			this.Text = "Authenticate";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.gpbLogin.ResumeLayout(false);
			this.gpbLogin.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbOperators;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.LinkLabel lnkFindServer;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label OperatorName;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label lblServerName;
		private System.Windows.Forms.GroupBox gpbLogin;
	}
}