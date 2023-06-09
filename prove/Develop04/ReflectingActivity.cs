/******************************************************************************
    Class Name:
        ReflectingActivity
    Responsibility:
        This class is a subclass of Activity and represents the reflecting activity.
    Behavior:
        Start(): void - starts the activity
*/

using System;

public class ReflectingActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();

    public ReflectingActivity() : base("Reflecting",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.")
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
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDown(5);

        // Shuffle the questions
        ShuffleQuestions();
        Console.Clear();

        // Set the end time 
        DateTime end = DateTime.Now.AddSeconds(_duration);
        int i = 0;

        // Loop through the questions
        while (DateTime.Now < end)
        {
            Console.Write($"> {_questions[i]} ");
            Spinner(10);
            Console.WriteLine();

            // Next question, if we've reached the end of the array, start over
            i++;
            i = (i >= _questions.Length) ? 0 : i;
        }

        DisplayCompleteMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Length);

        return _prompts[index];
    }

    private void ShuffleQuestions()
    {
        for (int i = _questions.Length - 1; i > 0; i--)
        {
            int randomIndex = _random.Next(i + 1);

            // Swap
            string temp = _questions[i];
            _questions[i] = _questions[randomIndex];
            _questions[randomIndex] = temp;
        }
    }
}