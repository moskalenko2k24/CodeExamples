using System;

class StaticClass
{	
	// Статические классы могут содержать только статические члены!
	static class TimeUtilClass
	{
		public static void PrintTime()
		{ Console.WriteLine(DateTime.Now.ToShortTimeString()); }
		public static void PrintDate()
		{ Console.WriteLine(DateTime.Today.ToShortDateString()); }
	}


	
	static void Main()
	{
		// TimeUtilClass u = new TimeUtilClass(); // Copmile error
		TimeUtilClass.PrintDate();
		TimeUtilClass.PrintTime();
		Console.ReadLine();
	}
}
