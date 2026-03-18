
using ModelsTasks.Models;

public class Program
{

    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Hello", "beho", "reko", "ABS", "Riy", "15.12.2000", "Mircelal", 055151255, "r@gmail.com", "salam123");
        Console.WriteLine(teacher.GetName());
        Console.WriteLine(teacher.GetSubject());
        Console.WriteLine(teacher.GetTeacher());
        Console.WriteLine(teacher.GetEmail());
        Console.WriteLine(teacher.GetBirthdate());
        Console.WriteLine(teacher.GetContact());



        Console.WriteLine("----------------------------------------------------------------------------------------------------------------");


        Student student = new Student()
        {
            FirstName = "Cavad",
            LastName = "Sukurlu",
            UserName = "7W",
            GroupNumber = "APA103",
            Score = 100,
            Birthdate = new DateOnly(2005, 11, 18),
            Address = "Haciqabul",
            PhoneNumber = "0553316415",
            Email = "sukurlucavad@gmail.com",
            Password = "12345"
        };
        Register.RegisterStudent(student);


        Login.LoginStudent(student);
        
































        //Console.WriteLine("------------------------------------------------------------------------------------");
        //Student student1 = new Student()
        //{
        //    FirstName = "Polad",
        //    LastName = "Sukurlu",
        //    UserName = "7W",
        //    GroupNumber = "APA103",
        //    Score = 100,
        //    Birthdate = new DateOnly(2005, 11, 18),
        //    Address = "Haciqabul",
        //    PhoneNumber = "0553316415",
        //    Email = "sukurlucavad@gmail.com",
        //    Password = "12345"
        //};
        //student1.Info();
        //Console.WriteLine("------------------------------------------------------------------------------------");
        //Student student2 = new Student()
        //{
        //    FirstName = "Polad",
        //    LastName = "Sukurlu",
        //    UserName = "7W",
        //    GroupNumber = "APA103",
        //    Score = 100,
        //    Birthdate = new DateOnly(2005, 11, 18),
        //    Address = "Haciqabul",
        //    PhoneNumber = "0553316415",
        //    Email = "sukurlucavad@gmail.com",
        //    Password = "12345"
        //};
        //student2.Info();
        //Console.WriteLine("------------------------------------------------------------------------------------");
        //Student student3 = new Student()
        //{
        //    FirstName = "Polad",
        //    LastName = "Sukurlu",
        //    UserName = "7W",
        //    GroupNumber = "APA103",
        //    Score = 100,
        //    Birthdate = new DateOnly(2005, 11, 18),
        //    Address = "Haciqabul",
        //    PhoneNumber = "0553316415",
        //    Email = "sukurlucavad@gmail.com",
        //    Password = "12345"
        //};
        //student3.Info();
        //Console.WriteLine("------------------------------------------------------------------------------------");
        //Student student4 = new Student()
        //{
        //    FirstName = "Polad",
        //    LastName = "Sukurlu",
        //    UserName = "7W",
        //    GroupNumber = "APA103",
        //    Score = 100,
        //    Birthdate = new DateOnly(2005, 11, 18),
        //    Address = "Haciqabul",
        //    PhoneNumber = "0553316415",
        //    Email = "sukurlucavad@gmail.com",
        //    Password = "12345"
        //};
        //student4.Info();
        //Console.WriteLine("------------------------------------------------------------------------------------");
        //Student student5 = new Student()
        //{
        //    FirstName = "Polad",
        //    LastName = "Sukurlu",
        //    UserName = "7W",
        //    GroupNumber = "APA103",
        //    Score = 100,
        //    Birthdate = new DateOnly(2005, 11, 18),
        //    Address = "Haciqabul",
        //    PhoneNumber = "0553316415",
        //    Email = "sukurlucavad@gmail.com",
        //    Password = "12345"
        //};
        //student5.Info();
        //Console.WriteLine("------------------------------------------------------------------------------------");
        //Student student6 = new Student()
        //{
        //    FirstName = "Polad",
        //    LastName = "Sukurlu",
        //    UserName = "7W",
        //    GroupNumber = "APA103",
        //    Score = 100,
        //    Birthdate = new DateOnly(2005, 11, 18),
        //    Address = "Haciqabul",
        //    PhoneNumber = "0553316415",
        //    Email = "sukurlucavad@gmail.com",
        //    Password = "12345"
        //};
        //student6.Info();
        //Console.WriteLine("------------------------------------------------------------------------------------");
        //Student student7 = new Student()
        //{
        //    FirstName = "Polad",
        //    LastName = "Sukurlu",
        //    UserName = "7W",
        //    GroupNumber = "APA103",
        //    Score = 100,
        //    Birthdate = new DateOnly(2005, 11, 18),
        //    Address = "Haciqabul",
        //    PhoneNumber = "0553316415",
        //    Email = "sukurlucavad@gmail.com",
        //    Password = "12345"
        //};
        //student7.Info();
        //Console.WriteLine("------------------------------------------------------------------------------------");
        //Student student8 = new Student()
        //{
        //    FirstName = "Polad",
        //    LastName = "Sukurlu",
        //    UserName = "7W",
        //    GroupNumber = "APA103",
        //    Score = 100,
        //    Birthdate = new DateOnly(2005, 11, 18),
        //    Address = "Haciqabul",
        //    PhoneNumber = "0553316415",
        //    Email = "sukurlucavad@gmail.com",
        //    Password = "12345"
        //};
        //student8.Info();
        //Console.WriteLine("------------------------------------------------------------------------------------");
        //Student student9 = new Student()
        //{
        //    FirstName = "Polad",
        //    LastName = "Sukurlu",
        //    UserName = "7W",
        //    GroupNumber = "APA103",
        //    Score = 100,
        //    Birthdate = new DateOnly(2005, 11, 18),
        //    Address = "Haciqabul",
        //    PhoneNumber = "0553316415",
        //    Email = "sukurlucavad@gmail.com",
        //    Password = "12345"
        //};
        //student9.Info();




        //Console.WriteLine(student.GetName());
        //Console.WriteLine(student.GetGroup());
        //Console.WriteLine(student.GetStudent());
        //Console.WriteLine(student.GetEmail());
        //Console.WriteLine(student.GetBitdate());
        //Console.WriteLine(student.GetContact());


    }
}

