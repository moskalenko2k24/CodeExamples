using System;

class Constructors
{
	
	class Motorcycle
	{
		public int driverIntensity;
		public string driverName;
		// Связывание конструкторов в цепочку.
		public Motorcycle() {}
		public Motorcycle(int intensity): this(intensity, "") 
		{
			Console.WriteLine("Motorcycle(int intensity)");
		}
		public Motorcycle(string name): this (0, name) 
		{
			Console.WriteLine("Motorcycle(string name)");
		}
		
		// Это 'главный конструктор', выполняющий всю реальную работу,
		public Motorcycle(int intensity, string name)
		{
			Console.WriteLine("Motorcycle(int intensity, string name)");
			if (intensity > 10)
			{
				intensity = 10;
			}
		}
	}
	
	static void Main()
	{
		Motorcycle m1 = new Motorcycle();
		Motorcycle m2 = new Motorcycle(12);
		Motorcycle m3 = new Motorcycle("BMW"); 
	}
}
