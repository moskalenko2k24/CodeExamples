using System;

class Inheritance
{	
	class A
	{
		public readonly int value;
		public A(int x = 0)
		{
			Console.WriteLine("A(int x = 0)");
			value = x;
		}
		
	}
	
	sealed class B: A
	{
		public readonly int key;
		public B(int x = 0, int y = 0): base(x)
		{
			Console.WriteLine("B(int x = 0, int y = 0)");
			key = y;
		}
	}
	
	static void Main()
	{
		B b = new B();
	}
}
