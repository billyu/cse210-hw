/*
This is a base class that represents a Assignment.
Attributes:
    _studentName : string
    _topic : string
Constructors:
    Assignment()
    Assignment(studentName : string, topic : string)
Methods:
    GetSummary() : string
*/

using System;

public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "Unknown";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}