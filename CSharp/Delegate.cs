using System;

class Program
{
	public delegate int BinOp(int x, int y);
	
	static int Mult(int a, int b) { return a * b; }
	static int Sum(int a, int b) { return a + b; }
	
	static int Calc(int a, int b, BinOp f)
	{
		//return f.Invoke(a, b);
		return f(a, b);
	}
	
	static void DisplayDelegateInfo(Delegate delObj)
	{
		foreach (Delegate d in delObj.GetInvocationList())
		{
			Console.WriteLine("Method Name: {0}", d.Method);
			Console.WriteLine("Type Name: {0}", d.Target); 	 
		}
	}

	
	static void Main()
	{
		int x = 3;
		int y = 4;
		Console.WriteLine("{0} * {1} = {2}", x, y, Calc(x, y, Mult));
		BinOp s = new BinOp(Sum); // BinOp s = Sum;
		Console.WriteLine("{0} + {1} = {2}", x, y, Calc(x, y, s));
		Console.WriteLine("{0} + {1} = {2}", 2, 9, Calc(2, 9, s));
		Console.WriteLine("----------");
		DisplayDelegateInfo(new BinOp(Sum));
		Console.ReadLine();
	}
}
