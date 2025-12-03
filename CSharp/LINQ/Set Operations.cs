using System;
using System.Linq;

class Program
{   
    static void Main()
    {
        int[] a = {4, 3, 2, 2, 1};
        int[] b = {6, 5, 4, 3};
        
        Console.WriteLine("A = {4, 3, 2, 2, 1}");
        Console.WriteLine("B = {6, 5, 4, 3}");
        
        Console.WriteLine("\na.Distinct()");
        var dist = a.Distinct();            // 4 3 2 1
        foreach (int x in dist)
        {
            Console.Write("{0} ", x);
        }
        Console.WriteLine();
        
        Console.WriteLine("\na.Concat(b)");
        var conc = a.Concat(b);            // 4 3 2 2 1 6 5 4 3
        foreach (int x in conc)
        {
            Console.Write("{0} ", x);
        }
        Console.WriteLine();
        
        
        // Set difference
        Console.WriteLine("\na.Except(b)");
        var difference = a.Except(b);       // 2 1
        foreach (int x in difference)
        {
            Console.Write("{0} ", x);
        }
        Console.WriteLine();
        
        // Set union
        Console.WriteLine("\na.Union(b)");
        var union = a.Union(b);             // 4 3 2 1 6 5
        foreach (int x in union)
        {
            Console.Write("{0} ", x);
        }
        Console.WriteLine();
        
        // Set intersection
        Console.WriteLine("\na.Intersect(b)");
        var intersection = a.Intersect(b);  // 4 3
        foreach (int x in intersection)
        {
            Console.Write("{0} ", x);
        }
        Console.WriteLine();
        
        
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}