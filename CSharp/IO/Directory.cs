using System;
using System.IO;

namespace FileApp
{
    class Program
    {
        static void Main()
        {
            string folder = @"E:\";
            Console.WriteLine(folder);
            if (Directory.Exists(folder))
            {
                foreach (var subfolder in Directory.GetDirectories(folder))
                {
                    Console.WriteLine(subfolder);
                }
                foreach (var file in Directory.GetFiles(folder))
                {
                    Console.WriteLine(file);
                }
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}