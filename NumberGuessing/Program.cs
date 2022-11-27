using System;

class Program
{
    static void Main(string[] args)
    {
        // User Chances Tracker
        int userChances = 5;

        // Introduction Text
        Console.WriteLine("Let's play the guessing number game!");
        Console.WriteLine($"You have {userChances} chances to win!");
        Console.WriteLine("Are you ready?");
        Console.WriteLine("Enter a number between 1 and 20:");

        // Random Number Generator
        Random rand = new Random();
        int randomNumber = rand.Next(1, 21);

        // userNumber Variable Declaration
        int userNumber;

        // Input Evaluation
        do
        {
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (randomNumber == userNumber)
            {
                Console.WriteLine("Congratulations! You have guessed the correct number!");
                Console.WriteLine("The game is over, thanks for playing!");
                return;
            }

            if (randomNumber > userNumber)
            {
                // Check if guessing difference is 5 or less

                if ((randomNumber - userNumber) <= 5)
                {
                    Console.WriteLine("You are close!");
                }
                else
                {
                    Console.WriteLine("The number is too low!");
                }
            }

            if (randomNumber < userNumber)
            {
                if((userNumber - randomNumber) <= 5)
                {
                    Console.WriteLine("You are close!");
                }
                else
                {
                    Console.WriteLine("The number is too high!");
                }
            }
            userChances--;
            Console.WriteLine($"You have {userChances} chance(s) left!");

            if (userChances <= 0) break;
        }

        while (randomNumber != userNumber);

        Console.WriteLine("The game is over, thanks for playing!");
    }
}
