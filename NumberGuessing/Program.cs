using System;

class Program
{
    const int NUM_OF_CHANCES = 5;
    static void Main(string[] args)
    {
        // Introduction Text
        Console.WriteLine("Let's play the guessing number game!");
        Console.WriteLine($"You have {NUM_OF_CHANCES} chances to win!");
        Console.WriteLine("Are you ready?");
        Console.WriteLine("Enter a number between 1 and 20:");

        // Random Number Generator
        Random rand = new Random();
        int randomNumber = rand.Next(1, 21);

        // User Chances Tracker
        int userChances = NUM_OF_CHANCES;

        // userNumber Variable Declaration
        int userNumber;

        do
        {
            // Input Evaluation
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (randomNumber == userNumber)
            {
                Console.WriteLine("Congratulations! You have guessed the correct number!");
                Console.WriteLine("The game is over, thanks for playing!");
                return;
            }

            // Check if guessing difference is 5 or less
            if (Math.Abs(randomNumber - userNumber) <= 5)
            {
                Console.WriteLine("You are close!");
            }
            else
            {
                Console.WriteLine("The number is too low/ high!");
            }

            userChances--;
            Console.WriteLine($"You have {userChances} chance(s) left!");

            if (userChances <= 0) break;
        }

        while (true);
        
        Console.WriteLine("The game is over, thanks for playing!");
    }
}
