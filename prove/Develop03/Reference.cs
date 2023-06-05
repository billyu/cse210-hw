/******************************************************************************
    Class Name:
        Reference
    Responsibility:
        This class will encapsulate information related to the reference of 
        the scripture. It will have the book name, chapter, and verse(s).
    Attributes:
        _bookName: string
        _chapter: int
        _verseStart: int
        _verseEnd: Optional[int]
    Behavior:
        ToText(): String - Returns a formatted string with the reference details, 
                    like "John 3:16" or "Proverbs 3:5-6".
    Constructors:
        Reference(bookName: String, chapter: int, verse: int) - for single verse
        Reference(bookName: String, chapter: int, verseStart: int, verseEnd: int) - for verse range
*/

using System;

public class Reference
{
    private string _bookName;
    private int _chapter;
    private int _verseStart;
    private int? _verseEnd;

    public Reference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verseStart = verse;
    }

    public Reference(string bookName, int chapter, int verseStart, int verseEnd)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string ToText()
    {
        if (_verseEnd == null)
        {
            return $"{_bookName} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_bookName} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}