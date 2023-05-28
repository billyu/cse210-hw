/******************************************************************************
    Class Name:
        Scripture
    Responsibility:
        This class will represent a scripture, including the reference and 
        the words of the scripture.
    Attributes:
        _reference: Reference
        _words: List<Word>
    Behavior:
        HideWords(n: int): void - hides n random words in the scripture
        ShowAllWords(): void - shows all words in the scripture
        IsFullyHidden(): bool - returns true if all words are hidden, false otherwise
        ToText(): String - returns a formatted string with the reference and 
                    the words of the scripture.
    Constructors:
        Scripture(reference: Reference, text: string) - creates a new scripture 
                    with the given reference and text. The text will be split 
                    into words and stored in the _words array.
*/

using System;
using System.Collections.Generic;

public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _words = new List<Word>();

        // split the text into words and store them in the _words array
        string[] words = text.Split(' ');
        foreach (string word in words) {
            _words.Add(new Word(word));
        }
    }

    public void HideWords(int n) {
        Random random = new Random();

        // Create a list of all visible words
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words) {
            if (word.IsVisible()) {
                visibleWords.Add(word);
            }
        }

        // If there are fewer visible words than n, hide all visible words
        if (visibleWords.Count < n) {
            n = visibleWords.Count;
        }

        // Hide n random words from the list of visible words
        for (int i = 0; i < n; i++) {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public void ShowAllWords() {
        foreach (Word word in _words) {
            word.Show();
        }
    }

    public bool IsFullyHidden() {
        // return true if all words are hidden, false otherwise
        foreach (Word word in _words) {
            if (word.IsVisible()) {
                return false;
            }
        }
        return true;
    }

    public string ToText() {
        // return a formatted string with the reference and the words of the scripture
        string output = $"{_reference.ToText()}\n";
        foreach (Word word in _words) {
            output += $"{word.ToText()} ";
        }
        return output;
    }
}