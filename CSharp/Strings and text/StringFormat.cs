using System;

namespace Work {
	class Code {
		static void Main() {
			Console.WriteLine("\"{0,4:D}\"", 12); // "  12"
			Console.WriteLine("\"{0,-4:D}\"", 12); // "12  "
			Console.WriteLine("\"{0:D4}\"", 12); // "0012"
			Console.WriteLine("{0:C5}", 57.7); // 57,70000р.
			Console.WriteLine("{0:F4}", 3.1415926); // 3,1416
		}
	}
}
