using System;
namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 9),a;
            bool b;
            Console.Write("Enter number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Random Number: {0}",randomNumber);
            b = a > randomNumber;
            Console.WriteLine("Boolean {0}> {1} is {2}", a, randomNumber, b);
        }
    }
}
