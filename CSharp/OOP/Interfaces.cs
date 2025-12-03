using System;

class Interfaces
{	
	
	public interface IDrawToScreen
	{
		void Draw();
	}
	
	public interface IDrawToPrinter
	{
		void Draw();
	}
	
	class Circle: IDrawToPrinter, IDrawToScreen
	{
		void IDrawToPrinter.Draw() // without public!
		{
			Console.WriteLine("Draw to printer");
		}
		
		void IDrawToScreen.Draw()
		{
			Console.WriteLine("Draw to screen");
		}
		/*public void Draw() {
			Console.WriteLine("Draaaww");
		}*/
	}
	
	static void Main()
	{
		Circle c = new Circle();
		(c as IDrawToPrinter).Draw();
		(c as IDrawToScreen).Draw();
	}
}
