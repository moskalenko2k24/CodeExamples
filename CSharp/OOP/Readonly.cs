using System;

namespace ReadonlyExample {
	class MathLib {
	    public readonly double k; // error with const
	    public MathLib(double k) {
	        this.k = k;
	    }
	}
 
	class Program {
	    static void Main(string[] args) {
	        MathLib mathLib = new MathLib(3.8);
	        Console.WriteLine(mathLib.k); // 3.8
	        // Console.ReadLine();
	    }
	}
}