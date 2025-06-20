using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user to enter their name
        Console.Write("Enter your name: ");
        string yourName = Console.ReadLine();

        // Print the welcome message
        Console.WriteLine("Welcome " + yourName + ", to dotnet technology.");
    }
}
