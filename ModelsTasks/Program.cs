// See https://aka.ms/new-console-template for more information

using ModelsTasks;

Student student = new Student("Cavad","Sukurlu","Cavad","APA103",98,new DateOnly(2005,11,18),"Baku","0553316415","sukurlucavad@gmail.com","123456");

Console.WriteLine(student.GetName());
Console.WriteLine(student.GetGroup());
Console.WriteLine(student.GetStudent());
Console.WriteLine(student.GetEmail());
Console.WriteLine(student.GetBitdate());
Console.WriteLine(student.GetContact());