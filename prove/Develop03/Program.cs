/*
Program Specifications:
- Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
- Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
- Clear the console screen and display the complete scripture, including the reference and the text.
- Prompt the user to press the enter key or type quit.
- If the user types quit, the program should end.
- If the user presses the enter key (without typing quit), the program should hide a few random words in 
    the scripture, clear the console screen, and display the scripture again.
- The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
- When all words in the scripture are hidden, the program should end.
- When selecting the random words to hide, for the core requirements, you can select any word at random, even if 
    the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are 
    not already hidden.)
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture
        Reference reference = new Reference("2 Nephi", 31, 3);
        Scripture scripture = new Scripture(reference, "For my soul delighteth in plainness; for after this manner doth the Lord God work among the children of men. For the Lord God giveth light unto the understanding; for he speaketh unto men according to their language, unto their understanding.");

        // Prompt the user with the full scripture
        Console.Clear();
        Console.WriteLine(scripture.ToText());
        Console.WriteLine();
        Console.WriteLine("Press enter to hide a few words, type start to restart again, or quit to exit.");

        String input = Console.ReadLine();

        while (input != "quit" && !scripture.IsFullyHidden())
        {
            // If user types start, reset the scripture (show all words)
            if (input == "start")
            {
                scripture.ShowAllWords();
            }
            else
            {
                // Otherwise, hide a few words
                scripture.HideWords(3);
            }

            // Prompt the user with the scripture
            Console.Clear();
            Console.WriteLine(scripture.ToText());
            Console.WriteLine();
            Console.WriteLine("Press enter to hide a few words, type start to restart again, or quit to exit.");

            input = Console.ReadLine();
        }

    }
}