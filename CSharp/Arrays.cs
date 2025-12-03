using System;

namespace dotNET {
	public class ArrayTest {
		static void Main() {
			int[] a = new int[5];
			Console.WriteLine("a:");
			foreach (var i in a)
				Console.Write(i + " ");
			int[] b = {1, 2, 3, 4, 5};
			Console.WriteLine("\nb:");
			foreach (var i in b)
				Console.Write(i + " ");
			int[,] matrix = new int[4, 4]; // !!! only [,] !!!
			for (int i = 0; i < 4; i++)
				matrix[i, i] = i + 1;
			Console.WriteLine("\nmatrix:");
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 4; j++)
					Console.Write(matrix[i, j] + " "); // [i, j], not [i][j] !!!
				Console.WriteLine();
			}
		}
	}
}