using System.Collections.Generic;

namespace DataAccess
{
    public interface IStudentDataAccess
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        IEnumerable<Student> ListStudents();
        int GetMark(string studentName, string subjectName);
    }
}