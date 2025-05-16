using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? ");
        string first = Console.Readline();

        Console.Write("what is your last name? ");
        string last = Console.Readline();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}
