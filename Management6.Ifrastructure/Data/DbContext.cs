using Management6.Domain.Models;
namespace Management6.Ifrastructure.Data
{
    public class DbContext
    {
        public Student[] students { get; set;}

        public DbContext()
        {
            this.students = new Student[12];
        }

        public int StudentCount { get; set; } = 0;
    }
}
