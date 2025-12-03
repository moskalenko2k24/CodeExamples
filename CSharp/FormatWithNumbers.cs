using System;

class FormatWithNumbers
{	
	static void Main()
	{
		Console.WriteLine("{0,5}", 123);   // "  123"
		Console.WriteLine("{0,-5}", 123);  // "123  "
		Console.WriteLine();
		
		Console.WriteLine("D");
		Console.WriteLine("{0:D5}", 123);  // 00123
		Console.WriteLine("{0:D5}", -123); // -00123
		Console.WriteLine();
		
		Console.WriteLine("X");
		Console.WriteLine("{0:X4}", 255);  // 00FF
		Console.WriteLine("{0:x}", 255);   // ff
		Console.WriteLine();
		
		Console.WriteLine("P");
		Console.WriteLine("{0:P}", 0.75678);              // 75,68%
		Console.WriteLine("{0:P0}", 0.75678);             // 76%
		Console.WriteLine("{0:P2}", 0.75678);             // 75,68%
		Console.WriteLine();
		
		Console.WriteLine("E");
		Console.WriteLine("{0:E}", 1025.1024);            // 1,025102E+003		
		Console.WriteLine("{0:E2}", 1025.1024);           // 1,03E+003
		Console.WriteLine();
		
		Console.WriteLine("F");
		Console.WriteLine("{0:F}", 56123.24784);          // 56123,25
		Console.WriteLine("{0:F3}", 56123.24784);         // 56123,248
		Console.WriteLine("{0:F5}", 56123.24784);         // 56123,24784
		Console.WriteLine();
		
		Console.WriteLine("N");
		Console.WriteLine("{0:N}", 2147483647);           // 2 147 483 647,00
		Console.WriteLine("{0:N0}", 2147483647);          // 2 147 483 647
		Console.WriteLine("{0:N}", 2147483647.1235678);   // 2 147 483 647,12
		Console.WriteLine("{0:N5}", 2147483647.1235678);  // 2 147 483 647,12357
		Console.WriteLine();
		
		Console.WriteLine("C");
		Console.WriteLine("{0:C}", 1450584);              // 1 450 584,00р.
		Console.WriteLine("{0:C}", 1450584.5);            // 1 450 584,50р.
		Console.WriteLine("{0:C}", 1450584.787);          // 1 450 584,79р.
		Console.WriteLine("{0:C1}", 1450584.787);         // 1 450 584,8р.
		Console.WriteLine();
	}
}
