using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] droppedfiles = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
                if (droppedfiles.Length > 0)
                {
                    foreach (string hold in droppedfiles)
                    {
                        string fileName = getFileName(hold);
                        listBox1.Items.Add(fileName);
                        //listBox1.Items.Add(hold);
                    }
                }

            }catch(Exception catchedExcption)
            {
                listBox1.Items.Add("Are you fool or something");
            }
              
        }

        private string getFileName(string path)
        {
            if (Directory.Exists(path)) return "This is not a file";
            //else return Path.GetExtension(path);
            else return Path.GetFileNameWithoutExtension(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
