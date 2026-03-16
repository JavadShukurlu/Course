using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTasks
{
    public class Student
    {
        string _firstName;
        string _lastName;
        public string userName;
        public string  groupNumber;
        public double score;
        public DateOnly birthdate;
        public string adress;
        public string phoneNumber;
        public string email;
        public string password;



        public Student()
        {
            
        }
        public Student(string FirstName):this()
        {
            _firstName = FirstName;
        }
        public Student(string FirstName,string LastName):this(FirstName)
        {
            _lastName = LastName;
        }
        public Student(string FirstName, string LastName,string UserName):this(FirstName,LastName)
        {
            userName = UserName;
        }
        public Student(string FirstName, string LastName, string UserName,string GroupNumber):this(FirstName,LastName,UserName)
        {
            groupNumber = GroupNumber;
        }
        public Student(string FirstName, string LastName, string UserName, string GroupNumber,double Score):this(FirstName,LastName,
            UserName,GroupNumber)
        {
            score = Score;
        }
        public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score,DateOnly Birthdate) : this(FirstName, LastName,
            UserName, GroupNumber,Score)
        {
            birthdate = Birthdate;
        }
        public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score, DateOnly Birthdate,string Adress) : this(FirstName, LastName,
            UserName, GroupNumber, Score,Birthdate)
        {
            adress = Adress;
        }
        public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score, DateOnly Birthdate, string Adress,string PhoneNumber) : this(FirstName, LastName,
            UserName, GroupNumber, Score, Birthdate,Adress)
        {
            phoneNumber = PhoneNumber;
        }
        public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score, DateOnly Birthdate, string Adress, string PhoneNumber,string Email) : this(FirstName, LastName,
            UserName, GroupNumber, Score, Birthdate, Adress,PhoneNumber)
        {
            email = Email;
        }

        public Student(string FirstName, string LastName, string UserName, string GroupNumber, double Score, DateOnly Birthdate, string Adress, string PhoneNumber, string Email,string Password) : this(FirstName, LastName,
            UserName, GroupNumber, Score, Birthdate, Adress, PhoneNumber,Email)
        {
            password = Password;
        }

        public  string GetName()
        {
            return $"{_firstName} {_lastName}";
        }

        public string GetGroup()
        {
            return $"{groupNumber}";
        }
        public string GetStudent()
        {
            return $"{_firstName} {_lastName} {email} {userName}";
        } 
        public string GetEmail()
        {
            return $"{email}";
        }
        public string GetBitdate()
        {
            return $"{birthdate}";
        }

        public string GetContact()
        {
            return $"{phoneNumber} {email}";
        }

    }
}
