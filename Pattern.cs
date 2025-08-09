using System;
namespace ConsoleApp1
{
    public class Pattern
    {
        public void PrintPattern()
        {
            Console.WriteLine("Welcome to the Pattern Printer!");
            int row = 5;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}