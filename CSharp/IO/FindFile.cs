using System;
using System.IO;

namespace FileApp
{
    class Program
    {
        static bool FindFile(string folder, string fname)
        {
            bool found = false;
            string[] files;
            try
            {
                files = Directory.GetFiles(folder);
            }
            catch
            {
                return false;
            }
            foreach (var file in files)
            {
                if (Path.GetFileName(file) == fname) // IO.Path
                {
                    found = true;
                    Console.WriteLine(file);
                }
            }
            foreach (var subfolder in Directory.GetDirectories(folder))
            {
                found |= FindFile(subfolder, fname);
            }
            return found;
        }

        static void Main()
        {
            string folder = @"C:\";
            Console.WriteLine(folder);
            if (!FindFile(folder, "main.cpp"))
            {
                Console.WriteLine("File not found!");
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}