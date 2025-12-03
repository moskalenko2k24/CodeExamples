using System;

class ParseFromString
{		
	static void Main()
	{
		Console.WriteLine("=> Data type parsing:");
		bool b = bool.Parse("True");
		Console.WriteLine("Value of b: {0}", b);
		
		double d = double.Parse("99,884");
		Console.WriteLine("Value of d: {0}", d);
		
		int i = int.Parse("8");
		Console.WriteLine("Value of i: {0}", i);
		
		char с = Char.Parse("w");
		Console.WriteLine("Value of с: {0}", с);
		
		Console.WriteLine();
	}
}
