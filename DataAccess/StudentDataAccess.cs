using System;
using System.Collections.Generic;
using System.Linq;

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
        public bool IsGroupLeader { get; set; }
        public IEnumerable<Subject> FinishedSubjects { get; set; } = new List<Subject>();
        public IEnumerable<Subject> AssignedSubjects { get; set; } = new List<Subject>();

    }

    public class StudentDataAccess : IStudentDataAccess
    {
        private List<Student> Students { get; set; }

        public StudentDataAccess()
        {
            Students = new List<Student>
            {
                new Student{ Name = "Alex" },
                new Student{ Name = "Maria" },
                new Student{ Name = "Dan" },
            };
        }

        /// <param name="student">Studnet object</param>
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }


        public void UpdateStudent(Student student)
        {
            var studentToUpdate = this.Students.FirstOrDefault(x => string.Equals(x.Name, student.Name, StringComparison.OrdinalIgnoreCase));
            studentToUpdate = student;
        }

        public IEnumerable<Student> ListStudents()
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
