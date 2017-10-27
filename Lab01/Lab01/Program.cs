using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, lname, ID, GPA;
             Console.Write("Enter name:");
             name = Console.ReadLine();
             Console.Write("Enter Lastname:");
             lname = Console.ReadLine();
             Console.Write("Enter ID:");
             ID = Console.ReadLine();
             Console.Write("Enter GPA.:");
             GPA = Console.ReadLine();
             Console.WriteLine("------------------");
             Console.Write("Name: {0}\nLastname: {1}\nID: {2}\nGPA.:{3}\n", name, lname, ID, GPA);
             Console.ReadKey();

        }
    }
}
