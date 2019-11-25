using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N:");
            int N = int.Parse(Console.ReadLine());
            method2(N);
        }
         
            static void method2(int N)//metoda de determinare a numerelor care nu sunt divizibile nici cu 3,nici cu 7
            {
                for (int i = 0; i <= N; i++)
                {
                    if (i % 3 == 1 && i % 7 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }

