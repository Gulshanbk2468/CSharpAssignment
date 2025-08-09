using System.ComponentModel;
using System.Numerics;

public class Calculator
{
    public void Setdata()
    {    
        Console.WriteLine("Welcome to the Calculator App!");
        Console.WriteLine("Enter first numbers:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second numbers:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        int i = 1;
        
            Console.WriteLine("Enter an operator (+, -, *, /, %):");
            char oper = Convert.ToChar(Console.ReadLine());
            double add = num1 + num2;
            double sub = num1 - num2;
            double mul = num1 * num2;
            double mod = num1 % num2;

            double result = oper switch
            {
                '+' => add,
                '-' => sub,
                '*' => mul,
                '/' => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero."),
                '%' => mod
            };

            Console.WriteLine($"Result = {result}");
            Console.WriteLine("Thanks for using my Calculator App");
 
    }
    
    public void Again() {
        bool isAgain = true;
        while (isAgain) {
            Console.WriteLine("1.Press 1 to CalculateAgain.\n2.Press 2 to Exit.");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Setdata();
                    break;

                case 2:
                    isAgain = false;
                    break;

                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
 
}
