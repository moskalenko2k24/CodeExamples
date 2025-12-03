using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            // int n = int.Parse(Console.ReadLine());
            var s = new SortedDictionary<int, int>(); // std::set
            string[] snums = Console.ReadLine().Split();
            int[] nums = new int[snums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(snums[i]);
            }

            foreach (var i in nums)
            {
                if (s.ContainsKey(i))
                {
                    s[i]++;
                }
                else
                {
                    s.Add(i, 1);
                }
            }
            foreach (var i in s)
            {
                for (int k = 0; k < i.Value; k++)
                {
                    Console.Write(i.Key + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
/*
    5 0 9 11 2 23 2 2 3 0 11 2 4 7 5 8 9 6 13
    0 0 2 2 2 2 3 4 5 5 6 7 8 9 9 11 11 13 23
*/