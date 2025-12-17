using Management.Application.Service;
namespace Management6.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newStudent = new StudentService();
            newStudent.AddStudent("John", "Doe");
            newStudent.AddStudent("Jane", "Smith");
            newStudent.AddStudent("Alice", "Johnson");

            newStudent.PrintStudents();

            Console.WriteLine($" Studentlar miqdori:{newStudent.GetStudentCount()}");
        }
    }
}
