using System;
public class Fraction
{
    static void Main(string[] args)

    {
        // Fraction.cs
    private int _top;
    private int _bottom;

    // Constructor 1: No parameters, default to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: One parameter (numerator), denominator defaults to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Two parameters (numerator and denominator)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int value)
    {
        _top = value;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int value)
    {
        _bottom = value;
    }

    // Method to return the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
}

// Program.cs
class Program
{
    static void Main()
    {
        // Using Constructor 1: 1/1
        Fraction frac1 = new Fraction();
        Console.WriteLine("Fraction 1:");
        DisplayFractionInfo(frac1);

        // Using Constructor 2: 5/1
        Fraction frac2 = new Fraction(5);
        Console.WriteLine("\nFraction 2:");
        DisplayFractionInfo(frac2);

        // Using Constructor 3: 3/4
        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine("\nFraction 3:");
        DisplayFractionInfo(frac3);

        // Using Constructor 3: 1/3
        Fraction frac4 = new Fraction(1, 3);
        Console.WriteLine("\nFraction 4:");
        DisplayFractionInfo(frac4);

        // Testing Setters and Getters
        frac4.SetTop(6);
        frac4.SetBottom(7);
        Console.WriteLine("\nModified Fraction 4:");
        Console.WriteLine($"New Top: {frac4.GetTop()}");
        Console.WriteLine($"New Bottom: {frac4.GetBottom()}");
        DisplayFractionInfo(frac4);
    }

    static void DisplayFractionInfo(Fraction frac)
    {
        Console.WriteLine($"Fraction String: {frac.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {frac.GetDecimalValue()}");
    }
}
