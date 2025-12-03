using System;
using System.Linq;

class Program
{
    static void QueryOverInts()
    {
        int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
        // Получить числа меньше 10.
        var subset = from i in numbers where i < 10 select i;
        // Запрос LINQ выполняется здесь!
        foreach (var i in subset)
        {
            Console.WriteLine("{0} < 10", i);
        }
        Console.WriteLine();
        // Изменить некоторые данные в массиве.
        numbers[0] = 4;
        // Запрос LINQ снова выполняется!
        foreach (var j in subset)
        {
            Console.WriteLine("{0} < 10", j);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        QueryOverInts();
        Console.ReadLine();
    }
}