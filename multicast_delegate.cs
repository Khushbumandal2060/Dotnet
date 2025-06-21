using System;

// Declare delegate
delegate void Operation(int a, int b);

class Calculator
{
    // Method 1
    public void Add(int x, int y)
    {
        Console.WriteLine($"Addition: {x + y}");
    }

    // Method 2
    public void Subtract(int x, int y)
    {
        Console.WriteLine($"Subtraction: {x - y}");
    }

    // Method 3
    public void Multiply(int x, int y)
    {
        Console.WriteLine($"Multiplication: {x * y}");
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Create multicast delegate instance
        Operation op;

        // Point delegate to Add method
        op = calc.Add;

        // Add more methods to the delegate
        op += calc.Subtract;
        op += calc.Multiply;

        // Invoke delegate (calls all 3 methods)
        Console.WriteLine("Multicast Delegate Output:");
        op(100, 50);
    }
}
