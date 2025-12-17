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
                Id = RandomSon(),
                FirstName = firstName,
                LastName = lastName
            };
            if (this.DbContext.StudentCount >= this.DbContext.students.Length)
            {
                Console.WriteLine(" Studentlar soni maksimal chegaraga yetdi, yangi talaba qoshib bolmaydi! ");
                return;
            }
            else
            {
                this.DbContext.students[this.DbContext.StudentCount] = newStudent;
            }
                
            this.DbContext.StudentCount++;
        }

        public void PrintStudents() 
        { 
            for(int i=0; i < this.DbContext.StudentCount; i++)
            {
                var s = this.DbContext.students[i];
                Console.WriteLine($" Id: {s.Id}, Name: {s.FirstName} {s.LastName}");
            }
        }

        public int GetStudentCount()
        {
            return this.DbContext.StudentCount;
        }

        public string RandomSon()
        {
            char birinchiSon = (char)new Random().Next('A', 'Z');
            char ikkinchiSon = (char)new Random().Next('A', 'Z');
            int uchinchiSon = new Random().Next(1000, 10000);

            return $"{birinchiSon}{ikkinchiSon}{uchinchiSon}";
        }
    }
}
