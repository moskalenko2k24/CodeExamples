using System;

class Test
{		
	static void OutFunc(int a, int b, out int sum) 
	{
		sum = a + b;
	}
	
	static void RefFunc(int a, int b, ref int sum) 
	{
		sum = a + b;
	}
	
	static int ParamsFunc(params int[] a) 
	{
		int res = 0;
		for (int i = 0; i < a.Length; i++)
			res += a[i];
		return res;
	}
	
	static void Main()
	{
		int x = 3, y = 15;
		int z;
		OutFunc(x, y, out z);
		Console.WriteLine("OutFunc: {0}", z);
		
		int a = 1, b = 2;
		int c = 0; // int c; // Compile Error
		RefFunc(a, b, ref c);
		Console.WriteLine("RefFunc: {0}", c);
		
		Console.WriteLine("ParamsFunc: {0}", ParamsFunc(1, 3, 5, 7, 9, 11)); // 36
	}
}
