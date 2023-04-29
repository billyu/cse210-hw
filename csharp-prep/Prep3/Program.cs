using System;

class Program
{
    static void Main(string[] args)
    {
        // Task: In the Guess My Number game the computer picks a magic number, 
        // and then the user tries to guess it. After each guess, the computer 
        // tells the user to guess "higher" or "lower" until they guess the magic number.

        // Create a random generator
        Random random = new Random();

        // Keep track of the number of guesses
        int guesses = 0;

        // Generate a random number between 1 and 100
        int magicNumber = random.Next(1, 101);

        // Ask the user to guess the number
        Console.WriteLine("Guess a number between 1 and 100");
        int guess = int.Parse(Console.ReadLine());

        // Keep asking the user to guess until they guess the magic number
        while (guess != magicNumber)
        {
            // Increment the number of guesses
            guesses++;

            // Tell the user to guess higher or lower
            if (guess < magicNumber)
            {
                Console.WriteLine("Guess higher");
            }
            else
            {
                Console.WriteLine("Guess lower");
            }

            // Ask the user to guess again
            guess = int.Parse(Console.ReadLine());
        }

        // Tell the user they guessed the magic number
        Console.WriteLine("You guessed the magic number!");
        Console.WriteLine($"It took you {guesses} guesses");
    }
}