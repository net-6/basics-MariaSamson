using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            function(50);
        }
        static void function(int n)
        {
            for(int i=0;i<=n;i++)
            {
                if(i%15==0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                    Console.WriteLine(i);
            }
        }
    }
}
