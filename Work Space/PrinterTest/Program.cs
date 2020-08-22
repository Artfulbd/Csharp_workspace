using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Diagnostics;

namespace PrinterTest
{
    class Program
    {
      
        private static Font printFont;
        private static StreamReader streamToPrint;
        static void Main(string[] args)
        {
            printButton_Click();
            Console.WriteLine("Finish");
            Console.ReadLine();
        }
        static void printButton_Click()
        {
            try
            {
                streamToPrint = new StreamReader("C:\\Users\\Dell\\Desktop\\TestDoc.docx");
                try
                {
                    printFont = new Font("Arial", 20);
                    PrintDocument pd = new PrintDocument();
                    //pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                    Console.WriteLine(pd.PrinterSettings.PrinterName);
                   // pd.PrinterSettings.PrinterName = "";
                    // Set the page orientation to landscape.
                    //pd.DefaultPageSettings.Landscape = true;
                    pd.Print();
                    //Console.WriteLine(streamToPrint);
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // The PrintPage event is raised for each page to be printed.
        static void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());

                
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
    }
}
