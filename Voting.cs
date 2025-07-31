using System;
namespace ConsoleApp1
{
    public class Voting
    {
        public void CheckEligibility()
        {
            Console.WriteLine("Welcome to the Voting Eligibility Checker!");
            Console.WriteLine("Please enter your details to check if you are eligible to vote.");
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }

        }

    }
}