using System;
namespace ConsoleApp1
{
    public class Admin
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the Admin Panel!");
            string email = "gulshanbk11@gmail.com";
            string password = "12345678";
            Console.WriteLine("Please enter your email:");
            string inputEmail = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string inputPassword = Console.ReadLine();
        if(inputEmail == email && inputPassword == password)
            {
                Console.WriteLine("Login successful! You are now in the admin panel.");
            }
            else
            {
                Console.WriteLine("Invalid email or password. Please try again.");
            }
        }
    }
}