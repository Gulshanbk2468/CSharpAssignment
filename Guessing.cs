    // Q: What does the SetData method do in the Guessing Game?
    /// Starts a console-based guessing game where the user attempts to guess a randomly generated number between 1 and 100.
    /// The method provides feedback if the guess is too low or too high, and tracks the number of attempts taken to guess correctly.
using System;
public class Guessing
{

    public void SetData()
    {
        Random random = new Random();
        int genNum = random.Next(1, 101); // Random number between 1 and 100
        int i = 0;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Try to guess the number I'm thinking of (between 1 and 100).");

        while ( true)
        {
            Console.Write("Enter your guess: ");
             int guessNum = Convert.ToInt32(Console.ReadLine());

            if (guessNum < genNum)
            {
                Console.WriteLine("Too low! Try again.");
                i++; //Increment the value of i 
            }
            else if (guessNum > genNum)
            {
                Console.WriteLine("Too high! Try again.");
                i++; //Increment the value of i
            }
            else
            {
                Console.WriteLine($"Congratulations! You've guessed the number!!!\nYou attempt in {i} times to guess the number {genNum}");
                return; // Exit the loop and end the game
            }
        }
    }
}