using System;
public class BinaryToDecimal
{
    public void SetData()
    {
        Console.WriteLine("Enter number...");
        int OriginalNum = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int reminder = 0;
        double result = 0;
        while (OriginalNum > 0)
        {
            reminder = OriginalNum % 10;
                if (reminder == 1 || reminder == 0)
            {
                result += reminder * Math.Pow(2, count);
            }
            OriginalNum /= 10;
            count++;
        }
        Console.WriteLine($"The binary number is:{result}");

    }
}