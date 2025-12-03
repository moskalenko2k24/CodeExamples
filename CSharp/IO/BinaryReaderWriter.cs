using System;
using System.IO;

struct State
{
    public string name;
    public string capital;
    public int area;
    public double people;
 
    public State(string n, string c, int a, double p)
    {
        name = n;
        capital = c;
        people = p;
        area = a;
    }
}

class Program
{
    static void Main(string[] args)
    {
        State[] states = new State[2];
        states[0] = new State("Германия", "Берлин",  357168,  80.8);
        states[1] = new State("Франция", "Париж", 640679, 64.7);
 
		string path = "data.txt";
 
        try
        {
            /*using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach (State s in states)
                {
                    writer.Write(s.name);
                    writer.Write(s.capital);
                    writer.Write(s.area);
                    writer.Write(s.people);
                }
            }*/

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                // while not end of file
                while (reader.PeekChar() > -1)
                {
                    string name = reader.ReadString();
                    string capital = reader.ReadString();
                    int area = reader.ReadInt32();
                    double population = reader.ReadDouble();
 
                    Console.WriteLine("Страна: {0}  столица: {1}  площадь {2} кв. км   численность населения: {3} млн. чел.", 
                        name, capital, area, population);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
    }
}