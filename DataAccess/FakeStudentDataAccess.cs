//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataAccess
//{
//    public class FakeStudentDataAccess : IStudentDataAccess
//    {
//        public FakeStudentDataAccess()
//        {

//        }
//        public void AddStudent(string student)
//        {
//            Console.WriteLine("I am not adding student to list.");
//        }

//        public IEnumerable<string> ListStudents()
//        {
//            Console.WriteLine("There is no list.");
//            return new List<string> { "Bob", "Jhon", "Ivan" };
//        }

//        public int GetMark(string studentName)
//        {
//            return 10;
//        }
//    }
//}
