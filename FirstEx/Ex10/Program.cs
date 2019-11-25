using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Triangle();
        }
        
        static void Triangle()
        {
            Console.WriteLine("Please enter the number:");
            int input = int.Parse(Console.ReadLine());
            int a, b;

            for (a = 1; a <= input; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (a = input - 1; a >= 0; a--)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }



        }
 
}
}
