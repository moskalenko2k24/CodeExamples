using System;

class Inheritance
{	
	class A
	{
		public void ololo() { Console.WriteLine("ololo"); }
	}
	
	class B: A
	{
		// warning without new
		public new void ololo() { Console.WriteLine("olololo"); }
	}
	
	class C
	{
		public virtual void kek() { Console.WriteLine("kek"); }
	}
	
	class D: C
	{
		public override void kek() { Console.WriteLine("kekeke"); }
	}
	
	static void Main()
	{
		B b = new B();
		b.ololo();  // olololo
		A bb = new B();
		bb.ololo(); // ololo
		
		C c = new C();
		c.kek(); // kek
		C d = new D();
		d.kek(); // kekeke
	}
}
