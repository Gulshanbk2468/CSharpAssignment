using System;
public class Arithmetic
{
    public void Add(double a, double b)
    {
        double Sum = a + b;
        Console.WriteLine($"Sum is: {Sum}");
    }
    public void Substract(double a, double b)
    {
        double Sub = a - b;
        Console.WriteLine($"Substract is: {Sub}");
    }
    public void Multiply(double a, double b)
    {
        double Mul = a * b;
        Console.WriteLine($"Multiplt is :{Mul}");
    }
    public void Divide(int a, int b)
    {
        if (b != 0)
        {
            double quotient = (double)a / b;
            Console.WriteLine($"Quotient: {quotient}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}
