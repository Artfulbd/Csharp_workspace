namespace Paxton.Net2.OemSample.GetEventDescriptions
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
			this.gbpGetEventDescriptions = new System.Windows.Forms.GroupBox();
			this.dgEventDescriptions = new System.Windows.Forms.DataGridView();
			this.lblEventDescriptions = new System.Windows.Forms.Label();
			this.gbpGetEventDescriptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgEventDescriptions)).BeginInit();
			this.SuspendLayout();
			// 
			// gbpGetEventDescriptions
			// 
			this.gbpGetEventDescriptions.Controls.Add(this.dgEventDescriptions);
			this.gbpGetEventDescriptions.Controls.Add(this.lblEventDescriptions);
			this.gbpGetEventDescriptions.Location = new System.Drawing.Point(13, 13);
			this.gbpGetEventDescriptions.Name = "gbpGetEventDescriptions";
			this.gbpGetEventDescriptions.Size = new System.Drawing.Size(485, 222);
			this.gbpGetEventDescriptions.TabIndex = 0;
			this.gbpGetEventDescriptions.TabStop = false;
			this.gbpGetEventDescriptions.Text = "Get event descriptions...";
			// 
			// dgEventDescriptions
			// 
			this.dgEventDescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEventDescriptions.Location = new System.Drawing.Point(113, 28);
			this.dgEventDescriptions.Name = "dgEventDescriptions";
			this.dgEventDescriptions.Size = new System.Drawing.Size(354, 177);
			this.dgEventDescriptions.TabIndex = 2;
			// 
			// lblEventDescriptions
			// 
			this.lblEventDescriptions.AutoSize = true;
			this.lblEventDescriptions.Location = new System.Drawing.Point(7, 28);
			this.lblEventDescriptions.Name = "lblEventDescriptions";
			this.lblEventDescriptions.Size = new System.Drawing.Size(99, 13);
			this.lblEventDescriptions.TabIndex = 1;
			this.lblEventDescriptions.Text = "Event Descriptions:";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 246);
			this.Controls.Add(this.gbpGetEventDescriptions);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "GetEventDescriptions";
			this.gbpGetEventDescriptions.ResumeLayout(false);
			this.gbpGetEventDescriptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgEventDescriptions)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbpGetEventDescriptions;
		private System.Windows.Forms.Label lblEventDescriptions;
		private System.Windows.Forms.DataGridView dgEventDescriptions;
	}
}