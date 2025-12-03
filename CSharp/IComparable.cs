using System;

class Compare
{
	class Student: IComparable<Student> // IComparable
	{
		public string Name;
		public int Age;
		int IComparable<Student>.CompareTo(Student o) // int CompareTo(object o)
		{
			// if (!(o is Student)) 
			return Age - o.Age;
		}
		public override string ToString()
		{
			return string.Format("[Student Name = {0}, Age = {1}]", Name, Age);
		}

	}
	
	static void Main(string[] args)
	{
		Student[] s = {
			new Student{ Name = "Andrey", Age = 18 },
			new Student{ Name = "CodeR", Age = 25},
			new Student{ Name = "Oleg", Age = 17 },
			new Student{ Name = "Ivan", Age = 20 },
			new Student{ Name = "Baby", Age = 16 }
		};
		Array.Sort(s);
		foreach (var st in s)
			Console.WriteLine(st);
		Console.ReadLine();
	}
}
