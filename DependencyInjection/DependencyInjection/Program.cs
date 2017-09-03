using System;
using DependencyInjection.Concrete;

namespace DependencyInjection
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var admin = new StudentAdministration(new TestStudentRepository());
			admin.AddFiveStudents();
			admin.PrintAllStudents();

			Console.ReadLine();
		}
	}
}
