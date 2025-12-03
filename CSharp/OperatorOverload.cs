using System;

class Code
{
	class Point
	{
		int x { get; set; }
		int y { get; set; }
		public Point(int x = 0, int y = 0)
		{
			this.x = x;
			this.y = y;
		}
		
		public static Point operator + (Point a, Point b)
		{
			return new Point(a.x + b.x, a.y + b.y);
		}
		
		public static Point operator ++ (Point a) // prefix and postfix 
		{
			a.x++; a.y++;
			return a;
		}
		
		public override string ToString()
		{
			return string.Format("({0}; {1})", x, y);
		}	
		
		public override bool Equals(object obj)
		{
			return this.ToString() == obj.ToString();
		}

		public static bool operator ==(Point lhs, Point rhs) {
			return lhs.Equals(rhs);
		}

		public static bool operator !=(Point lhs, Point rhs) {
			return !lhs.Equals(rhs);
		}
	}
	
	static void Main(string[] args)
	{
		Point O = new Point();
		Point A = new Point(3, 4);
		A += new Point(2, 9); // += overloaded automatically
		Console.WriteLine(A); // 5 13
		//Console.WriteLine(A + O + new Point(10, 8));
		O++; ++O;
		Console.WriteLine(O); // 2 2
		Console.WriteLine(new Point(5, 15) == new Point(2 + 3, 10 + 5));
		Console.ReadLine();
	}
}