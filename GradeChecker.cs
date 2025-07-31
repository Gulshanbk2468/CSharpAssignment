using System;
namespace ConsoleApp1
{
    class GradeChecker
    {
        public void Setdata()
        {   Console.WriteLine("Welcome to the Grade Checker!");
            Console.Write("Enter first grade: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second grade: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third grade: ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            double average = (grade1 + grade2 + grade3) / 3;

            string result = average switch
            {
                >= 90 and <= 100 => "A+",
                >= 80 and < 90 => "A",
                >= 70 and < 80 => "B",
                >= 60 and < 70 => "C",
                >= 50 and < 60 => "D",
                >= 0 and < 50 => "F",
                _ => "Invalid marks"
            };

            Console.WriteLine($"Your grade is: {result}");
        }
   };
}
    
