using System;

class ValueRefTypes
{
	struct Point // Value type
	{
		public int X;
		public int Y;
		
		public Point(int XPos, int YPos)
		{
			X = XPos;
			Y = YPos;
		}
		
		public void Display()
		{
			Console.WriteLine("X = {0}, Y = {1}", X, Y);
		}
	}
	
	class PointRef // Reference type
	{
		public int X;
		public int Y;
	
		public PointRef(int XPos, int YPos)
		{
			X = XPos;
			Y = YPos;
		}
		
		public void Display()
		{
			Console.WriteLine("X = {0}, Y = {1}", X, Y);
		}
	}
	
	static void ValueTypeAssignment()
	{
		Console.WriteLine("Assigning value types\n");
		Point pl = new Point(10, 10);
		Point p2 = pl;
		// Вывести обе переменных Point.
		pl.Display();
		p2.Display();
		// Изменить pl.X и вывести снова. Значение p2.X не изменилось.
		pl.X = 100;
		Console.WriteLine("\n=> Changed pl.X\n");
		pl.Display();
		p2.Display();
	}

	static void ReferenceTypeAssignment()
	{
		Console.WriteLine("Assigning reference types\n");
		PointRef pl = new PointRef(10, 10);
		PointRef p2 = pl;
		// Вывести обе переменных PointRef.
		pl.Display();
		p2.Display();
		// Изменить pl.X и вывести снова.
		pl.X = 100;
		Console.WriteLine("\n=> Changed pl.X\n");
		pl.Display();
		p2.Display();
	}


	static void Main()
	{
		ValueTypeAssignment();
		Console.WriteLine("-------------------------");
		ReferenceTypeAssignment();
	}
}
