using System;

class UserPreferences
{

    public void SetUserData(int age, double height, bool notifications)
    {

        Console.WriteLine("User Preferences ");
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your height is: " + height + " meters");
        Console.WriteLine("Notifications: " + notifications);

    }
}

