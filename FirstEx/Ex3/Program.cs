using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string r = Console.ReadLine();
            int radius = int.Parse(r);

            perimeter_and_area(radius);
        }
            static void perimeter_and_area(int radius)
            { 
            float pi = 3.14f;
            float Area = pi * (radius * radius);
            float perimeter = 2 * pi * radius;
            Console.WriteLine("the area is: " + Area);
            Console.WriteLine("The perimeter is:" + perimeter);
            }
        }
    }

