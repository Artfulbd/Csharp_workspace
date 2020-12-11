using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace PrintToPRinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const string dir = @"C:\Users\Artful\Desktop\NSU PDF";
            FileArivalHandeler(dir);


        }
        static void printThis()
        {
            string pathPdf = @"C:/Users/Artful/Desktop/Testing.pdf";
            ProcessStartInfo infoPrintPdf = new ProcessStartInfo();
            infoPrintPdf.FileName = pathPdf;
            // The printer name is hardcoded here, but normally I get this from a combobox with all printers
            string printerName = "Canon iP2700 series";
            string driverName = "printqueue.inf";
            string portName = "USB001";
            infoPrintPdf.FileName = @"C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe";
            //infoPrintPdf.FileName = @"E:\AcroRd32.exe";
            //infoPrintPdf.Arguments = string.Format("/t {0} \"{1}\" \"{2}\" \"{3}\"",pathPdf, printerName, driverName, portName);
            infoPrintPdf.Arguments = type();

            Console.WriteLine(infoPrintPdf.Arguments.ToString());
            infoPrintPdf.CreateNoWindow = false;
            infoPrintPdf.UseShellExecute = false;
            infoPrintPdf.WindowStyle = ProcessWindowStyle.Hidden;
            Process printPdf = new Process();
            printPdf.StartInfo = infoPrintPdf;
            printPdf.Start();

            // This time depends on the printer, but has to be long enough to
            // let the printer start printing
            System.Threading.Thread.Sleep(10000);

            if (!printPdf.CloseMainWindow())              // CloseMainWindow never seems to succeed
            {
                printPdf.Kill();
                printPdf.WaitForExit();  // Kill AcroRd32.exe
            }

            printPdf.Close();  // Close the process and release resources
        }

        static string type()
        {
            string pathPdf = @"C:/Users/Artful/Desktop/Testing.pdf";
            string printerName = "Canon iP2700 series";
            string driverName = "printqueue.inf";
            string portName = "USB001";
            return string.Format("/t {0} \"{1}\" \"{2}\" \"{3}\"",pathPdf, printerName, driverName, portName);
        }

        static void FileArivalHandeler(string loc)
        {
            //string[] args = Environment.GetCommandLineArgs();

            // Create a new FileSystemWatcher and set its properties.
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = loc;

                // Watch for changes in LastAccess and LastWrite times, and
                // the renaming of files or directories.
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                // Only watch text files.
                watcher.Filter = "*.pdf";

                // Add event handlers.
                //watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
               // watcher.Deleted += OnChanged;

                // Begin watching.
                watcher.EnableRaisingEvents = true;

                // Wait for the user to quit the program.
                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }
        }
         private static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            

            Console.WriteLine($"File: {e.FullPath} filename:{e.Name}");
            string old = e.FullPath;
            Thread.Sleep(1000);
            string dir = @"C:\Users\Artful\Desktop\NewDir\"+e.Name;
            Console.WriteLine($"New dir: {dir}");
            File.Copy(old, dir, true);
            File.Delete(old);
        }

    }
}
