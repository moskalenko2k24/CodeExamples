using System;

public class TestArray {
    public static void Main() {
        int[][] a = new int [5][]; // jaggedArray
        for (int i = 0; i < a.Length; i++)
            a[i] = new int[a.Length - i];
        for (int i = 0; i < a.Length; i++) {
            for (int j = 0; j < a[i].Length; j++)
                Console.Write(a[i][j] + " ");
            Console.WriteLine();
        }
    }
}