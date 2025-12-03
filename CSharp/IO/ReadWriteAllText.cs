using System;
using System.IO;   // File
using System.Text; // Encoding

namespace WorkWithFiles 
{
    class Code 
    {
        static void Main() 
        {
            // Console.WriteLine(File.ReadAllText("in.txt", Encoding.UTF8));
            Encoding enc = Encoding.UTF8;
            File.WriteAllText("out.txt", File.ReadAllText("in.txt", enc), enc);
        }
    }
}