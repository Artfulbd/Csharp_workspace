namespace Paxton.Net2.OemSample.ViewEvents
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.dgvEvents = new System.Windows.Forms.DataGridView();
			this.gpbViewEvents = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
			this.gpbViewEvents.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvEvents
			// 
			this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEvents.Location = new System.Drawing.Point(15, 19);
			this.dgvEvents.Name = "dgvEvents";
			this.dgvEvents.Size = new System.Drawing.Size(898, 308);
			this.dgvEvents.TabIndex = 0;
			// 
			// gpbViewEvents
			// 
			this.gpbViewEvents.Controls.Add(this.dgvEvents);
			this.gpbViewEvents.Location = new System.Drawing.Point(13, 13);
			this.gpbViewEvents.Name = "gpbViewEvents";
			this.gpbViewEvents.Size = new System.Drawing.Size(931, 347);
			this.gpbViewEvents.TabIndex = 2;
			this.gpbViewEvents.TabStop = false;
			this.gpbViewEvents.Text = "View events...";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 380);
			this.Controls.Add(this.gpbViewEvents);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "ViewEvents";
			((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
			this.gpbViewEvents.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvEvents;
		private System.Windows.Forms.GroupBox gpbViewEvents;
	}
}