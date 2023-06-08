/*
This is a derived class that represents a Math Assignment. It is a child class of Assignment.
Attributes:
    _textbookSection : string
    _problems : string
Constructors:
    MathAssignment()
    MathAssignment(studentName : string, topic : string, textbookSection : string, problems : string)
Methods:
    GetHomeworkList() : string
*/

using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment()
    {
        _textbookSection = "Unknown";
        _problems = "Unknown";
    }

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }
}