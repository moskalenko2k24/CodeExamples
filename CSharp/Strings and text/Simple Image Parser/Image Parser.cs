using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Work 
{
	class ImageParser
	{
		static void Main() 
		{
			var text = File.ReadAllText("test.html.html");
			var matches = Regex.Matches(text, "<img .*>");
			if (File.Exists("res.txt"))
				File.Delete("res.txt");
			var endl = Environment.NewLine;
			foreach (Match match in matches) 
			{
				var i = match.Index;
				string pattern = "src=\"";
				int posStart = text.IndexOf(pattern, i);
				int posFinish = text.IndexOf('\"', posStart + pattern.Length);
				posStart += pattern.Length;
				File.AppendAllText("res.txt", text.Substring(posStart, posFinish-posStart) + "\r\n");
			}
		}
	}
}
