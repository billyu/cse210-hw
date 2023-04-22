using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the grade percentage
        Console.Write("What is your grade percentage? ");
        string gradePercentageString = Console.ReadLine();

        // Convert the grade percentage to an integer
        int gradePercentage = int.Parse(gradePercentageString);

        // Handle the case where the grade percentage is not between 0 and 100
        if (gradePercentage < 0 || gradePercentage > 100)
        {
            Console.WriteLine("Grade percentage must be between 0 and 100.");
            return;
        }

        // Determine the letter grade
        string letterGrade = "";
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Handle the the + and - grades, if the last digit >= 7, then +, if the last digit <= 3, then -
        if (gradePercentage % 10 >= 7)
        {
            // Handle the exception of A+ and F+
            if (letterGrade != "A" && letterGrade != "F")
            {
                letterGrade += "+";
            }
        }
        else if (gradePercentage % 10 <= 3)
        {
            // Handle the exception of F-
            if (letterGrade != "F")
            {
                letterGrade += "-";
            }
        }

        // Print the letter grade using string interpolatio
        Console.WriteLine($"Your letter grade is {letterGrade}.");

        // Congratulate the user scores above 70
        // Encourage the user to study more if the score is below 70
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed this class!");
        }
        else
        {
            Console.WriteLine("Please study more.");
        }
    }
}