using System;
using System.Collections.Generic;

class Work
{
    static List<string>[] ListCreate()
    {
        return new List <string>[] {
            new List <string>() {"мама", "мыла"},
            new List <string>() {"Яна", "Наташа", "Марина"}
        };
    }
    
    static void Main(string[] args)
    {
        foreach (var arr in ListCreate())
            Console.WriteLine(string.Join(" ", arr));
    }
    
}