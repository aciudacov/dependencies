using System;
using System.Collections.Generic;

namespace DataAccess
{
    //public class RepositoryMock
    //{
    //    public void AddStudent()
    //    {
    //        throw new MyCustomException("We saved student");
    //    }
    //}

    public class Subject
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        public IEnumerable<Subject> FinishedSubjects { get; set; }
    }

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

        /// <param name="student">Studnet object</param>
        public void AddStudent(string student)
        {
            Students.Add(student);
        }

        public void AddStudent(int studentNr)
        {
            //Students.Add(student);
        }

        public IEnumerable<string> ListStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
            return Students;
        }

        public int GetMark(string studentName, string subjectName)
        {
            throw new NotImplementedException();
        }
    }
}
