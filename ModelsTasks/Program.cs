
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






        Student student = new Student("Cavad", "Sukurlu", "Cavad", "APA103", 98, new DateOnly(2005, 11, 18), "Baku", "0553316415", "sukurlucavad@gmail.com", "123456");

        Console.WriteLine(student.GetName());
        Console.WriteLine(student.GetGroup());
        Console.WriteLine(student.GetStudent());
        Console.WriteLine(student.GetEmail());
        Console.WriteLine(student.GetBitdate());
        Console.WriteLine(student.GetContact());
    }
}

