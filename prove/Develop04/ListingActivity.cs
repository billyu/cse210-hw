/******************************************************************************
    Class Name:
        ListingActivity
    Responsibility:
        This class is a subclass of Activity and represents the listing activity.
    Behavior:
        Start(): void - starts the activity
*/

using System;

public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity() : base("Listing",
        "This activity will help you reflect on the good things in your life " +
        "by having you list as many things as you can in a certain area.")
    {
    }

    public void Start()
    {
        Console.Clear();
        DisplayWelcomeMessage();

        Console.Clear();
        GetReadyPrompt();

        // Generate a prompt
        string prompt = GetRandomPrompt();

        // Display the prompt
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\n --- {prompt} ---");
        Console.Write("You may begin in: ");
        CountDown(5);

        // Set the end time 
        DateTime end = DateTime.Now.AddSeconds(_duration);

        // Loop as many prompts as time allows, and store the responses in a list

        List<string> responses = new List<string>();

        while (DateTime.Now < end)
        {
            Console.Write($"> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        // Display the number of responses
        Console.WriteLine($"\nYou listed {responses.Count} items.");

        DisplayCompleteMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Length);

        return _prompts[index];
    }
}