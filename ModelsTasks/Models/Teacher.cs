namespace ModelsTasks.Models
{
    public class Teacher
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Departmentname { get; set; }
        public string Subject { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public int PhoneNum { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        public void Info()
        {
            Console.WriteLine("Melumatlar");
            Console.WriteLine($"Username:{Username}\n Firstname:{Firstname}\n Lastname {Lastname}\n Departmentname {Departmentname}\n Subject {Subject}\n Birthdate {Birthdate}\n Address {Address}\n PhoneNum {PhoneNum} \n Email {Email} \n Password {Password} ");

            Console.WriteLine("--------------------------------------");
        }

        //    public Teacher()
        //    {

        //    }
        //    public Teacher(string username) : this()
        //    {
        //        Username = username;
        //    }
        //    public Teacher(string username, string firstname) : this(username)
        //    {
        //        Firstname = firstname;
        //    }

        //    public Teacher(string username, string firstname, string lastname) : this(username, firstname)
        //    {
        //        Lastname = lastname;
        //    }
        //    public Teacher(string username, string firstname, string lastname, string departmentname) : this(username, firstname, lastname)
        //    {
        //        Departmentname = departmentname;
        //    }
        //    public Teacher(string username, string firstname, string lastname, string departmentname, string subject) : this(username, firstname, lastname, departmentname)
        //    {
        //        Subject = subject;
        //    }
        //    public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday) : this(username, firstname, lastname, departmentname, subject)
        //    {
        //        Birthdate = birthday;
        //    }
        //    public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday, string address) : this(username, firstname, lastname, departmentname, subject, birthday)
        //    {
        //        Address = address;
        //    }
        //    public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday, string address, int phonenum) : this(username, firstname, lastname, departmentname, subject, birthday, address)
        //    {
        //        PhoneNum = phonenum;
        //    }
        //    public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday, string address, int phonenum, string email) : this(username, firstname, lastname, departmentname, subject, birthday, address, phonenum)
        //    {
        //        Email = email;
        //    }
        //    public Teacher(string username, string firstname, string lastname, string departmentname, string subject, string birthday, string address, int phonenum, string email, string password) : this(username, firstname, lastname, departmentname, subject, birthday, address, phonenum, email)
        //    {
        //        Password = password;
        //    }


        //    public string GetName()
        //    {
        //        return $"{Firstname}{Lastname}";
        //    }
        //    public string GetSubject()
        //    {
        //        return $"{Subject}";
        //    }
        //    public string GetTeacher()
        //    {
        //        return $"{Firstname}{Lastname}{Email}{Username}";
        //    }
        //    public string GetEmail()
        //    {
        //        return $"{Email}";
        //    }
        //    public string GetBirthdate()
        //    {
        //        return $"{Birthdate}";
        //    }
        //    public string GetContact()
        //    {
        //        return $"{PhoneNum}{Email}";
        //    }



    }
}
