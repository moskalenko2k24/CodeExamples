using System;

class Program
{
	static void ReflectOverAnonymousType(object obj)
	{
		Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
		Console.WriteLine("Base class of {0} is {1}",
		                  obj.GetType().Name,
		                  obj.GetType().BaseType);
		Console.WriteLine("obj.ToString() == {0}", obj.ToString());
		Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
		Console.WriteLine();
	}
	
	static void Main()
	{
		var me = new { Name = "Andrey", Age = 18 };
		var Andrey = new { Name = "Andrey", Age = 18 };
		ReflectOverAnonymousType(me);
		ReflectOverAnonymousType(Andrey);
		Console.WriteLine("me.Equals(Andrey) == {0}", me.Equals(Andrey)); // True 
		Console.WriteLine("(me == Andrey) == {0}", me == Andrey);         // False
		Console.ReadLine();
	}
}


