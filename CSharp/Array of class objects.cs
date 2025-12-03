using System;
using System.Linq;

class Student {
	public string name { get; set; };
	public int age { get; set; };
	public override string ToString() {
		return name + " " + age;
 	}
}

class Program {
	public static void Main() {
		int studentCount = int.Parse(Console.ReadLine());
		Student[] students = new Student[studentCount];
		for (int i = 0; i < students.Length; i++) {
			students[i] = new Student(); // !!!
			string[] info = Console.ReadLine().Split();
			students[i].name = info[0];
			students[i].age = int.Parse(info[1]);
		}
		students = students.OrderBy(s => s.name).ToArray();
		for (int i = 0; i < students.Length; i++)
			Console.WriteLine(students[i]);
	}
}