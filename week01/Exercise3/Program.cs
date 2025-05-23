using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = -1;

        do
        {
            {
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }


            if (magicNumber > guess)
            {
                Console.Write("what is your guess?");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("HIGHER");
                }

                else if (magicNumber < guess)
                {
                    Console.WriteLine("LOWER");
                }
                else
                {
                    Console.WriteLine("AWESOME! YOU GUESSED RIGHT");
                }

            }
        }
            while
            (guess != magicNumber);

    }
}