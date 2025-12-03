using System;

class Inheritance
{	
	class A
	{
		public int value;
	}
	
	sealed class B: A
	{
		public void print()
		{
			Console.WriteLine(value);
		}
	}
	
	class C: A // class C: B // error
	{
		
	}
	
	static void Main()
	{
		B b = new B();
		b.value = 123;
		b.print();
	}
}
