using System;
using System.Reflection;


static class MyExtensions // static only!!!
{
	// Этот метод позволяет любому объекту отобразить
	// сборку, в которой он определен.
	public static void DisplayDefiningAssembly(this object obj)
	{ 
		Console.WriteLine("{0} lives here: => {1}\n", 
						  obj.GetType().Name,
		                  Assembly.GetAssembly(obj.GetType()).GetName().Name);
	}
	
	// Этот метод позволяет любому целому изменить порядок следования
	// десятичных цифр на обратный. Например, 56 превратится в 65.
	public static int ReverseDigits(this int i)
	{
		// Транслировать int в string и затем получить все его символы.
		char[] digits = i.ToString().ToCharArray();
		// Изменить порядок элементов массива.
		Array.Reverse(digits);
		// Вставить обратно встроку.
		string newDigits = new string(digits);
		// Вернуть модифицированную строку как int.
		return int.Parse(newDigits);
	}
	
	
	static void Main(string[] args)
	{
		Console.WriteLine(1234.ReverseDigits());
		1234.DisplayDefiningAssembly();
		Console.ReadLine();
	}
}
