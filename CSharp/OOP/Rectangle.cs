using System;

class Program
{
	class ShapeInfo
	{
		public string infoString;
		public ShapeInfo(string info)
		{
			infoString = info;
		}
	}

	struct Rectangle
	{
		// Структура Rectangle содержит член ссылочного типа,
		public ShapeInfo rectInfo;
		public int rectTop, rectLeft, rectBottom, rectRight;
		// public Rectangle() {} // compile error
		public Rectangle(string info, int top, int left, int bottom, int right)
		{
			rectInfo = new ShapeInfo(info);
			rectTop = top; rectBottom = bottom;
			rectLeft = left; rectRight = right;
		}
		public void Display()
		{
			Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
			"Left = {3}, Right = {4}",
			rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
		}
	}

	static void Main()
	{
		// Создать первую переменную Rectangle.
		Console.WriteLine("-> Creating rl");
		Rectangle rl = new Rectangle("First Rect", 10, 10, 50, 50);
		// Присвоить новой переменной Rectangle переменную rl.
		Console.WriteLine("-> Assigning r2 to rl");
		Rectangle r2 = rl;
		// Изменить некоторые значения в r2.
		Console.WriteLine("-> Changing values of r2");
		r2.rectInfo.infoString = "This is new info!";
		r2.rectBottom = 4444;
		// Вывести значения из обеих переменных Rectangle.
		rl.Display();
		r2.Display();
	}
}
