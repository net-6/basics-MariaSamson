using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            //without using conditional statements
            Console.WriteLine("{0} >= {1}", Math.Max(a, b));
        
            //with conditional statements


        }
    }
}
