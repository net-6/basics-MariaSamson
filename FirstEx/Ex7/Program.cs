using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N:");
            int N = int.Parse(Console.ReadLine());
            method(N);
        }
            static void method(int N)
            {
                for (int i = 1; i <= N; i++)
                    Console.WriteLine(i);
            }
        }
    }
 

