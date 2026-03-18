

namespace ModelsTasks.Models
{
    public class Register
    {
        public static List<Student> Students = new List<Student>();


        public static void RegisterStudent(Student students)
        {
            Students.Add(students);

            foreach(var student in Students)
            {
                Console.WriteLine($"FirstName:{student.FirstName}\n" +
                    $"LastName:{student.LastName}\n" +
                    $"{student.Email}\n" +
                    $"Password:{student.Password}");
            }

            Console.WriteLine();
        }
    }
}
