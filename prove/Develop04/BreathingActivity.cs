/******************************************************************************
    Class Name:
        BreathingActivity
    Responsibility:
        This class is a subclass of Activity and represents the breathing activity.
    Behavior:
        Start(): void - starts the activity
*/

using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing",
        "This activity will help you relax by walking your through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.")
    {
    }

    public void Start()
    {
        Console.Clear();
        DisplayWelcomeMessage();

        Console.Clear();
        GetReadyPrompt();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in...");
            CountDown(4);
            Console.Write("\nNow breathe out...");
            CountDown(6);
            Console.WriteLine();
        }

        DisplayCompleteMessage();
    }
}