using System;

class HeightChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter your height in centimeters: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double height))
        {
            if (height <= 0)
            {
                Console.WriteLine("Height must be greater than 0.");
            }
            else if (height < 150)
            {
                Console.WriteLine("You are considered short.");
            }
            else if (height >= 150 && height <= 180)
            {
                Console.WriteLine("You are of average height.");
            }
            else
            {
                Console.WriteLine("You are tall.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
