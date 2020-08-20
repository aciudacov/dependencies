using DataAccess;
using System;

namespace BusinessLogic
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

        public string AddStudentReturnUppercase(string studentName)
        {
            if (studentName == "Alex")
            {
                _studentRepository.AddStudent(studentName);
            }
            else
            {
                _studentRepository.ListStudents();
            }

            return studentName.ToUpper();
        }

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
