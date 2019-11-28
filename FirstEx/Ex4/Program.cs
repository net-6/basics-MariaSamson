using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            int number1 = int.Parse(firstNumber);
            int number2 = int.Parse(secondNumber);
            function(number1, number2);
        }
         
         //function that prints the numbers that are divisible with 5
            static void function(int number1,int number2)
            {
                for (int i = number1; i <= number2; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                }
            }
        }
    }

