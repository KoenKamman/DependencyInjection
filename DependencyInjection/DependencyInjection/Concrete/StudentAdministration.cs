using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjection.Abstract;
using DependencyInjection.Models;

namespace DependencyInjection.Concrete
{
	public class StudentAdministration : IStudentAdministration
	{
		private readonly IStudentRepository _studentRepository;

		public StudentAdministration(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public void AddFiveStudents()
		{
			for (var i = 0; i < 5; i++)
			{
				var student = new Student
				{
					Id = i,
					Name = "Student " + i,
					StudentNumber = (109300 + i).ToString("00000000")
				};
				_studentRepository.AddStudent(student);

			}
		}

		public void PrintAllStudents()
		{
			foreach (var student in _studentRepository.GetStudents())
			{
				Console.WriteLine(student.Name);
			}
		}

	}
}
