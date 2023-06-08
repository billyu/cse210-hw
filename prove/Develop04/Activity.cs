/******************************************************************************
    Class Name:
        Activity
    Responsibility:
        This class will represent the base class for all activities. It will
        contain the common attributes and behavior for all activities.
    Protected Attributes:
        _name: string
        _description: string
        _duration: int
    Protected Behavior:
        GetReadyPrompt(): void - displays a message to get ready for the activity
        CountDown(int seconds): void - counts down from the given number of seconds
        Spinner(int seconds): void - displays a spinner for the given number of seconds
    Public Behavior:
        DisplayWelcomeMessage(): void - displays a welcome message for the activity and asks for the duration
        DisplayCompleteMessage(): void - displays a message when the activity is finished
    Constructors:
        Activity(name: string, description: string) - creates a new activity with
                    the given name and description.
*/

using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void Spinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % 4;
        }
    }

    protected void GetReadyPrompt()
    {
        Console.WriteLine("Get ready...");
        Spinner(3);
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the " + _name + " Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayCompleteMessage()
    {
        Console.WriteLine("\nWell done!!");
        Spinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        Spinner(3);
    }
}