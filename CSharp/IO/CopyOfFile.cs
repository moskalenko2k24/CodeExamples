using System;
using System.IO; // File

namespace WorkWithFiles
{
    class Code
    {
        static void Main()
        {
            File.WriteAllBytes("2.pdf", File.ReadAllBytes("1.pdf")); // Copy of file
            // File.Copy("1.pdf", "2.pdf"); // it's the same :D
        }
    }
}