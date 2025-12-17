using Management6.Ifrastructure.Data;
using Management6.Domain.Models;
namespace Management.Application.Service
{
    public class StudentService
    {
        public DbContext DbContext { get; set; }
        public StudentService()
        {
            this.DbContext = new DbContext();
        }
        public void AddStudent(string firstName, string lastName)
        {
            Student newStudent = new Student
            {
                Id = new Random().Next(1000, 9999).ToString(),
                FirstName = firstName,
                LastName = lastName
            };
            this.DbContext.students[this.DbContext.StudentCount] = newStudent;
            this.DbContext.StudentCount++;
        }
    }
}
