using System;
 
namespace CloneObj
{
	public class PointDescription
	{
		public string PetName {get; set;}
		public Guid PointID {get; set;}
		public PointDescription()
		{
			PetName = "No-name";
			PointID = Guid.NewGuid();
		}
		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
	
	public class Point: ICloneable
	{
		public int X {get; set;}
		public int Y {get; set;}
		public PointDescription desc = new PointDescription();
		
		public Point(int xPos, int yPos, string petName)
		{
			X = xPos; Y = yPos;
			desc.PetName = petName;
		}
		public Point() { }
		public override string ToString()
		{
			return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}\n", X, Y, desc.PetName, desc.PointID);
		}
		public object Clone()
		{
			//return this.MemberwiseClone();
			Point c = new Point(X, Y, desc.PetName);
			c.desc = (PointDescription)desc.Clone();
			return c;
		}
	}
 
	class Code 
	{
		static void Main()
		{
			Console.WriteLine("***** Fun with Object Cloning *****\n");
			Console.WriteLine("Cloned рЗ and stored new Point in p4");
			Point p3 = new Point(100, 100, "Jane");
			Point p4 = (Point)p3.Clone();
			Console.WriteLine("Before modification:");
			Console.WriteLine("p3: {0}", p3);
			Console.WriteLine("p4: {0}", p4);
			p4.desc.PetName = "My new Point";
			p4.X = 9;
			Console.WriteLine("\nChanged p4.desc.petName and p4.X");
			Console.WriteLine("After modification:");
			Console.WriteLine("p3: {0}", p3);
			Console.WriteLine("p4: {0}", p4);
			Console.ReadLine();
		}
	}
}
