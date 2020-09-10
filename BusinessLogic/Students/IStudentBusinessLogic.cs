using DataAccess;
using System.Collections.Generic;

namespace BusinessLogic.Students
{
    public interface IStudentBusinessLogic
    {
        string BadMethodWhichDoMillionOfThings(string studentName);

        void AddStudent(string student);
        void ListStudents();

        void AssignStudentToSubject(string student, string subject);
        IEnumerable<Student> GetStudentsWithHighestMark(string subjectName);

    }
}