using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaner
{
    public partial class Form1 : Form
    {
        private List<String> extList = new List<String>();
        public Form1()
        {
            InitializeComponent();
            cleanBtn.Enabled = false;
            loadExtentionsCombo();
        }


        private void loadExtentionsCombo()
        {
            extComboBox.BeginUpdate();
            const string ex = "ext";
            string data = Resource1.ResourceManager.GetString("count");
            int count = Int32.Parse(data);
            try
            {
                for (int i = 0; i < count; i++)
                {
                    data = Resource1.ResourceManager.GetString(ex + i.ToString());
                    if (data.Length > 1)
                    {
                        extComboBox.Items.Add(data);
                    }
                }
            }
            catch (Exception e) { /*set error here*/ }

            extComboBox.EndUpdate();
        }




        private void extComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            
            string target = extComboBox.SelectedItem.ToString();
            bool hasInList = false;
            for (int i = listBox1.Items.Count - 1; i > -1; i--)
            {
                if (listBox1.Items[i].ToString().Equals(target))
                {
                    listBox1.Items.RemoveAt(i);
                    extList.Remove(target);
                    hasInList = true;
                    break;
                }
            }
            if (!hasInList)
            {
                if(!pathTextBox.Text.Equals(""))
                    cleanBtn.Enabled = true;
                listBox1.Items.Add(target);
                extList.Add(target);
            }
            listBox1.EndUpdate();
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            Deleter dlt = new Deleter(pathTextBox.Text, extList, cCheckBox.Checked, sCheckBox.Checked, viewCheckBox.Checked);
            List<String> deletedFiles;
            try
            {
                deletedFiles = dlt.clean();
                loadOnListBox(deletedFiles, dlt.whoDeniedAccess());
            }
            catch (DirectoryNotFoundException de){seletedFilelTextBox.Text = de.ToString();}
            catch (FormatException fe){seletedFilelTextBox.Text = fe.ToString();}
        }

        private void loadOnListBox(List<String> deletedFiles, List<String> deniedFiles)
        {
            seletedFilelTextBox.Text = "";
            deniedFileTextBox.Text = "";
            string deleted = "", denied = "";
            foreach(string st in deletedFiles)
            {
                deleted += st + "\n";
            }
            string stt = viewCheckBox.Checked ? "Matched files.  toral" : "Deleted files.   total:";
            labelDeleted.Text = stt + deletedFiles.Count.ToString();
            seletedFilelTextBox.Text = deleted.Equals("") ? "No match found..!" : deleted;

            foreach (string st in deniedFiles)
            {
                denied += st + "\n";
            }
            labelDenied.Text = "Those who denied acces.  total:" + deniedFiles.Count.ToString();
            deniedFileTextBox.Text = denied.Equals("") ? "No one..!" : denied; ;

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            cleanBtn.Enabled = false;
            pathTextBox.Text = "";

            labelDeleted.Text = "Deleted files.";
            labelDenied.Text = "Those who denied acces.";

            seletedFilelTextBox.Text = "";
            deniedFileTextBox.Text = "";

            listBox1.Items.Clear();
            extList.Clear();            
        }

        private void pathTextBox_doubleClicked(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Choose path"})
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                    pathTextBox.Text = fbd.SelectedPath;
            }
        }
    }
}
