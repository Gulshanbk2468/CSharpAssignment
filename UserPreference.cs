using System;

class UserPreferences{

    public void SetUserData(int age, double height, bool notifications){
    
        Console.WriteLine("User Preferences ");
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your height is: " + height + " meters");
        Console.WriteLine("Notifications: " + notifications);  
    }

    static void Main(string[] args){
    
        UserPreferences user = new UserPreferences();

        Console.WriteLine("Welcome! Please enter your details.");

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your height in meters: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Do you want notifications? (true/false): ");
        bool notifications = Convert.ToBoolean(Console.ReadLine());

        user.SetUserData(age, height, notifications);

        Console.WriteLine("\nThank you for setting your preferences!");
    }
}
/*pogba@NJR-Gulshan:~/CurrencyConverter$ dotnet run
Welcome! Please enter your details.
Enter your age: 17
Enter your height in meters: 2 
Do you want notifications? (true/false): true 

---- User Preferences ----
Your age is: 17
Your height is: 2 meters
Notifications: True

Thank you for setting your preferences!
pogba@NJR-Gulshan:~/CurrencyConverter$ */
