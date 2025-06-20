using System;

class Program
{
    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your address: ");
        string address = Console.ReadLine();

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        // Output on separate lines
        Console.WriteLine("\n--- Your Information ---");
        Console.WriteLine("Name   : " + name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Email  : " + email);
    }
}
