using System;
namespace ConsoleApp1
{
    class GradeChecker
    {
        public void Setdata()
        {
            while (true)
            {
                Console.WriteLine("\nType 'exit' at any time to quit.");
                Console.WriteLine("Welcome to the Grade Checker!");
                Console.Write("Enter first grade: ");
                string grade1 = Console.ReadLine();
                if (grade1.Equals("exit" , StringComparison.OrdinalIgnoreCase))
                    break;
                Console.Write("Enter second grade: ");
                string grade2 = Console.ReadLine();
                if (grade2.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;
                Console.Write("Enter third grade: ");
                string grade3 = Console.ReadLine();
                if (grade2.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;      

                double num1 = Convert.ToDouble(grade1);
                double num2 = Convert.ToDouble(grade2);
                double num3 = Convert.ToDouble(grade3);

                double average = (num1 + num2 + num3) / 3;

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
        }
    }
}
    
