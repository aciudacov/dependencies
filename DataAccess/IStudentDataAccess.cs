using System.Collections.Generic;

namespace DataAccess
{
    public interface IStudentDataAccess
    {
        void AddStudent(string student);
        IEnumerable<string> ListStudents();
        int GetMark(string studentName, string subjectName);
    }
}