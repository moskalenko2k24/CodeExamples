using System;

class Enums
{
	enum Color: byte {
		Red,   // 0
		Green, // 1
		Blue   // 2
	}
	
	static void EvaluateEnum(System.Enum e)
	{
		Console.WriteLine("=> Information about {0}", e.GetType().Name);
		Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));
		// Получить все пары "имя/значение" для входного параметра.
		Array enumData = Enum.GetValues(e.GetType());
		Console.WriteLine("This enum has {0} members.", enumData.Length);
		// Вывести строковое имя и ассоциированное значение,
		for(int i = 0; i < enumData.Length; i++)
		{
			Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
		}
		Console.WriteLine();
	}
	
	static void Main()
	{
		Color c = Color.Red;
		EvaluateEnum(c);
	}
}
