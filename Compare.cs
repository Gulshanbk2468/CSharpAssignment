using System;
namespace ConsoleApp1
{
    public class Compare
    {
        public void Cmp()
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The first number is greater than the second number.");
            }else if (num1 < num2)
            {
                Console.WriteLine("The first number is less than the second number.");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }
        }
    }
}