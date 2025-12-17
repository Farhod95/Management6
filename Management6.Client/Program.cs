using Management.Application.Service;
using System.Diagnostics;
namespace Management6.Client
{
    internal class Program
    {
        public static StudentService newStudent = new StudentService();
        private const string parol = "1111";
        static void Main(string[] args)
        {
            int passwordCounter = 1;
            Console.WriteLine($" Assalumu alaykum, xurmatli o'qituvchi ! \n");

            while (passwordCounter <= 3)
            {
                Console.Write(" Iltimos parolingizni kiriting: ");
                string password = Console.ReadLine();
                if (password == parol)
                {
                    SalomBer(); break;
                }
                else
                {
                    if(passwordCounter == 3)
                    {
                        Console.WriteLine(" Uch marta xato parol kiritdingiz, tizimdan chiqilyapti...");
                        break;
                    }
                    Console.WriteLine(" Parolingiz xato, qaytadan urinib ko'ring! \n");
                    Console.WriteLine($" {3-passwordCounter} marta imkoningiz qoldi.\n");
                }
                passwordCounter++;
            }
        }

        static void SalomBer()
        {
            Console.WriteLine("\n Xush kelibsiz Elbek ! ");
            bool savol = false;
            while (!savol)
            {
                savol = true;
                Console.WriteLine("\n Quyidagi menyudan birini tanlang: \n");
                Console.WriteLine(" 1) Yangi talaba qoshish");
                Console.WriteLine(" 2) Talabalar ro'yxati");
                Console.WriteLine(" 3) Qabullar soni\n");
                Console.Write(" Kerakli bo'limni raqamini kiriting: ");

                if (int.TryParse(Console.ReadLine(), out int amal)) ;
                else
                {
                    Console.WriteLine(" Klaviaturadan faqatgina raqam kirtiish lozim! ");
                    if (QaytaIshgaTushir()) { savol = false; continue; }
                }

                switch (amal)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            TalabaQoshish();
                            if (QaytaIshgaTushir()) savol = false;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine();
                            newStudent.PrintStudents();
                            if (QaytaIshgaTushir()) savol = false;
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine();
                            Console.WriteLine($" Dastur studentlari miqdori:{newStudent.GetStudentCount()}");
                            Console.WriteLine($" Dasturda bo'sh o'rinlar miqdori:{12-newStudent.GetStudentCount()}");
                            if (QaytaIshgaTushir()) savol = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine(" Bunday amal mavjud emas !");
                            if (QaytaIshgaTushir()) savol = false;
                            break;
                        }
                }
            }
        }

        static void TalabaQoshish()
        {
            Console.Write(" Yangi student ismini kiriting:");
            string ism = Console.ReadLine();
            Console.Write(" Yangi student familiyasini kiriting:");
            string familiya = Console.ReadLine();

            newStudent.AddStudent(ism, familiya);
            Console.WriteLine("\n Yangi talaba muvofaqqiyatli qo'shildi !");
        }
        
        static bool QaytaIshgaTushir()
        {
            Console.Write("\n Dasturni qayta ishga tushirishni istaysizmi (yes/no): ");
            return Console.ReadLine().ToLower() == "yes";
        }
    }
}


