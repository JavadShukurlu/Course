using ModelsTasks.Models;

public class Program
{

    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Hello","beho","reko","ABS","Riy","15.12.2000","Mircelal",055151255,"r@gmail.com","salam123");
        Console.WriteLine(teacher.GetName());
        Console.WriteLine(teacher.GetSubject());
        Console.WriteLine(teacher.GetTeacher());
        Console.WriteLine(teacher.GetEmail());
        Console.WriteLine(teacher.GetBirthdate());
        Console.WriteLine(teacher.GetContact());

    }
    

}