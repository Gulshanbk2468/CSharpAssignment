using System;

namespace ConsoleApp1
{
    public class Compare
    {
        public void Cmp()
        {
            while (true) // infinite loop
            {
                Console.WriteLine("\nType 'end' at any time to quit.");

                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine();
                if (input1.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine();
                if (input2.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                int num1 = Convert.ToInt32(input1);
                int num2 = Convert.ToInt32(input2);

                if (num1 > num2)
                {
                    Console.WriteLine("The first number is greater than the second number.");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("The first number is less than the second number.");
                }
                else
                {
                    Console.WriteLine("Both numbers are equal.");
                }
            }

            Console.WriteLine("Program exited.");
        }
    }
}
