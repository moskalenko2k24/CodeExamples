using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Print<T>(IEnumerable<T> a) 
    {
        foreach (var x in a)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }
    
    public static void Main()
    {
        // string[] s = Console.ReadLine().Split();
        List <int> a = new List <int>(){1, 2, 3, 5}; // new List <int>(s.Length);
        //foreach (var i in s) a.Add(int.Parse(i));
        Console.WriteLine(a.Sum()); // 11
        Print(a = a.OrderBy(x => -x).ToList()); // 5 3 2 1
        
        a.AddRange(new int[] {1, 1, 1}); 
        Print(a); // 5 3 2 1 1 1 1
        
        a.Remove(1);  // O(n)
        Print(a); // 5 3 2 1 1 1
        
        a.RemoveAt(1); // O(n)
        Print(a); // 5 2 1 1 1
        
        a.RemoveAll(x => x == 1); // only Predicate, O(n)
        Print(a); // 5 2
    }
}