/*
This is a derived class that represents a Writing Assignment. It is a child class of Assignment.
Attributes:
    _title : string
Constructors:
    WritingAssignment()
    WritingAssignment(studentName : string, topic : string, title : string)
Methods:
    GetWritingInformation() : string
*/

using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment()
    {
        _title = "Unknown";
    }

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return _title + " by " + _studentName;
    }
}