using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DependencyInjection.Abstract;
using DependencyInjection.Models;

namespace DependencyInjection.Concrete
{
    public class TestStudentRepository : IStudentRepository
    {
	    private readonly List<Student> _students = new List<Student>();

	    public bool AddStudent(Student student)
	    {
		    if (_students.Any(a => a.Id == student.Id))
		    {
			    return false;
		    }

			_students.Add(student);
		    return true;
	    }

	    public bool DeleteStudent(Student student)
	    {
		    throw new NotImplementedException();
	    }

	    public IEnumerable<Student> GetStudents()
	    {
		    return _students;
	    }

	    public bool EditStudent(Student student)
	    {
		    throw new NotImplementedException();
	    }
    }
}
