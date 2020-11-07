using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileJob
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Resource1.ResourceManager.GetString("data");
          
            Console.WriteLine(data);
            /*try
            {
                Console.WriteLine("Hello World!");
                string target_dir = @"E:\";
                string[] ex = { "*.exe", "*.o" };
                Deleter dl = new Deleter(target_dir, ex.ToList(), false, true);
                List<string> deletedFilesList = dl.clean();
                Console.WriteLine("Files deleted from {0} are :", target_dir);
                foreach (string file in deletedFilesList)
                {
                    Console.WriteLine("  " + file);
                }
                deletedFilesList = dl.whoDeniedAccess();
                if (deletedFilesList.Count > 0)
                {
                    Console.WriteLine("Those who denied access: ");
                    foreach (string file in deletedFilesList)
                    {
                        Console.WriteLine("  " + file);
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "Exceptoion");
            }*/
            for (int i = 0; i <= 0; i++)
            {

            }
            int i = 10;

        }


    }
}

    
