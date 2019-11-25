using System;

namespace FirstEx
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string thirdNumber = Console.ReadLine();

            int number1 = int.Parse(firstNumber);
            int number2 = int.Parse(secondNumber);
            int number3 = int.Parse(thirdNumber);

            Sum(number1, number2, number3);

            
        }
        static void Sum(int number1, int number2, int  number3)
        {

            Console.WriteLine("the sum is: " + (number1 + number2 + number3));
        }
    }
}

