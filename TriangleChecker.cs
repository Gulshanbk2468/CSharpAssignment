using System;
namespace ConsoleApp1
{
    class TriangleChecker
    {
        public void CheckTriangle()
        {
            Console.WriteLine("Welcome to Triangle side Checker....\n lets check if the sides can form a triangle or not");
            Console.WriteLine("Enter the length of the first side:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side:");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the third side:");
            double side3 = Convert.ToDouble(Console.ReadLine());
            if (side1 + side2 > side3 &&
                side1 + side3 > side2 &&
                side2 + side3 > side1)
            {
                Console.WriteLine("The sides can form a triangle.");

                double s = (side1 + side2 + side3) / 2;
                double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
                Console.WriteLine("The area of the triangle is: " + area);
            }
            else
            {
                Console.WriteLine("The sides cannot form a triangle.");
            }
        }
    }
}