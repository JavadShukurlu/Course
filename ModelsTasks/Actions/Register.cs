using ModelsTasks.Models;

namespace ModelsTasks.Actions
{


    public  class Register
    {
        public static List<Teacher> teachers = new List<Teacher>();
        public static void ReProduct(Teacher teacher)
        {
            teachers.Add(teacher);
            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Email}--{item.Password}");
            }
            Console.WriteLine();
        }

        internal static void RegisterStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}

