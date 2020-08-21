namespace BusinessLogic.Students
{
    public interface IStudentBusinessLogic
    {
        string BadMethodWhichDoMillionOfThings(string studentName);

        void AddStudent(string student);
        void ListStudents();
    }
}