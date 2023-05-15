/******************************************************************************
    Class Name:
        Entry
    Responsibility:
        Represent a single journal entry, store and display its contents.
    State:
        _entryDate: DateTime
        _entryText: string
        _entryPrompt: string
    Behavior:
        JournalEntry(entryDate, entryText, entryPrompt)
        DisplayEntry()
        ToJson()
*/

// Import namespaces
using System.Text.Json;

public class Entry {
    // Define member variables here.
    public DateTime EntryDate { get; set;}
    public string EntryText { get; set;}
    public string EntryPrompt { get; set;}

    // Define constructor here.
    public Entry() {
        EntryDate = DateTime.Now;
        EntryText = "";
        EntryPrompt = "";
    }
    public Entry(DateTime entryDate, string entryText, string entryPrompt) {
        EntryDate = entryDate;
        EntryText = entryText;
        EntryPrompt = entryPrompt;
    }

    // Display journal entry
    public void DisplayEntry() {
        Console.WriteLine($"{EntryDate} - {EntryPrompt}");
        Console.WriteLine(EntryText);
    }

    // Convert the object to JSON
    public string ToJson() {
        return JsonSerializer.Serialize(this);
    }
}