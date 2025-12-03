using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void QueryOverStrings()
    {
        string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};
        IEnumerable<string> subset = from game in currentVideoGames 
                                     where game.Contains(" ") 
                                     orderby game select game;
        foreach (string game in subset)
            Console.WriteLine(game);
    }
    
    static void Main()
    {
        Console.WriteLine("***** Fun with LINQ to Objects *****\n");
        QueryOverStrings();
        Console.ReadLine();
    }
}