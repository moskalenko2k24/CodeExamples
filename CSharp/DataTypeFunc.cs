using System;

class DataTypeFunc
{	
	static void NumTypeFunctionality()
	{
		Console.WriteLine("=> Number type functionality:");
		Console.WriteLine("int.MinValue: {0}", int.MinValue);
		Console.WriteLine("int.MaxValue: {0}", int.MaxValue);
		Console.WriteLine("double.MinValue: {0}", double.MinValue);
		Console.WriteLine("double.MaxValue: {0}", double.MaxValue);
		Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
		Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
		Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
		Console.WriteLine();
	}
	
	static void BoolFunctionality()
	{
		Console.WriteLine("=> Bool type Functionality:");
		Console.WriteLine("bool.FalseString: {0} ", bool.FalseString);
		Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
		Console.WriteLine();

	}
	
	static void CharFunctionality()
	{
		Console.WriteLine("=> Char type Functionality:");
		char myChar = 'а';
		Console.WriteLine("char.IsDigit('а'): {0}", char.IsDigit(myChar));
		Console.WriteLine("char.IsLetter('а'): {0}", char.IsLetter(myChar));
		Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
		Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
		Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
		Console.WriteLine();
	}

	
	static void Main()
	{
		NumTypeFunctionality();
		BoolFunctionality();
		CharFunctionality();
	}
}
