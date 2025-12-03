using System;

class Inheritance
{	
	class A
	{
		public virtual void print() { Console.WriteLine("A.print()"); }
	}
	
	class B: A
	{
		override sealed public void print() { Console.WriteLine("B.print()"); }
	}
	
	class C: B
	{
		//public override void print() { Console.WriteLine("C.print()"); }
	}
	
	static void Main()
	{
		
	}
}
