using ModelsTasks.Actions;
using ModelsTasks.Models;


public class Program
{
    public static void Main(string[] args)
    {
        //Teacher teacher = new Teacher()
        //{

        //    Username="Beho",
        //    Firstname="Be",
        //    Lastname="Re",
        //    Departmentname="Bah",
        //    Subject="IT",
        //    Birthdate="25.Dec",
        //    Address="Mircele",
        //    PhoneNum=055136,
        //    Email="awvawevawe@",
        //    Password="124asvq"
        //};

        //Teacher teacher1 = new Teacher()
        //{

        //    Username = "Rec",
        //    Firstname = "Beh",
        //    Lastname = "Ras",
        //    Departmentname = "Bah124",
        //    Subject = "IT",
        //    Birthdate = "25.Dec",
        //    Address = "Mircele",
        //    PhoneNum = 055136,
        //    Email = "awvawevawe@",
        //    Password = "124asvq"
        //};


        //Teacher teacher2 = new Teacher()
        //{

        //    Username = "Fec",
        //    Firstname = "Be",
        //    Lastname = "Re",
        //    Departmentname = "Bah",
        //    Subject = "IT",
        //    Birthdate = "25.Dec",
        //    Address = "Mircele",
        //    PhoneNum = 055136,
        //    Email = "awvawevawe@",
        //    Password = "124asvq"
        //};


        //Teacher teacher3 = new Teacher()
        //{

        //    Username = "Acq",
        //    Firstname = "Be",
        //    Lastname = "Re",
        //    Departmentname = "Bah",
        //    Subject = "IT",
        //    Birthdate = "25.Dec",
        //    Address = "Mircele",
        //    PhoneNum = 055136,
        //    Email = "awvawevawe@",
        //    Password = "124asvq"
        //};


        //Teacher teacher4 = new Teacher()
        //{

        //    Username = "AWW",
        //    Firstname = "Be",
        //    Lastname = "Re",
        //    Departmentname = "Bah",
        //    Subject = "IT",
        //    Birthdate = "25.Dec",
        //    Address = "Mircele",
        //    PhoneNum = 055136,
        //    Email = "awvawevawe@",
        //    Password = "124asvq"
        //};


        //Teacher teacher5 = new Teacher()
        //{

        //    Username = "VAWE",
        //    Firstname = "Be",
        //    Lastname = "Re",
        //    Departmentname = "Bah",
        //    Subject = "IT",
        //    Birthdate = "25.Oct",
        //    Address = "Mircele",
        //    PhoneNum = 055136,
        //    Email = "11541@",
        //    Password = "124asvq"
        //};

        //Teacher teacher6 = new Teacher()
        //{

        //    Username = "AWBEA",
        //    Firstname = "aweb",
        //    Lastname = "AEBA",
        //    Departmentname = "!4111",
        //    Subject = "IT",
        //    Birthdate = "20.Dec",
        //    Address = "Mircele",
        //    PhoneNum = 055123136,
        //    Email = "awvaweva11we@",
        //    Password = "124asvq"
        //};

        //teacher.Info();
        //teacher1.Info();
        //teacher2.Info();
        //teacher3.Info();
        //teacher4.Info();
        //teacher5.Info();
        //teacher6.Info();



        //Console.WriteLine(teacher.GetName());
        //Console.WriteLine(teacher.GetSubject());
        //Console.WriteLine(teacher.GetTeacher());
        //Console.WriteLine(teacher.GetEmail());
        //Console.WriteLine(teacher.GetBirthdate());
        //Console.WriteLine(teacher.GetContact());


        //Student student = new Student("Cavad", "Sukurlu", "Cavad", "APA103", 98, new DateOnly(2005, 11, 18), "Baku", "0553316415", "sukurlucavad@gmail.com", "123456");

        //Console.WriteLine(student.GetName());
        //Console.WriteLine(student.GetGroup());
        //Console.WriteLine(student.GetStudent());
        //Console.WriteLine(student.GetEmail());
        //Console.WriteLine(student.GetBitdate());
        //Console.WriteLine(student.GetContact());





        Teacher teacher = new Teacher()
        {
            Email = "teach1@gmail.com",
            Password = "test123"

        };

        Teacher teacher1 = new Teacher()
        {
            Email = "salam123@gmail.com",
            Password = "hae1541"

        };




        void Test()
        {
            Register.ReProduct(teacher);
            Register.ReProduct(teacher1);
        }
        Test();

        Login.TeacherLogin(teacher);
        Login.TeacherLogin(teacher1);









    }
}











