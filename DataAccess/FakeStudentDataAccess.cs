using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class FakeStudentDataAccess : IStudentDataAccess
    {
        public FakeStudentDataAccess()
        {

        }
        public void AddStudent(string student)
        {
            Console.WriteLine("I am not adding student to list.");
        }

        public void ListStudents()
        {
            Console.WriteLine("There is no list.");
        }
    }
}
