using System;

class Program
{
    static void Main(string[] args)
    {
        // Take first number
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        // Take second number
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        // Take operator (+, -, *, /)
        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        double result;

        // Perform operation based on operator
        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}
