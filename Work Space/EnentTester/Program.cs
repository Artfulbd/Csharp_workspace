using iTextSharp.text.pdf;
using System;
using System.Threading;

namespace EnentTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = new Tester();
            
            test.FileEvent += FileInsertedEvent;
            test.fire();
            /*var punch = new RFIDPunch(); // publisher

            punch.RFIDPunchEvent += Punch_RFIDPunchEvent; // subscriber 
            punch.tester();
            punch.tester();
            Console.WriteLine("Done.....!");*/


        }
        private static void FileInsertedEvent(object sender, FileInsertionEventArgs e)
        {
            Console.WriteLine("Name:  " + e.name);
            Console.WriteLine("Page count  " + e.page_count);
            Console.WriteLine("Size  " + e.size);
            Console.WriteLine("Time  " + e.time);
        }

        /*private static void Punch_RFIDPunchEvent(object sender, RFIDPunchedEventArgs e)
        {
            Console.WriteLine("Event catched! Got notification:  " + e.getName());
        }*/
    }
    class Tester
    {
        
        public event EventHandler<FileInsertionEventArgs> FileEvent;

        public void fire()
        {
            fireEvent();
        }

        protected virtual void fireEvent()
        {
            string file_name = @"C:\Users\Artful\Desktop\NSU PDF\3. App Layer Protocols.pdf";
            FileEvent?.Invoke(this, new FileInsertionEventArgs(file_name));
        }

    }
    class FileInsertionEventArgs : EventArgs
    {
        public string name{ get; }
        public int page_count { get; }
        public DateTime time { get; }
        public double size { get; }
        public FileInsertionEventArgs(string name)
        {
            this.name = name;
            System.IO.FileInfo fi = new System.IO.FileInfo(name);
            if (fi.Exists)
            {
                this.page_count = new PdfReader(name).NumberOfPages;
                this.time = fi.LastWriteTime;
                this.size = fi.Length / 1024;
            }
            
        }
    }

    /*public class RFIDPunchedEventArgs : EventArgs //custom event argument class
    {
        private string name = "I am something from RFID event";
        public RFIDPunchedEventArgs(string file_name)
        {
            this.name = file_name;
        }
        public string getName()
        {
            return this.name;
        }
    }
    public class RFIDPunch
    {
        public delegate void RFIDPunchedEnentHandeler(object sender, RFIDPunchedEventArgs e);
        public event RFIDPunchedEnentHandeler RFIDPunchEvent;
        public void tester()
        {
            fireRFIDPunch();
        }

        protected virtual void fireRFIDPunch()
        {
            Thread.Sleep(2000);
            RFIDPunchEvent?.Invoke(this, new RFIDPunchedEventArgs("my file name"));
            // this _" ?. "_ is equivalant to if(RFIDPunchEvent != null)
        }

    }*/
}
