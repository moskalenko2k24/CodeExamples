using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
 // Для определения FileNotFoundException.
namespace ExternalAssemblyReflector
{
	class Program
	{
		static void DisplayTypesInAsm(Assembly asm)
		{
			Console.WriteLine("\n***** Types in Assembly *****");
			Console.WriteLine("->{0}", asm.FullName);
			Type[] types = asm.GetTypes();
			foreach (Type t in types)
				Console.WriteLine("Type: {0}", t);
			Console.WriteLine("");
		}
		static void Main(string[] args)
		{
			Console.WriteLine("***** External Assembly Viewer *****");
			string asmName = "";
			Assembly asm = null;
			do {
				Console.WriteLine("\nEnter an assembly to evaluate");
				// Запросить имя сборки.
				Console.Write("or enter Q to quit: ");
				// Получить имя сборки.
				asmName = Console.ReadLine();
				// Пользователь желает завершить программу?
				if (asmName.ToUpper() == "Q") {
					break;
				}
				// Попробовать загрузить сборку,
				try {
					asm = Assembly.Load(asmName);
					DisplayTypesInAsm(asm);
				} catch {
					Console.WriteLine("Sorry, can't find assembly."); // Сборка не найдена.
				}
			} while (true) ;
		}
	}
}
