using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your first name?");
        string firstname = Console.Readline();
        Console.WriteLine("what is your last name?");
        string lastname = Console.Readline();
        Console.WriteLine($"Your name is "{lastname}" "{firstname}" "{lastname}" ");
    }
}
