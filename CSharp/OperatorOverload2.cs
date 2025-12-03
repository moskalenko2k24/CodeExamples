using System;

class Code
{
	struct Square
	{
		public Square(int x = 0) { Size = x; }
		public int Size;
		
		public override string ToString()
		{
			return string.Format("[Square Size = {0}]", Size);
		}
		
		public static explicit operator Square(int x)
		{
			return new Square(x);
		}

	}
	
	struct Rectangle
	{
		public int Width;
		public int Heigth;
		
		public Rectangle(int a = 0, int b = 0) 
		{
			Width = a;
			Heigth = b;
		}
		
		public static explicit operator Square(Rectangle r)
		{
			return new Square(Math.Min(r.Width, r.Heigth));
		}
		
		/*public static implicit operator Square(Rectangle r)
		{
			return new Square(Math.Min(r.Width, r.Heigth));
		}*/
	}
	
	
	
	static void Main(string[] args)
	{
		Rectangle ABCD = new Rectangle(15, 5);
		Square sq = (Square)ABCD;
		Square sq2 = (Square)90;
		Console.WriteLine(sq);
		Console.WriteLine(sq2);
		Console.ReadLine();
	}
}