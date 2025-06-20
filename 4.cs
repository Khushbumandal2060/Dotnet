using System;

class Program
{
    static void Main(string[] args)
    {
        // Input principal
        Console.Write("Enter Principal amount: ");
        double principal = double.Parse(Console.ReadLine());

        // Input time
        Console.Write("Enter Time (in years): ");
        double time = double.Parse(Console.ReadLine());

        // Input rate
        Console.Write("Enter Rate of interest (%): ");
        double rate = double.Parse(Console.ReadLine());

        // Calculate simple interest
        double simpleInterest = (principal * time * rate) / 100;

        // Display result
        Console.WriteLine($"Simple Interest = {simpleInterest:F2}");
    }
}
