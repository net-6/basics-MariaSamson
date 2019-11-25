using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string thirdNumber = Console.ReadLine();
            string fourthNumber = Console.ReadLine();
            string fifthNumber = Console.ReadLine();

            int number1 = int.Parse(firstNumber);
            int number2 = int.Parse(secondNumber);
            int number3 = int.Parse(thirdNumber);
            int number4 = int.Parse(fourthNumber);
            int number5 = int.Parse(fifthNumber);
            Smallest(number1, number2, number3, number4, number5);
            Largest(number1, number2, number3, number4, number5);

        }

        static void Smallest(int number1, int number2, int number3, int number4, int number5)
        {   ///The smallest number
            int min = number1;
            if (number2 < min)
            {
                min = number2;
            }
            if (number3 < min)
            {
                min = number3;
            }
            if (number4 < min)
            {
                min = number4;
            }
            if (number5 < min)
            {
                min = number5;
            }
            Console.WriteLine(min);
        }
        static void Largest(int number1, int number2, int number3, int number4, int number5)
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
            if (number5 > max)
            {
                max = number5;
            }
            Console.WriteLine(max);
        }

    }
}

    

