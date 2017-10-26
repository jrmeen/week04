using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : char");
            Console.WriteLine("Size :" + sizeof(char));
            Console.WriteLine("Minimum Value :" + char.MinValue);
            Console.WriteLine("Maximum Value :" + char.MaxValue);
        }
    }
}
