using System;
using System.Collections;

class Interfaces
{	
	
	public class IntArray: IEnumerable
	{
		private int[] a;
		public IntArray(int n)
		{
			a = new int[n];
		}
		
		public int this[int i] 
		{
			get
			{
				return a[i];
			}
			set
			{
				a[i] = value;
			}
		}
		
		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < a.Length; i++)
                yield return a[i];
		}
		
	}
	
	static void Main()
	{
		IntArray x = new IntArray(10);
		for (int i = 0; i < 10; i++)
			x[i] = 2 * i;
		foreach (var t in x) Console.Write(t + " ");
		Console.WriteLine();
		
	}
}
