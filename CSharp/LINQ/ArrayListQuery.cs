using System;
using System.Collections;
using System.Linq;

class Program
{
    static void ArrayListQuery()
    {
        ArrayList a = new ArrayList()
        {
            3, 4, 1, 5, new { Name = "Andrew", Age = 18 }, 10, 3, 3, 2, 0, 1, -1
        };
        var nums = a.OfType<int>();
        var numbers = from num in nums where num < 4 select num;
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
    
    static void Main()
    {
        ArrayListQuery();
        Console.ReadLine();
    }
}