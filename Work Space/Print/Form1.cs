using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public PrinterSettings.PaperSizeCollection A4 { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Something";
            listBox1.Text = "Done";
            Print();
            //pageSetupDialog1.ShowDialog();
        }
        private void Print()
        {

            string name = "";
            List<string> PrinterFound = new List<string>();
           // PrinterSettings printer = new PrinterSettings();
            int i = 0;
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                PrinterFound.Add(item.ToString());
                label1.Text = item.ToString();
                Console.WriteLine(PrinterFound[i++]);
            }
          //  printer.PrinterName = PrinterFound[0];
            label1.Text = PrinterFound[0];

            PrintDocument PrintDoc = new PrintDocument();

            PrintDoc.DocumentName = @"E:/GIT/Smart_printZone/Idea.pdf";
            PrintDoc.PrinterSettings.PrinterName = PrinterFound[0];
            //PrintDoc.PrinterSettings.PaperSizes = A4;

            PrintDoc.Print();
        }
    }
}
