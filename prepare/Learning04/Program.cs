using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Assignment object
        // with student name as "Samuel Bennett", and the topic as "Multiplication"
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        // Print the summary of the assignment
        Console.WriteLine(assignment.GetSummary());

        // Create a new MathAssignment object
        // with student name as "Roberto Rodriguez", the topic as "Fractions",
        // the textbook section as "Section 7.3", and the problems as "Problems 8-19"
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");

        // Print the summary and home work list of the assignment
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Create a new WritingAssignment object
        // with student name as "Mary Waters", the topic as "European History",
        // and the title as "The Causes of World War II"
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        // Print the summary and writing information of the assignment
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}