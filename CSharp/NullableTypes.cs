using System;

class NullableTypes
{
	static void Main()
	{
		int? x = null; // System.Nullable<int>
		Console.WriteLine(x ?? -1);
	}
}
