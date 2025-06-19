
// Program.cs
using System;

    class Program
    {
    static void Main(string[] args)
    {
        // Base class test
        Assignment baseAssignment = new Assignment("Samuel Akinbola", "Software Architecture");
        Console.WriteLine(baseAssignment.GetSummary());

        Console.WriteLine(); // spacing

        // MathAssignment test
        MathAssignment mathAssignment = new MathAssignment("Grace Akinbola", "Algebra", "7.3", "12-15, 18-21");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine(); //spacing

        //Writing Assignment
        WritingAssignment writingAssignment = new WritingAssignment("John Doe", "world History", "Causes of World war 1");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        }
    }

