using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjection.Models;

namespace DependencyInjection.Abstract
{
    public interface IStudentRepository
    {
	    bool AddStudent(Student student);
	    bool DeleteStudent(Student student);
	    IEnumerable<Student> GetStudents();
	    bool EditStudent(Student student);
    }
}
