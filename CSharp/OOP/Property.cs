using System;

class Property
{	
	class Human
	{
		int mID;
		public int ID 
		{
			get 
			{
				Console.WriteLine("mID get");
				return mID;
			}
			set
			{
				Console.WriteLine("mID set");
				mID = value;
			}
		}
	}
	
	static void Main()
	{
		Human h = new Human();
		h.ID = 123; // mID set
		Console.WriteLine(h.ID); // mID get 
	}
}
