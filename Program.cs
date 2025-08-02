using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calculator.cs
            Calculator calculator = new Calculator();
            calculator.Setdata();



            // GradeChecker.cs
            GradeChecker gradeChecker = new GradeChecker();
            gradeChecker.Setdata();

            // TriangleChecker.cs
            TriangleChecker triangleChecker = new TriangleChecker();
            triangleChecker.CheckTriangle();

            // Quadrant.cs
            Quadrant quadrant = new Quadrant();
            quadrant.SetUserData();

            // Voting.cs
            Voting voting = new Voting();
            voting.CheckEligibility();

            // Admin.cs
            Admin admin = new Admin();
            admin.Display();

            // UserPreferences.cs
            UserPreferences userPreferences = new UserPreferences();
            Console.WriteLine("Welcome! Please enter your details.");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Do you want notifications? (true/false): ");
            bool notifications = Convert.ToBoolean(Console.ReadLine());
            userPreferences.SetUserData(age, height, notifications);
            Console.WriteLine("\nThank you for setting your preferences!");

            // HeightChecker.cs
            HeightChecker heightChecker = new HeightChecker();
            heightChecker.CheckHeight();


        }
    }
}
// This code is the entry point for the Calculator application.`