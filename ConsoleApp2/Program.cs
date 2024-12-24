// See https://aka.ms/new-console-template for more information

using ConsoleApp2.student;

Students students = new Students();
string name, GPA, major;
Console.WriteLine("Enter Name ");
name = Console.ReadLine();
Console.WriteLine("Enter Major");
major = Console.ReadLine();
Console.WriteLine("Enter your GPA");
GPA = Console.ReadLine();
Console.WriteLine(students.GetInfo(name, major, GPA));


Console.WriteLine("------------------");

//Task 2

