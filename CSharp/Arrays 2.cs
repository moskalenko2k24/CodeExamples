using System;

public class TestArrays {
	public static void Main() {
		int[,,] arr = new int[4, 3, 2];
		Console.WriteLine("arr.Rank: " + arr.Rank); // 3 dimensions
		Console.WriteLine("arr.Length: " + arr.Length); // 4 * 3 * 2 = 24
		// Console.WriteLine("arr[0].Length: " + arr[0].Length); // Compile error
		Console.WriteLine("arr.GetLength(0): " + arr.GetLength(0));
		int [,] Arr2D = { {1, 2, 3}, {4, 5, 6} };
		int p = 1;
		foreach (var i in Arr2D)
			p *= i;
		Console.WriteLine(p);
	}
}