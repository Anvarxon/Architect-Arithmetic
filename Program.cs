using System;
/*
This program allows to calculate the area and cost of flooring of three different shapes.
*/
namespace Architect_Arithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            This program allows to calculate the area and cost of flooring of three different shapes.
            */

            Console.WriteLine("Hi! This app can calculate the flooring cost of building.\nYou can enter shapes like rectangle, circle and traingle. ");

            Console.Write("First, enter the cost of flooring, please: ");
            double cost = Double.Parse(Console.ReadLine());

            Console.Write("Great! Now choose one shape of floor by typing: rectangle or triangle or circle: ");
            string shape = Console.ReadLine();

            switch (shape)
            {
                case "rectangle":
                    Console.Write("Enter the length of rectangle: ");
                    double length = Double.Parse(Console.ReadLine());

                    Console.Write("Enter the width of rectangle: ");
                    double width = Double.Parse(Console.ReadLine());

                    double recArea = RectangleArea(length, width);
                    Console.WriteLine($"Area of rectangle is {recArea}");
                    Console.WriteLine($"Total cost of flooring is {CalculateTotalCostOfFlooring(recArea, cost)}");
                    break;

                case "circle":
                    Console.Write("Enter the radius of circle: ");
                    double radius = Double.Parse(Console.ReadLine());
                    double calculatedCircleArea = CircleArea(radius);
                    double calculatedHalfCircleArea = calculatedCircleArea / 2;


                    Console.WriteLine("Is it full circle like this 'o'? Please answer by typing yes or no.");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Console.WriteLine($"Area of full circle is {calculatedCircleArea}");
                        Console.WriteLine($"Cost of flooring is {Math.Round(CalculateTotalCostOfFlooring(calculatedCircleArea, cost), 2)}");
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine($"Area of half circle is {calculatedHalfCircleArea}");
                        Console.WriteLine($"Cost of flooring is {Math.Round(CalculateTotalCostOfFlooring(calculatedHalfCircleArea, cost), 2)}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid value");
                    }
                    break;

                case "triangle":
                    Console.Write("Enter the height of triangle: ");
                    double height = Double.Parse(Console.ReadLine());

                    Console.Write("Enter the bottom of triangle: ");
                    double bottom = Double.Parse(Console.ReadLine());

                    double triangleArea = TriangleArea(height, bottom);
                    Console.WriteLine($"Area of triangle is {triangleArea}");
                    Console.WriteLine($"Cost of flooring is {Math.Round(CalculateTotalCostOfFlooring(triangleArea, cost), 2)}");
                    break;

                default:
                    Console.WriteLine("Invalid value. Please enter another one.");
                    break;
            }
        }

        static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double TriangleArea(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        static double CalculateTotalCostOfFlooring(double area, double costPerMeter)
        {
            return area * costPerMeter;
        }
    }
}
