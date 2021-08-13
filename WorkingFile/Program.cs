using System;
using System.IO;
using System.Collections.Generic;

namespace WorkingFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\Users\cassielcortez\Desktop\oi";
            //string targetPath = @"C:\Users\cassielcortez\Desktop\oi\file2.txt"


            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(sourcePath + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            //string[] lines = File.ReadAllLines(sourcePath);

            //using (StreamWriter sw = File.AppendText(targetPath))
            //{
            //    foreach (string line in lines)
            //    {
            //        sw.WriteLine(line.ToUpper());
            //    }

            //}

            //try
            //{
            //    using (StreamReader sr = File.OpenText(sourcePath))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}


            //string targetPath = @"C:\Users\cassielcortez\Desktop\oi\file2.txt";

            //FileStream fileStream = null;
            //StreamReader streamReader = null;

            //try
            //{
            //    streamReader = File.OpenText(sourcePath);
            //    while (!streamReader.EndOfStream)
            //    {
            //        string line = streamReader.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred:" + e.Message);
            //}
            //finally
            //{
            //    if (streamReader != null) streamReader.Close();
            //}
        }
    }
}
