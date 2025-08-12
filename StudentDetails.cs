using System;
using ConsoleApp1;
public class StudentDetails
{
    public void SetData()
    {
        Console.WriteLine("Welcome to Ambika ICT Hub!");
        Console.WriteLine("Please enter the number of students:");
        int noofstudents = Convert.ToInt32(Console.ReadLine()!);

        if (noofstudents <= 0)
        {
            Console.WriteLine("Invalid number of students. Please enter a positive integer.");
            return;
        }

        Console.WriteLine("Enter the no. of subject");     
        int noofsubject = Convert.ToInt32(Console.ReadLine()!);

        if (noofsubject <= 0)
        {
            Console.WriteLine("Invalid number of subjects. Please enter a positive integer.");
            return;
        }
        
        double sum = 0;
        for (int i = 1; i <= noofstudents; i++)
        {
            Console.WriteLine($"Enter the name of student {i}:");
            string name = Console.ReadLine()!;

            for (int j = 1; j <= noofsubject; j++)
            {
                Console.WriteLine($"Hey {name}, enter the marks for subject {j}:");
                double marks = Convert.ToDouble(Console.ReadLine()!);

                if (marks > 100 || marks < 35)
                {
                    Console.WriteLine("Invalid marks entered.\nTry again.");
                    return;
                }
                sum += marks;
            }
            double average = sum / 5;
            double gpa = average / 25;
            Console.WriteLine($"Student: {name}\nTotal Marks: {sum}\nAverage Marks: {average}\nGPA: {gpa}");
            if (gpa >= 3.5)
            {
                Console.WriteLine($"{name} is eligible for the scholarship in Ambika.");
            }
            else
            {
                 Console.WriteLine($"{name} is not eligible for the scholarship in Ambika.");
            }
        }
    }
}