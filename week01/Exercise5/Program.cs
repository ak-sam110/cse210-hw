using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        DisplayResult(userName, squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int SquaredNumber)
    {
        Console.WriteLine($"{name},the square of your favorite number is {SquaredNumber}.");
    }
}