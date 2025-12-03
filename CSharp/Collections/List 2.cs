using System;
using System.Collections.Generic;

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
        var a = new List<int>() {1, 1, 2, 2, 3, 4};
        a.RemoveRange(2, 3); // index, count of elements to remove
        Print(a); // 1 1 4
        
        a.Insert(1, 5); // position, value
        Print(a); // 1 5 1 4
        
        Console.WriteLine(a);
    }
}