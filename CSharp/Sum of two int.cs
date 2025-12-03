using System;

public class Test
{
	public static void Main()
	{
		string[] nums = Console.ReadLine().Split();
		int a = int.Parse(nums[0]);
		int b = int.Parse(nums[1]);
		Console.WriteLine(1LL * a * b);
	}
}