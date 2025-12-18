using Management.Application.Service;

namespace Management6.Client
{
    internal class Program
    {
        public StudentService newStudent { get; set; }
        public Program()
        {
            this.newStudent = new StudentService();
        }
        private const string parol = "1111";

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║        STUDENT MANAGEMENT SYSTEM             ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");

            var program = new Program();
            program.Run();
        }

        public void Run()
        {
            int passwordCounter = 1;
            Console.WriteLine("\n╔══════════════════════════════════════════════╗");
            Console.WriteLine("║ Assalomu alaykum, xurmatli o'qituvchi !      ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝\n");

            while (passwordCounter <= 3)
            {
                Console.Write(" Iltimos parolingizni kiriting: ");
                string password = Console.ReadLine();

                if (password == parol)
                {
                    SalomBer();
                    break;
                }
                else
                {
                    if (passwordCounter == 3)
                    {
                        Console.WriteLine("\n╔══════════════════════════════════════════════╗");
                        Console.WriteLine("║ Uch marta xato parol kiritdingiz             ║");
                        Console.WriteLine("║ Tizimdan chiqilyapti...                      ║");
                        Console.WriteLine("╚══════════════════════════════════════════════╝");
                        break;
                    }

                    Console.WriteLine("\n╔══════════════════════════════════════════════╗");
                    Console.WriteLine("║ Parolingiz xato, qayta urinib ko'ring!       ║");
                    Console.WriteLine($"║ {3 - passwordCounter} marta imkoningiz bor                       ║");
                    Console.WriteLine("╚══════════════════════════════════════════════╝\n");
                }

                passwordCounter++;
            }
        }

        public void SalomBer()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║        Xush kelibsiz Elbek !                 ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");

            bool savol = false;
            while (!savol)
            {
                savol = true;

                Console.WriteLine("\n╔══════════════════════════════════════════════╗");
                Console.WriteLine("║                ASOSIY MENYU                  ║");
                Console.WriteLine("╠══════════════════════════════════════════════╣");
                Console.WriteLine("║ 1) Yangi talaba qo'shish                     ║");
                Console.WriteLine("║ 2) Talabalar ro'yxati                        ║");
                Console.WriteLine("║ 3) Qabullar soni                             ║");
                Console.WriteLine("╚══════════════════════════════════════════════╝");

                Console.Write(" Kerakli bo'lim raqamini kiriting: ");

                if (int.TryParse(Console.ReadLine(), out int amal)) ;
                else
                {
                    Console.WriteLine("\n╔══════════════════════════════════════════════╗");
                    Console.WriteLine("║ Faqat raqam kiritish mumkin!                 ║");
                    Console.WriteLine("╚══════════════════════════════════════════════╝");

                    if (QaytaIshgaTushir()) { savol = false; continue; }
                }

                switch (amal)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("╔══════════════════════════════════════════════╗");
                        Console.WriteLine("║        YANGI TALABA QO‘SHISH                 ║");
                        Console.WriteLine("╚══════════════════════════════════════════════╝\n");

                        TalabaQoshish();
                        if (QaytaIshgaTushir()) savol = false;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("╔══════════════════════════════════════════════╗");
                        Console.WriteLine("║           TALABALAR RO‘YXATI                 ║");
                        Console.WriteLine("╠══════════════════════════════════════════════╣");

                        newStudent.PrintStudents();

                        Console.WriteLine("╚══════════════════════════════════════════════╝");
                        if (QaytaIshgaTushir()) savol = false;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("╔══════════════════════════════════════════════╗");
                        Console.WriteLine("║               STATISTIKA                     ║");
                        Console.WriteLine("╠══════════════════════════════════════════════╣");

                        Console.WriteLine($" Dastur studentlari miqdori: {newStudent.GetStudentCount()}");
                        Console.WriteLine($" Bo'sh o'rinlar soni        : {12 - newStudent.GetStudentCount()}");

                        Console.WriteLine("╚══════════════════════════════════════════════╝");
                        if (QaytaIshgaTushir()) savol = false;
                        break;

                    default:
                        Console.WriteLine("\n╔══════════════════════════════════════════════╗");
                        Console.WriteLine("║ Bunday amal mavjud emas!                     ║");
                        Console.WriteLine("╚══════════════════════════════════════════════╝");

                        if (QaytaIshgaTushir()) savol = false;
                        break;
                }
            }
        }

        public void TalabaQoshish()
        {
            Console.Write(" Yangi student ismini kiriting: ");
            string ism = Console.ReadLine();

            Console.Write(" Yangi student familiyasini kiriting: ");
            string familiya = Console.ReadLine();

            newStudent.AddStudent(ism, familiya);

            Console.WriteLine("\n╔══════════════════════════════════════════════╗");
            Console.WriteLine("║ Yangi talaba muvaffaqiyatli qo'shildi!       ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
        }

        public bool QaytaIshgaTushir()
        {
            Console.Write("\n Dasturni qayta ishga tushirishni istaysizmi (yes/no): ");
            return Console.ReadLine().ToLower() == "yes";
        }
    }
}
