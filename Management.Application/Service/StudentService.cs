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
                Id = new Random().Next(1, 1000).ToString(),
                FirstName = firstName,
                LastName = lastName
            };
            this.DbContext.students[this.DbContext.StudentCount] = newStudent;
            this.DbContext.StudentCount++;
        }

        public void PrintStudents() 
        { 
            for(int i=0; i < this.DbContext.StudentCount; i++)
            {
                var s = this.DbContext.students[i];
                Console.WriteLine($" Id: {s.Id}, FirstName: {s.FirstName}   LastName: {s.LastName}");
            }
        }

        public int GetStudentCount()
        {
            return this.DbContext.StudentCount;
        }
    }
}
