using System;
using System.IO;


namespace Printzone
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            /*string dir = "F:\\";
            try
            {
                string[] st = Directory.GetFiles(dir);
                foreach (string pt in st)
                {
                    Console.WriteLine(pt);
                }
            }catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }*/


            string sourceFile = @"C:\Users\Dell\Desktop\Prac\Hold\test.txt";
            string destinationFile = @"C:\Users\Dell\Desktop\testt.txt";

            // To move a file or folder to a new location:
            System.IO.File.Move(sourceFile, destinationFile);


        }
    }
}
