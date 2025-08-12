using System;
namespace ConsoleApp1;

public class StudentDetl
{
    public void SetData()
    {
        Console.WriteLine("Welcome to the Student Details Program!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine()!;

        double sum = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Hey {name} enter the marks of subjects {i}:");
            double marks = Convert.ToDouble(Console.ReadLine()!);
            if (marks > 100 || marks < 35)
            {
                Console.WriteLine("Invalid Option");
                return;
            }
            sum += marks;
        }
                double average = sum / 5;
                double gpa = average / 25;
                Console.WriteLine($"Your sum is: {sum}\nYour average marks are: {average}\nYour GPA is: {gpa}");

                if (gpa >= 3.5)
                {
                    Console.WriteLine("You are eligible for the scholarship in Ambika.");
                }
                else
                {
                    Console.WriteLine("You are not eligible for the scholarship in Ambika.");
                }
            }
        }
