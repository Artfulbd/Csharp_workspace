using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




using System.Windows.Forms;

using System.Drawing.Printing;
using System.Reflection.Metadata;

namespace PrintByDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiated an object of Spire.Doc.Document
            
            Document doc = new Document();
            
            //Load word document

            doc.LoadFromFile("sample.doc");
            
            // Instantiated System.Windows.Forms.PrintDialog object .

            PrintDialog dialog = new PrintDialog();
            
            dialog.AllowPrintToFile = true;
            
            dialog.AllowCurrentPage = true;
            
            dialog.AllowSomePages = true;
            
            dialog.UseEXDialog = true;
            
       // associate System.Windows.Forms.PrintDialog object with Spire.Doc.Document 

            doc.PrintDialog = dialog;
            
            PrintDocument printDoc = doc.PrintDocument;
            
            //Background printing 

            printDoc.Print();
           
            //Interaction printing 

            if (dialog.ShowDialog() == DialogResult.OK)
                
            {
                
                printDoc.Print();
                
            }
        }
    }
}
