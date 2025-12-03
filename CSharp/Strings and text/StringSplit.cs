using System;

namespace Work 
{
	class Code 
	{
		static void Main() 
		{
			string s = "Это предложение состоит из нескольких слов?!   Попробуем вывести все слова!  !!";
			string[] sep = {".", "?", "!", ":", " "};
			var words = s.Split(sep, 10000, StringSplitOptions.RemoveEmptyEntries); // 10000 макс. кол-во слов
			foreach (var word in words)
				Console.WriteLine(word);
			Console.WriteLine(String.Join(" ", words));
		}
	}
}