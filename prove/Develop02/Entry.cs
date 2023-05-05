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
    public DateTime _entryDate { get; set;}
    public string _entryText { get; set;}
    public string _entryPrompt { get; set;}

    // Define constructor here.
    public Entry() {
        _entryDate = DateTime.Now;
        _entryText = "";
        _entryPrompt = "";
    }
    public Entry(DateTime entryDate, string entryText, string entryPrompt) {
        _entryDate = entryDate;
        _entryText = entryText;
        _entryPrompt = entryPrompt;
    }

    // Display journal entry
    public void DisplayEntry() {
        Console.WriteLine($"{_entryDate} - {_entryPrompt}");
        Console.WriteLine(_entryText);
    }

    // Convert the object to JSON
    public string ToJson() {
        return JsonSerializer.Serialize(this);
    }
}