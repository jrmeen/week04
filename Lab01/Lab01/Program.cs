using System;
namespace thruthTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A, B, Y, Z;
            Console.WriteLine("      Y = A NOT B");
            Console.WriteLine("-----------------------");
            Console.WriteLine("   A      B\t| Not A | Not B");
            Console.WriteLine("-----------------------");
            A = false; B = false; Y = !A; Z = !B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t | {3}", A, B, Y, Z);
            A = false; B = true; Y = !A; Z = !B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t | {3}", A, B, Y, Z);
            A = true; B = false; Y = !A; Z = !B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t | {3}", A, B, Y, Z);
            A = true; B = true; Y = !A; Z = !B;
            Console.WriteLine(" {0}\t{1}\t| {2}\t | {3}", A, B, Y, Z);
            Console.WriteLine("-----------------------");
        }
    }
}
