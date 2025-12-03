using System;
 
namespace CloneObj 
{
	class Student: ICloneable 
	{
		public string name;
		public int age;
		public object Clone() 
		{
			return new Student { name = this.name, age = this.age };
		}
		public override string ToString() 
		{
			return name + " " + age;
		}
	}
 
	class Code 
	{
		static void Main()
		 {
			Student a = new Student { name = "Andrey", age = 18 };
			Student b = (Student)a.Clone();
			b.name = "Ivan";
			Console.WriteLine(a + Environment.NewLine + b);
		}
	}
}
