// using System;
class Currency
{
    public void convert()
    {
        // currency converting program
        System.Console.WriteLine("Currency Converter Started...");
        System.Console.WriteLine("Enter amount in Nepali Rupees:");
        double amount = Convert.ToDouble(System.Console.ReadLine());

        System.Console.WriteLine("Choose the currency to convert:");
        System.Console.WriteLine("1. Indian Rupees");
        System.Console.WriteLine("2. US Dollars");
        System.Console.WriteLine("3. Japanese Yen");

        int choice = Convert.ToInt32(System.Console.ReadLine());

        switch (choice)
        {
            case 1:
                double rate1 = 1.65;
                double inr = amount * rate1;
                System.Console.WriteLine("Amount in Indian Rupees: " + inr);
                break;
            case 2:
                double rate2 = 0.0073;
                double usd = amount * rate2;
                System.Console.WriteLine("Amount in US Dollars: " + usd);
                break;
            case 3:
                double rate3 = 1.06;
                double yen = amount * rate3;
                System.Console.WriteLine("Amount in Japanese Yen: " + yen);
                break;
            default:
                System.Console.WriteLine("Wrong option. Please enter 1, 2 or 3.");
                break;
        }
    }
}


