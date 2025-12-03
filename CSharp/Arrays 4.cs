using System;

public class Test
{
	static void PrintArray(int[] a) 
	{
		for (int i = 0; i < a.Length; i++)
			Console.Write(a[i] + (i < a.Length-1 ? " ": ""));
		Console.WriteLine();
	}
	
	static void ModifyArray(int[] a)
	{
		for (int i = 0; i < a.Length; i++)
			a[i] *= 2; // array is referebce type so values will be changed
	}
	
	static void Print2DArray(int [,] a)
	{
		for (int i = 0; i < a.GetLength(0); i++)
		{
			for (int j = 0; j < a.GetLength(1); j++)
				Console.Write(a[i, j] + " ");
			Console.WriteLine();
		}
	}
	
	static void Main()
	{
		int[] x = {10, 20, 30, 40, 50};
		PrintArray(x);
		PrintArray(new int[] {2, 3, 5, 7});
		ModifyArray(x);
		PrintArray(x);
		Console.WriteLine("2D array:");
		Print2DArray(new int[,]{ {1, 2, 3}, {4, 5, 6}, {3, 2, 1} });
	}
}