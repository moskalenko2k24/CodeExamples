using System;
using System.IO;   // File
using System.Linq; // Select, Sum

namespace WorkWithFiles 
{
    class Code 
    {
        static void Main() 
        {
            string[] input = File.ReadAllLines("in.txt");
            string output = "";
            for (int i = 1; i < input.Length; i++)
            {
                output += input[i].Split().Select(int.Parse).Sum() + " ";
            }
            File.WriteAllText("out.txt", output);
        }
    }
}