using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if number is even or odd
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is Even.");
        }
        else
        {
            Console.WriteLine($"{number} is Odd.");
        }
    }
}
