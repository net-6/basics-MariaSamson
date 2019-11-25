using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nr1 = Console.ReadLine();
            string nr2 = Console.ReadLine();
            string nr3 = Console.ReadLine();
            string nr4 = Console.ReadLine();


            int number1 = int.Parse(nr1);
            int number2 = int.Parse(nr2);
            int number3 = int.Parse(nr3);
            int number4 = int.Parse(nr4);
        }
            static void TheGreatest(int number1, int number2, int number3, int number4)
            {
                int max = number1;
                if (number2 > max)
                {
                    max = number2;
                }
                if (number3 > max)
                {
                    max = number3;
                }
                if (number4 > max)
                {
                    max = number4;
                }
                
                Console.WriteLine("Max is: " + max);
            }
        }
    }

