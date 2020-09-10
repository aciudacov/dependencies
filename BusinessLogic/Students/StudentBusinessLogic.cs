using DataAccess;
using System;
using System.Collections.Generic;
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
        /// Do not add new methods in repository layer (data layer)! use those you already have
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetStudentsWithHighestMark(string subjectName)
        {
            //var allStudents = ListStudents()
            //foreach(student)
            //{
            //    GetMark()
            //}
            //if highest()
            throw new NotImplementedException();
        }

        /// <summary>
        /// Logic:
        /// 1. Base positive scenario - adds new subjecect with Grade "0" to AssignedSubjects and updates student, so that change would be saved. Let's pretend that you have in-DB database and only way to save
        /// cahnged subject is to call StudentDataAccess.UpdateStudent();
        /// 2. If student is group leader, the Name of assigned subject should be in UPPERCASE
        /// 3. If student aldready have same subject (by name) in his FinishedSubjects - thow a custom "SubjectAlreadyFinished" exception with message "{Student.Name} has aldready finished {Subject.Name} with mark {Subject.Mark}"
        /// </summary>
        public void AssignStudentToSubject(string student, string subject)
        {

        }

        public void AddStudent(string student)
        {
            throw new NotImplementedException();
        }

        public void ListStudents()
        {
            throw new NotImplementedException();
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
    }
}
