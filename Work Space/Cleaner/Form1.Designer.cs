namespace Cleaner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cleanBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.extComboBox = new System.Windows.Forms.ComboBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.cCheckBox = new System.Windows.Forms.CheckBox();
            this.sCheckBox = new System.Windows.Forms.CheckBox();
            this.deniedFileTextBox = new System.Windows.Forms.RichTextBox();
            this.seletedFilelTextBox = new System.Windows.Forms.RichTextBox();
            this.labelDenied = new System.Windows.Forms.Label();
            this.labelDeleted = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.label3 = new System.Windows.Forms.Label();
            this.viewCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cleanBtn
            // 
            resources.ApplyResources(this.cleanBtn, "cleanBtn");
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // pathTextBox
            // 
            resources.ApplyResources(this.pathTextBox, "pathTextBox");
            this.pathTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.pathTextBox.Name = "pathTextBox";
            this.toolTip1.SetToolTip(this.pathTextBox, resources.GetString("pathTextBox.ToolTip"));
            this.pathTextBox.DoubleClick += new System.EventHandler(this.pathTextBox_doubleClicked);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // extComboBox
            // 
            resources.ApplyResources(this.extComboBox, "extComboBox");
            this.extComboBox.FormattingEnabled = true;
            this.extComboBox.Name = "extComboBox";
            this.extComboBox.TabStop = false;
            this.extComboBox.SelectedIndexChanged += new System.EventHandler(this.extComboBox_SelectedIndexChanged);
            // 
            // resetBtn
            // 
            resources.ApplyResources(this.resetBtn, "resetBtn");
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // cCheckBox
            // 
            resources.ApplyResources(this.cCheckBox, "cCheckBox");
            this.cCheckBox.Name = "cCheckBox";
            this.cCheckBox.UseVisualStyleBackColor = true;
            // 
            // sCheckBox
            // 
            resources.ApplyResources(this.sCheckBox, "sCheckBox");
            this.sCheckBox.Name = "sCheckBox";
            this.sCheckBox.UseVisualStyleBackColor = true;
            // 
            // deniedFileTextBox
            // 
            resources.ApplyResources(this.deniedFileTextBox, "deniedFileTextBox");
            this.deniedFileTextBox.BackColor = System.Drawing.Color.Linen;
            this.deniedFileTextBox.Name = "deniedFileTextBox";
            this.deniedFileTextBox.ReadOnly = true;
            // 
            // seletedFilelTextBox
            // 
            resources.ApplyResources(this.seletedFilelTextBox, "seletedFilelTextBox");
            this.seletedFilelTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.seletedFilelTextBox.Name = "seletedFilelTextBox";
            this.seletedFilelTextBox.ReadOnly = true;
            // 
            // labelDenied
            // 
            resources.ApplyResources(this.labelDenied, "labelDenied");
            this.labelDenied.Name = "labelDenied";
            // 
            // labelDeleted
            // 
            resources.ApplyResources(this.labelDeleted, "labelDeleted");
            this.labelDeleted.Name = "labelDeleted";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // viewCheckBox
            // 
            resources.ApplyResources(this.viewCheckBox, "viewCheckBox");
            this.viewCheckBox.Name = "viewCheckBox";
            this.viewCheckBox.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ArifulLinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.viewCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDeleted);
            this.Controls.Add(this.labelDenied);
            this.Controls.Add(this.seletedFilelTextBox);
            this.Controls.Add(this.deniedFileTextBox);
            this.Controls.Add(this.sCheckBox);
            this.Controls.Add(this.cCheckBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.extComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cleanBtn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Aquamarine;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox extComboBox;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.CheckBox sCheckBox;
        private System.Windows.Forms.CheckBox cCheckBox;
        private System.Windows.Forms.RichTextBox deniedFileTextBox;
        private System.Windows.Forms.RichTextBox seletedFilelTextBox;
        private System.Windows.Forms.Label labelDeleted;
        private System.Windows.Forms.Label labelDenied;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox viewCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

