namespace ModelsTasks.Models
{
    public class Teacher
    {
        string Username;
        string Firstname;
        string Lastname;
        string Departmentname;
        string Subject;
        string Birthdate;
        string Address;
        int PhoneNum;
        string Email;
        string Password;


        //public Teacher(
        //    string username, string firstname,
        //    string lastname, string departmentname,
        //    string subject, string birthday,
        //    string address, int phonenum,
        //    string email, string password)
        //{
        //    Username = username; Firstname = firstname;
        //    Lastname = lastname; Departmentname = departmentname;
        //    Subject = subject; Birthdate = birthday;
        //    Address = address; PhoneNum = phonenum;
        //    Email = email;
        //}

        public Teacher()
        {

        }
        public Teacher(string username) : this()
        {
            Username=username;
        }
        public Teacher(string username, string firstname) : this(username)
        {
            Firstname=firstname;
        }

        public Teacher(string username, string firstname, string lastname) : this(username, firstname)
        {
            Lastname=lastname;
        }
        public Teacher(string username, string firstname, string lastname, string departmentname) : this(username, firstname, lastname)
        {
            Departmentname=departmentname;
        }
        public Teacher(string username, string firstname, string lastname, string departmentname, string subject) : this(username, firstname, lastname, departmentname)
        {
            Subject=subject;
        }
        public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday) : this(username, firstname, lastname, departmentname, subject)
        {
            Birthdate=birthday;
        }
        public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday, string address) : this(username, firstname, lastname, departmentname, subject, birthday)
        {
            Address=address;
        }
        public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday, string address, int phonenum) : this(username, firstname, lastname, departmentname, subject, birthday, address)
        {
            PhoneNum=phonenum;
        }
        public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday, string address, int phonenum, string email) : this(username, firstname, lastname, departmentname, subject, birthday, address, phonenum)
        {
            Email=email;
        }
        public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday, string address, int phonenum, string email,string password) : this(username, firstname, lastname, departmentname, subject, birthday, address, phonenum,email)
        {
            Password=password;
        }


        public string GetName()
        {
            return $"{Firstname}{Lastname}";
        }
        public string GetSubject()
        {
            return $"{Subject}";
        }
        public string GetTeacher()
        {
            return $"{Firstname}{Lastname}{Email}{Username}";
        }
        public string GetEmail()
        {
            return $"{Email}";
        }
        public string GetBirthdate()
        {
            return $"{Birthdate}";
        }
        public string GetContact()
        {
            return $"{PhoneNum}{Email}";
        }



    }
}
