using System;

class Program
{
	static void ShowEnvironmentDetails()
	{
		Console.WriteLine("User name: {0}", Environment.UserName);
		Console.WriteLine("Machine name: {0}", Environment.MachineName);
		Console.WriteLine("Drives:");
		foreach (string drive in Environment.GetLogicalDrives())
			Console.WriteLine("  {0}", drive);
		Console.WriteLine("OS: {0}", Environment.OSVersion); 
		Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
		Console.WriteLine(".NET Version: {0}", Environment.Version);
		Console.WriteLine("System directory: {0}", Environment.SystemDirectory);
	}
	
	static void Main()
	{
		ShowEnvironmentDetails();
		Console.WriteLine("Press Enter to exit...");
		Console.ReadLine();
	}
}
