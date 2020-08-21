using DataAccess;
using System;
using System.Linq;

namespace BusinessLogic.Students
{
    public class StudentBusinessLogic : IStudentBusinessLogic
    {
        IStudentDataAccess _studentRepository;

        public IStudentDataAccess _studentRepository2 { get; set; }

        IStudentDataAccess _studentRepository3;

        public void InjectDependencies(IStudentDataAccess studentRepository)
        {
            _studentRepository3 = studentRepository;
        }

        public StudentBusinessLogic(IStudentDataAccess studentRepository)
        {
            _studentRepository = studentRepository;
        }


        //if "Print" print names for all stuents in console
        //if any other name - create a new student in "memory DB" witgh no subjects
        public string BadMethodWhichDoMillionOfThings(string studentName)
        {
            if(studentName == "Lector")
            {
                return _studentRepository.ListStudents().Count().ToString();
            }
            return studentName.ToUpper();
        }

        /// <summary>
        /// Looks for a student among all students in memory DB with highest grade for provided subject
        /// </summary>
        /// <returns></returns>
        public int GetStudentWithHighestMark(string subjectName)
        {

        }

        //public string AddStudentReturnUppercase(string studentName)
        //{
        //    if (studentName == "Alex")
        //    {
        //        _studentRepository.AddStudent(studentName);
        //    }
        //    else
        //    {
        //        _studentRepository.ListStudents();
        //    }

        //    return studentName.ToUpper();
        //}

        public void AddStudent(string student)
        {
            _studentRepository.AddStudent(student);

        }
        public void ListStudents()
        {
            _studentRepository.ListStudents();
        }


    }
}
