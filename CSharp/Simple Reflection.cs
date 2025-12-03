using System;
using System.Linq;
using System.Reflection;

class Program
{	
	
	class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Student(string Name = "Noname", int Age = -1)
		{
			this.Name = Name;
			this.Age = Age;
		}
		
		public override string ToString()
		{
			return string.Format("[Student Name = {0}, Age = {1}]", Name, Age);
		}
		
		public void Show()
		{
			Console.WriteLine("I am a student!!!");
		}

	}
	
	static void Main()
	{
		Student Andrey = new Student() { Name = "Andrey", Age = 18 };
		Type t = Andrey.GetType();
		
		/*
		MethodInfo[] methods = t.GetMethods();
		foreach (MethodInfo method in methods)
			Console.WriteLine("-> {0}", method.Name);
		*/
		
		var fieldNames = from f in t.GetProperties() select f.Name;
		foreach (string s in fieldNames)
			Console.WriteLine(s);
		
		return;
	}
}


