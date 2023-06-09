using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        string choice = "";

        do
        {
            // Display the menu
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. List Activities History");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");

            // Get the user's choice
            choice = Console.ReadLine();

            // Start the appropriate activity
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    activities.Add(breathingActivity);
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Start();
                    activities.Add(reflectingActivity);
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    activities.Add(listingActivity);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Activities History");
                    Console.WriteLine("------------------");
                    foreach (Activity activity in activities)
                    {
                        Console.WriteLine($"{activity.GetName()} - {activity.GetDuration()} seconds");
                    }
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("That was not a valid choice.");
                    break;
            }
        }
        while (choice != "5");
    }
}