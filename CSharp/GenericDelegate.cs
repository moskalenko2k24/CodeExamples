using System;

class Program
{
	public delegate void GenericDelegate<T>(T arg);
	
	static void Main(string[] args)
	{
		Console.WriteLine("***** Generic Delegates *****\n");
		// Зарегистрировать цели.
		GenericDelegate<string> strTarget =
			new GenericDelegate<string>(StringTarget);
		strTarget("Some string data");
		GenericDelegate<int> intTarget =
			new GenericDelegate<int>(IntTarget);
		intTarget(9);
		Console.ReadLine();
	}
	
	static void StringTarget(string arg)
	{
		Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
	}
	
	static void IntTarget(int arg)
	{
		Console.WriteLine("++arg is: {0}", ++arg);
	}

}