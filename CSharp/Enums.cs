using System;

class Enums
{
	enum Color: byte {
		Red,   // 0
		Green, // 1
		Blue   // 2
	}
	
	static void Main()
	{
		Color c = Color.Red;
		Console.WriteLine(Enum.GetUnderlyingType(c.GetType()));
		Console.WriteLine(Enum.GetUnderlyingType(typeof(Color)));
		Console.WriteLine("{0} = {1}", c.ToString(), (byte)c); // Red = 0
	}
}
