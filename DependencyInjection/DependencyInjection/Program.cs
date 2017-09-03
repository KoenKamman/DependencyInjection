using System;
using DependencyInjection.Abstract;
using DependencyInjection.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
	class Program
	{
		static void Main(string[] args)
		{
			var serviceProvider = new ServiceCollection()
				.AddTransient<IStudentRepository, TestStudentRepository>()
				.AddTransient<IStudentAdministration, StudentAdministration>()
				.BuildServiceProvider();

			var admin = serviceProvider.GetService<IStudentAdministration>();

			admin.AddFiveStudents();
			admin.PrintAllStudents();

			Console.ReadLine();
		}
	}
}
