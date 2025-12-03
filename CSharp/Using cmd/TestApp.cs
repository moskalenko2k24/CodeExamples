// csc *.cs
// csc /out:FileName.exe *.cs
// csc /r:System.Windows.Forms.dll *.cs
// csc /r:System.Windows.Forms.dll;System.Drawing.dll *.cs
// r = reference

using System;
using System.Windows.Forms;

class TestApp
{
	static void Main() 
	{
		Console.WriteLine("Testing! 1, 2, 3");
		MessageBox.Show("Hello...");
	}
}
