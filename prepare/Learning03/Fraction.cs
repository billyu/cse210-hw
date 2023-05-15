/*
This is a class that represents a fraction.
Attributes:
    _top : int
    _bottom : int
Constructors:
    Fraction()
    Fraction(wholeNumber : int)
    Fraction(top : int, bottom : int)
Getters/Setters:
    GetTop() : int
    GetBottom() : int
    SetTop(top : int)
    SetBottom(bottom : int)
Methods:
    GetFractionString() : string
    GetDecimalValue() : double
*/

using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 0;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}