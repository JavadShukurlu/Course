
using ModelsTasks.Models;

namespace ModelsTasks.Actions
{
    class Login:Register
    {
        public static void TeacherLogin(Teacher teacher)
        {
            
            Console.WriteLine("Emaili daxil eidn:");
            string email=Console.ReadLine();
            Console.WriteLine("Sifreni daxil edin:");
            string password=Console.ReadLine();

            foreach (var item in teachers) 
            {
                if( email!=item.Email && password!=item.Password)
                    Console.WriteLine("Sifre ve ya email sehcvdir");
                else
                    Console.WriteLine("Giris ugurludur!");
            }
        }

        internal static void LoginStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
