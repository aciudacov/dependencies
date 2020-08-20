namespace BusinessLogic
{
    public interface IStudentBusinessLogic
    {
        string AddStudentReturnUppercase(string studentName);

        void AddStudent(string student);
        void ListStudents();
    }
}