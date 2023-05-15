using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Verify that we can call each constructor and that we can retrieve and display 
        the different representations for a few different fractions. 
        Example:
            1
            5
            3/4
            1/3
        */

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        f1.SetTop(1);

        // Display the fractions as strings and decimal value for f1,f2,f3 and f4
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
   }
}