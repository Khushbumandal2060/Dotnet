using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter first number (a): ");
        int a = int.Parse(Console.ReadLine());

        
        Console.Write("Enter second number (b): ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nBefore swapping: a = {a}, b = {b}");

        // Swapping using a temporary variable
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}
