    //Question: Create a number guessing game where the user tries to guess a randomly generated number between 1 and 100.
    //Provide feedback to the user if their guess is too low or too high.
    //Once the user guesses correctly, congratulate them and display the number of attempts it took.
    //Additionally, calculate the sum of the generated number and the user's guessed number, then triple the sum and display the result.
using System;
public class Triple
{
    public void SetData()
    {
            Random random = new Random();
            int genNum = random.Next(1, 101); // Random number between 1 and 100
            Console.WriteLine("Welcome to Ambika ICT Hub");
           int i = 0;
            while (true)
        {
            Console.WriteLine("Enter a number..");
            int guessNum = Convert.ToInt32(Console.ReadLine());
            if (guessNum < genNum)
            {
                Console.WriteLine("Too low! Try again.");
                i++;
            }
            else if (guessNum > genNum)
            {
                Console.WriteLine("Too high! Try again.");
                i++;
            }
            else
            {
                Console.WriteLine($"🎉 Congratulations! You've guessed the number {genNum} correctly! in {i} attempt.");
                int sum = genNum + guessNum;
                int Triplenum = sum * 3;
                Console.WriteLine($"The Sum is : {sum}\nTriple of the sum is : {Triplenum}");

                return; // Exit the loop and end the game
            }
        }
    }
}