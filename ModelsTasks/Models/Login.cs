

using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ModelsTasks.Models
{
    public class Login:Register
    {
       
        
        public static void LoginStudent(Student student)
        {
            Console.WriteLine("Emaili daxil edin:");
            string Email = Console.ReadLine();
            Console.WriteLine("Passwordu daxil edin:");
            string Password = Console.ReadLine();
            foreach(var item in Students)
            {
                if (Email != item.Email && Password != item.Password)
                    Console.WriteLine("Sifre ve ya email sehvdir");
                else
                    Console.WriteLine("Girsi ugurludur!");
                
            }
        }
    }
}
