using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal;

        // Dispaly the welcome message
        Console.WriteLine("Welcome to your journal!");

        // Ask the user if they want to load a journal or create a new one
        Console.Write("Do you want to load a journal? (y/n)");
        string loadChoice = Console.ReadLine();

        if (loadChoice == "y") {
            // Ask the user for the file name
            Console.Write("What is the name of the file?");
            string fileName = Console.ReadLine();

            // Load the journal from the file
            journal = Journal.LoadJournal(fileName);
        } else {
            // Create a new journal
            // Ask the user for the name of the journal
            Console.Write("What is the name of the journal?");
            string journalName = Console.ReadLine();
            journal = new Journal(journalName);
        }

        // Ask the user what they want to do, quit until they select 5
        while (true) {
            // Display the menu
            Console.WriteLine("Please select on of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            // Get the user's choice
            Console.Write("What would you like to do?");
            string choice = Console.ReadLine();

            // Perform the action
            if (choice == "1") {
                // Write
                // Default date is today
                DateTime entryDate = DateTime.Now;
                // Generate a random prompt
                string entryPrompt = journal.GeneratePrompt();
                // Ask the user for the text
                Console.WriteLine(entryPrompt);
                string entryText = Console.ReadLine();
                journal.AddEntry(entryDate, entryText, entryPrompt);
            } else if (choice == "2") {
                // Display
                journal.DisplayJournal();
            } else if (choice == "3") {
                // Load
                Console.Write("What is the name of the file?");
                string fileName = Console.ReadLine();
                journal = Journal.LoadJournal(fileName);
            } else if (choice == "4") {
                // Save
                Console.Write("What is the name of the file?");
                string fileName = Console.ReadLine();
                journal.SaveJournal(fileName);
            } else if (choice == "5") {
                // Quit
                break;
            } else {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}