using System;
using System.IO;   // StreamReader
using System.Text; // Encoding

namespace WorkWithFiles
{
    class Code
    {
        static void Main()
        {
            Console.WriteLine("Read lines:");
            try
            {
                using (var f = new StreamReader("in.txt", Encoding.Default))
                {
                    string line;
                    while ((line = f.ReadLine()) != null)
                        Console.WriteLine(line);
                }
            }
            catch
            {
                Console.WriteLine("Process failed!");
            }

            Console.WriteLine("Read chars:");
            try
            {
                using (var f = new StreamReader("in.txt", Encoding.Default))
                {
                    int x;
                    while ((x = f.Read()) != -1)
                    {
                        char c = (char)x;
                        Console.Write(c);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Process failed!");
            }
            // Also we can use ReadToEnd
            Console.ReadLine();
        }
    }
}