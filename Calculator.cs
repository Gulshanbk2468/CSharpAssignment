using System;
using System.Xml.XPath;
namespace ConsoleApp1
{
    class Calculator
    {
        public void Setdata()
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Choose an operation:\n1. +\n2. -\n3. *\n4. /\n5. %");

            char operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    double sum = num1 + num2;
                    Console.WriteLine($"Sum is: {sum}");
                    break;
                case '-':
                    double difference = num1 - num2;
                    Console.WriteLine($"Difference is: {difference}");
                    break;
                case '*':
                    double product = num1 * num2;
                    Console.WriteLine($"Product is: {product}");
                    break;
                case '/':

                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    else
                    {
                        double quotient = num1 / num2;
                        Console.WriteLine($"Quotient is: {quotient}");
                    }
                    break;
                case '%':
                    double reminder = num1 % num2;
                    Console.WriteLine($"Reminder is: {reminder}");
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose a valid operation.");
                    break;
            }
        }
    }
}