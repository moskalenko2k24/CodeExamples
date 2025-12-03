using System;

class Program
{
	public class Car
	{
		public int CurrentSpeed { get; set; }
		public int MaxSpeed { get; set; }
		public string PetName { get; set; }
		
		private bool carIsDead;
		
		public Car() { MaxSpeed = 100; }
		public Car(string name, int maxSp, int currSp)
		{
			CurrentSpeed = currSp;
			MaxSpeed = maxSp;
			PetName = name;
		}
		
		public delegate void CarEngineHandler(string msgForCaller);
		
		private CarEngineHandler listOfHandlers;
		
		public void RegisterWithCarEngine(CarEngineHandler methodToCall)
		{
			if (listOfHandlers == null)
				listOfHandlers = methodToCall;
			else 
				listOfHandlers += methodToCall; // Delegate.Combine(listOfHandlers, methodToCall)
		}
		
		public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
		{
			listOfHandlers -= methodToCall;
		}

		
		public void Accelerate(int delta)
		{
			if (carIsDead)
			{
				if (listOfHandlers != null)
					listOfHandlers("Sorry, this car is dead...");
			}
			else
			{
				CurrentSpeed += delta;
				if (10 == (MaxSpeed - CurrentSpeed)
				    && listOfHandlers != null)
				{
					listOfHandlers("Careful buddy! Gonna blow!");
				}
				if (CurrentSpeed >= MaxSpeed)
					carIsDead = true;
				else
					Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
			}
		}

	}
	
	static void Main()
	{
		Console.WriteLine("***** Delegates as event enablers *****\n");
		// Сначала создать объект Car.
		Car cl = new Car("SlugBug", 100, 10);
		// Теперь сообщить ему, какой метод вызывать,
		// когда он захочет отправить сообщение.
		cl.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
		cl.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));
		// Ускорить (это инициирует события).
		Console.WriteLine("***** Speeding up *****");
		for (int i = 0; i < 6; i++)
			cl.Accelerate(20);
		Console.ReadLine();
	}
	
	// Это цель для входящих сообщений.
	public static void OnCarEngineEvent(string msg)
	{
		Console.WriteLine("\n***** Message From Car Object *****");
		Console.WriteLine("=> {0}", msg);
		Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
	}
	
	public static void OnCarEngineEvent2(string msg)
	{
		Console.WriteLine("=> {0}", msg.ToUpper());
	}
}