// csc /r:System.Windows.Forms.dll TestApp.cs HelloMsg.cs
// csc /r:System.Windows.Forms.dll *.cs // <- compile all files in folder

using System;
using System.Windows.Forms;

class TestApp
{
	static void Main() 
	{
		Console.WriteLine("Testing! 1, 2, 3");
		HelloMessage h = new HelloMessage();
		h.Speak();
	}
}
