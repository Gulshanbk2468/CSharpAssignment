using System;
namespace ConsoleApp1
{
    class Quadrant
    {
        public void SetUserData()
        {
            Console.WriteLine("Welcome to the Quadrant Checker!");
            Console.WriteLine("Please enter the x-coordinate:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the y-coordinate:");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant I.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant II.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant III.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant IV.");
            }
            Console.WriteLine("Thank you for using the Quadrant Checker!");
        }
    }
}