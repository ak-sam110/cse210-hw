using System.Collections.Generic;
   
class Program
{
    static void Main(string[] args)
    {
        list<int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a series of numbers (0 to stop):");

        do 
        {
            Console.Write("Enter number:");
            number=int.Parse(Console.ReadLine());
            if (number !=0)
            {
            number.Add(number);
            }
        } 
        while(number!=0);
            int sum = 0;
        foreach (int num in numbers)
        {
        sum+=num;
        }
            Console.WriteLine($"Sum:{sum}");
            double average = (double)sum / number.Count;
            Console.WriteLine($"Average:{average}");
            int max = numbers[0];
            foreach (int num in numbers)
        {
            if(num > max)
            {
            max=num;
            }
        }
            Console.WriteLine($"Maximum:{max}");
            int smallestPositive = int.MaxValue;
            foreach(int num in numbers)
        {
            if(num > 0 && num < smallestPositive)
            {
            smallestPositive=num;
            }
        }
            if(smallestPositive !=int.MaxValue)
        {
             Console.WriteLine($"smallest positive:{smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }
            number.Sort();
            Console.WriteLine("sorted list.");
            foreach(int num in numbers)
        {
           Console.WriteLine(num);
        }
    }
}