

using System.Runtime.Loader;
using System.Security.Cryptography;

namespace ModelsTasks.Models
{
    public class Student
    {
        //string _firstName;
        //string _lastName;
        //public string userName;
        //public string  groupNumber;
        //public double score;
        //public DateOnly birthdate;
        //public string adress;
        //public string phoneNumber;
        //public string email;
        //public string password;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string GroupNumber { get; set; }
        public double Score { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        public void Info()
        {
            Console.WriteLine("Melumatlar:");
            Console.WriteLine($"FirstName:{FirstName},\n" +
                $"LastName:{LastName},\n" +
                $"UserName:{UserName},\n" +
                $"GroupNumber:{GroupNumber},\n" +
                $"Score:{Score},\n" +
                $"Birthdate:{Birthdate},\n" +
                $"Address:{Address},\n" +
                $"PhoneNumber:{PhoneNumber},\n" +
                $"Email:{Email},\n" +
                $"Password:{Password}");
        }
        //public Student()
        //{
            
        //}
        //public Student(string FirstName):this()
        //{
        //    FirstName = FirstName;
        //}
        //public Student(string FirstName,string LastName):this(FirstName)
        //{
        //    LastName = LastName;
        //}
        //public Student(string FirstName, string LastName,string UserName):this(FirstName,LastName)
        //{
        //    UserName = UserName;
        //}
        //public Student(string FirstName, string LastName, string UserName,string GroupNumber):this(FirstName,LastName,UserName)
        //{
        //    GroupNumber = GroupNumber;
        //}
        //public Student(string FirstName, string LastName, string UserName, string GroupNumber,double Score):this(FirstName,LastName,
        //    UserName,GroupNumber)
        //{
        //    Score = Score;
        //}
        //public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score,DateOnly BirthDate) : this(FirstName, LastName,
        //    UserName, GroupNumber,Score)
        //{
        //    Birthdate = BirthDate;
        //}
        //public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score, DateOnly BirthDate,string Adress) : this(FirstName, LastName,
        //    UserName, GroupNumber, Score,BirthDate)
        //{
        //    Address = Adress;
        //}
        //public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score, DateOnly BirthDate, string Adress,string PhoneNumber) : this(FirstName, LastName,
        //    UserName, GroupNumber, Score, BirthDate,Adress)
        //{
        //    this.PhoneNumber = PhoneNumber;
        //}
        //public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score, DateOnly BirthDate, string Adress, string PhoneNumber,string Email) : this(FirstName, LastName,
        //    UserName, GroupNumber, Score, BirthDate, Adress,PhoneNumber)
        //{
        //    this.Email = Email;
        //}

        //public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score, DateOnly BirthDate, string Adress, string PhoneNumber, string Email,string Password) : this(FirstName, LastName,
        //    UserName, GroupNumber, Score, BirthDate, Adress, PhoneNumber,Email)
        //{
        //    this.Password = Password;
        //}

        //public  string GetName()
        //{
        //    return $"{FirstName} {LastName}";
        //}

        //public string GetGroup()
        //{
        //    return $"{GroupNumber}";
        //}
        //public string GetStudent()
        //{
        //    return $"{FirstName} {LastName} {Email} {UserName}";
        //} 
        //public string GetEmail()
        //{
        //    return $"{Email}";
        //}
        //public string GetBitdate()
        //{
        //    return $"{Birthdate}";
        //}

        //public string GetContact()
        //{
        //    return $"{PhoneNumber} {Email}";
        //}

    }
}
