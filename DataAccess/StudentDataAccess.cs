using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class StudentDataAccess : IStudentDataAccess
    {
        private List<string> Students { get; set; }

        public StudentDataAccess()
        {
            Students = new List<string>
            {
                "Alex",
                "Maria",
                "Dan"
            };
        }
        public void AddStudent(string student)
        {
            Students.Add(student);
        }

        public void AddStudent(int studentNr)
        {
            //Students.Add(student);
        }

        public void ListStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
