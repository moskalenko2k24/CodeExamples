using System;

class StaticUse
{
	
	class SavingsAccount
	{
		public double currBalance;
		public static double currInterestRate;
		public SavingsAccount(double balance)
		{
			// currInterestRate = 0.04;	//	Это	статические данные!
			currBalance = balance;
		}
		
		// статические конструкторы полезны для инициализации статических данных,
		// когда их значение известно только в RunTime
		static SavingsAccount() 
		{
			Console.WriteLine("In static ctor");
			currInterestRate = 0.04; 
		}
		
		// Статические члены для установки/получения процентной ставки,
		public static void SetInterestRate(double newRate)
		{
			currInterestRate = newRate;
		}
		
		public static double GetInterestRate()
		{
			return currInterestRate;
		}
	}
	
	static void Main()
	{
		Console.WriteLine("***** Fun with Static Data *****\n");
		// Создать счет.
		SavingsAccount sl = new SavingsAccount(50);
		// Вывести текущую процентную ставку.
		Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
		
		// Попытаться изменить процентную ставку через свойство.
		SavingsAccount.SetInterestRate(0.08);
		// Создать второй счет.
		SavingsAccount s2 = new SavingsAccount(100);
		// Должно вывестись 0.08... не так ли??
		Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate()); 
		Console.ReadLine();
	}
}
