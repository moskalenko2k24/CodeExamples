using System;
using System.Linq;

class Program
{   
    static T[] CombineArrays<T>(params T[][] a)
    {
        return a.SelectMany(x => x).ToArray();
    }
        
    static void Main()
    {
        int[] a = {1, 2, 3};
        int[] b = {4, 5, 6, 7};
        int[] c = {8, 9, 10, 11, 12};
        
        int[] d = CombineArrays(a, b, c);
        foreach (int x in d)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        
        int[][] m = new[] 
        { 
            new[] {11, 12},
            new[] {13, 14, 15},
            new[] {16, 17, 18, 19}
        };
        
        int[] e = CombineArrays(m);
        foreach (int x in e)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        
        Console.ReadLine();
    }
}