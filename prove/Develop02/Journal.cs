/******************************************************************************
    Class Name:
        Journal
    Responsibility:
        Represent a single journal. Store, manage, and display its contents.
    State:
        _journalName: string
        _entries: List<Entry>
    Behavior:
        Journal(journalName)
        AddEntry(entryDate, entryText, entryPrompt)
        DisplayJournal()
        ToJson()
        SaveJournal(string fileName)
        LoadJournal(string fileName)
        GeneratePrompt()
*/

// Import namespaces
using System.Collections.Generic;
using System.Text.Json;

public class Journal {
    // Define member variables here.
    public string JournalName { get; set;}
    public List<Entry> Entries { get; set;}

    // Define constructor here.
    public Journal() {
        JournalName = "";
        Entries = new List<Entry>();
    }
    public Journal(string journalName) {
        JournalName = journalName;
        Entries = new List<Entry>();
    }

    // Add a new entry to the journal
    public void AddEntry(DateTime entryDate, string entryText, string entryPrompt) {
        Entry newEntry = new Entry(entryDate, entryText, entryPrompt);
        Entries.Add(newEntry);
    }

    // Display all entries in the journal
    public void DisplayJournal() {
        Console.WriteLine($"Journal: {JournalName}");
        foreach (Entry entry in Entries) {
            entry.DisplayEntry();
        }
    }

    // Convert the object to JSON
    public string ToJson() {
        return JsonSerializer.Serialize(this);
    }

    // Convert the object to JSON and save it to a file
    public void SaveJournal(string fileName) {
        string json = ToJson();
        File.WriteAllText(fileName, json);
    }

    // Load a journal from a file
    public static Journal LoadJournal(string fileName) {
        string json = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<Journal>(json);
    }

    // Randomly generate a prompt for the journal entry
    // Possible prompts:
    // 1. Who was the most interesting person I interacted with today?
    // 2. What was the most interesting thing I learned today?
    // 3. What was the best part of my day?
    // 4. What was the worst part of my day?
    // 5. How did I see the hand of the Lord in my life today?
    // 6. What am I most grateful for today?
    // 7. What was the strongest emotion I felt today?
    // 8. What was the most beautiful thing I saw today?
    // 9. If I had one thing I could do over today, what would it be?
    // 10. What is one thing I can do tomorrow to make it better than today?

    public string GeneratePrompt() {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the most interesting thing I learned today?",
            "What was the best part of my day?",
            "What was the worst part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What am I most grateful for today?",
            "What was the strongest emotion I felt today?",
            "What was the most beautiful thing I saw today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I can do tomorrow to make it better than today?"
        };
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}