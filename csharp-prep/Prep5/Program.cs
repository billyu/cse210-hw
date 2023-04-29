using System;

class Program
{
    // Task: Write a C# program that has several simple functions:

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    // PromptUserName - Asks for and returns the user's name (as a string)
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    // DisplayResult - Accepts the user's name and the squared number and displays them.

    // In the Main method, call each of the functions in the order listed above.
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        number = SquareNumber(number);
        DisplayResult(name, number);
    }

    // Display Welcome function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Prompt User Name function
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    // Prompt User Number function
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Square Number function
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Display Result function
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"Hello {name}, your favorite number squared is {number}");
    }
}