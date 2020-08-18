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
