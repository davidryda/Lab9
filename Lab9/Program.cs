using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        public const double pi = Math.PI;
        public static int counter = 1;

        static void Main(string[] args)
        {
            bool loop = true;
            Console.WriteLine("Welcome to the Circle Tester");
            while (loop)
            {
                Console.Write("Enter radius: ");
                string input = Console.ReadLine().Trim();
                double.TryParse(input, out double radius);
                Circle createdCircle = new Circle(radius);

                createdCircle.GetCircumference();
                createdCircle.GetArea();

                Console.WriteLine("Circumference: " + createdCircle.GetFormattedCircumference());
                Console.WriteLine("Area: " + createdCircle.GetFormattedArea());

                Console.WriteLine("Continue? (Y or N)");
                char answer = Console.ReadLine().ToLower().Trim()[0];
                if (answer == 'y')
                {
                    counter++;
                    loop = true;
                }
                else
                {
                    Console.WriteLine("You made {0} circle things!", counter);
                    loop = false;
                }
            }
            //Write the total number of built circles

            Console.ReadKey();

            /*bool loop = true;
            Console.WriteLine("Welcome to the Circle Tester");
            while (loop)
            {
                Console.Write("Enter radius: ");
                string input = Console.ReadLine().Trim();
                double radius = 0.0;
                double.TryParse(input, out radius);

                double circumference = 2 * pi * radius;
                double area = pi * radius * radius;

                double roundedCircumference = Math.Round(circumference, 2);
                double roundedArea = Math.Round(area, 2);

                Console.WriteLine("Circumference: " + roundedCircumference);
                Console.WriteLine("Area: " + roundedArea);
                Console.WriteLine("Continue? (y or N)");
                char answer = Console.ReadLine().ToLower().Trim()[0];
                if (answer == 'y')
                {
                    loop = true;
                }
                else
                {
                    Environment.Exit(0);
                }
            }*/
        }
    }
}
